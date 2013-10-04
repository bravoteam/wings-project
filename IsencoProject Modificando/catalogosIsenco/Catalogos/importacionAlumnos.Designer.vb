<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class importacionAlumnos
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
        Me.cargarCmd = New System.Windows.Forms.Button()
        Me.consultarcmd = New System.Windows.Forms.Button()
        Me.TextPathExcel = New System.Windows.Forms.TextBox()
        Me.txtHoja = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dglabelCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.importarCmd = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Grid.Location = New System.Drawing.Point(12, 79)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1105, 495)
        Me.Grid.TabIndex = 33
        '
        'cargarCmd
        '
        Me.cargarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Spelling_
        Me.cargarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cargarCmd.Location = New System.Drawing.Point(220, 46)
        Me.cargarCmd.Name = "cargarCmd"
        Me.cargarCmd.Size = New System.Drawing.Size(159, 32)
        Me.cargarCmd.TabIndex = 32
        Me.cargarCmd.Text = "Cargar Datos"
        Me.cargarCmd.UseVisualStyleBackColor = True
        '
        'consultarcmd
        '
        Me.consultarcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultarcmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Binoculars_next_
        Me.consultarcmd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.consultarcmd.Location = New System.Drawing.Point(12, 46)
        Me.consultarcmd.Name = "consultarcmd"
        Me.consultarcmd.Size = New System.Drawing.Size(159, 32)
        Me.consultarcmd.TabIndex = 31
        Me.consultarcmd.Text = "Explorar Archivo"
        Me.consultarcmd.UseVisualStyleBackColor = True
        '
        'TextPathExcel
        '
        Me.TextPathExcel.Location = New System.Drawing.Point(12, 25)
        Me.TextPathExcel.Name = "TextPathExcel"
        Me.TextPathExcel.Size = New System.Drawing.Size(367, 20)
        Me.TextPathExcel.TabIndex = 34
        '
        'txtHoja
        '
        Me.txtHoja.Location = New System.Drawing.Point(401, 25)
        Me.txtHoja.Name = "txtHoja"
        Me.txtHoja.Size = New System.Drawing.Size(105, 20)
        Me.txtHoja.TabIndex = 35
        Me.txtHoja.Text = "Hoja4"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dglabelCount
        '
        Me.dglabelCount.AutoSize = True
        Me.dglabelCount.Location = New System.Drawing.Point(171, 577)
        Me.dglabelCount.Name = "dglabelCount"
        Me.dglabelCount.Size = New System.Drawing.Size(0, 13)
        Me.dglabelCount.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Archivo a Importar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nombre de la Hoja:"
        '
        'importarCmd
        '
        Me.importarCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importarCmd.Image = Global.catalogosIsenco.My.Resources.Resources._16__Save_
        Me.importarCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.importarCmd.Location = New System.Drawing.Point(951, 46)
        Me.importarCmd.Name = "importarCmd"
        Me.importarCmd.Size = New System.Drawing.Size(159, 32)
        Me.importarCmd.TabIndex = 44
        Me.importarCmd.Text = "Importar Datos"
        Me.importarCmd.UseVisualStyleBackColor = True
        '
        'importacionAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 595)
        Me.Controls.Add(Me.importarCmd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dglabelCount)
        Me.Controls.Add(Me.txtHoja)
        Me.Controls.Add(Me.TextPathExcel)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.cargarCmd)
        Me.Controls.Add(Me.consultarcmd)
        Me.Name = "importacionAlumnos"
        Me.Text = "Importar Datos de Alumnos"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents cargarCmd As System.Windows.Forms.Button
    Friend WithEvents consultarcmd As System.Windows.Forms.Button
    Friend WithEvents TextPathExcel As System.Windows.Forms.TextBox
    Friend WithEvents txtHoja As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dglabelCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents importarCmd As System.Windows.Forms.Button
End Class
