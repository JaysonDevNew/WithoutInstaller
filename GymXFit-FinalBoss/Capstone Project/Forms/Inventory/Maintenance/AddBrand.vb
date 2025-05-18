Imports MySql.Data.MySqlClient
Public Class AddBrand
    Private Sub btnAddbrand_Click(sender As Object, e As EventArgs) Handles btnAddbrand.Click
        Try
            If String.IsNullOrWhiteSpace(txtBrand.Text) Then
                MessageBox.Show("Please insert a brand name.", "Empty Brand name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            openConn()

            Dim sql As String = "INSERT INTO tblbrandname (brandname) VALUES (@brandname)"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@brandname", txtBrand.Text)


            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Brand name has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtBrand.Clear()
                MaintenanceForm.LoadBrand()

            Else
                MessageBox.Show("Failed to add brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub

    Private Sub btnUpdatebrand_Click(sender As Object, e As EventArgs) Handles btnUpdatebrand.Click
        Try
            ' Ensure the category textbox is not empty
            If String.IsNullOrWhiteSpace(txtBrand.Text) Then
                MessageBox.Show("Please enter a brand name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Ensure ID is not empty
            If String.IsNullOrWhiteSpace(txtID.Text) Then
                MessageBox.Show("Brand name ID is missing. Please select a brand name to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            openConn() ' Open database connection

            ' Get category ID
            Dim brandID As Integer = Convert.ToInt32(txtID.Text)

            ' Update query
            Dim sql As String = "UPDATE tblbrandname SET brandname = @brandname WHERE id = @id"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@brandname", txtBrand.Text)
            cmd.Parameters.AddWithValue("@id", brandID) ' Use categoryID instead of categoryId

            ' Execute the update command
            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Brand name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView in MaintenanceForm
                MaintenanceForm.LoadBrand()

                ' Close the AddCategory form after updating
                Me.Close()
            Else
                MessageBox.Show("Failed to update brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close() ' Close connection
        End Try
    End Sub

    Private Sub txtBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBrand.KeyPress
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class