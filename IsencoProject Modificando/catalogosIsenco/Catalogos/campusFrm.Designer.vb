<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class campusFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidCampus = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcolonia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmunicipio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcct = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.salirCmd = New System.Windows.Forms.Button()
        Me.eliminarCmd = New System.Windows.Forms.Button()
        Me.nuevoCmd = New System.Windows.Forms.Button()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.guardarCmd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID CAMPUS:"
        '
        'txtidCampus
        '
        Me.txtidCampus.Enabled = False
        Me.txtidCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidCampus.Location = New System.Drawing.Point(92, 26)
        Me.txtidCampus.Name = "txtidCampus"
        Me.txtidCampus.Size = New System.Drawing.Size(100, 21)
        Me.txtidCampus.TabIndex = 4
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(92, 52)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(362, 21)
        Me.txtnombre.TabIndex = 0
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
        'txtcalle
        '
        Me.txtcalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcalle.Location = New System.Drawing.Point(92, 78)
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(362, 21)
        Me.txtcalle.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CALLE:"
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(543, 78)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(114, 21)
        Me.txtnumero.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(462, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "#"
        '
        'txtcolonia
        '
        Me.txtcolonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolonia.Location = New System.Drawing.Point(92, 104)
        Me.txtcolonia.Name = "txtcolonia"
        Me.txtcolonia.Size = New System.Drawing.Size(362, 21)
        Me.txtcolonia.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "COLONIA:"
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmunicipio.Location = New System.Drawing.Point(92, 130)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(362, 21)
        Me.txtmunicipio.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MUNICIPIO:"
        '
        'txtcp
        '
        Me.txtcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcp.Location = New System.Drawing.Point(543, 130)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(114, 21)
        Me.txtcp.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "CP:"
        '
        'txtcct
        '
        Me.txtcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcct.Location = New System.Drawing.Point(92, 156)
        Me.txtcct.Name = "txtcct"
        Me.txtcct.Size = New System.Drawing.Size(362, 21)
        Me.txtcct.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CCT:"
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(92, 182)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(362, 21)
        Me.txttelefono.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "TELEFONO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtidCampus)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcct)
        Me.GroupBox1.Controls.Add(Me.txtcalle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcp)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtmunicipio)
        Me.GroupBox1.Controls.Add(Me.txtcolonia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 223)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE CAMPUS"
        '
        'salirCmd
        '
        Me.salirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Exit_
        Me.salirCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salirCmd.Location = New System.Drawing.Point(686, 143)
        Me.salirCmd.Name = "salirCmd"
        Me.salirCmd.Size = New System.Drawing.Size(142, 26)
        Me.salirCmd.TabIndex = 11
        Me.salirCmd.Text = "Salir"
        Me.salirCmd.UseVisualStyleBackColor = True
        '
        'eliminarCmd
        '
        Me.eliminarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Db_delete_
        Me.eliminarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminarCmd.Location = New System.Drawing.Point(686, 78)
        Me.eliminarCmd.Name = "eliminarCmd"
        Me.eliminarCmd.Size = New System.Drawing.Size(142, 27)
        Me.eliminarCmd.TabIndex = 9
        Me.eliminarCmd.Text = "Eliminar"
        Me.eliminarCmd.UseVisualStyleBackColor = True
        '
        'nuevoCmd
        '
        Me.nuevoCmd.BackColor = System.Drawing.SystemColors.Control
        Me.nuevoCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__File_add_
        Me.nuevoCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nuevoCmd.Location = New System.Drawing.Point(686, 12)
        Me.nuevoCmd.Name = "nuevoCmd"
        Me.nuevoCmd.Size = New System.Drawing.Size(142, 27)
        Me.nuevoCmd.TabIndex = 12
        Me.nuevoCmd.Text = "Nuevo"
        Me.nuevoCmd.UseVisualStyleBackColor = False
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.Btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbuscar.Location = New System.Drawing.Point(686, 111)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(142, 26)
        Me.Btnbuscar.TabIndex = 10
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'guardarCmd
        '
        Me.guardarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.guardarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarCmd.Location = New System.Drawing.Point(686, 45)
        Me.guardarCmd.Name = "guardarCmd"
        Me.guardarCmd.Size = New System.Drawing.Size(142, 27)
        Me.guardarCmd.TabIndex = 8
        Me.guardarCmd.Text = "Guardar"
        Me.guardarCmd.UseVisualStyleBackColor = True
        '
        'campusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 241)
        Me.Controls.Add(Me.salirCmd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.eliminarCmd)
        Me.Controls.Add(Me.nuevoCmd)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.guardarCmd)
        Me.Name = "campusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Campus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents guardarCmd As System.Windows.Forms.Button
    Friend WithEvents nuevoCmd As System.Windows.Forms.Button
    Friend WithEvents eliminarCmd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcalle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcolonia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmunicipio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcct As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidCampus As System.Windows.Forms.TextBox
    Friend WithEvents salirCmd As System.Windows.Forms.Button

End Class
