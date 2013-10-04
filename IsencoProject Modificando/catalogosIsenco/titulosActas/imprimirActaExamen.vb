Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class imprimirActaExamen

    Private Sub imprimirActaExamen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        actualizarReporte()
        actualizarReporte()
    End Sub
    Private Sub actualizarReporte()
        Me.examen_profesionalTableAdapter.Fill(Me.reportesDT.examen_profesional, variables.idExamen)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        actualizarReporte()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
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
        "  <PageWidth>23cm</PageWidth>" +
        "  <PageHeight>30cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "acta_cara.rdl"
            Dim fs As New FileStream("C:\ISENCO\ACT" & llenarActaExamen.txtNombre.Text & "_CARA.pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "acta_contra.rdl"
            fs = New FileStream("C:\ISENCO\ACT" & llenarActaExamen.txtNombre.Text & "_CONTRA.pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\ACT" & llenarActaExamen.txtNombre.Text & "_CARA.pdf")
            Process.Start("C:\ISENCO\ACT" & llenarActaExamen.txtNombre.Text & "_CONTRA.pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class