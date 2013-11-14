<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estadisticasFinalFrm
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.estadisticasfinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportesDT = New catalogosIsenco.reportesDT()
        Me.estadisticasfinalTableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinalTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.estadisticasfinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.estadisticasfinalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.estadisticasgrupales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1319, 574)
        Me.ReportViewer1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1319, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'estadisticasfinalBindingSource
        '
        Me.estadisticasfinalBindingSource.DataMember = "estadisticasfinal"
        Me.estadisticasfinalBindingSource.DataSource = Me.reportesDT
        '
        'reportesDT
        '
        Me.reportesDT.DataSetName = "reportesDT"
        Me.reportesDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'estadisticasfinalTableAdapter
        '
        Me.estadisticasfinalTableAdapter.ClearBeforeFill = True
        '
        'estadisticasFinalFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 574)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "estadisticasFinalFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadisticas Finales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.estadisticasfinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents estadisticasfinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportesDT As catalogosIsenco.reportesDT
    Friend WithEvents estadisticasfinalTableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinalTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
