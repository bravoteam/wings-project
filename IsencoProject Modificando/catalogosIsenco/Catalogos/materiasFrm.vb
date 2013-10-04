Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports System.Data.SqlClient

Public Class materiasFrm
    Public Sub New(ByVal nombreD As String, ByVal carreraD As String, _
                   ByVal idCarreraD As String, ByVal especialidadD As String, _
                   ByVal idEspecialidadD As String, ByVal semestreD As String, _
                   ByVal idSemestreD As String, ByVal planD As String, _
                   ByVal claveD As String, ByVal idMateriaD As String, _
                   ByVal activoD As Integer, ByVal AC As Integer)
        InitializeComponent()
        txtnombre.Text = nombreD
        cmbCarrera.Text = buscarCarrera(carreraD)
        comboc.Text = idCarreraD
        cmbEspecialidad.Text = buscarEspecialidad(especialidadD)
        comboe.Text = idEspecialidadD
        cmbSemestre.Text = buscarSemestre(semestreD)
        combos.Text = idSemestreD
        txtidMateria.Text = idMateriaD
        txtclaveIsenco.Text = claveD
        txtplan.Text = planD
        If activoD = -1 Then
            chkMateria.Checked = True
        Else
            chkMateria.Checked = False
        End If
        If AC = -1 Then
            chkCalifica.Checked = True
        Else
            chkCalifica.Checked = False
        End If
    End Sub

    Private Sub carreraCombo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCarrera.DropDown
        cmbCarrera.Items.Clear()
        comboc.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from licenciaturas"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbCarrera.Items.Add(variables.SQLdr("NOMBRE").ToString)
                comboc.Items.Add(variables.SQLdr("IDLICENCIATURA").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try

    End Sub

    Private Sub especialidadCombo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecialidad.DropDown
        cmbEspecialidad.Items.Clear()
        comboe.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from especialidades"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbEspecialidad.Items.Add(variables.SQLdr("DESCRIPCION").ToString)
                comboe.Items.Add(variables.SQLdr("IDESPECIALIDAD").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub semestreCombo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSemestre.DropDown
        cmbSemestre.Items.Clear()
        combos.Items.Clear()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from semestres"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                cmbSemestre.Items.Add(variables.SQLdr("NUMERO").ToString)
                combos.Items.Add(variables.SQLdr("IDSEMESTRE").ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub


    Private Sub semestreCombo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSemestre.TextChanged
        If cmbSemestre.SelectedIndex >= 0 Then
            combos.Text = combos.Items.Item(cmbSemestre.SelectedIndex)
        End If
    End Sub

    Private Sub especialidadCombo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecialidad.TextChanged
        If cmbEspecialidad.SelectedIndex >= 0 Then
            comboe.Text = comboe.Items.Item(cmbEspecialidad.SelectedIndex)
        End If
    End Sub

    Private Sub carreraCombo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCarrera.TextChanged
        If cmbCarrera.SelectedIndex >= 0 Then
            comboc.Text = comboc.Items.Item(cmbCarrera.SelectedIndex)
        End If
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub nuevoCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoCmd.Click
        limpiar_campos(GroupBox1)
        txtnombre.Focus()
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim f As New frmBuscarAlumno
        f.Text = "Busqueda X Materia"
        variables.banderaAccion = "materias"
        f.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Dim _modeloMaterias As New modelos.modeloMateria
        _modeloMaterias.IDMATERIA = Val(txtidMateria.Text)
        _modeloMaterias.IDCARRERA = Val(comboc.Text)
        _modeloMaterias.IDESPECIALIDAD = Val(comboe.Text)
        _modeloMaterias.IDSEMESTRE = Val(combos.Text)
        _modeloMaterias.NOMBRE = txtnombre.Text
        _modeloMaterias.PLANDEESTUDIOS = txtplan.Text
        _modeloMaterias.CLAVEISENCO = txtclaveIsenco.Text
        If chkMateria.Checked = True Then
            _modeloMaterias.ACTIVA = 1
        Else
            _modeloMaterias.ACTIVA = 0
        End If
        If chkCalifica.Checked = True Then
            _modeloMaterias.TIPOCHECK = 1
        Else
            _modeloMaterias.TIPOCHECK = 0
        End If


        If funcionesLocales.validarReceptor(GroupBox1) = True Then
            If _modeloMaterias.IDMATERIA > 0 Then
                funcionesLocales.actualizarMaterias(_modeloMaterias)
            Else
                funcionesLocales.guardarMaterias(_modeloMaterias)
                Dim _m As New modelos.modeloMateria
                _m = funcionesLocales.traerUltimaMateria()
                txtnombre.Text = _m.NOMBRE
                cmbCarrera.Text = buscarCarrera(_m.IDCARRERA)
                comboc.Text = _m.IDCARRERA
                cmbEspecialidad.Text = buscarEspecialidad(_m.IDESPECIALIDAD)
                comboe.Text = _m.IDESPECIALIDAD
                cmbSemestre.Text = buscarSemestre(_m.IDSEMESTRE)
                combos.Text = _m.IDSEMESTRE
                txtidMateria.Text = _m.IDMATERIA
                txtclaveIsenco.Text = _m.CLAVEISENCO
                txtplan.Text = _m.PLANDEESTUDIOS
                If _m.ACTIVA = 1 Then
                    chkMateria.Checked = True
                Else
                    chkMateria.Checked = False
                End If
                If _m.TIPOCHECK = 1 Then
                    chkCalifica.Checked = True
                Else
                    chkCalifica.Checked = False
                End If

            End If
        End If
    End Sub

    Private Sub materiasFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Private Function buscarCarrera(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from licenciaturas WHERE idlicenciatura=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("NOMBRE").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Private Function buscarEspecialidad(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from especialidades WHERE IDESPECIALIDAD=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("DESCRIPCION").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Private Function buscarSemestre(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from semestres WHERE IDSEMESTRE=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("NUMERO").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Private Function buscarMaestro(ByVal valor As String) As String
        Dim retorno As String = ""
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from maestro WHERE IDMAESTRO=" & Val(valor) & " "
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                retorno = variables.SQLdr("NOMBRE").ToString & " " & variables.SQLdr("APELLIDO_PATERNO").ToString & " " & variables.SQLdr("APELLIDO_MATERNO").ToString
            End While
            variables.conexion.cerrarConexion()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function

    Private Sub eliminarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarCmd.Click
        Dim _modeloCampus As New modelos.modeloMateria
        _modeloCampus.IDMATERIA = Val(txtidMateria.Text)
        _modeloCampus.IDCARRERA = Val(comboc.Text)
        _modeloCampus.IDESPECIALIDAD = Val(comboe.Text)
        _modeloCampus.IDSEMESTRE = Val(combos.Text)
        _modeloCampus.NOMBRE = txtnombre.Text
        _modeloCampus.PLANDEESTUDIOS = txtplan.Text
        _modeloCampus.CLAVEISENCO = txtclaveIsenco.Text
        Dim seguro = MsgBox("¿Estas Seguro Que Deseas Eliminar El Registro?", vbYesNo)
        If seguro = vbYes Then
            funcionesLocales.eliminarMaterias(_modeloCampus)
            limpiar_campos(GroupBox1)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If cmbCarrera.Text = "" Then
            comboc.Text = ""
        End If
        If cmbEspecialidad.Text = "" Then
            comboe.Text = ""
        End If
        If cmbSemestre.Text = "" Then
            combos.Text = ""
        End If
    End Sub

    Private Sub cmbMaestro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class