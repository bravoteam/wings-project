Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports datosCompartidos.funciones
Public Class FrmConfiguration2

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub FrmConfiguration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds, ds1, ds2, ds3, ds4, ds5 As New DataSet
        ds = getpersonal()
        loadComboBox(ds, cmbdirectivo1, "id", "nombre")
        ds1 = getpersonal()
        loadComboBox(ds1, cmbresponsable1, "id", "nombre")
        ds2 = getpersonal()
        loadComboBox(ds2, cmbdirectivo2, "id", "nombre")
        ds3 = getpersonal()
        loadComboBox(ds3, cmbresponsable2, "id", "nombre")
        ds4 = getpersonal()
        loadComboBox(ds4, cmbdirectivo3, "id", "nombre")
        ds5 = getpersonal()
        loadComboBox(ds5, cmbresponsable3, "id", "nombre")
        load_information()
    End Sub
    Private Sub load_information()
        Try
            'agregue la variable existe_registro en variables
            variables.existe_registro = False
            variables.conexion.abrirConexion()
            variables.sql = "select Director1,Responsable1,Fecha1,Director2,Responsable2,Fecha2,Director3,Responsable3,Fecha3 from RegistroEscolar_config"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            If variables.SQLdr.HasRows Then
                variables.existe_registro = True
            Else
                variables.existe_registro = False
            End If
            If variables.existe_registro Then
                While variables.SQLdr.Read
                    txtdirectivo1.Text = variables.SQLdr("Director1").ToString
                    txtdirectivo2.Text = variables.SQLdr("Director2").ToString
                    txtdirectivo3.Text = variables.SQLdr("Director3").ToString
                    txtresponsable1.Text = variables.SQLdr("Responsable1").ToString
                    txtresponsable2.Text = variables.SQLdr("Responsable2").ToString
                    txtresponsable3.Text = variables.SQLdr("Responsable3").ToString
                    txtfecha1.Text = variables.SQLdr("Fecha1").ToString
                    txtfecha2.Text = variables.SQLdr("Fecha2").ToString
                    txtfecha3.Text = variables.SQLdr("Fecha3").ToString
                End While
            Else
                MsgBox("AUN NO SE HAN SELECCIONADO DATOS DE FIRMAS PARA EL REGISTRO DE ESCOLARIDAD" + Chr(13) + "Favor de Actualizar Datos", MsgBoxStyle.Information, "ALERTA!!!!")
            End If
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            Throw ex
        Finally
            variables.conexion.cerrarConexion()
        End Try

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim b As New BaseDatos
        Try
            b.abrirConexion()
            ' si existe registro solo actualizo datos
            If variables.existe_registro Then
                variables.sql = "UPDATE RegistroEscolar_Config SET Director1=@DIRECTOR1,Responsable1=@RESPONSABLE1,Fecha1=@FECHA1," & _
                                    "Director2=@DIRECTOR2,Responsable2=@RESPONSABLE2,Fecha2=@FECHA2," & _
                                    "Director3=@DIRECTOR3,Responsable3=@RESPONSABLE3,Fecha3=@FECHA3"
            Else ' sino existe registro entonces lo creo
                variables.sql = "INSERT INTO [ISENCO].[dbo].[RegistroEscolar_Config] ([Director1],[Responsable1],[Fecha1]," & _
                                "[Director2],[Responsable2],[Fecha2],[Director3],[Responsable3],[Fecha3])" & _
                                "VALUES(@DIRECTOR1,@RESPONSABLE1,@FECHA1,@DIRECTOR2,@RESPONSABLE2,@FECHA2," & _
                                "@DIRECTOR3,@RESPONSABLE3,@FECHA3)"
            End If
            Dim cmd As New SqlCommand(variables.sql, b.Conexion)
            With cmd
                .Parameters.AddWithValue("@DIRECTOR1", cmbdirectivo1.Text)
                .Parameters.AddWithValue("@RESPONSABLE1", cmbresponsable1.Text)
                .Parameters.AddWithValue("@FECHA1", dt1.Value)

                .Parameters.AddWithValue("@DIRECTOR2", cmbdirectivo2.Text)
                .Parameters.AddWithValue("@RESPONSABLE2", cmbresponsable2.Text)
                .Parameters.AddWithValue("@FECHA2", Dt2.Value)

                .Parameters.AddWithValue("@DIRECTOR3", cmbdirectivo3.Text)
                .Parameters.AddWithValue("@RESPONSABLE3", cmbresponsable3.Text)
                .Parameters.AddWithValue("@FECHA3", Dt3.Value)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("LOS DATOS HAN SIDO ACTUALIZADOS!!!!", MsgBoxStyle.Information, "REGISTRO ALMACENADO")
            b.cerrarConexion()
        Catch ex As Exception
            Throw ex
        End Try
        load_information() 'cargo los nuevos datos en el formulario
    End Sub
End Class