﻿Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class Reporte_Reprobadas
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
        "  <PageWidth>21.59cm</PageWidth>" +
        "  <PageHeight>29.7cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "Reporte_Reprobadas.rdl"
            Dim fs As New FileStream("C:\ISENCO\" & "Reporte_Reprobadas" & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & "Reporte_Reprobadas" & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GenerarPDFToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPDFToolStripMenuItem1.Click
        pdf()
    End Sub

    Private Sub Reporte_Reprobadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportesDT.REPROBADAS_PRIMERA_SEGUNDA' table. You can move, or remove it, as needed.
        Me.ciclo_escolarTableAdapter.Fill(Me.ReportesDT.ciclo_escolar)
        Me.MujeresTableAdapter.Fill(Me.ReportesDT.Mujeres, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.HombresTableAdapter.Fill(Me.ReportesDT.Hombres, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.TotalHombresMujeresTableAdapter.Fill(Me.ReportesDT.TotalHombresMujeres, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.REPROBADAS_PRIMERA_SEGUNDATableAdapter.Fill(Me.ReportesDT.REPROBADAS_PRIMERA_SEGUNDA, FrmMain.cmbEspecialidad.Text, FrmMain.cmbSemestre.Text, FrmMain.cmbGrupo.Text, FrmMain.cmbCampus.Text, IdLice, FrmMain.cmbTurno.Text, FrmMain.cmbModalidad.Text)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class