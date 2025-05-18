<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SessionForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControlPanel = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControlForm = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.dgvSessionHistory = New Guna.UI.WinForms.GunaDataGridView()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sessiontime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSessionName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtSessionPayment = New Guna.UI.WinForms.GunaTextBox()
        Me.btnSaveSession = New Guna.UI.WinForms.GunaTileButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSessionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1145, 62)
        Me.Panel1.TabIndex = 37
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(1041, 15)
        Me.GunaControlBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(43, 32)
        Me.GunaControlBox2.TabIndex = 2
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.CustomClick = True
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1085, 15)
        Me.GunaControlBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(43, 32)
        Me.GunaControlBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Session"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 6
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControlPanel
        '
        Me.GunaDragControlPanel.TargetControl = Me.Panel1
        '
        'GunaDragControlForm
        '
        Me.GunaDragControlForm.TargetControl = Me
        '
        'dgvSessionHistory
        '
        Me.dgvSessionHistory.AllowUserToAddRows = False
        Me.dgvSessionHistory.AllowUserToDeleteRows = False
        Me.dgvSessionHistory.AllowUserToOrderColumns = True
        Me.dgvSessionHistory.AllowUserToResizeColumns = False
        Me.dgvSessionHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSessionHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSessionHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSessionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSessionHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvSessionHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSessionHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSessionHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSessionHistory.ColumnHeadersHeight = 30
        Me.dgvSessionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSessionHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fname, Me.payment, Me.sdate, Me.sessiontime})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSessionHistory.EnableHeadersVisualStyles = False
        Me.dgvSessionHistory.GridColor = System.Drawing.Color.White
        Me.dgvSessionHistory.Location = New System.Drawing.Point(24, 198)
        Me.dgvSessionHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSessionHistory.Name = "dgvSessionHistory"
        Me.dgvSessionHistory.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSessionHistory.RowHeadersVisible = False
        Me.dgvSessionHistory.RowHeadersWidth = 20
        Me.dgvSessionHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionHistory.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSessionHistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvSessionHistory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSessionHistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionHistory.RowTemplate.Height = 30
        Me.dgvSessionHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSessionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessionHistory.Size = New System.Drawing.Size(1092, 485)
        Me.dgvSessionHistory.TabIndex = 38
        Me.dgvSessionHistory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvSessionHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSessionHistory.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvSessionHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvSessionHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvSessionHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSessionHistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSessionHistory.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvSessionHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvSessionHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSessionHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvSessionHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSessionHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSessionHistory.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvSessionHistory.ThemeStyle.ReadOnly = True
        Me.dgvSessionHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSessionHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSessionHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dgvSessionHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvSessionHistory.ThemeStyle.RowsStyle.Height = 30
        Me.dgvSessionHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvSessionHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.MinimumWidth = 6
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'payment
        '
        Me.payment.HeaderText = "Payment"
        Me.payment.MinimumWidth = 6
        Me.payment.Name = "payment"
        Me.payment.ReadOnly = True
        '
        'sdate
        '
        Me.sdate.HeaderText = "Date"
        Me.sdate.MinimumWidth = 6
        Me.sdate.Name = "sdate"
        Me.sdate.ReadOnly = True
        '
        'sessiontime
        '
        Me.sessiontime.HeaderText = "Time"
        Me.sessiontime.MinimumWidth = 6
        Me.sessiontime.Name = "sessiontime"
        Me.sessiontime.ReadOnly = True
        '
        'txtSessionName
        '
        Me.txtSessionName.BackColor = System.Drawing.Color.Transparent
        Me.txtSessionName.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSessionName.BorderColor = System.Drawing.Color.Silver
        Me.txtSessionName.BorderSize = 1
        Me.txtSessionName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSessionName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSessionName.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtSessionName.FocusedForeColor = System.Drawing.Color.Black
        Me.txtSessionName.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.txtSessionName.ForeColor = System.Drawing.Color.Black
        Me.txtSessionName.Location = New System.Drawing.Point(24, 128)
        Me.txtSessionName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSessionName.Name = "txtSessionName"
        Me.txtSessionName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSessionName.Radius = 4
        Me.txtSessionName.SelectedText = ""
        Me.txtSessionName.Size = New System.Drawing.Size(581, 47)
        Me.txtSessionName.TabIndex = 39
        '
        'txtSessionPayment
        '
        Me.txtSessionPayment.BackColor = System.Drawing.Color.Transparent
        Me.txtSessionPayment.BaseColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSessionPayment.BorderColor = System.Drawing.Color.Silver
        Me.txtSessionPayment.BorderSize = 1
        Me.txtSessionPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSessionPayment.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSessionPayment.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtSessionPayment.FocusedForeColor = System.Drawing.Color.Black
        Me.txtSessionPayment.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.txtSessionPayment.ForeColor = System.Drawing.Color.Black
        Me.txtSessionPayment.Location = New System.Drawing.Point(627, 128)
        Me.txtSessionPayment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSessionPayment.Name = "txtSessionPayment"
        Me.txtSessionPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSessionPayment.Radius = 4
        Me.txtSessionPayment.SelectedText = ""
        Me.txtSessionPayment.Size = New System.Drawing.Size(291, 47)
        Me.txtSessionPayment.TabIndex = 40
        '
        'btnSaveSession
        '
        Me.btnSaveSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveSession.Animated = True
        Me.btnSaveSession.AnimationHoverSpeed = 0.07!
        Me.btnSaveSession.AnimationSpeed = 0.03!
        Me.btnSaveSession.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveSession.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnSaveSession.BorderColor = System.Drawing.Color.Transparent
        Me.btnSaveSession.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSaveSession.FocusedColor = System.Drawing.Color.Empty
        Me.btnSaveSession.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnSaveSession.ForeColor = System.Drawing.Color.White
        Me.btnSaveSession.Image = Nothing
        Me.btnSaveSession.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnSaveSession.Location = New System.Drawing.Point(933, 127)
        Me.btnSaveSession.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveSession.Name = "btnSaveSession"
        Me.btnSaveSession.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSaveSession.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnSaveSession.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSaveSession.OnHoverImage = Nothing
        Me.btnSaveSession.OnPressedColor = System.Drawing.Color.Black
        Me.btnSaveSession.Radius = 6
        Me.btnSaveSession.Size = New System.Drawing.Size(183, 43)
        Me.btnSaveSession.TabIndex = 41
        Me.btnSaveSession.Text = "Save"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 36)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Full name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(620, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 36)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Payment"
        '
        'SessionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1145, 710)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSaveSession)
        Me.Controls.Add(Me.txtSessionPayment)
        Me.Controls.Add(Me.txtSessionName)
        Me.Controls.Add(Me.dgvSessionHistory)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SessionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SessionForm"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSessionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControlPanel As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControlForm As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents dgvSessionHistory As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtSessionPayment As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtSessionName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSaveSession As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents payment As DataGridViewTextBoxColumn
    Friend WithEvents sdate As DataGridViewTextBoxColumn
    Friend WithEvents sessiontime As DataGridViewTextBoxColumn
End Class
