<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancellation_Form
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.txtRFID = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontact = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaddress = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtexpired = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtreason = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncancelled = New Guna.UI.WinForms.GunaAdvenceButton()
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
        Me.Panel1.Size = New System.Drawing.Size(819, 50)
        Me.Panel1.TabIndex = 0
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Membership Cancellation"
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(752, 11)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox2.TabIndex = 6
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(777, 11)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(28, 24)
        Me.GunaControlBox1.TabIndex = 5
        '
        'txtRFID
        '
        Me.txtRFID.BackColor = System.Drawing.Color.Transparent
        Me.txtRFID.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtRFID.BorderColor = System.Drawing.Color.Silver
        Me.txtRFID.BorderSize = 0
        Me.txtRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRFID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtRFID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtRFID.FocusedForeColor = System.Drawing.Color.Black
        Me.txtRFID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Black
        Me.txtRFID.Location = New System.Drawing.Point(29, 118)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFID.Radius = 4
        Me.txtRFID.ReadOnly = True
        Me.txtRFID.SelectedText = ""
        Me.txtRFID.Size = New System.Drawing.Size(337, 33)
        Me.txtRFID.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "RFID"
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.Transparent
        Me.txtfname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtfname.BorderColor = System.Drawing.Color.Silver
        Me.txtfname.BorderSize = 0
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtfname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtfname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtfname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.Black
        Me.txtfname.Location = New System.Drawing.Point(29, 180)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.Radius = 4
        Me.txtfname.ReadOnly = True
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(337, 33)
        Me.txtfname.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Name"
        '
        'txtcontact
        '
        Me.txtcontact.BackColor = System.Drawing.Color.Transparent
        Me.txtcontact.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcontact.BorderColor = System.Drawing.Color.Silver
        Me.txtcontact.BorderSize = 0
        Me.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontact.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcontact.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcontact.FocusedForeColor = System.Drawing.Color.Black
        Me.txtcontact.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.ForeColor = System.Drawing.Color.Black
        Me.txtcontact.Location = New System.Drawing.Point(431, 118)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontact.Radius = 4
        Me.txtcontact.ReadOnly = True
        Me.txtcontact.SelectedText = ""
        Me.txtcontact.Size = New System.Drawing.Size(337, 33)
        Me.txtcontact.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(427, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Contact"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.Transparent
        Me.txtaddress.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtaddress.BorderColor = System.Drawing.Color.Silver
        Me.txtaddress.BorderSize = 0
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.FocusedBaseColor = System.Drawing.Color.White
        Me.txtaddress.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtaddress.FocusedForeColor = System.Drawing.Color.Black
        Me.txtaddress.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(29, 242)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.Radius = 4
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.Size = New System.Drawing.Size(337, 124)
        Me.txtaddress.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Address"
        '
        'txtexpired
        '
        Me.txtexpired.BackColor = System.Drawing.Color.Transparent
        Me.txtexpired.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtexpired.BorderColor = System.Drawing.Color.Silver
        Me.txtexpired.BorderSize = 0
        Me.txtexpired.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtexpired.FocusedBaseColor = System.Drawing.Color.White
        Me.txtexpired.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtexpired.FocusedForeColor = System.Drawing.Color.Black
        Me.txtexpired.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexpired.ForeColor = System.Drawing.Color.Black
        Me.txtexpired.Location = New System.Drawing.Point(431, 180)
        Me.txtexpired.Name = "txtexpired"
        Me.txtexpired.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtexpired.Radius = 4
        Me.txtexpired.ReadOnly = True
        Me.txtexpired.SelectedText = ""
        Me.txtexpired.Size = New System.Drawing.Size(337, 33)
        Me.txtexpired.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(427, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Expiration Date"
        '
        'txtreason
        '
        Me.txtreason.BackColor = System.Drawing.Color.Transparent
        Me.txtreason.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtreason.BorderColor = System.Drawing.Color.Silver
        Me.txtreason.BorderSize = 0
        Me.txtreason.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreason.FocusedBaseColor = System.Drawing.Color.White
        Me.txtreason.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtreason.FocusedForeColor = System.Drawing.Color.Black
        Me.txtreason.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreason.ForeColor = System.Drawing.Color.Black
        Me.txtreason.Location = New System.Drawing.Point(431, 242)
        Me.txtreason.Multiline = True
        Me.txtreason.Name = "txtreason"
        Me.txtreason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreason.Radius = 4
        Me.txtreason.SelectedText = ""
        Me.txtreason.Size = New System.Drawing.Size(337, 167)
        Me.txtreason.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(427, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Reason for cancellation"
        '
        'btncancelled
        '
        Me.btncancelled.Animated = True
        Me.btncancelled.AnimationHoverSpeed = 0.07!
        Me.btncancelled.AnimationSpeed = 0.03!
        Me.btncancelled.BackColor = System.Drawing.Color.Transparent
        Me.btncancelled.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btncancelled.BorderColor = System.Drawing.Color.Black
        Me.btncancelled.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncancelled.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncancelled.CheckedForeColor = System.Drawing.Color.White
        Me.btncancelled.CheckedImage = Nothing
        Me.btncancelled.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncancelled.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncancelled.FocusedColor = System.Drawing.Color.Empty
        Me.btncancelled.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btncancelled.ForeColor = System.Drawing.Color.White
        Me.btncancelled.Image = Nothing
        Me.btncancelled.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncancelled.LineColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btncancelled.Location = New System.Drawing.Point(651, 437)
        Me.btncancelled.Name = "btncancelled"
        Me.btncancelled.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btncancelled.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancelled.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancelled.OnHoverImage = Nothing
        Me.btncancelled.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btncancelled.OnPressedColor = System.Drawing.Color.Black
        Me.btncancelled.Radius = 4
        Me.btncancelled.Size = New System.Drawing.Size(117, 35)
        Me.btncancelled.TabIndex = 60
        Me.btncancelled.Text = "Save"
        Me.btncancelled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cancellation_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(819, 506)
        Me.Controls.Add(Me.btncancelled)
        Me.Controls.Add(Me.txtreason)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtexpired)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cancellation_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancellation_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents txtRFID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcontact As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtreason As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtexpired As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btncancelled As Guna.UI.WinForms.GunaAdvenceButton
End Class
