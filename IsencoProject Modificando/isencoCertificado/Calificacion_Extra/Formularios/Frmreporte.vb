Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class Frmreporte

    Private Sub Frmreporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_tercero' table. You can move, or remove it, as needed.
        Me.TercerSemestreTableAdapter.Fill(Me.isencoDataSet.tercerSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_Cuarto' table. You can move, or remove it, as needed.
        Me.CuartoSemestreTableAdapter.Fill(Me.isencoDataSet.cuartoSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_QUINTO' table. You can move, or remove it, as needed.
        Me.QuintoSemestreTableAdapter.Fill(Me.isencoDataSet.quintoSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_SEXTO' table. You can move, or remove it, as needed.
        Me.SextoSemestreTableAdapter.Fill(Me.isencoDataSet.sextoSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_SEPTIMO' table. You can move, or remove it, as needed.
        Me.SeptimoSemestreTableAdapter.Fill(Me.isencoDataSet.septimoSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_OCTAVO' table. You can move, or remove it, as needed.
        Me.OctavoSemestreTableAdapter.Fill(Me.isencoDataSet.octavoSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_SEGUNDO' table. You can move, or remove it, as needed.
        Me.SegundoSemestreTableAdapter.Fill(Me.isencoDataSet.segundoSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificado_PRIMER' table. You can move, or remove it, as needed.
        Me.PrimerSemestreTableAdapter.Fill(Me.isencoDataSet.primerSemestre, Frmalumnos.txtmatricula.Text)
        'TODO: This line of code loads data into the 'isencoDataSet.certificados' table. You can move, or remove it, as needed.
        Me.certificadosTableAdapter.Fill(Me.isencoDataSet.certificados, Frmalumnos.txtmatricula.Text)
        Me.ReportViewer1.RefreshReport()
        '  Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
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
        "  <PageWidth>24cm</PageWidth>" +
        "  <PageHeight>30cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        ReportViewer1.LocalReport.ReportPath = "certificado_cara.rdl"
        Dim fs As New FileStream("C:\ISENCO\" & Frmalumnos.nombreTxt.Text & "_Certificado_CARA.pdf", FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()

        bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        ReportViewer2.LocalReport.ReportPath = "certificado_CONTRA.rdl"
        fs = New FileStream("C:\ISENCO\" & Frmalumnos.nombreTxt.Text & "_Certificado_CONTRA.pdf", FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()

        'printPDF()
        Process.Start("C:\ISENCO\" & Frmalumnos.nombreTxt.Text & "_Certificado_CONTRA.pdf")
        Me.Close()
        'printPDF()
        Process.Start("C:\ISENCO\" & Frmalumnos.nombreTxt.Text & "_Certificado_CARA.pdf")
        Me.Close()

        MsgBox("Exportado")
    End Sub

End Class