<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKardex
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
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarArchivoAImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.KardexAlumnoDT = New Kardex_Alumno.KardexAlumnoDT()
        Me.Primer_SemestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Primer_SemestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Primer_SemestreTableAdapter()
        Me.Segundo_semestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Segundo_semestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Segundo_semestreTableAdapter()
        Me.Tercer_semestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tercer_semestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Tercer_semestreTableAdapter()
        Me.Cuarto_semestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cuarto_semestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Cuarto_semestreTableAdapter()
        Me.alumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.alumnoTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.alumnoTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Quinto_semestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Quinto_semestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Quinto_semestreTableAdapter()
        Me.Sexto_semestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sexto_semestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Sexto_semestreTableAdapter()
        Me.Septimo_semestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Septimo_semestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Septimo_semestreTableAdapter()
        Me.Octavo_semestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Octavo_semestreTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.Octavo_semestreTableAdapter()
        Me.promedioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.promedioTableAdapter = New Kardex_Alumno.KardexAlumnoDTTableAdapters.promedioTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.KardexAlumnoDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Primer_SemestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segundo_semestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tercer_semestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cuarto_semestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quinto_semestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sexto_semestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Septimo_semestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Octavo_semestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(931, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarArchivoAImprimirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GenerarToolStripMenuItem.Text = "&Opciones"
        '
        'GenerarArchivoAImprimirToolStripMenuItem
        '
        Me.GenerarArchivoAImprimirToolStripMenuItem.Name = "GenerarArchivoAImprimirToolStripMenuItem"
        Me.GenerarArchivoAImprimirToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.GenerarArchivoAImprimirToolStripMenuItem.Text = "&Generar Archivo a Imprimir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "KardexDt"
        ReportDataSource1.Value = Me.Primer_SemestreBindingSource
        ReportDataSource2.Name = "KardexDt1"
        ReportDataSource2.Value = Me.Segundo_semestreBindingSource
        ReportDataSource3.Name = "KardexDt2"
        ReportDataSource3.Value = Me.Tercer_semestreBindingSource
        ReportDataSource4.Name = "KardexDt3"
        ReportDataSource4.Value = Me.Cuarto_semestreBindingSource
        ReportDataSource5.Name = "KardexDtA"
        ReportDataSource5.Value = Me.alumnoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Kardex_Alumno.Kardex_alumno.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(459, 579)
        Me.ReportViewer1.TabIndex = 5
        '
        'KardexAlumnoDT
        '
        Me.KardexAlumnoDT.DataSetName = "KardexAlumnoDT"
        Me.KardexAlumnoDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Primer_SemestreBindingSource
        '
        Me.Primer_SemestreBindingSource.DataMember = "Primer_Semestre"
        Me.Primer_SemestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Primer_SemestreTableAdapter
        '
        Me.Primer_SemestreTableAdapter.ClearBeforeFill = True
        '
        'Segundo_semestreBindingSource
        '
        Me.Segundo_semestreBindingSource.DataMember = "Segundo_semestre"
        Me.Segundo_semestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Segundo_semestreTableAdapter
        '
        Me.Segundo_semestreTableAdapter.ClearBeforeFill = True
        '
        'Tercer_semestreBindingSource
        '
        Me.Tercer_semestreBindingSource.DataMember = "Tercer_semestre"
        Me.Tercer_semestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Tercer_semestreTableAdapter
        '
        Me.Tercer_semestreTableAdapter.ClearBeforeFill = True
        '
        'Cuarto_semestreBindingSource
        '
        Me.Cuarto_semestreBindingSource.DataMember = "Cuarto_semestre"
        Me.Cuarto_semestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Cuarto_semestreTableAdapter
        '
        Me.Cuarto_semestreTableAdapter.ClearBeforeFill = True
        '
        'alumnoBindingSource
        '
        Me.alumnoBindingSource.DataMember = "alumno"
        Me.alumnoBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'alumnoTableAdapter
        '
        Me.alumnoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource6.Name = "KardexDt4"
        ReportDataSource6.Value = Me.Quinto_semestreBindingSource
        ReportDataSource7.Name = "KardexDt5"
        ReportDataSource7.Value = Me.Sexto_semestreBindingSource
        ReportDataSource8.Name = "KardexDt6"
        ReportDataSource8.Value = Me.Septimo_semestreBindingSource
        ReportDataSource9.Name = "KardexDt7"
        ReportDataSource9.Value = Me.Octavo_semestreBindingSource
        ReportDataSource10.Name = "promedio"
        ReportDataSource10.Value = Me.promedioBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Kardex_Alumno.Kardex_alumno_contra.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(472, 27)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(459, 579)
        Me.ReportViewer2.TabIndex = 6
        '
        'Quinto_semestreBindingSource
        '
        Me.Quinto_semestreBindingSource.DataMember = "Quinto_semestre"
        Me.Quinto_semestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Quinto_semestreTableAdapter
        '
        Me.Quinto_semestreTableAdapter.ClearBeforeFill = True
        '
        'Sexto_semestreBindingSource
        '
        Me.Sexto_semestreBindingSource.DataMember = "Sexto_semestre"
        Me.Sexto_semestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Sexto_semestreTableAdapter
        '
        Me.Sexto_semestreTableAdapter.ClearBeforeFill = True
        '
        'Septimo_semestreBindingSource
        '
        Me.Septimo_semestreBindingSource.DataMember = "Septimo_semestre"
        Me.Septimo_semestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Septimo_semestreTableAdapter
        '
        Me.Septimo_semestreTableAdapter.ClearBeforeFill = True
        '
        'Octavo_semestreBindingSource
        '
        Me.Octavo_semestreBindingSource.DataMember = "Octavo_semestre"
        Me.Octavo_semestreBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'Octavo_semestreTableAdapter
        '
        Me.Octavo_semestreTableAdapter.ClearBeforeFill = True
        '
        'promedioBindingSource
        '
        Me.promedioBindingSource.DataMember = "promedio"
        Me.promedioBindingSource.DataSource = Me.KardexAlumnoDT
        '
        'promedioTableAdapter
        '
        Me.promedioTableAdapter.ClearBeforeFill = True
        '
        'frmKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 618)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmKardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.KardexAlumnoDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Primer_SemestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segundo_semestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tercer_semestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cuarto_semestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quinto_semestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sexto_semestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Septimo_semestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Octavo_semestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.promedioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GenerarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarArchivoAImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Primer_SemestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KardexAlumnoDT As Kardex_Alumno.KardexAlumnoDT
    Friend WithEvents Segundo_semestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tercer_semestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cuarto_semestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents alumnoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Primer_SemestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Primer_SemestreTableAdapter
    Friend WithEvents Segundo_semestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Segundo_semestreTableAdapter
    Friend WithEvents Tercer_semestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Tercer_semestreTableAdapter
    Friend WithEvents Cuarto_semestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Cuarto_semestreTableAdapter
    Friend WithEvents alumnoTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.alumnoTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Quinto_semestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sexto_semestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Septimo_semestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Octavo_semestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents promedioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quinto_semestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Quinto_semestreTableAdapter
    Friend WithEvents Sexto_semestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Sexto_semestreTableAdapter
    Friend WithEvents Septimo_semestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Septimo_semestreTableAdapter
    Friend WithEvents Octavo_semestreTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.Octavo_semestreTableAdapter
    Friend WithEvents promedioTableAdapter As Kardex_Alumno.KardexAlumnoDTTableAdapters.promedioTableAdapter

End Class
