Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class impresionListas

    Private Sub impresionListas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        If SD = 0 Then
            Me.Lista_AsistenciaTableAdapter.Fill(Me.isencoDataSet.Lista_Asistencia, principalOtrosRpt.cmbEspecialidad.Text, _
                                                  principalOtrosRpt.cmbSemestre.Text, principalOtrosRpt.cmbGrupo.Text, principalOtrosRpt.cmbCampus.Text, _
                                                  principalOtrosRpt.cmbLicenciatura.Text, principalOtrosRpt.cmbTurno.Text, _
                                                  principalOtrosRpt.cmbModalidad.Text, principalOtrosRpt.CmbParcial.Text)
            If principalOtrosRpt.CmbParcial.Text = "PRIMERA PARCIAL" Then
                Dim parameters As New List(Of ReportParameter)()
                parameters.Add(New ReportParameter("maestro", principalOtrosRpt.CmbDocentes.Text))
                parameters.Add(New ReportParameter("materia", principalOtrosRpt.CmbMaterias.Text))
                parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
                parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))
                ReportViewer1.LocalReport.SetParameters(parameters)
                Me.ReportViewer1.RefreshReport()
            Else
                Dim parameters As New List(Of ReportParameter)()
                parameters.Add(New ReportParameter("maestro", principalOtrosRpt.CmbDocentes.Text))
                parameters.Add(New ReportParameter("materia", principalOtrosRpt.CmbMaterias.Text))
                parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
                parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))
                ReportViewer2.LocalReport.SetParameters(parameters)
                Me.ReportViewer2.RefreshReport()
            End If
        Else
            Me.LISTA2TableAdapter.Fill(Me.isencoDataSet.LISTA2, principalOtrosRpt.cmbEspecialidad.Text, _
                                       principalOtrosRpt.cmbSemestre.Text, principalOtrosRpt.cmbGrupo.Text, _
                                       principalOtrosRpt.cmbCampus.Text, principalOtrosRpt.cmbLicenciatura.Text, _
                                       principalOtrosRpt.cmbTurno.Text, principalOtrosRpt.cmbModalidad.Text, principalOtrosRpt.CmbParcial.Text)
            Dim parameters As New List(Of ReportParameter)()
            parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
            parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))
            If principalOtrosRpt.CmbParcial.Text = "PRIMERA PARCIAL" Then
                ReportViewer3.LocalReport.SetParameters(parameters)
                Me.ReportViewer3.RefreshReport()
            Else
                ReportViewer4.LocalReport.SetParameters(parameters)
                Me.ReportViewer4.RefreshReport()
            End If
        End If
    End Sub
    Public Shared Sub actualizarReporte()
        impresionListas.ReportViewer1.RefreshReport()
        If SD = 0 Then
            impresionListas.Lista_AsistenciaTableAdapter.Fill(impresionListas.isencoDataSet.Lista_Asistencia, principalOtrosRpt.cmbEspecialidad.Text, _
                                                  principalOtrosRpt.cmbSemestre.Text, principalOtrosRpt.cmbGrupo.Text, principalOtrosRpt.cmbCampus.Text, _
                                                  principalOtrosRpt.cmbLicenciatura.Text, principalOtrosRpt.cmbTurno.Text, _
                                                  principalOtrosRpt.cmbModalidad.Text, principalOtrosRpt.CmbParcial.Text)
            If principalOtrosRpt.CmbParcial.Text = "PRIMERA PARCIAL" Then
                Dim parameters As New List(Of ReportParameter)()
                parameters.Add(New ReportParameter("maestro", principalOtrosRpt.CmbDocentes.Text))
                parameters.Add(New ReportParameter("materia", principalOtrosRpt.CmbMaterias.Text))
                parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
                parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))
                impresionListas.ReportViewer1.LocalReport.SetParameters(parameters)
                impresionListas.ReportViewer1.RefreshReport()
            Else
                Dim parameters As New List(Of ReportParameter)()
                parameters.Add(New ReportParameter("maestro", principalOtrosRpt.CmbDocentes.Text))
                parameters.Add(New ReportParameter("materia", principalOtrosRpt.CmbMaterias.Text))
                parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
                parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))
                impresionListas.ReportViewer2.LocalReport.SetParameters(parameters)
                impresionListas.ReportViewer2.RefreshReport()
            End If
        Else
            impresionListas.LISTA2TableAdapter.Fill(impresionListas.isencoDataSet.LISTA2, principalOtrosRpt.cmbEspecialidad.Text, _
                                       principalOtrosRpt.cmbSemestre.Text, principalOtrosRpt.cmbGrupo.Text, _
                                       principalOtrosRpt.cmbCampus.Text, principalOtrosRpt.cmbLicenciatura.Text, _
                                       principalOtrosRpt.cmbTurno.Text, principalOtrosRpt.cmbModalidad.Text, principalOtrosRpt.CmbParcial.Text)
            Dim parameters As New List(Of ReportParameter)()
            parameters.Add(New ReportParameter("ciclo", principalOtrosRpt.cbmCicloEscolar.Text))
            parameters.Add(New ReportParameter("turno", principalOtrosRpt.cmbTurno.Text))

            If principalOtrosRpt.CmbParcial.Text = "PRIMERA PARCIAL" Then
                impresionListas.ReportViewer3.LocalReport.SetParameters(parameters)
                impresionListas.ReportViewer3.RefreshReport()
            Else
                impresionListas.ReportViewer4.LocalReport.SetParameters(parameters)
                impresionListas.ReportViewer4.RefreshReport()
            End If
        End If
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
        "  <PageWidth>35.56cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try

            If principalOtrosRpt.CmbParcial.Text = "PRIMERA PARCIAL" Then
                If SD = 0 Then
                    bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer1.LocalReport.ReportPath = "Lista_de_Asistencia.rdl"
                Else
                    bytes = ReportViewer3.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer3.LocalReport.ReportPath = "Lista_de_AsistenciaSD.rdl"
                End If
            Else
                If SD = 0 Then
                    bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer2.LocalReport.ReportPath = "Lista_de_Asistencia2.rdl"
                Else
                    bytes = ReportViewer4.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer4.LocalReport.ReportPath = "Lista_de_AsistenciaSD2.rdl"
                End If
            End If
            Dim fs As New FileStream("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        PDF()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click

    End Sub
End Class