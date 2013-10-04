Imports datosCompartidos.funciones
Public Class cicloEscolarFrm
    Public Sub New(ByVal modelo As modelos.modeloCicloEscolar)
        InitializeComponent()
        txtidCiclo.Text = modelo.IDCICLOESCOLAR
        fechaDtp1.Value = Date.Parse(modelo.INICIO)
        fechaDtp2.Value = Date.Parse(modelo.FIN)
        txtDescripcion.Text = modelo.DESCRIPCION
        If modelo.ACTUAL = 1 Then
            actualCheck.Checked = True
        Else
            actualCheck.Checked = False
        End If
    End Sub
    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        frmBuscarAlumno.Text = "Busqueda X Ciclo Escolar"
        variables.banderaAccion = "ciclos"
        frmBuscarAlumno.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Dim _modeloCiclos As New modelos.modeloCicloEscolar
        _modeloCiclos.INICIO = fechaDtp1.Value.Date
        _modeloCiclos.FIN = fechaDtp2.Value.Date
        _modeloCiclos.DESCRIPCION = txtDescripcion.Text
        If actualCheck.Checked = True Then
            _modeloCiclos.ACTUAL = 1
        Else
            _modeloCiclos.ACTUAL = 0
        End If
        _modeloCiclos.IDCICLOESCOLAR = Val(txtidCiclo.Text)
        If _modeloCiclos.IDCICLOESCOLAR > 0 Then
            funcionesLocales.actualizarCiclo(_modeloCiclos)
        Else
            funcionesLocales.guardarCiclo(_modeloCiclos)
            Dim _m As New modelos.modeloCicloEscolar
            _m = funcionesLocales.traerUltimoCiclo()
            txtidCiclo.Text = _m.IDCICLOESCOLAR
            fechaDtp1.Value = _m.INICIO
            fechaDtp2.Value = _m.FIN
            txtDescripcion.Text = _m.DESCRIPCION

            If _m.ACTUAL = 1 Then
                actualCheck.Checked = True
            Else
                actualCheck.Checked = False
            End If
        End If
    End Sub

    Private Sub eliminarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarCmd.Click
        Dim _modeloAd As New modelos.modeloCicloEscolar
        _modeloAd.IDCICLOESCOLAR = Val(txtidCiclo.Text)

        Dim seguro = MsgBox("¿Estas Seguro Que Deseas Eliminar El Registro?", vbYesNo)
        If seguro = vbYes Then
            funcionesLocales.eliminarCiclo(_modeloAd)
            limpiar_campos(GroupBox1)
        End If
    End Sub

    Private Sub nuevoCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoCmd.Click
        limpiar_campos(GroupBox1)
    End Sub

    Private Sub cicloEscolarFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class