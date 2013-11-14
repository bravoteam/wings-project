<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlumnoMaestro
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
        Me.Gbxdatos = New System.Windows.Forms.GroupBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbLicenciatura = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCampus = New System.Windows.Forms.ComboBox()
        Me.cmbmaestro = New System.Windows.Forms.ComboBox()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        Me.GbxAlumnos = New System.Windows.Forms.GroupBox()
        Me.lblRegs = New System.Windows.Forms.Label()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblidmaestro = New System.Windows.Forms.Label()
        Me.GbxDocentes = New System.Windows.Forms.GroupBox()
        Me.Gbxdatos.SuspendLayout()
        Me.GbxAlumnos.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxDocentes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbxdatos
        '
        Me.Gbxdatos.Controls.Add(Me.BtnGenerar)
        Me.Gbxdatos.Controls.Add(Me.Label2)
        Me.Gbxdatos.Controls.Add(Me.cmbTurno)
        Me.Gbxdatos.Controls.Add(Me.Label7)
        Me.Gbxdatos.Controls.Add(Me.cmbEspecialidad)
        Me.Gbxdatos.Controls.Add(Me.Label6)
        Me.Gbxdatos.Controls.Add(Me.cmbLicenciatura)
        Me.Gbxdatos.Controls.Add(Me.Label4)
        Me.Gbxdatos.Controls.Add(Me.cmbGrupo)
        Me.Gbxdatos.Controls.Add(Me.Label5)
        Me.Gbxdatos.Controls.Add(Me.cmbSemestre)
        Me.Gbxdatos.Controls.Add(Me.Label1)
        Me.Gbxdatos.Controls.Add(Me.cmbCampus)
        Me.Gbxdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbxdatos.Location = New System.Drawing.Point(6, 15)
        Me.Gbxdatos.Margin = New System.Windows.Forms.Padding(4)
        Me.Gbxdatos.Name = "Gbxdatos"
        Me.Gbxdatos.Padding = New System.Windows.Forms.Padding(4)
        Me.Gbxdatos.Size = New System.Drawing.Size(1140, 149)
        Me.Gbxdatos.TabIndex = 46
        Me.Gbxdatos.TabStop = False
        Me.Gbxdatos.Text = "Datos Escolares"
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.Blue
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGenerar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerar.Location = New System.Drawing.Point(874, 43)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(232, 57)
        Me.BtnGenerar.TabIndex = 51
        Me.BtnGenerar.Text = "Generar Lista"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Turno"
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"TM", "TV"})
        Me.cmbTurno.Location = New System.Drawing.Point(245, 100)
        Me.cmbTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(71, 24)
        Me.cmbTurno.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 79)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Especialidad"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(368, 100)
        Me.cmbEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(385, 24)
        Me.cmbEspecialidad.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(365, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Licenciatura"
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(368, 45)
        Me.cmbLicenciatura.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(385, 24)
        Me.cmbLicenciatura.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Grupo"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(135, 100)
        Me.cmbGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(71, 24)
        Me.cmbGrupo.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Semestre"
        '
        'cmbSemestre
        '
        Me.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Items.AddRange(New Object() {"7", "8"})
        Me.cmbSemestre.Location = New System.Drawing.Point(20, 100)
        Me.cmbSemestre.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(77, 24)
        Me.cmbSemestre.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Campus"
        '
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(21, 45)
        Me.cmbCampus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(297, 24)
        Me.cmbCampus.TabIndex = 38
        '
        'cmbmaestro
        '
        Me.cmbmaestro.FormattingEnabled = True
        Me.cmbmaestro.Location = New System.Drawing.Point(21, 19)
        Me.cmbmaestro.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbmaestro.Name = "cmbmaestro"
        Me.cmbmaestro.Size = New System.Drawing.Size(732, 24)
        Me.cmbmaestro.TabIndex = 47
        '
        'BtnAsignar
        '
        Me.BtnAsignar.BackColor = System.Drawing.Color.Blue
        Me.BtnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAsignar.ForeColor = System.Drawing.Color.White
        Me.BtnAsignar.Image = Global.catalogosIsenco.My.Resources.Resources._16__File_add_
        Me.BtnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAsignar.Location = New System.Drawing.Point(874, 11)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(232, 51)
        Me.BtnAsignar.TabIndex = 52
        Me.BtnAsignar.Text = "Asignar Docente"
        Me.BtnAsignar.UseVisualStyleBackColor = False
        '
        'GbxAlumnos
        '
        Me.GbxAlumnos.Controls.Add(Me.lblRegs)
        Me.GbxAlumnos.Controls.Add(Me.DG)
        Me.GbxAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxAlumnos.Location = New System.Drawing.Point(11, 240)
        Me.GbxAlumnos.Margin = New System.Windows.Forms.Padding(4)
        Me.GbxAlumnos.Name = "GbxAlumnos"
        Me.GbxAlumnos.Padding = New System.Windows.Forms.Padding(4)
        Me.GbxAlumnos.Size = New System.Drawing.Size(1140, 524)
        Me.GbxAlumnos.TabIndex = 48
        Me.GbxAlumnos.TabStop = False
        Me.GbxAlumnos.Text = "Alumnos"
        '
        'lblRegs
        '
        Me.lblRegs.AutoSize = True
        Me.lblRegs.Location = New System.Drawing.Point(9, 498)
        Me.lblRegs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegs.Name = "lblRegs"
        Me.lblRegs.Size = New System.Drawing.Size(17, 17)
        Me.lblRegs.TabIndex = 40
        Me.lblRegs.Text = "0"
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(11, 23)
        Me.DG.Margin = New System.Windows.Forms.Padding(4)
        Me.DG.Name = "DG"
        Me.DG.RowTemplate.Height = 24
        Me.DG.Size = New System.Drawing.Size(1121, 471)
        Me.DG.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(510, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 15)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "(ENTER PARA BUSCAR MAESTROS)"
        '
        'lblidmaestro
        '
        Me.lblidmaestro.AutoSize = True
        Me.lblidmaestro.Location = New System.Drawing.Point(761, 23)
        Me.lblidmaestro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidmaestro.Name = "lblidmaestro"
        Me.lblidmaestro.Size = New System.Drawing.Size(17, 17)
        Me.lblidmaestro.TabIndex = 155
        Me.lblidmaestro.Text = "0"
        '
        'GbxDocentes
        '
        Me.GbxDocentes.Controls.Add(Me.lblidmaestro)
        Me.GbxDocentes.Controls.Add(Me.Label3)
        Me.GbxDocentes.Controls.Add(Me.BtnAsignar)
        Me.GbxDocentes.Controls.Add(Me.cmbmaestro)
        Me.GbxDocentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxDocentes.Location = New System.Drawing.Point(6, 167)
        Me.GbxDocentes.Name = "GbxDocentes"
        Me.GbxDocentes.Size = New System.Drawing.Size(1141, 69)
        Me.GbxDocentes.TabIndex = 47
        Me.GbxDocentes.TabStop = False
        Me.GbxDocentes.Text = "Docentes:"
        '
        'FrmAlumnoMaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 778)
        Me.Controls.Add(Me.Gbxdatos)
        Me.Controls.Add(Me.GbxAlumnos)
        Me.Controls.Add(Me.GbxDocentes)
        Me.Name = "FrmAlumnoMaestro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alumno Maestro"
        Me.Gbxdatos.ResumeLayout(False)
        Me.Gbxdatos.PerformLayout()
        Me.GbxAlumnos.ResumeLayout(False)
        Me.GbxAlumnos.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxDocentes.ResumeLayout(False)
        Me.GbxDocentes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCampus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmaestro As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAsignar As System.Windows.Forms.Button
    Friend WithEvents GbxAlumnos As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegs As System.Windows.Forms.Label
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblidmaestro As System.Windows.Forms.Label
    Friend WithEvents GbxDocentes As System.Windows.Forms.GroupBox
End Class
