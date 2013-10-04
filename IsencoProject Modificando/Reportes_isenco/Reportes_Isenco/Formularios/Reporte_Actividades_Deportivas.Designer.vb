<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Actividades_Deportivas
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
        Me.MujeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDT = New Reportes_Isenco.ReportesDT()
        Me.HombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalHombresMujeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ciclo_escolarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Actividades_culturales_deportivasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MujeresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.MujeresTableAdapter()
        Me.HombresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.HombresTableAdapter()
        Me.TotalHombresMujeresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.TotalHombresMujeresTableAdapter()
        Me.ciclo_escolarTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.ciclo_escolarTableAdapter()
        Me.Actividades_culturales_deportivasTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.Actividades_culturales_deportivasTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GenerarPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPDFToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalHombresMujeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Actividades_culturales_deportivasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MujeresBindingSource
        '
        Me.MujeresBindingSource.DataMember = "Mujeres"
        Me.MujeresBindingSource.DataSource = Me.ReportesDT
        '
        'ReportesDT
        '
        Me.ReportesDT.DataSetName = "ReportesDT"
        Me.ReportesDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HombresBindingSource
        '
        Me.HombresBindingSource.DataMember = "Hombres"
        Me.HombresBindingSource.DataSource = Me.ReportesDT
        '
        'TotalHombresMujeresBindingSource
        '
        Me.TotalHombresMujeresBindingSource.DataMember = "TotalHombresMujeres"
        Me.TotalHombresMujeresBindingSource.DataSource = Me.ReportesDT
        '
        'ciclo_escolarBindingSource
        '
        Me.ciclo_escolarBindingSource.DataMember = "ciclo_escolar"
        Me.ciclo_escolarBindingSource.DataSource = Me.ReportesDT
        '
        'Actividades_culturales_deportivasBindingSource
        '
        Me.Actividades_culturales_deportivasBindingSource.DataMember = "Actividades_culturales_deportivas"
        Me.Actividades_culturales_deportivasBindingSource.DataSource = Me.ReportesDT
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.MujeresBindingSource
        ReportDataSource2.Name = "DataSet3"
        ReportDataSource2.Value = Me.HombresBindingSource
        ReportDataSource3.Name = "DataSet4"
        ReportDataSource3.Value = Me.TotalHombresMujeresBindingSource
        ReportDataSource4.Name = "DataSet5"
        ReportDataSource4.Value = Me.ciclo_escolarBindingSource
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.Actividades_culturales_deportivasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Reportes_Isenco.Reporte_Actividades_cult_deport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(11, 28)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(809, 491)
        Me.ReportViewer1.TabIndex = 0
        '
        'MujeresTableAdapter
        '
        Me.MujeresTableAdapter.ClearBeforeFill = True
        '
        'HombresTableAdapter
        '
        Me.HombresTableAdapter.ClearBeforeFill = True
        '
        'TotalHombresMujeresTableAdapter
        '
        Me.TotalHombresMujeresTableAdapter.ClearBeforeFill = True
        '
        'ciclo_escolarTableAdapter
        '
        Me.ciclo_escolarTableAdapter.ClearBeforeFill = True
        '
        'Actividades_culturales_deportivasTableAdapter
        '
        Me.Actividades_culturales_deportivasTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPDFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GenerarPDFToolStripMenuItem
        '
        Me.GenerarPDFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPDFToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.GenerarPDFToolStripMenuItem.Name = "GenerarPDFToolStripMenuItem"
        Me.GenerarPDFToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GenerarPDFToolStripMenuItem.Text = "Opciones"
        '
        'GenerarPDFToolStripMenuItem1
        '
        Me.GenerarPDFToolStripMenuItem1.Name = "GenerarPDFToolStripMenuItem1"
        Me.GenerarPDFToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.GenerarPDFToolStripMenuItem1.Text = "Generar PDF"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Reporte_Actividades_Deportivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 535)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Reporte_Actividades_Deportivas"
        Me.Text = "Reporte Actividades Culturales y Deportivas"
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalHombresMujeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Actividades_culturales_deportivasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MujeresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportesDT As Reportes_Isenco.ReportesDT
    Friend WithEvents HombresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalHombresMujeresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ciclo_escolarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Actividades_culturales_deportivasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MujeresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.MujeresTableAdapter
    Friend WithEvents HombresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.HombresTableAdapter
    Friend WithEvents TotalHombresMujeresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.TotalHombresMujeresTableAdapter
    Friend WithEvents ciclo_escolarTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.ciclo_escolarTableAdapter
    Friend WithEvents Actividades_culturales_deportivasTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.Actividades_culturales_deportivasTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GenerarPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPDFToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
