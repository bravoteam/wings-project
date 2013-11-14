Imports System.Data
Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones


Public Class becados
    Private Sub consultarcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarcmd.Click
        variables.campus = cmbCampus.Text
        variables.licenciatura = cmbLicenciatura.Text
        variables.especialidad = cmbEspecialidad.Text
        variables.turno = cmbTurno.Text
        variables.semestre = cmbSemestre.Text
        variables.grupo = cmbGrupo.Text
        variables.beca = cmbTipoBeca.Text

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        sql = "SELECT MATRICULA, IDCAMPUS, APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE, IDLICENCIATURA,IDESPECIALIDAD,IDTURNO, IDSEMESTRE, " & _
        "IDGRUPO, BECA FROM ALUMNO where (beca <> 'null') and (beca <> ' ') and (IDCAMPUS LIKE '%" & variables.campus & "%' ) and (IDLICENCIATURA LIKE '%" & variables.licenciatura & "%' ) " & _
        "and (IDESPECIALIDAD LIKE '%" & variables.especialidad & "%' ) and (IDTURNO LIKE '%" & variables.turno & "%' ) and (IDSEMESTRE LIKE '%" & variables.semestre & "%' ) " & _
        "and (IDGRUPO LIKE '%" & variables.grupo & "%' ) and (BECA LIKE '%" & variables.beca & "%') AND IDSTATUS NOT LIKE '%BAJA%' AND IDSTATUS NOT LIKE '%EGR%' " & _
        "order by IDCAMPUS,IDLICENCIATURA,IDESPECIALIDAD,IDSEMESTRE,IDGRUPO,APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        Grid.DataSource = ds.Tables(0)
        ToolStripStatusLabel3.Text = Grid.RowCount - 1
    End Sub

    Private Sub generarListado()
        Try
            Grid.Rows.Clear()
            Grid.Columns.Clear()
            variables.conexion.abrirConexion()
            Grid.Columns.Add("MATRICULA", "MATRICULA")
            Grid.Columns.Add("IDCAMPUS", "IDCAMPUS")
            Grid.Columns.Add("APELLIDO_PATERNO", "APELLIDO_PATERNO")
            Grid.Columns.Add("APELLIDO_MATERNO", "APELLIDO_MATERNO")
            Grid.Columns.Add("NOMBRE", "NOMBRE")
            Grid.Columns.Add("IDLICENCIATURA", "IDLICENCIATURA")
            Grid.Columns.Add("IDESPECIALIDAD", "IDESPECIALIDAD")
            Grid.Columns.Add("IDTURNO", "IDTURNO")
            Grid.Columns.Add("IDSEMESTRE", "IDSEMESTRE")
            Grid.Columns.Add("IDGRUPO", "IDGRUPO")
            Grid.Columns.Add("BECA", "BECA")



            Grid.Columns.Item("MATRICULA").Width = 150
            Grid.Columns.Item("MATRICULA").ReadOnly = True

            Grid.Columns.Item("IDCAMPUS").Width = 150
            Grid.Columns.Item("IDCAMPUS").ReadOnly = True

            Grid.Columns.Item("APELLIDO_PATERNO").Width = 200
            Grid.Columns.Item("APELLIDO_PATERNO").ReadOnly = True

            Grid.Columns.Item("APELLIDO_MATERNO").Width = 200
            Grid.Columns.Item("APELLIDO_MATERNO").ReadOnly = True

            Grid.Columns.Item("NOMBRE").Width = 450
            Grid.Columns.Item("NOMBRE").ReadOnly = True

            Grid.Columns.Item("IDLICENCIATURA").Width = 350
            Grid.Columns.Item("IDLICENCIATURA").ReadOnly = True

            Grid.Columns.Item("IDESPECIALIDAD").Width = 350
            Grid.Columns.Item("IDESPECIALIDAD").ReadOnly = True

            Grid.Columns.Item("IDTURNO").Width = 150
            Grid.Columns.Item("IDTURNO").ReadOnly = True

            Grid.Columns.Item("IDSEMESTRE").Width = 200
            Grid.Columns.Item("IDSEMESTRE").ReadOnly = True

            Grid.Columns.Item("IDGRUPO").Width = 200
            Grid.Columns.Item("IDGRUPO").ReadOnly = True

            Grid.Columns.Item("BECA").Width = 200
            Grid.Columns.Item("BECA").ReadOnly = True

            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()

        End Try
        'estadisticasImprFrm.ReportViewer1.RefreshReport()
    End Sub

    Private Sub insertaRow()
        'insertaRow(ByVal i As Integer, ByVal grupo As String, ByVal dato As String, ByVal campus As String)
        variables.sql = "SELECT MATRICULA, IDCAMPUS, APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE, IDturno, IDSEMESTRE, IDLICENCIATURA,IDESPECIALIDAD, IDSEMESTRE, IDGRUPO, BECA FROM ALUMNO"

        'variables.sql = "SELECT COUNT(matricula) from alumno" & _
        '" WHERE (IDLICENCIATURA LIKE '%" + dato + "%') AND (genero='H') AND (idsemestre=" & i & ") AND(idgrupo='" + grupo + "') AND (idcampus='" + campus + "')"
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        Dim nH As Integer = CInt(cmd.ExecuteScalar())


        variables.sql = "select " & _
                   "MATRICULA, IDCAMPUS, APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE, IDturno, IDSEMESTRE, IDLICENCIATURA,IDESPECIALIDAD, IDSEMESTRE, IDGRUPO, BECA " & _
                   "order by apellido_paterno,apellido_materno, nombre, idcampus"
        'variables.sql = "SELECT COUNT(matricula) from alumno WHERE (IDLICENCIATURA LIKE '%" + dato + "%') AND (genero='M') AND (idsemestre=" & i & ") AND(idgrupo='" + grupo + "') AND (idcampus='" + campus + "')"
        cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
        Dim nM = CInt(cmd.ExecuteScalar())
        'Grid.Rows.Add(campus, "2010-2012", i, grupo, dato, " ", nH, nM, nH + nM)
    End Sub

    Private Sub cmbCampus_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCampus.DropDown
        Dim ds As New DataSet
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
    End Sub

    Private Sub cmbLicenciatura_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLicenciatura.DropDown
        Dim ds As New DataSet
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "idLicenciatura", "licenciatura")
    End Sub

    Private Sub cmbEspecialidad_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecialidad.DropDown
        Dim ds As New DataSet
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "idEspecialidad", "especialidad")
    End Sub

    Private Sub cmbSemestre_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSemestre.DropDown
        Dim ds As New DataSet
        ds = getGrados()
        loadComboBox(ds, cmbSemestre, "IDSEMESTRE", "grado")
    End Sub

    Private Sub cmbGrupo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo.DropDown
        Dim ds As New DataSet
        ds = getGrupos()
        loadComboBox(ds, cmbGrupo, "nombre", "nombre")
    End Sub


    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        becadoImprFrm.Text = "BECADOS"

        becadoImprFrm.ShowDialog()
        becadoImprFrm.ReportViewer1.Refresh()
    End Sub

    Private Sub cmbTipoBeca_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoBeca.DropDown
        Dim ds As New DataSet
        ds = getTiposBecas()
        loadComboBox(ds, cmbTipoBeca, "id", "descripcion")
    End Sub
End Class