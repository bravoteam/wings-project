Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class imprimirKardexFrm

    Private Sub imprimirKardexFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        actualizarRep()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        PDF()
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
            Dim fs As New FileStream("C:\ISENCO\" & "Kardex-Cara" & variables.matricula & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer2.LocalReport.ReportPath = "Kardex_alumno_contra.rdl"

            Dim fs1 As New FileStream("C:\ISENCO\" & "Kardex-Contra" & variables.matricula & ".pdf", FileMode.Create)
            fs1.Write(bytes, 0, bytes.Length)
            fs1.Close()

            Process.Start("C:\ISENCO\" & "Kardex-Cara" & variables.matricula & ".pdf")
            Process.Start("C:\ISENCO\" & "Kardex-Contra" & variables.matricula & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        actualizarRep()
    End Sub
    Private Sub actualizarRep()
        'TODO: This line of code loads data into the 'isencoDataSet.directivos1' table. You can move, or remove it, as needed.
        Me.directivos1TableAdapter.Fill(Me.isencoDataSet.directivos1)
        'TODO: This line of code loads data into the 'KardexAlumnoDT.promedio' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'KardexAlumnoDT.alumno' table. You can move, or remove it, as needed.
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("maestro1", frmdocente.Cmbmaestro.Text))
        parameters.Add(New ReportParameter("maestro2", frmdocente.Cmbmaestro2.Text))
        parameters.Add(New ReportParameter("maestro3", frmdocente.Cmbmaestro3.Text))
        parameters.Add(New ReportParameter("maestro4", frmdocente.Cmbmaestro4.Text))
        parameters.Add(New ReportParameter("Periodo", frmdocente.UDPeriodo.Value))
        parameters.Add(New ReportParameter("fecha1", CDate(frmdocente.DtpFecha.Value)))
        parameters.Add(New ReportParameter("fecha2", CDate(frmdocente.DtpFecha2.Value)))
        parameters.Add(New ReportParameter("fecha3", CDate(frmdocente.Dtpfecha3.Value)))
        parameters.Add(New ReportParameter("fecha4", CDate(frmdocente.DtpFecha4.Value)))

        Dim parameters1 As New List(Of ReportParameter)()

        parameters1.Add(New ReportParameter("fecha5", CDate(frmdocente.DtpFecha5.Value)))
        parameters1.Add(New ReportParameter("fecha6", CDate(frmdocente.DtpFecha6.Value)))
        parameters1.Add(New ReportParameter("fecha7", CDate(frmdocente.DtpFecha7.Value)))
        parameters1.Add(New ReportParameter("fecha8", CDate(frmdocente.DtpFecha8.Value)))

        parameters1.Add(New ReportParameter("maestro5", frmdocente.Cmbmaestro5.Text))
        parameters1.Add(New ReportParameter("maestro6", frmdocente.Cmbmaestro6.Text))
        parameters1.Add(New ReportParameter("maestro7", frmdocente.Cmbmaestro7.Text))
        parameters1.Add(New ReportParameter("maestro8", frmdocente.Cmbmaestro8.Text))

        Me.ReportViewer2.LocalReport.SetParameters(parameters1)
        Me.ReportViewer1.LocalReport.SetParameters(parameters)


        'Me.KalumnoTableAdapter.Fill(Me.isencoDataSet.Kalumno, frmdocente.lblMatricula.Text)
        Me.Ksemestre5TableAdapter.Fill(Me.isencoDataSet.Ksemestre5, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.Ksemestre6TableAdapter.Fill(Me.isencoDataSet.Ksemestre6, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.Ksemestre7TableAdapter.Fill(Me.isencoDataSet.Ksemestre7, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.Ksemestre8TableAdapter.Fill(Me.isencoDataSet.Ksemestre8, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.Ksemestre2TableAdapter.Fill(Me.isencoDataSet.Ksemestre2, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.Ksemestre3TableAdapter.Fill(Me.isencoDataSet.Ksemestre3, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.Ksemestre4TableAdapter.Fill(Me.isencoDataSet.Ksemestre4, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.Ksemestre1TableAdapter.Fill(Me.isencoDataSet.Ksemestre1, frmdocente.lblMatricula.Text, Val(frmdocente.lblID.Text))
        Me.KalumnoTableAdapter.Fill(Me.isencoDataSet.Kalumno, frmdocente.lblMatricula.Text)
        Me.KpromedioTableAdapter.Fill(Me.isencoDataSet.Kpromedio, frmdocente.lblMatricula.Text)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.Text = modificacionCalifFrm.lblnombre.Text

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()

    End Sub
End Class
