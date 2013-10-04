Imports System.Data.SqlClient
Imports datosCompartidos.funciones

Public Class consultaPreregFrm
    Public Sub llenarAlumno(ByVal modelo As modelos.modeloRegistro)
        For Each control As Windows.Forms.Control In Me.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            End If
            If TypeOf control Is ComboBox Then
                CType(control, ComboBox).Text = ""
            End If
        Next
        lblFolio.Text = ""
        lblPreregistro.Text = ""
        txtid.Text = ""
        cmbLicenciatura.Text = ""
        cmbSegunda.Text = ""

        txtid.Text = modelo.id
        txtNombre.Text = modelo.nombre
        txtApellidoPaterno.Text = modelo.apellido_paterno
        txtApellidoMaterno.Text = modelo.apellido_materno
        txtCalle.Text = modelo.calle
        txtNumExt.Text = modelo.num_ext
        txtColonia.Text = modelo.colonia
        txtMunicipio.Text = modelo.municipio
        txtLocalidad.Text = modelo.localidad
        txtCURP.Text = modelo.curp
        txtTelefono.Text = modelo.telefono
        txtEmail.Text = modelo.mail
        oFechaNacimiento.Value = Date.Parse(modelo.fecha_nacimiento)
        txtObservaciones.Text = modelo.observaciones
        cmbCampus.Text = modelo.campus
        cmbLicenciatura.Text = modelo.licenciatura
        cmbSegunda.Text = modelo.segunda_opcion
        txtEdad.Text = modelo.edad
        txtCCTbach.Text = modelo.bach_anterior_cct
        txtBach.Text = modelo.bach_anterior
        Txtpromedio.Text = modelo.promedio
        lblPreregistro.Text = modelo.folio_preregistro
        lblFolio.Text = modelo.folio_isenco
        cmbRecomendado.Text = modelo.autorizado_por
        txtAula.Text = modelo.aula
        txtTurno.Text = modelo.turno
        txtPsico.Text = modelo.resultado_psico
        txtCeneval.Text = modelo.resultado_ceneval
        txtDocumentosPresen.Text = modelo.trajoDocumentos
        If modelo.vino_psico = 0 Then
            chkAsistioPsico.Checked = False
        Else
            chkAsistioPsico.Checked = True
        End If
        If modelo.vino_ceneval = 0 Then
            chkAsistioCene.Checked = False
        Else
            chkAsistioCene.Checked = True
        End If
    End Sub
    Public Sub llenarAlumnoInterno(ByVal modelo As modelos.modeloAlumno)
        For Each control As Windows.Forms.Control In Me.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            End If
            If TypeOf control Is ComboBox Then
                CType(control, ComboBox).Text = ""
            End If
        Next
        txtid.Text = ""
        cmbLicenciatura.Text = ""
        cmbSegunda.Text = ""
        lblFolio.Text = ""
        lblPreregistro.Text = ""
        txtNombre.Text = modelo.NOMBRE
        txtApellidoPaterno.Text = modelo.APELLIDO_PATERNO
        txtApellidoMaterno.Text = modelo.APELLIDO_MATERNO
        txtCalle.Text = modelo.CALLE
        txtNumExt.Text = modelo.NUMERO_EXTERIOR
        txtColonia.Text = modelo.COLONIA
        txtMunicipio.Text = modelo.IDMUNICIPIO
        txtLocalidad.Text = modelo.IDMUNICIPIO
        txtCURP.Text = modelo.CURP
        txtTelefono.Text = modelo.TELEFONO_CASA
        txtEmail.Text = modelo.CORREO_ELECTRONICO
        oFechaNacimiento.Value = Date.Parse(modelo.FECHA_NACIMIENTO)
        txtObservaciones.Text = modelo.OBSERVACIONES
        txtEdad.Text = Format(obtenerEdad(oFechaNacimiento.Value), "00")
        txtCCTbach.Text = "06EBP0001O"
        txtBach.Text = "CENTRO DE ESTUDIOS DE BACHILLERATO, COLIMA"
        Txtpromedio.Text = ""
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
        txtCCTbach.Text = m.bach_anterior_cct
        txtCalle.Text = m.calle
        cmbCampus.Text = m.campus
        txtColonia.Text = m.colonia
        txtCURP.Text = m.curp
        txtEdad.Text = m.edad
        oFechaNacimiento.Value = m.fecha_nacimiento
        lblFolio.Text = m.folio_isenco
        lblPreregistro.Text = m.folio_preregistro
        cmbLicenciatura.Text = m.licenciatura
        txtLocalidad.Text = m.localidad
        txtEmail.Text = m.mail
        txtMunicipio.Text = m.municipio
        txtNombre.Text = m.nombre
        txtNumExt.Text = m.num_ext
        txtObservaciones.Text = m.observaciones
        Txtpromedio.Text = m.promedio
        cmbSegunda.Text = m.segunda_opcion
        txtTelefono.Text = m.telefono
        txtPromedioAlt.Text = m.promedio_alt
        cmbRecomendado.Text = m.autorizado_por
        txtAula.Text = m.aula
        txtTurno.Text = m.turno
        txtPsico.Text = m.resultado_psico
        txtCeneval.Text = m.resultado_ceneval
        txtDocumentosPresen.Text = m.trajoDocumentos
        If m.vino_psico = 0 Then
            chkAsistioPsico.Checked = False
        Else
            chkAsistioPsico.Checked = True
        End If
        If m.vino_ceneval = 0 Then
            chkAsistioCene.Checked = False
        Else
            chkAsistioCene.Checked = True
        End If
        If m.validado_por = "X" Then
            lblValidado.Text = "NO VALIDADO"
            lblValidado.BackColor = Color.Orange
            lblValidado.ForeColor = Color.White
        Else
            lblValidado.Text = "REGISTRO VALIDADO"
            lblValidado.BackColor = Color.Blue
            lblValidado.ForeColor = Color.White
        End If
    End Sub
    Private Sub RegresarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "preregistro"
        frmBuscarAlumno.Show()
    End Sub
    Private Sub reiniciarFormulario()
        Me.Controls.Clear()
        InitializeComponent()
        cargarCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        reiniciarFormulario()
        lblFolio.Text = ""
        lblPreregistro.Text = ""
        txtid.Text = ""
        cmbLicenciatura.Text = ""
        cmbSegunda.Text = ""
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            Dim _modelo As New modelos.modeloRegistro
            _modelo.id = Val(txtid.Text)
            _modelo.apellido_materno = txtApellidoMaterno.Text.ToUpper
            _modelo.apellido_paterno = txtApellidoPaterno.Text.ToUpper
            _modelo.bach_anterior = txtBach.Text.ToUpper
            _modelo.bach_anterior_cct = txtCCTbach.Text.ToUpper
            _modelo.calle = txtCalle.Text.ToUpper
            _modelo.campus = cmbCampus.Text.ToUpper
            _modelo.colonia = txtColonia.Text.ToUpper
            _modelo.curp = txtCURP.Text.ToUpper
            _modelo.edad = txtEdad.Text.ToUpper
            _modelo.fecha_nacimiento = oFechaNacimiento.Value.Date
            _modelo.folio_isenco = lblFolio.Text.ToUpper
            _modelo.folio_preregistro = lblPreregistro.Text.ToUpper
            _modelo.licenciatura = cmbLicenciatura.Text.ToUpper
            _modelo.localidad = txtLocalidad.Text.ToUpper
            _modelo.mail = txtEmail.Text.ToUpper
            _modelo.municipio = txtMunicipio.Text.ToUpper
            _modelo.nombre = txtNombre.Text.ToUpper
            _modelo.num_ext = txtNumExt.Text
            _modelo.observaciones = txtObservaciones.Text.ToUpper
            _modelo.promedio = Convert.ToDecimal(Txtpromedio.Text)
            _modelo.segunda_opcion = cmbSegunda.Text.ToUpper
            _modelo.telefono = txtTelefono.Text.ToUpper
            _modelo.promedio_alt = Convert.ToDecimal(txtPromedioAlt.Text)
            _modelo.resultado_ceneval = Convert.ToDecimal(txtCeneval.Text)
            _modelo.resultado_psico = Convert.ToDecimal(txtPsico.Text)
            _modelo.autorizado_por = cmbRecomendado.Text
            _modelo.aula = txtAula.Text
            _modelo.turno = txtTurno.Text
            _modelo.trajoDocumentos = txtDocumentosPresen.Text
            If chkAsistioCene.Checked = True Then
                _modelo.vino_ceneval = 1  'si vino
            Else
                _modelo.vino_ceneval = 0  'no vino
            End If
            If chkAsistioPsico.Checked = True Then
                _modelo.vino_psico = 1  'si vino
            Else
                _modelo.vino_psico = 0  'no vino
            End If

            If _modelo.id > 0 Then
                actualizarRegistro(_modelo)
            Else
                guardarRegistro(_modelo)
                traerUltimo()
            End If
        Catch ex As Exception
            MsgBox("Error Encontrado: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub traerUltimo()
        Try
            Dim _modelo As New modelos.modeloRegistro
            variables.conexion.abrirConexion()
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.sql = "select max(id) from preregistro "

            cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader
            While variables.SQLdr.Read()
                _modelo.id = variables.SQLdr(0)
            End While
            traerDatospre(_modelo.id)
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub guardarRegistro(ByVal modelo As modelos.modeloRegistro)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO preregistro(curp,apellido_paterno,apellido_materno,nombre,edad," & _
                "colonia,calle,num_ext,localidad,municipio,telefono,mail,campus,licenciatura," & _
                "bach_anterior_cct, bach_anterior,promedio,folio_preregistro,segunda_opcion,folio_isenco,observaciones,fecha_nacimiento,promedio_alt," & _
                "vino_psico,vino_ceneval,autorizado_por,resultado_psico,resultado_ceneval,aula,turno)" & _
                         "VALUES(@curp,@apellido_paterno,@apellido_materno,@nombre,@edad," & _
                "@colonia,@calle,@num_ext,@localidad,@municipio,@telefono,@mail,@campus,@licenciatura," & _
                "@bach_anterior_cct, @bach_anterior,@promedio,@folio_preregistro,@segunda_opcion,@folio_isenco,@observaciones,@fecha_nacimiento,@promedio_alt," & _
                "@vino_psico,@vino_ceneval,@autorizado_por,@resultado_psico,@resultado_ceneval,@aula,@turno)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@curp", modelo.curp)
                .Parameters.AddWithValue("@apellido_paterno", modelo.apellido_paterno)
                .Parameters.AddWithValue("@apellido_materno", modelo.apellido_materno)
                .Parameters.AddWithValue("@nombre", modelo.nombre)
                .Parameters.AddWithValue("@edad", modelo.edad)
                .Parameters.AddWithValue("@colonia", modelo.colonia)
                .Parameters.AddWithValue("@calle", modelo.calle)
                .Parameters.AddWithValue("@num_ext", modelo.num_ext)
                .Parameters.AddWithValue("@localidad", modelo.localidad)
                .Parameters.AddWithValue("@municipio", modelo.municipio)
                .Parameters.AddWithValue("@telefono", modelo.telefono)
                .Parameters.AddWithValue("@mail", modelo.mail)
                .Parameters.AddWithValue("@campus", modelo.campus)
                .Parameters.AddWithValue("@licenciatura", modelo.licenciatura)
                .Parameters.AddWithValue("@bach_anterior_cct", modelo.bach_anterior_cct)
                .Parameters.AddWithValue("@bach_anterior", modelo.bach_anterior)
                .Parameters.AddWithValue("@promedio", modelo.promedio)
                .Parameters.AddWithValue("@folio_preregistro", modelo.folio_preregistro)
                .Parameters.AddWithValue("@segunda_opcion", modelo.segunda_opcion)
                .Parameters.AddWithValue("@folio_isenco", modelo.folio_isenco)
                .Parameters.AddWithValue("@observaciones", modelo.observaciones)
                .Parameters.AddWithValue("@fecha_nacimiento", modelo.fecha_nacimiento)
                .Parameters.AddWithValue("@promedio_alt", modelo.promedio_alt)
                .Parameters.AddWithValue("@vino_psico", modelo.vino_psico)
                .Parameters.AddWithValue("@vino_ceneval", modelo.vino_ceneval)
                .Parameters.AddWithValue("@autorizado_por", modelo.autorizado_por)
                .Parameters.AddWithValue("@resultado_psico", modelo.resultado_psico)
                .Parameters.AddWithValue("@resultado_ceneval", modelo.resultado_ceneval)
                .Parameters.AddWithValue("@aula", modelo.aula)
                .Parameters.AddWithValue("@turno", modelo.turno)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Private Sub actualizarRegistro(ByVal modelo As modelos.modeloRegistro)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE preregistro SET curp=@curp,apellido_paterno=@apellido_paterno," & _
                "apellido_materno=@apellido_materno,nombre=@nombre,edad=@edad," & _
               "colonia=@colonia,calle=@calle,num_ext=@num_ext," & _
               "localidad=@localidad,municipio=@municipio,telefono=@telefono,mail=@mail," & _
               "campus=@campus,licenciatura=@licenciatura," & _
               "bach_anterior_cct=@bach_anterior_cct, bach_anterior=@bach_anterior,promedio=@promedio," & _
               "folio_preregistro=@folio_preregistro,segunda_opcion=@segunda_opcion,folio_isenco=@folio_isenco," & _
               "observaciones=@observaciones,fecha_nacimiento=@fecha_nacimiento,promedio_alt=@promedio_alt," & _
               "vino_psico=@vino_psico,vino_ceneval=@vino_ceneval,autorizado_por=@autorizado_por," & _
               "resultado_psico=@resultado_psico,resultado_ceneval=@resultado_ceneval,aula=@aula,turno=@turno,trajoDocumentos=@trajoDocumentos WHERE id=@id"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@curp", modelo.curp)
                .Parameters.AddWithValue("@apellido_paterno", modelo.apellido_paterno)
                .Parameters.AddWithValue("@apellido_materno", modelo.apellido_materno)
                .Parameters.AddWithValue("@nombre", modelo.nombre)
                .Parameters.AddWithValue("@edad", modelo.edad)
                .Parameters.AddWithValue("@colonia", modelo.colonia)
                .Parameters.AddWithValue("@calle", modelo.calle)
                .Parameters.AddWithValue("@num_ext", modelo.num_ext)
                .Parameters.AddWithValue("@localidad", modelo.localidad)
                .Parameters.AddWithValue("@municipio", modelo.municipio)
                .Parameters.AddWithValue("@telefono", modelo.telefono)
                .Parameters.AddWithValue("@mail", modelo.mail)
                .Parameters.AddWithValue("@campus", modelo.campus)
                .Parameters.AddWithValue("@licenciatura", modelo.licenciatura)
                .Parameters.AddWithValue("@bach_anterior_cct", modelo.bach_anterior_cct)
                .Parameters.AddWithValue("@bach_anterior", modelo.bach_anterior)
                .Parameters.AddWithValue("@promedio", modelo.promedio)
                .Parameters.AddWithValue("@folio_preregistro", modelo.folio_preregistro)
                .Parameters.AddWithValue("@segunda_opcion", modelo.segunda_opcion)
                .Parameters.AddWithValue("@folio_isenco", modelo.folio_isenco)
                .Parameters.AddWithValue("@observaciones", modelo.observaciones)
                .Parameters.AddWithValue("@fecha_nacimiento", modelo.fecha_nacimiento)
                .Parameters.AddWithValue("@promedio_alt", modelo.promedio_alt)
                .Parameters.AddWithValue("@vino_psico", modelo.vino_psico)
                .Parameters.AddWithValue("@vino_ceneval", modelo.vino_ceneval)
                .Parameters.AddWithValue("@autorizado_por", modelo.autorizado_por)
                .Parameters.AddWithValue("@resultado_psico", modelo.resultado_psico)
                .Parameters.AddWithValue("@resultado_ceneval", modelo.resultado_ceneval)
                .Parameters.AddWithValue("@aula", modelo.aula)
                .Parameters.AddWithValue("@turno", modelo.turno)
                .Parameters.AddWithValue("@trajoDocumentos", modelo.trajoDocumentos)
                .Parameters.AddWithValue("@id", modelo.id)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Private Sub consultaPreregFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If variables.tipoUsuario = 1 Then 'Control Escolar
            deshabilitarControles(Tab1)
            deshabilitarControles(Tab3)
            deshabilitarControles(Tab4)
            Button1.Visible = False
            cmdGenerar.Visible = False
            txtPsico.Visible = False
            txtCeneval.Visible = False
            chkAsistioCene.Enabled = False
            chkAsistioPsico.Enabled = False
            cmbRecomendado.Visible = False
            Label24.Visible = False
            Txtpromedio.Visible = False
            Label37.Visible = False
            NuevoToolStripMenuItem.Visible = False
        End If
        cargarCombos()
    End Sub
    Private Sub deshabilitarControles(ByVal GbxDatos As TabPage)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If (TypeOf ctl Is System.Windows.Forms.TextBox) Or (TypeOf ctl Is System.Windows.Forms.ComboBox) Or (TypeOf ctl Is System.Windows.Forms.DateTimePicker) Then
                ctl.Enabled = False
            End If
        Next ctl
    End Sub
    Private Sub cargarCombos()
        cmbCampus.Items.Clear()
        cmbCampus.Items.Add("CUAUHTÉMOC")
        cmbCampus.Items.Add("TECOMÁN")
        cmbCampus.Items.Add("MANZANILLO")
        cmbCampus.Items.Add("COLIMA")
        cmbLicenciatura.Items.Clear()
        cmbLicenciatura.Items.Add("BACHILLERATO")
        cmbLicenciatura.Items.Add("LIC. EDUC.  PREESCOLAR")
        cmbLicenciatura.Items.Add("LIC. EDUC. ESPECIAL ÁREA DE ATENCIÓN MOTRIZ")
        cmbLicenciatura.Items.Add("LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN BIOLOGÍA.")
        cmbLicenciatura.Items.Add("LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN INGLÉS")
        cmbLicenciatura.Items.Add("LIC. EDUC. PRIMARIA")
        cmbSegunda.Items.Clear()
        cmbSegunda.Items.Add("BACHILLERATO")
        cmbSegunda.Items.Add("LIC. EDUC.  PREESCOLAR")
        cmbSegunda.Items.Add("LIC. EDUC. ESPECIAL ÁREA DE ATENCIÓN MOTRIZ")
        cmbSegunda.Items.Add("LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN BIOLOGÍA.")
        cmbSegunda.Items.Add("LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN INGLÉS")
        cmbSegunda.Items.Add("LIC. EDUC. PRIMARIA")
    End Sub

    Private Sub cmdGenerar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGenerar.Click
        Dim cadena As String = ""
        Try
            If cmbCampus.Text = "" Then
                MsgBox("Elija un Campus no se puede generar el folio", MsgBoxStyle.Critical)
                cmbCampus.Focus()
                Exit Sub
            End If
            If cmbLicenciatura.Text = "" Then
                MsgBox("Elija una Licenciatura no se puede generar el folio", MsgBoxStyle.Critical)
                cmbLicenciatura.Focus()
                Exit Sub
            End If
            Select Case cmbCampus.Text
                Case "CUAUHTÉMOC"
                    cadena = "1"
                Case "TECOMÁN"
                    cadena = "2"
                Case "MANZANILLO"
                    cadena = "3"
                Case "COLIMA"
                    cadena = "4"
            End Select
            Select Case cmbLicenciatura.Text
                Case "BACHILLERATO"
                    cadena = cadena & "0"
                Case "LIC. EDUC.  PREESCOLAR"
                    cadena = cadena & "1"
                Case "LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN BIOLOGÍA."
                    cadena = cadena & "2"
                Case "LIC. EDUC. ESPECIAL ÁREA DE ATENCIÓN MOTRIZ"
                    cadena = cadena & "3"
                Case "LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN INGLÉS"
                    cadena = cadena & "4"
                Case "LIC. EDUC. PRIMARIA"
                    cadena = cadena & "5"
            End Select
            cadena = cadena & Format(Val(txtid.Text), "0000")
            lblFolio.Text = cadena
            cadena = ""
        Catch ex As Exception
            MsgBox(ex, vbCritical)
            Exit Sub
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "interno"
        frmBuscarAlumno.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblNombre.Text = txtNombre.Text & " " & txtApellidoPaterno.Text & " " & txtApellidoMaterno.Text
    End Sub
End Class