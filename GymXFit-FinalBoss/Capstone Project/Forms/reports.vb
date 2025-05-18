Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class reports

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles btnhistory.Click
        FilterLogsByDateRange()
    End Sub

    Private Sub btnloadpayment_Click(sender As Object, e As EventArgs) Handles btnloadpayment.Click
        FilterPaymentsByDateRange()
    End Sub

    Private Sub LoadPaymentData()
        Try
            ' Check if end date is earlier than start date
            If dttologs.Value.Date < dtfromlogs.Value.Date Then
                MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            openConn()
            dgvpayments.Rows.Clear()

            Dim recordFound As Boolean = False

            Using cmd As New MySqlCommand("SELECT * FROM tblpayment WHERE paymentdate BETWEEN @startDate AND @endDate", con)
                cmd.Parameters.AddWithValue("@startDate", dtfromlogs.Value.Date.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@endDate", dttologs.Value.Date.ToString("yyyy-MM-dd"))

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgvpayments.Rows.Add(dr.Item("rfid").ToString(),
                               dr.Item("transactionno").ToString(),
                               dr.Item("name").ToString(),
                               dr.Item("services").ToString(),
                               dr.Item("description").ToString(),
                               dr.Item("total").ToString(),
                               Convert.ToDateTime(dr.Item("paymentdate")).ToString("yyyy-MM-dd"),
                               Convert.ToDateTime(dr.Item("nextdue")).ToString("yyyy-MM-dd"),
                               dr.Item("paymenttype").ToString(),
                               dr.Item("referenceno").ToString())
                        recordFound = True
                    End While
                End Using
            End Using

            If Not recordFound Then
                MessageBox.Show("No records found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvpayments.Rows.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub FilterByDateRange()
        Try
            ' Check if date range is valid
            If dtpdatefrom.Value.Date > dtpdateto.Value.Date Then
                MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            openConn()
            dgvcancel.Rows.Clear()

            ' Ensure Revert button column is added once
            If dgvcancel.Columns("Revert") Is Nothing Then
                Dim btn As New DataGridViewButtonColumn()
                btn.Name = "Revert"
                btn.HeaderText = "Actions"
                btn.Text = "Revert"
                btn.UseColumnTextForButtonValue = True
                dgvcancel.Columns.Add(btn)
            End If

            ' Counter to store the number of filtered records
            Dim recordCount As Integer = 0

            ' SQL query with parameterized filtering
            Using cmd As New MySqlCommand("SELECT * FROM tblcancellation WHERE DATE(date) BETWEEN @startDate AND @endDate", con)
                cmd.Parameters.AddWithValue("@startDate", dtpdatefrom.Value.Date.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@endDate", dtpdateto.Value.Date.ToString("yyyy-MM-dd"))

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgvcancel.Rows.Add(dr.Item("rfid").ToString(),
                                   dr.Item("name").ToString(),
                                   dr.Item("address").ToString(),
                                   dr.Item("reason").ToString(),
                                   Convert.ToDateTime(dr.Item("date")).ToString("yyyy-MM-dd"),
                                   dr.Item("cancelby").ToString())

                        recordCount += 1
                    End While
                End Using
            End Using

            ' Show message if no records found
            If recordCount = 0 Then
                MessageBox.Show("No cancellation records found for the selected date range.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Display count of records
            lblnumberofcancel.Text = recordCount.ToString()

        Catch ex As Exception
            MessageBox.Show("Error filtering cancellation records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvcancel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcancel.CellContentClick
        If e.ColumnIndex = dgvcancel.Columns("Revert").Index AndAlso e.RowIndex >= 0 Then
            ' Get the RFID from the selected row
            Dim rfid As String = dgvcancel.Rows(e.RowIndex).Cells("rfid").Value.ToString()
            txtRFID.Text = rfid

            If MessageBox.Show("Revert this cancellation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    openConn()

                    ' STEP 1: Retrieve the RFID from txtRFID
                    Dim rfidFromTextbox As String = txtRFID.Text

                    ' STEP 2: Retrieve archived data based on RFID from tblarchived_members
                    Dim selectCmd As New MySqlCommand("SELECT * FROM tblarchived_members WHERE rfid = @rfid", con)
                    selectCmd.Parameters.AddWithValue("@rfid", rfidFromTextbox)
                    Dim reader As MySqlDataReader = selectCmd.ExecuteReader()

                    If reader.Read() Then
                        reader.Close() ' Close the reader before executing a new command

                        ' STEP 3: Re-execute the SELECT command to retrieve values again (since reader is forward-only)
                        selectCmd = New MySqlCommand("SELECT * FROM tblarchived_members WHERE rfid = @rfid", con)
                        selectCmd.Parameters.AddWithValue("@rfid", rfidFromTextbox)
                        reader = selectCmd.ExecuteReader()

                        If reader.Read() Then
                            ' STEP 4: Insert data back to tblmembers
                            Dim insertCmd As New MySqlCommand("INSERT INTO tblmembers 
                        (picture, rfid, first_name, middle_name, last_name, age, contact_no, address, gender, member_since, emergency_contact, status)
                        VALUES
                        (@picture, @rfid, @first_name, @middle_name, @last_name, @age, @contact_no, @address, @gender, @member_since, @emergency_contact, @status)", con)

                            insertCmd.Parameters.AddWithValue("@picture", reader("picture"))
                            insertCmd.Parameters.AddWithValue("@rfid", reader("rfid"))
                            insertCmd.Parameters.AddWithValue("@first_name", reader("first_name"))
                            insertCmd.Parameters.AddWithValue("@middle_name", reader("middle_name"))
                            insertCmd.Parameters.AddWithValue("@last_name", reader("last_name"))
                            insertCmd.Parameters.AddWithValue("@age", reader("age"))
                            insertCmd.Parameters.AddWithValue("@contact_no", reader("contact_no"))
                            insertCmd.Parameters.AddWithValue("@address", reader("address"))
                            insertCmd.Parameters.AddWithValue("@gender", reader("gender"))
                            insertCmd.Parameters.AddWithValue("@member_since", reader("member_since"))
                            insertCmd.Parameters.AddWithValue("@emergency_contact", reader("emergency_contact"))
                            insertCmd.Parameters.AddWithValue("@status", reader("status"))

                            reader.Close()
                            insertCmd.ExecuteNonQuery()

                            ' STEP 5: Delete from tblcancellation
                            Dim deleteCancelCmd As New MySqlCommand("DELETE FROM tblcancellation WHERE rfid = @rfid", con)
                            deleteCancelCmd.Parameters.AddWithValue("@rfid", rfidFromTextbox)
                            deleteCancelCmd.ExecuteNonQuery()

                            ' STEP 6: Delete from archive
                            Dim deleteArchiveCmd As New MySqlCommand("DELETE FROM tblarchived_members WHERE rfid = @rfid", con)
                            deleteArchiveCmd.Parameters.AddWithValue("@rfid", rfidFromTextbox)
                            deleteArchiveCmd.ExecuteNonQuery()

                            ' Remove from DataGridView
                            dgvcancel.Rows.RemoveAt(e.RowIndex)

                            MessageBox.Show("Membership reverted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            reader.Close()
                            MessageBox.Show("Failed to reload archived data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        reader.Close()
                        MessageBox.Show("Archived member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error reverting: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            End If
        End If

    End Sub




    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        FilterByDateRange()
    End Sub

    Private Sub PnlAttendance_Paint(sender As Object, e As PaintEventArgs) Handles PnlAttendance.Paint

    End Sub
    Private Sub FilterLogsByDateRange()
        Try
            openConn()
            dgvloghistory.Rows.Clear()

            Dim recordCount As Integer = 0

            Using cmd As New MySqlCommand("SELECT rfid, name AS fname, sdate, 
                                   Time_in, Time_out 
                            FROM tblloghistory 
                            WHERE DATE(sdate) BETWEEN @startDate AND @endDate 
                            ORDER BY sdate DESC", con)

                cmd.Parameters.AddWithValue("@startDate", dtfromlogs.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@endDate", dttologs.Value.ToString("yyyy-MM-dd"))

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        ' Validate Date
                        Dim formattedDate As String = If(IsDBNull(dr("sdate")), "-----", Convert.ToDateTime(dr("sdate")).ToString("yyyy-MM-dd"))

                        ' Validate Time In and Time Out
                        Dim timeIn As String = If(IsDBNull(dr("Time_in")) OrElse dr("Time_in").ToString() = "", "-----", dr("Time_in").ToString())
                        Dim timeOut As String = If(IsDBNull(dr("Time_out")) OrElse dr("Time_out").ToString() = "", "-----", dr("Time_out").ToString())

                        ' Add data to DataGridView
                        dgvloghistory.Rows.Add(
             dr("rfid").ToString(),
             dr("fname").ToString(),
             formattedDate,
             timeIn,
             timeOut
         )

                        recordCount += 1
                    End While
                End Using
            End Using
            If recordCount = 0 Then
                MessageBox.Show("No records found for the selected filters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            lblnumberoflogs.Text = recordCount.ToString()

        Catch ex As Exception
            MessageBox.Show("Error filtering activity logs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub








    Private Function GetCorrectTime(amTime As Object, pmTime As Object) As String
        If Not IsDBNull(amTime) AndAlso Not String.IsNullOrEmpty(amTime.ToString()) Then
            Return amTime.ToString()
        ElseIf Not IsDBNull(pmTime) AndAlso Not String.IsNullOrEmpty(pmTime.ToString()) Then
            Return pmTime.ToString()
        Else
            Return "-----"
        End If
    End Function

    Private Sub LoadMemberLogNamesToComboBox()
        Try
            openConn()
            cmbMemberLog.Items.Clear()
            cmbMemberLog.Items.Add("All") ' Always add "All" first

            Using cmd As New MySqlCommand("SELECT DISTINCT name FROM tblloghistory ORDER BY name ASC", con)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        cmbMemberLog.Items.Add(dr("name").ToString())
                    End While
                End Using
            End Using

            cmbMemberLog.SelectedIndex = 0 ' Default to "All"
        Catch ex As Exception
            MessageBox.Show("Failed to load member names: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub LoadMemberNamesToComboBox()
        Try
            openConn()
            cmbMemberPayment.Items.Clear()
            cmbMemberPayment.Items.Add("All") ' Always add "All" first

            Using cmd As New MySqlCommand("SELECT DISTINCT name FROM tblpayment ORDER BY name ASC", con)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        cmbMemberPayment.Items.Add(dr("name").ToString())
                    End While
                End Using
            End Using

            cmbMemberPayment.SelectedIndex = 0 ' Default to "All"
        Catch ex As Exception
            MessageBox.Show("Failed to load member names: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub FilterPaymentsByDateRange()
        Try
            If dtendpayment.Value.Date < dtstartpayment.Value.Date Then
                MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            openConn()
            dgvpayments.Rows.Clear()

            Dim selectedName As String = cmbMemberPayment.Text.Trim()
            Dim recordCount As Integer = 0
            Dim totalAmount As Decimal = 0

            ' Base query
            Dim query As String = "SELECT * FROM tblpayment WHERE DATE(paymentdate) BETWEEN @startDate AND @endDate"

            ' Add filter by name if not "All"
            If selectedName <> "All" Then
                query &= " AND name = @name"
            End If

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@startDate", dtstartpayment.Value.Date.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@endDate", dtendpayment.Value.Date.ToString("yyyy-MM-dd"))

                If selectedName <> "All" Then
                    cmd.Parameters.AddWithValue("@name", selectedName)
                End If

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim payment As Decimal
                        Decimal.TryParse(dr("total").ToString(), payment)

                        dgvpayments.Rows.Add(dr("rfid").ToString(),
                                         dr("transactionno").ToString(),
                                         dr("name").ToString(),
                                         dr("services").ToString(),
                                         dr("description").ToString(),
                                         payment.ToString("N2"),
                                         Convert.ToDateTime(dr("paymentdate")).ToString("yyyy-MM-dd"),
                                         Convert.ToDateTime(dr("nextdue")).ToString("yyyy-MM-dd"),
                                         dr("paymenttype").ToString(),
                                         dr("referenceno").ToString())

                        totalAmount += payment
                        recordCount += 1
                    End While
                End Using
            End Using

            If recordCount = 0 Then
                MessageBox.Show("No records found for the selected filters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            lblnumberofpayments.Text = totalAmount.ToString("N0")

        Catch ex As Exception
            MessageBox.Show("Error filtering payment records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub FilterIncomeHistoryByDateRange()
        Try
            ' Check if the end date is earlier than the start date
            If dtpto.Value.Date < dtpfrom.Value.Date Then
                MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            openConn()
            dgvIncome.Rows.Clear()

            Dim recordCount As Integer = 0
            Dim totalIncome As Decimal = 0

            ' Base query for tblpayment (using paymentdate instead of incomedate)
            Dim query As String = "SELECT * FROM tblpayment WHERE DATE(paymentdate) BETWEEN @startDate AND @endDate"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@startDate", dtpfrom.Value.Date.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@endDate", dtpto.Value.Date.ToString("yyyy-MM-dd"))

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim income As Decimal
                        Decimal.TryParse(dr("total").ToString(), income)

                        ' Add rows to dgvIncome
                        dgvIncome.Rows.Add(dr("id").ToString(),
                                           dr("rfid").ToString(),
                            dr("transactionno").ToString(),
                                   dr("name").ToString(),
                                   dr("services").ToString(),
                                   dr("description").ToString(),
                                   income.ToString("N2"),
                                   Convert.ToDateTime(dr("paymentdate")).ToString("yyyy-MM-dd"), ' Use paymentdate here
                                   Convert.ToDateTime(dr("nextdue")).ToString("yyyy-MM-dd"),
                                   dr("paymenttype").ToString(),
                                   dr("referenceno").ToString())

                        totalIncome += income
                        recordCount += 1
                    End While
                End Using
            End Using

            If recordCount = 0 Then
                MessageBox.Show("No records found for the selected filters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            lblnumberofpayments.Text = totalIncome.ToString("N0")

        Catch ex As Exception
            MessageBox.Show("Error filtering income records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub







    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles btnExpPayment.Click
        ' Check if DataGridView is empty
        If dgvpayments.RowCount = 0 Then
            MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
                        Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Payments")
                        Dim totalAmount As Decimal = 0

                        ' Determine the last column letter dynamically
                        Dim lastColNumber As Integer = dgvpayments.ColumnCount
                        Dim lastColLetter As String = XLHelper.GetColumnLetterFromNumber(lastColNumber)

                        ' Add a title at the top (Row 1)
                        worksheet.Range("A1:" & lastColLetter & "1").Merge()
                        worksheet.Cell("A1").Value = "PAYMENT RECORDS"
                        worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A1").Style.Font.Bold = True
                        worksheet.Cell("A1").Style.Font.FontSize = 16
                        worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                        worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                        ' Add selected date range (Row 2)
                        Dim dateRange As String = "Date Range: " & dtstartpayment.Value.ToString("MMMM dd, yyyy") & " - " & dtendpayment.Value.ToString("MMMM dd, yyyy")
                        worksheet.Range("A2:" & lastColLetter & "2").Merge()
                        worksheet.Cell("A2").Value = dateRange
                        worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A2").Style.Font.Italic = True
                        worksheet.Cell("A2").Style.Font.FontSize = 12
                        worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                        ' Add headers (row 3)
                        For colIndex As Integer = 0 To dgvpayments.ColumnCount - 1
                            worksheet.Cell(3, colIndex + 1).Value = dgvpayments.Columns(colIndex).HeaderText
                            worksheet.Cell(3, colIndex + 1).Style.Font.Bold = True
                            worksheet.Cell(3, colIndex + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                        Next

                        ' Add data rows (row 4 onward)
                        For rowIndex As Integer = 0 To dgvpayments.RowCount - 1
                            For colIndex As Integer = 0 To dgvpayments.ColumnCount - 1
                                worksheet.Cell(rowIndex + 4, colIndex + 1).Value = dgvpayments.Rows(rowIndex).Cells(colIndex).Value?.ToString()
                            Next
                            ' Add total from "Total" column (assuming at index 5)
                            Dim payment As Decimal
                            If Decimal.TryParse(dgvpayments.Rows(rowIndex).Cells(5).Value?.ToString(), payment) Then
                                totalAmount += payment
                            End If
                        Next

                        ' Display Total
                        Dim totalRow As Integer = dgvpayments.RowCount + 4
                        worksheet.Cell(totalRow, 5).Value = "Total:"
                        worksheet.Cell(totalRow, 5).Style.Font.Bold = True
                        worksheet.Cell(totalRow, 6).Value = totalAmount.ToString("N2")
                        worksheet.Cell(totalRow, 6).Style.Font.Bold = True

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
    End Sub




    Private Sub btnExpLogs_Click(sender As Object, e As EventArgs) Handles btnExpLogs.Click
        ' Check if DataGridView is empty
        If dgvloghistory.RowCount = 0 Then
            MessageBox.Show("No log history available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
                        Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Log History")

                        ' Determine the last column letter dynamically
                        Dim lastColNumber As Integer = dgvloghistory.ColumnCount
                        Dim lastColLetter As String = XLHelper.GetColumnLetterFromNumber(lastColNumber)

                        ' Add a title at the top (Row 1)
                        worksheet.Range("A1:" & lastColLetter & "1").Merge()
                        worksheet.Cell("A1").Value = "LOG HISTORY RECORDS"
                        worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A1").Style.Font.Bold = True
                        worksheet.Cell("A1").Style.Font.FontSize = 16
                        worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                        worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                        ' Add selected date range (Row 2)
                        Dim dateRange As String = "Date Range: " & dtstartpayment.Value.ToString("MMMM dd, yyyy") & " - " & dtendpayment.Value.ToString("MMMM dd, yyyy")
                        worksheet.Range("A2:" & lastColLetter & "2").Merge()
                        worksheet.Cell("A2").Value = dateRange
                        worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A2").Style.Font.Italic = True
                        worksheet.Cell("A2").Style.Font.FontSize = 12
                        worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                        ' Add headers (Row 3)
                        For colIndex As Integer = 0 To dgvloghistory.ColumnCount - 1
                            worksheet.Cell(3, colIndex + 1).Value = dgvloghistory.Columns(colIndex).HeaderText
                            worksheet.Cell(3, colIndex + 1).Style.Font.Bold = True
                            worksheet.Cell(3, colIndex + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                        Next

                        ' Add data rows (Row 4 onward)
                        For rowIndex As Integer = 0 To dgvloghistory.RowCount - 1
                            For colIndex As Integer = 0 To dgvloghistory.ColumnCount - 1
                                worksheet.Cell(rowIndex + 4, colIndex + 1).Value = dgvloghistory.Rows(rowIndex).Cells(colIndex).Value?.ToString()
                            Next
                        Next

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
    End Sub


    Private Sub btnExpCancel_Click(sender As Object, e As EventArgs) Handles btnExpCancel.Click
        ' Check if DataGridView is empty
        If dgvcancel.RowCount = 0 Then
            MessageBox.Show("No cancellation records available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Stop execution if there's no data
        End If

        Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
                        Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Cancellation History")
                        Dim totalRows As Integer = dgvcancel.RowCount

                        ' Determine the last column letter dynamically (excluding Action column)
                        Dim lastColNumber As Integer = dgvcancel.ColumnCount - 1 ' Exclude Action column
                        Dim lastColLetter As String = XLHelper.GetColumnLetterFromNumber(lastColNumber)

                        ' Add a title at the top (Row 1)
                        worksheet.Range("A1:" & lastColLetter & "1").Merge()
                        worksheet.Cell("A1").Value = "CANCELLATION HISTORY"
                        worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A1").Style.Font.Bold = True
                        worksheet.Cell("A1").Style.Font.FontSize = 16
                        worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                        worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                        ' Add selected date range (Row 2)
                        Dim dateRange As String = "Date Range: " & dtpdatefrom.Value.ToString("MMMM dd, yyyy") & " - " & dtpdateto.Value.ToString("MMMM dd, yyyy")
                        worksheet.Range("A2:" & lastColLetter & "2").Merge()
                        worksheet.Cell("A2").Value = dateRange
                        worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A2").Style.Font.Italic = True
                        worksheet.Cell("A2").Style.Font.FontSize = 12
                        worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                        ' Add headers (row 3), excluding "Action" column
                        For colIndex As Integer = 0 To dgvcancel.ColumnCount - 2 ' Exclude the Action column
                            worksheet.Cell(3, colIndex + 1).Value = dgvcancel.Columns(colIndex).HeaderText
                            worksheet.Cell(3, colIndex + 1).Style.Font.Bold = True
                            worksheet.Cell(3, colIndex + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                        Next

                        ' Add data rows (row 4 onward), excluding "Action" column
                        For rowIndex As Integer = 0 To dgvcancel.RowCount - 1
                            For colIndex As Integer = 0 To dgvcancel.ColumnCount - 2 ' Exclude the Action column
                                worksheet.Cell(rowIndex + 4, colIndex + 1).Value = dgvcancel.Rows(rowIndex).Cells(colIndex).Value?.ToString()
                            Next
                        Next

                        ' Display Total (count of rows)
                        Dim totalRow As Integer = dgvcancel.RowCount + 4
                        worksheet.Cell(totalRow, 5).Value = "Total Rows:"
                        worksheet.Cell(totalRow, 5).Style.Font.Bold = True
                        worksheet.Cell(totalRow, 6).Value = totalRows.ToString()
                        worksheet.Cell(totalRow, 6).Style.Font.Bold = True

                        ' Auto-fit columns for better readability
                        worksheet.Columns().AdjustToContents()

                        ' Save the workbook
                        workbook.SaveAs(sfd.FileName)
                    End Using

                    MessageBox.Show("Cancellation records export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error exporting cancellation records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub



    Private Sub PnlCancel_Paint(sender As Object, e As PaintEventArgs) Handles PnlCancel.Paint

    End Sub

    Private Sub reports_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Add button column only once
        If dgvcancel.Columns("Revert") Is Nothing Then
            Dim btn As New DataGridViewButtonColumn()
            btn.Name = "Revert"
            btn.HeaderText = "Actions"
            btn.Text = "Revert"
            btn.UseColumnTextForButtonValue = True
            dgvcancel.Columns.Add(btn)
        End If

        LoadMemberNamesToComboBox()
        LoadMemberLogNamesToComboBox()
    End Sub

    Private Sub GunaDataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIncome.CellContentClick

    End Sub



    Private Sub GunaAdvenceTileButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton3.Click
        FilterIncomeHistoryByDateRange()

    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        ' Check if DataGridView is empty
        If dgvIncome.RowCount = 0 Then
            MessageBox.Show("No income records available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Stop execution if there's no data
        End If

        Try
            ' Create new Excel workbook using ClosedXML
            Using workbook As New XLWorkbook()
                Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Income History")

                ' Get last column letter dynamically
                Dim lastCol As Integer = dgvIncome.Columns.Count
                Dim lastColLetter As String = XLHelper.GetColumnLetterFromNumber(lastCol)

                ' BIG TITLE at the top (dynamic merge)
                worksheet.Range($"A1:{lastColLetter}1").Merge()
                worksheet.Cell("A1").Value = "INCOME HISTORY REPORT"
                worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                worksheet.Cell("A1").Style.Font.Bold = True
                worksheet.Cell("A1").Style.Font.FontSize = 16
                worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                ' Write Date Range (dynamic merge)
                worksheet.Range($"A2:{lastColLetter}2").Merge()
                Dim dateRange As String = "Report From: " & dtpfrom.Value.ToShortDateString() & " - " & dtpto.Value.ToShortDateString()
                worksheet.Cell("A2").Value = dateRange
                worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                worksheet.Cell("A2").Style.Font.Italic = True
                worksheet.Cell("A2").Style.Font.FontSize = 12
                worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                ' Write Headers (Row 3)
                For colIndex As Integer = 0 To dgvIncome.Columns.Count - 1
                    worksheet.Cell(3, colIndex + 1).Value = dgvIncome.Columns(colIndex).HeaderText
                    worksheet.Cell(3, colIndex + 1).Style.Font.Bold = True
                    worksheet.Cell(3, colIndex + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                Next

                ' Write Data Rows (Starting from Row 4)
                Dim totalIncome As Decimal = 0D
                For rowIndex As Integer = 0 To dgvIncome.RowCount - 1
                    For colIndex As Integer = 0 To dgvIncome.Columns.Count - 1
                        Dim cellValue = dgvIncome.Rows(rowIndex).Cells(colIndex).Value
                        If TypeOf cellValue Is Byte() Then
                            worksheet.Cell(rowIndex + 4, colIndex + 1).Value = "[Image]"
                        Else
                            worksheet.Cell(rowIndex + 4, colIndex + 1).Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)

                            ' Try to sum the "Total" column (you can also use column name if needed)
                            If dgvIncome.Columns(colIndex).HeaderText.ToLower().Contains("total") Then
                                Dim tempVal As Decimal
                                If Decimal.TryParse(cellValue?.ToString(), tempVal) Then
                                    totalIncome += tempVal
                                End If
                            End If
                        End If
                    Next
                Next

                ' Write Total Income (Row under data)
                Dim totalRow As Integer = dgvIncome.RowCount + 4
                worksheet.Cell(totalRow, 1).Value = "Total Income:"
                worksheet.Cell(totalRow, 2).Value = totalIncome.ToString("N2") ' format as 2 decimal
                worksheet.Cell(totalRow, 1).Style.Font.Bold = True

                ' AutoFit columns for better readability
                worksheet.Columns().AdjustToContents()

                ' Save File
                Using sfd As New SaveFileDialog() With {.Filter = "Excel Files|*.xlsx", .Title = "Save Income Report", .FileName = "Income_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".xlsx"}
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

    Private Sub dtfromlogs_ValueChanged(sender As Object, e As EventArgs) Handles dtfromlogs.ValueChanged

    End Sub

    Private Sub PnlPayment_Paint(sender As Object, e As PaintEventArgs) Handles PnlPayment.Paint

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles SessionHistory.Click

    End Sub

    Private Sub btnSessionFilter_Click(sender As Object, e As EventArgs) Handles btnSessionFilter.Click
        Try
            If dtpsessionto.Value.Date < dtpsessionfrom.Value.Date Then
                MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            openConn()
            dgvsession.Rows.Clear()

            Dim recordFound As Boolean = False
            Dim query As String = "SELECT * FROM tblsession WHERE date BETWEEN @startDate AND @endDate"

            ' Use a Dictionary to group records by RFID and Date
            Dim records As New Dictionary(Of String, DataRow)

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@startDate", dtpsessionfrom.Value.Date.ToString("MM-dd-yyyy"))
                cmd.Parameters.AddWithValue("@endDate", dtpsessionto.Value.Date.ToString("MM-dd-yyyy"))

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Add the record to your DataGridView
                        dgvsession.Rows.Add(
                        reader("fullname").ToString(),
                        reader("payment").ToString(),
                        Convert.ToDateTime(reader("date")).ToString("MM-dd-yyyy"),
                        reader("time").ToString()
                    )
                        recordFound = True
                    End While
                End Using
            End Using

            If Not recordFound Then
                MessageBox.Show("No records found for the selected filters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvsession.Rows.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            lblSession.Text = dgvsession.Rows.Count.ToString()
            dgvsession.ClearSelection()
            con.Close()
        End Try
    End Sub

    Private Sub btnSessionExport_Click(sender As Object, e As EventArgs) Handles btnSessionExport.Click
        ' Check if DataGridView is empty
        If dgvsession.RowCount = 0 Then
            MessageBox.Show("No session records available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Stop execution if there's no data
        End If

        Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
                        Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Session History")

                        ' Determine the last column letter dynamically
                        Dim lastColNumber As Integer = dgvsession.ColumnCount
                        Dim lastColLetter As String = XLHelper.GetColumnLetterFromNumber(lastColNumber)

                        ' Add a title at the top (Row 1)
                        worksheet.Range("A1:" & lastColLetter & "1").Merge()
                        worksheet.Cell("A1").Value = "SESSION HISTORY RECORDS"
                        worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A1").Style.Font.Bold = True
                        worksheet.Cell("A1").Style.Font.FontSize = 16
                        worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromArgb(20, 99, 168)
                        worksheet.Cell("A1").Style.Font.FontColor = XLColor.White

                        ' Add selected date range (Row 2)
                        Dim dateRange As String = "Date Range: " & dtpsessionfrom.Value.ToString("MMMM dd, yyyy") & " - " & dtpsessionto.Value.ToString("MMMM dd, yyyy")
                        worksheet.Range("A2:" & lastColLetter & "2").Merge()
                        worksheet.Cell("A2").Value = dateRange
                        worksheet.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        worksheet.Cell("A2").Style.Font.Italic = True
                        worksheet.Cell("A2").Style.Font.FontSize = 12
                        worksheet.Cell("A2").Style.Fill.BackgroundColor = XLColor.FromArgb(222, 235, 247)

                        ' Add headers (Row 3) - Include all columns
                        For colIndex As Integer = 0 To dgvsession.ColumnCount - 1
                            worksheet.Cell(3, colIndex + 1).Value = dgvsession.Columns(colIndex).HeaderText
                            worksheet.Cell(3, colIndex + 1).Style.Font.Bold = True
                            worksheet.Cell(3, colIndex + 1).Style.Fill.BackgroundColor = XLColor.LightGray
                        Next

                        ' Add data rows (Row 4 onward)
                        For rowIndex As Integer = 0 To dgvsession.RowCount - 1
                            For colIndex As Integer = 0 To dgvsession.ColumnCount - 1
                                Dim cellValue = dgvsession.Rows(rowIndex).Cells(colIndex).Value

                                ' Safely handle various data types
                                If TypeOf cellValue Is Byte() Then
                                    ' Skip images for now
                                    worksheet.Cell(rowIndex + 4, colIndex + 1).Value = "[Image]"
                                ElseIf TypeOf cellValue Is DateTime Then
                                    ' Format date/time values if they exist
                                    worksheet.Cell(rowIndex + 4, colIndex + 1).Value = CType(cellValue, DateTime).ToString("MM/dd/yyyy HH:mm")
                                Else
                                    ' For other types (string, decimal, etc.), convert to string
                                    worksheet.Cell(rowIndex + 4, colIndex + 1).Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                                End If
                            Next
                        Next

                        ' Align Total Row under Date and Time Column (Assuming Date is in column 1 and Time in column 2)
                        ' For example, if Date is in Column 1, Time is in Column 2, Total Rows should be placed starting from Column 3
                        Dim totalRow As Integer = dgvsession.RowCount + 4
                        worksheet.Cell(totalRow, 3).Value = "Total Records:"
                        worksheet.Cell(totalRow, 3).Style.Font.Bold = True
                        worksheet.Cell(totalRow, 4).Value = dgvsession.RowCount.ToString()
                        worksheet.Cell(totalRow, 4).Style.Font.Bold = True

                        ' Auto-fit columns for better readability
                        worksheet.Columns().AdjustToContents()

                        ' Save the workbook
                        workbook.SaveAs(sfd.FileName)
                    End Using

                    MessageBox.Show("Session records export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error exporting session records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub dgvpayments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpayments.CellContentClick

    End Sub
End Class