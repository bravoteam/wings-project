<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuAlumnos))
        Me.optionCalificaciones = New System.Windows.Forms.PictureBox()
        CType(Me.optionCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optionCalificaciones
        '
        Me.optionCalificaciones.BackColor = System.Drawing.Color.Transparent
        Me.optionCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optionCalificaciones.Location = New System.Drawing.Point(41, 25)
        Me.optionCalificaciones.Name = "optionCalificaciones"
        Me.optionCalificaciones.Size = New System.Drawing.Size(204, 62)
        Me.optionCalificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.optionCalificaciones.TabIndex = 61
        Me.optionCalificaciones.TabStop = False
        '
        'menuAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1364, 776)
        Me.Controls.Add(Me.optionCalificaciones)
        Me.Name = "menuAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal de Alumnos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.optionCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents optionCalificaciones As System.Windows.Forms.PictureBox
End Class
