<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Member_View_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRFID = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfirstname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmiddlename = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtgender = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcontact = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtage = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlastname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtemergency = New Guna.UI.WinForms.GunaTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtaddress = New Guna.UI.WinForms.GunaTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtmembersince = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.pnlstatus = New System.Windows.Forms.Panel()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.btncancelmember = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnupdatemember = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.memberpic = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlstatus.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(897, 50)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.view_user
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(833, 13)
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
        Me.GunaControlBox1.Location = New System.Drawing.Point(857, 12)
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
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Member Profile"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(677, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Profile Picture"
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
        Me.txtRFID.Location = New System.Drawing.Point(41, 108)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFID.Radius = 4
        Me.txtRFID.ReadOnly = True
        Me.txtRFID.SelectedText = ""
        Me.txtRFID.Size = New System.Drawing.Size(237, 33)
        Me.txtRFID.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "RFID"
        '
        'txtfirstname
        '
        Me.txtfirstname.BackColor = System.Drawing.Color.Transparent
        Me.txtfirstname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtfirstname.BorderColor = System.Drawing.Color.Silver
        Me.txtfirstname.BorderSize = 0
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtfirstname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtfirstname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtfirstname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.ForeColor = System.Drawing.Color.Black
        Me.txtfirstname.Location = New System.Drawing.Point(41, 184)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.Radius = 4
        Me.txtfirstname.ReadOnly = True
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.Size = New System.Drawing.Size(237, 33)
        Me.txtfirstname.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "First Name"
        '
        'txtmiddlename
        '
        Me.txtmiddlename.BackColor = System.Drawing.Color.Transparent
        Me.txtmiddlename.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtmiddlename.BorderColor = System.Drawing.Color.Silver
        Me.txtmiddlename.BorderSize = 0
        Me.txtmiddlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmiddlename.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmiddlename.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtmiddlename.FocusedForeColor = System.Drawing.Color.Black
        Me.txtmiddlename.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmiddlename.ForeColor = System.Drawing.Color.Black
        Me.txtmiddlename.Location = New System.Drawing.Point(41, 266)
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmiddlename.Radius = 4
        Me.txtmiddlename.ReadOnly = True
        Me.txtmiddlename.SelectedText = ""
        Me.txtmiddlename.Size = New System.Drawing.Size(237, 33)
        Me.txtmiddlename.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(37, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Middle Name"
        '
        'txtgender
        '
        Me.txtgender.BackColor = System.Drawing.Color.Transparent
        Me.txtgender.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtgender.BorderColor = System.Drawing.Color.Silver
        Me.txtgender.BorderSize = 0
        Me.txtgender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgender.FocusedBaseColor = System.Drawing.Color.White
        Me.txtgender.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtgender.FocusedForeColor = System.Drawing.Color.Black
        Me.txtgender.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.ForeColor = System.Drawing.Color.Black
        Me.txtgender.Location = New System.Drawing.Point(317, 266)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgender.Radius = 4
        Me.txtgender.ReadOnly = True
        Me.txtgender.SelectedText = ""
        Me.txtgender.Size = New System.Drawing.Size(237, 33)
        Me.txtgender.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(313, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Gender"
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
        Me.txtcontact.Location = New System.Drawing.Point(317, 184)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontact.Radius = 4
        Me.txtcontact.ReadOnly = True
        Me.txtcontact.SelectedText = ""
        Me.txtcontact.Size = New System.Drawing.Size(237, 33)
        Me.txtcontact.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(313, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 23)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Contact Number"
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
        Me.txtage.Location = New System.Drawing.Point(317, 108)
        Me.txtage.Name = "txtage"
        Me.txtage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtage.Radius = 4
        Me.txtage.ReadOnly = True
        Me.txtage.SelectedText = ""
        Me.txtage.Size = New System.Drawing.Size(237, 33)
        Me.txtage.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(313, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 23)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Age"
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.Color.Transparent
        Me.txtlastname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtlastname.BorderColor = System.Drawing.Color.Silver
        Me.txtlastname.BorderSize = 0
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtlastname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtlastname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtlastname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.ForeColor = System.Drawing.Color.Black
        Me.txtlastname.Location = New System.Drawing.Point(41, 342)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.Radius = 4
        Me.txtlastname.ReadOnly = True
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.Size = New System.Drawing.Size(237, 33)
        Me.txtlastname.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(37, 318)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 23)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Last Name"
        '
        'txtemergency
        '
        Me.txtemergency.BackColor = System.Drawing.Color.Transparent
        Me.txtemergency.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtemergency.BorderColor = System.Drawing.Color.Silver
        Me.txtemergency.BorderSize = 0
        Me.txtemergency.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemergency.FocusedBaseColor = System.Drawing.Color.White
        Me.txtemergency.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtemergency.FocusedForeColor = System.Drawing.Color.Black
        Me.txtemergency.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemergency.ForeColor = System.Drawing.Color.Black
        Me.txtemergency.Location = New System.Drawing.Point(317, 342)
        Me.txtemergency.Name = "txtemergency"
        Me.txtemergency.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemergency.Radius = 4
        Me.txtemergency.ReadOnly = True
        Me.txtemergency.SelectedText = ""
        Me.txtemergency.Size = New System.Drawing.Size(237, 33)
        Me.txtemergency.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(313, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 23)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Emergency Contact"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(313, 391)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 23)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Member Since"
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
        Me.txtaddress.Location = New System.Drawing.Point(41, 415)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.Radius = 4
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.Size = New System.Drawing.Size(237, 56)
        Me.txtaddress.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(37, 391)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 23)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Address"
        '
        'dtmembersince
        '
        Me.dtmembersince.BackColor = System.Drawing.Color.Transparent
        Me.dtmembersince.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtmembersince.BorderColor = System.Drawing.Color.Silver
        Me.dtmembersince.BorderSize = 0
        Me.dtmembersince.CustomFormat = Nothing
        Me.dtmembersince.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtmembersince.Enabled = False
        Me.dtmembersince.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dtmembersince.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.dtmembersince.ForeColor = System.Drawing.Color.Black
        Me.dtmembersince.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmembersince.Location = New System.Drawing.Point(317, 417)
        Me.dtmembersince.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtmembersince.MinDate = New Date(2025, 1, 26, 0, 0, 0, 0)
        Me.dtmembersince.Name = "dtmembersince"
        Me.dtmembersince.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtmembersince.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dtmembersince.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtmembersince.OnPressedColor = System.Drawing.Color.Black
        Me.dtmembersince.Radius = 4
        Me.dtmembersince.Size = New System.Drawing.Size(237, 33)
        Me.dtmembersince.TabIndex = 62
        Me.dtmembersince.Text = "26/01/2025"
        Me.dtmembersince.Value = New Date(2025, 1, 26, 0, 0, 0, 0)
        '
        'pnlstatus
        '
        Me.pnlstatus.Controls.Add(Me.lblstatus)
        Me.pnlstatus.Location = New System.Drawing.Point(582, 329)
        Me.pnlstatus.Name = "pnlstatus"
        Me.pnlstatus.Size = New System.Drawing.Size(279, 121)
        Me.pnlstatus.TabIndex = 63
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Black
        Me.lblstatus.Location = New System.Drawing.Point(93, 42)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(95, 36)
        Me.lblstatus.TabIndex = 33
        Me.lblstatus.Text = "Gender"
        '
        'btncancelmember
        '
        Me.btncancelmember.Animated = True
        Me.btncancelmember.AnimationHoverSpeed = 0.07!
        Me.btncancelmember.AnimationSpeed = 0.03!
        Me.btncancelmember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btncancelmember.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btncancelmember.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncancelmember.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncancelmember.CheckedForeColor = System.Drawing.Color.White
        Me.btncancelmember.CheckedImage = Global.Capstone_Project.My.Resources.Resources.cancelicon
        Me.btncancelmember.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncancelmember.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncancelmember.FocusedColor = System.Drawing.Color.Empty
        Me.btncancelmember.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btncancelmember.ForeColor = System.Drawing.Color.White
        Me.btncancelmember.Image = Global.Capstone_Project.My.Resources.Resources.cancelicon
        Me.btncancelmember.ImageSize = New System.Drawing.Size(25, 25)
        Me.btncancelmember.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncancelmember.Location = New System.Drawing.Point(836, 56)
        Me.btncancelmember.Name = "btncancelmember"
        Me.btncancelmember.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btncancelmember.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancelmember.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancelmember.OnHoverImage = Nothing
        Me.btncancelmember.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btncancelmember.OnPressedColor = System.Drawing.Color.Black
        Me.btncancelmember.Size = New System.Drawing.Size(43, 40)
        Me.btncancelmember.TabIndex = 65
        '
        'btnupdatemember
        '
        Me.btnupdatemember.Animated = True
        Me.btnupdatemember.AnimationHoverSpeed = 0.07!
        Me.btnupdatemember.AnimationSpeed = 0.03!
        Me.btnupdatemember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnupdatemember.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnupdatemember.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnupdatemember.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnupdatemember.CheckedForeColor = System.Drawing.Color.White
        Me.btnupdatemember.CheckedImage = Global.Capstone_Project.My.Resources.Resources.editicon
        Me.btnupdatemember.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnupdatemember.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupdatemember.FocusedColor = System.Drawing.Color.Empty
        Me.btnupdatemember.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnupdatemember.ForeColor = System.Drawing.Color.White
        Me.btnupdatemember.Image = Global.Capstone_Project.My.Resources.Resources.editicon
        Me.btnupdatemember.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnupdatemember.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnupdatemember.Location = New System.Drawing.Point(778, 56)
        Me.btnupdatemember.Name = "btnupdatemember"
        Me.btnupdatemember.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnupdatemember.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdatemember.OnHoverForeColor = System.Drawing.Color.White
        Me.btnupdatemember.OnHoverImage = Nothing
        Me.btnupdatemember.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnupdatemember.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdatemember.Size = New System.Drawing.Size(43, 40)
        Me.btnupdatemember.TabIndex = 64
        '
        'memberpic
        '
        Me.memberpic.BaseColor = System.Drawing.Color.White
        Me.memberpic.Image = Global.Capstone_Project.My.Resources.Resources.gymnast_11630721
        Me.memberpic.Location = New System.Drawing.Point(631, 116)
        Me.memberpic.Name = "memberpic"
        Me.memberpic.Size = New System.Drawing.Size(185, 175)
        Me.memberpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.memberpic.TabIndex = 20
        Me.memberpic.TabStop = False
        Me.memberpic.UseTransfarantBackground = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'Member_View_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(897, 517)
        Me.Controls.Add(Me.btncancelmember)
        Me.Controls.Add(Me.btnupdatemember)
        Me.Controls.Add(Me.pnlstatus)
        Me.Controls.Add(Me.dtmembersince)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtemergency)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmiddlename)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.memberpic)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Member_View_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member_View_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlstatus.ResumeLayout(False)
        Me.pnlstatus.PerformLayout()
        CType(Me.memberpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents memberpic As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents txtRFID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfirstname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmiddlename As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtgender As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcontact As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtage As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtlastname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtemergency As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtaddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dtmembersince As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents pnlstatus As Panel
    Friend WithEvents btnupdatemember As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btncancelmember As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblstatus As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
