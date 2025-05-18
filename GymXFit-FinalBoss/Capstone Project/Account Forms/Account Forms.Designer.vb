<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_Forms
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnbrowse = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pctprofile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.txtname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtconfirmpass = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnregister = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbmusertype = New Guna.UI.WinForms.GunaComboBox()
        Me.lblPasswordStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtemail = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctprofile, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(520, 50)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.add_user
        Me.PictureBox1.Location = New System.Drawing.Point(8, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 36)
        Me.PictureBox1.TabIndex = 6
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(460, 12)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox2.TabIndex = 5
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(484, 11)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "New Account"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnbrowse
        '
        Me.btnbrowse.Animated = True
        Me.btnbrowse.AnimationHoverSpeed = 0.07!
        Me.btnbrowse.AnimationSpeed = 0.03!
        Me.btnbrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnbrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbrowse.BorderColor = System.Drawing.Color.Black
        Me.btnbrowse.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnbrowse.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnbrowse.CheckedForeColor = System.Drawing.Color.White
        Me.btnbrowse.CheckedImage = Nothing
        Me.btnbrowse.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnbrowse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbrowse.FocusedColor = System.Drawing.Color.Empty
        Me.btnbrowse.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Image = Nothing
        Me.btnbrowse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbrowse.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbrowse.Location = New System.Drawing.Point(188, 232)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbrowse.OnHoverImage = Nothing
        Me.btnbrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbrowse.OnPressedColor = System.Drawing.Color.Black
        Me.btnbrowse.Radius = 4
        Me.btnbrowse.Size = New System.Drawing.Size(136, 35)
        Me.btnbrowse.TabIndex = 23
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(211, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Profile Picture"
        '
        'pctprofile
        '
        Me.pctprofile.BaseColor = System.Drawing.Color.White
        Me.pctprofile.Image = Global.Capstone_Project.My.Resources.Resources.gymnast_11630721
        Me.pctprofile.Location = New System.Drawing.Point(188, 74)
        Me.pctprofile.Name = "pctprofile"
        Me.pctprofile.Size = New System.Drawing.Size(136, 136)
        Me.pctprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctprofile.TabIndex = 21
        Me.pctprofile.TabStop = False
        Me.pctprofile.UseTransfarantBackground = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.Transparent
        Me.txtname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtname.BorderColor = System.Drawing.Color.Silver
        Me.txtname.BorderSize = 0
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(14, 343)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.Radius = 4
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(225, 33)
        Me.txtname.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Name"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtusername.BorderColor = System.Drawing.Color.Silver
        Me.txtusername.BorderSize = 0
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtusername.FocusedForeColor = System.Drawing.Color.Black
        Me.txtusername.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(280, 343)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Radius = 4
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(225, 33)
        Me.txtusername.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(277, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Username"
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.BackColor = System.Drawing.Color.Transparent
        Me.txtconfirmpass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtconfirmpass.BorderColor = System.Drawing.Color.Silver
        Me.txtconfirmpass.BorderSize = 0
        Me.txtconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmpass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtconfirmpass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtconfirmpass.FocusedForeColor = System.Drawing.Color.Black
        Me.txtconfirmpass.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpass.ForeColor = System.Drawing.Color.Black
        Me.txtconfirmpass.Location = New System.Drawing.Point(280, 413)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtconfirmpass.Radius = 4
        Me.txtconfirmpass.SelectedText = ""
        Me.txtconfirmpass.Size = New System.Drawing.Size(225, 33)
        Me.txtconfirmpass.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(277, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Confirm Password"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtpassword.BorderColor = System.Drawing.Color.Silver
        Me.txtpassword.BorderSize = 0
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtpassword.FocusedForeColor = System.Drawing.Color.Black
        Me.txtpassword.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(14, 413)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Radius = 4
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(225, 33)
        Me.txtpassword.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Password"
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
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(257, 549)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 4
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(117, 35)
        Me.GunaAdvenceButton3.TabIndex = 36
        Me.GunaAdvenceButton3.Text = "Cancel"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnregister.Location = New System.Drawing.Point(137, 549)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnregister.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregister.OnHoverForeColor = System.Drawing.Color.White
        Me.btnregister.OnHoverImage = Nothing
        Me.btnregister.OnHoverLineColor = System.Drawing.Color.Green
        Me.btnregister.OnPressedColor = System.Drawing.Color.Black
        Me.btnregister.Radius = 4
        Me.btnregister.Size = New System.Drawing.Size(117, 35)
        Me.btnregister.TabIndex = 35
        Me.btnregister.Text = "Register"
        Me.btnregister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "User Type"
        '
        'cbmusertype
        '
        Me.cbmusertype.BackColor = System.Drawing.Color.Transparent
        Me.cbmusertype.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cbmusertype.BorderColor = System.Drawing.Color.Silver
        Me.cbmusertype.BorderSize = 0
        Me.cbmusertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbmusertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmusertype.FocusedColor = System.Drawing.Color.Empty
        Me.cbmusertype.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmusertype.ForeColor = System.Drawing.Color.Black
        Me.cbmusertype.FormattingEnabled = True
        Me.cbmusertype.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.cbmusertype.Location = New System.Drawing.Point(14, 494)
        Me.cbmusertype.Name = "cbmusertype"
        Me.cbmusertype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cbmusertype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbmusertype.Radius = 4
        Me.cbmusertype.Size = New System.Drawing.Size(237, 28)
        Me.cbmusertype.TabIndex = 38
        '
        'lblPasswordStatus
        '
        Me.lblPasswordStatus.AutoSize = True
        Me.lblPasswordStatus.Font = New System.Drawing.Font("Poppins Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordStatus.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordStatus.Location = New System.Drawing.Point(10, 449)
        Me.lblPasswordStatus.Name = "lblPasswordStatus"
        Me.lblPasswordStatus.Size = New System.Drawing.Size(21, 19)
        Me.lblPasswordStatus.TabIndex = 39
        Me.lblPasswordStatus.Text = "......"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(277, 468)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Email"
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
        Me.txtemail.Location = New System.Drawing.Point(280, 489)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.Radius = 4
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(225, 33)
        Me.txtemail.TabIndex = 41
        '
        'Account_Forms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 610)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPasswordStatus)
        Me.Controls.Add(Me.cbmusertype)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pctprofile)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Account_Forms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account_Forms"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbrowse As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label9 As Label
    Friend WithEvents pctprofile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txtconfirmpass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnregister As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cbmusertype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lblPasswordStatus As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtemail As Guna.UI.WinForms.GunaTextBox
End Class
