Imports datosCompartidos.Datos
Imports System.Data.SqlClient

Module procedimientos
    Public Function NEncontrados(ByVal DondeBuscar As String, ByVal Buscado As String) As Integer
        Dim Encon As Integer
        Dim Busq As Integer
        Dim DondeHay As Integer
        Encon = 0
        For Busq = 1 To Len(DondeBuscar)
            DondeHay = InStr(Busq, DondeBuscar, Buscado)
            If Not DondeHay = 0 Then
                Encon = Encon + 1
                Busq = DondeHay
            End If
        Next
        NEncontrados = Encon
    End Function

    Public Function obtenerPromedio(ByVal matriculaVar As String) As String
        Dim promedio As Decimal = 0
        Dim promedioS As String
        Dim i As Integer = 0
        variables.conexion.abrirConexion()
        'SQLSTR = "SELECT ROUND(avg((CALIFICACION + calificacion2) / 2), 1, 1) AS promedio" & _
        '" FROM calificaciones WHERE  (Matricula = '" + matriculaVar + "') AND (IDMATERIA <> 1233) AND (IDMATERIA <> 1232)"

        'variables.sql = "SELECT ROUND(avg((CALIFICACION + calificacion2) / 2),1,1) AS promedio" & _
        '" FROM calificaciones WHERE  (Matricula = '" + matriculaVar + "') AND (IDMATERIA <> 1233) AND (IDMATERIA <> 1232)"
        variables.sql = "SELECT  " & _
                  "case when (calificacion+calificacion2)/2 < 6 then " & _
           "case when extra1>=6 and extra1<>13 and extra1<> 0 then extra1 " &
           "else " & _
           "case when extra2>=6 and extra2<>13 and extra2 <> 0 then extra2 " & _
            "else extra3 End " & _
            "End else avg((calificacion+calificacion2)/2) end as promedio " & _
            "FROM calificaciones where IDMATERIA<>1232 and IDMATERIA<>1233 and Matricula='" + matriculaVar + "' " & _
            "group by IDCALIFICACION,Matricula,IDSEMESTRE,IDLICENCIATURA,CALIFICACION,calificacion2,extra1,extra2,extra3,IDMATERIA "
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()

        While (variables.SQLdr.Read())
            promedio += variables.SQLdr("promedio")
            i += 1
        End While
        promedio = promedio / i
        promedioS = Mid(promedio, 1, 3)
        Return promedioS
    End Function
    Public Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount

            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol

                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value()

                Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function
End Module
