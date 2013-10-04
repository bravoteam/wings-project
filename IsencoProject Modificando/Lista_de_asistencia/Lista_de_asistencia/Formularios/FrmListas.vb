Imports System.Data.SqlClient
Imports Lista_de_asistencia.Datos
Imports Microsoft.Reporting.WinForms

Public Class FrmListas
    Private conf As New Configuracion
    Private model As New Modelos.AlumnosModel

    Private Sub FrmListas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        'CmbDocentes.Items.Add("")
        For Each P As String In Parcial
            CmbParcial.Items.Add(P)
        Next

        For Each Ma As String In Maestro
            CmbDocentes.Items.Add(Ma)
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

    Private Sub CmbMaterias_Click(ByVal sender As Object, ByVal e As System.EventArgs)
       
    End Sub


    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        'id_combo()
        If CmbMaterias.Text = "" And CmbDocentes.Text = "" Then
            SD = 1
        Else
            SD = 0
        End If
        If CmbParcial.Text = "PRIMERA PARCIAL" Then
            FrmImpresion.Show()
            If SD = 0 Then
                FrmImpresion.ReportViewer1.Show()
                FrmImpresion.ReportViewer2.Hide()
                FrmImpresion.ReportViewer3.Hide()
                FrmImpresion.ReportViewer4.Hide()
            Else
                FrmImpresion.ReportViewer1.Hide()
                FrmImpresion.ReportViewer2.Hide()
                FrmImpresion.ReportViewer3.Show()
                FrmImpresion.ReportViewer4.Hide()
            End If
        Else
            FrmImpresion.Show()
            If SD = 0 Then
                FrmImpresion.ReportViewer2.Show()
                FrmImpresion.ReportViewer1.Hide()
                FrmImpresion.ReportViewer3.Hide()
                FrmImpresion.ReportViewer4.Hide()
            Else
                FrmImpresion.ReportViewer1.Hide()
                FrmImpresion.ReportViewer2.Hide()
                FrmImpresion.ReportViewer3.Hide()
                FrmImpresion.ReportViewer4.Show()
            End If
        End If
    End Sub
    Private Sub id_combo()
        Dim b As New BaseDatos
        b.abrirConexion()
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
    Private Sub cmbSemestre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSemestre.SelectedIndexChanged
        CmbMaterias.Items.Clear()
        CmbMaterias.Text = ""
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged, CmbMaterias.Click
        If chk1.Checked = True Then
            CmbMaterias.Text = ""
            CmbDocentes.Text = ""
            gp1.Enabled = False
        Else
            gp1.Enabled = True
        End If
    End Sub

    Private Sub CmbMaterias_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbMaterias.SelectedIndexChanged

    End Sub

    Private Sub CmbMaterias_DropDown(sender As System.Object, e As System.EventArgs) Handles CmbMaterias.DropDown
        Dim msg As String = ""
        Dim idlicen As String = ""
        Dim b As New BaseDatos
        CmbMaterias.Items.Clear()
        If cmbLicenciatura.Text = "" Then msg = "Licenciatura"
        If cmbSemestre.Text = "" Then msg = "Semestre"
        If msg <> "" Then
            MsgBox("Falta seleccionar el campo" & " " & msg)
        Else
            idlicen = model.getidlicenciatura(cmbLicenciatura.Text)
            Dim Materias As List(Of String) = model.getMaterias(cmbSemestre.Text, idlicen)
            '   CmbMaterias.Items.Add("")
            For Each L As String In Materias
                CmbMaterias.Items.Add(L)
            Next
        End If
    End Sub
End Class
