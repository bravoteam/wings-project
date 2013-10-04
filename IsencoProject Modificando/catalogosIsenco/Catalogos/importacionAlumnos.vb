Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class importacionAlumnos

    Public connectionStringTemplate As String = _
    "Provider=Microsoft.ACE.OLEDB.12.0;" + _
    "Data Source={0};" + _
    "Extended Properties=""Excel 12.0;HDR=Yes;IMEX=1"""
    Public worksheet As DataTable
    Public workbook As DataSet = New DataSet()
    Private Sub consultarcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarcmd.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xlsx)|*.xlsx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextPathExcel.Text = .FileName
            End If
        End With
    End Sub

    Private Sub exportarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cargarCmd.Click
        Dim XLSPathx As String = TextPathExcel.Text
        Dim XLSPath As String = TextPathExcel.Text
        Dim connectionString As String = String.Format(connectionStringTemplate, XLSPath)
        Dim sqlSelect As String = "SELECT * FROM [" + txtHoja.Text + "$] ;"
        ' Load the Excel worksheet into a DataTable

        Dim excelAdapter As System.Data.Common.DataAdapter = New System.Data.OleDb.OleDbDataAdapter(sqlSelect, connectionString)
        Try
            excelAdapter.Fill(workbook)
            worksheet = workbook.Tables(0)
            Grid.DataSource = worksheet
            dglabelCount.Text = "Total de Registros: " & Grid.RowCount
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub importarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles importarCmd.Click
        Try
            Dim mensaje As String = MsgBox("Deseas Importar la Informacion", vbYesNo)
            If mensaje = vbYes Then
                importarInformacion()
                MsgBox("Transaccion Completada!!")
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub
    Private Sub importarInformacion()
        variables.conexion.abrirConexion()
        Dim sql As String
        For i = 0 To Grid.RowCount - 1

            If Grid.Item(9, i).Value.ToString = "PROMOVIDO" Then
                'sql = "UPDATE alumno set IDSEMESTRE='" & vaS & "', IDSTATUS='" & Grid.Item(9, i).Value.ToString & "' where (matricula='" & Grid.Item(0, i).Value.ToString & "') "
            Else
                sql = "UPDATE alumno set IDSTATUS='" & Grid.Item(9, i).Value.ToString & "' where (matricula='" & Grid.Item(0, i).Value.ToString & "') "
            End If

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            cmd.ExecuteNonQuery()
        Next
        variables.conexion.cerrarConexion()
    End Sub
End Class