Imports MySql.Data.MySqlClient
Public Class AddProductName
    Private Sub btnAddproduct_Click(sender As Object, e As EventArgs) Handles btnAddproduct.Click
        Try
            If String.IsNullOrWhiteSpace(txtProduct.Text) Then
                MessageBox.Show("Please insert a product name.", "Empty Product name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            openConn()

            Dim sql As String = "INSERT INTO tblproductname (productname) VALUES (@productname)"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@productname", txtProduct.Text)


            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Product name has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtProduct.Clear()
                MaintenanceForm.LoadProductName()


            Else
                MessageBox.Show("Failed to add product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdateproduct_Click(sender As Object, e As EventArgs) Handles btnUpdateproduct.Click
        Try
            ' Ensure the category textbox is not empty
            If String.IsNullOrWhiteSpace(txtProduct.Text) Then
                MessageBox.Show("Please enter a product name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Ensure ID is not empty
            If String.IsNullOrWhiteSpace(txtID.Text) Then
                MessageBox.Show("Product name ID is missing. Please select a brand name to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            openConn() ' Open database connection

            ' Get category ID
            Dim productID As Integer = Convert.ToInt32(txtID.Text)

            ' Update query
            Dim sql As String = "UPDATE tblproductname SET productname = @productname WHERE id = @id"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@productname", txtProduct.Text)
            cmd.Parameters.AddWithValue("@id", productID) ' Use categoryID instead of categoryId

            ' Execute the update command
            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Product name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView in MaintenanceForm
                MaintenanceForm.LoadProductName()

                ' Close the AddCategory form after updating
                Me.Close()
            Else
                MessageBox.Show("Failed to update product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close() ' Close connection
        End Try
    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged

    End Sub

    Private Sub txtProduct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProduct.KeyPress
        ' If the typed character is lowercase, convert it to uppercase
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

End Class