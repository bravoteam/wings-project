<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanEstudiosCicloFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCiclo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbPlan = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.cmbLicenciatura = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridListado = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CICLO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDLICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LICENCIATURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPECIALIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEMESTRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMATERIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MATERIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grupoPrincipal = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grupoPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCiclo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(484, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ELIGE EL CICLO ESCOLAR"
        '
        'cmbCiclo
        '
        Me.cmbCiclo.BackColor = System.Drawing.Color.White
        Me.cmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiclo.ForeColor = System.Drawing.Color.Black
        Me.cmbCiclo.FormattingEnabled = True
        Me.cmbCiclo.Location = New System.Drawing.Point(8, 42)
        Me.cmbCiclo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCiclo.Name = "cmbCiclo"
        Me.cmbCiclo.Size = New System.Drawing.Size(463, 99)
        Me.cmbCiclo.TabIndex = 140
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbEspecialidad)
        Me.GroupBox2.Controls.Add(Me.cmbLicenciatura)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(508, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1221, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ELIGE LA LICENCIATURA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbPlan)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.cmbSemestre)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(789, 26)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(424, 144)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ELIGE EL SEMESTRE Y PLAN"
        '
        'cmbPlan
        '
        Me.cmbPlan.BackColor = System.Drawing.Color.White
        Me.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlan.ForeColor = System.Drawing.Color.Black
        Me.cmbPlan.FormattingEnabled = True
        Me.cmbPlan.Location = New System.Drawing.Point(105, 26)
        Me.cmbPlan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPlan.Name = "cmbPlan"
        Me.cmbPlan.Size = New System.Drawing.Size(309, 60)
        Me.cmbPlan.TabIndex = 149
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Blue
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(12, 82)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(404, 58)
        Me.btnBuscar.TabIndex = 141
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cmbSemestre
        '
        Me.cmbSemestre.BackColor = System.Drawing.Color.White
        Me.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemestre.ForeColor = System.Drawing.Color.Black
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbSemestre.Location = New System.Drawing.Point(12, 26)
        Me.cmbSemestre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(84, 60)
        Me.cmbSemestre.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 20)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "ELIGE ESPECIALIDAD"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.BackColor = System.Drawing.Color.White
        Me.cmbEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecialidad.ForeColor = System.Drawing.Color.Black
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(8, 123)
        Me.cmbEspecialidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(779, 33)
        Me.cmbEspecialidad.TabIndex = 141
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.BackColor = System.Drawing.Color.White
        Me.cmbLicenciatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLicenciatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLicenciatura.ForeColor = System.Drawing.Color.Black
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(8, 42)
        Me.cmbLicenciatura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(779, 33)
        Me.cmbLicenciatura.TabIndex = 140
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(584, 36)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "LISTADO DE MATERIAS Y DOCENTES"
        '
        'gridListado
        '
        Me.gridListado.AllowUserToAddRows = False
        Me.gridListado.AllowUserToDeleteRows = False
        Me.gridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CICLO, Me.IDLICE, Me.LICENCIATURA, Me.ESPECIALIDAD, Me.SEMESTRE, Me.IDMATERIA, Me.MATERIA})
        Me.gridListado.Location = New System.Drawing.Point(4, 17)
        Me.gridListado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridListado.Name = "gridListado"
        Me.gridListado.ReadOnly = True
        Me.gridListado.Size = New System.Drawing.Size(1589, 453)
        Me.gridListado.TabIndex = 144
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CICLO
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CICLO.DefaultCellStyle = DataGridViewCellStyle1
        Me.CICLO.HeaderText = "CICLO ESCOLAR"
        Me.CICLO.Name = "CICLO"
        Me.CICLO.ReadOnly = True
        Me.CICLO.Width = 70
        '
        'IDLICE
        '
        Me.IDLICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDLICE.HeaderText = "IDLICE"
        Me.IDLICE.Name = "IDLICE"
        Me.IDLICE.ReadOnly = True
        '
        'LICENCIATURA
        '
        Me.LICENCIATURA.HeaderText = "LICEN"
        Me.LICENCIATURA.Name = "LICENCIATURA"
        Me.LICENCIATURA.ReadOnly = True
        '
        'ESPECIALIDAD
        '
        Me.ESPECIALIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ESPECIALIDAD.DefaultCellStyle = DataGridViewCellStyle2
        Me.ESPECIALIDAD.HeaderText = "ESPECIALIDAD"
        Me.ESPECIALIDAD.Name = "ESPECIALIDAD"
        Me.ESPECIALIDAD.ReadOnly = True
        Me.ESPECIALIDAD.Width = 130
        '
        'SEMESTRE
        '
        Me.SEMESTRE.HeaderText = "SEMESTRE"
        Me.SEMESTRE.Name = "SEMESTRE"
        Me.SEMESTRE.ReadOnly = True
        '
        'IDMATERIA
        '
        Me.IDMATERIA.HeaderText = "IDMATERIA"
        Me.IDMATERIA.Name = "IDMATERIA"
        Me.IDMATERIA.ReadOnly = True
        '
        'MATERIA
        '
        Me.MATERIA.HeaderText = "MATERIA"
        Me.MATERIA.Name = "MATERIA"
        Me.MATERIA.ReadOnly = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackColor = System.Drawing.Color.Blue
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdAgregar.Image = Global.catalogosIsenco.My.Resources.Resources._16__File_add_
        Me.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(1595, 14)
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(119, 62)
        Me.cmdAgregar.TabIndex = 145
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.Blue
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEliminar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Db_delete_
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(1595, 82)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(119, 62)
        Me.cmdEliminar.TabIndex = 146
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grupoPrincipal)
        Me.Panel1.Controls.Add(Me.gridListado)
        Me.Panel1.Controls.Add(Me.cmdEliminar)
        Me.Panel1.Controls.Add(Me.cmdAgregar)
        Me.Panel1.Location = New System.Drawing.Point(16, 254)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1717, 490)
        Me.Panel1.TabIndex = 147
        '
        'grupoPrincipal
        '
        Me.grupoPrincipal.Controls.Add(Me.Button1)
        Me.grupoPrincipal.Controls.Add(Me.Label4)
        Me.grupoPrincipal.Controls.Add(Me.cmbMateria)
        Me.grupoPrincipal.Controls.Add(Me.cmdGuardar)
        Me.grupoPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoPrincipal.Location = New System.Drawing.Point(271, 73)
        Me.grupoPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoPrincipal.Name = "grupoPrincipal"
        Me.grupoPrincipal.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoPrincipal.Size = New System.Drawing.Size(1036, 154)
        Me.grupoPrincipal.TabIndex = 147
        Me.grupoPrincipal.TabStop = False
        Me.grupoPrincipal.Text = "Alta de Materias a Licenciaturas"
        Me.grupoPrincipal.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(999, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 32)
        Me.Button1.TabIndex = 147
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 20)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "ELIGE LA MATERIA"
        '
        'cmbMateria
        '
        Me.cmbMateria.BackColor = System.Drawing.Color.White
        Me.cmbMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMateria.ForeColor = System.Drawing.Color.Black
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(13, 59)
        Me.cmbMateria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(1013, 33)
        Me.cmbMateria.TabIndex = 143
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Blue
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGuardar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(856, 101)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(172, 43)
        Me.cmdGuardar.TabIndex = 142
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'PlanEstudiosCicloFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1739, 740)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PlanEstudiosCicloFrm"
        Me.Text = "Plan de Estudios y Licenciaturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.grupoPrincipal.ResumeLayout(False)
        Me.grupoPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridListado As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grupoPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbMateria As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CICLO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDLICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LICENCIATURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESPECIALIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEMESTRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMATERIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MATERIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbPlan As System.Windows.Forms.ComboBox
End Class
