Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports System.Data.SqlClient

Public Class inscripcionFrm
    Private model As New datosCompartidos.Modelos.AlumnosModel
    Private Sub inscripcionFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "idLicenciatura", "licenciatura")
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "idEspecialidad", "especialidad")
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
        ds = getGrados()
        loadComboBox(ds, cmbSemestre, "IDSEMESTRE", "grado")
        ds = getGrupos()
        loadComboBox(ds, cmbGrupo, "nombre", "nombre")
        Dim cicloescolar As List(Of String) = model.getcicloescolar

        For Each ciclo As String In cicloescolar
            Cmbciclo.Items.Add(ciclo)
        Next
        Cmbciclo.Text = "2012-2013"
        cmbCampus.Text = "CUAUHTEMOC"
        cmbEspecialidad.Text = ""
    End Sub
    Private Sub generaGrid()
        Dim cs1 As New DataGridViewCheckBoxColumn
        Grid.Columns.Add("MATRICULA", "MATRICULA")
        Grid.Columns.Add("NOMBREAL", "NOMBRE")
        Grid.Columns.Add("CAMPUS", "CAMPUS")
        Grid.Columns.Add("LICENCIATURA", "LICENCIATURA")
        Grid.Columns.Add("ESPECIALIDAD", "ESPECIALIDAD")
        Grid.Columns.Add("TURNO", "TURNO")
        Grid.Columns.Add("SEMESTRE", "SEMESTRE")
        Grid.Columns.Add("GRUPO", "GRUPO")
        Grid.Columns.Add("FECHA", "FECHA")
        Grid.Columns.Add("CICLOESCOLAR", "CICLO ESCOLAR")
        Grid.Columns.Add("TIPOBECA", "TIPO BECA")
        Grid.Columns.Add("OBSERVACIONES", "OBSERVACIONES")

        cs1 = New DataGridViewCheckBoxColumn()
        cs1.Name = "INSCRIBIR"
        cs1.HeaderText = "INSCRIBIR"
        'Aca se agrega la columna tipo CheckBox
        Grid.Columns.Add(cs1)

        Grid.Columns.Item("MATRICULA").Width = 100
        Grid.Columns.Item("MATRICULA").ReadOnly = True

        Grid.Columns.Item("NOMBREAL").Width = 150
        Grid.Columns.Item("NOMBREAL").ReadOnly = True
        Grid.Columns.Item("NOMBREAL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Grid.Columns.Item("CAMPUS").Width = 100
        Grid.Columns.Item("CAMPUS").Visible = False

        Grid.Columns.Item("LICENCIATURA").Width = 150
        Grid.Columns.Item("LICENCIATURA").Visible = False

        Grid.Columns.Item("ESPECIALIDAD").Width = 450
        Grid.Columns.Item("ESPECIALIDAD").Visible = False

        Grid.Columns.Item("TURNO").Width = 80
        Grid.Columns.Item("TURNO").Visible = False

        Grid.Columns.Item("SEMESTRE").Width = 80
        Grid.Columns.Item("SEMESTRE").Visible = False

        Grid.Columns.Item("GRUPO").Width = 80
        Grid.Columns.Item("GRUPO").Visible = False

        Grid.Columns.Item("FECHA").Width = 50

        Grid.Columns.Item("CICLOESCOLAR").Width = 50

        Grid.Columns.Item("TIPOBECA").Width = 130

        Grid.Columns.Item("OBSERVACIONES").Width = 200

    End Sub

    Private Sub consultarcmd_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmd.Click

        Dim sql As String = ""
        Dim aux As String = ""
        Dim cs1 As New DataGridViewCheckBoxColumn
        Try
            Grid.Rows.Clear()
            Grid.Columns.Clear()
            generaGrid()

            sql = "select * FROM alumno a where " & _
            "a.IDCAMPUS = '" & cmbCampus.Text & "' and a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
            "and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' and a.IDSEMESTRE = '" & cmbSemestre.Text & "' " & _
            "and a.IDGRUPO = '" & cmbGrupo.Text & "' " & _
            "order by a.apellido_paterno,a.apellido_materno, a.nombre"

            variables.conexion.abrirConexion()
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While variables.SQLdr.Read
                Grid.Rows.Add()
            End While
            variables.SQLdr.Close()

            variables.SQLdr = cmd.ExecuteReader
            Dim I As Integer
            I = 0

            While variables.SQLdr.Read()
                Grid(0, I).Value = (variables.SQLdr("MATRICULA").ToString).ToUpper
                Grid(1, I).Value = (variables.SQLdr("APELLIDO_PATERNO").ToString).ToUpper & " " & (variables.SQLdr("APELLIDO_MATERNO").ToString).ToUpper & " " & (variables.SQLdr("NOMBRE").ToString).ToUpper
                Grid(2, I).Value = (variables.SQLdr("IDCAMPUS").ToString).ToUpper
                Grid(3, I).Value = (variables.SQLdr("IDLICENCIATURA").ToString)
                Grid(4, I).Value = (variables.SQLdr("IDESPECIALIDAD").ToString).ToUpper
                Grid(5, I).Value = (variables.SQLdr("IDTURNO").ToString).ToUpper
                Grid(6, I).Value = (variables.SQLdr("IDSEMESTRE").ToString).ToUpper
                Grid(7, I).Value = (variables.SQLdr("IDGRUPO").ToString).ToUpper
                Grid(8, I).Value = Format(fechaDtp.Value, "dd-MM-yyyy")
                Grid(9, I).Value = Cmbciclo.Text
                Grid(10, I).Value = (variables.SQLdr("BECA").ToString).ToUpper
                Grid(11, I).Value = " "
                I = I + 1
            End While

            Grid.Update()
            Grid.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click
        Try
            variables.mensajeAS = MsgBox("Deseas Inscribir a los Alumnos?", MsgBoxStyle.YesNo)
            If variables.mensajeAS = vbYes Then
                insertarInscripciones()
                MsgBox("Actualizacion Exitosa!!", MsgBoxStyle.Information)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub insertarInscripciones()
        Try
            variables.conexion.abrirConexion()
            Dim sql As String
            For i = 0 To Grid.RowCount - 1
                If Grid.Item(12, i).Value = True Then 'calificacion1
                    sql = "INSERT INTO alumno_pago(matricula,nombreAl,campus,licenciatura,especialidad,turno,semestre,grupo,fecha,cicloescolar,tipobeca,observaciones)" & _
                        "VALUES(@matricula,@nombreAl,@campus,@licenciatura,@especialidad,@turno,@semestre,@grupo,@fecha,@cicloescolar,@tipobeca,@observaciones) "
                    Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                    With cmd
                        .Parameters.AddWithValue("@matricula", Grid(0, i).Value.ToString)
                        .Parameters.AddWithValue("@nombreAl", Grid(1, i).Value.ToString)
                        .Parameters.AddWithValue("@campus", Grid(2, i).Value.ToString)
                        .Parameters.AddWithValue("@licenciatura", Grid(3, i).Value.ToString)
                        .Parameters.AddWithValue("@especialidad", Grid(4, i).Value.ToString)
                        .Parameters.AddWithValue("@turno", Grid(5, i).Value.ToString)
                        .Parameters.AddWithValue("@semestre", Grid(6, i).Value.ToString)
                        .Parameters.AddWithValue("@grupo", Grid(7, i).Value.ToString)
                        .Parameters.AddWithValue("@fecha", Date.Parse(Grid(8, i).Value.ToString))
                        .Parameters.AddWithValue("@cicloescolar", Grid(9, i).Value.ToString)
                        If Grid(10, i).Value = "" Then
                            Grid(10, i).Value = " "
                        End If
                        .Parameters.AddWithValue("@tipobeca", Grid(10, i).Value.ToString)
                        If Grid(11, i).Value = "" Then
                            Grid(11, i).Value = " "
                        End If
                        .Parameters.AddWithValue("@observaciones", Grid(11, i).Value.ToString)
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Alumno Inscrito: " & Grid.Item(0, i).Value.ToString)
                End If
            Next
            variables.conexion.cerrarConexion()
        Catch
            MsgBox("Error Actualizando Verifique", vbCritical)
            Exit Sub
        End Try
    End Sub
End Class