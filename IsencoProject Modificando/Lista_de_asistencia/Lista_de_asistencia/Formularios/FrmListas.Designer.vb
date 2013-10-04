<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListas
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
        Me.gp1 = New System.Windows.Forms.GroupBox()
        Me.CmbDocentes = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbMaterias = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CmbParcial = New System.Windows.Forms.ComboBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbModalidad = New System.Windows.Forms.ComboBox()
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
        Me.Gbxdatos.SuspendLayout()
        Me.gp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbxdatos
        '
        Me.Gbxdatos.Controls.Add(Me.gp1)
        Me.Gbxdatos.Controls.Add(Me.chk1)
        Me.Gbxdatos.Controls.Add(Me.BtnSalir)
        Me.Gbxdatos.Controls.Add(Me.CmbParcial)
        Me.Gbxdatos.Controls.Add(Me.BtnGenerar)
        Me.Gbxdatos.Controls.Add(Me.Label10)
        Me.Gbxdatos.Controls.Add(Me.Label3)
        Me.Gbxdatos.Controls.Add(Me.Label2)
        Me.Gbxdatos.Controls.Add(Me.cmbModalidad)
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
        Me.Gbxdatos.Location = New System.Drawing.Point(1, 2)
        Me.Gbxdatos.Name = "Gbxdatos"
        Me.Gbxdatos.Size = New System.Drawing.Size(653, 270)
        Me.Gbxdatos.TabIndex = 41
        Me.Gbxdatos.TabStop = False
        Me.Gbxdatos.Text = "Datos Escolares"
        '
        'gp1
        '
        Me.gp1.Controls.Add(Me.CmbDocentes)
        Me.gp1.Controls.Add(Me.Label8)
        Me.gp1.Controls.Add(Me.CmbMaterias)
        Me.gp1.Controls.Add(Me.Label9)
        Me.gp1.Location = New System.Drawing.Point(11, 130)
        Me.gp1.Name = "gp1"
        Me.gp1.Size = New System.Drawing.Size(626, 53)
        Me.gp1.TabIndex = 59
        Me.gp1.TabStop = False
        '
        'CmbDocentes
        '
        Me.CmbDocentes.FormattingEnabled = True
        Me.CmbDocentes.Location = New System.Drawing.Point(360, 23)
        Me.CmbDocentes.Name = "CmbDocentes"
        Me.CmbDocentes.Size = New System.Drawing.Size(266, 21)
        Me.CmbDocentes.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Materias"
        '
        'CmbMaterias
        '
        Me.CmbMaterias.FormattingEnabled = True
        Me.CmbMaterias.Location = New System.Drawing.Point(10, 23)
        Me.CmbMaterias.Name = "CmbMaterias"
        Me.CmbMaterias.Size = New System.Drawing.Size(329, 21)
        Me.CmbMaterias.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(359, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Docentes"
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1.Location = New System.Drawing.Point(17, 116)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(178, 17)
        Me.chk1.TabIndex = 58
        Me.chk1.Text = "Omitir Materias y Docentes"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(135, 225)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 41)
        Me.BtnSalir.TabIndex = 43
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'CmbParcial
        '
        Me.CmbParcial.FormattingEnabled = True
        Me.CmbParcial.Location = New System.Drawing.Point(20, 199)
        Me.CmbParcial.Name = "CmbParcial"
        Me.CmbParcial.Size = New System.Drawing.Size(329, 21)
        Me.CmbParcial.TabIndex = 57
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Location = New System.Drawing.Point(21, 225)
        Me.BtnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(110, 41)
        Me.BtnGenerar.TabIndex = 42
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Parcial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Modalidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Turno"
        '
        'cmbModalidad
        '
        Me.cmbModalidad.FormattingEnabled = True
        Me.cmbModalidad.Items.AddRange(New Object() {"E"})
        Me.cmbModalidad.Location = New System.Drawing.Point(439, 94)
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.Size = New System.Drawing.Size(53, 21)
        Me.cmbModalidad.TabIndex = 49
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(371, 93)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(54, 21)
        Me.cmbTurno.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Especialidad"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(20, 94)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(329, 21)
        Me.cmbEspecialidad.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Licenciatura"
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(371, 43)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(266, 21)
        Me.cmbLicenciatura.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(580, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Grupo"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(583, 93)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(54, 21)
        Me.cmbGrupo.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Semestre"
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(514, 93)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(52, 21)
        Me.cmbSemestre.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Campus"
        '
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(20, 43)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(329, 21)
        Me.cmbCampus.TabIndex = 38
        '
        'FrmListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 274)
        Me.Controls.Add(Me.Gbxdatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmListas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Listas de Asistencias"
        Me.Gbxdatos.ResumeLayout(False)
        Me.Gbxdatos.PerformLayout()
        Me.gp1.ResumeLayout(False)
        Me.gp1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbModalidad As System.Windows.Forms.ComboBox
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
    Friend WithEvents CmbMaterias As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbDocentes As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents CmbParcial As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents gp1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox

End Class
