Imports Kardex_Alumno.Datos
Imports System.Data.SqlClient

Public Class variables
    Public Shared conexion As New BaseDatos
    Public Shared SQLCmd As New SqlCommand() 'The SQL Command
    Public Shared dt As DataSet
    Public Shared SQLdr As SqlDataReader
    Public Shared da As SqlDataAdapter
    Public Shared sql As String
    Public Shared SQLSTR As String
    Public Shared banderaAccion As String
    Public Shared ultimaMat As Double
    Public Shared IDESPE As String
    Public Shared IdLice As String
    Public Shared materiasLI As String
    Public Shared especialidadLI As String
    Public Shared semestreLI As String
    Public Shared grupoLI As String
    Public Shared campusLI As String
    Public Shared turnoLI As String
    Public Shared modalidadLI As String
    Public Shared docenteLI As String
    Public Shared parcialLI As String
End Class

