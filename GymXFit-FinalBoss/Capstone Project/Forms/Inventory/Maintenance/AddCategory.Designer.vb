<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCategory
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
        Me.txtCategory = New Guna.UI.WinForms.GunaTextBox()
        Me.btnAddcategory = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnUpdatecategory = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnCancelcategory = New Guna.UI.WinForms.GunaAdvenceButton()
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
        Me.Panel1.Size = New System.Drawing.Size(529, 29)
        Me.Panel1.TabIndex = 2
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(489, 3)
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
        Me.Label1.Size = New System.Drawing.Size(141, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Category Entry"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.Transparent
        Me.txtCategory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtCategory.BorderColor = System.Drawing.Color.Silver
        Me.txtCategory.BorderSize = 0
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtCategory.FocusedForeColor = System.Drawing.Color.Black
        Me.txtCategory.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.Location = New System.Drawing.Point(12, 58)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategory.Radius = 4
        Me.txtCategory.SelectedText = ""
        Me.txtCategory.Size = New System.Drawing.Size(498, 33)
        Me.txtCategory.TabIndex = 6
        '
        'btnAddcategory
        '
        Me.btnAddcategory.Animated = True
        Me.btnAddcategory.AnimationHoverSpeed = 0.07!
        Me.btnAddcategory.AnimationSpeed = 0.03!
        Me.btnAddcategory.BackColor = System.Drawing.Color.Transparent
        Me.btnAddcategory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddcategory.BorderColor = System.Drawing.Color.Black
        Me.btnAddcategory.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddcategory.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddcategory.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddcategory.CheckedImage = Nothing
        Me.btnAddcategory.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddcategory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddcategory.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddcategory.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnAddcategory.ForeColor = System.Drawing.Color.White
        Me.btnAddcategory.Image = Nothing
        Me.btnAddcategory.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddcategory.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddcategory.Location = New System.Drawing.Point(221, 134)
        Me.btnAddcategory.Name = "btnAddcategory"
        Me.btnAddcategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddcategory.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddcategory.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddcategory.OnHoverImage = Nothing
        Me.btnAddcategory.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddcategory.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddcategory.Radius = 4
        Me.btnAddcategory.Size = New System.Drawing.Size(92, 33)
        Me.btnAddcategory.TabIndex = 32
        Me.btnAddcategory.Text = "Add"
        '
        'btnUpdatecategory
        '
        Me.btnUpdatecategory.Animated = True
        Me.btnUpdatecategory.AnimationHoverSpeed = 0.07!
        Me.btnUpdatecategory.AnimationSpeed = 0.03!
        Me.btnUpdatecategory.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdatecategory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatecategory.BorderColor = System.Drawing.Color.Black
        Me.btnUpdatecategory.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdatecategory.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdatecategory.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdatecategory.CheckedImage = Nothing
        Me.btnUpdatecategory.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdatecategory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdatecategory.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdatecategory.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnUpdatecategory.ForeColor = System.Drawing.Color.White
        Me.btnUpdatecategory.Image = Nothing
        Me.btnUpdatecategory.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnUpdatecategory.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatecategory.Location = New System.Drawing.Point(319, 134)
        Me.btnUpdatecategory.Name = "btnUpdatecategory"
        Me.btnUpdatecategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatecategory.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdatecategory.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdatecategory.OnHoverImage = Nothing
        Me.btnUpdatecategory.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdatecategory.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdatecategory.Radius = 4
        Me.btnUpdatecategory.Size = New System.Drawing.Size(92, 33)
        Me.btnUpdatecategory.TabIndex = 33
        Me.btnUpdatecategory.Text = "Update"
        '
        'btnCancelcategory
        '
        Me.btnCancelcategory.Animated = True
        Me.btnCancelcategory.AnimationHoverSpeed = 0.07!
        Me.btnCancelcategory.AnimationSpeed = 0.03!
        Me.btnCancelcategory.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelcategory.BaseColor = System.Drawing.Color.White
        Me.btnCancelcategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelcategory.BorderSize = 2
        Me.btnCancelcategory.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCancelcategory.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCancelcategory.CheckedForeColor = System.Drawing.Color.White
        Me.btnCancelcategory.CheckedImage = Nothing
        Me.btnCancelcategory.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCancelcategory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancelcategory.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancelcategory.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnCancelcategory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelcategory.Image = Nothing
        Me.btnCancelcategory.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancelcategory.LineColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelcategory.Location = New System.Drawing.Point(417, 134)
        Me.btnCancelcategory.Name = "btnCancelcategory"
        Me.btnCancelcategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelcategory.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancelcategory.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancelcategory.OnHoverImage = Nothing
        Me.btnCancelcategory.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelcategory.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancelcategory.Radius = 4
        Me.btnCancelcategory.Size = New System.Drawing.Size(92, 33)
        Me.btnCancelcategory.TabIndex = 35
        Me.btnCancelcategory.Text = "Cancel"
        Me.btnCancelcategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtID.Location = New System.Drawing.Point(12, 97)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.Radius = 4
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(498, 33)
        Me.txtID.TabIndex = 36
        Me.txtID.Visible = False
        '
        'AddCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 172)
        Me.Controls.Add(Me.btnCancelcategory)
        Me.Controls.Add(Me.btnUpdatecategory)
        Me.Controls.Add(Me.btnAddcategory)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCategory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategory As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnAddcategory As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnUpdatecategory As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnCancelcategory As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtID As Guna.UI.WinForms.GunaTextBox
End Class
