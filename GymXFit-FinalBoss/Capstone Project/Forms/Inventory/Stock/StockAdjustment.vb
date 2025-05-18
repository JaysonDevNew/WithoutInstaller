Imports Mysqlx
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class StockAdjustment
    Dim connection As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")
    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

        If e.ColumnIndex >= 0 AndAlso dgvProducts.Columns(e.ColumnIndex).Name = "Action" Then
            Dim selectedRow As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            ' Transfer data to textboxes
            txtProductID.Text = selectedRow.Cells("id").Value.ToString()
            txtbrandname.Text = selectedRow.Cells("brandname").Value.ToString()
            txtproductname.Text = selectedRow.Cells("productname").Value.ToString()
            txtcategory.Text = selectedRow.Cells("pcategory").Value.ToString()
            txtprice.Text = selectedRow.Cells("price").Value.ToString()
            txtcurrentstock.Text = selectedRow.Cells("stock").Value.ToString()
        End If
    End Sub

    Private Sub LoadProducts()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, brandname, productname, pcategory, price, stock FROM tblproducts"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            dgvProducts.Rows.Clear()
            dgvProducts.Columns.Clear() ' Clear existing columns before adding new ones

            ' Add columns manually
            dgvProducts.Columns.Add("id", "ID")
            dgvProducts.Columns.Add("brandname", "Brand Name")
            dgvProducts.Columns.Add("productname", "Product Name")
            dgvProducts.Columns.Add("pcategory", "Category")
            dgvProducts.Columns.Add("price", "Price")
            dgvProducts.Columns.Add("stock", "Stock")

            ' Add Action Button Column
            Dim btnColumn As New DataGridViewButtonColumn()
            btnColumn.HeaderText = "Action"
            btnColumn.Name = "Action"
            btnColumn.Text = "Select"
            btnColumn.UseColumnTextForButtonValue = True
            dgvProducts.Columns.Add(btnColumn)

            ' Populate DataGridView
            While reader.Read()
                dgvProducts.Rows.Add(reader("id"), reader("brandname"), reader("productname"), reader("pcategory"), reader("price"), reader("stock"))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub StocAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtreason.MaxLength = 20
        txtadjustedby.MaxLength = 20

        LoadProducts()
        For Each column As DataGridViewColumn In dgvProducts.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClearForm()
        txtproductname.Clear()
        txtbrandname.Clear()
        txtproductname.Clear()
        txtcategory.Clear()
        txtprice.Clear()
        txtcurrentstock.Clear()
        txtadjustedstock.Clear()
        txtreason.Clear()
        txtadjustedby.Clear()
        rdbaddstock.Checked = False
        rdbremovestock.Checked = False
        txtProductID.Clear()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblstock_Click(sender As Object, e As EventArgs) Handles lblstock.Click
        StockEntry.Show()
        Me.Hide()
    End Sub

    Private Sub lblstockadjustment_Click(sender As Object, e As EventArgs) Handles lblstockadjustment.Click

    End Sub

    Private Sub lbladjustmenthistory_Click(sender As Object, e As EventArgs) Handles lbladjustmenthistory.Click
        Dim stockHistoryForm As New StockAdjustmentHistory()
        stockHistoryForm.Show()
        Me.Hide()
    End Sub

    Private Sub lblstockhistory_Click(sender As Object, e As EventArgs) Handles lblstockhistory.Click
        StockHistory.Show()
        Me.Hide()
    End Sub

    Private Sub txtadjustedstock_TextChanged(sender As Object, e As EventArgs) Handles txtadjustedstock.TextChanged
        If txtadjustedstock.Text <> "" Then
            Dim value As Integer
            If Integer.TryParse(txtadjustedstock.Text, value) Then
                If value > 999 Then
                    txtadjustedstock.Text = "999"
                    txtadjustedstock.SelectionStart = txtadjustedstock.Text.Length ' Keep cursor at end
                End If
            End If
        End If
    End Sub

    Private Sub txtadjustedstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtadjustedstock.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the input

        End If
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnadjust.Click

        Try
            ' Validate if all required fields are filled
            If String.IsNullOrWhiteSpace(txtproductname.Text) OrElse
       String.IsNullOrWhiteSpace(txtbrandname.Text) OrElse
       String.IsNullOrWhiteSpace(txtcategory.Text) OrElse
       String.IsNullOrWhiteSpace(txtprice.Text) OrElse
       String.IsNullOrWhiteSpace(txtcurrentstock.Text) OrElse
       String.IsNullOrWhiteSpace(txtadjustedstock.Text) OrElse
       String.IsNullOrWhiteSpace(txtreason.Text) OrElse
       String.IsNullOrWhiteSpace(txtadjustedby.Text) Then

                MessageBox.Show("Please fill in all required fields before adjusting stock.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Confirm stock adjustment before proceeding
            Dim confirmAdjustment As DialogResult = MessageBox.Show("Are you sure you want to adjust the stock?", "Confirm Adjustment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmAdjustment = DialogResult.No Then Exit Sub ' Stop execution if user cancels

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim currentStock As Integer = Convert.ToInt32(txtcurrentstock.Text)
            Dim adjustedStock As Integer = Convert.ToInt32(txtadjustedstock.Text)
            Dim newStock As Integer

            If rdbaddstock.Checked Then
                ' Add adjusted stock to current stock
                newStock = currentStock + adjustedStock

            ElseIf rdbremovestock.Checked Then
                ' Ensure adjusted stock is not greater than current stock
                If adjustedStock > currentStock Then
                    MessageBox.Show("Error: Adjusted stock exceeded the current product stock!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub ' Stop execution
                ElseIf adjustedStock = currentStock Then
                    Dim result As DialogResult = MessageBox.Show(
            "Adjusted stock is equal to current stock." & vbCrLf & "Are you sure you want to remove all the current stock?",
            "Confirm Full Stock Removal",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )
                    If result = DialogResult.No Then
                        Exit Sub
                    End If
                End If

                ' Subtract adjusted stock from current stock
                newStock = currentStock - adjustedStock

            Else
                MessageBox.Show("Please select an adjustment type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' 1. Update stock in tblproducts
            Dim queryUpdate As String = "UPDATE tblproducts SET stock = @newStock WHERE productname = @productName"
            Using cmdUpdate As New MySqlCommand(queryUpdate, connection)
                cmdUpdate.Parameters.AddWithValue("@newStock", newStock)
                cmdUpdate.Parameters.AddWithValue("@productName", txtproductname.Text)
                cmdUpdate.ExecuteNonQuery()
            End Using

            ' 2. Insert into tblstockadjustment (Only storing date in date_adjusted)
            Dim queryInsert As String = "INSERT INTO tblstockadjustment (brand_name, product_name, product_category, price, current_stock, adjusted_stock, adjusted_type, reason, adjusted_by, date_adjusted) 
                          VALUES (@brandName, @productName, @productCategory, @price, @currentStock, @adjustedStock, @adjustedType, @reason, @adjustedBy, CURDATE())"
            Using cmdInsert As New MySqlCommand(queryInsert, connection)
                cmdInsert.Parameters.AddWithValue("@brandName", txtbrandname.Text)
                cmdInsert.Parameters.AddWithValue("@productName", txtproductname.Text)
                cmdInsert.Parameters.AddWithValue("@productCategory", txtcategory.Text)
                cmdInsert.Parameters.AddWithValue("@price", Convert.ToDecimal(txtprice.Text))
                cmdInsert.Parameters.AddWithValue("@currentStock", currentStock) ' Store the old stock before updating
                cmdInsert.Parameters.AddWithValue("@adjustedStock", adjustedStock)
                cmdInsert.Parameters.AddWithValue("@adjustedType", If(rdbaddstock.Checked, "Addition", "Deduction"))
                cmdInsert.Parameters.AddWithValue("@reason", txtreason.Text)
                cmdInsert.Parameters.AddWithValue("@adjustedBy", txtadjustedby.Text)
                cmdInsert.ExecuteNonQuery()
            End Using

            ' Update UI
            txtcurrentstock.Text = newStock.ToString()

            ' Clear input fields after successful insert
            ClearForm()

            MessageBox.Show("Stock adjustment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            LoadProducts()
        End Try

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim confirmCancel As DialogResult = MessageBox.Show("Are you sure you want to cancel and clear all inputs?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmCancel = DialogResult.Yes Then
            ClearForm()
        End If
    End Sub

    Private Sub TxtSeearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSeearch.TextChanged
        For Each row As DataGridViewRow In dgvProducts.Rows
            If row.Cells("productname").Value IsNot Nothing AndAlso row.Cells("brandname").Value IsNot Nothing Then
                row.Visible = row.Cells("productname").Value.ToString().ToLower().Contains(TxtSeearch.Text.ToLower()) OrElse
                              row.Cells("brandname").Value.ToString().ToLower().Contains(TxtSeearch.Text.ToLower())
            End If
        Next
    End Sub

    Private Sub txtreason_TextChanged(sender As Object, e As EventArgs) Handles txtreason.TextChanged

    End Sub

    Private Sub txtreason_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtreason.KeyPress
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only letters are allowed in the reason field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtadjustedby_TextChanged(sender As Object, e As EventArgs) Handles txtadjustedby.TextChanged

    End Sub

    Private Sub txtadjustedby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtadjustedby.KeyPress
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtadjustedby_KeyDown(sender As Object, e As KeyEventArgs) Handles txtadjustedby.KeyDown

    End Sub
End Class