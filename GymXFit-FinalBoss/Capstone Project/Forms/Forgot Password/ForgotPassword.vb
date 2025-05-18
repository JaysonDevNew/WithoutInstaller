Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class ForgotPassword

    Dim generatedOTP As String
    Dim otpGeneratedTime As DateTime
    Dim countdown As Integer = 30
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtConfirmPass.Enabled = False
        Me.KeyPreview = True

        txtChangePass.UseSystemPasswordChar = True
        otptimer.Interval = 1000 ' 1 second

        txtConfirmPass.UseSystemPasswordChar = True
        txtotp.MaxLength = 6

    End Sub

    Private Sub txtChangePass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChangePass.KeyPress
        ' Allow only valid password characters
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso
       Not Char.IsSymbol(e.KeyChar) AndAlso
       Not Char.IsPunctuation(e.KeyChar) AndAlso
       Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtConfirmPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmPass.KeyPress
        ' Allow only valid password characters
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso
       Not Char.IsSymbol(e.KeyChar) AndAlso
       Not Char.IsPunctuation(e.KeyChar) AndAlso
       Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' --- Event when txtCheckUsername loses focus ---
    Private Sub txtCheckUsername_LostFocus(sender As Object, e As EventArgs) Handles txtCheckUsername.LostFocus
        If txtCheckUsername.Text.Trim() <> "" Then
            Try
                openConn()
                cmd = New MySqlCommand("SELECT COUNT(*) FROM tblaccount WHERE username = @username", con)
                cmd.Parameters.AddWithValue("@username", txtCheckUsername.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count = 0 Then
                    MessageBox.Show("Username does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCheckUsername.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Error checking username: " & ex.Message)
            End Try
        End If
    End Sub

    ' --- Event when btnChangePass is clicked ---
    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        ' Validation
        If txtCheckUsername.Text.Trim() = "" OrElse txtChangePass.Text.Trim() = "" OrElse txtConfirmPass.Text.Trim() = "" Then
            MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtChangePass.Text.Trim() <> txtConfirmPass.Text.Trim() Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Update password
        Try
            openConn()
            cmd = New MySqlCommand("UPDATE tblaccount SET password = @password WHERE username = @username", con)
            cmd.Parameters.AddWithValue("@password", txtChangePass.Text.Trim())
            cmd.Parameters.AddWithValue("@username", txtCheckUsername.Text.Trim())

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Clear fields after success
                txtCheckUsername.Clear()
                txtChangePass.Clear()
                txtConfirmPass.Clear()
                txtotp.Clear()
                txtemail.Clear()
                txtotp.Enabled = False

            Else
                MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message)
        End Try
    End Sub

    Private Sub txtChangePass_TextChanged(sender As Object, e As EventArgs) Handles txtChangePass.TextChanged
        Dim password As String = txtChangePass.Text

        If password.Length < 8 Then
            lblPasswordStatus.Text = "Password too short (min 8 characters)"
            lblPasswordStatus.ForeColor = Color.Red
            txtConfirmPass.Enabled = False
            Exit Sub
        End If

        Dim hasUpper As Boolean = password.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = password.Any(AddressOf Char.IsLower)
        Dim hasDigit As Boolean = password.Any(AddressOf Char.IsDigit)
        Dim hasSpecial As Boolean = password.Any(Function(c) Not Char.IsLetterOrDigit(c))

        If hasUpper AndAlso hasLower AndAlso hasDigit AndAlso hasSpecial Then
            lblPasswordStatus.Text = "Strong Password ✅"
            lblPasswordStatus.ForeColor = Color.Green
            txtConfirmPass.Enabled = True ' Allow proceeding
        Else
            lblPasswordStatus.Text = "Weak Password ❌ (needs Uppercase, Lowercase, Number, Special)"
            lblPasswordStatus.ForeColor = Color.Red
            txtConfirmPass.Enabled = False ' Block proceeding
        End If
    End Sub

    Private Sub ForgotPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePass.PerformClick()
            txtCheckUsername.Focus()
        End If
    End Sub

    Private Sub btnsendotp_Click(sender As Object, e As EventArgs) Handles btnsendotp.Click
        Dim connectionString As String = "server=localhost;username=root;password=;database=gymxfit_database"

        If txtCheckUsername.Text = "" Or txtemail.Text = "" Then
            MessageBox.Show("Please fill in both Username and Email.")
            Exit Sub
        End If

        Using con As New MySqlConnection(connectionString)
            Try
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tblaccount  WHERE username=@username AND email=@email", con)
                cmd.Parameters.AddWithValue("@username", txtCheckUsername.Text)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)

                con.Open()
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If result = 1 Then
                    ' ✅ Match found — generate and send OTP
                    Dim rand As New Random()
                    generatedOTP = rand.Next(100000, 999999).ToString()

                    ' Send Email via Gmail SMTP
                    Dim smtp As New SmtpClient("smtp.gmail.com", 587)
                    smtp.EnableSsl = True
                    smtp.Credentials = New NetworkCredential("gymxfit3@gmail.com", "zjsd gxew xaad giwg")

                    Dim mail As New MailMessage()
                    mail.From = New MailAddress("GadgetProOfficial39@gmail.com")
                    mail.To.Add(txtemail.Text)
                    mail.Subject = "GymXFit - Your OTP Code"
                    mail.Body = "Dear " & txtCheckUsername.Text & "," & vbCrLf & vbCrLf &
                                "You requested to reset your password. Your One-Time Password (OTP) is:" & vbCrLf &
                                generatedOTP & vbCrLf & vbCrLf &
                                "This OTP is valid for 5 minutes. Please do not share it with anyone." & vbCrLf & vbCrLf &
                                "Thank you,"
                    smtp.Send(mail)

                    MessageBox.Show("An OTP has been sent to your Gmail. Please check your inbox.")

                    ' Start 30-second cooldown
                    otpGeneratedTime = DateTime.Now
                    btnsendotp.Enabled = False
                    countdown = 30
                    lbltimer.Text = "Resend OTP in: " & countdown & "s"
                    lbltimer.Visible = True
                    otptimer.Start()
                    txtotp.Enabled = True
                Else
                    MessageBox.Show("Username and Email do not match any record.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If txtotp.Text = "" Then
            MessageBox.Show("Please enter the OTP.")
            Exit Sub
        End If

        ' Check if 5 minutes passed
        If DateTime.Now > otpGeneratedTime.AddMinutes(5) Then
            MessageBox.Show("OTP has expired. Please request a new one.")
            Exit Sub
        End If

        ' Check if OTP matches
        If txtotp.Text = generatedOTP Then
            MessageBox.Show("OTP verified. You may now reset your password.")
            ' Enable password reset controls here

            txtChangePass.Enabled = True
            txtConfirmPass.Enabled = True
            txtConfirmPass.Enabled = True

        Else
            MessageBox.Show("Incorrect OTP.")
        End If
    End Sub

    Private Sub otptimer_Tick(sender As Object, e As EventArgs) Handles otptimer.Tick
        countdown -= 1
        lbltimer.Text = "Resend OTP in: " & countdown & "s"

        If countdown <= 0 Then
            otptimer.Stop()
            btnsendotp.Enabled = True
            lbltimer.Visible = False
        End If
    End Sub

    Private Sub txtotp_TextChanged(sender As Object, e As EventArgs) Handles txtotp.TextChanged

    End Sub

    Private Sub txtotp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtotp.KeyPress
        ' Allow only digits and control keys (like backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkpassword.CheckedChanged
        Dim showPassword As Boolean = chkpassword.Checked

        txtChangePass.UseSystemPasswordChar = Not showPassword
        txtConfirmPass.UseSystemPasswordChar = Not showPassword
    End Sub
End Class