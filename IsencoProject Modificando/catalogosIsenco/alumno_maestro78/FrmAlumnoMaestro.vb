Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports datosCompartidos.funciones

Public Class FrmAlumnoMaestro
    Dim actualizar_cmbmaestro As Boolean = False
    Dim actualizar_cmbmateria As Boolean = False
    Private Sub FrmAlumnoMaestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializar_formulario()
    End Sub
    Public Function verifica_maestro(ByVal id As Integer) As String
        Dim maestro As String = ""
        variables.conexion.abrirConexion()
        Try
            variables.sql = "select p.apellido_paterno, p.apellido_materno, p.nombre from personal as p " & _
                            "inner join tutor_alumno78 as t on p.Id = t.idpersonal where t.idalumno = '" & id & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While variables.SQLdr.Read
                maestro = variables.SQLdr("apellido_paterno").ToString + " " + variables.SQLdr("apellido_materno").ToString + " " + variables.SQLdr("nombre").ToString
            End While
            If variables.SQLdr.HasRows = False Then
                maestro = ""
            End If
            variables.SQLdr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
        Return maestro ' regresa el dato del maestro
    End Function
    Private Sub inicializar_combos()
        cmbCampus.Text = ""
        cmbEspecialidad.Text = ""
        cmbGrupo.Text = ""
        cmbLicenciatura.Text = ""
        cmbSemestre.Text = ""
        cmbTurno.Text = ""
        CmbPlanEst.Text = ""
        Cmbplan.Text = ""
    End Sub
    Private Sub inicializar_formulario()
        Dim ds As New DataSet
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "IDLICENCIATURA", "licenciatura")
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "IDESPECIALIDAD", "especialidad")
        ds = getGrupos()
        loadComboBox(ds, cmbGrupo, "nombre", "nombre")
        ds = getplanestudios()
        loadComboBox(ds, CmbPlanEst, "id", "planEstudios")
        inicializar_combos()
        GbxDocentes.Enabled = False
        BtnAsignar.Enabled = False
    End Sub
    Private Sub GeneraGrid()
        DG.Columns.Add("MATRICULA", "MATRICULA")
        DG.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO")
        DG.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO")
        DG.Columns.Add("NOMBRE", "NOMBRE")
        DG.Columns.Add("IDALUMNO", "ID")
        Dim chkboxcol As New DataGridViewCheckBoxColumn
        DG.Columns.Add(chkboxcol)
        DG.Columns.Add("MAESTRO", "MAESTRO")
        DG.Columns.Item("MAESTRO").Width = 400
        DG.Columns.Item("IDALUMNO").ReadOnly = True
        DG.Columns.Item("APELLIDO_PATERNO").ReadOnly = True
        DG.Columns.Item("APELLIDO_MATERNO").ReadOnly = True
        DG.Columns.Item("NOMBRE").ReadOnly = True
        DG.Columns.Item("MATRICULA").ReadOnly = True
    End Sub
    Private Sub obtener_lista()
        DG.Rows.Clear()
        DG.Columns.Clear()
        GeneraGrid()
        actualizar_cmbmaestro = False
        actualizar_cmbmateria = False
        variables.conexion.abrirConexion()
        Try
            variables.sql = "select " & _
                " matricula,apellido_paterno,apellido_materno,nombre,idalumno from alumno " & _
                "where IDCAMPUS = '" & cmbCampus.Text & "' and IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
                "and IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and idturno = '" & cmbTurno.Text & "' " & _
                "and IDSEMESTRE = '" & cmbSemestre.Text & "' and IDGRUPO = '" & cmbGrupo.Text & "' " & _
                "and idstatus<>'EGRESADO' and IDSTATUS NOT LIKE '%BAJA%' " & _
                "order by apellido_paterno,apellido_materno, nombre"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While variables.SQLdr.Read
                DG.Rows.Add()
            End While
            variables.SQLdr.Close()
            variables.SQLdr = cmd.ExecuteReader
            Dim I As Integer
            I = 0
            While variables.SQLdr.Read()
                DG(0, I).Value = variables.SQLdr("matricula").ToString
                DG(1, I).Value = variables.SQLdr("apellido_paterno").ToString
                DG(2, I).Value = variables.SQLdr("apellido_materno").ToString
                DG(3, I).Value = variables.SQLdr("nombre").ToString
                DG(4, I).Value = variables.SQLdr("idalumno").ToString
                I = I + 1
            End While
            DG.Update()
            DG.Focus()
            lblRegs.Text = "No. de Alumnos:" & Str(DG.RowCount)
            'revisar el grid para asignarles los maestros que ya tengan

            For I = 0 To DG.RowCount - 1
                DG(6, I).Value = verifica_maestro(DG(4, I).Value)
            Next I
            GbxDocentes.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        obtener_lista()
    End Sub

    Private Sub cmbCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCampus.SelectedIndexChanged, cmbEspecialidad.SelectedIndexChanged, cmbGrupo.SelectedIndexChanged, cmbLicenciatura.SelectedIndexChanged, cmbTurno.SelectedIndexChanged
        GbxDocentes.Enabled = False
    End Sub
    Private Sub extraer_id_maestro()
        Dim str As String
        Dim strArr() As String
        ' Dim count As Integer
        str = cmbmaestro.Text
        If str <> "" Then
            strArr = str.Split("-")
            lblidmaestro.TextAlign = ContentAlignment.BottomLeft
            lblidmaestro.Text = strArr(1)
        End If
    End Sub
    Private Sub extraer_id_materia()
        Dim str As String
        Dim strArr() As String
        ' Dim count As Integer
        str = Cmbplan.Text
        If str <> "" Then
            strArr = str.Split("-")
            lblidmateria.TextAlign = ContentAlignment.BottomLeft
            lblidmateria.Text = strArr(1)
        End If
    End Sub
    Private Sub cmbmaestro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmaestro.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""
            sql = "select id,apellido_paterno + ' ' + apellido_materno + ' ' + nombre + ' - ' + str(id) as nombreCompleto from personal where activo=1 " & _
                "and (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + cmbmaestro.Text + "%' " & _
                "ORDER BY apellido_paterno,apellido_materno,nombre"
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            loadComboBox(ds, cmbmaestro, "id", "nombreCompleto")
            BtnAsignar.Enabled = True
            extraer_id_maestro()
            If lblidmaestro.Text <> "" Then
                actualizar_cmbmaestro = True
            End If
        End If
    End Sub


    Private Sub BtnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAsignar.Click
        Dim i As Integer
        Dim sql As String = ""
        Dim encontrado As Boolean = False
        Try
            For i = 0 To DG.RowCount - 1
                If DG(5, i).Value = True Then
                    variables.conexion.abrirConexion()
                    sql = "select * from tutor_alumno78 where idalumno = @IDALUMNO"
                    Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                    With cmd
                        .Parameters.AddWithValue("@IDALUMNO", DG(4, i).Value)
                    End With
                    variables.SQLdr = cmd.ExecuteReader()
                    If variables.SQLdr.HasRows Then
                        encontrado = True
                    Else
                        encontrado = False
                    End If
                    variables.SQLdr.Close()
                    If encontrado Then
                        sql = "UPDATE tutor_alumno78 set idpersonal = @IDPERSONAL where idalumno = @IDALUMNO"
                        Dim cmd2 As New SqlCommand(sql, variables.conexion.Conexion)
                        With cmd2
                            .Parameters.AddWithValue("@IDALUMNO", DG(4, i).Value)
                            .Parameters.AddWithValue("@IDPERSONAL", CInt(lblidmaestro.Text))
                        End With
                        Dim nM = CInt(cmd2.ExecuteScalar())
                    Else
                        sql = "INSERT INTO [ISENCO].[dbo].[tutor_alumno78] ([idpersonal],[idalumno]) values(@IDPERSONAL,@IDALUMNO)"
                        Dim cmd2 As New SqlCommand(sql, variables.conexion.Conexion)
                        With cmd2
                            .Parameters.AddWithValue("@IDALUMNO", DG(4, i).Value)
                            .Parameters.AddWithValue("@IDPERSONAL", CInt(lblidmaestro.Text))
                        End With
                        Dim nH As Integer = CInt(cmd2.ExecuteScalar())
                    End If
                End If
            Next i
            obtener_lista()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub eliminar_registro()
        Dim sql As String = ""
        variables.conexion.abrirConexion()
        sql = "delete from tutor_alumno78 where idalumno = @IDALUMNO"
        Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
        With cmd
            .Parameters.AddWithValue("@IDALUMNO", DG(4, DG.CurrentRow.Index).Value)
        End With
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub DG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellDoubleClick
        Dim mensaje As String
        Try
            mensaje = MsgBox("Esta Seguro de Eliminar el docente asignado al id-alumno: " & DG(4, DG.CurrentRow.Index).Value & "?", vbYesNo)
            If mensaje = vbYes Then
                eliminar_registro()
                MsgBox("Eliminacion Completa!", vbInformation)
                obtener_lista()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub cmbmaestro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbmaestro.SelectedIndexChanged
        If actualizar_cmbmaestro Then
            extraer_id_maestro()
        End If
    End Sub

    Private Sub Cmbplan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbplan.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""
            Dim aux As String = ""
            If cmbEspecialidad.Text <> "" Then
                aux = " and e.descripcion = '" & cmbEspecialidad.Text & "'"
            End If
            sql = "select m.idmateria,m.nombre + ' - ' + str(m.idmateria) as nombreCompleto from materias as m" & _
                  " inner join licenciaturas as l on l.IDLICENCIATURA = m.IDCARRERA" & _
                  " left join especialidades as e on e.IDESPECIALIDAD = m.IDESPECIALIDAD" & _
                  " where m.activa=1 and m.nombre like '%" + Cmbplan.Text + "%' and l.NOMBRE = '" & cmbLicenciatura.Text & "'" & _
                  " and m.planDEestudios = '" & CmbPlanEst.Text & "'" & aux
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            loadComboBox(ds, Cmbplan, "idmateria", "nombreCompleto")
            BtnAsignar.Enabled = True
            extraer_id_materia()
            If lblidmateria.Text <> "" Then
                actualizar_cmbmateria = True
            End If
        End If
    End Sub
    Private Sub Cmbplan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbplan.SelectedIndexChanged
        If actualizar_cmbmateria Then
            extraer_id_materia()
        End If
    End Sub
End Class