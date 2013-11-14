Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Imports datosCompartidos

Public Class funciones
    Public Shared Sub limpiar_campos(ByVal grupo As GroupBox)
        Dim ctl As Control

        For Each ctl In grupo.Controls
            If (TypeOf ctl Is System.Windows.Forms.TextBox) Or (TypeOf ctl Is System.Windows.Forms.ComboBox) Then
                ctl.Text = ""
            End If
        Next ctl
    End Sub
    Public Shared Sub loadComboBox(ByRef ds As DataSet, _
                            ByRef combo As ComboBox, _
                            ByRef campoValor As String, _
                            ByRef campoDisplay As String)
        combo.DataSource = ds.Tables(0)
        combo.ValueMember = campoValor
        combo.DisplayMember = campoDisplay
    End Sub

    Public Shared Function getAulas(bandera As Integer) As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        If bandera = 1 Then
            sql = "select id, upper(ubicacion) as ubicacion " & _
            "from aulas where aplicaPara = " & bandera & "; "
        Else
            sql = "select id, (ubicacion + ' ' + descripcion) as ubicacion " & _
                "from aulas where aplicaPara = " & bandera & "; "
        End If

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds
    End Function

    Public Shared Function getLicenciaturas() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select idLicenciatura, upper(nombre) as licenciatura " & _
            "from licenciaturas; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function GetstatusCalificaciones() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select id, upper(descripcion) as descripcion " & _
            "from status_calificaciones; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getMateriasExtra(matricula As String) As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "SELECT M.NOMBRE AS MATERIA,M.IDMATERIA FROM ALUMNO AS A " & _
                     " INNER JOIN CALIFICACIONES AS C ON C.MATRICULA = A.MATRICULA" & _
                     " INNER JOIN MATERIAS AS M ON M.IDMATERIA = C.IDMATERIA" & _
                     " WHERE A.MATRICULA = '" & matricula & "' and (C.calificacion<6 or C.calificacion2<6) ORDER BY M.NOMBRE"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getEspecialidades() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select idEspecialidad, upper(descripcion) as especialidad " & _
            "from especialidades; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getTiposBecas() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct(BECA)as descripcion,0 as id from alumno " & _
        "where LEN(BECA)>2 and BECA not like '%guna%' " & _
        "and BECA not like '%nin%' " & _
        "order by BECA"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getCampus() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select IDCAMPUS, upper(MUNICIPIO) as campus " & _
            "from campus; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getAcuerdosJurado() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select id, descripcion " & _
            "from acuerdos_jurado_acta; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getGrados() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select IDSEMESTRE, upper(NUMERO) as grado " & _
            "from semestres order by idsemestre; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getGrupos() As DataSet

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct(nombre) " & _
            "from grupos order by nombre; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds

    End Function
    Public Shared Function getparciales() As DataSet
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String
        sql = "select idparcial,descripcion from parciales"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        Return ds
    End Function
    Public Shared Function getMaestros() As DataSet
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String
        sql = "select  nombre + ' ' + apellido_paterno + ' ' + apellido_materno  as nombreS,idmaestro " & _
            "from maestro order by nombre,apellido_paterno,apellido_materno"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        Return ds

    End Function
    Public Shared Function obtenerCicloActual() As String
        Dim ciclo As String = ""
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr2 As SqlDataReader
        b.abrirConexion()
        sql = "SELECT * from ciclo_escolar where ACTUAL=1"
        Dim cmd As New SqlCommand(sql, b.Conexion)
        SQLdr2 = cmd.ExecuteReader
        While (SQLdr2.Read())
            ciclo = SQLdr2("DESCRIPCION").ToString
        End While
        b.cerrarConexion()
        Return ciclo
    End Function
    Public Shared Function obtenerEdad(ByVal FechaNacimiento As DateTime) As Double
        Dim dblEdad As Double = DateTime.Now.Subtract(FechaNacimiento).TotalDays / 365.25
        Return dblEdad
    End Function
    Public Shared Function obtenerPersonalXPuestos(p As String) As String
        Dim retorno As String = ""
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr As SqlDataReader
        Dim cmd As New SqlCommand
        b.abrirConexion()
        sql = "select PP.nombre,PP.apellido_paterno,PP.apellido_materno," & _
                        "P.descripcion from directivos D inner join puestos P " & _
                        "on P.id=D.idPuesto inner join personal PP " & _
                        "on PP.id=D.idPersonal " & _
                        "where P.descripcion='" & p & "'"

        cmd = New SqlCommand(sql, b.Conexion)
        SQLdr = cmd.ExecuteReader()
        While SQLdr.Read()
            retorno = SQLdr("nombre").ToString & " " & _
                SQLdr("apellido_paterno").ToString & " " & _
                SQLdr("apellido_materno").ToString
        End While

        b.cerrarConexion()
        Return retorno
    End Function
    Public Shared Function obtenerFechaConfrontaTit() As Date
        Dim retorno As Date
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr As SqlDataReader
        Dim cmd As New SqlCommand
        b.abrirConexion()
        sql = "select fechaRegConfronTit from configuracion"

        cmd = New SqlCommand(sql, b.Conexion)
        SQLdr = cmd.ExecuteReader()
        While SQLdr.Read()
            retorno = SQLdr("fechaRegConfronTit")
        End While

        b.cerrarConexion()
        Return retorno
    End Function
    Public Shared Function obtenerFechaConfrontaCert() As Date
        Dim retorno As Date
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr As SqlDataReader
        Dim cmd As New SqlCommand
        b.abrirConexion()
        sql = "select fechaRegConfronCert from configuracion"

        cmd = New SqlCommand(sql, b.Conexion)
        SQLdr = cmd.ExecuteReader()
        While SQLdr.Read()
            retorno = SQLdr("fechaRegConfronCert")
        End While

        b.cerrarConexion()
        Return retorno
    End Function
    Public Shared Function obtenerFechaExpCert() As Date
        Dim retorno As Date
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr As SqlDataReader
        Dim cmd As New SqlCommand
        b.abrirConexion()
        sql = "select fechaExpCert from configuracion"

        cmd = New SqlCommand(sql, b.Conexion)
        SQLdr = cmd.ExecuteReader()
        While SQLdr.Read()
            retorno = SQLdr("fechaExpCert")
        End While

        b.cerrarConexion()
        Return retorno
    End Function
    Public Shared Function getpersonal() As DataSet
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String
        sql = "select ID,UPPER(NOMBRE) + ' ' + UPPER(APELLIDO_PATERNO) + ' ' + UPPER(APELLIDO_MATERNO) as nombre " & _
         "from personal order by nombre; "

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

        Return ds
    End Function

    Private Shared Function variables() As Object
        Throw New NotImplementedException
    End Function

End Class
