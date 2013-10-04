Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos
Imports System.Data.SqlClient

Public Class llenarActaExamen

    Private Sub llenarActaExamen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        ds = getAcuerdosJurado()
        loadComboBox(ds, cmbAcuerdo, "id", "descripcion")
    End Sub

    Private Sub consultarcmdP_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmdP.Click
        frmBuscarAlumno.Text = "Busqueda X Presidente"
        variables.banderaAccion = "actaP"
        frmBuscarAlumno.txtBuscar.Focus()
        frmBuscarAlumno.ShowDialog()
    End Sub

    Private Sub consultarcmdS_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmdS.Click
        frmBuscarAlumno.Text = "Busqueda X Secretario"
        variables.banderaAccion = "actaS"
        frmBuscarAlumno.txtBuscar.Focus()
        frmBuscarAlumno.ShowDialog()
    End Sub

    Private Sub consultarcmdV_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmdV.Click
        frmBuscarAlumno.Text = "Busqueda X Vocal"
        variables.banderaAccion = "actaV"
        frmBuscarAlumno.txtBuscar.Focus()
        frmBuscarAlumno.ShowDialog()
    End Sub

    Private Sub GuardarEImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarEImprimirToolStripMenuItem.Click
        variables.conexion.abrirConexion()
        variables.idalumno = Val(lblActaID.Text)
        If variables.idalumno > 0 Then
            variables.sql = "UPDATE examen_profesional set autorizacion=@autorizacion,idalumno=@idalumno,nombre_completo=@nombre_completo,licenciatura=@licenciatura," & _
                "titulo_tesis=@titulo_tesis,presidente=@presidente,secretario=@secretario,vocal=@vocal,lugar_aplicacion=@lugar_aplicacion," & _
                "municipio=@municipio,hora=@hora,fecha_examen=@fecha_examen,director_plantel=@director_plantel,control_escolar=@control_escolar," & _
                "registrado_confrontado=@registrado_confrontado,resultado_examen=@resultado_examen,fecha_confrontado=@fecha_confrontado where id=@id"
        Else
            variables.sql = "insert into examen_profesional(autorizacion,idalumno,nombre_completo,licenciatura,titulo_tesis,presidente,secretario,vocal," & _
                "lugar_aplicacion,municipio,hora,fecha_examen,director_plantel,control_escolar,registrado_confrontado,resultado_examen,fecha_confrontado)" & _
                         "values (@autorizacion,@idalumno,@nombre_completo,@licenciatura,@titulo_tesis,@presidente,@secretario,@vocal," & _
                "@lugar_aplicacion,@municipio,@hora,@fecha_examen,@director_plantel,@control_escolar,@registrado_confrontado,@resultado_examen,@fecha_confrontado)"
        End If
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        With cmd
            .Parameters.AddWithValue("@autorizacion", txtAutorizacion.Text)
            .Parameters.AddWithValue("@idalumno", Val(txtIdAlumno.Text))
            .Parameters.AddWithValue("@nombre_completo", txtNombre.Text)
            .Parameters.AddWithValue("@licenciatura", txtLicenciatura.Text)
            .Parameters.AddWithValue("@titulo_tesis", txtNombre_Documento.Text)
            .Parameters.AddWithValue("@presidente", txtPresidente.Text)
            .Parameters.AddWithValue("@secretario", txtSecretario.Text)
            .Parameters.AddWithValue("@vocal", txtVocal.Text)
            .Parameters.AddWithValue("@lugar_aplicacion", cmbAula.Text)
            .Parameters.AddWithValue("@municipio", cmbLugar.Text)
            .Parameters.AddWithValue("@hora", dtpHora.Value)
            .Parameters.AddWithValue("@fecha_examen", dtpFecha.Value.Date)
            .Parameters.AddWithValue("@director_plantel", txtDirector.Text)
            .Parameters.AddWithValue("@control_escolar", txtGestion.Text)
            .Parameters.AddWithValue("@registrado_confrontado", txtConfrontado.Text)
            .Parameters.AddWithValue("@resultado_examen", cmbAcuerdo.Text)
            .Parameters.AddWithValue("@fecha_confrontado", dtpFc.Value.Date)
            .Parameters.AddWithValue("@id", variables.idExamen)
        End With

        cmd.ExecuteNonQuery()
        MsgBox("REGISTRO ALMACENADO CORRECTAMENTE")
        variables.conexion.cerrarConexion()
        If variables.idExamen = 0 Then
            traerUltimoRegistro()
        End If
        imprimirActaExamen.Show()
    End Sub
    Private Sub traerUltimoRegistro()

        variables.conexion.abrirConexion()
        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.sql = "Select max(id) AS TOT from examen_profesional"
        cmd = New SqlCommand(variables.sql, variables.conexion.Conexion)
        variables.SQLdr = cmd.ExecuteReader()
        variables.idExamen = 0
        While variables.SQLdr.Read() 'While Data is Present
            variables.idExamen = variables.SQLdr("TOT")
            lblActaID.Text = variables.idExamen
        End While
        variables.SQLdr.Close()
        variables.conexion.cerrarConexion()
    End Sub
End Class