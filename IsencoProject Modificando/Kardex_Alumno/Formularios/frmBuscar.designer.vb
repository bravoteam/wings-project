<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarAlumbo
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalirCmd = New System.Windows.Forms.Button()
        Me.GenerarCmd = New System.Windows.Forms.Button()
        Me.filtrarCmd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UDPeriodo = New System.Windows.Forms.NumericUpDown()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UDPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(79, 7)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(542, 22)
        Me.txtBuscar.TabIndex = 0
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
        Me.Grid.Location = New System.Drawing.Point(12, 39)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.Size = New System.Drawing.Size(608, 221)
        Me.Grid.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'SalirCmd
        '
        Me.SalirCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirCmd.Image = Global.Kardex_Alumno.My.Resources.Resources.salir2
        Me.SalirCmd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SalirCmd.Location = New System.Drawing.Point(629, 77)
        Me.SalirCmd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SalirCmd.Name = "SalirCmd"
        Me.SalirCmd.Size = New System.Drawing.Size(97, 28)
        Me.SalirCmd.TabIndex = 24
        Me.SalirCmd.Text = "SALIR"
        Me.SalirCmd.UseVisualStyleBackColor = True
        '
        'GenerarCmd
        '
        Me.GenerarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarCmd.Image = Global.Kardex_Alumno.My.Resources.Resources._001_35
        Me.GenerarCmd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.GenerarCmd.Location = New System.Drawing.Point(628, 41)
        Me.GenerarCmd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GenerarCmd.Name = "GenerarCmd"
        Me.GenerarCmd.Size = New System.Drawing.Size(98, 28)
        Me.GenerarCmd.TabIndex = 23
        Me.GenerarCmd.Text = "KARDEX"
        Me.GenerarCmd.UseVisualStyleBackColor = True
        '
        'filtrarCmd
        '
        Me.filtrarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtrarCmd.Image = Global.Kardex_Alumno.My.Resources.Resources._001_37
        Me.filtrarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.filtrarCmd.Location = New System.Drawing.Point(629, 6)
        Me.filtrarCmd.Name = "filtrarCmd"
        Me.filtrarCmd.Size = New System.Drawing.Size(97, 26)
        Me.filtrarCmd.TabIndex = 22
        Me.filtrarCmd.Text = "Filtrar"
        Me.filtrarCmd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UDPeriodo)
        Me.GroupBox1.Location = New System.Drawing.Point(628, 113)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(98, 82)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plan de Estudios"
        '
        'UDPeriodo
        '
        Me.UDPeriodo.Location = New System.Drawing.Point(10, 32)
        Me.UDPeriodo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UDPeriodo.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.UDPeriodo.Minimum = New Decimal(New Integer() {1997, 0, 0, 0})
        Me.UDPeriodo.Name = "UDPeriodo"
        Me.UDPeriodo.Size = New System.Drawing.Size(76, 20)
        Me.UDPeriodo.TabIndex = 0
        Me.UDPeriodo.Value = New Decimal(New Integer() {1997, 0, 0, 0})
        '
        'frmBuscarAlumbo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(733, 271)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SalirCmd)
        Me.Controls.Add(Me.GenerarCmd)
        Me.Controls.Add(Me.filtrarCmd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.txtBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBuscarAlumbo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARDEX ALUMNO"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.UDPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents filtrarCmd As System.Windows.Forms.Button
    Friend WithEvents GenerarCmd As System.Windows.Forms.Button
    Friend WithEvents SalirCmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UDPeriodo As System.Windows.Forms.NumericUpDown
End Class
