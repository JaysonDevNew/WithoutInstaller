Public Class LoadingScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pgbar.Value += 3
        lblpercent.Text = "LOADING... " & pgbar.Value & "%"

        If pgbar.Value >= 100 Then
            Timer1.Stop()
            MainForm.Show()
            Me.Dispose() ' Hide the loading screen when done

            ' Reset progress bar and percentage text for future use
            pgbar.Value = 0
            lblpercent.Text = "LOADING... 0%"
        End If
    End Sub

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pgbar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub pgbar_Click(sender As Object, e As EventArgs) Handles pgbar.Click

    End Sub
End Class
