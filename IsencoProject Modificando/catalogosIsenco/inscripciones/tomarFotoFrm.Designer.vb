<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tomarFotoFrm
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
        Me.btnTake = New System.Windows.Forms.Button()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtidAlumno = New System.Windows.Forms.TextBox()
        Me.oFotografia = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCampus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLicenciatura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtFotografia = New System.Windows.Forms.TextBox()
        CType(Me.oFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTake
        '
        Me.btnTake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTake.Location = New System.Drawing.Point(899, 463)
        Me.btnTake.Name = "btnTake"
        Me.btnTake.Size = New System.Drawing.Size(161, 29)
        Me.btnTake.TabIndex = 75
        Me.btnTake.Text = "Tomar Foto"
        Me.btnTake.UseVisualStyleBackColor = True
        '
        'btnBegin
        '
        Me.btnBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.Location = New System.Drawing.Point(588, 462)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(175, 30)
        Me.btnBegin.TabIndex = 74
        Me.btnBegin.Text = "Iniciar Captura"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(13, 24)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(76, 13)
        Me.Label39.TabIndex = 72
        Me.Label39.Text = "ID ALUMNO"
        '
        'txtidAlumno
        '
        Me.txtidAlumno.Enabled = False
        Me.txtidAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidAlumno.Location = New System.Drawing.Point(95, 16)
        Me.txtidAlumno.Name = "txtidAlumno"
        Me.txtidAlumno.Size = New System.Drawing.Size(130, 21)
        Me.txtidAlumno.TabIndex = 73
        '
        'oFotografia
        '
        Me.oFotografia.BackColor = System.Drawing.Color.Transparent
        Me.oFotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.oFotografia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oFotografia.Location = New System.Drawing.Point(588, 72)
        Me.oFotografia.Name = "oFotografia"
        Me.oFotografia.Size = New System.Drawing.Size(472, 385)
        Me.oFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.oFotografia.TabIndex = 71
        Me.oFotografia.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(12, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(514, 35)
        Me.txtNombre.TabIndex = 65
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(14, 156)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(512, 35)
        Me.txtApellidoPaterno.TabIndex = 66
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(15, 236)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(511, 35)
        Me.txtApellidoMaterno.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "NOMBRE (S)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "APELLIDO PATERNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "APELLIDO MATERNO"
        '
        'Timer1
        '
        '
        'txtCampus
        '
        Me.txtCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampus.Location = New System.Drawing.Point(15, 322)
        Me.txtCampus.Name = "txtCampus"
        Me.txtCampus.Size = New System.Drawing.Size(511, 35)
        Me.txtCampus.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "CAMPUS"
        '
        'txtLicenciatura
        '
        Me.txtLicenciatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenciatura.Location = New System.Drawing.Point(16, 405)
        Me.txtLicenciatura.Multiline = True
        Me.txtLicenciatura.Name = "txtLicenciatura"
        Me.txtLicenciatura.Size = New System.Drawing.Size(511, 87)
        Me.txtLicenciatura.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 20)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "LICENCIATURA"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(874, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 59)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Blue
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(588, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(186, 59)
        Me.btnBuscar.TabIndex = 125
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtFotografia
        '
        Me.txtFotografia.Location = New System.Drawing.Point(738, 463)
        Me.txtFotografia.Name = "txtFotografia"
        Me.txtFotografia.Size = New System.Drawing.Size(206, 20)
        Me.txtFotografia.TabIndex = 127
        Me.txtFotografia.Visible = False
        '
        'tomarFotoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 520)
        Me.Controls.Add(Me.txtFotografia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtLicenciatura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCampus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTake)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.txtidAlumno)
        Me.Controls.Add(Me.oFotografia)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "tomarFotoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toma de Fotografía"
        CType(Me.oFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTake As System.Windows.Forms.Button
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtidAlumno As System.Windows.Forms.TextBox
    Friend WithEvents oFotografia As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtCampus As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtLicenciatura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtFotografia As System.Windows.Forms.TextBox
End Class
