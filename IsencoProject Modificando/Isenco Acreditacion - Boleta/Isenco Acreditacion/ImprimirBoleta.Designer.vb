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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.boletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.acreditacionDataSet = New Isenco_Acreditacion.acreditacionDataSet()
        Me.directivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.directivos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.promedioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ciclo_escolarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boletaTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.boletaTableAdapter()
        Me.directivosTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivosTableAdapter()
        Me.directivos1TableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivos1TableAdapter()
        Me.promedioTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.promedioTableAdapter()
        Me.ciclo_escolarTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.ciclo_escolarTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.boletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acreditacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'ciclo_escolarBindingSource
        '
        Me.ciclo_escolarBindingSource.DataMember = "ciclo_escolar"
        Me.ciclo_escolarBindingSource.DataSource = Me.acreditacionDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1042, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
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
        'ciclo_escolarTableAdapter
        '
        Me.ciclo_escolarTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.boletaBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.directivosBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.directivos1BindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.promedioBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.ciclo_escolarBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Isenco_Acreditacion.Boleta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1042, 408)
        Me.ReportViewer1.TabIndex = 0
        '
        'ImprimirBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 432)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ImprimirBoleta"
        Me.Text = "ImprimirBoleta"
        CType(Me.boletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acreditacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.directivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.directivos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boletaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents acreditacionDataSet As Isenco_Acreditacion.acreditacionDataSet
    Friend WithEvents directivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents boletaTableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.boletaTableAdapter
    Friend WithEvents directivosTableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivosTableAdapter
    Friend WithEvents directivos1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents directivos1TableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivos1TableAdapter
    Friend WithEvents promedioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents promedioTableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.promedioTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ciclo_escolarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ciclo_escolarTableAdapter As Isenco_Acreditacion.acreditacionDataSetTableAdapters.ciclo_escolarTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
