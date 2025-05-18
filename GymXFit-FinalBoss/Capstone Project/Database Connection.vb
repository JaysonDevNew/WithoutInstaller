Imports MySql.Data.MySqlClient
Module Database_Connection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Sub openConn()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "server=localhost;username=root;password=;database=gymxfit_database"
            con.Open()
        End If
    End Sub

End Module
