Imports Microsoft.Reporting.WinForms
Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Imports System.IO

Public Class culturalesNoACFrm

    Private Sub culturalesNoACFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'isencoDataSet.ACTIVIDADESNOACREDITADAS' table. You can move, or remove it, as needed.
        Me.ACTIVIDADESNOACREDITADASTableAdapter.Fill(Me.isencoDataSet.ACTIVIDADESNOACREDITADAS, _
                                                     principalOtrosRpt.cmbEspecialidad.Text, _
                                                     principalOtrosRpt.cmbSemestre.Text, _
                                                     principalOtrosRpt.cmbGrupo.Text, _
                                                     principalOtrosRpt.cmbCampus.Text, _
                                                     principalOtrosRpt.cmbLicenciatura.SelectedValue, _
                                                     principalOtrosRpt.cmbLicenciatura.Text, _
                                                     principalOtrosRpt.cmbTurno.Text)


        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("SEMESTRE", principalOtrosRpt.cmbSemestre.Text))
        parameters.Add(New ReportParameter("TURNO", principalOtrosRpt.cmbTurno.Text))
        parameters.Add(New ReportParameter("GRUPO", principalOtrosRpt.cmbGrupo.Text))
        parameters.Add(New ReportParameter("NHOMBRES", 0))
        parameters.Add(New ReportParameter("NMUJERES", 0))
        parameters.Add(New ReportParameter("NTOTAL", 0))
        parameters.Add(New ReportParameter("CICLO", "2013-2013"))
        Me.ReportViewer1.LocalReport.SetParameters(parameters)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        actualizarReporte()
    End Sub
    Public Shared Sub actualizarReporte()
        Dim NHOMBRES As Integer = 0
        Dim NMUJERES As Integer = 0
        'TODO: This line of code loads data into the 'isencoDataSet.ACTIVIDADESNOACREDITADAS' table. You can move, or remove it, as needed.
        culturalesNoACFrm.ACTIVIDADESNOACREDITADASTableAdapter.Fill(culturalesNoACFrm.isencoDataSet.ACTIVIDADESNOACREDITADAS, _
                                                     principalOtrosRpt.cmbEspecialidad.Text, _
                                                     principalOtrosRpt.cmbSemestre.Text, _
                                                     principalOtrosRpt.cmbGrupo.Text, _
                                                     principalOtrosRpt.cmbCampus.Text, _
                                                     principalOtrosRpt.cmbLicenciatura.SelectedValue, _
                                                     principalOtrosRpt.cmbLicenciatura.Text, _
                                                     principalOtrosRpt.cmbTurno.Text)

        NHOMBRES = calcularTotalesGenero("H")
        NMUJERES = calcularTotalesGenero("M")
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("SEMESTRE", principalOtrosRpt.cmbSemestre.Text))
        parameters.Add(New ReportParameter("TURNO", principalOtrosRpt.cmbTurno.Text))
        parameters.Add(New ReportParameter("GRUPO", principalOtrosRpt.cmbGrupo.Text))
        parameters.Add(New ReportParameter("NHOMBRES", NHOMBRES))
        parameters.Add(New ReportParameter("NMUJERES", NMUJERES))
        parameters.Add(New ReportParameter("NTOTAL", NHOMBRES + NMUJERES))
        parameters.Add(New ReportParameter("CICLO", "2013-2013"))
        culturalesNoACFrm.ReportViewer1.LocalReport.SetParameters(parameters)

        culturalesNoACFrm.ReportViewer1.RefreshReport()
    End Sub
    Private Shared Function calcularTotalesGenero(g As String) As Integer
        Dim valor As Integer = 0
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr2 As SqlDataReader
        b.abrirConexion()
        sql = "SELECT A.GENERO,COUNT(GENERO) as EXPRESION " & _
              "FROM  calificaciones AS C INNER JOIN " & _
              "alumno AS A ON C.Matricula = A.MATRICULA INNER JOIN " & _
              "materias AS M ON C.IDMATERIA = M.IDMATERIA " & _
              "WHERE (A.IDESPECIALIDAD = '" & principalOtrosRpt.cmbEspecialidad.Text & "') AND (C.IDSEMESTRE = '" & principalOtrosRpt.cmbSemestre.Text & "') " & _
              "AND (A.IDGRUPO = '" & principalOtrosRpt.cmbGrupo.Text & "') AND (A.IDCAMPUS = '" & principalOtrosRpt.cmbCampus.Text & "') AND " & _
              "(C.IDLICENCIATURA = '" & principalOtrosRpt.cmbLicenciatura.SelectedValue & "') " & _
              "AND (A.IDLICENCIATURA = '" & principalOtrosRpt.cmbLicenciatura.Text & "') " & _
              "AND (A.IDturno = '" & principalOtrosRpt.cmbTurno.Text & "') AND (C.CALIFICACION = 0) AND " & _
              "(C.calificacion2 = 0) And (C.IDMATERIA = 1233) " & _
              "AND (A.IDSTATUS <> 'BAJA TEMPORAL') AND (A.IDSTATUS <> 'BAJA DEFINITIVA') AND (A.IDSTATUS <> 'EGRESADO') " & _
              "AND GENERO='" & g & "' GROUP BY GENERO"
        Dim cmd As New SqlCommand(sql, b.Conexion)
        SQLdr2 = cmd.ExecuteReader
        While (SQLdr2.Read())
            valor = SQLdr2("EXPRESION")
        End While
        b.cerrarConexion()
        Return valor
    End Function

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
        "  <PageWidth>29.7cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = "Reporte_Actividades_cult_deport.rdlc"
            Dim fs As New FileStream("C:\ISENCO\" & "Reporte_Actividades_cult_deport" & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & "Reporte_Actividades_cult_deport" & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class