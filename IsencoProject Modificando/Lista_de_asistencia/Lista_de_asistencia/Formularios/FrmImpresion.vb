Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class FrmImpresion

    Private Sub FrmImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SD = 0 Then
            Me.Lista_AsistenciaTableAdapter1.Fill(Me.listaAsistenciaDT.Lista_Asistencia, FrmListas.cmbEspecialidad.Text, _
                                                  FrmListas.cmbSemestre.Text, FrmListas.cmbGrupo.Text, FrmListas.cmbCampus.Text, _
                                                  FrmListas.cmbLicenciatura.Text, FrmListas.cmbTurno.Text, _
                                                  FrmListas.cmbModalidad.Text, FrmListas.CmbParcial.Text)
            If FrmListas.CmbParcial.Text = "PRIMERA PARCIAL" Then
                Dim parameters As New List(Of ReportParameter)()
                parameters.Add(New ReportParameter("maestro", FrmListas.CmbDocentes.Text))
                parameters.Add(New ReportParameter("materia", FrmListas.CmbMaterias.Text))
                ReportViewer1.LocalReport.SetParameters(parameters)
                Me.ReportViewer1.RefreshReport()
            Else
                Dim parameters As New List(Of ReportParameter)()
                parameters.Add(New ReportParameter("maestro", FrmListas.CmbDocentes.Text))
                parameters.Add(New ReportParameter("materia", FrmListas.CmbMaterias.Text))
                ReportViewer2.LocalReport.SetParameters(parameters)
                Me.ReportViewer2.RefreshReport()
            End If
        Else
            Me.LISTA2TableAdapter.Fill(Me.listaAsistenciaDT.LISTA2, FrmListas.cmbEspecialidad.Text, FrmListas.cmbSemestre.Text, FrmListas.cmbGrupo.Text, FrmListas.cmbCampus.Text, FrmListas.cmbLicenciatura.Text, FrmListas.cmbTurno.Text, FrmListas.cmbModalidad.Text, FrmListas.CmbParcial.Text)
            If FrmListas.CmbParcial.Text = "PRIMERA PARCIAL" Then
                Me.ReportViewer3.RefreshReport()
            Else
                Me.ReportViewer4.RefreshReport()
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

            If FrmListas.CmbParcial.Text = "PRIMERA PARCIAL" Then
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
            Dim fs As New FileStream("C:\ISENCO\" & FrmListas.cmbLicenciatura.Text & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & FrmListas.cmbLicenciatura.Text & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click
        PDF()
    End Sub
End Class