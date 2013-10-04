Imports System.IO

Public Class frmAlumnos

    Private conf As New Configuracion
    Private model As New Modelos.AlumnosModel

    Private RutaServerFotos As String = ""
    Private Fotografia As String = ""
    Private FotoVacia As String = System.AppDomain.CurrentDomain.BaseDirectory + "nf.jpg"

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

        oFotografia.Image = Image.FromFile(FotoVacia)

        For Each bachiller As String In Bachilleratos
            comboBachProc.Items.Add(bachiller)
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
        cmbModalidad.Enabled = False

        cmbEstatus.Items.Add("")
        For Each Es As String In Estatus
            cmbEstatus.Items.Add(Es)
        Next

        cmbTurno.Items.Add("")
        For Each T As String In Turnos
            cmbTurno.Items.Add(T)
        Next

        Grid.Columns.Clear()
        Grid.Rows.Clear()

        Me.Text = conf.TituloModulo

    End Sub

    Private Sub reiniciarFormulario()
        Me.Controls.Clear()
        InitializeComponent()
        iniciarFormulario()
    End Sub

    Private Sub cargarAlumno(ByVal P As String)
        Dim A As Modelos.Alumno
        Dim SinImagen As String = System.AppDomain.CurrentDomain.BaseDirectory + "fa\nf.jpg"
        Dim ds As New DataSet
        Dim i As Integer = 0

        Grid.Columns.Clear()
        Grid.Rows.Clear()

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
        txtSemestre.Text = A.Semestre
        txtGrupo.Text = A.Grupo
        txtGeneracion.Text = A.Generacion
        cmbEstatus.Text = A.Estatus
        txtPlanEstatal.Text = A.PlanEst
        If Not IsNothing(A.FechaIngreso) And A.FechaIngreso.Length > 0 Then oFechaIngreso.Value = Date.Parse(A.FechaIngreso)
        If Not IsNothing(A.FechaSalida) And A.FechaSalida.Length > 0 Then oFechaEgreso.Value = Date.Parse(A.FechaSalida)
        txtBeca.Text = A.Beca
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
        If A.AdeudoLibrosMaterial = "0" Then
            chkAdeudoMaterial.Checked = False
        ElseIf A.AdeudoLibrosMaterial = "1" Then
            chkAdeudoMaterial.Checked = True
        End If

        If model.getPagoInscripcion(A.Matricula, A.Campus, A.Licenciatura, A.Especialidad, A.Modalidad, A.Turno, A.Semestre, A.Grupo) = True Then
            chkPagoInscripcion.Checked = True
        Else
            chkPagoInscripcion.Checked = False
        End If

        'fotografia
        If A.Foto.Length > 0 And System.IO.File.Exists(A.Foto) Then
            oFotografia.Image = Image.FromFile(A.Foto)
            Fotografia = A.Foto
        ElseIf A.Foto.Length = 0 And System.IO.File.Exists(A.Foto) = False Then
            oFotografia.Image = Image.FromFile(FotoVacia)
            Fotografia = FotoVacia
        End If

        'cargar calificaciones
        ds = model.getCalificacionesAlumno(A.Matricula)
        Dim Promedio As Double = 0
        If ds.Tables(0).Rows.Count > 0 Then
            For Each C As DataColumn In ds.Tables(0).Columns
                Grid.Columns.Add(C.ColumnName.ToString.ToUpper, C.ColumnName.ToString.ToUpper)
            Next

            Grid.Columns.Add("PROMEDIO", "PROMEDIO")

            Grid.Rows.Add(ds.Tables(0).Rows.Count)

            For Each F As DataRow In ds.Tables(0).Rows
                Promedio = 0
                Grid("SEMESTRE", i).Value = F("SEMESTRE").ToString
                Grid("GRUPO", i).Value = F("GRUPO").ToString
                Grid("MATERIA", i).Value = F("MATERIA").ToString
                If F("MATERIA").ToString = "Actividades Culturales y Deportivas" Then
                    Promedio = Decimal.Parse(F("PRIMER PARCIAL").ToString) + Decimal.Parse(F("SEGUNDA PARCIAL").ToString)
                    If F("PRIMER PARCIAL").ToString >= "1" Then
                        Grid("PRIMER PARCIAL", i).Value = "AC"
                    Else
                        Grid("PRIMER PARCIAL", i).Value = "NA"
                    End If
                    If F("SEGUNDA PARCIAL").ToString >= "1" Then
                        Grid("SEGUNDA PARCIAL", i).Value = "AC"
                    Else
                        Grid("SEGUNDA PARCIAL", i).Value = "NA"
                    End If
                    If Promedio >= 1 Then
                        'SE PONE EL ACREDITADO
                        Grid("PROMEDIO", i).Value = "AC"
                    Else
                        'SE PONE NO ACREDITADO
                        Grid("PROMEDIO", i).Value = "NA"
                    End If
                ElseIf F("MATERIA").ToString = "Servicio Social Interno" Then
                    '  Promedio = Integer.Parse(Grid("PRIMER PARCIAL", i).Value) + Integer.Parse(Grid("SEGUNDA PARCIAL", i).Value)
                    Promedio = Decimal.Parse(F("PRIMER PARCIAL").ToString) + Decimal.Parse(F("SEGUNDA PARCIAL").ToString)

                    If F("PRIMER PARCIAL").ToString >= "1" Then
                        Grid("PRIMER PARCIAL", i).Value = "AC"
                    Else
                        Grid("PRIMER PARCIAL", i).Value = "NA"
                    End If
                    If F("SEGUNDA PARCIAL").ToString >= "1" Then
                        Grid("SEGUNDA PARCIAL", i).Value = "AC"
                    Else
                        Grid("SEGUNDA PARCIAL", i).Value = "NA"
                    End If
                    If Promedio >= 1 Then
                        'SE PONE EL ACREDITADO
                        Grid("PROMEDIO", i).Value = "AC"
                    Else
                        'SE PONE NO ACREDITADO
                        Grid("PROMEDIO", i).Value = "NA"
                    End If
                Else
                    Grid("PRIMER PARCIAL", i).Value = F("PRIMER PARCIAL").ToString
                    Grid("SEGUNDA PARCIAL", i).Value = F("SEGUNDA PARCIAL").ToString
                    '**************** validacion para el promedio *************************
                    If Grid("PRIMER PARCIAL", i).Value > 0 And Grid("SEGUNDA PARCIAL", i).Value > 0 Then
                        Promedio = (Integer.Parse(Grid("PRIMER PARCIAL", i).Value) + Integer.Parse(Grid("SEGUNDA PARCIAL", i).Value)) / 2
                    End If
                    If Decimal.Parse(F("REGU 1").ToString) > 0 Then
                        Promedio = Decimal.Parse(F("REGU 1").ToString)
                    End If
                    If Decimal.Parse(F("REGU 2").ToString) > 0 Then
                        Promedio = Decimal.Parse(F("REGU 2").ToString)
                    End If
                    If Decimal.Parse(F("REGU 3").ToString) > 0 Then
                        Promedio = Decimal.Parse(F("REGU 3").ToString)
                    End If
                    If Decimal.Parse(F("REGU 4").ToString) > 0 Then
                        Promedio = Decimal.Parse(F("REGU 4").ToString)
                    End If
                    '**************************************************************************
                    '========== ESTE CODIGO ES PARA CAMBIAR A N/P LAS CALIFICACIONES QUE SON 13
                    If F("REGU 1").ToString = 13 Then
                        Grid("REGU 1", i).Value = "N/P"
                    Else
                        Grid("REGU 1", i).Value = F("REGU 1").ToString
                    End If
                    If F("REGU 2").ToString = 13 Then
                        Grid("REGU 2", i).Value = "N/P"
                    Else
                        Grid("REGU 2", i).Value = F("REGU 2").ToString
                    End If
                    If F("REGU 3").ToString = 13 Then
                        Grid("REGU 3", i).Value = "N/P"
                    Else
                        Grid("REGU 3", i).Value = F("REGU 3").ToString
                    End If
                    If F("REGU 4").ToString = 13 Then
                        Grid("REGU 4", i).Value = "N/P"
                    Else
                        Grid("REGU 4", i).Value = F("REGU 4").ToString
                    End If
                    If Promedio = 13 Then
                        Grid("PROMEDIO", i).Value = "N/P"
                    ElseIf Promedio > 0 Then
                        Grid("PROMEDIO", i).Value = Promedio
                    Else
                        Grid("PROMEDIO", i).Value = "5"
                    End If

                End If
                '=== VALIDAR PROMEDIOS POR SI ES DEPORTIVA O CULTURAL Y SI ES N/P
                'If Promedio = 13 Then
                '    Grid("PROMEDIO", i).Value = "N/P"
                'End If
                'Grid("PROMEDIO", i).Value = Promedio

                i = i + 1
            Next

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

        'If txtCURP.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar la CURP." & vbCrLf
        'If txtNoSS.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el número del seguro social." & vbCrLf

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

        cambiarColorFondo(txtSemestre, Color.White, Color.Black)
        If txtSemestre.Text.Length = 0 Then
            MsjError = MsjError & "- Falta proporcionar el semestre." & vbCrLf
            cambiarColorFondo(txtSemestre, Color.Salmon, Color.White)
        End If

        cambiarColorFondo(txtGrupo, Color.White, Color.Black)
        'se comento para que dieran de alta los alumnos sin grupo
        'If txtGrupo.Text.Length = 0 Then
        '    MsjError = MsjError & "- Falta proporcionar el grupo." & vbCrLf
        '    cambiarColorFondo(txtGrupo, Color.Salmon, Color.White)
        'End If

        'If txtGeneracion.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar la generación." & vbCrLf
        'If cmbEstatus.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el estatus del alumno." & vbCrLf
        'If txtPlanEstatal.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el plan estatal." & vbCrLf
        'If txtBeca.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar la beca." & vbCrLf

        'If txtCalle.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar la calle." & vbCrLf
        'If txtNumExt.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el número exterior." & vbCrLf
        ''If txtNumInt.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el número interior." & vbCrLf
        'If txtColonia.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar la colonia." & vbCrLf
        'If cmbEstado.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el estado." & vbCrLf
        'If txtMunicipio.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el municipio." & vbCrLf
        'If txtCP.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el código postal." & vbCrLf
        'If txtTelefono.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el teléfono." & vbCrLf
        'If txtCelular.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el celular." & vbCrLf

        'cambiarColorFondo(cmbTurno, Color.White, Color.Black)
        'If txtEmail.Text.Length = 0 Or model.validarEmail(txtEmail.Text) = True Then
        '    MsjError = MsjError & "- Falta proporcionar el correo electrónico." & vbCrLf
        '    cambiarColorFondo(cmbTurno, Color.Salmon, Color.White)
        'End If

        'If txtContactoEmergencia.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el contacto de emergencia." & vbCrLf
        'If txtTelefonoEmergencia.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el teléfono de emergencia." & vbCrLf
        'If txtTipoSangre.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar el tipo de sangre del alumno(a)." & vbCrLf
        ''If txtObservaciones.Text.Length = 0 Then MsjError = MsjError & "- Falta proporcionar las observaciones." & vbCrLf

        ''If Model.validarCURP(txtCURP.Text) = False Then MsjError = MsjError & "- La CURP proporcionada no es correcta." & vbCrLf
        'If Model.validarEmail(txtEmail.Text) = False Then MsjError = MsjError & "- El correo electrónico proporcionado no es correcta." & vbCrLf

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
                txtSemestre.Text, txtGrupo.Text, txtBeca.Text, _
                cmbCampus.Text, txtPlanEstatal.Text, txtGeneracion.Text, _
                oFechaIngreso.Value.Date, oFechaEgreso.Value.Date, cmbTurno.Text, _
                cmbLicenciatura.Text, cmbEspecialidad.Text, cmbModalidad.Text,
                cmbEstatus.Text, FotoNueva, txtNoSS.Text, Txtpuntaje.Text, Txtprombachi.Text, comboBachProc.Text)
        '=====================| adeudo de material/libros |==========================================
        model.adeudoLibros(txtMatricula.Text, chkAdeudoMaterial.Checked)

        '=====================| pago inscripcion/reinscripcion |=====================================
        model.pagoInscripcion(txtMatricula.Text, _
                                 cmbCampus.Text, _
                                 cmbLicenciatura.Text, _
                                 cmbEspecialidad.Text, _
                                 cmbModalidad.Text, _
                                 cmbTurno.Text, _
                                 txtSemestre.Text, _
                                 txtGrupo.Text)

        '====================| actualizar el grupo en la tabla calificacion | ====================
        model.act_calificacion_grupo(txtGrupo.Text, txtMatricula.Text, txtSemestre.Text)
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
        Dim Er As Modelos.AlumnosModel.MensajesAlumnoRegular
        Dim MensajeError As String = ""

        btnPromover.Enabled = False

        'validar que el alumno es regular
        Er = model.esAlumnoRegular(txtMatricula.Text, txtSemestre.Text, txtGrupo.Text)

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
        txtSemestre.Text = (Integer.Parse(txtSemestre.Text) + 1)
        btnPromover.Enabled = True

    End Sub

    Private Sub cambiarColorFondo(ByRef _Control As Control, ByVal ColorFondo As Color, ByVal ColorLetra As Color)
        _Control.BackColor = ColorFondo
        _Control.ForeColor = ColorLetra
    End Sub

#End Region

    Private Sub frmAlumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        frmBuscar.txtIdBusqueda.Text = "13"
        frmBuscar.ShowDialog()
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
        guardarInformacion()
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

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        reiniciarFormulario()
    End Sub

    
End Class
