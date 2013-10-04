Imports datosCompartidos.funciones
Public Class campusFrm

    Public Sub New(ByVal nombreD As String, ByVal calleD As String, ByVal cctD As String, ByVal codigoD As String, ByVal coloniaD As String, ByVal municipioD As String, ByVal numeroD As String, ByVal telefonoD As String, ByVal idCampusD As String)
        InitializeComponent()
        txtnombre.Text = nombreD
        txtcalle.Text = calleD
        txtidCampus.Text = idCampusD
        txtcolonia.Text = coloniaD
        txtcct.Text = cctD
        txtcp.Text = codigoD
        txtmunicipio.Text = municipioD
        txtnumero.Text = numeroD
        txttelefono.Text = telefonoD
    End Sub

    Private Sub nuevoCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoCmd.Click
        limpiar_campos(GroupBox1)
    End Sub

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Dim _modeloCampus As New modelos.modeloCampus
        _modeloCampus.IDCAMPUS = Val(txtidCampus.Text)
        _modeloCampus.CALLE = txtcalle.Text
        _modeloCampus.CCT = txtcct.Text
        _modeloCampus.CODIGO_POSTAL = txtcp.Text
        _modeloCampus.COLONIA = txtcolonia.Text
        _modeloCampus.MUNICIPIO = txtmunicipio.Text
        _modeloCampus.NOMBRE = txtnombre.Text
        _modeloCampus.NUMERO = txtnumero.Text
        _modeloCampus.TELEFONO = txttelefono.Text

        If funcionesLocales.validarReceptor(GroupBox1) = True Then
            If _modeloCampus.IDCAMPUS > 0 Then
                funcionesLocales.actualizarCampus(_modeloCampus)
            Else
                funcionesLocales.guardarCampus(_modeloCampus)
                Dim _m As New modelos.modeloCampus
                _m = funcionesLocales.traerUltimoCampus()
                txtnombre.Text = _m.NOMBRE
                txtcalle.Text = _m.CALLE
                txtcct.Text = _m.CCT
                txtcp.Text = _m.CODIGO_POSTAL
                txtcolonia.Text = _m.COLONIA
                txtmunicipio.Text = _m.MUNICIPIO
                txtnumero.Text = _m.NUMERO
                txttelefono.Text = _m.TELEFONO
                txtidCampus.Text = _m.IDCAMPUS

            End If
        End If
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim f As New frmBuscarAlumno
        f.Text = "Busqueda X Campus"
        variables.banderaAccion = "campus"
        f.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub campusFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub eliminarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarCmd.Click
        Dim _modeloCampus As New modelos.modeloCampus
        _modeloCampus.IDCAMPUS = Val(txtidCampus.Text)
        _modeloCampus.CALLE = txtcalle.Text
        _modeloCampus.CCT = txtcct.Text
        _modeloCampus.CODIGO_POSTAL = txtcp.Text
        _modeloCampus.COLONIA = txtcolonia.Text
        _modeloCampus.MUNICIPIO = txtmunicipio.Text
        _modeloCampus.NOMBRE = txtnombre.Text
        _modeloCampus.NUMERO = txtnumero.Text
        _modeloCampus.TELEFONO = txttelefono.Text
        Dim seguro = MsgBox("¿Estas Seguro Que Deseas Eliminar El Registro?", vbYesNo)
        If seguro = vbYes Then
            funcionesLocales.eliminarCampus(_modeloCampus)
            limpiar_campos(GroupBox1)
        End If
    End Sub
End Class
