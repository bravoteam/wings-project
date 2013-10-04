<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmreporte
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
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource13 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource14 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource15 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource16 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource17 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource18 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource19 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource20 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.isencoDataSet = New isencoCertificados.isencoDataSet()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.certificadosTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.certificadosTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IsencoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimerSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimerSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.primerSemestreTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegundoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegundoSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.segundoSemestreTableAdapter()
        Me.TercerSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TercerSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.tercerSemestreTableAdapter()
        Me.CuartoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuartoSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.cuartoSemestreTableAdapter()
        Me.QuintoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuintoSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.quintoSemestreTableAdapter()
        Me.SextoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SextoSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.sextoSemestreTableAdapter()
        Me.SeptimoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeptimoSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.septimoSemestreTableAdapter()
        Me.OctavoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OctavoSemestreTableAdapter = New isencoCertificados.isencoDataSetTableAdapters.octavoSemestreTableAdapter()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsencoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimerSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TercerSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuartoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuintoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SextoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeptimoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OctavoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'isencoDataSet
        '
        Me.isencoDataSet.DataSetName = "isencoDataSet"
        Me.isencoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(9, 2)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(94, 33)
        Me.btnprint.TabIndex = 1
        Me.btnprint.Text = "IMPRIMIR"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource11.Name = "DataSet1"
        ReportDataSource11.Value = Me.BindingSource1
        ReportDataSource12.Name = "DataSet2"
        ReportDataSource12.Value = Me.PrimerSemestreBindingSource
        ReportDataSource13.Name = "DataSet3"
        ReportDataSource13.Value = Me.SegundoSemestreBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource13)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "isencoCertificados.Certificado_cara.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 37)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(912, 266)
        Me.ReportViewer1.TabIndex = 2
        '
        'certificadosTableAdapter
        '
        Me.certificadosTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource14.Name = "DataSet7"
        ReportDataSource14.Value = Me.BindingSource2
        ReportDataSource15.Name = "DataSet1"
        ReportDataSource15.Value = Me.TercerSemestreBindingSource
        ReportDataSource16.Name = "DataSet2"
        ReportDataSource16.Value = Me.CuartoSemestreBindingSource
        ReportDataSource17.Name = "DataSet3"
        ReportDataSource17.Value = Me.QuintoSemestreBindingSource
        ReportDataSource18.Name = "DataSet4"
        ReportDataSource18.Value = Me.SextoSemestreBindingSource
        ReportDataSource19.Name = "DataSet5"
        ReportDataSource19.Value = Me.SeptimoSemestreBindingSource
        ReportDataSource20.Name = "DataSet6"
        ReportDataSource20.Value = Me.OctavoSemestreBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource14)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource15)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource16)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource17)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource18)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource19)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource20)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "isencoCertificados.Certificado_contra.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(9, 308)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(912, 261)
        Me.ReportViewer2.TabIndex = 3
        '
        'IsencoDataSetBindingSource
        '
        Me.IsencoDataSetBindingSource.DataSource = Me.isencoDataSet
        Me.IsencoDataSetBindingSource.Position = 0
        '
        'PrimerSemestreBindingSource
        '
        Me.PrimerSemestreBindingSource.DataMember = "primerSemestre"
        Me.PrimerSemestreBindingSource.DataSource = Me.IsencoDataSetBindingSource
        '
        'PrimerSemestreTableAdapter
        '
        Me.PrimerSemestreTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "certificados"
        Me.BindingSource1.DataSource = Me.IsencoDataSetBindingSource
        '
        'SegundoSemestreBindingSource
        '
        Me.SegundoSemestreBindingSource.DataMember = "segundoSemestre"
        Me.SegundoSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'SegundoSemestreTableAdapter
        '
        Me.SegundoSemestreTableAdapter.ClearBeforeFill = True
        '
        'TercerSemestreBindingSource
        '
        Me.TercerSemestreBindingSource.DataMember = "tercerSemestre"
        Me.TercerSemestreBindingSource.DataSource = Me.IsencoDataSetBindingSource
        '
        'TercerSemestreTableAdapter
        '
        Me.TercerSemestreTableAdapter.ClearBeforeFill = True
        '
        'CuartoSemestreBindingSource
        '
        Me.CuartoSemestreBindingSource.DataMember = "cuartoSemestre"
        Me.CuartoSemestreBindingSource.DataSource = Me.IsencoDataSetBindingSource
        '
        'CuartoSemestreTableAdapter
        '
        Me.CuartoSemestreTableAdapter.ClearBeforeFill = True
        '
        'QuintoSemestreBindingSource
        '
        Me.QuintoSemestreBindingSource.DataMember = "quintoSemestre"
        Me.QuintoSemestreBindingSource.DataSource = Me.IsencoDataSetBindingSource
        '
        'QuintoSemestreTableAdapter
        '
        Me.QuintoSemestreTableAdapter.ClearBeforeFill = True
        '
        'SextoSemestreBindingSource
        '
        Me.SextoSemestreBindingSource.DataMember = "sextoSemestre"
        Me.SextoSemestreBindingSource.DataSource = Me.IsencoDataSetBindingSource
        '
        'SextoSemestreTableAdapter
        '
        Me.SextoSemestreTableAdapter.ClearBeforeFill = True
        '
        'SeptimoSemestreBindingSource
        '
        Me.SeptimoSemestreBindingSource.DataMember = "septimoSemestre"
        Me.SeptimoSemestreBindingSource.DataSource = Me.IsencoDataSetBindingSource
        '
        'SeptimoSemestreTableAdapter
        '
        Me.SeptimoSemestreTableAdapter.ClearBeforeFill = True
        '
        'OctavoSemestreBindingSource
        '
        Me.OctavoSemestreBindingSource.DataMember = "octavoSemestre"
        Me.OctavoSemestreBindingSource.DataSource = Me.IsencoDataSetBindingSource
        '
        'OctavoSemestreTableAdapter
        '
        Me.OctavoSemestreTableAdapter.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "certificados"
        Me.BindingSource2.DataSource = Me.IsencoDataSetBindingSource
        '
        'Frmreporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 578)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnprint)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frmreporte"
        Me.Text = "Certificado Viewer"
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsencoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimerSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TercerSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuartoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuintoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SextoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeptimoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OctavoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents certificadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents isencoDataSet As isencoCertificados.isencoDataSet
    Friend WithEvents certificadosTableAdapter As isencoCertificados.isencoDataSetTableAdapters.certificadosTableAdapter
    Friend WithEvents certificado_PRIMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CertificadoSEGUNDOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents certificado_SEGUNDOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents certificado_terceroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents certificado_CuartoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents certificado_QUINTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents certificado_SEXTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents certificado_SEPTIMOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents certificado_OCTAVOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CertificadosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IsencoDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimerSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SegundoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TercerSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuartoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuintoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SextoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeptimoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OctavoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimerSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.primerSemestreTableAdapter
    Friend WithEvents SegundoSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.segundoSemestreTableAdapter
    Friend WithEvents TercerSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.tercerSemestreTableAdapter
    Friend WithEvents CuartoSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.cuartoSemestreTableAdapter
    Friend WithEvents QuintoSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.quintoSemestreTableAdapter
    Friend WithEvents SextoSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.sextoSemestreTableAdapter
    Friend WithEvents SeptimoSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.septimoSemestreTableAdapter
    Friend WithEvents OctavoSemestreTableAdapter As isencoCertificados.isencoDataSetTableAdapters.octavoSemestreTableAdapter
End Class
