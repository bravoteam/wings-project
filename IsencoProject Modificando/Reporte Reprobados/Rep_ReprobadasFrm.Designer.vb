<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpt_ReprobadasFrm
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Reporte_EspecificoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New REPORTE_DE_REPROBADOS.DataSet1()
        Me.Reporte_GeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkRptgral = New System.Windows.Forms.CheckBox()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLicenciatura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCampus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.consultarcmd = New System.Windows.Forms.Button()
        Me.cmdGrupo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Reporte_GeneralTableAdapter = New REPORTE_DE_REPROBADOS.DataSet1TableAdapters.Reporte_GeneralTableAdapter()
        Me.Reporte_EspecificoTableAdapter = New REPORTE_DE_REPROBADOS.DataSet1TableAdapters.Reporte_EspecificoTableAdapter()
        CType(Me.Reporte_EspecificoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reporte_GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reporte_EspecificoBindingSource
        '
        Me.Reporte_EspecificoBindingSource.DataMember = "Reporte_Especifico"
        Me.Reporte_EspecificoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reporte_GeneralBindingSource
        '
        Me.Reporte_GeneralBindingSource.DataMember = "Reporte_General"
        Me.Reporte_GeneralBindingSource.DataSource = Me.DataSet1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChkRptgral)
        Me.Panel1.Controls.Add(Me.cmbTurno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbEspecialidad)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbLicenciatura)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbCampus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSemestre)
        Me.Panel1.Controls.Add(Me.consultarcmd)
        Me.Panel1.Controls.Add(Me.cmdGrupo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1323, 150)
        Me.Panel1.TabIndex = 19
        '
        'ChkRptgral
        '
        Me.ChkRptgral.AutoSize = True
        Me.ChkRptgral.Location = New System.Drawing.Point(439, 107)
        Me.ChkRptgral.Name = "ChkRptgral"
        Me.ChkRptgral.Size = New System.Drawing.Size(136, 21)
        Me.ChkRptgral.TabIndex = 27
        Me.ChkRptgral.Text = "Reporte General"
        Me.ChkRptgral.UseVisualStyleBackColor = True
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"TM", "TV"})
        Me.cmbTurno.Location = New System.Drawing.Point(1011, 63)
        Me.cmbTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(296, 24)
        Me.cmbTurno.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(887, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "TURNO:"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(1011, 15)
        Me.cmbEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(296, 24)
        Me.cmbEspecialidad.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(887, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ESPECIALIDAD:"
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(439, 15)
        Me.cmbLicenciatura.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(439, 24)
        Me.cmbLicenciatura.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "LICENCIATURA:"
        '
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(104, 15)
        Me.cmbCampus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(212, 24)
        Me.cmbCampus.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "CAMPUS:"
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(104, 64)
        Me.cmbSemestre.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(212, 24)
        Me.cmbSemestre.TabIndex = 4
        '
        'consultarcmd
        '
        Me.consultarcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmd.Location = New System.Drawing.Point(104, 97)
        Me.consultarcmd.Margin = New System.Windows.Forms.Padding(4)
        Me.consultarcmd.Name = "consultarcmd"
        Me.consultarcmd.Size = New System.Drawing.Size(227, 36)
        Me.consultarcmd.TabIndex = 18
        Me.consultarcmd.Text = "Consultar"
        Me.consultarcmd.UseVisualStyleBackColor = True
        '
        'cmdGrupo
        '
        Me.cmdGrupo.FormattingEnabled = True
        Me.cmdGrupo.Location = New System.Drawing.Point(439, 64)
        Me.cmdGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGrupo.Name = "cmdGrupo"
        Me.cmdGrupo.Size = New System.Drawing.Size(439, 24)
        Me.cmdGrupo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "SEMESTRE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "GRUPO:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ReportViewer2)
        Me.Panel2.Controls.Add(Me.ReportViewer1)
        Me.Panel2.Location = New System.Drawing.Point(15, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1318, 588)
        Me.Panel2.TabIndex = 20
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Reporte_EspecificoBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "REPORTE_DE_REPROBADOS.ReporteReprobadas_espec.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(8, 17)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1297, 568)
        Me.ReportViewer2.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Reporte_GeneralBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "REPORTE_DE_REPROBADOS.ReporteReprobadas_gral.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 17)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1297, 568)
        Me.ReportViewer1.TabIndex = 0
        '
        'Reporte_GeneralTableAdapter
        '
        Me.Reporte_GeneralTableAdapter.ClearBeforeFill = True
        '
        'Reporte_EspecificoTableAdapter
        '
        Me.Reporte_EspecificoTableAdapter.ClearBeforeFill = True
        '
        'Rpt_ReprobadasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 770)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Rpt_ReprobadasFrm"
        Me.Text = "Reportes de Calificaciones"
        CType(Me.Reporte_EspecificoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reporte_GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ChkRptgral As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents consultarcmd As System.Windows.Forms.Button
    Friend WithEvents cmdGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reporte_GeneralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As REPORTE_DE_REPROBADOS.DataSet1
    Friend WithEvents Reporte_GeneralTableAdapter As REPORTE_DE_REPROBADOS.DataSet1TableAdapters.Reporte_GeneralTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reporte_EspecificoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reporte_EspecificoTableAdapter As REPORTE_DE_REPROBADOS.DataSet1TableAdapters.Reporte_EspecificoTableAdapter

End Class
