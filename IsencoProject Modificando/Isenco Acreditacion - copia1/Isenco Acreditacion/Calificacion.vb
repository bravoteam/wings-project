Public Class Calificacion

    Dim IDLICE, IDESPE, IDmat As Integer
    Dim CARGANDO As Boolean = False
    Dim clavesMaterias(50) As Integer

    Private Sub checar_fechas_parciales()
        'checar fechas
           End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGANDO = False
        SQLConn.ConnectionString = CadenaConexion
        SQLConn.Open() 'Open the connection
        SQLCmd.Connection = SQLConn 'Sets the Connection to use with the SQL Command
        DG.Rows.Clear()
        DG.Columns.Clear()
        'checar_fechas_parciales()
        'SQLSTR = "Select fecha_1parcial,fecha_2parcial,fecha_1parcial_cierre,fecha_2parcial_cierre,fecha_actualsistema from candado"
        'SQLCmd.CommandText = SQLSTR
        'SQLdr = SQLCmd.ExecuteReader
        'While SQLdr.Read() 'While Data is Present
        '    Dim fechaActual As Date
        '    fechaActual = Format(Now.Date)
        '    If fechaActual >= SQLdr("fecha_1parcial").ToString And fechaActual <= SQLdr("fecha_1parcial_cierre").ToString Then
        '        LBL_PARCIAL.Text = "1 PARCIAL"
        '    End If
        '    If fechaActual >= SQLdr("fecha_2parcial").ToString And fechaActual <= SQLdr("fecha_2parcial_cierre").ToString Then
        '        LBL_PARCIAL.Text = "2 PARCIAL"
        '    End If

        '    If fechaActual >= SQLdr("fecha_1parcial").ToString And fechaActual <= SQLdr("fecha_1parcial_cierre").ToString Or fechaActual >= SQLdr("fecha_2parcial").ToString And fechaActual <= SQLdr("fecha_2parcial_cierre").ToString Then
        '    Else
        '        MsgBox("Estas Fuera del Periodo de Captura de Calificaciones")
        '        LBL_PARCIAL.Text = "Fuera de Tiempo"
        '        SQLConn.Close()
        '        Exit Sub
        '    End If
        'End While
        'SQLdr.Close()

        'se checa que parcial esta activa mediante el candado
        '****************************** COMIENZA A CARGAR LOS DATOS EN EL DATAGRID ************************************
        SQLSTR = " SELECT MATRICULA, NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO " & _
               " FROM alumno WHERE IDCAMPUS='" & cmbCampus.Text & "' AND " & _
               " IDLICENCIATURA='" & cmbLicenciatura.Text & "' AND " & _
               " IDESPECIALIDAD='" & cmbEspecialidad.Text & "' AND " & _
               " IDTURNO='" & cmbTurno.Text & "' AND " & _
               " IDMODALIDAD='" & cmbModalidad.Text & "' AND " & _
               " IDSEMESTRE='" & cmbSemestre.Text & "'AND " & _
               " IDGRUPO='" & cmbGrupo.Text & "'AND " & _
               " IDSTATUS <> 'EGRESADO' AND " & _
               " (IDSTATUS NOT like '%BAJA%') ORDER BY APELLIDO_PATERNO asc, APELLIDO_MATERNO asc,NOMBRE asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        '******************************* SE CONFIGURAN LAS COLUMNAS DE DATOS GENERALES *************************************
        DG.Columns.Add("MATRICULA", "MATRICULA")
        DG.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO")
        DG.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO")
        DG.Columns.Add("NOMBRE", "NOMBRES")

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

        '******************************* SE CARGAN LOS DATOS GENERALES DEL ALUMNO *************************************
        While SQLdr.Read
            DG.Rows.Add()
        End While
        SQLdr.Close()

        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        Dim I As Integer
        I = 0
        While SQLdr.Read() 'While Data is Present
            DG(0, I).Value = (SQLdr("MATRICULA").ToString).ToUpper
            DG(1, I).Value = (SQLdr("APELLIDO_PATERNO").ToString).ToUpper
            DG(2, I).Value = (SQLdr("APELLIDO_MATERNO").ToString).ToUpper
            DG(3, I).Value = (SQLdr("NOMBRE").ToString).ToUpper

            I = I + 1
        End While
        SQLdr.Close()

        '******************************* SE OBTIENE EL INDICE DE LICENCIATURA *************************************
        SQLSTR = " SELECT IDLICENCIATURA FROM LICENCIATURAS WHERE NOMBRE='" & cmbLicenciatura.Text & "' "
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read
            IdLice = SQLdr("IDLICENCIATURA").ToString
        End While
        SQLdr.Close()
        '******************************* SE OBTIENE EL INDICE DE ESPECIALIDAD*************************************
        SQLSTR = " SELECT IDESPECIALIDAD FROM ESPECIALIDADES WHERE DESCRIPCION='" & cmbEspecialidad.Text & "' "
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read
            IDESPE = SQLdr("IDESPECIALIDAD").ToString
        End While
        SQLdr.Close()

        '******************************* SE CARGAN LOS DATOS DE LAS MATERIAS *************************************
        I = 4
        SQLSTR = " SELECT NOMBRE,idmateria FROM MATERIAS WHERE IDCARRERA='" & IDLICE & "' AND IDESPECIALIDAD='" & IDESPE & "' " & _
            " AND IDSEMESTRE='" & cmbSemestre.Text & "' or nombre='servicio social interno'or nombre='actividades culturales y deportivas' ORDER BY idmateria ASC"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data

        Dim cs1 As New DataGridViewCheckBoxColumn
        While SQLdr.Read
            If SQLdr("NOMBRE").ToString = "SERVICIO SOCIAL INTERNO" Or SQLdr("NOMBRE").ToString = "ACTIVIDADES CULTURALES Y DEPORTIVAS" Then
                cs1 = New DataGridViewCheckBoxColumn
                DG.Columns.Add(cs1)
                cs1.Name = SQLdr("NOMBRE").ToString
                cs1.HeaderText = SQLdr("NOMBRE").ToString
            Else
                DG.Columns.Add(SQLdr("NOMBRE").ToString & "1", SQLdr("NOMBRE").ToString)
                DG.Columns.Item(SQLdr("NOMBRE").ToString & "1").Width = 80

                DG.Columns.Add(SQLdr("NOMBRE").ToString & "2", SQLdr("NOMBRE").ToString)
                DG.Columns.Item(SQLdr("NOMBRE").ToString & "2").Width = 80

                Dim STILO = New DataGridViewCellStyle()
                STILO.Format = "N2"
                DG.Columns.Item(SQLdr("NOMBRE").ToString & "1").DefaultCellStyle = STILO
                DG.Columns.Item(SQLdr("NOMBRE").ToString & "2").DefaultCellStyle = STILO
                ''magia
                If LBL_PARCIAL.Text = "2 PARCIAL" Then
                    ' DG.Columns.Item(SQLdr("NOMBRE").ToString & "1").Visible = False
                    DG.Columns.Item(SQLdr("NOMBRE").ToString & "2").Visible = True
                Else
                    DG.Columns.Item(SQLdr("NOMBRE").ToString & "1").Visible = True
                    ' DG.Columns.Item(SQLdr("NOMBRE").ToString & "2").Visible = False
                End If
            End If
            clavesMaterias(I) = SQLdr("idmateria").ToString
            I = I + 1
        End While
        SQLdr.Close()

        '******************************* SE CARGAN LAS CALIFICACIONES CORRESPONDIENTES DEL ALUMNO *************************************
        Dim contX As Integer
        contX = 4
        For I = 0 To DG.RowCount - 2
            For J = 4 To DG.ColumnCount - 1
                IDmat = clavesMaterias(contX)
                SQLSTR = "SELECT CALIFICACION,calificacion2 FROM calificaciones WHERE matricula='" & DG(0, I).Value & "' AND  " & _
                " idmateria='" & IDmat & "' AND idsemestre='" & cmbSemestre.Text & "' AND idlicenciatura='" & IDLICE & "' and idgrupo='" & cmbGrupo.Text & "'"
                SQLCmd.CommandText = SQLSTR 'Sets the SQL String
                SQLdr = SQLCmd.ExecuteReader 'Gets Data
                While SQLdr.Read
                    If DG.Columns.Item(J).Name = "SERVICIO SOCIAL INTERNO" Or DG.Columns.Item(J).Name = "ACTIVIDADES CULTURALES Y DEPORTIVAS" Then
                        If SQLdr("calificacion").ToString = "0" And SQLdr("calificacion2").ToString = "0" Then
                            DG(J, I).Value = False
                        Else
                            DG(J, I).Value = True
                        End If
                    Else
                        DG(J, I).Value = SQLdr("CALIFICACION").ToString
                        J = J + 1
                        DG(J, I).Value = SQLdr("CALIFICACION2").ToString
                    End If
                    contX = contX + 1
                End While
                SQLdr.Close()
            Next
            contX = 4
        Next

        SQLConn.Close()
    End Sub

    Private Sub guardarCal()
        SQLConn.ConnectionString = CadenaConexion 'Set the Connection String++
        SQLConn.Open() 'Open the connection
        SQLCmd.Connection = SQLConn 'Sets the Connection to use with the SQL Command
        Dim contX As Integer
        contX = 4

        For i = 0 To DG.RowCount - 2
            'se quito el delete porque afectaba en las calificaciones de regularizacion
            'SQLCmd.CommandText = "DELETE FROM calificaciones WHERE matricula='" & DG(0, i).Value & "'"
            'SQLCmd.ExecuteNonQuery() 'Gets Data

            For j = 4 To DG.ColumnCount - 1
                IDmat = clavesMaterias(contX)
                'insertar()
                Dim cal, cal2 As Integer
                Select Case (DG(j, i).Value)
                    Case "False"
                        cal = "0"
                    Case "True"
                        cal = "1"
                    Case Else
                        cal = DG(j, i).Value
                        If j + 1 = DG.ColumnCount Then
                        Else
                            If DG(j + 1, i).Value = "" Then
                                cal2 = 0
                            Else
                                cal2 = DG(j + 1, i).Value
                            End If
                            j = j + 1
                        End If
                End Select
                
                'checar que sino existe la materia y el alumno se le cree el registro y sino que lo actualice
                SQLCmd.CommandText = "SELECT MATRICULA FROM CALIFICACIONES WHERE MATRICULA = '" & DG(0, i).Value & "' AND IDMATERIA = '" & IDmat & "' " & _
                                     "AND IDSEMESTRE = '" & cmbSemestre.Text & "' AND IDGRUPO = '" & cmbGrupo.Text & "' AND IDLICENCIATURA = '" & IDLICE & "'"
                SQLdr = SQLCmd.ExecuteReader()
                encontrado = False
                While SQLdr.Read
                    encontrado = True
                End While
                SQLdr.Close()
                If encontrado Then ' si encuentra el registro en la tabla de calificaciones solamente actualiza datos

                    SQLCmd.CommandText = "UPDATE calificaciones SET calificacion = '" & cal & "', calificacion2 = '" & cal2 & "' WHERE matricula = '" & DG(0, i).Value & "'" & _
                                    " and idsemestre = '" & cmbSemestre.Text & "' and idgrupo = '" & cmbGrupo.Text & "' and idmateria =  '" & IDmat & "' and idlicenciatura = '" & IDLICE & "'"
                Else 'sino lo encuentra entonces crea el registro de calificaciones de ese alumno
                    SQLCmd.CommandText = "insert into calificaciones (matricula,idmateria,idparcial,idsemestre,idlicenciatura," & _
                        " idgrupo,calificacion,calificacion2,IDMAESTRO) values ('" & DG(0, i).Value & "','" & IDmat & "','1','" & cmbSemestre.Text & "'," & _
                        "'" & IDLICE & "','" & cmbGrupo.Text & "','" & cal & "','" & cal2 & "','1')"
                End If
                SQLCmd.ExecuteNonQuery() 'Gets Data

                contX = contX + 1
            Next
            contX = 4
        Next

        SQLConn.Close()
        MsgBox("GUARDADO CON ÉXITO", MsgBoxStyle.Information)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        guardarCal()
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ImprimirBoleta.Show()
        ' AltadeCalificacion_Imprimir.Show()
    End Sub
    Private Sub growdatagrid()
        DG.Height = Me.Height - 145
        DG.Width = Me.Width - 18
    End Sub
    Private Sub cargar_formulario()
        'checar fechas
        SQLSTR = "Select fecha_1parcial,fecha_2parcial,fecha_1parcial_cierre,fecha_2parcial_cierre,fecha_actualsistema from candado"
        SQLCmd.CommandText = SQLSTR
        SQLdr = SQLCmd.ExecuteReader
        While SQLdr.Read() 'While Data is Present
            Dim fechaActual As Date
            fechaActual = Format(Now.Date)
            If fechaActual >= SQLdr("fecha_1parcial").ToString And fechaActual <= SQLdr("fecha_1parcial_cierre").ToString Then
                LBL_PARCIAL.Text = "1 PARCIAL"
            End If
            If fechaActual >= SQLdr("fecha_2parcial").ToString And fechaActual <= SQLdr("fecha_2parcial_cierre").ToString Then
                LBL_PARCIAL.Text = "2 PARCIAL"
            End If
        End While
        SQLdr.Close()

    End Sub
    Private Sub cargar_combos()
        SQLSTR = " SELECT IDCAMPUS FROM alumno GROUP BY IDCAMPUS ORDER BY IDCAMPUS asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read() 'While Data is Present
            cmbCampus.Items.Add((SQLdr("IDCAMPUS").ToString).ToUpper)
        End While
        SQLdr.Close()

        SQLSTR = " SELECT IDLICENCIATURA FROM alumno GROUP BY IDLICENCIATURA ORDER BY IDLICENCIATURA asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read() 'While Data is Present
            cmbLicenciatura.Items.Add((SQLdr("IDlicenciatura").ToString).ToUpper)
        End While
        SQLdr.Close()

        SQLSTR = " SELECT IDESPECIALIDAD FROM alumno GROUP BY IDESPECIALIDAD ORDER BY IDESPECIALIDAD asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read() 'While Data is Present
            cmbEspecialidad.Items.Add((SQLdr("IDESPECIALIDAD").ToString).ToUpper)
        End While
        SQLdr.Close()

        SQLSTR = " SELECT IDTURNO FROM alumno GROUP BY IDTURNO ORDER BY IDTURNO asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read() 'While Data is Present
            cmbTurno.Items.Add((SQLdr("IDTURNO").ToString).ToUpper)
        End While
        SQLdr.Close()

        SQLSTR = " SELECT IDMODALIDAD FROM alumno GROUP BY IDMODALIDAD ORDER BY IDMODALIDAD asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read() 'While Data is Present
            cmbModalidad.Items.Add((SQLdr("IDMODALIDAD").ToString).ToUpper)
        End While
        SQLdr.Close()

        SQLSTR = "SELECT IDSEMESTRE FROM alumno GROUP BY IDSEMESTRE ORDER BY CAST(IDSEMESTRE AS NUMERIC) asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read() 'While Data is Present
            cmbSemestre.Items.Add((SQLdr("IDSEMESTRE").ToString).ToUpper)
        End While
        SQLdr.Close()

        SQLSTR = " SELECT IDGRUPO FROM alumno GROUP BY IDGRUPO ORDER BY IDGRUPO asc"
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read() 'While Data is Present
            cmbGrupo.Items.Add((SQLdr("IDGRUPO").ToString).ToUpper)
        End While
    End Sub
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

            SQLConn.Open() 'Open the connection
            SQLCmd.Connection = SQLConn 'Sets the Connection to use with the SQL Command
            cargar_formulario() ' inicializa los componentes en el formulario
            cargar_combos() ' rellena los combos con datos
            SQLdr.Close() ' cierra conexion del query
            SQLConn.Close() 'cierra la conexion a la base de datos
        Catch ex As Exception
            MsgBox("Error No se puede conectar a la BD " & vbCrLf & ex.Message.ToString, vbInformation)
            Dim a As String = MsgBox("¿Deseas Reintentar La Conexion?", vbYesNo)
            If a = vbYes Then
                GoTo again
            End If
        End Try
    End Sub


End Class