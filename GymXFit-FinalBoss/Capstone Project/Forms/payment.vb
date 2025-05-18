Imports System.Windows.Controls
Imports MySql.Data.MySqlClient
Public Class payment
    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayments()
        ValidateMembershipStatus()
        UpdateCountServices()
    End Sub

    Private Sub LoadPayments()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim sql As String = "SELECT * FROM tblpayment"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            dgvpayment.Rows.Clear()

            While dr.Read()

                dgvpayment.Rows.Add(
                    dr("rfid"),
                    dr("transactionno"),
                    dr("name"),
                    dr("services"),
                    dr("description"),
                    dr("total"),
                    dr("paymentdate"),
                    dr("nextdue"),
                    dr("paymenttype"),
                    dr("referenceno")
)
            End While

            dgvpayment.ClearSelection()
        Catch ex As Exception
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub txtpsearch_TextChanged(sender As Object, e As EventArgs)
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            ' SQL query to filter payment records based on multiple columns
            Dim sql As String = "SELECT transactionno, rfid, name, 
                                services, description, total, paymentdate, nextdue, paymenttype, referenceno
                             FROM tblpayment 
                             WHERE rfid LIKE @search OR 
                                   transactionno LIKE @search OR
                                   services LIKE @search OR 
                                   description LIKE @search OR 
                                   paymentdate LIKE @search OR 
                                   paymenttype LIKE @search OR 
                                   referenceno LIKE @search"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@search", "%" & txtpsearch.Text.Trim() & "%")
            dr = cmd.ExecuteReader()

            dgvpayment.Rows.Clear()

            While dr.Read()
                dgvpayment.Rows.Add(
                    dr("rfid"),
                    dr("transactionno"),
                    dr("name"),
                    dr("services"),
                    dr("description"),
                    dr("total"),
                    dr("paymentdate"),
                    dr("nextdue"),
                    dr("paymenttype"),
                    dr("referenceno")
                )
            End While

            dgvpayment.ClearSelection()
            dgvpayment.Refresh() ' Refresh the DataGridView

        Catch ex As Exception
            MessageBox.Show("Error searching payment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnpayment_Click_1(sender As Object, e As EventArgs) Handles btnpayment.Click
        Dim editform As New Add_Payment(Me)
        editform.ShowDialog() ' Use addmemberform.Show() instead of ShowDialog() to prevent blocking the main form
        editform.txtRFID.Focus()
    End Sub

    Public Sub RefreshGrid()
        LoadPayments() ' Call the existing LoadPayments method to reload the data
        UpdateCountServices()
    End Sub

    Private Sub ValidateMembershipStatus()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            ' Get current date
            Dim currentDate As Date = Date.Now

            ' Select all members with their latest payment records
            Dim sql As String = "SELECT p.rfid, p.nextdue, m.status 
                             FROM tblpayment p 
                             INNER JOIN tblmembers m ON p.rfid = m.rfid"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Dim membersToUpdate As New List(Of String) ' Store members whose status needs an update

            While dr.Read()
                Dim nextDueDate As Date = Date.Parse(dr("nextdue").ToString())
                Dim rfid As String = dr("rfid").ToString()
                Dim currentStatus As String = dr("status").ToString()

                ' Check if the membership is expired
                If nextDueDate < currentDate AndAlso currentStatus <> "EXPIRED" Then
                    membersToUpdate.Add(rfid) ' Add expired members to update list
                End If
            End While

            dr.Close()

            ' Update the status for expired members
            For Each rfid In membersToUpdate
                Dim updateSql As String = "UPDATE tblmembers SET status = 'EXPIRED' WHERE rfid = @rfid"
                Dim updateCmd As New MySqlCommand(updateSql, con)
                updateCmd.Parameters.AddWithValue("@rfid", rfid)
                updateCmd.ExecuteNonQuery()
            Next

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error validating membership status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub UpdateCountServices()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            ' Query to count services based on their type in tblmaintenance
            Dim sql As String = "SELECT m.type, COUNT(p.services) AS count 
                             FROM tblpayment p 
                             INNER JOIN tblmaintenance m ON p.services = m.services 
                             GROUP BY m.type"

            Dim cmd As New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Reset labels to 0
            lblDaily.Text = "0"
            lblMonthly.Text = "0"
            lblYearly.Text = "0"

            ' Loop through the results and update the labels
            While dr.Read()
                Select Case dr("type").ToString()
                    Case "DAILY"
                        lblDaily.Text = dr("count").ToString()
                    Case "MONTHLY"
                        lblMonthly.Text = dr("count").ToString()
                    Case "YEARLY"
                        lblYearly.Text = dr("count").ToString()
                End Select
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating payment types: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtpsearch.TextChanged
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            ' SQL query with search filters
            Dim sql As String = "SELECT rfid, transactionno, name, services, description, total, 
                                    paymentdate, nextdue, paymenttype, referenceno
                             FROM tblpayment 
                             WHERE rfid LIKE @search OR 
                                   transactionno LIKE @search OR 
                                   name LIKE @search OR 
                                   services LIKE @search OR 
                                   paymentdate LIKE @search OR 
                                   nextdue LIKE @search OR 
                                   paymenttype LIKE @search"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@search", "%" & txtpsearch.Text.Trim() & "%")
            dr = cmd.ExecuteReader()

            ' Clear DataGridView before adding new results
            dgvpayment.Rows.Clear()

            ' Populate DataGridView
            While dr.Read()
                dgvpayment.Rows.Add(
                    dr("rfid"),
                    dr("transactionno"),
                    dr("name"),
                    dr("services"),
                    dr("description"),
                    dr("total"),
                    dr("paymentdate"),
                    dr("nextdue"),
                    dr("paymenttype"),
                    dr("referenceno")
                )
            End While

            dgvpayment.ClearSelection()
            dgvpayment.Refresh() ' Refresh the DataGridView

        Catch ex As Exception
            MessageBox.Show("Error searching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub




End Class