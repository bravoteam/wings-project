<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Primera_segunda
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GenerarPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPDFToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportesDT = New Reportes_Isenco.ReportesDT()
        Me.calificaciones2parcial1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.calificaciones2parcial1TableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.calificaciones2parcial1TableAdapter()
        Me.MujeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MujeresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.MujeresTableAdapter()
        Me.HombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HombresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.HombresTableAdapter()
        Me.TotalHombresMujeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalHombresMujeresTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.TotalHombresMujeresTableAdapter()
        Me.ciclo_escolarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ciclo_escolarTableAdapter = New Reportes_Isenco.ReportesDTTableAdapters.ciclo_escolarTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ReportesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calificaciones2parcial1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalHombresMujeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPDFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 28)
        Me.MenuStrip1.TabIndex = 3
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
        'ReportViewer1
        '
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.calificaciones2parcial1BindingSource
        ReportDataSource7.Name = "DataSet2"
        ReportDataSource7.Value = Me.MujeresBindingSource
        ReportDataSource8.Name = "DataSet3"
        ReportDataSource8.Value = Me.HombresBindingSource
        ReportDataSource9.Name = "DataSet4"
        ReportDataSource9.Value = Me.TotalHombresMujeresBindingSource
        ReportDataSource10.Name = "DataSet5"
        ReportDataSource10.Value = Me.ciclo_escolarBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Reportes_Isenco.Reporte_Primera_Segunda_Parcial.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 37)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1080, 612)
        Me.ReportViewer1.TabIndex = 4
        '
        'ReportesDT
        '
        Me.ReportesDT.DataSetName = "ReportesDT"
        Me.ReportesDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'calificaciones2parcial1BindingSource
        '
        Me.calificaciones2parcial1BindingSource.DataMember = "calificaciones2parcial1"
        Me.calificaciones2parcial1BindingSource.DataSource = Me.ReportesDT
        '
        'calificaciones2parcial1TableAdapter
        '
        Me.calificaciones2parcial1TableAdapter.ClearBeforeFill = True
        '
        'MujeresBindingSource
        '
        Me.MujeresBindingSource.DataMember = "Mujeres"
        Me.MujeresBindingSource.DataSource = Me.ReportesDT
        '
        'MujeresTableAdapter
        '
        Me.MujeresTableAdapter.ClearBeforeFill = True
        '
        'HombresBindingSource
        '
        Me.HombresBindingSource.DataMember = "Hombres"
        Me.HombresBindingSource.DataSource = Me.ReportesDT
        '
        'HombresTableAdapter
        '
        Me.HombresTableAdapter.ClearBeforeFill = True
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
        'ciclo_escolarBindingSource
        '
        Me.ciclo_escolarBindingSource.DataMember = "ciclo_escolar"
        Me.ciclo_escolarBindingSource.DataSource = Me.ReportesDT
        '
        'ciclo_escolarTableAdapter
        '
        Me.ciclo_escolarTableAdapter.ClearBeforeFill = True
        '
        'Reporte_Primera_segunda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 658)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Reporte_Primera_segunda"
        Me.Text = "Reporte Primera y Segunda Parcial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ReportesDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calificaciones2parcial1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalHombresMujeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GenerarPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPDFToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents calificaciones2parcial1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportesDT As Reportes_Isenco.ReportesDT
    Friend WithEvents MujeresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HombresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalHombresMujeresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ciclo_escolarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents calificaciones2parcial1TableAdapter As Reportes_Isenco.ReportesDTTableAdapters.calificaciones2parcial1TableAdapter
    Friend WithEvents MujeresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.MujeresTableAdapter
    Friend WithEvents HombresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.HombresTableAdapter
    Friend WithEvents TotalHombresMujeresTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.TotalHombresMujeresTableAdapter
    Friend WithEvents ciclo_escolarTableAdapter As Reportes_Isenco.ReportesDTTableAdapters.ciclo_escolarTableAdapter
End Class
