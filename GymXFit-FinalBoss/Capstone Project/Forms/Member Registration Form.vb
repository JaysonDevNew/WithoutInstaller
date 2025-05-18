Imports AForge.Imaging.Filters
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Member_Registration_Form
    Dim imgpath As String
    Dim arrimage() As Byte
    Public parentsForm As membership ' Reference to the parent form

    ' Constructor to accept the parent form reference
    Public Sub New(parent As membership)
        InitializeComponent()
        parentsForm = parent
    End Sub


    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click

        ' First check if the profile picture has been changed from default
        If memberpic.Image Is Nothing OrElse ImageEquals(memberpic.Image, My.Resources.gymnast_1163072) Then
            MessageBox.Show("Please upload a profile picture. A profile picture is required for registration.", "Missing Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Then check the rest of the form fields as you were doing before
        If String.IsNullOrWhiteSpace(txtRFID.Text) OrElse
       String.IsNullOrWhiteSpace(txtfname.Text) OrElse
       String.IsNullOrWhiteSpace(txtmname.Text) OrElse
       String.IsNullOrWhiteSpace(txtlname.Text) OrElse
       String.IsNullOrWhiteSpace(txtage.Text) OrElse
       String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
       String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
       (Not rdbmale.Checked AndAlso Not rdbfemale.Checked) OrElse
       String.IsNullOrWhiteSpace(txtemergencycontact.Text) Then
            MessageBox.Show("Please complete all account details.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If




        If Not IsNumeric(txtemergencycontact.Text) Then
            MessageBox.Show("Emergency contact must be a valid number.", "Invalid Emergency Contact", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' --- Only Database Operations inside Try ---
        Try
            openConn()

            ' Check for duplicate RFID
            Dim checkRFIDCmd As New MySqlCommand("SELECT COUNT(*) FROM tblmembers WHERE rfid = @rfid", con)
            checkRFIDCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
            If Convert.ToInt32(checkRFIDCmd.ExecuteScalar()) > 0 Then
                MessageBox.Show("The RFID already exists. Please use a unique RFID.", "Duplicate RFID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
                Return
            End If

            ' Check for duplicate full name
            Dim checkNameCmd As New MySqlCommand("SELECT COUNT(*) FROM tblmembers WHERE first_name=@fname AND middle_name=@mname AND last_name=@lname", con)
            checkNameCmd.Parameters.AddWithValue("@fname", txtfname.Text)
            checkNameCmd.Parameters.AddWithValue("@mname", txtmname.Text)
            checkNameCmd.Parameters.AddWithValue("@lname", txtlname.Text)
            If Convert.ToInt32(checkNameCmd.ExecuteScalar()) > 0 Then
                MessageBox.Show("A member with the same name already exists.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
                Return
            End If

            ' Convert picture to byte array
            Dim mstream As New MemoryStream()
            memberpic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrimage As Byte() = mstream.ToArray()
            mstream.Close()

            ' Gender selection
            Dim rgender As String = If(rdbmale.Checked, "MALE", If(rdbfemale.Checked, "FEMALE", ""))

            ' Insert new member
            Dim sql As String = "INSERT INTO tblmembers (picture, rfid, first_name, middle_name, last_name, age, contact_no, address, gender, member_since, emergency_contact) " &
                        "VALUES(@profile_image, @rfid, @first_name, @middle_name, @last_name, @age, @contact_no, @address, @gender, @member_since, @emergency_contact)"
            Dim cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@profile_image", arrimage)
            cmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
            cmd.Parameters.AddWithValue("@first_name", txtfname.Text)
            cmd.Parameters.AddWithValue("@middle_name", txtmname.Text)
            cmd.Parameters.AddWithValue("@last_name", txtlname.Text)
            cmd.Parameters.AddWithValue("@age", txtage.Text)
            cmd.Parameters.AddWithValue("@contact_no", txtcontact.Text)
            cmd.Parameters.AddWithValue("@address", txtaddress.Text)
            cmd.Parameters.AddWithValue("@gender", rgender)
            cmd.Parameters.AddWithValue("@member_since", dtmembersince.Value)
            cmd.Parameters.AddWithValue("@emergency_contact", txtemergencycontact.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Member has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reset form
                memberpic.Image = Nothing
                txtRFID.Clear()
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtage.Clear()
                txtcontact.Clear()
                txtaddress.Clear()
                rdbmale.Checked = False
                rdbfemale.Checked = False
                dtmembersince.Value = Date.Now
                txtemergencycontact.Clear()
                memberpic.Image = My.Resources.gymnast_1163072

                ' Refresh grid and count
                parentsForm.RefreshGrid()
                parentsForm.UpdateCountMember()


            Else
                MessageBox.Show("Failed to add member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Function ImageEquals(img1 As Image, img2 As Image) As Boolean
        If img1 Is Nothing OrElse img2 Is Nothing Then
            Return img1 Is Nothing AndAlso img2 Is Nothing
        End If

        ' Compare basic properties first for efficiency
        If img1.Width <> img2.Width OrElse img1.Height <> img2.Height Then
            Return False
        End If

        ' For more precise comparison, convert both to byte arrays and compare
        Using ms1 As New MemoryStream()
            Using ms2 As New MemoryStream()
                img1.Save(ms1, Imaging.ImageFormat.Png)
                img2.Save(ms2, Imaging.ImageFormat.Png)

                Dim bytes1 As Byte() = ms1.ToArray()
                Dim bytes2 As Byte() = ms2.ToArray()

                If bytes1.Length <> bytes2.Length Then
                    Return False
                End If

                For i As Integer = 0 To bytes1.Length - 1
                    If bytes1(i) <> bytes2(i) Then
                        Return False
                    End If
                Next

                Return True
            End Using
        End Using
    End Function

    Public Sub Clear()
        ' Reset form fields
        memberpic.Image = My.Resources.gymnast_1163072
        txtRFID.Clear()
        txtfname.Clear()
        txtmname.Clear()
        txtlname.Clear()
        txtage.Clear()
        txtcontact.Clear()
        txtaddress.Clear()
        rdbmale.Checked = False
        rdbfemale.Checked = False
        dtmembersince.Value = Date.Now
        txtemergencycontact.Clear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Member_Registration_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRFID.Focus()
        dtmembersince.Value = Date.Now
    End Sub

    Private Sub btncapture_Click(sender As Object, e As EventArgs) Handles btncapture.Click
        Dim webcam As New Webcam_Form(Me)
        webcam.Show()
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        membership.RefreshGrid()
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

    Private Sub txtmname_TextChanged(sender As Object, e As EventArgs) Handles txtmname.TextChanged

    End Sub

    Private Sub txtmname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Cancel the keypress event
        End If
        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub txtlname_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub txtlname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Cancel the keypress event
        End If

        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
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
                txtage.Text = "" ' Set max allowed value
                txtage.SelectionStart = txtage.Text.Length ' Keep cursor at the end
            ElseIf age < 1 Then
                MessageBox.Show("Age must be at least 1!", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtage.Text = "" ' Set min allowed value
                txtage.SelectionStart = txtage.Text.Length ' Keep cursor at the end
            End If
        End If
    End Sub




    ' Prevent non-numeric input
    Private Sub txtRFID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Prevent input of non-numeric characters
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



    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Clear()
        Me.Close()
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

        If digitsOnly.Length <> 11 OrElse Not digitsOnly.StartsWith("09") Then
            MessageBox.Show("Emergency contact must be exactly 11 digits and start with '09'.", "Invalid Emergency Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            e.Cancel = True
        End If
    End Sub


    Private Sub txtRFID_TextChanged(sender As Object, e As EventArgs) Handles txtRFID.TextChanged
        If txtRFID.Text.Length >= 10 Then
            txtRFID.SelectionStart = 0
            txtRFID.SelectionLength = Len(txtRFID.Text)
            txtRFID.Focus()
        End If
    End Sub

    Private Sub txtcontact_TextChanged(sender As Object, e As EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub txtemergencycontact_TextChanged(sender As Object, e As EventArgs) Handles txtemergencycontact.TextChanged

    End Sub
End Class

