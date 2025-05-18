<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PanelMenu = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnbackup = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnsales = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btninventory = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnmaintenance = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnactivity = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnaccount = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnreport = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnpayment = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnmembership = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btndashboard = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lblloginname = New System.Windows.Forms.Label()
        Me.Profilepicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Icontitle = New System.Windows.Forms.PictureBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.Profilepicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icontitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.BorderColor = System.Drawing.Color.Transparent
        Me.PanelMenu.BorderRadius = 1
        Me.PanelMenu.BorderThickness = 1
        Me.PanelMenu.Controls.Add(Me.GunaAdvenceButton1)
        Me.PanelMenu.Controls.Add(Me.btnbackup)
        Me.PanelMenu.Controls.Add(Me.btnsales)
        Me.PanelMenu.Controls.Add(Me.btninventory)
        Me.PanelMenu.Controls.Add(Me.btnmaintenance)
        Me.PanelMenu.Controls.Add(Me.btnactivity)
        Me.PanelMenu.Controls.Add(Me.btnaccount)
        Me.PanelMenu.Controls.Add(Me.btnreport)
        Me.PanelMenu.Controls.Add(Me.btnpayment)
        Me.PanelMenu.Controls.Add(Me.btnmembership)
        Me.PanelMenu.Controls.Add(Me.btndashboard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.PanelMenu.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.PanelColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanelMenu.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanelMenu.ShadowColor = System.Drawing.Color.Transparent
        Me.PanelMenu.ShadowDept = 2
        Me.PanelMenu.ShadowDepth = 2
        Me.PanelMenu.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Dropped
        Me.PanelMenu.ShadowTopLeftVisible = False
        Me.PanelMenu.Size = New System.Drawing.Size(230, 749)
        Me.PanelMenu.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.PanelMenu.TabIndex = 1
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Global.Capstone_Project.My.Resources.Resources.logout_rounded_left_filled_100px
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Global.Capstone_Project.My.Resources.Resources.logout_rounded_left_filled_100px1
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(0, 696)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GunaAdvenceButton1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(230, 53)
        Me.GunaAdvenceButton1.TabIndex = 12
        Me.GunaAdvenceButton1.Text = "Logout"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnbackup
        '
        Me.btnbackup.Animated = True
        Me.btnbackup.AnimationHoverSpeed = 0.07!
        Me.btnbackup.AnimationSpeed = 0.03!
        Me.btnbackup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnbackup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnbackup.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbackup.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbackup.CheckedForeColor = System.Drawing.Color.White
        Me.btnbackup.CheckedImage = Global.Capstone_Project.My.Resources.Resources.data_configuration_60px
        Me.btnbackup.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbackup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnbackup.FocusedColor = System.Drawing.Color.Empty
        Me.btnbackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackup.ForeColor = System.Drawing.Color.White
        Me.btnbackup.Image = Global.Capstone_Project.My.Resources.Resources.data_configuration_60px
        Me.btnbackup.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnbackup.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnbackup.Location = New System.Drawing.Point(0, 617)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbackup.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbackup.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbackup.OnHoverImage = Nothing
        Me.btnbackup.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbackup.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnbackup.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnbackup.Size = New System.Drawing.Size(230, 53)
        Me.btnbackup.TabIndex = 11
        Me.btnbackup.Text = "Back-up & Restore"
        Me.btnbackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsales
        '
        Me.btnsales.Animated = True
        Me.btnsales.AnimationHoverSpeed = 0.07!
        Me.btnsales.AnimationSpeed = 0.03!
        Me.btnsales.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnsales.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnsales.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnsales.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnsales.CheckedForeColor = System.Drawing.Color.White
        Me.btnsales.CheckedImage = CType(resources.GetObject("btnsales.CheckedImage"), System.Drawing.Image)
        Me.btnsales.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnsales.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsales.FocusedColor = System.Drawing.Color.Empty
        Me.btnsales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsales.ForeColor = System.Drawing.Color.White
        Me.btnsales.Image = CType(resources.GetObject("btnsales.Image"), System.Drawing.Image)
        Me.btnsales.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnsales.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnsales.Location = New System.Drawing.Point(0, 564)
        Me.btnsales.Name = "btnsales"
        Me.btnsales.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnsales.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnsales.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsales.OnHoverImage = Nothing
        Me.btnsales.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnsales.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnsales.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnsales.Size = New System.Drawing.Size(230, 53)
        Me.btnsales.TabIndex = 10
        Me.btnsales.Text = "Sales"
        Me.btnsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btninventory
        '
        Me.btninventory.Animated = True
        Me.btninventory.AnimationHoverSpeed = 0.07!
        Me.btninventory.AnimationSpeed = 0.03!
        Me.btninventory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btninventory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btninventory.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btninventory.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btninventory.CheckedForeColor = System.Drawing.Color.White
        Me.btninventory.CheckedImage = CType(resources.GetObject("btninventory.CheckedImage"), System.Drawing.Image)
        Me.btninventory.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btninventory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btninventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btninventory.FocusedColor = System.Drawing.Color.Empty
        Me.btninventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventory.ForeColor = System.Drawing.Color.White
        Me.btninventory.Image = CType(resources.GetObject("btninventory.Image"), System.Drawing.Image)
        Me.btninventory.ImageSize = New System.Drawing.Size(30, 30)
        Me.btninventory.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btninventory.Location = New System.Drawing.Point(0, 511)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btninventory.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btninventory.OnHoverForeColor = System.Drawing.Color.White
        Me.btninventory.OnHoverImage = Nothing
        Me.btninventory.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btninventory.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btninventory.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btninventory.Size = New System.Drawing.Size(230, 53)
        Me.btninventory.TabIndex = 9
        Me.btninventory.Text = "Inventory"
        Me.btninventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmaintenance
        '
        Me.btnmaintenance.Animated = True
        Me.btnmaintenance.AnimationHoverSpeed = 0.07!
        Me.btnmaintenance.AnimationSpeed = 0.03!
        Me.btnmaintenance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnmaintenance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnmaintenance.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmaintenance.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmaintenance.CheckedForeColor = System.Drawing.Color.White
        Me.btnmaintenance.CheckedImage = Global.Capstone_Project.My.Resources.Resources.maintenance
        Me.btnmaintenance.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmaintenance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnmaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmaintenance.FocusedColor = System.Drawing.Color.Empty
        Me.btnmaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmaintenance.ForeColor = System.Drawing.Color.White
        Me.btnmaintenance.Image = Global.Capstone_Project.My.Resources.Resources.maintenance
        Me.btnmaintenance.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnmaintenance.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmaintenance.Location = New System.Drawing.Point(0, 458)
        Me.btnmaintenance.Name = "btnmaintenance"
        Me.btnmaintenance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmaintenance.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmaintenance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnmaintenance.OnHoverImage = Nothing
        Me.btnmaintenance.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmaintenance.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmaintenance.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnmaintenance.Size = New System.Drawing.Size(230, 53)
        Me.btnmaintenance.TabIndex = 8
        Me.btnmaintenance.Text = "Maintenance"
        Me.btnmaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnactivity
        '
        Me.btnactivity.Animated = True
        Me.btnactivity.AnimationHoverSpeed = 0.07!
        Me.btnactivity.AnimationSpeed = 0.03!
        Me.btnactivity.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnactivity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnactivity.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnactivity.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnactivity.CheckedForeColor = System.Drawing.Color.White
        Me.btnactivity.CheckedImage = CType(resources.GetObject("btnactivity.CheckedImage"), System.Drawing.Image)
        Me.btnactivity.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnactivity.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnactivity.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnactivity.FocusedColor = System.Drawing.Color.Empty
        Me.btnactivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactivity.ForeColor = System.Drawing.Color.White
        Me.btnactivity.Image = CType(resources.GetObject("btnactivity.Image"), System.Drawing.Image)
        Me.btnactivity.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnactivity.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnactivity.Location = New System.Drawing.Point(0, 405)
        Me.btnactivity.Name = "btnactivity"
        Me.btnactivity.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnactivity.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnactivity.OnHoverForeColor = System.Drawing.Color.White
        Me.btnactivity.OnHoverImage = Nothing
        Me.btnactivity.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnactivity.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnactivity.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnactivity.Size = New System.Drawing.Size(230, 53)
        Me.btnactivity.TabIndex = 7
        Me.btnactivity.Text = "Activity Logs"
        Me.btnactivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnaccount
        '
        Me.btnaccount.Animated = True
        Me.btnaccount.AnimationHoverSpeed = 0.07!
        Me.btnaccount.AnimationSpeed = 0.03!
        Me.btnaccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnaccount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnaccount.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaccount.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaccount.CheckedForeColor = System.Drawing.Color.White
        Me.btnaccount.CheckedImage = CType(resources.GetObject("btnaccount.CheckedImage"), System.Drawing.Image)
        Me.btnaccount.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnaccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnaccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccount.ForeColor = System.Drawing.Color.White
        Me.btnaccount.Image = CType(resources.GetObject("btnaccount.Image"), System.Drawing.Image)
        Me.btnaccount.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnaccount.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnaccount.Location = New System.Drawing.Point(0, 352)
        Me.btnaccount.Name = "btnaccount"
        Me.btnaccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaccount.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnaccount.OnHoverImage = Nothing
        Me.btnaccount.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaccount.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnaccount.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnaccount.Size = New System.Drawing.Size(230, 53)
        Me.btnaccount.TabIndex = 6
        Me.btnaccount.Text = "Accounts"
        Me.btnaccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnreport
        '
        Me.btnreport.Animated = True
        Me.btnreport.AnimationHoverSpeed = 0.07!
        Me.btnreport.AnimationSpeed = 0.03!
        Me.btnreport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnreport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnreport.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnreport.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnreport.CheckedForeColor = System.Drawing.Color.White
        Me.btnreport.CheckedImage = CType(resources.GetObject("btnreport.CheckedImage"), System.Drawing.Image)
        Me.btnreport.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnreport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnreport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnreport.FocusedColor = System.Drawing.Color.Empty
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.White
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnreport.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnreport.Location = New System.Drawing.Point(0, 299)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnreport.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnreport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnreport.OnHoverImage = Nothing
        Me.btnreport.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnreport.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnreport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnreport.Size = New System.Drawing.Size(230, 53)
        Me.btnreport.TabIndex = 5
        Me.btnreport.Text = "Reports"
        Me.btnreport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnpayment
        '
        Me.btnpayment.Animated = True
        Me.btnpayment.AnimationHoverSpeed = 0.07!
        Me.btnpayment.AnimationSpeed = 0.03!
        Me.btnpayment.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnpayment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnpayment.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnpayment.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnpayment.CheckedForeColor = System.Drawing.Color.White
        Me.btnpayment.CheckedImage = CType(resources.GetObject("btnpayment.CheckedImage"), System.Drawing.Image)
        Me.btnpayment.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnpayment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnpayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnpayment.FocusedColor = System.Drawing.Color.Empty
        Me.btnpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayment.ForeColor = System.Drawing.Color.White
        Me.btnpayment.Image = CType(resources.GetObject("btnpayment.Image"), System.Drawing.Image)
        Me.btnpayment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnpayment.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnpayment.Location = New System.Drawing.Point(0, 246)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnpayment.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnpayment.OnHoverForeColor = System.Drawing.Color.White
        Me.btnpayment.OnHoverImage = Nothing
        Me.btnpayment.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnpayment.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnpayment.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnpayment.Size = New System.Drawing.Size(230, 53)
        Me.btnpayment.TabIndex = 4
        Me.btnpayment.Text = "Payments"
        Me.btnpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnpayment.TextOffsetX = -1
        '
        'btnmembership
        '
        Me.btnmembership.Animated = True
        Me.btnmembership.AnimationHoverSpeed = 0.07!
        Me.btnmembership.AnimationSpeed = 0.03!
        Me.btnmembership.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnmembership.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnmembership.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.CheckedForeColor = System.Drawing.Color.White
        Me.btnmembership.CheckedImage = CType(resources.GetObject("btnmembership.CheckedImage"), System.Drawing.Image)
        Me.btnmembership.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnmembership.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmembership.FocusedColor = System.Drawing.Color.Empty
        Me.btnmembership.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmembership.ForeColor = System.Drawing.Color.White
        Me.btnmembership.Image = CType(resources.GetObject("btnmembership.Image"), System.Drawing.Image)
        Me.btnmembership.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnmembership.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnmembership.Location = New System.Drawing.Point(0, 193)
        Me.btnmembership.Name = "btnmembership"
        Me.btnmembership.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.OnHoverForeColor = System.Drawing.Color.White
        Me.btnmembership.OnHoverImage = Nothing
        Me.btnmembership.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnmembership.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnmembership.Size = New System.Drawing.Size(230, 53)
        Me.btnmembership.TabIndex = 3
        Me.btnmembership.Text = "Membership"
        Me.btnmembership.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btndashboard
        '
        Me.btndashboard.Animated = True
        Me.btndashboard.AnimationHoverSpeed = 0.07!
        Me.btndashboard.AnimationSpeed = 0.03!
        Me.btndashboard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btndashboard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btndashboard.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btndashboard.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btndashboard.CheckedForeColor = System.Drawing.Color.White
        Me.btndashboard.CheckedImage = Global.Capstone_Project.My.Resources.Resources.dashboard_60px
        Me.btndashboard.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btndashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btndashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndashboard.FocusedColor = System.Drawing.Color.Empty
        Me.btndashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.White
        Me.btndashboard.Image = Global.Capstone_Project.My.Resources.Resources.dashboard_60px
        Me.btndashboard.ImageSize = New System.Drawing.Size(30, 30)
        Me.btndashboard.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btndashboard.Location = New System.Drawing.Point(0, 140)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btndashboard.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btndashboard.OnHoverForeColor = System.Drawing.Color.White
        Me.btndashboard.OnHoverImage = Nothing
        Me.btndashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btndashboard.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btndashboard.Size = New System.Drawing.Size(230, 53)
        Me.btndashboard.TabIndex = 2
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(230, 140)
        Me.PanelLogo.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.lblloginname)
        Me.GunaPanel1.Controls.Add(Me.Profilepicture)
        Me.GunaPanel1.Controls.Add(Me.Icontitle)
        Me.GunaPanel1.Controls.Add(Me.lbltitle)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(230, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1021, 64)
        Me.GunaPanel1.TabIndex = 2
        '
        'lblloginname
        '
        Me.lblloginname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblloginname.AutoSize = True
        Me.lblloginname.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.lblloginname.ForeColor = System.Drawing.Color.White
        Me.lblloginname.Location = New System.Drawing.Point(856, 20)
        Me.lblloginname.Name = "lblloginname"
        Me.lblloginname.Size = New System.Drawing.Size(89, 26)
        Me.lblloginname.TabIndex = 4
        Me.lblloginname.Text = "Username"
        '
        'Profilepicture
        '
        Me.Profilepicture.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Profilepicture.BaseColor = System.Drawing.Color.Transparent
        Me.Profilepicture.Image = Global.Capstone_Project.My.Resources.Resources.gymnast_1163072
        Me.Profilepicture.Location = New System.Drawing.Point(817, 12)
        Me.Profilepicture.Name = "Profilepicture"
        Me.Profilepicture.Size = New System.Drawing.Size(38, 38)
        Me.Profilepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Profilepicture.TabIndex = 3
        Me.Profilepicture.TabStop = False
        Me.Profilepicture.UseTransfarantBackground = False
        '
        'Icontitle
        '
        Me.Icontitle.Image = CType(resources.GetObject("Icontitle.Image"), System.Drawing.Image)
        Me.Icontitle.Location = New System.Drawing.Point(6, 13)
        Me.Icontitle.Name = "Icontitle"
        Me.Icontitle.Size = New System.Drawing.Size(38, 37)
        Me.Icontitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icontitle.TabIndex = 2
        Me.Icontitle.TabStop = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(43, 15)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(153, 42)
        Me.lbltitle.TabIndex = 1
        Me.lbltitle.Text = "Dashboard"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(230, 64)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1021, 685)
        Me.PanelDesktop.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1251, 749)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.Profilepicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icontitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnbackup As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnsales As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btninventory As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnmaintenance As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnactivity As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnaccount As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnreport As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnpayment As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnmembership As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btndashboard As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents Icontitle As PictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Profilepicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblloginname As Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
