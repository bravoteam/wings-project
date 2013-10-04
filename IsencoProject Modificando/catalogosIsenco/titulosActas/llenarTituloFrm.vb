Imports System.Data.SqlClient

Public Class llenarTituloFrm

    Private Sub GuardarEImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarEImprimirToolStripMenuItem.Click
        variables.conexion.abrirConexion()
        variables.idalumno = Val(lblActaID.Text)
        variables.sql = "UPDATE examen_profesional set numero_titulo=@numero_titulo,planest=@planest,generacion=@generacion,anio_egreso=@anio_egreso," & _
                "registro=@registro,libronum=@libronum,fojanum=@fojanum,fecha_expedicion=@fecha_expedicion,fecha_subdireccion=@fecha_subdireccion," & _
                "gobernador=@gobernador,secretario_educacion=@secretario_educacion where id=@id"
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        With cmd
            .Parameters.AddWithValue("@numero_titulo", txt_tituloNum.Text)
            .Parameters.AddWithValue("@planest", txt_plan.Text)
            .Parameters.AddWithValue("@generacion", txt_generacion.Text)
            .Parameters.AddWithValue("@anio_egreso", txtAñoEgreso.Text)
            .Parameters.AddWithValue("@registro", txt_Registro.Text)
            .Parameters.AddWithValue("@libronum", txt_libro_num.Text)
            .Parameters.AddWithValue("@fojanum", txt_foja.Text)
            .Parameters.AddWithValue("@fecha_expedicion", dtpExpedicion.Value.Date)
            .Parameters.AddWithValue("@fecha_subdireccion", dtpGestion.Value.Date)
            .Parameters.AddWithValue("@gobernador", txtGobernador.Text)
            .Parameters.AddWithValue("@secretario_educacion", txtSecretario.Text)
            .Parameters.AddWithValue("@id", variables.idExamen)
        End With

        cmd.ExecuteNonQuery()
        MsgBox("REGISTRO ALMACENADO CORRECTAMENTE")
        variables.conexion.cerrarConexion()
        imprimirTitulo.Show()
    End Sub

    Private Sub llenarTituloFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class