Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Threading.Tasks

Public Class activitylogs
    ' Use connection string variable to ensure consistency
    Private ReadOnly connectionString As String = "server=localhost;user id=root;password=;database=gymxfit_database"

    Private Sub activitylogs_Load(sender As Object, e As EventArgs) Handles Me.Load
        datentime.Enabled = True
        txtRFID.Focus()
        dtdatenow.Value = Date.Now
        dttimenow.Format = DateTimePickerFormat.Time
        dttimenow.ShowUpDown = True
        LoadLogs()

        TimerFocus.Interval = 500 ' Set focus every half a second
        TimerFocus.Enabled = True

        Me.TopMost = False
        Timer3.Enabled = True
    End Sub

    Private Sub TimerFocus_Tick(sender As Object, e As EventArgs) Handles TimerFocus.Tick
        If Me.Visible Then
            txtRFID.Focus()
        End If
    End Sub

    Private Sub datentime_Tick_1(sender As Object, e As EventArgs) Handles datentime.Tick
        lbldatentime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt", Globalization.CultureInfo.InvariantCulture).ToUpper()
    End Sub

    Private Sub txtRFID_TextChanged(sender As Object, e As EventArgs) Handles txtRFID.TextChanged
        ' Ensure that the RFID input is complete before processing
        If txtRFID.Text.Length >= 10 Then
            Timer1.Interval = 500 ' Delay to ensure complete RFID input
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop the timer to avoid multiple triggers
        ProcessRFID()
    End Sub

    Private Sub ProcessRFID()
        If txtRFID.Text.Trim().Length >= 10 Then
            Try
                If txtRFID.Text.Length >= 10 Then
                    txtRFID.SelectionStart = 0
                    txtRFID.SelectionLength = Len(txtRFID.Text)
                    txtRFID.Focus()
                End If

                Dim memberStatus As String = ""
                Dim remainingVisits As Integer = 0

                ' Step 1: Check membership status from tblmembers
                Using con1 As New MySqlConnection(connectionString)
                    con1.Open()
                    Using statusCmd As New MySqlCommand("SELECT status, remaining_visits FROM tblmembers WHERE rfid = @rfid", con1)
                        statusCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
                        Using dr As MySqlDataReader = statusCmd.ExecuteReader()
                            If dr.Read() Then
                                memberStatus = dr("status").ToString()
                                remainingVisits = Convert.ToInt32(dr("remaining_visits"))

                                Select Case memberStatus.Trim().ToUpper()
                                    Case "ACTIVE"
                                        If remainingVisits <= 0 Then
                                            MessageBox.Show("You have used all your allowed sessions. Please renew your membership.", "Membership Renewal Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            dr.Close()

                                            Using updateCon As New MySqlConnection(connectionString)
                                                updateCon.Open()
                                                Dim updateSql As String = "UPDATE tblmembers SET status = 'PENDING' WHERE rfid = @rfid"
                                                Using updateCmd As New MySqlCommand(updateSql, updateCon)
                                                    updateCmd.Parameters.AddWithValue("@rfid", txtRFID.Text.Trim())
                                                    updateCmd.ExecuteNonQuery()
                                                End Using
                                            End Using

                                            Dim renewalForm As New RenewalForm(txtRFID.Text)
                                            renewalForm.ShowDialog()
                                            txtRFID.Clear()
                                            Return
                                        End If

                                    Case "EXPIRED"
                                        MessageBox.Show("Membership has Expired. Please renew.", "Membership Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        txtRFID.Clear()
                                        Return
                                    Case "PENDING"
                                        MessageBox.Show("Membership is Pending.", "Membership Pending. Please proceed on payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        txtRFID.Clear()
                                        Return
                                    Case Else
                                        MessageBox.Show("Membership status is not recognized.", "Unknown Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        txtRFID.Clear()
                                        Return
                                End Select
                            Else
                                MessageBox.Show("RFID not found in members database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                txtRFID.Clear()
                                Return
                            End If
                        End Using
                    End Using
                End Using

                ' Step 2: Fetch the most recent payment details
                Dim paymentDate As DateTime = DateTime.Now
                Dim nextDueDate As DateTime = DateTime.Now

                Using con2 As New MySqlConnection(connectionString)
                    con2.Open()
                    Using paymentCmd As New MySqlCommand("SELECT paymentdate, nextdue FROM tblpayment WHERE rfid=@rfid ORDER BY paymentdate DESC LIMIT 1", con2)
                        paymentCmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
                        Using dr As MySqlDataReader = paymentCmd.ExecuteReader()
                            If dr.Read() Then
                                paymentDate = Convert.ToDateTime(dr("paymentdate"))
                                nextDueDate = Convert.ToDateTime(dr("nextdue"))

                                Dim remainingDays As Integer = (nextDueDate - DateTime.Now).Days
                                If remainingDays <= 7 AndAlso remainingDays > 0 Then
                                    MessageBox.Show($"Warning: Your membership is about to expire in {remainingDays} days. Please renew your membership before it expires.", "Membership Expiring Soon", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            End If
                        End Using
                    End Using
                End Using

                ' Step 3: Fetch user details
                Using con3 As New MySqlConnection(connectionString)
                    con3.Open()
                    Using cmd As New MySqlCommand("SELECT name, services, picture FROM tblpayment WHERE rfid=@rfid", con3)
                        cmd.Parameters.AddWithValue("@rfid", txtRFID.Text)
                        Using dr As MySqlDataReader = cmd.ExecuteReader()
                            If dr.Read() Then
                                lblname.Text = dr("name").ToString()
                                lblservices.Text = dr("services").ToString()

                                Try
                                    If Not IsDBNull(dr("picture")) Then
                                        Dim imgData As Byte() = DirectCast(dr("picture"), Byte())
                                        If imgData IsNot Nothing AndAlso imgData.Length > 0 Then
                                            Using ms As New MemoryStream(imgData)
                                                Using tempImage As Image = Image.FromStream(ms)
                                                    ms.Position = 0
                                                    memberpic.Image = Image.FromStream(ms)
                                                End Using
                                            End Using
                                        Else
                                            memberpic.Image = My.Resources.gymnast_1163072
                                        End If
                                    Else
                                        memberpic.Image = My.Resources.gymnast_1163072
                                    End If
                                Catch
                                    memberpic.Image = My.Resources.gymnast_1163072
                                End Try
                            Else
                                lblname.Text = ""
                                lblservices.Text = ""
                                memberpic.Image = My.Resources.gymnast_1163072
                                Return
                            End If
                        End Using
                    End Using
                End Using

                ' Step 4: Determine whether to log AM or PM attendance
                Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay
                Dim noonTime As TimeSpan = New TimeSpan(12, 0, 0)

                If currentTime <= noonTime Then
                    LogAttendance(txtRFID.Text, lblname.Text, dtdatenow.Value, dttimenow.Value, "AM")
                Else
                    LogAttendance(txtRFID.Text, lblname.Text, dtdatenow.Value, dttimenow.Value, "PM")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                txtRFID.Clear()
            End Try
        End If
    End Sub


    Private Function GetCorrectTime(amTime As Object, pmTime As Object) As String
        Dim result As String = ""

        If Not IsDBNull(amTime) AndAlso Not String.IsNullOrEmpty(amTime.ToString()) Then
            result &= "AM: " & amTime.ToString() & " "
        End If

        If Not IsDBNull(pmTime) AndAlso Not String.IsNullOrEmpty(pmTime.ToString()) Then
            result &= "PM: " & pmTime.ToString()
        End If

        If result = "" Then
            result = "-----"
        End If

        Return result.Trim()
    End Function

    Private Function CheckRemainingVisits(rfid As String) As Boolean
        Dim hasRemainingVisits As Boolean = True

        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' First, check if member exists and is active
                Using statusCmd As New MySqlCommand("SELECT status, remaining_visits FROM tblmembers WHERE rfid = @rfid", con)
                    statusCmd.Parameters.AddWithValue("@rfid", rfid)

                    Using dr As MySqlDataReader = statusCmd.ExecuteReader()
                        If dr.Read() Then
                            Dim status As String = dr("status").ToString()
                            Dim remainingVisits As Integer = Convert.ToInt32(dr("remaining_visits"))

                            ' Check if member is active and has remaining visits
                            If status.Trim().ToUpper() = "ACTIVE" Then
                                If remainingVisits <= 0 Then
                                    ' No remaining visits, prompt for renewal
                                    MessageBox.Show("You have used all your allowed visits. Please renew your membership.",
                                               "Membership Renewal Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                                    ' Show renewal form
                                    Dim renewalForm As New RenewalForm(rfid)
                                    renewalForm.ShowDialog()

                                    ' After renewal, reload member info
                                    Return CheckRemainingVisits(rfid)
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using

            Return hasRemainingVisits

        Catch ex As Exception
            MessageBox.Show("Error checking remaining visits: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Async Sub LogAttendance(rfid As String, name As String, logDate1 As Date, logTime1 As Date, period As String)
        Dim logDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim logTime As String = lbltime.Text

        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' Fetch the name based on RFID from tblpayment
                Using nameCmd As New MySqlCommand("SELECT name FROM tblpayment WHERE rfid = @rfid", con)
                    nameCmd.Parameters.AddWithValue("@rfid", rfid)

                    Using drName As MySqlDataReader = nameCmd.ExecuteReader()
                        If drName.Read() Then
                            name = drName("name").ToString()
                        End If
                    End Using
                End Using

                ' Check if there is already an IN record without OUT
                Dim lastLogId As Integer = -1

                Using cmd As New MySqlCommand("SELECT id FROM tblloghistory WHERE rfid = @rfid AND sdate = @sdate AND (Time_out = '---------' OR Time_out IS NULL) ORDER BY id DESC LIMIT 1", con)
                    cmd.Parameters.AddWithValue("@rfid", rfid)
                    cmd.Parameters.AddWithValue("@sdate", logDate)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            lastLogId = Convert.ToInt32(dr("id"))
                        End If
                    End Using
                End Using

                timer2.Interval = 2000 ' 2 seconds
                timer2.Start()

                If lastLogId <> -1 Then
                    ' 2nd scan -> Update Time_out
                    Using updateCmd As New MySqlCommand("UPDATE tblloghistory SET Time_out = @timeout WHERE id = @id", con)
                        updateCmd.Parameters.AddWithValue("@timeout", logTime)
                        updateCmd.Parameters.AddWithValue("@id", lastLogId)
                        updateCmd.ExecuteNonQuery()
                    End Using

                    ' Display the name in the label and update result message
                    lblname.Text = name
                    lblResult.Text = "✅ Success: Time-Out recorded!"

                    ' Decrement the remaining_visits only on Time-Out (completed visit)
                    Using updateVisitsCmd As New MySqlCommand("UPDATE tblmembers SET remaining_visits = remaining_visits - 1 WHERE rfid = @rfid AND remaining_visits > 0", con)
                        updateVisitsCmd.Parameters.AddWithValue("@rfid", rfid)
                        updateVisitsCmd.ExecuteNonQuery()
                    End Using
                Else
                    ' 1st scan -> Insert Time_in
                    Using insertCmd As New MySqlCommand("INSERT INTO tblloghistory (rfid, name, sdate, Time_in, Time_out) VALUES (@rfid, @name, @sdate, @timein, '---------')", con)
                        insertCmd.Parameters.AddWithValue("@rfid", rfid)
                        insertCmd.Parameters.AddWithValue("@name", name)
                        insertCmd.Parameters.AddWithValue("@sdate", logDate)
                        insertCmd.Parameters.AddWithValue("@timein", logTime)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    ' Display the name in the label and update result message
                    lblname.Text = name
                    lblResult.Text = "✅ Success: Time-In recorded!"
                End If

                ' Refresh DataGridView after insert/update
                LoadLogs()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error logging attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub clearLogs()
        lblname.Text = ""
        lblservices.Text = ""
        lblResult.Text = ""
        memberpic.Image = My.Resources.gymnast_1163072
    End Sub

    Public Sub LoadLogs()
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Dim sql As String = "SELECT rfid, name AS fname, sdate, Time_in, Time_out FROM tblloghistory WHERE DATE(sdate) = CURDATE() ORDER BY id DESC"

                Using cmd As New MySqlCommand(sql, con)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        dgvloghistory.Rows.Clear()

                        While dr.Read()
                            Dim formattedDate As String = If(IsDBNull(dr("sdate")), "-----", Convert.ToDateTime(dr("sdate")).ToString("yyyy-MM-dd"))
                            Dim timeIn As String = If(IsDBNull(dr("Time_in")), "-----", dr("Time_in").ToString())
                            Dim timeOut As String = If(IsDBNull(dr("Time_out")), "-----", dr("Time_out").ToString())

                            dgvloghistory.Rows.Add(
                                dr("rfid").ToString(),
                                dr("fname").ToString(),
                                formattedDate,
                                timeIn,
                                timeOut
                            )
                        End While

                        dgvloghistory.ClearSelection()
                        dgvloghistory.Refresh()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading log history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        lblname.Text = ""
        memberpic.Image = My.Resources.gymnast_1163072
        lblservices.Text = ""
        lblResult.Text = ""
        timer2.Stop()
    End Sub

    Private Sub btnSession_Click(sender As Object, e As EventArgs) Handles btnSession.Click
        SessionForm.Show()
        Me.Close()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        ' Left empty as in original code
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        ' Left empty as in original code
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lbltime.Text = DateTime.Now.ToString("hh:mm: tt")

        ' Move the label to the right
        lbltime.Left += 5 ' Move 5 pixels every tick

        ' If label goes beyond the form, reset its position to the left
        If lbltime.Left > Me.Width Then
            lbltime.Left = -Label1.Width
        End If
    End Sub
End Class