Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Sales_History
    Dim connection As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")
    Private Sub Sales_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadProductsByCategory("All") ' Load all products initially
        LoadSalesHistory("All", "All")
        LoadTransactionNumbers()
        LoadTimeFilters()
    End Sub

    Private Sub LoadSalesHistory(Optional ByVal category As String = "All", Optional ByVal product As String = "All")
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()

            Dim query As String = "SELECT transaction_no, product_name, category, price, quantity, total, amount, payment, transac_change, date FROM tblsales"
            Dim whereClause As New List(Of String)
            Dim cmd As New MySqlCommand()

            If category <> "All" Then
                whereClause.Add("category = @category")
                cmd.Parameters.AddWithValue("@category", category)
            End If

            If product <> "All" Then
                whereClause.Add("product_name = @product")
                cmd.Parameters.AddWithValue("@product", product)
            End If

            If whereClause.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereClause)
            End If

            cmd.CommandText = query
            cmd.Connection = connection

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                dgvSalesHistory.Rows.Clear()
                While dr.Read()
                    dgvSalesHistory.Rows.Add(
                        dr("transaction_no").ToString(),
                        dr("product_name").ToString(),
                        dr("category").ToString(),
                        dr("price").ToString(),
                        dr("quantity").ToString(),
                        dr("total").ToString(),
                        dr("amount").ToString(),
                        dr("payment").ToString(),
                        dr("transac_change").ToString(),
                        Convert.ToDateTime(dr("date")).ToString("yyyy-MM-dd")
                    )
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
        UpdateRecordCount()
        CalculateTotalQuantitySold()
    End Sub


    Private Sub LoadCategories()
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()
            Dim query As String = "SELECT DISTINCT pcategory FROM tblproducts"
            Using cmd As New MySqlCommand(query, connection)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    cmBCategory.Items.Clear()
                    cmBCategory.Items.Add("All") ' Default option to show all categories
                    While dr.Read()
                        cmBCategory.Items.Add(dr("pcategory").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    Private Sub LoadProductsByCategory(category As String)
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()

            Dim query As String = "SELECT productname FROM tblproducts"
            If category <> "All" Then
                query &= " WHERE pcategory = @category"
            End If

            Using cmd As New MySqlCommand(query, connection)
                If category <> "All" Then cmd.Parameters.AddWithValue("@category", category)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    cmbproducts.Items.Clear()
                    cmbproducts.Items.Add("All") ' Default option to show all products
                    While dr.Read()
                        cmbproducts.Items.Add(dr("productname").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    Private Sub cmbproducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproducts.SelectedIndexChanged
        Dim selectedCategory As String = cmBCategory.SelectedItem.ToString()
        Dim selectedProduct As String = cmbproducts.SelectedItem.ToString()
        LoadSalesHistory(selectedCategory, selectedProduct) ' Filter by category & product
    End Sub


    Private Sub cmBCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmBCategory.SelectedIndexChanged
        Dim selectedCategory As String = cmBCategory.SelectedItem.ToString()
        LoadProductsByCategory(selectedCategory)
        LoadSalesHistory(selectedCategory, "All") ' Filter sales based on category
    End Sub

    Private Sub FilterSalesByDate()
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()

            ' Base query
            Dim query As String = "SELECT transaction_no, product_name, category, price,  quantity, total, amount, payment, transac_change, date FROM tblsales"
            Dim whereClause As New List(Of String)
            Dim cmd As New MySqlCommand()

            ' Apply date filter
            Dim fromDate As Date = dtpfrom.Value
            Dim toDate As Date = dtpto.Value

            whereClause.Add("date BETWEEN @fromDate AND @toDate")
            cmd.Parameters.AddWithValue("@fromDate", fromDate.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@toDate", toDate.ToString("yyyy-MM-dd"))

            ' Append WHERE conditions
            If whereClause.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereClause)
            End If

            cmd.CommandText = query
            cmd.Connection = connection

            ' Execute query and update DataGridView
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                dgvSalesHistory.Rows.Clear()
                While dr.Read()
                    dgvSalesHistory.Rows.Add(
                        dr("transaction_no").ToString(),
                        dr("product_name").ToString(),
                        dr("category").ToString(),
                         dr("price").ToString(),
                        dr("quantity").ToString(),
                        dr("total").ToString(),
                        dr("amount").ToString(),
                        dr("payment").ToString(),
                        dr("transac_change").ToString(),
                        Convert.ToDateTime(dr("date")).ToString("yyyy-MM-dd")
                    )
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering sales history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
        UpdateRecordCount()
        CalculateTotalQuantitySold()
    End Sub

    Private Sub dtpfrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpfrom.ValueChanged

        dtpto.MinDate = dtpfrom.Value.Date
    End Sub

    Private Sub LoadTransactionNumbers()
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()

            Dim query As String = "SELECT DISTINCT transaction_no FROM tblsales"
            Using cmd As New MySqlCommand(query, connection)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    cmbTransaction.Items.Clear()
                    cmbTransaction.Items.Add("All") ' Default option to show all transactions
                    While dr.Read()
                        cmbTransaction.Items.Add(dr("transaction_no").ToString())
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading transaction numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    ' ✅ Filter dgvSalesHistory based on selected transaction number
    Private Sub FilterSalesByTransactionNumber()
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()

            Dim query As String = "SELECT transaction_no, product_name, category, price, quantity, total, amount, payment, transac_change, date FROM tblsales"
            Dim whereClause As New List(Of String)
            Dim cmd As New MySqlCommand()

            ' Get selected transaction number
            Dim selectedTransaction As String = cmbTransaction.SelectedItem.ToString()
            If selectedTransaction <> "All" Then
                whereClause.Add("transaction_no = @transactionNo")
                cmd.Parameters.AddWithValue("@transactionNo", selectedTransaction)
            End If

            ' Append WHERE conditions
            If whereClause.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereClause)
            End If

            cmd.CommandText = query
            cmd.Connection = connection

            ' Execute query and update DataGridView
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                dgvSalesHistory.Rows.Clear()
                While dr.Read()
                    dgvSalesHistory.Rows.Add(
                    dr("transaction_no").ToString(),
                    dr("product_name").ToString(),
                    dr("category").ToString(),
                      dr("price").ToString(),
                    dr("quantity").ToString(),
                    dr("total").ToString(),
                    dr("amount").ToString(),
                    dr("payment").ToString(),
                    dr("transac_change").ToString(),
                    Convert.ToDateTime(dr("date")).ToString("yyyy-MM-dd")
                )
                End While
                CalculateTotalQuantitySold()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering sales history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try

    End Sub

    Private Sub cmbTransaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTransaction.SelectedIndexChanged

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If cmbTransaction.SelectedIndex = -1 OrElse String.IsNullOrEmpty(cmbTransaction.Text) Then
            MessageBox.Show("Please select a transaction number first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            FilterSalesByTransactionNumber()

            UpdateRecordCount()

        End If
    End Sub

    Private Sub LoadTimeFilters()
        cmbtime.Items.Clear()

        cmbtime.Items.Add("All") ' Default option to show all transactions
        cmbtime.Items.Add("Daily")
        cmbtime.Items.Add("Weekly")
        cmbtime.Items.Add("Monthly")
        cmbtime.SelectedIndex = 0 ' Set default selection to "All"
    End Sub

    ' ✅ Filter dgvSalesHistory based on selected time range
    Private Sub FilterSalesByTime()
        Try
            If connection.State = ConnectionState.Closed Then connection.Open()

            Dim query As String = "SELECT transaction_no, product_name, category, price, quantity, total, amount, payment, transac_change, date FROM tblsales"
            Dim whereClause As New List(Of String)
            Dim cmd As New MySqlCommand()

            ' Get selected time filter
            Dim selectedTime As String = cmbtime.SelectedItem.ToString()

            Select Case selectedTime
                Case "Daily"
                    whereClause.Add("DATE(date) = CURDATE()")
                Case "Weekly"
                    whereClause.Add("YEARWEEK(date, 1) = YEARWEEK(CURDATE(), 1)") ' Week starts on Monday
                Case "Monthly"
                    whereClause.Add("MONTH(date) = MONTH(CURDATE()) AND YEAR(date) = YEAR(CURDATE())")
            End Select

            ' Apply product filter if selected
            Dim selectedProduct As String = If(cmbproducts.SelectedItem IsNot Nothing, cmbproducts.SelectedItem.ToString(), "All")
            If selectedProduct <> "All" Then
                whereClause.Add("product_name = @product")
                cmd.Parameters.AddWithValue("@product", selectedProduct)
            End If

            ' Append WHERE conditions
            If whereClause.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereClause)
            End If

            cmd.CommandText = query
            cmd.Connection = connection

            ' Execute query and update DataGridView
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                dgvSalesHistory.Rows.Clear()
                While dr.Read()
                    dgvSalesHistory.Rows.Add(
                        dr("transaction_no").ToString(),
                        dr("product_name").ToString(),
                        dr("category").ToString(),
                          dr("price").ToString(),
                        dr("quantity").ToString(),
                        dr("total").ToString(),
                        dr("amount").ToString(),
                        dr("payment").ToString(),
                        dr("transac_change").ToString(),
                        Convert.ToDateTime(dr("date")).ToString("yyyy-MM-dd")
                    )
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering sales history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
        UpdateRecordCount()
        CalculateTotalQuantitySold()
    End Sub

    Private Sub cmbtime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtime.SelectedIndexChanged
        FilterSalesByTime()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        If dgvSalesHistory.RowCount = 0 Then
            MessageBox.Show("No sales records available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using workbook As New XLWorkbook()
                Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Sales History")

                ' BIG TITLE at the top
                worksheet.Range("A1:J1").Merge()
                worksheet.Cell("A1").Value = "GYMXFIT SALES HISTORY REPORT"
                worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                worksheet.Cell("A1").Style.Font.Bold = True
                worksheet.Cell("A1").Style.Font.FontSize = 16
                worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                ' Write Date Range
                Dim dateRange As String = "Report From: " & dtpfrom.Value.ToShortDateString() & " - " & dtpto.Value.ToShortDateString()
                worksheet.Range("A2:J2").Merge()
                worksheet.Cell("A2").Value = dateRange
                worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                worksheet.Cell("A2").Style.Font.Italic = True
                worksheet.Cell("A2").Style.Font.FontSize = 12
                worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                ' Write Filters (Category, Product, etc.)
                Dim rowPointer As Integer = 4 ' Start writing details at Row 4

                If Not String.IsNullOrWhiteSpace(cmBCategory.Text) AndAlso cmBCategory.Text <> "All" Then
                    worksheet.Cell(rowPointer, 1).Value = "Category:"
                    worksheet.Cell(rowPointer, 2).Value = cmBCategory.Text
                    rowPointer += 1
                End If

                If Not String.IsNullOrWhiteSpace(cmbproducts.Text) AndAlso cmbproducts.Text <> "All" Then
                    worksheet.Cell(rowPointer, 1).Value = "Product Name:"
                    worksheet.Cell(rowPointer, 2).Value = cmbproducts.Text
                    rowPointer += 1
                End If

                If Not String.IsNullOrWhiteSpace(cmbTransaction.Text) Then
                    worksheet.Cell(rowPointer, 1).Value = "Transaction No:"
                    worksheet.Cell(rowPointer, 2).Value = cmbTransaction.Text
                    rowPointer += 1
                End If

                If Not String.IsNullOrWhiteSpace(cmbtime.Text) AndAlso cmbtime.Text <> "All" Then
                    worksheet.Cell(rowPointer, 1).Value = "Time:"
                    worksheet.Cell(rowPointer, 2).Value = cmbtime.Text
                    rowPointer += 1
                End If

                If Not String.IsNullOrWhiteSpace(lblsold.Text) Then
                    worksheet.Cell(rowPointer, 1).Value = "Total Quantity Sold:"
                    worksheet.Cell(rowPointer, 2).Value = lblsold.Text
                    rowPointer += 1
                End If

                If Not String.IsNullOrWhiteSpace(lblsales.Text) Then
                    worksheet.Cell(rowPointer, 1).Value = "Total Sales:"
                    worksheet.Cell(rowPointer, 2).Value = lblsales.Text
                    rowPointer += 1
                End If

                ' Write Column Headers
                Dim headerRow As Integer = rowPointer + 2 ' Leave a gap after filters
                For colIndex As Integer = 0 To dgvSalesHistory.Columns.Count - 1
                    If dgvSalesHistory.Columns(colIndex).Visible Then
                        worksheet.Cell(headerRow, colIndex + 1).Value = dgvSalesHistory.Columns(colIndex).HeaderText
                        worksheet.Cell(headerRow, colIndex + 1).Style.Font.Bold = True
                        worksheet.Cell(headerRow, colIndex + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                    End If
                Next

                ' Write Data Rows
                Dim dataStartRow As Integer = headerRow + 1
                Dim totalSalesAmount As Decimal = 0
                Dim dataRow As Integer = dataStartRow

                For Each row As DataGridViewRow In dgvSalesHistory.Rows
                    If Not row.IsNewRow Then
                        Dim colIndex As Integer = 0
                        For Each cell As DataGridViewCell In row.Cells
                            If dgvSalesHistory.Columns(cell.ColumnIndex).Visible Then
                                Dim cellValue = cell.Value
                                If TypeOf cellValue Is Byte() Then
                                    worksheet.Cell(dataRow, colIndex + 1).Value = "[Image]"
                                Else
                                    worksheet.Cell(dataRow, colIndex + 1).Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                                End If

                                ' Sum up "Total" Column if exists
                                If dgvSalesHistory.Columns(cell.ColumnIndex).HeaderText = "Total" Then
                                    Dim temp As Decimal
                                    If Decimal.TryParse(cellValue?.ToString(), temp) Then
                                        totalSalesAmount += temp
                                    End If
                                End If

                                colIndex += 1
                            End If
                        Next
                        dataRow += 1
                    End If
                Next

                ' Write Grand Total at the bottom
                worksheet.Cell(dataRow, 1).Value = "Grand Total Sales:"
                worksheet.Cell(dataRow, 2).Value = totalSalesAmount.ToString("N2")
                worksheet.Cell(dataRow, 1).Style.Font.Bold = True

                ' AutoFit Columns
                worksheet.Columns().AdjustToContents()

                ' Save File Dialog
                Using sfd As New SaveFileDialog() With {.Filter = "Excel Files|*.xlsx", .Title = "Save Sales History Report", .FileName = "SalesHistory_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".xlsx"}
                    If sfd.ShowDialog() = DialogResult.OK Then
                        workbook.SaveAs(sfd.FileName)
                        MessageBox.Show("Report successfully exported to Excel.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Export failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    ' Add this method to calculate and display the record count
    Private Sub UpdateRecordCount()
        ' Set the record count to lblsales
        Dim totalAmount As Decimal = 0

        For Each row As DataGridViewRow In dgvSalesHistory.Rows
            If Not row.IsNewRow Then
                Dim value As Object = row.Cells("amount").Value
                If value IsNot Nothing AndAlso IsNumeric(value) Then
                    totalAmount += Convert.ToDecimal(value)
                End If
            End If
        Next

        lblsales.Text = "₱ " & totalAmount.ToString("N2")
    End Sub

    Private Sub dtpto_ValueChanged(sender As Object, e As EventArgs) Handles dtpto.ValueChanged

    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles filter.Click
        FilterSalesByDate()
        cmbtime.SelectedIndex = 0
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        cmbtime.SelectedIndex = -0
        cmbTransaction.SelectedIndex = -0
        cmBCategory.SelectedIndex = -0
        cmbproducts.SelectedIndex = 0

        ' Reset DateTimePickers to today's date
        dtpfrom.Value = Date.Today
        dtpto.Value = Date.Today


    End Sub

    Private Sub CalculateTotalQuantitySold()
        Dim totalQuantity As Integer = 0

        For Each row As DataGridViewRow In dgvSalesHistory.Rows
            If Not row.IsNewRow Then
                Dim value As Object = row.Cells("quantity").Value
                If value IsNot Nothing AndAlso IsNumeric(value) Then
                    totalQuantity += Convert.ToInt32(value)
                End If
            End If
        Next

        lblsold.Text = totalQuantity.ToString()
    End Sub

    Private Sub lblsales_Click(sender As Object, e As EventArgs) Handles lblsales.Click

    End Sub

    Private Sub dgvSalesHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesHistory.CellContentClick

    End Sub

    Private Sub lblsold_Click(sender As Object, e As EventArgs) Handles lblsold.Click

    End Sub
End Class