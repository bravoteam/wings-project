Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class estadisticasFinalFrm

    Private Sub estadisticasFinalFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal' table. You can move, or remove it, as needed.
        Me.estadisticasfinalTableAdapter.Fill(Me.reportesDT.estadisticasfinal)

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        PDF()
    End Sub
    Private Sub PDF()
        Dim deviceInfo As String
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
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            Me.ReportViewer1.RefreshReport()


            Dim fs As New FileStream("C:\ISENCO\estadisticas.pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\estadisticas.pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class