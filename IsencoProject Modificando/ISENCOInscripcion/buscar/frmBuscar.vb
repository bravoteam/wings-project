Imports ISENCOInscripcion.Modelos
Imports ISENCOInscripcion.Datos

Public Class frmBuscar

    Private Model As New Buscar
    Private Busqueda As Busqueda
    Private BD As New BaseDatos

#Region "-------->> MyCode <<----------"

    Private Sub Buscar(ByVal ParametroBuscar)
        If ParametroBuscar.Length > 0 And ParametroBuscar.Trim().Length > 0 Then

            Grid.Visible = False

            'limpiar grid
            Grid.Columns.Clear()
            Grid.Rows.Clear()

            ParametroBuscar = BD.SafeSqlLiteral(ParametroBuscar)

            'obtener resultados
            Model.getBusquedaResultados(Busqueda.Sentencia, ParametroBuscar)

            Grid.Visible = True

        End If
    End Sub

    Private Sub getRegistro(ByVal Fila As Long)
        Dim CamposRegreso As String
        Dim Formulario As Form
        Dim CuadroTexto As TextBox

        Formulario = Application.OpenForms(Busqueda.Formulario.ToString)
        CuadroTexto = Formulario.Controls(Busqueda.Control.ToString)
        CamposRegreso = Grid.Rows(Fila).Cells("CAMPOS_REGRESO").Value.ToString
        CuadroTexto.Text = CamposRegreso
        Formulario.Focus()

        Me.Close()
    End Sub

#End Region

    Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Busqueda = Model.getBusquedaDatos(Integer.Parse(txtIdBusqueda.Text))

        'cambiar el título a la ventana
        Me.Text = Busqueda.Titulo
        txtBuscar.Text = ""
        Grid.Columns.Clear()
        Grid.Rows.Clear()

    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar(txtBuscar.Text)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Buscar(txtBuscar.Text)

    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Dim Fila As DataGridViewRow
        If Grid.Rows.Count > 0 Then
            Fila = Grid.CurrentRow
            getRegistro(Fila.Index)
        End If
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class