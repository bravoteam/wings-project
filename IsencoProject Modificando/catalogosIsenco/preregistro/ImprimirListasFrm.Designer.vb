<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirListasFrm
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
        Me.PreregistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsencoDataSet = New catalogosIsenco.isencoDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rContexto = New System.Windows.Forms.RadioButton()
        Me.rCeneval = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.consultarcmd = New System.Windows.Forms.Button()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAulas = New System.Windows.Forms.ComboBox()
        Me.chkTipo = New System.Windows.Forms.CheckBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PreregistroTableAdapter = New catalogosIsenco.isencoDataSetTableAdapters.preregistroTableAdapter()
        CType(Me.PreregistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsencoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PreregistroBindingSource
        '
        Me.PreregistroBindingSource.DataMember = "preregistro"
        Me.PreregistroBindingSource.DataSource = Me.IsencoDataSet
        '
        'IsencoDataSet
        '
        Me.IsencoDataSet.DataSetName = "isencoDataSet"
        Me.IsencoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rContexto)
        Me.Panel1.Controls.Add(Me.rCeneval)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.consultarcmd)
        Me.Panel1.Controls.Add(Me.cmbTurno)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbAulas)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 77)
        Me.Panel1.TabIndex = 41
        '
        'rContexto
        '
        Me.rContexto.AutoSize = True
        Me.rContexto.Checked = True
        Me.rContexto.Location = New System.Drawing.Point(427, 16)
        Me.rContexto.Name = "rContexto"
        Me.rContexto.Size = New System.Drawing.Size(113, 19)
        Me.rContexto.TabIndex = 113
        Me.rContexto.TabStop = True
        Me.rContexto.Text = "Aula Contexto"
        Me.rContexto.UseVisualStyleBackColor = True
        '
        'rCeneval
        '
        Me.rCeneval.AutoSize = True
        Me.rCeneval.Location = New System.Drawing.Point(556, 14)
        Me.rCeneval.Name = "rCeneval"
        Me.rCeneval.Size = New System.Drawing.Size(108, 19)
        Me.rCeneval.TabIndex = 112
        Me.rCeneval.Text = "Aula Ceneval"
        Me.rCeneval.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, -3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Filtro:"
        '
        'consultarcmd
        '
        Me.consultarcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmd.Location = New System.Drawing.Point(835, 34)
        Me.consultarcmd.Name = "consultarcmd"
        Me.consultarcmd.Size = New System.Drawing.Size(170, 29)
        Me.consultarcmd.TabIndex = 55
        Me.consultarcmd.Text = "Consultar"
        Me.consultarcmd.UseVisualStyleBackColor = True
        '
        'cmbTurno
        '
        Me.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"Turno 1", "Turno 2", "Turno 3", "Turno 4", "Turno 5"})
        Me.cmbTurno.Location = New System.Drawing.Point(16, 40)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(240, 23)
        Me.cmbTurno.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(269, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Aula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Turno"
        '
        'cmbAulas
        '
        Me.cmbAulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAulas.FormattingEnabled = True
        Me.cmbAulas.Location = New System.Drawing.Point(272, 40)
        Me.cmbAulas.Name = "cmbAulas"
        Me.cmbAulas.Size = New System.Drawing.Size(505, 23)
        Me.cmbAulas.TabIndex = 37
        '
        'chkTipo
        '
        Me.chkTipo.AutoSize = True
        Me.chkTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTipo.Location = New System.Drawing.Point(841, 92)
        Me.chkTipo.Name = "chkTipo"
        Me.chkTipo.Size = New System.Drawing.Size(82, 19)
        Me.chkTipo.TabIndex = 111
        Me.chkTipo.Text = "Validado"
        Me.chkTipo.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(2, 111)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(1030, 451)
        Me.grid.TabIndex = 42
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 561)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1369, 22)
        Me.StatusStrip1.TabIndex = 43
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "Numero de Alumnos"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.RegresarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1369, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarGruposToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AsignarGruposToolStripMenuItem
        '
        Me.AsignarGruposToolStripMenuItem.Name = "AsignarGruposToolStripMenuItem"
        Me.AsignarGruposToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AsignarGruposToolStripMenuItem.Text = "Imprimir Lista"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1038, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 29)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PreregistroBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "catalogosIsenco.ListasPreregistroCen.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(1045, 112)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(323, 449)
        Me.ReportViewer2.TabIndex = 116
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.PreregistroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "catalogosIsenco.ListasPreregistro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1045, 113)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(416, 445)
        Me.ReportViewer1.TabIndex = 117
        '
        'PreregistroTableAdapter
        '
        Me.PreregistroTableAdapter.ClearBeforeFill = True
        '
        'ImprimirListasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 583)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.chkTipo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ImprimirListasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImprimirListasFrm"
        CType(Me.PreregistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsencoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents consultarcmd As System.Windows.Forms.Button
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAulas As System.Windows.Forms.ComboBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarGruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkTipo As System.Windows.Forms.CheckBox
    Friend WithEvents rContexto As System.Windows.Forms.RadioButton
    Friend WithEvents rCeneval As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PreregistroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IsencoDataSet As catalogosIsenco.isencoDataSet
    Friend WithEvents PreregistroTableAdapter As catalogosIsenco.isencoDataSetTableAdapters.preregistroTableAdapter
End Class
