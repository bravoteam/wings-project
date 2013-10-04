Imports datosCompartidos.Datos
Imports datosCompartidos.funciones

Public Class Calificacion

    Dim IDLICE, IDESPE, IDmat As Integer
    Dim CARGANDO As Boolean = False
    Dim clavesMaterias(50) As Integer

    Private Sub checar_fechas_parciales()
        'checar fechas
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        Dim materias As New List(Of String)
        Dim i, j, bandera, colCh As Integer
        Dim aux As String = ""
        Dim cs1 As New DataGridViewCheckBoxColumn
        bandera = 0
        colCh = 0
        Try
            DG.Rows.Clear()
            DG.Columns.Clear()

            If comboMaterias.Text = "" Then
                sql = "select " & _
                "C.idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
                "m.IDMATERIA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.asistenciaP1, c.asistenciaP2,m.TIPOCHECK,a.idalumno " & _
                "from alumno a " & _
                "inner join calificaciones c on c.Matricula = a.MATRICULA " & _
                "inner join materias m on m.IDMATERIA = c.IDMATERIA " & _
                "where a.IDCAMPUS = '" & cmbCampus.Text & "' and a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
                "and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' " & _
                "and a.IDSEMESTRE = '" & cmbSemestre.Text & "' and a.IDGRUPO = '" & cmbGrupo.Text & "' " & _
                "and c.IDSEMESTRE='" & cmbSemestre.Text & "' and c.idgrupo='" & cmbGrupo.Text & "' and a.idstatus<>'EGRESADO' and a.IDSTATUS NOT LIKE '%BAJA%' " & _
                "AND c.idlicenciatura='" & cmbLicenciatura.SelectedValue & "'" & _
                "and M.activa=1  " & _
                "group by a.MATRICULA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.asistenciaP1, c.asistenciaP2 , m.TIPOCHECK, m.IDMATERIA, " & _
                " a.apellido_paterno, a.apellido_materno, a.nombre,C.idcalificacion " & _
                "order by a.apellido_paterno,a.apellido_materno, a.nombre, m.TIPOCHECK desc, m.IDMATERIA"
            Else
                sql = "select " & _
                "C.idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
                "m.IDMATERIA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.asistenciaP1, c.asistenciaP2,m.TIPOCHECK " & _
                "from alumno a " & _
                "inner join calificaciones c on c.Matricula = a.MATRICULA " & _
                "inner join materias m on m.IDMATERIA = c.IDMATERIA " & _
                "where a.IDCAMPUS = '" & cmbCampus.Text & "' and a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
                "and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' " & _
                "and a.IDSEMESTRE = '" & cmbSemestre.Text & "' and a.IDGRUPO = '" & cmbGrupo.Text & "' " & _
                "and c.IDSEMESTRE='" & cmbSemestre.Text & "' and c.idmateria=" & Val(comboMaterias.SelectedValue) & " " & _
                "AND c.idlicenciatura='" & cmbLicenciatura.SelectedValue & "'" & _
                "and M.activa=1 and c.idgrupo='" & cmbGrupo.Text & "' and a.idstatus<>'EGRESADO' and a.IDSTATUS NOT LIKE '%BAJA%' " & _
                "group by a.MATRICULA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.asistenciaP1, c.asistenciaP2 , m.TIPOCHECK, m.IDMATERIA, " & _
                " a.apellido_paterno, a.apellido_materno, a.nombre,C.idcalificacion " & _
                "order by a.apellido_paterno,a.apellido_materno, a.nombre, m.TIPOCHECK desc, m.IDMATERIA"
                bandera = 1
            End If
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count <= 0 Then ' SI NO TRAE REGISTROS SE GENERAN LAS CALIFICACIONES
                MsgBox("NO EXISTEN DATOS, GENERANDO REGISTROS")
                If comboMaterias.Text = "" Then
                    sql = "select 0 as idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
                    "m.IDMATERIA, m.NOMBRE, 0 as calificacion,0 as calificacion2,0 as asistenciaP1,0 as asistenciaP2,m.TIPOCHECK " & _
                    "from alumno a,materias m  " & _
                    "where (a.IDCAMPUS = '" & cmbCampus.Text & "' and " & _
                    "a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
                    "and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' and " & _
                    "a.IDSEMESTRE = '" & cmbSemestre.Text & "' and a.IDGRUPO = '" & cmbGrupo.Text & "' AND IDSTATUS NOT LIKE '%BAJA%' and IDSTATUS<>'EGRESADO') " & _
                    "and (m.ACTIVA=1 and m.IDSEMESTRE='" & cmbSemestre.Text & "' and m.IDCARRERA='" & cmbLicenciatura.SelectedValue & "' " & _
                    "and m.IDESPECIALIDAD=" & Val(cmbEspecialidad.SelectedValue) & " or m.idmateria=1232 or m.idmateria=1233) " & _
                    "group by a.MATRICULA,a.apellido_paterno, a.apellido_materno, a.nombre," & _
                    "a.IDSTATUS,m.IDMATERIA,m.NOMBRE,m.TIPOCHECK,a.IDGRUPO,a.IDLICENCIATURA,a.IDSEMESTRE " & _
                    "order by a.apellido_paterno,a.apellido_materno, a.nombre,m.TIPOCHECK desc, m.NOMBRE"
                Else
                    sql = "select " & _
                    " 0 as idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
                    "m.IDMATERIA, m.NOMBRE,  0 as calificacion,0 as calificacion2,0 as asistenciaP1,0 as asistenciaP2,m.TIPOCHECK " & _
                    "from alumno a " & _
                    "inner join calificaciones c on c.Matricula = a.MATRICULA " & _
                    "inner join materias m on m.IDMATERIA = c.IDMATERIA " & _
                    "where a.IDCAMPUS = '" & cmbCampus.Text & "' and a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
                    "and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' and " & _
                    "a.IDSEMESTRE = '" & cmbSemestre.Text & "' and a.IDGRUPO = '" & cmbGrupo.Text & "' " & _
                    "and c.IDSEMESTRE='" & cmbSemestre.Text & "' and c.idmateria=" & Val(comboMaterias.SelectedValue) & " " & _
                    "AND c.idlicenciatura='" & cmbLicenciatura.SelectedValue & "'" & _
                    "and M.activa=1 and c.idgrupo='" & cmbGrupo.Text & "' " & _
                    "group by a.MATRICULA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.asistenciaP1, c.asistenciaP2 , m.TIPOCHECK, m.IDMATERIA, " & _
                    " a.apellido_paterno, a.apellido_materno, a.nombre,C.idcalificacion " & _
                    "order by a.apellido_paterno,a.apellido_materno, a.nombre, m.TIPOCHECK desc, m.IDMATERIA"

                    sql = "select  0 as idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
                        "m.IDMATERIA, m.NOMBRE,  0 as calificacion,0 as calificacion2,0 as asistenciaP1,0 as asistenciaP2," & _
                        "m.TIPOCHECK from alumno a,materias m " & _
                        "where a.IDCAMPUS = '" & cmbCampus.Text & "' and a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
                        "and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' and " & _
                        "a.IDSEMESTRE = '" & cmbSemestre.Text & "' and a.IDGRUPO = '" & cmbGrupo.Text & "' and a.IDSTATUS<>'EGRESADO' and a.IDSTATUS NOT LIKE '%BAJA%' " & _
                        "and  M.activa=1 and m.idmateria=" & Val(comboMaterias.SelectedValue) & " " & _
                        "group by a.MATRICULA, m.NOMBRE, m.TIPOCHECK, m.IDMATERIA, a.apellido_paterno, a.apellido_materno, a.nombre " & _
                        "order by a.apellido_paterno,a.apellido_materno, a.nombre, m.TIPOCHECK desc, m.IDMATERIA"
                End If
                b.abrirConexion()
                ds = b.getDataSet(sql)
                b.cerrarConexion()
                DG.Columns.Add("IDCALIFICACION", "IDCALIFICACION") '0
                DG.Columns.Add("MATRICULA", "MATRICULA") '1
                DG.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO") '2
                DG.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO") '3
                DG.Columns.Add("NOMBRE", "NOMBRES") '4
                DG.Columns.Add("IDMATERIA", "IDMATERIA") '5
                DG.Columns.Add("MATERIA", "MATERIA") '6
                DG.Columns.Add("CALIFICACION1P", "CALIFICACION1P") '7
                DG.Columns.Add("CALIFICACION2P", "CALIFICACION2P") '8


                DG.Columns.Add("PORCENTAJE1P", "PORCENTAJE1P") '9
                DG.Columns.Add("PORCENTAJE2P", "PORCENTAJE2P") '10
                DG.Columns.Add("TIPOCHECK", "TIPOCHECK") '11

                DG.Columns.Item("MATRICULA").Width = 80
                DG.Columns.Item("MATRICULA").ReadOnly = True

                DG.Columns.Item("APELLIDO_PATERNO").Width = 70
                DG.Columns.Item("APELLIDO_PATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_PATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("APELLIDO_MATERNO").Width = 70
                DG.Columns.Item("APELLIDO_MATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_MATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("NOMBRE").Width = 100
                DG.Columns.Item("NOMBRE").ReadOnly = True
                DG.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("IDMATERIA").Width = 100
                DG.Columns.Item("IDMATERIA").ReadOnly = True
                DG.Columns.Item("IDMATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("MATERIA").Width = 200
                DG.Columns.Item("MATERIA").ReadOnly = True
                DG.Columns.Item("MATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Rows.Add(ds.Tables(0).Rows.Count)
                i = 0
                j = 0
                For Each f As DataRow In ds.Tables(0).Rows
                    For Each c As DataColumn In ds.Tables(0).Columns
                        DG(j, i).Value = f(c).ToString
                        j += 1
                        If j > ds.Tables(0).Columns.Count - 1 Then j = 0
                    Next
                    i += 1
                Next
            Else
                'materias
                For Each f As DataRow In ds.Tables(0).Rows
                    If aux <> f("nombre").ToString And Not (materias.Contains(f("nombre"))) Then
                        aux = f("nombre").ToString
                        materias.Add(aux)
                    End If
                Next
                DG.Columns.Add("IDCALIFICACION", "IDCALIFICACION") '0
                DG.Columns.Add("MATRICULA", "MATRICULA") '1
                DG.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO") '2
                DG.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO") '3
                DG.Columns.Add("NOMBRE", "NOMBRES") '4
                DG.Columns.Add("IDMATERIA", "IDMATERIA") '5
                DG.Columns.Add("MATERIA", "MATERIA") '6
                DG.Columns.Add("CALIFICACION1P", "CALIFICACION1P") '7
                DG.Columns.Add("CALIFICACION2P", "CALIFICACION2P") '8
                DG.Columns.Add("PORCENTAJE1P", "PORCENTAJE1P") '9
                DG.Columns.Add("PORCENTAJE2P", "PORCENTAJE2P") '10
                DG.Columns.Add("TIPOCHECK", "TIPOCHECK") '11


                DG.Columns.Item("MATRICULA").Width = 80
                DG.Columns.Item("MATRICULA").ReadOnly = True

                DG.Columns.Item("APELLIDO_PATERNO").Width = 70
                DG.Columns.Item("APELLIDO_PATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_PATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("APELLIDO_MATERNO").Width = 70
                DG.Columns.Item("APELLIDO_MATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_MATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("NOMBRE").Width = 100
                DG.Columns.Item("NOMBRE").ReadOnly = True
                DG.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("IDMATERIA").Width = 100
                DG.Columns.Item("IDMATERIA").ReadOnly = True
                DG.Columns.Item("IDMATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Columns.Item("MATERIA").Width = 200
                DG.Columns.Item("MATERIA").ReadOnly = True
                DG.Columns.Item("MATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                DG.Rows.Add(ds.Tables(0).Rows.Count)
                i = 0
                j = 0
                For Each f As DataRow In ds.Tables(0).Rows
                    For Each c As DataColumn In ds.Tables(0).Columns
                        DG(j, i).Value = f(c).ToString
                        j += 1
                        If j > ds.Tables(0).Columns.Count - 1 Then j = 0
                    Next
                    i += 1
                Next
            End If


                DG.Columns(0).Visible = True
            DG.Columns(5).Visible = False
            DG.Columns(11).Visible = False
                If cmbParcial.Text = "PRIMERA PARCIAL" Then
                    DG.Columns.Item("CALIFICACION2P").Visible = False
                    DG.Columns.Item("PORCENTAJE2P").Visible = False
                End If
                If cmbParcial.Text = "SEGUNDA PARCIAL" Then
                    DG.Columns.Item("CALIFICACION1P").Visible = False
                    DG.Columns.Item("PORCENTAJE1P").Visible = False
                End If

                If bandera = 1 Then
                    DG.Columns(6).Visible = False
                Else
                    DG.Columns(6).Visible = True
                End If
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub ActualizarCalificaciones()
        'Try
        SQLConn.ConnectionString = CadenaConexion 'Set the Connection String++
        SQLConn.Open() 'Open the connection
        SQLCmd.Connection = SQLConn 'Sets the Connection to use with the SQL Command
        Dim contX As Integer = 0
        Dim idCalif As Integer = 0
        Dim cal, cal2 As Double
        Dim P1, P2, cicloEscolar, matricula As String
        Dim idEspecialidad As Integer = 0
        cicloEscolar = obtenerCicloActual()
        For i = 0 To DG.RowCount - 2
            cal = 0
            cal2 = 0
            idCalif = Val(DG(0, i).Value)
            matricula = DG(1, i).Value
            IDmat = Val(DG(5, i).Value)
            If DG(7, i).Value = "" Then
                DG(7, i).Value = 0
            End If
            cal = DG(7, i).Value
            If DG(8, i).Value = "" Then
                DG(8, i).Value = 0
            End If
            cal2 = DG(8, i).Value
            P1 = DG(9, i).Value
            P2 = DG(10, i).Value

            If cmbEspecialidad.Text = "" Then
                idEspecialidad = 0
            Else
                idEspecialidad = cmbEspecialidad.SelectedValue
            End If

            'Actualiza las calificaciones
            If idCalif > 0 Then
                SQLCmd.CommandText = "UPDATE calificaciones SET CALIFICACION = " & cal & ",calificacion2=" & cal2 & ", " & _
                    "asistenciaP1='" & P1 & "',asistenciaP2='" & P2 & "',IDCICLOESCOLAR='" & cicloEscolar & "',IDESPECIALIDAD=" & idEspecialidad & ",estado='' " & _
                    "WHERE IDCALIFICACION = " & idCalif & " "
                SQLCmd.ExecuteNonQuery()
            Else
                SQLCmd.CommandText = "INSERT INTO calificaciones(matricula,idmaestro,idmateria,calificacion," & _
                    "idparcial,idsemestre,idlicenciatura,idcicloescolar,idgrupo,calificacion2,asistenciaP1,asistenciaP2,IDESPECIALIDAD,estado)" & _
                    "VALUES('" & matricula & "',1," & IDmat & "," & cal & ",1," & Val(cmbSemestre.Text) & "," & _
                    "" & Val(cmbLicenciatura.SelectedValue) & ",'" & cicloEscolar & "','" & cmbGrupo.Text & "'," & cal2 & "," & _
                    "'" & P1 & "','" & P2 & "'," & idEspecialidad & ",'')"
                SQLCmd.ExecuteNonQuery()
            End If

        Next
        SQLConn.Close()
        MsgBox("GUARDADO CON ÉXITO", MsgBoxStyle.Information)
        ' Catch
        'MsgBox("ERROR VERIFIQUE LOS DATOS ", MsgBoxStyle.Critical)
        'Exit Sub
        ' End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        ActualizarCalificaciones()
        Button2.Enabled = True
        'Call Button1_Click(sender, e)
        DG.Rows.Clear()
        comboMaterias.DataSource = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        variables.campus = cmbCampus.Text
        variables.licenciatura = cmbLicenciatura.Text
        variables.IdLice = cmbLicenciatura.SelectedValue
        variables.turno = cmbTurno.Text
        variables.grupo = cmbGrupo.Text
        variables.matricula = DG(1, DG.CurrentCell.RowIndex).Value.ToString
        variables.semestre = cmbSemestre.Text
        variables.especialidad = cmbEspecialidad.Text
        variables.param = 1
        variables.ciclo = obtenerCicloActual()
        variables.usaFecha = 0
        imprimirBoleta.Show()
    End Sub
    Private Sub growdatagrid()
        DG.Height = Me.Height - 145
        DG.Width = Me.Width - 18
    End Sub
    'Private Sub cargar_formulario()
    'checar fechas
    '    SQLSTR = "Select fecha_1parcial,fecha_2parcial,fecha_1parcial_cierre,fecha_2parcial_cierre,fecha_actualsistema from candado"
    '    SQLCmd.CommandText = SQLSTR
    '    SQLdr = SQLCmd.ExecuteReader
    '    While SQLdr.Read() 'While Data is Present
    'Dim fechaActual As Date
    '        fechaActual = Format(Now.Date)
    '        If fechaActual >= SQLdr("fecha_1parcial").ToString And fechaActual <= SQLdr("fecha_1parcial_cierre").ToString Then
    '            LBL_PARCIAL.Text = "1 PARCIAL"
    '        End If
    '        If fechaActual >= SQLdr("fecha_2parcial").ToString And fechaActual <= SQLdr("fecha_2parcial_cierre").ToString Then
    '            LBL_PARCIAL.Text = "2 PARCIAL"
    '        End If
    '    End While
    '    SQLdr.Close()

    'End Sub
    
    Private Sub Calificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
again:
            growdatagrid() 'crecer el datagrid al tamaño del formulario



            Dim Conf As New Configuracion
            Dim Ignition As String = Conf.getIgnition()

            CadenaConexion = "Data Source=" + Ignition.Split("|")(0) + "; " +
                                    "Initial Catalog=" + Ignition.Split("|")(1) + "; " +
                                    "User ID=" + Ignition.Split("|")(2) + "; " +
                                    "Password=" + Ignition.Split("|")(3)

            SQLConn.ConnectionString = CadenaConexion

            'SQLConn.Open() 'Open the connection
            'SQLCmd.Connection = SQLConn 'Sets the Connection to use with the SQL Command
            'cargar_formulario() ' inicializa los componentes en el formulario
            'cargar_combos() ' rellena los combos con datos
            'SQLdr.Close() ' cierra conexion del query
            ' SQLConn.Close() 'cierra la conexion a la base de datos
        Catch ex As Exception
            MsgBox("Error No se puede conectar a la BD " & vbCrLf & ex.Message.ToString, vbInformation)
            Dim a As String = MsgBox("¿Deseas Reintentar La Conexion?", vbYesNo)
            If a = vbYes Then
                GoTo again
            End If
        End Try
    End Sub


    Private Sub ComboBox1_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboMaterias.DropDown
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        Dim materias As New List(Of String)
        Dim i, j As Integer
        Dim aux As String = ""

        'sql = "select " & _
        '"DISTINCT(m.NOMBRE) as nombre,m.idmateria,M.TIPOCHECK " & _
        '"from alumno a " & _
        '"inner join calificaciones c on c.Matricula = a.MATRICULA " & _
        '"inner join materias m on m.IDMATERIA = c.IDMATERIA " & _
        '"where a.IDCAMPUS = '" & cmbCampus.Text & "' and a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
        '"and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' " & _
        '"and a.IDSEMESTRE = '" & cmbSemestre.Text & "' and a.IDGRUPO = '" & cmbGrupo.Text & "' " & _
        '"and c.IDSEMESTRE='" & cmbSemestre.Text & "' " & _
        '"and M.activa=1 " & _
        '"group by a.MATRICULA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.asistenciaP1, c.asistenciaP2 , m.TIPOCHECK, m.IDMATERIA, " & _
        '" a.apellido_paterno, a.apellido_materno, a.nombre,C.idcalificacion " & _
        '"order by m.TIPOCHECK desc"

        sql = "select * from materias where IDCARRERA=" & Val(cmbLicenciatura.SelectedValue) & " " & _
                "and ACTIVA=1 and IDSEMESTRE='" & cmbSemestre.Text & "' " & _
                "and IDESPECIALIDAD=" & Val(cmbEspecialidad.SelectedValue) & " or idmateria=1232 or idmateria=1233 or idmateria=1278 or idmateria=1279 " & _
                "order by TIPOCHECK desc,NOMBRE"
        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()

            'se carga el combo
        loadComboBox(ds, comboMaterias, "idmateria", "nombre")
    End Sub

    Private Sub cmbLicenciatura_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLicenciatura.DropDown
        Dim ds As New DataSet
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "idLicenciatura", "licenciatura")
    End Sub

    Private Sub cmbEspecialidad_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbEspecialidad.DropDown
        Dim ds As New DataSet
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "idEspecialidad", "especialidad")
    End Sub

    Private Sub cmbCampus_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbCampus.DropDown
        Dim ds As New DataSet
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
    End Sub

    Private Sub cmbSemestre_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbSemestre.DropDown
        Dim ds As New DataSet
        ds = getGrados()
        loadComboBox(ds, cmbSemestre, "IDSEMESTRE", "grado")
    End Sub

    Private Sub cmbGrupo_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbGrupo.DropDown
        Dim ds As New DataSet
        ds = getGrupos()
        loadComboBox(ds, cmbGrupo, "nombre", "nombre")
    End Sub

    Private Sub DG_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellContentClick

    End Sub

    Private Sub cmbLicenciatura_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbLicenciatura.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmbEspecialidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbEspecialidad.SelectedIndexChanged

    End Sub

    Private Sub DG_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub
    ' evento Keypress  
    ' '''''''''''''''''''  
    Private Sub validar_Keypress( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = DG.CurrentCell.ColumnIndex

        ' comprobar si la celda en edición corresponde a la columna 1 o 3  
        If columna = 7 Or columna = 8 Or columna = 9 Or columna = 10 Then

            ' Obtener caracter  
            Dim caracter As Char = e.KeyChar

            ' comprobar si el caracter es un número o el retroceso  
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar  
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub
End Class