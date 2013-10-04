<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimirBoleta
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
        Me.ciclo_escolarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.isencoDataSet = New catalogosIsenco.isencoDataSet()
        Me.boletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.directivos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.promedioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.directivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.boletaTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.boletaTableAdapter()
        Me.directivosTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.directivosTableAdapter()
        Me.directivos1TableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.directivos1TableAdapter()
        Me.promedioTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.promedioTableAdapter()
        Me.ciclo_escolarTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.ciclo_escolarTableAdapter()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ciclo_escolarBindingSource
        '
        Me.ciclo_escolarBindingSource.DataMember = "ciclo_escolar"
        Me.ciclo_escolarBindingSource.DataSource = Me.isencoDataSet
        '
        'isencoDataSet
        '
        Me.isencoDataSet.DataSetName = "isencoDataSet"
        Me.isencoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'boletaBindingSource
        '
        Me.boletaBindingSource.DataMember = "boleta"
        Me.boletaBindingSource.DataSource = Me.isencoDataSet
        '
        'directivos1BindingSource
        '
        Me.directivos1BindingSource.DataMember = "directivos1"
        Me.directivos1BindingSource.DataSource = Me.isencoDataSet
        '
        'promedioBindingSource
        '
        Me.promedioBindingSource.DataMember = "promedio"
        Me.promedioBindingSource.DataSource = Me.isencoDataSet
        '
        'directivosBindingSource
        '
        Me.directivosBindingSource.DataMember = "directivos"
        Me.directivosBindingSource.DataSource = Me.isencoDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1015, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet5"
        ReportDataSource1.Value = Me.ciclo_escolarBindingSource
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.boletaBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.directivos1BindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.promedioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Boleta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1015, 447)
        Me.ReportViewer1.TabIndex = 1
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
        'imprimirBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "imprimirBoleta"
        Me.Text = "Imprimir Boleta"
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.directivos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.directivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents boletaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents isencoDataSet As catalogosIsenco.isencoDataSet
    Friend WithEvents directivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents directivos1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents promedioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ciclo_escolarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents boletaTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.boletaTableAdapter
    Friend WithEvents directivosTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.directivosTableAdapter
    Friend WithEvents directivos1TableAdapter As catalogosIsenco.isencoDataSetTableAdapters.directivos1TableAdapter
    Friend WithEvents promedioTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.promedioTableAdapter
    Friend WithEvents ciclo_escolarTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.ciclo_escolarTableAdapter
End Class
