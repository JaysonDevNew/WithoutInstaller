Imports MySql.Data.MySqlClient
Imports TheArtOfDev.HtmlRenderer.Adapters

Public Class AddMaintenance
    Private Sub txtServices_TextChanged(sender As Object, e As EventArgs) Handles txtServices.TextChanged

    End Sub

    Private Sub txtServices_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServices.KeyPress
        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub txtDescrp_TextChanged(sender As Object, e As EventArgs) Handles txtDescrp.TextChanged

    End Sub

    Private Sub txtDescrp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescrp.KeyPress
        If Char.IsLower(e.KeyChar) Then
            ' Convert lowercase to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If txtAmount.Text <> "" Then
            ' Ensure only numeric format
            If Not IsNumeric(txtAmount.Text) Then
                txtAmount.Text = "0.00"
                txtAmount.SelectionStart = txtAmount.Text.Length
            Else
                Dim parts() As String = txtAmount.Text.Split("."c)

                ' Check if integer part exceeds 6 digits
                If parts(0).Length > 6 Then
                    MessageBox.Show("Amount must not exceed 6 digits before the decimal.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    ' Trim the integer part to 6 digits
                    Dim trimmedIntegerPart As String = parts(0).Substring(0, 6)

                    ' Rebuild the text with trimmed integer and original decimal part (if exists)
                    If parts.Length > 1 Then
                        txtAmount.Text = trimmedIntegerPart & "." & parts(1)
                    Else
                        txtAmount.Text = trimmedIntegerPart
                    End If

                    txtAmount.SelectionStart = txtAmount.Text.Length
                End If
            End If
        End If
    End Sub



    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        ' Allow only digits, one dot, and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            Exit Sub
        End If

        ' Ensure only one decimal point
        If e.KeyChar = "."c AndAlso txtAmount.Text.Contains(".") Then
            e.Handled = True
            Exit Sub
        End If

        ' Predict the future text after the keypress
        Dim futureText As String
        If txtAmount.SelectionLength > 0 Then
            ' If user selected text, it will be replaced
            futureText = txtAmount.Text.Remove(txtAmount.SelectionStart, txtAmount.SelectionLength)
            futureText = futureText.Insert(txtAmount.SelectionStart, e.KeyChar)
        Else
            futureText = txtAmount.Text.Insert(txtAmount.SelectionStart, e.KeyChar)
        End If

        ' Validate the future value
        Dim futureValue As Decimal = 0
        If Decimal.TryParse(futureText, futureValue) Then
            If futureValue > 100000 Then
                e.Handled = True ' Block typing if it exceeds 1000
            End If
        End If
    End Sub


    Private Sub txtAmount_Leave(sender As Object, e As EventArgs) Handles txtAmount.Leave
        If txtAmount.Text <> "" Then
            Dim amount As Decimal
            If Decimal.TryParse(txtAmount.Text, amount) Then
                txtAmount.Text = amount.ToString("N2") ' Format with "N2" (thousands separator + 2 decimal places)
            Else
                txtAmount.Text = "0.00" ' Default value if invalid input
            End If
        Else
            txtAmount.Text = "0.00" ' Set to default when empty
        End If
    End Sub



    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            If String.IsNullOrWhiteSpace(txtServices.Text) OrElse
           String.IsNullOrWhiteSpace(txtDescrp.Text) OrElse
           String.IsNullOrWhiteSpace(cbmType.Text) OrElse
           String.IsNullOrWhiteSpace(txtAmount.Text) Then
                MessageBox.Show("Please complete all fields.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Exit if validation fails
            End If

            openConn()

            Dim sql As String = "INSERT INTO tblmaintenance (services, description, type, amount) VALUES (@services, @sdescription, @type, @amount)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@services", txtServices.Text)
            cmd.Parameters.AddWithValue("@sdescription", txtDescrp.Text)
            cmd.Parameters.AddWithValue("@type", cbmType.Text)
            cmd.Parameters.AddWithValue("@amount", txtAmount.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Record has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearfields()

                Dim parentForm As maintenance = Application.OpenForms.OfType(Of maintenance)().FirstOrDefault()
                If parentForm IsNot Nothing Then
                    parentForm.Refreshdgv()
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub clearfields()
        txtServices.Clear()
        txtDescrp.Clear()
        cbmType.SelectedIndex = -1
        txtAmount.Clear()
    End Sub

    Public MaintenanceID As Integer ' Holds the ID of the maintenance to update

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        Try
            ' Validate inputs
            If String.IsNullOrWhiteSpace(txtServices.Text) OrElse
               String.IsNullOrWhiteSpace(txtDescrp.Text) OrElse
               String.IsNullOrWhiteSpace(cbmType.Text) OrElse
               String.IsNullOrWhiteSpace(txtAmount.Text) Then
                MessageBox.Show("Please complete all fields.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MaintenanceID = 0 Then
                MessageBox.Show("No record selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            openConn()

            ' Build the UPDATE query
            Dim sql As String = "UPDATE tblmaintenance SET services = @services, description = @description, type = @type, amount = @amount WHERE id = @id"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@services", txtServices.Text)
            cmd.Parameters.AddWithValue("@description", txtDescrp.Text)
            cmd.Parameters.AddWithValue("@type", cbmType.Text)
            cmd.Parameters.AddWithValue("@amount", txtAmount.Text)
            cmd.Parameters.AddWithValue("@id", MaintenanceID)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Record has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearfields()
                Me.Close()

                Dim parentForm As maintenance = Application.OpenForms.OfType(Of maintenance)().FirstOrDefault()
                If parentForm IsNot Nothing Then
                    parentForm.Refreshdgv()
                End If

                MaintenanceID = 0 ' Reset after update
            Else
                MessageBox.Show("No changes were made.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        clearfields()
    End Sub
End Class