Imports datosCompartidos.Datos

Namespace Modelos_

    Public Class Busqueda
        Public Property IdBusqueda As Integer
        Public Property Titulo As String
        Public Property Tipo As String
        Public Property Sentencia As String
        Public Property Formulario
        Public Property Control As String

        Public Sub New(ByVal idbusqueda As Integer, ByVal titulo As String, ByVal tipo As String, ByVal sentencia As String, ByVal formulario As String, ByVal control As String)
            Me.IdBusqueda = idbusqueda
            Me.Titulo = titulo
            Me.Tipo = tipo
            Me.Sentencia = sentencia
            Me.Formulario = formulario
            Me.Control = control
        End Sub

    End Class

    Public Class Buscar

        Public Function getBusquedaDatos(ByVal IdBusqueda As Integer) As Busqueda
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String = ""
            Dim BusquedaDatos As Busqueda = Nothing

            b.abrirConexion()

            sql = "select id_busqueda, titulo, tipo, sentencia, formulario, control " & _
                "from busquedas where id_busqueda = " & IdBusqueda & ";"

            ds = b.getDataSet(sql)

            If ds.Tables(0).Rows.Count > 0 Then
                For Each f As DataRow In ds.Tables(0).Rows
                    BusquedaDatos = New Busqueda(
                        Integer.Parse(f("id_busqueda").ToString),
                        f("titulo").ToString,
                        f("tipo").ToString,
                        f("sentencia").ToString,
                        f("formulario").ToString,
                        f("control").ToString)
                Next
            End If

            b.cerrarConexion()

            Return BusquedaDatos

        End Function

        Public Sub getBusquedaResultados(ByVal SentenciaSQL As String, ByVal ParametroBuscar As String)
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim dr As Data.SqlClient.SqlDataReader = Nothing
            Dim CantidadCampos As Integer = 0
            Dim i As Integer = 0
            Dim j As Integer = 0

            frmBuscarAlumno.Grid.Rows.Clear()

            SentenciaSQL = SentenciaSQL.Replace("{BUSCAR}", ParametroBuscar)

            b.abrirConexion()

            b.loadDataReader(SentenciaSQL, dr)

            'generar encabezados en el grid
            CantidadCampos = dr.FieldCount - 1
            For i = 0 To CantidadCampos
                frmBuscarAlumno.Grid.Columns.Add(dr.GetName(i).ToString.ToUpper, dr.GetName(i).ToString.ToUpper)
            Next

            dr.Close()
            dr = Nothing

            ds = b.getDataSet(SentenciaSQL)

            If ds.Tables(0).Rows.Count > 0 Then
                i = 0
                frmBuscarAlumno.Grid.Rows.Add(ds.Tables(0).Rows.Count)
                For Each f As DataRow In ds.Tables(0).Rows
                    For Each c As DataColumn In ds.Tables(0).Columns
                        'campos_regreso
                        frmBuscarAlumno.Grid(j, i).Value = f(c).ToString
                        j += 1
                        If j > CantidadCampos Then j = 0
                    Next
                    i += 1
                Next
            End If

            'ocultar columna de campos regreso
            frmBuscarAlumno.Grid.Columns(CantidadCampos).Visible = False

            b.cerrarConexion()

        End Sub

    End Class

End Namespace