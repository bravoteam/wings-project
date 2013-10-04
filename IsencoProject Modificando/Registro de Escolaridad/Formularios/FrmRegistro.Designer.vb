<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
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
        Me.components = New System.ComponentModel.Container()
        Me.Gbxdatos = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbModalidad = New System.Windows.Forms.ComboBox()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbLicenciatura = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCampus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbplantel3 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbplantel2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cmbplantel = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cmbregularizacion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cmbacreditacion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbInscripcion = New System.Windows.Forms.ComboBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.IDSEMESTREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGRUPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESPECIALIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOPATERNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOMATERNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterianombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDLICENCIATURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMATERIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calificacion2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREMATERIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveisencoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARRERANOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCAMPUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDturnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extra1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extra2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extra3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcreditadasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoacreditadasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGISTROESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroDt = New Registro_de_Escolaridad.RegistroDt()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cmbciclo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Dtp3 = New System.Windows.Forms.DateTimePicker()
        Me.Dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.REGISTROESCOLARIDADTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTROESCOLARIDADTableAdapter()
        Me.REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter()
        Me.Gbxdatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTROESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gbxdatos
        '
        Me.Gbxdatos.Controls.Add(Me.Label3)
        Me.Gbxdatos.Controls.Add(Me.Label2)
        Me.Gbxdatos.Controls.Add(Me.cmbModalidad)
        Me.Gbxdatos.Controls.Add(Me.cmbTurno)
        Me.Gbxdatos.Controls.Add(Me.Label7)
        Me.Gbxdatos.Controls.Add(Me.cmbEspecialidad)
        Me.Gbxdatos.Controls.Add(Me.Label6)
        Me.Gbxdatos.Controls.Add(Me.cmbLicenciatura)
        Me.Gbxdatos.Controls.Add(Me.Label4)
        Me.Gbxdatos.Controls.Add(Me.cmbGrupo)
        Me.Gbxdatos.Controls.Add(Me.Label5)
        Me.Gbxdatos.Controls.Add(Me.cmbSemestre)
        Me.Gbxdatos.Controls.Add(Me.Label1)
        Me.Gbxdatos.Controls.Add(Me.cmbCampus)
        Me.Gbxdatos.Location = New System.Drawing.Point(2, 2)
        Me.Gbxdatos.Name = "Gbxdatos"
        Me.Gbxdatos.Size = New System.Drawing.Size(662, 135)
        Me.Gbxdatos.TabIndex = 42
        Me.Gbxdatos.TabStop = False
        Me.Gbxdatos.Text = "Datos Escolares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Modalidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Turno"
        '
        'cmbModalidad
        '
        Me.cmbModalidad.Enabled = False
        Me.cmbModalidad.FormattingEnabled = True
        Me.cmbModalidad.Items.AddRange(New Object() {"E"})
        Me.cmbModalidad.Location = New System.Drawing.Point(439, 94)
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.Size = New System.Drawing.Size(53, 21)
        Me.cmbModalidad.TabIndex = 49
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(371, 93)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(54, 21)
        Me.cmbTurno.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Especialidad"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(20, 94)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(329, 21)
        Me.cmbEspecialidad.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Licenciatura"
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(371, 43)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(266, 21)
        Me.cmbLicenciatura.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(580, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Grupo"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(583, 93)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(54, 21)
        Me.cmbGrupo.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Semestre"
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(514, 93)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(52, 21)
        Me.cmbSemestre.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Campus"
        '
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(20, 43)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(329, 21)
        Me.cmbCampus.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cmbplantel3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cmbplantel2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Cmbplantel)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Cmbregularizacion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Cmbacreditacion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CmbInscripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 139)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(376, 280)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Directivos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 231)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 13)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "DIRECTOR DEL PLANTEL"
        '
        'cmbplantel3
        '
        Me.cmbplantel3.FormattingEnabled = True
        Me.cmbplantel3.Location = New System.Drawing.Point(16, 247)
        Me.cmbplantel3.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbplantel3.Name = "cmbplantel3"
        Me.cmbplantel3.Size = New System.Drawing.Size(332, 21)
        Me.cmbplantel3.TabIndex = 68
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 13)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "DIRECTOR DEL PLANTEL"
        '
        'cmbplantel2
        '
        Me.cmbplantel2.FormattingEnabled = True
        Me.cmbplantel2.Location = New System.Drawing.Point(16, 212)
        Me.cmbplantel2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbplantel2.Name = "cmbplantel2"
        Me.cmbplantel2.Size = New System.Drawing.Size(332, 21)
        Me.cmbplantel2.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 13)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "DIRECTOR DEL PLANTEL"
        '
        'Cmbplantel
        '
        Me.Cmbplantel.FormattingEnabled = True
        Me.Cmbplantel.Location = New System.Drawing.Point(16, 176)
        Me.Cmbplantel.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbplantel.Name = "Cmbplantel"
        Me.Cmbplantel.Size = New System.Drawing.Size(332, 21)
        Me.Cmbplantel.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "REGULARIZACIÓN"
        '
        'Cmbregularizacion
        '
        Me.Cmbregularizacion.FormattingEnabled = True
        Me.Cmbregularizacion.Location = New System.Drawing.Point(16, 137)
        Me.Cmbregularizacion.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbregularizacion.Name = "Cmbregularizacion"
        Me.Cmbregularizacion.Size = New System.Drawing.Size(332, 21)
        Me.Cmbregularizacion.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "ACREDITACIÓN"
        '
        'Cmbacreditacion
        '
        Me.Cmbacreditacion.FormattingEnabled = True
        Me.Cmbacreditacion.Location = New System.Drawing.Point(16, 88)
        Me.Cmbacreditacion.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbacreditacion.Name = "Cmbacreditacion"
        Me.Cmbacreditacion.Size = New System.Drawing.Size(332, 21)
        Me.Cmbacreditacion.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "INSCRIPCIÓN"
        '
        'CmbInscripcion
        '
        Me.CmbInscripcion.FormattingEnabled = True
        Me.CmbInscripcion.Location = New System.Drawing.Point(16, 39)
        Me.CmbInscripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbInscripcion.Name = "CmbInscripcion"
        Me.CmbInscripcion.Size = New System.Drawing.Size(332, 21)
        Me.CmbInscripcion.TabIndex = 56
        '
        'dg
        '
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoGenerateColumns = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSEMESTREDataGridViewTextBoxColumn, Me.IDGRUPODataGridViewTextBoxColumn, Me.IDESPECIALIDADDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDOPATERNODataGridViewTextBoxColumn, Me.APELLIDOMATERNODataGridViewTextBoxColumn, Me.MaterianombreDataGridViewTextBoxColumn, Me.IDLICENCIATURADataGridViewTextBoxColumn, Me.MatriculaDataGridViewTextBoxColumn, Me.IDMATERIADataGridViewTextBoxColumn, Me.CALIFICACIONDataGridViewTextBoxColumn, Me.Calificacion2DataGridViewTextBoxColumn, Me.CURPDataGridViewTextBoxColumn, Me.GENERODataGridViewTextBoxColumn, Me.NOMBREMATERIADataGridViewTextBoxColumn, Me.ClaveisencoDataGridViewTextBoxColumn, Me.CARRERANOMBREDataGridViewTextBoxColumn, Me.IDCAMPUSDataGridViewTextBoxColumn, Me.IDSTATUSDataGridViewTextBoxColumn, Me.IDturnoDataGridViewTextBoxColumn, Me.Extra1DataGridViewTextBoxColumn, Me.Extra2DataGridViewTextBoxColumn, Me.Extra3DataGridViewTextBoxColumn, Me.AcreditadasDataGridViewTextBoxColumn, Me.NoacreditadasDataGridViewTextBoxColumn})
        Me.dg.DataSource = Me.REGISTROESCOLARIDADBindingSource
        Me.dg.Location = New System.Drawing.Point(2, 423)
        Me.dg.Margin = New System.Windows.Forms.Padding(2)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(771, 203)
        Me.dg.TabIndex = 47
        '
        'IDSEMESTREDataGridViewTextBoxColumn
        '
        Me.IDSEMESTREDataGridViewTextBoxColumn.DataPropertyName = "IDSEMESTRE"
        Me.IDSEMESTREDataGridViewTextBoxColumn.HeaderText = "IDSEMESTRE"
        Me.IDSEMESTREDataGridViewTextBoxColumn.Name = "IDSEMESTREDataGridViewTextBoxColumn"
        Me.IDSEMESTREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDGRUPODataGridViewTextBoxColumn
        '
        Me.IDGRUPODataGridViewTextBoxColumn.DataPropertyName = "IDGRUPO"
        Me.IDGRUPODataGridViewTextBoxColumn.HeaderText = "IDGRUPO"
        Me.IDGRUPODataGridViewTextBoxColumn.Name = "IDGRUPODataGridViewTextBoxColumn"
        Me.IDGRUPODataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDESPECIALIDADDataGridViewTextBoxColumn
        '
        Me.IDESPECIALIDADDataGridViewTextBoxColumn.DataPropertyName = "IDESPECIALIDAD"
        Me.IDESPECIALIDADDataGridViewTextBoxColumn.HeaderText = "IDESPECIALIDAD"
        Me.IDESPECIALIDADDataGridViewTextBoxColumn.Name = "IDESPECIALIDADDataGridViewTextBoxColumn"
        Me.IDESPECIALIDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APELLIDOPATERNODataGridViewTextBoxColumn
        '
        Me.APELLIDOPATERNODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO_PATERNO"
        Me.APELLIDOPATERNODataGridViewTextBoxColumn.HeaderText = "APELLIDO_PATERNO"
        Me.APELLIDOPATERNODataGridViewTextBoxColumn.Name = "APELLIDOPATERNODataGridViewTextBoxColumn"
        Me.APELLIDOPATERNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'APELLIDOMATERNODataGridViewTextBoxColumn
        '
        Me.APELLIDOMATERNODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO_MATERNO"
        Me.APELLIDOMATERNODataGridViewTextBoxColumn.HeaderText = "APELLIDO_MATERNO"
        Me.APELLIDOMATERNODataGridViewTextBoxColumn.Name = "APELLIDOMATERNODataGridViewTextBoxColumn"
        Me.APELLIDOMATERNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterianombreDataGridViewTextBoxColumn
        '
        Me.MaterianombreDataGridViewTextBoxColumn.DataPropertyName = "materianombre"
        Me.MaterianombreDataGridViewTextBoxColumn.HeaderText = "materianombre"
        Me.MaterianombreDataGridViewTextBoxColumn.Name = "MaterianombreDataGridViewTextBoxColumn"
        Me.MaterianombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDLICENCIATURADataGridViewTextBoxColumn
        '
        Me.IDLICENCIATURADataGridViewTextBoxColumn.DataPropertyName = "IDLICENCIATURA"
        Me.IDLICENCIATURADataGridViewTextBoxColumn.HeaderText = "IDLICENCIATURA"
        Me.IDLICENCIATURADataGridViewTextBoxColumn.Name = "IDLICENCIATURADataGridViewTextBoxColumn"
        Me.IDLICENCIATURADataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatriculaDataGridViewTextBoxColumn
        '
        Me.MatriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.HeaderText = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.Name = "MatriculaDataGridViewTextBoxColumn"
        Me.MatriculaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDMATERIADataGridViewTextBoxColumn
        '
        Me.IDMATERIADataGridViewTextBoxColumn.DataPropertyName = "IDMATERIA"
        Me.IDMATERIADataGridViewTextBoxColumn.HeaderText = "IDMATERIA"
        Me.IDMATERIADataGridViewTextBoxColumn.Name = "IDMATERIADataGridViewTextBoxColumn"
        Me.IDMATERIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CALIFICACIONDataGridViewTextBoxColumn
        '
        Me.CALIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "CALIFICACION"
        Me.CALIFICACIONDataGridViewTextBoxColumn.HeaderText = "CALIFICACION"
        Me.CALIFICACIONDataGridViewTextBoxColumn.Name = "CALIFICACIONDataGridViewTextBoxColumn"
        Me.CALIFICACIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Calificacion2DataGridViewTextBoxColumn
        '
        Me.Calificacion2DataGridViewTextBoxColumn.DataPropertyName = "calificacion2"
        Me.Calificacion2DataGridViewTextBoxColumn.HeaderText = "calificacion2"
        Me.Calificacion2DataGridViewTextBoxColumn.Name = "Calificacion2DataGridViewTextBoxColumn"
        Me.Calificacion2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CURPDataGridViewTextBoxColumn
        '
        Me.CURPDataGridViewTextBoxColumn.DataPropertyName = "CURP"
        Me.CURPDataGridViewTextBoxColumn.HeaderText = "CURP"
        Me.CURPDataGridViewTextBoxColumn.Name = "CURPDataGridViewTextBoxColumn"
        Me.CURPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GENERODataGridViewTextBoxColumn
        '
        Me.GENERODataGridViewTextBoxColumn.DataPropertyName = "GENERO"
        Me.GENERODataGridViewTextBoxColumn.HeaderText = "GENERO"
        Me.GENERODataGridViewTextBoxColumn.Name = "GENERODataGridViewTextBoxColumn"
        Me.GENERODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREMATERIADataGridViewTextBoxColumn
        '
        Me.NOMBREMATERIADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_MATERIA"
        Me.NOMBREMATERIADataGridViewTextBoxColumn.HeaderText = "NOMBRE_MATERIA"
        Me.NOMBREMATERIADataGridViewTextBoxColumn.Name = "NOMBREMATERIADataGridViewTextBoxColumn"
        Me.NOMBREMATERIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClaveisencoDataGridViewTextBoxColumn
        '
        Me.ClaveisencoDataGridViewTextBoxColumn.DataPropertyName = "claveisenco"
        Me.ClaveisencoDataGridViewTextBoxColumn.HeaderText = "claveisenco"
        Me.ClaveisencoDataGridViewTextBoxColumn.Name = "ClaveisencoDataGridViewTextBoxColumn"
        Me.ClaveisencoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CARRERANOMBREDataGridViewTextBoxColumn
        '
        Me.CARRERANOMBREDataGridViewTextBoxColumn.DataPropertyName = "CARRERANOMBRE"
        Me.CARRERANOMBREDataGridViewTextBoxColumn.HeaderText = "CARRERANOMBRE"
        Me.CARRERANOMBREDataGridViewTextBoxColumn.Name = "CARRERANOMBREDataGridViewTextBoxColumn"
        Me.CARRERANOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDCAMPUSDataGridViewTextBoxColumn
        '
        Me.IDCAMPUSDataGridViewTextBoxColumn.DataPropertyName = "IDCAMPUS"
        Me.IDCAMPUSDataGridViewTextBoxColumn.HeaderText = "IDCAMPUS"
        Me.IDCAMPUSDataGridViewTextBoxColumn.Name = "IDCAMPUSDataGridViewTextBoxColumn"
        Me.IDCAMPUSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDSTATUSDataGridViewTextBoxColumn
        '
        Me.IDSTATUSDataGridViewTextBoxColumn.DataPropertyName = "IDSTATUS"
        Me.IDSTATUSDataGridViewTextBoxColumn.HeaderText = "IDSTATUS"
        Me.IDSTATUSDataGridViewTextBoxColumn.Name = "IDSTATUSDataGridViewTextBoxColumn"
        Me.IDSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDturnoDataGridViewTextBoxColumn
        '
        Me.IDturnoDataGridViewTextBoxColumn.DataPropertyName = "IDturno"
        Me.IDturnoDataGridViewTextBoxColumn.HeaderText = "IDturno"
        Me.IDturnoDataGridViewTextBoxColumn.Name = "IDturnoDataGridViewTextBoxColumn"
        Me.IDturnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Extra1DataGridViewTextBoxColumn
        '
        Me.Extra1DataGridViewTextBoxColumn.DataPropertyName = "extra1"
        Me.Extra1DataGridViewTextBoxColumn.HeaderText = "extra1"
        Me.Extra1DataGridViewTextBoxColumn.Name = "Extra1DataGridViewTextBoxColumn"
        Me.Extra1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Extra2DataGridViewTextBoxColumn
        '
        Me.Extra2DataGridViewTextBoxColumn.DataPropertyName = "extra2"
        Me.Extra2DataGridViewTextBoxColumn.HeaderText = "extra2"
        Me.Extra2DataGridViewTextBoxColumn.Name = "Extra2DataGridViewTextBoxColumn"
        Me.Extra2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Extra3DataGridViewTextBoxColumn
        '
        Me.Extra3DataGridViewTextBoxColumn.DataPropertyName = "extra3"
        Me.Extra3DataGridViewTextBoxColumn.HeaderText = "extra3"
        Me.Extra3DataGridViewTextBoxColumn.Name = "Extra3DataGridViewTextBoxColumn"
        Me.Extra3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcreditadasDataGridViewTextBoxColumn
        '
        Me.AcreditadasDataGridViewTextBoxColumn.DataPropertyName = "acreditadas"
        Me.AcreditadasDataGridViewTextBoxColumn.HeaderText = "acreditadas"
        Me.AcreditadasDataGridViewTextBoxColumn.Name = "AcreditadasDataGridViewTextBoxColumn"
        Me.AcreditadasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoacreditadasDataGridViewTextBoxColumn
        '
        Me.NoacreditadasDataGridViewTextBoxColumn.DataPropertyName = "noacreditadas"
        Me.NoacreditadasDataGridViewTextBoxColumn.HeaderText = "noacreditadas"
        Me.NoacreditadasDataGridViewTextBoxColumn.Name = "NoacreditadasDataGridViewTextBoxColumn"
        Me.NoacreditadasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'REGISTROESCOLARIDADBindingSource
        '
        Me.REGISTROESCOLARIDADBindingSource.DataMember = "REGISTROESCOLARIDAD"
        Me.REGISTROESCOLARIDADBindingSource.DataSource = Me.RegistroDt
        '
        'RegistroDt
        '
        Me.RegistroDt.DataSetName = "RegistroDt"
        Me.RegistroDt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cmbciclo)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Dtp3)
        Me.GroupBox2.Controls.Add(Me.Dtp2)
        Me.GroupBox2.Controls.Add(Me.Dtp1)
        Me.GroupBox2.Location = New System.Drawing.Point(404, 139)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(376, 280)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Fechas"
        '
        'Cmbciclo
        '
        Me.Cmbciclo.FormattingEnabled = True
        Me.Cmbciclo.Location = New System.Drawing.Point(20, 188)
        Me.Cmbciclo.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbciclo.Name = "Cmbciclo"
        Me.Cmbciclo.Size = New System.Drawing.Size(320, 21)
        Me.Cmbciclo.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "CICLO-ESCOLAR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "FECHA REGULARIZACIÓN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "FECHA ACREDITACIÓN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "FECHA INSCRIPCIÓN"
        '
        'Dtp3
        '
        Me.Dtp3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp3.Location = New System.Drawing.Point(20, 137)
        Me.Dtp3.Margin = New System.Windows.Forms.Padding(2)
        Me.Dtp3.Name = "Dtp3"
        Me.Dtp3.Size = New System.Drawing.Size(320, 20)
        Me.Dtp3.TabIndex = 72
        '
        'Dtp2
        '
        Me.Dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp2.Location = New System.Drawing.Point(20, 88)
        Me.Dtp2.Margin = New System.Windows.Forms.Padding(2)
        Me.Dtp2.Name = "Dtp2"
        Me.Dtp2.Size = New System.Drawing.Size(320, 20)
        Me.Dtp2.TabIndex = 71
        '
        'Dtp1
        '
        Me.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp1.Location = New System.Drawing.Point(20, 39)
        Me.Dtp1.Margin = New System.Windows.Forms.Padding(2)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(320, 20)
        Me.Dtp1.TabIndex = 70
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.Registro_de_Escolaridad.My.Resources.Resources._16__Clear_
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(670, 51)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(110, 41)
        Me.BtnLimpiar.TabIndex = 48
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Registro_de_Escolaridad.My.Resources.Resources._16__Exit_
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(670, 95)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 41)
        Me.BtnSalir.TabIndex = 45
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Image = Global.Registro_de_Escolaridad.My.Resources.Resources._16__File_add_
        Me.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerar.Location = New System.Drawing.Point(670, 7)
        Me.BtnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(110, 41)
        Me.BtnGenerar.TabIndex = 44
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'dg2
        '
        Me.dg2.AllowUserToDeleteRows = False
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Location = New System.Drawing.Point(302, 478)
        Me.dg2.Margin = New System.Windows.Forms.Padding(2)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.RowTemplate.Height = 24
        Me.dg2.Size = New System.Drawing.Size(183, 121)
        Me.dg2.TabIndex = 50
        '
        'REGISTROESCOLARIDADTableAdapter
        '
        Me.REGISTROESCOLARIDADTableAdapter.ClearBeforeFill = True
        '
        'REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter
        '
        Me.REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter.ClearBeforeFill = True
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 635)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.Gbxdatos)
        Me.Controls.Add(Me.dg2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmRegistro"
        Me.Text = "Registro de Escolaridad"
        Me.Gbxdatos.ResumeLayout(False)
        Me.Gbxdatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTROESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCampus As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cmbregularizacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cmbacreditacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbInscripcion As System.Windows.Forms.ComboBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents IDSEMESTREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDGRUPODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESPECIALIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOPATERNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOMATERNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterianombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDLICENCIATURADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatriculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMATERIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALIFICACIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calificacion2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENERODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREMATERIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaveisencoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CARRERANOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCAMPUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDturnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Extra1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Extra2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Extra3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr100DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AprobadasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReprobadasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcreditadasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoacreditadasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGISTROESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistroDt As Registro_de_Escolaridad.RegistroDt
    Friend WithEvents REGISTROESCOLARIDADTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTROESCOLARIDADTableAdapter
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Dtp3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cmbplantel As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Cmbciclo As System.Windows.Forms.ComboBox
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTRO_ESCOLARIDAD_ANTERIORTableAdapter
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbplantel3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbplantel2 As System.Windows.Forms.ComboBox

End Class
