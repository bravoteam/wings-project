Imports System.Data.SqlClient
Imports datosCompartidos.funciones
Imports System.IO

Public Class ExtrasFrm
    Public Fotografia As String = ""
    Private Ext As String = ""
    Public FotografiaAnterior As String = ""
    Private FotoVacia As String = System.AppDomain.CurrentDomain.BaseDirectory + "nf.jpg"
    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "extracalif"
        frmBuscarAlumno.ShowDialog()
    End Sub
    Public Sub generarConsultaPrincipal(ByVal idTipo As Integer)
        Try
            Gbxmaterias.Enabled = False
            limpiar_etiquetas()
            Dim modelo As modelos.modeloAlumno
            Grid.Rows.Clear()
            Grid.Columns.Clear()
            variables.conexion.abrirConexion()
            modelo = funcionesLocales.traerAlumno(txtmatricula.Text)
            If modelo.IDALUMNO <> 0 Then
                lblnombre.Text = modelo.NOMBRE & " " & modelo.APELLIDO_PATERNO & " " & modelo.APELLIDO_MATERNO
                If Not (IsNothing(modelo.FOTO)) Then
                    Dim bytBLOBData() As Byte = modelo.FOTO
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    oFotografia.Image = Image.FromStream(stmBLOBData)
                End If
                generaGrid()
            Else
                MsgBox("El Alumno No Existe", MsgBoxStyle.Critical)
                lblnombre.Text = ""
                Exit Sub
            End If
            variables.conexion.cerrarConexion()
            variables.conexion.abrirConexion()
            If idTipo = 1 Then
                ' quitar el -1 en el semestre
                variables.sql = "select C.idcalificacion, c.Matricula,c.IDMATERIA,m.NOMBRE,c.CALIFICACION," & _
                       "c.calificacion2,c.IDCICLOESCOLAR,c.IDSEMESTRE,c.extra1,c.extra1_fecha,c.extra2,c.extra2_fecha,c.extra3,c.extra3_fecha,a.idcampus," & _
                       "c.idgrupo,c.IDCICLOESCOLAR,a.idsemestre,a.idlicenciatura as IDLICENCIATURA,a.idespecialidad as ESPE,A.FOTO " & _
                       "from calificaciones c inner join materias m on c.IDMATERIA=m.IDMATERIA " & _
                       "INNER JOIN alumno a on a.matricula=c.matricula and a.idsemestre -1 = c.idsemestre " & _
                       "INNER JOIN status_calificaciones S on S.id=c.idStatus " & _
                       "WHERE C.Matricula='" + txtmatricula.Text + "' and ((c.calificacion + c.calificacion2)/2) < 6" & _
                        "ORDER BY C.idmateria"

                'variables.sql = "select C.idcalificacion, c.Matricula,c.IDMATERIA,m.NOMBRE,c.CALIFICACION," & _
                '            "c.calificacion2,c.IDCICLOESCOLAR,c.IDSEMESTRE,c.extra1,c.extra1_fecha,c.extra2,c.extra2_fecha,c.extra3,c.extra3_fecha,a.idcampus," & _
                '            "c.idgrupo,c.IDCICLOESCOLAR,a.idsemestre,a.idlicenciatura as IDLICENCIATURA,a.idespecialidad as ESPE,A.FOTO " & _
                '            "from calificaciones c inner join materias m on c.IDMATERIA=m.IDMATERIA " & _
                '            "INNER JOIN alumno a on a.matricula=c.matricula and a.idsemestre -1 = c.idsemestre " & _
                '            "INNER JOIN status_calificaciones S on S.id=c.idStatus " & _
                '            "WHERE C.Matricula='" + txtmatricula.Text + "' and ((c.calificacion + c. calificacion2)/2) < 6" & _
                '             "ORDER BY C.IDSEMESTRE"
            Else
                variables.sql = "select C.idcalificacion, c.Matricula,c.IDSEMESTRE,c.IDMATERIA,m.NOMBRE,c.CALIFICACION," & _
                            "c.calificacion2,c.IDCICLOESCOLAR ,c.extra1,c.extra1_fecha,c.extra2,c.extra2_fecha,c.extra3,c.extra3_fecha,c.idlicenciatura,a.idcampus " & _
                            "c.idgrupo,c.idlicenciatura,a.idlicenciatura as lice,a.idespecialidad as espe,S.descripcion,S.id " & _
                            "from calificaciones c inner join materias m on c.IDMATERIA=m.IDMATERIA " & _
                            "INNER JOIN alumno a on a.matricula=c.matricula " & _
                            "INNER JOIN status_calificaciones S on S.id=c.idStatus " & _
                            "WHERE C.Matricula='" + txtmatricula.Text + "' ORDER BY C.IDSEMESTRE"
            End If
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While variables.SQLdr.Read
                Grid.Rows.Add()
            End While
            variables.SQLdr.Close()

            variables.SQLdr = cmd.ExecuteReader
            Dim I As Integer
            I = 0
            limpiar_etiquetas()
            Dim registro_encontrado As Boolean = False
            While variables.SQLdr.Read()
                registro_encontrado = True
                Grid(0, I).Value = (variables.SQLdr("IDMATERIA").ToString)
                Grid(1, I).Value = (variables.SQLdr("NOMBRE").ToString).ToUpper
                Grid(2, I).Value = (variables.SQLdr("CALIFICACION").ToString).ToUpper
                Grid(3, I).Value = (variables.SQLdr("CALIFICACION2").ToString).ToUpper
                Grid(4, I).Value = (variables.SQLdr("EXTRA1").ToString).ToUpper
                Grid(5, I).Value = Format((variables.SQLdr("EXTRA1_FECHA")), "dd-MM-yyyy")
                Grid(6, I).Value = (variables.SQLdr("EXTRA2").ToString).ToUpper
                Grid(7, I).Value = Format((variables.SQLdr("EXTRA2_FECHA")), "dd-MM-yyyy")
                Grid(8, I).Value = (variables.SQLdr("EXTRA3").ToString).ToUpper
                Grid(9, I).Value = Format((variables.SQLdr("EXTRA3_FECHA")), "dd-MM-yyyy")
                Grid(10, I).Value = (variables.SQLdr("IDCALIFICACION").ToString)

                lblcarrera.Text = (variables.SQLdr("IDLICENCIATURA").ToString).ToUpper
                If (variables.SQLdr("ESPE").ToString).ToUpper <> "" Then
                    lblcarrera.Text = lblcarrera.Text + " CON ESPECIALIDAD EN " & (variables.SQLdr("ESPE").ToString).ToUpper
                End If
                lblcicloescolar.Text = (variables.SQLdr("IDCICLOESCOLAR").ToString).ToUpper
                lblcampus.Text = (variables.SQLdr("IDCAMPUS").ToString).ToUpper
                lblsemestre.Text = (variables.SQLdr("IDSEMESTRE").ToString).ToUpper
                lblgrupo.Text = (variables.SQLdr("IDGRUPO").ToString).ToUpper

                I = I + 1
            End While
            Grid.Update()
            Grid.Focus()
            If Not registro_encontrado Then
                'manda un mensaje de que el alumno no cuenta con calificaciones generadas'
                MsgBox("EL ALUMNO " & lblnombre.Text & "  NO CUENTA CON CALIFICACIONES GENERADAS EN EL SEMESTRE ACTUAL", MsgBoxStyle.Critical, "NO EXISTEN CALIFICACIONES")
            End If
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
        If variables.tipoUsuario = 10 Then
            Me.ToolStripMenuItem3.Enabled = False
        End If
    End Sub
    Private Sub traer_materia(ByVal idmateria As Integer)
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from materias where idmateria = '" & idmateria & "' order by IDMATERIA DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            lblclaveisenco.Text = ""
            lblidmateria.Text = ""
            lblplanest.Text = ""
            lblmateria.Text = ""
            While (variables.SQLdr.Read())
                Gbxmaterias.Enabled = True
                lblidmateria.Text = Val(variables.SQLdr("IDMATERIA").ToString)
                lblmateria.Text = variables.SQLdr("NOMBRE").ToString
                lblplanest.Text = variables.SQLdr("PLANDEESTUDIOS").ToString
                lblclaveisenco.Text = variables.SQLdr("CLAVEISENCO").ToString
            End While
            variables.conexion.cerrarConexion()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub traer_calificacion_extra(ByVal idcalificacion As Integer)
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from calificaciones where idcalificacion = '" & idcalificacion & "' order by IDcalificacion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            primeratxt.Enabled = True
            segundatxt.Enabled = True
            terceratxt.Enabled = True
            DTP1.Enabled = True
            DTP1.Enabled = True
            DTP1.Enabled = True
            While (variables.SQLdr.Read())
                lblidcalificacion.Text = Val(variables.SQLdr("IDCALIFICACION").ToString)
                primeratxt.Text = Val(variables.SQLdr("EXTRA1").ToString)
                segundatxt.Text = Val(variables.SQLdr("EXTRA2").ToString)
                terceratxt.Text = Val(variables.SQLdr("EXTRA3").ToString)
                DTP1.Value = Format((variables.SQLdr("EXTRA1_FECHA")), "dd-MM-yyyy")
                DTP2.Value = Format((variables.SQLdr("EXTRA2_FECHA")), "dd-MM-yyyy")
                DTP3.Value = Format((variables.SQLdr("EXTRA3_FECHA")), "dd-MM-yyyy")
                If primeratxt.Text <> "0" Then
                    primeratxt.Enabled = False
                    DTP1.Enabled = False
                End If
                If segundatxt.Text <> "0" Then
                    segundatxt.Enabled = False
                    DTP2.Enabled = False
                End If
                If terceratxt.Text <> "0" Then
                    terceratxt.Enabled = False
                    DTP3.Enabled = False
                End If

            End While
            variables.conexion.cerrarConexion()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub generaGrid()
        Grid.Columns.Add("IDMATERIA", "IDMATERIA")
        Grid.Columns.Add("NOMBRE", "MATERIA")
        Grid.Columns.Add("CALIFICACION", "1ra PARCIAL")
        Grid.Columns.Add("CALIFICACION2", "2da PARCIAL")
        Grid.Columns.Add("EXTRA1", "REGU 1")
        Grid.Columns.Add("EXTRA1F", "FECHA EXTRA 1(DD-MM-AAAA)")
        Grid.Columns.Add("EXTRA2", "REGU 2")
        Grid.Columns.Add("EXTRA2F", "FECHA EXTRA 2(DD-MM-AAAA)")
        Grid.Columns.Add("EXTRA3", "REGU 3")
        Grid.Columns.Add("EXTRA3F", "FECHA EXTRA 3(DD-MM-AAAA)")
        Grid.Columns.Add("IDCALIFICACION", "IDCALIFICACION")
        Grid.Columns.Item("IDMATERIA").Width = 150
        Grid.Columns.Item("IDMATERIA").ReadOnly = True

        Grid.Columns.Item("NOMBRE").Width = 450
        Grid.Columns.Item("NOMBRE").ReadOnly = True
        Grid.Columns.Item("NOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Grid.Columns.Item("CALIFICACION").Width = 100
        Grid.Columns.Item("CALIFICACION2").Width = 100
        Grid.Columns.Item("EXTRA1").Width = 100
        Grid.Columns.Item("EXTRA2").Width = 100
        Grid.Columns.Item("EXTRA3").Width = 100
        Grid.Columns.Item("EXTRA1F").Width = 200


    End Sub
    Private Sub limpiar_etiquetas()
        lblcampus.Text = ""
        lblcarrera.Text = ""
        lblcicloescolar.Text = ""
        lblsemestre.Text = ""
        lblgrupo.Text = ""
        lblclaveisenco.Text = ""
        lblplanest.Text = ""
        lblmateria.Text = ""
        lblidmateria.Text = ""
    End Sub
    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Me.Close()
    End Sub
    Private Sub Grid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseDoubleClick
        traer_materia(Grid.Item("IDMATERIA", Grid.CurrentRow.Index).Value)
        traer_calificacion_extra(Grid.Item("IDCALIFICACION", Grid.CurrentRow.Index).Value)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Try
            variables.mensajeAS = MsgBox("Deseas Actualizar las Calificaciones?", MsgBoxStyle.YesNo)
            If variables.mensajeAS = vbYes Then
                actualizarCalificaciones()
                MsgBox("Actualizacion Exitosa!!", MsgBoxStyle.Information)
                generarConsultaPrincipal(1)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
        Gbxmaterias.Enabled = False
    End Sub

    Private Sub actualizarCalificaciones()
        Try
            variables.conexion.abrirConexion()
            Dim sql As String

            If Val(primeratxt.Text) <= 0 Then 'extra1
                primeratxt.Text = 0
            End If
            If Val(segundatxt.Text) <= 0 Then 'extra2
                segundatxt.Text = 0
            End If
            If Val(terceratxt.Text) <= 0 Then 'extra3
                terceratxt.Text = 0
            End If

            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)

            sql = "UPDATE calificaciones set" & _
                " extra1=@extra1,extra2=@extra2, extra3=@extra3, extra1_fecha=@extra1_fecha," & _
                " extra2_fecha=@extra2_fecha, extra3_fecha=@extra3_fecha " & _
                "where (IDCALIFICACION=@IDCALIFICACION) "

            cmd = New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@extra1", CDbl(primeratxt.Text))
                .Parameters.AddWithValue("@extra2", CDbl(segundatxt.Text))
                .Parameters.AddWithValue("@extra3", CDbl(terceratxt.Text))
                .Parameters.AddWithValue("@extra1_fecha", CDate(DTP1.Value))
                .Parameters.AddWithValue("@extra2_fecha", CDate(DTP2.Value))
                .Parameters.AddWithValue("@extra3_fecha", CDate(DTP3.Value))
                .Parameters.AddWithValue("@IDCALIFICACION", lblidcalificacion)
            End With
            cmd.ExecuteNonQuery()

            variables.conexion.cerrarConexion()
        Catch
            MsgBox("Error Actualizando Verifique")
            Exit Sub
        End Try
    End Sub

End Class