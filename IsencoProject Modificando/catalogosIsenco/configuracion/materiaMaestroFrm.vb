Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Public Class materiaMaestroFrm
    
    Private Sub materiaMaestroFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        sql = "select IDCICLOESCOLAR,DESCRIPCION from ciclo_escolar ORDER BY DESCRIPCION desc"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        loadComboBox(ds, cmbCiclo, "IDCICLOESCOLAR", "DESCRIPCION")
        'LICENCIATURA
        sql = "select IDLICENCIATURA,NOMBRE from licenciaturas ORDER BY NOMBRE"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        loadComboBox(ds, cmbLicenciatura, "IDLICENCIATURA", "NOMBRE")
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If cmbSemestre.Text = "" Or cmbGrupo.Text = "" Then
            MsgBox("Elija Semestre y Grupo", vbCritical)
            Exit Sub
        End If
        If cmbCiclo.Text = "" Then
            MsgBox("Elija Ciclo Escolar", vbCritical)
            Exit Sub
        End If
        If cmbLicenciatura.Text = "" Then
            MsgBox("Elija Licenciatura", vbCritical)
            Exit Sub
        End If
        If cmbPlan.Text = "" Then
            MsgBox("Elija el Plan de Estudios", vbCritical)
            Exit Sub
        End If
        If cmbCampus.Text = "" Then
            MsgBox("Elija el Campus", vbCritical)
            Exit Sub
        End If
        ejecutarConsulta()
    End Sub
    Private Sub generaGrid()

        gridListado.Columns.Add("IDCICLOLIC", "IDCICLOLIC")
        gridListado.Columns.Add("CICLO", "CICLO ESCOLAR")
        gridListado.Columns.Add("IDLICE", "IDLICE")
        gridListado.Columns.Add("LICENCIATURA", "LICENCIATURA")
        gridListado.Columns.Add("ESPECIALIDAD", "ESPECIALIDAD")
        gridListado.Columns.Add("SEMESTRE", "SEMESTRE")
        gridListado.Columns.Add("GRUPO", "GRUPO")
        gridListado.Columns.Add("IDMATERIA", "IDMATERIA")
        gridListado.Columns.Add("MATERIA", "MATERIA")
        gridListado.Columns.Add("HORAS", "HORAS")
        gridListado.Columns.Add("IDMAESTROMAT", "IDMAESTROMAT")
        gridListado.Columns.Add("IDMAESTRO", "IDMAESTRO")
        gridListado.Columns.Add("MAESTRO", "MAESTRO")

        gridListado.Columns.Item("IDCICLOLIC").Width = 0
        gridListado.Columns.Item("IDCICLOLIC").ReadOnly = True
        gridListado.Columns.Item("IDCICLOLIC").Visible = False
        gridListado.Columns.Item("CICLO").Width = 100
        gridListado.Columns.Item("CICLO").ReadOnly = True
        gridListado.Columns.Item("IDLICE").Width = 100
        gridListado.Columns.Item("IDLICE").ReadOnly = True
        gridListado.Columns.Item("IDLICE").Visible = False
        gridListado.Columns.Item("LICENCIATURA").Width = 200
        gridListado.Columns.Item("LICENCIATURA").ReadOnly = True
        gridListado.Columns.Item("ESPECIALIDAD").Width = 250
        gridListado.Columns.Item("ESPECIALIDAD").ReadOnly = True
        gridListado.Columns.Item("SEMESTRE").Width = 70
        gridListado.Columns.Item("SEMESTRE").ReadOnly = True
        gridListado.Columns.Item("GRUPO").Width = 70
        gridListado.Columns.Item("GRUPO").ReadOnly = True
        gridListado.Columns.Item("IDMATERIA").ReadOnly = True
        gridListado.Columns.Item("IDMATERIA").Width = 100
        gridListado.Columns.Item("IDMATERIA").Visible = False
        gridListado.Columns.Item("MATERIA").ReadOnly = True
        gridListado.Columns.Item("MATERIA").Width = 400
        gridListado.Columns.Item("HORAS").Width = 70
        gridListado.Columns.Item("HORAS").ReadOnly = True
        gridListado.Columns.Item("IDMAESTROMAT").Width = 0
        gridListado.Columns.Item("IDMAESTROMAT").ReadOnly = True
        gridListado.Columns.Item("IDMAESTROMAT").Visible = False
        gridListado.Columns.Item("IDMAESTRO").Width = 0
        gridListado.Columns.Item("IDMAESTRO").ReadOnly = True
        gridListado.Columns.Item("IDMAESTRO").Visible = False
        gridListado.Columns.Item("MAESTRO").ReadOnly = True
        gridListado.Columns.Item("MAESTRO").Width = 400

    End Sub
    Private Sub ejecutarConsulta()
        Try
            If cmbLicenciatura.Text = "EDUCACIÓN ESPECIAL" Or cmbLicenciatura.Text = "EDUCACIÓN SECUNDARIA" Then
                If cmbEspecialidad.Text = "" Then
                    MsgBox("Elija una Especialidad!", vbCritical)
                    cmbEspecialidad.Focus()
                    Exit Sub
                End If
            End If

            gridListado.Rows.Clear()
            gridListado.Columns.Clear()
            generaGrid()
            variables.conexion.abrirConexion()
            If funcionesLocales.validarReceptorGP(GroupBox2) Then
                variables.sql = "select CL.id,C.DESCRIPCION as cicloEscolar,L.IDLICENCIATURA,L.NOMBRE as licenciatura,E.DESCRIPCION as especialidad," & _
                                "CL.semestre,M.IDMATERIA,M.NOMBRE as materia,CL.planEstudios,PM.grupo,PM.id as idPM,PM.horasGrupo,P.id as idPersonal, " & _
                                "P.apellido_paterno + ' ' + P.apellido_materno + ' ' + P.nombre as nombreCompleto " & _
                                "from cicloescolar_licenciatura CL " & _
                                "inner join ciclo_escolar C on C.IDCICLOESCOLAR=CL.idCicloEscolar " & _
                                "inner join licenciaturas L on L.IDLICENCIATURA=CL.idLicenciatura " & _
                                "LEFT join especialidades E on E.IDESPECIALIDAD=CL.idEspecialidad " & _
                                "inner join materias M on M.IDMATERIA=CL.idMateria " & _
                                "LEFT join personal_materia PM on PM.idCicloLicenciatura=CL.id and PM.grupo='" & cmbGrupo.Text & "' and PM.campus='" & cmbCampus.Text & "' " & _
                                "LEFT join personal P on p.id=PM.idPersonal " & _
                                "where CL.idCicloEscolar = " & Val(cmbCiclo.SelectedValue) & " and Cl.idLicenciatura = " & Val(cmbLicenciatura.SelectedValue) & " " & _
                                "and CL.semestre=" & Val(cmbSemestre.Text) & "  and CL.idEspecialidad=" & Val(cmbEspecialidad.SelectedValue) & " and CL.planEstudios='" & cmbPlan.Text & "' "

            Else
                MsgBox("Llene la Informacion Correspondiente", vbInformation)
                funcionesLocales.pintarControles(GroupBox2)
            End If


            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While variables.SQLdr.Read
                gridListado.Rows.Add()
            End While
            variables.SQLdr.Close()

            variables.SQLdr = cmd.ExecuteReader
            Dim I As Integer
            I = 0
            While variables.SQLdr.Read()
                gridListado(0, I).Value = variables.SQLdr("id").ToString
                gridListado(1, I).Value = variables.SQLdr("cicloEscolar").ToString
                gridListado(2, I).Value = variables.SQLdr("idlicenciatura").ToString
                gridListado(3, I).Value = variables.SQLdr("licenciatura").ToString
                gridListado(4, I).Value = variables.SQLdr("especialidad").ToString
                gridListado(5, I).Value = variables.SQLdr("semestre").ToString
                gridListado(6, I).Value = variables.SQLdr("grupo").ToString
                gridListado(7, I).Value = variables.SQLdr("idmateria").ToString
                gridListado(8, I).Value = variables.SQLdr("materia").ToString
                gridListado(9, I).Value = variables.SQLdr("horasGrupo").ToString
                gridListado(10, I).Value = variables.SQLdr("idPM").ToString
                gridListado(11, I).Value = variables.SQLdr("idPersonal").ToString
                gridListado(12, I).Value = variables.SQLdr("nombreCompleto").ToString

                I = I + 1
            End While
            gridListado.Update()
            gridListado.Focus()

            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmbMaestro_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbMaestro.DropDown
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        grupoPrincipal.Visible = False
    End Sub

    Private Sub gridListado_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridListado.CellContentDoubleClick
        grupoPrincipal.Visible = True
        txtIdCicloLicenciatura.Text = Val(gridListado.Rows(e.RowIndex).Cells("IDCICLOLIC").Value)
        txtIdPersonalMateria.Text = Val(gridListado.Rows(e.RowIndex).Cells("IDMAESTROMAT").Value)
        lblMateria.Text = "ELIGE MAESTRO PARA MATERIA: " & gridListado.Rows(e.RowIndex).Cells("MATERIA").Value.ToString
    End Sub

    Private Sub cmbMaestro_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMaestro.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""
            sql = "select id,apellido_paterno + ' ' + apellido_materno + ' ' + nombre as nombreCompleto from personal where activo=1 " & _
                "and (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + cmbMaestro.Text + "%' " & _
                "ORDER BY apellido_paterno,apellido_materno,nombre"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            loadComboBox(ds, cmbMaestro, "id", "nombreCompleto")
        End If
    End Sub


    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Dim _modelo As New modelos.personal_materia
            If txtHoras.Text = "" Then
                MsgBox("Debes escribir cuantas horas da de esa materia x semana", vbCritical)
                Exit Sub
            End If
            _modelo.id = Val(txtIdPersonalMateria.Text)
            _modelo.idCicloLicenciatura = Val(txtIdCicloLicenciatura.Text)
            _modelo.grupo = cmbGrupo.Text
            _modelo.horasGrupo = CDbl(txtHoras.Text)
            _modelo.idPersonal = Val(cmbMaestro.SelectedValue)
            _modelo.campus = cmbCampus.Text
            guardarRegistro(_modelo)

        Catch ex As Exception
            MsgBox("Error Encontrado: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub guardarRegistro(ByVal modelo As modelos.personal_materia)
        Dim sql As String = ""
        Try
            variables.conexion.abrirConexion()
            If modelo.id > 0 Then
                sql = "UPDATE personal_materia SET idCicloLicenciatura=@idCicloLicenciatura,grupo=@grupo,idPersonal=@idPersonal,horasGrupo=@horasGrupo, " & _
                    "campus=@campus where id=@id"
            Else
                sql = "INSERT INTO personal_materia(idCicloLicenciatura,grupo,idPersonal,horasGrupo,campus)" & _
                "VALUES(@idCicloLicenciatura,@grupo,@idPersonal,@horasGrupo,@campus)"
            End If

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idCicloLicenciatura", modelo.idCicloLicenciatura)
                .Parameters.AddWithValue("@grupo", modelo.grupo)
                .Parameters.AddWithValue("@idPersonal", modelo.idPersonal)
                .Parameters.AddWithValue("@horasGrupo", modelo.horasGrupo)
                .Parameters.AddWithValue("@campus", modelo.campus)
                .Parameters.AddWithValue("@id", modelo.id)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
            grupoPrincipal.Visible = False
            cmbMaestro.DataSource = Nothing
            txtHoras.Text = ""
            txtIdCicloLicenciatura.Text = ""
            txtIdPersonalMateria.Text = ""
            ejecutarConsulta()

        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Private Sub cmbEspecialidad_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbEspecialidad.DropDown
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        'ESPECIALIDAD
        sql = "select IDESPECIALIDAD,DESCRIPCION from especialidades ORDER BY DESCRIPCION"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        loadComboBox(ds, cmbEspecialidad, "IDESPECIALIDAD", "DESCRIPCION")
    End Sub

    Private Sub cmbPlan_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbPlan.DropDown
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""

        sql = "select id,planEstudios from plan_estudios order by planEstudios desc"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        loadComboBox(ds, cmbPlan, "id", "planEstudios")
    End Sub
End Class