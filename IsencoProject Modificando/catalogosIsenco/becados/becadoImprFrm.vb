Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class becadoImprFrm

    Private Sub becadoImprFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'reportesDT.becadosDt' table. You can move, or remove it, as needed.
        Me.becadosDtTableAdapter.Fill(Me.reportesDT.becadosDt, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)

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
        Try
            deviceInfo = "<DeviceInfo>" +
            "<OutputFormat>PDF</OutputFormat>" +
            "  <PageWidth>35.56cm</PageWidth>" +
            "  <PageHeight>21.59cm</PageHeight>" +
            "  <MarginTop>0cm</MarginTop>" +
            "  <MarginLeft>0cm</MarginLeft>" +
            "  <MarginRight>0cm</MarginRight>" +
            "  <MarginBottom>0cm</MarginBottom>" +
            "</DeviceInfo>"

            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            'ReportViewer1.LocalReport.ReportPath = "becados.rdlc"
            Me.ReportViewer1.RefreshReport()

            Dim fs As New FileStream("C:\ISENCO\" & becados.cmbCampus.Text & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & becados.cmbCampus.Text & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class