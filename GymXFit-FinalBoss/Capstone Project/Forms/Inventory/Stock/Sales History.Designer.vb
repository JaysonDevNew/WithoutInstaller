<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales_History
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblsold = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnrefresh = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.filter = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblsales = New System.Windows.Forms.Label()
        Me.btnexport = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.dgvSalesHistory = New Guna.UI.WinForms.GunaDataGridView()
        Me.transactionno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.change = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbtime = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbproducts = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmBCategory = New Guna.UI.WinForms.GunaComboBox()
        Me.btnConfirm = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTransaction = New System.Windows.Forms.ComboBox()
        Me.dtpto = New System.Windows.Forms.DateTimePicker()
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSalesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblsold)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnrefresh)
        Me.Panel2.Controls.Add(Me.filter)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblsales)
        Me.Panel2.Controls.Add(Me.btnexport)
        Me.Panel2.Controls.Add(Me.dgvSalesHistory)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmbtime)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbproducts)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmBCategory)
        Me.Panel2.Controls.Add(Me.btnConfirm)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmbTransaction)
        Me.Panel2.Controls.Add(Me.dtpto)
        Me.Panel2.Controls.Add(Me.dtpfrom)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(13, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1373, 730)
        Me.Panel2.TabIndex = 49
        '
        'lblsold
        '
        Me.lblsold.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsold.AutoSize = True
        Me.lblsold.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsold.ForeColor = System.Drawing.Color.Black
        Me.lblsold.Location = New System.Drawing.Point(1235, 38)
        Me.lblsold.Name = "lblsold"
        Me.lblsold.Size = New System.Drawing.Size(95, 56)
        Me.lblsold.TabIndex = 79
        Me.lblsold.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1219, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Product Sold"
        '
        'btnrefresh
        '
        Me.btnrefresh.Animated = True
        Me.btnrefresh.AnimationHoverSpeed = 0.07!
        Me.btnrefresh.AnimationSpeed = 0.03!
        Me.btnrefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnrefresh.BaseColor = System.Drawing.Color.Maroon
        Me.btnrefresh.BorderColor = System.Drawing.Color.Black
        Me.btnrefresh.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnrefresh.CheckedForeColor = System.Drawing.Color.White
        Me.btnrefresh.CheckedImage = Global.Capstone_Project.My.Resources.Resources.print_96px
        Me.btnrefresh.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnrefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnrefresh.FocusedColor = System.Drawing.Color.Empty
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.Image = Global.Capstone_Project.My.Resources.Resources.refresh_xxl
        Me.btnrefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnrefresh.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnrefresh.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.Location = New System.Drawing.Point(1115, 47)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnrefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.btnrefresh.OnHoverImage = Nothing
        Me.btnrefresh.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.OnPressedColor = System.Drawing.Color.Black
        Me.btnrefresh.Radius = 4
        Me.btnrefresh.Size = New System.Drawing.Size(56, 37)
        Me.btnrefresh.TabIndex = 77
        Me.btnrefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'filter
        '
        Me.filter.Animated = True
        Me.filter.AnimationHoverSpeed = 0.07!
        Me.filter.AnimationSpeed = 0.03!
        Me.filter.BackColor = System.Drawing.Color.Transparent
        Me.filter.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.filter.BorderColor = System.Drawing.Color.Black
        Me.filter.CheckedBaseColor = System.Drawing.Color.Gray
        Me.filter.CheckedBorderColor = System.Drawing.Color.Black
        Me.filter.CheckedForeColor = System.Drawing.Color.White
        Me.filter.CheckedImage = Nothing
        Me.filter.CheckedLineColor = System.Drawing.Color.DimGray
        Me.filter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.filter.FocusedColor = System.Drawing.Color.Empty
        Me.filter.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.filter.ForeColor = System.Drawing.Color.White
        Me.filter.Image = Nothing
        Me.filter.ImageSize = New System.Drawing.Size(52, 52)
        Me.filter.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.filter.Location = New System.Drawing.Point(448, 11)
        Me.filter.Name = "filter"
        Me.filter.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.filter.OnHoverBorderColor = System.Drawing.Color.Black
        Me.filter.OnHoverForeColor = System.Drawing.Color.White
        Me.filter.OnHoverImage = Nothing
        Me.filter.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.filter.OnPressedColor = System.Drawing.Color.Black
        Me.filter.Radius = 4
        Me.filter.Size = New System.Drawing.Size(92, 25)
        Me.filter.TabIndex = 76
        Me.filter.Text = "Filter"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1028, 689)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Total Profit"
        '
        'lblsales
        '
        Me.lblsales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsales.AutoSize = True
        Me.lblsales.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsales.ForeColor = System.Drawing.Color.Black
        Me.lblsales.Location = New System.Drawing.Point(1133, 674)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(95, 56)
        Me.lblsales.TabIndex = 75
        Me.lblsales.Text = "0.00"
        '
        'btnexport
        '
        Me.btnexport.Animated = True
        Me.btnexport.AnimationHoverSpeed = 0.07!
        Me.btnexport.AnimationSpeed = 0.03!
        Me.btnexport.BackColor = System.Drawing.Color.Transparent
        Me.btnexport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexport.BorderColor = System.Drawing.Color.Black
        Me.btnexport.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexport.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnexport.CheckedForeColor = System.Drawing.Color.White
        Me.btnexport.CheckedImage = Global.Capstone_Project.My.Resources.Resources.print_96px
        Me.btnexport.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnexport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexport.FocusedColor = System.Drawing.Color.Empty
        Me.btnexport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnexport.ForeColor = System.Drawing.Color.White
        Me.btnexport.Image = Global.Capstone_Project.My.Resources.Resources.print_96px1
        Me.btnexport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnexport.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnexport.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexport.Location = New System.Drawing.Point(1053, 47)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnexport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexport.OnHoverImage = Nothing
        Me.btnexport.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexport.OnPressedColor = System.Drawing.Color.Black
        Me.btnexport.Radius = 4
        Me.btnexport.Size = New System.Drawing.Size(56, 37)
        Me.btnexport.TabIndex = 72
        Me.btnexport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvSalesHistory
        '
        Me.dgvSalesHistory.AllowUserToAddRows = False
        Me.dgvSalesHistory.AllowUserToDeleteRows = False
        Me.dgvSalesHistory.AllowUserToOrderColumns = True
        Me.dgvSalesHistory.AllowUserToResizeColumns = False
        Me.dgvSalesHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSalesHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvSalesHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSalesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalesHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalesHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSalesHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSalesHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSalesHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvSalesHistory.ColumnHeadersHeight = 50
        Me.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSalesHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transactionno, Me.product, Me.category, Me.price, Me.quantity, Me.total, Me.Amount, Me.payment, Me.change, Me.date1})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSalesHistory.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvSalesHistory.EnableHeadersVisualStyles = False
        Me.dgvSalesHistory.GridColor = System.Drawing.Color.White
        Me.dgvSalesHistory.Location = New System.Drawing.Point(12, 102)
        Me.dgvSalesHistory.Name = "dgvSalesHistory"
        Me.dgvSalesHistory.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSalesHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvSalesHistory.RowHeadersVisible = False
        Me.dgvSalesHistory.RowHeadersWidth = 51
        Me.dgvSalesHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Poppins", 9.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSalesHistory.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvSalesHistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvSalesHistory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.dgvSalesHistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSalesHistory.RowTemplate.Height = 40
        Me.dgvSalesHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSalesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesHistory.Size = New System.Drawing.Size(1334, 563)
        Me.dgvSalesHistory.TabIndex = 71
        Me.dgvSalesHistory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvSalesHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSalesHistory.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSalesHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvSalesHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvSalesHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSalesHistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSalesHistory.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvSalesHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvSalesHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSalesHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSalesHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSalesHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSalesHistory.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvSalesHistory.ThemeStyle.ReadOnly = True
        Me.dgvSalesHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSalesHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSalesHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSalesHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvSalesHistory.ThemeStyle.RowsStyle.Height = 40
        Me.dgvSalesHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvSalesHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'transactionno
        '
        Me.transactionno.HeaderText = "Transaction No"
        Me.transactionno.MinimumWidth = 6
        Me.transactionno.Name = "transactionno"
        Me.transactionno.ReadOnly = True
        '
        'product
        '
        Me.product.HeaderText = "Product Name"
        Me.product.MinimumWidth = 6
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.MinimumWidth = 6
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.MinimumWidth = 6
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.MinimumWidth = 6
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'payment
        '
        Me.payment.HeaderText = "Payment"
        Me.payment.MinimumWidth = 6
        Me.payment.Name = "payment"
        Me.payment.ReadOnly = True
        '
        'change
        '
        Me.change.HeaderText = "Change"
        Me.change.MinimumWidth = 6
        Me.change.Name = "change"
        Me.change.ReadOnly = True
        '
        'date1
        '
        Me.date1.HeaderText = "Date"
        Me.date1.MinimumWidth = 6
        Me.date1.Name = "date1"
        Me.date1.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(580, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 23)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Filter by Time"
        '
        'cmbtime
        '
        Me.cmbtime.BackColor = System.Drawing.Color.Transparent
        Me.cmbtime.BaseColor = System.Drawing.Color.White
        Me.cmbtime.BorderColor = System.Drawing.Color.Silver
        Me.cmbtime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtime.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtime.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cmbtime.ForeColor = System.Drawing.Color.Black
        Me.cmbtime.FormattingEnabled = True
        Me.cmbtime.Items.AddRange(New Object() {"None", "All", "Daily ", "Weekly", "Monthly"})
        Me.cmbtime.Location = New System.Drawing.Point(694, 12)
        Me.cmbtime.Name = "cmbtime"
        Me.cmbtime.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbtime.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtime.Size = New System.Drawing.Size(204, 28)
        Me.cmbtime.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(273, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Product Name"
        '
        'cmbproducts
        '
        Me.cmbproducts.BackColor = System.Drawing.Color.Transparent
        Me.cmbproducts.BaseColor = System.Drawing.Color.White
        Me.cmbproducts.BorderColor = System.Drawing.Color.Silver
        Me.cmbproducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbproducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproducts.FocusedColor = System.Drawing.Color.Empty
        Me.cmbproducts.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cmbproducts.ForeColor = System.Drawing.Color.Black
        Me.cmbproducts.FormattingEnabled = True
        Me.cmbproducts.Items.AddRange(New Object() {"."})
        Me.cmbproducts.Location = New System.Drawing.Point(382, 56)
        Me.cmbproducts.Name = "cmbproducts"
        Me.cmbproducts.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbproducts.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbproducts.Size = New System.Drawing.Size(175, 28)
        Me.cmbproducts.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 23)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Category"
        '
        'cmBCategory
        '
        Me.cmBCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmBCategory.BaseColor = System.Drawing.Color.White
        Me.cmBCategory.BorderColor = System.Drawing.Color.Silver
        Me.cmBCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmBCategory.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cmBCategory.ForeColor = System.Drawing.Color.Black
        Me.cmBCategory.FormattingEnabled = True
        Me.cmBCategory.Items.AddRange(New Object() {"."})
        Me.cmBCategory.Location = New System.Drawing.Point(86, 56)
        Me.cmBCategory.Name = "cmBCategory"
        Me.cmBCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmBCategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmBCategory.Size = New System.Drawing.Size(175, 28)
        Me.cmBCategory.TabIndex = 49
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
        Me.btnConfirm.Location = New System.Drawing.Point(914, 47)
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
        Me.Label3.Location = New System.Drawing.Point(580, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Transaction No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Filter"
        '
        'cmbTransaction
        '
        Me.cmbTransaction.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransaction.FormattingEnabled = True
        Me.cmbTransaction.Items.AddRange(New Object() {"."})
        Me.cmbTransaction.Location = New System.Drawing.Point(694, 53)
        Me.cmbTransaction.Name = "cmbTransaction"
        Me.cmbTransaction.Size = New System.Drawing.Size(204, 31)
        Me.cmbTransaction.TabIndex = 45
        '
        'dtpto
        '
        Me.dtpto.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(267, 11)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(175, 27)
        Me.dtpto.TabIndex = 44
        '
        'dtpfrom
        '
        Me.dtpfrom.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(86, 11)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(175, 27)
        Me.dtpfrom.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 49)
        Me.Panel1.TabIndex = 50
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1330, 12)
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
        Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sales History"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me.dgvSalesHistory
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel1
        '
        'Sales_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 785)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sales_History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales_History"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvSalesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConfirm As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTransaction As ComboBox
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmBCategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbtime As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbproducts As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dgvSalesHistory As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents transactionno As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents payment As DataGridViewTextBoxColumn
    Friend WithEvents change As DataGridViewTextBoxColumn
    Friend WithEvents date1 As DataGridViewTextBoxColumn
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label10 As Label
    Friend WithEvents lblsales As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents filter As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnexport As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnrefresh As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblsold As Label
    Friend WithEvents Label4 As Label
End Class
