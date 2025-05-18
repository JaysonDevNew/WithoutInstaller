Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Account_Forms
    Dim imgpath As String
    Dim arrimage() As Byte
    Private accountsForm As accounts ' Reference to the main form

    ' Constructor to accept the reference to the accounts form
    Public Sub New(parentForm As accounts)
        InitializeComponent()
        accountsForm = parentForm
    End Sub

    ' Button to browse and load an image into a PictureBox
    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image File(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"

        If ofd.ShowDialog() = DialogResult.OK Then
            imgpath = ofd.FileName
            pctprofile.Image = Image.FromFile(imgpath)
        End If

        ofd = Nothing
    End Sub

    ' Button to insert data and image into MySQL
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Try
            ' Validate that no fields are empty
            If String.IsNullOrWhiteSpace(txtname.Text) Then
                MessageBox.Show("Please enter a name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtname.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtemail.Text) Then
                MessageBox.Show("Please enter an email address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtemail.Focus()
                Return
            Else
                Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
                If Not Regex.IsMatch(txtemail.Text, emailPattern) Then
                    MessageBox.Show("Please enter a valid email address format (e.g. name@example.com).", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtemail.Focus()
                    Return
                End If
            End If

            If String.IsNullOrWhiteSpace(txtusername.Text) Then
                MessageBox.Show("Please enter a username.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtusername.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtemail.Text) Then
                MessageBox.Show("Please enter an email address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtemail.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtpassword.Text) Then
                MessageBox.Show("Please enter a password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpassword.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtconfirmpass.Text) Then
                MessageBox.Show("Please confirm your password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtconfirmpass.Focus()
                Return
            End If

            If cbmusertype.SelectedIndex = -1 Then
                MessageBox.Show("Please select a user type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbmusertype.Focus()
                Return
            End If

            If pctprofile.Image Is Nothing Then
                MessageBox.Show("Please upload a profile image.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnbrowse.Focus()
                Return
            End If

            ' Validate that the passwords match
            If txtpassword.Text <> txtconfirmpass.Text Then
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpassword.Focus()
                Return
            End If

            ' Convert the image into a byte array
            Dim mstream As New MemoryStream()
            pctprofile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            mstream.Close()

            ' Open the connection using the shared module
            openConn()
            Dim sql As String = "INSERT INTO tblaccount (picture, name, username, email, password, usertype) VALUES (@profile_image, @name, @username, @email, @password, @usertype)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@profile_image", arrimage)
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@email", txtemail.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@usertype", cbmusertype.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear form fields
                txtname.Clear()
                txtusername.Clear()
                txtemail.Clear()
                txtpassword.Clear()
                txtconfirmpass.Clear()
                pctprofile.Image = My.Resources.gymnast_1163072
                cbmusertype.Text = ""

                ' Call RefreshGrid on the accounts form
                accountsForm.RefreshGrid()
                accountsForm.dgvaccount.ClearSelection()
            Else
                MessageBox.Show("Failed to insert record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        txtname.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtconfirmpass.Clear()
        pctprofile.Image = My.Resources.gymnast_1163072
        cbmusertype.Text = ""

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        Dim password As String = txtpassword.Text

        If password.Length < 8 Then
            lblPasswordStatus.Text = "Password too short (min 8 characters)"
            lblPasswordStatus.ForeColor = Color.Red
            Exit Sub
        End If

        Dim hasUpper As Boolean = password.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = password.Any(AddressOf Char.IsLower)
        Dim hasDigit As Boolean = password.Any(AddressOf Char.IsDigit)
        Dim hasSpecial As Boolean = password.Any(Function(c) Not Char.IsLetterOrDigit(c))

        If hasUpper AndAlso hasLower AndAlso hasDigit AndAlso hasSpecial Then
            lblPasswordStatus.Text = "Strong Password ✅"
            lblPasswordStatus.ForeColor = Color.Green
        Else
            lblPasswordStatus.Text = "Weak Password ❌ (needs Uppercase, Lowercase, Number, Special)"
            lblPasswordStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        Dim currentText As String = txtname.Text
        Dim newText As String = ""

        For Each c As Char In currentText
            If Char.IsLetter(c) OrElse Char.IsWhiteSpace(c) Then
                newText &= c
            End If
        Next

        If txtname.Text <> newText Then
            Dim selectionStart As Integer = txtname.SelectionStart
            txtname.Text = newText
            txtname.SelectionStart = Math.Min(selectionStart, txtname.Text.Length)
        End If
    End Sub

    Private Sub Account_Forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

