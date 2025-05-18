Public Class Member_View_Form

    Private Sub Member_View_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnupdatemember_Click(sender As Object, e As EventArgs) Handles btnupdatemember.Click
        Try
            Dim parentForm As membership = CType(Me.Owner, membership) ' Get the parent form
            Dim editForm As New Member_Edit_Form(parentForm) ' Pass the correct parent


            ' Pass values from Member_View_Form to Member_Edit_Form
            With editForm
                .txtRFID.Text = txtRFID.Text
                .txtfname.Text = txtfirstname.Text
                .txtmname.Text = txtmiddlename.Text
                .txtlname.Text = txtlastname.Text
                .txtaddress.Text = txtaddress.Text
                .txtage.Text = txtage.Text
                .txtcontact.Text = txtcontact.Text
                .txtemergencycontact.Text = txtemergency.Text

                ' Set gender selection
                If txtgender.Text = "MALE" Then
                    .rdbmale.Checked = True
                ElseIf txtgender.Text = "FEMALE" Then
                    .rdbfemale.Checked = True
                End If

                ' Set DateTimePicker value safely
                If Not String.IsNullOrEmpty(dtmembersince.Text) Then
                    .dtmembersince.Value = Convert.ToDateTime(dtmembersince.Text)
                Else
                    .dtmembersince.Value = DateTime.Now
                End If

                ' Load profile picture
                If memberpic.Image IsNot Nothing Then
                    .memberpic.Image = memberpic.Image
                Else
                    .memberpic.Image = My.Resources.gymnast_1163072 ' Default image
                End If
            End With

            ' Show the Member Edit Form
            Me.Close()
            editForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles btncancelmember.Click
        Try
            ' Create a new instance of the CancelForm
            Dim cancelForm As New CancelForm()

            ' Ensure Member_View_Form controls exist and are accessible
            cancelForm.txtRFID.Text = txtRFID.Text
            cancelForm.txtcancelcontact.Text = txtcontact.Text
            cancelForm.txtcanceladdress.Text = txtaddress.Text
            cancelForm.txtcancelmembersince.Text = dtmembersince.Value.ToString("yyyy-MM-dd")

            ' Ensure txtfirstname, txtmiddlename, and txtlastname exist
            Dim middleName As String = If(String.IsNullOrWhiteSpace(txtmiddlename.Text), "", txtmiddlename.Text & " ")
            Dim fullName As String = $"{txtfirstname.Text} {middleName}{txtlastname.Text}".Trim()

            ' Ensure CancelForm has a textbox named "txtcancelname" for full name
            cancelForm.txtcancelname.Text = fullName

            ' Show the CancelForm
            Me.Close()
            cancelForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class