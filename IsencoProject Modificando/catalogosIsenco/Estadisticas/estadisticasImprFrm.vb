Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class estadisticasImprFrm

    Private Sub estadisticasImprFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'reportesDT.estadisticasDt' table. You can move, or remove it, as needed.
        Dim parameters As New ReportParameter

        parameters = New ReportParameter("CICLO", "2012-2013")
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.estadisticasDtTableAdapter.Fill(Me.reportesDT.estadisticasDt, variables.campus)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
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
            'ReportViewer1.LocalReport.ReportPath = "Impr_HyM.rdl"
            Me.ReportViewer1.RefreshReport()


            Dim fs As New FileStream("C:\ISENCO\" & estadisticasFrm.cmbCampus.Text & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & estadisticasFrm.cmbCampus.Text & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class