Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports System.Data.SqlClient

Public Class PlanEstudiosCicloFrm

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If cmbSemestre.Text = "" Then
            MsgBox("Elija Semestre", vbCritical)
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
        variables.ciclo = cmbCiclo.Text
        variables.semestre = cmbSemestre.Text
        variables.licenciatura = cmbLicenciatura.Text
        ejecutarConsulta()
    End Sub
    Private Sub generaGrid()

        gridListado.Columns.Add("ID", "ID")
        gridListado.Columns.Add("CICLO", "CICLO ESCOLAR")
        gridListado.Columns.Add("IDLICE", "IDLICE")
        gridListado.Columns.Add("LICENCIATURA", "LICENCIATURA")
        gridListado.Columns.Add("ESPECIALIDAD", "ESPECIALIDAD")
        gridListado.Columns.Add("SEMESTRE", "SEMESTRE")
        gridListado.Columns.Add("IDMATERIA", "IDMATERIA")
        gridListado.Columns.Add("MATERIA", "MATERIA")

        gridListado.Columns.Item("ID").Width = 0
        gridListado.Columns.Item("ID").ReadOnly = True
        gridListado.Columns.Item("ID").Visible = False
        gridListado.Columns.Item("CICLO").Width = 100
        gridListado.Columns.Item("CICLO").ReadOnly = True
        gridListado.Columns.Item("IDLICE").Width = 100
        gridListado.Columns.Item("IDLICE").ReadOnly = True
        gridListado.Columns.Item("IDLICE").Visible = False
        gridListado.Columns.Item("LICENCIATURA").Width = 200
        gridListado.Columns.Item("LICENCIATURA").ReadOnly = True
        gridListado.Columns.Item("ESPECIALIDAD").Width = 250
        gridListado.Columns.Item("ESPECIALIDAD").ReadOnly = True
        gridListado.Columns.Item("SEMESTRE").Width = 100
        gridListado.Columns.Item("SEMESTRE").ReadOnly = True
        gridListado.Columns.Item("IDMATERIA").ReadOnly = True
        gridListado.Columns.Item("IDMATERIA").Width = 100
        gridListado.Columns.Item("MATERIA").ReadOnly = True
        gridListado.Columns.Item("MATERIA").Width = 400
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
                                "CL.semestre,M.IDMATERIA,M.NOMBRE as materia,CL.planEstudios " & _
                                "from cicloescolar_licenciatura CL " & _
                                "inner join ciclo_escolar C on C.IDCICLOESCOLAR=CL.idCicloEscolar " & _
                                "inner join licenciaturas L on L.IDLICENCIATURA=CL.idLicenciatura " & _
                                "left join especialidades E on E.IDESPECIALIDAD=CL.idEspecialidad " & _
                                "inner join materias M on M.IDMATERIA=CL.idMateria " & _
                                "where CL.idCicloEscolar = " & Val(cmbCiclo.SelectedValue) & " and Cl.idLicenciatura = " & Val(cmbLicenciatura.SelectedValue) & " " & _
                                "and CL.semestre=" & Val(cmbSemestre.Text) & " and CL.idEspecialidad=" & Val(cmbEspecialidad.SelectedValue) & " " & _
                                "and CL.planEstudios='" & cmbPlan.Text & "' order by CL.id"

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
                gridListado(6, I).Value = variables.SQLdr("idmateria").ToString
                gridListado(7, I).Value = variables.SQLdr("materia").ToString
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
    Private Sub PlanEstudiosCicloFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        grupoPrincipal.Visible = False
    End Sub

    Private Sub cmbMateria_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbMateria.DropDown
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        If cmbLicenciatura.Text = "EDUCACIÓN ESPECIAL" Or cmbLicenciatura.Text = "EDUCACIÓN SECUNDARIA" Then
            sql = "select IDMATERIA,NOMBRE from materias where IDCARRERA=" & Val(cmbLicenciatura.SelectedValue) & " " & _
              "and PlanDEestudios='" & cmbPlan.Text & "' and IDSEMESTRE='" & cmbSemestre.Text & "' " & _
              "and IDESPECIALIDAD=" & Val(cmbEspecialidad.SelectedValue) & " or idmateria=1232 or idmateria=1233 or idmateria=1278 or idmateria=1279 ORDER BY NOMBRE"
        Else
            sql = "select IDMATERIA,NOMBRE from materias where IDCARRERA=" & Val(cmbLicenciatura.SelectedValue) & " " & _
               "and PlanDEestudios='" & cmbPlan.Text & "' and IDSEMESTRE='" & cmbSemestre.Text & "' " & _
               "and IDESPECIALIDAD=0 or idmateria=1232 or idmateria=1233 or idmateria=1278 or idmateria=1279 ORDER BY NOMBRE"
        End If

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        loadComboBox(ds, cmbMateria, "IDMATERIA", "NOMBRE")
    End Sub

    Private Sub cmdAgregar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregar.Click
        If cmbCiclo.Text <> variables.ciclo Or variables.licenciatura <> cmbLicenciatura.Text Or variables.semestre <> cmbSemestre.Text Then
            ejecutarConsulta()
        End If
        'If gridListado.RowCount <= 0 Then
        '    MsgBox("Realice una Busqueda", vbCritical)
        '    Exit Sub
        'End If
        grupoPrincipal.Visible = True
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Dim _modelo As New modelos.cicloescolar_licenciatura
            If cmbPlan.Text = "" Then
                MsgBox("Error Elija un Plan de Estudios", vbCritical)
                Exit Sub
            End If
            _modelo.idCicloEscolar = Val(cmbCiclo.SelectedValue)
            _modelo.idEspecialidad = Val(cmbEspecialidad.SelectedValue)
            _modelo.idLicenciatura = Val(cmbLicenciatura.SelectedValue)
            _modelo.idMateria = Val(cmbMateria.SelectedValue)
            _modelo.planEstudios = cmbPlan.Text
            _modelo.semestre = Val(cmbSemestre.Text)
            guardarRegistro(_modelo)

        Catch ex As Exception
            MsgBox("Error Encontrado: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub guardarRegistro(ByVal modelo As modelos.cicloescolar_licenciatura)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO cicloescolar_licenciatura(idCicloEscolar,idLicenciatura,idEspecialidad,semestre,idMateria," & _
                "planEstudios)VALUES(@idCicloEscolar,@idLicenciatura,@idEspecialidad,@semestre,@idMateria," & _
                "@planEstudios)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idCicloEscolar", modelo.idCicloEscolar)
                .Parameters.AddWithValue("@idLicenciatura", modelo.idLicenciatura)
                .Parameters.AddWithValue("@idEspecialidad", modelo.idEspecialidad)
                .Parameters.AddWithValue("@semestre", modelo.semestre)
                .Parameters.AddWithValue("@idMateria", modelo.idMateria)
                .Parameters.AddWithValue("@planEstudios", modelo.planEstudios)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
            ejecutarConsulta()
            grupoPrincipal.Visible = False
        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminar.Click
        Dim mensaje As String
        Try
            mensaje = MsgBox("Deseas eliminar la siguiente materia: " & gridListado.Item(7, gridListado.CurrentRow.Index).Value.ToString & "?", vbYesNo)
            If mensaje = vbYes Then
                variables.conexion.abrirConexion()
                Dim sql As String
                sql = " DELETE FROM cicloescolar_licenciatura where (id=" & CDbl(gridListado.Item(0, gridListado.CurrentRow.Index).Value.ToString) & ") "
                Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                cmd.ExecuteNonQuery()
                variables.conexion.cerrarConexion()
                MsgBox("Eliminacion Completa!", vbInformation)
                ejecutarConsulta()
            Else
                Exit Sub
            End If
        Catch
            MsgBox("Error Actualizando intente de nuevo", vbCritical)
            Exit Sub
        End Try
    End Sub

    Private Sub cmbPlan_DropDown(sender As System.Object, e As System.EventArgs)
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""

        sql = "select id,planEstudios from plan_estudios order by planEstudios desc"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        loadComboBox(ds, cmbPlan, "id", "planEstudios")
    End Sub

    Private Sub ComboBox1_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbPlan.DropDown
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