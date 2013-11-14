Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class ImpresionConcentradoCalif


    Private Sub ImpresionConcentradoCalif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'isencoDataSet.LISTA_FOTOS' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'isencoDataSet.Lista_Asistencia' table. You can move, or remove it, as needed.
        If variables.parcial = 1 Then
            variables.parcialdescripcion = "PRIMERA PARCIAL"
        Else
            variables.parcialdescripcion = "SEGUNDA PARCIAL"
        End If
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.Lista_AsistenciaTableAdapter.Fill(Me.isencoDataSet.Lista_Asistencia, principalOtrosRpt.cmbEspecialidad.Text, _
                                                      principalOtrosRpt.cmbSemestre.Text, principalOtrosRpt.cmbGrupo.Text, principalOtrosRpt.cmbCampus.Text, _
                                                      principalOtrosRpt.cmbLicenciatura.Text, principalOtrosRpt.cmbTurno.Text, _
                                                      principalOtrosRpt.cmbModalidad.Text, variables.parcialdescripcion)
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
        parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.LocalReport.SetParameters(parameters)
        Me.LISTA_FOTOSTableAdapter.Fill(Me.isencoDataSet.LISTA_FOTOS, principalOtrosRpt.cmbEspecialidad.Text, _
                                                      principalOtrosRpt.cmbSemestre.Text, principalOtrosRpt.cmbGrupo.Text, principalOtrosRpt.cmbCampus.Text, _
                                                      principalOtrosRpt.cmbLicenciatura.Text, principalOtrosRpt.cmbTurno.Text, _
                                                      principalOtrosRpt.cmbModalidad.Text)
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Sub PDF()
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
        "  <PageWidth>21cm</PageWidth>" +
        "  <PageHeight>29cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "Lista_Concen_calif.rdl"
            Dim fs As New FileStream("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & "Concentrado_calif.pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & "Concentrado_calif.pdf")

            bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer2.LocalReport.ReportPath = "Listas_con_fotos.rdl"
            Dim fs1 As New FileStream("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & "FOTOS.pdf", FileMode.Create)
            fs1.Write(bytes, 0, bytes.Length)
            fs1.Close()
            Process.Start("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & "FOTOS.pdf")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click

    End Sub
    Public Shared Sub actualizar_reporte()
        ImpresionConcentradoCalif.ReportViewer1.RefreshReport()
        ImpresionConcentradoCalif.ReportViewer2.RefreshReport()

        If variables.parcial = 1 Then
            variables.parcialdescripcion = "PRIMERA PARCIAL"
        Else
            variables.parcialdescripcion = "SEGUNDA PARCIAL"
        End If
        ImpresionConcentradoCalif.Lista_AsistenciaTableAdapter.Fill(ImpresionConcentradoCalif.isencoDataSet.Lista_Asistencia, principalOtrosRpt.cmbEspecialidad.Text, _
                                                      principalOtrosRpt.cmbSemestre.Text, principalOtrosRpt.cmbGrupo.Text, principalOtrosRpt.cmbCampus.Text, _
                                                      principalOtrosRpt.cmbLicenciatura.Text, principalOtrosRpt.cmbTurno.Text, _
                                                      principalOtrosRpt.cmbModalidad.Text, variables.parcialdescripcion)
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
        parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))
        impresionListas.ReportViewer1.LocalReport.SetParameters(parameters)
        impresionListas.ReportViewer2.LocalReport.SetParameters(parameters)
        impresionListas.ReportViewer1.RefreshReport()
        impresionListas.ReportViewer2.RefreshReport()

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        PDF()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class