Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports Microsoft.Reporting.WinForms

Public Class estadisticasFrm

    Private Sub consultarcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarcmd.Click
        generarListado()
    End Sub
    Private Sub generarListado()
        Try
            variables.campus = cmbCampus.Text
            Dim parameters As New ReportParameter

            parameters = New ReportParameter("CICLO", "2012-2013")
            Me.ReportViewer1.LocalReport.SetParameters(parameters)
            Me.estadisticasDtTableAdapter.Fill(Me.reportesDT.estadisticasDt, variables.campus)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()

        End Try
        estadisticasImprFrm.ReportViewer1.RefreshReport()
    End Sub
    'Private Sub insertaRow(ByVal i As Integer, ByVal grupo As String, ByVal dato As String, ByVal campus As String)
    '    variables.sql = "SELECT COUNT(matricula) from alumno WHERE (IDLICENCIATURA LIKE '%" + dato + "%') AND (genero='H') AND (idsemestre=" & i & ") AND(idgrupo='" + grupo + "') AND (idcampus='" + campus + "')"
    '    Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
    '    Dim nH As Integer = CInt(cmd.ExecuteScalar())

    '    variables.sql = "SELECT COUNT(matricula) from alumno WHERE (IDLICENCIATURA LIKE '%" + dato + "%') AND (genero='M') AND (idsemestre=" & i & ") AND(idgrupo='" + grupo + "') AND (idcampus='" + campus + "')"
    '    cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
    '    Dim nM = CInt(cmd.ExecuteScalar())
    '    Grid.Rows.Add(campus, "2010-2012", i, grupo, dato, " ", nH, nM, nH + nM)
    'End Sub

    Private Sub cmbCampus_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCampus.DropDown
        Dim ds As New DataSet
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
    End Sub

    Private Sub guardarCmd_Click(sender As System.Object, e As System.EventArgs) Handles guardarCmd.Click
        estadisticasImprFrm.Text = "Generar Impresion H y M"
        variables.campus = cmbCampus.Text
        estadisticasImprFrm.ShowDialog()
        estadisticasImprFrm.ReportViewer1.RefreshReport()
    End Sub

End Class