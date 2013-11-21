Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class calificacionMaestroFrm
    Dim columna As Integer = 0
    Dim celda As Integer = 0
    Private Sub calificacionMaestroFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim fechaAbierta, fechaCierre, fechaServer As Date
        variables.conexion.abrirConexion()
        variables.sql = "select fecha,cierre,parcial, GETDATE() as fechaServer from candado where tipoAcceso =" & variables.tipoAcceso & ""
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()

        While (variables.SQLdr.Read())
            fechaAbierta = variables.SQLdr("fecha")
            fechaCierre = variables.SQLdr("cierre")
            variables.parcial = Val(variables.SQLdr("parcial"))
            'Se obtiene la fecha del SERVER
            fechaServer = variables.SQLdr("fechaServer")
        End While
        variables.conexion.cerrarConexion()

        If fechaCierre < fechaServer Then
            MsgBox("Sistema de Calificaciones Cerrado!", MsgBoxStyle.Critical)
            cmbObtener.Enabled = False
            cmdGuardar.Enabled = False
        End If
    End Sub
    Private Sub obtenerInformacion(id As Integer)
        variables.conexion.abrirConexion()
        variables.sql = "select cl.semestre,pm.grupo,pm.campus,cl.idLicenciatura, l.NOMBRE as licenciatura ,cl.idEspecialidad, isnull(e.DESCRIPCION,'') as especialidad,p.id as idMaestro " & _
                        "from personal_materia pm inner join personal p on p.id=pm.idpersonal " & _
                        "inner join cicloescolar_licenciatura cl on cl.id=pm.idciclolicenciatura " & _
                        "inner join materias m on m.idmateria=cl.idmateria " & _
                        "inner join licenciaturas l on l.idlicenciatura=cl.idlicenciatura " & _
                        "left join especialidades e on e.IDESPECIALIDAD=cl.idEspecialidad " & _
                        "where(pm.id = " & id & ") "
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()

        While (variables.SQLdr.Read())
            txtCampus.Text = variables.SQLdr("campus").ToString
            txtLicenciatura.Text = variables.SQLdr("licenciatura").ToString
            variables.IdLice = variables.SQLdr("idLicenciatura").ToString
            txtEspecialidad.Text = variables.SQLdr("especialidad").ToString
            variables.idesp = variables.SQLdr("idEspecialidad")
            variables.idMaestro = variables.SQLdr("idMaestro")
            txtSemestre.Text = variables.SQLdr("semestre").ToString
            txtGrupo.Text = variables.SQLdr("grupo").ToString
        End While
    End Sub

    Private Sub comboMaterias_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboMaterias.DropDown
        DG.Rows.Clear()
    End Sub

    Private Sub comboMaterias_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles comboMaterias.SelectedValueChanged
        Dim index As Integer
        index = cmbAux.FindString(comboMaterias.SelectedValue.ToString)
        cmbAux.SelectedIndex = index
        obtenerInformacion(Val(cmbAux.Text))
    End Sub

    Private Sub cmbObtener_Click(sender As System.Object, e As System.EventArgs) Handles cmbObtener.Click
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String = ""
        Dim materias As New List(Of String)
        Dim i, j, bandera, colCh As Integer
        Dim aux As String = ""
        Dim cs1 As New DataGridViewCheckBoxColumn
        bandera = 0
        colCh = 0
        If variables.parcial = 1 Then
            lblParcial.Text = "PRIMERA PARCIAL"
        End If
        If variables.parcial = 2 Then
            lblParcial.Text = "SEGUNDA PARCIAL"
        End If
        If variables.parcial = 3 Then
            lblParcial.Text = "TERCERA PARCIAL"
        End If
        If comboMaterias.Text = "" Then
            MsgBox("Error", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            DG.Rows.Clear()
            DG.Columns.Clear()
            sql = "select " & _
            "C.idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
            "m.IDMATERIA, m.NOMBRE, c.asistenciaP1, c.asistenciaP2,c.asistenciaP3,c.CALIFICACION, c.calificacion2,c.calificacion3,a.idalumno," & variables.idMaestro & " " & _
            "from alumno a " & _
            "inner join calificaciones c on c.Matricula = a.MATRICULA " & _
            "inner join materias m on m.IDMATERIA = c.IDMATERIA " & _
            "where a.IDCAMPUS = '" & txtCampus.Text & "' and a.IDLICENCIATURA = '" & txtLicenciatura.Text & "' " & _
            "and a.IDESPECIALIDAD = '" & txtEspecialidad.Text & "' " & _
            "and a.IDSEMESTRE = '" & txtSemestre.Text & "' and a.IDGRUPO = '" & txtGrupo.Text & "' " & _
            "and c.IDSEMESTRE='" & txtSemestre.Text & "' and c.idmateria=" & Val(cmbAux.SelectedValue) & " " & _
            "AND c.idlicenciatura='" & variables.IdLice & "'" & _
            " and c.idgrupo='" & txtGrupo.Text & "' and a.idstatus<>'EGRESADO' and a.IDSTATUS NOT LIKE '%BAJA%' " & _
            "group by a.MATRICULA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.asistenciaP1, c.asistenciaP2 , m.IDMATERIA, " & _
            " a.apellido_paterno, a.apellido_materno, a.nombre,C.idcalificacion,a.idalumno,calificacion3,asistenciaP3 " & _
            "order by a.apellido_paterno,a.apellido_materno, a.nombre, m.IDMATERIA"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count <= 0 Then ' SI NO TRAE REGISTROS SE GENERAN LAS CALIFICACIONES
                MsgBox("NO EXISTEN DATOS, GENERANDO REGISTROS")

                sql = "select  0 as idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
                    "m.IDMATERIA, m.NOMBRE, 0 as asistenciaP1,0 as asistenciaP2,0 as asistenciaP3, 0 as calificacion,0 as calificacion2,0 as calificacion3," & _
                    "a.idalumno," & variables.idMaestro & "  from alumno a,materias m " & _
                    "where a.IDCAMPUS = '" & txtCampus.Text & "' and a.IDLICENCIATURA = '" & txtLicenciatura.Text & "' " & _
                    "and a.IDESPECIALIDAD = '" & txtEspecialidad.Text & "' and " & _
                    "a.IDSEMESTRE = '" & txtSemestre.Text & "' and a.IDGRUPO = '" & txtGrupo.Text & "' and a.IDSTATUS<>'EGRESADO' and a.IDSTATUS NOT LIKE '%BAJA%' " & _
                    " and m.idmateria=" & Val(cmbAux.SelectedValue) & " " & _
                    "group by a.MATRICULA, m.NOMBRE, m.IDMATERIA, a.apellido_paterno, a.apellido_materno, a.nombre,a.idalumno " & _
                    "order by a.apellido_paterno,a.apellido_materno, a.nombre, m.IDMATERIA"
                b.abrirConexion()
                ds = b.getDataSet(sql)
                b.cerrarConexion()
                DG.Columns.Add("IDCALIFICACION", "ID") '0
                DG.Columns.Add("MATRICULA", "MATRICULA") '1
                DG.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO") '2
                DG.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO") '3
                DG.Columns.Add("NOMBRE", "NOMBRES") '4
                DG.Columns.Add("IDMATERIA", "IDMATERIA") '5
                DG.Columns.Add("MATERIA", "MATERIA") '6


                DG.Columns.Add("PORCENTAJE1P", "PORCENTAJE1P") '7
                DG.Columns.Add("PORCENTAJE2P", "PORCENTAJE2P") '8
                DG.Columns.Add("PORCENTAJE3P", "PORCENTAJE3P") '9
                DG.Columns.Add("CALIFICACION1P", "CALIFICACION1P") '10
                DG.Columns.Add("CALIFICACION2P", "CALIFICACION2P") '11
                DG.Columns.Add("CALIFICACION3P", "CALIFICACION3P") '12



                DG.Columns.Add("IDALUMNO", "IDALUMNO") '13
                DG.Columns.Add("IDMAESTRO", "IDMAESTRO") '14

                'DG.Columns.Item("MATRICULA").Width = 80
                DG.Columns.Item("MATRICULA").ReadOnly = True
                ' DG.Columns.Item("IDCALIFICACION").Width = 40
                DG.Columns.Item("IDCALIFICACION").ReadOnly = True
                ' DG.Columns.Item("IDALUMNO").Width = 40
                DG.Columns.Item("IDALUMNO").ReadOnly = True
                DG.Columns.Item("IDMAESTRO").ReadOnly = True
                ' DG.Columns.Item("APELLIDO_PATERNO").Width = 70
                DG.Columns.Item("APELLIDO_PATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_PATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("APELLIDO_MATERNO").Width = 70
                DG.Columns.Item("APELLIDO_MATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_MATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("NOMBRE").Width = 100
                DG.Columns.Item("NOMBRE").ReadOnly = True
                DG.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("IDMATERIA").Width = 100
                DG.Columns.Item("IDMATERIA").ReadOnly = True
                DG.Columns.Item("IDMATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("MATERIA").Width = 200
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

                DG.Columns.Add("IDCALIFICACION", "ID") '0
                DG.Columns.Add("MATRICULA", "MATRICULA") '1
                DG.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO") '2
                DG.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO") '3
                DG.Columns.Add("NOMBRE", "NOMBRES") '4
                DG.Columns.Add("IDMATERIA", "IDMATERIA") '5
                DG.Columns.Add("MATERIA", "MATERIA") '6

                DG.Columns.Add("PORCENTAJE1P", "PORCENTAJE1P") '7
                DG.Columns.Add("PORCENTAJE2P", "PORCENTAJE2P") '8
                DG.Columns.Add("PORCENTAJE3P", "PORCENTAJE3P") '9
                DG.Columns.Add("CALIFICACION1P", "CALIFICACION1P") '10
                DG.Columns.Add("CALIFICACION2P", "CALIFICACION2P") '11
                DG.Columns.Add("CALIFICACION3P", "CALIFICACION3P") '12





                DG.Columns.Add("IDALUMNO", "IDALUMNO") '13
                DG.Columns.Add("IDMAESTRO", "IDMAESTRO") '14
                'DG.Columns.Item("IDCALIFICACION").Width = 40
                DG.Columns.Item("IDCALIFICACION").ReadOnly = True
                'DG.Columns.Item("MATRICULA").Width = 80
                DG.Columns.Item("MATRICULA").ReadOnly = True
                ' DG.Columns.Item("IDALUMNO").Width = 40
                DG.Columns.Item("IDALUMNO").ReadOnly = True
                DG.Columns.Item("IDMAESTRO").ReadOnly = True
                'DG.Columns.Item("APELLIDO_PATERNO").Width = 70
                DG.Columns.Item("APELLIDO_PATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_PATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("APELLIDO_MATERNO").Width = 70
                DG.Columns.Item("APELLIDO_MATERNO").ReadOnly = True
                DG.Columns.Item("APELLIDO_MATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("NOMBRE").Width = 100
                DG.Columns.Item("NOMBRE").ReadOnly = True
                DG.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("IDMATERIA").Width = 100
                DG.Columns.Item("IDMATERIA").ReadOnly = True
                DG.Columns.Item("IDMATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'DG.Columns.Item("MATERIA").Width = 200
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

            If variables.parcial = 1 Then
                DG.Columns(7).Visible = True
                DG.Columns(8).Visible = False
                DG.Columns(9).Visible = False
                DG.Columns(10).Visible = True
                DG.Columns(11).Visible = False
                DG.Columns(12).Visible = False
            End If
            If variables.parcial = 2 Then
                DG.Columns(7).Visible = False
                DG.Columns(8).Visible = True
                DG.Columns(9).Visible = False
                DG.Columns(10).Visible = False
                DG.Columns(11).Visible = True
                DG.Columns(12).Visible = False
            End If
            If variables.parcial = 3 Then
                DG.Columns(7).Visible = False
                DG.Columns(8).Visible = False
                DG.Columns(9).Visible = True
                DG.Columns(10).Visible = False
                DG.Columns(11).Visible = False
                DG.Columns(12).Visible = True
            End If
            DG.Columns(6).Visible = False
            DG.Columns(5).Visible = False
            DG.Columns(0).Visible = False
            DG.Columns(1).Visible = False
            DG.Columns(13).Visible = False
            DG.Columns(14).Visible = False

            ToolStripStatusLabel3.Text = DG.RowCount
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DG_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellEnter
        habilitar_deshabilitar_celdas()
    End Sub

    Private Sub DG_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellLeave
        Dim columna_actual As Integer = DG.CurrentCell.ColumnIndex
        If columna_actual = 10 Or columna_actual = 11 Or columna_actual = 12 Or columna_actual = 7 Or columna_actual = 8 Or columna_actual = 9 Then 'columna de calificaciones 10,11,12
            columna = DG.CurrentCell.ColumnIndex
            celda = DG.CurrentCell.RowIndex
        End If
       
    End Sub

    Private Sub DG_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DG.CellMouseClick
        habilitar_deshabilitar_celdas()
    End Sub
    Private Sub habilitar_deshabilitar_celdas()
        Dim msg_error As String = ""
        Dim existe_error As Boolean = False
        If columna = 10 Or columna = 11 Or columna = 12 Then 'columna de calificaciones 10,11,12
            'SI LAS CALIFICACIONES SON MAYORES A 10
            If DG.Item(columna, celda).Value > 10 Then
                msg_error = "LAS CALIFICACIONES NO DEBEN SER MAYORES A 10"
                DG.Item(columna, celda).Value = 0
                existe_error = True
            End If
            'SI LOS PORCENTAJES SON MAYORES A 100
            If DG.Item(columna - 3, celda).Value > 100 Then
                msg_error = "LOS PORCENTAJES NO DEBEN SER MAYORES A 100"
                DG.Item(columna - 3, celda).Value = 0
                existe_error = True
            End If

            If Val(DG(columna - 3, celda).Value) < 85 Then
                DG.Item(columna, celda).ReadOnly = True
                DG.Item(columna, celda).Value = 0
            Else
                DG.Item(columna, celda).ReadOnly = False
            End If
            ' SI EXISTE UN ERROR ENTONCES MANDAR MENSAJE DE ALERTA
            If existe_error Then MsgBox(msg_error, MsgBoxStyle.Critical, "ERROR")
            '---------------------
        Else ' sino, si la columna es igual a la de porcentaje 7,8,9
            If columna = 7 Or columna = 8 Or columna = 9 Then

                'verificar que la calificacion no sea mayor a 10
                If DG.Item(columna + 3, celda).Value > 10 Then
                    DG.Item(columna + 3, celda).Value = 0
                    msg_error = "LAS CALIFICACIONES NO DEBEN SER MAYORES A 10"
                    existe_error = True
                End If
                If DG.Item(columna, celda).Value > 100 Then
                    DG.Item(columna, celda).Value = 0
                    msg_error = "LOS PORCENTAJES NO DEBEN SER MAYORES A 100"
                    existe_error = True
                End If
                If Val(DG(columna, celda).Value) < 85 Then
                    DG.Item(columna + 3, celda).ReadOnly = True
                    DG.Item(columna + 3, celda).Value = 0
                Else
                    DG.Item(columna + 3, celda).ReadOnly = False
                End If
                If existe_error Then MsgBox(msg_error, MsgBoxStyle.Critical, "ERROR")
            End If
        End If

    End Sub
    Private Sub DG_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub
    Private Sub validar_Keypress( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = DG.CurrentCell.ColumnIndex
        Dim caracter As Char = e.KeyChar
        ' comprobar si la celda en edición corresponde a la columna 1 o 3  
        If columna = 7 Or columna = 8 Or columna = 9 Or columna = 10 Or columna = 11 Or columna = 12 Then
            ' comprobar si el caracter es un número o el retroceso  
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                e.KeyChar = Chr(0)
            End If
        End If
   

    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        If DG.RowCount <= 0 Then
            MsgBox("No es posible almacenar informacion NO EXISTE!", vbCritical)
            Exit Sub
        Else
            cmdGuardar.Enabled = False
            ActualizarCalificaciones()
            cmdGuardar.Enabled = True
            DG.Rows.Clear()
        End If
    End Sub
    Private Sub ActualizarCalificaciones()
        Try
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""

            Dim contX As Integer = 0
            Dim idCalif As Double = 0
            Dim IDmat As Integer = 0
            Dim cal, cal2, cal3 As Decimal
            Dim P1, P2, P3, cicloEscolar, matricula As String
            Dim idEspecialidad As Integer = 0

            cicloEscolar = obtenerCicloActual()
            variables.ciclo = cicloEscolar
            For i = 0 To DG.RowCount - 1
                cal = 0
                cal2 = 0
                cal3 = 0
                idCalif = Val(DG(0, i).Value)
                matricula = DG(1, i).Value
                IDmat = Val(DG(5, i).Value)
                If DG(10, i).Value = 0 Then
                    DG(10, i).Value = 0
                End If
                cal = DG(10, i).Value
                If DG(11, i).Value = 0 Then
                    DG(11, i).Value = 0
                End If
                cal2 = DG(11, i).Value
                If DG(12, i).Value = 0 Then
                    DG(12, i).Value = 0
                End If
                cal3 = DG(12, i).Value
                P1 = DG(7, i).Value
                P2 = DG(8, i).Value
                P3 = DG(9, i).Value
                variables.idalumno = DG(13, i).Value
                If txtEspecialidad.Text = "" Then
                    idEspecialidad = 0
                Else
                    idEspecialidad = variables.idesp
                End If

                'Actualiza las calificaciones
                If idCalif > 0 Then
                    variables.conexion.abrirConexion()

                    sql = "UPDATE calificaciones SET CALIFICACION = @CALIFICACION,calificacion2=@calificacion2,calificacion3=@calificacion3, " & _
                        "asistenciaP1=@asistenciaP1,asistenciaP2=@asistenciaP2,asistenciaP3=@asistenciaP3,IDCICLOESCOLAR=@IDCICLOESCOLAR," & _
                        "IDESPECIALIDAD=@IDESPECIALIDAD,estado=@estado,usuario=@usuario " & _
                        "WHERE IDCALIFICACION =@IDCALIFICACION"

                    Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                    With cmd
                        .Parameters.AddWithValue("@CALIFICACION", cal)
                        .Parameters.AddWithValue("@calificacion2", cal2)
                        .Parameters.AddWithValue("@calificacion3", cal3)
                        .Parameters.AddWithValue("@asistenciaP1", P1)
                        .Parameters.AddWithValue("@asistenciaP2", P2)
                        .Parameters.AddWithValue("@asistenciaP3", P3)
                        .Parameters.AddWithValue("@IDCICLOESCOLAR", cicloEscolar)
                        .Parameters.AddWithValue("@IDESPECIALIDAD", idEspecialidad)
                        .Parameters.AddWithValue("@estado", "Actualizacion")
                        .Parameters.AddWithValue("@usuario", variables.usuario)
                        .Parameters.AddWithValue("@IDCALIFICACION", idCalif)
                    End With
                    cmd.ExecuteNonQuery()
                Else
                    variables.conexion.abrirConexion()

                    sql = "INSERT INTO calificaciones(matricula,idmaestro,idmateria,calificacion," & _
                        "idparcial,idsemestre,idlicenciatura,idcicloescolar,idgrupo,calificacion2,asistenciaP1,asistenciaP2," & _
                        "IDESPECIALIDAD,estado,calificacion3,asistenciaP3,idAlumno,fecha,usuario)" & _
                        "VALUES(@matricula,@idmaestro,@idmateria,@calificacion," & _
                        "@idparcial,@idsemestre,@idlicenciatura,@idcicloescolar,@idgrupo,@calificacion2,@asistenciaP1,@asistenciaP2," & _
                        "@IDESPECIALIDAD,@estado,@calificacion3,@asistenciaP3,@idAlumno,@fecha,@usuario)"

                    Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                    With cmd
                        .Parameters.AddWithValue("@matricula", matricula)
                        .Parameters.AddWithValue("@idmaestro", variables.idMaestro)
                        .Parameters.AddWithValue("@idmateria", IDmat)
                        .Parameters.AddWithValue("@CALIFICACION", cal)
                        .Parameters.AddWithValue("@idparcial", 1)
                        .Parameters.AddWithValue("@idsemestre", Val(txtSemestre.Text))
                        .Parameters.AddWithValue("@idlicenciatura", Val(variables.IdLice))
                        .Parameters.AddWithValue("@idcicloescolar", cicloEscolar)
                        .Parameters.AddWithValue("@idgrupo", txtGrupo.Text)
                        .Parameters.AddWithValue("@calificacion2", cal2)
                        .Parameters.AddWithValue("@asistenciaP1", P1)
                        .Parameters.AddWithValue("@asistenciaP2", P2)
                        .Parameters.AddWithValue("@IDESPECIALIDAD", idEspecialidad)
                        .Parameters.AddWithValue("@estado", "Insercion")
                        .Parameters.AddWithValue("@calificacion3", cal3)
                        .Parameters.AddWithValue("@asistenciaP3", P3)
                        .Parameters.AddWithValue("@idAlumno", variables.idalumno)
                        .Parameters.AddWithValue("@fecha", Date.Now.Date)
                        .Parameters.AddWithValue("@usuario", variables.usuario)
                    End With
                    cmd.ExecuteNonQuery()
                End If

            Next
            variables.conexion.cerrarConexion()
            MsgBox("GUARDADO CON ÉXITO", MsgBoxStyle.Information)
            actualizarReporte()
        Catch ex As Exception
            MsgBox("ERROR VERIFIQUE LOS DATOS " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public objeto As New ReportViewer
    Private Sub actualizarReporte()

        objeto = ReportViewer1
        calificacionesMaestrosTableAdapter.Fill(reportesDT.calificacionesMaestros, _
                                                    variables.idMaestro, _
                                                    cmbAux.SelectedValue, _
                                                    Convert.ToDecimal(variables.IdLice), _
                                                    variables.idesp, _
                                                    variables.ciclo, _
                                                    txtGrupo.Text, _
                                                    txtSemestre.Text)


        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("SEMESTRE", txtSemestre.Text))
        parameters.Add(New ReportParameter("GRUPO", txtGrupo.Text))
        parameters.Add(New ReportParameter("CICLO", "CICLO ESCOLAR: " & variables.ciclo))
        parameters.Add(New ReportParameter("CAMPUS", txtCampus.Text))
        parameters.Add(New ReportParameter("parcial", variables.parcial))
        parameters.Add(New ReportParameter("LICENCIATURA", txtLicenciatura.Text & " " & txtEspecialidad.Text))
        parameters.Add(New ReportParameter("MAESTRO", variables.nombreUsuario.ToUpper))
        objeto.LocalReport.SetParameters(parameters)

        objeto.RefreshReport()
        pdf()
    End Sub

    Private Sub pdf()
        Dim deviceInfo As String
        'Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim bytes As Byte()
        deviceInfo = "<DeviceInfo>" +
           "<OutputFormat>PDF</OutputFormat>" +
           "  <PageWidth>21.59cm</PageWidth>" +
           "  <PageHeight>27.94cm</PageHeight>" +
           "  <MarginTop>0.5cm</MarginTop>" +
           "  <MarginLeft>0cm</MarginLeft>" +
           "  <MarginRight>0cm</MarginRight>" +
           "  <MarginBottom>0.5cm</MarginBottom>" +
           "</DeviceInfo>"
        Try
            'Inicializar la clase Random  
            Dim Random As New Random()

            ' generar un random entre 1 y 100  
            Dim numero As Integer = Random.Next(1, 100)

            Dim nombreR As String = Mid(comboMaterias.Text, 1, 10) & txtSemestre.Text & txtGrupo.Text & numero
            bytes = objeto.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            objeto.LocalReport.ReportPath = "reporteCalificacionesMaestro.rdlc"

            Dim fs As New FileStream("C:\ISENCO\" & nombreR & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & nombreR & ".pdf")
            fs.Dispose()
            '  If objeto.Created Then
            'objeto.Dispose()
            ' End If

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try

    End Sub

    Private Sub ObtenerCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObtenerCmd.Click
        Dim b As New BaseDatos
        Dim ds As New DataSet
        'Se obtiene las materias
        If Len(comboMaterias.Text) <= 0 Then
            variables.sql = "select pm.id, m.idmateria,m.nombre + '-' + cast(cl.semestre as varchar) + '°' + pm.grupo + '-' + pm.campus + ' ' + l.nombre as nombrestodos " & _
                        "from personal_materia pm inner join personal p on p.id=pm.idpersonal inner join " & _
                        "cicloescolar_licenciatura cl on cl.id=pm.idciclolicenciatura inner join materias m on m.idmateria=cl.idmateria inner join licenciaturas l on l.idlicenciatura=cl.idlicenciatura " & _
                        "where pm.idpersonal=" & variables.personalUser & ""
            b.abrirConexion()
            ds = b.getDataSet(variables.sql)
            b.cerrarConexion()
            loadComboBox(ds, comboMaterias, "id", "nombrestodos")
            loadComboBox(ds, cmbAux, "idmateria", "id")
            obtenerInformacion(cmbAux.SelectedValue)
            DG.Rows.Clear()
            cmdGuardar.Enabled = True
            cmbObtener.Enabled = True
        End If
        Dim index As Integer
        index = cmbAux.FindString(comboMaterias.SelectedValue.ToString)
        cmbAux.SelectedIndex = index
        obtenerInformacion(Val(cmbAux.Text))
    End Sub
End Class