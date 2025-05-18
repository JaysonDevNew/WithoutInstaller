Imports System.IO
Imports TheArtOfDev.HtmlRenderer.Adapters
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class Member_Edit_Form
    Dim arrimage() As Byte
    Private originalValues As New Dictionary(Of String, String)


    Private origImage As Image
    Private parentsForm As membership ' Private to enforce encapsulation

    ' Constructor to accept the parent form
    Public Sub New(parent As membership)
        InitializeComponent()
        parentsForm = parent
    End Sub
    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            openFileDialog.Title = "Select a profile picture"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Load the selected image into the picture box
                Dim newImage As Image = Image.FromFile(openFileDialog.FileName)
                memberpic.Image = newImage

                ' Compare the new image with the original
                If Not ImagesAreEqual(origImage, newImage) Then
                    btnupdate.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Member_Edit_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnupdate.Enabled = False

        ' Store original values
        originalData("first_name") = txtfname.Text
        originalData("middle_name") = txtmname.Text
        originalData("last_name") = txtlname.Text
        originalData("age") = txtage.Text
        originalData("address") = txtaddress.Text
        originalData("contact_no") = txtcontact.Text
        originalData("emergency_contact") = txtemergencycontact.Text
        originalData("gender") = If(rdbmale.Checked, "MALE", "FEMALE")
        originalData("member_since") = dtmembersince.Value.ToString()

        ' Attach event handlers for all input fields
        AddHandler txtfname.TextChanged, AddressOf InputChanged
        AddHandler txtmname.TextChanged, AddressOf InputChanged
        AddHandler txtlname.TextChanged, AddressOf InputChanged
        AddHandler txtage.TextChanged, AddressOf InputChanged
        AddHandler txtaddress.TextChanged, AddressOf InputChanged
        AddHandler txtcontact.TextChanged, AddressOf InputChanged
        AddHandler txtemergencycontact.TextChanged, AddressOf InputChanged
        AddHandler dtmembersince.ValueChanged, AddressOf InputChanged
        AddHandler rdbmale.CheckedChanged, AddressOf InputChanged
        AddHandler rdbfemale.CheckedChanged, AddressOf InputChanged
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs)
        Dim imageChanged As Boolean = Not ImagesAreEqual(origImage, memberpic.Image)

        If txtfname.Text <> originalData("first_name") OrElse
       txtmname.Text <> originalData("middle_name") OrElse
       txtlname.Text <> originalData("last_name") OrElse
       txtage.Text <> originalData("age") OrElse
       txtaddress.Text <> originalData("address") OrElse
       txtcontact.Text <> originalData("contact_no") OrElse
       txtemergencycontact.Text <> originalData("emergency_contact") OrElse
       (If(rdbmale.Checked, "MALE", "FEMALE") <> originalData("gender")) OrElse
       dtmembersince.Value.ToString() <> originalData("member_since") OrElse
       imageChanged Then
            btnupdate.Enabled = True
        Else
            btnupdate.Enabled = False
        End If
    End Sub

    Private Function ImagesAreEqual(img1 As Image, img2 As Image) As Boolean
        If img1 Is Nothing OrElse img2 Is Nothing Then Return False
        Using ms1 As New MemoryStream(), ms2 As New MemoryStream()
            img1.Save(ms1, Imaging.ImageFormat.Png)
            img2.Save(ms2, Imaging.ImageFormat.Png)
            Return ms1.ToArray().SequenceEqual(ms2.ToArray())
        End Using
    End Function



    Private Function ImageToByteArray(img As Image) As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, img.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    Private originalData As New Dictionary(Of String, String)

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Validate required fields
            If String.IsNullOrWhiteSpace(txtfname.Text) OrElse
           String.IsNullOrWhiteSpace(txtlname.Text) OrElse
           String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
           String.IsNullOrWhiteSpace(txtRFID.Text) Then

                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Fetch current data from the database for comparison
            Dim querySelect As String = "SELECT * FROM tblmembers WHERE rfid = @rfid"
            Dim currentData As New Dictionary(Of String, Object)

            ' Add this validation after checking if fields are empty, but BEFORE openConn()
            If Not IsNumeric(txtemergencycontact.Text) Then
                MessageBox.Show("Emergency contact must be a valid number.", "Invalid Emergency Contact", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Exit if validation fails
            End If


            openConn()
            Using cmdSelect As New MySqlCommand(querySelect, con)
                cmdSelect.Parameters.AddWithValue("@rfid", txtRFID.Text)
                Using reader As MySqlDataReader = cmdSelect.ExecuteReader()
                    If reader.Read() Then
                        currentData("first_name") = reader("first_name").ToString()
                        currentData("middle_name") = reader("middle_name").ToString()
                        currentData("last_name") = reader("last_name").ToString()
                        currentData("age") = reader("age").ToString()
                        currentData("address") = reader("address").ToString()
                        currentData("contact_no") = reader("contact_no").ToString()
                        currentData("emergency_contact") = reader("emergency_contact").ToString()
                        currentData("gender") = reader("gender").ToString()
                        currentData("member_since") = reader("member_since").ToString()

                        ' Check if there's an existing image
                        If Not IsDBNull(reader("picture")) Then
                            currentData("picture") = DirectCast(reader("picture"), Byte())
                        Else
                            currentData("picture") = Nothing
                        End If
                    Else
                        MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using
            End Using

            ' Check if any field has changed
            Dim hasChanges As Boolean = False

            If txtfname.Text <> currentData("first_name").ToString() OrElse
           txtmname.Text <> currentData("middle_name").ToString() OrElse
           txtlname.Text <> currentData("last_name").ToString() OrElse
           txtage.Text <> currentData("age").ToString() OrElse
           txtaddress.Text <> currentData("address").ToString() OrElse
           txtcontact.Text <> currentData("contact_no").ToString() OrElse
           txtemergencycontact.Text <> currentData("emergency_contact").ToString() OrElse
           (If(rdbmale.Checked, "MALE", "FEMALE") <> currentData("gender").ToString()) OrElse
           dtmembersince.Value.ToString() <> currentData("member_since").ToString() Then
                hasChanges = True
            End If

            ' Check if the image has changed
            Dim newImageBytes As Byte() = Nothing
            If memberpic.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    Using bmp As New Bitmap(memberpic.Image)
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    End Using
                    newImageBytes = ms.ToArray()
                End Using
            End If

            ' Compare images
            If newImageBytes IsNot Nothing Then
                If currentData("picture") Is Nothing OrElse Not newImageBytes.SequenceEqual(DirectCast(currentData("picture"), Byte())) Then
                    hasChanges = True
                End If
            End If

            ' If no changes detected, show message and exit
            If Not hasChanges Then
                MessageBox.Show("No changes detected.", "Update Not Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Start building the base update query
            Dim query As String = "UPDATE tblmembers SET " &
                              "first_name = @fname, " &
                              "middle_name = @mname, " &
                              "last_name = @lname, " &
                              "age = @age, " &
                              "address = @address, " &
                              "contact_no = @contact, " &
                              "emergency_contact = @emergencycontact, " &
                              "gender = @gender, " &
                              "member_since = @membersince"

            ' Include image update if a new one is provided
            If newImageBytes IsNot Nothing Then
                query &= ", picture = @picture"
            End If

            query &= " WHERE rfid = @rfid"

            ' Execute the update query
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
                cmd.Parameters.AddWithValue("@fname", txtfname.Text)
                cmd.Parameters.AddWithValue("@mname", txtmname.Text)
                cmd.Parameters.AddWithValue("@lname", txtlname.Text)
                cmd.Parameters.AddWithValue("@age", txtage.Text)
                cmd.Parameters.AddWithValue("@address", txtaddress.Text)
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text)
                cmd.Parameters.AddWithValue("@emergencycontact", txtemergencycontact.Text)
                cmd.Parameters.AddWithValue("@gender", If(rdbmale.Checked, "MALE", "FEMALE"))
                cmd.Parameters.AddWithValue("@membersince", dtmembersince.Value)

                If newImageBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@picture", newImageBytes)
                End If

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Member details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()

                    ' Refresh parent form
                    Dim parentForm As membership = Application.OpenForms.OfType(Of membership)().FirstOrDefault()
                    If parentForm IsNot Nothing Then
                        parentForm.RefreshGrid()
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("No records updated. Please check the RFID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub ClearFields()
        txtRFID.Clear()
        txtfname.Clear()
        txtmname.Clear()
        txtlname.Clear()
        txtmname.Clear()
        txtage.Clear()
        txtaddress.Clear()
        txtcontact.Clear()
        txtemergencycontact.Clear()
        memberpic.Image = My.Resources.gymnast_1163072
        rdbmale.Checked = False
        rdbfemale.Checked = False
        dtmembersince.Value = Date.Now
    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub txtfname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfname.KeyPress
        ' Allow only letters, space, and control keys (e.g., Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Cancel the keypress event
        End If

        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub



    Private Sub txtmname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmname.KeyPress
        ' Allow only letters, space, and control keys (e.g., Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Cancel the keypress event
        End If

        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub txtlname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlname.KeyPress
        ' Allow only letters, space, and control keys (e.g., Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Cancel the keypress event
        End If

        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub txtaddress_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtaddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaddress.KeyPress
        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub txtRFID_TextChanged(sender As Object, e As EventArgs) Handles txtRFID.TextChanged
        If txtRFID.Text.Length >= 10 Then
            txtRFID.SelectionStart = 0
            txtRFID.SelectionLength = Len(txtRFID.Text)
            txtRFID.Focus()
        End If
    End Sub


    ' Allow only numbers (digits) and control keys (e.g., backspace)
    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Prevent invalid input
        End If
    End Sub

    ' Validate age range (1-100) after input changes
    Private Sub txtage_TextChanged(sender As Object, e As EventArgs) Handles txtage.TextChanged
        Dim age As Integer

        ' Check if the textbox is not empty and contains a valid number
        If Integer.TryParse(txtage.Text, age) Then
            ' Restrict age to max 100
            If age > 100 Then
                MessageBox.Show("Age cannot be more than 100!", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtage.Text = "100" ' Set max allowed value
                txtage.SelectionStart = txtage.Text.Length ' Keep cursor at the end
            ElseIf age < 1 Then
                MessageBox.Show("Age must be at least 1!", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtage.Text = "1" ' Set min allowed value
                txtage.SelectionStart = txtage.Text.Length ' Keep cursor at the end
            End If
        End If
    End Sub


    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        ' Allow only digits and control keys (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            ' If already 11 digits, block further digit input
            Dim digitsOnly As String = New String(txtcontact.Text.Where(AddressOf Char.IsDigit).ToArray())
            If digitsOnly.Length >= 11 AndAlso Not txtcontact.SelectedText.Length > 0 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtcontact_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcontact.Validating
        Dim digitsOnly As String = New String(txtcontact.Text.Where(AddressOf Char.IsDigit).ToArray())

        If digitsOnly.Length <> 11 OrElse Not digitsOnly.StartsWith("09") Then
            MessageBox.Show("Contact number must be exactly 11 digits and start with '09'.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtemergencycontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemergencycontact.KeyPress
        ' Allow only digits and control keys (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            ' Limit to 11 digits
            Dim digitsOnly As String = New String(txtemergencycontact.Text.Where(AddressOf Char.IsDigit).ToArray())
            If digitsOnly.Length >= 11 AndAlso Not txtemergencycontact.SelectedText.Length > 0 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtemergencycontact_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtemergencycontact.Validating
        Dim digitsOnly As String = New String(txtemergencycontact.Text.Where(AddressOf Char.IsDigit).ToArray())

        If String.IsNullOrWhiteSpace(digitsOnly) Then
            ' Optional: Skip validation if it's empty
            Return
        End If

        If digitsOnly.Length <> 11 OrElse Not digitsOnly.StartsWith("09") Then
            MessageBox.Show("Emergency contact must be exactly 11 digits and start with '09'.", "Invalid Emergency Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Me.Close()
    End Sub
End Class