Imports datosCompartidos.funciones
Imports datosCompartidos
Imports System.Data.SqlClient

Public Class certificadosFrm
    Private conf As New Configuracion
    Private model As New modelos.modeloAlumno
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
    Private mensaje As String = ""
    Private campus As String = ""
    Private valorAsignaturas As New NumToLetter
    Private valorCreditos As New NumToLetter
    Private valorFecha As New NumToLetter

    Private Sub cambiarFecha()
        fechaDtp.Value = obtenerFechaConfrontaCert()
        fechaExpDtp.Value = obtenerFechaExpCert()
        diasTxt.Text = fechaExpDtp.Value.Date.Day
        mesTxt.Text = Format(fechaExpDtp.Value.Date, "MMMM").ToUpper
        añoTxt.Text = fechaExpDtp.Value.Date.Year
        valorFecha.Number = CDbl(diasTxt.Text)
        diasTxt.Text = valorFecha.ToLetter.ToUpper
        valorFecha.Number = CDbl(Mid(añoTxt.Text, 3, 2))
        añoTxt.Text = valorFecha.ToLetter.ToUpper
    End Sub
    Private Sub txtmatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmatricula.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(txtmatricula.Text) Then
                limpiar_campos(GbxDatos)
                lblStatus.Text = "NO ENCONTRADO"
                cmbTipoCer.Text = ""
                cmbTrabajo.Text = ""
                cmdModalidad.Text = ""
                comboGenero.Text = ""
                fechaDtp.Value = obtenerFechaConfrontaCert()
                fechaExpDtp.Value = obtenerFechaExpCert()
                buscar_matricula(txtmatricula.Text)
                cambiarFecha()
            Else
                MsgBox("NO SE PUEDEN INTRODUCIR CARACTERES", MsgBoxStyle.Critical, "ERROR")
                txtmatricula.SelectAll()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub txtmatricula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmatricula.TextChanged
        If txtmatricula.Text = "" Then limpiar_campos(GbxDatos)
    End Sub
    Public Sub buscar_matricula(ByVal dato As String)
        Dim encontrado As Boolean = False
        Try
            variables.conexion.abrirConexion()
            variables.sql = "SELECT * FROM certificados" & _
                     " WHERE matricula = '" & dato & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            lblStatus.Text = "NO ENCONTRADO"
            If variables.SQLdr.HasRows Then
                While variables.SQLdr.Read()
                    lblStatus.Text = "ENCONTRADO"

                End While
            End If
            variables.conexion.cerrarConexion()
            variables.conexion.abrirConexion()

            variables.sql = "SELECT A.*,L.idlicenciatura as IDLICE FROM alumno A inner join licenciaturas L on L.nombre=A.idlicenciatura" & _
                     " WHERE A.matricula = '" & dato & "'"
            cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            encontrado = False
            While (variables.SQLdr.Read()) 'While Data is Present
                encontrado = True
                nombreTxt.Text = variables.SQLdr("NOMBRE").ToString.ToUpper & " " & variables.SQLdr("APELLIDO_PATERNO").ToString.ToUpper & " " & variables.SQLdr("APELLIDO_MATERNO").ToString.ToUpper
                curpTxt.Text = variables.SQLdr("CURP").ToString.ToUpper
                If variables.SQLdr("GENERO").ToString.ToUpper = "M" Then
                    comboGenero.Text = "LICENCIADA"
                Else
                    comboGenero.Text = "LICENCIADO"
                End If
                campus = variables.SQLdr("IDCAMPUS").ToString.ToUpper
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

                cmbTrabajo.Text = "06ENL0001X" ' QUITAR CUANDO SE AUTORICE
                cmbTipoCer.Text = "COMPLETOS"
                cmdModalidad.Text = "ESCOLARIZADA"
                especialidadTxt.Text = variables.SQLdr("IDESPECIALIDAD").ToString.ToUpper
                licenciaturaTxt.Text = variables.SQLdr("IDLICENCIATURA").ToString.ToUpper
                variables.IdLice = variables.SQLdr("IDLICE").ToString
                'SE HACE LA VALIDACION PARA GENERAR EL TITULO DE CERTIFICADO
                '--------------------------------------------------------------
                If especialidadTxt.Text = "" Then
                    tituloCerTxt.Text = comboGenero.Text + " EN " + licenciaturaTxt.Text
                Else
                    tituloCerTxt.Text = comboGenero.Text + " EN " + licenciaturaTxt.Text + " CON ESPECIALIDAD EN " + especialidadTxt.Text
                End If
                'MANDA A LLAMAR LA FUNCION PARA COINCIDENCIAS Y ASI COLOCAR EL PLAN DE ESTUDIOS
                '--------------------------------------------------------------
                If NEncontrados(variables.SQLdr("IDLICENCIATURA").ToString.ToUpper, "PRIMARIA") Then
                    planTxt.Text = 1997
                    creditosTxt.Text = 448
                    asignaturasTxt.Text = 45
                End If
                If NEncontrados(variables.SQLdr("IDLICENCIATURA").ToString.ToUpper, "PREESCOLAR") Then
                    planTxt.Text = 1999
                    creditosTxt.Text = 448
                    asignaturasTxt.Text = 42
                End If
                If NEncontrados(variables.SQLdr("IDLICENCIATURA").ToString.ToUpper, "SECUNDARIA") Then
                    If NEncontrados(variables.SQLdr("IDESPECIALIDAD").ToString.ToUpper, "MATEM") Then
                        planTxt.Text = 1999
                        creditosTxt.Text = 392 ' CAMBIAR CREDITOS
                        asignaturasTxt.Text = 46
                    Else
                        planTxt.Text = 1999
                        creditosTxt.Text = 392
                        asignaturasTxt.Text = 45
                    End If
                    
                End If
                'SE LLENA EL DATO DE EXPEDICION
                '--------------------------------------------------------------
                expedidoTxt.Text = "COLIMA,COLIMA"
            End While
            variables.SQLdr.Close()
            directorTxt.Text = obtenerPersonalXPuestos("DIRECTOR ISENCO")
            revisadoTxt.Text = obtenerPersonalXPuestos("REVISADO Y CONFRONTADO POR")
            validadoTxt.Text = obtenerPersonalXPuestos("SUBDIRECCIÓN DE EDUCACIÓN SUPERIOR")

            promedioTxt.Text = obtenerPromedio(txtmatricula.Text)
            cambiarFecha()
            '===============================================
            If Not encontrado Then
                MsgBox("EL REGISTRO NO FUE ENCONTRADO EN LA BASE DE DATOS", MsgBoxStyle.Critical, "ERROR")
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub guardar_registro() ' Inserta el registro de certificado
        Try

            variables.conexion.abrirConexion()

            Dim sql As String = "insert into certificados(matricula,nombre,curp,tipo_certificado,titulo_certificado," & _
                "modalidad,plan_estudios,expedido_en,dia_expedido,mes_expedido,anio_expedido,director,total_asignaturas, " & _
                "total_creditos,promedio,revisado_confrontado,fecha_revisado_confrontado,nombre_validacion,centro_trabajo) " & _
                         "values (@matricula,@nombre,@curp,@tipo_certificado,@titulo_certificado," & _
                "@modalidad,@plan_estudios,@expedido_en,@dia_expedido,@mes_expedido,@anio_expedido,@director,@total_asignaturas, " & _
                "@total_creditos,@promedio,@revisado_confrontado,@fecha_revisado_confrontado,@nombre_validacion,@centro_trabajo)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
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

            variables.conexion.abrirConexion()
            Dim sql As String = "UPDATE certificados SET nombre=@nombre,curp=@curp,tipo_certificado=@tipo_certificado, " & _
                "titulo_certificado=@titulo_certificado,modalidad=@modalidad,plan_estudios=@plan_estudios,expedido_en=@expedido_en, " & _
                "dia_expedido=@dia_expedido,mes_expedido=@mes_expedido,anio_expedido=@anio_expedido,director=@director, " & _
                "total_asignaturas=@total_asignaturas,total_creditos=@total_creditos,promedio=@promedio,revisado_confrontado=@revisado_confrontado, " & _
                "fecha_revisado_confrontado=@fecha_revisado_confrontado,nombre_validacion=@nombre_validacion,centro_trabajo=@centro_trabajo " & _
                "WHERE matricula=@matricula"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
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

    Private Sub cmbTrabajo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrabajo.DropDown
        cmbTrabajo.Enabled = True
        variables.conexion.abrirConexion()
        Try
            cmbTrabajo.Items.Clear()
            variables.sql = "SELECT CCT from campus"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader
            While (variables.SQLdr.Read()) ' SE CARGAN LOS DATOS EN EL COMBO
                cmbTrabajo.Items.Add(variables.SQLdr(0).ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
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

    Private Sub limpiar_camposLocal()
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
        fechaDtp.Value = obtenerFechaConfrontaCert()
        fechaExpDtp.Value = obtenerFechaExpCert()
        cambiarFecha()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub certificadosFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtmatricula.Text = variables.matricula
        If txtmatricula.Text <> "" Then
            buscar_matricula(txtmatricula.Text)
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiar_camposLocal()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        If funcionesLocales.validarReceptor(GbxDatos) = True Then
            If lblStatus.Text = "NO ENCONTRADO" Then
                guardar_registro()
                pintarControles(GbxDatos)
                limpiar_campos(GbxDatos)
            Else
                actualizar_registro()
                pintarControles(GbxDatos)
            End If
            'se muestra la forma donde aparecen los reportes}
            variables.nombreAlumno = nombreTxt.Text
            variables.matriculaValor = txtmatricula.Text
            imprimeCertificadoFrm.Show()
        End If
    End Sub
End Class