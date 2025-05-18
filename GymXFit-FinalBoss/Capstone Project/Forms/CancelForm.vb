Imports MySql.Data.MySqlClient
Public Class CancelForm
    Private Sub btncancelled_Click(sender As Object, e As EventArgs) Handles btncancelled.Click
        Try
            If String.IsNullOrWhiteSpace(txtreason.Text) OrElse txtreason.Text = "Enter reason here..." Then
                MessageBox.Show("Please provide a valid reason for cancellation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtreason.Focus()
                Exit Sub
            End If

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to cancel this membership?.",
                                                            "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirmResult = DialogResult.Yes Then
                openConn()
                Dim datenow As String = Date.Now.ToString("yyyy-MM-dd")

                ' Step 1: Retrieve full member data
                Dim selectCmd As New MySqlCommand("SELECT * FROM tblmembers WHERE rfid = @rfid", con)
                selectCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)

                Dim dr As MySqlDataReader = selectCmd.ExecuteReader()

                If dr.Read() Then
                    ' Step 2: Insert full data into archive table
                    Dim archiveCmd As New MySqlCommand("INSERT INTO tblarchived_members 
                    (rfid, picture, first_name, middle_name, last_name, age, contact_no, address, gender, member_since, emergency_contact, status)
                    VALUES
                    (@rfid, @picture, @first_name, @middle_name, @last_name, @age, @contact_no, @address, @gender, @member_since, @emergency_contact, @status)", con)

                    archiveCmd.Parameters.AddWithValue("@rfid", dr("rfid"))
                    archiveCmd.Parameters.AddWithValue("@picture", dr("picture"))
                    archiveCmd.Parameters.AddWithValue("@first_name", dr("first_name"))
                    archiveCmd.Parameters.AddWithValue("@middle_name", dr("middle_name"))
                    archiveCmd.Parameters.AddWithValue("@last_name", dr("last_name"))
                    archiveCmd.Parameters.AddWithValue("@age", dr("age"))
                    archiveCmd.Parameters.AddWithValue("@contact_no", dr("contact_no"))
                    archiveCmd.Parameters.AddWithValue("@address", dr("address"))
                    archiveCmd.Parameters.AddWithValue("@gender", dr("gender"))
                    archiveCmd.Parameters.AddWithValue("@member_since", dr("member_since"))
                    archiveCmd.Parameters.AddWithValue("@emergency_contact", dr("emergency_contact"))
                    archiveCmd.Parameters.AddWithValue("@status", dr("status"))
                    dr.Close() ' Must close reader before executing another command
                    archiveCmd.ExecuteNonQuery()

                    ' Step 3: Insert into cancellation table
                    Dim cancelCmd As New MySqlCommand("INSERT INTO tblcancellation (rfid, name, address, `date`, cancelby, reason) 
                        VALUES (@rfid, @name, @address, @date, @cancelby, @reason)", con)

                    cancelCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
                    cancelCmd.Parameters.AddWithValue("@name", txtcancelname.Text)
                    cancelCmd.Parameters.AddWithValue("@address", txtcanceladdress.Text)
                    cancelCmd.Parameters.AddWithValue("@date", datenow)
                    cancelCmd.Parameters.AddWithValue("@cancelby", MainForm.lblloginname.Text)
                    cancelCmd.Parameters.AddWithValue("@reason", txtreason.Text.Trim())
                    cancelCmd.ExecuteNonQuery()

                    ' Step 4: Delete from tblmembers
                    Dim deleteCmd As New MySqlCommand("DELETE FROM tblmembers WHERE rfid = @rfid", con)
                    deleteCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
                    Dim rowsAffected As Integer = deleteCmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Cancellation of membership saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        Dim parentForm As membership = Application.OpenForms.OfType(Of membership)().FirstOrDefault()
                        If parentForm IsNot Nothing Then
                            parentForm.RefreshGrid()
                        End If
                    Else
                        MessageBox.Show("Member not found in tblmembers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    MessageBox.Show("Member data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Membership cancellation aborted.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub txtreason_TextChanged(sender As Object, e As EventArgs) Handles txtreason.TextChanged

    End Sub

    Private Sub txtreason_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtreason.KeyPress
        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class