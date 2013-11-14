<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionConcentradoCalif
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Lista_AsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.isencoDataSet = New catalogosIsenco.isencoDataSet()
        Me.LISTA_FOTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Lista_AsistenciaTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.Lista_AsistenciaTableAdapter()
        Me.LISTA_FOTOSTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.LISTA_FOTOSTableAdapter()
        CType(Me.Lista_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTA_FOTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        'LISTA_FOTOSBindingSource
        '
        Me.LISTA_FOTOSBindingSource.DataMember = "LISTA_FOTOS"
        Me.LISTA_FOTOSBindingSource.DataSource = Me.isencoDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(980, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 25)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(962, 652)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(954, 626)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Concentrado de Calificaciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "listaAsistenciaDT"
        ReportDataSource3.Value = Me.Lista_AsistenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Lista_Concen_calif.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 2)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(950, 622)
        Me.ReportViewer1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(869, 626)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reporte de Alumnos con Fotos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(639, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "listaAsistenciaDT"
        ReportDataSource4.Value = Me.LISTA_FOTOSBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "catalogosIsenco.Listas_con_fotos.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(2, 2)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(865, 622)
        Me.ReportViewer2.TabIndex = 3
        '
        'Lista_AsistenciaTableAdapter
        '
        Me.Lista_AsistenciaTableAdapter.ClearBeforeFill = True
        '
        'LISTA_FOTOSTableAdapter
        '
        Me.LISTA_FOTOSTableAdapter.ClearBeforeFill = True
        '
        'ImpresionConcentradoCalif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 687)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ImpresionConcentradoCalif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IMPRESION DE CONCENTRADO DE CALIFICACIONES"
        CType(Me.Lista_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isencoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTA_FOTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lista_AsistenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents isencoDataSet As catalogosIsenco.isencoDataSet
    Friend WithEvents Lista_AsistenciaTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.Lista_AsistenciaTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LISTA_FOTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LISTA_FOTOSTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.LISTA_FOTOSTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
