<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maintenance))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.dgvmaintenance = New Guna.UI.WinForms.GunaDataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servicesoffer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.samount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editm = New System.Windows.Forms.DataGridViewImageColumn()
        Me.deletem = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnnewmaintenance = New Guna.UI.WinForms.GunaTileButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblmaintenance = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtsearch = New Bunifu.UI.WinForms.BunifuTextBox()
        CType(Me.dgvmaintenance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvmaintenance
        '
        Me.dgvmaintenance.AllowUserToAddRows = False
        Me.dgvmaintenance.AllowUserToDeleteRows = False
        Me.dgvmaintenance.AllowUserToOrderColumns = True
        Me.dgvmaintenance.AllowUserToResizeColumns = False
        Me.dgvmaintenance.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvmaintenance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmaintenance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvmaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvmaintenance.BackgroundColor = System.Drawing.Color.White
        Me.dgvmaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvmaintenance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvmaintenance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmaintenance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvmaintenance.ColumnHeadersHeight = 50
        Me.dgvmaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvmaintenance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.servicesoffer, Me.descp, Me.type, Me.samount, Me.editm, Me.deletem})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmaintenance.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvmaintenance.EnableHeadersVisualStyles = False
        Me.dgvmaintenance.GridColor = System.Drawing.Color.White
        Me.dgvmaintenance.Location = New System.Drawing.Point(15, 200)
        Me.dgvmaintenance.Name = "dgvmaintenance"
        Me.dgvmaintenance.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmaintenance.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvmaintenance.RowHeadersVisible = False
        Me.dgvmaintenance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmaintenance.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvmaintenance.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvmaintenance.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvmaintenance.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmaintenance.RowTemplate.Height = 40
        Me.dgvmaintenance.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmaintenance.Size = New System.Drawing.Size(1002, 433)
        Me.dgvmaintenance.TabIndex = 14
        Me.dgvmaintenance.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvmaintenance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvmaintenance.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvmaintenance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvmaintenance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvmaintenance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvmaintenance.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvmaintenance.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvmaintenance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvmaintenance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvmaintenance.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvmaintenance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvmaintenance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvmaintenance.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvmaintenance.ThemeStyle.ReadOnly = True
        Me.dgvmaintenance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvmaintenance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvmaintenance.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvmaintenance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvmaintenance.ThemeStyle.RowsStyle.Height = 40
        Me.dgvmaintenance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvmaintenance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 49
        '
        'servicesoffer
        '
        Me.servicesoffer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.servicesoffer.HeaderText = "Services"
        Me.servicesoffer.Name = "servicesoffer"
        Me.servicesoffer.ReadOnly = True
        '
        'descp
        '
        Me.descp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descp.HeaderText = "Description"
        Me.descp.Name = "descp"
        Me.descp.ReadOnly = True
        '
        'type
        '
        Me.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Width = 71
        '
        'samount
        '
        Me.samount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.samount.HeaderText = "Amount"
        Me.samount.Name = "samount"
        Me.samount.ReadOnly = True
        Me.samount.Width = 93
        '
        'editm
        '
        Me.editm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.editm.HeaderText = ""
        Me.editm.Image = Global.Capstone_Project.My.Resources.Resources.pedit
        Me.editm.Name = "editm"
        Me.editm.ReadOnly = True
        Me.editm.Width = 5
        '
        'deletem
        '
        Me.deletem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deletem.HeaderText = ""
        Me.deletem.Image = Global.Capstone_Project.My.Resources.Resources.pdelete
        Me.deletem.Name = "deletem"
        Me.deletem.ReadOnly = True
        Me.deletem.Width = 5
        '
        'btnnewmaintenance
        '
        Me.btnnewmaintenance.Animated = True
        Me.btnnewmaintenance.AnimationHoverSpeed = 0.07!
        Me.btnnewmaintenance.AnimationSpeed = 0.03!
        Me.btnnewmaintenance.BackColor = System.Drawing.Color.Transparent
        Me.btnnewmaintenance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnnewmaintenance.BorderColor = System.Drawing.Color.Transparent
        Me.btnnewmaintenance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnnewmaintenance.FocusedColor = System.Drawing.Color.Empty
        Me.btnnewmaintenance.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewmaintenance.ForeColor = System.Drawing.Color.White
        Me.btnnewmaintenance.Image = Nothing
        Me.btnnewmaintenance.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnnewmaintenance.Location = New System.Drawing.Point(259, 140)
        Me.btnnewmaintenance.Name = "btnnewmaintenance"
        Me.btnnewmaintenance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnnewmaintenance.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnnewmaintenance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnewmaintenance.OnHoverImage = Nothing
        Me.btnnewmaintenance.OnPressedColor = System.Drawing.Color.Black
        Me.btnnewmaintenance.Radius = 6
        Me.btnnewmaintenance.Size = New System.Drawing.Size(120, 41)
        Me.btnnewmaintenance.TabIndex = 16
        Me.btnnewmaintenance.Text = "Create New"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Medium", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(891, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 26)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Total Record"
        '
        'lblmaintenance
        '
        Me.lblmaintenance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmaintenance.Font = New System.Drawing.Font("Poppins Medium", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaintenance.ForeColor = System.Drawing.Color.White
        Me.lblmaintenance.Location = New System.Drawing.Point(882, 115)
        Me.lblmaintenance.Name = "lblmaintenance"
        Me.lblmaintenance.Size = New System.Drawing.Size(143, 76)
        Me.lblmaintenance.TabIndex = 39
        Me.lblmaintenance.Text = "0"
        Me.lblmaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me.dgvmaintenance
        '
        'txtsearch
        '
        Me.txtsearch.AcceptsReturn = False
        Me.txtsearch.AcceptsTab = False
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
        Me.txtsearch.Location = New System.Drawing.Point(15, 133)
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
        Me.txtsearch.TabIndex = 15
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtsearch.TextMarginBottom = 0
        Me.txtsearch.TextMarginLeft = 3
        Me.txtsearch.TextMarginTop = 0
        Me.txtsearch.TextPlaceholder = "Search..."
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.WordWrap = True
        '
        'maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 661)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblmaintenance)
        Me.Controls.Add(Me.btnnewmaintenance)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.dgvmaintenance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "maintenance"
        Me.Text = "paymenthistory"
        CType(Me.dgvmaintenance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvmaintenance As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtsearch As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents btnnewmaintenance As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents Label10 As Label
    Friend WithEvents lblmaintenance As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents servicesoffer As DataGridViewTextBoxColumn
    Friend WithEvents descp As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents samount As DataGridViewTextBoxColumn
    Friend WithEvents editm As DataGridViewImageColumn
    Friend WithEvents deletem As DataGridViewImageColumn
End Class
