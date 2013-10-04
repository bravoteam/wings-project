Imports System.Data.SqlClient

Public Class generarMatriculas
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
        Try
            variables.conexion.abrirConexion()
            variables.dt = variables.conexion.getDataSet("select matricula,apellido_paterno,apellido_materno,nombre,idcampus,idsemestre,idgrupo,idturno,idlicenciatura,idespecialidad " & _
                                                         "from alumno where (IDSEMESTRE = '" & cmbSemestre.Text & "') AND " & _
                                                         "IDGRUPO = '" & cmdGrupo.Text & "' AND (matricula = '') AND (idlicenciatura='" & cmdLicenciatura.Text & "') " & _
                                                         "AND (idespecialidad='" & cmdEspecialidad.Text & "') AND (IDCAMPUS = '" & cmbCampus.Text & "') " & _
                                                         "AND (IDturno = '" & cmbTurno.Text & "') order by apellido_paterno,apellido_materno,nombre")
            Grid.DataSource = variables.dt.Tables(0)
            Grid.Update()
            Grid.Focus()
            generarMatriculasAlumnos()
            lblRegs.Text = "# Registros: " & Grid.RowCount
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub generarMatriculasAlumnos()
        Try
            variables.conexion.abrirConexion()
            If radio1.Checked = True Then
                variables.sql = "select ultimaMatriculaL from configuracion"
                Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
                variables.ultimaMat = cmd.ExecuteScalar

                For i = 0 To Grid.RowCount - 1
                    Grid.Item(0, i).Value = variables.ultimaMat.ToString & "0000"
                    variables.ultimaMat += 1
                Next
            Else
                variables.sql = "select ultimaMatriculaB from configuracion"
                Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
                variables.ultimaMat = cmd.ExecuteScalar

                For i = 0 To Grid.RowCount - 1
                    Grid.Item(0, i).Value = variables.ultimaMat.ToString
                    variables.ultimaMat += 1
                Next
            End If
            
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
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

    Private Sub cmdEspecialidad_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEspecialidad.DropDown
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

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Try
            Dim sql As String
            actualizarAlumnos()
            variables.conexion.abrirConexion()
            If radio1.Checked = True Then
                sql = "UPDATE configuracion set ultimaMatriculaL=" & variables.ultimaMat & " "
            Else
                sql = "UPDATE configuracion set ultimaMatriculaB=" & variables.ultimaMat & " "
            End If
            Dim cmd As New SqlCommand(Sql, variables.conexion.Conexion)
            cmd.ExecuteNonQuery()
            MsgBox("MATRICULAS GENERADAS CORRECTAMENTE")
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub actualizarAlumnos()
        variables.conexion.abrirConexion()
        For i = 0 To Grid.RowCount - 1
            Dim sql As String = "UPDATE alumno set MATRICULA='" & Grid.Item(0, i).Value.ToString & "' where (apellido_paterno='" & Grid.Item(1, i).Value.ToString & "') " & _
                                "AND (apellido_materno='" & Grid.Item(2, i).Value.ToString & "') AND (nombre='" & Grid.Item(3, i).Value.ToString & "')"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            cmd.ExecuteNonQuery()
        Next
        variables.conexion.cerrarConexion()
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class