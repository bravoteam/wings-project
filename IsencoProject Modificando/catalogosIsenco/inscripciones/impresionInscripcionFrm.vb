Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class impresionInscripcionFrm

    Private Sub impresionInscripcionFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Public Sub actualizarReportes()
        'TODO: This line of code loads data into the 'inscripcion.imss' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'inscripcion.Documentos_alumnos_entregados' table. You can move, or remove it, as needed.
        Dim parameters As New ReportParameter
        parameters = New ReportParameter("faltaDocs", variables.faltaDocs)
        Me.ReportViewer5.LocalReport.SetParameters(parameters)
        

        Me.Documentos_alumnos_entregadosTableAdapter.Fill(Me.inscripcion.Documentos_alumnos_entregados, variables.idalumno)
        'TODO: This line of code loads data into the 'inscripcion.Documentos_alumnos_entregados' table. You can move, or remove it, as needed.
        Me.Documentos_alumnos_entregadosTableAdapter.Fill(Me.inscripcion.Documentos_alumnos_entregados, variables.idalumno)
        'TODO: This line of code loads data into the 'inscripcion.Documentos_alumnos' table. You can move, or remove it, as needed.
        Me.Documentos_alumnosTableAdapter.Fill(Me.inscripcion.Documentos_alumnos, variables.idalumno)
        'TODO: This line of code loads data into the 'inscripcion.Documentos_alumnos' table. You can move, or remove it, as needed.
        Me.Documentos_alumnosTableAdapter.Fill(Me.inscripcion.Documentos_alumnos, variables.idalumno)
        'TODO: This line of code loads data into the 'inscripcion.Documentos_alumnos' table. You can move, or remove it, as needed.
        Me.Documentos_alumnosTableAdapter.Fill(Me.inscripcion.Documentos_alumnos, variables.idalumno)
        'TODO: This line of code loads data into the 'inscripcion.Documentos_alumnos' table. You can move, or remove it, as needed.
        Me.Documentos_alumnosTableAdapter.Fill(Me.inscripcion.Documentos_alumnos, variables.idalumno)
        'TODO: This line of code loads data into the 'inscripcion.imss' table. You can move, or remove it, as needed.
        Me.imssTableAdapter.Fill(Me.inscripcion.imss, variables.idalumno)

        Me.ReportViewer7.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
        Me.ReportViewer4.RefreshReport()
        Me.ReportViewer5.RefreshReport()
        'esta parte es para ocultar la pestaña que quieras
        'Me.TabPage3.Parent = Nothing
        Me.ReportViewer6.RefreshReport()

        'If variables.licenciatura = "CENTRO DE ESTUDIOS DE BACHILLERATO" Then
        '    Me.TabPage2.Parent = Nothing
        'Else
        '    Me.TabPage1.Parent = Nothing
        'End If
        'If variables.promedio > 8 Then
        '    Me.TabPage4.Parent = Nothing
        'End If
        'If variables.faltaDocs = "" Then
        '    Me.TabPage5.Parent = Nothing
        'End If

    End Sub
    Public Sub PDF()
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
        "  <PageHeight>27.94cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            'IMSS
            bytes = ReportViewer7.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer7.LocalReport.ReportPath = "imss.rdlc"
            Dim fs As New FileStream("C:\ISENCO\" & "imss" & variables.idalumno & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & "imss" & variables.idalumno & ".pdf")

            'If variables.licenciatura = "CENTRO DE ESTUDIOS DE BACHILLERATO" Then
            '    'FICHABACHI
            '    bytes = ReportViewer3.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            '    ReportViewer3.LocalReport.ReportPath = "FICHA DE BACHILLERATO.rdlc"
            '    fs = New FileStream("C:\ISENCO\" & "FICHABACH" & variables.idalumno & ".pdf", FileMode.Create)
            '    fs.Write(bytes, 0, bytes.Length)
            '    fs.Close()
            '    Process.Start("C:\ISENCO\" & "FICHABACH" & variables.idalumno & ".pdf")
            'Else
            '    'FICHALIC
            '    bytes = ReportViewer4.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            '    ReportViewer4.LocalReport.ReportPath = "FICHA DE LICENCIATURA.rdlc"
            '    fs = New FileStream("C:\ISENCO\" & "FICHALIC" & variables.idalumno & ".pdf", FileMode.Create)
            '    fs.Write(bytes, 0, bytes.Length)
            '    fs.Close()
            '    Process.Start("C:\ISENCO\" & "FICHALIC" & variables.idalumno & ".pdf")
            'End If

            ''BIENVENIDA
            'bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            'ReportViewer1.LocalReport.ReportPath = "bienvenida.rdlc"
            'fs = New FileStream("C:\ISENCO\" & "BIENVENIDA" & variables.idalumno & ".pdf", FileMode.Create)
            'fs.Write(bytes, 0, bytes.Length)
            'fs.Close()
            'Process.Start("C:\ISENCO\" & "BIENVENIDA" & variables.idalumno & ".pdf")
            'If variables.promedio < 8 Then
            '    'COMPROMISOPROMEDIO
            '    bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            '    ReportViewer2.LocalReport.ReportPath = "carta_compromiso_promedio.rdlc"
            '    fs = New FileStream("C:\ISENCO\" & "PROMEDIO" & variables.idalumno & ".pdf", FileMode.Create)
            '    fs.Write(bytes, 0, bytes.Length)
            '    fs.Close()
            '    Process.Start("C:\ISENCO\" & "PROMEDIO" & variables.idalumno & ".pdf")
            'End If
            'If variables.faltaDocs <> "" Then
            '    'COMPROMISODOCUSN
            '    bytes = ReportViewer5.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            '    ReportViewer5.LocalReport.ReportPath = "Carta_Compromiso_tem.rdlc"
            '    fs = New FileStream("C:\ISENCO\" & "COMPROMISO" & variables.idalumno & ".pdf", FileMode.Create)
            '    fs.Write(bytes, 0, bytes.Length)
            '    fs.Close()
            '    Process.Start("C:\ISENCO\" & "COMPROMISO" & variables.idalumno & ".pdf")
            'End If

            ''DOCUEMNTOS
            'bytes = ReportViewer6.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            'ReportViewer6.LocalReport.ReportPath = "documentos_lic.rdlc"
            'fs = New FileStream("C:\ISENCO\" & "DOCUMENTOS" & variables.idalumno & ".pdf", FileMode.Create)
            'fs.Write(bytes, 0, bytes.Length)
            'fs.Close()
            'Process.Start("C:\ISENCO\" & "DOCUMENTOS" & variables.idalumno & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

    Private Sub ReimprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReimprimirToolStripMenuItem.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "RPinscripcion"
        variables.idesp = 20
        frmBuscarAlumno.Show()
    End Sub

    Private Sub ReportViewer2_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer2.Load

    End Sub
End Class