<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup_restore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup_restore))
        Me.BunifuShapes1 = New Bunifu.UI.WinForms.BunifuShapes()
        Me.BunifuLabel19 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuShapes2 = New Bunifu.UI.WinForms.BunifuShapes()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnBackup = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnRestore = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.SuspendLayout()
        '
        'BunifuShapes1
        '
        Me.BunifuShapes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuShapes1.Angle = 0!
        Me.BunifuShapes1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.BorderColor = System.Drawing.Color.White
        Me.BunifuShapes1.BorderThickness = 4
        Me.BunifuShapes1.FillColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.FillShape = True
        Me.BunifuShapes1.Location = New System.Drawing.Point(249, 57)
        Me.BunifuShapes1.Name = "BunifuShapes1"
        Me.BunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line
        Me.BunifuShapes1.Sides = 5
        Me.BunifuShapes1.Size = New System.Drawing.Size(512, 31)
        Me.BunifuShapes1.TabIndex = 8
        Me.BunifuShapes1.Text = "BunifuShapes1"
        '
        'BunifuLabel19
        '
        Me.BunifuLabel19.AllowParentOverrides = False
        Me.BunifuLabel19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuLabel19.AutoEllipsis = False
        Me.BunifuLabel19.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel19.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel19.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel19.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel19.Location = New System.Drawing.Point(461, 32)
        Me.BunifuLabel19.Name = "BunifuLabel19"
        Me.BunifuLabel19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel19.Size = New System.Drawing.Size(83, 36)
        Me.BunifuLabel19.TabIndex = 7
        Me.BunifuLabel19.Text = "Back Up"
        Me.BunifuLabel19.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel19.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuShapes2
        '
        Me.BunifuShapes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuShapes2.Angle = 0!
        Me.BunifuShapes2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShapes2.BorderColor = System.Drawing.Color.White
        Me.BunifuShapes2.BorderThickness = 4
        Me.BunifuShapes2.FillColor = System.Drawing.Color.Transparent
        Me.BunifuShapes2.FillShape = True
        Me.BunifuShapes2.Location = New System.Drawing.Point(249, 346)
        Me.BunifuShapes2.Name = "BunifuShapes2"
        Me.BunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line
        Me.BunifuShapes2.Sides = 5
        Me.BunifuShapes2.Size = New System.Drawing.Size(512, 31)
        Me.BunifuShapes2.TabIndex = 11
        Me.BunifuShapes2.Text = "BunifuShapes2"
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(461, 321)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(76, 36)
        Me.BunifuLabel1.TabIndex = 10
        Me.BunifuLabel1.Text = "Restore"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnBackup
        '
        Me.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBackup.Animated = True
        Me.btnBackup.AnimationHoverSpeed = 0.05!
        Me.btnBackup.AnimationSpeed = 0.03!
        Me.btnBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBackup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBackup.BorderColor = System.Drawing.Color.Transparent
        Me.btnBackup.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnBackup.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnBackup.CheckedForeColor = System.Drawing.Color.White
        Me.btnBackup.CheckedImage = CType(resources.GetObject("btnBackup.CheckedImage"), System.Drawing.Image)
        Me.btnBackup.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBackup.FocusedColor = System.Drawing.Color.Empty
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Image = Global.Capstone_Project.My.Resources.Resources.backup
        Me.btnBackup.ImageSize = New System.Drawing.Size(96, 96)
        Me.btnBackup.LineColor = System.Drawing.Color.Transparent
        Me.btnBackup.Location = New System.Drawing.Point(249, 109)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBackup.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnBackup.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBackup.OnHoverImage = Nothing
        Me.btnBackup.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnBackup.OnPressedColor = System.Drawing.Color.Black
        Me.btnBackup.Radius = 8
        Me.btnBackup.Size = New System.Drawing.Size(512, 191)
        Me.btnBackup.TabIndex = 12
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRestore.Animated = True
        Me.btnRestore.AnimationHoverSpeed = 0.05!
        Me.btnRestore.AnimationSpeed = 0.03!
        Me.btnRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnRestore.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRestore.BorderColor = System.Drawing.Color.Transparent
        Me.btnRestore.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnRestore.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnRestore.CheckedForeColor = System.Drawing.Color.White
        Me.btnRestore.CheckedImage = Global.Capstone_Project.My.Resources.Resources.restore
        Me.btnRestore.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnRestore.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRestore.FocusedColor = System.Drawing.Color.Empty
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Image = Global.Capstone_Project.My.Resources.Resources.restore
        Me.btnRestore.ImageSize = New System.Drawing.Size(96, 96)
        Me.btnRestore.LineColor = System.Drawing.Color.Transparent
        Me.btnRestore.Location = New System.Drawing.Point(249, 400)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnRestore.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnRestore.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRestore.OnHoverImage = Nothing
        Me.btnRestore.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnRestore.OnPressedColor = System.Drawing.Color.Black
        Me.btnRestore.Radius = 8
        Me.btnRestore.Size = New System.Drawing.Size(512, 191)
        Me.btnRestore.TabIndex = 13
        '
        'backup_restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 661)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.BunifuShapes2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuShapes1)
        Me.Controls.Add(Me.BunifuLabel19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "backup_restore"
        Me.Text = "backup_restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuShapes1 As Bunifu.UI.WinForms.BunifuShapes
    Friend WithEvents BunifuLabel19 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuShapes2 As Bunifu.UI.WinForms.BunifuShapes
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnBackup As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnRestore As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
