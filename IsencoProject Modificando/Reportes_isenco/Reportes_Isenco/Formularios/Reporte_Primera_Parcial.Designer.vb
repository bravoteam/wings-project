<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Primera_Parcial
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GenerarPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPDFToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.calificaciones1parcialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDT = New Reportes_Isenco.ReportesDT()
        Me.MujeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalHombresMujeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalHombresMujeresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.TotalHombresMujeresTableAdapter()
        Me.calificaciones1parcialTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.calificaciones1parcialTableAdapter()
        Me.MujeresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.MujeresTableAdapter()
        Me.HombresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.HombresTableAdapter()
        Me.CicloescolarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ciclo_escolarTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.ciclo_escolarTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.calificaciones1parcialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalHombresMujeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CicloescolarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.calificaciones1parcialBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.MujeresBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.HombresBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.TotalHombresMujeresBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.CicloescolarBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Reportes_Isenco.Reporte_Primera_Parcial.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(18, 34)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1080, 612)
        Me.ReportViewer1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPDFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GenerarPDFToolStripMenuItem
        '
        Me.GenerarPDFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPDFToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.GenerarPDFToolStripMenuItem.Name = "GenerarPDFToolStripMenuItem"
        Me.GenerarPDFToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.GenerarPDFToolStripMenuItem.Text = "Opciones"
        '
        'GenerarPDFToolStripMenuItem1
        '
        Me.GenerarPDFToolStripMenuItem1.Name = "GenerarPDFToolStripMenuItem1"
        Me.GenerarPDFToolStripMenuItem1.Size = New System.Drawing.Size(160, 24)
        Me.GenerarPDFToolStripMenuItem1.Text = "Generar PDF"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'calificaciones1parcialBindingSource
        '
        Me.calificaciones1parcialBindingSource.DataMember = "calificaciones1parcial"
        Me.calificaciones1parcialBindingSource.DataSource = Me.ReportesDT
        '
        'ReportesDT
        '
        Me.ReportesDT.DataSetName = "ReportesDT"
        Me.ReportesDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MujeresBindingSource
        '
        Me.MujeresBindingSource.DataMember = "Mujeres"
        Me.MujeresBindingSource.DataSource = Me.ReportesDT
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
        'TotalHombresMujeresTableAdapter
        '
        Me.TotalHombresMujeresTableAdapter.ClearBeforeFill = True
        '
        'calificaciones1parcialTableAdapter
        '
        Me.calificaciones1parcialTableAdapter.ClearBeforeFill = True
        '
        'MujeresTableAdapter
        '
        Me.MujeresTableAdapter.ClearBeforeFill = True
        '
        'HombresTableAdapter
        '
        Me.HombresTableAdapter.ClearBeforeFill = True
        '
        'CicloescolarBindingSource
        '
        Me.CicloescolarBindingSource.DataMember = "ciclo_escolar"
        Me.CicloescolarBindingSource.DataSource = Me.ReportesDT
        '
        'Ciclo_escolarTableAdapter
        '
        Me.Ciclo_escolarTableAdapter.ClearBeforeFill = True
        '
        'Reporte_Primera_Parcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 658)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte_Primera_Parcial"
        Me.Text = "Reporte Primera Parcial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.calificaciones1parcialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalHombresMujeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CicloescolarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TotalHombresMujeresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.TotalHombresMujeresTableAdapter
    Friend WithEvents calificaciones1parcialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportesDT As Reportes_Isenco.ReportesDT
    Friend WithEvents MujeresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HombresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalHombresMujeresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents calificaciones1parcialTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.calificaciones1parcialTableAdapter
    Friend WithEvents MujeresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.MujeresTableAdapter
    Friend WithEvents HombresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.HombresTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GenerarPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPDFToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CicloescolarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ciclo_escolarTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.ciclo_escolarTableAdapter
End Class
