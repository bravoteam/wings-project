Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones

Public Class administrativosFrm
    Public Sub New(ByVal modelo As modelos.modeloAdministrativo)
        InitializeComponent()
        txtnombre.Text = modelo.NOMBRE
        cmbCampus.Text = modelo.CAMPUS
        cmbPuesto.Text = modelo.PUESTO
        txtidAdministrativo.Text = modelo.IDDIRECTIVO
    End Sub
    Private Sub cmbCampus_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCampus.DropDown
        cmbCampus.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from campus"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbCampus.Items.Add(variables.SQLdr("MUNICIPIO").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Dim _modeloAdministrativos As New modelos.modeloAdministrativo
        _modeloAdministrativos.NOMBRE = txtnombre.Text
        _modeloAdministrativos.PUESTO = cmbPuesto.Text
        _modeloAdministrativos.CAMPUS = cmbCampus.Text
        _modeloAdministrativos.IDDIRECTIVO = Val(txtidAdministrativo.Text)

        If funcionesLocales.validarReceptor(GroupBox1) = True Then
            If _modeloAdministrativos.IDDIRECTIVO > 0 Then
                funcionesLocales.actualizarAdministrativo(_modeloAdministrativos)
            Else
                funcionesLocales.guardarAdministrativo(_modeloAdministrativos)
                Dim _m As New modelos.modeloAdministrativo
                _m = funcionesLocales.traerUltimoAdministrativo()
                txtnombre.Text = _m.NOMBRE
                cmbCampus.Text = _m.CAMPUS
                cmbPuesto.Text = _m.PUESTO
                txtidAdministrativo.Text = _m.IDDIRECTIVO
            End If
        End If
    End Sub

    Private Sub eliminarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarCmd.Click
        Dim _modeloAd As New modelos.modeloAdministrativo
        _modeloAd.IDDIRECTIVO = Val(txtidAdministrativo.Text)
        _modeloAd.IDDIRECTIVO = txtnombre.Text
        _modeloAd.PUESTO = cmbPuesto.Text
        _modeloAd.CAMPUS = cmbCampus.Text
        
        Dim seguro = MsgBox("¿Estas Seguro Que Deseas Eliminar El Registro?", vbYesNo)
        If seguro = vbYes Then
            funcionesLocales.eliminarAdministrativo(_modeloAd)
            limpiar_campos(GroupBox1)
        End If
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim f As New frmBuscarAlumno
        f.Text = "Busqueda X Administrativo"
        variables.banderaAccion = "administrativos"
        f.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub administrativosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nuevoCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoCmd.Click
        limpiar_campos(GroupBox1)
    End Sub
End Class