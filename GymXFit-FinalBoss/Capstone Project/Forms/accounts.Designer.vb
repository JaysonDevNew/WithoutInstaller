<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accounts))
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnewaccount = New Guna.UI.WinForms.GunaTileButton()
        Me.txtsearch = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.dgvaccount = New Guna.UI.WinForms.GunaDataGridView()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelupdate = New System.Windows.Forms.Panel()
        Me.txtUsertype = New Guna.UI.WinForms.GunaTextBox()
        Me.lblPasswordStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnupdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbrowse = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pctprofile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New Guna.UI.WinForms.GunaTextBox()
        CType(Me.dgvaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelupdate.SuspendLayout()
        CType(Me.pctprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "List of Account"
        '
        'btnnewaccount
        '
        Me.btnnewaccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnewaccount.Animated = True
        Me.btnnewaccount.AnimationHoverSpeed = 0.07!
        Me.btnnewaccount.AnimationSpeed = 0.03!
        Me.btnnewaccount.BackColor = System.Drawing.Color.Transparent
        Me.btnnewaccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnnewaccount.BorderColor = System.Drawing.Color.Transparent
        Me.btnnewaccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnnewaccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnnewaccount.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewaccount.ForeColor = System.Drawing.Color.White
        Me.btnnewaccount.Image = Nothing
        Me.btnnewaccount.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnnewaccount.Location = New System.Drawing.Point(881, 12)
        Me.btnnewaccount.Name = "btnnewaccount"
        Me.btnnewaccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnnewaccount.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnnewaccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnewaccount.OnHoverImage = Nothing
        Me.btnnewaccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnnewaccount.Radius = 6
        Me.btnnewaccount.Size = New System.Drawing.Size(137, 41)
        Me.btnnewaccount.TabIndex = 4
        Me.btnnewaccount.Text = "New Account"
        '
        'txtsearch
        '
        Me.txtsearch.AcceptsReturn = False
        Me.txtsearch.AcceptsTab = False
        Me.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.txtsearch.Location = New System.Drawing.Point(790, 58)
        Me.txtsearch.MaxLength = 32767
        Me.txtsearch.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtsearch.Modified = False
        Me.txtsearch.Multiline = False
        Me.txtsearch.Name = "txtsearch"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsearch.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.White
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtsearch.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsearch.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.White
        StateProperties8.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        StateProperties8.ForeColor = System.Drawing.Color.White
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsearch.OnIdleState = StateProperties8
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
        Me.txtsearch.TabIndex = 7
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtsearch.TextMarginBottom = 0
        Me.txtsearch.TextMarginLeft = 3
        Me.txtsearch.TextMarginTop = 0
        Me.txtsearch.TextPlaceholder = "Search..."
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.WordWrap = True
        '
        'dgvaccount
        '
        Me.dgvaccount.AllowUserToAddRows = False
        Me.dgvaccount.AllowUserToDeleteRows = False
        Me.dgvaccount.AllowUserToOrderColumns = True
        Me.dgvaccount.AllowUserToResizeColumns = False
        Me.dgvaccount.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvaccount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvaccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvaccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvaccount.BackgroundColor = System.Drawing.Color.White
        Me.dgvaccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvaccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvaccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvaccount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvaccount.ColumnHeadersHeight = 40
        Me.dgvaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvaccount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Email})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvaccount.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvaccount.EnableHeadersVisualStyles = False
        Me.dgvaccount.GridColor = System.Drawing.Color.White
        Me.dgvaccount.Location = New System.Drawing.Point(1, 139)
        Me.dgvaccount.Name = "dgvaccount"
        Me.dgvaccount.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvaccount.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvaccount.RowHeadersVisible = False
        Me.dgvaccount.RowHeadersWidth = 51
        Me.dgvaccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvaccount.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvaccount.RowTemplate.Height = 40
        Me.dgvaccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvaccount.Size = New System.Drawing.Size(1002, 489)
        Me.dgvaccount.TabIndex = 8
        Me.dgvaccount.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvaccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvaccount.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvaccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvaccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvaccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvaccount.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvaccount.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvaccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvaccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvaccount.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Bold)
        Me.dgvaccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvaccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvaccount.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvaccount.ThemeStyle.ReadOnly = True
        Me.dgvaccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvaccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvaccount.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvaccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvaccount.ThemeStyle.RowsStyle.Height = 40
        Me.dgvaccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvaccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me.dgvaccount
        '
        'panelupdate
        '
        Me.panelupdate.BackColor = System.Drawing.Color.White
        Me.panelupdate.Controls.Add(Me.txtemail)
        Me.panelupdate.Controls.Add(Me.Label4)
        Me.panelupdate.Controls.Add(Me.txtUsertype)
        Me.panelupdate.Controls.Add(Me.lblPasswordStatus)
        Me.panelupdate.Controls.Add(Me.Label6)
        Me.panelupdate.Controls.Add(Me.GunaAdvenceButton3)
        Me.panelupdate.Controls.Add(Me.btnupdate)
        Me.panelupdate.Controls.Add(Me.txtpassword)
        Me.panelupdate.Controls.Add(Me.Label5)
        Me.panelupdate.Controls.Add(Me.txtusername)
        Me.panelupdate.Controls.Add(Me.Label3)
        Me.panelupdate.Controls.Add(Me.txtname)
        Me.panelupdate.Controls.Add(Me.Label2)
        Me.panelupdate.Controls.Add(Me.btnbrowse)
        Me.panelupdate.Controls.Add(Me.Label9)
        Me.panelupdate.Controls.Add(Me.pctprofile)
        Me.panelupdate.Controls.Add(Me.Panel2)
        Me.panelupdate.Location = New System.Drawing.Point(380, 81)
        Me.panelupdate.Name = "panelupdate"
        Me.panelupdate.Size = New System.Drawing.Size(457, 528)
        Me.panelupdate.TabIndex = 9
        Me.panelupdate.Visible = False
        '
        'txtUsertype
        '
        Me.txtUsertype.BackColor = System.Drawing.Color.Transparent
        Me.txtUsertype.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtUsertype.BorderColor = System.Drawing.Color.Silver
        Me.txtUsertype.BorderSize = 0
        Me.txtUsertype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsertype.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsertype.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtUsertype.FocusedForeColor = System.Drawing.Color.Black
        Me.txtUsertype.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsertype.ForeColor = System.Drawing.Color.Black
        Me.txtUsertype.Location = New System.Drawing.Point(239, 355)
        Me.txtUsertype.Name = "txtUsertype"
        Me.txtUsertype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsertype.Radius = 4
        Me.txtUsertype.ReadOnly = True
        Me.txtUsertype.SelectedText = ""
        Me.txtUsertype.Size = New System.Drawing.Size(199, 33)
        Me.txtUsertype.TabIndex = 56
        '
        'lblPasswordStatus
        '
        Me.lblPasswordStatus.AutoSize = True
        Me.lblPasswordStatus.Font = New System.Drawing.Font("Poppins Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordStatus.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordStatus.Location = New System.Drawing.Point(23, 392)
        Me.lblPasswordStatus.Name = "lblPasswordStatus"
        Me.lblPasswordStatus.Size = New System.Drawing.Size(21, 19)
        Me.lblPasswordStatus.TabIndex = 55
        Me.lblPasswordStatus.Text = "......"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(238, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "User Type"
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
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(229, 481)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 4
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(117, 35)
        Me.GunaAdvenceButton3.TabIndex = 52
        Me.GunaAdvenceButton3.Text = "Cancel"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnupdate
        '
        Me.btnupdate.Animated = True
        Me.btnupdate.AnimationHoverSpeed = 0.07!
        Me.btnupdate.AnimationSpeed = 0.03!
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnupdate.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnupdate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnupdate.CheckedForeColor = System.Drawing.Color.White
        Me.btnupdate.CheckedImage = Nothing
        Me.btnupdate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnupdate.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Image = Nothing
        Me.btnupdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnupdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnupdate.Location = New System.Drawing.Point(106, 481)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnupdate.OnHoverImage = Nothing
        Me.btnupdate.OnHoverLineColor = System.Drawing.Color.Green
        Me.btnupdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdate.Radius = 4
        Me.btnupdate.Size = New System.Drawing.Size(117, 35)
        Me.btnupdate.TabIndex = 51
        Me.btnupdate.Text = "Update"
        Me.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtpassword.Location = New System.Drawing.Point(26, 355)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Radius = 4
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(203, 33)
        Me.txtpassword.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Password"
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
        Me.txtusername.Location = New System.Drawing.Point(239, 285)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Radius = 4
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(199, 33)
        Me.txtusername.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(235, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Username"
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
        Me.txtname.Location = New System.Drawing.Point(26, 285)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.Radius = 4
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(203, 33)
        Me.txtname.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Name"
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
        Me.btnbrowse.Location = New System.Drawing.Point(157, 210)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbrowse.OnHoverImage = Nothing
        Me.btnbrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbrowse.OnPressedColor = System.Drawing.Color.Black
        Me.btnbrowse.Radius = 4
        Me.btnbrowse.Size = New System.Drawing.Size(136, 35)
        Me.btnbrowse.TabIndex = 42
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(180, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 23)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Profile Picture"
        '
        'pctprofile
        '
        Me.pctprofile.BaseColor = System.Drawing.Color.White
        Me.pctprofile.Image = Global.Capstone_Project.My.Resources.Resources.gymnast_11630721
        Me.pctprofile.Location = New System.Drawing.Point(164, 59)
        Me.pctprofile.Name = "pctprofile"
        Me.pctprofile.Size = New System.Drawing.Size(120, 122)
        Me.pctprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctprofile.TabIndex = 40
        Me.pctprofile.TabStop = False
        Me.pctprofile.UseTransfarantBackground = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 50)
        Me.Panel2.TabIndex = 39
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(35, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Update Account"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 8
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Picture"
        Me.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Username"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Password"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "User Type"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Email"
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
        Me.txtemail.Location = New System.Drawing.Point(27, 425)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.Radius = 4
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(199, 33)
        Me.txtemail.TabIndex = 58
        '
        'accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 661)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnnewaccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvaccount)
        Me.Controls.Add(Me.panelupdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "accounts"
        Me.Text = "accounts"
        CType(Me.dgvaccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelupdate.ResumeLayout(False)
        Me.panelupdate.PerformLayout()
        CType(Me.pctprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnewaccount As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents dgvaccount As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelupdate As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnupdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnbrowse As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label9 As Label
    Friend WithEvents pctprofile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblPasswordStatus As Label
    Friend WithEvents txtUsertype As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As Guna.UI.WinForms.GunaTextBox
End Class
