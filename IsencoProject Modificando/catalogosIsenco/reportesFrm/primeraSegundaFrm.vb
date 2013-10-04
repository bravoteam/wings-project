Imports Microsoft.Reporting.WinForms
Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Imports System.IO

Public Class primeraSegundaFrm

    Private Sub primeraSegundaFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'isencoDataSet.PRIMERA_SEGUNDA_PARCIAL' table. You can move, or remove it, as needed.
        actualizarReporte()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        actualizarReporte()
    End Sub
    Public Shared Sub actualizarReporte()
        Dim NHOMBRES As Integer = 0
        Dim NMUJERES As Integer = 0

        primeraSegundaFrm.PRIMERA_SEGUNDA_PARCIALTableAdapter.Fill(primeraSegundaFrm.isencoDataSet.PRIMERA_SEGUNDA_PARCIAL, _
                                                    principalOtrosRpt.cmbEspecialidad.Text, _
                                                    principalOtrosRpt.cmbLicenciatura.SelectedValue, _
                                                    principalOtrosRpt.cmbTurno.Text, _
                                                    principalOtrosRpt.cmbCampus.Text, _
                                                    principalOtrosRpt.cmbSemestre.Text, _
                                                    principalOtrosRpt.cbmCicloEscolar.Text, _
                                                    principalOtrosRpt.cmbGrupo.Text)


        NHOMBRES = calcularTotalesGeneroCalif("H")
        NMUJERES = calcularTotalesGeneroCalif("M")
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("SEMESTRE", principalOtrosRpt.cmbSemestre.Text))
        parameters.Add(New ReportParameter("TURNO", principalOtrosRpt.cmbTurno.Text))
        parameters.Add(New ReportParameter("GRUPO", principalOtrosRpt.cmbGrupo.Text))
        parameters.Add(New ReportParameter("NHOMBRES", NHOMBRES))
        parameters.Add(New ReportParameter("NMUJERES", NMUJERES))
        parameters.Add(New ReportParameter("NTOTAL", NHOMBRES + NMUJERES))
        parameters.Add(New ReportParameter("CICLO", "2013-2013"))
        parameters.Add(New ReportParameter("CAMPUS", principalOtrosRpt.cmbCampus.Text))
        If variables.reporte = 1 Then
            primeraSegundaFrm.ReportViewer2.LocalReport.SetParameters(parameters)

            primeraSegundaFrm.ReportViewer2.RefreshReport()
        End If
        If variables.reporte = 2 Then
            primeraSegundaFrm.ReportViewer3.LocalReport.SetParameters(parameters)

            primeraSegundaFrm.ReportViewer3.RefreshReport()
        End If
        If variables.reporte = 3 Then
            primeraSegundaFrm.ReportViewer1.LocalReport.SetParameters(parameters)

            primeraSegundaFrm.ReportViewer1.RefreshReport()
        End If

    End Sub
    Private Shared Function calcularTotalesGenero(g As String) As Integer
        Dim valor As Integer = 0
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr2 As SqlDataReader
        b.abrirConexion()
        sql = "SELECT A.genero,count(A.genero) AS EXPRESION " & _
              "FROM alumno AS A " & _
              "where (A.IDESPECIALIDAD = '" & principalOtrosRpt.cmbEspecialidad.Text & "') " & _
              "AND (A.IDSEMESTRE = '" & principalOtrosRpt.cmbSemestre.Text & "') " & _
              "AND (A.IDGRUPO = '" & principalOtrosRpt.cmbGrupo.Text & "') " & _
              "AND (A.IDCAMPUS = '" & principalOtrosRpt.cmbCampus.Text & "') " & _
              "AND (A.IDLICENCIATURA = '" & principalOtrosRpt.cmbLicenciatura.Text & "') " & _
              "AND (A.IDturno = '" & principalOtrosRpt.cmbTurno.Text & "') " & _
              "AND (A.IDSTATUS <> 'BAJA TEMPORAL') AND (A.IDSTATUS <> 'BAJA DEFINITIVA') " & _
              "AND (A.IDSTATUS <> 'EGRESADO') AND (A.GENERO='" & g & "') GROUP BY A.genero"
        Dim cmd As New SqlCommand(sql, b.Conexion)
        SQLdr2 = cmd.ExecuteReader
        While (SQLdr2.Read())
            valor = SQLdr2("EXPRESION")
        End While
        b.cerrarConexion()
        Return valor
    End Function
    Private Shared Function calcularTotalesGeneroCalif(g As String) As Integer
        Dim valor As Integer = 0
        Dim b As New BaseDatos
        Dim sql As String
        Dim SQLdr2 As SqlDataReader
        b.abrirConexion()
        sql = "SELECT  A.GENERO " & _
               "FROM    calificaciones AS C INNER JOIN " & _
               "alumno AS A ON C.Matricula = A.MATRICULA INNER JOIN " & _
               "materias AS M ON C.IDMATERIA = M.IDMATERIA " & _
               "WHERE   (A.IDESPECIALIDAD = '" & principalOtrosRpt.cmbEspecialidad.Text & "') AND " & _
               "(C.IDLICENCIATURA = " & Val(principalOtrosRpt.cmbLicenciatura.SelectedValue) & ") AND (A.IDturno = '" & principalOtrosRpt.cmbTurno.Text & "') " & _
               "AND (C.IDMATERIA <> 1232) AND " & _
               "(C.IDMATERIA <> 1233) AND (A.IDSTATUS <> 'BAJA TEMPORAL') AND (A.IDSTATUS <> 'BAJA DEFINITIVA') " & _
               "AND (A.IDSTATUS <> 'EGRESADO') AND (A.IDCAMPUS = '" & principalOtrosRpt.cmbCampus.Text & "') AND (C.IDSEMESTRE = '2') " & _
               "AND (C.IDCICLOESCOLAR = '" & principalOtrosRpt.cbmCicloEscolar.Text & "') AND  (C.IDGRUPO = '" & principalOtrosRpt.cmbGrupo.Text & "') AND (A.GENERO='" & g & "') " & _
               " GROUP BY C.Matricula, C.IDLICENCIATURA, C.IDCICLOESCOLAR, C.IDSEMESTRE, C.IDGRUPO, " & _
               "A.IDALUMNO, A.NOMBRE, A.APELLIDO_PATERNO, A.APELLIDO_MATERNO, A.GENERO, A.CALLE,  " & _
               "A.NUMERO_EXTERIOR, A.NUMERO_INTERIOR, A.COLONIA, A.IDMUNICIPIO, A.IDESTADO, A.CODIGO_POSTAL, A.CURP, A.TELEFONO_CASA, A.TELEFONO_CEL, " & _
               "A.CORREO_ELECTRONICO, A.FECHA_NACIMIENTO, A.FECHA_INGRESO, A.FECHA_SALIDA, A.TIPO_SANGRE, A.TELEFONO_EMERGENCIA, A.MATRICULA, " & _
               "A.IDCAMPUS, A.IDturno, A.IDSTATUS, A.IDAREA, A.IDMODALIDAD, A.IDESPECIALIDAD, A.IDSEMESTRE, A.IDGRUPO, " & _
               "A.IDLICENCIATURA, A.GENERO"
        Dim cmd As New SqlCommand(sql, b.Conexion)
        SQLdr2 = cmd.ExecuteReader
        While (SQLdr2.Read())
            valor = valor + 1
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
        "  <PageWidth>30.7cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            Dim nombreR As String = ""
            If variables.reporte = 1 Then
                nombreR = "Reporte_Primera_Parcial.rdlc"
                bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                ReportViewer2.LocalReport.ReportPath = nombreR
            End If
            If variables.reporte = 2 Then
                nombreR = "Reporte_Segunda_Parcial.rdlc"
                bytes = ReportViewer3.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                ReportViewer3.LocalReport.ReportPath = nombreR
            End If
            If variables.reporte = 3 Then
                nombreR = "Reporte_Primera_Segunda_Parcial.rdl"
                bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                ReportViewer1.LocalReport.ReportPath = nombreR
            End If

            Dim fs As New FileStream("C:\ISENCO\" & nombreR & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & nombreR & ".pdf")
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class