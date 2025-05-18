<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member_Registration_Form
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRFID = New Guna.UI.WinForms.GunaTextBox()
        Me.txtfname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtaddress = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btncapture = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdbmale = New Guna.UI.WinForms.GunaRadioButton()
        Me.rdbfemale = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtage = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcontact = New Guna.UI.WinForms.GunaTextBox()
        Me.txtemergencycontact = New Guna.UI.WinForms.GunaTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnregister = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.dtmembersince = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.memberpic = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memberpic, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(535, 50)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.add_user
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 36)
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(471, 13)
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
        Me.GunaControlBox1.Location = New System.Drawing.Point(495, 12)
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
        Me.Label1.Location = New System.Drawing.Point(41, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Member Registration"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RFID"
        '
        'txtRFID
        '
        Me.txtRFID.BackColor = System.Drawing.Color.Transparent
        Me.txtRFID.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtRFID.BorderColor = System.Drawing.Color.Silver
        Me.txtRFID.BorderSize = 0
        Me.txtRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRFID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtRFID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtRFID.FocusedForeColor = System.Drawing.Color.Black
        Me.txtRFID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Black
        Me.txtRFID.Location = New System.Drawing.Point(16, 114)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFID.Radius = 4
        Me.txtRFID.SelectedText = ""
        Me.txtRFID.Size = New System.Drawing.Size(237, 33)
        Me.txtRFID.TabIndex = 5
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.Transparent
        Me.txtfname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtfname.BorderColor = System.Drawing.Color.Silver
        Me.txtfname.BorderSize = 0
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtfname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtfname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtfname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.Black
        Me.txtfname.Location = New System.Drawing.Point(16, 174)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.Radius = 4
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(237, 33)
        Me.txtfname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name"
        '
        'txtmname
        '
        Me.txtmname.BackColor = System.Drawing.Color.Transparent
        Me.txtmname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtmname.BorderColor = System.Drawing.Color.Silver
        Me.txtmname.BorderSize = 0
        Me.txtmname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtmname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtmname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.ForeColor = System.Drawing.Color.Black
        Me.txtmname.Location = New System.Drawing.Point(16, 234)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmname.Radius = 4
        Me.txtmname.SelectedText = ""
        Me.txtmname.Size = New System.Drawing.Size(237, 33)
        Me.txtmname.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Middle Name"
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.Color.Transparent
        Me.txtlname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtlname.BorderColor = System.Drawing.Color.Silver
        Me.txtlname.BorderSize = 0
        Me.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtlname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtlname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtlname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.Color.Black
        Me.txtlname.Location = New System.Drawing.Point(16, 304)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlname.Radius = 4
        Me.txtlname.SelectedText = ""
        Me.txtlname.Size = New System.Drawing.Size(237, 33)
        Me.txtlname.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Last Name"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.Transparent
        Me.txtaddress.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtaddress.BorderColor = System.Drawing.Color.Silver
        Me.txtaddress.BorderSize = 0
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.FocusedBaseColor = System.Drawing.Color.White
        Me.txtaddress.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtaddress.FocusedForeColor = System.Drawing.Color.Black
        Me.txtaddress.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(16, 484)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.Radius = 4
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.Size = New System.Drawing.Size(492, 114)
        Me.txtaddress.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(347, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Profile Picture"
        '
        'btncapture
        '
        Me.btncapture.Animated = True
        Me.btncapture.AnimationHoverSpeed = 0.07!
        Me.btncapture.AnimationSpeed = 0.03!
        Me.btncapture.BackColor = System.Drawing.Color.Transparent
        Me.btncapture.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncapture.BorderColor = System.Drawing.Color.Black
        Me.btncapture.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncapture.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncapture.CheckedForeColor = System.Drawing.Color.White
        Me.btncapture.CheckedImage = Nothing
        Me.btncapture.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncapture.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncapture.FocusedColor = System.Drawing.Color.Empty
        Me.btncapture.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapture.ForeColor = System.Drawing.Color.White
        Me.btncapture.Image = Nothing
        Me.btncapture.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncapture.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncapture.Location = New System.Drawing.Point(324, 234)
        Me.btncapture.Name = "btncapture"
        Me.btncapture.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncapture.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncapture.OnHoverForeColor = System.Drawing.Color.White
        Me.btncapture.OnHoverImage = Nothing
        Me.btncapture.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncapture.OnPressedColor = System.Drawing.Color.Black
        Me.btncapture.Radius = 4
        Me.btncapture.Size = New System.Drawing.Size(136, 35)
        Me.btncapture.TabIndex = 20
        Me.btncapture.Text = "Capture"
        Me.btncapture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(267, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Sex"
        '
        'rdbmale
        '
        Me.rdbmale.BaseColor = System.Drawing.Color.White
        Me.rdbmale.CheckedOffColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.rdbmale.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.rdbmale.FillColor = System.Drawing.Color.White
        Me.rdbmale.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbmale.Location = New System.Drawing.Point(294, 306)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(60, 20)
        Me.rdbmale.TabIndex = 22
        Me.rdbmale.Text = "Male"
        '
        'rdbfemale
        '
        Me.rdbfemale.BaseColor = System.Drawing.Color.White
        Me.rdbfemale.CheckedOffColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.rdbfemale.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.rdbfemale.FillColor = System.Drawing.Color.White
        Me.rdbfemale.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbfemale.Location = New System.Drawing.Point(413, 306)
        Me.rdbfemale.Name = "rdbfemale"
        Me.rdbfemale.Size = New System.Drawing.Size(76, 20)
        Me.rdbfemale.TabIndex = 23
        Me.rdbfemale.Text = "Female"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age"
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.Transparent
        Me.txtage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtage.BorderColor = System.Drawing.Color.Silver
        Me.txtage.BorderSize = 0
        Me.txtage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtage.FocusedBaseColor = System.Drawing.Color.White
        Me.txtage.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtage.FocusedForeColor = System.Drawing.Color.Black
        Me.txtage.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(16, 364)
        Me.txtage.Name = "txtage"
        Me.txtage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtage.Radius = 4
        Me.txtage.SelectedText = ""
        Me.txtage.Size = New System.Drawing.Size(237, 33)
        Me.txtage.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contact No."
        '
        'txtcontact
        '
        Me.txtcontact.BackColor = System.Drawing.Color.Transparent
        Me.txtcontact.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcontact.BorderColor = System.Drawing.Color.Silver
        Me.txtcontact.BorderSize = 0
        Me.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontact.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcontact.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcontact.FocusedForeColor = System.Drawing.Color.Black
        Me.txtcontact.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.ForeColor = System.Drawing.Color.Black
        Me.txtcontact.Location = New System.Drawing.Point(16, 424)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontact.Radius = 4
        Me.txtcontact.SelectedText = ""
        Me.txtcontact.Size = New System.Drawing.Size(237, 33)
        Me.txtcontact.TabIndex = 15
        '
        'txtemergencycontact
        '
        Me.txtemergencycontact.BackColor = System.Drawing.Color.Transparent
        Me.txtemergencycontact.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtemergencycontact.BorderColor = System.Drawing.Color.Silver
        Me.txtemergencycontact.BorderSize = 0
        Me.txtemergencycontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemergencycontact.FocusedBaseColor = System.Drawing.Color.White
        Me.txtemergencycontact.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtemergencycontact.FocusedForeColor = System.Drawing.Color.Black
        Me.txtemergencycontact.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemergencycontact.ForeColor = System.Drawing.Color.Black
        Me.txtemergencycontact.Location = New System.Drawing.Point(271, 424)
        Me.txtemergencycontact.Name = "txtemergencycontact"
        Me.txtemergencycontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemergencycontact.Radius = 4
        Me.txtemergencycontact.SelectedText = ""
        Me.txtemergencycontact.Size = New System.Drawing.Size(237, 33)
        Me.txtemergencycontact.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(267, 400)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Emergency Contact No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(267, 340)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Member Since"
        '
        'btnregister
        '
        Me.btnregister.Animated = True
        Me.btnregister.AnimationHoverSpeed = 0.07!
        Me.btnregister.AnimationSpeed = 0.03!
        Me.btnregister.BackColor = System.Drawing.Color.Transparent
        Me.btnregister.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregister.BorderColor = System.Drawing.Color.Black
        Me.btnregister.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnregister.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnregister.CheckedForeColor = System.Drawing.Color.White
        Me.btnregister.CheckedImage = Nothing
        Me.btnregister.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnregister.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnregister.FocusedColor = System.Drawing.Color.Empty
        Me.btnregister.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnregister.ForeColor = System.Drawing.Color.White
        Me.btnregister.Image = Nothing
        Me.btnregister.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnregister.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregister.Location = New System.Drawing.Point(146, 612)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnregister.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregister.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregister.OnHoverImage = Nothing
        Me.btnregister.OnHoverLineColor = System.Drawing.Color.Green
        Me.btnregister.OnPressedColor = System.Drawing.Color.Black
        Me.btnregister.Radius = 4
        Me.btnregister.Size = New System.Drawing.Size(117, 35)
        Me.btnregister.TabIndex = 33
        Me.btnregister.Text = "Register"
        Me.btnregister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.Animated = True
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GunaAdvenceButton3.BorderSize = 2
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = Nothing
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaAdvenceButton3.Image = Nothing
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(266, 612)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 4
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(117, 35)
        Me.GunaAdvenceButton3.TabIndex = 34
        Me.GunaAdvenceButton3.Text = "Cancel"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtmembersince
        '
        Me.dtmembersince.BackColor = System.Drawing.Color.Transparent
        Me.dtmembersince.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtmembersince.BorderColor = System.Drawing.Color.Silver
        Me.dtmembersince.BorderSize = 0
        Me.dtmembersince.CustomFormat = Nothing
        Me.dtmembersince.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtmembersince.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dtmembersince.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.dtmembersince.ForeColor = System.Drawing.Color.Black
        Me.dtmembersince.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmembersince.Location = New System.Drawing.Point(271, 364)
        Me.dtmembersince.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtmembersince.MinDate = New Date(2025, 1, 26, 0, 0, 0, 0)
        Me.dtmembersince.Name = "dtmembersince"
        Me.dtmembersince.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtmembersince.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtmembersince.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtmembersince.OnPressedColor = System.Drawing.Color.Black
        Me.dtmembersince.Radius = 4
        Me.dtmembersince.Size = New System.Drawing.Size(237, 33)
        Me.dtmembersince.TabIndex = 35
        Me.dtmembersince.Text = "1/26/2025"
        Me.dtmembersince.Value = New Date(2025, 1, 26, 0, 0, 0, 0)
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'memberpic
        '
        Me.memberpic.BackColor = System.Drawing.Color.White
        Me.memberpic.BaseColor = System.Drawing.Color.White
        Me.memberpic.Image = Global.Capstone_Project.My.Resources.Resources.gymnast_1163072
        Me.memberpic.Location = New System.Drawing.Point(324, 71)
        Me.memberpic.Name = "memberpic"
        Me.memberpic.Size = New System.Drawing.Size(143, 136)
        Me.memberpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.memberpic.TabIndex = 18
        Me.memberpic.TabStop = False
        Me.memberpic.UseTransfarantBackground = False
        '
        'Member_Registration_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(535, 663)
        Me.Controls.Add(Me.dtmembersince)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.txtemergencycontact)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.rdbfemale)
        Me.Controls.Add(Me.rdbmale)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btncapture)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.memberpic)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Member_Registration_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member_Registration_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memberpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRFID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtaddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtlname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents memberpic As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btncapture As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label9 As Label
    Friend WithEvents rdbfemale As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents rdbmale As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtemergencycontact As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcontact As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtage As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnregister As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents dtmembersince As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
