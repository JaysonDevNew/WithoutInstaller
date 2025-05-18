
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class StockEntry
    Dim connection As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")
    Private Sub StockEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        dtpdatereceived.Value = Date.Today
        For Each row As DataGridViewRow In dgvStockEntry.Rows
            Dim addedStockValue As String = If(row.Cells("AddedStock").Value, "").ToString().Trim()

            ' Check if the "Added Stock" column is NOT blank
            If Not String.IsNullOrEmpty(addedStockValue) Then
                row.DefaultCellStyle.ForeColor = Color.Gray ' Make text gray to indicate it's disabled
                row.ReadOnly = True   ' Make the row read-only (can't select)
            Else
                row.DefaultCellStyle.ForeColor = Color.Black ' Normal color
                row.ReadOnly = False  ' Allow selection
            End If
        Next

        Try
            ' Open connection if not already open
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            ' Clear previous items
            cmbCategory.Items.Clear()

            ' Query to get distinct categories
            Dim sql As String = "SELECT DISTINCT pcategory FROM tblproducts ORDER BY pcategory"
            Dim cmd As New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Load categories into ComboBox
            While dr.Read()
                cmbCategory.Items.Add(dr("pcategory").ToString())
            End While

            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If dgvProducts.Columns("Action") Is Nothing Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.Name = "Action"
            btnCol.HeaderText = "Action"
            btnCol.Text = "Select"
            btnCol.UseColumnTextForButtonValue = True
            dgvProducts.Columns.Add(btnCol)
        End If
        txtrefno.ReadOnly = True
        txtProductName.ReadOnly = True
        txtreceivedby.MaxLength = 10
        dtpdatereceived.Format = DateTimePickerFormat.Custom
        dtpdatereceived.CustomFormat = "yyyy-MM-dd"  ' Display as YYYY-MM-DD

        dgvStockEntry.Rows.Clear()
    End Sub

    Private selectedRowIndex As Integer = -1


    Private Sub LoadProducts()
        Try
            ' Check if connection is already open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, brandname, productname, pcategory, price, stock FROM tblproducts"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            dgvProducts.Rows.Clear() ' Clear previous data

            ' Check if button column exists, add it if missing
            If dgvProducts.Columns.Count = 0 Then
                dgvProducts.Columns.Add("id", "ID")
                dgvProducts.Columns.Add("brandname", "Brand Name")
                dgvProducts.Columns.Add("productname", "Product Name")
                dgvProducts.Columns.Add("pcategory", "Category")
                dgvProducts.Columns.Add("price", "Price")
                dgvProducts.Columns.Add("stock", "Stock")

                ' Add Action Button Column

            End If

            ' Counters for stock levels
            Dim normalCount As Integer = 0
            Dim lowCount As Integer = 0
            Dim criticalCount As Integer = 0

            ' Load Data into DataGridView
            While reader.Read()
                Dim stock As Integer = Convert.ToInt32(reader("stock"))

                ' Count stock levels
                If stock > 40 Then
                    normalCount += 1
                ElseIf stock >= 10 AndAlso stock < 40 Then
                    lowCount += 1
                Else
                    criticalCount += 1
                End If

                dgvProducts.Rows.Add(reader("id"), reader("brandname"), reader("productname"), reader("pcategory"), reader("price"), stock, "Select")
            End While

            reader.Close()

            ' Update stock level labels
            lblnormal.Text = normalCount.ToString()
            lbllow.Text = lowCount.ToString()
            lblcritical.Text = criticalCount.ToString()

            dgvProducts.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            ' Ensure connection is closed to avoid open connection issues
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        If e.ColumnIndex = dgvProducts.Columns("Action").Index AndAlso e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            ' Check if "Remove" button column already exists, if not, add it
            If dgvStockEntry.Columns("Remove") Is Nothing Then
                Dim removeButton As New DataGridViewButtonColumn()
                removeButton.HeaderText = "Action"
                removeButton.Text = "Remove"
                removeButton.Name = "Remove"
                removeButton.UseColumnTextForButtonValue = True
                dgvStockEntry.Columns.Add(removeButton)
            End If

            ' Add row to dgvStockEntry
            dgvStockEntry.Rows.Add(row.Cells("id").Value, row.Cells("brandname").Value, row.Cells("productname").Value, row.Cells("pcategory").Value, row.Cells("price").Value, row.Cells("stock").Value, "")

            ' Display selected row ID in TextBox
            txtProductID.Text = row.Cells("id").Value.ToString()
            txtProductName.Text = row.Cells("productname").Value.ToString()
        End If


        panelselect.Visible = False
        panelselect.SendToBack()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        For Each row As DataGridViewRow In dgvProducts.Rows
            If row.Cells("productname").Value IsNot Nothing AndAlso row.Cells("brandname").Value IsNot Nothing Then
                row.Visible = row.Cells("productname").Value.ToString().ToLower().Contains(txtsearch.Text.ToLower()) OrElse
                              row.Cells("brandname").Value.ToString().ToLower().Contains(txtsearch.Text.ToLower())
            End If
        Next
    End Sub

    Private Sub btnselectproduct_Click(sender As Object, e As EventArgs) Handles btnselectproduct.Click
        panelselect.Visible = True
        panelselect.BringToFront()

        LoadProducts()
        Static lowStockMessageShown As Boolean = False

        Try
            ' Ensure connection is closed before opening
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, brandname, productname, pcategory, price, stock FROM tblproducts"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            dgvProducts.Rows.Clear() ' Clear existing data

            ' Reload DataGridView with updated data
            While reader.Read()
                dgvProducts.Rows.Add(reader("id"), reader("brandname"), reader("productname"), reader("pcategory"), reader("price"), reader("stock"), "Select")
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close connection after use
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        Dim lowStockCount As Integer = 0

        ' Loop through DataGridView rows to check stock values
        For Each row As DataGridViewRow In dgvProducts.Rows
            If row.Cells("stock").Value IsNot Nothing Then
                Dim stockValue As Integer = Convert.ToInt32(row.Cells("stock").Value)
                If stockValue < 10 Then
                    lowStockCount += 1
                End If
            End If
        Next

        ' Show the message only once
        If lowStockCount > 0 AndAlso Not lowStockMessageShown Then
            Dim productWord As String = If(lowStockCount = 1, "product", "products")
            MessageBox.Show("Warning! There are " & lowStockCount & " " & productWord & " with critically low stock.", "Low Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Set the flag to True so the message won't show again
            lowStockMessageShown = True
        ElseIf lowStockCount = 0 AndAlso Not lowStockMessageShown Then
            MessageBox.Show("All products have sufficient stock.", "Stock Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Set the flag to True so the message won't show again
            lowStockMessageShown = True
        End If

    End Sub

    Private Sub dgvStockEntry_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockEntry.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvStockEntry.Rows(e.RowIndex)
            txtProductName.Text = selectedRow.Cells("productname1").Value.ToString()
        End If
        If e.ColumnIndex = dgvStockEntry.Columns("addedstock").Index AndAlso e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex
            txtaddedstock.Focus()
        End If

        If e.ColumnIndex = dgvStockEntry.Columns("Remove").Index AndAlso e.RowIndex >= 0 Then
            ' Confirm before removing
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this entry?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                dgvStockEntry.Rows.RemoveAt(e.RowIndex) ' Remove selected row
            End If
        End If


    End Sub

    Private Sub btnupdatestock_Click(sender As Object, e As EventArgs) Handles btnupdatestock.Click
        If String.IsNullOrWhiteSpace(txtrefno.Text) OrElse
               String.IsNullOrWhiteSpace(txtreceivedby.Text) OrElse
             String.IsNullOrWhiteSpace(txtaddedstock.Text) Then

            MessageBox.Show("Please complete all the information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dgvStockEntry.SelectedRows.Count > 0 Then
            ' Get the selected row index
            Dim rowIndex As Integer = dgvStockEntry.CurrentCell.RowIndex

            ' Check if "Added Stock" column is already filled
            Dim addedStockValue As String = If(dgvStockEntry.Rows(rowIndex).Cells("AddedStock").Value, "").ToString().Trim()

            If Not String.IsNullOrEmpty(addedStockValue) Then
                MessageBox.Show("Action Not Allowed.", "Exisitng Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub ' Prevent further execution
            End If

            ' Get the value from txtaddedstock
            Dim addedStock As Integer
            If Integer.TryParse(txtaddedstock.Text, addedStock) Then
                ' Update the "Added Stock" column in the selected row
                dgvStockEntry.Rows(rowIndex).Cells("AddedStock").Value = addedStock
            Else
                MessageBox.Show("Please enter a valid number for Added Stock.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else
            MessageBox.Show("Please select a product first.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Ensure the connection is opened only if it's closed
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Validate input
            If String.IsNullOrEmpty(txtProductID.Text) OrElse String.IsNullOrEmpty(txtaddedstock.Text) Then
                MessageBox.Show("Please select a product and enter the added stock.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Get product ID and added stock from textboxes
            Dim productID As Integer = Convert.ToInt32(txtProductID.Text)
            Dim addedStock As Integer = Convert.ToInt32(txtaddedstock.Text)

            ' Update stock in tblproducts
            Dim query As String = "UPDATE tblproducts SET stock = stock + @addedStock WHERE id = @id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@addedStock", addedStock)
            cmd.Parameters.AddWithValue("@id", productID)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No matching product found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Reload DataGridView to reflect updated stock
            LoadProducts()

            ' Disable selection for rows with "Added Stock" already set
            For Each row As DataGridViewRow In dgvStockEntry.Rows
                Dim addedStockValue As String = If(row.Cells("AddedStock").Value, "").ToString().Trim()

                If Not String.IsNullOrEmpty(addedStockValue) Then
                    row.DefaultCellStyle.ForeColor = Color.Gray ' Make text gray
                    row.ReadOnly = True   ' Make the row read-only
                Else
                    row.DefaultCellStyle.ForeColor = Color.Black ' Normal color
                    row.ReadOnly = False  ' Allow selection
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection safely
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

    End Sub


    Private Sub dgvStockEntry_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockEntry.CellClick

        If e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex ' Store the selected row index

            ' Display the existing "Added Stock" value (if any) in txtAddedStock
            If dgvStockEntry.Rows(selectedRowIndex).Cells("addedstock").Value IsNot Nothing Then
                txtaddedstock.Text = dgvStockEntry.Rows(selectedRowIndex).Cells("addedstock").Value.ToString()
            End If
        End If

    End Sub

    Private Sub btnfinishrestocking_Click(sender As Object, e As EventArgs) Handles btnfinishrestocking.Click

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Check if DataGridView is empty first
            If dgvStockEntry.Rows.Count = 0 OrElse dgvStockEntry.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then
                MessageBox.Show("Stock Entry table is empty. Please add at least one product before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Validate other required fields
            If String.IsNullOrWhiteSpace(txtrefno.Text) OrElse String.IsNullOrWhiteSpace(txtreceivedby.Text) Then
                MessageBox.Show("Please complete all fields before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim referenceNo As String = txtrefno.Text.Trim()
            Dim receivedBy As String = txtreceivedby.Text.Trim()
            Dim dateReceived As String = dtpdatereceived.Value.ToString("yyyy-MM-dd") ' DateTimePicker value

            ' Prepare insert query
            Dim query As String = "INSERT INTO tblstockentry (reference_no, received_by, date_received, product_id, product_name, brand_name, product_category, price, current_stock, added_stock)
                VALUES (@referenceNo, @receivedBy, @dateReceived, @productID, @productName, @brandName, @productCategory, @price, @currentStock, @addedStock)"

            Using cmd As New MySqlCommand(query, connection)
                ' Add common parameters
                cmd.Parameters.Add("@referenceNo", MySqlDbType.VarChar).Value = referenceNo
                cmd.Parameters.Add("@receivedBy", MySqlDbType.VarChar).Value = receivedBy
                cmd.Parameters.Add("@dateReceived", MySqlDbType.DateTime).Value = dateReceived

                For Each row As DataGridViewRow In dgvStockEntry.Rows
                    If Not row.IsNewRow Then
                        ' Check if Added Stock is empty
                        If row.Cells("addedstock").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("addedstock").Value.ToString()) Then
                            MessageBox.Show("Add stock to the selected products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                        ' Get values from DataGridView
                        Dim productID As Integer = Convert.ToInt32(row.Cells("productid1").Value)
                        Dim productName As String = row.Cells("productname1").Value.ToString()
                        Dim brandName As String = row.Cells("brandname1").Value.ToString()
                        Dim productCategory As String = row.Cells("pcategory1").Value.ToString()
                        Dim price As Decimal = Convert.ToDecimal(row.Cells("price1").Value)
                        Dim currentStock As Integer = Convert.ToInt32(row.Cells("currentstock1").Value)
                        Dim addedStock As Integer = Convert.ToInt32(row.Cells("addedstock").Value)

                        ' Add row-specific parameters
                        cmd.Parameters.AddWithValue("@productID", productID)
                        cmd.Parameters.AddWithValue("@productName", productName)
                        cmd.Parameters.AddWithValue("@brandName", brandName)
                        cmd.Parameters.AddWithValue("@productCategory", productCategory)
                        cmd.Parameters.AddWithValue("@price", price)
                        cmd.Parameters.AddWithValue("@currentStock", currentStock)
                        cmd.Parameters.AddWithValue("@addedStock", addedStock)

                        ' Execute insertion
                        cmd.ExecuteNonQuery()

                        ' Clear row-specific parameters for next loop iteration
                        cmd.Parameters.RemoveAt("@productID")
                        cmd.Parameters.RemoveAt("@productName")
                        cmd.Parameters.RemoveAt("@brandName")
                        cmd.Parameters.RemoveAt("@productCategory")
                        cmd.Parameters.RemoveAt("@price")
                        cmd.Parameters.RemoveAt("@currentStock")
                        cmd.Parameters.RemoveAt("@addedStock")
                    End If
                Next
            End Using

            MessageBox.Show("Stock entry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' **Clear input fields and DataGridView after successful insert**
            txtrefno.Clear()
            txtreceivedby.Clear()
            txtProductName.Clear()
            txtaddedstock.Clear()
            dgvStockEntry.Rows.Clear() ' Clear all rows in DataGridView

        Catch ex As Exception
            MessageBox.Show("Error saving stock entry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

    End Sub

    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        Dim refNo As String = DateTime.Now.ToString("yyyyMMdd-HHmmss") & "-" & GetRandomNumber()

        ' Set the generated reference number in txtrefno
        txtrefno.Text = refNo

        ' Make txtrefno read-only
        txtrefno.ReadOnly = True
    End Sub

    ' Function to generate a random number for uniqueness
    Private Function GetRandomNumber() As String
        Dim rnd As New Random()
        Return rnd.Next(1000, 9999).ToString() ' Generates a 4-digit random number
    End Function


    Private Sub dgvProducts_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProducts.CellFormatting
        If dgvProducts.Columns(e.ColumnIndex).Name = "stock" AndAlso e.Value IsNot Nothing Then
            Dim stockValue As Integer
            If Integer.TryParse(e.Value.ToString(), stockValue) Then
                ' Apply background color based on stock levels
                If stockValue < 50 Then
                    e.CellStyle.BackColor = Color.Red  ' Stock less than 10 → RED
                    e.CellStyle.ForeColor = Color.White ' Set text color to white for contrast
                ElseIf stockValue > 100 Then
                    e.CellStyle.BackColor = Color.Green  ' Stock 40 and above → GREEN
                    e.CellStyle.ForeColor = Color.White ' Set text color to white for contrast
                ElseIf stockValue < 100 Then
                    e.CellStyle.BackColor = Color.Yellow  ' Stock 30 and below → YELLOW
                    e.CellStyle.ForeColor = Color.Black ' Set text color to black for better readability
                End If
            End If
        End If
    End Sub

    Private Sub lblstockadjustment_Click(sender As Object, e As EventArgs) Handles lblstockadjustment.Click
        StockAdjustment.Show()
        Me.Hide()
    End Sub

    Private Sub lbladjustmenthistory_Click(sender As Object, e As EventArgs) Handles lbladjustmenthistory.Click
        StockAdjustmentHistory.Show()
        Me.Hide()
    End Sub

    Private Sub lblstockhistory_Click(sender As Object, e As EventArgs) Handles lblstockhistory.Click
        StockHistory.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelselect.Visible = False
        panelselect.SendToBack()

        ' Clear search and category filter
        txtsearch.Text = ""
        cmbCategory.SelectedIndex = -1 ' Clears the selected item

        ' Optionally reload all products
        LoadProducts()
    End Sub

    Private Sub panelmain_Paint(sender As Object, e As PaintEventArgs) Handles panelmain.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtProductID_TextChanged(sender As Object, e As EventArgs) Handles txtProductID.TextChanged

    End Sub

    Private Sub txtaddedstock_TextChanged(sender As Object, e As EventArgs) Handles txtaddedstock.TextChanged
        ' Check if the entered text contains any non-numeric characters
        If System.Text.RegularExpressions.Regex.IsMatch(txtaddedstock.Text, "[^\d]") Then
            ' Remove non-numeric characters
            txtaddedstock.Text = System.Text.RegularExpressions.Regex.Replace(txtaddedstock.Text, "[^\d]", "")
            ' Move the cursor to the end of the text
            txtaddedstock.SelectionStart = txtaddedstock.Text.Length
        End If

        ' Check if the entered number is greater than 999
        If txtaddedstock.Text <> "" Then
            Dim value As Integer
            If Integer.TryParse(txtaddedstock.Text, value) Then
                If value > 999 Then
                    txtaddedstock.Text = "999"
                    txtaddedstock.SelectionStart = txtaddedstock.Text.Length ' Keep cursor at end
                End If
            End If
        End If
    End Sub


    Private Sub panelselect_Paint(sender As Object, e As PaintEventArgs) Handles panelselect.Paint

    End Sub

    Private Sub GunaLinePanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel3.Paint

    End Sub

    Private Sub lblnormal_Click(sender As Object, e As EventArgs) Handles lblnormal.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub GunaLinePanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel2.Paint

    End Sub

    Private Sub lbllow_Click(sender As Object, e As EventArgs) Handles lbllow.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub GunaLinePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel1.Paint

    End Sub

    Private Sub lblcritical_Click(sender As Object, e As EventArgs) Handles lblcritical.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub lblstock_Click(sender As Object, e As EventArgs) Handles lblstock.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtpdatereceived_ValueChanged(sender As Object, e As EventArgs) Handles dtpdatereceived.ValueChanged

    End Sub

    Private Sub txtrefno_TextChanged(sender As Object, e As EventArgs) Handles txtrefno.TextChanged

    End Sub

    Private Sub Searc_Click(sender As Object, e As EventArgs) Handles Searc.Click

    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged

    End Sub

    Private Sub txtreceivedby_TextChanged(sender As Object, e As EventArgs) Handles txtreceivedby.TextChanged
        ' Check if the text contains any non-alphabetic characters
        If System.Text.RegularExpressions.Regex.IsMatch(txtreceivedby.Text, "[^a-zA-Z]") Then
            ' Remove non-alphabetic characters
            txtreceivedby.Text = System.Text.RegularExpressions.Regex.Replace(txtreceivedby.Text, "[^a-zA-Z]", "")
            ' Move the cursor to the end of the text
            txtreceivedby.SelectionStart = txtreceivedby.Text.Length
        End If
    End Sub


    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        StockHistory.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        StockHistory.ShowDialog()
        Me.Close()
    End Sub

    Private Sub txtreceivedby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtreceivedby.KeyPress
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadProductsByCategory()
    End Sub

    Private Sub LoadProductsByCategory()
        Static lowStockMessageShown As Boolean = False

        Try
            ' Open connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, brandname, productname, pcategory, price, stock FROM tblproducts WHERE pcategory = @category"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            dgvProducts.Rows.Clear() ' Clear existing data

            ' Load filtered rows
            While reader.Read()
                dgvProducts.Rows.Add(reader("id"), reader("brandname"), reader("productname"), reader("pcategory"), reader("price"), reader("stock"), "Select")
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products by category: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        ' Check for low stock warning
        Dim lowStockCount As Integer = 0

        For Each row As DataGridViewRow In dgvProducts.Rows
            If row.Cells("stock").Value IsNot Nothing Then
                Dim stockValue As Integer = Convert.ToInt32(row.Cells("stock").Value)
                If stockValue < 10 Then
                    lowStockCount += 1
                End If
            End If
        Next

        ' Show alert only once
        If lowStockCount > 0 AndAlso Not lowStockMessageShown Then
            Dim productWord As String = If(lowStockCount = 1, "product", "products")
            MessageBox.Show("Warning! There are " & lowStockCount & " " & productWord & " with critically low stock.", "Low Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lowStockMessageShown = True
        ElseIf lowStockCount = 0 AndAlso Not lowStockMessageShown Then
            MessageBox.Show("All products have sufficient stock.", "Stock Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lowStockMessageShown = True
        End If
    End Sub

    Private Sub EnsureActionColumnExists()
        If dgvProducts.Columns("Action") Is Nothing Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.Name = "Action"
            btnCol.HeaderText = "Action"
            btnCol.Text = "Select"
            btnCol.UseColumnTextForButtonValue = True
            dgvProducts.Columns.Add(btnCol)
        End If
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick

    End Sub
End Class