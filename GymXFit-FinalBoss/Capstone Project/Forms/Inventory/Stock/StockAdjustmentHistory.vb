Imports Mysqlx
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Data.Common
Imports ClosedXML.Excel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class StockAdjustmentHistory
    Dim connection As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")
    Private Sub StockAdjustmentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadStockHistory()

    End Sub

    Private Sub LoadStockHistory()
        Try
            ' Ensure the connection is open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, brand_name, product_name, product_category, price, current_stock, adjusted_stock, adjusted_type, reason, adjusted_by, DATE_FORMAT(date_adjusted, '%Y-%m-%d') AS formatted_date FROM tblstockadjustment"

            Using cmd As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Check if columns are already added
                If dgvStockHistory.Columns.Count = 0 Then
                    ' Add columns programmatically
                    dgvStockHistory.Columns.Add("id", "ID")
                    dgvStockHistory.Columns.Add("brand_name", "Brand Name")
                    dgvStockHistory.Columns.Add("product_name", "Product Name")
                    dgvStockHistory.Columns.Add("product_category", "Category")
                    dgvStockHistory.Columns.Add("price", "Price")
                    dgvStockHistory.Columns.Add("current_stock", "Current Stock")
                    dgvStockHistory.Columns.Add("adjusted_stock", "Adjusted Stock")
                    dgvStockHistory.Columns.Add("adjusted_type", "Adjusted Type")
                    dgvStockHistory.Columns.Add("reason", "Reason")
                    dgvStockHistory.Columns.Add("adjusted_by", "Adjusted By")
                    dgvStockHistory.Columns.Add("formatted_date", "Date Adjusted")
                End If

                dgvStockHistory.Rows.Clear() ' Clear existing rows before loading

                While reader.Read()
                    ' Format the date to show only the date (not time)
                    Dim formattedDate As String = Convert.ToDateTime(reader("formatted_date")).ToString("yyyy-MM-dd")

                    dgvStockHistory.Rows.Add(
                        reader("id"),
                        reader("brand_name"),
                        reader("product_name"),
                        reader("product_category"),
                        reader("price"),
                        reader("current_stock"),
                        reader("adjusted_stock"),
                        reader("adjusted_type"),
                        reader("reason"),
                        reader("adjusted_by"),
                        formattedDate ' Add formatted date to the DataGridView
                    )
                End While

                reader.Close()
                UpdateStockCount()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub FilterStockHistoryByDate()
        Try
            If dtpto.Value < dtpFrom.Value Then
                MessageBox.Show("The 'To' date cannot be earlier than the 'From' date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim fromDate As String = dtpFrom.Value.ToString("yyyy-MM-dd")
            Dim toDate As String = dtpto.Value.ToString("yyyy-MM-dd")

            Dim query As String = "SELECT id, brand_name, product_name, product_category, price, current_stock, adjusted_stock, adjusted_type, reason, adjusted_by, date_adjusted 
                           FROM tblstockadjustment 
                           WHERE date_adjusted BETWEEN @fromDate AND @toDate"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@fromDate", fromDate)
                cmd.Parameters.AddWithValue("@toDate", toDate)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Check if columns are already added
                If dgvStockHistory.Columns.Count = 0 Then
                    dgvStockHistory.Columns.Add("id", "ID")
                    dgvStockHistory.Columns.Add("brand_name", "brand_name")
                    dgvStockHistory.Columns.Add("product_name", "product_name")
                    dgvStockHistory.Columns.Add("product_category", "product_category")
                    dgvStockHistory.Columns.Add("price", "price")
                    dgvStockHistory.Columns.Add("current_stock", "current_stock")
                    dgvStockHistory.Columns.Add("adjusted_stock", "adjusted_stock")
                    dgvStockHistory.Columns.Add("adjusted_type", "adjusted_type")
                    dgvStockHistory.Columns.Add("reason", "reason")
                    dgvStockHistory.Columns.Add("adjusted_by", "adjusted_by")
                    dgvStockHistory.Columns.Add("formatted_date", "adjusted_date")
                End If

                dgvStockHistory.Rows.Clear() ' Clear DataGridView before loading new data

                Dim hasData As Boolean = False
                While reader.Read()
                    dgvStockHistory.Rows.Add(
                    reader("id"),
                    reader("brand_name"),
                    reader("product_name"),
                    reader("product_category"),
                    reader("price"),
                    reader("current_stock"),
                    reader("adjusted_stock"),
                    reader("adjusted_type"),
                    reader("reason"),
                    reader("adjusted_by"),
                    Convert.ToDateTime(reader("date_adjusted")).ToString("yyyy-MM-dd") ' Format date only
    )
                    hasData = True
                End While
                reader.Close()

                If Not hasData Then
                    MessageBox.Show("No records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpto_ValueChanged(sender As Object, e As EventArgs) Handles dtpto.ValueChanged

    End Sub



    Private Sub FilterStockHistory()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim searchKeyword As String = TxtSeearch.Text.Trim()

            ' SQL query with search condition only (no date filtering)
            Dim query As String = "SELECT id, brand_name, product_name, product_category, price, current_stock, adjusted_stock, adjusted_type, reason, adjusted_by, 
                          DATE(date_adjusted) AS formatted_date 
                          FROM tblstockadjustment 
                          WHERE id LIKE @search 
                          OR brand_name LIKE @search 
                          OR product_name LIKE @search 
                          OR adjusted_by LIKE @search 
                          OR adjusted_type LIKE @search"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@search", "%" & searchKeyword & "%") ' Wildcards for partial matching

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                dgvStockHistory.Rows.Clear() ' Clear DataGridView before loading new data

                While reader.Read()
                    dgvStockHistory.Rows.Add(reader("id"),
                             reader("brand_name"),
                             reader("product_name"),
                             reader("product_category"),
                             reader("price"),
                             reader("current_stock"),
                             reader("adjusted_stock"),
                             reader("adjusted_type"),
                             reader("reason"),
                             reader("adjusted_by"),
                             Convert.ToDateTime(reader("formatted_date")).ToString("yyyy-MM-dd")) ' Date only
                End While
                reader.Close()
                UpdateStockCount()
            End Using
        Catch ex As Exception

        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub UpdateStockCount()
        Dim recordCount As Integer = dgvStockHistory.Rows.Count
        lblstock.Text = recordCount.ToString()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub lblstock_Click(sender As Object, e As EventArgs)
        StockEntry.Show()
        Me.Hide()
    End Sub

    Private Sub lblstockadjustment_Click(sender As Object, e As EventArgs)
        StockAdjustment.Show()
        Me.Hide()
    End Sub

    Private Sub lbladjustmenthistory_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblstockhistory_Click(sender As Object, e As EventArgs)
        StockHistory.Show()
        Me.Hide()
    End Sub

    Private Sub TxtSeearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSeearch.TextChanged
        FilterStockHistory()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        StockAdjustment.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnStockExport_Click(sender As Object, e As EventArgs) Handles btnStockExport.Click
        Try
            ' Check if DataGridView is empty
            If dgvStockHistory.RowCount = 0 OrElse dgvStockHistory.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then
                MessageBox.Show("No records found to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using workbook As New XLWorkbook()
                            Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Stock Adjustment")
                            Dim totalRecords As Integer = 0
                            Dim lastColumnIndex As Integer = dgvStockHistory.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).Count()

                            ' Add a title at the top (Row 1) - Merge title up to last data column
                            worksheet.Range("A1:" & XLHelper.GetColumnLetterFromNumber(lastColumnIndex) & "1").Merge()
                            worksheet.Cell("A1").Value = "STOCK ADJUSTMENT REPORT"
                            worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                            worksheet.Cell("A1").Style.Font.Bold = True
                            worksheet.Cell("A1").Style.Font.FontSize = 16
                            worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                            worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                            ' Add selected date range (Row 2) - Merge date range up to last data column
                            Dim dateRange As String = "Date Range: " & dtpFrom.Value.ToString("MMMM dd, yyyy") & " - " & dtpto.Value.ToString("MMMM dd, yyyy")
                            worksheet.Range("A2:" & XLHelper.GetColumnLetterFromNumber(lastColumnIndex) & "2").Merge()
                            worksheet.Cell("A2").Value = dateRange
                            worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                            worksheet.Cell("A2").Style.Font.Italic = True
                            worksheet.Cell("A2").Style.Font.FontSize = 12
                            worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                            ' Add headers (row 3)
                            Dim colIndex As Integer = 1
                            Dim idColumnIndex As Integer = -1
                            For Each column As DataGridViewColumn In dgvStockHistory.Columns
                                If column.Visible Then
                                    worksheet.Cell(3, colIndex).Value = column.HeaderText
                                    ' Track the "ID" column index for special formatting
                                    If column.HeaderText = "ID" Then
                                        idColumnIndex = colIndex
                                    End If
                                    colIndex += 1
                                End If
                            Next

                            ' Format ID column as text
                            If idColumnIndex > 0 Then
                                worksheet.Column(idColumnIndex).Style.NumberFormat.Format = "@"
                            End If

                            ' Add data rows (row 4 onward)
                            Dim rowIndex As Integer = 4
                            For Each row As DataGridViewRow In dgvStockHistory.Rows
                                If Not row.IsNewRow Then
                                    totalRecords += 1
                                    colIndex = 1
                                    For Each cell As DataGridViewCell In row.Cells
                                        If dgvStockHistory.Columns(cell.ColumnIndex).Visible Then
                                            Dim cellValue = cell.Value
                                            If TypeOf cellValue Is Byte() Then
                                                worksheet.Cell(rowIndex, colIndex).Value = "[Image]"
                                            Else
                                                If dgvStockHistory.Columns(cell.ColumnIndex).HeaderText = "ID" AndAlso cellValue IsNot Nothing Then
                                                    worksheet.Cell(rowIndex, colIndex).Value = "'" & cellValue.ToString()
                                                Else
                                                    worksheet.Cell(rowIndex, colIndex).Value = If(cellValue IsNot Nothing, cellValue.ToString(), "")
                                                End If
                                            End If
                                        End If
                                        colIndex += 1
                                    Next
                                    rowIndex += 1
                                End If
                            Next

                            ' Write Total Records
                            worksheet.Cell(rowIndex + 1, 1).Value = "Total Records:"
                            worksheet.Cell(rowIndex + 1, 2).Value = totalRecords.ToString()
                            worksheet.Cell(rowIndex + 1, 1).Style.Font.Bold = True

                            ' Auto-fit columns
                            worksheet.Columns().AdjustToContents()

                            ' Save the file
                            workbook.SaveAs(sfd.FileName)
                        End Using

                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error exporting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Export failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Make sure to include the ReleaseObject method if it's not already in this form
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

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        FilterStockHistoryByDate()

    End Sub
End Class