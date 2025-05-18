<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRFID = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcancelname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcancelcontact = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcanceladdress = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcancelmembersince = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtreason = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncancelled = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 50)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.cancelicon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(669, 13)
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
        Me.GunaControlBox1.Location = New System.Drawing.Point(693, 12)
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
        Me.Label1.Location = New System.Drawing.Point(39, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Membership Cancellation"
        '
        'txtRFID
        '
        Me.txtRFID.BackColor = System.Drawing.Color.Transparent
        Me.txtRFID.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtRFID.BorderColor = System.Drawing.Color.Silver
        Me.txtRFID.BorderSize = 0
        Me.txtRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRFID.Enabled = False
        Me.txtRFID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtRFID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtRFID.FocusedForeColor = System.Drawing.Color.Black
        Me.txtRFID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Black
        Me.txtRFID.Location = New System.Drawing.Point(232, 97)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFID.Radius = 4
        Me.txtRFID.ReadOnly = True
        Me.txtRFID.SelectedText = ""
        Me.txtRFID.Size = New System.Drawing.Size(446, 33)
        Me.txtRFID.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "RFID"
        '
        'txtcancelname
        '
        Me.txtcancelname.BackColor = System.Drawing.Color.Transparent
        Me.txtcancelname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcancelname.BorderColor = System.Drawing.Color.Silver
        Me.txtcancelname.BorderSize = 0
        Me.txtcancelname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcancelname.Enabled = False
        Me.txtcancelname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcancelname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcancelname.FocusedForeColor = System.Drawing.Color.Black
        Me.txtcancelname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcancelname.ForeColor = System.Drawing.Color.Black
        Me.txtcancelname.Location = New System.Drawing.Point(232, 147)
        Me.txtcancelname.Name = "txtcancelname"
        Me.txtcancelname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcancelname.Radius = 4
        Me.txtcancelname.ReadOnly = True
        Me.txtcancelname.SelectedText = ""
        Me.txtcancelname.Size = New System.Drawing.Size(446, 33)
        Me.txtcancelname.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Name"
        '
        'txtcancelcontact
        '
        Me.txtcancelcontact.BackColor = System.Drawing.Color.Transparent
        Me.txtcancelcontact.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcancelcontact.BorderColor = System.Drawing.Color.Silver
        Me.txtcancelcontact.BorderSize = 0
        Me.txtcancelcontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcancelcontact.Enabled = False
        Me.txtcancelcontact.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcancelcontact.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcancelcontact.FocusedForeColor = System.Drawing.Color.Black
        Me.txtcancelcontact.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcancelcontact.ForeColor = System.Drawing.Color.Black
        Me.txtcancelcontact.Location = New System.Drawing.Point(232, 193)
        Me.txtcancelcontact.Name = "txtcancelcontact"
        Me.txtcancelcontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcancelcontact.Radius = 4
        Me.txtcancelcontact.ReadOnly = True
        Me.txtcancelcontact.SelectedText = ""
        Me.txtcancelcontact.Size = New System.Drawing.Size(446, 33)
        Me.txtcancelcontact.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Contact"
        '
        'txtcanceladdress
        '
        Me.txtcanceladdress.BackColor = System.Drawing.Color.Transparent
        Me.txtcanceladdress.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcanceladdress.BorderColor = System.Drawing.Color.Silver
        Me.txtcanceladdress.BorderSize = 0
        Me.txtcanceladdress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcanceladdress.Enabled = False
        Me.txtcanceladdress.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcanceladdress.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcanceladdress.FocusedForeColor = System.Drawing.Color.Black
        Me.txtcanceladdress.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcanceladdress.ForeColor = System.Drawing.Color.Black
        Me.txtcanceladdress.Location = New System.Drawing.Point(232, 244)
        Me.txtcanceladdress.Name = "txtcanceladdress"
        Me.txtcanceladdress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcanceladdress.Radius = 4
        Me.txtcanceladdress.ReadOnly = True
        Me.txtcanceladdress.SelectedText = ""
        Me.txtcanceladdress.Size = New System.Drawing.Size(446, 33)
        Me.txtcanceladdress.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(40, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Address"
        '
        'txtcancelmembersince
        '
        Me.txtcancelmembersince.BackColor = System.Drawing.Color.Transparent
        Me.txtcancelmembersince.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcancelmembersince.BorderColor = System.Drawing.Color.Silver
        Me.txtcancelmembersince.BorderSize = 0
        Me.txtcancelmembersince.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcancelmembersince.Enabled = False
        Me.txtcancelmembersince.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcancelmembersince.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtcancelmembersince.FocusedForeColor = System.Drawing.Color.Black
        Me.txtcancelmembersince.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcancelmembersince.ForeColor = System.Drawing.Color.Black
        Me.txtcancelmembersince.Location = New System.Drawing.Point(232, 290)
        Me.txtcancelmembersince.Name = "txtcancelmembersince"
        Me.txtcancelmembersince.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcancelmembersince.Radius = 4
        Me.txtcancelmembersince.ReadOnly = True
        Me.txtcancelmembersince.SelectedText = ""
        Me.txtcancelmembersince.Size = New System.Drawing.Size(446, 33)
        Me.txtcancelmembersince.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(40, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 23)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Member Since"
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
        Me.txtreason.Location = New System.Drawing.Point(232, 338)
        Me.txtreason.Multiline = True
        Me.txtreason.Name = "txtreason"
        Me.txtreason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtreason.Radius = 4
        Me.txtreason.SelectedText = ""
        Me.txtreason.Size = New System.Drawing.Size(446, 88)
        Me.txtreason.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(40, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 23)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Reason for cancellation"
        '
        'btncancelled
        '
        Me.btncancelled.Animated = True
        Me.btncancelled.AnimationHoverSpeed = 0.07!
        Me.btncancelled.AnimationSpeed = 0.03!
        Me.btncancelled.BackColor = System.Drawing.Color.Transparent
        Me.btncancelled.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancelled.BorderColor = System.Drawing.Color.Black
        Me.btncancelled.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncancelled.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncancelled.CheckedForeColor = System.Drawing.Color.White
        Me.btncancelled.CheckedImage = Nothing
        Me.btncancelled.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncancelled.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncancelled.FocusedColor = System.Drawing.Color.Empty
        Me.btncancelled.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btncancelled.ForeColor = System.Drawing.Color.White
        Me.btncancelled.Image = Nothing
        Me.btncancelled.ImageSize = New System.Drawing.Size(20, 20)
        Me.btncancelled.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancelled.Location = New System.Drawing.Point(295, 446)
        Me.btncancelled.Name = "btncancelled"
        Me.btncancelled.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btncancelled.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancelled.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancelled.OnHoverImage = Nothing
        Me.btncancelled.OnHoverLineColor = System.Drawing.Color.Green
        Me.btncancelled.OnPressedColor = System.Drawing.Color.Black
        Me.btncancelled.Radius = 4
        Me.btncancelled.Size = New System.Drawing.Size(143, 53)
        Me.btncancelled.TabIndex = 60
        Me.btncancelled.Text = "Save"
        Me.btncancelled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel1
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'CancelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(733, 524)
        Me.Controls.Add(Me.btncancelled)
        Me.Controls.Add(Me.txtreason)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcancelmembersince)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcanceladdress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcancelcontact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcancelname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CancelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CancelForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRFID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcancelname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcancelcontact As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcanceladdress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcancelmembersince As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtreason As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btncancelled As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
