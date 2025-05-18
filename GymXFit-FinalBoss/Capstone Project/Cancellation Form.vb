Imports MySql.Data.MySqlClient
Public Class Cancellation_Form
    Public parentsForm As membership

    Private Sub btncancelled_Click(sender As Object, e As EventArgs) Handles btncancelled.Click
        Try
            ' Validation
            If String.IsNullOrWhiteSpace(txtRFID.Text) OrElse
               String.IsNullOrWhiteSpace(txtfname.Text) OrElse
               String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
               String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
               String.IsNullOrWhiteSpace(txtexpired.Text) OrElse
               String.IsNullOrWhiteSpace(txtreason.Text) Then
                MessageBox.Show("Please fill in all fields before cancelling the membership.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Confirm cancellation
            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to cancel this membership?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.No Then
                Return
            End If

            ' Insert into tblcancellation
            openConn()
            Dim insertSql As String = "INSERT INTO tblcancellation (rfid, name, address, reason) VALUES (@rfid, @name, @address,@reason)"
            Dim insertCmd As New MySqlCommand(insertSql, con)
            insertCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
            insertCmd.Parameters.AddWithValue("@name", txtfname.Text)
            insertCmd.Parameters.AddWithValue("@address", txtaddress.Text)
            insertCmd.Parameters.AddWithValue("@reason", txtreason.Text)

            If insertCmd.ExecuteNonQuery() > 0 Then
                ' Update status in tblmembers
                Dim updateSql As String = "UPDATE tblmembers SET status = 'Cancelled' WHERE rfid = @rfid"
                Dim updateCmd As New MySqlCommand(updateSql, con)
                updateCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)

                If updateCmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Membership successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh parent form and close
                    If parentsForm IsNot Nothing Then
                        parentsForm.RefreshGrid()
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("Failed to update the member's status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Failed to insert cancellation details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub


End Class