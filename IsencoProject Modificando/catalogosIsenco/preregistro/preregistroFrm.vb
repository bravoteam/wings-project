Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports System.Data.SqlClient

Public Class preregistroFrm
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

    Private Sub preregistroFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarCombos()
    End Sub

    Private Sub consultarcmd_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmd.Click
        Dim b As New BaseDatos
        Dim ds As New DataSet
        variables.sql = "select * from preregistro where licenciatura like '%" & cmbLicenciatura.Text & "%' and campus like '%" & cmbCampus.Text & "%' " & _
            "order by campus,licenciatura,apellido_paterno,apellido_materno,nombre"
        b.abrirConexion()
        ds = b.getDataSet(variables.sql)
        grid.DataSource = ds.Tables(0)
        StatusStrip1.Items(1).Text = grid.RowCount
        b.cerrarConexion()
    End Sub

    Private Sub GenerarFolioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarFolioToolStripMenuItem.Click
        Dim cadena As String = ""
        Try

            For i = 0 To grid.RowCount - 1
                Select Case grid.Item("campus", i).Value.ToString
                    Case "CUAUHTÉMOC"
                        cadena = "1"
                    Case "TECOMÁN"
                        cadena = "2"
                    Case "MANZANILLO"
                        cadena = "3"
                    Case "COLIMA"
                        cadena = "4"
                End Select
                Select Case grid.Item("licenciatura", i).Value.ToString
                    Case "BACHILLERATO"
                        cadena = cadena & "0"
                    Case "LIC. EDUC.  PREESCOLAR"
                        cadena = cadena & "1"
                    Case "LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN BIOLOGÍA."
                        cadena = cadena & "2"
                    Case "LIC. EDUC. ESPECIAL ÁREA DE ATENCIÓN MOTRIZ"
                        cadena = cadena & "3"
                    Case "LIC. EDUC. SECUNDARIA CON ESPECIALIDAD EN INGLÉS"
                        cadena = cadena & "4"
                    Case "LIC. EDUC. PRIMARIA"
                        cadena = cadena & "5"
                End Select
                cadena = cadena & Format(grid.Item("id", i).Value, "0000")
                grid("folio_isenco", i).Value = cadena
                cadena = ""
            Next i
        Catch ex As Exception
            MsgBox(ex, vbCritical)
            Exit Sub
        End Try
    End Sub

    Private Sub GuardarDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarDatosToolStripMenuItem.Click
        Try
            variables.mensajeAS = MsgBox("Deseas Actualizar los folios?", MsgBoxStyle.YesNo)
            If variables.mensajeAS = vbYes Then
                If generarFolios() Then
                    MsgBox("Actualizacion Exitosa!!", MsgBoxStyle.Information)
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Function generarFolios() As Boolean
        Try
            Dim cad As String = ""
            variables.conexion.abrirConexion()
            Dim sql As String
            For i = 0 To grid.RowCount - 1
                cad = grid.Item("folio_isenco", i).Value.ToString
                If cad = "" Then
                    MsgBox("Error Genere los Folios", vbCritical)
                    Return False
                    Exit Function
                End If
                sql = "UPDATE preregistro set folio_isenco=" & grid.Item("folio_isenco", i).Value.ToString & " " & _
                      "WHERE (id=" & CDbl(grid.Item(0, i).Value.ToString) & ") "
                Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
                cmd.ExecuteNonQuery()
            Next
            variables.conexion.cerrarConexion()
            Return True
        Catch
            MsgBox("Error Actualizando Verifique")
            Return False
            Exit Function
        End Try
    End Function
End Class