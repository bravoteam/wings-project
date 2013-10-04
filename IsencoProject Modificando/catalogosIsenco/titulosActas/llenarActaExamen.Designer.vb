<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class llenarActaExamen
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
        Me.txtIdAlumno = New System.Windows.Forms.TextBox()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbAula = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtConfrontado = New System.Windows.Forms.TextBox()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbAcuerdo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.consultarcmdS = New System.Windows.Forms.Button()
        Me.consultarcmdV = New System.Windows.Forms.Button()
        Me.consultarcmdP = New System.Windows.Forms.Button()
        Me.txtVocal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSecretario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPresidente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpFc = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGestion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbLugar = New System.Windows.Forms.ComboBox()
        Me.lblActaID = New System.Windows.Forms.Label()
        Me.txtAutorizacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre_Documento = New System.Windows.Forms.TextBox()
        Me.txtLicenciatura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarEImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdAlumno
        '
        Me.txtIdAlumno.Location = New System.Drawing.Point(949, -11)
        Me.txtIdAlumno.Name = "txtIdAlumno"
        Me.txtIdAlumno.Size = New System.Drawing.Size(186, 21)
        Me.txtIdAlumno.TabIndex = 57
        Me.txtIdAlumno.Visible = False
        '
        'dtpHora
        '
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(593, 261)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(288, 21)
        Me.dtpHora.TabIndex = 8
        Me.dtpHora.Value = New Date(2013, 5, 13, 12, 0, 0, 0)
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(593, 214)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(288, 21)
        Me.dtpFecha.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(590, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Hora Exámen:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(590, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 15)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Fecha Exámen:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Aula:"
        '
        'cmbAula
        '
        Me.cmbAula.FormattingEnabled = True
        Me.cmbAula.Items.AddRange(New Object() {"Aula 1", "Aula 2", "Aula 3", "Aula 4", "Aula 5", "Aula 6", "Aula 7", "Aula 8", "Aula 9", "Aula 10"})
        Me.cmbAula.Location = New System.Drawing.Point(13, 263)
        Me.cmbAula.Name = "cmbAula"
        Me.cmbAula.Size = New System.Drawing.Size(407, 23)
        Me.cmbAula.TabIndex = 6
        Me.cmbAula.Text = "Favor de Seleccionar el Aula......"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.dtpHora)
        Me.GroupBox2.Controls.Add(Me.cmbAcuerdo)
        Me.GroupBox2.Controls.Add(Me.cmbAula)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbLugar)
        Me.GroupBox2.Controls.Add(Me.lblActaID)
        Me.GroupBox2.Controls.Add(Me.txtIdAlumno)
        Me.GroupBox2.Controls.Add(Me.txtAutorizacion)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNombre_Documento)
        Me.GroupBox2.Controls.Add(Me.txtLicenciatura)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtMatricula)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1158, 578)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.txtConfrontado)
        Me.GroupBox6.Controls.Add(Me.txtDirector)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(584, 288)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(559, 152)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Director del Plantel:"
        '
        'txtConfrontado
        '
        Me.txtConfrontado.Enabled = False
        Me.txtConfrontado.Location = New System.Drawing.Point(9, 77)
        Me.txtConfrontado.Name = "txtConfrontado"
        Me.txtConfrontado.Size = New System.Drawing.Size(534, 20)
        Me.txtConfrontado.TabIndex = 1
        '
        'txtDirector
        '
        Me.txtDirector.Enabled = False
        Me.txtDirector.Location = New System.Drawing.Point(9, 35)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(534, 20)
        Me.txtDirector.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(177, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Registrado y Confrontado por:"
        '
        'cmbAcuerdo
        '
        Me.cmbAcuerdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcuerdo.FormattingEnabled = True
        Me.cmbAcuerdo.Items.AddRange(New Object() {"POR UNANIMIDAD CON MENCIÓN HONORÍFICA", "POR UNANIMIDAD CON FELICITACIÓN", "POR UNANIMIDAD", "POR MAYORÍA"})
        Me.cmbAcuerdo.Location = New System.Drawing.Point(22, 481)
        Me.cmbAcuerdo.Name = "cmbAcuerdo"
        Me.cmbAcuerdo.Size = New System.Drawing.Size(519, 23)
        Me.cmbAcuerdo.TabIndex = 11
        Me.cmbAcuerdo.Text = "Favor de Seleccione un Acuerdo......"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 446)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(520, 32)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Veredicto de Examen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.consultarcmdS)
        Me.GroupBox1.Controls.Add(Me.consultarcmdV)
        Me.GroupBox1.Controls.Add(Me.consultarcmdP)
        Me.GroupBox1.Controls.Add(Me.txtVocal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSecretario)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPresidente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 152)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jurado Integrado por los CC. Profesores:"
        '
        'consultarcmdS
        '
        Me.consultarcmdS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmdS.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmdS.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmdS.Location = New System.Drawing.Point(528, 71)
        Me.consultarcmdS.Name = "consultarcmdS"
        Me.consultarcmdS.Size = New System.Drawing.Size(28, 32)
        Me.consultarcmdS.TabIndex = 1
        Me.consultarcmdS.UseVisualStyleBackColor = True
        '
        'consultarcmdV
        '
        Me.consultarcmdV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmdV.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmdV.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmdV.Location = New System.Drawing.Point(528, 114)
        Me.consultarcmdV.Name = "consultarcmdV"
        Me.consultarcmdV.Size = New System.Drawing.Size(28, 32)
        Me.consultarcmdV.TabIndex = 2
        Me.consultarcmdV.UseVisualStyleBackColor = True
        '
        'consultarcmdP
        '
        Me.consultarcmdP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmdP.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmdP.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmdP.Location = New System.Drawing.Point(528, 30)
        Me.consultarcmdP.Name = "consultarcmdP"
        Me.consultarcmdP.Size = New System.Drawing.Size(28, 32)
        Me.consultarcmdP.TabIndex = 0
        Me.consultarcmdP.UseVisualStyleBackColor = True
        '
        'txtVocal
        '
        Me.txtVocal.Enabled = False
        Me.txtVocal.Location = New System.Drawing.Point(13, 123)
        Me.txtVocal.Name = "txtVocal"
        Me.txtVocal.Size = New System.Drawing.Size(515, 21)
        Me.txtVocal.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Vocal:"
        '
        'txtSecretario
        '
        Me.txtSecretario.Enabled = False
        Me.txtSecretario.Location = New System.Drawing.Point(13, 82)
        Me.txtSecretario.Name = "txtSecretario"
        Me.txtSecretario.Size = New System.Drawing.Size(515, 21)
        Me.txtSecretario.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Secretario:"
        '
        'txtPresidente
        '
        Me.txtPresidente.Enabled = False
        Me.txtPresidente.Location = New System.Drawing.Point(12, 41)
        Me.txtPresidente.Name = "txtPresidente"
        Me.txtPresidente.Size = New System.Drawing.Size(516, 21)
        Me.txtPresidente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Presidente:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtpFc)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtGestion)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(584, 446)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(560, 114)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'dtpFc
        '
        Me.dtpFc.Location = New System.Drawing.Point(6, 77)
        Me.dtpFc.Name = "dtpFc"
        Me.dtpFc.Size = New System.Drawing.Size(288, 21)
        Me.dtpFc.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(148, 15)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Fecha de Confrontado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(241, 15)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Subdirección de Educación Superior"
        '
        'txtGestion
        '
        Me.txtGestion.Enabled = False
        Me.txtGestion.Location = New System.Drawing.Point(9, 35)
        Me.txtGestion.Name = "txtGestion"
        Me.txtGestion.Size = New System.Drawing.Size(534, 21)
        Me.txtGestion.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Lugar:"
        '
        'cmbLugar
        '
        Me.cmbLugar.FormattingEnabled = True
        Me.cmbLugar.Items.AddRange(New Object() {"CUAUHTÉMOC, COLIMA", "COLIMA, COLIMA", "MANZANILLO, COLIMA", "TECOMÁN, COLIMA"})
        Me.cmbLugar.Location = New System.Drawing.Point(13, 214)
        Me.cmbLugar.Name = "cmbLugar"
        Me.cmbLugar.Size = New System.Drawing.Size(407, 23)
        Me.cmbLugar.TabIndex = 5
        Me.cmbLugar.Text = "Favor de Seleccionar el Lugar......"
        '
        'lblActaID
        '
        Me.lblActaID.AutoSize = True
        Me.lblActaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActaID.Location = New System.Drawing.Point(1099, 13)
        Me.lblActaID.Name = "lblActaID"
        Me.lblActaID.Size = New System.Drawing.Size(30, 20)
        Me.lblActaID.TabIndex = 58
        Me.lblActaID.Text = "LK"
        '
        'txtAutorizacion
        '
        Me.txtAutorizacion.Location = New System.Drawing.Point(9, 31)
        Me.txtAutorizacion.Name = "txtAutorizacion"
        Me.txtAutorizacion.Size = New System.Drawing.Size(219, 21)
        Me.txtAutorizacion.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Número de Autorización:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nombre del Documento Recepcional:"
        '
        'txtNombre_Documento
        '
        Me.txtNombre_Documento.Location = New System.Drawing.Point(9, 115)
        Me.txtNombre_Documento.Multiline = True
        Me.txtNombre_Documento.Name = "txtNombre_Documento"
        Me.txtNombre_Documento.Size = New System.Drawing.Size(1118, 64)
        Me.txtNombre_Documento.TabIndex = 4
        '
        'txtLicenciatura
        '
        Me.txtLicenciatura.Location = New System.Drawing.Point(593, 73)
        Me.txtLicenciatura.Name = "txtLicenciatura"
        Me.txtLicenciatura.Size = New System.Drawing.Size(534, 21)
        Me.txtLicenciatura.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(590, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Licenciatura"
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Location = New System.Drawing.Point(234, 31)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(219, 21)
        Me.TxtMatricula.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(9, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(528, 21)
        Me.txtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Matrícula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre del Alumno:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 57
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarEImprimirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'GuardarEImprimirToolStripMenuItem
        '
        Me.GuardarEImprimirToolStripMenuItem.Name = "GuardarEImprimirToolStripMenuItem"
        Me.GuardarEImprimirToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GuardarEImprimirToolStripMenuItem.Text = "Guardar e Imprimir"
        '
        'llenarActaExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 590)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "llenarActaExamen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Llenado de Acta de Exámen"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdAlumno As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbAula As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAutorizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre_Documento As System.Windows.Forms.TextBox
    Friend WithEvents txtLicenciatura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfrontado As System.Windows.Forms.TextBox
    Friend WithEvents txtGestion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDirector As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbAcuerdo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLugar As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVocal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSecretario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPresidente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarEImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents consultarcmdS As System.Windows.Forms.Button
    Friend WithEvents consultarcmdV As System.Windows.Forms.Button
    Friend WithEvents consultarcmdP As System.Windows.Forms.Button
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblActaID As System.Windows.Forms.Label
    Friend WithEvents dtpFc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
End Class
