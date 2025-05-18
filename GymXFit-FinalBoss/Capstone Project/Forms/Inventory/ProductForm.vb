Imports MySql.Data.MySqlClient
Public Class ProductForm
    Private Sub btnAddnewproduct_Click(sender As Object, e As EventArgs) Handles btnAddnewproduct.Click
        AddProductListForm.Show()
        AddProductListForm.btnUpdateProduct.Enabled = False
    End Sub

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Public Sub LoadProducts()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim sql As String = "SELECT * FROM tblproducts"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            dgvproductlist.Rows.Clear()

            While dr.Read()
                dgvproductlist.Rows.Add(
                    dr("id"),
                    dr("brandname"),
                    dr("productname"),
                    dr("pcategory"),
                    dr("price"),
                    dr("stock")
                )
            End While

            dgvproductlist.ClearSelection()
            dgvproductlist.Refresh() ' Refresh the DataGridView
            lblproductlist.Text = dgvproductlist.Rows.Count

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub dgvproductlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproductlist.CellContentClick
        Dim colName As String = dgvproductlist.Columns(e.ColumnIndex).Name

        ' Ensure the selected row is valid
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvproductlist.Rows(e.RowIndex)

            If colName = "pedit" Then
                ' Open AddCategory Form and pass the selected category
                AddProductListForm.Show()
                AddProductListForm.btnAddProduct.Enabled = False  ' Disable the Add button
                AddProductListForm.btnUpdateProduct.Enabled = True ' Enable the Update button
                AddProductListForm.txtQTY.Enabled = False
                ' Populate the fields with the selected category data
                AddProductListForm.txtID.Text = selectedRow.Cells("id").Value.ToString() ' Set the ID
                AddProductListForm.cmbBrandname.Text = selectedRow.Cells("brandname").Value.ToString()
                AddProductListForm.cmbProductname.Text = selectedRow.Cells("productname").Value.ToString()
                AddProductListForm.cmbCategory.Text = selectedRow.Cells("pcategory").Value.ToString()
                AddProductListForm.txtPrice.Text = selectedRow.Cells("price").Value.ToString() ' Set the category name
                AddProductListForm.txtQTY.Text = selectedRow.Cells("quantity").Value.ToString()

            ElseIf colName = "pdelete" Then
                Dim productID As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                Dim productName As String = selectedRow.Cells("productname").Value.ToString()

                ' Confirm deletion
                Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete '" & productName & "'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If confirmDelete = DialogResult.Yes Then
                    Try
                        openConn()

                        Dim sql As String = "DELETE FROM tblproducts WHERE id = @id"
                        cmd = New MySqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@id", productID)

                        Dim result As Integer = cmd.ExecuteNonQuery()

                        If result > 0 Then
                            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadProducts()
                        Else
                            MessageBox.Show("Failed to delete Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()
                    End Try
                End If
            End If
        End If
    End Sub
End Class