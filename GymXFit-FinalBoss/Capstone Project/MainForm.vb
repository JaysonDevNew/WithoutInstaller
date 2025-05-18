Imports FontAwesome.Sharp
Imports Guna.UI.WinForms
Imports System.Drawing.Text
Imports System.Threading

Public Class MainForm

    Private currentbtn As Guna.UI.WinForms.GunaAdvenceButton
    Private currentchildform As Form
    Private fonts As New PrivateFontCollection()
    ' Method to activate button and update title and icon
    Private Sub ActivateButton(senderbtn As Object, customcolor As Color, newTitle As String, newIcon As Image)
        If senderbtn IsNot Nothing Then
            ' Reset the appearance of the previously active button, if any
            If currentbtn IsNot Nothing Then
                currentbtn.BaseColor = Color.FromArgb(30, 30, 30) ' Reset to default color
                currentbtn.ForeColor = Color.White ' Reset text color
            End If

            ' Update the current button
            currentbtn = CType(senderbtn, Guna.UI.WinForms.GunaAdvenceButton)

            ' Apply the active state style
            currentbtn.BaseColor = customcolor ' Change background color
            currentbtn.ForeColor = Color.White ' Change text color for visibility

            ' Update title and icon
            lbltitle.Text = newTitle
            Icontitle.Image = newIcon
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the form is being closed by the user (e.g., clicking the X button)
        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Exit Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.Yes Then
                Application.Exit() ' Exit the application completely
            Else
                e.Cancel = True ' Cancel the close event
            End If
        End If
    End Sub



    Private Sub OpenChildForm(childform As Form)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        currentchildform = childform

        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childform)
        PanelDesktop.Tag = childform
        childform.BringToFront()
        childform.Show()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the default title and icon
        lbltitle.Text = "Dashboard"
        Icontitle.Image = My.Resources.dashboard_60px ' Replace with your default icon resource

        ' Activate the button for the Dashboard (if using button highlighting)
        Dim defaultButton As Object = Nothing ' Replace with the actual reference to your Dashboard button, if needed
        ActivateButton(defaultButton, Color.FromArgb(20, 99, 168), "Dashboard", My.Resources.dashboard_60px)

        ' Open the Dashboard form as the default child form
        OpenChildForm(New dashboard)
    End Sub


    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Dashboard", My.Resources.dashboard_60px)
        OpenChildForm(New dashboard)
    End Sub

    Private Sub btnmembership_Click(sender As Object, e As EventArgs) Handles btnmembership.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Membership", My.Resources.bank_card_back_side_60px)
        OpenChildForm(New membership)
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Payments", My.Resources.money_60px)
        OpenChildForm(New payment)
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Reports", My.Resources.graph_report_60px)
        OpenChildForm(New reports)
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Accounts", My.Resources.gender_neutral_user_60px)
        OpenChildForm(New accounts)
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles btnactivity.Click
        activitylogs.Show()
        activitylogs.txtRFID.Focus()
    End Sub



    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles btnmaintenance.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Maintenance", My.Resources.maintenance)
        OpenChildForm(New maintenance)
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles btninventory.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Inventory", My.Resources.product_60px)
        OpenChildForm(New inventory)
    End Sub

    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs) Handles btnsales.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Sales", My.Resources.loyalty_card_60px)
        OpenChildForm(New sales)
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Back-up & Restore", My.Resources.data_configuration_60px)
        OpenChildForm(New backup_restore)
    End Sub

    Private Sub btnEquipment_Click(sender As Object, e As EventArgs) 
        ActivateButton(sender, Color.FromArgb(20, 99, 168), "Equipment Checklist", My.Resources.icons8_gym_96_white)
        OpenChildForm(New equipment)
    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Profilepicture.Click

    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.Width = x
        Me.Height = y - 30
        Me.Top = 0
        Me.Left = 0

        PanelDesktop.Left = (Me.Width - PanelDesktop.Width) / 2
        PanelDesktop.Left = (Me.Height - PanelDesktop.Width) / 2

    End Sub

    Private Sub PanelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles PanelDesktop.Paint

    End Sub

    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Logout()
    End Sub

    Public Sub Logout()
        ' Confirm logout action
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close current form and show login form
            Dim loginForm As New LoginForm() ' Replace with your login form name
            loginForm.Show()
            Application.OpenForms("MainForm").Close() ' Replace with your main form name
        End If
    End Sub


End Class
