Imports System.IO
Imports datosCompartidos
Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones

Public Class alumnosFrm
    Dim webcam As New WebCam
    Private conf As New Configuracion
    Private model As New datosCompartidos.Modelos.AlumnosModel

    Private RutaServerFotos As String = ""
    Public Fotografia As String = ""
    Private Ext As String = ""
    Public FotografiaAnterior As String = ""
    Private FotoVacia As String = System.AppDomain.CurrentDomain.BaseDirectory + "nf.jpg"
    Public Sub llenarAlumno(ByVal modelo As modelos.modeloAlumno)
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is System.Windows.Forms.TextBox Then x.Text = ""
        Next
        txtidAlumno.Text = modelo.IDALUMNO
        txtNombre.Text = modelo.NOMBRE
        txtApellidoPaterno.Text = modelo.APELLIDO_PATERNO
        txtApellidoMaterno.Text = modelo.APELLIDO_MATERNO
        cmbGenero.Text = modelo.GENERO
        txtCalle.Text = modelo.CALLE
        txtNumInt.Text = modelo.NUMERO_INTERIOR
        txtNumExt.Text = modelo.NUMERO_EXTERIOR
        txtColonia.Text = modelo.COLONIA
        txtMunicipio.Text = modelo.IDMUNICIPIO
        cmbEstado.Text = modelo.IDESTADO
        txtCP.Text = modelo.CODIGO_POSTAL
        txtCURP.Text = modelo.CURP
        txtTelefono.Text = modelo.TELEFONO_CASA
        txtCelular.Text = modelo.TELEFONO_CEL
        txtEmail.Text = modelo.CORREO_ELECTRONICO
        oFechaNacimiento.Value = Date.Parse(modelo.FECHA_NACIMIENTO)
        oFechaIngreso.Value = Date.Parse(modelo.FECHA_INGRESO)
        oFechaEgreso.Value = Date.Parse(modelo.FECHA_SALIDA)
        txtTipoSangre.Text = modelo.TIPO_SANGRE
        txtObservaciones.Text = modelo.OBSERVACIONES
        txtContactoEmergencia.Text = modelo.CONTACTO_EMERGENCIA
        txtTelefonoEmergencia.Text = modelo.TELEFONO_EMERGENCIA
        txtMatricula.Text = modelo.MATRICULA
        cmbCampus.Text = modelo.IDCAMPUS
        cmbTurno.Text = modelo.IDturno
        cmbEstatus.Text = modelo.IDSTATUS
        cmbModalidad.Text = modelo.IDMODALIDAD
        cmbEspecialidad.Text = modelo.IDESPECIALIDAD

        cmbSemestre.Text = modelo.IDSEMESTRE
        cmbGrupo.Text = modelo.IDGRUPO
        cmbLicenciatura.Text = modelo.IDLICENCIATURA
        If Not (IsNothing(modelo.FOTO)) Then
            Dim bytBLOBData() As Byte = modelo.FOTO
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            oFotografia.Image = Image.FromStream(stmBLOBData)
        End If


        txtPlanEstudios.Text = modelo.PLANEST
        txtGeneracion.Text = modelo.GENERACION
        comboBeca.Text = modelo.BECA
        txtNoSS.Text = modelo.NO_SS
        'chkAdeudo.Checked = Val(modelo.ADEUDO_LIBROS)
        Txtpuntaje.Text = modelo.PUNTAJECENEVAL
        Txtprombachi.Text = modelo.PROMEDIObACHILLERATO
        comboBachProc.Text = modelo.BACHILLERATOPROCEDENCIA
        'chkMaterial.Checked = Val(modelo.ADEUDO_MATERIAL)
        comboSecProc.Text = modelo.SECUNDARIAPROCEDENCIA
        chkDiscapacidad.Checked = Val(modelo.TIENE_DISCAPACIDAD)
        cmbDiscapacidad.Text = modelo.TIPO_DISCAPACIDAD
        txtObservacionesDisc.Text = modelo.DISCAPACIDAD_OBSERV
        direccionClinicaTxt.Text = modelo.CLINICA_DIRECCION
        cmbClinica.Text = modelo.CLINICA_IMSS
        txtEscuela.Text = modelo.ESCUELA_PRACTICA
        cmbEspecialidad.Text = modelo.IDESPECIALIDAD
        TXTPAPA.Text = modelo.NOMBRE_PAPA
        TXTMAMA.Text = modelo.NOMBRE_MAMA
        TXTLUGARNAC.Text = modelo.LUGAR_NACIMIENTO
        funcionesLocales.limpiarReceptorTabs(Me.TabPage3)
        traerHistorialInscripcion(Val(txtidAlumno.Text))
        traerhistorialDocumentos(Val(txtidAlumno.Text))
    End Sub
#Region "==========| MyCode |=========="

    Private Sub iniciarFormulario()

        Dim Estados As List(Of String) = model.getEstados()
        Dim Campus As List(Of String) = model.getCampus
        Dim Licenciaturas As List(Of String) = model.getLicenciaturas
        Dim Especialidades As List(Of String) = model.getEspecialidades
        Dim Modalidades As List(Of String) = model.getModalidades
        Dim Estatus As List(Of String) = model.getEstatusAlumno
        Dim Turnos As List(Of String) = model.getTurnos
        Dim Bachilleratos As List(Of String) = model.getBachilleratos
        Dim Secundaria As List(Of String) = model.getSecundarias
        Dim becas As List(Of String) = model.getBecas
        Dim discapacidades As List(Of String) = model.getDiscapacidades
        Dim semestres As List(Of String) = model.getSemestres
        Dim grupos As List(Of String) = model.getGrupos
        Dim clinicas As List(Of String) = model.getClinicas

        For Each clinica As String In clinicas
            cmbClinica.Items.Add(clinica)
        Next

        For Each bachiller As String In Bachilleratos
            comboBachProc.Items.Add(bachiller)
        Next

        For Each Secunda As String In Secundaria
            comboSecProc.Items.Add(Secunda)
        Next

        For Each beca As String In becas
            comboBeca.Items.Add(beca)
        Next

        For Each discapacidad As String In discapacidades
            cmbDiscapacidad.Items.Add(discapacidad)
        Next

        For Each semestre As String In semestres
            cmbSemestre.Items.Add(semestre)
        Next
        For Each grupo As String In grupos
            cmbGrupo.Items.Add(grupo)
        Next

        cmbGenero.Items.Add("H")
        cmbGenero.Items.Add("M")

        For Each Estado As String In Estados
            cmbEstado.Items.Add(Estado)
        Next
        cmbEstado.Text = "COLIMA"

        For Each C As String In Campus
            cmbCampus.Items.Add(C)
        Next

        For Each L As String In Licenciaturas
            cmbLicenciatura.Items.Add(L)
        Next

        cmbEspecialidad.Items.Add("")
        For Each E As String In Especialidades
            cmbEspecialidad.Items.Add(E)
        Next

        cmbModalidad.Items.Add("")
        For Each M As String In Modalidades
            cmbModalidad.Items.Add(M)
        Next
        cmbModalidad.Text = "E"
        'cmbModalidad.Enabled = False

        cmbEstatus.Items.Add("")
        For Each Es As String In Estatus
            cmbEstatus.Items.Add(Es)
        Next

        cmbTurno.Items.Add("")
        For Each T As String In Turnos
            cmbTurno.Items.Add(T)
        Next

        Me.Text = conf.TituloModulo
        If variables.tipoUsuario = 10 Then
            PromoverToolStripMenuItem.Enabled = False
            GuardarToolStripMenuItem.Enabled = False
            NuevoToolStripMenuItem.Enabled = False
            cmdEliminarHist.Enabled = False
            Button2.Enabled = False
        End If

    End Sub

    Private Sub reiniciarFormulario()
        Me.Controls.Clear()
        InitializeComponent()
        iniciarFormulario()
    End Sub

    Private Sub cargarAlumno(ByVal P As String)
        Dim A As datosCompartidos.Modelos.Alumno
        Dim SinImagen As String = System.AppDomain.CurrentDomain.BaseDirectory + "fa\nf.jpg"
        Dim ds As New DataSet
        Dim i As Integer = 0

        A = model.getAlumno(conf.getCamposRegreso(P).Item(0).ToString, _
                        conf.getCamposRegreso(P).Item(1).ToString, _
                        conf.getCamposRegreso(P).Item(2).ToString, _
                        conf.getCamposRegreso(P).Item(3).ToString, _
                        conf.getCamposRegreso(P).Item(4).ToString, _
                        conf.getCamposRegreso(P).Item(5).ToString, _
                        conf.getCamposRegreso(P).Item(6).ToString, _
                        conf.getCamposRegreso(P).Item(7).ToString, _
                        conf.getCamposRegreso(P).Item(8).ToString, _
                        conf.getCamposRegreso(P).Item(9).ToString, _
                        conf.getCamposRegreso(P).Item(10).ToString)

        txtNombre.Text = A.Nombre
        txtApellidoPaterno.Text = A.ApellidoPaterno
        txtApellidoMaterno.Text = A.ApellidoMaterno
        cmbGenero.Text = A.Genero
        txtCURP.Text = A.Curp
        txtNoSS.Text = A.NoSS
        If Not IsNothing(A.FechaNacimiento) And A.FechaNacimiento.Length > 0 Then oFechaNacimiento.Value = Date.Parse(A.FechaNacimiento)
        txtMatricula.Text = A.Matricula
        cmbCampus.Text = A.Campus
        cmbLicenciatura.Text = A.Licenciatura
        cmbEspecialidad.Text = A.Especialidad
        cmbModalidad.Text = A.Modalidad
        cmbTurno.Text = A.Turno
        cmbSemestre.Text = A.Semestre
        cmbGrupo.Text = A.Grupo
        txtGeneracion.Text = A.Generacion
        cmbEstatus.Text = A.Estatus
        txtPlanEstudios.Text = A.PlanEst
        If Not IsNothing(A.FechaIngreso) And A.FechaIngreso.Length > 0 Then oFechaIngreso.Value = Date.Parse(A.FechaIngreso)
        If Not IsNothing(A.FechaSalida) And A.FechaSalida.Length > 0 Then oFechaEgreso.Value = Date.Parse(A.FechaSalida)
        comboBeca.Text = A.Beca
        txtCalle.Text = A.Calle
        txtNumExt.Text = A.NumExterior
        txtNumInt.Text = A.NumInterior
        txtColonia.Text = A.Colonia
        cmbEstado.Text = A.Estado
        txtMunicipio.Text = A.Municipio
        txtCP.Text = A.CodigoPostal
        txtTelefono.Text = A.TelefonoCasa
        txtCelular.Text = A.TelefonoCel
        txtEmail.Text = A.CorreoElectronico
        txtContactoEmergencia.Text = A.ContactoEmergencia
        txtTelefonoEmergencia.Text = A.TelefonoEmergencia
        txtTipoSangre.Text = A.TipoSangre
        txtObservaciones.Text = A.Observaciones
        Txtpuntaje.Text = A.PuntajeCeneval
        Txtprombachi.Text = A.PromedioBachillerato
        comboBachProc.Text = A.BACHILLERATOPROCEDENCIA

        'If A.AdeudoLibrosMaterial = "0" Then
        'chkAdeudo.Checked = False
        'ElseIf A.AdeudoLibrosMaterial = "1" Then
        'chkAdeudo.Checked = True
        'End If

        'If model.getPagoInscripcion(A.Matricula, A.Campus, A.Licenciatura, A.Especialidad, A.Modalidad, A.Turno, A.Semestre, A.Grupo) = True Then
        '    chkPagoInscripcion.Checked = True
        'Else
        '    chkPagoInscripcion.Checked = False
        'End If

        'fotografia
        If A.Foto.Length > 0 And System.IO.File.Exists(A.Foto) Then
            oFotografia.Image = Image.FromFile(A.Foto)
            Fotografia = A.Foto
        ElseIf A.Foto.Length = 0 And System.IO.File.Exists(A.Foto) = False Then
            oFotografia.Image = Image.FromFile(FotoVacia)
            Fotografia = FotoVacia
        End If

    End Sub
    Private Sub guardarInformacion()
        Dim MsjError As String = ""
        Dim Ext As String = ""
        Dim FotoNueva As String = ""

        '=====================| validar entrada de datos |==========================================
        cambiarColorFondo(txtNombre, Color.White, Color.Black)
        If txtNombre.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el nombre." & vbCrLf
            cambiarColorFondo(txtNombre, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(txtApellidoPaterno, Color.White, Color.Black)
        If txtApellidoPaterno.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el apellido paterno." & vbCrLf
            cambiarColorFondo(txtApellidoPaterno, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(txtApellidoMaterno, Color.White, Color.Black)
        If txtApellidoMaterno.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el apellido materno." & vbCrLf
            cambiarColorFondo(txtApellidoMaterno, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(cmbGenero, Color.White, Color.Black)
        If cmbGenero.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el género." & vbCrLf
            cambiarColorFondo(cmbGenero, Color.Salmon, Color.White)
        End If

        If txtCURP.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar la CURP." & vbCrLf
        If txtNoSS.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el número del seguro social." & vbCrLf

        cambiarColorFondo(cmbCampus, Color.White, Color.Black)
        If cmbCampus.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el campus." & vbCrLf
            cambiarColorFondo(cmbCampus, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(cmbLicenciatura, Color.White, Color.Black)
        If cmbLicenciatura.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el dato de bachillerato/licenciatura/maestría." & vbCrLf
            cambiarColorFondo(cmbLicenciatura, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(cmbEspecialidad, Color.White, Color.Black)
        If cmbEspecialidad.Text.Length = 0 And (cmbLicenciatura.Text = "EDUCACIÓN ESPECIAL" Or cmbLicenciatura.Text = "EDUCACIÓN SECUNDARIA") Then
            MsjError = MsjError & "- Falta proporcionar la especialidad." & vbCrLf
            cambiarColorFondo(cmbEspecialidad, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(cmbModalidad, Color.White, Color.Black)
        If cmbModalidad.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar la modalidad." & vbCrLf
            cambiarColorFondo(cmbModalidad, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(cmbTurno, Color.White, Color.Black)
        If cmbTurno.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el turno." & vbCrLf
            cambiarColorFondo(cmbTurno, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(cmbSemestre, Color.White, Color.Black)
        If cmbSemestre.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el semestre." & vbCrLf
            cambiarColorFondo(cmbSemestre, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(cmbGrupo, Color.White, Color.Black)

        If MsjError.Length > 0 Then
            MessageBox.Show("Para poder almacenar la información es necesario que atienda lo siguiente: " & vbCrLf & MsjError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        '=====================| truncar datos |==========================================
        If txtDatos.Text.Length > 0 Then

            Dim Matricula As String, Nombre As String, ApellidoPaterno As String, ApellidoMaterno As String, _
            Campus As String, Licenciatura As String, Especialidad As String, _
            Modalidad As String, Turno As String, Semestre As String, Grupo As String

            Matricula = conf.getCamposRegreso(txtDatos.Text).Item(0).ToString()
            Nombre = conf.getCamposRegreso(txtDatos.Text).Item(1).ToString()
            ApellidoPaterno = conf.getCamposRegreso(txtDatos.Text).Item(2).ToString()
            ApellidoMaterno = conf.getCamposRegreso(txtDatos.Text).Item(3).ToString()
            Campus = conf.getCamposRegreso(txtDatos.Text).Item(4).ToString()
            Licenciatura = conf.getCamposRegreso(txtDatos.Text).Item(5).ToString()
            Especialidad = conf.getCamposRegreso(txtDatos.Text).Item(6).ToString()
            Modalidad = conf.getCamposRegreso(txtDatos.Text).Item(7).ToString()
            Turno = conf.getCamposRegreso(txtDatos.Text).Item(8).ToString()
            Semestre = conf.getCamposRegreso(txtDatos.Text).Item(9).ToString()
            Grupo = conf.getCamposRegreso(txtDatos.Text).Item(10).ToString()

            If Grupo <> "" Then
                model.truncarAlumno(Matricula, Nombre, ApellidoPaterno, ApellidoMaterno, Campus, Licenciatura, Especialidad, Modalidad, Turno, Semestre, Grupo)
            Else
                model.truncarAlumno2(Matricula, Nombre, ApellidoPaterno, ApellidoMaterno, Campus, Licenciatura, Especialidad, Modalidad, Turno, Semestre)
            End If

        End If

        '=====================| alta registro |==========================================
        If Fotografia.Length > 0 And File.Exists(Fotografia) And Directory.Exists("\\192.168.1.109\Users\usuario\Documents\fotos\") Then
            Ext = Path.GetExtension(Fotografia)
            RutaServerFotos = Trim(conf.getIgnition2())
            FotoNueva = RTrim(LTrim(RutaServerFotos)) & txtMatricula.Text & Ext
            FotoNueva = FotoNueva.Replace(" ", "")
            File.Copy(Fotografia, FotoNueva)
        End If

        model.altaAlumno(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, _
                cmbGenero.Text, txtCURP.Text, oFechaNacimiento.Value.Date, _
                txtCalle.Text, txtNumExt.Text, txtNumInt.Text, _
                txtColonia.Text, cmbEstado.Text, txtMunicipio.Text, _
                txtCP.Text, txtTelefono.Text, txtCelular.Text, _
                txtEmail.Text, txtContactoEmergencia.Text, txtTelefonoEmergencia.Text, _
                txtTipoSangre.Text, txtObservaciones.Text, txtMatricula.Text, _
                cmbSemestre.Text, cmbGrupo.Text, comboBeca.Text, _
                cmbCampus.Text, txtPlanEstudios.Text, txtGeneracion.Text, _
                oFechaIngreso.Value.Date, oFechaEgreso.Value.Date, cmbTurno.Text, _
                cmbLicenciatura.Text, cmbEspecialidad.Text, cmbModalidad.Text,
                cmbEstatus.Text, FotoNueva, txtNoSS.Text, Txtpuntaje.Text, Txtprombachi.Text, comboBachProc.Text)
        '=====================| adeudo de material/libros |==========================================
        'model.adeudoLibros(txtMatricula.Text, chkAdeudo.Checked)

        '=====================| pago inscripcion/reinscripcion |=====================================
        model.pagoInscripcion(txtMatricula.Text, _
                                 cmbCampus.Text, _
                                 cmbLicenciatura.Text, _
                                 cmbEspecialidad.Text, _
                                 cmbModalidad.Text, _
                                 cmbTurno.Text, _
                                 cmbSemestre.Text, _
                                 cmbGrupo.Text)

        '====================| actualizar el grupo en la tabla calificacion | ====================
        model.act_calificacion_grupo(cmbGrupo.Text, txtMatricula.Text, cmbSemestre.Text)
        '====================| actualizar el dato matricula en las tablas 

        'alumno
        'alumno_pago
        'calificaciones
        'certificados
        'doc_recepcional_liberado
        'examen_profesional
        'tit_carta_compromiso
        'tit_integracion_expediente
        'tit_recepcion_documentos

        reiniciarFormulario()

        MessageBox.Show("La información proporcionada ha sido almacenada en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub promoverAlumno()
        Dim Er As datosCompartidos.Modelos.AlumnosModel.MensajesAlumnoRegular
        Dim MensajeError As String = ""

        btnPromover.Enabled = False

        'validar que el alumno es regular
        Er = model.esAlumnoRegular(txtMatricula.Text, cmbSemestre.Text, cmbGrupo.Text)

        If Er.ErrorCalificaciones.Length > 0 Then MensajeError = MensajeError & Er.ErrorCalificaciones & vbCrLf
        If Er.ErrorActDepCult.Length > 0 Then MensajeError = MensajeError & Er.ErrorActDepCult & vbCrLf
        If Er.ErrorSevicios.Length > 0 Then MensajeError = MensajeError & Er.ErrorSevicios & vbCrLf
        If Er.ErrorAdeudoLibros.Length > 0 Then MensajeError = MensajeError & Er.ErrorAdeudoLibros & vbCrLf
        If Er.ErrorPago.Length > 0 Then MensajeError = MensajeError & Er.ErrorPago & vbCrLf

        If MensajeError.Length > 0 Then
            MensajeError = "El alumno(a) no puede ser promovido debido a lo siguiente: " & vbCrLf & MensajeError
            MessageBox.Show(MensajeError, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnPromover.Enabled = True
            Return
        End If

        'promocion del alumno
        model.promoverAlumno(txtMatricula.Text)
        cmbSemestre.Text = (Integer.Parse(cmbSemestre.Text) + 1)
        btnPromover.Enabled = True

    End Sub

    Private Sub cambiarColorFondo(ByRef _Control As Control, ByVal ColorFondo As Color, ByVal ColorLetra As Color)
        _Control.BackColor = ColorFondo
        _Control.ForeColor = ColorLetra
    End Sub

#End Region
    Private Sub traerhistorialDocumentos(id As Integer)
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from alumnoDocumentos where idAlumno=" & id & ""
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                'Datos de Acta
                txtOrigActa.Text = variables.SQLdr("actaOriginal").ToString
                txtCopiaActa.Text = variables.SQLdr("actaCopia").ToString
                txtObsActa.Text = variables.SQLdr("actaObservaciones").ToString
                If variables.SQLdr("faltaActa") = 1 Then
                    chkFaltoActa.Checked = True
                Else
                    chkFaltoActa.Checked = False
                End If
                'Datos de Curp
                txtCurpOrig.Text = variables.SQLdr("curpOriginal").ToString
                txtCurpCopia.Text = variables.SQLdr("curpCopia").ToString
                txtCurpObs.Text = variables.SQLdr("curpObservaciones").ToString
                If variables.SQLdr("faltaCurp") = 1 Then
                    chkFaltoCurp.Checked = True
                Else
                    chkFaltoCurp.Checked = False
                End If
                'Datos de Certificado
                txtCertOrig.Text = variables.SQLdr("certificadoOriginal").ToString
                txtCertCopia.Text = variables.SQLdr("certificadoCopia").ToString
                txtCertObs.Text = variables.SQLdr("certificadoObservaciones").ToString
                If variables.SQLdr("faltaCertificado") = 1 Then
                    chkFaltoCertificado.Checked = True
                Else
                    chkFaltoCertificado.Checked = False
                End If
                'Datos de Comprobante de Domicilio
                txtDomOrig.Text = variables.SQLdr("domicilioOriginal").ToString
                txtDomCopia.Text = variables.SQLdr("domicilioCopia").ToString
                txtDomObs.Text = variables.SQLdr("domicilioObservaciones").ToString
                If variables.SQLdr("faltaDomicilio") = 1 Then
                    chkFaltoComprobante.Checked = True
                Else
                    chkFaltoComprobante.Checked = False
                End If
                'Datos de Comprobante de Medico
                txtMedicoOrig.Text = variables.SQLdr("medicoOriginal").ToString
                txtMedicocopia.Text = variables.SQLdr("medicoCopia").ToString
                txtMedicoObs.Text = variables.SQLdr("medicoObservaciones").ToString
                If variables.SQLdr("faltaMedico") = 1 Then
                    chkFaltoMedico.Checked = True
                Else
                    chkFaltoMedico.Checked = False
                End If
                'Datos de Comprobante de Fotos
                txtFotosOrig.Text = variables.SQLdr("fotosOriginal").ToString
                txtFotosObs.Text = variables.SQLdr("fotosObservaciones").ToString
                If variables.SQLdr("faltaFotos") = 1 Then
                    chkFaltoFotos.Checked = True
                Else
                    chkFaltoFotos.Checked = False
                End If
                'Datos de Comprobante de Pagos
                txtPagosOrig.Text = variables.SQLdr("pagoOriginal").ToString
                txtPagoscopia.Text = variables.SQLdr("pagoCopia").ToString
                txtPagosobs.Text = variables.SQLdr("pagoObservaciones").ToString
                If variables.SQLdr("faltaPago") = 1 Then
                    chkFaltoPago.Checked = True
                Else
                    chkFaltoPago.Checked = False
                End If

            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub traerHistorialInscripcion(id As Integer)
        Dim ds As New DataSet
        Dim b As New BaseDatos
        Dim sql As String

        sql = "select idMovimiento,matricula,campus,licenciatura,semestre,grupo,turno,fecha,cicloescolar," & _
            "tipobeca,observaciones,idalumno from alumno_pago where idalumno=" & id & "  order by cicloEscolar"

        b.abrirConexion()
        ds = b.getDataSet(sql)
        b.cerrarConexion()
        dgInscrito.DataSource = ds.Tables(0)
        dgInscrito.Refresh()
    End Sub
    Private Sub frmAlumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub


    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        If txtDatos.Text.Length > 0 Then
            cargarAlumno(txtDatos.Text)
        End If
    End Sub

    Private Sub cmbLicenciatura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLicenciatura.SelectedIndexChanged
        If cmbLicenciatura.Text = "EDUCACIÓN ESPECIAL" Or cmbLicenciatura.Text = "EDUCACIÓN SECUNDARIA" Then
            cmbEspecialidad.Visible = True
            cmbEspecialidad.Text = ""
        Else
            cmbEspecialidad.Visible = False
            cmbEspecialidad.Text = ""
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If variables.tipoUsuario <> 10 Then
            Dim _modelo As New modelos.modeloAlumno
            _modelo.IDALUMNO = Val(txtidAlumno.Text)
            _modelo.NOMBRE = txtNombre.Text
            _modelo.APELLIDO_PATERNO = txtApellidoPaterno.Text
            _modelo.APELLIDO_MATERNO = txtApellidoMaterno.Text
            _modelo.GENERO = cmbGenero.Text
            _modelo.CALLE = txtCalle.Text
            _modelo.NUMERO_INTERIOR = txtNumInt.Text
            _modelo.NUMERO_EXTERIOR = txtNumExt.Text
            _modelo.COLONIA = txtColonia.Text
            _modelo.IDMUNICIPIO = txtMunicipio.Text
            _modelo.IDESTADO = cmbEstado.Text
            _modelo.CODIGO_POSTAL = txtCP.Text
            _modelo.CURP = txtCURP.Text
            _modelo.TELEFONO_CASA = txtTelefono.Text
            _modelo.TELEFONO_CEL = txtCelular.Text
            _modelo.CORREO_ELECTRONICO = txtEmail.Text
            _modelo.FECHA_NACIMIENTO = oFechaNacimiento.Value
            _modelo.FECHA_INGRESO = oFechaIngreso.Value
            _modelo.FECHA_SALIDA = oFechaEgreso.Value
            _modelo.TIPO_SANGRE = txtTipoSangre.Text
            _modelo.OBSERVACIONES = txtObservaciones.Text
            _modelo.CONTACTO_EMERGENCIA = txtContactoEmergencia.Text
            _modelo.TELEFONO_EMERGENCIA = txtTelefonoEmergencia.Text
            _modelo.MATRICULA = txtMatricula.Text
            _modelo.IDCAMPUS = cmbCampus.Text
            _modelo.IDturno = cmbTurno.Text
            _modelo.IDSTATUS = cmbEstatus.Text
            _modelo.IDAREA = " "
            _modelo.IDMODALIDAD = cmbModalidad.Text
            _modelo.IDESPECIALIDAD = cmbEspecialidad.Text
            _modelo.IDSEMESTRE = cmbSemestre.Text
            _modelo.IDGRUPO = cmbGrupo.Text
            _modelo.IDLICENCIATURA = cmbLicenciatura.Text
            _modelo.PLANEST = txtPlanEstudios.Text
            _modelo.GENERACION = txtGeneracion.Text
            _modelo.BECA = comboBeca.Text
            _modelo.NO_SS = txtNoSS.Text
            _modelo.ADEUDO_LIBROS = 1 'Val(chkAdeudo.Checked)
            _modelo.PUNTAJECENEVAL = Txtpuntaje.Text
            _modelo.PROMEDIObACHILLERATO = Txtprombachi.Text
            _modelo.BACHILLERATOPROCEDENCIA = comboBachProc.Text
            _modelo.ADEUDO_MATERIAL = 1 'Val(chkMaterial.Checked)
            _modelo.SECUNDARIAPROCEDENCIA = comboSecProc.Text
            _modelo.CLINICA_IMSS = cmbClinica.Text
            _modelo.TIENE_DISCAPACIDAD = Val(chkDiscapacidad.Checked)
            _modelo.TIPO_DISCAPACIDAD = cmbDiscapacidad.Text
            _modelo.DISCAPACIDAD_OBSERV = txtObservacionesDisc.Text
            _modelo.CLINICA_DIRECCION = direccionClinicaTxt.Text
            _modelo.ESCUELA_PRACTICA = txtEscuela.Text
            _modelo.NOMBRE_MAMA = TXTMAMA.Text
            _modelo.NOMBRE_PAPA = TXTPAPA.Text
            _modelo.LUGAR_NACIMIENTO = TXTLUGARNAC.Text
            _modelo.usuario = variables.usuario
            If IsNothing(oFotografia.Image) Then
                oFotografia.Image = Image.FromFile(FotoVacia)
                Fotografia = FotoVacia
                txtFotografia.Text = FotoVacia
            End If


            Dim ms As New System.IO.MemoryStream()
            oFotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            _modelo.FOTO = ms.GetBuffer()
            ' If funcionesLocales.validarReceptor(GroupBox1) = True Then
            If _modelo.IDALUMNO > 0 Then
                funcionesLocales.actualizarAlumno(_modelo)
                almacenadocumentos()
            Else
                funcionesLocales.guardarAlumno(_modelo)
                Dim _m As New modelos.modeloAlumno
                _m = funcionesLocales.traerUltimoAlumno()
                txtidAlumno.Text = _m.IDALUMNO
                txtNombre.Text = _m.NOMBRE
                txtApellidoPaterno.Text = _m.APELLIDO_PATERNO
                txtApellidoMaterno.Text = _m.APELLIDO_MATERNO
                cmbGenero.Text = _m.GENERO
                txtCalle.Text = _m.CALLE
                txtNumInt.Text = _m.NUMERO_INTERIOR
                txtNumExt.Text = _m.NUMERO_EXTERIOR
                txtColonia.Text = _m.COLONIA
                txtMunicipio.Text = _m.IDMUNICIPIO
                cmbEstado.Text = _m.IDESTADO
                txtCP.Text = _m.CODIGO_POSTAL
                txtCURP.Text = _m.CURP
                txtTelefono.Text = _m.TELEFONO_CASA
                txtCelular.Text = _m.TELEFONO_CEL
                txtEmail.Text = _m.CORREO_ELECTRONICO
                oFechaNacimiento.Value = Date.Parse(_m.FECHA_NACIMIENTO)
                oFechaIngreso.Value = Date.Parse(_m.FECHA_INGRESO)
                oFechaEgreso.Value = Date.Parse(_m.FECHA_SALIDA)
                txtTipoSangre.Text = _m.TIPO_SANGRE
                txtObservaciones.Text = _m.OBSERVACIONES
                txtContactoEmergencia.Text = _m.CONTACTO_EMERGENCIA
                txtTelefonoEmergencia.Text = _m.TELEFONO_EMERGENCIA
                txtMatricula.Text = _m.MATRICULA
                cmbCampus.Text = _m.IDCAMPUS
                cmbTurno.Text = _m.IDturno
                cmbEstatus.Text = _m.IDSTATUS
                cmbModalidad.Text = _m.IDMODALIDAD
                cmbEspecialidad.Text = _m.IDESPECIALIDAD
                cmbSemestre.Text = _m.IDSEMESTRE
                cmbGrupo.Text = _m.IDGRUPO
                cmbLicenciatura.Text = _m.IDLICENCIATURA

                Dim bytBLOBData() As Byte = _m.FOTO
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                oFotografia.Image = Image.FromStream(stmBLOBData)

                txtPlanEstudios.Text = _m.PLANEST
                txtGeneracion.Text = _m.GENERACION
                comboBeca.Text = _m.BECA
                txtNoSS.Text = _m.NO_SS
                'chkAdeudo.Checked = Val(_m.ADEUDO_LIBROS)
                Txtpuntaje.Text = _m.PUNTAJECENEVAL
                Txtprombachi.Text = _m.PROMEDIObACHILLERATO
                comboBachProc.Text = _m.BACHILLERATOPROCEDENCIA
                'chkMaterial.Checked = Val(_m.ADEUDO_MATERIAL)
                comboSecProc.Text = _m.SECUNDARIAPROCEDENCIA
                cmbClinica.Text = _m.CLINICA_IMSS
                chkDiscapacidad.Checked = Val(_m.TIENE_DISCAPACIDAD)
                cmbDiscapacidad.Text = _m.TIPO_DISCAPACIDAD
                txtObservacionesDisc.Text = _m.DISCAPACIDAD_OBSERV
                direccionClinicaTxt.Text = _m.CLINICA_DIRECCION
                txtEscuela.Text = _m.ESCUELA_PRACTICA
                TXTPAPA.Text = _m.NOMBRE_PAPA
                TXTMAMA.Text = _m.NOMBRE_MAMA
                TXTLUGARNAC.Text = _m.LUGAR_NACIMIENTO
                traerHistorialInscripcion(Val(txtidAlumno.Text))
            End If
        Else
            MsgBox("ESTA FUNCION NO ESTA PERMITIDA PARA ESTE TIPO DE USUARIO", MsgBoxStyle.Critical, "ALERTA!!!!")
        End If
        'End If
        'guardarInformacion()
    End Sub

    Private Sub btnPromover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromover.Click
        promoverAlumno()
    End Sub

    Private Sub Fotografia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oFotografia.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Archivos de Imagen (JPG, PNG)|*.jpg;*.png"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                    oFotografia.Image = Image.FromFile(openFileDialog1.FileName)
                    Fotografia = openFileDialog1.FileName
                    txtFotografia.Text = Fotografia
                End If
            Catch Ex As Exception
                MessageBox.Show("No se puede tener acceso al archivo. Error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub nuevoCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoCmd.Click
        reiniciarFormulario()
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub eliminarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _M As New modelos.modeloAlumno
        _M.MATRICULA = txtMatricula.Text
        If variables.tipoUsuario = 10 Then
            modificacionCalifFrm.GuardarCambiosToolStripMenuItem.Visible = False
            modificacionCalifFrm.EliminarCalificacionSeleccionadaToolStripMenuItem.Enabled = False
            modificacionCalifFrm.LimpiarGridToolStripMenuItem.Enabled = False
        End If
        modificacionCalifFrm.Show()
        modificacionCalifFrm.txtmatricula.Text = _M.MATRICULA
      
        modificacionCalifFrm.generarConsultaPrincipal(1)
    End Sub
    Private Sub cmbClinica_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClinica.SelectedValueChanged
        Try
            Dim valorDir As String = ""
            variables.conexion.abrirConexion()
            variables.sql = "select * from clinicas where nombre='" & cmbClinica.Text & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                valorDir = "DIRECCION: " + UCase(Trim(variables.SQLdr("domicilio").ToString)) + vbCrLf + "TELEFONO: " + Trim(variables.SQLdr("telefono").ToString)
            End While
            direccionClinicaTxt.Text = valorDir
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub cmdEliminarHist_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminarHist.Click
        If dgInscrito.RowCount > 0 Then
            Dim mensaje As String = MsgBox("Deseas Eliminar siguiente movimiento: " & dgInscrito.CurrentRow.Cells("idMovimiento").Value.ToString, vbYesNo)
            If mensaje = vbYes Then
                If Not dgInscrito.CurrentRow.IsNewRow Then
                    funcionesLocales.eliminarPago(dgInscrito.CurrentRow.Cells("idMovimiento").Value)
                    dgInscrito.Rows.Remove(dgInscrito.CurrentRow)
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        webcam.timer_tick(oFotografia)
    End Sub

    Private Sub btnBegin_Click(sender As System.Object, e As System.EventArgs) Handles btnBegin.Click
        webcam.Iniciar(Timer1, Me)
    End Sub

    Private Sub btnTake_Click(sender As System.Object, e As System.EventArgs) Handles btnTake.Click
        'webcam.Capturar(oFotografia)
        webcam.Detener(Timer1)
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegresarToolStripMenuItem.Click
        Call salirCmd_Click(sender, e)
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Call nuevoCmd_Click(sender, e)
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Call btnGuardar_Click(sender, e)
    End Sub

    Private Sub VerCalificacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerCalificacionesToolStripMenuItem.Click
        Call Button1_Click(sender, e)
    End Sub

    Private Sub PromoverToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PromoverToolStripMenuItem.Click
        Call btnPromover_Click(sender, e)
    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "alumnos"
        frmBuscarAlumno.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            If Val(txtidAlumno.Text) = 0 Then
                MsgBox("Error no hay Alumno Seleccionado", vbCritical)
                Exit Sub
            End If
            variables.conexion.abrirConexion()
            Dim sql As String

            sql = "INSERT INTO alumno_pago(matricula,nombreAl,campus,licenciatura,especialidad,turno,semestre,grupo,fecha,cicloescolar,tipobeca,observaciones,idAlumno)" & _
                "VALUES(@matricula,@nombreAl,@campus,@licenciatura,@especialidad,@turno,@semestre,@grupo,@fecha,@cicloescolar,@tipobeca,@observaciones,@idAlumno) "
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@matricula", txtMatricula.Text)
                .Parameters.AddWithValue("@nombreAl", txtApellidoPaterno.Text & " " & txtApellidoMaterno.Text & " " & txtNombre.Text)
                .Parameters.AddWithValue("@campus", cmbCampus.Text)
                .Parameters.AddWithValue("@licenciatura", cmbLicenciatura.Text)
                .Parameters.AddWithValue("@especialidad", cmbEspecialidad.Text)
                .Parameters.AddWithValue("@turno", cmbTurno.Text)
                .Parameters.AddWithValue("@semestre", cmbSemestre.Text)
                .Parameters.AddWithValue("@grupo", cmbGrupo.Text)
                .Parameters.AddWithValue("@fecha", Now.Date)
                .Parameters.AddWithValue("@cicloescolar", Cmbciclo.Text)
                .Parameters.AddWithValue("@tipobeca", comboBeca.Text)
                .Parameters.AddWithValue("@observaciones", cmbObservaciones.Text)
                .Parameters.AddWithValue("@idAlumno", Val(txtidAlumno.Text))
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Alumno Inscrito: " & txtNombre.Text & " " & txtApellidoPaterno.Text & " " & txtApellidoMaterno.Text)

            variables.conexion.cerrarConexion()
            traerHistorialInscripcion(Val(txtidAlumno.Text))

            'variables.idalumno = Val(txtidAlumno.Text)
            'variables.faltaDocs = cmbObservaciones.Text
            'impresionFicha.Show()
        Catch
            MsgBox("Error Actualizando Verifique", vbCritical)
            Exit Sub
        End Try
    End Sub
    'funcion para doc del alumno
    Private Sub almacenadocumentos()
        Dim _modelo As New modelos.modeloAlumnoDocumentosInscripcion
        _modelo.actaCopia = Val(txtCopiaActa.Text)
        _modelo.actaOriginal = Val(txtOrigActa.Text)
        _modelo.actaObservaciones = txtObsActa.Text
        _modelo.curpOriginal = Val(txtCurpOrig.Text)
        _modelo.curpCopia = Val(txtCurpCopia.Text)
        _modelo.curpObservaciones = txtCurpObs.Text
        _modelo.certificadoOriginal = Val(txtCertOrig.Text)
        _modelo.certificadoCopia = Val(txtCertCopia.Text)
        _modelo.certificadoObservaciones = txtCertObs.Text
        _modelo.domicilioOriginal = Val(txtDomOrig.Text)
        _modelo.domicilioCopia = Val(txtDomCopia.Text)
        _modelo.domicilioObservaciones = txtDomObs.Text
        _modelo.medicoOriginal = Val(txtMedicoOrig.Text)
        _modelo.medicoCopia = Val(txtMedicocopia.Text)
        _modelo.medicoObservaciones = txtMedicoObs.Text
        _modelo.fotosOriginal = Val(txtFotosOrig.Text)
        _modelo.fotosObservaciones = txtFotosObs.Text
        _modelo.pagoOriginal = Val(txtPagosOrig.Text)
        _modelo.pagoCopia = Val(txtPagoscopia.Text)
        _modelo.pagoObservaciones = txtPagosobs.Text
        _modelo.idAlumno = Val(txtidAlumno.Text)
        _modelo.idUsuario = variables.idusuario
        If chkFaltoActa.Checked = True Then
            _modelo.faltaActa = 1
        Else
            _modelo.faltaActa = 0
        End If
        If chkFaltoCertificado.Checked = True Then
            _modelo.faltaCertificado = 1
        Else
            _modelo.faltaCertificado = 0
        End If
        If chkFaltoComprobante.Checked = True Then
            _modelo.faltaDomicilio = 1
        Else
            _modelo.faltaDomicilio = 0
        End If
        If chkFaltoCurp.Checked = True Then
            _modelo.faltaCurp = 1
        Else
            _modelo.faltaCurp = 0
        End If
        If chkFaltoFotos.Checked = True Then
            _modelo.faltaFotos = 1
        Else
            _modelo.faltaFotos = 0
        End If
        If chkFaltoMedico.Checked = True Then
            _modelo.faltaMedico = 1
        Else
            _modelo.faltaMedico = 0
        End If
        If chkFaltoPago.Checked = True Then
            _modelo.faltaPago = 1
        Else
            _modelo.faltaPago = 0
        End If
        ' _modelo.id = 0
            funcionesLocales.actualizarAlumnoDocumentos(_modelo)

    End Sub

End Class