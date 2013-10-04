Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class imprimeCertificadoFrm

    Private Sub imprimeCertificadoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'isencoDataSet.tercerSemestre' table. You can move, or remove it, as needed.
        Me.tercerSemestreTableAdapter.Fill(Me.isencoDataSet.tercerSemestre, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.cuartoSemestre' table. You can move, or remove it, as needed.
        Me.cuartoSemestreTableAdapter.Fill(Me.isencoDataSet.cuartoSemestre, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.quintoSemestre' table. You can ove, or remove it, as needed.
        Me.quintoSemestreTableAdapter.Fill(Me.isencoDataSet.quintoSemestre, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.sextoSemestre' table. You can move, or remove it, as needed.
        Me.sextoSemestreTableAdapter.Fill(Me.isencoDataSet.sextoSemestre, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.septimoSemestre' table. You can move, or remove it, as needed.
        Me.septimoSemestreTableAdapter.Fill(Me.isencoDataSet.septimoSemestre, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.octavoSemestre' table. You can move, or remove it, as needed.
        Me.octavoSemestreTableAdapter.Fill(Me.isencoDataSet.octavoSemestre, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.primerSemestre' table. You can move, or remove it, as needed.
        Me.primerSemestreTableAdapter.Fill(Me.isencoDataSet.primerSemestre, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.segundoSemestre' table. You can move, or remove it, as needed.
        Me.segundoSemestreTableAdapter.Fill(Me.isencoDataSet.segundoSemestre, variables.matriculaValor)
        Me.certificadosTableAdapter.Fill(Me.isencoDataSet.certificados, variables.matriculaValor)
        'TODO: This line of code loads data into the 'isencoDataSet.certificados' table. You can move, or remove it, as needed.
        Me.certificadosTableAdapter.Fill(Me.isencoDataSet.certificados, variables.matriculaValor)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub pdf()
        Dim deviceInfo As String
        'Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim bytes As Byte()
        Try

            deviceInfo = "<DeviceInfo>" +
            "<OutputFormat>PDF</OutputFormat>" +
            "  <PageWidth>24cm</PageWidth>" +
            "  <PageHeight>30cm</PageHeight>" +
            "  <MarginTop>0cm</MarginTop>" +
            "  <MarginLeft>0cm</MarginLeft>" +
            "  <MarginRight>0cm</MarginRight>" +
            "  <MarginBottom>0cm</MarginBottom>" +
            "</DeviceInfo>"
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "certificado_cara.rdl"
            Dim fs As New FileStream("C:\ISENCO\" & variables.nombreAlumno & "_Certificado_CARA.pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer2.LocalReport.ReportPath = "certificado_CONTRA.rdl"
            fs = New FileStream("C:\ISENCO\" & variables.nombreAlumno & "_Certificado_CONTRA.pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            'printPDF()
            Process.Start("C:\ISENCO\" & variables.nombreAlumno & "_Certificado_CONTRA.pdf")
            Me.Close()
            'printPDF()
            Process.Start("C:\ISENCO\" & variables.nombreAlumno & "_Certificado_CARA.pdf")
            Me.Close()

            MsgBox("Exportado")
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        pdf()
    End Sub
End Class