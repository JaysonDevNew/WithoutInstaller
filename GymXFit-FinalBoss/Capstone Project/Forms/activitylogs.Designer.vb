<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class activitylogs
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSession = New Guna.UI.WinForms.GunaTileButton()
        Me.dttimenow = New System.Windows.Forms.DateTimePicker()
        Me.dgvloghistory = New Guna.UI.WinForms.GunaDataGridView()
        Me.rfid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeinn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.memberpic = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.txtRFID = New Guna.UI.WinForms.GunaTextBox()
        Me.lblservices = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.dtdatenow = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldatentime = New System.Windows.Forms.Label()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.datentime = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TimerFocus = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvloghistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.memberpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 718)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1031, 718)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbltime)
        Me.Panel5.Controls.Add(Me.btnSession)
        Me.Panel5.Controls.Add(Me.dttimenow)
        Me.Panel5.Controls.Add(Me.dgvloghistory)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.dtdatenow)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1031, 633)
        Me.Panel5.TabIndex = 3
        '
        'btnSession
        '
        Me.btnSession.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSession.Animated = True
        Me.btnSession.AnimationHoverSpeed = 0.07!
        Me.btnSession.AnimationSpeed = 0.03!
        Me.btnSession.BackColor = System.Drawing.Color.Transparent
        Me.btnSession.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnSession.BorderColor = System.Drawing.Color.Transparent
        Me.btnSession.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSession.FocusedColor = System.Drawing.Color.Empty
        Me.btnSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSession.ForeColor = System.Drawing.Color.White
        Me.btnSession.Image = Nothing
        Me.btnSession.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnSession.Location = New System.Drawing.Point(858, 585)
        Me.btnSession.Name = "btnSession"
        Me.btnSession.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSession.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnSession.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSession.OnHoverImage = Nothing
        Me.btnSession.OnPressedColor = System.Drawing.Color.Black
        Me.btnSession.Radius = 6
        Me.btnSession.Size = New System.Drawing.Size(137, 35)
        Me.btnSession.TabIndex = 14
        Me.btnSession.Text = "Add Session"
        '
        'dttimenow
        '
        Me.dttimenow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dttimenow.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dttimenow.Location = New System.Drawing.Point(634, 35)
        Me.dttimenow.Name = "dttimenow"
        Me.dttimenow.Size = New System.Drawing.Size(254, 20)
        Me.dttimenow.TabIndex = 13
        Me.dttimenow.Visible = False
        '
        'dgvloghistory
        '
        Me.dgvloghistory.AllowUserToAddRows = False
        Me.dgvloghistory.AllowUserToDeleteRows = False
        Me.dgvloghistory.AllowUserToOrderColumns = True
        Me.dgvloghistory.AllowUserToResizeColumns = False
        Me.dgvloghistory.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvloghistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvloghistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvloghistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvloghistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvloghistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvloghistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvloghistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvloghistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvloghistory.ColumnHeadersHeight = 30
        Me.dgvloghistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvloghistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rfid, Me.fname, Me.sdate, Me.timeinn, Me.timeout})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvloghistory.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvloghistory.EnableHeadersVisualStyles = False
        Me.dgvloghistory.GridColor = System.Drawing.Color.White
        Me.dgvloghistory.Location = New System.Drawing.Point(30, 310)
        Me.dgvloghistory.Name = "dgvloghistory"
        Me.dgvloghistory.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvloghistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvloghistory.RowHeadersVisible = False
        Me.dgvloghistory.RowHeadersWidth = 20
        Me.dgvloghistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvloghistory.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvloghistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvloghistory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvloghistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvloghistory.RowTemplate.Height = 30
        Me.dgvloghistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvloghistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvloghistory.Size = New System.Drawing.Size(966, 256)
        Me.dgvloghistory.TabIndex = 10
        Me.dgvloghistory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvloghistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvloghistory.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dgvloghistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvloghistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvloghistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvloghistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvloghistory.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvloghistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvloghistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvloghistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvloghistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvloghistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvloghistory.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvloghistory.ThemeStyle.ReadOnly = True
        Me.dgvloghistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvloghistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvloghistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dgvloghistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvloghistory.ThemeStyle.RowsStyle.Height = 30
        Me.dgvloghistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvloghistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'rfid
        '
        Me.rfid.HeaderText = "RFID"
        Me.rfid.MinimumWidth = 6
        Me.rfid.Name = "rfid"
        Me.rfid.ReadOnly = True
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.MinimumWidth = 6
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'sdate
        '
        Me.sdate.HeaderText = "Date"
        Me.sdate.MinimumWidth = 6
        Me.sdate.Name = "sdate"
        Me.sdate.ReadOnly = True
        '
        'timeinn
        '
        Me.timeinn.HeaderText = "Time in"
        Me.timeinn.MinimumWidth = 6
        Me.timeinn.Name = "timeinn"
        Me.timeinn.ReadOnly = True
        '
        'timeout
        '
        Me.timeout.HeaderText = "Time out"
        Me.timeout.MinimumWidth = 6
        Me.timeout.Name = "timeout"
        Me.timeout.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel3.Controls.Add(Me.memberpic)
        Me.Panel3.Controls.Add(Me.txtRFID)
        Me.Panel3.Controls.Add(Me.lblservices)
        Me.Panel3.Controls.Add(Me.lblname)
        Me.Panel3.Controls.Add(Me.lblResult)
        Me.Panel3.Location = New System.Drawing.Point(32, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(966, 254)
        Me.Panel3.TabIndex = 3
        '
        'memberpic
        '
        Me.memberpic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.memberpic.BaseColor = System.Drawing.Color.White
        Me.memberpic.Image = Global.Capstone_Project.My.Resources.Resources.gymnast_1163072
        Me.memberpic.Location = New System.Drawing.Point(55, 13)
        Me.memberpic.Name = "memberpic"
        Me.memberpic.Size = New System.Drawing.Size(241, 222)
        Me.memberpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.memberpic.TabIndex = 11
        Me.memberpic.TabStop = False
        Me.memberpic.UseTransfarantBackground = False
        '
        'txtRFID
        '
        Me.txtRFID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRFID.BackColor = System.Drawing.Color.Transparent
        Me.txtRFID.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtRFID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtRFID.BorderSize = 0
        Me.txtRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRFID.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtRFID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtRFID.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtRFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtRFID.ForeColor = System.Drawing.Color.White
        Me.txtRFID.Location = New System.Drawing.Point(412, 20)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFID.Radius = 4
        Me.txtRFID.SelectedText = ""
        Me.txtRFID.Size = New System.Drawing.Size(429, 48)
        Me.txtRFID.TabIndex = 6
        Me.txtRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblservices
        '
        Me.lblservices.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblservices.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblservices.ForeColor = System.Drawing.Color.White
        Me.lblservices.Location = New System.Drawing.Point(255, 113)
        Me.lblservices.Name = "lblservices"
        Me.lblservices.Size = New System.Drawing.Size(709, 66)
        Me.lblservices.TabIndex = 2
        Me.lblservices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblname
        '
        Me.lblname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(270, 63)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(693, 66)
        Me.lblname.TabIndex = 0
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Yellow
        Me.lblResult.Location = New System.Drawing.Point(255, 182)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(709, 66)
        Me.lblResult.TabIndex = 12
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtdatenow
        '
        Me.dtdatenow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtdatenow.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdatenow.Location = New System.Drawing.Point(203, 35)
        Me.dtdatenow.Name = "dtdatenow"
        Me.dtdatenow.Size = New System.Drawing.Size(254, 20)
        Me.dtdatenow.TabIndex = 12
        Me.dtdatenow.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel4.Controls.Add(Me.GunaControlBox1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.lbldatentime)
        Me.Panel4.Controls.Add(Me.GunaControlBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1031, 85)
        Me.Panel4.TabIndex = 2
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(994, 11)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.gxflogo_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(315, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gym X Fit Attendance Monitoring" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldatentime
        '
        Me.lbldatentime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbldatentime.AutoSize = True
        Me.lbldatentime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatentime.ForeColor = System.Drawing.Color.White
        Me.lbldatentime.Location = New System.Drawing.Point(728, 27)
        Me.lbldatentime.Name = "lbldatentime"
        Me.lbldatentime.Size = New System.Drawing.Size(140, 22)
        Me.lbldatentime.TabIndex = 2
        Me.lbldatentime.Text = "YYYY-MM-DD "
        Me.lbldatentime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(970, 12)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox2.TabIndex = 4
        '
        'datentime
        '
        Me.datentime.Enabled = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel4
        Me.BunifuDragControl1.Vertical = True
        '
        'TimerFocus
        '
        '
        'timer2
        '
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'lbltime
        '
        Me.lbltime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(440, 3)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(140, 22)
        Me.lbltime.TabIndex = 5
        Me.lbltime.Text = "YYYY-MM-DD "
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbltime.Visible = False
        '
        'Timer3
        '
        '
        'activitylogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 718)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "activitylogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "activitylogs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvloghistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.memberpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents memberpic As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents dgvloghistory As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblservices As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtRFID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbldatentime As Label
    Friend WithEvents datentime As Timer
    Friend WithEvents dtdatenow As DateTimePicker
    Friend WithEvents _timein As DateTimePicker
    Friend WithEvents dttimenow As DateTimePicker
    Friend WithEvents rfid As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents sdate As DataGridViewTextBoxColumn
    Friend WithEvents timeinn As DataGridViewTextBoxColumn
    Friend WithEvents timeout As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblResult As Label
    Friend WithEvents TimerFocus As Timer
    Friend WithEvents timer2 As Timer
    Friend WithEvents btnSession As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbltime As Label
    Friend WithEvents Timer3 As Timer
End Class
