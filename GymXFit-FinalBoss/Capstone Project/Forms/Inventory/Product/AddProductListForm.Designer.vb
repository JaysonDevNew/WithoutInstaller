<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProductListForm))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelProduct = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdateProduct = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnAddProduct = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.txtQTY = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.txtPrice = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.cmbBrandname = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbProductname = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbCategory = New Guna.UI.WinForms.GunaComboBox()
        Me.txtID = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(641, 35)
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
        Me.GunaControlBox1.Location = New System.Drawing.Point(601, 3)
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
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product Entry"
        '
        'btnCancelProduct
        '
        Me.btnCancelProduct.Animated = True
        Me.btnCancelProduct.AnimationHoverSpeed = 0.07!
        Me.btnCancelProduct.AnimationSpeed = 0.03!
        Me.btnCancelProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelProduct.BaseColor = System.Drawing.Color.White
        Me.btnCancelProduct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelProduct.BorderSize = 2
        Me.btnCancelProduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCancelProduct.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCancelProduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnCancelProduct.CheckedImage = Nothing
        Me.btnCancelProduct.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCancelProduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancelProduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancelProduct.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnCancelProduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelProduct.Image = Nothing
        Me.btnCancelProduct.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancelProduct.LineColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelProduct.Location = New System.Drawing.Point(362, 338)
        Me.btnCancelProduct.Name = "btnCancelProduct"
        Me.btnCancelProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelProduct.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancelProduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancelProduct.OnHoverImage = Nothing
        Me.btnCancelProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelProduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancelProduct.Radius = 4
        Me.btnCancelProduct.Size = New System.Drawing.Size(92, 33)
        Me.btnCancelProduct.TabIndex = 48
        Me.btnCancelProduct.Text = "Cancel"
        Me.btnCancelProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Animated = True
        Me.btnUpdateProduct.AnimationHoverSpeed = 0.07!
        Me.btnUpdateProduct.AnimationSpeed = 0.03!
        Me.btnUpdateProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateProduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateProduct.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateProduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdateProduct.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdateProduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.CheckedImage = Nothing
        Me.btnUpdateProduct.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdateProduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdateProduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdateProduct.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnUpdateProduct.ForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.Image = Nothing
        Me.btnUpdateProduct.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnUpdateProduct.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateProduct.Location = New System.Drawing.Point(264, 338)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateProduct.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdateProduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.OnHoverImage = Nothing
        Me.btnUpdateProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateProduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdateProduct.Radius = 4
        Me.btnUpdateProduct.Size = New System.Drawing.Size(92, 33)
        Me.btnUpdateProduct.TabIndex = 47
        Me.btnUpdateProduct.Text = "Update"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Animated = True
        Me.btnAddProduct.AnimationHoverSpeed = 0.07!
        Me.btnAddProduct.AnimationSpeed = 0.03!
        Me.btnAddProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnAddProduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddProduct.BorderColor = System.Drawing.Color.Black
        Me.btnAddProduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddProduct.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddProduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddProduct.CheckedImage = Nothing
        Me.btnAddProduct.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddProduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddProduct.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Image = Nothing
        Me.btnAddProduct.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddProduct.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddProduct.Location = New System.Drawing.Point(166, 338)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddProduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddProduct.OnHoverImage = Nothing
        Me.btnAddProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddProduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddProduct.Radius = 4
        Me.btnAddProduct.Size = New System.Drawing.Size(92, 33)
        Me.btnAddProduct.TabIndex = 46
        Me.btnAddProduct.Text = "Add"
        '
        'txtQTY
        '
        Me.txtQTY.AcceptsReturn = False
        Me.txtQTY.AcceptsTab = False
        Me.txtQTY.AnimationSpeed = 200
        Me.txtQTY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtQTY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtQTY.BackColor = System.Drawing.Color.Transparent
        Me.txtQTY.BackgroundImage = CType(resources.GetObject("txtQTY.BackgroundImage"), System.Drawing.Image)
        Me.txtQTY.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtQTY.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtQTY.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtQTY.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtQTY.BorderRadius = 4
        Me.txtQTY.BorderThickness = 2
        Me.txtQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtQTY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQTY.DefaultFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.DefaultText = ""
        Me.txtQTY.FillColor = System.Drawing.Color.White
        Me.txtQTY.HideSelection = True
        Me.txtQTY.IconLeft = Nothing
        Me.txtQTY.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQTY.IconPadding = 10
        Me.txtQTY.IconRight = Nothing
        Me.txtQTY.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQTY.Lines = New String(-1) {}
        Me.txtQTY.Location = New System.Drawing.Point(54, 258)
        Me.txtQTY.MaxLength = 32767
        Me.txtQTY.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtQTY.Modified = False
        Me.txtQTY.Multiline = False
        Me.txtQTY.Name = "txtQTY"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtQTY.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtQTY.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtQTY.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtQTY.OnIdleState = StateProperties4
        Me.txtQTY.Padding = New System.Windows.Forms.Padding(3)
        Me.txtQTY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQTY.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtQTY.PlaceholderText = "Enter quantity"
        Me.txtQTY.ReadOnly = False
        Me.txtQTY.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQTY.SelectedText = ""
        Me.txtQTY.SelectionLength = 0
        Me.txtQTY.SelectionStart = 0
        Me.txtQTY.ShortcutsEnabled = True
        Me.txtQTY.Size = New System.Drawing.Size(521, 44)
        Me.txtQTY.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtQTY.TabIndex = 42
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtQTY.TextMarginBottom = 0
        Me.txtQTY.TextMarginLeft = 3
        Me.txtQTY.TextMarginTop = 0
        Me.txtQTY.TextPlaceholder = "Enter quantity"
        Me.txtQTY.UseSystemPasswordChar = False
        Me.txtQTY.WordWrap = True
        '
        'txtPrice
        '
        Me.txtPrice.AcceptsReturn = False
        Me.txtPrice.AcceptsTab = False
        Me.txtPrice.AnimationSpeed = 200
        Me.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtPrice.BackgroundImage = CType(resources.GetObject("txtPrice.BackgroundImage"), System.Drawing.Image)
        Me.txtPrice.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtPrice.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtPrice.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtPrice.BorderRadius = 4
        Me.txtPrice.BorderThickness = 2
        Me.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.FillColor = System.Drawing.Color.White
        Me.txtPrice.HideSelection = True
        Me.txtPrice.IconLeft = Nothing
        Me.txtPrice.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.IconPadding = 10
        Me.txtPrice.IconRight = Nothing
        Me.txtPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.Lines = New String(-1) {}
        Me.txtPrice.Location = New System.Drawing.Point(55, 196)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtPrice.Modified = False
        Me.txtPrice.Multiline = False
        Me.txtPrice.Name = "txtPrice"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtPrice.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtPrice.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtPrice.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtPrice.OnIdleState = StateProperties8
        Me.txtPrice.Padding = New System.Windows.Forms.Padding(3)
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPrice.PlaceholderText = "Enter price"
        Me.txtPrice.ReadOnly = False
        Me.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.ShortcutsEnabled = True
        Me.txtPrice.Size = New System.Drawing.Size(521, 44)
        Me.txtPrice.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtPrice.TabIndex = 41
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPrice.TextMarginBottom = 0
        Me.txtPrice.TextMarginLeft = 3
        Me.txtPrice.TextMarginTop = 0
        Me.txtPrice.TextPlaceholder = "Enter price"
        Me.txtPrice.UseSystemPasswordChar = False
        Me.txtPrice.WordWrap = True
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
        'cmbBrandname
        '
        Me.cmbBrandname.BackColor = System.Drawing.Color.Transparent
        Me.cmbBrandname.BaseColor = System.Drawing.Color.White
        Me.cmbBrandname.BorderColor = System.Drawing.Color.Silver
        Me.cmbBrandname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBrandname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrandname.FocusedColor = System.Drawing.Color.Empty
        Me.cmbBrandname.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.cmbBrandname.ForeColor = System.Drawing.Color.Black
        Me.cmbBrandname.FormattingEnabled = True
        Me.cmbBrandname.Location = New System.Drawing.Point(55, 109)
        Me.cmbBrandname.Name = "cmbBrandname"
        Me.cmbBrandname.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBrandname.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbBrandname.Size = New System.Drawing.Size(521, 30)
        Me.cmbBrandname.TabIndex = 50
        '
        'cmbProductname
        '
        Me.cmbProductname.BackColor = System.Drawing.Color.Transparent
        Me.cmbProductname.BaseColor = System.Drawing.Color.White
        Me.cmbProductname.BorderColor = System.Drawing.Color.Silver
        Me.cmbProductname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProductname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductname.FocusedColor = System.Drawing.Color.Empty
        Me.cmbProductname.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.cmbProductname.ForeColor = System.Drawing.Color.Black
        Me.cmbProductname.FormattingEnabled = True
        Me.cmbProductname.Location = New System.Drawing.Point(55, 68)
        Me.cmbProductname.Name = "cmbProductname"
        Me.cmbProductname.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProductname.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbProductname.Size = New System.Drawing.Size(521, 30)
        Me.cmbProductname.TabIndex = 51
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BaseColor = System.Drawing.Color.White
        Me.cmbCategory.BorderColor = System.Drawing.Color.Silver
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCategory.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.Black
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(55, 153)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbCategory.Size = New System.Drawing.Size(521, 30)
        Me.cmbCategory.TabIndex = 52
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = False
        Me.txtID.AcceptsTab = False
        Me.txtID.AnimationSpeed = 200
        Me.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.BackgroundImage = CType(resources.GetObject("txtID.BackgroundImage"), System.Drawing.Image)
        Me.txtID.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtID.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtID.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtID.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtID.BorderRadius = 4
        Me.txtID.BorderThickness = 2
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DefaultFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.DefaultText = ""
        Me.txtID.FillColor = System.Drawing.Color.White
        Me.txtID.HideSelection = True
        Me.txtID.IconLeft = Nothing
        Me.txtID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.IconPadding = 10
        Me.txtID.IconRight = Nothing
        Me.txtID.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Lines = New String(-1) {}
        Me.txtID.Location = New System.Drawing.Point(54, 352)
        Me.txtID.MaxLength = 32767
        Me.txtID.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtID.Modified = False
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties9.FillColor = System.Drawing.Color.Empty
        StateProperties9.ForeColor = System.Drawing.Color.Empty
        StateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtID.OnActiveState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtID.OnDisabledState = StateProperties10
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        StateProperties11.FillColor = System.Drawing.Color.Empty
        StateProperties11.ForeColor = System.Drawing.Color.Empty
        StateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtID.OnHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.Silver
        StateProperties12.FillColor = System.Drawing.Color.White
        StateProperties12.ForeColor = System.Drawing.Color.Empty
        StateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtID.OnIdleState = StateProperties12
        Me.txtID.Padding = New System.Windows.Forms.Padding(3)
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtID.PlaceholderText = "Enter quantity"
        Me.txtID.ReadOnly = False
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.ShortcutsEnabled = True
        Me.txtID.Size = New System.Drawing.Size(521, 44)
        Me.txtID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtID.TabIndex = 53
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtID.TextMarginBottom = 0
        Me.txtID.TextMarginLeft = 3
        Me.txtID.TextMarginTop = 0
        Me.txtID.TextPlaceholder = "Enter quantity"
        Me.txtID.UseSystemPasswordChar = False
        Me.txtID.Visible = False
        Me.txtID.WordWrap = True
        '
        'AddProductListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 408)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.cmbProductname)
        Me.Controls.Add(Me.cmbBrandname)
        Me.Controls.Add(Me.btnCancelProduct)
        Me.Controls.Add(Me.btnUpdateProduct)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddProductListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProductListForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents txtQTY As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents btnCancelProduct As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdateProduct As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnAddProduct As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents cmbBrandname As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbCategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbProductname As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtID As Bunifu.UI.WinForms.BunifuTextBox
End Class
