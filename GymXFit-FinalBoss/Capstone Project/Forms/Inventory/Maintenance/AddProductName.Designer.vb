<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductName
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelproduct = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdateproduct = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnAddproduct = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.txtProduct = New Guna.UI.WinForms.GunaTextBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtID = New Guna.UI.WinForms.GunaTextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(532, 29)
        Me.Panel1.TabIndex = 41
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(492, 3)
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
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product name Entry"
        '
        'btnCancelproduct
        '
        Me.btnCancelproduct.Animated = True
        Me.btnCancelproduct.AnimationHoverSpeed = 0.07!
        Me.btnCancelproduct.AnimationSpeed = 0.03!
        Me.btnCancelproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelproduct.BaseColor = System.Drawing.Color.White
        Me.btnCancelproduct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelproduct.BorderSize = 2
        Me.btnCancelproduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCancelproduct.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCancelproduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnCancelproduct.CheckedImage = Nothing
        Me.btnCancelproduct.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCancelproduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancelproduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancelproduct.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnCancelproduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelproduct.Image = Nothing
        Me.btnCancelproduct.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancelproduct.LineColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelproduct.Location = New System.Drawing.Point(418, 133)
        Me.btnCancelproduct.Name = "btnCancelproduct"
        Me.btnCancelproduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelproduct.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancelproduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancelproduct.OnHoverImage = Nothing
        Me.btnCancelproduct.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelproduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancelproduct.Radius = 4
        Me.btnCancelproduct.Size = New System.Drawing.Size(92, 33)
        Me.btnCancelproduct.TabIndex = 45
        Me.btnCancelproduct.Text = "Cancel"
        Me.btnCancelproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdateproduct
        '
        Me.btnUpdateproduct.Animated = True
        Me.btnUpdateproduct.AnimationHoverSpeed = 0.07!
        Me.btnUpdateproduct.AnimationSpeed = 0.03!
        Me.btnUpdateproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateproduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateproduct.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateproduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdateproduct.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdateproduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdateproduct.CheckedImage = Nothing
        Me.btnUpdateproduct.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdateproduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdateproduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdateproduct.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnUpdateproduct.ForeColor = System.Drawing.Color.White
        Me.btnUpdateproduct.Image = Nothing
        Me.btnUpdateproduct.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnUpdateproduct.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateproduct.Location = New System.Drawing.Point(320, 133)
        Me.btnUpdateproduct.Name = "btnUpdateproduct"
        Me.btnUpdateproduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateproduct.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdateproduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateproduct.OnHoverImage = Nothing
        Me.btnUpdateproduct.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdateproduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdateproduct.Radius = 4
        Me.btnUpdateproduct.Size = New System.Drawing.Size(92, 33)
        Me.btnUpdateproduct.TabIndex = 44
        Me.btnUpdateproduct.Text = "Update"
        '
        'btnAddproduct
        '
        Me.btnAddproduct.Animated = True
        Me.btnAddproduct.AnimationHoverSpeed = 0.07!
        Me.btnAddproduct.AnimationSpeed = 0.03!
        Me.btnAddproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnAddproduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddproduct.BorderColor = System.Drawing.Color.Black
        Me.btnAddproduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddproduct.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddproduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddproduct.CheckedImage = Nothing
        Me.btnAddproduct.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddproduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddproduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddproduct.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnAddproduct.ForeColor = System.Drawing.Color.White
        Me.btnAddproduct.Image = Nothing
        Me.btnAddproduct.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddproduct.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddproduct.Location = New System.Drawing.Point(222, 133)
        Me.btnAddproduct.Name = "btnAddproduct"
        Me.btnAddproduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddproduct.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddproduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddproduct.OnHoverImage = Nothing
        Me.btnAddproduct.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddproduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddproduct.Radius = 4
        Me.btnAddproduct.Size = New System.Drawing.Size(92, 33)
        Me.btnAddproduct.TabIndex = 43
        Me.btnAddproduct.Text = "Add"
        '
        'txtProduct
        '
        Me.txtProduct.BackColor = System.Drawing.Color.Transparent
        Me.txtProduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtProduct.BorderColor = System.Drawing.Color.Silver
        Me.txtProduct.BorderSize = 0
        Me.txtProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProduct.FocusedBaseColor = System.Drawing.Color.White
        Me.txtProduct.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtProduct.FocusedForeColor = System.Drawing.Color.Black
        Me.txtProduct.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.ForeColor = System.Drawing.Color.Black
        Me.txtProduct.Location = New System.Drawing.Point(12, 55)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProduct.Radius = 4
        Me.txtProduct.SelectedText = ""
        Me.txtProduct.Size = New System.Drawing.Size(498, 33)
        Me.txtProduct.TabIndex = 42
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
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtID.BorderColor = System.Drawing.Color.Silver
        Me.txtID.BorderSize = 0
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtID.FocusedForeColor = System.Drawing.Color.Black
        Me.txtID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(12, 94)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.Radius = 4
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(498, 33)
        Me.txtID.TabIndex = 46
        Me.txtID.Visible = False
        '
        'AddProductName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 173)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelproduct)
        Me.Controls.Add(Me.btnUpdateproduct)
        Me.Controls.Add(Me.btnAddproduct)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddProductName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProductName"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelproduct As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdateproduct As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnAddproduct As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents txtProduct As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtID As Guna.UI.WinForms.GunaTextBox
End Class
