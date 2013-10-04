Imports Microsoft.Reporting.WinForms
Imports datosCompartidos.Datos
Imports System.Data.SqlClient
Imports System.IO

Public Class registro_escolaridad

    Private Sub registro_escolaridad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim H, M As Integer
        Dim _M As New modelos.modeloCampus
        _M = traerCampus(FrmRegistro.cmbCampus.Text)
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
        parameters.Add(New ReportParameter("calle", _M.CALLE)) ' 
        parameters.Add(New ReportParameter("numero", _M.NUMERO)) ' 
        parameters.Add(New ReportParameter("municipio", _M.MUNICIPIO)) ' 
        H = obtenerGenero("H")
        parameters.Add(New ReportParameter("hombres", H))
        M = obtenerGenero("M")
        parameters.Add(New ReportParameter("mujeres", M))
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        '====================================================================================================
        Me.REGISTRO_ESCOLARIDADTableAdapter.Fill(Me.registroEscolaridad.REGISTRO_ESCOLARIDAD, FrmRegistro.cmbEspecialidad.Text, FrmRegistro.cmbSemestre.Text, FrmRegistro.cmbGrupo.Text, FrmRegistro.cmbCampus.Text, FrmRegistro.cmbLicenciatura.Text, FrmRegistro.cmbModalidad.Text, FrmRegistro.cmbLicenciatura.SelectedValue, FrmRegistro.Cmbciclo.Text)
        Me.REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter.Fill(Me.registroEscolaridad.REGISTRO_ESCOLARIDAD_REPETIDOR, FrmRegistro.cmbEspecialidad.Text, FrmRegistro.cmbSemestre.Text, FrmRegistro.cmbGrupo.Text, FrmRegistro.cmbCampus.Text, FrmRegistro.cmbLicenciatura.Text, FrmRegistro.cmbModalidad.Text)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Function obtenerGenero(ByVal genero As String)
        Dim valor, id As Integer
        valor = 0
        id = 0

        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim sql As String

        

        b.abrirConexion()

        sql = "SELECT DISTINCT(A.MATRICULA),A.GENERO,A.NOMBRE " & _
              "FROM   alumno AS A,materias AS M,calificaciones AS C " & _
              "WHERE  (A.IDESPECIALIDAD = @IDESPECIALIDAD) AND (C.IDSEMESTRE = @IDSEMESTRE) AND (C.IDGRUPO = @IDGRUPO) AND " & _
              "(A.IDCAMPUS = @IDCAMPUS) AND (A.IDLICENCIATURA = @IDLICENCIATURA) AND " & _
              "(A.IDMODALIDAD = @IDMODALIDAD) AND (A.IDSTATUS <> 'EGRESADO') and not(m.nombre like '%optativa%') AND " & _
             "(A.MATRICULA = C.MATRICULA)AND(M.IDMATERIA = C.IDMATERIA) and (c.idlicenciatura = @idlicenciatura2) AND " & _
             "(C.IDCICLOESCOLAR = @CICLOESCOLAR) AND A.GENERO=@GENERO " & _
            "GROUP BY A.NOMBRE, A.APELLIDO_PATERNO, A.APELLIDO_MATERNO, M.NOMBRE, A.IDLICENCIATURA," & _
            "C.IDSEMESTRE, A.IDGRUPO, A.IDESPECIALIDAD, a.idturno, a.Matricula, c.IDMATERIA," & _
           "C.CALIFICACION, C.calificacion2, A.CURP, A.GENERO, M.NOMBRE, m.CLAVEISENCO, a.idstatus," & _
            "a.idcampus, a.idturno, a.idlicenciatura, A.IDSTATUS, c.extra1, c.extra2, c.extra3, c.acreditadas, c.noacreditadas, c.noacreditadasant"
        Dim cmd As New SqlCommand(sql, b.Conexion)
        With cmd
            .Parameters.AddWithValue("@IDESPECIALIDAD", FrmRegistro.cmbEspecialidad.Text)
            .Parameters.AddWithValue("@IDSEMESTRE", FrmRegistro.cmbSemestre.Text)
            .Parameters.AddWithValue("@IDGRUPO", FrmRegistro.cmbGrupo.Text)
            .Parameters.AddWithValue("@IDCAMPUS", FrmRegistro.cmbCampus.Text)
            .Parameters.AddWithValue("@IDLICENCIATURA", FrmRegistro.cmbLicenciatura.Text)
            .Parameters.AddWithValue("@IDMODALIDAD", FrmRegistro.cmbModalidad.Text)
            .Parameters.AddWithValue("@idlicenciatura2", FrmRegistro.cmbLicenciatura.SelectedValue)
            .Parameters.AddWithValue("@CICLOESCOLAR", FrmRegistro.Cmbciclo.Text)
            .Parameters.AddWithValue("@GENERO", genero)
        End With
        variables.SQLdr = cmd.ExecuteReader()
        While (variables.SQLdr.Read())
            valor = valor + 1
        End While
        b.cerrarConexion()

        Return valor
    End Function

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

            Process.Start("C:\ISENCO\" & "Registro_Escolaridad" & "test" & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
End Class