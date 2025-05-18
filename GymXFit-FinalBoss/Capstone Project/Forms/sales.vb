Imports Mysqlx
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Public Class sales
    Dim connection As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub pnlSales_Paint(sender As Object, e As PaintEventArgs) Handles pnlSales.Paint

    End Sub

    Private Sub LoadProducts()
        Try
            ' Ensure connection is closed before opening
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' SQL Query to fetch product details
            Dim query As String = "SELECT id, brandname, productname, pcategory, price, stock FROM tblproducts"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows before loading new data
            dgvProducts.Rows.Clear()

            ' Loop through the data and add to DataGridView
            While reader.Read()
                dgvProducts.Rows.Add(reader("id"), reader("brandname"), reader("productname"), reader("pcategory"), reader("price"), reader("stock"), "Select")
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadCategories()
        Try
            ' Open connection if closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get unique product categories
            Dim query As String = "SELECT DISTINCT pcategory FROM tblproducts"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing items before adding new ones
            cmbCategory.Items.Clear()

            ' Read and add categories to ComboBox
            While reader.Read()
                cmbCategory.Items.Add(reader("pcategory").ToString())
            End While

            ' Close reader
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub sales_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerDate.Enabled = True
        TimerTime.Enabled = True



        ' Load products into DataGridView
        LoadProducts()
        LoadCategories()
        Dim newTransactionNo As String = GenerateTransactionNumber()
        lbltransaction.Text = newTransactionNo
    End Sub

    Private Sub TimerDate_Tick(sender As Object, e As EventArgs) Handles TimerDate.Tick
        lblDate.Text = Date.Now.ToString("dddd, MMMM d, yyyy")
    End Sub

    Private Sub TimerTime_Tick(sender As Object, e As EventArgs) Handles TimerTime.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
    End Sub

    Private Sub btnmembership_Click(sender As Object, e As EventArgs) Handles btnmembership.Click
        If Not String.IsNullOrWhiteSpace(lbltransaction.Text) AndAlso IsNumeric(lbltransaction.Text) Then
            Dim result As DialogResult = MessageBox.Show("A transaction already exists. Do you want to generate a new one? This will clear the cart.",
                                                 "Confirm New Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                dgvCart.Rows.Clear() ' ✅ Clear cart

                ' ✅ Reset text fields
                txtamount.Text = "0.00"
                txtpayment.Text = "0.00"
                txtchange.Text = "0.00"

            Else
                Exit Sub ' ✅ Stop execution if user selects "No"
            End If
        End If

        ' ✅ Generate a new 12-digit transaction number
        Dim newTransactionNo As String = GenerateTransactionNumber()
        lbltransaction.Text = newTransactionNo
    End Sub

    Private Function GenerateTransactionNumber() As String
        ' Generate a unique transaction number (example: current date + random number)
        Dim random As New Random()
        Dim transactionNo As String = DateTime.Now.ToString("yyyyMMdd") & random.Next(1000, 9999)
        Return transactionNo
    End Function

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged


        If cmbCategory.SelectedIndex >= 0 Then ' Ensure a valid selection
            LoadProductsByCategory() ' No need to pass arguments
        Else
            ' Reset the products ComboBox if no category is selected
            cmbProducts.Items.Clear()
            cmbProducts.Items.Add("-- Select Product --")
            cmbProducts.SelectedIndex = 0
        End If
    End Sub

    Sub LoadProductsByCategory()
        Try
            ' Check if a category is selected
            If cmbCategory.SelectedItem Is Nothing Then Exit Sub

            ' Open connection if closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get products based on selected category
            Dim query As String = "SELECT productname FROM tblproducts WHERE pcategory = @category"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString())
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing items
            cmbProducts.Items.Clear()

            ' Read and add products to ComboBox
            While reader.Read()
                cmbProducts.Items.Add(reader("productname").ToString())
            End While

            ' Close reader
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducts.SelectedIndexChanged

        If cmbProducts.SelectedIndex > 0 Then
            ' Display the selected product in the ComboBox
            cmbProducts.Text = cmbProducts.SelectedItem.ToString()
        End If
    End Sub

    Private Sub btnaddtocart_Click(sender As Object, e As EventArgs) Handles btnaddtocart.Click


        If String.IsNullOrWhiteSpace(lbltransaction.Text) OrElse Not IsNumeric(lbltransaction.Text) Then
            MessageBox.Show("Please generate a valid transaction number first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Stop execution
        End If

        ' ✅ Ensure category is selected
        If cmbCategory.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(cmbCategory.Text) Then
            MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Ensure product is selected
        If cmbProducts.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(cmbProducts.Text) Then
            MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Ensure quantity is greater than 0
        Dim quantity As Integer = CInt(numquantity.Text) ' Using Guna NumericUpDown's Value property
        If quantity <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Stock Validation Before Adding to Cart
        Dim availableStock As Integer = 0
        Dim productName As String = cmbProducts.Text

        Try
            Using conn As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")
                conn.Open()

                ' Query to get the current stock
                Dim stockQuery As String = "SELECT stock FROM tblproducts WHERE productname = @product_name"
                Using cmdStock As New MySqlCommand(stockQuery, conn)
                    cmdStock.Parameters.AddWithValue("@product_name", productName)
                    Dim result As Object = cmdStock.ExecuteScalar()

                    ' If stock exists, store it as an integer
                    If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), availableStock) Then
                        ' ✅ If requested quantity is more than available stock, show error and stop
                        If quantity > availableStock Then
                            MessageBox.Show($"Not enough stock available for {productName}. Current stock: {availableStock}.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub ' Stop execution before adding to dgvCart
                        End If
                    Else
                        MessageBox.Show("Error retrieving stock information!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ' ✅ Retrieve product price from tblproducts
        Dim productPrice As Decimal = GetProductPrice(cmbProducts.SelectedItem.ToString())

        ' ✅ Calculate total price
        Dim total As Decimal = quantity * productPrice

        ' ✅ Ensure DataGridView has proper columns before adding rows
        If dgvCart.ColumnCount = 0 Then
            dgvCart.Columns.Add("TransactionNo", "Transaction No")
            dgvCart.Columns.Add("Product", "product")
            dgvCart.Columns.Add("Category", "category")
            dgvCart.Columns.Add("Price", "price")
            dgvCart.Columns.Add("Total", "Total")
        End If

        ' ✅ Add row to dgvCart (Only if stock validation passed)
        dgvCart.Rows.Add(lbltransaction.Text.Trim(), cmbProducts.SelectedItem.ToString(), cmbCategory.SelectedItem.ToString(), productPrice, quantity, total)
        UpdateTotalAmount()

        ' ✅ Reset numeric updown to 1 (default)
        numquantity.Text = 0
    End Sub

    Private Function GetProductPrice(productName As String) As Decimal
        Dim price As Decimal = 0
        Try
            ' Ensure the connection is open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get price from tblproducts
            Dim query As String = "SELECT price FROM tblproducts WHERE productname = @productName"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@productName", productName)

            ' Execute the query
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                price = Convert.ToDecimal(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching product price: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection after use
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        Return price
    End Function

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick

    End Sub
    Private Sub UpdateTotalAmount()
        Dim totalAmount As Decimal = 0

        ' Loop through all rows in dgvCart and sum up the "Total" column
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then ' Ensure it's not the new row placeholder
                totalAmount += Convert.ToDecimal(row.Cells("Total").Value)
            End If
        Next

        ' Display the total amount in lblAmount
        txtamount.Text = totalAmount.ToString("N2") ' Format to 2 decimal places
    End Sub

    Private Sub pnlInvoice_Paint(sender As Object, e As PaintEventArgs) Handles pnlInvoice.Paint

    End Sub

    Private Sub CalculateChange()
        Dim totalAmount As Decimal
        Dim paymentAmount As Decimal

        ' Ensure txtAmount contains a valid number
        If Not Decimal.TryParse(txtamount.Text, totalAmount) Then
            totalAmount = 0
        End If

        ' Ensure txtPayment contains a valid number
        If Not Decimal.TryParse(txtpayment.Text, paymentAmount) Then
            txtpayment.Text = "0.00"
            txtpayment.SelectAll()
            Return
        End If

        ' Prevent payment from being lower than total amount
        If paymentAmount < totalAmount Then
            MessageBox.Show("Payment cannot be lower than the total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpayment.Text = "0.00"
            txtpayment.SelectAll()
            Return
        End If

        ' Calculate change
        Dim changeAmount As Decimal = paymentAmount - totalAmount
        txtchange.Text = changeAmount.ToString("N2")
    End Sub

    Private Sub txtpayment_TextChanged(sender As Object, e As EventArgs) Handles txtpayment.TextChanged
        RemoveHandler txtpayment.TextChanged, AddressOf txtpayment_TextChanged

        Dim validText As String = ""
        Dim decimalCount As Integer = 0

        ' ✅ Check each character in the textbox
        For Each c As Char In txtpayment.Text
            If Char.IsDigit(c) Then
                validText &= c ' ✅ Allow digits
            ElseIf c = "."c AndAlso decimalCount = 0 Then
                validText &= c ' ✅ Allow only one decimal point
                decimalCount += 1
            End If
        Next

        ' ✅ Update text only if necessary
        If txtpayment.Text <> validText Then
            txtpayment.Text = validText
            txtpayment.SelectionStart = txtpayment.Text.Length ' ✅ Keep cursor at end
        End If

        ' ✅ Reattach event handler
        AddHandler txtpayment.TextChanged, AddressOf txtpayment_TextChanged
    End Sub


    Private Sub txtpayment_Leave(sender As Object, e As EventArgs) Handles txtpayment.Leave
        CalculateChange()
    End Sub



    Private Sub btntramsaction_Click(sender As Object, e As EventArgs) Handles btntramsaction.Click
        If String.IsNullOrWhiteSpace(lbltransaction.Text) OrElse Not IsNumeric(lbltransaction.Text) Then
            MessageBox.Show("Please generate a transaction number before proceeding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure the cart has items
        If dgvCart.Rows.Count = 0 Then
            MessageBox.Show("No items in the cart to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure payment is valid
        Dim totalAmount, paymentAmount, changeAmount As Decimal

        If Not Decimal.TryParse(txtamount.Text, totalAmount) Then
            MessageBox.Show("Invalid total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Decimal.TryParse(txtpayment.Text, paymentAmount) Then
            MessageBox.Show("Invalid payment amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Decimal.TryParse(txtchange.Text, changeAmount) Then
            MessageBox.Show("Invalid change amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if payment is less than the total amount
        If paymentAmount < totalAmount Then
            MessageBox.Show("Payment cannot be lower than the total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Database query for inserting into tblsales
        Dim insertQuery As String = "INSERT INTO tblsales (transaction_no, product_name, category, price, quantity, total, amount, payment, transac_change, date) 
                             VALUES (@transaction_no, @product_name, @category, @price, @quantity, @total, @amount, @payment, @change, @transac_date)"

        ' Database query for updating stock in tblproducts
        Dim updateStockQuery As String = "UPDATE tblproducts SET stock = stock - @quantity WHERE productname = @product_name"

        Try
            Using conn As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")
                conn.Open()

                ' ✅ Use Transaction to ensure all queries succeed together
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Loop through each row in dgvCart
                        For Each row As DataGridViewRow In dgvCart.Rows
                            If Not row.IsNewRow Then ' Skip empty row
                                Dim productName As String = row.Cells("product").Value.ToString()
                                Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value) ' Get actual quantity per row

                                ' ✅ Step 1: Insert sale into tblsales
                                Using cmdInsert As New MySqlCommand(insertQuery, conn, transaction)
                                    cmdInsert.Parameters.AddWithValue("@transaction_no", lbltransaction.Text)
                                    cmdInsert.Parameters.AddWithValue("@product_name", productName)
                                    cmdInsert.Parameters.AddWithValue("@category", row.Cells("Category").Value.ToString())
                                    cmdInsert.Parameters.AddWithValue("@price", row.Cells("price").Value.ToString())
                                    cmdInsert.Parameters.AddWithValue("@quantity", quantity)
                                    cmdInsert.Parameters.AddWithValue("@total", Convert.ToDecimal(row.Cells("Total").Value))
                                    cmdInsert.Parameters.AddWithValue("@amount", totalAmount)
                                    cmdInsert.Parameters.AddWithValue("@payment", paymentAmount)
                                    cmdInsert.Parameters.AddWithValue("@change", changeAmount)
                                    cmdInsert.Parameters.AddWithValue("@transac_date", Date.Now) ' ✅ Insert Current Date
                                    cmdInsert.ExecuteNonQuery()
                                End Using

                                ' ✅ Step 2: Update product stock in tblproducts
                                Using cmdUpdateStock As New MySqlCommand(updateStockQuery, conn, transaction)
                                    cmdUpdateStock.Parameters.AddWithValue("@quantity", quantity)
                                    cmdUpdateStock.Parameters.AddWithValue("@product_name", productName)
                                    cmdUpdateStock.ExecuteNonQuery()
                                End Using
                            End If
                        Next

                        ' ✅ Commit transaction if everything is successful
                        transaction.Commit()

                        MessageBox.Show("Transaction completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' ✅ Clear Cart and Reset Fields
                        dgvCart.Rows.Clear()
                        txtamount.Text = "0.00"
                        txtpayment.Text = "0.00"
                        txtchange.Text = "0.00"
                        lbltransaction.Text = ""
                        cmbCategory.SelectedIndex = -1
                        cmbProducts.SelectedIndex = -1 ' Reset transaction number
                        Dim newTransactionNo As String = GenerateTransactionNumber()
                        lbltransaction.Text = newTransactionNo

                    Catch ex As Exception
                        ' ✅ Rollback transaction if any error occurs
                        transaction.Rollback()
                        MessageBox.Show("Transaction failed! Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

            ' Refresh product list after update
            LoadProducts()

        Catch ex As Exception
            MessageBox.Show("Error processing transaction: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtpayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True ' Block other characters
        ElseIf e.KeyChar = "."c AndAlso txtpayment.Text.Contains(".") Then
            e.Handled = True ' Block multiple decimals
        End If

        ' Check if the cart (your DataGridView) is empty
        If dgvCart.Rows.Count = 0 Then
            ' Cancel typing
            e.Handled = True
            ' Optional: show a message
            MessageBox.Show("Cart is empty. Please add an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtpayment_LostFocus(sender As Object, e As EventArgs) Handles txtpayment.LostFocus

    End Sub

    Private Sub txtpayment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpayment.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevents the default beep sound
            CalculateChange()
        End If
    End Sub



    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Check if the clicked column is the "Action" button
            If dgvProducts.Columns(e.ColumnIndex).Name = "Action" Then
                ' Retrieve selected row
                Dim selectedRow As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

                ' Safely get values from the row
                Dim productCategory As String = If(selectedRow.Cells("pcategory").Value?.ToString(), "")
                Dim productName As String = If(selectedRow.Cells("productname").Value?.ToString(), "")

                ' Ensure values are not empty
                If Not String.IsNullOrEmpty(productCategory) AndAlso Not String.IsNullOrEmpty(productName) Then
                    ' Set values to ComboBoxes
                    cmbCategory.Text = productCategory
                    cmbProducts.Text = productName

                    ' Hide DataGridView after selection
                    dgvProducts.Visible = False
                    dgvProducts.SendToBack()
                Else
                    MessageBox.Show("Selected row contains empty values. Please check the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        If dgvProducts.Visible = False Then
            ' Load products and show dgvProducts on the first click
            LoadProducts()
            dgvProducts.BringToFront()
            dgvProducts.Visible = True

            dgvCart.Visible = False
            dgvCart.SendToBack()

            btnbrowse.Text = "Close"
        Else
            ' Hide dgvProducts and bring back dgvCart on the second click
            dgvProducts.Visible = False
            dgvProducts.SendToBack()

            dgvCart.Visible = True
            dgvCart.BringToFront()

            btnbrowse.Text = "[F2] Browse Product"
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub numquantity_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtchange_TextChanged(sender As Object, e As EventArgs) Handles txtchange.TextChanged

    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub lbltransaction_Click(sender As Object, e As EventArgs) Handles lbltransaction.Click

    End Sub

    Private Sub lbltransaction_no_Click(sender As Object, e As EventArgs) Handles lbltransaction_no.Click

    End Sub

    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lbl.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Sales_History.Show()

    End Sub

    Private Sub btnremovefromcart_Click(sender As Object, e As EventArgs) Handles btnremovefromcart.Click
        If dgvCart.SelectedRows.Count > 0 Then
            ' Get the total price of the selected row
            Dim selectedRow As DataGridViewRow = dgvCart.SelectedRows(0)

            ' Ensure the "Total" column exists and contains a valid number
            Dim rowTotal As Decimal = 0
            If Decimal.TryParse(selectedRow.Cells("total").Value.ToString(), rowTotal) Then
                ' Subtract the row's total price from txtamount
                Dim currentAmount As Decimal = 0
                Decimal.TryParse(txtamount.Text, currentAmount)
                currentAmount -= rowTotal

                ' Update txtamount with the new amount
                txtamount.Text = currentAmount.ToString("0.00")
            End If

            ' Remove the selected row from the DataGridView
            dgvCart.Rows.Remove(selectedRow)
        Else
            MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub sales_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout

    End Sub

    Private Sub sales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnmembership.PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            btnbrowse.PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            btntramsaction.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            btnremovefromcart.PerformClick()
        End If
    End Sub

    Private Sub numquantity_TextChanged(sender As Object, e As EventArgs) Handles numquantity.TextChanged
        If numquantity.Text <> "" Then
            Dim quantity As Integer
            If Integer.TryParse(numquantity.Text, quantity) Then
                If quantity > 999 Then

                    numquantity.Text = "999"
                    numquantity.SelectionStart = numquantity.Text.Length ' Keep cursor at end
                End If
            Else
                numquantity.Text = "" ' Reset invalid numeric value
            End If
        End If
    End Sub

    Private Sub numquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numquantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block the character

        End If

    End Sub

End Class