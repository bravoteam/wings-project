<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmalumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmalumnos))
        Me.GbxBusqueda = New System.Windows.Forms.GroupBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmatricula = New System.Windows.Forms.TextBox()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.fechaExpDtp = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.licenciaturaTxt = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.especialidadTxt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.comboGenero = New System.Windows.Forms.ComboBox()
        Me.validadoTxt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.fechaDtp = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.revisadoTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdModalidad = New System.Windows.Forms.ComboBox()
        Me.promedioTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.creditosTxt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.asignaturasTxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.directorTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.añoTxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mesTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.diasTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.expedidoTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.planTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tituloCerTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoCer = New System.Windows.Forms.ComboBox()
        Me.curpTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTrabajo = New System.Windows.Forms.ComboBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtdatos = New System.Windows.Forms.TextBox()
        Me.txtdatos2 = New System.Windows.Forms.TextBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.GbxBusqueda.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxBusqueda
        '
        Me.GbxBusqueda.Controls.Add(Me.Btnbuscar)
        Me.GbxBusqueda.Controls.Add(Me.Label1)
        Me.GbxBusqueda.Controls.Add(Me.txtmatricula)
        Me.GbxBusqueda.Location = New System.Drawing.Point(12, 12)
        Me.GbxBusqueda.Name = "GbxBusqueda"
        Me.GbxBusqueda.Size = New System.Drawing.Size(440, 48)
        Me.GbxBusqueda.TabIndex = 0
        Me.GbxBusqueda.TabStop = False
        Me.GbxBusqueda.Text = "Busqueda"
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Image = CType(resources.GetObject("Btnbuscar.Image"), System.Drawing.Image)
        Me.Btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Btnbuscar.Location = New System.Drawing.Point(358, 8)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(82, 30)
        Me.Btnbuscar.TabIndex = 1
        Me.Btnbuscar.Text = "X Nombre"
        Me.Btnbuscar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MATRICULA:"
        '
        'txtmatricula
        '
        Me.txtmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatricula.Location = New System.Drawing.Point(152, 17)
        Me.txtmatricula.Name = "txtmatricula"
        Me.txtmatricula.Size = New System.Drawing.Size(200, 21)
        Me.txtmatricula.TabIndex = 0
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.btnlimpiar)
        Me.GbxDatos.Controls.Add(Me.BtnGuardar)
        Me.GbxDatos.Controls.Add(Me.fechaExpDtp)
        Me.GbxDatos.Controls.Add(Me.Label22)
        Me.GbxDatos.Controls.Add(Me.lblStatus)
        Me.GbxDatos.Controls.Add(Me.Btnsalir)
        Me.GbxDatos.Controls.Add(Me.licenciaturaTxt)
        Me.GbxDatos.Controls.Add(Me.Label21)
        Me.GbxDatos.Controls.Add(Me.especialidadTxt)
        Me.GbxDatos.Controls.Add(Me.Label20)
        Me.GbxDatos.Controls.Add(Me.Label19)
        Me.GbxDatos.Controls.Add(Me.comboGenero)
        Me.GbxDatos.Controls.Add(Me.validadoTxt)
        Me.GbxDatos.Controls.Add(Me.Label18)
        Me.GbxDatos.Controls.Add(Me.fechaDtp)
        Me.GbxDatos.Controls.Add(Me.Label17)
        Me.GbxDatos.Controls.Add(Me.revisadoTxt)
        Me.GbxDatos.Controls.Add(Me.Label4)
        Me.GbxDatos.Controls.Add(Me.Label3)
        Me.GbxDatos.Controls.Add(Me.cmdModalidad)
        Me.GbxDatos.Controls.Add(Me.promedioTxt)
        Me.GbxDatos.Controls.Add(Me.Label2)
        Me.GbxDatos.Controls.Add(Me.creditosTxt)
        Me.GbxDatos.Controls.Add(Me.Label16)
        Me.GbxDatos.Controls.Add(Me.asignaturasTxt)
        Me.GbxDatos.Controls.Add(Me.Label15)
        Me.GbxDatos.Controls.Add(Me.directorTxt)
        Me.GbxDatos.Controls.Add(Me.Label14)
        Me.GbxDatos.Controls.Add(Me.añoTxt)
        Me.GbxDatos.Controls.Add(Me.Label13)
        Me.GbxDatos.Controls.Add(Me.mesTxt)
        Me.GbxDatos.Controls.Add(Me.Label12)
        Me.GbxDatos.Controls.Add(Me.diasTxt)
        Me.GbxDatos.Controls.Add(Me.Label11)
        Me.GbxDatos.Controls.Add(Me.expedidoTxt)
        Me.GbxDatos.Controls.Add(Me.Label10)
        Me.GbxDatos.Controls.Add(Me.planTxt)
        Me.GbxDatos.Controls.Add(Me.Label9)
        Me.GbxDatos.Controls.Add(Me.tituloCerTxt)
        Me.GbxDatos.Controls.Add(Me.Label8)
        Me.GbxDatos.Controls.Add(Me.Label7)
        Me.GbxDatos.Controls.Add(Me.cmbTipoCer)
        Me.GbxDatos.Controls.Add(Me.curpTxt)
        Me.GbxDatos.Controls.Add(Me.Label6)
        Me.GbxDatos.Controls.Add(Me.Label5)
        Me.GbxDatos.Controls.Add(Me.cmbTrabajo)
        Me.GbxDatos.Controls.Add(Me.nombreTxt)
        Me.GbxDatos.Controls.Add(Me.lblnombre)
        Me.GbxDatos.Location = New System.Drawing.Point(12, 66)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(934, 334)
        Me.GbxDatos.TabIndex = 1
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "Datos del Certificado"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(709, 304)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(78, 30)
        Me.btnlimpiar.TabIndex = 37
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(620, 305)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(78, 30)
        Me.BtnGuardar.TabIndex = 20
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'fechaExpDtp
        '
        Me.fechaExpDtp.Location = New System.Drawing.Point(598, 191)
        Me.fechaExpDtp.Name = "fechaExpDtp"
        Me.fechaExpDtp.Size = New System.Drawing.Size(288, 20)
        Me.fechaExpDtp.TabIndex = 85
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(595, 171)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 13)
        Me.Label22.TabIndex = 86
        Me.Label22.Text = "FECHA DE EXPEDICION"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(594, 236)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(292, 38)
        Me.lblStatus.TabIndex = 84
        Me.lblStatus.Text = "NO ENCONTRADO"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(807, 305)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(78, 30)
        Me.Btnsalir.TabIndex = 36
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'licenciaturaTxt
        '
        Me.licenciaturaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.licenciaturaTxt.Location = New System.Drawing.Point(151, 106)
        Me.licenciaturaTxt.Name = "licenciaturaTxt"
        Me.licenciaturaTxt.Size = New System.Drawing.Size(431, 21)
        Me.licenciaturaTxt.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(22, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 13)
        Me.Label21.TabIndex = 82
        Me.Label21.Text = "LICENCIATURA:"
        '
        'especialidadTxt
        '
        Me.especialidadTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.especialidadTxt.Location = New System.Drawing.Point(429, 75)
        Me.especialidadTxt.Name = "especialidadTxt"
        Me.especialidadTxt.Size = New System.Drawing.Size(153, 21)
        Me.especialidadTxt.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(320, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 13)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "ESPECIALIDAD"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "GENERO"
        '
        'comboGenero
        '
        Me.comboGenero.FormattingEnabled = True
        Me.comboGenero.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.comboGenero.Location = New System.Drawing.Point(152, 79)
        Me.comboGenero.Name = "comboGenero"
        Me.comboGenero.Size = New System.Drawing.Size(163, 21)
        Me.comboGenero.TabIndex = 6
        '
        'validadoTxt
        '
        Me.validadoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validadoTxt.Location = New System.Drawing.Point(152, 273)
        Me.validadoTxt.Name = "validadoTxt"
        Me.validadoTxt.Size = New System.Drawing.Size(431, 21)
        Me.validadoTxt.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 281)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "VALIDADO:"
        '
        'fechaDtp
        '
        Me.fechaDtp.Location = New System.Drawing.Point(152, 247)
        Me.fechaDtp.Name = "fechaDtp"
        Me.fechaDtp.Size = New System.Drawing.Size(200, 20)
        Me.fechaDtp.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "FECHA CONFRONTADO"
        '
        'revisadoTxt
        '
        Me.revisadoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.revisadoTxt.Location = New System.Drawing.Point(152, 220)
        Me.revisadoTxt.Name = "revisadoTxt"
        Me.revisadoTxt.Size = New System.Drawing.Size(431, 21)
        Me.revisadoTxt.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "REV. Y CONFRONTADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "MODALIDAD:"
        '
        'cmdModalidad
        '
        Me.cmdModalidad.FormattingEnabled = True
        Me.cmdModalidad.Items.AddRange(New Object() {"ESCOLARIZADA", "MIXTA" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cmdModalidad.Location = New System.Drawing.Point(732, 82)
        Me.cmdModalidad.Name = "cmdModalidad"
        Me.cmdModalidad.Size = New System.Drawing.Size(153, 21)
        Me.cmdModalidad.TabIndex = 8
        Me.cmdModalidad.Text = "ESCOLARIZADA"
        '
        'promedioTxt
        '
        Me.promedioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.promedioTxt.Location = New System.Drawing.Point(430, 246)
        Me.promedioTxt.Name = "promedioTxt"
        Me.promedioTxt.Size = New System.Drawing.Size(153, 21)
        Me.promedioTxt.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "PROMEDIO:"
        '
        'creditosTxt
        '
        Me.creditosTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditosTxt.Location = New System.Drawing.Point(430, 300)
        Me.creditosTxt.Name = "creditosTxt"
        Me.creditosTxt.Size = New System.Drawing.Size(153, 21)
        Me.creditosTxt.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(321, 305)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "TOTAL CREDITOS:"
        '
        'asignaturasTxt
        '
        Me.asignaturasTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asignaturasTxt.Location = New System.Drawing.Point(152, 300)
        Me.asignaturasTxt.Name = "asignaturasTxt"
        Me.asignaturasTxt.Size = New System.Drawing.Size(153, 21)
        Me.asignaturasTxt.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "TOTAL ASIGNATURAS:"
        '
        'directorTxt
        '
        Me.directorTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.directorTxt.Location = New System.Drawing.Point(152, 190)
        Me.directorTxt.Name = "directorTxt"
        Me.directorTxt.Size = New System.Drawing.Size(431, 21)
        Me.directorTxt.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "DIRECTOR PLANTEL:"
        '
        'añoTxt
        '
        Me.añoTxt.Enabled = False
        Me.añoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.añoTxt.Location = New System.Drawing.Point(827, 141)
        Me.añoTxt.Name = "añoTxt"
        Me.añoTxt.Size = New System.Drawing.Size(58, 21)
        Me.añoTxt.TabIndex = 61
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(790, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "AÑO"
        '
        'mesTxt
        '
        Me.mesTxt.Enabled = False
        Me.mesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mesTxt.Location = New System.Drawing.Point(719, 141)
        Me.mesTxt.Name = "mesTxt"
        Me.mesTxt.Size = New System.Drawing.Size(68, 21)
        Me.mesTxt.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(688, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "MES"
        '
        'diasTxt
        '
        Me.diasTxt.Enabled = False
        Me.diasTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diasTxt.Location = New System.Drawing.Point(620, 141)
        Me.diasTxt.Name = "diasTxt"
        Me.diasTxt.Size = New System.Drawing.Size(66, 21)
        Me.diasTxt.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(593, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "DIA"
        '
        'expedidoTxt
        '
        Me.expedidoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expedidoTxt.Location = New System.Drawing.Point(152, 163)
        Me.expedidoTxt.Name = "expedidoTxt"
        Me.expedidoTxt.Size = New System.Drawing.Size(431, 21)
        Me.expedidoTxt.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "EXPEDIDO EN:"
        '
        'planTxt
        '
        Me.planTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planTxt.Location = New System.Drawing.Point(732, 109)
        Me.planTxt.Name = "planTxt"
        Me.planTxt.Size = New System.Drawing.Size(153, 21)
        Me.planTxt.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(593, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "PLAN ESTUDIOS"
        '
        'tituloCerTxt
        '
        Me.tituloCerTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloCerTxt.Location = New System.Drawing.Point(152, 133)
        Me.tituloCerTxt.Name = "tituloCerTxt"
        Me.tituloCerTxt.Size = New System.Drawing.Size(431, 21)
        Me.tituloCerTxt.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "TITULO CERTIFICADO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(593, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "TIPO CERTIFICADO:"
        '
        'cmbTipoCer
        '
        Me.cmbTipoCer.FormattingEnabled = True
        Me.cmbTipoCer.Items.AddRange(New Object() {"COMPLETOS", "PARCIALES"})
        Me.cmbTipoCer.Location = New System.Drawing.Point(732, 53)
        Me.cmbTipoCer.Name = "cmbTipoCer"
        Me.cmbTipoCer.Size = New System.Drawing.Size(153, 21)
        Me.cmbTipoCer.TabIndex = 5
        Me.cmbTipoCer.Text = "COMPLETOS"
        '
        'curpTxt
        '
        Me.curpTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.curpTxt.Location = New System.Drawing.Point(152, 48)
        Me.curpTxt.Name = "curpTxt"
        Me.curpTxt.Size = New System.Drawing.Size(431, 21)
        Me.curpTxt.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "CURP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(593, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "CENTRO DE TRABAJO:"
        '
        'cmbTrabajo
        '
        Me.cmbTrabajo.FormattingEnabled = True
        Me.cmbTrabajo.Location = New System.Drawing.Point(732, 26)
        Me.cmbTrabajo.Name = "cmbTrabajo"
        Me.cmbTrabajo.Size = New System.Drawing.Size(153, 21)
        Me.cmbTrabajo.TabIndex = 3
        '
        'nombreTxt
        '
        Me.nombreTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreTxt.Location = New System.Drawing.Point(152, 21)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(431, 21)
        Me.nombreTxt.TabIndex = 2
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(23, 29)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(57, 13)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "NOMBRE:"
        '
        'txtdatos
        '
        Me.txtdatos.Location = New System.Drawing.Point(282, 402)
        Me.txtdatos.Name = "txtdatos"
        Me.txtdatos.Size = New System.Drawing.Size(113, 20)
        Me.txtdatos.TabIndex = 33
        Me.txtdatos.Visible = False
        '
        'txtdatos2
        '
        Me.txtdatos2.Location = New System.Drawing.Point(442, 402)
        Me.txtdatos2.Name = "txtdatos2"
        Me.txtdatos2.Size = New System.Drawing.Size(113, 20)
        Me.txtdatos2.TabIndex = 34
        Me.txtdatos2.Visible = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(449, 20)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(488, 38)
        Me.lbltitulo.TabIndex = 2
        Me.lbltitulo.Text = "INSTITUTO SUPERIOR DE EDUCACIÓN NORMAL DE COLIMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             ""PROFR. GREGORIO T" & _
            "ORRES QUINTERO"""
        '
        'Frmalumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 401)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.GbxDatos)
        Me.Controls.Add(Me.GbxBusqueda)
        Me.Controls.Add(Me.txtdatos)
        Me.Controls.Add(Me.txtdatos2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frmalumnos"
        Me.Text = "Impresion de Certificados"
        Me.GbxBusqueda.ResumeLayout(False)
        Me.GbxBusqueda.PerformLayout()
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbxBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmatricula As System.Windows.Forms.TextBox
    Friend WithEvents GbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents nombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTrabajo As System.Windows.Forms.ComboBox
    Friend WithEvents txtdatos2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdatos As System.Windows.Forms.TextBox
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoCer As System.Windows.Forms.ComboBox
    Friend WithEvents curpTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tituloCerTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents planTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents creditosTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents asignaturasTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents directorTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents añoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents diasTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents expedidoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents promedioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents validadoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents fechaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents revisadoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents comboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents especialidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents licenciaturaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents fechaExpDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label

End Class
