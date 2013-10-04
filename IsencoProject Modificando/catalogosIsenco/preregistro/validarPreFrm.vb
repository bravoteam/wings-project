Imports System.Data.SqlClient
Imports datosCompartidos.funciones

Public Class validarPreFrm
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
                lblHorario.Text = ""
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
                _modelo.promedio_alt = variables.SQLdr("promedio_alt")
                If _modelo.promedio_alt <= 0 Then
                    _modelo.promedio_alt = _modelo.promedio
                End If
                _modelo.segunda_opcion = variables.SQLdr("segunda_opcion").ToString.ToUpper
                _modelo.telefono = variables.SQLdr("telefono").ToString.ToUpper
                _modelo.aula = variables.SQLdr("aula").ToString.ToUpper
                _modelo.validado_por = variables.SQLdr("validado_por").ToString.ToUpper
                _modelo.tipo_folio = variables.SQLdr("tipo_folio").ToString.ToUpper
                If variables.SQLdr("turno").ToString = "Turno 1" Then
                    lblHorario.Text = "8:00 AM"
                End If
                If variables.SQLdr("turno").ToString = "Turno 2" Then
                    lblHorario.Text = "11:00 AM"
                End If
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
        For Each control As Windows.Forms.Control In Me.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            End If
            If TypeOf control Is ComboBox Then
                CType(control, ComboBox).Text = ""
            End If
        Next
        txtid.Text = m.id
        txtApellidoMaterno.Text = m.apellido_materno
        txtApellidoPaterno.Text = m.apellido_paterno
        txtBach.Text = m.bach_anterior
        txtCCTbach.Text = m.bach_anterior_cct
        txtCalle.Text = m.calle
        cmbCampus.Text = m.campus
        txtColonia.Text = m.colonia
        txtCurp.Text = m.curp
        txtEdad.Text = m.edad
        oFechaNacimiento.Value = m.fecha_nacimiento
        lblFolio.Text = m.folio_isenco
        lblPreregistro.Text = m.folio_preregistro
        txtFiltraFolio.Text = m.folio_preregistro
        cmbLicenciatura.Text = m.licenciatura
        txtLocalidad.Text = m.localidad
        txtEmail.Text = m.mail
        txtMunicipio.Text = m.municipio
        txtNombre.Text = m.nombre
        txtNumExt.Text = m.num_ext
        txtPromedio.Text = m.promedio
        txtPromedioAlt.Text = m.promedio_alt
        cmbSegunda.Text = m.segunda_opcion
        txtTelefono.Text = m.telefono
        txtAula.Text = m.aula
        If m.tipo_folio = 0 Or m.tipo_folio = 1 Then
            chkTipo.Checked = False
        Else
            chkTipo.Checked = True
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
    Private Sub consultarcmd_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmd.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "preregistro1"
        frmBuscarAlumno.Show()
    End Sub

    Private Sub txtFiltraFolio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltraFolio.KeyPress
        Dim valor As Integer = 0
        If e.KeyChar = Chr(13) Then
            valor = obtenerID(txtFiltraFolio.Text)
            If valor = 0 Then
                MsgBox("Folio No encontrado!!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                traerDatospre(valor)
            End If
        End If
    End Sub
    Private Function obtenerID(folio As String) As Integer
        Dim numero As Integer = 0
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select id from preregistro where folio_preregistro='" & folio & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While variables.SQLdr.Read
                numero = variables.SQLdr("id")
            End While
            variables.SQLdr.Close()
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
        Return numero
    End Function

    Private Sub RegresarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub reiniciarFormulario()
        Me.Controls.Clear()
        InitializeComponent()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        reiniciarFormulario()
        txtFiltraFolio.Focus()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles validarCmd.Click
        Try
            Dim bandera As String = ""
            Dim valor As String = ""
            Dim _modelo As New modelos.modeloRegistro
            Dim valor1, valor2 As Date
            valor1 = oFechaNacimiento.Value.Date
            valor2 = CDate("01-09-1993").Date

            If Val(txtEdad.Text) <= 20 Then
                If Val(txtEdad.Text) < 20 Then
                    bandera = " Fecha Correcta "
                    GoTo siguiente
                End If
                If valor1 <= valor2 Then
                    bandera = " Fecha Correcta "
                    GoTo siguiente
                Else
                    If chkTipo.Checked = False Then
                        MsgBox("La fecha de nacimiento no es adecuada!", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        bandera = " Validado pero fecha Invalida "
                    End If
                End If
            Else
                If chkTipo.Checked = False Then
                    MsgBox("La fecha de nacimiento no es adecuada!", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    bandera = " Validado pero fecha Invalida "
                End If
            End If

siguiente:
            If CDbl(txtPromedioAlt.Text) < 8.4 Then
                bandera = bandera & " Promedio No pasa "
                If chkTipo.Checked = False Then
                    MsgBox("Promedio Invalido!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If


            _modelo.id = Val(txtid.Text)
            _modelo.edad = txtEdad.Text.ToUpper
            _modelo.fecha_nacimiento = oFechaNacimiento.Value.Date
            _modelo.promedio_alt = Convert.ToDecimal(txtPromedioAlt.Text)
            _modelo.validado = 1
            _modelo.validado_por = variables.nombreUsuario
            _modelo.fecha_validado = Now.Date
            _modelo.observaciones = bandera

            If chkTipo.Checked = True Then
                _modelo.tipo_folio = 2  'Folio Isenco
            Else
                _modelo.tipo_folio = 1  'Folio SEP
            End If


            If _modelo.id > 0 Then
                actualizarRegistro(_modelo)
                reiniciarFormulario()
                txtFiltraFolio.Focus()
            Else
                MsgBox("Debes Seleccionar un Registro..", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error Encontrado: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub actualizarRegistro(ByVal modelo As modelos.modeloRegistro)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE preregistro SET edad=@edad,fecha_nacimiento=@fecha_nacimiento," & _
                                "promedio_alt=@promedio_alt,validado=@validado,validado_por=@validado_por,fecha_validado=@fecha_validado,observaciones=@observaciones," & _
                                "tipo_folio=@tipo_folio,hora_validado=@hora_validado WHERE id=@id"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@edad", modelo.edad)
                .Parameters.AddWithValue("@fecha_nacimiento", modelo.fecha_nacimiento)
                .Parameters.AddWithValue("@promedio_alt", modelo.promedio_alt)
                .Parameters.AddWithValue("@validado", modelo.validado)
                .Parameters.AddWithValue("@validado_por", modelo.validado_por)
                .Parameters.AddWithValue("@fecha_validado", modelo.fecha_validado)
                .Parameters.AddWithValue("@observaciones", modelo.observaciones)
                .Parameters.AddWithValue("@tipo_folio", modelo.tipo_folio)
                .Parameters.AddWithValue("@hora_validado", Now)
                .Parameters.AddWithValue("@id", modelo.id)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO VALIDADO!", MsgBoxStyle.Information)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Private Sub oFechaNacimiento_ValueChanged(sender As System.Object, e As System.EventArgs) Handles oFechaNacimiento.ValueChanged
        txtEdad.Text = Format(obtenerEdad(oFechaNacimiento.Value), "00")
    End Sub

    Private Sub validarPreFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If variables.tipoUsuario = 3 Then
            validarCmd.Enabled = False
        Else
            validarCmd.Enabled = True
        End If
    End Sub
End Class