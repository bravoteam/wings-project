Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports System.Data.SqlClient
Public Class asignarAulasFrm
    Private Sub cargarCombos()
        cmbCampus.Items.Clear()
        cmbCampus.Items.Add("CUAUHTÉMOC")
        cmbCampus.Items.Add("TECOMÁN")
        cmbCampus.Items.Add("MANZANILLO")
        cmbCampus.Items.Add("COLIMA")
        cmbLicenciatura.Items.Clear()
        cmbLicenciatura.Items.Add("BACHILLERATO")
        cmbLicenciatura.Items.Add("LIC. EDUC.  PREESCOLAR")
        cmbLicenciatura.Items.Add("LIC. EDUC. ESPECIAL ÁREA DE ATENCIÓN MOTRIZ")
        cmbLicenciatura.Items.Add("LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN BIOLOGÍA.")
        cmbLicenciatura.Items.Add("LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN INGLÉS")
        cmbLicenciatura.Items.Add("LIC. EDUC. PRIMARIA")
    End Sub
    Private Sub RegresarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub asignarAulasFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarCombos()
    End Sub

    Private Sub cmdLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles cmdLimpiar.Click
        listaLicenciaturas.Items.Clear()
        grid.DataSource = Nothing
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Dim i As Long, cadena As String
        If cmbCampus.Text = "" Then
            MsgBox("Elija un Campus", MsgBoxStyle.Critical)
            cmbCampus.Focus()
            Exit Sub
        End If
        If cmbLicenciatura.Text = "" Then
            MsgBox("Elija una Licenciatura", MsgBoxStyle.Critical)
            cmbLicenciatura.Focus()
            Exit Sub
        End If
        cadena = cmbCampus.Text & "|" & cmbLicenciatura.Text
        For i = 0 To listaLicenciaturas.Items.Count - 1
            If cadena = listaLicenciaturas.Items(i) Then
                MsgBox("Ya ha insertado esta opcion", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Next
        listaLicenciaturas.Items.Add(cmbCampus.Text & "|" & cmbLicenciatura.Text)
        llenarGrid()
    End Sub
    Private Sub llenarGrid()
        Dim b As New BaseDatos
        Dim ds As New DataSet
        Dim i As Integer
        Dim campus As String = ""
        Dim licenciatura As String = ""
        Dim cadena As String
        Dim ArrCadena As String()
        variables.sql = ""
        For i = 0 To listaLicenciaturas.Items.Count - 1
            cadena = listaLicenciaturas.Items(i)
            ArrCadena = cadena.split("|")
            campus = ArrCadena(0)
            licenciatura = ArrCadena(1)
            If i = 0 Then
                variables.sql = variables.sql & "(campus='" & campus & "' and licenciatura='" & licenciatura & "')"
            Else
                variables.sql = variables.sql & " or (campus='" & campus & "' and licenciatura='" & licenciatura & "')"
            End If
        Next
        If rContexto.Checked = True Then
            variables.sql = "select id,curp,apellido_paterno,apellido_materno,nombre,folio_isenco,campus,licenciatura,promedio,aula " & _
            "from preregistro where (" & variables.sql & ") and aula= 'X' order by apellido_paterno,apellido_materno,nombre"
        Else
            variables.sql = "select id,curp,apellido_paterno,apellido_materno,nombre,folio_isenco,campus,licenciatura,promedio,aulaCeneval " & _
                "from preregistro where (" & variables.sql & ") and validado= 1 order by apellido_paterno,apellido_materno,nombre"
        End If
        b.abrirConexion()
        ds = b.getDataSet(variables.sql)
        grid.DataSource = ds.Tables(0)
        StatusStrip2.Items(1).Text = grid.RowCount
        grid.AutoResizeColumns()
        b.cerrarConexion()
    End Sub
    Private Sub traerAulas()
        Dim tipo As Integer = 0
        Dim b As New BaseDatos
        Dim ds As New DataSet
        If rCeneval.Checked = True Then
            tipo = 2
            variables.sql = "select * from aulas where aplicaPara=" & tipo & " and id>= " & cmbAulas.SelectedValue & " order by id"
        Else
            tipo = 1
            variables.sql = "select * from aulas where aplicaPara=" & tipo & " order by id"
        End If
        b.abrirConexion()
        ds = b.getDataSet(variables.sql)
        grid2.DataSource = ds.Tables(0)
        grid2.AutoResizeColumns()
        b.cerrarConexion()
    End Sub
    Private Sub AsignarGruposToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarGruposToolStripMenuItem.Click
        Dim i, j, conteo, cupo, aux As Integer
        Dim aula As String = ""
        If rCeneval.Checked Then
            If cmbAulas.Text = "" Then
                MsgBox("Elige Aula", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        traerAulas()
        Try
            conteo = 0
            aux = 0
            For i = 0 To grid2.RowCount - 1
                cupo = grid2.Item("cupo", i).Value
                aula = grid2.Item("ubicacion", i).Value.ToString & " " & grid2.Item("descripcion", i).Value.ToString
                For j = conteo To cupo - 1
                    grid.Item("aulaCeneval", aux).Value = aula
                    If aux > grid.RowCount Then
                        Exit Sub
                    End If
                    aux = aux + 1
                Next
                conteo = 0
            Next
        Catch
            MsgBox("Error Actualizando Verifique")
            Exit Sub
        End Try
    End Sub

    Private Sub GuardarDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarDatosToolStripMenuItem.Click
        Try
            Dim cad As String = "X"
            If rCeneval.Checked = False Then
                If cmbTurno.Text.Length <= 0 Then
                    MsgBox("Seleccione Turno", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            Dim turno As String = cmbTurno.Text
            variables.conexion.abrirConexion()
            Dim sql As String
            For i = 0 To grid.RowCount - 1
                If rCeneval.Checked = True Then
                    cad = grid.Item("aulaCeneval", i).Value.ToString
                Else
                    cad = grid.Item("aula", i).Value.ToString
                End If

                If cad = "X" Then
                    MsgBox("Error Almacenando Aulas", vbCritical)
                    Exit Sub
                End If
                If rCeneval.Checked = True Then
                    sql = "UPDATE preregistro set aulaCeneval='" & cad & "' " & _
                      "WHERE (id=" & CDbl(grid.Item(0, i).Value.ToString) & ") "
                Else
                    sql = "UPDATE preregistro set aula='" & cad & "',turno='" & turno & "' " & _
                      "WHERE (id=" & CDbl(grid.Item(0, i).Value.ToString) & ") "
                End If
                
                Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                cmd.ExecuteNonQuery()
            Next
            variables.conexion.cerrarConexion()
        Catch
            MsgBox("Error Actualizando Verifique")
            Exit Sub
        End Try
    End Sub

    Private Sub rContexto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rContexto.CheckedChanged
        If rContexto.Checked = True Then
            cmbTurno.Enabled = True
        Else
            cmbTurno.Enabled = False
        End If
    End Sub

    Private Sub rCeneval_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rCeneval.CheckedChanged
        If rCeneval.Checked = True Then
            cmbTurno.Enabled = False
            Dim ds As DataSet
            ds = getAulas(2)
            loadComboBox(ds, cmbAulas, "id", "ubicacion")
        Else
            cmbTurno.Enabled = True
        End If
    End Sub
End Class