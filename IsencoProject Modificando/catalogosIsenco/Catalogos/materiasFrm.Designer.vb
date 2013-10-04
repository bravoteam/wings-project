<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class materiasFrm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCalifica = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkMateria = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboc = New System.Windows.Forms.ComboBox()
        Me.comboe = New System.Windows.Forms.ComboBox()
        Me.combos = New System.Windows.Forms.ComboBox()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtidMateria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtplan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtclaveIsenco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.salirCmd = New System.Windows.Forms.Button()
        Me.eliminarCmd = New System.Windows.Forms.Button()
        Me.nuevoCmd = New System.Windows.Forms.Button()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.guardarCmd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCalifica)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.chkMateria)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.comboc)
        Me.GroupBox1.Controls.Add(Me.comboe)
        Me.GroupBox1.Controls.Add(Me.combos)
        Me.GroupBox1.Controls.Add(Me.cmbSemestre)
        Me.GroupBox1.Controls.Add(Me.cmbEspecialidad)
        Me.GroupBox1.Controls.Add(Me.cmbCarrera)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtidMateria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtplan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtclaveIsenco)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 283)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE LA MATERIA"
        '
        'chkCalifica
        '
        Me.chkCalifica.AutoSize = True
        Me.chkCalifica.Location = New System.Drawing.Point(287, 239)
        Me.chkCalifica.Name = "chkCalifica"
        Me.chkCalifica.Size = New System.Drawing.Size(15, 14)
        Me.chkCalifica.TabIndex = 31
        Me.chkCalifica.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "SE CALIFICA"
        '
        'chkMateria
        '
        Me.chkMateria.AutoSize = True
        Me.chkMateria.Location = New System.Drawing.Point(126, 239)
        Me.chkMateria.Name = "chkMateria"
        Me.chkMateria.Size = New System.Drawing.Size(15, 14)
        Me.chkMateria.TabIndex = 29
        Me.chkMateria.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "MATERIA ACTIVA:"
        '
        'comboc
        '
        Me.comboc.FormattingEnabled = True
        Me.comboc.Location = New System.Drawing.Point(610, 80)
        Me.comboc.Name = "comboc"
        Me.comboc.Size = New System.Drawing.Size(56, 21)
        Me.comboc.TabIndex = 27
        Me.comboc.Visible = False
        '
        'comboe
        '
        Me.comboe.FormattingEnabled = True
        Me.comboe.Location = New System.Drawing.Point(610, 104)
        Me.comboe.Name = "comboe"
        Me.comboe.Size = New System.Drawing.Size(56, 21)
        Me.comboe.TabIndex = 26
        Me.comboe.Visible = False
        '
        'combos
        '
        Me.combos.FormattingEnabled = True
        Me.combos.Location = New System.Drawing.Point(610, 133)
        Me.combos.Name = "combos"
        Me.combos.Size = New System.Drawing.Size(56, 21)
        Me.combos.TabIndex = 25
        Me.combos.Visible = False
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(126, 134)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(499, 21)
        Me.cmbSemestre.TabIndex = 3
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(126, 107)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(499, 21)
        Me.cmbEspecialidad.TabIndex = 2
        '
        'cmbCarrera
        '
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(126, 80)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(499, 21)
        Me.cmbCarrera.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(126, 53)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(499, 21)
        Me.txtnombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID MATERIA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "PLAN DE ESTUDIOS"
        '
        'txtidMateria
        '
        Me.txtidMateria.Enabled = False
        Me.txtidMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidMateria.Location = New System.Drawing.Point(126, 26)
        Me.txtidMateria.Name = "txtidMateria"
        Me.txtidMateria.Size = New System.Drawing.Size(100, 21)
        Me.txtidMateria.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CARRERA:"
        '
        'txtplan
        '
        Me.txtplan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplan.Location = New System.Drawing.Point(126, 158)
        Me.txtplan.Name = "txtplan"
        Me.txtplan.Size = New System.Drawing.Size(499, 21)
        Me.txtplan.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CLAVE ISENCO:"
        '
        'txtclaveIsenco
        '
        Me.txtclaveIsenco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclaveIsenco.Location = New System.Drawing.Point(126, 187)
        Me.txtclaveIsenco.Name = "txtclaveIsenco"
        Me.txtclaveIsenco.Size = New System.Drawing.Size(499, 21)
        Me.txtclaveIsenco.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ESPECIALIDAD:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SEMESTRE:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'salirCmd
        '
        Me.salirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Exit_
        Me.salirCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salirCmd.Location = New System.Drawing.Point(684, 143)
        Me.salirCmd.Name = "salirCmd"
        Me.salirCmd.Size = New System.Drawing.Size(142, 26)
        Me.salirCmd.TabIndex = 10
        Me.salirCmd.Text = "Salir"
        Me.salirCmd.UseVisualStyleBackColor = True
        '
        'eliminarCmd
        '
        Me.eliminarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Db_delete_
        Me.eliminarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminarCmd.Location = New System.Drawing.Point(684, 78)
        Me.eliminarCmd.Name = "eliminarCmd"
        Me.eliminarCmd.Size = New System.Drawing.Size(142, 27)
        Me.eliminarCmd.TabIndex = 8
        Me.eliminarCmd.Text = "Eliminar"
        Me.eliminarCmd.UseVisualStyleBackColor = True
        '
        'nuevoCmd
        '
        Me.nuevoCmd.BackColor = System.Drawing.SystemColors.Control
        Me.nuevoCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__File_add_
        Me.nuevoCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevoCmd.Location = New System.Drawing.Point(684, 12)
        Me.nuevoCmd.Name = "nuevoCmd"
        Me.nuevoCmd.Size = New System.Drawing.Size(142, 27)
        Me.nuevoCmd.TabIndex = 11
        Me.nuevoCmd.Text = "Nuevo"
        Me.nuevoCmd.UseVisualStyleBackColor = False
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.Btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbuscar.Location = New System.Drawing.Point(684, 111)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(142, 26)
        Me.Btnbuscar.TabIndex = 9
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'guardarCmd
        '
        Me.guardarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.guardarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarCmd.Location = New System.Drawing.Point(684, 45)
        Me.guardarCmd.Name = "guardarCmd"
        Me.guardarCmd.Size = New System.Drawing.Size(142, 27)
        Me.guardarCmd.TabIndex = 7
        Me.guardarCmd.Text = "Guardar"
        Me.guardarCmd.UseVisualStyleBackColor = True
        '
        'materiasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 307)
        Me.Controls.Add(Me.salirCmd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.eliminarCmd)
        Me.Controls.Add(Me.nuevoCmd)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.guardarCmd)
        Me.Name = "materiasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Materias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents salirCmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtidMateria As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtplan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtclaveIsenco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents eliminarCmd As System.Windows.Forms.Button
    Friend WithEvents nuevoCmd As System.Windows.Forms.Button
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents guardarCmd As System.Windows.Forms.Button
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents comboc As System.Windows.Forms.ComboBox
    Friend WithEvents comboe As System.Windows.Forms.ComboBox
    Friend WithEvents combos As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkMateria As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkCalifica As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
