<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generarMatriculas
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
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdGrupo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radio2 = New System.Windows.Forms.RadioButton()
        Me.radio1 = New System.Windows.Forms.RadioButton()
        Me.guardarCmd = New System.Windows.Forms.Button()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdLicenciatura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCampus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.consultarcmd = New System.Windows.Forms.Button()
        Me.lblRegs = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Grid.Location = New System.Drawing.Point(18, 140)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1128, 448)
        Me.Grid.TabIndex = 3
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(78, 52)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(160, 21)
        Me.cmbSemestre.TabIndex = 14
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
        'cmdGrupo
        '
        Me.cmdGrupo.FormattingEnabled = True
        Me.cmdGrupo.Location = New System.Drawing.Point(329, 52)
        Me.cmdGrupo.Name = "cmdGrupo"
        Me.cmdGrupo.Size = New System.Drawing.Size(330, 21)
        Me.cmdGrupo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "GRUPO:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radio2)
        Me.Panel1.Controls.Add(Me.radio1)
        Me.Panel1.Controls.Add(Me.guardarCmd)
        Me.Panel1.Controls.Add(Me.cmbTurno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmdEspecialidad)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmdLicenciatura)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbCampus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSemestre)
        Me.Panel1.Controls.Add(Me.consultarcmd)
        Me.Panel1.Controls.Add(Me.cmdGrupo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 122)
        Me.Panel1.TabIndex = 18
        '
        'radio2
        '
        Me.radio2.AutoSize = True
        Me.radio2.Location = New System.Drawing.Point(847, 87)
        Me.radio2.Name = "radio2"
        Me.radio2.Size = New System.Drawing.Size(80, 17)
        Me.radio2.TabIndex = 28
        Me.radio2.Text = "Bachillerato"
        Me.radio2.UseVisualStyleBackColor = True
        '
        'radio1
        '
        Me.radio1.AutoSize = True
        Me.radio1.Checked = True
        Me.radio1.Location = New System.Drawing.Point(718, 87)
        Me.radio1.Name = "radio1"
        Me.radio1.Size = New System.Drawing.Size(83, 17)
        Me.radio1.TabIndex = 27
        Me.radio1.TabStop = True
        Me.radio1.Text = "Licenciatura"
        Me.radio1.UseVisualStyleBackColor = True
        '
        'guardarCmd
        '
        Me.guardarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.guardarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarCmd.Location = New System.Drawing.Point(329, 79)
        Me.guardarCmd.Name = "guardarCmd"
        Me.guardarCmd.Size = New System.Drawing.Size(170, 29)
        Me.guardarCmd.TabIndex = 19
        Me.guardarCmd.Text = "Guardar"
        Me.guardarCmd.UseVisualStyleBackColor = True
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"TM", "TV"})
        Me.cmbTurno.Location = New System.Drawing.Point(758, 51)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(223, 21)
        Me.cmbTurno.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(665, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "TURNO:"
        '
        'cmdEspecialidad
        '
        Me.cmdEspecialidad.FormattingEnabled = True
        Me.cmdEspecialidad.Location = New System.Drawing.Point(758, 12)
        Me.cmdEspecialidad.Name = "cmdEspecialidad"
        Me.cmdEspecialidad.Size = New System.Drawing.Size(223, 21)
        Me.cmdEspecialidad.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(665, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ESPECIALIDAD:"
        '
        'cmdLicenciatura
        '
        Me.cmdLicenciatura.FormattingEnabled = True
        Me.cmdLicenciatura.Location = New System.Drawing.Point(329, 12)
        Me.cmdLicenciatura.Name = "cmdLicenciatura"
        Me.cmdLicenciatura.Size = New System.Drawing.Size(330, 21)
        Me.cmdLicenciatura.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "LICENCIATURA:"
        '
        'cmbCampus
        '
        Me.cmbCampus.FormattingEnabled = True
        Me.cmbCampus.Location = New System.Drawing.Point(78, 12)
        Me.cmbCampus.Name = "cmbCampus"
        Me.cmbCampus.Size = New System.Drawing.Size(160, 21)
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
        'consultarcmd
        '
        Me.consultarcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmd.Location = New System.Drawing.Point(78, 79)
        Me.consultarcmd.Name = "consultarcmd"
        Me.consultarcmd.Size = New System.Drawing.Size(170, 29)
        Me.consultarcmd.TabIndex = 18
        Me.consultarcmd.Text = "Consultar"
        Me.consultarcmd.UseVisualStyleBackColor = True
        '
        'lblRegs
        '
        Me.lblRegs.AutoSize = True
        Me.lblRegs.Location = New System.Drawing.Point(15, 597)
        Me.lblRegs.Name = "lblRegs"
        Me.lblRegs.Size = New System.Drawing.Size(13, 13)
        Me.lblRegs.TabIndex = 19
        Me.lblRegs.Text = "0"
        '
        'generarMatriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 619)
        Me.Controls.Add(Me.lblRegs)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grid)
        Me.Name = "generarMatriculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Matriculas"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents consultarcmd As System.Windows.Forms.Button
    Friend WithEvents cmbCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents guardarCmd As System.Windows.Forms.Button
    Friend WithEvents radio2 As System.Windows.Forms.RadioButton
    Friend WithEvents radio1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblRegs As System.Windows.Forms.Label
End Class
