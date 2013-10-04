Imports System.Data.SqlClient
Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos

Public Class configuracionFrm
    Private Sub cargarCombos()
        Dim ds As New DataSet
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "IDLICENCIATURA", "licenciatura")
        ds = getEspecialidades()

        listaEspecialidades.DataSource = ds.Tables(0).Columns.Item(1)
        cmbLicenciatura.Text = ""
    End Sub
    Private Sub configuracionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        leerConexion()
        leerConfiguracion()
        cargarCombos()
    End Sub
    Private Sub leerConexion()
        funcionesLocales.leerXmlConfig(Me.txtServidor, Me.txtBd, Me.txtUser, Me.txtPass)
    End Sub
    Private Sub leerConfiguracion()
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from configuracion"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()
            While (variables.SQLdr.Read())
                txtanio.Text = variables.SQLdr("anioEscolar").ToString
                txtultimaMatL.Text = variables.SQLdr("ultimaMatriculaL").ToString
                txtUltimaMatB.Text = variables.SQLdr("ultimaMatriculaB").ToString
                dtRegConf.Value = variables.SQLdr("fechaRegConfronTit")
                dtpRegCert.Value = variables.SQLdr("fechaRegConfronCert")
                dtpExpCert.Value = variables.SQLdr("fechaExpCert")
            End While
            variables.conexion.cerrarConexion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Sub

    Private Sub salirCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirCmd.Click
        Me.Close()
        menuPrincipalFrm.Show()
    End Sub

    Private Sub guardarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarCmd.Click
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE configuracion set anioEscolar=@anioEscolar,ultimaMatriculaL=@ultimaMatriculaL, " & _
                "ultimaMatriculaB=@ultimaMatriculaB,fechaRegConfronTit=@fechaRegConfronTit," & _
                "fechaRegConfronCert=@fechaRegConfronCert,fechaExpCert=@fechaExpCert"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@anioEscolar", txtanio.Text)
                .Parameters.AddWithValue("@ultimaMatriculaL", txtultimaMatL.Text)
                .Parameters.AddWithValue("@ultimaMatriculaB", txtUltimaMatB.Text)
                .Parameters.AddWithValue("@fechaRegConfronTit", dtRegConf.Value.Date)
                .Parameters.AddWithValue("@fechaRegConfronCert", dtpRegCert.Value.Date)
                .Parameters.AddWithValue("@fechaExpCert", dtpExpCert.Value.Date)

            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
            leerConfiguracion()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class