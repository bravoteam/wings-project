Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Imports System.IO

Public Class calificacionAlumnoFrm
    Public Fotografia As String = ""
    Private Ext As String = ""
    Public FotografiaAnterior As String = ""
    Private FotoVacia As String = System.AppDomain.CurrentDomain.BaseDirectory + "nf.jpg"
    Private Sub calificacionAlumnoFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim fechaAbierta, fechaCierre, fechaServer As Date
        variables.conexion.abrirConexion()
        variables.sql = "select * from candado where tipoAcceso =" & variables.tipoAcceso & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()

        While (variables.SQLdr.Read())
            fechaAbierta = variables.SQLdr("fecha")
            fechaCierre = variables.SQLdr("cierre")
            variables.parcial = Val(variables.SQLdr("parcial"))
        End While


        'Se obtiene la fecha del SERVER
        variables.conexion.abrirConexion()
        variables.sql = "select GETDATE() as fecha"
        cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()

        While (variables.SQLdr.Read())
            fechaServer = variables.SQLdr("fecha")
        End While
        variables.conexion.cerrarConexion()

        If fechaCierre < fechaServer Then
            MsgBox("Sistema de Calificaciones Cerrado!", MsgBoxStyle.Critical)
            cmdGuardar.Enabled = False
        End If

        obtenerAlumno(variables.idLocalizado)
        variables.semestre = Val(Val(txtSemestre.Text) - 1)
        'Se obtiene las Calificaciones
        variables.sql = "select IDCALIFICACION,c.IDMATERIA,m.NOMBRE,CALIFICACION,calificacion2,calificacion3,asistenciaP1,asistenciaP2,asistenciaP3,idAlumno " & _
                        "from calificaciones c inner join materias m on m.IDMATERIA=c.IDMATERIA " & _
                        "where c.IDALUMNO=" & variables.idLocalizado & " and c.IDSEMESTRE='" & variables.semestre & "'"
        b.abrirConexion()
        ds = b.getDataSet(variables.sql)
        DG.Columns.Add("IDCALIFICACION", "ID") '0
        DG.Columns.Add("IDMATERIA", "IDMATERIA") '1
        DG.Columns.Add("MATERIA", "MATERIA") '2
        DG.Columns.Add("CALIFICACION1P", "CALIFICACION1P") '3
        DG.Columns.Add("CALIFICACION2P", "CALIFICACION2P") '4
        DG.Columns.Add("CALIFICACION3P", "CALIFICACION3P") '5
        DG.Columns.Add("PORCENTAJE1P", "PORCENTAJE1P") '6
        DG.Columns.Add("PORCENTAJE2P", "PORCENTAJE2P") '7
        DG.Columns.Add("PORCENTAJE3P", "PORCENTAJE3P") '8
        DG.Columns.Add("IDALUMNO", "IDALUMNO") '9

        DG.Columns.Item("IDCALIFICACION").ReadOnly = True
        DG.Columns.Item("IDMATERIA").ReadOnly = True
        DG.Columns.Item("IDMATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DG.Columns.Item("MATERIA").ReadOnly = True
        DG.Columns.Item("MATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DG.Columns.Item("CALIFICACION1P").ReadOnly = True
        DG.Columns.Item("CALIFICACION2P").ReadOnly = True
        DG.Columns.Item("CALIFICACION3P").ReadOnly = True
        DG.Columns.Item("PORCENTAJE1P").ReadOnly = True
        DG.Columns.Item("PORCENTAJE2P").ReadOnly = True
        DG.Columns.Item("PORCENTAJE3P").ReadOnly = True
        DG.Columns.Item("IDALUMNO").ReadOnly = True
        DG.Rows.Add(ds.Tables(0).Rows.Count)
        Dim i As Integer = 0
        Dim j As Integer = 0
        For Each f As DataRow In ds.Tables(0).Rows
            For Each c As DataColumn In ds.Tables(0).Columns
                DG(j, i).Value = f(c).ToString
                j += 1
                If j > ds.Tables(0).Columns.Count - 1 Then j = 0
            Next
            i += 1
        Next

        If variables.parcial = 1 Then
            DG.Columns(4).Visible = False
            DG.Columns(5).Visible = False
            DG.Columns(7).Visible = False
            DG.Columns(8).Visible = False
        End If
        If variables.parcial = 2 Then
            DG.Columns(3).Visible = False
            DG.Columns(5).Visible = False
            DG.Columns(6).Visible = False
            DG.Columns(8).Visible = False
        End If
        If variables.parcial = 3 Then
            DG.Columns(3).Visible = False
            DG.Columns(4).Visible = False
            DG.Columns(6).Visible = False
            DG.Columns(7).Visible = False
        End If
        DG.Columns(9).Visible = False
        DG.Columns(1).Visible = False
        DG.Columns(0).Visible = False
    End Sub
    Private Sub obtenerAlumno(id As Integer)
        variables.conexion.abrirConexion()
        variables.sql = "select * from alumno where idAlumno = " & id & " "
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()

        While (variables.SQLdr.Read())
            txtCampus.Text = variables.SQLdr("IDCAMPUS").ToString
            txtLicenciatura.Text = variables.SQLdr("IDLICENCIATURA").ToString
            txtEspecialidad.Text = variables.SQLdr("IDESPECIALIDAD").ToString
            txtSemestre.Text = variables.SQLdr("IDSEMESTRE").ToString
            txtGrupo.Text = variables.SQLdr("IDGRUPO").ToString
            comboAlumno.Text = variables.SQLdr("APELLIDO_PATERNO").ToString & " " & variables.SQLdr("APELLIDO_MATERNO").ToString & " " & variables.SQLdr("NOMBRE").ToString
            variables.foto = variables.SQLdr("foto")
        End While
        If Not (IsNothing(variables.foto)) Then
            Dim bytBLOBData() As Byte = variables.foto
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            oFotografia.Image = Image.FromStream(stmBLOBData)
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click

    End Sub

    Private Sub regresarCmd_Click(sender As System.Object, e As System.EventArgs) Handles regresarCmd.Click
        Me.Close()
    End Sub
End Class