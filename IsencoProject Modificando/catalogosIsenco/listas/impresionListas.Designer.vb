<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class impresionListas
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
        Me.Lista_AsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.isencoDataSet = New catalogosIsenco.isencoDataSet()
        Me.LISTA2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Lista_AsistenciaTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.Lista_AsistenciaTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LISTA2TableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.LISTA2TableAdapter()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Lista_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTA2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lista_AsistenciaBindingSource
        '
        Me.Lista_AsistenciaBindingSource.DataMember = "Lista_Asistencia"
        Me.Lista_AsistenciaBindingSource.DataSource = Me.isencoDataSet
        '
        'isencoDataSet
        '
        Me.isencoDataSet.DataSetName = "isencoDataSet"
        Me.isencoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LISTA2BindingSource
        '
        Me.LISTA2BindingSource.DataMember = "LISTA2"
        Me.LISTA2BindingSource.DataSource = Me.isencoDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "listaAsistenciaDT"
        ReportDataSource1.Value = Me.Lista_AsistenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Lista_de_Asistencia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 33)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1211, 610)
        Me.ReportViewer1.TabIndex = 1
        '
        'Lista_AsistenciaTableAdapter
        '
        Me.Lista_AsistenciaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "listaAsistenciaDT"
        ReportDataSource2.Value = Me.Lista_AsistenciaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Lista_de_Asistencia2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(16, 33)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1211, 610)
        Me.ReportViewer2.TabIndex = 2
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "listaAsistenciaDT"
        ReportDataSource3.Value = Me.LISTA2BindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Lista_de_AsistenciaSD.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(16, 33)
        Me.ReportViewer3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(1211, 610)
        Me.ReportViewer3.TabIndex = 3
        '
        'LISTA2TableAdapter
        '
        Me.LISTA2TableAdapter.ClearBeforeFill = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource4.Name = "listaAsistenciaDT"
        ReportDataSource4.Value = Me.LISTA2BindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Lista_de_AsistenciaSD2.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(16, 33)
        Me.ReportViewer4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(1211, 610)
        Me.ReportViewer4.TabIndex = 4
        '
        'impresionListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 647)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer4)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "impresionListas"
        Me.Text = "Impresion de Listas"
        CType(Me.Lista_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTA2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Lista_AsistenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents isencoDataSet As catalogosIsenco.isencoDataSet
    Friend WithEvents Lista_AsistenciaTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.Lista_AsistenciaTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LISTA2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LISTA2TableAdapter As catalogosIsenco.isencoDataSetTableAdapters.LISTA2TableAdapter
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
End Class
