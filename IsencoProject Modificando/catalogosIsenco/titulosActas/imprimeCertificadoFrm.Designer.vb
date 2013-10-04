<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimeCertificadoFrm
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.certificadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.isencoDataSet = New catalogosIsenco.isencoDataSet()
        Me.primerSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.segundoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tercerSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cuartoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.quintoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sextoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.septimoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.octavoSemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.certificadosTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.certificadosTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.primerSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.primerSemestreTableAdapter()
        Me.segundoSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.segundoSemestreTableAdapter()
        Me.tercerSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.tercerSemestreTableAdapter()
        Me.cuartoSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.cuartoSemestreTableAdapter()
        Me.quintoSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.quintoSemestreTableAdapter()
        Me.sextoSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.sextoSemestreTableAdapter()
        Me.septimoSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.septimoSemestreTableAdapter()
        Me.octavoSemestreTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.octavoSemestreTableAdapter()
        CType(Me.certificadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.primerSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.segundoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tercerSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cuartoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quintoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sextoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.septimoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.octavoSemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'certificadosBindingSource
        '
        Me.certificadosBindingSource.DataMember = "certificados"
        Me.certificadosBindingSource.DataSource = Me.isencoDataSet
        '
        'isencoDataSet
        '
        Me.isencoDataSet.DataSetName = "isencoDataSet"
        Me.isencoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'primerSemestreBindingSource
        '
        Me.primerSemestreBindingSource.DataMember = "primerSemestre"
        Me.primerSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'segundoSemestreBindingSource
        '
        Me.segundoSemestreBindingSource.DataMember = "segundoSemestre"
        Me.segundoSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'tercerSemestreBindingSource
        '
        Me.tercerSemestreBindingSource.DataMember = "tercerSemestre"
        Me.tercerSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'cuartoSemestreBindingSource
        '
        Me.cuartoSemestreBindingSource.DataMember = "cuartoSemestre"
        Me.cuartoSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'quintoSemestreBindingSource
        '
        Me.quintoSemestreBindingSource.DataMember = "quintoSemestre"
        Me.quintoSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'sextoSemestreBindingSource
        '
        Me.sextoSemestreBindingSource.DataMember = "sextoSemestre"
        Me.sextoSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'septimoSemestreBindingSource
        '
        Me.septimoSemestreBindingSource.DataMember = "septimoSemestre"
        Me.septimoSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'octavoSemestreBindingSource
        '
        Me.octavoSemestreBindingSource.DataMember = "octavoSemestre"
        Me.octavoSemestreBindingSource.DataSource = Me.isencoDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.certificadosBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.primerSemestreBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.segundoSemestreBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Certificado_cara.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 4)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1579, 779)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.tercerSemestreBindingSource
        ReportDataSource5.Name = "DataSet2"
        ReportDataSource5.Value = Me.cuartoSemestreBindingSource
        ReportDataSource6.Name = "DataSet3"
        ReportDataSource6.Value = Me.quintoSemestreBindingSource
        ReportDataSource7.Name = "DataSet4"
        ReportDataSource7.Value = Me.sextoSemestreBindingSource
        ReportDataSource8.Name = "DataSet5"
        ReportDataSource8.Value = Me.septimoSemestreBindingSource
        ReportDataSource9.Name = "DataSet6"
        ReportDataSource9.Value = Me.octavoSemestreBindingSource
        ReportDataSource10.Name = "DataSet7"
        ReportDataSource10.Value = Me.certificadosBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Certificado_contra.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(4, 4)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1575, 776)
        Me.ReportViewer2.TabIndex = 1
        '
        'certificadosTableAdapter
        '
        Me.certificadosTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1627, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 33)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1595, 816)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1587, 787)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cara"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1587, 787)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contra"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'primerSemestreTableAdapter
        '
        Me.primerSemestreTableAdapter.ClearBeforeFill = True
        '
        'segundoSemestreTableAdapter
        '
        Me.segundoSemestreTableAdapter.ClearBeforeFill = True
        '
        'tercerSemestreTableAdapter
        '
        Me.tercerSemestreTableAdapter.ClearBeforeFill = True
        '
        'cuartoSemestreTableAdapter
        '
        Me.cuartoSemestreTableAdapter.ClearBeforeFill = True
        '
        'quintoSemestreTableAdapter
        '
        Me.quintoSemestreTableAdapter.ClearBeforeFill = True
        '
        'sextoSemestreTableAdapter
        '
        Me.sextoSemestreTableAdapter.ClearBeforeFill = True
        '
        'septimoSemestreTableAdapter
        '
        Me.septimoSemestreTableAdapter.ClearBeforeFill = True
        '
        'octavoSemestreTableAdapter
        '
        Me.octavoSemestreTableAdapter.ClearBeforeFill = True
        '
        'imprimeCertificadoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1627, 871)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "imprimeCertificadoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Certificados"
        CType(Me.certificadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.primerSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.segundoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tercerSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cuartoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quintoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sextoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.septimoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.octavoSemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents certificadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents isencoDataSet As catalogosIsenco.isencoDataSet
    Friend WithEvents certificadosTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.certificadosTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents primerSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents segundoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents primerSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.primerSemestreTableAdapter
    Friend WithEvents segundoSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.segundoSemestreTableAdapter
    Friend WithEvents tercerSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cuartoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents quintoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sextoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents septimoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents octavoSemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tercerSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.tercerSemestreTableAdapter
    Friend WithEvents cuartoSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.cuartoSemestreTableAdapter
    Friend WithEvents quintoSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.quintoSemestreTableAdapter
    Friend WithEvents sextoSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.sextoSemestreTableAdapter
    Friend WithEvents septimoSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.septimoSemestreTableAdapter
    Friend WithEvents octavoSemestreTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.octavoSemestreTableAdapter
End Class
