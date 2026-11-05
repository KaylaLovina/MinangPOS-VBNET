Imports MySql.Data.MySqlClient

Module modKoneksi
    Public Const CONNECTION_STRING As String = "Server=localhost;Port=3306;Database=db_minangpos;Uid=root;Pwd=;CharSet=utf8mb4;SslMode=none;"

    Public Function BukaKoneksi() As MySqlConnection
        Dim koneksi As New MySqlConnection(CONNECTION_STRING)
        koneksi.Open()
        Return koneksi
    End Function
End Module