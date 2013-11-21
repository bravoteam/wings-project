<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calificacionMaestroFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.calificacionesMaestrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportesDT = New catalogosIsenco.reportesDT()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblParcial = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmbObtener = New System.Windows.Forms.Button()
        Me.cmbAux = New System.Windows.Forms.ComboBox()
        Me.txtCampus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtLicenciatura = New System.Windows.Forms.TextBox()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtSemestre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboMaterias = New System.Windows.Forms.ComboBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO_PATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO_MATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.calificacionesMaestrosTableAdapter = New catalogosIsenco.reportesDTTableAdapters.calificacionesMaestrosTableAdapter()
        CType(Me.calificacionesMaestrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'calificacionesMaestrosBindingSource
        '
        Me.calificacionesMaestrosBindingSource.DataMember = "calificacionesMaestros"
        Me.calificacionesMaestrosBindingSource.DataSource = Me.reportesDT
        '
        'reportesDT
        '
        Me.reportesDT.DataSetName = "reportesDT"
        Me.reportesDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 94)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 29)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Semestre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblParcial)
        Me.GroupBox1.Controls.Add(Me.cmdGuardar)
        Me.GroupBox1.Controls.Add(Me.cmbObtener)
        Me.GroupBox1.Controls.Add(Me.cmbAux)
        Me.GroupBox1.Controls.Add(Me.txtCampus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEspecialidad)
        Me.GroupBox1.Controls.Add(Me.txtLicenciatura)
        Me.GroupBox1.Controls.Add(Me.txtGrupo)
        Me.GroupBox1.Controls.Add(Me.txtSemestre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.comboMaterias)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1747, 230)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elige la Materia a Calificar"
        '
        'lblParcial
        '
        Me.lblParcial.AutoSize = True
        Me.lblParcial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblParcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParcial.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblParcial.Location = New System.Drawing.Point(653, 185)
        Me.lblParcial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParcial.Name = "lblParcial"
        Me.lblParcial.Size = New System.Drawing.Size(0, 42)
        Me.lblParcial.TabIndex = 58
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Blue
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGuardar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(1288, 175)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(451, 48)
        Me.cmdGuardar.TabIndex = 57
        Me.cmdGuardar.Text = "Guardar Cambios"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'cmbObtener
        '
        Me.cmbObtener.BackColor = System.Drawing.Color.Blue
        Me.cmbObtener.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmbObtener.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbObtener.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbObtener.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.cmbObtener.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cmbObtener.Location = New System.Drawing.Point(12, 175)
        Me.cmbObtener.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbObtener.Name = "cmbObtener"
        Me.cmbObtener.Size = New System.Drawing.Size(451, 48)
        Me.cmbObtener.TabIndex = 56
        Me.cmbObtener.Text = "Obtener Alumnos"
        Me.cmbObtener.UseVisualStyleBackColor = False
        '
        'cmbAux
        '
        Me.cmbAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAux.FormattingEnabled = True
        Me.cmbAux.Location = New System.Drawing.Point(1001, 12)
        Me.cmbAux.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAux.Name = "cmbAux"
        Me.cmbAux.Size = New System.Drawing.Size(299, 26)
        Me.cmbAux.TabIndex = 55
        Me.cmbAux.Visible = False
        '
        'txtCampus
        '
        Me.txtCampus.Enabled = False
        Me.txtCampus.Location = New System.Drawing.Point(156, 135)
        Me.txtCampus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCampus.Name = "txtCampus"
        Me.txtCampus.Size = New System.Drawing.Size(456, 34)
        Me.txtCampus.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 29)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Campus:"
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Enabled = False
        Me.txtEspecialidad.Location = New System.Drawing.Point(827, 138)
        Me.txtEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(911, 34)
        Me.txtEspecialidad.TabIndex = 52
        '
        'txtLicenciatura
        '
        Me.txtLicenciatura.Enabled = False
        Me.txtLicenciatura.Location = New System.Drawing.Point(827, 90)
        Me.txtLicenciatura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLicenciatura.Name = "txtLicenciatura"
        Me.txtLicenciatura.Size = New System.Drawing.Size(911, 34)
        Me.txtLicenciatura.TabIndex = 51
        '
        'txtGrupo
        '
        Me.txtGrupo.Enabled = False
        Me.txtGrupo.Location = New System.Drawing.Point(453, 90)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(159, 34)
        Me.txtGrupo.TabIndex = 50
        '
        'txtSemestre
        '
        Me.txtSemestre.Enabled = False
        Me.txtSemestre.Location = New System.Drawing.Point(156, 87)
        Me.txtSemestre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSemestre.Name = "txtSemestre"
        Me.txtSemestre.Size = New System.Drawing.Size(159, 34)
        Me.txtSemestre.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(647, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 29)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Especialidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(647, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 29)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Licenciatura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Grupo:"
        '
        'comboMaterias
        '
        Me.comboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMaterias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMaterias.FormattingEnabled = True
        Me.comboMaterias.Location = New System.Drawing.Point(12, 34)
        Me.comboMaterias.Margin = New System.Windows.Forms.Padding(4)
        Me.comboMaterias.Name = "comboMaterias"
        Me.comboMaterias.Size = New System.Drawing.Size(1725, 38)
        Me.comboMaterias.TabIndex = 28
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Matricula, Me.APELLIDO_PATERNO, Me.APELLIDO_MATERNO, Me.NOMBRE})
        Me.DG.Location = New System.Drawing.Point(11, 245)
        Me.DG.Margin = New System.Windows.Forms.Padding(4)
        Me.DG.Name = "DG"
        Me.DG.RowTemplate.Height = 24
        Me.DG.Size = New System.Drawing.Size(1733, 773)
        Me.DG.TabIndex = 44
        '
        'Matricula
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matricula.DefaultCellStyle = DataGridViewCellStyle1
        Me.Matricula.HeaderText = "Matricula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.ReadOnly = True
        Me.Matricula.Width = 70
        '
        'APELLIDO_PATERNO
        '
        Me.APELLIDO_PATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.APELLIDO_PATERNO.HeaderText = "APELLIDO PATERNO"
        Me.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.ReadOnly = True
        '
        'APELLIDO_MATERNO
        '
        Me.APELLIDO_MATERNO.HeaderText = "APELLIDO MATERNO"
        Me.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.NOMBRE.DefaultCellStyle = DataGridViewCellStyle2
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 93
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1022)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1779, 25)
        Me.StatusStrip1.TabIndex = 45
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "TOTAL DE ALUMNOS:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(149, 20)
        Me.ToolStripStatusLabel2.Text = "                                   "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 20)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1773, 1071)
        Me.TabControl1.TabIndex = 46
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DG)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1765, 1042)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Captura de Calificaciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1765, 1042)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Impresion de Calificaciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.calificacionesMaestrosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.reporteCalificacionesMaestro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 4)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1757, 1034)
        Me.ReportViewer1.TabIndex = 5
        '
        'calificacionesMaestrosTableAdapter
        '
        Me.calificacionesMaestrosTableAdapter.ClearBeforeFill = True
        '
        'calificacionMaestroFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1779, 1047)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "calificacionMaestroFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Calificaciones"
        CType(Me.calificacionesMaestrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents comboMaterias As System.Windows.Forms.ComboBox
    Friend WithEvents txtCampus As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents txtLicenciatura As System.Windows.Forms.TextBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtSemestre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents Matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO_PATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO_MATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbAux As System.Windows.Forms.ComboBox
    Friend WithEvents cmbObtener As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents lblParcial As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents calificacionesMaestrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportesDT As catalogosIsenco.reportesDT
    Friend WithEvents calificacionesMaestrosTableAdapter As catalogosIsenco.reportesDTTableAdapters.calificacionesMaestrosTableAdapter
End Class
