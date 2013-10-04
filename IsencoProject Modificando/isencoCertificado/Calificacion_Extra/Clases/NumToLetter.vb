<Serializable()> _
Public Class NumToLetter

#Region "Private fields"

	Private _astrConversor(2, 10) As String
	Private _mvarNumber As Object
	Private _mstrCurrency As String

#End Region

#Region "Public properties"

	''' <summary>
	''' Number property
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Number() As Object
		Get
			Return Me._mvarNumber
		End Get
		Set(ByVal value As Object)
			If IsNumeric(value) Then
				Me._mvarNumber = value
			End If
		End Set
	End Property

	''' <summary>
	''' Currency type property
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Currency() As String
		Get
			Return Me._mstrCurrency
		End Get
		Set(ByVal value As String)
			Me._mstrCurrency = value
		End Set
	End Property

#End Region

#Region "Constructor"

	''' <summary>
	''' Default Constructor
	''' </summary>
	''' <remarks></remarks>
	Public Sub New()
		Me.Initialize()
		Me._mstrCurrency = "pesos"
	End Sub

#End Region

#Region "Methods"

	''' <summary>
	''' Initialize variables
	''' </summary>
	''' <remarks></remarks>
	Private Sub Initialize()
		Me._astrConversor(0, 1) = "Ciento"
		Me._astrConversor(0, 2) = "Doscientos"
		Me._astrConversor(0, 3) = "Trescientos"
		Me._astrConversor(0, 4) = "Cuatrocientos"
		Me._astrConversor(0, 5) = "Quinientos"
		Me._astrConversor(0, 6) = "Seiscientos"
		Me._astrConversor(0, 7) = "Setecientos"
		Me._astrConversor(0, 8) = "Ochocientos"
		Me._astrConversor(0, 9) = "Novecientos"
        Me._astrConversor(1, 1) = "Uno"
		Me._astrConversor(1, 2) = "Dos"
		Me._astrConversor(1, 3) = "Tres"
		Me._astrConversor(1, 4) = "Cuatro"
		Me._astrConversor(1, 5) = "Cinco"
		Me._astrConversor(1, 6) = "Seis"
		Me._astrConversor(1, 7) = "Siete"
		Me._astrConversor(1, 8) = "Ocho"
		Me._astrConversor(1, 9) = "Nueve"
		Me._astrConversor(2, 1) = "Diez"
		Me._astrConversor(2, 2) = "Veinte"
		Me._astrConversor(2, 3) = "Treinta"
		Me._astrConversor(2, 4) = "Cuarenta"
		Me._astrConversor(2, 5) = "Cincuenta"
		Me._astrConversor(2, 6) = "Sesenta"
		Me._astrConversor(2, 7) = "Setenta"
		Me._astrConversor(2, 8) = "Ochenta"
		Me._astrConversor(2, 9) = "Noventa"
	End Sub

	''' <summary>
	''' Convert number to letter
	''' </summary>
	''' <returns>A string with the value text</returns>
	''' <remarks></remarks>
	Public Function ToLetter() As String
		Dim i As Integer
		Dim intProceed As Boolean
		Dim intPosNumber As Integer
		Dim intLongNumero As Integer
		Dim strNumber As String
		Dim strNumberLetter As String = ""

		' Set initial values
		Me._mvarNumber = Math.Abs(Convert.ToDecimal(Me._mvarNumber))
		strNumber = CStr(Fix(Me._mvarNumber))
		intLongNumero = Len(strNumber)
		intPosNumber = intLongNumero

		' Loop trough number
		For i = 1 To intLongNumero
			intProceed = True
			If (intPosNumber Mod 3) = 1 Then
				If intLongNumero > intPosNumber Then
					Select Case Mid(strNumber, i - 1, 2)
						Case "00"
							If UCase(Right(strNumberLetter, 7)) = "CIENTO " Then
								strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 7)
								strNumberLetter = strNumberLetter & "Cien "
							End If
						Case "11"
							strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 5)
							strNumberLetter = strNumberLetter & "Once "
							intProceed = False
						Case "12"
							strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 5)
							strNumberLetter = strNumberLetter & "Doce "
							intProceed = False
						Case "13"
							strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 5)
							strNumberLetter = strNumberLetter & "Trece "
							intProceed = False
						Case "14"
							strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 5)
							strNumberLetter = strNumberLetter & "Catorce "
							intProceed = False
						Case "15"
							strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 5)
							strNumberLetter = strNumberLetter & "Quince "
							intProceed = False
						Case "16", "17", "18", "19"
							strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 2)
							strNumberLetter = strNumberLetter & "ci"
						Case "21" To "29"
							strNumberLetter = Left(strNumberLetter, Len(strNumberLetter) - 2)
							strNumberLetter = strNumberLetter & "i"
						Case Else
							If Val(Mid(strNumber, i, 1)) > 0 And Val(Mid(strNumber, i - 1, 1)) > 0 Then
								strNumberLetter = strNumberLetter & "y "
							End If
					End Select
				End If
			End If

			If Val(Mid(strNumber, i, 1)) > 0 And intProceed Then
				strNumberLetter = strNumberLetter & Me._astrConversor((intPosNumber Mod 3), Convert.ToInt32(Mid(strNumber, i, 1))) & " "
			End If

            intPosNumber = intPosNumber - 1
		Next i


		Return strNumberLetter
	End Function

#End Region

End Class