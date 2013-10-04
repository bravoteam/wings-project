<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportePagosFrm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Gbxdatos = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbmCicloEscolar = New System.Windows.Forms.ComboBox()
        Me.consultarcmd = New System.Windows.Forms.Button()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.reportesDT = New catalogosIsenco.reportesDT()
        Me.alumno_pagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.alumno_pagoTableAdapter = New catalogosIsenco.reportesDTTableAdapters.alumno_pagoTableAdapter()
        Me.Gbxdatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alumno_pagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gbxdatos
        '
        Me.Gbxdatos.Controls.Add(Me.Label12)
        Me.Gbxdatos.Controls.Add(Me.cbmCicloEscolar)
        Me.Gbxdatos.Controls.Add(Me.consultarcmd)
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
        Me.Gbxdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbxdatos.Location = New System.Drawing.Point(12, 23)
        Me.Gbxdatos.Name = "Gbxdatos"
        Me.Gbxdatos.Size = New System.Drawing.Size(924, 116)
        Me.Gbxdatos.TabIndex = 44
        Me.Gbxdatos.TabStop = False
        Me.Gbxdatos.Text = "Encabezados del Reporte"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(295, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Ciclo Escolar"
        '
        'cbmCicloEscolar
        '
        Me.cbmCicloEscolar.FormattingEnabled = True
        Me.cbmCicloEscolar.Items.AddRange(New Object() {"2008-2009", "2009-2010", "2010-2011", "2011-2012", "2012-2013"})
        Me.cbmCicloEscolar.Location = New System.Drawing.Point(298, 86)
        Me.cbmCicloEscolar.Name = "cbmCicloEscolar"
        Me.cbmCicloEscolar.Size = New System.Drawing.Size(286, 21)
        Me.cbmCicloEscolar.TabIndex = 55
        '
        'consultarcmd
        '
        Me.consultarcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmd.Location = New System.Drawing.Point(595, 77)
        Me.consultarcmd.Name = "consultarcmd"
        Me.consultarcmd.Size = New System.Drawing.Size(170, 29)
        Me.consultarcmd.TabIndex = 54
        Me.consultarcmd.Text = "Consultar"
        Me.consultarcmd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Modalidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Turno"
        '
        'cmbModalidad
        '
        Me.cmbModalidad.Enabled = False
        Me.cmbModalidad.FormattingEnabled = True
        Me.cmbModalidad.Items.AddRange(New Object() {"E"})
        Me.cmbModalidad.Location = New System.Drawing.Point(82, 86)
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.Size = New System.Drawing.Size(53, 21)
        Me.cmbModalidad.TabIndex = 49
        Me.cmbModalidad.Text = "E"
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"TM", "TV"})
        Me.cmbTurno.Location = New System.Drawing.Point(20, 85)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(54, 21)
        Me.cmbTurno.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(592, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Especialidad"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(595, 39)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(309, 21)
        Me.cmbEspecialidad.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Licenciatura"
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(225, 38)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(359, 21)
        Me.cmbLicenciatura.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Grupo"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(226, 85)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(54, 21)
        Me.cmbGrupo.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Semestre"
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(152, 85)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(52, 21)
        Me.cmbSemestre.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Campus"
        '
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(20, 38)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(184, 21)
        Me.cmbCampus.TabIndex = 38
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(949, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.alumno_pagoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.reportePagos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 156)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(920, 584)
        Me.ReportViewer1.TabIndex = 47
        '
        'reportesDT
        '
        Me.reportesDT.DataSetName = "reportesDT"
        Me.reportesDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'alumno_pagoBindingSource
        '
        Me.alumno_pagoBindingSource.DataMember = "alumno_pago"
        Me.alumno_pagoBindingSource.DataSource = Me.reportesDT
        '
        'alumno_pagoTableAdapter
        '
        Me.alumno_pagoTableAdapter.ClearBeforeFill = True
        '
        'reportePagosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 752)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Gbxdatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "reportePagosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Pagos de Reinscripcion"
        Me.Gbxdatos.ResumeLayout(False)
        Me.Gbxdatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alumno_pagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbmCicloEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents consultarcmd As System.Windows.Forms.Button
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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents alumno_pagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportesDT As catalogosIsenco.reportesDT
    Friend WithEvents alumno_pagoTableAdapter As catalogosIsenco.reportesDTTableAdapters.alumno_pagoTableAdapter
End Class
