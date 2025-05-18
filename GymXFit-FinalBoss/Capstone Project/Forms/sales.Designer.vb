<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sales
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProducts = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCategory = New Guna.UI.WinForms.GunaComboBox()
        Me.transactionno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvProducts = New Guna.UI.WinForms.GunaDataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productnamr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnremovefromcart = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtchange = New Guna.UI.WinForms.GunaTextBox()
        Me.txtpayment = New Guna.UI.WinForms.GunaTextBox()
        Me.txtamount = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btntramsaction = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnbrowse = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnmembership = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.pnlInvoice = New System.Windows.Forms.Panel()
        Me.lbltransaction = New System.Windows.Forms.Label()
        Me.lbltransaction_no = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlSales = New System.Windows.Forms.Panel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnaddtocart = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.dgvCart = New Guna.UI.WinForms.GunaDataGridView()
        Me.numquantity = New System.Windows.Forms.TextBox()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlInvoice.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSales.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Poppins", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(54, 25)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(113, 58)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "0000"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(474, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 25)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Qty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(241, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Product"
        '
        'cmbProducts
        '
        Me.cmbProducts.BackColor = System.Drawing.Color.Transparent
        Me.cmbProducts.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbProducts.BorderColor = System.Drawing.Color.Silver
        Me.cmbProducts.BorderSize = 1
        Me.cmbProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducts.FocusedColor = System.Drawing.Color.Empty
        Me.cmbProducts.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cmbProducts.ForeColor = System.Drawing.Color.Black
        Me.cmbProducts.FormattingEnabled = True
        Me.cmbProducts.Location = New System.Drawing.Point(246, 46)
        Me.cmbProducts.Name = "cmbProducts"
        Me.cmbProducts.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmbProducts.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbProducts.Radius = 4
        Me.cmbProducts.Size = New System.Drawing.Size(216, 28)
        Me.cmbProducts.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbCategory.BorderColor = System.Drawing.Color.Silver
        Me.cmbCategory.BorderSize = 1
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCategory.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.Black
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(17, 46)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbCategory.Radius = 4
        Me.cmbCategory.Size = New System.Drawing.Size(216, 28)
        Me.cmbCategory.TabIndex = 65
        '
        'transactionno
        '
        Me.transactionno.HeaderText = "Transaction No"
        Me.transactionno.Name = "transactionno"
        Me.transactionno.ReadOnly = True
        '
        'product
        '
        Me.product.HeaderText = "Product Name"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToOrderColumns = True
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvProducts.ColumnHeadersHeight = 50
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.brandname, Me.productnamr, Me.pcategory, Me.DataGridViewTextBoxColumn1, Me.stock})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvProducts.EnableHeadersVisualStyles = False
        Me.dgvProducts.GridColor = System.Drawing.Color.White
        Me.dgvProducts.Location = New System.Drawing.Point(9, 81)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvProducts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProducts.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowTemplate.Height = 40
        Me.dgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(680, 504)
        Me.dgvProducts.TabIndex = 73
        Me.dgvProducts.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvProducts.ThemeStyle.ReadOnly = True
        Me.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProducts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvProducts.ThemeStyle.RowsStyle.Height = 40
        Me.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'brandname
        '
        Me.brandname.HeaderText = "Brand  Name"
        Me.brandname.Name = "brandname"
        Me.brandname.ReadOnly = True
        '
        'productnamr
        '
        Me.productnamr.HeaderText = "Product Name"
        Me.productnamr.Name = "productnamr"
        Me.productnamr.ReadOnly = True
        '
        'pcategory
        '
        Me.pcategory.HeaderText = "Category"
        Me.pcategory.Name = "pcategory"
        Me.pcategory.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(66, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(196, 26)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Sunday, Februay, 9, 2025"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnremovefromcart)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btntramsaction)
        Me.Panel2.Controls.Add(Me.btnbrowse)
        Me.Panel2.Controls.Add(Me.btnmembership)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(704, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 624)
        Me.Panel2.TabIndex = 71
        '
        'btnremovefromcart
        '
        Me.btnremovefromcart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnremovefromcart.Animated = True
        Me.btnremovefromcart.AnimationHoverSpeed = 0.07!
        Me.btnremovefromcart.AnimationSpeed = 0.03!
        Me.btnremovefromcart.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnremovefromcart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnremovefromcart.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnremovefromcart.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnremovefromcart.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnremovefromcart.CheckedForeColor = System.Drawing.Color.White
        Me.btnremovefromcart.CheckedImage = Global.Capstone_Project.My.Resources.Resources.settle
        Me.btnremovefromcart.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnremovefromcart.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnremovefromcart.FocusedColor = System.Drawing.Color.Empty
        Me.btnremovefromcart.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremovefromcart.ForeColor = System.Drawing.Color.White
        Me.btnremovefromcart.Image = Global.Capstone_Project.My.Resources.Resources.delete_icon
        Me.btnremovefromcart.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnremovefromcart.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnremovefromcart.Location = New System.Drawing.Point(0, 506)
        Me.btnremovefromcart.Name = "btnremovefromcart"
        Me.btnremovefromcart.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnremovefromcart.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnremovefromcart.OnHoverForeColor = System.Drawing.Color.White
        Me.btnremovefromcart.OnHoverImage = Nothing
        Me.btnremovefromcart.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnremovefromcart.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnremovefromcart.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnremovefromcart.Size = New System.Drawing.Size(327, 53)
        Me.btnremovefromcart.TabIndex = 10
        Me.btnremovefromcart.Text = "[F4] Remove From Cart "
        Me.btnremovefromcart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(327, 132)
        Me.Panel5.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.gxflogo_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txtchange)
        Me.Panel4.Controls.Add(Me.txtpayment)
        Me.Panel4.Controls.Add(Me.txtamount)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(0, 129)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(327, 221)
        Me.Panel4.TabIndex = 8
        '
        'txtchange
        '
        Me.txtchange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtchange.BackColor = System.Drawing.Color.Transparent
        Me.txtchange.BaseColor = System.Drawing.Color.White
        Me.txtchange.BorderColor = System.Drawing.Color.White
        Me.txtchange.BorderSize = 1
        Me.txtchange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtchange.FocusedBaseColor = System.Drawing.Color.White
        Me.txtchange.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtchange.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtchange.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtchange.Location = New System.Drawing.Point(157, 134)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtchange.Radius = 4
        Me.txtchange.ReadOnly = True
        Me.txtchange.SelectedText = ""
        Me.txtchange.Size = New System.Drawing.Size(167, 66)
        Me.txtchange.TabIndex = 33
        Me.txtchange.Text = "0.00"
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpayment
        '
        Me.txtpayment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpayment.BackColor = System.Drawing.Color.Transparent
        Me.txtpayment.BaseColor = System.Drawing.Color.White
        Me.txtpayment.BorderColor = System.Drawing.Color.White
        Me.txtpayment.BorderSize = 1
        Me.txtpayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpayment.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpayment.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtpayment.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtpayment.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtpayment.Location = New System.Drawing.Point(174, 87)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpayment.Radius = 4
        Me.txtpayment.SelectedText = ""
        Me.txtpayment.Size = New System.Drawing.Size(150, 66)
        Me.txtpayment.TabIndex = 32
        Me.txtpayment.Text = "0.00"
        Me.txtpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtamount
        '
        Me.txtamount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtamount.BackColor = System.Drawing.Color.Transparent
        Me.txtamount.BaseColor = System.Drawing.Color.White
        Me.txtamount.BorderColor = System.Drawing.Color.White
        Me.txtamount.BorderSize = 1
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.Enabled = False
        Me.txtamount.FocusedBaseColor = System.Drawing.Color.White
        Me.txtamount.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtamount.FocusedForeColor = System.Drawing.Color.White
        Me.txtamount.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtamount.Location = New System.Drawing.Point(157, 34)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.Radius = 4
        Me.txtamount.ReadOnly = True
        Me.txtamount.SelectedText = ""
        Me.txtamount.Size = New System.Drawing.Size(167, 66)
        Me.txtamount.TabIndex = 31
        Me.txtamount.Text = "0.00"
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 56)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Change:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(2, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 56)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Payment:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 56)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Amount:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Controls.Add(Me.lblDate)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 557)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 67)
        Me.Panel3.TabIndex = 7
        '
        'btntramsaction
        '
        Me.btntramsaction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntramsaction.Animated = True
        Me.btntramsaction.AnimationHoverSpeed = 0.07!
        Me.btntramsaction.AnimationSpeed = 0.03!
        Me.btntramsaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btntramsaction.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btntramsaction.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btntramsaction.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btntramsaction.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btntramsaction.CheckedForeColor = System.Drawing.Color.White
        Me.btntramsaction.CheckedImage = Global.Capstone_Project.My.Resources.Resources.settle
        Me.btntramsaction.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btntramsaction.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btntramsaction.FocusedColor = System.Drawing.Color.Empty
        Me.btntramsaction.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntramsaction.ForeColor = System.Drawing.Color.White
        Me.btntramsaction.Image = Global.Capstone_Project.My.Resources.Resources.settle
        Me.btntramsaction.ImageSize = New System.Drawing.Size(30, 30)
        Me.btntramsaction.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btntramsaction.Location = New System.Drawing.Point(0, 456)
        Me.btntramsaction.Name = "btntramsaction"
        Me.btntramsaction.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btntramsaction.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btntramsaction.OnHoverForeColor = System.Drawing.Color.White
        Me.btntramsaction.OnHoverImage = Nothing
        Me.btntramsaction.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btntramsaction.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btntramsaction.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btntramsaction.Size = New System.Drawing.Size(327, 53)
        Me.btntramsaction.TabIndex = 6
        Me.btntramsaction.Text = "[F3] Save Transaction "
        Me.btntramsaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnbrowse
        '
        Me.btnbrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrowse.Animated = True
        Me.btnbrowse.AnimationHoverSpeed = 0.07!
        Me.btnbrowse.AnimationSpeed = 0.03!
        Me.btnbrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbrowse.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbrowse.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbrowse.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbrowse.CheckedForeColor = System.Drawing.Color.White
        Me.btnbrowse.CheckedImage = Global.Capstone_Project.My.Resources.Resources.product_64px
        Me.btnbrowse.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbrowse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbrowse.FocusedColor = System.Drawing.Color.Empty
        Me.btnbrowse.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Image = Global.Capstone_Project.My.Resources.Resources.product_64px
        Me.btnbrowse.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnbrowse.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbrowse.Location = New System.Drawing.Point(0, 403)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbrowse.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbrowse.OnHoverImage = Nothing
        Me.btnbrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbrowse.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbrowse.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnbrowse.Size = New System.Drawing.Size(327, 53)
        Me.btnbrowse.TabIndex = 5
        Me.btnbrowse.Text = "[F2] Browse Product "
        Me.btnbrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmembership
        '
        Me.btnmembership.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmembership.Animated = True
        Me.btnmembership.AnimationHoverSpeed = 0.07!
        Me.btnmembership.AnimationSpeed = 0.03!
        Me.btnmembership.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.CheckedForeColor = System.Drawing.Color.White
        Me.btnmembership.CheckedImage = Global.Capstone_Project.My.Resources.Resources.newtransac
        Me.btnmembership.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnmembership.FocusedColor = System.Drawing.Color.Empty
        Me.btnmembership.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmembership.ForeColor = System.Drawing.Color.White
        Me.btnmembership.Image = Global.Capstone_Project.My.Resources.Resources.newtransac
        Me.btnmembership.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnmembership.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.Location = New System.Drawing.Point(0, 350)
        Me.btnmembership.Name = "btnmembership"
        Me.btnmembership.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.OnHoverForeColor = System.Drawing.Color.White
        Me.btnmembership.OnHoverImage = Nothing
        Me.btnmembership.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnmembership.Size = New System.Drawing.Size(327, 53)
        Me.btnmembership.TabIndex = 4
        Me.btnmembership.Text = "[F1] New Transaction"
        Me.btnmembership.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerDate
        '
        '
        'TimerTime
        '
        '
        'pnlInvoice
        '
        Me.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.pnlInvoice.Controls.Add(Me.lbltransaction)
        Me.pnlInvoice.Controls.Add(Me.lbltransaction_no)
        Me.pnlInvoice.Controls.Add(Me.lbl)
        Me.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInvoice.Location = New System.Drawing.Point(0, 0)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Size = New System.Drawing.Size(1031, 37)
        Me.pnlInvoice.TabIndex = 0
        '
        'lbltransaction
        '
        Me.lbltransaction.AutoSize = True
        Me.lbltransaction.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransaction.ForeColor = System.Drawing.Color.White
        Me.lbltransaction.Location = New System.Drawing.Point(152, 7)
        Me.lbltransaction.Name = "lbltransaction"
        Me.lbltransaction.Size = New System.Drawing.Size(196, 31)
        Me.lbltransaction.TabIndex = 2
        Me.lbltransaction.Text = "______________"
        '
        'lbltransaction_no
        '
        Me.lbltransaction_no.AutoSize = True
        Me.lbltransaction_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransaction_no.ForeColor = System.Drawing.Color.White
        Me.lbltransaction_no.Location = New System.Drawing.Point(156, 5)
        Me.lbltransaction_no.Name = "lbltransaction_no"
        Me.lbltransaction_no.Size = New System.Drawing.Size(0, 22)
        Me.lbltransaction_no.TabIndex = 1
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(12, 7)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(160, 31)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Transaction No.:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlSales)
        Me.Panel1.Controls.Add(Me.pnlInvoice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 661)
        Me.Panel1.TabIndex = 1
        '
        'pnlSales
        '
        Me.pnlSales.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSales.Controls.Add(Me.numquantity)
        Me.pnlSales.Controls.Add(Me.GunaAdvenceButton1)
        Me.pnlSales.Controls.Add(Me.btnaddtocart)
        Me.pnlSales.Controls.Add(Me.Panel2)
        Me.pnlSales.Controls.Add(Me.Label3)
        Me.pnlSales.Controls.Add(Me.Label2)
        Me.pnlSales.Controls.Add(Me.cmbProducts)
        Me.pnlSales.Controls.Add(Me.Label1)
        Me.pnlSales.Controls.Add(Me.cmbCategory)
        Me.pnlSales.Controls.Add(Me.dgvCart)
        Me.pnlSales.Controls.Add(Me.dgvProducts)
        Me.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSales.Location = New System.Drawing.Point(0, 37)
        Me.pnlSales.Name = "pnlSales"
        Me.pnlSales.Size = New System.Drawing.Size(1031, 624)
        Me.pnlSales.TabIndex = 1
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Navy
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Global.Capstone_Project.My.Resources.Resources.newtransac
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(675, 44)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.GunaAdvenceButton1.Radius = 4
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(106, 29)
        Me.GunaAdvenceButton1.TabIndex = 74
        Me.GunaAdvenceButton1.Text = "Sales History"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnaddtocart
        '
        Me.btnaddtocart.Animated = True
        Me.btnaddtocart.AnimationHoverSpeed = 0.07!
        Me.btnaddtocart.AnimationSpeed = 0.03!
        Me.btnaddtocart.BackColor = System.Drawing.Color.Transparent
        Me.btnaddtocart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaddtocart.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaddtocart.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaddtocart.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaddtocart.CheckedForeColor = System.Drawing.Color.White
        Me.btnaddtocart.CheckedImage = Global.Capstone_Project.My.Resources.Resources.newtransac
        Me.btnaddtocart.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaddtocart.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnaddtocart.FocusedColor = System.Drawing.Color.Empty
        Me.btnaddtocart.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddtocart.ForeColor = System.Drawing.Color.White
        Me.btnaddtocart.Image = Nothing
        Me.btnaddtocart.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnaddtocart.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaddtocart.Location = New System.Drawing.Point(549, 44)
        Me.btnaddtocart.Name = "btnaddtocart"
        Me.btnaddtocart.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaddtocart.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaddtocart.OnHoverForeColor = System.Drawing.Color.White
        Me.btnaddtocart.OnHoverImage = Nothing
        Me.btnaddtocart.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaddtocart.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaddtocart.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnaddtocart.Radius = 4
        Me.btnaddtocart.Size = New System.Drawing.Size(120, 30)
        Me.btnaddtocart.TabIndex = 72
        Me.btnaddtocart.Text = "Add to cart"
        Me.btnaddtocart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.AllowUserToOrderColumns = True
        Me.dgvCart.AllowUserToResizeColumns = False
        Me.dgvCart.AllowUserToResizeRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvCart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.BackgroundColor = System.Drawing.Color.White
        Me.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvCart.ColumnHeadersHeight = 50
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transactionno, Me.product, Me.category, Me.price, Me.quantity, Me.total})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvCart.EnableHeadersVisualStyles = False
        Me.dgvCart.GridColor = System.Drawing.Color.White
        Me.dgvCart.Location = New System.Drawing.Point(11, 81)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvCart.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCart.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCart.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.RowTemplate.Height = 40
        Me.dgvCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(678, 504)
        Me.dgvCart.TabIndex = 70
        Me.dgvCart.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCart.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCart.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvCart.ThemeStyle.ReadOnly = True
        Me.dgvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCart.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCart.ThemeStyle.RowsStyle.Height = 40
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'numquantity
        '
        Me.numquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numquantity.Location = New System.Drawing.Point(479, 46)
        Me.numquantity.Name = "numquantity"
        Me.numquantity.Size = New System.Drawing.Size(48, 29)
        Me.numquantity.TabIndex = 75
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 661)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "sales"
        Me.Text = "sales"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoice.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlSales.ResumeLayout(False)
        Me.pnlSales.PerformLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents btnbrowse As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnmembership As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProducts As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents transactionno As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents dgvProducts As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents brandname As DataGridViewTextBoxColumn
    Friend WithEvents productnamr As DataGridViewTextBoxColumn
    Friend WithEvents pcategory As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents btntramsaction As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtchange As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtpayment As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtamount As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TimerDate As Timer
    Friend WithEvents TimerTime As Timer
    Friend WithEvents pnlInvoice As Panel
    Friend WithEvents lbltransaction As Label
    Friend WithEvents lbltransaction_no As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlSales As Panel
    Friend WithEvents btnaddtocart As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents dgvCart As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnremovefromcart As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents numquantity As TextBox
End Class
