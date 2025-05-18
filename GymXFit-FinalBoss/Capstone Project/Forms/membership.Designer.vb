<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class membership
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(membership))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblactive = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblexpired = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblpending = New System.Windows.Forms.Label()
        Me.txtsearch = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.dgvmembers = New Guna.UI.WinForms.GunaDataGridView()
        Me.picture = New System.Windows.Forms.DataGridViewImageColumn()
        Me.rfid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.membersince = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emergency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnnewmember = New Guna.UI.WinForms.GunaTileButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.dgvmembers)
        Me.Panel1.Controls.Add(Me.btnnewmember)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 661)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblactive)
        Me.Panel3.Location = New System.Drawing.Point(161, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(137, 76)
        Me.Panel3.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Total Active"
        '
        'lblactive
        '
        Me.lblactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblactive.AutoSize = True
        Me.lblactive.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactive.ForeColor = System.Drawing.Color.White
        Me.lblactive.Location = New System.Drawing.Point(41, 19)
        Me.lblactive.Name = "lblactive"
        Me.lblactive.Size = New System.Drawing.Size(56, 70)
        Me.lblactive.TabIndex = 16
        Me.lblactive.Text = "0"
        Me.lblactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblexpired)
        Me.Panel4.Location = New System.Drawing.Point(306, 123)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(137, 76)
        Me.Panel4.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 26)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total Expired"
        '
        'lblexpired
        '
        Me.lblexpired.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblexpired.AutoSize = True
        Me.lblexpired.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpired.ForeColor = System.Drawing.Color.White
        Me.lblexpired.Location = New System.Drawing.Point(41, 19)
        Me.lblexpired.Name = "lblexpired"
        Me.lblexpired.Size = New System.Drawing.Size(56, 70)
        Me.lblexpired.TabIndex = 16
        Me.lblexpired.Text = "0"
        Me.lblexpired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblpending)
        Me.Panel2.Location = New System.Drawing.Point(17, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(137, 76)
        Me.Panel2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Total Pending"
        '
        'lblpending
        '
        Me.lblpending.AllowDrop = True
        Me.lblpending.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpending.AutoSize = True
        Me.lblpending.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpending.ForeColor = System.Drawing.Color.White
        Me.lblpending.Location = New System.Drawing.Point(41, 19)
        Me.lblpending.Name = "lblpending"
        Me.lblpending.Size = New System.Drawing.Size(56, 70)
        Me.lblpending.TabIndex = 16
        Me.lblpending.Text = "0"
        Me.lblpending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsearch
        '
        Me.txtsearch.AcceptsReturn = False
        Me.txtsearch.AcceptsTab = False
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.AnimationSpeed = 200
        Me.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtsearch.BackgroundImage = CType(resources.GetObject("txtsearch.BackgroundImage"), System.Drawing.Image)
        Me.txtsearch.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtsearch.BorderColorDisabled = System.Drawing.Color.White
        Me.txtsearch.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtsearch.BorderColorIdle = System.Drawing.Color.White
        Me.txtsearch.BorderRadius = 1
        Me.txtsearch.BorderThickness = 2
        Me.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtsearch.ForeColor = System.Drawing.Color.White
        Me.txtsearch.HideSelection = True
        Me.txtsearch.IconLeft = Nothing
        Me.txtsearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.IconPadding = 10
        Me.txtsearch.IconRight = Nothing
        Me.txtsearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.Lines = New String(-1) {}
        Me.txtsearch.Location = New System.Drawing.Point(791, 148)
        Me.txtsearch.MaxLength = 32767
        Me.txtsearch.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtsearch.Modified = False
        Me.txtsearch.Multiline = False
        Me.txtsearch.Name = "txtsearch"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsearch.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.White
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtsearch.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsearch.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.White
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsearch.OnIdleState = StateProperties4
        Me.txtsearch.Padding = New System.Windows.Forms.Padding(3)
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtsearch.PlaceholderText = "Search..."
        Me.txtsearch.ReadOnly = False
        Me.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.ShortcutsEnabled = True
        Me.txtsearch.Size = New System.Drawing.Size(228, 48)
        Me.txtsearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txtsearch.TabIndex = 12
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtsearch.TextMarginBottom = 0
        Me.txtsearch.TextMarginLeft = 3
        Me.txtsearch.TextMarginTop = 0
        Me.txtsearch.TextPlaceholder = "Search..."
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.WordWrap = True
        '
        'dgvmembers
        '
        Me.dgvmembers.AllowUserToAddRows = False
        Me.dgvmembers.AllowUserToDeleteRows = False
        Me.dgvmembers.AllowUserToOrderColumns = True
        Me.dgvmembers.AllowUserToResizeColumns = False
        Me.dgvmembers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvmembers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvmembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvmembers.BackgroundColor = System.Drawing.Color.White
        Me.dgvmembers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvmembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvmembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvmembers.ColumnHeadersHeight = 50
        Me.dgvmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvmembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.picture, Me.rfid, Me.fname, Me.age, Me.contactno, Me.address, Me.gender, Me.membersince, Me.emergency, Me.status})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmembers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvmembers.EnableHeadersVisualStyles = False
        Me.dgvmembers.GridColor = System.Drawing.Color.White
        Me.dgvmembers.Location = New System.Drawing.Point(17, 230)
        Me.dgvmembers.Name = "dgvmembers"
        Me.dgvmembers.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmembers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvmembers.RowHeadersVisible = False
        Me.dgvmembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmembers.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvmembers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvmembers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvmembers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmembers.RowTemplate.Height = 40
        Me.dgvmembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmembers.Size = New System.Drawing.Size(1002, 408)
        Me.dgvmembers.TabIndex = 13
        Me.dgvmembers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvmembers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvmembers.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvmembers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvmembers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvmembers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvmembers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvmembers.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvmembers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvmembers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvmembers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvmembers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvmembers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvmembers.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvmembers.ThemeStyle.ReadOnly = True
        Me.dgvmembers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvmembers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvmembers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvmembers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvmembers.ThemeStyle.RowsStyle.Height = 40
        Me.dgvmembers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvmembers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'picture
        '
        Me.picture.HeaderText = "Picture"
        Me.picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.picture.Name = "picture"
        Me.picture.ReadOnly = True
        '
        'rfid
        '
        Me.rfid.HeaderText = "RFID"
        Me.rfid.Name = "rfid"
        Me.rfid.ReadOnly = True
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'age
        '
        Me.age.HeaderText = "Age"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        '
        'contactno
        '
        Me.contactno.HeaderText = "Contact No."
        Me.contactno.Name = "contactno"
        Me.contactno.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'gender
        '
        Me.gender.HeaderText = "Sex"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'membersince
        '
        Me.membersince.HeaderText = "Member Since"
        Me.membersince.Name = "membersince"
        Me.membersince.ReadOnly = True
        '
        'emergency
        '
        Me.emergency.HeaderText = "Emergency Contact"
        Me.emergency.Name = "emergency"
        Me.emergency.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'btnnewmember
        '
        Me.btnnewmember.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnewmember.Animated = True
        Me.btnnewmember.AnimationHoverSpeed = 0.07!
        Me.btnnewmember.AnimationSpeed = 0.03!
        Me.btnnewmember.BackColor = System.Drawing.Color.Transparent
        Me.btnnewmember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnnewmember.BorderColor = System.Drawing.Color.Transparent
        Me.btnnewmember.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnnewmember.FocusedColor = System.Drawing.Color.Empty
        Me.btnnewmember.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewmember.ForeColor = System.Drawing.Color.White
        Me.btnnewmember.Image = Nothing
        Me.btnnewmember.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnnewmember.Location = New System.Drawing.Point(882, 82)
        Me.btnnewmember.Name = "btnnewmember"
        Me.btnnewmember.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnnewmember.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnnewmember.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnewmember.OnHoverImage = Nothing
        Me.btnnewmember.OnPressedColor = System.Drawing.Color.Black
        Me.btnnewmember.Radius = 6
        Me.btnnewmember.Size = New System.Drawing.Size(137, 41)
        Me.btnnewmember.TabIndex = 10
        Me.btnnewmember.Text = "New Member"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me.dgvmembers
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Capstone_Project.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'membership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 661)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "membership"
        Me.Text = "membership"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtsearch As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents dgvmembers As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnnewmember As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblpending As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblactive As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblexpired As Label
    Friend WithEvents picture As DataGridViewImageColumn
    Friend WithEvents rfid As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents contactno As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents membersince As DataGridViewTextBoxColumn
    Friend WithEvents emergency As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
