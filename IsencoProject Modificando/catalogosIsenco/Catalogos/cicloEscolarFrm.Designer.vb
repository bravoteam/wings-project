<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cicloEscolarFrm
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
        Me.salirCmd = New System.Windows.Forms.Button()
        Me.eliminarCmd = New System.Windows.Forms.Button()
        Me.nuevoCmd = New System.Windows.Forms.Button()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.guardarCmd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.actualCheck = New System.Windows.Forms.CheckBox()
        Me.fechaDtp2 = New System.Windows.Forms.DateTimePicker()
        Me.fechaDtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidCiclo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'salirCmd
        '
        Me.salirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Exit_
        Me.salirCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salirCmd.Location = New System.Drawing.Point(506, 143)
        Me.salirCmd.Name = "salirCmd"
        Me.salirCmd.Size = New System.Drawing.Size(142, 26)
        Me.salirCmd.TabIndex = 21
        Me.salirCmd.Text = "Salir"
        Me.salirCmd.UseVisualStyleBackColor = True
        '
        'eliminarCmd
        '
        Me.eliminarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Db_delete_
        Me.eliminarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminarCmd.Location = New System.Drawing.Point(506, 78)
        Me.eliminarCmd.Name = "eliminarCmd"
        Me.eliminarCmd.Size = New System.Drawing.Size(142, 27)
        Me.eliminarCmd.TabIndex = 19
        Me.eliminarCmd.Text = "Eliminar"
        Me.eliminarCmd.UseVisualStyleBackColor = True
        '
        'nuevoCmd
        '
        Me.nuevoCmd.BackColor = System.Drawing.SystemColors.Control
        Me.nuevoCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__File_add_
        Me.nuevoCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevoCmd.Location = New System.Drawing.Point(506, 12)
        Me.nuevoCmd.Name = "nuevoCmd"
        Me.nuevoCmd.Size = New System.Drawing.Size(142, 27)
        Me.nuevoCmd.TabIndex = 22
        Me.nuevoCmd.Text = "Nuevo"
        Me.nuevoCmd.UseVisualStyleBackColor = False
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.Btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbuscar.Location = New System.Drawing.Point(506, 111)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(142, 26)
        Me.Btnbuscar.TabIndex = 20
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'guardarCmd
        '
        Me.guardarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.guardarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarCmd.Location = New System.Drawing.Point(506, 45)
        Me.guardarCmd.Name = "guardarCmd"
        Me.guardarCmd.Size = New System.Drawing.Size(142, 27)
        Me.guardarCmd.TabIndex = 5
        Me.guardarCmd.Text = "Guardar"
        Me.guardarCmd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.actualCheck)
        Me.GroupBox1.Controls.Add(Me.fechaDtp2)
        Me.GroupBox1.Controls.Add(Me.fechaDtp1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidCiclo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 164)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL ADMINISTRATIVO"
        '
        'actualCheck
        '
        Me.actualCheck.AutoSize = True
        Me.actualCheck.Location = New System.Drawing.Point(127, 138)
        Me.actualCheck.Name = "actualCheck"
        Me.actualCheck.Size = New System.Drawing.Size(15, 14)
        Me.actualCheck.TabIndex = 4
        Me.actualCheck.UseVisualStyleBackColor = True
        '
        'fechaDtp2
        '
        Me.fechaDtp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaDtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDtp2.Location = New System.Drawing.Point(127, 80)
        Me.fechaDtp2.Name = "fechaDtp2"
        Me.fechaDtp2.Size = New System.Drawing.Size(194, 21)
        Me.fechaDtp2.TabIndex = 2
        '
        'fechaDtp1
        '
        Me.fechaDtp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaDtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDtp1.Location = New System.Drawing.Point(127, 53)
        Me.fechaDtp1.Name = "fechaDtp1"
        Me.fechaDtp1.Size = New System.Drawing.Size(194, 21)
        Me.fechaDtp1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID CICLO ESCOLAR:"
        '
        'txtidCiclo
        '
        Me.txtidCiclo.Enabled = False
        Me.txtidCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidCiclo.Location = New System.Drawing.Point(127, 26)
        Me.txtidCiclo.Name = "txtidCiclo"
        Me.txtidCiclo.Size = New System.Drawing.Size(100, 21)
        Me.txtidCiclo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "INICIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "FIN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ACTUAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "DESCRIPCION"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 107)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(194, 21)
        Me.txtDescripcion.TabIndex = 3
        '
        'cicloEscolarFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 188)
        Me.Controls.Add(Me.salirCmd)
        Me.Controls.Add(Me.eliminarCmd)
        Me.Controls.Add(Me.nuevoCmd)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.guardarCmd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "cicloEscolarFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Ciclos Escolares"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents salirCmd As System.Windows.Forms.Button
    Friend WithEvents eliminarCmd As System.Windows.Forms.Button
    Friend WithEvents nuevoCmd As System.Windows.Forms.Button
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents guardarCmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fechaDtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaDtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidCiclo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents actualCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
End Class
