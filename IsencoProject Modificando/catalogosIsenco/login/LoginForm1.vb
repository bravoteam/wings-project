Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports Microsoft.Reporting.WinForms
Imports System.IO
Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim valor As Boolean = False
        Dim b As New BaseDatos
        Dim ds As New DataSet

        valor = validarUsuario(UsernameTextBox.Text, PasswordTextBox.Text)
        If valor = True Then
            'codigo para extraer variables de parcial
            variables.tipoAcceso = 1
            variables.conexion.abrirConexion()
            variables.sql = "select * from candado where tipoAcceso =" & variables.tipoAcceso & ""
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                variables.parcial = Val(variables.SQLdr("parcial"))
            End While
            variables.conexion.cerrarConexion()
            '-----------------------------------------
            traerDatosUsuario(variables.idLocalizado, variables.descripcionTipoUsuario)
            If variables.tipoUsuario = 10 Then 'Usuario Coordinaciones
                For Each miitem As ToolStripMenuItem In menuPrincipalFrm.MenuStrip1.Items
                    miitem.Visible = False
                Next
                'aqui poner las opciones que se le van habilitar a las coordinaciones
                menuPrincipalFrm.InscripcionToolStripMenuItem.Visible = True
                menuPrincipalFrm.InscripcionDeAlumnosToolStripMenuItem.Visible = True
                menuPrincipalFrm.GenerarMatriculasToolStripMenuItem.Visible = False
                menuPrincipalFrm.PromocionDeAlumnosToolStripMenuItem.Visible = False
                menuPrincipalFrm.CambiosDeGruposToolStripMenuItem.Visible = False
                menuPrincipalFrm.InscripcionDeAlumnosToolStripMenuItem1.Visible = False
                menuPrincipalFrm.ControlDeCalificacionesToolStripMenuItem.Visible = True
                menuPrincipalFrm.ModificacionDeCalificacionesPorAlumnoToolStripMenuItem.Visible = True
                menuPrincipalFrm.GenerarCalificacionesToolStripMenuItem.Visible = True
                menuPrincipalFrm.InformesToolStripMenuItem.Visible = True
                menuPrincipalFrm.ReportesVariosToolStripMenuItem.Visible = True
                menuPrincipalFrm.GenerarCertificadfosToolStripMenuItem.Visible = False
                menuPrincipalFrm.EstadisticosHYMToolStripMenuItem.Visible = False
                menuPrincipalFrm.RegistroDeEscolaridadToolStripMenuItem.Visible = False
                menuPrincipalFrm.ReinscripcionDeAlumnosToolStripMenuItem.Visible = False
                menuPrincipalFrm.AlumnosBecadosToolStripMenuItem.Visible = True
                menuPrincipalFrm.ToolStripMenuItem1.Visible = False
                menuPrincipalFrm.GenerarCalificacionesToolStripMenuItem.Visible = False
                menuPrincipalFrm.CalificacionesExtrasToolStripMenuItem.Visible = False
                menuPrincipalFrm.SalirToolStripMenuItem.Visible = True
                menuPrincipalFrm.ReporteDeReprobadosGeneralToolStripMenuItem.Visible = False
                menuPrincipalFrm.CalificacionesParaMaestrosToolStripMenuItem.Visible = False
                menuPrincipalFrm.ModuloDeCalificacionesParaAlumnosToolStripMenuItem.Visible = False
            End If
            If variables.tipoUsuario = 3 Then 'Usuario Preinscripcion
                For Each miitem As ToolStripMenuItem In menuPrincipalFrm.MenuStrip1.Items
                    miitem.Visible = False
                Next
                menuPrincipalFrm.SalirToolStripMenuItem.Visible = True
                menuPrincipalFrm.PreinscripcionesToolStripMenuItem.Visible = True
                menuPrincipalFrm.GenerarFolioToolStripMenuItem.Enabled = False
                menuPrincipalFrm.ConsultaDeFoliosToolStripMenuItem.Enabled = False
                menuPrincipalFrm.ImpresionDeListasToolStripMenuItem.Enabled = False
                menuPrincipalFrm.AsignarAulasToolStripMenuItem.Enabled = False
            End If
            If variables.tipoUsuario = 4 Then 'Usuario RH
                For Each miitem As ToolStripMenuItem In menuPrincipalFrm.MenuStrip1.Items
                    miitem.Visible = False
                Next
                menuPrincipalFrm.SalirToolStripMenuItem.Visible = True
                menuPrincipalFrm.AcreditacionToolStripMenuItem.Visible = True

                menuPrincipalFrm.campusToolStripMenuItem.Visible = False
                menuPrincipalFrm.CicloEscolarToolStripMenuItem.Visible = False
                menuPrincipalFrm.MateriasToolStripMenuItem.Visible = False
                menuPrincipalFrm.AdministrativosToolStripMenuItem.Visible = False
                menuPrincipalFrm.ConfiguracionInicialToolStripMenuItem.Visible = False
                menuPrincipalFrm.ConfiguracionToolStripMenuItem.Visible = True
            End If
            If variables.tipoUsuario = 1 Then 'Control Escolar
                For Each miitem As ToolStripMenuItem In menuPrincipalFrm.MenuStrip1.Items
                    miitem.Visible = True
                Next
                menuPrincipalFrm.SalirToolStripMenuItem.Visible = True
                menuPrincipalFrm.PreinscripcionesToolStripMenuItem.Visible = True
                menuPrincipalFrm.GenerarFolioToolStripMenuItem.Visible = False
                menuPrincipalFrm.ConsultaDeFoliosToolStripMenuItem.Enabled = True
                menuPrincipalFrm.ImpresionDeListasToolStripMenuItem.Visible = False
                menuPrincipalFrm.AsignarAulasToolStripMenuItem.Visible = False
                menuPrincipalFrm.ValidarPreregistroToolStripMenuItem.Visible = False
                menuPrincipalFrm.InscripcionesToolStripMenuItem.Visible = False
            End If
            If variables.tipoUsuario = 30 Then 'Usuario Maestro
                For Each miitem As ToolStripMenuItem In menuPrincipalFrm.MenuStrip1.Items
                    miitem.Visible = False
                Next
                'aqui poner las opciones que se le van habilitar a las coordinaciones
                menuPrincipalFrm.ModuloDeCalificacionesParaAlumnosToolStripMenuItem.Visible = False
                menuPrincipalFrm.ControlDeCalificacionesToolStripMenuItem.Visible = True
                menuPrincipalFrm.GenerarCalificacionesToolStripMenuItem.Visible = False
                menuPrincipalFrm.ModificacionDeCalificacionesPorAlumnoToolStripMenuItem.Visible = False
                menuPrincipalFrm.CalificacionesExtrasToolStripMenuItem.Visible = False
                menuPrincipalFrm.SalirToolStripMenuItem.Visible = True
            End If
            If variables.tipoUsuario = 50 Then 'Usuario Alumno
                'For Each miitem As ToolStripMenuItem In menuPrincipalFrm.MenuStrip1.Items
                '    miitem.Visible = False
                'Next
                ''aqui poner las opciones que se le van habilitar a las coordinaciones
                'menuPrincipalFrm.ModuloDeCalificacionesParaAlumnosToolStripMenuItem.Visible = True
                'menuPrincipalFrm.ControlDeCalificacionesToolStripMenuItem.Visible = True
                'menuPrincipalFrm.GenerarCalificacionesToolStripMenuItem.Visible = False
                'menuPrincipalFrm.ModificacionDeCalificacionesPorAlumnoToolStripMenuItem.Visible = False
                'menuPrincipalFrm.CalificacionesExtrasToolStripMenuItem.Visible = False
                'menuPrincipalFrm.CalificacionesParaMaestrosToolStripMenuItem.Visible = False
                'menuPrincipalFrm.SalirToolStripMenuItem.Visible = True
                menuAlumnos.Show()
                Exit Sub
            End If
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            menuPrincipalFrm.ToolStripFecha.Text = Now
            menuPrincipalFrm.ToolStripUsuario.Text = variables.nombreUsuario
            menuPrincipalFrm.areaTrabajo.Text = variables.descripcionTipoUsuario
            menuPrincipalFrm.centrodetrabajo.Text = variables.carreramenu
            Me.Hide()
            menuPrincipalFrm.Show()
        Else
            MsgBox("Error Datos Invalidos!", vbCritical)
            Exit Sub
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("DATO: " & Mid(UsernameTextBox.Text, 1, 2) & ":" & Mid(UsernameTextBox.Text, 3, 2))
    End Sub
    Public Function validarUsuario(ByVal user As String, ByVal pass As String) As Boolean
        Dim res As Boolean = False
        variables.conexion.abrirConexion()
        'variables.sql = "SELECT * from usuarios where usuario='" & user & "' and password='" & pass & "'"

        variables.sql = "SELECT U.*,P.descripcion as perfil,T.descripcion as tipoUsuario FROM usuarios U " & _
                        "INNER JOIN usuarios_perfiles P on P.id=U.id_tipo_usuario " & _
                        "inner join usuarios_tipo T on T.id=U.tipo " & _
                        "where usuario='" & user & "' and password='" & pass & "'"

        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            variables.usuario = variables.SQLdr2("usuario").ToString
            variables.idusuario = variables.SQLdr2("id")
            variables.tipoUsuario = variables.SQLdr2("id_tipo_usuario")
            variables.idLocalizado = variables.SQLdr2("idLocalizado")
            variables.descripcionTipoUsuario = variables.SQLdr2("tipoUsuario")
            variables.nombreUsuario = variables.SQLdr2("nombre").ToString
            variables.perfilUsuario = variables.SQLdr2("perfil").ToString
            variables.campusmenu = variables.SQLdr2("campus").ToString
            variables.carreramenu = variables.SQLdr2("carrera").ToString
            variables.personalUser = variables.SQLdr2("idpersonal")
            variables.tipoAcceso = variables.SQLdr2("tipo")
            res = True
        End While
        variables.conexion.cerrarConexion()
        Return res
    End Function
    Private Sub traerDatosUsuario(ByVal id As Integer, ByVal perfil As String)
        Dim res As Boolean = False
        variables.conexion.abrirConexion()

        If perfil = "Personal" Then
            variables.sql = "select id,apellido_paterno + ' ' + apellido_materno + ' ' + nombre as nombrecompleto from personal where id=" & id & " "
        Else
            variables.sql = "select idAlumno as id,apellido_paterno + ' ' + apellido_materno + ' ' + nombre as nombrecompleto from alumno where IDALUMNO=" & id & " "
        End If

        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr2 = cmd.ExecuteReader
        While (variables.SQLdr2.Read())
            variables.idLocalizado = variables.SQLdr2("id")
            variables.nombreUsuario = variables.SQLdr2("nombrecompleto").ToString
            res = True
        End While
        variables.conexion.cerrarConexion()
    End Sub
End Class
