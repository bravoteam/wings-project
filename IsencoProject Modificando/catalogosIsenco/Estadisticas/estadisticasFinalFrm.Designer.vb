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
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource13 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource14 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource15 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource16 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.estadisticasfinal_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportesDT = New catalogosIsenco.reportesDT()
        Me.estadisticasfinal_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estadisticasfinal_3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estadisticasfinal_4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estadisticasfinal_5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estadisticasfinal_6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estadisticasfinal_7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estadisticasfinal_8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.estadisticasfinal_1TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_1TableAdapter()
        Me.estadisticasfinal_3TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_3TableAdapter()
        Me.estadisticasfinal_5TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_5TableAdapter()
        Me.estadisticasfinal_2TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_2TableAdapter()
        Me.estadisticasfinal_4TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_4TableAdapter()
        Me.estadisticasfinal_6TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_6TableAdapter()
        Me.estadisticasfinal_7TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_7TableAdapter()
        Me.estadisticasfinal_8TableAdapter = New catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_8TableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.estadisticasfinal_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticasfinal_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticasfinal_3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticasfinal_4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticasfinal_5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticasfinal_6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticasfinal_7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadisticasfinal_8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'estadisticasfinal_1BindingSource
        '
        Me.estadisticasfinal_1BindingSource.DataMember = "estadisticasfinal_1"
        Me.estadisticasfinal_1BindingSource.DataSource = Me.reportesDT
        '
        'reportesDT
        '
        Me.reportesDT.DataSetName = "reportesDT"
        Me.reportesDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'estadisticasfinal_2BindingSource
        '
        Me.estadisticasfinal_2BindingSource.DataMember = "estadisticasfinal_2"
        Me.estadisticasfinal_2BindingSource.DataSource = Me.reportesDT
        '
        'estadisticasfinal_3BindingSource
        '
        Me.estadisticasfinal_3BindingSource.DataMember = "estadisticasfinal_3"
        Me.estadisticasfinal_3BindingSource.DataSource = Me.reportesDT
        '
        'estadisticasfinal_4BindingSource
        '
        Me.estadisticasfinal_4BindingSource.DataMember = "estadisticasfinal_4"
        Me.estadisticasfinal_4BindingSource.DataSource = Me.reportesDT
        '
        'estadisticasfinal_5BindingSource
        '
        Me.estadisticasfinal_5BindingSource.DataMember = "estadisticasfinal_5"
        Me.estadisticasfinal_5BindingSource.DataSource = Me.reportesDT
        '
        'estadisticasfinal_6BindingSource
        '
        Me.estadisticasfinal_6BindingSource.DataMember = "estadisticasfinal_6"
        Me.estadisticasfinal_6BindingSource.DataSource = Me.reportesDT
        '
        'estadisticasfinal_7BindingSource
        '
        Me.estadisticasfinal_7BindingSource.DataMember = "estadisticasfinal_7"
        Me.estadisticasfinal_7BindingSource.DataSource = Me.reportesDT
        '
        'estadisticasfinal_8BindingSource
        '
        Me.estadisticasfinal_8BindingSource.DataMember = "estadisticasfinal_8"
        Me.estadisticasfinal_8BindingSource.DataSource = Me.reportesDT
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.estadisticasfinal_1BindingSource
        ReportDataSource10.Name = "DataSet2"
        ReportDataSource10.Value = Me.estadisticasfinal_2BindingSource
        ReportDataSource11.Name = "DataSet3"
        ReportDataSource11.Value = Me.estadisticasfinal_3BindingSource
        ReportDataSource12.Name = "DataSet4"
        ReportDataSource12.Value = Me.estadisticasfinal_4BindingSource
        ReportDataSource13.Name = "DataSet5"
        ReportDataSource13.Value = Me.estadisticasfinal_5BindingSource
        ReportDataSource14.Name = "DataSet6"
        ReportDataSource14.Value = Me.estadisticasfinal_6BindingSource
        ReportDataSource15.Name = "DataSet7"
        ReportDataSource15.Value = Me.estadisticasfinal_7BindingSource
        ReportDataSource16.Name = "DataSet8"
        ReportDataSource16.Value = Me.estadisticasfinal_8BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource13)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource14)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource15)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource16)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.estadisticasgrupales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1097, 503)
        Me.ReportViewer1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1135, 24)
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
        'estadisticasfinal_1TableAdapter
        '
        Me.estadisticasfinal_1TableAdapter.ClearBeforeFill = True
        '
        'estadisticasfinal_3TableAdapter
        '
        Me.estadisticasfinal_3TableAdapter.ClearBeforeFill = True
        '
        'estadisticasfinal_5TableAdapter
        '
        Me.estadisticasfinal_5TableAdapter.ClearBeforeFill = True
        '
        'estadisticasfinal_2TableAdapter
        '
        Me.estadisticasfinal_2TableAdapter.ClearBeforeFill = True
        '
        'estadisticasfinal_4TableAdapter
        '
        Me.estadisticasfinal_4TableAdapter.ClearBeforeFill = True
        '
        'estadisticasfinal_6TableAdapter
        '
        Me.estadisticasfinal_6TableAdapter.ClearBeforeFill = True
        '
        'estadisticasfinal_7TableAdapter
        '
        Me.estadisticasfinal_7TableAdapter.ClearBeforeFill = True
        '
        'estadisticasfinal_8TableAdapter
        '
        Me.estadisticasfinal_8TableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1111, 535)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1103, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Opciones para Reporte"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.cmdGenerar)
        Me.GroupBox4.Location = New System.Drawing.Point(566, 235)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(522, 236)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerar.Location = New System.Drawing.Point(16, 38)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(452, 184)
        Me.cmdGenerar.TabIndex = 3
        Me.cmdGenerar.Text = "GENERAR REPORTE"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.ListBox3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(522, 236)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Elige el Semestre"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.ListBox3.Location = New System.Drawing.Point(6, 38)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox3.Size = New System.Drawing.Size(462, 184)
        Me.ListBox3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(566, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elige Campus uno o Varios"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Items.AddRange(New Object() {"CUAUHTEMOC", "COLIMA", "TECOMAN", "MANZANILLO"})
        Me.ListBox2.Location = New System.Drawing.Point(6, 38)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox2.Size = New System.Drawing.Size(462, 164)
        Me.ListBox2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elige si necesitas Licenciatura o Bachillerato"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"BACHILLERATO", "LICENCIATURA"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(462, 84)
        Me.ListBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1103, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vista Previa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'estadisticasFinalFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 574)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "estadisticasFinalFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadisticas Finales"
        CType(Me.estadisticasfinal_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportesDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticasfinal_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticasfinal_3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticasfinal_4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticasfinal_5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticasfinal_6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticasfinal_7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadisticasfinal_8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents estadisticasfinal_1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportesDT As catalogosIsenco.reportesDT
    Friend WithEvents estadisticasfinal_1TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_1TableAdapter
    Friend WithEvents estadisticasfinal_3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticasfinal_3TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_3TableAdapter
    Friend WithEvents estadisticasfinal_5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticasfinal_5TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_5TableAdapter
    Friend WithEvents estadisticasfinal_2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticasfinal_4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticasfinal_6BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticasfinal_7BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticasfinal_8BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents estadisticasfinal_2TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_2TableAdapter
    Friend WithEvents estadisticasfinal_4TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_4TableAdapter
    Friend WithEvents estadisticasfinal_6TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_6TableAdapter
    Friend WithEvents estadisticasfinal_7TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_7TableAdapter
    Friend WithEvents estadisticasfinal_8TableAdapter As catalogosIsenco.reportesDTTableAdapters.estadisticasfinal_8TableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGenerar As System.Windows.Forms.Button
End Class
