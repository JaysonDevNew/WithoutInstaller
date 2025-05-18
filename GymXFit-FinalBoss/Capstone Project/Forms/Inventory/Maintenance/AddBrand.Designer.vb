<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBrand
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
        Me.btnCancelbrand = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdatebrand = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnAddbrand = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.txtBrand = New Guna.UI.WinForms.GunaTextBox()
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
        Me.Panel1.TabIndex = 36
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
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Brand Entry"
        '
        'btnCancelbrand
        '
        Me.btnCancelbrand.Animated = True
        Me.btnCancelbrand.AnimationHoverSpeed = 0.07!
        Me.btnCancelbrand.AnimationSpeed = 0.03!
        Me.btnCancelbrand.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelbrand.BaseColor = System.Drawing.Color.White
        Me.btnCancelbrand.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelbrand.BorderSize = 2
        Me.btnCancelbrand.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCancelbrand.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCancelbrand.CheckedForeColor = System.Drawing.Color.White
        Me.btnCancelbrand.CheckedImage = Nothing
        Me.btnCancelbrand.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCancelbrand.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancelbrand.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancelbrand.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnCancelbrand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelbrand.Image = Nothing
        Me.btnCancelbrand.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancelbrand.LineColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelbrand.Location = New System.Drawing.Point(419, 132)
        Me.btnCancelbrand.Name = "btnCancelbrand"
        Me.btnCancelbrand.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelbrand.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancelbrand.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancelbrand.OnHoverImage = Nothing
        Me.btnCancelbrand.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelbrand.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancelbrand.Radius = 4
        Me.btnCancelbrand.Size = New System.Drawing.Size(92, 33)
        Me.btnCancelbrand.TabIndex = 40
        Me.btnCancelbrand.Text = "Cancel"
        Me.btnCancelbrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdatebrand
        '
        Me.btnUpdatebrand.Animated = True
        Me.btnUpdatebrand.AnimationHoverSpeed = 0.07!
        Me.btnUpdatebrand.AnimationSpeed = 0.03!
        Me.btnUpdatebrand.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdatebrand.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatebrand.BorderColor = System.Drawing.Color.Black
        Me.btnUpdatebrand.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdatebrand.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdatebrand.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdatebrand.CheckedImage = Nothing
        Me.btnUpdatebrand.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdatebrand.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdatebrand.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdatebrand.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnUpdatebrand.ForeColor = System.Drawing.Color.White
        Me.btnUpdatebrand.Image = Nothing
        Me.btnUpdatebrand.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnUpdatebrand.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatebrand.Location = New System.Drawing.Point(321, 132)
        Me.btnUpdatebrand.Name = "btnUpdatebrand"
        Me.btnUpdatebrand.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatebrand.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdatebrand.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdatebrand.OnHoverImage = Nothing
        Me.btnUpdatebrand.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatebrand.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdatebrand.Radius = 4
        Me.btnUpdatebrand.Size = New System.Drawing.Size(92, 33)
        Me.btnUpdatebrand.TabIndex = 39
        Me.btnUpdatebrand.Text = "Update"
        '
        'btnAddbrand
        '
        Me.btnAddbrand.Animated = True
        Me.btnAddbrand.AnimationHoverSpeed = 0.07!
        Me.btnAddbrand.AnimationSpeed = 0.03!
        Me.btnAddbrand.BackColor = System.Drawing.Color.Transparent
        Me.btnAddbrand.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddbrand.BorderColor = System.Drawing.Color.Black
        Me.btnAddbrand.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddbrand.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddbrand.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddbrand.CheckedImage = Nothing
        Me.btnAddbrand.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddbrand.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddbrand.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddbrand.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnAddbrand.ForeColor = System.Drawing.Color.White
        Me.btnAddbrand.Image = Nothing
        Me.btnAddbrand.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddbrand.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddbrand.Location = New System.Drawing.Point(223, 132)
        Me.btnAddbrand.Name = "btnAddbrand"
        Me.btnAddbrand.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddbrand.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddbrand.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddbrand.OnHoverImage = Nothing
        Me.btnAddbrand.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddbrand.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddbrand.Radius = 4
        Me.btnAddbrand.Size = New System.Drawing.Size(92, 33)
        Me.btnAddbrand.TabIndex = 38
        Me.btnAddbrand.Text = "Add"
        '
        'txtBrand
        '
        Me.txtBrand.BackColor = System.Drawing.Color.Transparent
        Me.txtBrand.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtBrand.BorderColor = System.Drawing.Color.Silver
        Me.txtBrand.BorderSize = 0
        Me.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBrand.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtBrand.FocusedForeColor = System.Drawing.Color.Black
        Me.txtBrand.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.ForeColor = System.Drawing.Color.Black
        Me.txtBrand.Location = New System.Drawing.Point(12, 53)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrand.Radius = 4
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.Size = New System.Drawing.Size(498, 33)
        Me.txtBrand.TabIndex = 37
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
        Me.txtID.Location = New System.Drawing.Point(12, 92)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.Radius = 4
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(498, 33)
        Me.txtID.TabIndex = 41
        Me.txtID.Visible = False
        '
        'AddBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 173)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelbrand)
        Me.Controls.Add(Me.btnUpdatebrand)
        Me.Controls.Add(Me.btnAddbrand)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddBrand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelbrand As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdatebrand As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnAddbrand As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents txtBrand As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtID As Guna.UI.WinForms.GunaTextBox
End Class
