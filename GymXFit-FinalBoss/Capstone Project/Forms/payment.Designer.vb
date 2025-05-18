<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvpayment = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnpayment = New Guna.UI.WinForms.GunaTileButton()
        Me.txtpsearch = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblYearly = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDaily = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dgvpayment)
        Me.Panel1.Controls.Add(Me.btnpayment)
        Me.Panel1.Controls.Add(Me.txtpsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 661)
        Me.Panel1.TabIndex = 0
        '
        'dgvpayment
        '
        Me.dgvpayment.AllowUserToAddRows = False
        Me.dgvpayment.AllowUserToDeleteRows = False
        Me.dgvpayment.AllowUserToOrderColumns = True
        Me.dgvpayment.AllowUserToResizeColumns = False
        Me.dgvpayment.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvpayment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvpayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvpayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvpayment.BackgroundColor = System.Drawing.Color.White
        Me.dgvpayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvpayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvpayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvpayment.ColumnHeadersHeight = 50
        Me.dgvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvpayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpayment.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvpayment.EnableHeadersVisualStyles = False
        Me.dgvpayment.GridColor = System.Drawing.Color.White
        Me.dgvpayment.Location = New System.Drawing.Point(15, 230)
        Me.dgvpayment.Name = "dgvpayment"
        Me.dgvpayment.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpayment.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvpayment.RowHeadersVisible = False
        Me.dgvpayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpayment.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvpayment.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvpayment.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvpayment.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpayment.RowTemplate.Height = 40
        Me.dgvpayment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvpayment.Size = New System.Drawing.Size(1002, 408)
        Me.dgvpayment.TabIndex = 17
        Me.dgvpayment.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvpayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvpayment.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvpayment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvpayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvpayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvpayment.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvpayment.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvpayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvpayment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvpayment.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvpayment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvpayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvpayment.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvpayment.ThemeStyle.ReadOnly = True
        Me.dgvpayment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvpayment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvpayment.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvpayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvpayment.ThemeStyle.RowsStyle.Height = 40
        Me.dgvpayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvpayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Column1
        '
        Me.Column1.HeaderText = "RFID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Transaction ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Services"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Description"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Next Due Date"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Payment Type"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Reference No."
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'btnpayment
        '
        Me.btnpayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpayment.Animated = True
        Me.btnpayment.AnimationHoverSpeed = 0.07!
        Me.btnpayment.AnimationSpeed = 0.03!
        Me.btnpayment.BackColor = System.Drawing.Color.Transparent
        Me.btnpayment.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnpayment.BorderColor = System.Drawing.Color.Transparent
        Me.btnpayment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnpayment.FocusedColor = System.Drawing.Color.Empty
        Me.btnpayment.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayment.ForeColor = System.Drawing.Color.White
        Me.btnpayment.Image = Nothing
        Me.btnpayment.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnpayment.Location = New System.Drawing.Point(882, 82)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnpayment.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnpayment.OnHoverForeColor = System.Drawing.Color.White
        Me.btnpayment.OnHoverImage = Nothing
        Me.btnpayment.OnPressedColor = System.Drawing.Color.Black
        Me.btnpayment.Radius = 6
        Me.btnpayment.Size = New System.Drawing.Size(137, 41)
        Me.btnpayment.TabIndex = 14
        Me.btnpayment.Text = "Scan RFID"
        '
        'txtpsearch
        '
        Me.txtpsearch.AcceptsReturn = False
        Me.txtpsearch.AcceptsTab = False
        Me.txtpsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpsearch.AnimationSpeed = 200
        Me.txtpsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtpsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtpsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtpsearch.BackgroundImage = CType(resources.GetObject("txtpsearch.BackgroundImage"), System.Drawing.Image)
        Me.txtpsearch.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtpsearch.BorderColorDisabled = System.Drawing.Color.White
        Me.txtpsearch.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtpsearch.BorderColorIdle = System.Drawing.Color.White
        Me.txtpsearch.BorderRadius = 1
        Me.txtpsearch.BorderThickness = 2
        Me.txtpsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtpsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpsearch.DefaultFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpsearch.DefaultText = ""
        Me.txtpsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtpsearch.ForeColor = System.Drawing.Color.White
        Me.txtpsearch.HideSelection = True
        Me.txtpsearch.IconLeft = Nothing
        Me.txtpsearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpsearch.IconPadding = 10
        Me.txtpsearch.IconRight = Nothing
        Me.txtpsearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpsearch.Lines = New String(-1) {}
        Me.txtpsearch.Location = New System.Drawing.Point(791, 148)
        Me.txtpsearch.MaxLength = 32767
        Me.txtpsearch.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtpsearch.Modified = False
        Me.txtpsearch.Multiline = False
        Me.txtpsearch.Name = "txtpsearch"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtpsearch.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.White
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtpsearch.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtpsearch.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.White
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtpsearch.OnIdleState = StateProperties4
        Me.txtpsearch.Padding = New System.Windows.Forms.Padding(3)
        Me.txtpsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpsearch.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtpsearch.PlaceholderText = "Search..."
        Me.txtpsearch.ReadOnly = False
        Me.txtpsearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpsearch.SelectedText = ""
        Me.txtpsearch.SelectionLength = 0
        Me.txtpsearch.SelectionStart = 0
        Me.txtpsearch.ShortcutsEnabled = True
        Me.txtpsearch.Size = New System.Drawing.Size(228, 48)
        Me.txtpsearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txtpsearch.TabIndex = 16
        Me.txtpsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpsearch.TextMarginBottom = 0
        Me.txtpsearch.TextMarginLeft = 3
        Me.txtpsearch.TextMarginTop = 0
        Me.txtpsearch.TextPlaceholder = "Search..."
        Me.txtpsearch.UseSystemPasswordChar = False
        Me.txtpsearch.WordWrap = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me.dgvpayment
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblMonthly)
        Me.Panel3.Location = New System.Drawing.Point(162, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(137, 76)
        Me.Panel3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Montlhy Services"
        '
        'lblMonthly
        '
        Me.lblMonthly.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.ForeColor = System.Drawing.Color.White
        Me.lblMonthly.Location = New System.Drawing.Point(41, 19)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(56, 70)
        Me.lblMonthly.TabIndex = 16
        Me.lblMonthly.Text = "0"
        Me.lblMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblYearly)
        Me.Panel4.Location = New System.Drawing.Point(307, 123)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(137, 76)
        Me.Panel4.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 26)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Yearly Services"
        '
        'lblYearly
        '
        Me.lblYearly.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYearly.AutoSize = True
        Me.lblYearly.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearly.ForeColor = System.Drawing.Color.White
        Me.lblYearly.Location = New System.Drawing.Point(41, 19)
        Me.lblYearly.Name = "lblYearly"
        Me.lblYearly.Size = New System.Drawing.Size(56, 70)
        Me.lblYearly.TabIndex = 16
        Me.lblYearly.Text = "0"
        Me.lblYearly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblDaily)
        Me.Panel2.Location = New System.Drawing.Point(18, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(137, 76)
        Me.Panel2.TabIndex = 18
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
        Me.Label1.Text = "Daily Services"
        '
        'lblDaily
        '
        Me.lblDaily.AllowDrop = True
        Me.lblDaily.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDaily.AutoSize = True
        Me.lblDaily.Font = New System.Drawing.Font("Poppins", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaily.ForeColor = System.Drawing.Color.White
        Me.lblDaily.Location = New System.Drawing.Point(41, 19)
        Me.lblDaily.Name = "lblDaily"
        Me.lblDaily.Size = New System.Drawing.Size(56, 70)
        Me.lblDaily.TabIndex = 16
        Me.lblDaily.Text = "0"
        Me.lblDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 661)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "payment"
        Me.Text = "payment"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvpayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvpayment As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btnpayment As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents txtpsearch As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMonthly As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblYearly As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDaily As Label
End Class
