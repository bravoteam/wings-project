Imports System.Data.SqlClient

Public Class procesoInscripcionFrm

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Me.Controls.Clear()
        InitializeComponent()
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "inscripcion"
        frmBuscarAlumno.Show()
    End Sub
    Public Sub traerDatospre(ByVal id As Integer)
        Try
            Dim _modelo As New modelos.modeloRegistro
            variables.conexion.abrirConexion()
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            ' Se hace la consulta principal
            variables.sql = "select * from preregistro where id = " & id & " "

            cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader
            While variables.SQLdr.Read()
                _modelo.id = variables.SQLdr("id")
                _modelo.apellido_materno = variables.SQLdr("apellido_materno").ToString.ToUpper
                _modelo.apellido_paterno = variables.SQLdr("apellido_paterno").ToString.ToUpper
                _modelo.bach_anterior = variables.SQLdr("bach_anterior").ToString.ToUpper
                _modelo.bach_anterior_cct = variables.SQLdr("bach_anterior_cct").ToString.ToUpper
                _modelo.calle = variables.SQLdr("calle").ToString.ToUpper
                _modelo.campus = variables.SQLdr("campus").ToString.ToUpper
                _modelo.colonia = variables.SQLdr("colonia").ToString.ToUpper
                _modelo.curp = variables.SQLdr("curp").ToString.ToUpper
                _modelo.edad = variables.SQLdr("edad").ToString.ToUpper
                If IsDBNull(variables.SQLdr("fecha_nacimiento")) Then
                    _modelo.fecha_nacimiento = Now.Date
                Else
                    _modelo.fecha_nacimiento = variables.SQLdr("fecha_nacimiento")
                End If

                _modelo.folio_isenco = variables.SQLdr("folio_isenco").ToString.ToUpper
                _modelo.folio_preregistro = variables.SQLdr("folio_preregistro").ToString.ToUpper
                _modelo.licenciatura = variables.SQLdr("licenciatura").ToString.ToUpper
                _modelo.localidad = variables.SQLdr("localidad").ToString.ToUpper
                _modelo.mail = variables.SQLdr("mail").ToString.ToUpper
                _modelo.municipio = variables.SQLdr("municipio").ToString.ToUpper
                _modelo.nombre = variables.SQLdr("nombre").ToString.ToUpper
                _modelo.num_ext = variables.SQLdr("num_ext").ToString.ToUpper
                _modelo.observaciones = variables.SQLdr("observaciones").ToString.ToUpper
                _modelo.promedio = variables.SQLdr("promedio")
                _modelo.segunda_opcion = variables.SQLdr("segunda_opcion").ToString.ToUpper
                _modelo.telefono = variables.SQLdr("telefono").ToString.ToUpper
                _modelo.promedio_alt = variables.SQLdr("promedio_alt")
                _modelo.aula = variables.SQLdr("aula").ToString.ToUpper
                _modelo.autorizado_por = variables.SQLdr("autorizado_por").ToString.ToUpper
                _modelo.turno = variables.SQLdr("turno").ToString
                _modelo.vino_ceneval = variables.SQLdr("vino_ceneval")
                _modelo.vino_psico = variables.SQLdr("vino_psico")
                _modelo.resultado_ceneval = variables.SQLdr("resultado_ceneval")
                _modelo.resultado_psico = variables.SQLdr("resultado_psico")
                _modelo.validado_por = variables.SQLdr("validado_por")
                _modelo.trajoDocumentos = variables.SQLdr("trajoDocumentos")
                _modelo.grupo = variables.SQLdr("grupo")
                _modelo.cenevalPuntos = variables.SQLdr("cenevalPuntos")
            End While
            asignarModeloText(_modelo)
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub asignarModeloText(m As modelos.modeloRegistro)
        txtid.Text = m.id
        txtApellidoMaterno.Text = m.apellido_materno
        txtApellidoPaterno.Text = m.apellido_paterno
        txtBach.Text = m.bach_anterior
        txtCalle.Text = m.calle
        cmbCampus.Text = m.campus
        txtColonia.Text = m.colonia
        txtCURP.Text = m.curp
        oFechaNacimiento.Value = m.fecha_nacimiento
        cmbLicenciatura.Text = m.licenciatura
        txtEmail.Text = m.mail
        txtMunicipio.Text = m.municipio
        txtNombre.Text = m.nombre
        txtNumExt.Text = m.num_ext
        Txtpromedio.Text = m.promedio
        txtTelefono.Text = m.telefono
        txtTurno.Text = m.turno
        txtGrupo.Text = m.grupo
        txtCelular.Text = m.telefono
        txtEstado.Text = "COLIMA"
        txtPuntaje.Text = m.cenevalPuntos
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If funcionesLocales.validarReceptorTabs(Tab1) = True Then
            'Inicia el Almacenamiento primero en tabla alumnos
            almacenarEnAlumno()
            almacenaIMSS()
            almacenadocumentos()
            variables.faltaDocs = ""
            If chkFaltoActa.Checked = True Then
                variables.faltaDocs = "ACTA DE NACIMIENTO"
            End If
            If chkFaltoCurp.Checked = True Then
                If variables.faltaDocs.Length > 0 Then
                    variables.faltaDocs = variables.faltaDocs & " , CURP"
                Else
                    variables.faltaDocs = "CURP"
                End If
            End If
            If chkFaltoCertificado.Checked = True Then
                If variables.faltaDocs.Length > 0 Then
                    variables.faltaDocs = variables.faltaDocs & " , CERTIFICADO DE TERMINACION DE ESTUDIOS"
                Else
                    variables.faltaDocs = "CERTIFICADO DE TERMINACION DE ESTUDIOS"
                End If
            End If
            If chkFaltoComprobante.Checked = True Then
                If variables.faltaDocs.Length > 0 Then
                    variables.faltaDocs = variables.faltaDocs & " , COMPROBANTE DE DOMICILIO"
                Else
                    variables.faltaDocs = "COMPROBANTE DE DOMICILIO"
                End If
            End If
            If chkFaltoMedico.Checked = True Then
                If variables.faltaDocs.Length > 0 Then
                    variables.faltaDocs = variables.faltaDocs & " , CERTIFICADO MEDICO"
                Else
                    variables.faltaDocs = "CERTIFICADO MEDICO"
                End If
            End If
            If chkFaltoFotos.Checked = True Then
                If variables.faltaDocs.Length > 0 Then
                    variables.faltaDocs = variables.faltaDocs & " , FOTOS"
                Else
                    variables.faltaDocs = "FOTOS"
                End If
            End If
            If chkFaltoPago.Checked = True Then
                If variables.faltaDocs.Length > 0 Then
                    variables.faltaDocs = variables.faltaDocs & " , PAGO DE DERECHOS"
                Else
                    variables.faltaDocs = "PAGO DE DERECHOS"
                End If
            End If
            MsgBox(variables.faltaDocs)
            variables.promedio = Convert.ToDecimal(Txtpromedio.Text)
            variables.idalumno = Val(txtid.Text)
            variables.licenciatura = cmbLicenciatura.Text
            impresionInscripcionFrm.Show()
            impresionInscripcionFrm.actualizarReportes()
            impresionInscripcionFrm.PDF()
            MsgBox("ALUMNO INSCRITO SATISFACTORIAMENTE", vbInformation)
            variables.promedio = 0
            variables.idalumno = 0
            variables.licenciatura = ""
            variables.faltaDocs = ""
        Else
            MsgBox("LLENE LA INFORMACION CORRESPONDIENTE", vbCritical)
            Exit Sub
        End If

    End Sub
    Private Sub almacenadocumentos()
        Dim _modelo As New modelos.modeloAlumnoDocumentosInscripcion
        _modelo.actaCopia = Val(txtCopiaActa.Text)
        _modelo.actaOriginal = Val(txtOrigActa.Text)
        _modelo.actaObservaciones = txtObsActa.Text
        _modelo.curpOriginal = Val(TextBox5.Text)
        _modelo.curpCopia = Val(TextBox4.Text)
        _modelo.curpObservaciones = TextBox3.Text
        _modelo.certificadoOriginal = Val(TextBox8.Text)
        _modelo.certificadoCopia = Val(TextBox7.Text)
        _modelo.certificadoObservaciones = TextBox6.Text
        _modelo.domicilioOriginal = Val(TextBox11.Text)
        _modelo.domicilioCopia = Val(TextBox10.Text)
        _modelo.domicilioObservaciones = TextBox9.Text
        _modelo.medicoOriginal = Val(TextBox14.Text)
        _modelo.medicoCopia = Val(TextBox13.Text)
        _modelo.medicoObservaciones = TextBox12.Text
        _modelo.fotosOriginal = Val(TextBox17.Text)
        _modelo.fotosObservaciones = TextBox15.Text
        _modelo.pagoOriginal = Val(TextBox20.Text)
        _modelo.pagoCopia = Val(TextBox19.Text)
        _modelo.pagoObservaciones = TextBox18.Text
        _modelo.idAlumno = Val(txtid.Text)
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
        _modelo.id = 0
        If _modelo.id = 0 Then
            funcionesLocales.almacenarAlumnoDocumentos(_modelo)
        End If
    End Sub
    Private Sub almacenaIMSS()
        Dim _modelo As New modelos.modeloIMSS
        _modelo.id = 0
        _modelo.idAlumno = Val(txtid.Text)
        If cmbLicenciatura.Text = "CENTRO DE ESTUDIOS DE BACHILLERATO" Then
            _modelo.nivelEducativo = "MEDIO SUPERIOR"
            If cmbCampus.Text = "TECOMAN" Then
                _modelo.registroIMSS = ""
                _modelo.clavePlantel = "06EBP0003M"
                _modelo.RESPONSABLE = "MA. GUADALUPE RAMOS LÓPEZ"
            End If
            If cmbCampus.Text = "MANZANILLO" Then
                _modelo.registroIMSS = ""
                _modelo.clavePlantel = "06EBP0002N"
                _modelo.RESPONSABLE = "JAMES ZAVALA CHAVEZ"
            End If
            If cmbCampus.Text = "COLIMA" Then
                _modelo.registroIMSS = "A-4599003324"
                _modelo.clavePlantel = "06EBP0001O"
                _modelo.RESPONSABLE = "IRMA GABRIELA CRUZ ITURRIBARRIA"
            End If
        Else
            _modelo.nivelEducativo = "SUPERIOR"
            If cmbCampus.Text = "TECOMAN" Then
                _modelo.registroIMSS = ""
                _modelo.clavePlantel = "06ENL0003V"
                _modelo.RESPONSABLE = "MA. GUADALUPE RAMOS LÓPEZ"
            End If
            If cmbCampus.Text = "MANZANILLO" Then
                _modelo.registroIMSS = ""
                _modelo.clavePlantel = "06ENL0002W"
                _modelo.RESPONSABLE = "JAMES ZAVALA CHAVEZ"
            End If
            If cmbCampus.Text = "CUAUHTEMOC" Then
                _modelo.registroIMSS = ""
                _modelo.clavePlantel = "06ENL0001X"
                _modelo.RESPONSABLE = "IRMA GABRIELA CRUZ ITURRIBARRIA"
            End If
        End If
        _modelo.ESTUDIAS_TRABAJAS = ComboBox1.Text
        _modelo.DEPENDES_ECONOMICA = ComboBox2.Text
        _modelo.TRABAJA_DEPENDES = ComboBox3.Text
        _modelo.ESTA_PROTEGIDO_SS = ComboBox4.Text
        _modelo.INSTITUCION_PRO_SS = ComboBox5.Text
        _modelo.fecha = oFechaIngreso.Value
        If _modelo.id = 0 Then
            funcionesLocales.almacenarFormatoIMSS(_modelo)
        End If
    End Sub
    Private Sub almacenarEnAlumno()
        Dim buscado As Integer = 0
        Dim _modelo As New modelos.modeloAlumno
        _modelo.IDALUMNO = 0
        _modelo.NOMBRE = txtNombre.Text
        _modelo.APELLIDO_PATERNO = txtApellidoPaterno.Text
        _modelo.APELLIDO_MATERNO = txtApellidoMaterno.Text
        _modelo.GENERO = cmbGenero.Text
        _modelo.CALLE = txtCalle.Text
        _modelo.NUMERO_INTERIOR = ""
        _modelo.NUMERO_EXTERIOR = txtNumExt.Text
        _modelo.COLONIA = txtColonia.Text
        _modelo.IDMUNICIPIO = txtMunicipio.Text
        _modelo.IDESTADO = txtEstado.Text
        _modelo.CODIGO_POSTAL = txtCp.Text
        _modelo.CURP = txtCURP.Text
        _modelo.TELEFONO_CASA = txtTelefono.Text
        _modelo.TELEFONO_CEL = txtCelular.Text
        _modelo.CORREO_ELECTRONICO = txtEmail.Text
        _modelo.FECHA_NACIMIENTO = oFechaNacimiento.Value
        _modelo.FECHA_INGRESO = oFechaIngreso.Value
        _modelo.FECHA_SALIDA = oFechaIngreso.Value
        _modelo.TIPO_SANGRE = txtTipoSangre.Text
        _modelo.CONTACTO_EMERGENCIA = txtContactoEmergencia.Text
        _modelo.TELEFONO_EMERGENCIA = txtTelefonoEmergencia.Text
        _modelo.MATRICULA = 0
        _modelo.IDCAMPUS = cmbCampus.Text
        _modelo.IDturno = txtTurno.Text
        _modelo.IDSTATUS = "PROMOVIDO"
        _modelo.IDAREA = " "
        _modelo.IDMODALIDAD = "E"
        _modelo.IDESPECIALIDAD = ""
        _modelo.IDSEMESTRE = "1"
        _modelo.IDGRUPO = txtGrupo.Text
        _modelo.IDLICENCIATURA = cmbLicenciatura.Text
        _modelo.PLANEST = "0000"
        If _modelo.IDLICENCIATURA = "CENTRO DE ESTUDIOS DE BACHILLERATO" Then
            _modelo.GENERACION = "2013-2016"
        Else
            _modelo.GENERACION = "2013-2017"
        End If
        _modelo.PUNTAJECENEVAL = txtPuntaje.Text
        _modelo.PROMEDIObACHILLERATO = Txtpromedio.Text
        _modelo.SECUNDARIAPROCEDENCIA = ""
        _modelo.BACHILLERATOPROCEDENCIA = ""

        If _modelo.IDLICENCIATURA = "CENTRO DE ESTUDIOS DE BACHILLERATO" Then
            _modelo.SECUNDARIAPROCEDENCIA = txtBach.Text
        Else
            _modelo.BACHILLERATOPROCEDENCIA = txtBach.Text
        End If
        _modelo.NOMBRE_MAMA = txtMama.Text
        _modelo.NOMBRE_PAPA = txtPapa.Text
        _modelo.LUGAR_NACIMIENTO = txtLugarNac.Text
        _modelo.CICLOESCOLAR = "2013-2014"
        _modelo.SMCuenta = smedicoCuentaTxt.Text
        _modelo.becaActual = becaEspecifiqueTxt.Text
        _modelo.usuario = variables.usuario
        buscado = buscarAlumno(_modelo.NOMBRE, _modelo.APELLIDO_PATERNO, _modelo.APELLIDO_MATERNO)
        If buscado = 0 Then
            funcionesLocales.inscribirAlumno(_modelo)
            Dim _m As New modelos.modeloAlumno
            _m = funcionesLocales.traerUltimoInscrito()
            txtid.Text = _m.IDALUMNO
        Else
            funcionesLocales.ActualizarinscripcionAlumno(_modelo)
            txtid.Text = variables.idalumno
        End If
        'If _modelo.IDALUMNO = 0 Then
        '    funcionesLocales.inscribirAlumno(_modelo)
        '    Dim _m As New modelos.modeloAlumno
        '    _m = funcionesLocales.traerUltimoInscrito()
        '    txtid.Text = _m.IDALUMNO
        'End If
    End Sub
    Private Function buscarAlumno(nombre As String, apellidoP As String, apellidoM As String) As Integer
        Dim encontrado As Integer = 0
        Try
            variables.conexion.abrirConexion()
            variables.idalumno = 0
            Dim sql As String = "select nombre,apellido_paterno,apellido_materno,idalumno from alumno where nombre='" & nombre & "' and " & _
                "apellido_paterno='" & apellidoP & "' and apellido_materno='" & apellidoM & "' "
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader
            While variables.SQLdr.Read()
                encontrado = 1
                variables.idalumno = variables.SQLdr("idalumno")
            End While
            variables.conexion.cerrarConexion()
        Catch exc As Exception
            Throw exc
            Exit Function
        End Try
        Return encontrado
    End Function
End Class