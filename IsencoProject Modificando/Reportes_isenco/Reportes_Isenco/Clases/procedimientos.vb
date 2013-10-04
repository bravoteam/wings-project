Module procedimientos
    Public Sub Abrir_conexion()
        SQLConn.ConnectionString = CadenaConexion
        SQLCmd.Connection = SQLConn 'Sets the Connection to use with the SQL Command
        SQLConn.Open() 'Open the connection
    End Sub
    Public Sub checar_conexion()
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        End If
    End Sub
End Module
