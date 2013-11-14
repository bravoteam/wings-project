<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class credencialFrm
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.isencoDataSet = New catalogosIsenco.isencoDataSet()
        Me.LISTA_FOTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LISTA_FOTOSTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.LISTA_FOTOSTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTA_FOTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "listaAsistenciaDT"
        ReportDataSource2.Value = Me.LISTA_FOTOSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.credencialRpt.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1159, 614)
        Me.ReportViewer1.TabIndex = 0
        '
        'isencoDataSet
        '
        Me.isencoDataSet.DataSetName = "isencoDataSet"
        Me.isencoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LISTA_FOTOSBindingSource
        '
        Me.LISTA_FOTOSBindingSource.DataMember = "LISTA_FOTOS"
        Me.LISTA_FOTOSBindingSource.DataSource = Me.isencoDataSet
        '
        'LISTA_FOTOSTableAdapter
        '
        Me.LISTA_FOTOSTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1159, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'credencialFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 638)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "credencialFrm"
        Me.Text = "Impresion de Credenciales"
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTA_FOTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LISTA_FOTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents isencoDataSet As catalogosIsenco.isencoDataSet
    Friend WithEvents LISTA_FOTOSTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.LISTA_FOTOSTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
