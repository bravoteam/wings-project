Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Public Class imprimirBoleta

    Private Sub imprimirBoleta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'acreditacionDataSet.promedio' table. You can move, or remove it, as needed.
            Me.promedioTableAdapter.Fill(Me.isencoDataSet.promedio, variables.matricula, _
                                         variables.IdLice, variables.grupo, variables.semestre)
            'TODO: This line of code loads data into the 'acreditacionDataSet.directivos1' table. You can move, or remove it, as needed.
            Me.directivos1TableAdapter.Fill(Me.isencoDataSet.directivos1)
            'TODO: This line of code loads data into the 'acreditacionDataSet.boleta' table. You can move, or remove it, as needed.
            Me.boletaTableAdapter.Fill(Me.isencoDataSet.boleta, variables.campus, _
                                      variables.licenciatura, variables.especialidad, _
                                        variables.semestre, variables.grupo, _
                                       Val(variables.IdLice), _
                                       variables.matricula)
            'TODO: This line of code loads data into the 'acreditacionDataSet.directivos' table. You can move, or remove it, as needed.

            'Me.directivosTableAdapter.Fill(Me.isencoDataSet.directivos, variables.matricula)
            Me.ciclo_escolarTableAdapter.Fill(Me.isencoDataSet.ciclo_escolar)
            Dim b As New BaseDatos
            Dim SQLdr2 As SqlDataReader
            Dim sql As String = ""
            Dim i As Integer = 0
            Dim firmas As String = ""
            Dim fecha As Date
            Select Case variables.campus
                Case "CUAUHTEMOC"
                    sql = "select firmas,fecha from boletaConfig where campus='" & variables.campus & "' " & _
                                        "and licenciatura='" & variables.licenciatura & "' "
                Case Else
                    sql = "select firmas,fecha from boletaConfig where campus='" & variables.campus & "' "
            End Select
            b.abrirConexion()
            Dim cmd As New SqlCommand(sql, b.Conexion)
            SQLdr2 = cmd.ExecuteReader
            While (SQLdr2.Read())
                firmas = SQLdr2("firmas").ToString
                fecha = SQLdr2("fecha")
            End While
            b.cerrarConexion()
            'Se valida si eligieron otra fecha
            If variables.usaFecha = 1 Then
                fecha = modificacionCalifFrm.dt1.Value
            End If
            Dim parameters As New List(Of ReportParameter)()
            parameters.Add(New ReportParameter("coordinador", firmas))
            parameters.Add(New ReportParameter("dia", Format(fecha, "dd")))
            parameters.Add(New ReportParameter("mes", UCase(Format(fecha, "MMMM"))))
            parameters.Add(New ReportParameter("anio", Format(fecha, "yyyy")))
            parameters.Add(New ReportParameter("semestre", variables.semestre))
            parameters.Add(New ReportParameter("param", variables.param))
            parameters.Add(New ReportParameter("ciclo", variables.ciclo))
            Me.ReportViewer1.LocalReport.SetParameters(parameters)

            Me.ReportViewer1.RefreshReport()
        Catch
            Exit Sub
        End Try
    End Sub
    Private Sub printPDF()
        With New Process
            .StartInfo.Verb = "print"
            .StartInfo.CreateNoWindow = False
            .StartInfo.FileName = "C:\ISENCO\" & variables.matricula & "_boleta.pdf"
            .Start()
            .WaitForExit(10000)
            If .HasExited = False Then
                .CloseMainWindow()
            End If
            .Close()
        End With
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
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
        Dim fs As New FileStream("C:\ISENCO\" & variables.matricula & "_boleta.pdf", FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        '        printPDF()
        Process.Start("C:\ISENCO\" & variables.matricula & "_boleta.pdf")
        Me.Close()
    End Sub
End Class