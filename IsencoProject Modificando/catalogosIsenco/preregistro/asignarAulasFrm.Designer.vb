<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asignarAulasFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rContexto = New System.Windows.Forms.RadioButton()
        Me.rCeneval = New System.Windows.Forms.RadioButton()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.listaLicenciaturas = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCampus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLicenciatura = New System.Windows.Forms.ComboBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grid2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbAulas = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbAulas)
        Me.Panel1.Controls.Add(Me.rContexto)
        Me.Panel1.Controls.Add(Me.rCeneval)
        Me.Panel1.Controls.Add(Me.cmbTurno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmdLimpiar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.listaLicenciaturas)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbCampus)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbLicenciatura)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1271, 152)
        Me.Panel1.TabIndex = 42
        '
        'rContexto
        '
        Me.rContexto.AutoSize = True
        Me.rContexto.Checked = True
        Me.rContexto.Location = New System.Drawing.Point(306, 3)
        Me.rContexto.Name = "rContexto"
        Me.rContexto.Size = New System.Drawing.Size(113, 19)
        Me.rContexto.TabIndex = 65
        Me.rContexto.TabStop = True
        Me.rContexto.Text = "Aula Contexto"
        Me.rContexto.UseVisualStyleBackColor = True
        '
        'rCeneval
        '
        Me.rCeneval.AutoSize = True
        Me.rCeneval.Location = New System.Drawing.Point(435, 1)
        Me.rCeneval.Name = "rCeneval"
        Me.rCeneval.Size = New System.Drawing.Size(108, 19)
        Me.rCeneval.TabIndex = 64
        Me.rCeneval.Text = "Aula Ceneval"
        Me.rCeneval.UseVisualStyleBackColor = True
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"Turno 1", "Turno 2", "Turno 3", "Turno 4"})
        Me.cmbTurno.Location = New System.Drawing.Point(16, 124)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(240, 23)
        Me.cmbTurno.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Turno"
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(765, 123)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(70, 23)
        Me.cmdLimpiar.TabIndex = 61
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(625, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 138)
        Me.Label4.TabIndex = 60
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(499, 83)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(70, 23)
        Me.cmdAdd.TabIndex = 59
        Me.cmdAdd.Text = "Agregar"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'listaLicenciaturas
        '
        Me.listaLicenciaturas.FormattingEnabled = True
        Me.listaLicenciaturas.ItemHeight = 15
        Me.listaLicenciaturas.Location = New System.Drawing.Point(841, 10)
        Me.listaLicenciaturas.Name = "listaLicenciaturas"
        Me.listaLicenciaturas.Size = New System.Drawing.Size(427, 139)
        Me.listaLicenciaturas.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(667, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Areas Para Asignar Aulas"
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
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(16, 40)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(240, 23)
        Me.cmbCampus.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Licenciatura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Campus"
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(16, 84)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(477, 23)
        Me.cmbLicenciatura.TabIndex = 37
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 181)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(1274, 551)
        Me.grid.TabIndex = 41
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.RegresarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1295, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarGruposToolStripMenuItem, Me.GuardarDatosToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AsignarGruposToolStripMenuItem
        '
        Me.AsignarGruposToolStripMenuItem.Name = "AsignarGruposToolStripMenuItem"
        Me.AsignarGruposToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AsignarGruposToolStripMenuItem.Text = "Asignar Grupos"
        '
        'GuardarDatosToolStripMenuItem
        '
        Me.GuardarDatosToolStripMenuItem.Name = "GuardarDatosToolStripMenuItem"
        Me.GuardarDatosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GuardarDatosToolStripMenuItem.Text = "Guardar Datos"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 733)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1295, 22)
        Me.StatusStrip2.TabIndex = 44
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel3.Text = "Numero de Alumnos"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'grid2
        '
        Me.grid2.AllowUserToAddRows = False
        Me.grid2.AllowUserToDeleteRows = False
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.Location = New System.Drawing.Point(28, 205)
        Me.grid2.Name = "grid2"
        Me.grid2.ReadOnly = True
        Me.grid2.Size = New System.Drawing.Size(433, 137)
        Me.grid2.TabIndex = 62
        Me.grid2.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 15)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Aula"
        '
        'cmbAulas
        '
        Me.cmbAulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAulas.FormattingEnabled = True
        Me.cmbAulas.Location = New System.Drawing.Point(276, 123)
        Me.cmbAulas.Name = "cmbAulas"
        Me.cmbAulas.Size = New System.Drawing.Size(217, 23)
        Me.cmbAulas.TabIndex = 66
        '
        'asignarAulasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 755)
        Me.Controls.Add(Me.grid2)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "asignarAulasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de Aulas a Preregistro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarGruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents listaLicenciaturas As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grid2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rContexto As System.Windows.Forms.RadioButton
    Friend WithEvents rCeneval As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbAulas As System.Windows.Forms.ComboBox
End Class
