<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class impresionInscripcionFrm
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
        Me.Documentos_alumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inscripcion = New catalogosIsenco.inscripcion()
        Me.Documentos_alumnos_entregadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.imssBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ReportViewer7 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReimprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Documentos_alumnosTableAdapter = New catalogosIsenco.inscripcionTableAdapters.Documentos_alumnosTableAdapter()
        Me.Documentos_alumnos_entregadosTableAdapter = New catalogosIsenco.inscripcionTableAdapters.Documentos_alumnos_entregadosTableAdapter()
        Me.imssTableAdapter = New catalogosIsenco.inscripcionTableAdapters.imssTableAdapter()
        CType(Me.Documentos_alumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inscripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Documentos_alumnos_entregadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imssBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Documentos_alumnosBindingSource
        '
        Me.Documentos_alumnosBindingSource.DataMember = "Documentos_alumnos"
        Me.Documentos_alumnosBindingSource.DataSource = Me.inscripcion
        '
        'inscripcion
        '
        Me.inscripcion.DataSetName = "inscripcion"
        Me.inscripcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Documentos_alumnos_entregadosBindingSource
        '
        Me.Documentos_alumnos_entregadosBindingSource.DataMember = "Documentos_alumnos_entregados"
        Me.Documentos_alumnos_entregadosBindingSource.DataSource = Me.inscripcion
        '
        'imssBindingSource
        '
        Me.imssBindingSource.DataMember = "imss"
        Me.imssBindingSource.DataSource = Me.inscripcion
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(15, 30)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1623, 873)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1615, 844)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ficha de Inscripcion Bachillerato"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer3.DocumentMapWidth = 43
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Documentos_alumnosBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "catalogosIsenco.FICHA DE BACHILLERATO.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(3, 2)
        Me.ReportViewer3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(1609, 840)
        Me.ReportViewer3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1615, 844)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ficha de Inscripcion Licenciatura"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Documentos_alumnosBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "catalogosIsenco.FICHA DE LICENCIATURA.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(3, 2)
        Me.ReportViewer4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(1606, 835)
        Me.ReportViewer4.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1615, 844)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bienvenida"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.Documentos_alumnosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.bienvenida.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1611, 840)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1615, 844)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Carta Compromiso Promedio"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.Documentos_alumnosBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "catalogosIsenco.carta_compromiso_promedio.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1611, 840)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ReportViewer5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1615, 844)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Carta Compromiso Temporal"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ReportViewer5
        '
        Me.ReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.Documentos_alumnos_entregadosBindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Carta_Compromiso_tem.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.Size = New System.Drawing.Size(1611, 840)
        Me.ReportViewer5.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReportViewer6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1615, 844)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Recepcion de Documentos Bachillerato"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ReportViewer6
        '
        Me.ReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.Documentos_alumnos_entregadosBindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "catalogosIsenco.documentos_lic.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.Size = New System.Drawing.Size(1611, 840)
        Me.ReportViewer6.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.ReportViewer7)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage7.Size = New System.Drawing.Size(1615, 844)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Formato IMSS"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ReportViewer7
        '
        Me.ReportViewer7.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.imssBindingSource
        Me.ReportViewer7.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer7.LocalReport.ReportEmbeddedResource = "catalogosIsenco.imss.rdlc"
        Me.ReportViewer7.Location = New System.Drawing.Point(4, 4)
        Me.ReportViewer7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer7.Name = "ReportViewer7"
        Me.ReportViewer7.Size = New System.Drawing.Size(1603, 833)
        Me.ReportViewer7.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReimprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1652, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReimprimirToolStripMenuItem
        '
        Me.ReimprimirToolStripMenuItem.Name = "ReimprimirToolStripMenuItem"
        Me.ReimprimirToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.ReimprimirToolStripMenuItem.Text = "Reimprimir"
        '
        'Documentos_alumnosTableAdapter
        '
        Me.Documentos_alumnosTableAdapter.ClearBeforeFill = True
        '
        'Documentos_alumnos_entregadosTableAdapter
        '
        Me.Documentos_alumnos_entregadosTableAdapter.ClearBeforeFill = True
        '
        'imssTableAdapter
        '
        Me.imssTableAdapter.ClearBeforeFill = True
        '
        'impresionInscripcionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1652, 900)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "impresionInscripcionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Documentos para Inscripcion"
        CType(Me.Documentos_alumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inscripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Documentos_alumnos_entregadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imssBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Documentos_alumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inscripcion As catalogosIsenco.inscripcion
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Documentos_alumnosTableAdapter As catalogosIsenco.inscripcionTableAdapters.Documentos_alumnosTableAdapter
    Friend WithEvents Documentos_alumnos_entregadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Documentos_alumnos_entregadosTableAdapter As catalogosIsenco.inscripcionTableAdapters.Documentos_alumnos_entregadosTableAdapter
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer7 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents imssBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents imssTableAdapter As catalogosIsenco.inscripcionTableAdapters.imssTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReimprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
