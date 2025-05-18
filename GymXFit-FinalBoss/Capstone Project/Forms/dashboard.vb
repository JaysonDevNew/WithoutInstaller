Imports MySql.Data.MySqlClient
Public Class dashboard
    Private Sub BunifuLabel20_Click(sender As Object, e As EventArgs) Handles BunifuLabel20.Click

    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateMemberCounts()
        LoadSalesSummary()

        If Date.Today.DayOfWeek = DayOfWeek.Friday Then
            MessageBox.Show(
                "Reminder: It's the end of the week. Please back up your database using the Backup and Restore feature. " &
                "For safety, store the backup in a secure location such as cloud storage or a flash drive.",
                "Weekly Backup Reminder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If
    End Sub
    Private Sub LoadSalesSummary()
        Try
            openConn()

            ' Get today's date
            Dim today As Date = Date.Today

            ' DAILY SALES
            Dim cmdDaily As New MySqlCommand("SELECT IFNULL(SUM(amount), 0) FROM tblsales WHERE DATE(date) = @today", con)
            cmdDaily.Parameters.AddWithValue("@today", today)
            Dim dailySales As Decimal = Convert.ToDecimal(cmdDaily.ExecuteScalar())
            bldaily.Text = dailySales.ToString("N2")

            ' WEEKLY SALES (current week)
            Dim cmdWeekly As New MySqlCommand("SELECT IFNULL(SUM(amount), 0) FROM tblsales WHERE WEEK(date, 1) = WEEK(@today, 1) AND YEAR(date) = YEAR(@today)", con)
            cmdWeekly.Parameters.AddWithValue("@today", today)
            Dim weeklySales As Decimal = Convert.ToDecimal(cmdWeekly.ExecuteScalar())
            blweekly.Text = weeklySales.ToString("N2")

            ' MONTHLY SALES (current month)
            Dim cmdMonthly As New MySqlCommand("SELECT IFNULL(SUM(amount), 0) FROM tblsales WHERE MONTH(`date`) = MONTH(@today) AND YEAR(`date`) = YEAR(@today)", con)
            cmdMonthly.Parameters.AddWithValue("@today", today)
            Dim monthlySales As Decimal = Convert.ToDecimal(cmdMonthly.ExecuteScalar())
            bllmonthly.Text = monthlySales.ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error loading sales summary: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub UpdateMemberCounts()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            ' Query to count all members based on their status
            Dim sql As String = "SELECT status, COUNT(*) AS count FROM tblmembers GROUP BY status"
            Dim cmd As New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Reset labels to 0
            lblpending.Text = "0"
            lblactive.Text = "0"
            lblexpired.Text = "0"

            ' Loop through the results and update the labels
            While dr.Read()
                Select Case dr("status").ToString()
                    Case "PENDING"
                        lblpending.Text = dr("count").ToString()
                    Case "ACTIVE"
                        lblactive.Text = dr("count").ToString()
                    Case "EXPIRED"
                        lblexpired.Text = dr("count").ToString()
                End Select
            End While
            dr.Close()

            ' Query to count members added today based on their status
            Dim todaySql As String = "SELECT status, COUNT(*) AS count FROM tblmembers WHERE DATE(member_since) = CURDATE() GROUP BY status"
            Dim todayCmd As New MySqlCommand(todaySql, con)
            Dim todayDr As MySqlDataReader = todayCmd.ExecuteReader()

            ' Reset new counts to 0
            lblnewpending.Text = "No pending membership"
            lblnewactive.Text = "No new active membership"
            lblnewexpired.Text = "No expired membership"

            ' Loop through today's results and update the labels
            While todayDr.Read()
                Select Case todayDr("status").ToString()
                    Case "PENDING"
                        lblnewpending.Text = $"{todayDr("count")} to pay membership"
                    Case "ACTIVE"
                        lblnewactive.Text = $"{todayDr("count")} newly active members"
                    Case "EXPIRED"
                        lblnewexpired.Text = $"{todayDr("count")} memberships expired today"
                End Select
            End While

        Catch ex As Exception
            MessageBox.Show("Error updating member counts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub lblpending_Click(sender As Object, e As EventArgs) Handles lblpending.Click

    End Sub
End Class