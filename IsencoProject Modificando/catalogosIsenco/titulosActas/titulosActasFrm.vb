Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports System.Data.SqlClient

Public Class titulosActasFrm

   
    Public Sub generarConsultaPrincipal()
        Try
            Grid.Rows.Clear()
            Grid.Columns.Clear()
            variables.conexion.abrirConexion()
            Grid.Columns.Add("IDALUMNO", "IDALUMNO")
            Grid.Columns.Add("MATRICULA", "MATRICULA")
            Grid.Columns.Add("APELLIDO_PATERNO", "APELLIDO PATERNO")
            Grid.Columns.Add("APELLIDO_MATERNO", "APELLIDO MATERNO")
            Grid.Columns.Add("NOMBRE", "NOMBRES")
            Grid.Columns.Add("GENERO", "GENERO")
            Grid.Columns.Add("IDCAMPUS", "CAMPUS")
            Grid.Columns.Add("IDSEMESTRE", "SEMESTRE")
            Grid.Columns.Add("IDGRUPO", "GRUPO")
            Grid.Columns.Add("LICENCIATURA", "LICENCIATURA")
            Grid.Columns.Add("ESPECIALIDAD", "ESPECIALIDAD")
            Grid.Columns.Add("ACTA", "ACTA|TITULO")
            Grid.Columns.Add("PLAN", "PLAN")
            Grid.Columns.Add("GENERACION", "GENERACION")

            Grid.Columns.Item("MATRICULA").Width = 150
            Grid.Columns.Item("MATRICULA").ReadOnly = True

            Grid.Columns.Item("APELLIDO_PATERNO").Width = 200
            Grid.Columns.Item("APELLIDO_PATERNO").ReadOnly = True
            Grid.Columns.Item("APELLIDO_PATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("APELLIDO_MATERNO").Width = 200
            Grid.Columns.Item("APELLIDO_MATERNO").ReadOnly = True
            Grid.Columns.Item("APELLIDO_MATERNO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("NOMBRE").Width = 450
            Grid.Columns.Item("NOMBRE").ReadOnly = True
            Grid.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("GENERO").Width = 100
            Grid.Columns.Item("GENERO").ReadOnly = True
            Grid.Columns.Item("GENERO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("IDCAMPUS").Width = 200
            Grid.Columns.Item("IDCAMPUS").ReadOnly = True
            Grid.Columns.Item("IDCAMPUS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("IDSEMESTRE").Width = 200
            Grid.Columns.Item("IDSEMESTRE").ReadOnly = True
            Grid.Columns.Item("IDSEMESTRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("IDGRUPO").Width = 200
            Grid.Columns.Item("IDGRUPO").ReadOnly = True
            Grid.Columns.Item("IDGRUPO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("LICENCIATURA").Width = 200
            Grid.Columns.Item("LICENCIATURA").ReadOnly = True
            Grid.Columns.Item("LICENCIATURA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("ESPECIALIDAD").Width = 200
            Grid.Columns.Item("ESPECIALIDAD").ReadOnly = True
            Grid.Columns.Item("ESPECIALIDAD").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("ACTA").Width = 200
            Grid.Columns.Item("ACTA").ReadOnly = True
            Grid.Columns.Item("ACTA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("PLAN").Width = 200
            Grid.Columns.Item("PLAN").ReadOnly = True
            Grid.Columns.Item("PLAN").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            Grid.Columns.Item("GENERACION").Width = 200
            Grid.Columns.Item("GENERACION").ReadOnly = True
            Grid.Columns.Item("GENERACION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            ' Se hace la consulta principal
            variables.sql = "select ISNULL(E.id,0) AS ACTA,A.idalumno,A.matricula,apellido_paterno,apellido_materno,nombre,A.PLANEST,A.GENERACION," & _
                            "idstatus,genero,idcampus,idsemestre,idgrupo,idlicenciatura,idespecialidad,isnull(E.numero_titulo,'') as numero_titulo " & _
                            "from alumno A LEFT JOIN examen_profesional E on E.idAlumno=A.IDALUMNO " & _
                            "where (A.matricula = '" & txtmatricula.Text & "') order by apellido_paterno,apellido_materno,nombre"

            cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While variables.SQLdr.Read
                Grid.Rows.Add()
            End While
            variables.SQLdr.Close()

            variables.SQLdr = cmd.ExecuteReader
            Dim I As Integer
            I = 0
            While variables.SQLdr.Read()
                Grid(0, I).Value = (variables.SQLdr("IDALUMNO").ToString).ToUpper
                Grid(1, I).Value = (variables.SQLdr("MATRICULA").ToString).ToUpper
                Grid(2, I).Value = (variables.SQLdr("APELLIDO_PATERNO").ToString).ToUpper
                Grid(3, I).Value = (variables.SQLdr("APELLIDO_MATERNO").ToString).ToUpper
                Grid(4, I).Value = (variables.SQLdr("NOMBRE").ToString).ToUpper
                Grid(5, I).Value = (variables.SQLdr("GENERO").ToString).ToUpper
                Grid(6, I).Value = (variables.SQLdr("IDCAMPUS").ToString).ToUpper
                Grid(7, I).Value = (variables.SQLdr("IDSEMESTRE").ToString).ToUpper
                Grid(8, I).Value = (variables.SQLdr("IDGRUPO").ToString).ToUpper
                Grid(9, I).Value = (variables.SQLdr("IDLICENCIATURA").ToString).ToUpper
                Grid(10, I).Value = (variables.SQLdr("IDESPECIALIDAD").ToString).ToUpper
                Grid(12, I).Value = (variables.SQLdr("PLANEST").ToString).ToUpper
                Grid(13, I).Value = (variables.SQLdr("GENERACION").ToString).ToUpper
                If variables.SQLdr("ACTA") > 0 Then
                    If variables.SQLdr("numero_titulo").ToString = "" Then
                        Grid(11, I).Value = "ACTA"
                    Else
                        Grid(11, I).Value = "TITULO"
                    End If
                Else
                    Grid(11, I).Value = "NINGUNO"
                End If
                I = I + 1
            End While

            Grid.Update()
            Grid.Focus()
            contarHombresYmujeres()
            Statusbar1.Items(0).Text = "# Registros: " & Grid.RowCount
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub contarHombresYmujeres()
        Dim hombre, mujer As Integer
        hombre = 0
        mujer = 0
        For i = 0 To Grid.RowCount - 1
            If Grid(5, i).Value.ToString = "H" Then
                hombre = hombre + 1
            End If
            If Grid(5, i).Value.ToString = "M" Then
                mujer = mujer + 1
            End If
        Next
        Statusbar1.Items(1).Text = "# Hombres: " & hombre
        Statusbar1.Items(2).Text = "# Mujeres: " & mujer
    End Sub

    Private Sub llenarActaEncontrada(acta As Integer)
        variables.conexion.abrirConexion()
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.sql = "Select E.*,A.matricula from examen_profesional E inner join alumno A on A.idalumno=E.idalumno where E.id=" & acta & " "
        cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()
        variables.idExamen = 0
        While variables.SQLdr.Read() 'While Data is Present
            variables.idExamen = variables.SQLdr("id")
            llenarActaExamen.TxtMatricula.Text = variables.SQLdr("matricula").ToString
            llenarActaExamen.txtNombre.Text = variables.SQLdr("nombre_completo").ToString
            llenarActaExamen.txtIdAlumno.Text = variables.SQLdr("idalumno").ToString

            llenarActaExamen.txtLicenciatura.Text = variables.SQLdr("licenciatura").ToString
            llenarActaExamen.txtLicenciatura.Text = llenarActaExamen.txtLicenciatura.Text.Replace("ÁREA", "CON ESPECIALIDAD EN")
            llenarActaExamen.txtDirector.Text = variables.SQLdr("director_plantel").ToString
            llenarActaExamen.txtGestion.Text = variables.SQLdr("control_escolar").ToString
            llenarActaExamen.txtConfrontado.Text = variables.SQLdr("registrado_confrontado").ToString
            llenarActaExamen.txtPresidente.Text = variables.SQLdr("presidente").ToString
            llenarActaExamen.txtSecretario.Text = variables.SQLdr("secretario").ToString
            llenarActaExamen.txtVocal.Text = variables.SQLdr("vocal").ToString
            llenarActaExamen.txtNombre_Documento.Text = variables.SQLdr("titulo_tesis").ToString
            llenarActaExamen.txtAutorizacion.Text = variables.SQLdr("autorizacion").ToString
            llenarActaExamen.cmbAcuerdo.Text = variables.SQLdr("resultado_examen").ToString
            llenarActaExamen.cmbAula.Text = variables.SQLdr("lugar_aplicacion").ToString
            llenarActaExamen.cmbLugar.Text = variables.SQLdr("municipio").ToString
            llenarActaExamen.dtpFecha.Value = variables.SQLdr("fecha_examen").ToString
            llenarActaExamen.dtpFc.Value = variables.SQLdr("fecha_confrontado").ToString
            llenarActaExamen.dtpHora.Value = variables.SQLdr("hora")
            llenarActaExamen.lblActaID.Text = variables.idExamen
        End While
        variables.SQLdr.Close()
        variables.conexion.cerrarConexion()
    End Sub
    Private Sub traerNumeroActa()
        variables.conexion.abrirConexion()
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        ' Se hace la consulta principal
        variables.sql = "Select id from examen_profesional where idalumno= " & variables.idalumno & " "

        cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()
        variables.idExamen = 0
        While variables.SQLdr.Read() 'While Data is Present
            variables.idExamen = (variables.SQLdr("id").ToString).ToUpper
        End While
        variables.SQLdr.Close()
        variables.conexion.cerrarConexion()
    End Sub

    Private Sub Btnbuscar_Click(sender As System.Object, e As System.EventArgs) Handles Btnbuscar.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "tituloActa"
        frmBuscarAlumno.ShowDialog()
    End Sub

    Private Sub txtmatricula_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmatricula.KeyPress
        If e.KeyChar = Chr(13) Then
            generarConsultaPrincipal()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim dgvr As DataGridViewRow = Grid.CurrentRow()
        If Grid.RowCount > 0 Then
            If dgvr.Cells("ACTA").Value = "NINGUNO" Then
                MsgBox("El Alumno no tiene el Acta", vbCritical)
                Exit Sub
            End If
            llenarTituloFrm.Show()
            llenarTituloFrm.txtNombre.Text = dgvr.Cells("NOMBRE").Value.ToString() & " " & _
                                             dgvr.Cells("APELLIDO_PATERNO").Value.ToString() & " " & _
                                             dgvr.Cells("APELLIDO_MATERNO").Value.ToString()
            llenarTituloFrm.txtIdAlumno.Text = dgvr.Cells("IDALUMNO").Value.ToString

            llenarTituloFrm.txt_plan.Text = dgvr.Cells("PLAN").Value.ToString
            llenarTituloFrm.txt_generacion.Text = dgvr.Cells("GENERACION").Value.ToString
            variables.conexion.abrirConexion()
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            ' Se hace la consulta principal
            variables.sql = "Select * from examen_profesional where idalumno= '" & dgvr.Cells("IDALUMNO").Value.ToString & "'"

            cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            variables.idExamen = 0
            While variables.SQLdr.Read() 'While Data is Present

                llenarTituloFrm.txtLicenciatura.Text = (variables.SQLdr("licenciatura").ToString).ToUpper
                llenarActaExamen.txtLicenciatura.Text = llenarActaExamen.txtLicenciatura.Text.Replace("ÁREA", "CON ESPECIALIDAD EN")
                llenarTituloFrm.txtNumActa.Text = variables.SQLdr("autorizacion").ToString
                llenarTituloFrm.txtFechaActa.Text = variables.SQLdr("fecha_examen").ToString
                llenarTituloFrm.txtActaExpedidaen.Text = variables.SQLdr("municipio").ToString
                llenarTituloFrm.txt_tituloNum.Text = variables.SQLdr("numero_titulo").ToString
                llenarTituloFrm.txt_plan.Text = variables.SQLdr("planest").ToString
                llenarTituloFrm.txt_generacion.Text = variables.SQLdr("generacion").ToString
                llenarTituloFrm.txtAñoEgreso.Text = variables.SQLdr("anio_egreso").ToString
                llenarTituloFrm.txt_Registro.Text = variables.SQLdr("registro").ToString
                llenarTituloFrm.txt_libro_num.Text = variables.SQLdr("libronum").ToString
                llenarTituloFrm.txt_foja.Text = variables.SQLdr("fojanum").ToString
                llenarTituloFrm.dtpExpedicion.Value = "2013-07-22" 'variables.SQLdr("fecha_expedicion").ToString
                llenarTituloFrm.dtpGestion.Value = "2013-07-19" 'variables.SQLdr("fecha_subdireccion").ToString
                llenarTituloFrm.txtGobernador.Text = variables.SQLdr("gobernador").ToString
                llenarTituloFrm.txtSecretario.Text = variables.SQLdr("secretario_educacion").ToString
                variables.idExamen = variables.SQLdr("id")
            End While
            variables.SQLdr.Close()
            variables.conexion.cerrarConexion()

            llenarTituloFrm.txtDirector.Text = obtenerPersonalXPuestos("DIRECTOR ISENCO")
            llenarTituloFrm.txtGestion.Text = obtenerPersonalXPuestos("SUBDIRECCIÓN DE EDUCACIÓN SUPERIOR")
            llenarTituloFrm.txtGobernador.Text = obtenerPersonalXPuestos("GOBERNADOR CONSTITUCIONAL DEL ESTADO DE COLIMA")
            llenarTituloFrm.txtSecretario.Text = obtenerPersonalXPuestos("SECRETARIO DE EDUCACIÓN")
            llenarTituloFrm.lblActaID.Text = variables.idExamen
        End If
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        Dim dgvr As DataGridViewRow = Grid.CurrentRow()
        If Grid.RowCount > 0 Then
            variables.idalumno = dgvr.Cells("IDALUMNO").Value
            traerNumeroActa()
            If variables.idExamen = 0 Then
                llenarActaExamen.TxtMatricula.Text = dgvr.Cells("MATRICULA").Value.ToString()
                llenarActaExamen.txtNombre.Text = dgvr.Cells("NOMBRE").Value.ToString() & _
                    " " & dgvr.Cells("APELLIDO_PATERNO").Value.ToString() & _
                    " " & dgvr.Cells("APELLIDO_MATERNO").Value.ToString()
                llenarActaExamen.txtIdAlumno.Text = dgvr.Cells("IDALUMNO").Value.ToString

                llenarActaExamen.txtLicenciatura.Text = dgvr.Cells("LICENCIATURA").Value.ToString
                If dgvr.Cells("ESPECIALIDAD").Value.ToString <> "" Then
                    llenarActaExamen.txtLicenciatura.Text = llenarActaExamen.txtLicenciatura.Text + " CON ESPECIALIDAD EN " & dgvr.Cells("ESPECIALIDAD").Value.ToString
                End If
                llenarActaExamen.txtDirector.Text = obtenerPersonalXPuestos("DIRECTOR ISENCO")
                llenarActaExamen.txtGestion.Text = obtenerPersonalXPuestos("SUBDIRECCIÓN DE EDUCACIÓN SUPERIOR")
                llenarActaExamen.txtConfrontado.Text = obtenerPersonalXPuestos("REVISADO Y CONFRONTADO POR")
                llenarActaExamen.dtpFc.Value = obtenerFechaConfrontaTit()
                llenarActaExamen.lblActaID.Text = variables.idExamen
            Else
                llenarActaEncontrada(variables.idExamen)
            End If
            llenarActaExamen.txtAutorizacion.Focus()
            llenarActaExamen.Show()
        End If
    End Sub

    Private Sub GenerarCertificadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarCertificadoToolStripMenuItem.Click
        Dim dgvr As DataGridViewRow = Grid.CurrentRow()
        If Grid.RowCount > 0 Then
            variables.matricula = dgvr.Cells("MATRICULA").Value.ToString()
            certificadosFrm.txtmatricula.Text = variables.matricula
            certificadosFrm.buscar_matricula(variables.matricula)
            certificadosFrm.Show()
        End If
    End Sub
End Class