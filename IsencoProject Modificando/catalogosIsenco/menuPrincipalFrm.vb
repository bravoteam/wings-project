Imports System.Data.SqlClient

Public Class menuPrincipalFrm

    Private Sub menuPrincipalFrm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LoginForm1.Show()
    End Sub

    Private Sub menuPrincipalFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListadoDeCalicacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles campusToolStripMenuItem.Click
        Dim f As New campusFrm("", "", "", "", "", "", "", "", "")
        f.Show()
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MateriasToolStripMenuItem.Click
        Dim f As New materiasFrm("", "", "", "", "", "", "", "", "", "", 0, 0)
        f.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        LoginForm1.Show()
    End Sub

    Private Sub GenerarMatriculasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarMatriculasToolStripMenuItem.Click
        Dim f As New generarMatriculas
        f.Show()
    End Sub

    Private Sub ListaDeAsistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("ListaAsistencias\Lista_de_asistencia.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub MaestrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaestrosToolStripMenuItem.Click
        Dim M As New modelos.modeloMaestro
        M.FECHA_INGRESO = Date.MinValue
        M.FECHA_NACIMIENTO = Date.MinValue
        M.FECHA_SALIDA = Date.MinValue
        Dim f As New maestrosFrm(M)
        f.Show()
    End Sub

    Private Sub InscripcionDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InscripcionDeAlumnosToolStripMenuItem.Click
        Dim M As New modelos.modeloAlumno
        alumnosFrm.llenarAlumno(M)
        alumnosFrm.Show()

    End Sub

    Private Sub GenerarCalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCalificacionesToolStripMenuItem.Click
        Calificacion.Show()
    End Sub

    Private Sub PromocionDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromocionDeAlumnosToolStripMenuItem.Click
        promocionAlumnosFrm.Show()
    End Sub

    Private Sub ConfiguracionInicialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionInicialToolStripMenuItem.Click
        configuracionFrm.Show()
    End Sub

    Private Sub AdministrativosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrativosToolStripMenuItem.Click
        Dim M As New modelos.modeloAdministrativo
        Dim f As New administrativosFrm(M)
        f.Show()
    End Sub


    Private Sub EstadisticosHYMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadisticosHYMToolStripMenuItem.Click
        Dim f As New estadisticasFrm
        f.Show()
    End Sub

    Private Sub ModificacionDeCalificacionesPorAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDeCalificacionesPorAlumnoToolStripMenuItem.Click
        modificacionCalifFrm.Show()
    End Sub

    Private Sub CicloEscolarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CicloEscolarToolStripMenuItem.Click
        Dim M As New modelos.modeloCicloEscolar
        M.INICIO = Date.MinValue
        M.FIN = Date.MinValue
        M.ACTUAL = 0
        M.IDCICLOESCOLAR = 0
        M.DESCRIPCION = ""
        Dim f As New cicloEscolarFrm(M)
        f.Show()
    End Sub

    Private Sub ReportesVariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesVariosToolStripMenuItem.Click
        principalOtrosRpt.Show()
    End Sub

    Private Sub InscripcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InscripcionToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub RegistroDeEscolaridadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeEscolaridadToolStripMenuItem.Click
        FrmRegistro2.Show()

    End Sub

    Private Sub CambiosDeGruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiosDeGruposToolStripMenuItem.Click
        cambiosGruposFrm.Show()
    End Sub

    Private Sub ExportacionDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportacionDeAlumnosToolStripMenuItem.Click
        exportacionAlumnosFrm.Show()
    End Sub

    Private Sub ImportacionDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportacionDeAlumnosToolStripMenuItem.Click
        importacionAlumnos.Show()
    End Sub

    Private Sub AlumnosBecadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlumnosBecadosToolStripMenuItem.Click
        becados.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub InscripcionDeAlumnosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles InscripcionDeAlumnosToolStripMenuItem1.Click
        inscripcionFrm.Show()
    End Sub

    Private Sub ReinscripcionDeAlumnosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReinscripcionDeAlumnosToolStripMenuItem.Click
        reportePagosFrm.Show()
    End Sub

    Private Sub CalificacionesExtrasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalificacionesExtrasToolStripMenuItem.Click
        ExtrasFrm.Show()
    End Sub

    Private Sub CertificacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        variables.matricula = ""
        certificadosFrm.Show()
    End Sub

    Private Sub ActaDeExámenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActaDeExámenToolStripMenuItem.Click
        titulosActasFrm.Show()
    End Sub

    Private Sub GenerarCertificadfosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarCertificadfosToolStripMenuItem.Click
        certificadosFrm.Show()
    End Sub

    Private Sub GenerarFolioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarFolioToolStripMenuItem.Click
        preregistroFrm.Show()
    End Sub

    Private Sub ConsultaDeFoliosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeFoliosToolStripMenuItem.Click
        consultaPreregFrm.Show()
    End Sub

    Private Sub ToolStripStatusLabel5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel5.Click
        Dim pass, pass1 As String
        pass = InputBox("Introduce la Nueva Contraseña - Max 6 Caracteres", "Cambio de Password")
        If pass.Length <= 0 Then
            Exit Sub
        End If
        If pass.Length > 6 Then
            MsgBox("Máximo 6 caracteres", MsgBoxStyle.Critical)
            Exit Sub
        End If
        pass1 = InputBox("Repite la Contraseña", "Cambio de Password")
        If pass <> pass1 Then
            MsgBox("No coinciden las contraseñas", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE usuarios SET password=@password WHERE id=@id"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@password", pass)
                .Parameters.AddWithValue("@id", variables.idusuario)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("PASSWORD ACTUALIZADO")
        Catch exc As Exception
            Throw exc
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripFecha.Text = Now
    End Sub

    Private Sub ValidarPreregistroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ValidarPreregistroToolStripMenuItem.Click
        validarPreFrm.Show()
    End Sub

    Private Sub AsignarAulasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarAulasToolStripMenuItem.Click
        asignarAulasFrm.Show()
    End Sub

    Private Sub ImpresionDeListasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpresionDeListasToolStripMenuItem.Click
        ImprimirListasFrm.Show()
    End Sub

    Private Sub ImprimirIMSSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirIMSSToolStripMenuItem.Click
        procesoInscripcionFrm.Show()
    End Sub

    Private Sub ReimprimirFormatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReimprimirFormatosToolStripMenuItem.Click
        impresionInscripcionFrm.Show()
    End Sub

    Private Sub TomarFotografiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TomarFotografiaToolStripMenuItem.Click
        tomarFotoFrm.Show()
    End Sub

    Private Sub ReporteDeReprobadosGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeReprobadosGeneralToolStripMenuItem.Click
        Rpt_ReprobadasFrm.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ConfigurarPlanesDeEstudiosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarPlanesDeEstudiosToolStripMenuItem.Click
        PlanEstudiosCicloFrm.Show()
    End Sub

    Private Sub ConfigurarMateriasMaestrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarMateriasMaestrosToolStripMenuItem.Click
        materiaMaestroFrm.Show()
    End Sub

    Private Sub CalificacionesParaMaestrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalificacionesParaMaestrosToolStripMenuItem.Click
        calificacionMaestroFrm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        FrmRegistroEsp.Show()
    End Sub

    Private Sub ModuloDeCalificacionesParaAlumnosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModuloDeCalificacionesParaAlumnosToolStripMenuItem.Click
        calificacionAlumnoFrm.Show()
    End Sub

    Private Sub ImrpresionDeCredencialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImrpresionDeCredencialToolStripMenuItem.Click
        credencialFrm.Show()
    End Sub

    Private Sub EstadisticasGeneralesDeGruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadisticasGeneralesDeGruposToolStripMenuItem.Click
        estadisticasFinalFrm.Show()
    End Sub

    Private Sub AsignarMaestroAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmAlumnoMaestro.Show()
    End Sub
End Class