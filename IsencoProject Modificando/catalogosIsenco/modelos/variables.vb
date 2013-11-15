Imports datosCompartidos.Datos
Imports System.Data.SqlClient

Public Class variables
    Public Shared conexion As New BaseDatos
    Public Shared SQLCmd As New SqlCommand() 'The SQL Command
    Public Shared dt As DataSet
    Public Shared SQLdr As SqlDataReader
    Public Shared SQLdr2 As SqlDataReader
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
    Public Shared mensajeAS As String
    Public Shared matriculaValor As String
    Public Shared nombreAlumno As String
    Public Shared campus As String
    Public Shared licenciatura As String
    Public Shared campus_L(4) As String
    Public Shared especialidad As String
    Public Shared turno As String
    Public Shared semestre As String
    Public Shared beca As String
    Public Shared ciclo As String
    Public Shared matricula As String
    Public Shared grupo As String
    Public Shared param As Integer
    Public Shared usaFecha As Integer
    Public Shared reporte As Integer
    Public Shared idalumno As Integer
    Public Shared idExamen As Integer
    Public Shared usuario As String
    Public Shared idusuario As Integer
    Public Shared tipoUsuario As Integer
    Public Shared descripcionTipoUsuario As String
    Public Shared tipoAcceso As Integer
    Public Shared nombreUsuario As String
    Public Shared idLocalizado As Integer
    Public Shared perfilUsuario As String
    Public Shared existe_registro As Boolean
    Public Shared valor1_extra As String = "0"
    Public Shared valor2_extra As String = "0"
    Public Shared valor3_extra As String = "0"
    Public Shared valor4_extra As String = "0"
    Public Shared valor5_extra As String = "0"
    Public Shared materia1_extra As String
    Public Shared materia2_extra As String
    Public Shared materia3_extra As String
    Public Shared materia4_extra As String
    Public Shared materia5_extra As String
    Public Shared num_materias As Integer
    Public Shared idespecialidad As Integer
    Public Shared idesp As Integer
    Public Shared promedio As Decimal
    Public Shared faltaDocs As String
    Public Shared campusmenu As String
    Public Shared carreramenu As String
    Public Shared personalUser As Integer
    Public Shared idMaestro As Integer
    Public Shared parcial As Integer
    Public Shared parcialdescripcion As String
    Public Shared foto As Array
End Class

