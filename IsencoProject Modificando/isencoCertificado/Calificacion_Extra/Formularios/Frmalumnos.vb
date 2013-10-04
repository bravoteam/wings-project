Imports System.Data.SqlClient

Public Class Frmalumnos
#Region "********DECLARACION VARIABLES**********"
    Private conf As New Configuracion
    Private model As New Modelos.AlumnosModel
    Private idmatricula As String
    Private idmateria As Integer
    Private text2, strextra1, strextra2, strextra3 As String
    Private sqlstr2 As String
    Private cant_extras As Integer
    Private fecha1 As DateTime
    Private fecha2 As DateTime
    Private fecha3 As DateTime
    Private dato1 As Boolean
    Private dato2 As Boolean
    Private dato3 As Boolean
    Private cont_materias_reprobadas As Integer = 0
    Private valorAsignaturas As New NumToLetter
    Private valorCreditos As New NumToLetter
    Private valorFecha As New NumToLetter
#End Region
    Private Sub limpiar_campos()
        Dim ctl As Control

        For Each ctl In Me.GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.Text = ""
            End If
        Next ctl
        lblStatus.Text = "NO ENCONTRADO"
        cmbTipoCer.Text = ""
        cmbTrabajo.Text = ""
        cmdModalidad.Text = ""
        comboGenero.Text = ""
        fechaDtp.Value = "10/07/2012"
        fechaExpDtp.Value = "06/07/2012"
        cambiarFecha()
        DeshabilitarControles()
    End Sub
    Private Sub cambiarFecha()
        diasTxt.Text = fechaExpDtp.Value.Date.Day
        mesTxt.Text = Format(fechaExpDtp.Value.Date, "MMMM").ToUpper
        añoTxt.Text = fechaExpDtp.Value.Date.Year
        valorFecha.Number = CDbl(diasTxt.Text)
        diasTxt.Text = valorFecha.ToLetter.ToUpper
        valorFecha.Number = CDbl(Mid(añoTxt.Text, 3, 2))
        añoTxt.Text = valorFecha.ToLetter.ToUpper
    End Sub
    Private Sub cargar_combo()
        cmbTrabajo.Enabled = True
        checar_conexion()
        Try
            Abrir_conexion()
            cmbTrabajo.Items.Clear()
            SQLSTR = "SELECT CCT from campus"
            SQLCmd.CommandText = SQLSTR
            SQLdr = SQLCmd.ExecuteReader
            While (SQLdr.Read()) ' SE CARGAN LOS DATOS EN EL COMBO
                cmbTrabajo.Items.Add(SQLdr(0).ToString)
            End While
            SQLdr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQLConn.Close()
        End Try
    End Sub

    Private Sub buscar_matricula(ByVal dato As String)
        Dim encontrado As Boolean = False
        checar_conexion()
        Try
            Abrir_conexion()
            SQLSTR = "SELECT * FROM certificados" & _
                     " WHERE matricula = '" & dato & "'"
            SQLCmd.CommandText = SQLSTR
            SQLdr = SQLCmd.ExecuteReader
            If SQLdr.HasRows Then
                While SQLdr.Read()
                    nombreTxt.Text = SQLdr("nombre").ToString
                    curpTxt.Text = SQLdr("curp").ToString
                    cmbTrabajo.Text = SQLdr("centro_trabajo").ToString
                    tituloCerTxt.Text = SQLdr("titulo_certificado").ToString
                    planTxt.Text = SQLdr("plan_estudios").ToString
                    expedidoTxt.Text = SQLdr("expedido_en").ToString
                    diasTxt.Text = SQLdr("dia_expedido").ToString
                    mesTxt.Text = SQLdr("mes_expedido").ToString
                    añoTxt.Text = SQLdr("anio_expedido").ToString
                    directorTxt.Text = SQLdr("director").ToString
                    asignaturasTxt.Text = SQLdr("total_asignaturas").ToString
                    creditosTxt.Text = SQLdr("total_creditos").ToString
                    promedioTxt.Text = SQLdr("promedio").ToString
                    revisadoTxt.Text = SQLdr("revisado_confrontado").ToString
                    validadoTxt.Text = SQLdr("nombre_validacion").ToString
                    fechaDtp.Value = SQLdr("fecha_revisado_confrontado")
                    cmbTipoCer.Text = SQLdr("tipo_certificado")
                    cmdModalidad.Text = SQLdr("modalidad")
                    lblStatus.Text = "ENCONTRADO"
                    SQLdr.Close()
                    promedioTxt.Text = Format(obtenerPromedio(txtmatricula.Text), "##.#")
                    Exit Sub
                End While
            End If
            SQLConn.Close()
            Abrir_conexion()

            SQLSTR = "SELECT * FROM alumno" & _
                     " WHERE matricula = '" & dato & "'"
            SQLCmd.CommandText = SQLSTR
            SQLdr = SQLCmd.ExecuteReader
            encontrado = False
            While (SQLdr.Read()) 'While Data is Present
                encontrado = True
                nombreTxt.Text = SQLdr("NOMBRE").ToString.ToUpper & " " & SQLdr("APELLIDO_PATERNO").ToString.ToUpper & " " & SQLdr("APELLIDO_MATERNO").ToString.ToUpper
                curpTxt.Text = SQLdr("CURP").ToString.ToUpper
                If SQLdr("GENERO").ToString.ToUpper = "M" Then
                    comboGenero.Text = "LICENCIADA"
                Else
                    comboGenero.Text = "LICENCIADO"
                End If
                campus = SQLdr("IDCAMPUS").ToString.ToUpper
                If campus = "COLIMA" Then
                    cmbTrabajo.Text = "06MSU0003G"
                End If
                If campus = "CUAUHTEMOC" Then
                    cmbTrabajo.Text = "06ENL0001X"
                End If
                If campus = "MANZANILLO" Then
                    cmbTrabajo.Text = "06ENL0002W"
                End If
                If campus = "TECOMAN" Then
                    cmbTrabajo.Text = "06ENL0003V"
                End If

                cmbTipoCer.Text = "COMPLETOS"
                cmdModalidad.Text = "ESCOLARIZADA"
                especialidadTxt.Text = SQLdr("IDESPECIALIDAD").ToString.ToUpper
                licenciaturaTxt.Text = SQLdr("IDLICENCIATURA").ToString.ToUpper
                'SE HACE LA VALIDACION PARA GENERAR EL TITULO DE CERTIFICADO
                '--------------------------------------------------------------
                If especialidadTxt.Text = "" Then
                    tituloCerTxt.Text = comboGenero.Text + " EN " + licenciaturaTxt.Text
                Else
                    tituloCerTxt.Text = comboGenero.Text + " EN " + licenciaturaTxt.Text + " CON ESPECIALIDAD EN " + especialidadTxt.Text
                End If
                'MANDA A LLAMAR LA FUNCION PARA COINCIDENCIAS Y ASI COLOCAR EL PLAN DE ESTUDIOS
                '--------------------------------------------------------------
                If NEncontrados(SQLdr("IDLICENCIATURA").ToString.ToUpper, "PRIMARIA") Then
                    planTxt.Text = 1997
                    creditosTxt.Text = 448
                    asignaturasTxt.Text = 45
                End If
                If NEncontrados(SQLdr("IDLICENCIATURA").ToString.ToUpper, "PREESCOLAR") Then
                    planTxt.Text = 1999
                    creditosTxt.Text = 448
                    asignaturasTxt.Text = 42
                End If
                If NEncontrados(SQLdr("IDLICENCIATURA").ToString.ToUpper, "SECUNDARIA") Then
                    planTxt.Text = 1999
                    creditosTxt.Text = 392
                    asignaturasTxt.Text = 45
                End If
                'SE LLENA EL DATO DE EXPEDICION
                '--------------------------------------------------------------
                expedidoTxt.Text = "COLIMA,COLIMA"
                lblStatus.Text = "NO ENCONTRADO"
            End While
            SQLdr.Close()
            directorTxt.Text = obtenerDirector()
            revisadoTxt.Text = obtenerConfrontado()
            validadoTxt.Text = obtenerValidado()
            promedioTxt.Text = Format(obtenerPromedio(txtmatricula.Text), "##.#")
            '===============================================
            If Not encontrado Then
                MsgBox("EL REGISTRO NO FUE ENCONTRADO EN LA BASE DE DATOS", MsgBoxStyle.Critical, "ERROR")
                txtdatos2.Text = ""
            Else
                txtdatos2.Text = text2
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQLConn.Close()
        End Try
    End Sub
    Private Sub cargarAlumno(ByVal P As String)
        Dim A As Modelos.Alumno

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
        txtmatricula.Text = A.Matricula

        txtdatos2.Text = A.Matricula


    End Sub
    Private Sub guardar_registro() ' Inserta el registro de certificado
        Try

            conexion.abrirConexion()

            Dim sql As String = "insert into certificados(matricula,nombre,curp,tipo_certificado,titulo_certificado," & _
                "modalidad,plan_estudios,expedido_en,dia_expedido,mes_expedido,anio_expedido,director,total_asignaturas, " & _
                "total_creditos,promedio,revisado_confrontado,fecha_revisado_confrontado,nombre_validacion,centro_trabajo) " & _
                         "values (@matricula,@nombre,@curp,@tipo_certificado,@titulo_certificado," & _
                "@modalidad,@plan_estudios,@expedido_en,@dia_expedido,@mes_expedido,@anio_expedido,@director,@total_asignaturas, " & _
                "@total_creditos,@promedio,@revisado_confrontado,@fecha_revisado_confrontado,@nombre_validacion,@centro_trabajo)"

            Dim cmd As New SqlCommand(sql, conexion.Conexion)
            If IsNumeric(asignaturasTxt.Text) Then
                valorAsignaturas.Number = CDbl(asignaturasTxt.Text)
                asignaturasTxt.Text = valorAsignaturas.ToLetter.ToString.ToUpper
            End If
            'valorCreditos.Number = CDbl(creditosTxt.Text)
            With cmd
                .Parameters.AddWithValue("@matricula", txtmatricula.Text)
                .Parameters.AddWithValue("@nombre", nombreTxt.Text)
                .Parameters.AddWithValue("@curp", curpTxt.Text)
                .Parameters.AddWithValue("@tipo_certificado", cmbTipoCer.Text)
                .Parameters.AddWithValue("@titulo_certificado", tituloCerTxt.Text)
                .Parameters.AddWithValue("@modalidad", cmdModalidad.Text)
                .Parameters.AddWithValue("@plan_estudios", planTxt.Text)
                .Parameters.AddWithValue("@expedido_en", expedidoTxt.Text)
                .Parameters.AddWithValue("@dia_expedido", diasTxt.Text)
                .Parameters.AddWithValue("@mes_expedido", mesTxt.Text)
                .Parameters.AddWithValue("@anio_expedido", añoTxt.Text)
                .Parameters.AddWithValue("@director", directorTxt.Text)
                .Parameters.AddWithValue("@total_asignaturas", asignaturasTxt.Text)
                .Parameters.AddWithValue("@total_creditos", creditosTxt.Text)
                .Parameters.AddWithValue("@promedio", Convert.ToDecimal(promedioTxt.Text))
                .Parameters.AddWithValue("@revisado_confrontado", revisadoTxt.Text)
                .Parameters.AddWithValue("@fecha_revisado_confrontado", fechaDtp.Value.Date)
                .Parameters.AddWithValue("@nombre_validacion", validadoTxt.Text)
                .Parameters.AddWithValue("@centro_trabajo", cmbTrabajo.Text)
            End With

            cmd.ExecuteNonQuery()


            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Private Sub actualizar_registro() ' Actualiza el registro de certificados
        Try

            conexion.abrirConexion()
            Dim sql As String = "UPDATE certificados SET nombre=@nombre,curp=@curp,tipo_certificado=@tipo_certificado, " & _
                "titulo_certificado=@titulo_certificado,modalidad=@modalidad,plan_estudios=@plan_estudios,expedido_en=@expedido_en, " & _
                "dia_expedido=@dia_expedido,mes_expedido=@mes_expedido,anio_expedido=@anio_expedido,director=@director, " & _
                "total_asignaturas=@total_asignaturas,total_creditos=@total_creditos,promedio=@promedio,revisado_confrontado=@revisado_confrontado, " & _
                "fecha_revisado_confrontado=@fecha_revisado_confrontado,nombre_validacion=@nombre_validacion,centro_trabajo=@centro_trabajo " & _
                "WHERE matricula=@matricula"

            Dim cmd As New SqlCommand(sql, conexion.Conexion)
            If IsNumeric(asignaturasTxt.Text) Then
                valorAsignaturas.Number = CDbl(asignaturasTxt.Text)
                asignaturasTxt.Text = valorAsignaturas.ToLetter.ToString.ToUpper
            End If

            '   valorCreditos.Number = CDbl(creditosTxt.Text)
            With cmd
                .Parameters.AddWithValue("@nombre", nombreTxt.Text)
                .Parameters.AddWithValue("@curp", curpTxt.Text)
                .Parameters.AddWithValue("@tipo_certificado", cmbTipoCer.Text)
                .Parameters.AddWithValue("@titulo_certificado", tituloCerTxt.Text)
                .Parameters.AddWithValue("@modalidad", cmdModalidad.Text)
                .Parameters.AddWithValue("@plan_estudios", planTxt.Text)
                .Parameters.AddWithValue("@expedido_en", expedidoTxt.Text)
                .Parameters.AddWithValue("@dia_expedido", diasTxt.Text)
                .Parameters.AddWithValue("@mes_expedido", mesTxt.Text)
                .Parameters.AddWithValue("@anio_expedido", añoTxt.Text)
                .Parameters.AddWithValue("@director", directorTxt.Text)
                .Parameters.AddWithValue("@total_asignaturas", asignaturasTxt.Text)
                .Parameters.AddWithValue("@total_creditos", creditosTxt.Text)
                .Parameters.AddWithValue("@promedio", Convert.ToDecimal(promedioTxt.Text))
                .Parameters.AddWithValue("@revisado_confrontado", revisadoTxt.Text)
                .Parameters.AddWithValue("@fecha_revisado_confrontado", fechaDtp.Value.Date)
                .Parameters.AddWithValue("@nombre_validacion", validadoTxt.Text)
                .Parameters.AddWithValue("@centro_trabajo", cmbTrabajo.Text)
                .Parameters.AddWithValue("@matricula", txtmatricula.Text)
            End With

            cmd.ExecuteNonQuery()


            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
#Region "****************EVENTOS******************"
    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        frmBuscar.txtIdBusqueda.Text = "13"
        frmBuscar.ShowDialog()
    End Sub
    Private Sub txtmatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmatricula.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(txtmatricula.Text) Then
                limpiar_campos()
                buscar_matricula(txtmatricula.Text)
                habilitarControles()
            Else
                MsgBox("NO SE PUEDEN INTRODUCIR CARACTERES", MsgBoxStyle.Critical, "ERROR")
                DeshabilitarControles()
                txtmatricula.SelectAll()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub txtmatricula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmatricula.TextChanged
        If txtmatricula.Text = "" Then limpiar_campos()
    End Sub
    Private Sub Frmalumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtmatricula.Focus()
        limpiar_campos()
        BtnGuardar.Enabled = True
    End Sub
    Private Sub Btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub txtdatos2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'el codigo que esta comentado era para validar lo de los alumnos sin materias reprobadas
        If txtdatos2.Text.Length > 0 Then 'And cont_materias_reprobadas > 0 Then
            cargar_combo()
            'cont_materias_reprobadas = 0
            'ElseIf cont_materias_reprobadas = 0 And txtdatos2.Text.Length > 0 Then
            '    MsgBox("EL ALUMNO NO CUENTA CON MATERIAS REPROBADAS", MsgBoxStyle.Information, "ERROR")
            '    cmbmaterias.Items.Clear()
        End If
    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar_campos()
        BtnGuardar.Enabled = False
    End Sub

#End Region

    Private Sub cmbTrabajo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTrabajo.DropDown
        cargar_combo()
    End Sub

    Private Sub cmbTrabajo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTrabajo.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbTipoCer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoCer.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub BtnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If Me.validarReceptor = True Then
            If lblStatus.Text = "NO ENCONTRADO" Then
                guardar_registro()
                pintarControles()
                limpiar_campos()
            Else
                actualizar_registro()
                pintarControles()
            End If
            'se muestra la forma donde aparecen los reportes
            Frmreporte.Show()
        End If
    End Sub
    Private Function validarReceptor() As Boolean
        Dim res As Boolean = True

        Me.pintarControles()
        Dim ctl As Control

        For Each ctl In Me.GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                If String.IsNullOrEmpty(ctl.Text) Then
                    If ctl.Name <> "especialidadTxt" And ctl.Name <> "licenciaturaTxt" Then
                        ctl.BackColor = Drawing.Color.Aqua()
                        res = False
                    End If
                End If
            End If
        Next ctl

        Return res
    End Function
    Private Sub pintarControles()
        Dim ctl As Control

        For Each ctl In Me.GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.BackColor = Drawing.Color.White
            End If
        Next ctl
    End Sub
    Private Sub habilitarControles()
        Dim ctl As Control

        For Each ctl In Me.GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.Enabled = True
            End If
        Next ctl
    End Sub
    Private Sub DeshabilitarControles()
        Dim ctl As Control

        For Each ctl In Me.GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.Enabled = False
            End If
        Next ctl
    End Sub
    Private Sub Btnsalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsalir.Click
        End
    End Sub

    Private Sub btnlimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        limpiar_campos()
    End Sub


    Private Sub GbxDatos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GbxDatos.Enter

    End Sub

    Private Sub txtdatos_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdatos.TextChanged
        If txtdatos.Text.Length > 0 Then
            cargarAlumno(txtdatos.Text)
            If IsNumeric(txtmatricula.Text) Then
                limpiar_campos()
                buscar_matricula(txtmatricula.Text)
            Else
                MsgBox("NO SE PUEDEN INTRODUCIR CARACTERES", MsgBoxStyle.Critical, "ERROR")
                txtmatricula.SelectAll()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub fechaExpDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaExpDtp.ValueChanged
        diasTxt.Text = fechaExpDtp.Value.Date.Day
        mesTxt.Text = Format(fechaExpDtp.Value.Date, "MMMM").ToUpper
        añoTxt.Text = fechaExpDtp.Value.Date.Year
        valorFecha.Number = CDbl(diasTxt.Text)
        diasTxt.Text = valorFecha.ToLetter.ToUpper
        valorFecha.Number = CDbl(Mid(añoTxt.Text, 3, 2))
        añoTxt.Text = valorFecha.ToLetter.ToUpper
    End Sub
End Class
