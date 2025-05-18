<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockHistory))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.btnConfirm = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbReferenceNo = New System.Windows.Forms.ComboBox()
        Me.dtpdateto = New System.Windows.Forms.DateTimePicker()
        Me.dtpdatefrom = New System.Windows.Forms.DateTimePicker()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvStockHistory = New Guna.UI.WinForms.GunaDataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referemce_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.received_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.current_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.added_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtSeearch = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnStockHistoryExport = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblstock = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvStockHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Animated = True
        Me.btnConfirm.AnimationHoverSpeed = 0.07!
        Me.btnConfirm.AnimationSpeed = 0.03!
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnConfirm.BorderColor = System.Drawing.Color.Black
        Me.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConfirm.FocusedColor = System.Drawing.Color.Empty
        Me.btnConfirm.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Image = Nothing
        Me.btnConfirm.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConfirm.Location = New System.Drawing.Point(973, 41)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnConfirm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnConfirm.OnHoverImage = Nothing
        Me.btnConfirm.OnPressedColor = System.Drawing.Color.Black
        Me.btnConfirm.Radius = 4
        Me.btnConfirm.Size = New System.Drawing.Size(133, 37)
        Me.btnConfirm.TabIndex = 47
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(656, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Reference No"
        '
        'cmbReferenceNo
        '
        Me.cmbReferenceNo.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReferenceNo.FormattingEnabled = True
        Me.cmbReferenceNo.Location = New System.Drawing.Point(758, 48)
        Me.cmbReferenceNo.Name = "cmbReferenceNo"
        Me.cmbReferenceNo.Size = New System.Drawing.Size(204, 31)
        Me.cmbReferenceNo.TabIndex = 45
        '
        'dtpdateto
        '
        Me.dtpdateto.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.dtpdateto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateto.Location = New System.Drawing.Point(352, 50)
        Me.dtpdateto.Name = "dtpdateto"
        Me.dtpdateto.Size = New System.Drawing.Size(157, 27)
        Me.dtpdateto.TabIndex = 44
        '
        'dtpdatefrom
        '
        Me.dtpdatefrom.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.dtpdatefrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatefrom.Location = New System.Drawing.Point(174, 50)
        Me.dtpdatefrom.Name = "dtpdatefrom"
        Me.dtpdatefrom.Size = New System.Drawing.Size(173, 27)
        Me.dtpdatefrom.TabIndex = 43
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1346, 12)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stock History"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1386, 49)
        Me.Panel1.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1298, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Back"
        '
        'dgvStockHistory
        '
        Me.dgvStockHistory.AllowUserToAddRows = False
        Me.dgvStockHistory.AllowUserToDeleteRows = False
        Me.dgvStockHistory.AllowUserToOrderColumns = True
        Me.dgvStockHistory.AllowUserToResizeColumns = False
        Me.dgvStockHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStockHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStockHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvStockHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStockHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStockHistory.ColumnHeadersHeight = 50
        Me.dgvStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStockHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.referemce_no, Me.received_by, Me.date_received, Me.product_id, Me.brand_name, Me.product_name, Me.product_category, Me.price, Me.current_stock, Me.added_stock})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStockHistory.EnableHeadersVisualStyles = False
        Me.dgvStockHistory.GridColor = System.Drawing.Color.White
        Me.dgvStockHistory.Location = New System.Drawing.Point(3, 98)
        Me.dgvStockHistory.Name = "dgvStockHistory"
        Me.dgvStockHistory.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStockHistory.RowHeadersVisible = False
        Me.dgvStockHistory.RowHeadersWidth = 51
        Me.dgvStockHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStockHistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvStockHistory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockHistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.RowTemplate.Height = 40
        Me.dgvStockHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockHistory.Size = New System.Drawing.Size(1364, 631)
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
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStockHistory.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvStockHistory.ThemeStyle.ReadOnly = True
        Me.dgvStockHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStockHistory.ThemeStyle.RowsStyle.Height = 40
        Me.dgvStockHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvStockHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 41
        '
        'referemce_no
        '
        Me.referemce_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.referemce_no.HeaderText = "Reference Number"
        Me.referemce_no.MinimumWidth = 6
        Me.referemce_no.Name = "referemce_no"
        Me.referemce_no.ReadOnly = True
        '
        'received_by
        '
        Me.received_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.received_by.HeaderText = "Received By"
        Me.received_by.MinimumWidth = 6
        Me.received_by.Name = "received_by"
        Me.received_by.ReadOnly = True
        Me.received_by.Width = 84
        '
        'date_received
        '
        Me.date_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.date_received.HeaderText = "Date Received"
        Me.date_received.MinimumWidth = 6
        Me.date_received.Name = "date_received"
        Me.date_received.ReadOnly = True
        Me.date_received.Width = 94
        '
        'product_id
        '
        Me.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.product_id.HeaderText = "Product ID"
        Me.product_id.MinimumWidth = 6
        Me.product_id.Name = "product_id"
        Me.product_id.ReadOnly = True
        Me.product_id.Width = 75
        '
        'brand_name
        '
        Me.brand_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.brand_name.HeaderText = "Brand Name"
        Me.brand_name.MinimumWidth = 6
        Me.brand_name.Name = "brand_name"
        Me.brand_name.ReadOnly = True
        '
        'product_name
        '
        Me.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product_name.HeaderText = "Product Name"
        Me.product_name.MinimumWidth = 6
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        '
        'product_category
        '
        Me.product_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product_category.HeaderText = "Category"
        Me.product_category.MinimumWidth = 6
        Me.product_category.Name = "product_category"
        Me.product_category.ReadOnly = True
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price.HeaderText = "Price"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 54
        '
        'current_stock
        '
        Me.current_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.current_stock.HeaderText = "Current Stock"
        Me.current_stock.MinimumWidth = 6
        Me.current_stock.Name = "current_stock"
        Me.current_stock.ReadOnly = True
        Me.current_stock.Width = 87
        '
        'added_stock
        '
        Me.added_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.added_stock.HeaderText = "Added Stock"
        Me.added_stock.MinimumWidth = 6
        Me.added_stock.Name = "added_stock"
        Me.added_stock.ReadOnly = True
        Me.added_stock.Width = 85
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtSeearch)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.Panel2.Controls.Add(Me.btnStockHistoryExport)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblstock)
        Me.Panel2.Controls.Add(Me.btnConfirm)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmbReferenceNo)
        Me.Panel2.Controls.Add(Me.dtpdateto)
        Me.Panel2.Controls.Add(Me.dtpdatefrom)
        Me.Panel2.Controls.Add(Me.dgvStockHistory)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(13, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 747)
        Me.Panel2.TabIndex = 48
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
        Me.TxtSeearch.Location = New System.Drawing.Point(9, -4)
        Me.TxtSeearch.MaxLength = 32767
        Me.TxtSeearch.MinimumSize = New System.Drawing.Size(1, 1)
        Me.TxtSeearch.Modified = False
        Me.TxtSeearch.Multiline = False
        Me.TxtSeearch.Name = "TxtSeearch"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Black
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TxtSeearch.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.White
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtSeearch.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TxtSeearch.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Black
        StateProperties4.FillColor = System.Drawing.SystemColors.Control
        StateProperties4.ForeColor = System.Drawing.Color.Black
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TxtSeearch.OnIdleState = StateProperties4
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
        Me.TxtSeearch.TabIndex = 83
        Me.TxtSeearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtSeearch.TextMarginBottom = 0
        Me.TxtSeearch.TextMarginLeft = 3
        Me.TxtSeearch.TextMarginTop = 0
        Me.TxtSeearch.TextPlaceholder = "Search..."
        Me.TxtSeearch.UseSystemPasswordChar = False
        Me.TxtSeearch.WordWrap = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Date Filter  (Start-End)"
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
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(525, 52)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Radius = 4
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(92, 25)
        Me.GunaAdvenceTileButton1.TabIndex = 81
        Me.GunaAdvenceTileButton1.Text = "Filter"
        '
        'btnStockHistoryExport
        '
        Me.btnStockHistoryExport.Animated = True
        Me.btnStockHistoryExport.AnimationHoverSpeed = 0.07!
        Me.btnStockHistoryExport.AnimationSpeed = 0.03!
        Me.btnStockHistoryExport.BackColor = System.Drawing.Color.Transparent
        Me.btnStockHistoryExport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockHistoryExport.BorderColor = System.Drawing.Color.Black
        Me.btnStockHistoryExport.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockHistoryExport.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnStockHistoryExport.CheckedForeColor = System.Drawing.Color.White
        Me.btnStockHistoryExport.CheckedImage = Global.Capstone_Project.My.Resources.Resources.print_96px
        Me.btnStockHistoryExport.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnStockHistoryExport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStockHistoryExport.FocusedColor = System.Drawing.Color.Empty
        Me.btnStockHistoryExport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStockHistoryExport.ForeColor = System.Drawing.Color.White
        Me.btnStockHistoryExport.Image = Global.Capstone_Project.My.Resources.Resources.print_96px1
        Me.btnStockHistoryExport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnStockHistoryExport.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStockHistoryExport.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockHistoryExport.Location = New System.Drawing.Point(1112, 40)
        Me.btnStockHistoryExport.Name = "btnStockHistoryExport"
        Me.btnStockHistoryExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockHistoryExport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStockHistoryExport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStockHistoryExport.OnHoverImage = Nothing
        Me.btnStockHistoryExport.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStockHistoryExport.OnPressedColor = System.Drawing.Color.Black
        Me.btnStockHistoryExport.Radius = 4
        Me.btnStockHistoryExport.Size = New System.Drawing.Size(56, 37)
        Me.btnStockHistoryExport.TabIndex = 80
        Me.btnStockHistoryExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1215, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Total Records"
        '
        'lblstock
        '
        Me.lblstock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblstock.AutoSize = True
        Me.lblstock.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.ForeColor = System.Drawing.Color.Black
        Me.lblstock.Location = New System.Drawing.Point(1222, 32)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(95, 56)
        Me.lblstock.TabIndex = 79
        Me.lblstock.Text = "0.00"
        '
        'StockHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 754)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockHistory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvStockHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConfirm As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbReferenceNo As ComboBox
    Friend WithEvents dtpdateto As DateTimePicker
    Friend WithEvents dtpdatefrom As DateTimePicker
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvStockHistory As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents referemce_no As DataGridViewTextBoxColumn
    Friend WithEvents received_by As DataGridViewTextBoxColumn
    Friend WithEvents date_received As DataGridViewTextBoxColumn
    Friend WithEvents product_id As DataGridViewTextBoxColumn
    Friend WithEvents brand_name As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents product_category As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents current_stock As DataGridViewTextBoxColumn
    Friend WithEvents added_stock As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblstock As Label
    Friend WithEvents btnStockHistoryExport As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSeearch As Bunifu.UI.WinForms.BunifuTextBox
End Class
