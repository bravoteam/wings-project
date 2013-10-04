Public Class funciones
    Public Shared Sub limpiar_campos(ByVal grupo As GroupBox)
        Dim ctl As Control

        For Each ctl In grupo.Controls
            If (TypeOf ctl Is System.Windows.Forms.TextBox) Or (TypeOf ctl Is System.Windows.Forms.ComboBox) Then
                ctl.Text = ""
            End If
        Next ctl
    End Sub
End Class
