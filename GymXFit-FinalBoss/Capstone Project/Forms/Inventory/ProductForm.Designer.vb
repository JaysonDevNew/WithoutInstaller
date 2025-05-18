<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvproductlist = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnAddnewproduct = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblproductlist = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pedit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pdelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvproductlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 49)
        Me.Panel1.TabIndex = 37
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(950, 3)
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
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product List"
        '
        'dgvproductlist
        '
        Me.dgvproductlist.AllowUserToAddRows = False
        Me.dgvproductlist.AllowUserToDeleteRows = False
        Me.dgvproductlist.AllowUserToOrderColumns = True
        Me.dgvproductlist.AllowUserToResizeColumns = False
        Me.dgvproductlist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvproductlist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvproductlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvproductlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvproductlist.BackgroundColor = System.Drawing.Color.White
        Me.dgvproductlist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvproductlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvproductlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproductlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvproductlist.ColumnHeadersHeight = 50
        Me.dgvproductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvproductlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.brandname, Me.productname, Me.pcategory, Me.price, Me.quantity, Me.pedit, Me.pdelete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproductlist.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvproductlist.EnableHeadersVisualStyles = False
        Me.dgvproductlist.GridColor = System.Drawing.Color.White
        Me.dgvproductlist.Location = New System.Drawing.Point(8, 125)
        Me.dgvproductlist.Name = "dgvproductlist"
        Me.dgvproductlist.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproductlist.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvproductlist.RowHeadersVisible = False
        Me.dgvproductlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproductlist.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvproductlist.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvproductlist.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvproductlist.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproductlist.RowTemplate.Height = 40
        Me.dgvproductlist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvproductlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproductlist.Size = New System.Drawing.Size(970, 491)
        Me.dgvproductlist.TabIndex = 38
        Me.dgvproductlist.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvproductlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvproductlist.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvproductlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvproductlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvproductlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvproductlist.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvproductlist.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvproductlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvproductlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvproductlist.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvproductlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvproductlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvproductlist.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvproductlist.ThemeStyle.ReadOnly = True
        Me.dgvproductlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvproductlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvproductlist.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvproductlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvproductlist.ThemeStyle.RowsStyle.Height = 40
        Me.dgvproductlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvproductlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnAddnewproduct
        '
        Me.btnAddnewproduct.Animated = True
        Me.btnAddnewproduct.AnimationHoverSpeed = 0.07!
        Me.btnAddnewproduct.AnimationSpeed = 0.03!
        Me.btnAddnewproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnAddnewproduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddnewproduct.BorderColor = System.Drawing.Color.Black
        Me.btnAddnewproduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddnewproduct.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddnewproduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddnewproduct.CheckedImage = Nothing
        Me.btnAddnewproduct.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddnewproduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddnewproduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddnewproduct.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnAddnewproduct.ForeColor = System.Drawing.Color.White
        Me.btnAddnewproduct.Image = Nothing
        Me.btnAddnewproduct.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddnewproduct.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddnewproduct.Location = New System.Drawing.Point(12, 73)
        Me.btnAddnewproduct.Name = "btnAddnewproduct"
        Me.btnAddnewproduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddnewproduct.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddnewproduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddnewproduct.OnHoverImage = Nothing
        Me.btnAddnewproduct.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddnewproduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddnewproduct.Radius = 4
        Me.btnAddnewproduct.Size = New System.Drawing.Size(122, 33)
        Me.btnAddnewproduct.TabIndex = 39
        Me.btnAddnewproduct.Text = "Add Product"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(874, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 25)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Total Record"
        '
        'lblproductlist
        '
        Me.lblproductlist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblproductlist.AutoSize = True
        Me.lblproductlist.Font = New System.Drawing.Font("Poppins Medium", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductlist.ForeColor = System.Drawing.Color.Black
        Me.lblproductlist.Location = New System.Drawing.Point(905, 63)
        Me.lblproductlist.Name = "lblproductlist"
        Me.lblproductlist.Size = New System.Drawing.Size(61, 76)
        Me.lblproductlist.TabIndex = 41
        Me.lblproductlist.Text = "0"
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 49
        '
        'brandname
        '
        Me.brandname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.brandname.HeaderText = "Brand Name"
        Me.brandname.Name = "brandname"
        Me.brandname.ReadOnly = True
        '
        'productname
        '
        Me.productname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productname.HeaderText = "Product Name"
        Me.productname.Name = "productname"
        Me.productname.ReadOnly = True
        '
        'pcategory
        '
        Me.pcategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pcategory.HeaderText = "Category"
        Me.pcategory.Name = "pcategory"
        Me.pcategory.ReadOnly = True
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 69
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 95
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Capstone_Project.My.Resources.Resources.pedit
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 5
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.Capstone_Project.My.Resources.Resources.pdelete
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 5
        '
        'pedit
        '
        Me.pedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pedit.HeaderText = ""
        Me.pedit.Image = Global.Capstone_Project.My.Resources.Resources.pedit
        Me.pedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.pedit.Name = "pedit"
        Me.pedit.ReadOnly = True
        Me.pedit.Width = 5
        '
        'pdelete
        '
        Me.pdelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pdelete.HeaderText = ""
        Me.pdelete.Image = Global.Capstone_Project.My.Resources.Resources.pdelete
        Me.pdelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.pdelete.Name = "pdelete"
        Me.pdelete.ReadOnly = True
        Me.pdelete.Width = 5
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
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 628)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAddnewproduct)
        Me.Controls.Add(Me.dgvproductlist)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblproductlist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvproductlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvproductlist As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnAddnewproduct As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Label10 As Label
    Friend WithEvents lblproductlist As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents brandname As DataGridViewTextBoxColumn
    Friend WithEvents productname As DataGridViewTextBoxColumn
    Friend WithEvents pcategory As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents pedit As DataGridViewImageColumn
    Friend WithEvents pdelete As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
