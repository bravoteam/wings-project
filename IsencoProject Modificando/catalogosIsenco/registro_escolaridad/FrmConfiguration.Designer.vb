<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguration2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmbresponsable3 = New System.Windows.Forms.ComboBox()
        Me.cmbdirectivo3 = New System.Windows.Forms.ComboBox()
        Me.Dt3 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmbresponsable2 = New System.Windows.Forms.ComboBox()
        Me.cmbdirectivo2 = New System.Windows.Forms.ComboBox()
        Me.Dt2 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbresponsable1 = New System.Windows.Forms.ComboBox()
        Me.cmbdirectivo1 = New System.Windows.Forms.ComboBox()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtfecha3 = New System.Windows.Forms.TextBox()
        Me.txtresponsable3 = New System.Windows.Forms.TextBox()
        Me.txtdirectivo3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtfecha2 = New System.Windows.Forms.TextBox()
        Me.txtresponsable2 = New System.Windows.Forms.TextBox()
        Me.txtdirectivo2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtfecha1 = New System.Windows.Forms.TextBox()
        Me.txtresponsable1 = New System.Windows.Forms.TextBox()
        Me.txtdirectivo1 = New System.Windows.Forms.TextBox()
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.lblresponsable1 = New System.Windows.Forms.Label()
        Me.lbldirectivo1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1117, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ImprimirToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.OtrosToolStripMenuItem.Text = "Opciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 24)
        Me.ToolStripMenuItem1.Text = "Guardar Cambios"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.ImprimirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 391)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Directivos y Fechas de Registro de Escolaridad"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmbresponsable3)
        Me.GroupBox8.Controls.Add(Me.cmbdirectivo3)
        Me.GroupBox8.Controls.Add(Me.Dt3)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(6, 262)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(530, 110)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Recuadro Regularizacion"
        '
        'cmbresponsable3
        '
        Me.cmbresponsable3.FormattingEnabled = True
        Me.cmbresponsable3.Location = New System.Drawing.Point(176, 51)
        Me.cmbresponsable3.Name = "cmbresponsable3"
        Me.cmbresponsable3.Size = New System.Drawing.Size(348, 24)
        Me.cmbresponsable3.TabIndex = 12
        '
        'cmbdirectivo3
        '
        Me.cmbdirectivo3.FormattingEnabled = True
        Me.cmbdirectivo3.Location = New System.Drawing.Point(176, 21)
        Me.cmbdirectivo3.Name = "cmbdirectivo3"
        Me.cmbdirectivo3.Size = New System.Drawing.Size(348, 24)
        Me.cmbdirectivo3.TabIndex = 11
        '
        'Dt3
        '
        Me.Dt3.Location = New System.Drawing.Point(176, 81)
        Me.Dt3.Name = "Dt3"
        Me.Dt3.Size = New System.Drawing.Size(348, 22)
        Me.Dt3.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Fecha:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Responsable del Area:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 17)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Directivo de la Escuela:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmbresponsable2)
        Me.GroupBox7.Controls.Add(Me.cmbdirectivo2)
        Me.GroupBox7.Controls.Add(Me.Dt2)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(6, 140)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(530, 110)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Recuadro Inscripción"
        '
        'cmbresponsable2
        '
        Me.cmbresponsable2.FormattingEnabled = True
        Me.cmbresponsable2.Location = New System.Drawing.Point(176, 51)
        Me.cmbresponsable2.Name = "cmbresponsable2"
        Me.cmbresponsable2.Size = New System.Drawing.Size(348, 24)
        Me.cmbresponsable2.TabIndex = 12
        '
        'cmbdirectivo2
        '
        Me.cmbdirectivo2.FormattingEnabled = True
        Me.cmbdirectivo2.Location = New System.Drawing.Point(176, 21)
        Me.cmbdirectivo2.Name = "cmbdirectivo2"
        Me.cmbdirectivo2.Size = New System.Drawing.Size(348, 24)
        Me.cmbdirectivo2.TabIndex = 11
        '
        'Dt2
        '
        Me.Dt2.Location = New System.Drawing.Point(176, 81)
        Me.Dt2.Name = "Dt2"
        Me.Dt2.Size = New System.Drawing.Size(348, 22)
        Me.Dt2.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Responsable del Area:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Directivo de la Escuela:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbresponsable1)
        Me.GroupBox6.Controls.Add(Me.cmbdirectivo1)
        Me.GroupBox6.Controls.Add(Me.dt1)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 24)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(530, 110)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Recuadro Inscripción"
        '
        'cmbresponsable1
        '
        Me.cmbresponsable1.FormattingEnabled = True
        Me.cmbresponsable1.Location = New System.Drawing.Point(176, 51)
        Me.cmbresponsable1.Name = "cmbresponsable1"
        Me.cmbresponsable1.Size = New System.Drawing.Size(348, 24)
        Me.cmbresponsable1.TabIndex = 12
        '
        'cmbdirectivo1
        '
        Me.cmbdirectivo1.FormattingEnabled = True
        Me.cmbdirectivo1.Location = New System.Drawing.Point(176, 21)
        Me.cmbdirectivo1.Name = "cmbdirectivo1"
        Me.cmbdirectivo1.Size = New System.Drawing.Size(348, 24)
        Me.cmbdirectivo1.TabIndex = 11
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(176, 81)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(348, 22)
        Me.dt1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Responsable del Area:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Directivo de la Escuela:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(566, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 391)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Directivos Actuales"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtfecha3)
        Me.GroupBox5.Controls.Add(Me.txtresponsable3)
        Me.GroupBox5.Controls.Add(Me.txtdirectivo3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 262)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(530, 110)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Recuadro Regularización"
        '
        'txtfecha3
        '
        Me.txtfecha3.Enabled = False
        Me.txtfecha3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha3.Location = New System.Drawing.Point(176, 77)
        Me.txtfecha3.Name = "txtfecha3"
        Me.txtfecha3.Size = New System.Drawing.Size(338, 24)
        Me.txtfecha3.TabIndex = 15
        '
        'txtresponsable3
        '
        Me.txtresponsable3.Enabled = False
        Me.txtresponsable3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresponsable3.Location = New System.Drawing.Point(176, 50)
        Me.txtresponsable3.Name = "txtresponsable3"
        Me.txtresponsable3.Size = New System.Drawing.Size(338, 24)
        Me.txtresponsable3.TabIndex = 14
        '
        'txtdirectivo3
        '
        Me.txtdirectivo3.Enabled = False
        Me.txtdirectivo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirectivo3.Location = New System.Drawing.Point(176, 23)
        Me.txtdirectivo3.Name = "txtdirectivo3"
        Me.txtdirectivo3.Size = New System.Drawing.Size(338, 24)
        Me.txtdirectivo3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Responsable del Area:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Directivo de la Escuela:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtfecha2)
        Me.GroupBox4.Controls.Add(Me.txtresponsable2)
        Me.GroupBox4.Controls.Add(Me.txtdirectivo2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(530, 110)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recuadro Acreditación"
        '
        'txtfecha2
        '
        Me.txtfecha2.Enabled = False
        Me.txtfecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha2.Location = New System.Drawing.Point(176, 78)
        Me.txtfecha2.Name = "txtfecha2"
        Me.txtfecha2.Size = New System.Drawing.Size(338, 24)
        Me.txtfecha2.TabIndex = 15
        '
        'txtresponsable2
        '
        Me.txtresponsable2.Enabled = False
        Me.txtresponsable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresponsable2.Location = New System.Drawing.Point(176, 51)
        Me.txtresponsable2.Name = "txtresponsable2"
        Me.txtresponsable2.Size = New System.Drawing.Size(338, 24)
        Me.txtresponsable2.TabIndex = 14
        '
        'txtdirectivo2
        '
        Me.txtdirectivo2.Enabled = False
        Me.txtdirectivo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirectivo2.Location = New System.Drawing.Point(176, 24)
        Me.txtdirectivo2.Name = "txtdirectivo2"
        Me.txtdirectivo2.Size = New System.Drawing.Size(338, 24)
        Me.txtdirectivo2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Responsable del Area:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Directivo de la Escuela:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtfecha1)
        Me.GroupBox3.Controls.Add(Me.txtresponsable1)
        Me.GroupBox3.Controls.Add(Me.txtdirectivo1)
        Me.GroupBox3.Controls.Add(Me.lblFecha1)
        Me.GroupBox3.Controls.Add(Me.lblresponsable1)
        Me.GroupBox3.Controls.Add(Me.lbldirectivo1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(530, 110)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recuadro Inscripción"
        '
        'txtfecha1
        '
        Me.txtfecha1.Enabled = False
        Me.txtfecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha1.Location = New System.Drawing.Point(176, 79)
        Me.txtfecha1.Name = "txtfecha1"
        Me.txtfecha1.Size = New System.Drawing.Size(338, 24)
        Me.txtfecha1.TabIndex = 12
        '
        'txtresponsable1
        '
        Me.txtresponsable1.Enabled = False
        Me.txtresponsable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresponsable1.Location = New System.Drawing.Point(176, 52)
        Me.txtresponsable1.Name = "txtresponsable1"
        Me.txtresponsable1.Size = New System.Drawing.Size(338, 24)
        Me.txtresponsable1.TabIndex = 11
        '
        'txtdirectivo1
        '
        Me.txtdirectivo1.Enabled = False
        Me.txtdirectivo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirectivo1.Location = New System.Drawing.Point(176, 25)
        Me.txtdirectivo1.Name = "txtdirectivo1"
        Me.txtdirectivo1.Size = New System.Drawing.Size(338, 24)
        Me.txtdirectivo1.TabIndex = 10
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.Location = New System.Drawing.Point(18, 82)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(51, 17)
        Me.lblFecha1.TabIndex = 9
        Me.lblFecha1.Text = "Fecha:"
        '
        'lblresponsable1
        '
        Me.lblresponsable1.AutoSize = True
        Me.lblresponsable1.Location = New System.Drawing.Point(18, 55)
        Me.lblresponsable1.Name = "lblresponsable1"
        Me.lblresponsable1.Size = New System.Drawing.Size(152, 17)
        Me.lblresponsable1.TabIndex = 8
        Me.lblresponsable1.Text = "Responsable del Area:"
        '
        'lbldirectivo1
        '
        Me.lbldirectivo1.AutoSize = True
        Me.lbldirectivo1.Location = New System.Drawing.Point(18, 27)
        Me.lbldirectivo1.Name = "lbldirectivo1"
        Me.lbldirectivo1.Size = New System.Drawing.Size(156, 17)
        Me.lbldirectivo1.TabIndex = 7
        Me.lbldirectivo1.Text = "Directivo de la Escuela:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(215, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(681, 29)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "CONFIGURACIÓN FIRMA DE REGISTRO ESCOLARIDAD"
        '
        'FrmConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 508)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfiguration"
        Me.Text = "Configuración de Directivos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfecha3 As System.Windows.Forms.TextBox
    Friend WithEvents txtresponsable3 As System.Windows.Forms.TextBox
    Friend WithEvents txtdirectivo3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfecha2 As System.Windows.Forms.TextBox
    Friend WithEvents txtresponsable2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdirectivo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfecha1 As System.Windows.Forms.TextBox
    Friend WithEvents txtresponsable1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdirectivo1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents lblresponsable1 As System.Windows.Forms.Label
    Friend WithEvents lbldirectivo1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbresponsable1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdirectivo1 As System.Windows.Forms.ComboBox
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbresponsable3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdirectivo3 As System.Windows.Forms.ComboBox
    Friend WithEvents Dt3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbresponsable2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdirectivo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
