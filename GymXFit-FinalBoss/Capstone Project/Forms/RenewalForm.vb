Imports Org.BouncyCastle.Asn1.Cmp
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports TheArtOfDev.HtmlRenderer.Adapters
Public Class RenewalForm
    Private _rfid As String
    Private con As New MySqlConnection("server=localhost;user id=root;password=;database=gymxfit_database")

    Public Sub New(rfid As String)
        InitializeComponent()
        _rfid = rfid
    End Sub

    Private Sub RenewalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load member info
        LoadMemberInfo()
        LoadServices()
        txttransno.Text = GenerateTransactionNumber()
        txtdate.Text = Date.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub LoadMemberInfo()
        Try
            If con.State = ConnectionState.Closed Then con.Open()

            Dim query As String = "SELECT m.first_name, m.middle_name, m.last_name, m.status, m.picture, " &
                                 "p.services, p.nextdue " &
                                 "FROM tblmembers m " &
                                 "LEFT JOIN tblpayment p ON m.rfid = p.rfid " &
                                 "WHERE m.rfid = @rfid " &
                                 "ORDER BY p.paymentdate DESC LIMIT 1"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@rfid", _rfid)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    ' Display member info
                    txtrfid.Text = _rfid
                    lblfullname.Text = $"{dr("first_name")} {dr("middle_name")} {dr("last_name")}".Trim()
                    txtstatus.Text = dr("status").ToString()
                    cmbservices.Text = dr("services").ToString()

                    If Not IsDBNull(dr("nextdue")) Then
                        txtnextdue.Text = Convert.ToDateTime(dr("nextdue")).ToString("yyyy-MM-dd")
                    Else
                        txtnextdue.Text = "Not Available"
                    End If

                    ' Display picture if available
                    If Not IsDBNull(dr("picture")) Then
                        Dim imgBytes As Byte() = DirectCast(dr("picture"), Byte())
                        Using ms As New MemoryStream(imgBytes)
                            pcpicture.Image = Image.FromStream(ms)
                        End Using
                    Else
                        pcpicture.Image = My.Resources.gymnast_1163072
                    End If
                Else
                    MessageBox.Show("Member not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading member info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub LoadServices()
        Try
            If con.State = ConnectionState.Closed Then con.Open()

            Dim query As String = "SELECT services, description, amount, type FROM tblmaintenance"
            Dim cmd As New MySqlCommand(query, con)

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                cmbservices.Items.Clear()

                While dr.Read()
                    cmbservices.Items.Add(dr("services").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub cmbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServices.SelectedIndexChanged
        Try
            If con.State = ConnectionState.Closed Then con.Open()

            Dim query As String = "SELECT description, amount, type FROM tblmaintenance WHERE services = @service"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@service", cmbServices.SelectedItem.ToString())

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    txtdesc.Text = dr("description").ToString()
                    txtamount.Text = Convert.ToDecimal(dr("amount")).ToString("N2")

                    ' Set duration label based on service type
                    Dim serviceType As String = dr("type").ToString().ToUpper()
                    Select Case serviceType
                        Case "MONTHLY"
                            lblDuration.Text = "No. of Months:"
                        Case "DAILY"
                            lblDuration.Text = "No. of Days:"
                        Case "YEARLY"
                            lblDuration.Text = "No. of Years:"
                    End Select
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading service details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        CalculateTotal()
    End Sub

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtnumberofmonth.TextChanged
        CalculateTotal()
        CalculateVisits()

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
        Catch ex As Exception
            MessageBox.Show("Error calculating next due date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CalculateTotal()
        Try
            If String.IsNullOrEmpty(txtamount.Text) OrElse String.IsNullOrEmpty(txtnumberofmonth.Text) Then
                txttotal.Text = "0.00"
                Return
            End If

            Dim amount As Decimal = Convert.ToDecimal(txtamount.Text)
            Dim duration As Integer = Convert.ToInt32(txtnumberofmonth.Text)

            txttotal.Text = (amount * duration).ToString("N2")
        Catch ex As Exception
            txttotal.Text = "0.00"
        End Try
    End Sub

    Private Sub CalculateVisits()
        Try
            If String.IsNullOrEmpty(txtnumberofmonth.Text) Then
                txtVisits.Text = "0"
                Return
            End If

            Dim duration As Integer = Convert.ToInt32(txtnumberofmonth.Text)
            Dim serviceType As String = lblDuration.Text
            Dim visits As Integer = 1

            ' Calculate visits based on service type
            Select Case serviceType
                Case "No. of Months:"
                    visits = duration * 30  ' 30 visits per month
                Case "No. of Days:"
                    visits = duration * 1      ' 1 visit per day
                Case "No. of Years:"
                    visits = duration * 365 ' 365 visits per year
                Case Else
                    visits = duration * 30  ' Default: 30 visits per month
            End Select

            txtVisits.Text = visits.ToString()
        Catch ex As Exception
            txtVisits.Text = "0"
        End Try
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click
        If String.IsNullOrEmpty(cmbservices.Text) OrElse String.IsNullOrEmpty(txtnumberofmonth.Text) OrElse
           String.IsNullOrEmpty(txttotal.Text) OrElse String.IsNullOrEmpty(txtVisits.Text) Then
            MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If con.State = ConnectionState.Closed Then con.Open()

            ' Generate transaction number
            Dim transactionNo As String = GenerateTransactionNumber()

            ' Get current date and calculate next due date
            Dim currentDate As DateTime = DateTime.Now
            Dim nextDueDate As DateTime = CalculateNextDueDate(currentDate, Convert.ToInt32(txtnumberofmonth.Text), lblDuration.Text)

            ' Begin transaction
            Dim transaction As MySqlTransaction = con.BeginTransaction()

            Try
                ' 1. Insert payment record
                Dim paymentQuery As String = "INSERT INTO tblpayment (rfid, transactionno, name, services, description, " &
                                            "total, paymentdate, nextdue, paymenttype, max_visits, remaining_visits) " &
                                            "VALUES (@rfid, @transactionNo, @name, @services, @description, " &
                                            "@total, @paymentDate, @nextDue, @paymentType, @maxVisits, @remainingVisits)"

                Using cmd As New MySqlCommand(paymentQuery, con, transaction)
                    cmd.Parameters.AddWithValue("@rfid", _rfid)
                    cmd.Parameters.AddWithValue("@transactionNo", txttransno.Text)
                    cmd.Parameters.AddWithValue("@name", lblfullname.Text)
                    cmd.Parameters.AddWithValue("@services", cmbServices.Text)
                    cmd.Parameters.AddWithValue("@description", txtdesc.Text)
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txttotal.Text))
                    cmd.Parameters.AddWithValue("@paymentDate", currentDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@nextDue", nextDueDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@paymentType", "CASH") ' Default to cash
                    cmd.Parameters.AddWithValue("@maxVisits", Convert.ToInt32(txtVisits.Text))
                    cmd.Parameters.AddWithValue("@remainingVisits", Convert.ToInt32(txtVisits.Text))

                    cmd.ExecuteNonQuery()
                End Using

                ' 2. Update member status and remaining visits
                Dim updateQuery As String = "UPDATE tblmembers SET status = 'ACTIVE', remaining_visits = @remainingVisits " &
                                            "WHERE rfid = @rfid"

                Using cmd As New MySqlCommand(updateQuery, con, transaction)
                    cmd.Parameters.AddWithValue("@remainingVisits", Convert.ToInt32(txtVisits.Text))
                    cmd.Parameters.AddWithValue("@rfid", _rfid)

                    cmd.ExecuteNonQuery()
                End Using

                ' Commit transaction
                transaction.Commit()

                MessageBox.Show("Membership renewed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()

            Catch ex As Exception
                ' Rollback transaction on error
                transaction.Rollback()
                Throw ex
            End Try

        Catch ex As Exception
            MessageBox.Show("Error renewing membership: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Function GenerateTransactionNumber() As String
        ' Generate a random 10-digit transaction number
        Dim random As New Random()
        Return random.Next(1000000000, 1999999999).ToString()
    End Function

    Private Function CalculateNextDueDate(startDate As DateTime, duration As Integer, durationType As String) As DateTime
        Select Case durationType
            Case "No. of Months:"
                Return startDate.AddMonths(duration)
            Case "No. of Days:"
                Return startDate.AddDays(duration)
            Case "No. of Years:"
                Return startDate.AddYears(duration)
            Case Else
                Return startDate.AddMonths(duration) ' Default to months
        End Select
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtnextdue_TextChanged(sender As Object, e As EventArgs) Handles txtnextdue.TextChanged

    End Sub
End Class