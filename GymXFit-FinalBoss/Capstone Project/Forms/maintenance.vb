Imports System.Windows.Controls
Imports MySql.Data.MySqlClient

Public Class maintenance
    Private Sub btnnewmaintenance_Click(sender As Object, e As EventArgs) Handles btnnewmaintenance.Click
        AddMaintenance.ShowDialog()
        AddMaintenance.btnUpdate.Enabled = False
    End Sub

    Private Sub maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMaintenance()
    End Sub

    Public Sub Refreshdgv()
        LoadMaintenance()
    End Sub


    Public Sub LoadMaintenance()
        Try
            If con.State = ConnectionState.Closed Then
                openConn()
            End If

            Dim sql As String = "SELECT * FROM tblmaintenance"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            dgvmaintenance.Rows.Clear()

            While dr.Read()

                dgvmaintenance.Rows.Add(
                    dr("id"),
                    dr("services"),
                    dr("description"),
                    dr("type"),
                    dr("amount")
                )
            End While

            dgvmaintenance.ClearSelection()
            dgvmaintenance.Refresh() ' Refresh the DataGridView
            lblmaintenance.Text = dgvmaintenance.Rows.Count

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub dgvmaintenance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmaintenance.CellContentClick
        Dim colName As String = dgvmaintenance.Columns(e.ColumnIndex).Name

        AddMaintenance.MaintenanceID = dgvmaintenance.CurrentRow.Cells("id").Value

        ' Ensure the selected row is valid
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvmaintenance.Rows(e.RowIndex)

            If colName = "editm" Then
                ' Open AddCategory Form and pass the selected category
                AddMaintenance.Show()
                AddMaintenance.btnCreate.Enabled = False  ' Disable the Add button
                AddMaintenance.btnUpdate.Enabled = True ' Enable the Update button

                ' Populate the fields with the selected category data
                AddMaintenance.txtServices.Text = selectedRow.Cells("servicesoffer").Value.ToString() ' Set the ID
                AddMaintenance.txtDescrp.Text = selectedRow.Cells("descp").Value.ToString()
                AddMaintenance.cbmType.Text = selectedRow.Cells("type").Value.ToString() ' Set the category name
                AddMaintenance.txtAmount.Text = selectedRow.Cells("samount").Value.ToString()

            ElseIf colName = "deletem" Then
                Dim categoryId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                Dim servicesName As String = selectedRow.Cells("servicesoffer").Value.ToString()

                ' Confirm deletion
                Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete '" & servicesName & "'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If confirmDelete = DialogResult.Yes Then
                    Try
                        openConn()

                        Dim sql As String = "DELETE FROM tblmaintenance WHERE id = @id"
                        cmd = New MySqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@id", categoryId)

                        Dim result As Integer = cmd.ExecuteNonQuery()

                        If result > 0 Then
                            MessageBox.Show("'" & servicesName & "' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadMaintenance() ' Refresh the DataGridView
                        Else
                            MessageBox.Show("Failed to delete maintenance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        con.Close()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub txtsearchmaintenance_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            openConn()
            dgvmaintenance.Rows.Clear()

            Dim query As String = "SELECT * FROM tblmaintenance WHERE services LIKE @search OR description LIKE @search OR type LIKE @search"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgvmaintenance.Rows.Add(dr("id").ToString(),
                                                dr("services").ToString(),
                                                dr("description").ToString(),
                                                dr("type").ToString(),
                                                Format(CDec(dr("amount")), "N2"))
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class