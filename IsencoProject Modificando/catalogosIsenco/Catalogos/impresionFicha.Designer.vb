<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class impresionFicha
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.inscripcion = New catalogosIsenco.inscripcion()
        Me.Documentos_alumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Documentos_alumnosTableAdapter = New catalogosIsenco.inscripcionTableAdapters.Documentos_alumnosTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.inscripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Documentos_alumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 11)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1196, 709)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1188, 683)
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
        Me.ReportViewer3.Location = New System.Drawing.Point(2, 2)
        Me.ReportViewer3.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(1184, 679)
        Me.ReportViewer3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1188, 683)
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
        Me.ReportViewer4.Location = New System.Drawing.Point(2, 2)
        Me.ReportViewer4.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(1184, 679)
        Me.ReportViewer4.TabIndex = 0
        '
        'inscripcion
        '
        Me.inscripcion.DataSetName = "inscripcion"
        Me.inscripcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Documentos_alumnosBindingSource
        '
        Me.Documentos_alumnosBindingSource.DataMember = "Documentos_alumnos"
        Me.Documentos_alumnosBindingSource.DataSource = Me.inscripcion
        '
        'Documentos_alumnosTableAdapter
        '
        Me.Documentos_alumnosTableAdapter.ClearBeforeFill = True
        '
        'impresionFicha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 791)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "impresionFicha"
        Me.Text = "impresionFicha"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.inscripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Documentos_alumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Documentos_alumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inscripcion As catalogosIsenco.inscripcion
    Friend WithEvents Documentos_alumnosTableAdapter As catalogosIsenco.inscripcionTableAdapters.Documentos_alumnosTableAdapter
End Class
