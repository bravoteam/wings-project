Imports System.IO
Imports datosCompartidos
Imports System.Data.SqlClient
Imports datosCompartidos.Datos
Imports datosCompartidos.funciones
Public Class tomarFotoFrm
    Dim webcam As New WebCam
    Private conf As New Configuracion
    Private model As New datosCompartidos.Modelos.AlumnosModel

    Private RutaServerFotos As String = ""
    Public Fotografia As String = ""
    Private Ext As String = ""
    Public FotografiaAnterior As String = ""
    Private FotoVacia As String = System.AppDomain.CurrentDomain.BaseDirectory + "nf.jpg"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        webcam.timer_tick(oFotografia)
    End Sub

    Private Sub btnBegin_Click(sender As System.Object, e As System.EventArgs) Handles btnBegin.Click
        webcam.Iniciar(Timer1, Me)
    End Sub

    Private Sub btnTake_Click(sender As System.Object, e As System.EventArgs) Handles btnTake.Click
        'webcam.Capturar(oFotografia)
        webcam.Detener(Timer1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim _modelo As New modelos.modeloAlumno
        _modelo.IDALUMNO = Val(txtidAlumno.Text)

        If IsNothing(oFotografia.Image) Then
            oFotografia.Image = Image.FromFile(FotoVacia)
            Fotografia = FotoVacia
            txtFotografia.Text = FotoVacia
        End If


        Dim ms As New System.IO.MemoryStream()
        oFotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        _modelo.FOTO = ms.GetBuffer()
        ' If funcionesLocales.validarReceptor(GroupBox1) = True Then
        If _modelo.IDALUMNO > 0 Then
            funcionesLocales.actualizarFoto(_modelo)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        frmBuscarAlumno.Text = "Busqueda X Alumno"
        variables.banderaAccion = "actualizaFoto"
        frmBuscarAlumno.Show()
    End Sub
End Class