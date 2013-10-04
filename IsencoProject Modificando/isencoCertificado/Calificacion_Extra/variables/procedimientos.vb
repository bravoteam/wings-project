Imports isencoCertificados.Datos
Module procedimientos
    Public Sub Abrir_conexion()
        Dim b As New BaseDatos
        SQLConn.ConnectionString = b.CadenaConexion
        SQLCmd.Connection = SQLConn 'Sets the Connection to use with the SQL Command
        SQLConn.Open() 'Open the connection
    End Sub
    Public Sub checar_conexion()
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        End If
    End Sub
    Public Function NEncontrados(ByVal DondeBuscar As String, ByVal Buscado As String) As Integer
        Dim Encon As Integer
        Dim Busq As Integer
        Dim DondeHay As Integer
        Encon = 0
        For Busq = 1 To Len(DondeBuscar)
            DondeHay = InStr(Busq, DondeBuscar, Buscado)
            If Not DondeHay = 0 Then
                Encon = Encon + 1
                Busq = DondeHay
            End If
        Next
        NEncontrados = Encon
    End Function
    Public Function obtenerDirector() As String
        Dim director As String = ""
        checar_conexion()
        Abrir_conexion()
        SQLSTR = "SELECT * from directivos where PUESTO='DIRECTOR'"
        SQLCmd.CommandText = SQLSTR
        SQLdr2 = SQLCmd.ExecuteReader
        While (SQLdr2.Read())
            director = SQLdr2("NOMBRE").ToString
        End While
        SQLdr2.Close()
        Return director
    End Function
    Public Function obtenerConfrontado() As String
        Dim director As String = ""
        checar_conexion()
        Abrir_conexion()
        SQLSTR = "SELECT * from directivos where PUESTO='REVISADO Y CONFRONTADO POR'"
        SQLCmd.CommandText = SQLSTR
        SQLdr2 = SQLCmd.ExecuteReader
        While (SQLdr2.Read())
            director = SQLdr2("NOMBRE").ToString
        End While
        SQLdr2.Close()
        Return director
    End Function
    Public Function obtenerValidado() As String
        Dim director As String = ""
        checar_conexion()
        Abrir_conexion()
        SQLSTR = "SELECT * from directivos where PUESTO='SUBDIRECCIÓN DE EDUCACIÓN SUPERIOR'"
        SQLCmd.CommandText = SQLSTR
        SQLdr2 = SQLCmd.ExecuteReader
        While (SQLdr2.Read())
            director = SQLdr2("NOMBRE").ToString
        End While
        SQLdr2.Close()
        Return director
    End Function
    Public Function obtenerPromedio(ByVal matriculaVar As String) As Decimal
        checar_conexion()
        Abrir_conexion()
        'SQLSTR = "SELECT ROUND(avg((CALIFICACION + calificacion2) / 2), 1, 1) AS promedio" & _
        '" FROM calificaciones WHERE  (Matricula = '" + matriculaVar + "') AND (IDMATERIA <> 1233) AND (IDMATERIA <> 1232)"

        SQLSTR = "SELECT avg((CALIFICACION + calificacion2) / 2) AS promedio" & _
        " FROM calificaciones WHERE  (Matricula = '" + matriculaVar + "') AND (IDMATERIA <> 1233) AND (IDMATERIA <> 1232)"

        SQLCmd.CommandText = SQLSTR
        Dim promedio As Decimal = SQLCmd.ExecuteScalar
        Return promedio
    End Function

End Module
