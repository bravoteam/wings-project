Imports System.Data
Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones


Public Class becados

    Public CAMPUS, LICENCIATURA, ESPECIALIDAD, TURNO, SEMESTRE, GRUPO As String

    Private Sub consultarcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarcmd.Click
        CAMPUS = cmbCampus.Text
        LICENCIATURA = cmbLicenciatura.Text
        ESPECIALIDAD = cmbEspecialidad.Text
        TURNO = cmbTurno.Text
        SEMESTRE = cmbSemestre.Text
        GRUPO = cmbGrupo.Text

        If cmbCampus.Text = "" Then
            MsgBox("SELECCIONAR CAMPUS")
        Else
            If cmbLicenciatura.Text = "" Then
                MsgBox("SELECCIONAR LICENCIATURA")
            Else
                If cmbTurno.Text = "" Then
                    MsgBox("SELECCIONAR TURNO")
                Else
                    If cmbSemestre.Text = "" Then
                        MsgBox("SELECCIONAR SEMESTRE")
                    Else
                        If cmbGrupo.Text = "" Then
                            MsgBox("SELECCIONAR GRUPO")
                        Else
                            If cmbLicenciatura.Text = "EDUCACIÓN SECUNDARIA" Or cmbLicenciatura.Text = "EDUCACIÓN ESPECIAL" Then
                                If cmbEspecialidad.Text = "" Or cmbEspecialidad.Text = "null" Then
                                    MsgBox("SELECCIONAR ESPECIALIDAD")
                                Else
                                    'MsgBox("CON ESPECIALIDAD")
                                    Dim b As New BaseDatos
                                    Dim ds As New DataSet
                                    Dim sql As String = ""
                                    sql = "SELECT MATRICULA, IDCAMPUS, APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE, IDLICENCIATURA,IDESPECIALIDAD,IDTURNO, IDSEMESTRE, IDGRUPO, BECA FROM ALUMNO where (beca <> 'null') and (beca <> ' ') and (IDCAMPUS = '" & CAMPUS & "' ) and (IDLICENCIATURA = '" & LICENCIATURA & "' ) and (IDESPECIALIDAD = '" & ESPECIALIDAD & "' ) and (IDTURNO = '" & TURNO & "' ) and (IDSEMESTRE = '" & SEMESTRE & "' ) and (IDGRUPO = '" & GRUPO & "' ) order by apellido_paterno"
                                    b.abrirConexion()
                                    ds = b.getDataSet(sql)
                                    b.cerrarConexion()
                                    Grid.DataSource = ds.Tables(0)
                                End If
                            Else
                                'MsgBox("SIN ESPECIALIDAD")
                                cmbEspecialidad.Text = " "
                                Dim b As New BaseDatos
                                Dim ds As New DataSet
                                Dim sql As String = ""
                                'Dim cnn As New SqlConnection("Data Source=localhost;Initial Catalog=isenco;Integrated Security=SSPI;")
                                'Dim da As New SqlDataAdapter("SELECT MATRICULA, IDCAMPUS, APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE, IDLICENCIATURA,IDESPECIALIDAD,IDTURNO, IDSEMESTRE, IDGRUPO, BECA FROM ALUMNO where (beca <> 'null') and (beca <> ' ') and (IDCAMPUS = '" & CAMPUS & "' ) and (IDLICENCIATURA = '" & LICENCIATURA & "' ) and (IDTURNO = '" & TURNO & "' ) and (IDSEMESTRE = '" & SEMESTRE & "' ) and (IDGRUPO = '" & GRUPO & "' )", cnn)
                                'Dim ds As New DataSet
                                sql = "SELECT MATRICULA, IDCAMPUS, APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRE, IDLICENCIATURA,IDESPECIALIDAD,IDTURNO, IDSEMESTRE, IDGRUPO, BECA FROM ALUMNO where (beca <> 'null') and (beca <> ' ') and (IDCAMPUS = '" & CAMPUS & "' ) and (IDLICENCIATURA = '" & LICENCIATURA & "' ) and (IDTURNO = '" & TURNO & "' ) and (IDSEMESTRE = '" & SEMESTRE & "' ) and (IDGRUPO = '" & GRUPO & "' ) order by apellido_paterno"
                                b.abrirConexion()
                                ds = b.getDataSet(sql)
                                b.cerrarConexion()
                                Grid.DataSource = ds.Tables(0)
                            End If
                        End If
                    End If
                End If
                End If
            End If
     





        'generarListado()
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
        becadoImprFrm.TextBox1.Text = cmbCampus.Text
        becadoImprFrm.TextBox2.Text = cmbLicenciatura.Text
        becadoImprFrm.TextBox3.Text = cmbEspecialidad.Text
        becadoImprFrm.TextBox4.Text = cmbTurno.Text
        becadoImprFrm.TextBox5.Text = cmbSemestre.Text
        becadoImprFrm.TextBox6.Text = cmbGrupo.Text

        becadoImprFrm.ShowDialog()
        becadoImprFrm.ReportViewer1.Refresh()
    End Sub
End Class