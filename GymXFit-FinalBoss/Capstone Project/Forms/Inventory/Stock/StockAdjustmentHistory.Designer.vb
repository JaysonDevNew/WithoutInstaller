<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockAdjustmentHistory
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockAdjustmentHistory))
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpto = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dgvStockHistory = New Guna.UI.WinForms.GunaDataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.current_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjusted_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjusted_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjusted_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjusted_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnStockExport = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblstock = New System.Windows.Forms.Label()
        Me.TxtSeearch = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvStockHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stock Adjustment History"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1386, 49)
        Me.Panel1.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1158, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 28)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Stock Adjustment"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1346, 3)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(257, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Filter  (Start-End)"
        '
        'dtpto
        '
        Me.dtpto.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Location = New System.Drawing.Point(679, 81)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(252, 27)
        Me.dtpto.TabIndex = 44
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Location = New System.Drawing.Point(424, 81)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(243, 27)
        Me.dtpFrom.TabIndex = 43
        '
        'dgvStockHistory
        '
        Me.dgvStockHistory.AllowUserToAddRows = False
        Me.dgvStockHistory.AllowUserToDeleteRows = False
        Me.dgvStockHistory.AllowUserToOrderColumns = True
        Me.dgvStockHistory.AllowUserToResizeColumns = False
        Me.dgvStockHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStockHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvStockHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvStockHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStockHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvStockHistory.ColumnHeadersHeight = 50
        Me.dgvStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStockHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.brand_name, Me.product_name, Me.product_category, Me.price, Me.current_stock, Me.adjusted_stock, Me.adjusted_type, Me.reason, Me.adjusted_by, Me.adjusted_date})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvStockHistory.EnableHeadersVisualStyles = False
        Me.dgvStockHistory.GridColor = System.Drawing.Color.White
        Me.dgvStockHistory.Location = New System.Drawing.Point(12, 122)
        Me.dgvStockHistory.Name = "dgvStockHistory"
        Me.dgvStockHistory.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvStockHistory.RowHeadersVisible = False
        Me.dgvStockHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Poppins", 9.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvStockHistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvStockHistory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.dgvStockHistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.RowTemplate.Height = 40
        Me.dgvStockHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockHistory.Size = New System.Drawing.Size(1368, 622)
        Me.dgvStockHistory.TabIndex = 42
        Me.dgvStockHistory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvStockHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dgvStockHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStockHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvStockHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvStockHistory.ThemeStyle.ReadOnly = True
        Me.dgvStockHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dgvStockHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStockHistory.ThemeStyle.RowsStyle.Height = 40
        Me.dgvStockHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvStockHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 44
        '
        'brand_name
        '
        Me.brand_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.brand_name.HeaderText = "Brand Name"
        Me.brand_name.Name = "brand_name"
        Me.brand_name.ReadOnly = True
        '
        'product_name
        '
        Me.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product_name.HeaderText = "Product Name"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        '
        'product_category
        '
        Me.product_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product_category.HeaderText = "Category"
        Me.product_category.Name = "product_category"
        Me.product_category.ReadOnly = True
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 63
        '
        'current_stock
        '
        Me.current_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.current_stock.HeaderText = "Current Stock"
        Me.current_stock.Name = "current_stock"
        Me.current_stock.ReadOnly = True
        Me.current_stock.Width = 107
        '
        'adjusted_stock
        '
        Me.adjusted_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.adjusted_stock.HeaderText = "Adjusted Stock"
        Me.adjusted_stock.Name = "adjusted_stock"
        Me.adjusted_stock.ReadOnly = True
        Me.adjusted_stock.Width = 114
        '
        'adjusted_type
        '
        Me.adjusted_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.adjusted_type.HeaderText = "Adjusted_Type"
        Me.adjusted_type.Name = "adjusted_type"
        Me.adjusted_type.ReadOnly = True
        Me.adjusted_type.Width = 126
        '
        'reason
        '
        Me.reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.reason.HeaderText = "Reason"
        Me.reason.Name = "reason"
        Me.reason.ReadOnly = True
        '
        'adjusted_by
        '
        Me.adjusted_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.adjusted_by.HeaderText = "Adjusted By"
        Me.adjusted_by.Name = "adjusted_by"
        Me.adjusted_by.ReadOnly = True
        Me.adjusted_by.Width = 97
        '
        'adjusted_date
        '
        Me.adjusted_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.adjusted_date.HeaderText = "Date"
        Me.adjusted_date.Name = "adjusted_date"
        Me.adjusted_date.ReadOnly = True
        Me.adjusted_date.Width = 61
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.Panel2.Controls.Add(Me.btnStockExport)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblstock)
        Me.Panel2.Controls.Add(Me.TxtSeearch)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpto)
        Me.Panel2.Controls.Add(Me.dtpFrom)
        Me.Panel2.Controls.Add(Me.dgvStockHistory)
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1392, 765)
        Me.Panel2.TabIndex = 49
        '
        'GunaAdvenceTileButton1
        '
        Me.GunaAdvenceTileButton1.Animated = True
        Me.GunaAdvenceTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.CheckedImage = Nothing
        Me.GunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton1.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.GunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.Image = Nothing
        Me.GunaAdvenceTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(937, 75)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Radius = 4
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(133, 37)
        Me.GunaAdvenceTileButton1.TabIndex = 79
        Me.GunaAdvenceTileButton1.Text = "Filter"
        '
        'btnStockExport
        '
        Me.btnStockExport.Animated = True
        Me.btnStockExport.AnimationHoverSpeed = 0.07!
        Me.btnStockExport.AnimationSpeed = 0.03!
        Me.btnStockExport.BackColor = System.Drawing.Color.Transparent
        Me.btnStockExport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockExport.BorderColor = System.Drawing.Color.Black
        Me.btnStockExport.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockExport.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnStockExport.CheckedForeColor = System.Drawing.Color.White
        Me.btnStockExport.CheckedImage = Global.Capstone_Project.My.Resources.Resources.print_96px
        Me.btnStockExport.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnStockExport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStockExport.FocusedColor = System.Drawing.Color.Empty
        Me.btnStockExport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStockExport.ForeColor = System.Drawing.Color.White
        Me.btnStockExport.Image = Global.Capstone_Project.My.Resources.Resources.print_96px1
        Me.btnStockExport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnStockExport.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStockExport.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockExport.Location = New System.Drawing.Point(1076, 75)
        Me.btnStockExport.Name = "btnStockExport"
        Me.btnStockExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockExport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStockExport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStockExport.OnHoverImage = Nothing
        Me.btnStockExport.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockExport.OnPressedColor = System.Drawing.Color.Black
        Me.btnStockExport.Radius = 4
        Me.btnStockExport.Size = New System.Drawing.Size(56, 37)
        Me.btnStockExport.TabIndex = 78
        Me.btnStockExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1227, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Total Records"
        '
        'lblstock
        '
        Me.lblstock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblstock.AutoSize = True
        Me.lblstock.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.ForeColor = System.Drawing.Color.Black
        Me.lblstock.Location = New System.Drawing.Point(1251, 52)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(45, 56)
        Me.lblstock.TabIndex = 77
        Me.lblstock.Text = "0"
        '
        'TxtSeearch
        '
        Me.TxtSeearch.AcceptsReturn = False
        Me.TxtSeearch.AcceptsTab = False
        Me.TxtSeearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSeearch.AnimationSpeed = 200
        Me.TxtSeearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtSeearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtSeearch.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSeearch.BackgroundImage = CType(resources.GetObject("TxtSeearch.BackgroundImage"), System.Drawing.Image)
        Me.TxtSeearch.BorderColorActive = System.Drawing.SystemColors.Control
        Me.TxtSeearch.BorderColorDisabled = System.Drawing.Color.White
        Me.TxtSeearch.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.TxtSeearch.BorderColorIdle = System.Drawing.Color.Black
        Me.TxtSeearch.BorderRadius = 1
        Me.TxtSeearch.BorderThickness = 2
        Me.TxtSeearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtSeearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSeearch.DefaultFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSeearch.DefaultText = ""
        Me.TxtSeearch.FillColor = System.Drawing.SystemColors.Control
        Me.TxtSeearch.ForeColor = System.Drawing.Color.Black
        Me.TxtSeearch.HideSelection = True
        Me.TxtSeearch.IconLeft = Nothing
        Me.TxtSeearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSeearch.IconPadding = 10
        Me.TxtSeearch.IconRight = Nothing
        Me.TxtSeearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSeearch.Lines = New String(-1) {}
        Me.TxtSeearch.Location = New System.Drawing.Point(12, 68)
        Me.TxtSeearch.MaxLength = 32767
        Me.TxtSeearch.MinimumSize = New System.Drawing.Size(1, 1)
        Me.TxtSeearch.Modified = False
        Me.TxtSeearch.Multiline = False
        Me.TxtSeearch.Name = "TxtSeearch"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Black
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TxtSeearch.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.White
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtSeearch.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TxtSeearch.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Black
        StateProperties8.FillColor = System.Drawing.SystemColors.Control
        StateProperties8.ForeColor = System.Drawing.Color.Black
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TxtSeearch.OnIdleState = StateProperties8
        Me.TxtSeearch.Padding = New System.Windows.Forms.Padding(3)
        Me.TxtSeearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSeearch.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.TxtSeearch.PlaceholderText = "Search..."
        Me.TxtSeearch.ReadOnly = False
        Me.TxtSeearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSeearch.SelectedText = ""
        Me.TxtSeearch.SelectionLength = 0
        Me.TxtSeearch.SelectionStart = 0
        Me.TxtSeearch.ShortcutsEnabled = True
        Me.TxtSeearch.Size = New System.Drawing.Size(228, 48)
        Me.TxtSeearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.TxtSeearch.TabIndex = 50
        Me.TxtSeearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtSeearch.TextMarginBottom = 0
        Me.TxtSeearch.TextMarginLeft = 3
        Me.TxtSeearch.TextMarginTop = 0
        Me.TxtSeearch.TextPlaceholder = "Search..."
        Me.TxtSeearch.UseSystemPasswordChar = False
        Me.TxtSeearch.WordWrap = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'StockAdjustmentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockAdjustmentHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockAdjustmentHistory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvStockHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dgvStockHistory As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents brand_name As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents product_category As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents current_stock As DataGridViewTextBoxColumn
    Friend WithEvents adjusted_stock As DataGridViewTextBoxColumn
    Friend WithEvents adjusted_type As DataGridViewTextBoxColumn
    Friend WithEvents reason As DataGridViewTextBoxColumn
    Friend WithEvents adjusted_by As DataGridViewTextBoxColumn
    Friend WithEvents adjusted_date As DataGridViewTextBoxColumn
    Friend WithEvents TxtSeearch As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label10 As Label
    Friend WithEvents lblstock As Label
    Friend WithEvents btnStockExport As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
