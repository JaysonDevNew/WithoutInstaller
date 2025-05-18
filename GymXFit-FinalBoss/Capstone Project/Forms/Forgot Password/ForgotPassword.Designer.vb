<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.txtCheckUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.txtChangePass = New Guna.UI.WinForms.GunaTextBox()
        Me.txtConfirmPass = New Guna.UI.WinForms.GunaTextBox()
        Me.btnChangePass = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPasswordStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New Guna.UI.WinForms.GunaTextBox()
        Me.otptimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtotp = New Guna.UI.WinForms.GunaTextBox()
        Me.btnsendotp = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lbltimer = New System.Windows.Forms.Label()
        Me.chkpassword = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 50)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.icons8_password_64
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.Animated = True
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.White
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(511, 13)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox2.TabIndex = 1
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(535, 12)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Forgot Password"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'txtCheckUsername
        '
        Me.txtCheckUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtCheckUsername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtCheckUsername.BorderColor = System.Drawing.Color.Silver
        Me.txtCheckUsername.BorderSize = 0
        Me.txtCheckUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCheckUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCheckUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtCheckUsername.FocusedForeColor = System.Drawing.Color.Black
        Me.txtCheckUsername.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckUsername.ForeColor = System.Drawing.Color.Black
        Me.txtCheckUsername.Location = New System.Drawing.Point(43, 97)
        Me.txtCheckUsername.Name = "txtCheckUsername"
        Me.txtCheckUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCheckUsername.Radius = 4
        Me.txtCheckUsername.SelectedText = ""
        Me.txtCheckUsername.Size = New System.Drawing.Size(220, 33)
        Me.txtCheckUsername.TabIndex = 6
        '
        'txtChangePass
        '
        Me.txtChangePass.BackColor = System.Drawing.Color.Transparent
        Me.txtChangePass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtChangePass.BorderColor = System.Drawing.Color.Silver
        Me.txtChangePass.BorderSize = 0
        Me.txtChangePass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChangePass.Enabled = False
        Me.txtChangePass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtChangePass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtChangePass.FocusedForeColor = System.Drawing.Color.Black
        Me.txtChangePass.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangePass.ForeColor = System.Drawing.Color.Black
        Me.txtChangePass.Location = New System.Drawing.Point(43, 316)
        Me.txtChangePass.Name = "txtChangePass"
        Me.txtChangePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChangePass.Radius = 4
        Me.txtChangePass.SelectedText = ""
        Me.txtChangePass.Size = New System.Drawing.Size(482, 33)
        Me.txtChangePass.TabIndex = 7
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtConfirmPass.BorderColor = System.Drawing.Color.Silver
        Me.txtConfirmPass.BorderSize = 0
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.Enabled = False
        Me.txtConfirmPass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtConfirmPass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtConfirmPass.FocusedForeColor = System.Drawing.Color.Black
        Me.txtConfirmPass.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPass.Location = New System.Drawing.Point(43, 405)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPass.Radius = 4
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.Size = New System.Drawing.Size(482, 33)
        Me.txtConfirmPass.TabIndex = 8
        '
        'btnChangePass
        '
        Me.btnChangePass.Animated = True
        Me.btnChangePass.AnimationHoverSpeed = 0.07!
        Me.btnChangePass.AnimationSpeed = 0.03!
        Me.btnChangePass.BackColor = System.Drawing.Color.Transparent
        Me.btnChangePass.BaseColor = System.Drawing.Color.Navy
        Me.btnChangePass.BorderColor = System.Drawing.Color.Black
        Me.btnChangePass.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnChangePass.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnChangePass.CheckedForeColor = System.Drawing.Color.White
        Me.btnChangePass.CheckedImage = Nothing
        Me.btnChangePass.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnChangePass.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChangePass.FocusedColor = System.Drawing.Color.Empty
        Me.btnChangePass.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.btnChangePass.ForeColor = System.Drawing.Color.White
        Me.btnChangePass.Image = Nothing
        Me.btnChangePass.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnChangePass.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChangePass.Location = New System.Drawing.Point(408, 499)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnChangePass.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnChangePass.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChangePass.OnHoverImage = Nothing
        Me.btnChangePass.OnHoverLineColor = System.Drawing.Color.Green
        Me.btnChangePass.OnPressedColor = System.Drawing.Color.Black
        Me.btnChangePass.Radius = 4
        Me.btnChangePass.Size = New System.Drawing.Size(117, 35)
        Me.btnChangePass.TabIndex = 34
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(38, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(38, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 26)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(38, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 26)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Confirm Password"
        '
        'lblPasswordStatus
        '
        Me.lblPasswordStatus.AutoSize = True
        Me.lblPasswordStatus.Font = New System.Drawing.Font("Poppins Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordStatus.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordStatus.Location = New System.Drawing.Point(39, 352)
        Me.lblPasswordStatus.Name = "lblPasswordStatus"
        Me.lblPasswordStatus.Size = New System.Drawing.Size(21, 19)
        Me.lblPasswordStatus.TabIndex = 56
        Me.lblPasswordStatus.Text = "......"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(299, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 26)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.Transparent
        Me.txtemail.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtemail.BorderColor = System.Drawing.Color.Silver
        Me.txtemail.BorderSize = 0
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtemail.FocusedForeColor = System.Drawing.Color.Black
        Me.txtemail.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(304, 97)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.Radius = 4
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(209, 33)
        Me.txtemail.TabIndex = 58
        '
        'otptimer
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(38, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 26)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "OTP"
        '
        'txtotp
        '
        Me.txtotp.BackColor = System.Drawing.Color.Transparent
        Me.txtotp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtotp.BorderColor = System.Drawing.Color.Silver
        Me.txtotp.BorderSize = 0
        Me.txtotp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtotp.Enabled = False
        Me.txtotp.FocusedBaseColor = System.Drawing.Color.White
        Me.txtotp.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtotp.FocusedForeColor = System.Drawing.Color.Black
        Me.txtotp.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtotp.ForeColor = System.Drawing.Color.Black
        Me.txtotp.Location = New System.Drawing.Point(43, 178)
        Me.txtotp.Name = "txtotp"
        Me.txtotp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtotp.Radius = 4
        Me.txtotp.SelectedText = ""
        Me.txtotp.Size = New System.Drawing.Size(220, 33)
        Me.txtotp.TabIndex = 60
        '
        'btnsendotp
        '
        Me.btnsendotp.Animated = True
        Me.btnsendotp.AnimationHoverSpeed = 0.07!
        Me.btnsendotp.AnimationSpeed = 0.03!
        Me.btnsendotp.BackColor = System.Drawing.Color.Transparent
        Me.btnsendotp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsendotp.BorderColor = System.Drawing.Color.Black
        Me.btnsendotp.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnsendotp.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnsendotp.CheckedForeColor = System.Drawing.Color.White
        Me.btnsendotp.CheckedImage = Nothing
        Me.btnsendotp.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnsendotp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsendotp.FocusedColor = System.Drawing.Color.Empty
        Me.btnsendotp.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.btnsendotp.ForeColor = System.Drawing.Color.White
        Me.btnsendotp.Image = Nothing
        Me.btnsendotp.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsendotp.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsendotp.Location = New System.Drawing.Point(281, 176)
        Me.btnsendotp.Name = "btnsendotp"
        Me.btnsendotp.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnsendotp.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsendotp.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsendotp.OnHoverImage = Nothing
        Me.btnsendotp.OnHoverLineColor = System.Drawing.Color.Green
        Me.btnsendotp.OnPressedColor = System.Drawing.Color.Black
        Me.btnsendotp.Radius = 4
        Me.btnsendotp.Size = New System.Drawing.Size(117, 35)
        Me.btnsendotp.TabIndex = 61
        Me.btnsendotp.Text = "Send OTP"
        Me.btnsendotp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.Animated = True
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = Nothing
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(404, 176)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.Green
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 4
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(117, 35)
        Me.GunaAdvenceButton2.TabIndex = 62
        Me.GunaAdvenceButton2.Text = "Verify OTP"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltimer
        '
        Me.lbltimer.AutoSize = True
        Me.lbltimer.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltimer.Location = New System.Drawing.Point(217, 242)
        Me.lbltimer.Name = "lbltimer"
        Me.lbltimer.Size = New System.Drawing.Size(123, 22)
        Me.lbltimer.TabIndex = 63
        Me.lbltimer.Text = "Resend OTP in: 30s"
        Me.lbltimer.Visible = False
        '
        'chkpassword
        '
        Me.chkpassword.AutoSize = True
        Me.chkpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpassword.Location = New System.Drawing.Point(43, 458)
        Me.chkpassword.Name = "chkpassword"
        Me.chkpassword.Size = New System.Drawing.Size(127, 19)
        Me.chkpassword.TabIndex = 64
        Me.chkpassword.Text = "Show Password"
        Me.chkpassword.UseVisualStyleBackColor = True
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 546)
        Me.Controls.Add(Me.chkpassword)
        Me.Controls.Add(Me.lbltimer)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.btnsendotp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtotp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblPasswordStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtChangePass)
        Me.Controls.Add(Me.txtCheckUsername)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txtConfirmPass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtChangePass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtCheckUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnChangePass As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPasswordStatus As Label
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnsendotp As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtotp As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtemail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents otptimer As Timer
    Friend WithEvents lbltimer As Label
    Friend WithEvents chkpassword As CheckBox
End Class
