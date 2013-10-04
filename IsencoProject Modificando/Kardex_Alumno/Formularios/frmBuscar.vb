Imports Kardex_Alumno.Datos
Imports System.Data.SqlClient

Public Class frmBuscarAlumbo
    Private BD As New BaseDatos
    Private Sub filtrarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrarCmd.Click
        buscarXDescripcion(txtBuscar.Text)
        Grid.DataSource = variables.dt.Tables(0)
        Grid.Update()
        Grid.Focus()
        activar_boton_kardex()
    End Sub
    Private Sub activar_boton_kardex()
        'activar o desactivar el boton de kardex en caso de que no genere nada de resultados la busqueda
        If Grid.Rows.Count > 0 Then
            GenerarCmd.Enabled = True
        Else
            GenerarCmd.Enabled = False
        End If
    End Sub
    Private Sub txtBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            filtrarCmd.PerformClick()
        End If
    End Sub

    'Private Sub Grid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
    '    If variables.banderaAccion = "campus" Then
    '        Dim frm As New campusFrm(Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("CALLE").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("NUMERO").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("COLONIA").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("MUNICIPIO").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("CODIGO_POSTAL").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("CCT").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("TELEFONO").Value.ToString,
    '                                 Grid.Rows(e.RowIndex).Cells("IDCAMPUS").Value.ToString)
    '        frm.Show()
    '        Me.Close()
    '    End If
    '    If variables.banderaAccion = "materias" Then
    '        Dim frm As New materiasFrm(Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDCARRERA").Value.ToString,
    '                                   Grid.Rows(e.RowIndex).Cells("IDCARRERA").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDESPECIALIDAD").Value.ToString,
    '                                   Grid.Rows(e.RowIndex).Cells("IDESPECIALIDAD").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDSEMESTRE").Value.ToString,
    '                                   Grid.Rows(e.RowIndex).Cells("IDSEMESTRE").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDMAESTRO").Value.ToString,
    '                                   Grid.Rows(e.RowIndex).Cells("IDMAESTRO").Value.ToString, Grid.Rows(e.RowIndex).Cells("PLANDEESTUDIOS").Value.ToString,
    '                                   Grid.Rows(e.RowIndex).Cells("CLAVEISENCO").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDMATERIA").Value.ToString,
    '                                   Grid.Rows(e.RowIndex).Cells("ACTIVA").Value)

    '        frm.Show()
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If variables.banderaAccion = "campus" Then
    '            Dim frm As New campusFrm(Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("CALLE", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("NUMERO", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("COLONIA", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("MUNICIPIO", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("CODIGO_POSTAL", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("CCT", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("TELEFONO", Grid.CurrentRow.Index).Value.ToString,
    '                                     Grid.Item("IDCAMPUS", Grid.CurrentRow.Index).Value.ToString)
    '            frm.Show()
    '            Me.Close()
    '        End If
    '        If variables.banderaAccion = "materias" Then
    '            Dim frm As New materiasFrm(Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDCARRERA", Grid.CurrentRow.Index).Value.ToString,
    '                                  Grid.Item("IDCARRERA", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDESPECIALIDAD", Grid.CurrentRow.Index).Value.ToString,
    '                                  Grid.Item("IDESPECIALIDAD", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDSEMESTRE", Grid.CurrentRow.Index).Value.ToString,
    '                                  Grid.Item("IDSEMESTRE", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDMAESTRO", Grid.CurrentRow.Index).Value.ToString,
    '                                  Grid.Item("IDMAESTRO", Grid.CurrentRow.Index).Value.ToString, Grid.Item("PLANDEESTUDIOS", Grid.CurrentRow.Index).Value.ToString,
    '                                  Grid.Item("CLAVEISENCO", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDMATERIA", Grid.CurrentRow.Index).Value.ToString,
    '                                  Grid.Item("ACTIVA", Grid.CurrentRow.Index).Value)

    '            frm.Show()
    '            Me.Close()
    '        End If
    '    End If
    'End Sub

    Private Sub frmBuscarAlumbo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        variables.banderaAccion = "Alumno"
        GenerarCmd.Enabled = False
    End Sub

    Private Sub SalirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirCmd.Click
        Me.Close()
    End Sub

    Private Sub Grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        GenerarCmd.PerformClick()
    End Sub
    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenerarCmd.PerformClick()
        End If
    End Sub

    Private Sub GenerarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCmd.Click
        'frmKardex.Text = Grid.Rows(Grid.CurrentRow.Index).Cells("Matricula").Value.ToString
        If Grid.Rows(Grid.CurrentRow.Index).Cells("MATRICULA").Value.ToString = "" Then
            MsgBox("ESTE ALUMNO NO CUENTA CON MATRICULA ASIGNADA, FAVOR DE ASIGNARLE MATRICULA", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        Else
            frmdocente.lblMatricula.Text = Grid.Rows(Grid.CurrentRow.Index).Cells("MATRICULA").Value.ToString
            frmdocente.lblID.Text = obtenerIDLICE(Grid.Rows(Grid.CurrentRow.Index).Cells("idlicenciatura").Value.ToString)
            frmdocente.Show()
            ' frmKardex.Show()
        End If

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
End Class