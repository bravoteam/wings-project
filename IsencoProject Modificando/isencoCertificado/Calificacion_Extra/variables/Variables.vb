Imports System.Data.SqlClient
Imports isencoCertificados.Datos

Module Variables
    Public SQLConn As New SqlConnection() 'The SQL Connection
    Public SQLCmd As New SqlCommand() 'The SQL Command
    Public SQLdr As SqlDataReader 'The Local Data Store
    Public SQLdr2 As SqlDataReader 'The Local Data Store
    Public da As SqlDataAdapter
    Public dtb As DataTable
    '***************************************************OBSERVACION*****************************************************************
    ' cada vez que lleve el sistema al isenco cambiar esta variable y tambien en el archivo ignition cambiar la configuracion por el 
    ' numero de ip correspondiente 
    '********************************************************************************************************************************
    Public SQLSTR As String
    Public IdLice As String
    Public CadenaConexion As String ' = "Data Source=192.168.2.5;Initial Catalog=ISENCO;User ID=sa;password=isenco"
    'Public CadenaConexion As String = "Data Source=localhost;Initial Catalog=ISENCO;User ID=sa;password=isenco"

    Public Password As String
    ' Password=""
    Public fechaActual As Date
    Public Accion As String
    Public formulario As String
    Public direccion_ip As String = "\\192.168.1.126\documentos\"
    Public id_usuario, id_destinatario, id_usuario_global As Integer
    Public encontrado As Boolean
    '******variables de mensajes de errores
    Public err1, usuario_seleccionado As Boolean
    Public conexion As New BaseDatos

    Public dt As DataSet
    Public _busquedaObtenida As New DataTable
    Public sql As String = ""
    Public ds As DataSet
    Public cmd As New SqlCommand
    Public trans As SqlTransaction = Nothing
    Public mensaje As String = ""
    Public campus As String = ""
End Module


