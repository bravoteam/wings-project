Imports System.Data.SqlClient
Imports datosCompartidos
Public Class Rpt_ReprobadasFrm


    Private Sub cmbCampus_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCampus.DropDown
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

    Private Sub cmdLicenciatura_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLicenciatura.DropDown
        cmbLicenciatura.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from licenciaturas order by nombre"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbLicenciatura.Items.Add(variables.SQLdr("nombre").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmdEspecialidad_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEspecialidad.DropDown
        cmbEspecialidad.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from especialidades order by descripcion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbEspecialidad.Items.Add(variables.SQLdr("descripcion").ToString)
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




    Private Sub consultarcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarcmd.Click
        If ChkRptgral.Checked = True Then
            Me.cmbTurno.Text = ""
            Me.cmbSemestre.Text = ""
            Me.cmbLicenciatura.Text = ""
            Me.cmbEspecialidad.Text = ""
            Me.cmdGrupo.Text = ""
            Me.cmbCampus.Text = ""
            Me.ReportViewer1.Visible = True
            Me.ReportViewer2.Visible = False
            Me.Reporte_GeneralTableAdapter.Fill(Me.IsencoDataSet.Reporte_General)
            Me.ReportViewer1.RefreshReport()
        Else
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = True
            Me.Reporte_EspecificoTableAdapter.Fill(Me.IsencoDataSet.Reporte_Especifico, cmbSemestre.Text, cmbLicenciatura.Text, cmbCampus.Text, cmbEspecialidad.Text, cmdGrupo.Text, cmbTurno.Text)
            Me.ReportViewer2.RefreshReport()
        End If
    End Sub

    Private Sub Rpt_ReprobadasFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IsencoDataSet.Reporte_General' table. You can move, or remove it, as needed.
        Me.Reporte_GeneralTableAdapter.Fill(Me.IsencoDataSet.Reporte_General)

    End Sub
End Class
