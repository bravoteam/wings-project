Imports System.Data.SqlClient

Public Class exportacionAlumnosFrm

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            bloquearControles()
        Else
            desbloquearControles()
        End If
    End Sub
    Private Sub bloquearControles()
        cmbCampus.Text = ""
        cmbCampus.Enabled = False
        cmbSemestre.Text = ""
        cmbSemestre.Enabled = False
        cmbTurno.Text = ""
        cmbTurno.Enabled = False
        cmdEspecialidad.Text = ""
        cmdEspecialidad.Enabled = False
        cmdGrupo.Text = ""
        cmdGrupo.Enabled = False
        cmdLicenciatura.Text = ""
        cmdLicenciatura.Enabled = False
    End Sub
    Private Sub desbloquearControles()
        cmbCampus.Text = ""
        cmbCampus.Enabled = True
        cmbSemestre.Text = ""
        cmbSemestre.Enabled = True
        cmbTurno.Text = ""
        cmbTurno.Enabled = True
        cmdEspecialidad.Text = ""
        cmdEspecialidad.Enabled = True
        cmdGrupo.Text = ""
        cmdGrupo.Enabled = True
        cmdLicenciatura.Text = ""
        cmdLicenciatura.Enabled = True
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
                cmdLicenciatura.Items.Add(variables.SQLdr("nombre").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmbSemestre_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSemestre.DropDown
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

    Private Sub cmdGrupo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGrupo.DropDown
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

    Private Sub cmdEspecialidad_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEspecialidad.DropDown
        cmdEspecialidad.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from especialidades order by descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmdEspecialidad.Items.Add(variables.SQLdr("descripcion").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub exportarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exportarCmd.Click
        GridAExcel(Me.Grid)
    End Sub

    Private Sub consultarcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarcmd.Click
        generarConsultaPrincipal()
    End Sub
    Private Sub generarConsultaPrincipal()
        Try
            ' Grid.Rows.Clear()
            'Grid.Columns.Clear()
            variables.conexion.abrirConexion()

            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If chkTodos.Checked = True Then
                variables.sql = "select * " & _
                           "from alumno order by apellido_paterno,apellido_materno,nombre"
            Else
                variables.sql = "select * " & _
                           "from alumno where (IDSEMESTRE = '" & cmbSemestre.Text & "') AND " & _
                           "IDGRUPO = '" & cmdGrupo.Text & "' AND (idlicenciatura='" & cmdLicenciatura.Text & "') " & _
                           "AND (idespecialidad='" & cmdEspecialidad.Text & "') AND (IDCAMPUS = '" & cmbCampus.Text & "') " & _
                           "AND (IDturno = '" & cmbTurno.Text & "') order by apellido_paterno,apellido_materno,nombre"
            End If


            cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
            Dim da As New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            Grid.DataSource = dt

            Grid.Update()
            Grid.Focus()
            contarHombresYmujeres()
            Statusbar1.Items(0).Text = "# Registros: " & Grid.RowCount
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

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class