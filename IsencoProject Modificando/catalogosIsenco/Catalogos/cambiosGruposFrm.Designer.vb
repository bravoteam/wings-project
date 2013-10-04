<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiosGruposFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.statusGroup = New System.Windows.Forms.GroupBox()
        Me.cmbNTurno = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.actualizaCmd = New System.Windows.Forms.Button()
        Me.cmbNGrupo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.consultarcmd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdLicenciatura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCampus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.cmdGrupo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Statusbar1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbNSemestre = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.statusGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Statusbar1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusGroup
        '
        Me.statusGroup.Controls.Add(Me.cmbNSemestre)
        Me.statusGroup.Controls.Add(Me.Label9)
        Me.statusGroup.Controls.Add(Me.cmbNTurno)
        Me.statusGroup.Controls.Add(Me.Label8)
        Me.statusGroup.Controls.Add(Me.actualizaCmd)
        Me.statusGroup.Controls.Add(Me.cmbNGrupo)
        Me.statusGroup.Controls.Add(Me.Label7)
        Me.statusGroup.Location = New System.Drawing.Point(713, 10)
        Me.statusGroup.Name = "statusGroup"
        Me.statusGroup.Size = New System.Drawing.Size(448, 118)
        Me.statusGroup.TabIndex = 27
        Me.statusGroup.TabStop = False
        Me.statusGroup.Text = "CAMBIAR GRUPO Y TURNO"
        Me.statusGroup.Visible = False
        '
        'cmbNTurno
        '
        Me.cmbNTurno.FormattingEnabled = True
        Me.cmbNTurno.Items.AddRange(New Object() {"TV", "TM"})
        Me.cmbNTurno.Location = New System.Drawing.Point(113, 81)
        Me.cmbNTurno.Name = "cmbNTurno"
        Me.cmbNTurno.Size = New System.Drawing.Size(107, 21)
        Me.cmbNTurno.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "NUEVO TURNO"
        '
        'actualizaCmd
        '
        Me.actualizaCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actualizaCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Spelling_
        Me.actualizaCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.actualizaCmd.Location = New System.Drawing.Point(238, 74)
        Me.actualizaCmd.Name = "actualizaCmd"
        Me.actualizaCmd.Size = New System.Drawing.Size(143, 32)
        Me.actualizaCmd.TabIndex = 20
        Me.actualizaCmd.Text = "Actualizar"
        Me.actualizaCmd.UseVisualStyleBackColor = True
        '
        'cmbNGrupo
        '
        Me.cmbNGrupo.FormattingEnabled = True
        Me.cmbNGrupo.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "U"})
        Me.cmbNGrupo.Location = New System.Drawing.Point(113, 51)
        Me.cmbNGrupo.Name = "cmbNGrupo"
        Me.cmbNGrupo.Size = New System.Drawing.Size(107, 21)
        Me.cmbNGrupo.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "NUEVO GRUPO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.statusGroup)
        Me.Panel1.Controls.Add(Me.cmbTurno)
        Me.Panel1.Controls.Add(Me.consultarcmd)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmdEspecialidad)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmdLicenciatura)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbCampus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSemestre)
        Me.Panel1.Controls.Add(Me.cmdGrupo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 131)
        Me.Panel1.TabIndex = 31
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"TM", "TV"})
        Me.cmbTurno.Location = New System.Drawing.Point(68, 81)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(161, 21)
        Me.cmbTurno.TabIndex = 25
        '
        'consultarcmd
        '
        Me.consultarcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmd.Location = New System.Drawing.Point(550, 79)
        Me.consultarcmd.Name = "consultarcmd"
        Me.consultarcmd.Size = New System.Drawing.Size(143, 32)
        Me.consultarcmd.TabIndex = 18
        Me.consultarcmd.Text = "Consultar"
        Me.consultarcmd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "TURNO:"
        '
        'cmdEspecialidad
        '
        Me.cmdEspecialidad.FormattingEnabled = True
        Me.cmdEspecialidad.Location = New System.Drawing.Point(326, 53)
        Me.cmdEspecialidad.Name = "cmdEspecialidad"
        Me.cmdEspecialidad.Size = New System.Drawing.Size(367, 21)
        Me.cmdEspecialidad.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ESPECIALIDAD:"
        '
        'cmdLicenciatura
        '
        Me.cmdLicenciatura.FormattingEnabled = True
        Me.cmdLicenciatura.Location = New System.Drawing.Point(326, 12)
        Me.cmdLicenciatura.Name = "cmdLicenciatura"
        Me.cmdLicenciatura.Size = New System.Drawing.Size(367, 21)
        Me.cmdLicenciatura.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "LICENCIATURA:"
        '
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(70, 12)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(159, 21)
        Me.cmbCampus.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "CAMPUS:"
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(70, 52)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(159, 21)
        Me.cmbSemestre.TabIndex = 14
        '
        'cmdGrupo
        '
        Me.cmdGrupo.FormattingEnabled = True
        Me.cmdGrupo.Location = New System.Drawing.Point(326, 81)
        Me.cmdGrupo.Name = "cmdGrupo"
        Me.cmdGrupo.Size = New System.Drawing.Size(81, 21)
        Me.cmdGrupo.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "SEMESTRE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "GRUPO:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Statusbar1
        '
        Me.Statusbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.Statusbar1.Location = New System.Drawing.Point(0, 692)
        Me.Statusbar1.Name = "Statusbar1"
        Me.Statusbar1.Size = New System.Drawing.Size(1185, 22)
        Me.Statusbar1.TabIndex = 32
        Me.Statusbar1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(12, 164)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1166, 523)
        Me.Grid.TabIndex = 30
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarCambiosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1185, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarCambiosToolStripMenuItem1})
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'GuardarCambiosToolStripMenuItem1
        '
        Me.GuardarCambiosToolStripMenuItem1.Name = "GuardarCambiosToolStripMenuItem1"
        Me.GuardarCambiosToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.GuardarCambiosToolStripMenuItem1.Text = "Guardar Cambios"
        '
        'cmbNSemestre
        '
        Me.cmbNSemestre.FormattingEnabled = True
        Me.cmbNSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbNSemestre.Location = New System.Drawing.Point(113, 19)
        Me.cmbNSemestre.Name = "cmbNSemestre"
        Me.cmbNSemestre.Size = New System.Drawing.Size(107, 21)
        Me.cmbNSemestre.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "NUEVO SEMESTRE"
        '
        'cambiosGruposFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 714)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Statusbar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Grid)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "cambiosGruposFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambios de Grupos"
        Me.statusGroup.ResumeLayout(False)
        Me.statusGroup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Statusbar1.ResumeLayout(False)
        Me.Statusbar1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusGroup As System.Windows.Forms.GroupBox
    Friend WithEvents actualizaCmd As System.Windows.Forms.Button
    Friend WithEvents cmbNGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents consultarcmd As System.Windows.Forms.Button
    Friend WithEvents cmdGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Statusbar1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbNTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GuardarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbNSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
