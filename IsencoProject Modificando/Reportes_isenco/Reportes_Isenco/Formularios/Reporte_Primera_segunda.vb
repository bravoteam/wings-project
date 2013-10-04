Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class Reporte_Primera_segunda
    Private Sub pdf()
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
        "  <PageWidth>29.7cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "Reporte_Primera_Segunda_Parcial.rdl"
            Dim fs As New FileStream("C:\ISENCO\" & "Reporte_Primera_Segunda_Parcial" & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & "Reporte_Primera_Segunda_Parcial" & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
    Private Sub Reporte_Primera_segunda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportesDT.calificaciones2parcial1' table. You can move, or remove it, as needed.
        Me.ciclo_escolarTableAdapter.Fill(Me.ReportesDT.ciclo_escolar)
        Me.ciclo_escolarTableAdapter.Fill(Me.ReportesDT.ciclo_escolar)
        Me.MujeresTableAdapter.Fill(Me.ReportesDT.Mujeres, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.HombresTableAdapter.Fill(Me.ReportesDT.Hombres, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.TotalHombresMujeresTableAdapter.Fill(Me.ReportesDT.TotalHombresMujeres, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.calificaciones2parcial1TableAdapter.Fill(Me.ReportesDT.calificaciones2parcial1, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub GenerarPDFToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPDFToolStripMenuItem1.Click
        pdf()
    End Sub
End Class