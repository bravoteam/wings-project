Imports datosCompartidos
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class ImprimirListasFrm
    Private Sub ImprimirListasFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_information()

    End Sub
    Private Sub load_information()
        Dim ds As DataSet
        ds = getAulas(1)
        loadComboBox(ds, cmbAulas, "id", "ubicacion")
    End Sub
    Private Sub actualizarReporte()
        Dim parameters = New ReportParameter
        If grid.RowCount >= 1 Then
            If cmbTurno.Text = "Turno 2" Then
                parameters = New ReportParameter("turno", "11:00")
            Else
                parameters = New ReportParameter("turno", "08:00")
            End If
            

            Me.ReportViewer2.LocalReport.SetParameters(parameters)

            'Me.PreregistroTableAdapter.Fill(Me.isencoDataSet.preregistro, cmbAulas.Text, cmbTurno.Text)
            'TODO: This line of code loads data into the 'isencoDataSet.Preregistro1' table. You can move, or remove it, as needed.
            Me.PreregistroTableAdapter.Fill(Me.IsencoDataSet.preregistro, cmbAulas.Text, cmbTurno.Text)
            ReportViewer2.RefreshReport()
            ReportViewer1.RefreshReport()
        End If
    End Sub
    Private Sub consultarcmd_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmd.Click
        llenarGrid()
    End Sub
    Private Sub llenarGrid()
        Dim b As New BaseDatos
        Dim ds As New DataSet
        variables.sql = ""
        If chkTipo.Checked = True Then
            If rCeneval.Checked = True Then
                variables.sql = "select id,apellido_paterno,apellido_materno,nombre,folio_isenco as folio, aula,aulaCeneval from preregistro " & _
          "where aulaCeneval = '" & cmbAulas.Text & "' and validado = 1 order by apellido_paterno,apellido_materno,nombre"
            Else
                variables.sql = "select id,apellido_paterno,apellido_materno,nombre,folio_isenco as folio, aula,aulaCeneval from preregistro " & _
          "where turno = '" & cmbTurno.Text & "' and aula = '" & cmbAulas.Text & "' and validado = 1 order by apellido_paterno,apellido_materno,nombre"
            End If
        Else
            If rCeneval.Checked = True Then
                variables.sql = "select id,apellido_paterno,apellido_materno,nombre,folio_isenco as folio, aula,aulaCeneval from preregistro " & _
          "where aulaCeneval = '" & cmbAulas.Text & "' order by apellido_paterno,apellido_materno,nombre"
            Else
                variables.sql = "select id,apellido_paterno,apellido_materno,nombre,folio_isenco as folio, aula,aulaCeneval from preregistro " & _
          "where turno = '" & cmbTurno.Text & "' and aula = '" & cmbAulas.Text & "' order by apellido_paterno,apellido_materno,nombre"
            End If
            
        End If
        b.abrirConexion()
        ds = b.getDataSet(variables.sql)
        grid.DataSource = ds.Tables(0)
        StatusStrip1.Items(1).Text = grid.RowCount
        grid.AutoResizeColumns()
        b.cerrarConexion()
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub PDF()
        Dim deviceInfo As String
        'Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim reporte As String
        Dim bytes As Byte()

        deviceInfo = "<DeviceInfo>" +
        "<OutputFormat>PDF</OutputFormat>" +
        "  <PageWidth>35.56cm</PageWidth>" +
        "  <PageHeight>21.59cm</PageHeight>" +
        "  <MarginTop>0cm</MarginTop>" +
        "  <MarginLeft>0cm</MarginLeft>" +
        "  <MarginRight>0cm</MarginRight>" +
        "  <MarginBottom>0cm</MarginBottom>" +
        "</DeviceInfo>"
        Try


            reporte = "ListasPreregistroCen.rdlc"
            bytes = ReportViewer2.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer2.LocalReport.ReportPath = reporte


            Dim fs As New FileStream("C:\ISENCO\" & cmbAulas.Text & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\" & cmbAulas.Text & ".pdf")


            reporte = "ListasPreregistro.rdlc"
            bytes = ReportViewer1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            ReportViewer1.LocalReport.ReportPath = reporte


            fs = New FileStream("C:\ISENCO\P" & cmbAulas.Text & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("C:\ISENCO\P" & cmbAulas.Text & ".pdf")

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

    Private Sub AsignarGruposToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarGruposToolStripMenuItem.Click
        If grid.RowCount > 0 Then
            PDF()
        Else
            MsgBox("NO SE PUEDE GENERAR REPORTE PORQUE AUN NO SE HA HECHO UNA CONSULTA", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    
    Private Sub rContexto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rContexto.CheckedChanged
        If rContexto.Checked = True Then
            cmbTurno.Enabled = True
            Dim ds As DataSet
            ds = getAulas(1)
            loadComboBox(ds, cmbAulas, "id", "ubicacion")
        End If
    End Sub

    Private Sub rCeneval_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rCeneval.CheckedChanged
        If rCeneval.Checked = True Then
            cmbTurno.Enabled = False
            Dim ds As DataSet
            ds = getAulas(2)
            loadComboBox(ds, cmbAulas, "id", "ubicacion")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        actualizarReporte()
    End Sub
End Class