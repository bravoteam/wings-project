Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports datosCompartidos.funciones

Public Class FrmRegistroEsp
    Private conf As New Configuracion
    Private model As New datosCompartidos.Modelos.AlumnosModel
    Dim idlice2 As String = ""
    Private Sub FrmRegistroEsp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializar_formulario()
    End Sub
    Public Shared Function traer_idespecialidad(ByVal especialidad As String) As Integer
        Try
            'agregue la variable existe_registro en variables
            variables.existe_registro = False
            variables.conexion.abrirConexion()
            variables.sql = "select idespecialidad as id from especialidades where descripcion = '" & especialidad & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            variables.idespecialidad = 0
            While variables.SQLdr.Read
                variables.idespecialidad = Integer.Parse(variables.SQLdr(0).ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            Throw ex
        Finally
            variables.conexion.cerrarConexion()
        End Try
        Return variables.idespecialidad
    End Function
    Private Sub inicializar_formulario()
        Dim ds As New DataSet
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "IDLICENCIATURA", "licenciatura")
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "IDESPECIALIDAD", "especialidad")
        ds = getGrados()
        loadComboBox(ds, cmbSemestre, "IDSEMESTRE", "grado")
        ds = getGrupos()
        loadComboBox(ds, cmbGrupo, "nombre", "nombre")

        limpiar_combos()
        Dim cicloescolar As List(Of String) = model.getcicloescolar
        For Each ciclo As String In cicloescolar
            cmbcicloescolar.Items.Add(ciclo)
        Next
    End Sub
    Private Sub validar_datos()
        If variables.materia2_extra = "" Then
            variables.materia2_extra = "0"
        End If
        If variables.materia3_extra = "" Then
            variables.materia3_extra = "0"
        End If
        If variables.materia4_extra = "" Then
            variables.materia4_extra = "0"
        End If
        If variables.materia5_extra = "" Then
            variables.materia5_extra = "0"
        End If
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
                    'cambio la conexion  en actualizacion para que se actualice la tabla reporte_registro escolaridad la cantidad de materias
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
                If ((dg2(12, i).Value + dg2(13, i).Value) / 2) >= 6 And (dg2(11, i).Value <> 1233 And dg2(11, i).Value <> 1278) And (dg(11, i).Value <> 1233 And dg(11, i).Value <> 1232) Then
                    cont_aprobadas_normal = cont_aprobadas_normal + 1
                Else ' si la materia esta reprobada entonces buscar en los extras
                    valor_extra1 = 0
                    valor_extra2 = 0
                    valor_extra3 = 0
                    If IsDBNull(dg2(22, i).Value) = False Then valor_extra1 = dg2(22, i).Value
                    If IsDBNull(dg2(23, i).Value) = False Then valor_extra2 = dg2(23, i).Value
                    If IsDBNull(dg2(24, i).Value) = False Then valor_extra3 = dg2(24, i).Value

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
                                If (dg2(11, i).Value <> 1233 And dg2(11, i).Value <> 1232 And dg(11, i).Value <> 1278 And dg(11, i).Value <> 1279) Then
                                    cont_reprobadas_normal = cont_reprobadas_normal + 1
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub validar_numeros_enteros()
        Select Case variables.valor2_extra
            Case 1
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 2
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 3
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 4
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 5
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 6
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 7
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 8
                variables.valor2_extra = variables.valor2_extra & ".0"
            Case 9
                variables.valor2_extra = variables.valor2_extra & ".0"
        End Select
        Select Case variables.valor3_extra
            Case 1
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 2
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 3
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 4
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 5
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 6
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 7
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 8
                variables.valor3_extra = variables.valor3_extra & ".0"
            Case 9
                variables.valor3_extra = variables.valor3_extra & ".0"
        End Select
        Select Case variables.valor4_extra
            Case 1
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 2
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 3
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 4
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 5
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 6
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 7
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 8
                variables.valor4_extra = variables.valor4_extra & ".0"
            Case 9
                variables.valor4_extra = variables.valor4_extra & ".0"

        End Select
    End Sub
    Private Sub checar_materias_acreditadas()
        Dim b As New BaseDatos
        Dim i As Integer
        Dim matriculainicial As String = ""
        Dim IDalumnoinicial As Integer = 0
        Dim matriculatemp As String = ""
        Dim cont_aprobadas_normal As Integer = 0
        Dim cont_reprobadas_normal As Integer = 0
        Dim valor_extra1 As String = "0"
        Dim valor_extra2 As String = "0"
        Dim valor_extra3 As String = "0"
        Dim valor_regu As Decimal = 0

        matriculainicial = dg(25, 0).Value.ToString
        IDalumnoinicial = dg(28, 0).Value.ToString
        For i = 0 To dg.Rows.Count - 1
            If matriculainicial <> dg(25, i).Value Then 'cambia de matricula
                'aqui actualizar los registros o crearlos de acuerdo al total de materias reprobadas
                '-----------------------------------------------------------------------------------
                Try
                    validar_datos()
                    b.abrirConexion()
                    'validar los datos para que sean con punto decimal
                    validar_numeros_enteros() ' agregar esto al nuevo reporte que tenga esteban
                    Dim sql As String = "update reporte_registro_escolar set reg_oport1=@REG_OPORT1,reg_oport2=@REG_OPORT2,reg_oport3=@REG_OPORT3,reg_oport4=@REG_OPORT4," & _
                                    "reg_materia1=@REG_MATERIA1,reg_materia2=@REG_MATERIA2,reg_materia3=@REG_MATERIA3,reg_materia4=@REG_MATERIA4," & _
                                    "acred_act=@ACREDITADAS,acred_no =@NOACREDITADAS, idgrupo = @IDGRUPO " & _
                                    "where idalumno = @IDALUMNO and idcicloescolar = @IDCICLOESCOLAR and idsemestre = @IDSEMESTRE and idgrupo=@IDGRUPO"

                    Dim cmd As New SqlCommand(sql, b.Conexion)
                    With cmd
                        .Parameters.AddWithValue("@REG_OPORT1", variables.valor2_extra)
                        .Parameters.AddWithValue("@REG_OPORT2", variables.valor3_extra)
                        .Parameters.AddWithValue("@REG_OPORT3", variables.valor4_extra)
                        .Parameters.AddWithValue("@REG_OPORT4", variables.valor5_extra)
                        .Parameters.AddWithValue("@REG_MATERIA1", variables.materia2_extra)
                        .Parameters.AddWithValue("@REG_MATERIA2", variables.materia3_extra)
                        .Parameters.AddWithValue("@REG_MATERIA3", variables.materia4_extra)
                        .Parameters.AddWithValue("@REG_MATERIA4", variables.materia5_extra)
                        .Parameters.AddWithValue("@ACREDITADAS", cont_aprobadas_normal)
                        .Parameters.AddWithValue("@NOACREDITADAS", cont_reprobadas_normal)
                        .Parameters.AddWithValue("@IDALUMNO", IDalumnoinicial)
                        .Parameters.AddWithValue("@IDSEMESTRE", cmbSemestre.Text)
                        .Parameters.AddWithValue("@IDGRUPO", cmbGrupo.Text)
                        .Parameters.AddWithValue("@IDCICLOESCOLAR", cmbcicloescolar.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    b.cerrarConexion()
                Catch ex As Exception
                    Throw ex
                End Try
                cont_aprobadas_normal = 0
                cont_reprobadas_normal = 0
                matriculainicial = dg(25, i).Value
                IDalumnoinicial = dg(28, i).Value
                i = i - 1
                limpiar_variables()
            Else

                If ((dg(12, i).Value + dg(13, i).Value) / 2) >= 6 And (dg(11, i).Value <> 1233 And dg(11, i).Value <> 1232) And (dg(11, i).Value <> 1278 And dg(11, i).Value <> 1279) Then
                    cont_aprobadas_normal = cont_aprobadas_normal + 1
                Else ' si la materia esta reprobada entonces buscar en los extras
                    valor_extra1 = ""
                    valor_extra2 = ""
                    valor_extra3 = ""
                    If IsDBNull(dg(22, i).Value) = False Then valor_extra1 = dg(22, i).Value
                    If IsDBNull(dg(23, i).Value) = False Then valor_extra2 = dg(23, i).Value
                    If IsDBNull(dg(24, i).Value) = False Then valor_extra3 = dg(24, i).Value
                    If valor_extra1 >= 6 And valor_extra1 <> 0 And valor_extra1 <> 13 Then
                        cont_aprobadas_normal = cont_aprobadas_normal + 1
                        variables.valor1_extra = valor_extra1
                        variables.materia1_extra = dg(17, i).Value
                    Else
                        If valor_extra2 >= "6" And valor_extra2 <> "0" And valor_extra2 <> "13" Then
                            cont_aprobadas_normal = cont_aprobadas_normal + 1
                            variables.valor1_extra = valor_extra2 'aqui me traigo el valor del extra
                            variables.materia1_extra = dg(17, i).Value
                        Else
                            If valor_extra3 >= "6" And valor_extra3 <> "0" And valor_extra3 <> "13" Then
                                cont_aprobadas_normal = cont_aprobadas_normal + 1
                                variables.valor1_extra = valor_extra3
                                variables.materia1_extra = dg(17, i).Value
                            Else
                                'aqui van las reprobadas
                                If (dg(11, i).Value <> 1233 And dg(11, i).Value <> 1232 And dg(11, i).Value <> 1278 And dg(11, i).Value <> 1279) Then
                                    cont_reprobadas_normal = cont_reprobadas_normal + 1
                                End If
                            End If
                        End If
                    End If
                    'abro conexion y consulto
                    If variables.valor1_extra <> "0" Then
                        If variables.valor2_extra = "0" Then
                            variables.valor2_extra = variables.valor1_extra
                            variables.materia2_extra = variables.materia1_extra
                            GoTo fuera
                        End If
                        If variables.valor3_extra = "0" Then
                            variables.valor3_extra = variables.valor1_extra
                            variables.materia3_extra = variables.materia1_extra
                            GoTo fuera
                        End If
                        If variables.valor4_extra = "0" Then
                            variables.valor4_extra = variables.valor1_extra
                            variables.materia4_extra = variables.materia1_extra
                            GoTo fuera
                        End If
                        If variables.valor5_extra = "0" Then
                            variables.valor5_extra = variables.valor1_extra
                            variables.materia5_extra = variables.materia1_extra
                            GoTo fuera
                        End If
                    End If
fuera:
                    variables.valor1_extra = "0"
                End If

                Try
                    'agregue la variable existe_registro en variables
                    variables.existe_registro = False
                    variables.conexion.abrirConexion()
                    variables.sql = "select * from reporte_registro_escolar where idalumno = '" & dg(28, i).Value & "' and idcicloescolar = '" & dg(29, i).Value & "' " & _
                                    "and idmateria= '" & dg(11, i).Value & "' and idsemestre = '" & dg(8, i).Value & "'"
                    Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
                    variables.SQLdr = cmd.ExecuteReader()
                    If variables.SQLdr.HasRows Then
                        variables.existe_registro = True
                    Else
                        variables.existe_registro = False
                    End If
                    variables.conexion.cerrarConexion()
                Catch ex As Exception
                    Throw ex
                Finally
                    variables.conexion.cerrarConexion()
                End Try
                'si existe el registro entonces actualizo el dato
                If variables.existe_registro Then
                    Try
                        variables.conexion.abrirConexion()
                        variables.sql = "update reporte_registro_escolar set calificacion = @CALIFICACION,calificacion2 = @CALIFICACION2, status= @IDSTATUS,IDGRUPO = @IDGRUPO where idalumno = @IDALUMNO and idcicloescolar = @IDCICLOESCOLAR " & _
                                       "and idmateria= @IDMATERIA and idsemestre = @IDSEMESTRE"
                        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
                        With cmd
                            .Parameters.AddWithValue("@CALIFICACION", dg(12, i).Value)
                            .Parameters.AddWithValue("@CALIFICACION2", dg(13, i).Value)
                            .Parameters.AddWithValue("@IDALUMNO", dg(28, i).Value)
                            .Parameters.AddWithValue("@IDCICLOESCOLAR", dg(29, i).Value)
                            .Parameters.AddWithValue("@IDMATERIA", dg(11, i).Value)
                            .Parameters.AddWithValue("@IDSEMESTRE", dg(8, i).Value)
                            .Parameters.AddWithValue("@IDSTATUS", dg(30, i).Value)
                            .Parameters.AddWithValue("@IDGRUPO", cmbGrupo.Text)
                        End With
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Throw ex
                    Finally
                        variables.conexion.cerrarConexion()
                    End Try
                Else
                    'sino existe el registro entonces lo creo
                    Try
                        variables.conexion.abrirConexion()
                        Dim sql As String = "INSERT INTO [ISENCO].[dbo].[reporte_registro_escolar]" & _
                                            "([idalumno],[idmateria],[calificacion],[calificacion2]," & _
                                            "[idcampus],[idlicenciatura]," & _
                                            "[idespecialidad],[idsemestre],[idgrupo],[idcicloescolar],[status],[tipocheck])" & _
                                            "values(@IDALUMNO,@IDMATERIA,@CALIFICACION,@CALIFICACION2," & _
                                            "@IDCAMPUS,@IDLICENCIATURA,@IDESPECIALIDAD," & _
                                            "@IDSEMESTRE,@IDGRUPO,@IDCICLOESCOLAR,@STATUS,@TIPOCHECK)"
                        Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                        With cmd
                            .Parameters.AddWithValue("@IDALUMNO", dg(28, i).Value)
                            .Parameters.AddWithValue("@IDMATERIA", dg(11, i).Value)
                            .Parameters.AddWithValue("@CALIFICACION", dg(12, i).Value)
                            .Parameters.AddWithValue("@CALIFICACION2", dg(13, i).Value)
                            .Parameters.AddWithValue("@IDCAMPUS", dg(19, i).Value)
                            .Parameters.AddWithValue("@IDLICENCIATURA", dg(7, i).Value)
                            .Parameters.AddWithValue("@IDESPECIALIDAD", dg(10, i).Value)
                            .Parameters.AddWithValue("@IDSEMESTRE", dg(8, i).Value)
                            .Parameters.AddWithValue("@IDGRUPO", dg(9, i).Value)
                            .Parameters.AddWithValue("@IDCICLOESCOLAR", dg(29, i).Value)
                            .Parameters.AddWithValue("@STATUS", dg(30, i).Value)
                            .Parameters.AddWithValue("@TIPOCHECK", dg(27, i).Value)

                        End With
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Throw ex
                    Finally
                        variables.conexion.cerrarConexion()
                    End Try

                End If

            End If
        Next
        '==========================
        Try
            validar_datos()
            b.abrirConexion()
            validar_numeros_enteros() 'esto lo puse hoy
            Dim sql As String = "update reporte_registro_escolar set reg_oport1=@REG_OPORT1,reg_oport2=@REG_OPORT2,reg_oport3=@REG_OPORT3,reg_oport4=@REG_OPORT4," & _
                            "reg_materia1=@REG_MATERIA1,reg_materia2=@REG_MATERIA2,reg_materia3=@REG_MATERIA3,reg_materia4=@REG_MATERIA4," & _
                            "acred_act=@ACREDITADAS,acred_no =@NOACREDITADAS,IDGRUPO = @IDGRUPO " & _
                            "where idalumno = @IDALUMNO and idcicloescolar = @IDCICLOESCOLAR and idsemestre = @IDSEMESTRE and idgrupo=@IDGRUPO"

            Dim cmd As New SqlCommand(sql, b.Conexion)
            With cmd
                .Parameters.AddWithValue("@REG_OPORT1", variables.valor2_extra)
                .Parameters.AddWithValue("@REG_OPORT2", variables.valor3_extra)
                .Parameters.AddWithValue("@REG_OPORT3", variables.valor4_extra)
                .Parameters.AddWithValue("@REG_OPORT4", variables.valor5_extra)
                .Parameters.AddWithValue("@REG_MATERIA1", variables.materia2_extra)
                .Parameters.AddWithValue("@REG_MATERIA2", variables.materia3_extra)
                .Parameters.AddWithValue("@REG_MATERIA3", variables.materia4_extra)
                .Parameters.AddWithValue("@REG_MATERIA4", variables.materia5_extra)
                .Parameters.AddWithValue("@ACREDITADAS", cont_aprobadas_normal)
                .Parameters.AddWithValue("@NOACREDITADAS", cont_reprobadas_normal)
                .Parameters.AddWithValue("@IDALUMNO", IDalumnoinicial)
                .Parameters.AddWithValue("@IDSEMESTRE", cmbSemestre.Text)
                .Parameters.AddWithValue("@IDGRUPO", cmbGrupo.Text)
                .Parameters.AddWithValue("@IDCICLOESCOLAR", cmbcicloescolar.Text)
            End With
            cmd.ExecuteNonQuery()
            b.cerrarConexion()

        Catch ex As Exception
            Throw ex
        End Try
        cont_aprobadas_normal = 0
        cont_reprobadas_normal = 0
        'matriculainicial = dg(25, i).Value
        'IDalumnoinicial = dg(28, i).Value
        'i = i - 1
        limpiar_variables()
        '==========================
    End Sub
    Private Sub limpiar_combos()
        cmbCampus.Text = ""
        cmbEspecialidad.Text = ""
        cmbGrupo.Text = ""
        cmbLicenciatura.Text = ""
        cmbSemestre.Text = ""
        cmbTurno.Text = ""
    End Sub
    Private Sub limpiar_variables()
        variables.valor1_extra = "0"
        variables.valor2_extra = "0"
        variables.valor3_extra = "0"
        variables.valor4_extra = "0"
        variables.valor5_extra = "0"
        'cambiar estos con 0'
        variables.materia1_extra = ""
        variables.materia2_extra = ""
        variables.materia3_extra = ""
        variables.materia4_extra = ""
        variables.materia5_extra = ""
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        FrmConfiguration2.Show()
    End Sub


    Private Sub BtnGenerar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        'elegir el tamaño del reporte dependiendo del numero de materias
        variables.idesp = traer_idespecialidad(cmbEspecialidad.Text)
        Try
            'agregue la variable existe_registro en variables
            variables.existe_registro = False
            variables.conexion.abrirConexion()
            variables.sql = "select count(distinct(c.idmateria)) as total from calificaciones as c " & _
                            "INNER JOIN materias as m on (m.IDMATERIA= c.IDMATERIA and c.idespecialidad = m.idespecialidad and c.idlicenciatura = m.idcarrera) " & _
                            " where c.idsemestre = '" & cmbSemestre.Text & "' and c.idgrupo = '" & cmbGrupo.Text & "'" & _
                            " and c.idcicloescolar = '" & cmbcicloescolar.Text & "' and c.idlicenciatura = '" & cmbLicenciatura.SelectedValue & "' and c.idmateria <> 0 and c.idespecialidad = '" & variables.idesp & "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While variables.SQLdr.Read
                variables.num_materias = Integer.Parse(variables.SQLdr(0).ToString)
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            Throw ex
        Finally
            variables.conexion.cerrarConexion()
        End Try
        Label8.Text = variables.num_materias
        '---------------------------------------------------------------
        If cmbSemestre.Text Mod 2 <> 0 Then
            'si el semestre es impar entonces revisar las calificaciones de un ciclo escolar atras
            Dim parts As String() = cmbcicloescolar.Text.Split(New Char() {"-"})
            Dim part As String
            Dim ciclo As String = ""
            Dim anio As Integer = 0
            For Each part In parts
                anio = Integer.Parse(part) - 1
                ciclo = ciclo + Str(anio).Trim + "-"
            Next part
            'en la parte de ciclo se concatena dependiendo del ciclo correspondiente
            Me.REGISTRO_ESCOLARIDADTableAdapter.Fill(Me.RegistroEscolaridad.REGISTRO_ESCOLARIDAD, cmbEspecialidad.Text, cmbSemestre.Text, cmbGrupo.Text, cmbCampus.Text, cmbLicenciatura.Text, cmbModalidad.Text, cmbLicenciatura.SelectedValue, cmbcicloescolar.Text)
            Me.REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter.Fill(Me.RegistroEscolaridad.REGISTRO_ESCOLARIDAD_ANTERIOR, cmbEspecialidad.Text, cmbSemestre.Text - 1, cmbGrupo.Text, cmbCampus.Text, cmbLicenciatura.Text, cmbModalidad.Text, cmbLicenciatura.SelectedValue, Mid(ciclo, 1, 9))
        Else
            Me.REGISTRO_ESCOLARIDADTableAdapter.Fill(Me.RegistroEscolaridad.REGISTRO_ESCOLARIDAD, cmbEspecialidad.Text, cmbSemestre.Text, cmbGrupo.Text, cmbCampus.Text, cmbLicenciatura.Text, cmbModalidad.Text, cmbLicenciatura.SelectedValue, cmbcicloescolar.Text)
            Me.REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter.Fill(Me.RegistroEscolaridad.REGISTRO_ESCOLARIDAD_ANTERIOR, cmbEspecialidad.Text, cmbSemestre.Text - 1, cmbGrupo.Text, cmbCampus.Text, cmbLicenciatura.Text, cmbModalidad.Text, cmbLicenciatura.SelectedValue, cmbcicloescolar.Text)

        End If
        If dg.Rows.Count - 1 > 0 Then
            If cmbSemestre.Text <> "1" Then
                '--------------------
                checar_materias_acreditadas()
                '--------------------
                FRmRep_RegistroEsp.Show()
            Else
                checar_materias_acreditadas()
                FRmRep_RegistroEsp.Show()
            End If
        Else
            MsgBox("LOS DATOS PROPORCIONADOS NO SON CORRECTOS", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
    End Sub

End Class