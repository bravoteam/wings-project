Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class estadisticasFinalFrm

    Private Sub estadisticasFinalFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_2' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_2TableAdapter.Fill(Me.reportesDT.estadisticasfinal_2, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_4' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_4TableAdapter.Fill(Me.reportesDT.estadisticasfinal_4, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_6' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_6TableAdapter.Fill(Me.reportesDT.estadisticasfinal_6, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_7' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_7TableAdapter.Fill(Me.reportesDT.estadisticasfinal_7, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_8' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_8TableAdapter.Fill(Me.reportesDT.estadisticasfinal_8, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_5' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_5TableAdapter.Fill(Me.reportesDT.estadisticasfinal_5, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_3' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_3TableAdapter.Fill(Me.reportesDT.estadisticasfinal_3, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_1' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_1TableAdapter.Fill(Me.reportesDT.estadisticasfinal_1, variables.licenciatura)
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal' table. You can move, or remove it, as needed.

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