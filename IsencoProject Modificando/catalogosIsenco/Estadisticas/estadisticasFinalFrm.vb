Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class estadisticasFinalFrm


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

    Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click
        Dim i As Integer = 0
        variables.licenciatura = ListBox1.SelectedItem.ToString
        variables.semestre = ""
        For i = 0 To 4
            variables.campus_L(i) = ""
        Next
        i = 0
        For Each item As Object In ListBox2.SelectedItems
            variables.campus_L(i) = item
            i = i + 1
        Next
        For Each item As Object In ListBox3.SelectedItems
            variables.semestre = variables.semestre & item & ","
        Next
        If variables.licenciatura = "LICENCIATURA" Then
            variables.licenciatura = "EDUCA"
        End If

        generarReporte()
    End Sub
    Private Sub generarReporte()
        Dim parameters As New List(Of ReportParameter)()
        If variables.semestre.Contains("1") Then
            parameters.Add(New ReportParameter("semestre1", 1))
        Else
            parameters.Add(New ReportParameter("semestre1", 0))
        End If
        If variables.semestre.Contains("2") Then
            parameters.Add(New ReportParameter("semestre2", 1))
        Else
            parameters.Add(New ReportParameter("semestre2", 0))
        End If
        If variables.semestre.Contains("3") Then
            parameters.Add(New ReportParameter("semestre3", 1))
        Else
            parameters.Add(New ReportParameter("semestre3", 0))
        End If
        If variables.semestre.Contains("4") Then
            parameters.Add(New ReportParameter("semestre4", 1))
        Else
            parameters.Add(New ReportParameter("semestre4", 0))
        End If
        If variables.semestre.Contains("5") Then
            parameters.Add(New ReportParameter("semestre5", 1))
        Else
            parameters.Add(New ReportParameter("semestre5", 0))
        End If
        If variables.semestre.Contains("6") Then
            parameters.Add(New ReportParameter("semestre6", 1))
        Else
            parameters.Add(New ReportParameter("semestre6", 0))
        End If
        If variables.semestre.Contains("7") Then
            parameters.Add(New ReportParameter("semestre7", 1))
        Else
            parameters.Add(New ReportParameter("semestre7", 0))
        End If
        If variables.semestre.Contains("8") Then
            parameters.Add(New ReportParameter("semestre8", 1))
        Else
            parameters.Add(New ReportParameter("semestre8", 0))
        End If

        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_2' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_2TableAdapter.Fill(Me.reportesDT.estadisticasfinal_2, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_4' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_4TableAdapter.Fill(Me.reportesDT.estadisticasfinal_4, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_6' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_6TableAdapter.Fill(Me.reportesDT.estadisticasfinal_6, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_7' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_7TableAdapter.Fill(Me.reportesDT.estadisticasfinal_7, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_8' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_8TableAdapter.Fill(Me.reportesDT.estadisticasfinal_8, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_5' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_5TableAdapter.Fill(Me.reportesDT.estadisticasfinal_5, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_3' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_3TableAdapter.Fill(Me.reportesDT.estadisticasfinal_3, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal_1' table. You can move, or remove it, as needed.
        Me.estadisticasfinal_1TableAdapter.Fill(Me.reportesDT.estadisticasfinal_1, variables.licenciatura, variables.campus_L(0), variables.campus_L(1), variables.campus_L(2), variables.campus_L(3))
        'TODO: This line of code loads data into the 'reportesDT.estadisticasfinal' table. You can move, or remove it, as needed.
        ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.Refresh()
        ReportViewer1.Refresh()
    End Sub
End Class