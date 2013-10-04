Imports System.Data.SqlClient
Imports datosCompartidos.funciones

Public Class modificacionCalifFrm
    Private Sub txtmatricula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmatricula.KeyPress
        Dim contador As Integer = 0
        If e.KeyChar = Chr(13) Then
            contador = revisarLicenciaturas(txtmatricula.Text)
            If contador = 0 Then
                MsgBox("Error no hay calificaciones", vbCritical)
                Exit Sub
            End If
            If contador = 1 Then
                generarConsultaPrincipal(1)
            Else
                Panel1.Visible = True
                MsgBox("Debes Elegir la Licenciatura", vbInformation)
            End If
        End If
    End Sub
    Private Function revisarLicenciaturas(matricula As String) As String
        Dim numero As Integer = 0
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select distinct(IDLICENCIATURA) from calificaciones where matricula='" & matricula & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While variables.SQLdr.Read
                numero = numero + 1
            End While
            If numero > 1 Then
                Dim ds As New DataSet
                ds = getLicenciaturas()
                loadComboBox(ds, cmdLicenciatura, "IDLICENCIATURA", "licenciatura")
            End If
            variables.SQLdr.Close()
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
        Return numero
    End Function
    Public Sub generarConsultaPrincipal(idTipo As Integer)
        Try
            Dim modelo As modelos.modeloAlumno
            Grid.Rows.Clear()
            Grid.Columns.Clear()
            variables.conexion.abrirConexion()
            modelo = funcionesLocales.traerAlumno(txtmatricula.Text)
            If modelo.IDALUMNO <> 0 Then
                lblnombre.Text = modelo.NOMBRE & " " & modelo.APELLIDO_PATERNO & " " & modelo.APELLIDO_MATERNO
                generaGrid()
            Else
                MsgBox("El Alumno No Existe", MsgBoxStyle.Critical)
                lblnombre.Text = ""
                Exit Sub
            End If
            variables.conexion.cerrarConexion()
            variables.conexion.abrirConexion()
            If idTipo = 1 Then
                variables.sql = "select C.idcalificacion, c.Matricula,c.IDSEMESTRE,c.IDMATERIA,m.NOMBRE,c.CALIFICACION," & _
                            "c.calificacion2,c.IDCICLOESCOLAR,c.extra1,c.extra1_fecha,c.extra2,c.extra2_fecha,c.extra3,c.extra3_fecha,c.idlicenciatura,a.idcampus," & _
                            "c.idgrupo,c.idlicenciatura,a.idlicenciatura as lice,a.idespecialidad as espe,S.descripcion,S.id " & _
                            "from calificaciones c inner join materias m on c.IDMATERIA=m.IDMATERIA " & _
                            "INNER JOIN alumno a on a.matricula=c.matricula " & _
                            "INNER JOIN status_calificaciones S on S.id=c.idStatus " & _
                            "WHERE C.Matricula='" + txtmatricula.Text + "' " & _
                             "ORDER BY C.IDSEMESTRE"
            Else
                variables.sql = "select C.idcalificacion, c.Matricula,c.IDSEMESTRE,c.IDMATERIA,m.NOMBRE,c.CALIFICACION," & _
                            "c.calificacion2,c.IDCICLOESCOLAR ,c.extra1,c.extra1_fecha,c.extra2,c.extra2_fecha,c.extra3,c.extra3_fecha,c.idlicenciatura,a.idcampus " & _
                            "c.idgrupo,c.idlicenciatura,a.idlicenciatura as lice,a.idespecialidad as espe,S.descripcion,S.id " & _
                            "from calificaciones c inner join materias m on c.IDMATERIA=m.IDMATERIA " & _
                            "INNER JOIN alumno a on a.matricula=c.matricula " & _
                            "INNER JOIN status_calificaciones S on S.id=c.idStatus " & _
                            "WHERE C.Matricula='" + txtmatricula.Text + "' " & _
                            "AND IDLICENCIATURA='" & cmdLicenciatura.SelectedValue & "' ORDER BY C.IDSEMESTRE"
            End If
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While variables.SQLdr.Read
                Grid.Rows.Add()
            End While
            variables.SQLdr.Close()

            variables.SQLdr = cmd.ExecuteReader
            Dim I As Integer
            I = 0
            While variables.SQLdr.Read()
                Grid(0, I).Value = (variables.SQLdr("IDCALIFICACION").ToString).ToUpper
                Grid(1, I).Value = (variables.SQLdr("MATRICULA").ToString).ToUpper
                Grid(2, I).Value = (variables.SQLdr("IDSEMESTRE").ToString).ToUpper
                Grid(3, I).Value = (variables.SQLdr("IDMATERIA").ToString)
                Grid(4, I).Value = (variables.SQLdr("NOMBRE").ToString).ToUpper
                Grid(5, I).Value = (variables.SQLdr("CALIFICACION").ToString).ToUpper
                Grid(6, I).Value = (variables.SQLdr("CALIFICACION2").ToString).ToUpper
                Grid(7, I).Value = (variables.SQLdr("IDCICLOESCOLAR").ToString).ToUpper
                Grid(8, I).Value = (variables.SQLdr("EXTRA1").ToString).ToUpper
                Grid(9, I).Value = Format((variables.SQLdr("EXTRA1_FECHA")), "dd-MM-yyyy")
                Grid(10, I).Value = (variables.SQLdr("EXTRA2").ToString).ToUpper
                Grid(11, I).Value = Format((variables.SQLdr("EXTRA2_FECHA")), "dd-MM-yyyy")
                Grid(12, I).Value = (variables.SQLdr("EXTRA3").ToString).ToUpper
                Grid(13, I).Value = Format((variables.SQLdr("EXTRA3_FECHA")), "dd-MM-yyyy")
                Grid(14, I).Value = (variables.SQLdr("IDCAMPUS").ToString).ToUpper
                Grid(15, I).Value = (variables.SQLdr("IDLICENCIATURA").ToString).ToUpper
                Grid(16, I).Value = (variables.SQLdr("LICE").ToString).ToUpper
                Grid(17, I).Value = (variables.SQLdr("ESPE").ToString).ToUpper
                Grid(18, I).Value = (variables.SQLdr("IDGRUPO").ToString).ToUpper
                Grid(19, I).Value = (variables.SQLdr("DESCRIPCION").ToString).ToUpper
                Grid(20, I).Value = (variables.SQLdr("DESCRIPCION").ToString).ToUpper
                I = I + 1
            End While
            Grid.Update()
            Grid.Focus()

            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
        If variables.tipoUsuario = 10 Then
            Me.ToolStripMenuItem2.Enabled = False
            Me.ToolStripMenuItem3.Enabled = False
            Me.ToolStripMenuItem4.Enabled = False
        End If
    End Sub
    Private Sub generaGrid()
        Dim cmb As New DataGridViewComboBoxColumn
        Dim ds As New DataSet
        ds = GetstatusCalificaciones()
        cmb.HeaderText = "NUEVO STATUS"
        cmb.Name = "NUEVOSTATUS"
        cmb.DataSource = ds.Tables(0)
        cmb.DisplayMember = "descripcion"
        cmb.ValueMember = "id"
        cmb.Width = 200

        Grid.Columns.Add("IDCALIFICACION", "IDCALIFICACION")
        Grid.Columns.Add("MATRICULA", "MATRICULA")
        Grid.Columns.Add("IDSEMESTRE", "SEMESTRE")
        Grid.Columns.Add("IDMATERIA", "IDMATERIA")
        Grid.Columns.Add("NOMBRE", "MATERIA")
        Grid.Columns.Add("CALIFICACION", "1ra PARCIAL")
        Grid.Columns.Add("CALIFICACION2", "2da PARCIAL")
        Grid.Columns.Add("IDCICLOESCOLAR", "CICLO ESCOLAR")
        Grid.Columns.Add("EXTRA1", "REGU 1")
        Grid.Columns.Add("EXTRA1F", "FECHA EXTRA 1(DD-MM-AAAA)")
        Grid.Columns.Add("EXTRA2", "REGU 2")
        Grid.Columns.Add("EXTRA2F", "FECHA EXTRA 2(DD-MM-AAAA)")
        Grid.Columns.Add("EXTRA3", "REGU 3")
        Grid.Columns.Add("EXTRA3F", "FECHA EXTRA 3(DD-MM-AAAA)")
        Grid.Columns.Add("CAMPUS", "CAMPUS")
        Grid.Columns.Add("IDLICENCIATURA", "IDLICENCIATURA")
        Grid.Columns.Add("LICENCIATURA", "LICENCIATURA")
        Grid.Columns.Add("ESPECIALIDAD", "ESPECIALIDAD")
        Grid.Columns.Add("GRUPO", "GRUPO")
        Grid.Columns.Add("STATUS", "STATUS")

        variables.conexion.abrirConexion()
        Dim CboStatus As New DataGridViewComboBoxColumn()
        CboStatus.Name = "NUEVO STATUS"
        'Se ontienen los Status de la tabla

        variables.sql = "select * from status_calificaciones ORDER by descripcion"
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()
        While (variables.SQLdr.Read())
            CboStatus.Items.Add(variables.SQLdr("DESCRIPCION").ToString)
        End While
        variables.SQLdr.Close()
        CboStatus.Width = 150
        Grid.Columns.Add(CboStatus)
        variables.conexion.cerrarConexion()

        Grid.Columns.Item("IDCALIFICACION").Width = 0
        Grid.Columns.Item("IDCALIFICACION").ReadOnly = True
        Grid.Columns.Item("IDCALIFICACION").Visible = False

        Grid.Columns.Item("MATRICULA").Width = 150
        Grid.Columns.Item("MATRICULA").ReadOnly = True

        Grid.Columns.Item("IDSEMESTRE").Width = 100
        Grid.Columns.Item("IDSEMESTRE").ReadOnly = True

        Grid.Columns.Item("IDMATERIA").Width = 150
        Grid.Columns.Item("IDMATERIA").ReadOnly = True

        Grid.Columns.Item("NOMBRE").Width = 450
        Grid.Columns.Item("NOMBRE").ReadOnly = True
        Grid.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Grid.Columns.Item("CALIFICACION").Width = 100

        Grid.Columns.Item("CALIFICACION2").Width = 100

        Grid.Columns.Item("IDCICLOESCOLAR").Width = 130

        Grid.Columns.Item("EXTRA1").Width = 130

        Grid.Columns.Item("EXTRA2").Width = 130

        Grid.Columns.Item("EXTRA3").Width = 130

        Grid.Columns.Item("CAMPUS").Width = 130
        Grid.Columns.Item("CAMPUS").Visible = False

        Grid.Columns.Item("IDLICENCIATURA").Width = 130
        Grid.Columns.Item("IDLICENCIATURA").Visible = False

        Grid.Columns.Item("LICENCIATURA").Width = 130
        Grid.Columns.Item("LICENCIATURA").ReadOnly = True

        Grid.Columns.Item("ESPECIALIDAD").Width = 130
        Grid.Columns.Item("ESPECIALIDAD").ReadOnly = True

        Grid.Columns.Item("GRUPO").Width = 130
        Grid.Columns.Item("GRUPO").ReadOnly = True

        Grid.Columns.Item("STATUS").Visible = False
   
    End Sub

    Private Sub Btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsalir.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            variables.mensajeAS = MsgBox("Deseas Actualizar las Calificaciones?", MsgBoxStyle.YesNo)
            If variables.mensajeAS = vbYes Then
                actualizarCalificaciones()
                MsgBox("Actualizacion Exitosa!!", MsgBoxStyle.Information)
                generarConsultaPrincipal(1)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub actualizarCalificaciones()
        Dim idStatus As Integer = 0
        Try
            variables.conexion.abrirConexion()
            Dim sql As String
            For i = 0 To Grid.RowCount - 1
                If Val(Grid.Item(5, i).Value.ToString) <= 0 Then 'calificacion1
                    Grid.Item(5, i).Value = 0
                End If
                If Val(Grid.Item(6, i).Value.ToString) <= 0 Then 'calificacion2
                    Grid.Item(6, i).Value = 0
                End If
                If Val(Grid.Item(8, i).Value.ToString) <= 0 Then 'extra1
                    Grid.Item(8, i).Value = 0
                End If
                If Val(Grid.Item(10, i).Value.ToString) <= 0 Then 'extra2
                    Grid.Item(10, i).Value = 0
                End If
                If Val(Grid.Item(12, i).Value.ToString) <= 0 Then 'extra3
                    Grid.Item(12, i).Value = 0
                End If

                variables.sql = "select * from status_calificaciones where descripcion='" & Grid.Item(20, i).Value.ToString & "'"
                Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
                variables.SQLdr = cmd.ExecuteReader()
                While (variables.SQLdr.Read())
                    idStatus = variables.SQLdr("id")
                End While
                variables.SQLdr.Close()
                

                sql = "UPDATE calificaciones set CALIFICACION=@CALIFICACION, " & _
                    " CALIFICACION2=@CALIFICACION2,IDCICLOESCOLAR = @IDCICLOESCOLAR," & _
                    " extra1=@extra1,extra2=@extra2, extra3=@extra3, extra1_fecha=@extra1_fecha," & _
                    " extra2_fecha=@extra2_fecha, extra3_fecha=@extra3_fecha,idStatus=@idStatus,usuario=@usuario " & _
                    "where (IDCALIFICACION=@IDCALIFICACION) "

                cmd = New SqlCommand(sql, variables.conexion.Conexion)
                With cmd
                    .Parameters.AddWithValue("@CALIFICACION", CDbl(Grid.Item(5, i).Value.ToString))
                    .Parameters.AddWithValue("@CALIFICACION2", CDbl(Grid.Item(6, i).Value.ToString))
                    .Parameters.AddWithValue("@IDCICLOESCOLAR", Grid.Item(7, i).Value.ToString)
                    .Parameters.AddWithValue("@extra1", Convert.ToDecimal(Grid.Item(8, i).Value.ToString))
                    .Parameters.AddWithValue("@extra2", Convert.ToDecimal(Grid.Item(10, i).Value.ToString))
                    .Parameters.AddWithValue("@extra3", Convert.ToDecimal(Grid.Item(12, i).Value.ToString))
                    .Parameters.AddWithValue("@extra1_fecha", CDate(Grid.Item(9, i).Value).Date)
                    .Parameters.AddWithValue("@extra2_fecha", CDate(Grid.Item(11, i).Value).Date)
                    .Parameters.AddWithValue("@extra3_fecha", CDate(Grid.Item(13, i).Value).Date)
                    .Parameters.AddWithValue("@idStatus", idStatus)
                    .Parameters.AddWithValue("@IDCALIFICACION", Grid.Item(0, i).Value)
                    .Parameters.AddWithValue("@usuario", variables.usuario)
                End With
                cmd.ExecuteNonQuery()
            Next
            variables.conexion.cerrarConexion()
        Catch
            MsgBox("Error Actualizando Verifique")
            Exit Sub
        End Try
    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        txtmatricula.Text = ""
        Grid.Columns.Clear()
        txtmatricula.Focus()
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "modifcalif"
        frmBuscarAlumno.ShowDialog()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        generarConsultaPrincipal(2)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles cmdInicializar.Click
        Panel1.Visible = False
        txtmatricula.Focus()
    End Sub
    Private Function obtenerIDLICE(ByVal lice As String) As String
        Dim id As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from licenciaturas where NOMBRE='" & lice & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                id = Val(variables.SQLdr("IDLICENCIATURA").ToString)
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return id
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function

    Private Sub cmdKardex_Click(sender As System.Object, e As System.EventArgs) Handles cmdKardex.Click
        If Grid.RowCount > 0 Then
            If Grid.Rows(Grid.CurrentRow.Index).Cells("MATRICULA").Value.ToString = "" Then
                MsgBox("El alumno no tiene matricula, FAVOR DE ASIGNARLE MATRICULA", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            Else
                frmdocente.lblMatricula.Text = Grid.Rows(Grid.CurrentRow.Index).Cells("MATRICULA").Value.ToString
                variables.IdLice = Grid.Rows(Grid.CurrentRow.Index).Cells("IDLICENCIATURA").Value
                frmdocente.lblID.Text = variables.IdLice
                frmdocente.Show()
            End If
        End If
    End Sub

    Private Sub cmdBoleta_Click(sender As System.Object, e As System.EventArgs) Handles cmdBoleta.Click
        Try
            variables.matricula = Grid.Rows(Grid.CurrentRow.Index).Cells("MATRICULA").Value.ToString
            variables.IdLice = Grid.Rows(Grid.CurrentRow.Index).Cells("IDLICENCIATURA").Value.ToString
            variables.campus = Grid.Rows(Grid.CurrentRow.Index).Cells("CAMPUS").Value.ToString
            variables.licenciatura = Grid.Rows(Grid.CurrentRow.Index).Cells("LICENCIATURA").Value.ToString
            variables.especialidad = Grid.Rows(Grid.CurrentRow.Index).Cells("ESPECIALIDAD").Value.ToString
            variables.grupo = Grid.Rows(Grid.CurrentRow.Index).Cells("GRUPO").Value.ToString
            variables.semestre = Grid.Rows(Grid.CurrentRow.Index).Cells("IDSEMESTRE").Value.ToString
            variables.ciclo = Grid.Rows(Grid.CurrentRow.Index).Cells("IDCICLOESCOLAR").Value.ToString
            variables.param = 0
            imprimirBoleta.Show()
        Catch
            Exit Sub
        End Try
    End Sub
    Private Sub chkFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFecha.CheckedChanged
        If chkFecha.Checked = True Then
            dt1.Visible = True
            variables.usaFecha = 1
        Else
            dt1.Visible = False
            variables.usaFecha = 0
        End If
    End Sub

    Private Sub cmdEliminar_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminar.Click
        Dim mensaje As String
        Try
            mensaje = MsgBox("Deseas eliminar la siguiente calificacion: " & Grid.Item(4, Grid.CurrentRow.Index).Value.ToString & "?", vbYesNo)
            If mensaje = vbYes Then
                variables.conexion.abrirConexion()
                Dim sql As String
                sql = " DELETE FROM calificaciones where (IDCALIFICACION=" & CDbl(Grid.Item(0, Grid.CurrentRow.Index).Value.ToString) & ") "
                Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                cmd.ExecuteNonQuery()
                variables.conexion.cerrarConexion()
                MsgBox("Eliminacion Completa!", vbInformation)
                generarConsultaPrincipal(1)
            Else
                Exit Sub
            End If
        Catch
            MsgBox("Error Actualizando intente de nuevo", vbCritical)
            Exit Sub
        End Try
    End Sub

    Private Sub EliminarCalificacionSeleccionadaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarCalificacionSeleccionadaToolStripMenuItem.Click
        Call cmdEliminar_Click(sender, e)
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Call BtnGuardar_Click(sender, e)
    End Sub

    Private Sub LimpiarGridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarGridToolStripMenuItem.Click
        Call btnlimpiar_Click(sender, e)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Call Btnsalir_Click(sender, e)
    End Sub

    Private Sub BoletaDeCalificacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoletaDeCalificacionToolStripMenuItem.Click
        Call cmdBoleta_Click(sender, e)
    End Sub

    Private Sub KardexToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KardexToolStripMenuItem.Click
        Call cmdKardex_Click(sender, e)
    End Sub
    Private Sub Grid_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Enter
        Dim semestre As String = ""
        Dim valor As Object
        semestre = Grid.Item("idsemestre", Grid.CurrentRow.Index).Value.ToString()
        valor = Grid.Item("NUEVO STATUS", Grid.CurrentRow.Index).Value
        If valor Is Nothing Then Exit Sub

        For i = 0 To Grid.RowCount - 1
            If Val(Grid.Item("idsemestre", i).Value.ToString) = semestre Then 'se compara el semestre
                Grid.Item("STATUS", i).Value = valor
                Grid.Item("NUEVO STATUS", i).Value = valor
            End If
        Next
    End Sub

    Private Sub Grid_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseDown
        Dim semestre As String = ""
        Dim valor As Object
        semestre = Grid.Item("idsemestre", Grid.CurrentRow.Index).Value.ToString()
        valor = Grid.Item("NUEVO STATUS", Grid.CurrentRow.Index).Value
        If valor Is Nothing Then Exit Sub

        For i = 0 To Grid.RowCount - 1
            If Val(Grid.Item("idsemestre", i).Value.ToString) = semestre Then 'se compara el semestre
                Grid.Item("STATUS", i).Value = valor
                Grid.Item("NUEVO STATUS", i).Value = valor
            End If
        Next
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Call cmdEliminar_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Call BtnGuardar_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Call btnlimpiar_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Call Btnsalir_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Call cmdBoleta_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Call cmdKardex_Click(sender, e)
    End Sub

    Private Sub Grid_MouseLeave(sender As Object, e As System.EventArgs) Handles Grid.MouseLeave
        On Error Resume Next
        Dim semestre As String = ""
        Dim valor As Object
        semestre = Grid.Item("idsemestre", Grid.CurrentRow.Index).Value.ToString()
        valor = Grid.Item("NUEVO STATUS", Grid.CurrentRow.Index).Value
        If valor Is Nothing Then Exit Sub

        For i = 0 To Grid.RowCount - 1
            If Val(Grid.Item("idsemestre", i).Value.ToString) = semestre Then 'se compara el semestre
                Grid.Item("STATUS", i).Value = valor
                Grid.Item("NUEVO STATUS", i).Value = valor
            End If
        Next
    End Sub
End Class