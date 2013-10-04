<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpresion
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Lista_AsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listaAsistenciaDT = New Lista_de_asistencia.listaAsistenciaDT()
        Me.LISTA2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Lista_AsistenciaTableAdapter1 = New Lista_de_asistencia.listaAsistenciaDTTableAdapters.Lista_AsistenciaTableAdapter()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LISTA2TableAdapter = New Lista_de_asistencia.listaAsistenciaDTTableAdapters.LISTA2TableAdapter()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Lista_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaAsistenciaDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTA2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lista_AsistenciaBindingSource
        '
        Me.Lista_AsistenciaBindingSource.DataMember = "Lista_Asistencia"
        Me.Lista_AsistenciaBindingSource.DataSource = Me.listaAsistenciaDT
        '
        'listaAsistenciaDT
        '
        Me.listaAsistenciaDT.DataSetName = "listaAsistenciaDT"
        Me.listaAsistenciaDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LISTA2BindingSource
        '
        Me.LISTA2BindingSource.DataMember = "LISTA2"
        Me.LISTA2BindingSource.DataSource = Me.listaAsistenciaDT
        '
        'BtnExportar
        '
        Me.BtnExportar.Location = New System.Drawing.Point(9, 2)
        Me.BtnExportar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(194, 32)
        Me.BtnExportar.TabIndex = 1
        Me.BtnExportar.Text = "Generar Archivo para Imprimir"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "listaAsistenciaDT"
        ReportDataSource1.Value = Me.Lista_AsistenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Lista_de_asistencia.Lista_de_Asistencia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(14, 106)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowPrintButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1025, 573)
        Me.ReportViewer1.TabIndex = 2
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "listaAsistenciaDT"
        ReportDataSource2.Value = Me.Lista_AsistenciaBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Lista_de_asistencia.Lista_de_Asistencia2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(15, 116)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ShowPrintButton = False
        Me.ReportViewer2.Size = New System.Drawing.Size(1024, 573)
        Me.ReportViewer2.TabIndex = 3
        '
        'Lista_AsistenciaTableAdapter1
        '
        Me.Lista_AsistenciaTableAdapter1.ClearBeforeFill = True
        '
        'ReportViewer3
        '
        ReportDataSource3.Name = "listaAsistenciaDT"
        ReportDataSource3.Value = Me.LISTA2BindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "Lista_de_asistencia.Lista_de_AsistenciaSD.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(15, 29)
        Me.ReportViewer3.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ShowPrintButton = False
        Me.ReportViewer3.Size = New System.Drawing.Size(1024, 573)
        Me.ReportViewer3.TabIndex = 4
        '
        'LISTA2TableAdapter
        '
        Me.LISTA2TableAdapter.ClearBeforeFill = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer4.AutoSize = True
        ReportDataSource4.Name = "listaAsistenciaDT"
        ReportDataSource4.Value = Me.LISTA2BindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "Lista_de_asistencia.Lista_de_AsistenciaSD2.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(6, 29)
        Me.ReportViewer4.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.ShowPrintButton = False
        Me.ReportViewer4.Size = New System.Drawing.Size(1033, 573)
        Me.ReportViewer4.TabIndex = 5
        '
        'FrmImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 622)
        Me.Controls.Add(Me.ReportViewer4)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.BtnExportar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImpresion"
        CType(Me.Lista_AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaAsistenciaDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTA2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents Lista_asistenciaTableAdapter As Lista_de_asistencia.listaAsistenciaDTTableAdapters.Lista_AsistenciaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Lista_AsistenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents listaAsistenciaDT As Lista_de_asistencia.listaAsistenciaDT
    Friend WithEvents Lista_AsistenciaTableAdapter1 As Lista_de_asistencia.listaAsistenciaDTTableAdapters.Lista_AsistenciaTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LISTA2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LISTA2TableAdapter As Lista_de_asistencia.listaAsistenciaDTTableAdapters.LISTA2TableAdapter
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer

    '    Friend WithEvents Lista_asistenciaTableAdapter As Lista_de_asistencia.DataSet1TableAdapters.LISTA_ASISTENCIATableAdapter
End Class
