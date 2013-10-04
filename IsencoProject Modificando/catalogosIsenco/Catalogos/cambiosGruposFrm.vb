Imports System.Data.SqlClient
Public Class cambiosGruposFrm
    Private Sub semestreCombo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSemestre.DropDown
        cmbSemestre.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from semestres order by numero"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbSemestre.Items.Add(variables.SQLdr("NUMERO").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub grupoCmd_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrupo.DropDown
        cmdGrupo.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from grupos where IDGRUPO='" & cmbSemestre.Text & "' order by nombre"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmdGrupo.Items.Add(variables.SQLdr("NOMBRE").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub consultarcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarcmd.Click
        generarConsultaPrincipal()
    End Sub
    Private Sub generarConsultaPrincipal()
        Try
            Grid.Rows.Clear()
            Grid.Columns.Clear()
            variables.conexion.abrirConexion()
            Grid.Columns.Add("MATRICULA", "MATRICULA")
            Grid.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO")
            Grid.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO")
            Grid.Columns.Add("NOMBRE", "NOMBRES")
            Grid.Columns.Add("GENERO", "GENERO")
            Grid.Columns.Add("IDCAMPUS", "CAMPUS")
            Grid.Columns.Add("IDSEMESTRE", "SEMESTRE")
            Grid.Columns.Add("IDGRUPO", "GRUPO")
            Grid.Columns.Add("IDSTATUS", "STATUS ACTUAL")
            Grid.Columns.Add("NGRUPO", "NUEVO GRUPO")
            Grid.Columns.Add("NTURNO", "NUEVO TURNO")
            Grid.Columns.Add("NSEMESTRE", "NUEVO SEMESTRE")
            Grid.Columns.Add("ID", "ID")

            Grid.Columns.Item("MATRICULA").Width = 150
            Grid.Columns.Item("MATRICULA").ReadOnly = True

            Grid.Columns.Item("APELLIDO_PATERNO").Width = 200
            Grid.Columns.Item("APELLIDO_PATERNO").ReadOnly = True
            Grid.Columns.Item("APELLIDO_PATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("APELLIDO_MATERNO").Width = 200
            Grid.Columns.Item("APELLIDO_MATERNO").ReadOnly = True
            Grid.Columns.Item("APELLIDO_MATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("NOMBRE").Width = 450
            Grid.Columns.Item("NOMBRE").ReadOnly = True
            Grid.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("GENERO").Width = 100
            Grid.Columns.Item("GENERO").ReadOnly = True
            Grid.Columns.Item("GENERO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("IDCAMPUS").Width = 200
            Grid.Columns.Item("IDCAMPUS").ReadOnly = True
            Grid.Columns.Item("IDCAMPUS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("IDSEMESTRE").Width = 200
            Grid.Columns.Item("IDSEMESTRE").ReadOnly = True
            Grid.Columns.Item("IDSEMESTRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("IDGRUPO").Width = 200
            Grid.Columns.Item("IDGRUPO").ReadOnly = True
            Grid.Columns.Item("IDGRUPO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


            Grid.Columns.Item("IDSTATUS").Width = 200
            Grid.Columns.Item("IDSTATUS").ReadOnly = True
            Grid.Columns.Item("IDSTATUS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("NGRUPO").Width = 100
            Grid.Columns.Item("NGRUPO").ReadOnly = True
            Grid.Columns.Item("NGRUPO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("NTURNO").Width = 100
            Grid.Columns.Item("NTURNO").ReadOnly = True
            Grid.Columns.Item("NTURNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("NSEMESTRE").Width = 100
            Grid.Columns.Item("NSEMESTRE").ReadOnly = True
            Grid.Columns.Item("NSEMESTRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("ID").Width = 100
            Grid.Columns.Item("ID").ReadOnly = True
            Grid.Columns.Item("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)


            ' Se hace la consulta principal
            variables.sql = "select matricula,apellido_paterno,apellido_materno,nombre,idstatus,genero,idcampus,idsemestre,idgrupo,idalumno " & _
                            "from alumno where (IDSEMESTRE = '" & cmbSemestre.Text & "') AND " & _
                            "IDGRUPO = '" & cmdGrupo.Text & "' AND (idlicenciatura='" & cmdLicenciatura.Text & "') " & _
                            "AND (idespecialidad='" & cmdEspecialidad.Text & "') AND (IDCAMPUS = '" & cmbCampus.Text & "') " & _
                            "AND (IDturno = '" & cmbTurno.Text & "') order by apellido_paterno,apellido_materno,nombre"

            cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While variables.SQLdr.Read
                Grid.Rows.Add()
            End While
            variables.SQLdr.Close()

            variables.SQLdr = cmd.ExecuteReader
            Dim I As Integer
            I = 0
            While variables.SQLdr.Read()
                Grid(0, I).Value = (variables.SQLdr("MATRICULA").ToString).ToUpper
                Grid(1, I).Value = (variables.SQLdr("APELLIDO_PATERNO").ToString).ToUpper
                Grid(2, I).Value = (variables.SQLdr("APELLIDO_MATERNO").ToString).ToUpper
                Grid(3, I).Value = (variables.SQLdr("NOMBRE").ToString).ToUpper
                Grid(4, I).Value = (variables.SQLdr("GENERO").ToString).ToUpper
                Grid(5, I).Value = (variables.SQLdr("IDCAMPUS").ToString).ToUpper
                Grid(6, I).Value = (variables.SQLdr("IDSEMESTRE").ToString).ToUpper
                Grid(7, I).Value = (variables.SQLdr("IDGRUPO").ToString).ToUpper
                Grid(8, I).Value = (variables.SQLdr("IDSTATUS").ToString).ToUpper
                Grid(9, I).Value = (variables.SQLdr("IDGRUPO").ToString).ToUpper
                Grid(10, I).Value = cmbTurno.Text
                Grid(11, I).Value = cmbSemestre.Text
                Grid(12, I).Value = (variables.SQLdr("idalumno").ToString).ToUpper
                I = I + 1
            End While

            Grid.Update()
            Grid.Focus()
            contarHombresYmujeres()
            Statusbar1.Items(0).Text = "# Registros: " & Grid.RowCount
            cmbNSemestre.Text = cmbSemestre.Text
            cmbNGrupo.Text = cmdGrupo.Text
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub contarHombresYmujeres()
        Dim hombre, mujer As Integer
        hombre = 0
        mujer = 0
        For i = 0 To Grid.RowCount - 1
            If Grid(4, i).Value.ToString = "H" Then
                hombre = hombre + 1
            End If
            If Grid(4, i).Value.ToString = "M" Then
                mujer = mujer + 1
            End If
        Next
        Statusbar1.Items(1).Text = "# Hombres: " & hombre
        Statusbar1.Items(2).Text = "# Mujeres: " & mujer
    End Sub
    Private Sub cmbCampus_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCampus.DropDown
        cmbCampus.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from campus order by municipio"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbCampus.Items.Add(variables.SQLdr("municipio").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmdLicenciatura_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLicenciatura.DropDown
        cmdLicenciatura.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from licenciaturas order by nombre"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmdLicenciatura.Items.Add(UCase(variables.SQLdr("nombre").ToString))
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmdEspecialidad_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEspecialidad.DropDown
        cmdEspecialidad.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from especialidades order by descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmdEspecialidad.Items.Add(UCase(variables.SQLdr("descripcion").ToString))
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub actualizarAlumnos()
        variables.conexion.abrirConexion()
        Dim sql As String
        Dim vaS As Integer = Val(cmbSemestre.Text) + 1
        For i = 0 To Grid.RowCount - 1
            sql = "UPDATE alumno set IDGRUPO='" & Grid.Item(9, i).Value.ToString & "'," & _
                "IDTURNO='" & Grid.Item(10, i).Value.ToString & "',IDSEMESTRE ='" & Grid.Item(11, i).Value.ToString & "' where (IDALUMNO=" & Grid.Item(12, i).Value.ToString & ") "

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            cmd.ExecuteNonQuery()
        Next
        variables.conexion.cerrarConexion()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' If statusGroup.Visible = False Then
        If Grid.RowCount > 0 Then
            statusGroup.Visible = True
        Else
            statusGroup.Visible = False
        End If
        'End If
    End Sub

    Private Sub actualizaCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actualizaCmd.Click
        If cmbNSemestre.Text = "" Then
            MsgBox("Debes Elegir un Semestre", MsgBoxStyle.Critical)
            cmbNSemestre.Focus()
            Exit Sub
        End If
        If cmbNGrupo.Text = "" Then
            MsgBox("Debes Elegir un Grupo", MsgBoxStyle.Critical)
            cmbNGrupo.Focus()
            Exit Sub
        End If
        If cmbNTurno.Text = "" Then
            MsgBox("Debes Elegir un Turno", MsgBoxStyle.Critical)
            cmbNTurno.Focus()
            Exit Sub
        End If


        Dim I As Integer
        For I = 0 To Grid.RowCount - 1
            Grid(9, I).Value = cmbNGrupo.Text
            Grid(10, I).Value = cmbNTurno.Text
            Grid(11, I).Value = cmbNSemestre.Text
        Next
        'For I = 0 To Grid.RowCount - 1
        '    Grid(10, I).Value = cmbNTurno.Text
        'Next
    End Sub

    Private Sub promocionAlumnosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Statusbar1.Items(0).Text = "# Registros: " & 0
        Statusbar1.Items(1).Text = "# Hombres: " & 0
        Statusbar1.Items(2).Text = "# Mujeres: " & 0
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem1.Click
        Try
            variables.mensajeAS = MsgBox("Deseas Actualizar los Alumnos?", MsgBoxStyle.YesNo)
            If variables.mensajeAS = vbYes Then
                actualizarAlumnos()
                MsgBox("Actualizacion Exitosa!!", MsgBoxStyle.Information)
                generarConsultaPrincipal()
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
End Class