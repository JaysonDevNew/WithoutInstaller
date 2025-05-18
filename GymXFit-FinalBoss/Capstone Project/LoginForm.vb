Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports Mysqlx.XDevAPI.Common
Imports Mysqlx

Public Class LoginForm
    Private failedLoginAttempts As New Dictionary(Of String, Integer) ' Stores failed attempts per user
    Private accountLockoutTime As New Dictionary(Of String, DateTime) ' Stores lockout time per user

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.PasswordChar = Chr(149)
        txtusername.Focus()
    End Sub

    Private Sub LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginPanel.Paint
        LoginPanel.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtusername.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()

        ' Check if username or password is empty
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check if this account is locked
        If accountLockoutTime.ContainsKey(username) AndAlso DateTime.Now < accountLockoutTime(username) Then
            Dim remainingTime As Integer = CInt((accountLockoutTime(username) - DateTime.Now).TotalSeconds)
            MessageBox.Show($"Account '{username}' is locked. Try again in {remainingTime} seconds.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            openConn()

            ' First check if username exists
            Dim checkUsernameQuery As String = "SELECT * FROM tblaccount WHERE username COLLATE utf8mb4_bin = @username"
            Dim usernameExists As Boolean = False
            Dim correctPassword As Boolean = False
            Dim retrievedUserName As String = ""
            Dim userType As String = ""
            Dim userPicture() As Byte

            Using cmd As New MySqlCommand(checkUsernameQuery, con)
                cmd.Parameters.AddWithValue("@username", username)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.HasRows Then
                        usernameExists = True
                        If dr.Read() Then
                            If dr("password").ToString() = password Then
                                correctPassword = True
                                retrievedUserName = dr("name").ToString()
                                userType = dr("usertype").ToString()
                                If Not IsDBNull(dr("picture")) Then
                                    userPicture = CType(dr("picture"), Byte())
                                End If
                            End If
                        End If
                    End If
                End Using
            End Using

            If usernameExists Then
                If correctPassword Then
                    ' Successful login - Reset failed attempts
                    failedLoginAttempts(username) = 0
                    accountLockoutTime.Remove(username)

                    LoadingScreen.Show()
                    Me.Hide()
                    MainForm.lblloginname.Text = retrievedUserName

                    ' Load profile picture safely
                    If userPicture IsNot Nothing Then
                        MainForm.Profilepicture.Image = ByteArrayToImage(userPicture)
                    Else
                        MainForm.Profilepicture.Image = Nothing
                    End If

                    ' Restrict buttons if Employee
                    If userType = "Employee" Then
                        MainForm.btnbackup.Visible = False
                        MainForm.btnaccount.Visible = False
                        MainForm.btnreport.Visible = False
                        MainForm.btninventory.Visible = False
                        MainForm.btnmaintenance.Visible = False
                    End If

                    Exit Sub ' Successful login

                Else
                    ' Wrong password
                    If Not failedLoginAttempts.ContainsKey(username) Then
                        failedLoginAttempts(username) = 0
                    End If

                    failedLoginAttempts(username) += 1

                    If failedLoginAttempts(username) >= 3 Then
                        accountLockoutTime(username) = DateTime.Now.AddSeconds(30) ' Lock for 30 seconds
                        MessageBox.Show($"Account '{username}' is locked due to too many failed attempts. Try again in 30 seconds.", "Login Locked", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim remainingAttempts As Integer = 3 - failedLoginAttempts(username)
                        MessageBox.Show($"Incorrect password. {remainingAttempts} attempt(s) remaining.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                ' Username does not exist
                MessageBox.Show("Username does not exist.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    ' Convert Byte Array to Image
    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    ' Show/Hide Password
    Private Sub chkpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkpassword.CheckedChanged
        txtpassword.PasswordChar = If(chkpassword.Checked, "", Chr(149))
    End Sub

    ' Enter Key to Login
    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuButton1_Click(btnlogin, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuButton1_Click(btnlogin, EventArgs.Empty)
        End If
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuButton1_Click(btnlogin, EventArgs.Empty)
        End If
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub BunifuLabel5_Click(sender As Object, e As EventArgs) Handles lblforgot.Click
        ForgotPassword.Show()
    End Sub

    Private Sub BunifuLabel5_MouseHover(sender As Object, e As EventArgs) Handles lblforgot.MouseHover
        lblforgot.Font = New Font(lblforgot.Font, FontStyle.Underline)
    End Sub

    Private Sub BunifuLabel5_MouseLeave(sender As Object, e As EventArgs) Handles lblforgot.MouseLeave
        lblforgot.Font = New Font(lblforgot.Font, FontStyle.Regular)
    End Sub

End Class
