Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Imports System.Configuration
Imports System.Text.RegularExpressions
Imports Registro_de_Escolaridad.Datos

Namespace Datos

    Public Class ParValor
        Public Valor As Object
        Public Descripcion As String

        Public Sub New(ByVal valor As Object, ByVal descripcion As String)
            Me.Valor = valor
            Me.Descripcion = descripcion
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Descripcion
        End Function

        'Dim a As Integer
        'a = CType(cmbDocumentos.SelectedItem, ParValor).Valor
        'MsgBox(a.ToString)

    End Class

    Public Class BaseDatos

        Private CadenaConexion_ As String '= "Data Source=(local); Initial Catalog=isenco; User ID=sa; password=123456"
        Public Conexion As SqlConnection
        Public Comando As SqlCommand
        Public DataReader As SqlDataReader
        Public DataAdapter As SqlDataAdapter
        Public DataSet_ As DataSet
        Public DataRow_ As DataRow

        Public Sub New()

        End Sub

        Public Property CadenaConexion As String

            Get
                Dim Conf As New Configuracion
                Dim Ignition As String = Conf.getIgnition()

                CadenaConexion_ = "Data Source=" + Ignition.Split("|")(0) + "; " +
                                    "Initial Catalog=" + Ignition.Split("|")(1) + "; " +
                                    "User ID=" + Ignition.Split("|")(2) + "; " +
                                    "Password=" + Ignition.Split("|")(3)

                Return CadenaConexion_
            End Get

            Set(ByVal value As String)
                If value <> vbNull Then
                    If value.ToString.Trim.Length > 0 Then
                        CadenaConexion_ = value
                    End If
                End If
            End Set

        End Property

        Public Sub abrirConexion()
            Try
                Conexion = New SqlConnection
                Conexion.ConnectionString = Me.CadenaConexion
                Conexion.Open()
            Catch e As Exception
                MessageBox.Show("No se ha podido iniciar el servicio de base de datos.", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Function probarConexion() As Boolean
            If IsNothing(Conexion) Or Conexion.State <> ConnectionState.Open Then
                Return False
            End If
            Return True
        End Function

        Public Sub cerrarConexion()
            Try
                If Conexion.State <> ConnectionState.Closed Then
                    Conexion.Close()
                    Conexion = Nothing
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Function desbloquearTablas(ByVal Sentencia As String) As String
            Dim S As String
            S = Sentencia.ToLower
            If S.IndexOf(" from ") = -1 Then
                Return Sentencia
            Else
                Dim vAux As String, vRelacionales(32) As String, I As Long, vPos As Long
                ReDim Preserve vRelacionales(0) : vRelacionales(0) = " WHERE "
                ReDim Preserve vRelacionales(1) : vRelacionales(1) = " Where "
                ReDim Preserve vRelacionales(2) : vRelacionales(2) = " where "
                ReDim Preserve vRelacionales(3) : vRelacionales(3) = " GROUP "
                ReDim Preserve vRelacionales(4) : vRelacionales(4) = " Group "
                ReDim Preserve vRelacionales(5) : vRelacionales(5) = " group "
                ReDim Preserve vRelacionales(6) : vRelacionales(6) = " ORDER "
                ReDim Preserve vRelacionales(7) : vRelacionales(7) = " Order "
                ReDim Preserve vRelacionales(8) : vRelacionales(8) = " order "
                ReDim Preserve vRelacionales(9) : vRelacionales(9) = " HAVING "
                ReDim Preserve vRelacionales(10) : vRelacionales(10) = " Having "
                ReDim Preserve vRelacionales(11) : vRelacionales(11) = " having "
                ReDim Preserve vRelacionales(12) : vRelacionales(12) = " LEFT "
                ReDim Preserve vRelacionales(13) : vRelacionales(13) = " Left "
                ReDim Preserve vRelacionales(14) : vRelacionales(14) = " left "
                ReDim Preserve vRelacionales(15) : vRelacionales(15) = " OUTER "
                ReDim Preserve vRelacionales(16) : vRelacionales(16) = " Outer "
                ReDim Preserve vRelacionales(17) : vRelacionales(17) = " outer "
                ReDim Preserve vRelacionales(18) : vRelacionales(18) = " FULL "
                ReDim Preserve vRelacionales(19) : vRelacionales(19) = " Full "
                ReDim Preserve vRelacionales(20) : vRelacionales(20) = " full "
                ReDim Preserve vRelacionales(21) : vRelacionales(21) = " RIGHT "
                ReDim Preserve vRelacionales(22) : vRelacionales(22) = " Right "
                ReDim Preserve vRelacionales(23) : vRelacionales(23) = " right "
                ReDim Preserve vRelacionales(24) : vRelacionales(24) = " JOIN "
                ReDim Preserve vRelacionales(25) : vRelacionales(25) = " Join "
                ReDim Preserve vRelacionales(26) : vRelacionales(26) = " join "
                ReDim Preserve vRelacionales(27) : vRelacionales(27) = " CROSS "
                ReDim Preserve vRelacionales(28) : vRelacionales(28) = " cross "
                ReDim Preserve vRelacionales(29) : vRelacionales(29) = " Cross "
                ReDim Preserve vRelacionales(30) : vRelacionales(30) = " INNER "
                ReDim Preserve vRelacionales(31) : vRelacionales(31) = " inner "
                ReDim Preserve vRelacionales(32) : vRelacionales(32) = " Inner "
                Sentencia = Sentencia.Replace(" ON ", " (NOLOCK) ON ") ' Pone el NoLock antes de cada ON
                Sentencia = Sentencia.Replace(" On ", " (NOLOCK) On ") ' Pone el NoLock antes de cada ON
                Sentencia = Sentencia.Replace(" on ", " (NOLOCK) on ") ' Pone el NoLock antes de cada ON
                vPos = Sentencia.IndexOf(vRelacionales(0))
                If vPos > 0 Then
                    vAux = Sentencia.Substring(0, vPos)
                Else
                    vAux = Sentencia
                End If
                For I = 1 To vRelacionales.Length - 1
                    vPos = vAux.IndexOf(vRelacionales(I))
                    If vPos > 0 Then vAux = vAux.Substring(0, vPos) & " "
                Next
                Return Sentencia.Replace(vAux.Trim, vAux.Trim & " (NOLOCK) ")
            End If
        End Function

        Public Function getDataSet(ByVal SentenciaSQL As String) As DataSet

            Dim AdaptadorSQL As SqlDataAdapter
            Dim DataSetTmp As DataSet

            Try

                If probarConexion() = False Then
                    Return Nothing
                End If

                SentenciaSQL = SentenciaSQL.ToUpper()

                AdaptadorSQL = New SqlDataAdapter(SentenciaSQL, Conexion)

                If Not IsNothing(DataReader) Then
                    DataReader.Close()
                End If

                DataSetTmp = New DataSet()
                AdaptadorSQL.Fill(DataSetTmp)

                Return DataSetTmp

            Catch ex As Exception

                Throw ex

            End Try

        End Function

        Public Function ejecutarComando(ByVal SentenciaSQL As String) As Object

            If probarConexion() = False Then abrirConexion()

            If Not IsNothing(DataReader) Then DataReader.Close()

            SentenciaSQL = SentenciaSQL.ToUpper

            Try
                Comando = New SqlCommand(SentenciaSQL, Conexion)
                Comando.ExecuteNonQuery()
                Return getValor("SET NOCOUNT OFF SELECT SCOPE_IDENTITY() AS 'ULTIMO_ID'")
            Catch ex As Exception
                Return 0
            End Try


        End Function

        Public Function getValor(ByVal SentenciaSQL As String, Optional ByVal CualCampo As Integer = 0) As Object

            Dim Objeto As Object = ""

            If probarConexion() = False Then abrirConexion()

            Comando = New SqlCommand(SentenciaSQL.ToUpper, Conexion)

            Try
                If Not IsNothing(DataReader) Then DataReader.Close()
                DataReader = Comando.ExecuteReader()
                If DataReader.Read() Then Objeto = FVobValor(DataReader, CualCampo)
                DataReader.Close()
                Return Objeto
            Catch ex As Exception
                Throw New System.Exception(ex.Message.ToString)
            End Try
        End Function

        Public Sub loadDataReader(ByVal SentenciaSQL As String, ByRef Reader As SqlDataReader) 'By MIKE
            Try
                If probarConexion() = False Then abrirConexion()
                Dim VPobodcmComando As New SqlCommand(SentenciaSQL.ToUpper, Conexion)
                Reader = VPobodcmComando.ExecuteReader()
            Catch ex As Exception
                Throw New System.Exception("Error DataReader: " & ex.ToString)
            End Try
        End Sub

        Public Function FVobValor(ByVal VLstTipoCampo As String, ByVal VLobValor As Object) As Object
            Select Case LCase(VLstTipoCampo)
                Case "char", "varchar2", "varchar"
                    If IsDBNull(VLobValor) Then
                        Return ""
                    Else
                        Return CStr(VLobValor)
                    End If
                Case "date", "datetime"
                    If IsDBNull(VLobValor) Then
                        Return CDate("1/1/1900")
                    Else
                        Return CDate(VLobValor)
                    End If
                Case "decimal"
                    If IsDBNull(VLobValor) Then
                        Return 0
                    Else
                        Return CDbl(VLobValor)
                    End If
                Case "int16", "int32", "number", "int", "smallint", "tinyint"
                    If IsDBNull(VLobValor) Then
                        Return 0
                    Else
                        Return CInt(VLobValor)
                    End If
                Case "single", "double", "float", "money"
                    If IsDBNull(VLobValor) Then
                        Return 0
                    Else
                        Return CSng(VLobValor)
                    End If
                Case "int64", "bigint"
                    If IsDBNull(VLobValor) Then
                        Return 0
                    Else
                        Return CLng(VLobValor)
                    End If
                Case "bit"
                    If IsDBNull(VLobValor) Then
                        Return 0
                    Else
                        Return IIf(VLobValor = 0, 0, 1)
                    End If
            End Select
            Return ""
        End Function

        Public Function FVobValor(ByRef VLobodtrDataReader As SqlDataReader, ByVal VLstCampo As String) As Object
            Dim i As Long
            i = 0
            While i < VLobodtrDataReader.FieldCount
                If LCase(VLobodtrDataReader.GetName(i)) = LCase(VLstCampo) Then Exit While
                i = i + 1
            End While
            Try
                'If i < dr.FieldCount Then
                Return FVobValor(VLobodtrDataReader.GetDataTypeName(i), VLobodtrDataReader.GetValue(i))
            Catch
                Throw New System.Exception("Nombre de campo no existente: " & VLstCampo & ". Favor de revisar.")
            End Try
        End Function

        Public Function FVobValor(ByRef VLobodtrDataReader As SqlDataReader, ByVal VLinNumero As Integer) As Object
            Return FVobValor(VLobodtrDataReader.GetDataTypeName(VLinNumero), VLobodtrDataReader.GetValue(VLinNumero))
        End Function

        Public Function SafeSqlLiteral(ByVal strValue, Optional ByVal intLevel = 1) As String

            '*** Written by user CWA, CoolWebAwards.com Forums. 2 February 2010
            '*** http://forum.coolwebawards.com/threads/11-Preventing-SQL-injection-attacks-using-VB-NET

            ' intLevel represent how thorough the value will be checked for dangerous code
            ' intLevel (1) - Do just the basic. This level will already counter most of the SQL injection attacks
            ' intLevel (2) - &nbsp; (non breaking space) will be added to most words used in SQL queries to prevent unauthorized access to the database. Safe to be printed back into HTML code. Don't use for usernames or passwords

            If Not IsDBNull(strValue) Then
                If intLevel > 0 Then
                    strValue = Replace(strValue, "'", "''") ' Most important one! This line alone can prevent most injection attacks
                    strValue = Replace(strValue, "--", "")
                    strValue = Replace(strValue, "[", "[[]")
                    strValue = Replace(strValue, "%", "[%]")
                End If

                If intLevel > 1 Then
                    Dim myArray As Array
                    myArray = Split("xp_ ;update ;insert ;select ;drop ;alter ;create ;rename ;delete ;replace ", ";")
                    Dim i, i2, intLenghtLeft As Integer
                    For i = LBound(myArray) To UBound(myArray)
                        Dim rx As New Regex(myArray(i), RegexOptions.Compiled Or RegexOptions.IgnoreCase)
                        Dim matches As MatchCollection = rx.Matches(strValue)
                        i2 = 0
                        For Each match As Match In matches
                            Dim groups As GroupCollection = match.Groups
                            intLenghtLeft = groups.Item(0).Index + Len(myArray(i)) + i2
                            strValue = Left(strValue, intLenghtLeft - 1) & "&nbsp;" & Right(strValue, Len(strValue) - intLenghtLeft)
                            i2 += 5
                        Next
                    Next
                End If

                'strValue = replace(strValue, ";", ";&nbsp;")
                'strValue = replace(strValue, "_", "[_]")

                Return strValue
            Else
                Return strValue
            End If

        End Function

    End Class

End Namespace