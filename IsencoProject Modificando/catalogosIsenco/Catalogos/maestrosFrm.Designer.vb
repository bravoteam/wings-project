<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maestrosFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtidMaestro = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumExt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.oFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCURP = New System.Windows.Forms.TextBox()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.oFechaEgreso = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.oFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTipoSangre = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTelefonoEmergencia = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtContactoEmergencia = New System.Windows.Forms.TextBox()
        Me.guardarCmd = New System.Windows.Forms.Button()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.nuevoCmd = New System.Windows.Forms.Button()
        Me.eliminarCmd = New System.Windows.Forms.Button()
        Me.salirCmd = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.Tab3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab1)
        Me.TabControl1.Controls.Add(Me.Tab2)
        Me.TabControl1.Controls.Add(Me.Tab3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 384)
        Me.TabControl1.TabIndex = 17
        '
        'Tab1
        '
        Me.Tab1.BackColor = System.Drawing.Color.Transparent
        Me.Tab1.Controls.Add(Me.Label38)
        Me.Tab1.Controls.Add(Me.txtidMaestro)
        Me.Tab1.Controls.Add(Me.txtMunicipio)
        Me.Tab1.Controls.Add(Me.Label15)
        Me.Tab1.Controls.Add(Me.txtEmail)
        Me.Tab1.Controls.Add(Me.Label13)
        Me.Tab1.Controls.Add(Me.txtCelular)
        Me.Tab1.Controls.Add(Me.Label14)
        Me.Tab1.Controls.Add(Me.txtTelefono)
        Me.Tab1.Controls.Add(Me.Label11)
        Me.Tab1.Controls.Add(Me.txtCP)
        Me.Tab1.Controls.Add(Me.cmbEstado)
        Me.Tab1.Controls.Add(Me.Label10)
        Me.Tab1.Controls.Add(Me.Label5)
        Me.Tab1.Controls.Add(Me.Label6)
        Me.Tab1.Controls.Add(Me.txtColonia)
        Me.Tab1.Controls.Add(Me.Label7)
        Me.Tab1.Controls.Add(Me.txtNumExt)
        Me.Tab1.Controls.Add(Me.Label8)
        Me.Tab1.Controls.Add(Me.txtCalle)
        Me.Tab1.Controls.Add(Me.txtNombre)
        Me.Tab1.Controls.Add(Me.Label1)
        Me.Tab1.Controls.Add(Me.Label16)
        Me.Tab1.Controls.Add(Me.oFechaNacimiento)
        Me.Tab1.Controls.Add(Me.txtApellidoPaterno)
        Me.Tab1.Controls.Add(Me.Label2)
        Me.Tab1.Controls.Add(Me.txtApellidoMaterno)
        Me.Tab1.Controls.Add(Me.Label3)
        Me.Tab1.Controls.Add(Me.Label12)
        Me.Tab1.Controls.Add(Me.txtCURP)
        Me.Tab1.Location = New System.Drawing.Point(4, 24)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Tab1.Size = New System.Drawing.Size(892, 356)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Datos Personales"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(690, 207)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 15)
        Me.Label38.TabIndex = 51
        Me.Label38.Text = "ID :"
        '
        'txtidMaestro
        '
        Me.txtidMaestro.Enabled = False
        Me.txtidMaestro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidMaestro.Location = New System.Drawing.Point(693, 223)
        Me.txtidMaestro.Name = "txtidMaestro"
        Me.txtidMaestro.Size = New System.Drawing.Size(100, 21)
        Me.txtidMaestro.TabIndex = 52
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(230, 125)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(204, 21)
        Me.txtMunicipio.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(438, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(165, 15)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "CORREO ELECTRÓNICO"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(441, 174)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(352, 21)
        Me.txtEmail.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(234, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "CELULAR"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(230, 225)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(204, 21)
        Me.txtCelular.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 209)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "TELEFONO"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(10, 225)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(205, 21)
        Me.txtTelefono.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(438, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 15)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "CODIGO POSTAL"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(441, 125)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(97, 21)
        Me.txtCP.TabIndex = 9
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(10, 125)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(205, 23)
        Me.cmbEstado.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "ESTADO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "MUNICIPIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(437, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "COLONIA"
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(440, 74)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(353, 21)
        Me.txtColonia.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "NUM EXTERIOR"
        '
        'txtNumExt
        '
        Me.txtNumExt.Location = New System.Drawing.Point(341, 74)
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(93, 21)
        Me.txtNumExt.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 15)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "CALLE/AVENIDA"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(10, 74)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(320, 21)
        Me.txtCalle.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(272, 21)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NOMBRE (S)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(544, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(162, 15)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "FECHA DE NACIMIENTO"
        '
        'oFechaNacimiento
        '
        Me.oFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.oFechaNacimiento.Location = New System.Drawing.Point(547, 125)
        Me.oFechaNacimiento.Name = "oFechaNacimiento"
        Me.oFechaNacimiento.Size = New System.Drawing.Size(246, 21)
        Me.oFechaNacimiento.TabIndex = 10
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(290, 27)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(242, 21)
        Me.txtApellidoPaterno.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "APELLIDO PATERNO"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(541, 27)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(252, 21)
        Me.txtApellidoMaterno.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(538, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "APELLIDO MATERNO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "CURP"
        '
        'txtCURP
        '
        Me.txtCURP.Location = New System.Drawing.Point(12, 174)
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.Size = New System.Drawing.Size(422, 21)
        Me.txtCURP.TabIndex = 11
        '
        'Tab2
        '
        Me.Tab2.BackColor = System.Drawing.Color.Transparent
        Me.Tab2.Controls.Add(Me.chkActivo)
        Me.Tab2.Controls.Add(Me.Label35)
        Me.Tab2.Controls.Add(Me.oFechaEgreso)
        Me.Tab2.Controls.Add(Me.Label34)
        Me.Tab2.Controls.Add(Me.oFechaIngreso)
        Me.Tab2.Location = New System.Drawing.Point(4, 24)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Tab2.Size = New System.Drawing.Size(892, 356)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Datos Escolares"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(9, 67)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(155, 19)
        Me.chkActivo.TabIndex = 56
        Me.chkActivo.Text = "   MAESTRO ACTIVO"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(217, 11)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(135, 15)
        Me.Label35.TabIndex = 63
        Me.Label35.Text = "FECHA DE EGRESO"
        '
        'oFechaEgreso
        '
        Me.oFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.oFechaEgreso.Location = New System.Drawing.Point(220, 27)
        Me.oFechaEgreso.Name = "oFechaEgreso"
        Me.oFechaEgreso.Size = New System.Drawing.Size(179, 21)
        Me.oFechaEgreso.TabIndex = 54
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 11)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(140, 15)
        Me.Label34.TabIndex = 62
        Me.Label34.Text = "FECHA DE INGRESO"
        '
        'oFechaIngreso
        '
        Me.oFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.oFechaIngreso.Location = New System.Drawing.Point(9, 27)
        Me.oFechaIngreso.Name = "oFechaIngreso"
        Me.oFechaIngreso.Size = New System.Drawing.Size(179, 21)
        Me.oFechaIngreso.TabIndex = 53
        '
        'Tab3
        '
        Me.Tab3.BackColor = System.Drawing.Color.Transparent
        Me.Tab3.Controls.Add(Me.Label19)
        Me.Tab3.Controls.Add(Me.txtObservaciones)
        Me.Tab3.Controls.Add(Me.Label24)
        Me.Tab3.Controls.Add(Me.txtTipoSangre)
        Me.Tab3.Controls.Add(Me.Label25)
        Me.Tab3.Controls.Add(Me.txtTelefonoEmergencia)
        Me.Tab3.Controls.Add(Me.Label26)
        Me.Tab3.Controls.Add(Me.txtContactoEmergencia)
        Me.Tab3.Location = New System.Drawing.Point(4, 24)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Size = New System.Drawing.Size(892, 356)
        Me.Tab3.TabIndex = 2
        Me.Tab3.Text = "Datos Emergencia"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(121, 15)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "OBSERVACIONES"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(6, 67)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(637, 71)
        Me.txtObservaciones.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(423, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(121, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "TIPO DE SANGRE"
        '
        'txtTipoSangre
        '
        Me.txtTipoSangre.Location = New System.Drawing.Point(426, 28)
        Me.txtTipoSangre.MaxLength = 3
        Me.txtTipoSangre.Name = "txtTipoSangre"
        Me.txtTipoSangre.Size = New System.Drawing.Size(97, 21)
        Me.txtTipoSangre.TabIndex = 41
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(276, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(173, 15)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "TELEFONO EMERGENCIA"
        '
        'txtTelefonoEmergencia
        '
        Me.txtTelefonoEmergencia.Location = New System.Drawing.Point(279, 28)
        Me.txtTelefonoEmergencia.Name = "txtTelefonoEmergencia"
        Me.txtTelefonoEmergencia.Size = New System.Drawing.Size(141, 21)
        Me.txtTelefonoEmergencia.TabIndex = 40
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 12)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(260, 15)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "NOMBRE CONTACTO DE EMERGENCIA"
        '
        'txtContactoEmergencia
        '
        Me.txtContactoEmergencia.Location = New System.Drawing.Point(4, 28)
        Me.txtContactoEmergencia.Name = "txtContactoEmergencia"
        Me.txtContactoEmergencia.Size = New System.Drawing.Size(269, 21)
        Me.txtContactoEmergencia.TabIndex = 39
        '
        'guardarCmd
        '
        Me.guardarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.guardarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarCmd.Location = New System.Drawing.Point(918, 277)
        Me.guardarCmd.Name = "guardarCmd"
        Me.guardarCmd.Size = New System.Drawing.Size(142, 27)
        Me.guardarCmd.TabIndex = 12
        Me.guardarCmd.Text = "Guardar"
        Me.guardarCmd.UseVisualStyleBackColor = True
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.Btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbuscar.Location = New System.Drawing.Point(918, 343)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(142, 26)
        Me.Btnbuscar.TabIndex = 14
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'nuevoCmd
        '
        Me.nuevoCmd.BackColor = System.Drawing.SystemColors.Control
        Me.nuevoCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__File_add_
        Me.nuevoCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevoCmd.Location = New System.Drawing.Point(918, 244)
        Me.nuevoCmd.Name = "nuevoCmd"
        Me.nuevoCmd.Size = New System.Drawing.Size(142, 27)
        Me.nuevoCmd.TabIndex = 16
        Me.nuevoCmd.Text = "Nuevo"
        Me.nuevoCmd.UseVisualStyleBackColor = False
        '
        'eliminarCmd
        '
        Me.eliminarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Db_delete_
        Me.eliminarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminarCmd.Location = New System.Drawing.Point(918, 310)
        Me.eliminarCmd.Name = "eliminarCmd"
        Me.eliminarCmd.Size = New System.Drawing.Size(142, 27)
        Me.eliminarCmd.TabIndex = 13
        Me.eliminarCmd.Text = "Eliminar"
        Me.eliminarCmd.UseVisualStyleBackColor = True
        '
        'salirCmd
        '
        Me.salirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Exit_
        Me.salirCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salirCmd.Location = New System.Drawing.Point(918, 375)
        Me.salirCmd.Name = "salirCmd"
        Me.salirCmd.Size = New System.Drawing.Size(142, 26)
        Me.salirCmd.TabIndex = 15
        Me.salirCmd.Text = "Salir"
        Me.salirCmd.UseVisualStyleBackColor = True
        '
        'maestrosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 406)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.salirCmd)
        Me.Controls.Add(Me.eliminarCmd)
        Me.Controls.Add(Me.nuevoCmd)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.guardarCmd)
        Me.Name = "maestrosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Personal"
        Me.TabControl1.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.Tab2.PerformLayout()
        Me.Tab3.ResumeLayout(False)
        Me.Tab3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumExt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents oFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCURP As System.Windows.Forms.TextBox
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents oFechaEgreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents oFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tab3 As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTipoSangre As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoEmergencia As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtContactoEmergencia As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtidMaestro As System.Windows.Forms.TextBox
    Friend WithEvents guardarCmd As System.Windows.Forms.Button
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents nuevoCmd As System.Windows.Forms.Button
    Friend WithEvents eliminarCmd As System.Windows.Forms.Button
    Friend WithEvents salirCmd As System.Windows.Forms.Button
End Class
