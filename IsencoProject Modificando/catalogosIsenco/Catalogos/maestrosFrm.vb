Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports System.Data.SqlClient
Imports datosCompartidos

Public Class maestrosFrm
    Public Sub New(ByVal modelo As modelos.modeloMaestro)
        InitializeComponent()
        txtNombre.Text = modelo.NOMBRE
        txtidMaestro.Text = modelo.ID
        txtApellidoPaterno.Text = modelo.APELLIDO_PATERNO
        txtApellidoMaterno.Text = modelo.APELLIDO_MATERNO
        txtCalle.Text = modelo.CALLE
        txtNumExt.Text = modelo.NUMERO
        txtColonia.Text = modelo.COLONIA
        txtMunicipio.Text = modelo.MUNICIPIO
        cmbEstado.Text = modelo.ESTADO
        txtCP.Text = modelo.CP
        txtCURP.Text = modelo.CURP
        txtTelefono.Text = modelo.TELEFONO_CASA
        txtCelular.Text = modelo.TELEFONO_CEL
        txtEmail.Text = modelo.email
        oFechaNacimiento.Value = Date.Parse(modelo.FECHA_NACIMIENTO)
        oFechaIngreso.Value = Date.Parse(modelo.FECHA_INGRESO)
        oFechaEgreso.Value = Date.Parse(modelo.FECHA_SALIDA)
        txtTipoSangre.Text = modelo.TIPO_SANGRE
        txtObservaciones.Text = modelo.OBSERVACIONES
        txtContactoEmergencia.Text = modelo.CONTACTO_EMERGENCIA
        txtTelefonoEmergencia.Text = modelo.TELEFONO_EMERGENCIA
        chkActivo.Checked = modelo.ACTIVO
    End Sub
    Private Sub maestrosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nuevoCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoCmd.Click
        Me.Controls.Clear()
        InitializeComponent()
        txtNombre.Focus()
    End Sub

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Dim _modeloMaestro As New modelos.modeloMaestro
        If chkActivo.Checked = True Then
            _modeloMaestro.ACTIVO = 1
        Else
            _modeloMaestro.ACTIVO = 0
        End If
        _modeloMaestro.APELLIDO_MATERNO = txtApellidoMaterno.Text
        _modeloMaestro.APELLIDO_PATERNO = txtApellidoPaterno.Text
        _modeloMaestro.CALLE = txtCalle.Text
        _modeloMaestro.CP = txtCP.Text
        _modeloMaestro.COLONIA = txtColonia.Text
        _modeloMaestro.CONTACTO_EMERGENCIA = txtContactoEmergencia.Text
        _modeloMaestro.email = txtEmail.Text
        _modeloMaestro.CURP = txtCURP.Text
        _modeloMaestro.ESTADO = cmbEstado.Text
        _modeloMaestro.FECHA_INGRESO = oFechaIngreso.Value
        _modeloMaestro.FECHA_NACIMIENTO = oFechaNacimiento.Value
        _modeloMaestro.FECHA_SALIDA = oFechaEgreso.Value
        _modeloMaestro.ID = Val(txtidMaestro.Text)
        _modeloMaestro.MUNICIPIO = txtMunicipio.Text
        _modeloMaestro.NOMBRE = txtNombre.Text
        _modeloMaestro.NUMERO = txtNumExt.Text
        _modeloMaestro.OBSERVACIONES = txtObservaciones.Text
        _modeloMaestro.TELEFONO_CASA = txtTelefono.Text
        _modeloMaestro.TELEFONO_CEL = txtCelular.Text
        _modeloMaestro.TELEFONO_EMERGENCIA = txtTelefonoEmergencia.Text
        _modeloMaestro.TIPO_SANGRE = txtTipoSangre.Text

        If funcionesLocales.validarReceptorTabs(Tab1) = True Then
            If _modeloMaestro.ID > 0 Then
                funcionesLocales.actualizarMaestros(_modeloMaestro)
            Else
                funcionesLocales.guardarMaestros(_modeloMaestro)
                Dim _m As New modelos.modeloMaestro
                _m = funcionesLocales.traerUltimoMaestro()
                txtNombre.Text = _m.NOMBRE
                txtidMaestro.Text = _m.ID
                txtApellidoPaterno.Text = _m.APELLIDO_PATERNO
                txtApellidoMaterno.Text = _m.APELLIDO_MATERNO
                txtCalle.Text = _m.CALLE
                txtNumExt.Text = _m.NUMERO
                txtColonia.Text = _m.COLONIA
                txtMunicipio.Text = _m.MUNICIPIO
                cmbEstado.Text = _m.ESTADO
                txtCP.Text = _m.CP
                txtCURP.Text = _m.CURP
                txtTelefono.Text = _m.TELEFONO_CASA
                txtCelular.Text = _m.TELEFONO_CEL
                txtEmail.Text = _m.EMAIL
                oFechaNacimiento.Value = Date.Parse(_m.FECHA_NACIMIENTO)
                oFechaIngreso.Value = Date.Parse(_m.FECHA_INGRESO)
                oFechaEgreso.Value = Date.Parse(_m.FECHA_SALIDA)
                txtTipoSangre.Text = _m.TIPO_SANGRE
                txtObservaciones.Text = _m.OBSERVACIONES
                txtContactoEmergencia.Text = _m.CONTACTO_EMERGENCIA
                txtTelefonoEmergencia.Text = _m.TELEFONO_EMERGENCIA
                chkActivo.Checked = _m.ACTIVO
            End If
        End If
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim f As New frmBuscarAlumno
        f.Text = "Busqueda X Maestro"
        variables.banderaAccion = "maestros"
        f.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub eliminarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarCmd.Click
        Dim _modeloMaestro As New modelos.modeloMaestro
        If chkActivo.Checked = True Then
            _modeloMaestro.ACTIVO = 1
        Else
            _modeloMaestro.ACTIVO = 0
        End If
        _modeloMaestro.APELLIDO_MATERNO = txtApellidoMaterno.Text
        _modeloMaestro.APELLIDO_PATERNO = txtApellidoPaterno.Text
        _modeloMaestro.CALLE = txtCalle.Text
        _modeloMaestro.CP = txtCP.Text
        _modeloMaestro.COLONIA = txtColonia.Text
        _modeloMaestro.CONTACTO_EMERGENCIA = txtContactoEmergencia.Text
        _modeloMaestro.email = txtEmail.Text
        _modeloMaestro.CURP = txtCURP.Text
        _modeloMaestro.ESTADO = cmbEstado.Text
        _modeloMaestro.FECHA_INGRESO = oFechaIngreso.Value
        _modeloMaestro.FECHA_NACIMIENTO = oFechaNacimiento.Value
        _modeloMaestro.FECHA_SALIDA = oFechaEgreso.Value
        _modeloMaestro.ID = Val(txtidMaestro.Text)
        _modeloMaestro.MUNICIPIO = txtMunicipio.Text
        _modeloMaestro.NOMBRE = txtNombre.Text
        _modeloMaestro.NUMERO = txtNumExt.Text
        _modeloMaestro.OBSERVACIONES = txtObservaciones.Text
        _modeloMaestro.TELEFONO_CASA = txtTelefono.Text
        _modeloMaestro.TELEFONO_CEL = txtCelular.Text
        _modeloMaestro.TELEFONO_EMERGENCIA = txtTelefonoEmergencia.Text
        _modeloMaestro.TIPO_SANGRE = txtTipoSangre.Text
        Dim seguro = MsgBox("¿Estas Seguro Que Deseas Eliminar El Registro?", vbYesNo)
        If seguro = vbYes Then
            funcionesLocales.eliminarMaestros(_modeloMaestro)
            Me.Controls.Clear()
            InitializeComponent()
            txtNombre.Focus()
        End If
    End Sub

    Private Sub cmbEstado_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.DropDown
        Dim model As New datosCompartidos.Modelos.AlumnosModel
        Dim Estados As List(Of String) = model.getEstados()
        cmbEstado.Items.Clear()
        For Each Estado As String In Estados
            cmbEstado.Items.Add(Estado)
        Next
    End Sub
End Class