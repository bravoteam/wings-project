Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class credencialFrm

    Private Sub credencialFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'isencoDataSet.LISTA_FOTOS' table. You can move, or remove it, as needed.
        Me.LISTA_FOTOSTableAdapter.Fill(Me.isencoDataSet.LISTA_FOTOS, "", "1", "C", "CUAUHTEMOC", "EDUCACIÓN PRIMARIA", "TV", "E")

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        PDF()
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
        "  <PageWidth>20cm</PageWidth>" +
        "  <PageHeight>20cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "credencialRpt.rdlc"
            Dim fs As New FileStream("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & "credencial.pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & principalOtrosRpt.cmbLicenciatura.Text & "credencial.pdf")
        Catch ex As Exception

        End Try
    End Sub
End Class