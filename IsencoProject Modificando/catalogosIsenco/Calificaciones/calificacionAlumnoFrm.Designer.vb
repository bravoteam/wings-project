<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calificacionAlumnoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calificacionAlumnoFrm))
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.txtCampus = New System.Windows.Forms.TextBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtLicenciatura = New System.Windows.Forms.TextBox()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtSemestre = New System.Windows.Forms.TextBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.oFotografia = New System.Windows.Forms.PictureBox()
        Me.comboAlumno = New System.Windows.Forms.Label()
        Me.regresarCmd = New System.Windows.Forms.PictureBox()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regresarCmd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Blue
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(572, 620)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(505, 66)
        Me.cmdGuardar.TabIndex = 57
        Me.cmdGuardar.Text = "Acepto Calificaciones"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'txtCampus
        '
        Me.txtCampus.Enabled = False
        Me.txtCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampus.Location = New System.Drawing.Point(46, 425)
        Me.txtCampus.Name = "txtCampus"
        Me.txtCampus.Size = New System.Drawing.Size(255, 31)
        Me.txtCampus.TabIndex = 54
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Enabled = False
        Me.txtEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecialidad.Location = New System.Drawing.Point(46, 534)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(500, 31)
        Me.txtEspecialidad.TabIndex = 52
        '
        'txtLicenciatura
        '
        Me.txtLicenciatura.Enabled = False
        Me.txtLicenciatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenciatura.Location = New System.Drawing.Point(46, 479)
        Me.txtLicenciatura.Name = "txtLicenciatura"
        Me.txtLicenciatura.Size = New System.Drawing.Size(500, 31)
        Me.txtLicenciatura.TabIndex = 51
        '
        'txtGrupo
        '
        Me.txtGrupo.Enabled = False
        Me.txtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupo.Location = New System.Drawing.Point(46, 639)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(255, 31)
        Me.txtGrupo.TabIndex = 50
        '
        'txtSemestre
        '
        Me.txtSemestre.Enabled = False
        Me.txtSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemestre.Location = New System.Drawing.Point(46, 586)
        Me.txtSemestre.Name = "txtSemestre"
        Me.txtSemestre.Size = New System.Drawing.Size(255, 31)
        Me.txtSemestre.TabIndex = 49
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.BackgroundColor = System.Drawing.Color.Navy
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Enabled = False
        Me.DG.Location = New System.Drawing.Point(557, 313)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(776, 280)
        Me.DG.TabIndex = 46
        '
        'oFotografia
        '
        Me.oFotografia.BackColor = System.Drawing.Color.White
        Me.oFotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.oFotografia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oFotografia.Location = New System.Drawing.Point(45, 92)
        Me.oFotografia.Name = "oFotografia"
        Me.oFotografia.Size = New System.Drawing.Size(204, 182)
        Me.oFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.oFotografia.TabIndex = 60
        Me.oFotografia.TabStop = False
        '
        'comboAlumno
        '
        Me.comboAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAlumno.Location = New System.Drawing.Point(46, 314)
        Me.comboAlumno.Name = "comboAlumno"
        Me.comboAlumno.Size = New System.Drawing.Size(500, 81)
        Me.comboAlumno.TabIndex = 61
        '
        'regresarCmd
        '
        Me.regresarCmd.BackColor = System.Drawing.Color.Transparent
        Me.regresarCmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regresarCmd.Location = New System.Drawing.Point(46, 34)
        Me.regresarCmd.Name = "regresarCmd"
        Me.regresarCmd.Size = New System.Drawing.Size(204, 58)
        Me.regresarCmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.regresarCmd.TabIndex = 62
        Me.regresarCmd.TabStop = False
        '
        'calificacionAlumnoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1339, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.regresarCmd)
        Me.Controls.Add(Me.comboAlumno)
        Me.Controls.Add(Me.oFotografia)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.txtCampus)
        Me.Controls.Add(Me.txtEspecialidad)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.txtSemestre)
        Me.Controls.Add(Me.txtLicenciatura)
        Me.Controls.Add(Me.txtGrupo)
        Me.Name = "calificacionAlumnoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calificaciones de Alumnos"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regresarCmd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents txtCampus As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents txtLicenciatura As System.Windows.Forms.TextBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtSemestre As System.Windows.Forms.TextBox
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents oFotografia As System.Windows.Forms.PictureBox
    Friend WithEvents comboAlumno As System.Windows.Forms.Label
    Friend WithEvents regresarCmd As System.Windows.Forms.PictureBox
End Class
