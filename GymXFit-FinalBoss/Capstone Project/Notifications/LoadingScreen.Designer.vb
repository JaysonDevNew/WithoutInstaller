<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadingScreen
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblpercent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pgbar = New Guna.UI.WinForms.GunaProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capstone_Project.My.Resources.Resources.gxflogo_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(216, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'lblpercent
        '
        Me.lblpercent.AutoSize = True
        Me.lblpercent.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpercent.ForeColor = System.Drawing.Color.White
        Me.lblpercent.Location = New System.Drawing.Point(224, 307)
        Me.lblpercent.Name = "lblpercent"
        Me.lblpercent.Size = New System.Drawing.Size(167, 48)
        Me.lblpercent.TabIndex = 2
        Me.lblpercent.Text = "LOADING..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'pgbar
        '
        Me.pgbar.BackColor = System.Drawing.Color.Transparent
        Me.pgbar.BorderColor = System.Drawing.Color.Black
        Me.pgbar.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition
        Me.pgbar.IdleColor = System.Drawing.Color.White
        Me.pgbar.Location = New System.Drawing.Point(26, 358)
        Me.pgbar.Name = "pgbar"
        Me.pgbar.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.pgbar.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.pgbar.Radius = 10
        Me.pgbar.Size = New System.Drawing.Size(600, 27)
        Me.pgbar.TabIndex = 3
        '
        'LoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 426)
        Me.Controls.Add(Me.pgbar)
        Me.Controls.Add(Me.lblpercent)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadingScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblpercent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents pgbar As Guna.UI.WinForms.GunaProgressBar
End Class
