Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class reportePagosFrm

    Private Sub reportePagosFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "IDLICENCIATURA", "licenciatura")
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "IDESPECIALIDAD", "especialidad")
        ds = getGrados()
        loadComboBox(ds, cmbSemestre, "IDSEMESTRE", "grado")
        ds = getGrupos()
        loadComboBox(ds, cmbGrupo, "nombre", "nombre")

        cmbCampus.Text = ""
        cmbLicenciatura.Text = ""
        cmbEspecialidad.Text = ""
    End Sub

    Private Sub consultarcmd_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmd.Click
        'TODO: This line of code loads data into the 'reportesDT.alumno_pago' table. You can move, or remove it, as needed.
        Me.alumno_pagoTableAdapter.Fill(Me.reportesDT.alumno_pago, cmbCampus.Text, cmbGrupo.Text, cmbSemestre.Text, cmbLicenciatura.Text, cmbEspecialidad.Text, cbmCicloEscolar.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        pdf()
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
        deviceInfo = "<DeviceInfo>" +
        "<OutputFormat>PDF</OutputFormat>" +
        "  <PageWidth>35.56cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>1cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>1.5cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "reportePagos.rdlc"
            Dim fs As New FileStream("C:\ISENCO\" & "reportePagos" & "test" & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            Process.Start("C:\ISENCO\" & "reportePagos" & "test" & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class