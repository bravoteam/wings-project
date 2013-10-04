<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirBoleta
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.boletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.acreditacionDataSet = New Isenco_Acreditacion.acreditacionDataSet()
        Me.directivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.directivos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.promedioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.boletaTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.boletaTableAdapter()
        Me.directivosTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivosTableAdapter()
        Me.directivos1TableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivos1TableAdapter()
        Me.promedioTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.promedioTableAdapter()
        CType(Me.boletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acreditacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.boletaBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.directivosBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.directivos1BindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.promedioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Isenco_Acreditacion.Boleta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1018, 378)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'boletaBindingSource
        '
        Me.boletaBindingSource.DataMember = "boleta"
        Me.boletaBindingSource.DataSource = Me.acreditacionDataSet
        '
        'acreditacionDataSet
        '
        Me.acreditacionDataSet.DataSetName = "acreditacionDataSet"
        Me.acreditacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'directivosBindingSource
        '
        Me.directivosBindingSource.DataMember = "directivos"
        Me.directivosBindingSource.DataSource = Me.acreditacionDataSet
        '
        'directivos1BindingSource
        '
        Me.directivos1BindingSource.DataMember = "directivos1"
        Me.directivos1BindingSource.DataSource = Me.acreditacionDataSet
        '
        'promedioBindingSource
        '
        Me.promedioBindingSource.DataMember = "promedio"
        Me.promedioBindingSource.DataSource = Me.acreditacionDataSet
        '
        'boletaTableAdapter
        '
        Me.boletaTableAdapter.ClearBeforeFill = True
        '
        'directivosTableAdapter
        '
        Me.directivosTableAdapter.ClearBeforeFill = True
        '
        'directivos1TableAdapter
        '
        Me.directivos1TableAdapter.ClearBeforeFill = True
        '
        'promedioTableAdapter
        '
        Me.promedioTableAdapter.ClearBeforeFill = True
        '
        'ImprimirBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 432)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ImprimirBoleta"
        Me.Text = "ImprimirBoleta"
        CType(Me.boletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acreditacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.directivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.directivos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents boletaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents acreditacionDataSet As Isenco_Acreditacion.acreditacionDataSet
    Friend WithEvents directivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents boletaTableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.boletaTableAdapter
    Friend WithEvents directivosTableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivosTableAdapter
    Friend WithEvents directivos1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents directivos1TableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivos1TableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents promedioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents promedioTableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.promedioTableAdapter
End Class
