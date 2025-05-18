Imports MySql.Data.MySqlClient
Public Class MaintenanceForm
    Private Sub PnlPayment_Paint(sender As Object, e As PaintEventArgs) Handles PnlPayment.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles btnAddbrand.Click
        AddBrand.Show()
    End Sub

    Private Sub btnAddcategory_Click(sender As Object, e As EventArgs) Handles btnAddcategory.Click
        AddCategory.Show()
        AddCategory.btnUpdatecategory.Enabled = False
    End Sub

    Private Sub GunaAdvenceTileButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        AddProductName.Show()
        AddProductName.btnUpdateproduct.Enabled = False
    End Sub

    Public Sub LoadCategory()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim sql As String = "SELECT * FROM tblcategory"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            dgvcategory.Rows.Clear()

            While dr.Read()

                dgvcategory.Rows.Add(
                    dr("id"),
                    dr("category")
                )
            End While

            dgvcategory.ClearSelection()
            dgvcategory.Refresh() ' Refresh the DataGridView
            lblcategorycount.Text = dgvcategory.Rows.Count

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

    Public Sub LoadBrand()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim sql As String = "SELECT * FROM tblbrandname"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            dgvbrandname.Rows.Clear()

            While dr.Read()

                dgvbrandname.Rows.Add(
                    dr("id"),
                    dr("brandname")
                )
            End While

            dgvbrandname.ClearSelection()
            dgvbrandname.Refresh() ' Refresh the DataGridView
            lblbrandcount.Text = dgvbrandname.Rows.Count

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

    Public Sub LoadProductName()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim sql As String = "SELECT * FROM tblproductname"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            dgvproductname.Rows.Clear()

            While dr.Read()

                dgvproductname.Rows.Add(
                    dr("id"),
                    dr("productname")
                )
            End While

            dgvproductname.ClearSelection()
            dgvproductname.Refresh() ' Refresh the DataGridView
            lblProductcount.Text = dgvproductname.Rows.Count

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

    Private Sub dgvcategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategory.CellContentClick
        Dim colName As String = dgvcategory.Columns(e.ColumnIndex).Name

        ' Ensure the selected row is valid
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvcategory.Rows(e.RowIndex)

            If colName = "edit" Then
                ' Open AddCategory Form and pass the selected category
                AddCategory.Show()
                AddCategory.btnAddcategory.Enabled = False  ' Disable the Add button
                AddCategory.btnUpdatecategory.Enabled = True ' Enable the Update button

                ' Populate the fields with the selected category data
                AddCategory.txtID.Text = selectedRow.Cells("id").Value.ToString() ' Set the ID
                AddCategory.txtCategory.Text = selectedRow.Cells("category").Value.ToString() ' Set the category name

            ElseIf colName = "delete" Then
                Dim categoryId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                Dim categoryName As String = selectedRow.Cells("category").Value.ToString()

                ' Confirm deletion
                Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete '" & categoryName & "'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If confirmDelete = DialogResult.Yes Then
                    Try
                        openConn()

                        Dim sql As String = "DELETE FROM tblcategory WHERE id = @id"
                        cmd = New MySqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@id", categoryId)

                        Dim result As Integer = cmd.ExecuteNonQuery()

                        If result > 0 Then
                            MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadCategory() ' Refresh the DataGridView
                        Else
                            MessageBox.Show("Failed to delete category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



    Private Sub MaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategory()
        LoadBrand()
        LoadProductName()
    End Sub

    Private Sub PnlCancel_Paint(sender As Object, e As PaintEventArgs) Handles PnlCancel.Paint

    End Sub

    Private Sub dgvbrandname_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbrandname.CellContentClick
        Dim colName As String = dgvbrandname.Columns(e.ColumnIndex).Name

        ' Ensure the selected row is valid
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvbrandname.Rows(e.RowIndex)

            If colName = "editbrnd" Then
                ' Open AddCategory Form and pass the selected category
                AddBrand.Show()
                AddBrand.btnAddbrand.Enabled = False  ' Disable the Add button
                AddBrand.btnUpdatebrand.Enabled = True ' Enable the Update button

                ' Populate the fields with the selected category data
                AddBrand.txtID.Text = selectedRow.Cells("idbrnd").Value.ToString() ' Set the ID
                AddBrand.txtBrand.Text = selectedRow.Cells("brandname").Value.ToString() ' Set the category name

            ElseIf colName = "deletebrnd" Then
                Dim brandID As Integer = Convert.ToInt32(selectedRow.Cells("idbrnd").Value)
                Dim brandName As String = selectedRow.Cells("brandname").Value.ToString()

                ' Confirm deletion
                Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete '" & brandName & "'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If confirmDelete = DialogResult.Yes Then
                    Try
                        openConn()

                        Dim sql As String = "DELETE FROM tblbrandname WHERE id = @id"
                        cmd = New MySqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@id", brandID)

                        Dim result As Integer = cmd.ExecuteNonQuery()

                        If result > 0 Then
                            MessageBox.Show("Brand name deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadBrand() ' Refresh the DataGridView
                        Else
                            MessageBox.Show("Failed to delete brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvproductname_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproductname.CellContentClick
        Dim colName As String = dgvproductname.Columns(e.ColumnIndex).Name

        ' Ensure the selected row is valid
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvproductname.Rows(e.RowIndex)

            If colName = "editprdct" Then
                ' Open AddCategory Form and pass the selected category
                AddProductName.Show()
                AddProductName.btnAddproduct.Enabled = False  ' Disable the Add button
                AddProductName.btnUpdateproduct.Enabled = True ' Enable the Update button

                ' Populate the fields with the selected category data
                AddProductName.txtID.Text = selectedRow.Cells("idprdct").Value.ToString() ' Set the ID
                AddProductName.txtProduct.Text = selectedRow.Cells("pdctname").Value.ToString() ' Set the category name

            ElseIf colName = "deleteprdct" Then
                Dim productID As Integer = Convert.ToInt32(selectedRow.Cells("idprdct").Value)
                Dim productName As String = selectedRow.Cells("pdctname").Value.ToString()

                ' Confirm deletion
                Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete '" & productName & "'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If confirmDelete = DialogResult.Yes Then
                    Try
                        openConn()

                        Dim sql As String = "DELETE FROM tblproductname WHERE id = @id"
                        cmd = New MySqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@id", productID)

                        Dim result As Integer = cmd.ExecuteNonQuery()

                        If result > 0 Then
                            MessageBox.Show("Product name deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadProductName() ' Refresh the DataGridView
                        Else
                            MessageBox.Show("Failed to delete Product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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