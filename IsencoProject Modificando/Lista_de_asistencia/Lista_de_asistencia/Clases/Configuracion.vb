Imports System.IO
Imports System.Text.RegularExpressions

Public Class Configuracion

    Public Property TituloModulo As String = "Instituto Superior de Educación Normal de Colima ""Profr. Gregorio Torres Quintero"" - Control Escolar ::.. Alumnos(as)"
    Public Property FotoVacia As String = System.AppDomain.CurrentDomain.BaseDirectory + "fa\nf.jpg"

    'Public Sub mostrarChildForm(ByRef FormularioChild As Form, ByRef FormularioParent As Form)
    '    FormularioChild.MdiParent = MDIParent
    '    FormularioChild.AutoScroll = True
    '    FormularioChild.Show()
    'End Sub

    Public Function getIgnition() As String

        Dim Archivo As String = System.AppDomain.CurrentDomain.BaseDirectory + "ignition.dat"
        Dim Texto As String = ""

        If System.IO.File.Exists(Archivo) = True Then

            Dim objReader As New System.IO.StreamReader(Archivo)

            Do While objReader.Peek() <> -1
                Texto = Texto & objReader.ReadLine() & vbNewLine
            Loop

            objReader.Close()
            objReader = Nothing

        End If

        Return Texto

    End Function

    Public Function getIgnition2() As String

        Dim Archivo As String = System.AppDomain.CurrentDomain.BaseDirectory + "ignition2.dat"
        Dim Texto As String = ""

        If System.IO.File.Exists(Archivo) = True Then

            Dim objReader As New System.IO.StreamReader(Archivo)

            Do While objReader.Peek() <> -1
                Texto = Texto & objReader.ReadLine()
            Loop

            objReader.Close()
            objReader = Nothing

        End If

        Return Trim(Texto)

    End Function

    Public Function getCamposRegreso(ByVal CamposRegreso As String) As List(Of Object)

        Dim matches
        Dim patron As String = "\[\[([^]]*)\]\]"
        Dim lista As New List(Of Object)

        CamposRegreso = CamposRegreso.Replace(Environment.NewLine, "")
        matches = Regex.Matches(CamposRegreso, patron)

        For Each m As Match In matches
            lista.Add(m.Groups(1))
        Next

        Return lista

    End Function

End Class