Imports System.Data.SqlClient
Imports Reportes_Isenco.Datos
Public Class FrmMain
    Private conf As New Configuracion
    Private model As New Modelos.AlumnosModel
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

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
        'CmbDocentes.Items.Add("")
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
    Private Sub id_combo()
        checar_conexion()
        Abrir_conexion()
        IDESPE = 0
        SQLSTR = " SELECT IDLICENCIATURA FROM LICENCIATURAS WHERE NOMBRE='" & cmbLicenciatura.Text & "' "
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read
            IdLice = SQLdr("IDLICENCIATURA").ToString
        End While
        SQLdr.Close()
        SQLSTR = " SELECT IDESPECIALIDAD FROM ESPECIALIDADES WHERE DESCRIPCION='" & cmbEspecialidad.Text & "' "
        SQLCmd.CommandText = SQLSTR 'Sets the SQL String
        SQLdr = SQLCmd.ExecuteReader 'Gets Data
        While SQLdr.Read
            IDESPE = SQLdr("IDESPECIALIDAD").ToString
        End While
        SQLdr.Close()
        SQLConn.Close()
    End Sub
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializar_formulario()
    End Sub

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        If CmbtipoReporte.Text = "" Then
            MsgBox("Favor de Seleccionar el tipo de reporte", MsgBoxStyle.Critical, "ERROR")
            CmbtipoReporte.Focus()
            Exit Sub
        End If
        Select Case CmbtipoReporte.Text
            Case "PRIMERA PARCIAL"
                id_combo()
                Reporte_Primera_Parcial.Show()
            Case "SEGUNDA PARCIAL"
                id_combo()
                Reporte_Segunda_Parcial.Show()
            Case "PRIMERA Y SEGUNDA PARCIAL"
                id_combo()
                Reporte_Primera_segunda.Show()
            Case "PRIMERA OPORTUNIDAD REGULARIZACIÓN"
                id_combo()
                Reporte_Primera_Oportunidad.Show()
            Case "SEGUNDA OPORTUNIDAD REGULARIZACIÓN"
                id_combo()
                Reporte_Segunda_Oportunidad.Show()
            Case "TERCERA OPORTUNIDAD REGULARIZACIÓN"
                id_combo()
                Reporte_Tercera_Oportunidad.Show()
            Case "ACREDITADOS X OPORTUNIDAD"
                id_combo()
                Reporte_Oportunidades_Regularizacion.Show()
            Case "NO ACREDITADOS X MATERIA"
                id_combo()
                Reporte_Reprobadas.Show()
            Case "NO ACREDITADOS - ACT. CULT. Y DEP."
                id_combo()
                Reporte_Actividades_Deportivas.Show()
            Case "PROMEDIO X MATERIAS"
                id_combo()
                Reporte_Promedio_x_Materias.Show()
        End Select

    End Sub
End Class
