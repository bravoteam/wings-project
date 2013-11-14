Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos

Public Class principalOtrosRpt
    Private model As New datosCompartidos.Modelos.AlumnosModel
    Private Sub cargarCombos()
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
        ds = getparciales()
        loadComboBox(ds, CmbParcial, "idparcial", "descripcion")
        ds = getMaestros()
        loadComboBox(ds, CmbDocentes, "idmaestro", "nombreS")

        cmbCampus.Text = ""
        cmbLicenciatura.Text = ""
        cmbEspecialidad.Text = ""
        CmbParcial.Text = ""
        CmbDocentes.Text = ""
    End Sub

    Private Sub consultarcmd_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmd.Click
        Dim forma As Form
        forma = culturalesNoACFrm
        If CmbtipoReporte.Text = "" Then
            MsgBox("Favor de Seleccionar el tipo de reporte", MsgBoxStyle.Critical, "ERROR")
            CmbtipoReporte.Focus()
            Exit Sub
        End If
        Select Case CmbtipoReporte.Text
            Case "PRIMERA PARCIAL"
                forma = primeraSegundaFrm
                variables.reporte = 1
                forma.Text = "Reporte de Primera Parcial"
                primeraSegundaFrm.actualizarReporte()
                primeraSegundaFrm.ReportViewer1.Visible = False
                primeraSegundaFrm.ReportViewer2.Visible = True
                primeraSegundaFrm.ReportViewer3.Visible = False
                primeraSegundaFrm.actualizarReporte()
                primeraSegundaFrm.Show()
            Case "SEGUNDA PARCIAL"
                forma = primeraSegundaFrm
                variables.reporte = 2
                forma.Text = "Reporte de Segunda Parcial"
                primeraSegundaFrm.actualizarReporte()
                primeraSegundaFrm.ReportViewer1.Visible = False
                primeraSegundaFrm.ReportViewer2.Visible = False
                primeraSegundaFrm.ReportViewer3.Visible = True
                primeraSegundaFrm.actualizarReporte()
                primeraSegundaFrm.Show()
            Case "PRIMERA Y SEGUNDA PARCIAL"
                forma = primeraSegundaFrm
                variables.reporte = 3
                forma.Text = "Reporte de Primera y Segunda Parcial"
                primeraSegundaFrm.actualizarReporte()
                primeraSegundaFrm.ReportViewer2.Visible = False
                primeraSegundaFrm.ReportViewer1.Visible = True
                primeraSegundaFrm.ReportViewer3.Visible = False
                primeraSegundaFrm.actualizarReporte()
                primeraSegundaFrm.Show()
            Case "PRIMERA OPORTUNIDAD REGULARIZACIÓN"

            Case "SEGUNDA OPORTUNIDAD REGULARIZACIÓN"

            Case "TERCERA OPORTUNIDAD REGULARIZACIÓN"

            Case "ACREDITADOS X OPORTUNIDAD"

            Case "NO ACREDITADOS X MATERIA"
                forma = culturalesNoACFrm
                culturalesNoACFrm.actualizarReporte()
                forma.Show()
            Case ("NO ACREDITADOS - ACT. CULT. Y DEP.")
                forma = culturalesNoACFrm
                culturalesNoACFrm.actualizarReporte()
                forma.Show()
            Case "PROMEDIO X MATERIAS"
            Case "LISTA DE ASISTENCIA"
                panelLista.Visible = True
                CmbParcial.Text = ""
                CmbDocentes.Text = ""
                CmbMaterias.Text = ""
            Case "LISTA DE CONCENTRADO DE CALIFICACIONES"
                panelLista.Visible = False
                CmbParcial.Text = ""
                CmbDocentes.Text = ""
                CmbMaterias.Text = ""
                ImpresionConcentradoCalif.actualizar_reporte()
                ImpresionConcentradoCalif.Show()
        End Select

    End Sub


    Private Sub principalOtrosRpt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarCombos()
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
            For Each L As String In Materias
                CmbMaterias.Items.Add(L)
            Next
        End If
    End Sub

    Private Sub chk1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            CmbMaterias.Text = ""
            CmbDocentes.Text = ""
            gp1.Enabled = False
        Else
            gp1.Enabled = True
        End If
    End Sub

    Private Sub cmdContinuar_Click(sender As System.Object, e As System.EventArgs) Handles cmdContinuar.Click
        If CmbMaterias.Text = "" And CmbDocentes.Text = "" Then
            SD = 1
        Else
            SD = 0
        End If
        If CmbParcial.Text = "PRIMERA PARCIAL" Then
            impresionListas.actualizarReporte()
            impresionListas.Show()
            If SD = 0 Then
                impresionListas.ReportViewer1.Show()
                impresionListas.ReportViewer2.Hide()
                impresionListas.ReportViewer3.Hide()
                impresionListas.ReportViewer4.Hide()
            Else
                impresionListas.ReportViewer1.Hide()
                impresionListas.ReportViewer2.Hide()
                impresionListas.ReportViewer3.Show()
                impresionListas.ReportViewer4.Hide()
            End If
        Else
            impresionListas.actualizarReporte()
            impresionListas.Show()
            If SD = 0 Then
                impresionListas.ReportViewer2.Show()
                impresionListas.ReportViewer1.Hide()
                impresionListas.ReportViewer3.Hide()
                impresionListas.ReportViewer4.Hide()
            Else
                impresionListas.ReportViewer1.Hide()
                impresionListas.ReportViewer2.Hide()
                impresionListas.ReportViewer3.Hide()
                impresionListas.ReportViewer4.Show()
            End If
        End If
        
    End Sub

    Private Sub CmbtipoReporte_DropDown(sender As System.Object, e As System.EventArgs) Handles CmbtipoReporte.DropDown
        panelLista.Visible = False
    End Sub

    Private Sub cmbModalidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbModalidad.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
End Class