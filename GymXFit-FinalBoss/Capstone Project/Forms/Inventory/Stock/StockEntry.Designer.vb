<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockEntry
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblnormal = New System.Windows.Forms.Label()
        Me.lbllow = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.lblcritical = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblstockadjustment = New System.Windows.Forms.Label()
        Me.lbladjustmenthistory = New System.Windows.Forms.Label()
        Me.lblstockhistory = New System.Windows.Forms.Label()
        Me.lblstock = New System.Windows.Forms.Label()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btngenerate = New Guna.UI.WinForms.GunaButton()
        Me.btnfinishrestocking = New Guna.UI.WinForms.GunaButton()
        Me.btnselectproduct = New Guna.UI.WinForms.GunaButton()
        Me.btnupdatestock = New Guna.UI.WinForms.GunaButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpdatereceived = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txtrefno = New Guna.UI.WinForms.GunaTextBox()
        Me.Searc = New System.Windows.Forms.Label()
        Me.txtreceivedby = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelmain = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProductName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtaddedstock = New Guna.UI.WinForms.GunaTextBox()
        Me.txtProductID = New Guna.UI.WinForms.GunaTextBox()
        Me.dgvStockEntry = New Guna.UI.WinForms.GunaDataGridView()
        Me.productid1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcategory1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currentstock1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addedstock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelselect = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbCategory = New Guna.UI.WinForms.GunaComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GunaLinePanel3 = New Guna.UI.WinForms.GunaLinePanel()
        Me.dgvProducts = New Guna.UI.WinForms.GunaDataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsearch = New Guna.UI.WinForms.GunaTextBox()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinePanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GunaLinePanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelmain.SuspendLayout()
        CType(Me.dgvStockEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelselect.SuspendLayout()
        Me.GunaLinePanel3.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnormal
        '
        Me.lblnormal.AutoSize = True
        Me.lblnormal.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnormal.Location = New System.Drawing.Point(26, 28)
        Me.lblnormal.Name = "lblnormal"
        Me.lblnormal.Size = New System.Drawing.Size(34, 42)
        Me.lblnormal.TabIndex = 60
        Me.lblnormal.Text = "0"
        '
        'lbllow
        '
        Me.lbllow.AutoSize = True
        Me.lbllow.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllow.Location = New System.Drawing.Point(27, 28)
        Me.lbllow.Name = "lbllow"
        Me.lbllow.Size = New System.Drawing.Size(34, 42)
        Me.lbllow.TabIndex = 59
        Me.lbllow.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 23)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Normal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 16)
        Me.Label9.TabIndex = 58
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.lblcritical)
        Me.GunaLinePanel1.Controls.Add(Me.Label11)
        Me.GunaLinePanel1.ForeColor = System.Drawing.Color.White
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(27, 84)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(80, 71)
        Me.GunaLinePanel1.TabIndex = 55
        '
        'lblcritical
        '
        Me.lblcritical.AutoSize = True
        Me.lblcritical.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcritical.Location = New System.Drawing.Point(26, 28)
        Me.lblcritical.Name = "lblcritical"
        Me.lblcritical.Size = New System.Drawing.Size(34, 42)
        Me.lblcritical.TabIndex = 58
        Me.lblcritical.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 23)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Crittical"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(597, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 23)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Product Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 42)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Product List"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblstockadjustment)
        Me.Panel3.Controls.Add(Me.lbladjustmenthistory)
        Me.Panel3.Controls.Add(Me.lblstockhistory)
        Me.Panel3.Controls.Add(Me.lblstock)
        Me.Panel3.Location = New System.Drawing.Point(12, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(523, 49)
        Me.Panel3.TabIndex = 49
        '
        'lblstockadjustment
        '
        Me.lblstockadjustment.AutoSize = True
        Me.lblstockadjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockadjustment.Location = New System.Drawing.Point(212, 19)
        Me.lblstockadjustment.Name = "lblstockadjustment"
        Me.lblstockadjustment.Size = New System.Drawing.Size(117, 15)
        Me.lblstockadjustment.TabIndex = 3
        Me.lblstockadjustment.Text = "Stock Adjustment"
        '
        'lbladjustmenthistory
        '
        Me.lbladjustmenthistory.AutoSize = True
        Me.lbladjustmenthistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladjustmenthistory.Location = New System.Drawing.Point(343, 19)
        Me.lbladjustmenthistory.Name = "lbladjustmenthistory"
        Me.lbladjustmenthistory.Size = New System.Drawing.Size(130, 15)
        Me.lbladjustmenthistory.TabIndex = 2
        Me.lbladjustmenthistory.Text = "Adjustment  History"
        '
        'lblstockhistory
        '
        Me.lblstockhistory.AutoSize = True
        Me.lblstockhistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockhistory.Location = New System.Drawing.Point(96, 19)
        Me.lblstockhistory.Name = "lblstockhistory"
        Me.lblstockhistory.Size = New System.Drawing.Size(106, 15)
        Me.lblstockhistory.TabIndex = 1
        Me.lblstockhistory.Text = "Stock In History"
        '
        'lblstock
        '
        Me.lblstock.AutoSize = True
        Me.lblstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.Location = New System.Drawing.Point(12, 19)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(78, 15)
        Me.lblstock.TabIndex = 0
        Me.lblstock.Text = "Stock Entry"
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.GunaLinePanel2.Controls.Add(Me.lbllow)
        Me.GunaLinePanel2.Controls.Add(Me.Label8)
        Me.GunaLinePanel2.Controls.Add(Me.Label9)
        Me.GunaLinePanel2.ForeColor = System.Drawing.Color.White
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(122, 84)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(80, 71)
        Me.GunaLinePanel2.TabIndex = 56
        '
        'btngenerate
        '
        Me.btngenerate.Animated = True
        Me.btngenerate.AnimationHoverSpeed = 0.07!
        Me.btngenerate.AnimationSpeed = 0.03!
        Me.btngenerate.BackColor = System.Drawing.Color.Transparent
        Me.btngenerate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btngenerate.BorderColor = System.Drawing.Color.Black
        Me.btngenerate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btngenerate.FocusedColor = System.Drawing.Color.Empty
        Me.btngenerate.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerate.ForeColor = System.Drawing.Color.White
        Me.btngenerate.Image = Nothing
        Me.btngenerate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btngenerate.Location = New System.Drawing.Point(643, 86)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btngenerate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btngenerate.OnHoverForeColor = System.Drawing.Color.White
        Me.btngenerate.OnHoverImage = Nothing
        Me.btngenerate.OnPressedColor = System.Drawing.Color.Black
        Me.btngenerate.Radius = 6
        Me.btngenerate.Size = New System.Drawing.Size(75, 29)
        Me.btngenerate.TabIndex = 56
        Me.btngenerate.Text = "Generate"
        Me.btngenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnfinishrestocking
        '
        Me.btnfinishrestocking.Animated = True
        Me.btnfinishrestocking.AnimationHoverSpeed = 0.07!
        Me.btnfinishrestocking.AnimationSpeed = 0.03!
        Me.btnfinishrestocking.BackColor = System.Drawing.Color.Transparent
        Me.btnfinishrestocking.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnfinishrestocking.BorderColor = System.Drawing.Color.Black
        Me.btnfinishrestocking.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnfinishrestocking.FocusedColor = System.Drawing.Color.Empty
        Me.btnfinishrestocking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinishrestocking.ForeColor = System.Drawing.Color.White
        Me.btnfinishrestocking.Image = Nothing
        Me.btnfinishrestocking.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnfinishrestocking.Location = New System.Drawing.Point(1039, 798)
        Me.btnfinishrestocking.Name = "btnfinishrestocking"
        Me.btnfinishrestocking.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnfinishrestocking.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnfinishrestocking.OnHoverForeColor = System.Drawing.Color.White
        Me.btnfinishrestocking.OnHoverImage = Nothing
        Me.btnfinishrestocking.OnPressedColor = System.Drawing.Color.Black
        Me.btnfinishrestocking.Radius = 6
        Me.btnfinishrestocking.Size = New System.Drawing.Size(138, 47)
        Me.btnfinishrestocking.TabIndex = 55
        Me.btnfinishrestocking.Text = "Finish Restocking"
        Me.btnfinishrestocking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnselectproduct
        '
        Me.btnselectproduct.Animated = True
        Me.btnselectproduct.AnimationHoverSpeed = 0.07!
        Me.btnselectproduct.AnimationSpeed = 0.03!
        Me.btnselectproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnselectproduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnselectproduct.BorderColor = System.Drawing.Color.Black
        Me.btnselectproduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnselectproduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnselectproduct.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectproduct.ForeColor = System.Drawing.Color.White
        Me.btnselectproduct.Image = Nothing
        Me.btnselectproduct.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnselectproduct.Location = New System.Drawing.Point(35, 63)
        Me.btnselectproduct.Name = "btnselectproduct"
        Me.btnselectproduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnselectproduct.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnselectproduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnselectproduct.OnHoverImage = Nothing
        Me.btnselectproduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnselectproduct.Radius = 6
        Me.btnselectproduct.Size = New System.Drawing.Size(196, 56)
        Me.btnselectproduct.TabIndex = 44
        Me.btnselectproduct.Text = "Select Product"
        Me.btnselectproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnupdatestock
        '
        Me.btnupdatestock.Animated = True
        Me.btnupdatestock.AnimationHoverSpeed = 0.07!
        Me.btnupdatestock.AnimationSpeed = 0.03!
        Me.btnupdatestock.BackColor = System.Drawing.Color.Transparent
        Me.btnupdatestock.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnupdatestock.BorderColor = System.Drawing.Color.Black
        Me.btnupdatestock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupdatestock.FocusedColor = System.Drawing.Color.Empty
        Me.btnupdatestock.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatestock.ForeColor = System.Drawing.Color.White
        Me.btnupdatestock.Image = Nothing
        Me.btnupdatestock.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnupdatestock.Location = New System.Drawing.Point(1184, 798)
        Me.btnupdatestock.Name = "btnupdatestock"
        Me.btnupdatestock.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnupdatestock.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdatestock.OnHoverForeColor = System.Drawing.Color.White
        Me.btnupdatestock.OnHoverImage = Nothing
        Me.btnupdatestock.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdatestock.Radius = 6
        Me.btnupdatestock.Size = New System.Drawing.Size(138, 47)
        Me.btnupdatestock.TabIndex = 54
        Me.btnupdatestock.Text = "Confirm"
        Me.btnupdatestock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(473, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Received By"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Reference No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(743, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Date Received"
        '
        'dtpdatereceived
        '
        Me.dtpdatereceived.BaseColor = System.Drawing.Color.White
        Me.dtpdatereceived.BorderColor = System.Drawing.Color.Silver
        Me.dtpdatereceived.CustomFormat = Nothing
        Me.dtpdatereceived.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpdatereceived.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dtpdatereceived.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdatereceived.ForeColor = System.Drawing.Color.Black
        Me.dtpdatereceived.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatereceived.Location = New System.Drawing.Point(746, 88)
        Me.dtpdatereceived.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpdatereceived.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpdatereceived.Name = "dtpdatereceived"
        Me.dtpdatereceived.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpdatereceived.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpdatereceived.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpdatereceived.OnPressedColor = System.Drawing.Color.Black
        Me.dtpdatereceived.Size = New System.Drawing.Size(436, 27)
        Me.dtpdatereceived.TabIndex = 49
        Me.dtpdatereceived.Text = "2/13/2025"
        Me.dtpdatereceived.Value = New Date(2025, 2, 13, 19, 42, 4, 831)
        '
        'txtrefno
        '
        Me.txtrefno.BackColor = System.Drawing.Color.Transparent
        Me.txtrefno.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtrefno.BorderColor = System.Drawing.Color.Silver
        Me.txtrefno.BorderSize = 0
        Me.txtrefno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrefno.FocusedBaseColor = System.Drawing.Color.White
        Me.txtrefno.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtrefno.FocusedForeColor = System.Drawing.Color.Black
        Me.txtrefno.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtrefno.ForeColor = System.Drawing.Color.Black
        Me.txtrefno.Location = New System.Drawing.Point(258, 87)
        Me.txtrefno.Name = "txtrefno"
        Me.txtrefno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrefno.Radius = 4
        Me.txtrefno.SelectedText = ""
        Me.txtrefno.Size = New System.Drawing.Size(379, 30)
        Me.txtrefno.TabIndex = 48
        '
        'Searc
        '
        Me.Searc.AutoSize = True
        Me.Searc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searc.Location = New System.Drawing.Point(989, 122)
        Me.Searc.Name = "Searc"
        Me.Searc.Size = New System.Drawing.Size(157, 16)
        Me.Searc.TabIndex = 47
        Me.Searc.Text = "Total Stock Received"
        '
        'txtreceivedby
        '
        Me.txtreceivedby.BackColor = System.Drawing.Color.Transparent
        Me.txtreceivedby.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtreceivedby.BorderColor = System.Drawing.Color.Silver
        Me.txtreceivedby.BorderSize = 0
        Me.txtreceivedby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreceivedby.FocusedBaseColor = System.Drawing.Color.White
        Me.txtreceivedby.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtreceivedby.FocusedForeColor = System.Drawing.Color.Black
        Me.txtreceivedby.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtreceivedby.ForeColor = System.Drawing.Color.Black
        Me.txtreceivedby.Location = New System.Drawing.Point(477, 150)
        Me.txtreceivedby.Name = "txtreceivedby"
        Me.txtreceivedby.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreceivedby.Radius = 4
        Me.txtreceivedby.SelectedText = ""
        Me.txtreceivedby.Size = New System.Drawing.Size(455, 30)
        Me.txtreceivedby.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 23)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "High"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1330, 49)
        Me.Panel1.TabIndex = 46
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1290, 3)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stock Entry"
        '
        'panelmain
        '
        Me.panelmain.Controls.Add(Me.Label13)
        Me.panelmain.Controls.Add(Me.Label12)
        Me.panelmain.Controls.Add(Me.Panel3)
        Me.panelmain.Controls.Add(Me.btngenerate)
        Me.panelmain.Controls.Add(Me.btnfinishrestocking)
        Me.panelmain.Controls.Add(Me.btnselectproduct)
        Me.panelmain.Controls.Add(Me.btnupdatestock)
        Me.panelmain.Controls.Add(Me.Label5)
        Me.panelmain.Controls.Add(Me.Label4)
        Me.panelmain.Controls.Add(Me.Label3)
        Me.panelmain.Controls.Add(Me.Label2)
        Me.panelmain.Controls.Add(Me.dtpdatereceived)
        Me.panelmain.Controls.Add(Me.txtrefno)
        Me.panelmain.Controls.Add(Me.Searc)
        Me.panelmain.Controls.Add(Me.txtProductName)
        Me.panelmain.Controls.Add(Me.txtreceivedby)
        Me.panelmain.Controls.Add(Me.txtaddedstock)
        Me.panelmain.Controls.Add(Me.txtProductID)
        Me.panelmain.Controls.Add(Me.dgvStockEntry)
        Me.panelmain.Controls.Add(Me.panelselect)
        Me.panelmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelmain.Location = New System.Drawing.Point(0, 0)
        Me.panelmain.Name = "panelmain"
        Me.panelmain.Size = New System.Drawing.Size(1330, 788)
        Me.panelmain.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label13.Location = New System.Drawing.Point(1252, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 28)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Stock History"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1413, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 28)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Stock in  History"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.Transparent
        Me.txtProductName.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtProductName.BorderColor = System.Drawing.Color.Silver
        Me.txtProductName.BorderSize = 0
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtProductName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtProductName.FocusedForeColor = System.Drawing.Color.Black
        Me.txtProductName.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(35, 150)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.Radius = 4
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.Size = New System.Drawing.Size(379, 30)
        Me.txtProductName.TabIndex = 46
        '
        'txtaddedstock
        '
        Me.txtaddedstock.BackColor = System.Drawing.Color.Transparent
        Me.txtaddedstock.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtaddedstock.BorderColor = System.Drawing.Color.Silver
        Me.txtaddedstock.BorderSize = 0
        Me.txtaddedstock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddedstock.FocusedBaseColor = System.Drawing.Color.White
        Me.txtaddedstock.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtaddedstock.FocusedForeColor = System.Drawing.Color.Black
        Me.txtaddedstock.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddedstock.ForeColor = System.Drawing.Color.Black
        Me.txtaddedstock.Location = New System.Drawing.Point(993, 150)
        Me.txtaddedstock.Name = "txtaddedstock"
        Me.txtaddedstock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddedstock.Radius = 4
        Me.txtaddedstock.SelectedText = ""
        Me.txtaddedstock.Size = New System.Drawing.Size(340, 30)
        Me.txtaddedstock.TabIndex = 43
        '
        'txtProductID
        '
        Me.txtProductID.BackColor = System.Drawing.Color.Transparent
        Me.txtProductID.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtProductID.BorderColor = System.Drawing.Color.Silver
        Me.txtProductID.BorderSize = 0
        Me.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtProductID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtProductID.FocusedForeColor = System.Drawing.Color.Black
        Me.txtProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.ForeColor = System.Drawing.Color.Black
        Me.txtProductID.Location = New System.Drawing.Point(133, 79)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductID.Radius = 4
        Me.txtProductID.SelectedText = ""
        Me.txtProductID.Size = New System.Drawing.Size(88, 24)
        Me.txtProductID.TabIndex = 42
        '
        'dgvStockEntry
        '
        Me.dgvStockEntry.AllowUserToAddRows = False
        Me.dgvStockEntry.AllowUserToDeleteRows = False
        Me.dgvStockEntry.AllowUserToOrderColumns = True
        Me.dgvStockEntry.AllowUserToResizeColumns = False
        Me.dgvStockEntry.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStockEntry.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStockEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStockEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockEntry.BackgroundColor = System.Drawing.Color.White
        Me.dgvStockEntry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStockEntry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockEntry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStockEntry.ColumnHeadersHeight = 50
        Me.dgvStockEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStockEntry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productid1, Me.brandname1, Me.productname1, Me.pcategory1, Me.price1, Me.currentstock1, Me.addedstock})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockEntry.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStockEntry.EnableHeadersVisualStyles = False
        Me.dgvStockEntry.GridColor = System.Drawing.Color.White
        Me.dgvStockEntry.Location = New System.Drawing.Point(35, 206)
        Me.dgvStockEntry.Name = "dgvStockEntry"
        Me.dgvStockEntry.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockEntry.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStockEntry.RowHeadersVisible = False
        Me.dgvStockEntry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockEntry.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStockEntry.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvStockEntry.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.dgvStockEntry.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockEntry.RowTemplate.Height = 40
        Me.dgvStockEntry.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockEntry.Size = New System.Drawing.Size(1241, 542)
        Me.dgvStockEntry.TabIndex = 40
        Me.dgvStockEntry.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvStockEntry.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockEntry.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvStockEntry.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStockEntry.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvStockEntry.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStockEntry.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockEntry.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvStockEntry.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvStockEntry.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStockEntry.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockEntry.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStockEntry.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStockEntry.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvStockEntry.ThemeStyle.ReadOnly = True
        Me.dgvStockEntry.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStockEntry.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockEntry.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockEntry.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStockEntry.ThemeStyle.RowsStyle.Height = 40
        Me.dgvStockEntry.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvStockEntry.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStockEntry.Visible = False
        '
        'productid1
        '
        Me.productid1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.productid1.HeaderText = "ID"
        Me.productid1.Name = "productid1"
        Me.productid1.ReadOnly = True
        Me.productid1.Width = 50
        '
        'brandname1
        '
        Me.brandname1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.brandname1.HeaderText = "Brand Name"
        Me.brandname1.Name = "brandname1"
        Me.brandname1.ReadOnly = True
        '
        'productname1
        '
        Me.productname1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productname1.HeaderText = "Product Name"
        Me.productname1.Name = "productname1"
        Me.productname1.ReadOnly = True
        '
        'pcategory1
        '
        Me.pcategory1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pcategory1.HeaderText = "Category"
        Me.pcategory1.Name = "pcategory1"
        Me.pcategory1.ReadOnly = True
        '
        'price1
        '
        Me.price1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price1.HeaderText = "Price"
        Me.price1.Name = "price1"
        Me.price1.ReadOnly = True
        Me.price1.Width = 74
        '
        'currentstock1
        '
        Me.currentstock1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.currentstock1.HeaderText = "Current Stock"
        Me.currentstock1.Name = "currentstock1"
        Me.currentstock1.ReadOnly = True
        Me.currentstock1.Width = 142
        '
        'addedstock
        '
        Me.addedstock.HeaderText = "Added Stock"
        Me.addedstock.Name = "addedstock"
        Me.addedstock.ReadOnly = True
        '
        'panelselect
        '
        Me.panelselect.Controls.Add(Me.GunaButton1)
        Me.panelselect.Controls.Add(Me.Label14)
        Me.panelselect.Controls.Add(Me.cmbCategory)
        Me.panelselect.Controls.Add(Me.Button1)
        Me.panelselect.Controls.Add(Me.GunaLinePanel3)
        Me.panelselect.Controls.Add(Me.GunaLinePanel2)
        Me.panelselect.Controls.Add(Me.GunaLinePanel1)
        Me.panelselect.Controls.Add(Me.Label7)
        Me.panelselect.Controls.Add(Me.Label6)
        Me.panelselect.Controls.Add(Me.dgvProducts)
        Me.panelselect.Controls.Add(Me.txtsearch)
        Me.panelselect.Location = New System.Drawing.Point(241, 189)
        Me.panelselect.Name = "panelselect"
        Me.panelselect.Size = New System.Drawing.Size(899, 573)
        Me.panelselect.TabIndex = 47
        Me.panelselect.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(356, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 23)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Category"
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
        Me.cmbCategory.Location = New System.Drawing.Point(434, 118)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbCategory.Radius = 4
        Me.cmbCategory.Size = New System.Drawing.Size(157, 28)
        Me.cmbCategory.TabIndex = 66
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(784, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GunaLinePanel3
        '
        Me.GunaLinePanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.GunaLinePanel3.Controls.Add(Me.lblnormal)
        Me.GunaLinePanel3.Controls.Add(Me.Label10)
        Me.GunaLinePanel3.ForeColor = System.Drawing.Color.White
        Me.GunaLinePanel3.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel3.Location = New System.Drawing.Point(215, 84)
        Me.GunaLinePanel3.Name = "GunaLinePanel3"
        Me.GunaLinePanel3.Size = New System.Drawing.Size(80, 71)
        Me.GunaLinePanel3.TabIndex = 57
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToOrderColumns = True
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProducts.ColumnHeadersHeight = 50
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.productname, Me.brandname, Me.pcategory, Me.price, Me.stock, Me.Action})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProducts.EnableHeadersVisualStyles = False
        Me.dgvProducts.GridColor = System.Drawing.Color.White
        Me.dgvProducts.Location = New System.Drawing.Point(24, 161)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Poppins", 9.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProducts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProducts.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.dgvProducts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowTemplate.Height = 40
        Me.dgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(856, 398)
        Me.dgvProducts.TabIndex = 39
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
        Me.dgvProducts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvProducts.ThemeStyle.ReadOnly = True
        Me.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProducts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
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
        'productname
        '
        Me.productname.HeaderText = "Product Name"
        Me.productname.Name = "productname"
        Me.productname.ReadOnly = True
        '
        'brandname
        '
        Me.brandname.HeaderText = "Brand Name"
        Me.brandname.Name = "brandname"
        Me.brandname.ReadOnly = True
        '
        'pcategory
        '
        Me.pcategory.HeaderText = "Category"
        Me.pcategory.Name = "pcategory"
        Me.pcategory.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.Transparent
        Me.txtsearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtsearch.BorderColor = System.Drawing.Color.Silver
        Me.txtsearch.BorderSize = 0
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.FocusedBaseColor = System.Drawing.Color.White
        Me.txtsearch.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtsearch.FocusedForeColor = System.Drawing.Color.Black
        Me.txtsearch.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(710, 118)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.Radius = 4
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.Size = New System.Drawing.Size(168, 29)
        Me.txtsearch.TabIndex = 41
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel1
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Me.panelselect
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(462, 269)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 6
        Me.GunaButton1.Size = New System.Drawing.Size(75, 29)
        Me.GunaButton1.TabIndex = 59
        Me.GunaButton1.Text = "Generate"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StockEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockEntry"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelmain.ResumeLayout(False)
        Me.panelmain.PerformLayout()
        CType(Me.dgvStockEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelselect.ResumeLayout(False)
        Me.panelselect.PerformLayout()
        Me.GunaLinePanel3.ResumeLayout(False)
        Me.GunaLinePanel3.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblnormal As Label
    Friend WithEvents lbllow As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents lblcritical As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblstockadjustment As Label
    Friend WithEvents lbladjustmenthistory As Label
    Friend WithEvents lblstockhistory As Label
    Friend WithEvents lblstock As Label
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents btngenerate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnfinishrestocking As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnselectproduct As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnupdatestock As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpdatereceived As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txtrefno As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Searc As Label
    Friend WithEvents txtreceivedby As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelmain As Panel
    Friend WithEvents txtProductName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtaddedstock As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtProductID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents dgvStockEntry As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents productid1 As DataGridViewTextBoxColumn
    Friend WithEvents brandname1 As DataGridViewTextBoxColumn
    Friend WithEvents productname1 As DataGridViewTextBoxColumn
    Friend WithEvents pcategory1 As DataGridViewTextBoxColumn
    Friend WithEvents price1 As DataGridViewTextBoxColumn
    Friend WithEvents currentstock1 As DataGridViewTextBoxColumn
    Friend WithEvents addedstock As DataGridViewTextBoxColumn
    Friend WithEvents dgvProducts As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents productname As DataGridViewTextBoxColumn
    Friend WithEvents brandname As DataGridViewTextBoxColumn
    Friend WithEvents pcategory As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
    Friend WithEvents txtsearch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents panelselect As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents GunaLinePanel3 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbCategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
