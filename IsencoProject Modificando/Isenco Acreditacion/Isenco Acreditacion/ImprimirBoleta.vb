﻿Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Public Class ImprimirBoleta

    Private Sub ImprimirBoleta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'acreditacionDataSet.promedio' table. You can move, or remove it, as needed.
        Me.promedioTableAdapter.Fill(Me.acreditacionDataSet.promedio, Calificacion.DG(0, Calificacion.DG.CurrentCell.RowIndex).Value.ToString)
        'TODO: This line of code loads data into the 'acreditacionDataSet.directivos1' table. You can move, or remove it, as needed.
        Me.directivos1TableAdapter.Fill(Me.acreditacionDataSet.directivos1)
        'TODO: This line of code loads data into the 'acreditacionDataSet.boleta' table. You can move, or remove it, as needed.
        Me.boletaTableAdapter.Fill(Me.acreditacionDataSet.boleta, Calificacion.DG(0, Calificacion.DG.CurrentCell.RowIndex).Value.ToString)
        'TODO: This line of code loads data into the 'acreditacionDataSet.directivos' table. You can move, or remove it, as needed.
        Me.directivosTableAdapter.Fill(Me.acreditacionDataSet.directivos, Calificacion.DG(0, Calificacion.DG.CurrentCell.RowIndex).Value.ToString)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim deviceInfo As String
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim bytes As Byte()

        deviceInfo = "<DeviceInfo>" +
        "<OutputFormat>PDF</OutputFormat>" +
        "  <PageWidth>21.59cm</PageWidth>" +
        "  <PageHeight>27.94cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        ReportViewer1.LocalReport.ReportPath = "Report1.rdl"
        Dim fs As New FileStream("C:\ISENCO\" & Calificacion.DG(0, Calificacion.DG.CurrentCell.RowIndex).Value.ToString & "_boleta.pdf", FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        '        printPDF()
        Process.Start("C:\ISENCO\" & Calificacion.DG(0, Calificacion.DG.CurrentCell.RowIndex).Value.ToString & "_boleta.pdf")
        Me.Close()
    End Sub
    Private Sub printPDF()
        With New Process
            .StartInfo.Verb = "print"
            .StartInfo.CreateNoWindow = False
            .StartInfo.FileName = "C:\ISENCO\" & Calificacion.DG(0, Calificacion.DG.CurrentCell.RowIndex).Value.ToString & "_boleta.pdf"
            .Start()
            .WaitForExit(10000)
            If .HasExited = False Then
                .CloseMainWindow()
            End If
            .Close()
        End With
    End Sub

    Private Sub ReportViewer1_StatusChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportViewer1.StatusChanged

    End Sub
End Class