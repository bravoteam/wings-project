Imports Kardex_Alumno.Datos
Imports System.Data.SqlClient

Public Class frmdocente
    Private Sub OkCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkCmd.Click
        frmKardex.Show()
        Me.Close()
    End Sub


    Private Sub Cmbmaestro_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbmaestro.DropDown
        Cmbmaestro.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select nombre from directivos order by nombre"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                Cmbmaestro.Items.Add(variables.SQLdr("nombre").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub inicializar_combos()
        Cmbmaestro.Text = ""
        Cmbmaestro2.Text = ""
        Cmbmaestro3.Text = ""
        Cmbmaestro4.Text = ""
        Cmbmaestro5.Text = ""
        Cmbmaestro6.Text = ""
        Cmbmaestro7.Text = ""
        Cmbmaestro8.Text = ""
    End Sub
    Private Sub Cmbmaestro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbmaestro.SelectedIndexChanged
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select nombre from directivos order by nombre"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                Cmbmaestro2.Items.Add(variables.SQLdr("nombre").ToString)
                Cmbmaestro3.Items.Add(variables.SQLdr("nombre").ToString)
                Cmbmaestro4.Items.Add(variables.SQLdr("nombre").ToString)
                Cmbmaestro5.Items.Add(variables.SQLdr("nombre").ToString)
                Cmbmaestro6.Items.Add(variables.SQLdr("nombre").ToString)
                Cmbmaestro7.Items.Add(variables.SQLdr("nombre").ToString)
                Cmbmaestro8.Items.Add(variables.SQLdr("nombre").ToString)
            End While
            Cmbmaestro2.Text = Cmbmaestro.Text
            Cmbmaestro3.Text = Cmbmaestro.Text
            Cmbmaestro4.Text = Cmbmaestro.Text
            Cmbmaestro5.Text = Cmbmaestro.Text
            Cmbmaestro6.Text = Cmbmaestro.Text
            Cmbmaestro7.Text = Cmbmaestro.Text
            Cmbmaestro8.Text = Cmbmaestro.Text

            variables.conexion.cerrarConexion()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub frmdocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializar_combos()
        labelPlan.Text = frmBuscarAlumbo.UDPeriodo.Value
    End Sub

    Private Sub SalirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirCmd.Click
        inicializar_combos()
        Me.Close()
    End Sub
End Class