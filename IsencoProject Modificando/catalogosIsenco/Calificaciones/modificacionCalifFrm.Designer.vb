<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificacionCalifFrm
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
        Me.GbxBusqueda = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdInicializar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.cmdBoleta = New System.Windows.Forms.Button()
        Me.cmdKardex = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.cmdLicenciatura = New System.Windows.Forms.ComboBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmatricula = New System.Windows.Forms.TextBox()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.OpcionesDeCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarCalificacionSeleccionadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarImpresionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoletaDeCalificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbxBusqueda.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxBusqueda
        '
        Me.GbxBusqueda.Controls.Add(Me.Panel1)
        Me.GbxBusqueda.Controls.Add(Me.lblnombre)
        Me.GbxBusqueda.Controls.Add(Me.Btnbuscar)
        Me.GbxBusqueda.Controls.Add(Me.Label1)
        Me.GbxBusqueda.Controls.Add(Me.txtmatricula)
        Me.GbxBusqueda.Location = New System.Drawing.Point(24, 44)
        Me.GbxBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.GbxBusqueda.Name = "GbxBusqueda"
        Me.GbxBusqueda.Padding = New System.Windows.Forms.Padding(4)
        Me.GbxBusqueda.Size = New System.Drawing.Size(1807, 94)
        Me.GbxBusqueda.TabIndex = 1
        Me.GbxBusqueda.TabStop = False
        Me.GbxBusqueda.Text = "BUSQUEDA"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdInicializar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmdEliminar)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.cmdBoleta)
        Me.Panel1.Controls.Add(Me.cmdKardex)
        Me.Panel1.Controls.Add(Me.Btnsalir)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnlimpiar)
        Me.Panel1.Controls.Add(Me.cmdLicenciatura)
        Me.Panel1.Location = New System.Drawing.Point(8, 47)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1597, 46)
        Me.Panel1.TabIndex = 26
        Me.Panel1.Visible = False
        '
        'cmdInicializar
        '
        Me.cmdInicializar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInicializar.Location = New System.Drawing.Point(872, 0)
        Me.cmdInicializar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdInicializar.Name = "cmdInicializar"
        Me.cmdInicializar.Size = New System.Drawing.Size(291, 34)
        Me.cmdInicializar.TabIndex = 26
        Me.cmdInicializar.Text = "Inicializar Busqueda"
        Me.cmdInicializar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "LICENCIATURA:"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Db_delete_
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(1276, 9)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(121, 22)
        Me.cmdEliminar.TabIndex = 44
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEliminar.UseVisualStyleBackColor = True
        Me.cmdEliminar.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(1276, 25)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(121, 22)
        Me.BtnGuardar.TabIndex = 20
        Me.BtnGuardar.Text = "Guardar Cambios"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'cmdBoleta
        '
        Me.cmdBoleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBoleta.Image = Global.catalogosIsenco.My.Resources.Resources._001_35
        Me.cmdBoleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBoleta.Location = New System.Drawing.Point(1393, 9)
        Me.cmdBoleta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBoleta.Name = "cmdBoleta"
        Me.cmdBoleta.Size = New System.Drawing.Size(93, 22)
        Me.cmdBoleta.TabIndex = 40
        Me.cmdBoleta.Text = "Imprimir Boleta"
        Me.cmdBoleta.UseVisualStyleBackColor = True
        Me.cmdBoleta.Visible = False
        '
        'cmdKardex
        '
        Me.cmdKardex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKardex.Image = Global.catalogosIsenco.My.Resources.Resources.print
        Me.cmdKardex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKardex.Location = New System.Drawing.Point(1480, 6)
        Me.cmdKardex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdKardex.Name = "cmdKardex"
        Me.cmdKardex.Size = New System.Drawing.Size(117, 25)
        Me.cmdKardex.TabIndex = 39
        Me.cmdKardex.Text = "Imprimir Kardex"
        Me.cmdKardex.UseVisualStyleBackColor = True
        Me.cmdKardex.Visible = False
        '
        'Btnsalir
        '
        Me.Btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.Image = Global.catalogosIsenco.My.Resources.Resources._16__Exit_
        Me.Btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsalir.Location = New System.Drawing.Point(1480, 25)
        Me.Btnsalir.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(120, 22)
        Me.Btnsalir.TabIndex = 36
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        Me.Btnsalir.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.catalogosIsenco.My.Resources.Resources._001_35
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(624, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 34)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Consultar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Clear_
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpiar.Location = New System.Drawing.Point(1393, 28)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(93, 18)
        Me.btnlimpiar.TabIndex = 37
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        Me.btnlimpiar.Visible = False
        '
        'cmdLicenciatura
        '
        Me.cmdLicenciatura.FormattingEnabled = True
        Me.cmdLicenciatura.Location = New System.Drawing.Point(116, 6)
        Me.cmdLicenciatura.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLicenciatura.Name = "cmdLicenciatura"
        Me.cmdLicenciatura.Size = New System.Drawing.Size(488, 24)
        Me.cmdLicenciatura.TabIndex = 23
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(628, 23)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(0, 20)
        Me.lblnombre.TabIndex = 4
        Me.lblnombre.Tag = ""
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.Btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbuscar.Location = New System.Drawing.Point(399, 9)
        Me.Btnbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(215, 34)
        Me.Btnbuscar.TabIndex = 1
        Me.Btnbuscar.Text = "Buscar X Nombre"
        Me.Btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MATRICULA:"
        '
        'txtmatricula
        '
        Me.txtmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatricula.Location = New System.Drawing.Point(124, 17)
        Me.txtmatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmatricula.Name = "txtmatricula"
        Me.txtmatricula.Size = New System.Drawing.Size(265, 24)
        Me.txtmatricula.TabIndex = 0
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.Grid)
        Me.GbxDatos.Location = New System.Drawing.Point(16, 144)
        Me.GbxDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.GbxDatos.Size = New System.Drawing.Size(1807, 750)
        Me.GbxDatos.TabIndex = 2
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "DATOS DE LAS CALIFICACIONES"
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
        Me.Grid.Location = New System.Drawing.Point(8, 23)
        Me.Grid.Margin = New System.Windows.Forms.Padding(4)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1776, 719)
        Me.Grid.TabIndex = 38
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(656, 33)
        Me.chkFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(209, 21)
        Me.chkFecha.TabIndex = 43
        Me.chkFecha.Text = "Cambiar Fecha para Boletas"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(876, 27)
        Me.dt1.Margin = New System.Windows.Forms.Padding(4)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(264, 22)
        Me.dt1.TabIndex = 41
        Me.dt1.Visible = False
        '
        'OpcionesDeCalificacionesToolStripMenuItem
        '
        Me.OpcionesDeCalificacionesToolStripMenuItem.Name = "OpcionesDeCalificacionesToolStripMenuItem"
        Me.OpcionesDeCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.OpcionesDeCalificacionesToolStripMenuItem.Text = "Opciones de Calificaciones"
        '
        'EliminarCalificacionSeleccionadaToolStripMenuItem
        '
        Me.EliminarCalificacionSeleccionadaToolStripMenuItem.Name = "EliminarCalificacionSeleccionadaToolStripMenuItem"
        Me.EliminarCalificacionSeleccionadaToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.EliminarCalificacionSeleccionadaToolStripMenuItem.Text = "Eliminar Calificacion Seleccionada"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'LimpiarGridToolStripMenuItem
        '
        Me.LimpiarGridToolStripMenuItem.Name = "LimpiarGridToolStripMenuItem"
        Me.LimpiarGridToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.LimpiarGridToolStripMenuItem.Text = "Limpiar Grid"
        '
        'GenerarImpresionesToolStripMenuItem
        '
        Me.GenerarImpresionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoletaDeCalificacionToolStripMenuItem, Me.KardexToolStripMenuItem})
        Me.GenerarImpresionesToolStripMenuItem.Name = "GenerarImpresionesToolStripMenuItem"
        Me.GenerarImpresionesToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.GenerarImpresionesToolStripMenuItem.Text = "Generar Impresiones"
        '
        'BoletaDeCalificacionToolStripMenuItem
        '
        Me.BoletaDeCalificacionToolStripMenuItem.Name = "BoletaDeCalificacionToolStripMenuItem"
        Me.BoletaDeCalificacionToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.BoletaDeCalificacionToolStripMenuItem.Text = "Boleta de Calificacion"
        '
        'KardexToolStripMenuItem
        '
        Me.KardexToolStripMenuItem.Name = "KardexToolStripMenuItem"
        Me.KardexToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.KardexToolStripMenuItem.Text = "Kardex"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem5, Me.ToolStripMenuItem8})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1816, 28)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(199, 24)
        Me.ToolStripMenuItem1.Text = "Opciones de Calificaciones"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(305, 24)
        Me.ToolStripMenuItem2.Text = "Eliminar Calificacion Seleccionada"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(305, 24)
        Me.ToolStripMenuItem3.Text = "Guardar Cambios"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(305, 24)
        Me.ToolStripMenuItem4.Text = "Limpiar Grid"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(157, 24)
        Me.ToolStripMenuItem5.Text = "Generar Impresiones"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(223, 24)
        Me.ToolStripMenuItem6.Text = "Boleta de Calificacion"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(223, 24)
        Me.ToolStripMenuItem7.Text = "Kardex"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(50, 24)
        Me.ToolStripMenuItem8.Text = "Salir"
        '
        'modificacionCalifFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1816, 902)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.GbxDatos)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.GbxBusqueda)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "modificacionCalifFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial y Modificacion de Calificaciones"
        Me.GbxBusqueda.ResumeLayout(False)
        Me.GbxBusqueda.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbxDatos.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbxBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmatricula As System.Windows.Forms.TextBox
    Friend WithEvents GbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents cmdLicenciatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdInicializar As System.Windows.Forms.Button
    Friend WithEvents cmdKardex As System.Windows.Forms.Button
    Friend WithEvents cmdBoleta As System.Windows.Forms.Button
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents OpcionesDeCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarCalificacionSeleccionadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarImpresionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoletaDeCalificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KardexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
End Class
