Imports MySql.Data.MySqlClient
Module Database

    Public Function strconnection() As MySqlConnection

        Return New MySqlConnection("server=localhost;user id=root;database=skynet")

    End Function

    Public strcon As MySqlConnection = strconnection()

End Module
