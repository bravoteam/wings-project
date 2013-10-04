Imports Microsoft.Reporting.WinForms
Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Imports System.IO
Public Class FRmRep_RegistroEsp
    Private Sub refresh_reporte()
        'TODO: This line of code loads data into the 'registroEscolaridad.DATOS_FIRMAS' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'registroEscolaridad.REPORTE_REGISTRO' table. You can move, or remove it, as needed.
        Dim H, M As Integer
        Dim _M As New modelos.modeloCampus
        _M = traerCampus(FrmRegistroEsp.cmbCampus.Text)
        '==========parametros enviados desde el formulario al reportviewer==============
        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("Ciclo", FrmRegistroEsp.cmbcicloescolar.Text)) ' director del plantel
        parameters.Add(New ReportParameter("campus", FrmRegistroEsp.cmbCampus.Text)) ' campus del plantel
        parameters.Add(New ReportParameter("calle", _M.CALLE)) ' 
        parameters.Add(New ReportParameter("numero", _M.NUMERO)) ' 
        parameters.Add(New ReportParameter("municipio", _M.MUNICIPIO)) ' 
        H = obtenerGenero("H")
        parameters.Add(New ReportParameter("hombres", H))
        M = obtenerGenero("M")
        parameters.Add(New ReportParameter("mujeres", M))

        '====================================================================================================

        Me.REGISTRO_ESCOLARIDADTableAdapter.Fill(Me.registroEscolaridad.REGISTRO_ESCOLARIDAD, FrmRegistroEsp.cmbEspecialidad.Text, FrmRegistroEsp.cmbSemestre.Text, FrmRegistroEsp.cmbGrupo.Text, FrmRegistroEsp.cmbCampus.Text, FrmRegistroEsp.cmbLicenciatura.Text, FrmRegistroEsp.cmbModalidad.Text, FrmRegistroEsp.cmbLicenciatura.SelectedValue, FrmRegistroEsp.cmbcicloescolar.Text)
        Me.REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter.Fill(Me.registroEscolaridad.REGISTRO_ESCOLARIDAD_REPETIDOR, FrmRegistroEsp.cmbEspecialidad.Text, FrmRegistroEsp.cmbSemestre.Text, FrmRegistroEsp.cmbGrupo.Text, FrmRegistroEsp.cmbCampus.Text, FrmRegistroEsp.cmbLicenciatura.Text, FrmRegistroEsp.cmbModalidad.Text)
        Me.REPORTE_REGISTROTableAdapter.Fill(Me.registroEscolaridad.REPORTE_REGISTRO, FrmRegistroEsp.cmbCampus.Text, FrmRegistroEsp.cmbLicenciatura.Text, FrmRegistroEsp.cmbEspecialidad.Text, FrmRegistroEsp.cmbSemestre.Text, FrmRegistroEsp.cmbGrupo.Text, FrmRegistroEsp.cmbcicloescolar.Text)

        If (Val(FrmRegistroEsp.cmbSemestre.Text) Mod 2) = 0 Then 'es par el semestre, si es par el semestre entonces es letra b
            Me.DATOS_FIRMASTableAdapter.Fill(Me.registroEscolaridad.DATOS_FIRMAS, FrmRegistroEsp.cmbcicloescolar.Text, "B")
        Else
            'sino el semestre es impar entonces el letra A
            Me.DATOS_FIRMASTableAdapter.Fill(Me.registroEscolaridad.DATOS_FIRMAS, FrmRegistroEsp.cmbcicloescolar.Text, "A")
        End If

        Me.REPORTE_REGISTRO_FUERATableAdapter.Fill(Me.registroEscolaridad.REPORTE_REGISTRO_FUERA, FrmRegistroEsp.cmbCampus.Text, FrmRegistroEsp.cmbLicenciatura.Text, FrmRegistroEsp.cmbEspecialidad.Text, FrmRegistroEsp.cmbSemestre.Text, FrmRegistroEsp.cmbGrupo.Text, FrmRegistroEsp.cmbcicloescolar.Text)
        Select Case Integer.Parse(FrmRegistroEsp.Label8.Text)
            Case 4
                Me.ReportViewer4.LocalReport.SetParameters(parameters)
                Me.ReportViewer4.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer4.RefreshReport()
                Me.ReportViewer1.Visible = False
                Me.ReportViewer2.Visible = False
                Me.ReportViewer3.Visible = False
                Me.ReportViewer5.Visible = False
                Me.ReportViewer6.Visible = False
                Me.ReportViewer7.Visible = False
                Me.ReportViewer8.Visible = False
                Me.ReportViewer4.Visible = True
            Case 5
                Me.ReportViewer5.LocalReport.SetParameters(parameters)
                Me.ReportViewer5.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer5.RefreshReport()
                Me.ReportViewer1.Visible = False
                Me.ReportViewer2.Visible = False
                Me.ReportViewer3.Visible = False
                Me.ReportViewer4.Visible = False
                Me.ReportViewer6.Visible = False
                Me.ReportViewer8.Visible = False
                Me.ReportViewer5.Visible = True
            Case 6
                Me.ReportViewer6.LocalReport.SetParameters(parameters)
                Me.ReportViewer6.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer6.RefreshReport()
                Me.ReportViewer1.Visible = False
                Me.ReportViewer2.Visible = False
                Me.ReportViewer3.Visible = False
                Me.ReportViewer4.Visible = False
                Me.ReportViewer5.Visible = False
                Me.ReportViewer7.Visible = False
                Me.ReportViewer8.Visible = False
                Me.ReportViewer6.Visible = True
            Case 7
                Me.ReportViewer7.LocalReport.SetParameters(parameters)
                Me.ReportViewer7.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer7.RefreshReport()
                Me.ReportViewer1.Visible = False
                Me.ReportViewer2.Visible = False
                Me.ReportViewer3.Visible = False
                Me.ReportViewer5.Visible = False
                Me.ReportViewer6.Visible = False
                Me.ReportViewer4.Visible = False
                Me.ReportViewer8.Visible = False
                Me.ReportViewer7.Visible = True
            Case 8
                Me.ReportViewer3.LocalReport.SetParameters(parameters)
                Me.ReportViewer3.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer3.RefreshReport()
                Me.ReportViewer1.Visible = False
                Me.ReportViewer2.Visible = False
                Me.ReportViewer4.Visible = False
                Me.ReportViewer5.Visible = False
                Me.ReportViewer6.Visible = False
                Me.ReportViewer7.Visible = False
                Me.ReportViewer8.Visible = False
                Me.ReportViewer3.Visible = True

            Case 9
                Me.ReportViewer1.LocalReport.SetParameters(parameters)
                Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer1.RefreshReport()
                Me.ReportViewer3.Visible = False
                Me.ReportViewer2.Visible = False
                Me.ReportViewer4.Visible = False
                Me.ReportViewer5.Visible = False
                Me.ReportViewer6.Visible = False
                Me.ReportViewer7.Visible = False
                Me.ReportViewer8.Visible = False
                Me.ReportViewer1.Visible = True

            Case 10
                Me.ReportViewer2.LocalReport.SetParameters(parameters)
                Me.ReportViewer2.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer2.RefreshReport()
                Me.ReportViewer3.Visible = False
                Me.ReportViewer1.Visible = False
                Me.ReportViewer4.Visible = False
                Me.ReportViewer5.Visible = False
                Me.ReportViewer6.Visible = False
                Me.ReportViewer7.Visible = False
                Me.ReportViewer8.Visible = False
                Me.ReportViewer2.Visible = True
            Case 11
                Me.ReportViewer8.LocalReport.SetParameters(parameters)
                Me.ReportViewer8.ZoomMode = ZoomMode.FullPage
                Me.ReportViewer8.RefreshReport()
                Me.ReportViewer3.Visible = False
                Me.ReportViewer1.Visible = False
                Me.ReportViewer4.Visible = False
                Me.ReportViewer5.Visible = False
                Me.ReportViewer6.Visible = False
                Me.ReportViewer7.Visible = False
                Me.ReportViewer2.Visible = False
                Me.ReportViewer8.Visible = True
        End Select

    End Sub
    Private Function obtenerGenero(ByVal genero As String)
        Dim valor, id As Integer
        valor = 0
        id = 0

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        b.abrirConexion()
        'sql = "SELECT DISTINCT(A.MATRICULA),A.GENERO,A.NOMBRE " & _
        '      "FROM   alumno AS A,materias AS M,calificaciones AS C " & _
        '      "WHERE  (A.IDESPECIALIDAD = @IDESPECIALIDAD) AND (C.IDSEMESTRE = @IDSEMESTRE) AND (C.IDGRUPO = @IDGRUPO) AND " & _
        '      "(A.IDCAMPUS = @IDCAMPUS) AND (A.IDLICENCIATURA = @IDLICENCIATURA) AND " & _
        '      "(A.IDMODALIDAD = @IDMODALIDAD) AND (A.IDSTATUS <> 'EGRESADO') AND (A.IDSTATUS NOT LIKE '%BAJA%') and not(m.nombre like '%optativa%') AND " & _
        '     "(A.MATRICULA = C.MATRICULA)AND(M.IDMATERIA = C.IDMATERIA) and (c.idlicenciatura = @idlicenciatura2) AND " & _
        '     "(C.IDCICLOESCOLAR = @CICLOESCOLAR) AND A.GENERO=@GENERO " & _
        '    "GROUP BY A.NOMBRE, A.APELLIDO_PATERNO, A.APELLIDO_MATERNO, M.NOMBRE, A.IDLICENCIATURA," & _
        '    "C.IDSEMESTRE, A.IDGRUPO, A.IDESPECIALIDAD, a.idturno, a.Matricula, c.IDMATERIA," & _
        '   "C.CALIFICACION, C.calificacion2, A.CURP, A.GENERO, M.NOMBRE, m.CLAVEISENCO, a.idstatus," & _
        '    "a.idcampus, a.idturno, a.idlicenciatura, A.IDSTATUS, c.extra1, c.extra2, c.extra3, c.acreditadas, c.noacreditadas, c.noacreditadasant"

        sql = "SELECT DISTINCT(R.idalumno), A.NOMBRE, A.APELLIDO_PATERNO, A.APELLIDO_MATERNO, A.CURP, A.GENERO, A.IDSTATUS " & _
              "FROM reporte_registro_escolar AS R INNER JOIN " & _
               "alumno AS A ON A.IDALUMNO = R.idalumno INNER JOIN " & _
               "materias AS m ON m.IDMATERIA = R.idmateria " & _
               "WHERE  (R.idcampus = @IDCAMPUS) AND (R.idlicenciatura = @IDLICENCIATURA) AND (R.idespecialidad = @IDESPECIALIDAD) AND (R.idsemestre =  @IDSEMESTRE) AND " & _
               "(R.idgrupo =  @IDGRUPO) AND (R.idcicloescolar = @CICLOESCOLAR) and (r.status ='NORMAL') AND A.GENERO=@GENERO " & _
               "GROUP BY R.idalumno, A.NOMBRE, A.APELLIDO_PATERNO, A.APELLIDO_MATERNO, A.CURP, A.GENERO, A.IDSTATUS," & _
               "R.idmateria, R.calificacion, R.calificacion2, R.reg_oport1," & _
               "R.reg_oport2, R.reg_oport3, R.reg_oport4, R.reg_oport5, R.acred_act, R.acred_no, R.acred_ant, R.idcampus, " & _
               "R.idlicenciatura, R.idespecialidad, R.idsemestre, R.idgrupo,R.idcicloescolar, R.reg_materia1, R.reg_materia2," & _
               "R.reg_materia3, R.reg_materia4, R.reg_materia5, m.NOMBRE, m.CLAVEISENCO"

        Dim cmd As New SqlCommand(sql, b.Conexion)
        With cmd
            .Parameters.AddWithValue("@IDESPECIALIDAD", FrmRegistroEsp.cmbEspecialidad.Text)
            .Parameters.AddWithValue("@IDSEMESTRE", FrmRegistroEsp.cmbSemestre.Text)
            .Parameters.AddWithValue("@IDGRUPO", FrmRegistroEsp.cmbGrupo.Text)
            .Parameters.AddWithValue("@IDCAMPUS", FrmRegistroEsp.cmbCampus.Text)
            .Parameters.AddWithValue("@IDLICENCIATURA", FrmRegistroEsp.cmbLicenciatura.Text)
            .Parameters.AddWithValue("@IDMODALIDAD", FrmRegistroEsp.cmbModalidad.Text)
            .Parameters.AddWithValue("@idlicenciatura2", FrmRegistroEsp.cmbLicenciatura.SelectedValue)
            .Parameters.AddWithValue("@CICLOESCOLAR", FrmRegistroEsp.cmbcicloescolar.Text)
            .Parameters.AddWithValue("@GENERO", genero)
        End With
        variables.SQLdr = cmd.ExecuteReader()
        While (variables.SQLdr.Read())
            valor = valor + 1
        End While
        b.cerrarConexion()

        Return valor
    End Function
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
        "  <MarginBottom>1.0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try
            Select Case Integer.Parse(FrmRegistroEsp.Label8.Text)
                Case 4
                    bytes = ReportViewer4.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer4.LocalReport.ReportPath = "Reporte_registro_escolaridad6Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad6Esp" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad6Esp" & "test" & ".pdf")
                Case 5
                    bytes = ReportViewer5.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer5.LocalReport.ReportPath = "Reporte_registro_escolaridad7Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad7Esp" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad7Esp" & "test" & ".pdf")
                Case 6
                    bytes = ReportViewer6.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer6.LocalReport.ReportPath = "Reporte_registro_escolaridad8Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad8Esp" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad8Esp" & "test" & ".pdf")
                Case 7
                    bytes = ReportViewer7.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer7.LocalReport.ReportPath = "Reporte_registro_escolaridad9Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad9Esp" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad9Esp" & "test" & ".pdf")
                Case 8
                    bytes = ReportViewer3.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer3.LocalReport.ReportPath = "Reporte_registro_escolaridad5Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad5Esp" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad5Esp" & "test" & ".pdf")
                Case 9
                    bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer1.LocalReport.ReportPath = "Reporte_registro_escolaridad2Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad2" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad2Esp" & "test" & ".pdf")
                Case 10
                    bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer2.LocalReport.ReportPath = "Reporte_registro_escolaridad4Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad4" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad4Esp" & "test" & ".pdf")
                Case 11
                    bytes = ReportViewer8.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
                    ReportViewer8.LocalReport.ReportPath = "Reporte_registro_escolaridad1Esp.rdl"
                    Dim fs As New FileStream("C:\ISENCO\" & "Registro_Escolaridad1Esp" & "test" & ".pdf", FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()
                    Process.Start("C:\ISENCO\" & "Registro_Escolaridad1Esp" & "test" & ".pdf")
            End Select

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
    Private Sub FRmRep_RegistroEsp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        refresh_reporte()

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        PDF()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        refresh_reporte()
    End Sub
End Class