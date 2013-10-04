<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro_escolaridad
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
        Me.REGISTRO_ESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.registroEscolaridad = New catalogosIsenco.registroEscolaridad()
        Me.REGISTRO_ESCOLARIDAD_REPETIDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.REGISTRO_ESCOLARIDADTableAdapter = New catalogosIsenco.registroEscolaridadTableAdapters.REGISTRO_ESCOLARIDADTableAdapter()
        Me.REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter = New catalogosIsenco.registroEscolaridadTableAdapters.REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter()
        CType(Me.REGISTRO_ESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.registroEscolaridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTRO_ESCOLARIDAD_REPETIDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'REGISTRO_ESCOLARIDADBindingSource
        '
        Me.REGISTRO_ESCOLARIDADBindingSource.DataMember = "REGISTRO_ESCOLARIDAD"
        Me.REGISTRO_ESCOLARIDADBindingSource.DataSource = Me.registroEscolaridad
        '
        'registroEscolaridad
        '
        Me.registroEscolaridad.DataSetName = "registroEscolaridad"
        Me.registroEscolaridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REGISTRO_ESCOLARIDAD_REPETIDORBindingSource
        '
        Me.REGISTRO_ESCOLARIDAD_REPETIDORBindingSource.DataMember = "REGISTRO_ESCOLARIDAD_REPETIDOR"
        Me.REGISTRO_ESCOLARIDAD_REPETIDORBindingSource.DataSource = Me.registroEscolaridad
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OtrosToolStripMenuItem.Text = "Opciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.REGISTRO_ESCOLARIDADBindingSource
        ReportDataSource2.Name = "DataSet6"
        ReportDataSource2.Value = Me.REGISTRO_ESCOLARIDAD_REPETIDORBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Reporte_registro_escolaridad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(935, 368)
        Me.ReportViewer1.TabIndex = 1
        '
        'REGISTRO_ESCOLARIDADTableAdapter
        '
        Me.REGISTRO_ESCOLARIDADTableAdapter.ClearBeforeFill = True
        '
        'REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter
        '
        Me.REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter.ClearBeforeFill = True
        '
        'registro_escolaridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 392)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "registro_escolaridad"
        Me.Text = "Registro de Escolaridad"
        CType(Me.REGISTRO_ESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.registroEscolaridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTRO_ESCOLARIDAD_REPETIDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REGISTRO_ESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents registroEscolaridad As catalogosIsenco.registroEscolaridad
    Friend WithEvents REGISTRO_ESCOLARIDAD_REPETIDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGISTRO_ESCOLARIDADTableAdapter As catalogosIsenco.registroEscolaridadTableAdapters.REGISTRO_ESCOLARIDADTableAdapter
    Friend WithEvents REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter As catalogosIsenco.registroEscolaridadTableAdapters.REGISTRO_ESCOLARIDAD_REPETIDORTableAdapter
End Class
