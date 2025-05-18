Imports MySql.Data.MySqlClient

Public Class backup_restore
    Private Sub backup_restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            ' Create SaveFileDialog instance
            Dim backup As New SaveFileDialog With {
                .InitialDirectory = "C:\\",
                .Title = "Database Backup",
                .CheckFileExists = False,
                .CheckPathExists = False,
                .DefaultExt = "sql",
                .Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*",
                .RestoreDirectory = True
            }

            ' Show the Save File Dialog
            If backup.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' Open database connection
                openConn()

                ' Ensure that cmd is properly initialized and associated with the connection
                If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                    MessageBox.Show("Database connection is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Initialize the MySqlCommand with the active connection
                Dim cmd As New MySqlCommand()
                cmd.Connection = con

                ' Perform database backup
                Dim mb As New MySqlBackup(cmd)
                mb.ExportToFile(backup.FileName)

                ' Close connection after backup
                con.Close()

                MessageBox.Show("Database backup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during backup: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try
            ' Open File Dialog to Select Backup File
            Dim restore As New OpenFileDialog With {
                .InitialDirectory = "C:\\",
                .Title = "Restore Database",
                .CheckFileExists = True,
                .CheckPathExists = True,
                .DefaultExt = "sql",
                .Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*",
                .RestoreDirectory = True
            }

            If restore.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' Confirm before restoring
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to restore the database? This will overwrite existing data.", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.No Then Return

                Dim con As MySqlConnection = New MySqlConnection("server=localhost;username=root;password=;database=gymxfit_database;charset=utf8")

                ' Use MySqlCommand with the open connection
                cmd.Connection = con
                con.Open()

                ' Create MySqlBackup object and restore from file
                Dim mb As New MySqlBackup(cmd)
                mb.ImportFromFile(restore.FileName)

                ' Close the connection after restore
                con.Close()

                MessageBox.Show("Database restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during restore: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class