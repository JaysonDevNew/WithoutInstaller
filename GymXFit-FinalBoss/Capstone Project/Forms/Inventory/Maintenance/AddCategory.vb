Imports MySql.Data.MySqlClient
Imports TheArtOfDev.HtmlRenderer.Adapters
Public Class AddCategory
    Private Sub btnAddcategory_Click(sender As Object, e As EventArgs) Handles btnAddcategory.Click
        Try
            If String.IsNullOrWhiteSpace(txtCategory.Text) Then
                MessageBox.Show("Please insert a category.", "Empty Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            openConn()

            Dim sql As String = "INSERT INTO tblcategory (category) VALUES (@category)"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@category", txtCategory.Text)


            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Category has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                MaintenanceForm.LoadCategory()
                txtCategory.Clear()


            Else
                MessageBox.Show("Failed to add category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdatecategory_Click(sender As Object, e As EventArgs) Handles btnUpdatecategory.Click
        Try
            ' Ensure the category textbox is not empty
            If String.IsNullOrWhiteSpace(txtCategory.Text) Then
                MessageBox.Show("Please enter a category name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Ensure ID is not empty
            If String.IsNullOrWhiteSpace(txtID.Text) Then
                MessageBox.Show("Category ID is missing. Please select a category to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            openConn() ' Open database connection

            ' Get category ID
            Dim categoryID As Integer = Convert.ToInt32(txtID.Text)

            ' Update query
            Dim sql As String = "UPDATE tblcategory SET category = @category WHERE id = @id"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@category", txtCategory.Text)
            cmd.Parameters.AddWithValue("@id", categoryID) ' Use categoryID instead of categoryId

            ' Execute the update command
            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView in MaintenanceForm
                MaintenanceForm.LoadCategory()

                ' Close the AddCategory form after updating
                Me.Close()
            Else
                MessageBox.Show("Failed to update category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close() ' Close connection
        End Try
    End Sub

    Private Sub txtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub txtCategory_TextChanged(sender As Object, e As EventArgs) Handles txtCategory.TextChanged

    End Sub
End Class