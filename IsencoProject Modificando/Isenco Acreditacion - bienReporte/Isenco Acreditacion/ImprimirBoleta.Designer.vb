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
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.boletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.acreditacionDataSet = New Isenco_Acreditacion.acreditacionDataSet()
        Me.directivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.directivos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.promedioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.boletaTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.boletaTableAdapter()
        Me.directivosTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivosTableAdapter()
        Me.directivos1TableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.directivos1TableAdapter()
        Me.promedioTableAdapter = New Isenco_Acreditacion.acreditacionDataSetTableAdapters.promedioTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.boletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acreditacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.directivos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.boletaBindingSource
        ReportDataSource10.Name = "DataSet2"
        ReportDataSource10.Value = Me.directivosBindingSource
        ReportDataSource11.Name = "DataSet3"
        ReportDataSource11.Value = Me.directivos1BindingSource
        ReportDataSource12.Name = "DataSet4"
        ReportDataSource12.Value = Me.promedioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Isenco_Acreditacion.Boleta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1042, 408)
        Me.ReportViewer1.TabIndex = 0
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
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
End Class
