Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports TheArtOfDev.HtmlRenderer.Adapters

Public Class Add_Payment
    Public EditparentsForm As payment ' Reference to the parent form
    Private ReadOnly connectionString As String = "server=localhost;user id=root;password=;database=gymxfit_database"

    ' Constructor to accept the parent form reference
    Public Sub New(parent As payment)
        InitializeComponent()
        EditparentsForm = parent
    End Sub

    Dim arrimage() As Byte

    Private Sub Add_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtreferenceno.Clear()
        txtstatus.Clear()
        txtdate.Clear()
        LoadComboBox()
    End Sub

    ' Function to generate a 10-digit transaction number
    Private Function GenerateTransactionNumber() As String
        ' Use Random to generate a 10-digit number
        Dim random As New Random()
        Dim transactionNo As String = random.Next(1000000000, 1999999999).ToString()
        Return transactionNo
    End Function

    Private Sub CheckFields()
        ' Disable button by default
        btnpayment.Enabled = False

        ' Check each required field
        If String.IsNullOrWhiteSpace(txtrfid.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(txttransno.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(lblfullname.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(cmbservices.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(txtdesc.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(txttotal.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(txtdate.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(txtpayment.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(txtnextdue.Text) Then Exit Sub
        If String.IsNullOrWhiteSpace(cbmptype.Text) Then Exit Sub

        ' If payment type is not Cash, check reference number
        If cbmptype.Text.Trim().ToUpper() <> "CASH" AndAlso String.IsNullOrWhiteSpace(txtreferenceno.Text) Then Exit Sub

        ' If all fields are filled, enable the button
        btnpayment.Enabled = True
    End Sub

    Private Sub txtrfid_TextChanged(sender As Object, e As EventArgs) Handles txtrfid.TextChanged
        CheckFields()

        ' Ensure the RFID has at least 10 characters before proceeding
        If txtrfid.Text.Length < 10 Then Exit Sub

        ' Auto-select the text for quick scanning
        txtrfid.SelectionStart = 0
        txtrfid.SelectionLength = Len(txtrfid.Text)
        txtrfid.Focus()

        Try
            ' Generate and set the transaction number
            txttransno.Text = GenerateTransactionNumber()

            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' Define the query to retrieve member details
                Dim query As String = "SELECT picture, first_name, middle_name, last_name, status, member_since FROM tblmembers WHERE rfid = @rfid"

                Using command As New MySqlCommand(query, con)
                    command.Parameters.AddWithValue("@rfid", txtrfid.Text)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if the RFID exists in the database
                        If reader.Read() Then
                            ' Retrieve the full name
                            Dim firstName As String = reader("first_name").ToString()
                            Dim middleName As String = reader("middle_name").ToString()
                            Dim lastName As String = reader("last_name").ToString()
                            lblfullname.Text = $"{firstName} {middleName} {lastName}".Trim()

                            ' Retrieve the status
                            txtstatus.Text = reader("status").ToString()

                            ' Retrieve the date and format it
                            Dim memberDate As DateTime
                            If DateTime.TryParse(Date.Now.ToString("yyyy-MM-dd"), memberDate) Then
                                txtdate.Text = memberDate.ToString("yyyy-MM-dd") ' Format as "YYYY-MM-DD"
                            Else
                                txtdate.Text = Date.Now.ToString("yyyy-MM-dd") ' Set to current date if invalid
                            End If

                            ' Retrieve the profile picture (if stored as a byte array)
                            If Not IsDBNull(reader("picture")) Then
                                Dim imageBytes As Byte() = CType(reader("picture"), Byte())
                                Using ms As New IO.MemoryStream(imageBytes)
                                    pcpicture.Image = Image.FromStream(ms)
                                End Using
                            Else
                                ' Set a default image if no picture is available
                                pcpicture.Image = My.Resources.gymnast_1163072
                            End If
                        Else
                            ' Show message only if RFID is not found
                            MessageBox.Show("RFID is not valid. Please try again.", "Invalid RFID", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            ' Temporarily remove event handler to prevent infinite loop
                            RemoveHandler txtrfid.TextChanged, AddressOf txtrfid_TextChanged
                            txtrfid.Clear()
                            AddHandler txtrfid.TextChanged, AddressOf txtrfid_TextChanged

                            ' Clear fields
                            lblfullname.Text = ""
                            txtstatus.Clear()
                            txtdate.Clear()
                            txttransno.Clear()
                            pcpicture.Image = My.Resources.gymnast_1163072
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Show error message for debugging
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbservices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbservices.SelectedIndexChanged
        Try
            ' Prevent error when clearing combo box
            If cmbservices.SelectedItem Is Nothing Then
                txtdesc.Clear()
                txtamount.Clear()
                lblDuration.Text = "Duration"
                Exit Sub
            End If

            Using con As New MySqlConnection(connectionString)
                con.Open()

                Dim query As String = "SELECT description, amount, type FROM tblmaintenance WHERE services = @service"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@service", cmbservices.SelectedItem.ToString())

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtdesc.Text = reader("description").ToString()
                            txtamount.Text = Convert.ToDecimal(reader("amount")).ToString("N2")

                            ' Determine duration label based on type
                            Dim serviceType As String = reader("type").ToString().ToUpper()
                            If serviceType = "MONTHLY" Then
                                lblDuration.Text = "No. of Months:"
                            ElseIf serviceType = "DAILY" Then
                                lblDuration.Text = "No. of Days:"
                            ElseIf serviceType = "YEARLY" Then
                                lblDuration.Text = "No. of Years:"
                            End If
                        Else
                            txtdesc.Clear()
                            txtamount.Clear()
                            lblDuration.Text = "Duration"
                        End If
                    End Using
                End Using
            End Using

            ' Recalculate total if needed
            CalculateTotal()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Service Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadComboBox()
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Dim query As String = "SELECT services FROM tblmaintenance"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbservices.Items.Clear() ' Clear previous items

                        While reader.Read()
                            cmbservices.Items.Add(reader("services").ToString()) ' Add data to ComboBox
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateTotal()
        Dim amount As Decimal
        Dim numberOfMonths As Integer
        Dim total As Decimal

        ' Try to parse the amount and number of months, default to 0 if invalid
        If Decimal.TryParse(txtamount.Text, amount) AndAlso Integer.TryParse(txtnumberofmonth.Text, numberOfMonths) Then
            total = amount * numberOfMonths
        Else
            total = 0
        End If

        ' Format total with commas and two decimal places
        txttotal.Text = total.ToString("N2")
    End Sub

    Private Sub CalculateChange()
        Dim total As Decimal
        Dim payment As Decimal
        Dim change As Decimal

        ' Try to parse the total and payment, default to 0 if invalid
        If Decimal.TryParse(txttotal.Text, total) AndAlso Decimal.TryParse(txtpayment.Text, payment) Then
            change = payment - total
        Else
            change = 0
        End If

        ' Format values with commas and two decimal places
        txtchange.Text = change.ToString("N2")
        txttotal.Text = total.ToString("N2")
        txtpayment.Text = payment.ToString("N2")

        ' Validate payment amount
        If payment < total Then
            btnpayment.Enabled = False ' Disable the button if payment is less than total
        Else
            btnpayment.Enabled = True ' Enable the button if payment is greater than or equal to total
        End If
    End Sub

    Private Sub txtpayment_TextChanged(sender As Object, e As EventArgs) Handles txtpayment.TextChanged
        CalculateChange()
    End Sub

    Private Sub cbmptype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmptype.SelectedIndexChanged
        If cbmptype.SelectedItem Is Nothing Then
            Exit Sub
        End If

        If cbmptype.SelectedItem.ToString() = "CASH" Then
            txtreferenceno.ReadOnly = True
            txtreferenceno.Clear()
        ElseIf cbmptype.SelectedItem.ToString() = "G-CASH" Then
            txtreferenceno.ReadOnly = False
        End If

        CheckFields()
    End Sub

    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs) Handles txtdate.TextChanged
        ' Left empty as in original code
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        ClearContents()
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Create a list to store empty fields
        Dim emptyFields As New List(Of String)

        ' Check each required field
        If String.IsNullOrWhiteSpace(txtrfid.Text) Then emptyFields.Add("RFID")
        If String.IsNullOrWhiteSpace(txttransno.Text) Then emptyFields.Add("Transaction Number")
        If String.IsNullOrWhiteSpace(lblfullname.Text) Then emptyFields.Add("Full Name")
        If String.IsNullOrWhiteSpace(cmbservices.Text) Then emptyFields.Add("Services")
        If String.IsNullOrWhiteSpace(txtdesc.Text) Then emptyFields.Add("Description")
        If String.IsNullOrWhiteSpace(txttotal.Text) Then emptyFields.Add("Total")
        If String.IsNullOrWhiteSpace(txtdate.Text) Then emptyFields.Add("Payment Date")
        If String.IsNullOrWhiteSpace(txtnextdue.Text) Then emptyFields.Add("Next Due Date")
        If String.IsNullOrWhiteSpace(cbmptype.Text) Then emptyFields.Add("Payment Type")

        ' Check reference number only if payment type is not Cash
        If cbmptype.Text.Trim().ToUpper() <> "CASH" Then
            If String.IsNullOrWhiteSpace(txtreferenceno.Text) Then
                emptyFields.Add("Reference Number")
            End If
        End If

        ' If there are empty fields, show error message
        If emptyFields.Count > 0 Then
            MessageBox.Show("Please fill all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function ImageToByteArray(ByVal img As Image) As Byte()
        If img Is Nothing Then
            Return Nothing
        End If
        Using ms As New System.IO.MemoryStream()
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) ' Save as JPEG or PNG
            Return ms.ToArray()
        End Using
    End Function


    Private Sub btnpayment_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        ' Validate inputs
        If Not ValidateInputs() Then
            Return
        End If

        Try
            ' Open database connection
            openConn()

            Dim currentStatus As String = ""
            Dim latestNextDue As Date = DateTime.Now
            Dim durationToAdd As Integer = Integer.Parse(txtnumberofmonth.Text)

            ' Get current status from tblmembers
            Dim queryStatus As String = "SELECT status FROM tblmembers WHERE rfid = @rfid"
            Using cmd As New MySqlCommand(queryStatus, con)
                cmd.Parameters.AddWithValue("@rfid", txtrfid.Text.Trim())
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    currentStatus = reader("status").ToString()
                End If
                reader.Close()
            End Using

            ' Get latest next_due from tblpayment for the given RFID
            Dim queryNextDue As String = "SELECT nextdue FROM tblpayment WHERE rfid = @rfid ORDER BY paymentdate DESC LIMIT 1"
            Using cmd As New MySqlCommand(queryNextDue, con)
                cmd.Parameters.AddWithValue("@rfid", txtrfid.Text.Trim())
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() AndAlso Not IsDBNull(reader("nextdue")) Then
                    latestNextDue = Convert.ToDateTime(reader("nextdue"))
                End If
                reader.Close()
            End Using

            ' Calculate new next_due date
            Dim newNextDue As Date
            If currentStatus = "ACTIVE" Then
                newNextDue = latestNextDue.AddMonths(durationToAdd) ' Extend existing membership
            Else
                newNextDue = DateTime.Now.AddMonths(durationToAdd) ' Start fresh
            End If

            ' Calculate max visits based on membership duration
            Dim maxVisits As Integer = 0

            ' Determine service type and calculate visits
            Dim serviceType As String = lblDuration.Text

            Select Case serviceType
                Case "No. of Months:"
                    maxVisits = durationToAdd * 30  ' 30 visits per month
                Case "No. of Days:"
                    maxVisits = durationToAdd       ' 1 visit per day
                Case "No. of Years:"
                    maxVisits = durationToAdd * 365 ' 365 visits per year
                Case Else
                    maxVisits = durationToAdd * 30  ' Default: 30 visits per month
            End Select

            ' Insert payment record
            Dim sql As String = "INSERT INTO tblpayment (rfid, transactionno, name, services, description, total, paymentdate, nextdue, paymenttype, referenceno, picture, max_visits, remaining_visits) 
                      VALUES (@rfid, @transacno, @name, @services, @description, @total, @paymentdate, @next_due, @paymenttype, @referenceno, @picture, @max_visits, @remaining_visits)"
            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@rfid", txtrfid.Text.Trim())
                cmd.Parameters.AddWithValue("@transacno", txttransno.Text.Trim())
                cmd.Parameters.AddWithValue("@name", lblfullname.Text.Trim())
                cmd.Parameters.AddWithValue("@services", cmbservices.Text.Trim())
                cmd.Parameters.AddWithValue("@description", txtdesc.Text.Trim())
                cmd.Parameters.AddWithValue("@total", Decimal.Parse(txttotal.Text))
                cmd.Parameters.AddWithValue("@paymentdate", DateTime.Now.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@next_due", newNextDue.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@paymenttype", cbmptype.Text.Trim())
                cmd.Parameters.AddWithValue("@referenceno", If(String.IsNullOrWhiteSpace(txtreferenceno.Text), DBNull.Value, txtreferenceno.Text.Trim()))
                cmd.Parameters.AddWithValue("@max_visits", maxVisits)
                cmd.Parameters.AddWithValue("@remaining_visits", maxVisits)

                ' Save the image if provided
                If pcpicture.Image IsNot Nothing Then
                    Using msImage As New IO.MemoryStream()
                        Using bmpImage As New Bitmap(pcpicture.Image)
                            bmpImage.Save(msImage, System.Drawing.Imaging.ImageFormat.Jpeg)
                        End Using
                        cmd.Parameters.AddWithValue("@picture", msImage.ToArray())
                    End Using
                Else
                    cmd.Parameters.AddWithValue("@picture", DBNull.Value)
                End If

                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then
                    ' Update member status and remaining visits in tblmembers
                    Dim updateSql As String = "UPDATE tblmembers SET status = 'ACTIVE', remaining_visits = @remaining_visits WHERE rfid = @rfid"
                    Using updateCmd As New MySqlCommand(updateSql, con)
                        updateCmd.Parameters.AddWithValue("@rfid", txtrfid.Text.Trim())
                        updateCmd.Parameters.AddWithValue("@remaining_visits", maxVisits)
                        updateCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Payment Successfully Processed!" & vbCrLf & "Member has " & maxVisits & " sessions available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    EditparentsForm.RefreshGrid()
                    ClearContents()
                Else
                    MessageBox.Show("Something went wrong. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As FormatException
            MessageBox.Show("Invalid data format. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub





    Private Sub ClearContents()
        txtrfid.Clear()
        txttransno.Clear()
        lblfullname.Text = ""
        lblDuration.Text = ""
        cbmptype.SelectedIndex = -1
        cmbservices.SelectedIndex = -1
        txtdesc.Clear()
        txttotal.Text = "00.00"
        txtdate.Clear()
        txtnextdue.Clear()
        txtreferenceno.Clear()
        txtamount.Clear()
        txtpayment.Text = "00.00"
        txtchange.Text = "00.00"
        txtstatus.Clear()
        lblDuration.Text = "Duration:" ' Reset label to default
        txtrfid.Focus()
        txtnumberofmonth.Clear()
        pcpicture.Image = My.Resources.gymnast_1163072
    End Sub



    Private Sub txtnextdue_TextChanged(sender As Object, e As EventArgs) Handles txtnextdue.TextChanged

    End Sub

    Private Sub lblfullname_Click(sender As Object, e As EventArgs) Handles lblfullname.Click

    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtnumberofmonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumberofmonth.KeyPress
        ' Allow only digits and control keys (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the keypress event
            Return
        End If

        ' If the user types a number, validate the length and value
        If Char.IsDigit(e.KeyChar) Then
            Dim currentText As String = txtnumberofmonth.Text & e.KeyChar
            If currentText.Length > 2 OrElse (currentText.Length = 2 AndAlso Convert.ToInt32(currentText) > 12) Then
                e.Handled = True ' Cancel the keypress event if the number is more than 12 or has more than 2 digits
            End If
        End If
    End Sub


    Private Sub txtpayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the keypress event
        End If
    End Sub

    Private Sub BunifuGroupBox2_Enter(sender As Object, e As EventArgs) Handles BunifuGroupBox2.Enter

    End Sub

    Private Sub txtnumberofmonth_TextChanged(sender As Object, e As EventArgs) Handles txtnumberofmonth.TextChanged
        CalculateTotal()
        Try
            If String.IsNullOrWhiteSpace(txtnumberofmonth.Text) OrElse Not IsNumeric(txtnumberofmonth.Text) Then
                txtnextdue.Clear()
                Return
            End If

            ' Parse inputs
            Dim startDate As Date = Date.Parse(txtdate.Text)
            Dim duration As Integer = Integer.Parse(txtnumberofmonth.Text)

            ' Validate duration
            If duration <= 0 Then
                MessageBox.Show("Duration must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtnextdue.Clear()
                Return
            End If

            Dim nextDueDate As Date
            Dim serviceType As String = lblDuration.Text

            ' Calculate next due date based on service type
            If serviceType = "No. of Months:" Then
                nextDueDate = startDate.AddDays(30 * duration) ' Monthly: 30 days per month
            ElseIf serviceType = "No. of Days:" Then
                nextDueDate = startDate.AddDays(duration) ' Daily: Just add the days
            ElseIf serviceType = "No. of Years:" Then
                nextDueDate = startDate.AddMonths(12 * duration) ' Yearly: 12 months per year
            End If

            txtnextdue.Text = nextDueDate.ToString("yyyy-MM-dd") ' Format the date as YYYY-MM-DD
            CheckFields()
        Catch ex As Exception
            MessageBox.Show("Error calculating next due date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub BunifuGroupBox1_Enter(sender As Object, e As EventArgs) Handles BunifuGroupBox1.Enter

    End Sub
End Class