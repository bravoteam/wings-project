Imports Microsoft.Reporting.WinForms.LocalReport
Imports System.IO
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports Registro_de_Escolaridad.Datos
Imports System.Data.SqlClient
Public Class Reporte_Escolaridad
    Private conf As New Configuracion
    Private model As New Modelos.AlumnosModel
    Dim idlice As String = ""
    Private Sub obtener_id()
        Dim conexion2 As New BaseDatos
        conexion2.abrirConexion()
        Dim sql2 As String = "select idlicenciatura from licenciaturas where nombre = '" & FrmRegistro.cmbLicenciatura.Text & "'"
        Dim cmd As New SqlCommand(sql2, conexion2.Conexion)
        Dim SQLdr As SqlDataReader 'The Local Data Store
        SQLdr = cmd.ExecuteReader
        While SQLdr.Read
            idlice = SQLdr(0).ToString
        End While
        SQLdr.Close()
        conexion2.cerrarConexion()
    End Sub
    Private Sub Reporte_Escolaridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistroDt.mujeres' table. You can move, or remove it, as needed.
        ' Me.MujeresTableAdapter.Fill(Me.RegistroDt.mujeres)
        'TODO: This line of code loads data into the 'RegistroDt.REGISTROESCOLARIDAD_REPETIDOR' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'RegistroDt.hombres' table. You can move, or remove it, as needed.
        obtener_id()
        Me.HombresTableAdapter.Fill(Me.RegistroDt.hombres, FrmRegistro.cmbSemestre.Text, FrmRegistro.cmbGrupo.Text, idlice, FrmRegistro.Cmbciclo.Text)
        Me.MujeresTableAdapter.Fill(Me.RegistroDt.mujeres, FrmRegistro.cmbSemestre.Text, FrmRegistro.cmbGrupo.Text, idlice, FrmRegistro.Cmbciclo.Text)
        Me.MujeresTableAdapter.Fill(Me.RegistroDt1.mujeres, FrmRegistro.cmbSemestre.Text, FrmRegistro.cmbGrupo.Text, idlice, FrmRegistro.Cmbciclo.Text)
        Me.DirectivosTableAdapter.Fill(Me.RegistroDt.directivos)
        Me.Ciclo_escolarTableAdapter.Fill(Me.RegistroDt.ciclo_escolar)
        Me.DirectivosTableAdapter.Fill(Me.RegistroDt.directivos)
        '==========parametros enviados desde el formulario al reportviewer==============
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("Inscripcion", FrmRegistro.CmbInscripcion.Text))
        parameters.Add(New ReportParameter("Acreditacion", FrmRegistro.Cmbacreditacion.Text))
        parameters.Add(New ReportParameter("Regularizacion", FrmRegistro.Cmbregularizacion.Text))
        parameters.Add(New ReportParameter("Fechainscripcion", (FrmRegistro.Dtp1.Text)))
        parameters.Add(New ReportParameter("Fechaacreditacion", (FrmRegistro.Dtp2.Text)))
        parameters.Add(New ReportParameter("Fecharegularizacion", (FrmRegistro.Dtp3.Text)))
        parameters.Add(New ReportParameter("Director", FrmRegistro.Cmbplantel.Text)) ' director del plantel
        parameters.Add(New ReportParameter("Director2", FrmRegistro.cmbplantel2.Text)) ' director del plantel
        parameters.Add(New ReportParameter("Director3", FrmRegistro.cmbplantel3.Text)) ' director del plantel
        parameters.Add(New ReportParameter("Ciclo", FrmRegistro.Cmbciclo.Text)) ' director del plantel
        parameters.Add(New ReportParameter("campus", FrmRegistro.cmbCampus.Text)) ' campus del plantel
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        '====================================================================================================
        Me.Ciclo_escolarTableAdapter.Fill(Me.RegistroDt.ciclo_escolar)
        '  Me.RegistroEscolaridadEXTRA1TableAdapter.Fill(Me.RegistroDt.RegistroEscolaridadEXTRA1, "", "2", "C", "CUAUHTEMOC", "5", "TV", "E")
        Me.REGISTROESCOLARIDADTableAdapter.Fill(Me.RegistroDt.REGISTROESCOLARIDAD, FrmRegistro.cmbEspecialidad.Text, FrmRegistro.cmbSemestre.Text, FrmRegistro.cmbGrupo.Text, FrmRegistro.cmbCampus.Text, FrmRegistro.cmbLicenciatura.Text, FrmRegistro.cmbTurno.Text, FrmRegistro.cmbModalidad.Text, idlice, FrmRegistro.Cmbciclo.Text)
        Me.REGISTROESCOLARIDAD_REPETIDORTableAdapter.Fill(Me.RegistroDt.REGISTROESCOLARIDAD_REPETIDOR, FrmRegistro.cmbEspecialidad.Text, FrmRegistro.cmbSemestre.Text, FrmRegistro.cmbGrupo.Text, FrmRegistro.cmbCampus.Text, FrmRegistro.cmbLicenciatura.Text, FrmRegistro.cmbTurno.Text, FrmRegistro.cmbModalidad.Text)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
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
        "  <PageWidth>35.56cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>1cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>1.5cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "Reporte_registro_escolaridad.rdl"
            Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad" & "test" & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            'bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            'ReportViewer2.LocalReport.ReportPath = "Kardex_alumno_contra.rdl"

            'Dim fs1 As New FileStream("C:\ISENCO\" & "Kardex-Contra" & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("matricula").Value.ToString() & ".pdf", FileMode.Create)
            'fs1.Write(bytes, 0, bytes.Length)
            'fs1.Close()

            Process.Start("C:\ISENCO\" & "Registro_Escolaridad" & "test" & ".pdf")
            '            Process.Start("C:\ISENCO\" & "Kardex-Contra" & frmBuscarAlumbo.Grid.Rows(frmBuscarAlumbo.Grid.CurrentRow.Index).Cells("matricula").Value.ToString() & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub GenerarArchivoParaImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarArchivoParaImprimirToolStripMenuItem.Click
        PDF()
    End Sub
End Class