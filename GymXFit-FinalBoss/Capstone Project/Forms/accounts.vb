Imports System.IO
Imports DocumentFormat.OpenXml
Imports MySql.Data.MySqlClient

Public Class accounts


    Private Sub btnnewaccount_Click(sender As Object, e As EventArgs) Handles btnnewaccount.Click
        ' Pass the reference of this form to the Account_Forms form
        Dim registerForm As New Account_Forms(Me)
        registerForm.ShowDialog()

    End Sub



    Private Sub accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data when the form loads

        LoadData()


    End Sub

    Public Sub RefreshGrid()
        LoadData()
    End Sub

    Private Sub AddActionButtons()
        If dgvaccount.Columns.Contains("Update") = False Then
            Dim updateBtn As New DataGridViewButtonColumn()
            With updateBtn
                .Name = "Update"
                .HeaderText = "Update Account"
                .Text = "Update"
                .UseColumnTextForButtonValue = True
                .FlatStyle = FlatStyle.Flat
                .Width = 120
            End With
            dgvaccount.Columns.Add(updateBtn)
        End If
    End Sub

    Private Sub dgvaccount_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvaccount.CellPainting

    End Sub



    Public Sub LoadData()
        Try
            ' Open the connection if it's not already open
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            ' Include email in the query
            Dim sql As String = "SELECT picture, name, username, password, usertype, email FROM tblaccount"
            cmd = New MySqlCommand(sql, con)

            ' Execute the query and read data
            dr = cmd.ExecuteReader()

            ' Clear any existing rows in the DataGridView
            dgvaccount.Rows.Clear()

            While dr.Read()
                Dim img As Image = Nothing
                If Not IsDBNull(dr("picture")) Then
                    Try
                        Dim imgData As Byte() = CType(dr("picture"), Byte())
                        Using ms As New IO.MemoryStream(imgData)
                            img = Image.FromStream(ms)
                        End Using
                    Catch ex As Exception
                        img = My.Resources.account
                    End Try
                Else
                    img = My.Resources.account
                End If

                ' Mask the password
                Dim maskedPassword As String = New String("●"c, dr("password").ToString().Length)

                ' Add the row to DataGridView including email
                dgvaccount.Rows.Add(
            img,
            dr("name").ToString(),
            dr("username").ToString(),
            maskedPassword,
            dr("usertype").ToString(),
            dr("email").ToString()
        )
            End While

            ' Clear any initial selection
            dgvaccount.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the DataReader and connection are properly closed
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub dgvaccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvaccount.CellContentClick

        If e.RowIndex >= 0 Then
            If dgvaccount.Columns(e.ColumnIndex).Name = "Update" Then
                Dim row As DataGridViewRow = dgvaccount.Rows(e.RowIndex)
                panelupdate.BringToFront()
                panelupdate.Visible = True
                txtUsertype.Enabled = False

                txtname.Text = row.Cells("Column1").Value.ToString()
                txtusername.Text = row.Cells("Column2").Value.ToString()
                txtUsertype.Text = row.Cells("Column4").Value.ToString()
                txtemail.Text = row.Cells("Email").Value.ToString()

                ' Check if username is Admin (case-insensitive)
                If txtusername.Text.Trim().ToLower() = "admin" Then
                    txtemail.Enabled = False
                    txtpassword.Enabled = False
                Else
                    txtemail.Enabled = True
                    txtpassword.Enabled = True
                End If

                ' Profile Image
                If Not IsDBNull(row.Cells("Column5").Value) AndAlso row.Cells("Column5").Value IsNot Nothing Then
                    Try
                        pctprofile.Image = CType(row.Cells("Column5").Value, Image)
                    Catch ex As Exception
                        pctprofile.Image = Nothing
                        MessageBox.Show("Unable to load image.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                Else
                    pctprofile.Image = Nothing
                End If

                ' 🛠️ Fetch the REAL password from database
                LoadRealPassword(txtusername.Text)
            End If
        End If

    End Sub

    Private Sub LoadRealPassword(username As String)
        Try
            If con.State = ConnectionState.Closed Then openConn()

            Dim sql As String = "SELECT password FROM tblaccount WHERE username = @username"
            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@username", username)
                Dim realPassword As Object = cmd.ExecuteScalar()

                If realPassword IsNot Nothing Then
                    txtpassword.UseSystemPasswordChar = False
                    txtpassword.Text = realPassword.ToString()
                Else
                    txtpassword.Text = ""
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading real password: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub



    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If txtusername.Text = "" Then
                MessageBox.Show("Username cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Convert image to byte array
            Dim ms As New MemoryStream()
            Dim imgBytes() As Byte = Nothing
            If pctprofile.Image IsNot Nothing Then
                Dim clonedImage As Image = New Bitmap(pctprofile.Image) ' clone to avoid GDI+ error
                clonedImage.Save(ms, Imaging.ImageFormat.Jpeg)
                imgBytes = ms.ToArray()
            End If

            ' Open connection
            openConn()

            Dim sql As String = "UPDATE tblaccount SET name = @name, password = @password, usertype = @user_type, picture= @profile WHERE username = @username"
            Dim cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@user_type", txtUsertype.Text)
            cmd.Parameters.AddWithValue("@profile", If(imgBytes IsNot Nothing, imgBytes, DBNull.Value))

            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Optionally refresh the datagrid
                LoadData()

                panelupdate.Visible = False
            Else
                MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Profile Picture"
        ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then
            pctprofile.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        panelupdate.SendToBack()
        panelupdate.Visible = False
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        Dim currentText As String = txtname.Text
        Dim newText As String = ""

        For Each c As Char In currentText
            If Char.IsLetter(c) OrElse Char.IsWhiteSpace(c) Then
                newText &= c
            End If
        Next

        If txtname.Text <> newText Then
            Dim selectionStart As Integer = txtname.SelectionStart
            txtname.Text = newText
            txtname.SelectionStart = System.Math.Min(selectionStart, txtname.Text.Length)

        End If
    End Sub


    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim searchQuery As String = "SELECT picture, name, username, password, usertype FROM tblaccount " &
                                        "WHERE name LIKE @search OR username LIKE @search OR usertype LIKE @search"
            cmd = New MySqlCommand(searchQuery, con)
            cmd.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")

            dr = cmd.ExecuteReader()
            dgvaccount.Rows.Clear()

            While dr.Read()
                Dim img As Image = Nothing
                If Not IsDBNull(dr("picture")) Then
                    Try
                        Dim imgData As Byte() = CType(dr("picture"), Byte())
                        Using ms As New IO.MemoryStream(imgData)
                            img = Image.FromStream(ms)
                        End Using
                    Catch
                        img = My.Resources.account ' Placeholder if image can't be read
                    End Try
                Else
                    img = My.Resources.account ' Placeholder image
                End If

                dgvaccount.Rows.Add(img, dr("name").ToString(), dr("username").ToString(), dr("password").ToString(), dr("usertype").ToString())
            End While

            dgvaccount.ClearSelection()

        Catch ex As Exception

        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If con.State = ConnectionState.Open Then con.Close()
        End Try

    End Sub


    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        Dim password As String = txtpassword.Text

        If password.Length < 8 Then
            lblPasswordStatus.Text = "Password too short (min 8 characters)"
            lblPasswordStatus.ForeColor = Color.Red
            Exit Sub
        End If

        Dim hasUpper As Boolean = password.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = password.Any(AddressOf Char.IsLower)
        Dim hasDigit As Boolean = password.Any(AddressOf Char.IsDigit)
        Dim hasSpecial As Boolean = password.Any(Function(c) Not Char.IsLetterOrDigit(c))

        If hasUpper AndAlso hasLower AndAlso hasDigit AndAlso hasSpecial Then
            lblPasswordStatus.Text = "Strong Password ✅"
            lblPasswordStatus.ForeColor = Color.Green
        Else
            lblPasswordStatus.Text = "Weak Password ❌ (needs Uppercase, Lowercase, Number, Special)"
            lblPasswordStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub panelupdate_Paint(sender As Object, e As PaintEventArgs) Handles panelupdate.Paint

    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class

