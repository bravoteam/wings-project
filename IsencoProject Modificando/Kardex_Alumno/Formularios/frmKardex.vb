Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class frmKardex

    Private Sub frmKardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KardexAlumnoDT.promedio' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'KardexAlumnoDT.alumno' table. You can move, or remove it, as needed.
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("maestro1", frmdocente.Cmbmaestro.Text))
        parameters.Add(New ReportParameter("maestro2", frmdocente.Cmbmaestro2.Text))
        parameters.Add(New ReportParameter("maestro3", frmdocente.Cmbmaestro3.Text))
        parameters.Add(New ReportParameter("maestro4", frmdocente.Cmbmaestro4.Text))
        parameters.Add(New ReportParameter("Periodo", frmBuscarAlumbo.UDPeriodo.Value))
        parameters.Add(New ReportParameter("fecha1", CDate(frmdocente.DtpFecha.Text)))
        parameters.Add(New ReportParameter("fecha2", CDate(frmdocente.DtpFecha2.Text)))
        parameters.Add(New ReportParameter("fecha3", CDate(frmdocente.Dtpfecha3.Text)))
        parameters.Add(New ReportParameter("fecha4", CDate(frmdocente.DtpFecha4.Text)))

        Dim parameters1 As New List(Of ReportParameter)()

        parameters1.Add(New ReportParameter("fecha5", CDate(frmdocente.DtpFecha5.Text)))
        parameters1.Add(New ReportParameter("fecha6", CDate(frmdocente.DtpFecha6.Text)))
        parameters1.Add(New ReportParameter("fecha7", CDate(frmdocente.DtpFecha7.Text)))
        parameters1.Add(New ReportParameter("fecha8", CDate(frmdocente.DtpFecha8.Text)))

        parameters1.Add(New ReportParameter("maestro5", frmdocente.Cmbmaestro5.Text))
        parameters1.Add(New ReportParameter("maestro6", frmdocente.Cmbmaestro6.Text))
        parameters1.Add(New ReportParameter("maestro7", frmdocente.Cmbmaestro7.Text))
        parameters1.Add(New ReportParameter("maestro8", frmdocente.Cmbmaestro8.Text))

        Me.ReportViewer2.LocalReport.SetParameters(parameters1)
        Me.ReportViewer1.LocalReport.SetParameters(parameters)

        Me.alumnoTableAdapter.Fill(Me.KardexAlumnoDT.alumno, frmdocente.lblMatricula.Text)
        Me.Quinto_semestreTableAdapter.Fill(Me.KardexAlumnoDT.Quinto_semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.Sexto_semestreTableAdapter.Fill(Me.KardexAlumnoDT.Sexto_semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.Septimo_semestreTableAdapter.Fill(Me.KardexAlumnoDT.Septimo_semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.Octavo_semestreTableAdapter.Fill(Me.KardexAlumnoDT.Octavo_semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.Segundo_semestreTableAdapter.Fill(Me.KardexAlumnoDT.Segundo_semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.Tercer_semestreTableAdapter.Fill(Me.KardexAlumnoDT.Tercer_semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.Cuarto_semestreTableAdapter.Fill(Me.KardexAlumnoDT.Cuarto_semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.Primer_SemestreTableAdapter.Fill(Me.KardexAlumnoDT.Primer_Semestre, frmdocente.lblMatricula.Text, frmdocente.lblID.Text)
        Me.promedioTableAdapter.Fill(Me.KardexAlumnoDT.promedio, frmdocente.lblMatricula.Text)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.Text = frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("NOMBRE").Value.ToString() & " " & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("APELLIDO_PATERNO").Value.ToString() & " " & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("APELLIDO_MATERNO").Value.ToString()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub PDF()
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
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "Kardex_alumno.rdl"
            Dim fs As New FileStream("C:\ISENCO\" & "Kardex-Cara" & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("matricula").Value.ToString() & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer2.LocalReport.ReportPath = "Kardex_alumno_contra.rdl"

            Dim fs1 As New FileStream("C:\ISENCO\" & "Kardex-Contra" & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("matricula").Value.ToString() & ".pdf", FileMode.Create)
            fs1.Write(bytes, 0, bytes.Length)
            fs1.Close()

            Process.Start("C:\ISENCO\" & "Kardex-Cara" & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("matricula").Value.ToString() & ".pdf")
            Process.Start("C:\ISENCO\" & "Kardex-Contra" & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("matricula").Value.ToString() & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

    Private Sub GenerarArchivoAImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarArchivoAImprimirToolStripMenuItem.Click
        PDF()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class
