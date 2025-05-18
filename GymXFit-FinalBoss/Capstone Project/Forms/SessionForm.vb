Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class SessionForm
    Private Sub btnSaveSession_Click(sender As Object, e As EventArgs) Handles btnSaveSession.Click
        ' Validate payment
        Dim paymentAmount As Integer
        If Not Integer.TryParse(txtSessionPayment.Text.Trim(), paymentAmount) Then
            MessageBox.Show("Please enter a valid payment amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If paymentAmount < 50 Then
            MessageBox.Show("Insufficient balance. Payment must be at least 50.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            openConn()

            Dim sql As String = "INSERT INTO tblsession (FullName, Payment, Date, Time) " &
                            "VALUES (@fullname, @payment, @date, @time)"

            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@fullname", txtSessionName.Text)
                cmd.Parameters.AddWithValue("@payment", paymentAmount.ToString("F2"))
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM-dd-yyyy"))
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("hh:mm tt"))

                cmd.ExecuteNonQuery()
            End Using

            ' Clear the form inputs
            txtSessionName.Clear()
            txtSessionPayment.Clear()
            txtSessionName.Focus()
            LoadSession()

            MessageBox.Show("Session saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving session: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Public Sub LoadSession()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim sql As String = "SELECT FullName, Payment, Date, Time FROM tblsession ORDER BY Date DESC, Time DESC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            dgvSessionHistory.Rows.Clear()

            While dr.Read()
                Dim fullName As String = dr("FullName").ToString()
                Dim payment As String = dr("Payment").ToString()
                Dim sessionDate As String = Convert.ToDateTime(dr("Date")).ToString("MM-dd-yyyy")
                Dim sessionTime As String = Convert.ToDateTime(dr("Time")).ToString("hh:mm tt")

                dgvSessionHistory.Rows.Add(fullName, payment, sessionDate, sessionTime)
            End While

            dr.Close()
            dgvSessionHistory.ClearSelection()
            dgvSessionHistory.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error loading sessions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub



    Private Sub SessionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSession()
    End Sub



    Private Sub txtSessionPayment_TextChanged(sender As Object, e As EventArgs) Handles txtSessionPayment.TextChanged
        ' Keep only numeric characters
        Dim input As String = txtSessionPayment.Text
        Dim numericInput As String = ""

        For Each ch As Char In input
            If Char.IsDigit(ch) Then
                numericInput &= ch
            End If
        Next

        ' Update textbox if non-numeric characters were found
        If txtSessionPayment.Text <> numericInput Then
            txtSessionPayment.Text = numericInput
            txtSessionPayment.SelectionStart = txtSessionPayment.Text.Length
        End If

        ' Check numeric range
        If numericInput <> "" Then
            Dim value As Integer = Integer.Parse(numericInput)

            If value <= 1 Then
                ' Clear if value is too low
                txtSessionPayment.Text = ""
            ElseIf value > 1000 Then
                ' Clamp to 1000 if too high
                txtSessionPayment.Text = "1000"
                txtSessionPayment.SelectionStart = txtSessionPayment.Text.Length
            End If
        End If
    End Sub

    Private Sub txtSessionName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSessionName.KeyPress
        ' Allow only letters, space, and control keys (e.g., Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Cancel the keypress event
        End If

        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        activitylogs.Show()
        Me.Close()
    End Sub
End Class