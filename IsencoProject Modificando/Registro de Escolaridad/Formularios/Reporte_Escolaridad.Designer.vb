<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Escolaridad
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
        Me.ciclo_escolarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroDt = New Registro_de_Escolaridad.RegistroDt()
        Me.DirectivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGISTROESCOLARIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MujeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroDt1 = New Registro_de_Escolaridad.RegistroDt()
        Me.HombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGISTROESCOLARIDAD_REPETIDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MujeresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarArchivoParaImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CicloescolarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGISTROESCOLARIDADTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTROESCOLARIDADTableAdapter()
        Me.Ciclo_escolarTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.ciclo_escolarTableAdapter()
        Me.DirectivosTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.directivosTableAdapter()
        Me.MujeresTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.mujeresTableAdapter()
        Me.HombresTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.hombresTableAdapter()
        Me.REGISTROESCOLARIDADREPETIDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGISTROESCOLARIDAD_REPETIDORTableAdapter = New Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTROESCOLARIDAD_REPETIDORTableAdapter()
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTROESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroDt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTROESCOLARIDAD_REPETIDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MujeresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CicloescolarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTROESCOLARIDADREPETIDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ciclo_escolarBindingSource
        '
        Me.ciclo_escolarBindingSource.DataMember = "ciclo_escolar"
        Me.ciclo_escolarBindingSource.DataSource = Me.RegistroDt
        '
        'RegistroDt
        '
        Me.RegistroDt.DataSetName = "RegistroDt"
        Me.RegistroDt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DirectivosBindingSource
        '
        Me.DirectivosBindingSource.DataMember = "directivos"
        Me.DirectivosBindingSource.DataSource = Me.RegistroDt
        '
        'REGISTROESCOLARIDADBindingSource
        '
        Me.REGISTROESCOLARIDADBindingSource.DataMember = "REGISTROESCOLARIDAD"
        Me.REGISTROESCOLARIDADBindingSource.DataSource = Me.RegistroDt
        '
        'MujeresBindingSource
        '
        Me.MujeresBindingSource.DataMember = "mujeres"
        Me.MujeresBindingSource.DataSource = Me.RegistroDt1
        '
        'RegistroDt1
        '
        Me.RegistroDt1.DataSetName = "RegistroDt"
        Me.RegistroDt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HombresBindingSource
        '
        Me.HombresBindingSource.DataMember = "hombres"
        Me.HombresBindingSource.DataSource = Me.RegistroDt
        '
        'REGISTROESCOLARIDAD_REPETIDORBindingSource
        '
        Me.REGISTROESCOLARIDAD_REPETIDORBindingSource.DataMember = "REGISTROESCOLARIDAD_REPETIDOR"
        Me.REGISTROESCOLARIDAD_REPETIDORBindingSource.DataSource = Me.RegistroDt
        '
        'MujeresBindingSource1
        '
        Me.MujeresBindingSource1.DataMember = "mujeres"
        Me.MujeresBindingSource1.DataSource = Me.RegistroDt
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(872, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarArchivoParaImprimirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'GenerarArchivoParaImprimirToolStripMenuItem
        '
        Me.GenerarArchivoParaImprimirToolStripMenuItem.Name = "GenerarArchivoParaImprimirToolStripMenuItem"
        Me.GenerarArchivoParaImprimirToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.GenerarArchivoParaImprimirToolStripMenuItem.Text = "Generar Archivo para Imprimir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet3"
        ReportDataSource1.Value = Me.ciclo_escolarBindingSource
        ReportDataSource2.Name = "DataSet4"
        ReportDataSource2.Value = Me.DirectivosBindingSource
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.REGISTROESCOLARIDADBindingSource
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.MujeresBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.HombresBindingSource
        ReportDataSource6.Name = "DataSet6"
        ReportDataSource6.Value = Me.REGISTROESCOLARIDAD_REPETIDORBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Registro_de_Escolaridad.Reporte_registro_escolaridad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(872, 509)
        Me.ReportViewer1.TabIndex = 2
        '
        'CicloescolarBindingSource
        '
        Me.CicloescolarBindingSource.DataMember = "ciclo_escolar"
        Me.CicloescolarBindingSource.DataSource = Me.RegistroDt
        '
        'REGISTROESCOLARIDADTableAdapter
        '
        Me.REGISTROESCOLARIDADTableAdapter.ClearBeforeFill = True
        '
        'Ciclo_escolarTableAdapter
        '
        Me.Ciclo_escolarTableAdapter.ClearBeforeFill = True
        '
        'DirectivosTableAdapter
        '
        Me.DirectivosTableAdapter.ClearBeforeFill = True
        '
        'MujeresTableAdapter
        '
        Me.MujeresTableAdapter.ClearBeforeFill = True
        '
        'HombresTableAdapter
        '
        Me.HombresTableAdapter.ClearBeforeFill = True
        '
        'REGISTROESCOLARIDADREPETIDORBindingSource
        '
        Me.REGISTROESCOLARIDADREPETIDORBindingSource.DataMember = "REGISTROESCOLARIDAD_REPETIDOR"
        Me.REGISTROESCOLARIDADREPETIDORBindingSource.DataSource = Me.RegistroDt
        '
        'REGISTROESCOLARIDAD_REPETIDORTableAdapter
        '
        Me.REGISTROESCOLARIDAD_REPETIDORTableAdapter.ClearBeforeFill = True
        '
        'Reporte_Escolaridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 533)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Reporte_Escolaridad"
        Me.Text = "Reporte_Escolaridad"
        CType(Me.ciclo_escolarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTROESCOLARIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MujeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroDt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTROESCOLARIDAD_REPETIDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MujeresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CicloescolarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTROESCOLARIDADREPETIDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarArchivoParaImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroEscolaridadEXTRA1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RegistroDt As Registro_de_Escolaridad.RegistroDt
    Friend WithEvents REGISTROESCOLARIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGISTROESCOLARIDADTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTROESCOLARIDADTableAdapter
    Friend WithEvents CicloescolarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ciclo_escolarTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.ciclo_escolarTableAdapter
    Friend WithEvents DirectivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectivosTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.directivosTableAdapter
    Friend WithEvents MujeresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistroDt1 As Registro_de_Escolaridad.RegistroDt
    Friend WithEvents MujeresTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.mujeresTableAdapter
    Friend WithEvents ciclo_escolarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MujeresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HombresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HombresTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.hombresTableAdapter
    Friend WithEvents REGISTROESCOLARIDAD_REPETIDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGISTROESCOLARIDADREPETIDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGISTROESCOLARIDAD_REPETIDORTableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.REGISTROESCOLARIDAD_REPETIDORTableAdapter
    ' Friend WithEvents RegistroEscolaridadEXTRA1TableAdapter As Registro_de_Escolaridad.RegistroDtTableAdapters.RegistroEscolaridadEXTRA1TableAdapter
End Class
