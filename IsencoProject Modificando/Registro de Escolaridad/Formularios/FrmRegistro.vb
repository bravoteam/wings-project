Imports System.Data.SqlClient
Imports Registro_de_Escolaridad.Datos
Public Class FrmRegistro
    Private conf As New Configuracion
    Private model As New Modelos.AlumnosModel
    Dim idlice2 As String = ""
    Private Sub FrmRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializar_formulario()
    End Sub
    Private Sub inicializar_formulario()
        Dim Licenciaturas As List(Of String) = model.getLicenciaturas
        Dim Especialidades As List(Of String) = model.getEspecialidades
        Dim Turnos As List(Of String) = model.getTurnos
        Dim Campus As List(Of String) = model.getCampus
        Dim Modalidades As List(Of String) = model.getModalidades
        Dim Semestre As List(Of String) = model.getSemestres
        Dim Grupo As List(Of String) = model.getGrupos
        Dim Maestro As List(Of String) = model.getMaestros
        Dim Parcial As List(Of String) = model.getparciales
        Dim directivos As List(Of String) = model.getAdministrativos
        Dim cicloescolar As List(Of String) = model.getcicloescolar
        Cmbciclo.Items.Add("")
        For Each ciclo As String In cicloescolar
            Cmbciclo.Items.Add(ciclo)
        Next
        Cmbacreditacion.Items.Add("")
        CmbInscripcion.Items.Add("")
        Cmbregularizacion.Items.Add("")
        Cmbplantel.Items.Add("")
        For Each Adm As String In directivos
            Cmbacreditacion.Items.Add(Adm)
            CmbInscripcion.Items.Add(Adm)
            Cmbregularizacion.Items.Add(Adm)
            Cmbplantel.Items.Add(Adm)
            cmbplantel2.Items.Add(Adm)
            cmbplantel3.Items.Add(Adm)
        Next
        cmbLicenciatura.Items.Add("")
        For Each L As String In Licenciaturas
            cmbLicenciatura.Items.Add(L)
        Next
        cmbEspecialidad.Items.Add("")
        For Each E As String In Especialidades
            cmbEspecialidad.Items.Add(E)
        Next
        'SE COMENTO PORQUE SE QUITO LA MIXTA
        'cmbModalidad.Items.Add("")
        'For Each M As String In Modalidades
        'cmbModalidad.Items.Add(M)
        'Next
        cmbModalidad.Enabled = False
        cmbModalidad.Text = "E"
        cmbTurno.Items.Add("")
        For Each T As String In Turnos
            cmbTurno.Items.Add(T)
        Next
        cmbCampus.Items.Add("")
        For Each C As String In Campus
            cmbCampus.Items.Add(C)
        Next
        cmbSemestre.Items.Add("")
        For Each S As String In Semestre
            cmbSemestre.Items.Add(S)
        Next
        cmbGrupo.Items.Add("")
        For Each G As String In Grupo
            cmbGrupo.Items.Add(G)
        Next
    End Sub
    Private Sub obtener_id()
        Dim conexion2 As New BaseDatos
        conexion2.abrirConexion()
        Dim sql2 As String = "select idlicenciatura from licenciaturas where nombre = '" & Me.cmbLicenciatura.Text & "'"
        Dim cmd As New SqlCommand(sql2, conexion2.Conexion)
        Dim SQLdr As SqlDataReader 'The Local Data Store
        SQLdr = cmd.ExecuteReader
        While SQLdr.Read
            idlice2 = SQLdr(0).ToString
        End While
        SQLdr.Close()
        conexion2.cerrarConexion()
    End Sub
    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        obtener_id()
        Me.REGISTROESCOLARIDADTableAdapter.Fill(Me.RegistroDt.REGISTROESCOLARIDAD, cmbEspecialidad.Text, cmbSemestre.Text, cmbGrupo.Text, cmbCampus.Text, cmbLicenciatura.Text, cmbTurno.Text, cmbModalidad.Text, idlice2, Cmbciclo.Text)
        'Me.REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter.Fill(Me.RegistroDt.REGISTRO_ESCOLARIDAD_ANTERIOR, cmbEspecialidad.Text, cmbSemestre.Text - 1, cmbGrupo.Text, cmbCampus.Text, cmbLicenciatura.Text, cmbTurno.Text, cmbModalidad.Text, idlice2, Cmbciclo.Text)
        If dg.Rows.Count - 1 > 0 Then ' And dg2.Rows.Count - 1 > 0 Then
            'checar_materias_acreditadas_anteriores()
            checar_materias_acreditadas()
            Reporte_Escolaridad.Show()
        Else
            MsgBox("LOS DATOS PROPORCIONADOS NO SON CORRECTOS", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub checar_materias_acreditadas_anteriores()
        Dim conexion As New BaseDatos
        Dim i As Integer
        Dim matriculainicial As String = ""
        Dim matriculatemp As String = ""
        Dim cont_aprobadas_normal As Integer = 0
        Dim cont_reprobadas_normal As Integer = 0
        Dim valor_extra1 As Decimal = 0
        Dim valor_extra2 As Decimal = 0
        Dim valor_extra3 As Decimal = 0

        matriculainicial = dg2(10, 0).Value.ToString
        For i = 0 To dg2.Rows.Count - 1
            If matriculainicial <> dg2(10, i).Value Then ' aqui es cuando cambia de matricula
                Try
                    conexion.abrirConexion()
                    Dim sql As String = "UPDATE calificaciones SET noacreditadasant = @noacreditadasant where matricula = @matricula and idsemestre = @idsemestre and idgrupo = @idgrupo"
                    Dim cmd As New SqlCommand(sql, conexion.Conexion)
                    With cmd
                        .Parameters.AddWithValue("@noacreditadasant", cont_reprobadas_normal)
                        .Parameters.AddWithValue("@matricula", matriculainicial)
                        .Parameters.AddWithValue("@idsemestre", (dg2(7, 0).Value + 1))
                        .Parameters.AddWithValue("@idgrupo", dg2(8, 0).Value)
                    End With
                    cmd.ExecuteNonQuery()
                    conexion.cerrarConexion()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                cont_aprobadas_normal = 0
                cont_reprobadas_normal = 0
                matriculainicial = dg2(10, i).Value
                i = i - 1
            Else
                If ((dg2(12, i).Value + dg2(13, i).Value) / 2) >= 6 And (dg2(11, i).Value <> 1233 And dg2(11, i).Value <> 1232) Then
                    cont_aprobadas_normal = cont_aprobadas_normal + 1
                Else ' si la materia esta reprobada entonces buscar en los extras
                    valor_extra1 = 0
                    valor_extra2 = 0
                    valor_extra3 = 0
                    If IsDBNull(dg2(22, i).Value) = False Then valor_extra1 = dg2(22, i).Value
                    If IsDBNull(dg2(23, i).Value) = False Then valor_extra2 = dg2(23, i).Value
                    If IsDBNull(dg2(24, i).Value) = False Then valor_extra1 = dg2(24, i).Value

                    If valor_extra1 >= 6 And valor_extra1 <> 13 Then
                        cont_aprobadas_normal = cont_aprobadas_normal + 1
                    Else
                        If valor_extra2 >= 6 And valor_extra2 <> 13 Then
                            cont_aprobadas_normal = cont_aprobadas_normal + 1
                        Else
                            If valor_extra3 >= 6 And valor_extra3 <> 13 Then
                                cont_aprobadas_normal = cont_aprobadas_normal + 1
                            Else
                                'aqui van las reprobadas
                                If (dg2(11, i).Value <> 1233 And dg2(11, i).Value <> 1232) Then
                                    cont_reprobadas_normal = cont_reprobadas_normal + 1
                                End If
                            End If
                        End If
                    End If
            End If
                 
            End If
        Next
    End Sub
    Private Sub checar_materias_acreditadas()
        Dim conexion As New BaseDatos
        Dim i As Integer
        Dim matriculainicial As String = ""
        Dim matriculatemp As String = ""
        Dim cont_aprobadas_normal As Integer = 0
        Dim cont_reprobadas_normal As Integer = 0
        Dim valor_extra1 As Decimal = 0
        Dim valor_extra2 As Decimal = 0
        Dim valor_extra3 As Decimal = 0

        ' matriculainicial = dg(0,8)
        ' MsgBox(dg(8, 0).Value)
        matriculainicial = dg(8, 0).Value.ToString
        For i = 0 To dg.Rows.Count - 1
            If matriculainicial <> dg(8, i).Value Then ' aqui es cuando cambia de matricula
                'MsgBox(matriculainicial & "-" & cont_aprobadas_normal)
                Try
                    '
                    conexion.abrirConexion()
                    Dim sql As String = "UPDATE calificaciones SET acreditadas=@acreditadas,noacreditadas = @noacreditadas where matricula = @matricula and idsemestre = @idsemestre and idgrupo = @idgrupo"
                    Dim cmd As New SqlCommand(sql, conexion.Conexion)
                    With cmd
                        .Parameters.AddWithValue("@acreditadas", cont_aprobadas_normal)
                        .Parameters.AddWithValue("@noacreditadas", cont_reprobadas_normal)
                        .Parameters.AddWithValue("@matricula", matriculainicial)
                        .Parameters.AddWithValue("@idsemestre", dg(0, 0).Value)
                        .Parameters.AddWithValue("@idgrupo", dg(1, 0).Value)
                    End With
                    cmd.ExecuteNonQuery()
                    conexion.cerrarConexion()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                cont_aprobadas_normal = 0
                cont_reprobadas_normal = 0
                matriculainicial = dg(8, i).Value
                i = i - 1
            Else
                If ((dg(10, i).Value + dg(11, i).Value) / 2) >= 6 And (dg(9, i).Value <> 1233 And dg(9, i).Value <> 1232) Then
                    cont_aprobadas_normal = cont_aprobadas_normal + 1
                Else ' si la materia esta reprobada entonces buscar en los extras
                    valor_extra1 = 0
                    valor_extra2 = 0
                    valor_extra3 = 0
                    If IsDBNull(dg(20, i).Value) = False Then valor_extra1 = dg(20, i).Value
                    If IsDBNull(dg(21, i).Value) = False Then valor_extra2 = dg(21, i).Value
                    If IsDBNull(dg(22, i).Value) = False Then valor_extra3 = dg(22, i).Value
                    If valor_extra1 >= 6 And valor_extra1 <> 13 Then
                        cont_aprobadas_normal = cont_aprobadas_normal + 1
                    Else
                        If valor_extra2 >= 6 And valor_extra2 <> 13 Then
                            cont_aprobadas_normal = cont_aprobadas_normal + 1
                        Else
                            If valor_extra3 >= 6 And valor_extra3 <> 13 Then
                                cont_aprobadas_normal = cont_aprobadas_normal + 1
                            Else
                                'aqui van las reprobadas
                                If (dg(9, i).Value <> 1233 And dg(9, i).Value <> 1232) Then
                                    cont_reprobadas_normal = cont_reprobadas_normal + 1
                                End If
                            End If
                        End If


                    End If
                End If
                '    If ((dg(10, i).Value + dg(11, i).Value)) > 0 And (dg(9, i).Value = 1233 Or dg(9, i).Value = 1232) Then
                '        cont_aprobadas_normal = cont_aprobadas_normal + 1
                '        '  Else
                '        '      cont_reprobadas_normal = cont_reprobadas_normal + 1
                '    End If
            End If
        Next
    End Sub
    Private Sub limpiar_combos()
        cmbCampus.Text = ""
        cmbEspecialidad.Text = ""
        Cmbacreditacion.Text = ""
        cmbGrupo.Text = ""
        CmbInscripcion.Text = ""
        cmbLicenciatura.Text = ""
        Cmbregularizacion.Text = ""
        cmbSemestre.Text = ""
        cmbTurno.Text = ""
        Dtp1.Value = Today
        Dtp2.Value = Today
        Dtp3.Value = Today
    End Sub
    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        limpiar_combos()
    End Sub
End Class
