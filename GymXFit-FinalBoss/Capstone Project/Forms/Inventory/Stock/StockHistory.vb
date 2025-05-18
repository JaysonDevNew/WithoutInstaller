Imports Mysqlx
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Data.Common
Imports ClosedXML.Excel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class StockHistory
    Private Sub stockhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStockEntries()
        LoadReferenceNumbers()
        dgvStockHistory.Rows.Clear()
        UpdateRecordCount()
    End Sub
    Dim connection As New MySqlConnection("Server=localhost;Database=gymxfit_database;Uid=root;Pwd=;")

    Private Sub LoadStockEntries()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, reference_no, received_by, date_received, product_id, product_name, brand_name, product_category, price, current_stock, added_stock FROM tblstockentry ORDER BY date_received DESC"
            Using cmd As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                dgvStockHistory.Rows.Clear() ' Clear previous data

                While reader.Read()
                    dgvStockHistory.Rows.Add(
                    reader("ID"),
                    reader("reference_no"),
                    reader("received_by"),
                    Convert.ToDateTime(reader("date_received")).ToString("yyyy-MM-dd"),
                    reader("product_id"),
                    reader("product_name"),
                    reader("brand_name"),
                    reader("product_category"),
                    Convert.ToDecimal(reader("price")),
                    Convert.ToInt32(reader("current_stock")),
                    Convert.ToInt32(reader("added_stock"))
                )
                End While

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading stock entries: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        UpdateRecordCount()
    End Sub

    Private Sub LoadReferenceNumbers()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT DISTINCT reference_no FROM tblstockentry ORDER BY reference_no ASC"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            cmbReferenceNo.Items.Clear()
            cmbReferenceNo.Items.Add("-- Select Reference No --") ' Default option

            While reader.Read()
                cmbReferenceNo.Items.Add(reader("reference_no").ToString())
            End While

            reader.Close()
            cmbReferenceNo.SelectedIndex = 0 ' Set default selection
        Catch ex As Exception
            MessageBox.Show("Error loading reference numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub cmbReferenceNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReferenceNo.SelectedIndexChanged

    End Sub

    Private Sub FilterStockHistory(referenceNo As String)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, reference_no, received_by, date_received, product_id, product_name, brand_name, product_category, price, current_stock, added_stock FROM tblstockentry WHERE reference_no = @referenceNo"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@referenceNo", referenceNo)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                dgvStockHistory.Rows.Clear() ' Clear existing data

                While reader.Read()
                    dgvStockHistory.Rows.Add(
                    reader("id"),
                    reader("reference_no"),
                    reader("received_by"),
                    Convert.ToDateTime(reader("date_received")).ToString("yyyy-MM-dd"),
                    reader("product_id"),
                    reader("product_name"),
                    reader("brand_name"),
                    reader("product_category"),
                    Convert.ToDecimal(reader("price")),
                    Convert.ToInt32(reader("current_stock")),
                    Convert.ToInt32(reader("added_stock"))
                )
                End While

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering stock history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If cmbReferenceNo.SelectedIndex > 0 Then ' Ensure a valid selection
            FilterStockHistory(cmbReferenceNo.Text)
        Else
            MessageBox.Show("Please select a Reference No before filtering.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        UpdateRecordCount()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FilterByDateRange()
        Try
            If dtpdateto.Value < dtpdatefrom.Value Then
                MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Get selected dates from DateTimePickers
            Dim dateFrom As String = dtpdatefrom.Value.ToString("yyyy-MM-dd")
            Dim dateTo As String = dtpdateto.Value.ToString("yyyy-MM-dd")

            ' Query to filter records based on date range
            Dim query As String = "SELECT id, reference_no, received_by, date_received, product_id, product_name, brand_name, product_category, price, current_stock, added_stock 
                           FROM tblstockentry 
                           WHERE DATE(date_received) BETWEEN @dateFrom AND @dateTo 
                           ORDER BY date_received DESC"

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@dateFrom", dateFrom)
            cmd.Parameters.AddWithValue("@dateTo", dateTo)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Clear existing rows
            dgvStockHistory.Rows.Clear()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Add filtered data to DataGridView manually
                For Each row As DataRow In dt.Rows
                    dgvStockHistory.Rows.Add(row("id"),
                                 row("reference_no"),
                                 row("received_by"),
                                 Convert.ToDateTime(row("date_received")).ToString("yyyy-MM-dd"), ' Show Date only
                                 row("product_id"),
                                 row("product_name"),
                                 row("brand_name"),
                                 row("product_category"),
                                 row("price"),
                                 row("current_stock"),
                                 row("added_stock"))
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("Error filtering stock history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        UpdateRecordCount()
    End Sub

    Private Sub dtpdateto_ValueChanged(sender As Object, e As EventArgs) Handles dtpdateto.ValueChanged

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
        StockAdjustmentHistory.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        StockEntry.Show()
        Me.Close()
    End Sub

    Private Sub UpdateRecordCount()
        ' Set the record count to lblsales
        lblstock.Text = dgvStockHistory.Rows.Count.ToString()
    End Sub

    Private Sub dgvStockHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockHistory.CellContentClick

    End Sub


    Private Sub btnStockHistoryExport_Click(sender As Object, e As EventArgs) Handles btnStockHistoryExport.Click
        Try
            ' Check if DataGridView is empty
            If dgvStockHistory.RowCount = 0 Then
                MessageBox.Show("There are no records to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using workbook As New XLWorkbook()
                            Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Stock History")
                            Dim totalRecords As Integer = 0

                            ' Calculate the last visible column index
                            Dim lastColumnIndex As Integer = dgvStockHistory.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).Count()

                            ' Add a title at the top (Row 1) - Merge title up to last data column
                            worksheet.Range("A1:" & XLHelper.GetColumnLetterFromNumber(lastColumnIndex) & "1").Merge()
                            worksheet.Cell("A1").Value = "STOCK HISTORY RECORDS"
                            worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                            worksheet.Cell("A1").Style.Font.Bold = True
                            worksheet.Cell("A1").Style.Font.FontSize = 16
                            worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                            worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                            ' Add selected date range (Row 2) - Merge date range up to last data column
                            Dim dateRange As String = "Date Range: " & dtpdatefrom.Value.ToString("MMMM dd, yyyy") & " - " & dtpdateto.Value.ToString("MMMM dd, yyyy")
                            worksheet.Range("A2:" & XLHelper.GetColumnLetterFromNumber(lastColumnIndex) & "2").Merge()
                            worksheet.Cell("A2").Value = dateRange
                            worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                            worksheet.Cell("A2").Style.Font.Italic = True
                            worksheet.Cell("A2").Style.Font.FontSize = 12
                            worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                            ' Add headers (row 3)
                            Dim colIndex As Integer = 1
                            For Each column As DataGridViewColumn In dgvStockHistory.Columns
                                If column.Visible Then
                                    worksheet.Cell(3, colIndex).Value = column.HeaderText
                                    worksheet.Cell(3, colIndex).Style.Font.Bold = True
                                    worksheet.Cell(3, colIndex).Style.Fill.BackgroundColor = XLColor.LightGray
                                    colIndex += 1
                                End If
                            Next

                            ' Add data rows (row 4 onward)
                            Dim rowIndex As Integer = 4
                            For Each row As DataGridViewRow In dgvStockHistory.Rows
                                If Not row.IsNewRow Then
                                    totalRecords += 1
                                    colIndex = 1
                                    For Each cell As DataGridViewCell In row.Cells
                                        If dgvStockHistory.Columns(cell.ColumnIndex).Visible Then
                                            worksheet.Cell(rowIndex, colIndex).Value = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                                        End If
                                        colIndex += 1
                                    Next
                                    rowIndex += 1
                                End If
                            Next

                            ' Write total records
                            worksheet.Cell(rowIndex + 1, 1).Value = "Total Records:"
                            worksheet.Cell(rowIndex + 1, 2).Value = totalRecords.ToString()
                            worksheet.Cell(rowIndex + 1, 1).Style.Font.Bold = True

                            ' Auto-fit columns
                            worksheet.Columns().AdjustToContents()

                            ' Save file
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
        FilterByDateRange()
    End Sub

    Private Sub TxtSeearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtSeearch_TextChanged_1(sender As Object, e As EventArgs) Handles TxtSeearch.TextChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT id, reference_no, received_by, date_received, product_id, product_name, brand_name, product_category, price, current_stock, added_stock " &
                          "FROM tblstockentry " &
                          "WHERE product_name LIKE @search OR brand_name LIKE @search OR reference_no LIKE @search " &
                          "ORDER BY date_received DESC"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@search", "%" & TxtSeearch.Text & "%") ' Pass the search text safely

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                dgvStockHistory.Rows.Clear() ' Clear previous data

                While reader.Read()
                    dgvStockHistory.Rows.Add(
                reader("ID"),
                reader("reference_no"),
                reader("received_by"),
                Convert.ToDateTime(reader("date_received")).ToString("yyyy-MM-dd"),
                reader("product_id"),
                reader("product_name"),
                reader("brand_name"),
                reader("product_category"),
                Convert.ToDecimal(reader("price")),
                Convert.ToInt32(reader("current_stock")),
                Convert.ToInt32(reader("added_stock"))
            )
                End While

                reader.Close()

                ' ✅ Update record count AFTER filling the DataGridView
                lblstock.Text = "Total Records: " & dgvStockHistory.Rows.Count.ToString()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading stock entries: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
End Class