<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class materiaMaestroFrm
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
        Me.grupoPrincipal = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdPersonalMateria = New System.Windows.Forms.TextBox()
        Me.txtIdCicloLicenciatura = New System.Windows.Forms.TextBox()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.cmbMaestro = New System.Windows.Forms.ComboBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.gridListado = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbPlan = New System.Windows.Forms.ComboBox()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.cmbLicenciatura = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCiclo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCampus = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.grupoPrincipal.SuspendLayout()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grupoPrincipal)
        Me.Panel1.Controls.Add(Me.gridListado)
        Me.Panel1.Location = New System.Drawing.Point(5, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1385, 390)
        Me.Panel1.TabIndex = 151
        '
        'grupoPrincipal
        '
        Me.grupoPrincipal.Controls.Add(Me.Label6)
        Me.grupoPrincipal.Controls.Add(Me.txtIdPersonalMateria)
        Me.grupoPrincipal.Controls.Add(Me.txtIdCicloLicenciatura)
        Me.grupoPrincipal.Controls.Add(Me.txtHoras)
        Me.grupoPrincipal.Controls.Add(Me.Label3)
        Me.grupoPrincipal.Controls.Add(Me.Button1)
        Me.grupoPrincipal.Controls.Add(Me.lblMateria)
        Me.grupoPrincipal.Controls.Add(Me.cmbMaestro)
        Me.grupoPrincipal.Controls.Add(Me.cmdGuardar)
        Me.grupoPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoPrincipal.Location = New System.Drawing.Point(203, 59)
        Me.grupoPrincipal.Name = "grupoPrincipal"
        Me.grupoPrincipal.Size = New System.Drawing.Size(777, 149)
        Me.grupoPrincipal.TabIndex = 147
        Me.grupoPrincipal.TabStop = False
        Me.grupoPrincipal.Text = "Maestros y Materias"
        Me.grupoPrincipal.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(531, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 15)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "(ENTER PARA BUSCAR MAESTROS)"
        '
        'txtIdPersonalMateria
        '
        Me.txtIdPersonalMateria.Location = New System.Drawing.Point(330, 114)
        Me.txtIdPersonalMateria.Name = "txtIdPersonalMateria"
        Me.txtIdPersonalMateria.Size = New System.Drawing.Size(72, 22)
        Me.txtIdPersonalMateria.TabIndex = 152
        Me.txtIdPersonalMateria.Visible = False
        '
        'txtIdCicloLicenciatura
        '
        Me.txtIdCicloLicenciatura.Location = New System.Drawing.Point(213, 114)
        Me.txtIdCicloLicenciatura.Name = "txtIdCicloLicenciatura"
        Me.txtIdCicloLicenciatura.Size = New System.Drawing.Size(72, 22)
        Me.txtIdCicloLicenciatura.TabIndex = 151
        Me.txtIdCicloLicenciatura.Visible = False
        '
        'txtHoras
        '
        Me.txtHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoras.Location = New System.Drawing.Point(10, 98)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(171, 29)
        Me.txtHoras.TabIndex = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 16)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "HORAS FRENTE A GRUPO X SEMANA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(749, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 26)
        Me.Button1.TabIndex = 147
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Location = New System.Drawing.Point(7, 29)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(151, 16)
        Me.lblMateria.TabIndex = 146
        Me.lblMateria.Text = "ELIGE EL MAESTRO"
        '
        'cmbMaestro
        '
        Me.cmbMaestro.BackColor = System.Drawing.Color.White
        Me.cmbMaestro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMaestro.ForeColor = System.Drawing.Color.Black
        Me.cmbMaestro.FormattingEnabled = True
        Me.cmbMaestro.Location = New System.Drawing.Point(10, 48)
        Me.cmbMaestro.Name = "cmbMaestro"
        Me.cmbMaestro.Size = New System.Drawing.Size(761, 28)
        Me.cmbMaestro.TabIndex = 143
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Blue
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGuardar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(642, 94)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(129, 35)
        Me.cmdGuardar.TabIndex = 142
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'gridListado
        '
        Me.gridListado.AllowUserToAddRows = False
        Me.gridListado.AllowUserToDeleteRows = False
        Me.gridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridListado.Location = New System.Drawing.Point(3, 14)
        Me.gridListado.Name = "gridListado"
        Me.gridListado.ReadOnly = True
        Me.gridListado.Size = New System.Drawing.Size(1365, 368)
        Me.gridListado.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(474, 29)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "LISTADO DE MATERIAS Y DOCENTES"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbEspecialidad)
        Me.GroupBox2.Controls.Add(Me.cmbLicenciatura)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(388, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 202)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ELIGE LA LICENCIATURA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbCampus)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbPlan)
        Me.GroupBox3.Controls.Add(Me.cmbGrupo)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.cmbSemestre)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(603, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 175)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ELIGE EL SEMESTRE,PLAN Y GRUPO"
        '
        'cmbPlan
        '
        Me.cmbPlan.BackColor = System.Drawing.Color.White
        Me.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlan.ForeColor = System.Drawing.Color.Black
        Me.cmbPlan.FormattingEnabled = True
        Me.cmbPlan.Location = New System.Drawing.Point(79, 21)
        Me.cmbPlan.Name = "cmbPlan"
        Me.cmbPlan.Size = New System.Drawing.Size(233, 37)
        Me.cmbPlan.TabIndex = 150
        '
        'cmbGrupo
        '
        Me.cmbGrupo.BackColor = System.Drawing.Color.White
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrupo.ForeColor = System.Drawing.Color.Black
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "U"})
        Me.cmbGrupo.Location = New System.Drawing.Point(318, 21)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(64, 37)
        Me.cmbGrupo.TabIndex = 142
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Blue
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(11, 122)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(373, 47)
        Me.btnBuscar.TabIndex = 141
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cmbSemestre
        '
        Me.cmbSemestre.BackColor = System.Drawing.Color.White
        Me.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemestre.ForeColor = System.Drawing.Color.Black
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbSemestre.Location = New System.Drawing.Point(9, 21)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(64, 37)
        Me.cmbSemestre.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 16)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "ELIGE ESPECIALIDAD"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.BackColor = System.Drawing.Color.White
        Me.cmbEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecialidad.ForeColor = System.Drawing.Color.Black
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(6, 100)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(591, 28)
        Me.cmbEspecialidad.TabIndex = 141
        '
        'cmbLicenciatura
        '
        Me.cmbLicenciatura.BackColor = System.Drawing.Color.White
        Me.cmbLicenciatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLicenciatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLicenciatura.ForeColor = System.Drawing.Color.Black
        Me.cmbLicenciatura.FormattingEnabled = True
        Me.cmbLicenciatura.Location = New System.Drawing.Point(6, 34)
        Me.cmbLicenciatura.Name = "cmbLicenciatura"
        Me.cmbLicenciatura.Size = New System.Drawing.Size(591, 28)
        Me.cmbLicenciatura.TabIndex = 140
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCiclo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 147)
        Me.GroupBox1.TabIndex = 148
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
        Me.cmbCiclo.Location = New System.Drawing.Point(6, 34)
        Me.cmbCiclo.Name = "cmbCiclo"
        Me.cmbCiclo.Size = New System.Drawing.Size(348, 81)
        Me.cmbCiclo.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(505, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(556, 24)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "(DOBLE CLIC PARA AGREGAR O MODIFICAR MAESTRO)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "CAMPUS"
        '
        'cmbCampus
        '
        Me.cmbCampus.BackColor = System.Drawing.Color.White
        Me.cmbCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCampus.ForeColor = System.Drawing.Color.Black
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Items.AddRange(New Object() {"TECOMAN", "MANZANILLO", "COLIMA", "CUAUHTEMOC"})
        Me.cmbCampus.Location = New System.Drawing.Point(11, 79)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(371, 37)
        Me.cmbCampus.TabIndex = 152
        '
        'materiaMaestroFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 626)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "materiaMaestroFrm"
        Me.Text = "Relacion de Maestros con Materias"
        Me.Panel1.ResumeLayout(False)
        Me.grupoPrincipal.ResumeLayout(False)
        Me.grupoPrincipal.PerformLayout()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grupoPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblMateria As System.Windows.Forms.Label
    Friend WithEvents cmbMaestro As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents gridListado As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents txtHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIdPersonalMateria As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCicloLicenciatura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPlan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
