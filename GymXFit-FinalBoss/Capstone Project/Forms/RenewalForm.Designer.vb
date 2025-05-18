<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenewalForm
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
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.txtdate = New Guna.UI.WinForms.GunaTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbmptype = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbservices = New Guna.UI.WinForms.GunaComboBox()
        Me.txtchange = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtVisits = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtpayment = New Guna.UI.WinForms.GunaTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotal = New Guna.UI.WinForms.GunaTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtreferenceno = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnextdue = New Guna.UI.WinForms.GunaTextBox()
        Me.btnRenew = New Guna.UI.WinForms.GunaTileButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuGroupBox1 = New Bunifu.UI.WinForms.BunifuGroupBox()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.txtrfid = New Guna.UI.WinForms.GunaTextBox()
        Me.BunifuGroupBox2 = New Bunifu.UI.WinForms.BunifuGroupBox()
        Me.txtnumberofmonth = New Guna.UI.WinForms.GunaTextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtamount = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdesc = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstatus = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttransno = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pcpicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel1.SuspendLayout()
        Me.BunifuGroupBox1.SuspendLayout()
        Me.BunifuGroupBox2.SuspendLayout()
        CType(Me.pcpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'txtdate
        '
        Me.txtdate.BackColor = System.Drawing.Color.Transparent
        Me.txtdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtdate.BorderColor = System.Drawing.Color.Silver
        Me.txtdate.BorderSize = 1
        Me.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdate.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdate.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtdate.FocusedForeColor = System.Drawing.Color.Black
        Me.txtdate.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Location = New System.Drawing.Point(320, 275)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdate.Radius = 4
        Me.txtdate.ReadOnly = True
        Me.txtdate.SelectedText = ""
        Me.txtdate.Size = New System.Drawing.Size(216, 30)
        Me.txtdate.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(189, 279)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 25)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Date:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbmptype
        '
        Me.cbmptype.BackColor = System.Drawing.Color.Transparent
        Me.cbmptype.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cbmptype.BorderColor = System.Drawing.Color.Silver
        Me.cbmptype.BorderSize = 1
        Me.cbmptype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbmptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmptype.FocusedColor = System.Drawing.Color.Empty
        Me.cbmptype.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cbmptype.ForeColor = System.Drawing.Color.Black
        Me.cbmptype.FormattingEnabled = True
        Me.cbmptype.Items.AddRange(New Object() {"CASH", "G-CASH"})
        Me.cbmptype.Location = New System.Drawing.Point(703, 75)
        Me.cbmptype.Name = "cbmptype"
        Me.cbmptype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cbmptype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbmptype.Radius = 4
        Me.cbmptype.Size = New System.Drawing.Size(216, 28)
        Me.cbmptype.TabIndex = 65
        '
        'cmbservices
        '
        Me.cmbservices.BackColor = System.Drawing.Color.Transparent
        Me.cmbservices.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbservices.BorderColor = System.Drawing.Color.Silver
        Me.cmbservices.BorderSize = 1
        Me.cmbservices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbservices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbservices.FocusedColor = System.Drawing.Color.Empty
        Me.cmbservices.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cmbservices.ForeColor = System.Drawing.Color.Black
        Me.cmbservices.FormattingEnabled = True
        Me.cmbservices.Items.AddRange(New Object() {"MONTHLY MEMBERSHIP", "DAILY SESSION"})
        Me.cmbservices.Location = New System.Drawing.Point(320, 117)
        Me.cmbservices.Name = "cmbservices"
        Me.cmbservices.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmbservices.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbservices.Radius = 4
        Me.cmbservices.Size = New System.Drawing.Size(216, 28)
        Me.cmbservices.TabIndex = 64
        '
        'txtchange
        '
        Me.txtchange.BackColor = System.Drawing.Color.Transparent
        Me.txtchange.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtchange.BorderColor = System.Drawing.Color.Silver
        Me.txtchange.BorderSize = 1
        Me.txtchange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtchange.FocusedBaseColor = System.Drawing.Color.White
        Me.txtchange.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtchange.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtchange.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtchange.Location = New System.Drawing.Point(703, 245)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtchange.Radius = 4
        Me.txtchange.ReadOnly = True
        Me.txtchange.SelectedText = ""
        Me.txtchange.Size = New System.Drawing.Size(216, 38)
        Me.txtchange.TabIndex = 30
        Me.txtchange.Text = "00.00"
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtVisits)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 50)
        Me.Panel1.TabIndex = 41
        '
        'txtVisits
        '
        Me.txtVisits.BackColor = System.Drawing.Color.Transparent
        Me.txtVisits.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtVisits.BorderColor = System.Drawing.Color.Silver
        Me.txtVisits.BorderSize = 1
        Me.txtVisits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVisits.FocusedBaseColor = System.Drawing.Color.White
        Me.txtVisits.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtVisits.FocusedForeColor = System.Drawing.Color.Black
        Me.txtVisits.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtVisits.ForeColor = System.Drawing.Color.Black
        Me.txtVisits.Location = New System.Drawing.Point(385, 12)
        Me.txtVisits.Name = "txtVisits"
        Me.txtVisits.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVisits.Radius = 4
        Me.txtVisits.ReadOnly = True
        Me.txtVisits.SelectedText = ""
        Me.txtVisits.Size = New System.Drawing.Size(216, 30)
        Me.txtVisits.TabIndex = 68
        Me.txtVisits.Visible = False
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(902, 12)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(32, 26)
        Me.GunaControlBox2.TabIndex = 2
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(935, 12)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(32, 26)
        Me.GunaControlBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Renewal Form"
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.White
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancel.BorderSize = 2
        Me.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCancel.CheckedForeColor = System.Drawing.Color.White
        Me.btnCancel.CheckedImage = Nothing
        Me.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.LineColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(850, 513)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Radius = 4
        Me.btnCancel.Size = New System.Drawing.Size(117, 35)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpayment
        '
        Me.txtpayment.BackColor = System.Drawing.Color.Transparent
        Me.txtpayment.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtpayment.BorderColor = System.Drawing.Color.Silver
        Me.txtpayment.BorderSize = 1
        Me.txtpayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpayment.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpayment.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtpayment.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtpayment.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtpayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtpayment.Location = New System.Drawing.Point(703, 198)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpayment.Radius = 4
        Me.txtpayment.SelectedText = ""
        Me.txtpayment.Size = New System.Drawing.Size(216, 38)
        Me.txtpayment.TabIndex = 29
        Me.txtpayment.Text = "00.00"
        Me.txtpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(565, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 25)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Change:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(564, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 25)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Amount:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.Transparent
        Me.txttotal.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txttotal.BorderColor = System.Drawing.Color.Silver
        Me.txttotal.BorderSize = 1
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.FocusedBaseColor = System.Drawing.Color.White
        Me.txttotal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txttotal.FocusedForeColor = System.Drawing.Color.White
        Me.txttotal.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txttotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txttotal.Location = New System.Drawing.Point(703, 151)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.Radius = 4
        Me.txttotal.ReadOnly = True
        Me.txttotal.SelectedText = ""
        Me.txttotal.Size = New System.Drawing.Size(216, 38)
        Me.txttotal.TabIndex = 25
        Me.txttotal.Text = "00.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(564, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtreferenceno
        '
        Me.txtreferenceno.BackColor = System.Drawing.Color.Transparent
        Me.txtreferenceno.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtreferenceno.BorderColor = System.Drawing.Color.Silver
        Me.txtreferenceno.BorderSize = 1
        Me.txtreferenceno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreferenceno.FocusedBaseColor = System.Drawing.Color.White
        Me.txtreferenceno.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtreferenceno.FocusedForeColor = System.Drawing.Color.Black
        Me.txtreferenceno.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtreferenceno.ForeColor = System.Drawing.Color.Black
        Me.txtreferenceno.Location = New System.Drawing.Point(703, 112)
        Me.txtreferenceno.Name = "txtreferenceno"
        Me.txtreferenceno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreferenceno.Radius = 4
        Me.txtreferenceno.SelectedText = ""
        Me.txtreferenceno.Size = New System.Drawing.Size(216, 30)
        Me.txtreferenceno.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(564, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Reference No:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(564, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Payment Type:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnextdue
        '
        Me.txtnextdue.BackColor = System.Drawing.Color.Transparent
        Me.txtnextdue.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtnextdue.BorderColor = System.Drawing.Color.Silver
        Me.txtnextdue.BorderSize = 1
        Me.txtnextdue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnextdue.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnextdue.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtnextdue.FocusedForeColor = System.Drawing.Color.Black
        Me.txtnextdue.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtnextdue.ForeColor = System.Drawing.Color.Black
        Me.txtnextdue.Location = New System.Drawing.Point(703, 36)
        Me.txtnextdue.Name = "txtnextdue"
        Me.txtnextdue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnextdue.Radius = 4
        Me.txtnextdue.ReadOnly = True
        Me.txtnextdue.SelectedText = ""
        Me.txtnextdue.Size = New System.Drawing.Size(216, 30)
        Me.txtnextdue.TabIndex = 19
        '
        'btnRenew
        '
        Me.btnRenew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenew.Animated = True
        Me.btnRenew.AnimationHoverSpeed = 0.07!
        Me.btnRenew.AnimationSpeed = 0.03!
        Me.btnRenew.BackColor = System.Drawing.Color.Transparent
        Me.btnRenew.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnRenew.BorderColor = System.Drawing.Color.Transparent
        Me.btnRenew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRenew.FocusedColor = System.Drawing.Color.Empty
        Me.btnRenew.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.btnRenew.ForeColor = System.Drawing.Color.White
        Me.btnRenew.Image = Nothing
        Me.btnRenew.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnRenew.Location = New System.Drawing.Point(707, 513)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnRenew.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnRenew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRenew.OnHoverImage = Nothing
        Me.btnRenew.OnPressedColor = System.Drawing.Color.Black
        Me.btnRenew.Radius = 6
        Me.btnRenew.Size = New System.Drawing.Size(137, 35)
        Me.btnRenew.TabIndex = 39
        Me.btnRenew.Text = "Renew"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(564, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Next Due Date:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGroupBox1
        '
        Me.BunifuGroupBox1.BorderColor = System.Drawing.Color.Silver
        Me.BunifuGroupBox1.BorderRadius = 1
        Me.BunifuGroupBox1.BorderThickness = 1
        Me.BunifuGroupBox1.Controls.Add(Me.lblfullname)
        Me.BunifuGroupBox1.Controls.Add(Me.txtrfid)
        Me.BunifuGroupBox1.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.BunifuGroupBox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuGroupBox1.LabelIndent = 10
        Me.BunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid
        Me.BunifuGroupBox1.Location = New System.Drawing.Point(15, 70)
        Me.BunifuGroupBox1.Name = "BunifuGroupBox1"
        Me.BunifuGroupBox1.Size = New System.Drawing.Size(949, 89)
        Me.BunifuGroupBox1.TabIndex = 37
        Me.BunifuGroupBox1.TabStop = False
        Me.BunifuGroupBox1.Text = "Scan RFID Here"
        '
        'lblfullname
        '
        Me.lblfullname.Font = New System.Drawing.Font("Poppins", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.Color.Black
        Me.lblfullname.Location = New System.Drawing.Point(483, 23)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(460, 54)
        Me.lblfullname.TabIndex = 2
        Me.lblfullname.Text = "------"
        Me.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtrfid
        '
        Me.txtrfid.BackColor = System.Drawing.Color.Transparent
        Me.txtrfid.BaseColor = System.Drawing.Color.White
        Me.txtrfid.BorderColor = System.Drawing.Color.Silver
        Me.txtrfid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrfid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtrfid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtrfid.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtrfid.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrfid.ForeColor = System.Drawing.Color.Black
        Me.txtrfid.Location = New System.Drawing.Point(17, 29)
        Me.txtrfid.Name = "txtrfid"
        Me.txtrfid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrfid.Radius = 4
        Me.txtrfid.SelectedText = ""
        Me.txtrfid.Size = New System.Drawing.Size(309, 41)
        Me.txtrfid.TabIndex = 6
        Me.txtrfid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuGroupBox2
        '
        Me.BunifuGroupBox2.BorderColor = System.Drawing.Color.Silver
        Me.BunifuGroupBox2.BorderRadius = 1
        Me.BunifuGroupBox2.BorderThickness = 1
        Me.BunifuGroupBox2.Controls.Add(Me.txtdate)
        Me.BunifuGroupBox2.Controls.Add(Me.Label14)
        Me.BunifuGroupBox2.Controls.Add(Me.cbmptype)
        Me.BunifuGroupBox2.Controls.Add(Me.cmbservices)
        Me.BunifuGroupBox2.Controls.Add(Me.txtchange)
        Me.BunifuGroupBox2.Controls.Add(Me.txtpayment)
        Me.BunifuGroupBox2.Controls.Add(Me.Label13)
        Me.BunifuGroupBox2.Controls.Add(Me.Label12)
        Me.BunifuGroupBox2.Controls.Add(Me.txttotal)
        Me.BunifuGroupBox2.Controls.Add(Me.Label11)
        Me.BunifuGroupBox2.Controls.Add(Me.txtreferenceno)
        Me.BunifuGroupBox2.Controls.Add(Me.Label10)
        Me.BunifuGroupBox2.Controls.Add(Me.Label9)
        Me.BunifuGroupBox2.Controls.Add(Me.txtnextdue)
        Me.BunifuGroupBox2.Controls.Add(Me.Label8)
        Me.BunifuGroupBox2.Controls.Add(Me.txtnumberofmonth)
        Me.BunifuGroupBox2.Controls.Add(Me.lblDuration)
        Me.BunifuGroupBox2.Controls.Add(Me.txtamount)
        Me.BunifuGroupBox2.Controls.Add(Me.Label6)
        Me.BunifuGroupBox2.Controls.Add(Me.txtdesc)
        Me.BunifuGroupBox2.Controls.Add(Me.Label5)
        Me.BunifuGroupBox2.Controls.Add(Me.Label4)
        Me.BunifuGroupBox2.Controls.Add(Me.txtstatus)
        Me.BunifuGroupBox2.Controls.Add(Me.Label2)
        Me.BunifuGroupBox2.Controls.Add(Me.txttransno)
        Me.BunifuGroupBox2.Controls.Add(Me.Label3)
        Me.BunifuGroupBox2.Controls.Add(Me.pcpicture)
        Me.BunifuGroupBox2.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.BunifuGroupBox2.ForeColor = System.Drawing.Color.Black
        Me.BunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuGroupBox2.LabelIndent = 10
        Me.BunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid
        Me.BunifuGroupBox2.Location = New System.Drawing.Point(15, 172)
        Me.BunifuGroupBox2.Name = "BunifuGroupBox2"
        Me.BunifuGroupBox2.Size = New System.Drawing.Size(949, 331)
        Me.BunifuGroupBox2.TabIndex = 38
        Me.BunifuGroupBox2.TabStop = False
        Me.BunifuGroupBox2.Text = "Payment Details"
        '
        'txtnumberofmonth
        '
        Me.txtnumberofmonth.BackColor = System.Drawing.Color.Transparent
        Me.txtnumberofmonth.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtnumberofmonth.BorderColor = System.Drawing.Color.Silver
        Me.txtnumberofmonth.BorderSize = 1
        Me.txtnumberofmonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnumberofmonth.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnumberofmonth.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtnumberofmonth.FocusedForeColor = System.Drawing.Color.Black
        Me.txtnumberofmonth.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtnumberofmonth.ForeColor = System.Drawing.Color.Black
        Me.txtnumberofmonth.Location = New System.Drawing.Point(320, 232)
        Me.txtnumberofmonth.Name = "txtnumberofmonth"
        Me.txtnumberofmonth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnumberofmonth.Radius = 4
        Me.txtnumberofmonth.SelectedText = ""
        Me.txtnumberofmonth.Size = New System.Drawing.Size(216, 30)
        Me.txtnumberofmonth.TabIndex = 17
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDuration.ForeColor = System.Drawing.Color.Black
        Me.lblDuration.Location = New System.Drawing.Point(189, 236)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(84, 25)
        Me.lblDuration.TabIndex = 16
        Me.lblDuration.Text = "Duration:"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.Transparent
        Me.txtamount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtamount.BorderColor = System.Drawing.Color.Silver
        Me.txtamount.BorderSize = 1
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.FocusedBaseColor = System.Drawing.Color.White
        Me.txtamount.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtamount.FocusedForeColor = System.Drawing.Color.Black
        Me.txtamount.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtamount.ForeColor = System.Drawing.Color.Black
        Me.txtamount.Location = New System.Drawing.Point(320, 193)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.Radius = 4
        Me.txtamount.ReadOnly = True
        Me.txtamount.SelectedText = ""
        Me.txtamount.Size = New System.Drawing.Size(216, 30)
        Me.txtamount.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(189, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Amount:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdesc
        '
        Me.txtdesc.BackColor = System.Drawing.Color.Transparent
        Me.txtdesc.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtdesc.BorderColor = System.Drawing.Color.Silver
        Me.txtdesc.BorderSize = 1
        Me.txtdesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdesc.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdesc.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtdesc.FocusedForeColor = System.Drawing.Color.Black
        Me.txtdesc.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtdesc.ForeColor = System.Drawing.Color.Black
        Me.txtdesc.Location = New System.Drawing.Point(320, 154)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdesc.Radius = 4
        Me.txtdesc.ReadOnly = True
        Me.txtdesc.SelectedText = ""
        Me.txtdesc.Size = New System.Drawing.Size(216, 30)
        Me.txtdesc.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(189, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Description:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(189, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Services:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtstatus
        '
        Me.txtstatus.BackColor = System.Drawing.Color.Transparent
        Me.txtstatus.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtstatus.BorderColor = System.Drawing.Color.Silver
        Me.txtstatus.BorderSize = 1
        Me.txtstatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstatus.FocusedBaseColor = System.Drawing.Color.White
        Me.txtstatus.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtstatus.FocusedForeColor = System.Drawing.Color.Black
        Me.txtstatus.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtstatus.ForeColor = System.Drawing.Color.Black
        Me.txtstatus.Location = New System.Drawing.Point(320, 78)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstatus.Radius = 4
        Me.txtstatus.ReadOnly = True
        Me.txtstatus.SelectedText = ""
        Me.txtstatus.Size = New System.Drawing.Size(216, 30)
        Me.txtstatus.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(189, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Status:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txttransno
        '
        Me.txttransno.BackColor = System.Drawing.Color.Transparent
        Me.txttransno.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txttransno.BorderColor = System.Drawing.Color.Silver
        Me.txttransno.BorderSize = 1
        Me.txttransno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttransno.FocusedBaseColor = System.Drawing.Color.White
        Me.txttransno.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txttransno.FocusedForeColor = System.Drawing.Color.Black
        Me.txttransno.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txttransno.ForeColor = System.Drawing.Color.Black
        Me.txttransno.Location = New System.Drawing.Point(320, 39)
        Me.txttransno.Name = "txttransno"
        Me.txttransno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttransno.Radius = 4
        Me.txttransno.ReadOnly = True
        Me.txttransno.SelectedText = ""
        Me.txttransno.Size = New System.Drawing.Size(216, 30)
        Me.txttransno.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(189, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Transaction No:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcpicture
        '
        Me.pcpicture.BaseColor = System.Drawing.Color.White
        Me.pcpicture.Image = Global.Capstone_Project.My.Resources.Resources.gymnast_1163072
        Me.pcpicture.Location = New System.Drawing.Point(8, 75)
        Me.pcpicture.Name = "pcpicture"
        Me.pcpicture.Size = New System.Drawing.Size(180, 176)
        Me.pcpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcpicture.TabIndex = 0
        Me.pcpicture.TabStop = False
        Me.pcpicture.UseTransfarantBackground = False
        '
        'RenewalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 556)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.BunifuGroupBox1)
        Me.Controls.Add(Me.BunifuGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RenewalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RenewalForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGroupBox1.ResumeLayout(False)
        Me.BunifuGroupBox2.ResumeLayout(False)
        Me.BunifuGroupBox2.PerformLayout()
        CType(Me.pcpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txtdate As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbmptype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbservices As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtchange As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtpayment As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txttotal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtreferenceno As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnextdue As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnRenew As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGroupBox1 As Bunifu.UI.WinForms.BunifuGroupBox
    Friend WithEvents lblfullname As Label
    Friend WithEvents txtrfid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BunifuGroupBox2 As Bunifu.UI.WinForms.BunifuGroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumberofmonth As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents txtamount As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdesc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtstatus As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txttransno As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pcpicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents txtVisits As Guna.UI.WinForms.GunaTextBox
End Class
