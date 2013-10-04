Imports System.Data.SqlClient
Module VARIABLES
    Public SQLConn As New SqlConnection() 'The SQL Connection
    Public SQLCmd As New SqlCommand() 'The SQL Command
    Public SQLdr As SqlDataReader 'The Local Data Store
    Public SQLSTR As String
    Public IdLice, IDESPE As String
    Public SD As Integer = 0
    'Public CadenaConexion As String = "Data Source=192.168.2.5;Initial Catalog=ISENCO;User ID=sa;password=isenco"
    'Public CadenaConexion As String = "Data Source=isenco-colima.dyndns.org;Initial Catalog=ISENCO;User ID=sa;password=isenco"
    Public Password As String
    ' Password=""
    Public Accion As String
End Module
