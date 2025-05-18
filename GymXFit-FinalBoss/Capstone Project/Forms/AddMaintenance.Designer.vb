<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddMaintenance
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.txtServices = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescrp = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbmType = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmount = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCreate = New Guna.UI.WinForms.GunaTileButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 50)
        Me.Panel1.TabIndex = 1
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.Animated = True
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.White
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(640, 13)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox2.TabIndex = 1
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(664, 12)
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
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Maintenance Entry"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'txtServices
        '
        Me.txtServices.BackColor = System.Drawing.Color.Transparent
        Me.txtServices.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtServices.BorderColor = System.Drawing.Color.Silver
        Me.txtServices.BorderSize = 0
        Me.txtServices.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServices.FocusedBaseColor = System.Drawing.Color.White
        Me.txtServices.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtServices.FocusedForeColor = System.Drawing.Color.Black
        Me.txtServices.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServices.ForeColor = System.Drawing.Color.Black
        Me.txtServices.Location = New System.Drawing.Point(199, 105)
        Me.txtServices.Name = "txtServices"
        Me.txtServices.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServices.Radius = 4
        Me.txtServices.SelectedText = ""
        Me.txtServices.Size = New System.Drawing.Size(400, 33)
        Me.txtServices.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(89, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Service"
        '
        'txtDescrp
        '
        Me.txtDescrp.BackColor = System.Drawing.Color.Transparent
        Me.txtDescrp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtDescrp.BorderColor = System.Drawing.Color.Silver
        Me.txtDescrp.BorderSize = 0
        Me.txtDescrp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescrp.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDescrp.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtDescrp.FocusedForeColor = System.Drawing.Color.Black
        Me.txtDescrp.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrp.ForeColor = System.Drawing.Color.Black
        Me.txtDescrp.Location = New System.Drawing.Point(199, 152)
        Me.txtDescrp.Name = "txtDescrp"
        Me.txtDescrp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrp.Radius = 4
        Me.txtDescrp.SelectedText = ""
        Me.txtDescrp.Size = New System.Drawing.Size(400, 33)
        Me.txtDescrp.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(89, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description"
        '
        'cbmType
        '
        Me.cbmType.BackColor = System.Drawing.Color.Transparent
        Me.cbmType.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cbmType.BorderColor = System.Drawing.Color.Silver
        Me.cbmType.BorderSize = 1
        Me.cbmType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmType.FocusedColor = System.Drawing.Color.Empty
        Me.cbmType.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.cbmType.ForeColor = System.Drawing.Color.Black
        Me.cbmType.FormattingEnabled = True
        Me.cbmType.Items.AddRange(New Object() {"DAILY", "MONTHLY", "YEARLY"})
        Me.cbmType.Location = New System.Drawing.Point(199, 202)
        Me.cbmType.Name = "cbmType"
        Me.cbmType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cbmType.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbmType.Radius = 4
        Me.cbmType.Size = New System.Drawing.Size(400, 30)
        Me.cbmType.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(89, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Type"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.Transparent
        Me.txtAmount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtAmount.BorderColor = System.Drawing.Color.Silver
        Me.txtAmount.BorderSize = 0
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtAmount.FocusedForeColor = System.Drawing.Color.Black
        Me.txtAmount.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(199, 246)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.Radius = 4
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(400, 33)
        Me.txtAmount.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(89, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Amount"
        '
        'btnCreate
        '
        Me.btnCreate.Animated = True
        Me.btnCreate.AnimationHoverSpeed = 0.07!
        Me.btnCreate.AnimationSpeed = 0.03!
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCreate.BorderColor = System.Drawing.Color.Transparent
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreate.FocusedColor = System.Drawing.Color.Empty
        Me.btnCreate.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Image = Nothing
        Me.btnCreate.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnCreate.Location = New System.Drawing.Point(201, 322)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnCreate.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCreate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCreate.OnHoverImage = Nothing
        Me.btnCreate.OnPressedColor = System.Drawing.Color.Black
        Me.btnCreate.Radius = 6
        Me.btnCreate.Size = New System.Drawing.Size(105, 40)
        Me.btnCreate.TabIndex = 70
        Me.btnCreate.Text = "Create"
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnUpdate.BorderColor = System.Drawing.Color.Transparent
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Nothing
        Me.btnUpdate.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnUpdate.Location = New System.Drawing.Point(319, 322)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Radius = 6
        Me.btnUpdate.Size = New System.Drawing.Size(105, 40)
        Me.btnUpdate.TabIndex = 71
        Me.btnUpdate.Text = "Update"
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.Animated = True
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GunaAdvenceButton3.BorderSize = 2
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = Nothing
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaAdvenceButton3.Image = Nothing
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(437, 322)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 4
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(105, 40)
        Me.GunaAdvenceButton3.TabIndex = 72
        Me.GunaAdvenceButton3.Text = "Clear"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 400)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbmType)
        Me.Controls.Add(Me.txtDescrp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtServices)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddMaintenance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txtDescrp As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtServices As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbmType As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents btnCreate As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
End Class
