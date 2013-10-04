Imports System.Text.RegularExpressions
Imports Reportes_Isenco.Datos
Imports System.Data.SqlClient

Namespace Modelos

    Public Class AlumnosModel

        Public Structure MensajesAlumnoRegular
            Public ErrorCalificaciones As String
            Public ErrorActDepCult As String
            Public ErrorSevicios As String
            Public ErrorAdeudoLibros As String
            Public ErrorPago As String
        End Structure

        Public Function getCalificacionesAlumno(ByVal Matricula As String) As DataSet
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "SELECT " & _
                  "C.IDSEMESTRE AS 'SEMESTRE', " & _
                  "C.IDGRUPO AS 'GRUPO', " & _
                  "M.NOMBRE AS 'MATERIA', " & _
                  "ISNULL(C.CALIFICACION, '0') AS 'PRIMER PARCIAL', " & _
                  "ISNULL(C.CALIFICACION2, '0') AS 'SEGUNDA PARCIAL', " & _
                  "ISNULL(C.EXTRA1, '0') AS 'REGU 1', " & _
                  "ISNULL(C.EXTRA2, '0') AS 'REGU 2', " & _
                  "ISNULL(C.EXTRA3, '0') AS 'REGU 3', " & _
                  "ISNULL(C.EXTRA4, '0') AS 'REGU 4' " & _
                  "FROM CALIFICACIONES C " & _
                  "INNER JOIN MATERIAS M ON M.IDMATERIA = C.IDMATERIA " & _
                  "AND C.MATRICULA = '" & Matricula & "' " & _
                  "ORDER BY C.IDSEMESTRE, M.IDMATERIA;"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                Return ds
            End If

            Return ds
        End Function

        Public Function getPagoInscripcion(ByVal Matricula As String,
                                   ByVal Campus As String,
                                   ByVal Licenciatura As String,
                                   ByVal Especialidad As String, _
                                   ByVal Modalidad As String,
                                   ByVal Turno As String,
                                   ByVal Semestre As String,
                                   ByVal Grupo As String) As Boolean

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select top 1 matricula from alumno_pago where " & _
                "matricula = '" & Matricula & "' " & _
                "and campus = '" & Campus & "' " & _
                "and licenciatura = '" & Licenciatura & "' " & _
                "and especialidad = '" & Especialidad & "' " & _
                "and modalidad = '" & Modalidad & "' " & _
                "and turno = '" & Turno & "' " & _
                "and semestre = '" & Semestre & "' " & _
                "and grupo = '" & Grupo & "';"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count = 0 Then
                Return False
            End If

            Return True

        End Function
        Public Sub act_calificacion_grupo(ByVal Grupo As String,
                                          ByVal Matricula As String,
                                          ByVal Semestre As String)
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            sql = "update calificaciones set idgrupo = '" & Grupo & "' where matricula = '" & Matricula & "' and idsemestre = '" & Semestre & "'"
            b.abrirConexion()
            b.ejecutarComando(sql)
            b.cerrarConexion()
        End Sub
        Public Sub pagoInscripcion(ByVal Matricula As String,
                                   ByVal Campus As String,
                                   ByVal Licenciatura As String,
                                   ByVal Especialidad As String, _
                                   ByVal Modalidad As String,
                                   ByVal Turno As String,
                                   ByVal Semestre As String,
                                   ByVal Grupo As String)

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String

            sql = "select top 1 matricula from alumno_pago where " & _
                "matricula = '" & Matricula & "' " & _
                "and campus = '" & Campus & "' " & _
                "and licenciatura = '" & Licenciatura & "' " & _
                "and especialidad = '" & Especialidad & "' " & _
                "and modalidad = '" & Modalidad & "' " & _
                "and turno = '" & Turno & "' " & _
                "and semestre = '" & Semestre & "' " & _
                "and grupo = '" & Grupo & "';"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                Return
            End If

            b.abrirConexion()
            sql = "insert into alumno_pago(matricula, campus, licenciatura, especialidad, modalidad, turno, semestre, grupo) " & _
                "values(" & _
                "'" & Matricula & "'" & _
                "'" & Campus & "'" & _
                "'" & Licenciatura & "'" & _
                "'" & Especialidad & "'" & _
                "'" & Modalidad & "'" & _
                "'" & Turno & "'" & _
                "'" & Semestre & "'" & _
                "'" & Grupo & "'" & _
                ");"
            b.ejecutarComando(sql)
            b.cerrarConexion()

        End Sub

        Public Sub adeudoLibros(ByVal Matricula As String, ByVal Adeuda As Boolean)
            Dim b As New BaseDatos
            Dim sql As String
            Dim Valor As Integer = 0

            If Adeuda = True Then
                Valor = 1
            End If

            sql = "UPDATE ALUMNO SET ADEUDO_LIBROS_MATERIAL = '" & Valor & "';"

            b.abrirConexion()
            b.ejecutarComando(sql)
            b.cerrarConexion()

        End Sub

        Public Sub promoverAlumno(ByVal Matricula As String)
            Dim b As New BaseDatos
            Dim sql As String

            sql = "UPDATE ALUMNO " & _
                "SET IDSEMESTRE = (IDSEMESTRE + 1) " & _
                "WHERE MATRICULA = '" & Matricula & "';"

            b.abrirConexion()
            b.ejecutarComando(sql)
            b.cerrarConexion()

        End Sub

        Public Function esAlumnoRegular(ByVal Matricula As String,
                                        ByVal Semestre As String,
                                        ByVal Grupo As String) As MensajesAlumnoRegular
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            Dim calificacion As Double
            Dim calificacion2 As Double

            Dim Mensajes As MensajesAlumnoRegular
            Dim ErrorCalificaciones As String = ""
            Dim ErrorActDepCult As String = ""
            Dim ErrorSevicios As String = ""
            Dim ErrorAdeudoLibros As String = ""
            Dim ErrorPago As String = ""

            'validar que el alumno no ha reprobado ninguna materia
            sql = "SELECT " & _
                "ISNULL(((C.CALIFICACION + C.CALIFICACION2) / 2),0) AS 'PROMEDIO' " & _
                "FROM CALIFICACIONES C " & _
                "INNER JOIN ALUMNO A ON A.MATRICULA = C.MATRICULA " & _
                "AND C.MATRICULA = '" & Matricula & "' " & _
                "AND C.IDSEMESTRE = '" & Semestre & "' AND C.IDGRUPO = '" & Grupo & "';"

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    calificacion = Double.Parse(F("PROMEDIO").ToString)
                    If calificacion < 6 Then
                        ErrorCalificaciones = "- No ha aprobado todas la materias con regularidad."
                    End If
                Next
            End If
            ds = Nothing

            'validar que el alumno ha acreditado las actividades deportivas y culturales
            sql = "SELECT C.IDMATERIA, C.CALIFICACION, C.IDSEMESTRE, " & _
                "C.IDLICENCIATURA, C.IDGRUPO, C.IDPARCIAL, " & _
                "C.CALIFICACION2, M.NOMBRE, C.MATRICULA " & _
                "FROM CALIFICACIONES C " & _
                "INNER JOIN MATERIAS M ON M.IDMATERIA = C.IDMATERIA " & _
                "AND C.MATRICULA = '" & Matricula & "' " & _
                "AND C.IDSEMESTRE = '" & Semestre & "' " & _
                "AND C.IDGRUPO = '" & Grupo & "' " & _
                "AND C.IDMATERIA = '1233';" 'IDMATERIA - 1233 - ACTIVIDADES CULTURALES Y DEPORTIVAS

            ds = New DataSet
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    calificacion = Double.Parse(F("CALIFICACION").ToString)
                    calificacion2 = Double.Parse(F("CALIFICACION2").ToString)
                    If calificacion < 1 Or calificacion2 < 0 Then
                        ErrorActDepCult = "- No ha acreditado las Actividades Culturales y Deportivas."
                    End If
                Next
            End If
            ds = Nothing

            'validar que el alumno ha acreditado los servicios sociales
            sql = "SELECT C.IDMATERIA, C.CALIFICACION, C.IDSEMESTRE, " & _
                "C.IDLICENCIATURA, C.IDGRUPO, C.IDPARCIAL, " & _
                "C.CALIFICACION2, M.NOMBRE, C.MATRICULA " & _
                "FROM CALIFICACIONES C " & _
                "INNER JOIN MATERIAS M ON M.IDMATERIA = C.IDMATERIA " & _
                "AND C.MATRICULA = '" & Matricula & "' " & _
                "AND C.IDSEMESTRE = '" & Semestre & "' " & _
                "AND C.IDGRUPO = '" & Grupo & "' " & _
                "AND C.IDMATERIA = '1232';" 'IDMATERIA - 1232 - SERVICIO SOCIAL INTERNO

            ds = New DataSet
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    calificacion = Double.Parse(F("CALIFICACION").ToString)
                    'calificacion = Double.Parse(F("CALIFICACION").ToString)
                    If calificacion < 1 Or calificacion2 < 0 Then
                        ErrorSevicios = "- No ha acreditado el Servicio Social Interno."
                    End If
                Next
            End If
            ds = Nothing

            'validar que el alumno no debe libros o material
            sql = "SELECT ISNULL(ADEUDO_LIBROS_MATERIAL, '0') AS 'ADEUDO' " & _
                "FROM alumno a " & _
                "WHERE A.MATRICULA = '" & Matricula & "';"

            ds = New DataSet
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    If F("ADEUDO").ToString = "1" Then
                        ErrorAdeudoLibros = "- Tiene adeudo de material escolar y/o libros."
                    End If
                Next
            End If
            ds = Nothing

            'validar que el alumno haya pagado
            sql = "SELECT top 1 ap.matricula " & _
                "FROM alumno_pago ap " & _
                "WHERE " & _
                "ap.matricula = '" & Matricula & "' " & _
                "AND ap.semestre = '" & Semestre & "' " & _
                "AND ap.grupo = '" & Grupo & "';"

            ds = New DataSet
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count = 0 Then
                ErrorPago = "- No ha realizado el pago de inscripción o reinscripción."
            End If
            ds = Nothing

            Mensajes.ErrorCalificaciones = ErrorCalificaciones
            Mensajes.ErrorActDepCult = ErrorActDepCult
            Mensajes.ErrorSevicios = ErrorSevicios
            Mensajes.ErrorAdeudoLibros = ErrorAdeudoLibros
            Mensajes.ErrorPago = ErrorPago

            Return Mensajes

        End Function

        Public Sub truncarAlumno(ByVal Matricula As String, ByVal Nombre As String, ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, _
                                ByVal Campus As String, ByVal Licenciatura As String, ByVal Especialidad As String, _
                                ByVal Modalidad As String, ByVal Turno As String, ByVal Semestre As String, ByVal Grupo As String)
            ' se agrego la validacion de try-catch y tambien se agrego la transaccion para validar de que si existe un error se deshaga la operacion
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            'Dim sqltrans As SqlTransaction
            'sqltrans = b.Conexion.BeginTransaction()
            Try

                b.abrirConexion()
                sql = "DELETE FROM ALUMNO WHERE " & _
                    "NOMBRE = '" & Nombre & "' " & _
                    "AND APELLIDO_PATERNO = '" & ApellidoPaterno & "' " & _
                    "AND APELLIDO_MATERNO = '" & ApellidoMaterno & "' " & _
                    "AND IDCAMPUS = '" & Campus & "' " & _
                    "AND IDLICENCIATURA = '" & Licenciatura & "' " & _
                    "AND IDESPECIALIDAD = '" & Especialidad & "' " & _
                    "AND IDMODALIDAD = '" & Modalidad & "' " & _
                    "AND IDTURNO = '" & Turno & "' " & _
                    "AND IDSEMESTRE = '" & Semestre & "' " & _
                    "AND IDGRUPO = '" & Grupo & "';"

                If Matricula.Length > 0 Then
                    sql = "DELETE FROM ALUMNO WHERE MATRICULA = '" & Matricula & "';"
                End If

                b.ejecutarComando(sql)
                '   sqltrans.Commit()
            Catch exC As Exception
                '    sqltrans.Rollback()
                Throw exC
            End Try
            b.cerrarConexion()
        End Sub

        Public Sub altaAlumno(ByVal Nombre As String, ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, _
            ByVal Genero As String, ByVal CURP As String, ByVal FechaNacimiento As String, _
            ByVal Calle As String, ByVal NumExt As String, ByVal NumInt As String, _
            ByVal Colonia As String, ByVal Estado As String, ByVal Municipio As String, _
            ByVal CodigoPostal As String, ByVal Telefno As String, ByVal Celular As String, _
            ByVal Email As String, ByVal ContactoEmergencia As String, ByVal TelefonoEmergencia As String, _
            ByVal TipoSangre As String, ByVal Observaciones As String, ByVal Matricula As String, _
            ByVal Semestre As String, ByVal Grupo As String, ByVal Beca As String, _
            ByVal Campus As String, ByVal PlanEstatal As String, ByVal Generacion As String, _
            ByVal FechaIngreso As String, ByVal FechaEgreso As String, ByVal Turno As String, _
            ByVal Licenciatura As String, ByVal Especialidad As String, ByVal Modalidad As String,
            ByVal EstatusAlumno As String, ByVal Fotografia As String, ByVal NoSeguroSocial As String)

            Dim b As New BaseDatos
            Dim sql As String
            '------------CHECAR QUE EL ALUMNO NO EXISTA CON 
            sql = "INSERT INTO alumno ([IDALUMNO], [NOMBRE], [APELLIDO_PATERNO], [APELLIDO_MATERNO], [GENERO], [CALLE], [NUMERO_EXTERIOR], [NUMERO_INTERIOR], [COLONIA],[IDMUNICIPIO],[IDESTADO],[CODIGO_POSTAL],[CURP],[TELEFONO_CASA],[TELEFONO_CEL],[CORREO_ELECTRONICO],[FECHA_NACIMIENTO],[FECHA_INGRESO],[FECHA_SALIDA],[TIPO_SANGRE],[OBSERVACIONES],[CONTACTO_EMERGENCIA],[TELEFONO_EMERGENCIA],[MATRICULA],[IDCAMPUS],[IDturno],[IDSTATUS],[IDAREA],[IDMODALIDAD],[IDESPECIALIDAD],[IDSEMESTRE],[IDGRUPO],[IDLICENCIATURA],[FOTO],[PLANEST],[GENERACION],[BECA],[NO_SS]) " & _
                "VALUES(" & _
                "'0', " & _
                "'" & b.SafeSqlLiteral(Nombre) & "', " & _
                "'" & b.SafeSqlLiteral(ApellidoPaterno) & "', " & _
                "'" & b.SafeSqlLiteral(ApellidoMaterno) & "', " & _
                "'" & b.SafeSqlLiteral(Genero) & "', " & _
                "'" & b.SafeSqlLiteral(Calle) & "', " & _
                "'" & b.SafeSqlLiteral(NumExt) & "', " & _
                "'" & b.SafeSqlLiteral(NumInt) & "', " & _
                "'" & b.SafeSqlLiteral(Colonia) & "', " & _
                "'" & b.SafeSqlLiteral(Municipio) & "', " & _
                "'" & b.SafeSqlLiteral(Estado) & "', " & _
                "'" & b.SafeSqlLiteral(CodigoPostal) & "', " & _
                "'" & b.SafeSqlLiteral(CURP) & "', " & _
                "'" & b.SafeSqlLiteral(Telefno) & "', " & _
                "'" & b.SafeSqlLiteral(Celular) & "', " & _
                "'" & b.SafeSqlLiteral(Email) & "', " & _
                "'" & b.SafeSqlLiteral(FechaNacimiento) & "', " & _
                "'" & b.SafeSqlLiteral(FechaIngreso) & "', " & _
                "'" & b.SafeSqlLiteral(FechaEgreso) & "', " & _
                "'" & b.SafeSqlLiteral(TipoSangre) & "', " & _
                "'" & b.SafeSqlLiteral(Observaciones) & "', " & _
                "'" & b.SafeSqlLiteral(ContactoEmergencia) & "', " & _
                "'" & b.SafeSqlLiteral(TelefonoEmergencia) & "', " & _
                "'" & b.SafeSqlLiteral(Matricula) & "', " & _
                "'" & b.SafeSqlLiteral(Campus) & "', " & _
                "'" & b.SafeSqlLiteral(Turno) & "', " & _
                "'" & b.SafeSqlLiteral(EstatusAlumno) & "', " & _
                "'', " & _
                "'" & b.SafeSqlLiteral(Modalidad) & "', " & _
                "'" & b.SafeSqlLiteral(Especialidad) & "', " & _
                "'" & b.SafeSqlLiteral(Semestre) & "', " & _
                "'" & b.SafeSqlLiteral(Grupo) & "', " & _
                "'" & b.SafeSqlLiteral(Licenciatura) & "', " & _
                "'" & b.SafeSqlLiteral(Fotografia) & "', " & _
                "'" & b.SafeSqlLiteral(PlanEstatal) & "', " & _
                "'" & b.SafeSqlLiteral(Generacion) & "', " & _
                "'" & b.SafeSqlLiteral(Beca) & "', " & _
                "'" & b.SafeSqlLiteral(NoSeguroSocial) & "' " & _
                ");"

            b.abrirConexion()

            b.ejecutarComando(sql.ToUpper)

            b.cerrarConexion()

        End Sub

        '---------------------------------------

        Public Function getAlumno(ByVal Matricula As String, ByVal Nombre As String, ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, _
                            ByVal Campus As String, ByVal Licenciatura As String, ByVal Especialidad As String, _
                            ByVal Modalidad As String, ByVal Turno As String, ByVal Semestre As String, ByVal Grupo As String) As Alumno

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            Dim A As Alumno = Nothing

            If Matricula.Length = 0 Then

                sql = "SELECT TOP 1 * FROM ALUMNO WHERE " & _
                    "NOMBRE = '" & Nombre & "' " & _
                    "AND APELLIDO_PATERNO = '" & ApellidoPaterno & "' " & _
                    "AND APELLIDO_MATERNO = '" & ApellidoMaterno & "' " & _
                    "AND IDCAMPUS = '" & Campus & "' " & _
                    "AND IDLICENCIATURA = '" & Licenciatura & "' " & _
                    "AND IDESPECIALIDAD= '" & Especialidad & "' " & _
                    "AND IDMODALIDAD = '" & Modalidad & "' " & _
                    "AND IDTURNO = '" & Turno & "' " & _
                    "AND IDSEMESTRE = '" & Semestre & "' " & _
                    "AND IDGRUPO = '" & Grupo & "';"

            Else

                sql = "SELECT TOP 1 * FROM ALUMNO WHERE " & _
                    "MATRICULA = '" & Matricula & "';"

            End If

            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    A = New Alumno(F("IDALUMNO").ToString,
                                   F("NOMBRE").ToString,
                                   F("APELLIDO_PATERNO").ToString,
                                   F("APELLIDO_MATERNO").ToString,
                                   F("GENERO").ToString,
                                   F("CALLE").ToString,
                                   F("NUMERO_EXTERIOR").ToString,
                                   F("NUMERO_INTERIOR").ToString,
                                   F("COLONIA").ToString,
                                   F("IDMUNICIPIO").ToString,
                                   F("IDESTADO").ToString,
                                   F("CODIGO_POSTAL").ToString,
                                   F("CURP").ToString,
                                   F("TELEFONO_CASA").ToString,
                                   F("TELEFONO_CEL").ToString,
                                   F("CORREO_ELECTRONICO").ToString,
                                   F("FECHA_NACIMIENTO").ToString,
                                   F("FECHA_INGRESO").ToString,
                                   F("FECHA_SALIDA").ToString,
                                   F("TIPO_SANGRE").ToString,
                                   F("OBSERVACIONES").ToString,
                                   F("CONTACTO_EMERGENCIA").ToString,
                                   F("TELEFONO_EMERGENCIA").ToString,
                                   F("MATRICULA").ToString,
                                   F("IDCAMPUS").ToString,
                                   F("IDturno").ToString,
                                   F("IDSTATUS").ToString,
                                   F("IDAREA").ToString,
                                   F("IDMODALIDAD").ToString,
                                   F("IDESPECIALIDAD").ToString,
                                   F("IDSEMESTRE").ToString,
                                   F("IDGRUPO").ToString,
                                   F("IDLICENCIATURA").ToString,
                                   F("FOTO").ToString,
                                   F("PLANEST").ToString,
                                   F("GENERACION").ToString,
                                   F("BECA").ToString,
                                   F("NO_SS").ToString,
                                   F("ADEUDO_LIBROS_MATERIAL").ToString
                                   )
                Next
            Else
                Return Nothing
            End If

            Return A

        End Function
        Public Function getMaterias(ByVal semestre As String, ByVal idlicenciatura As String) As List(Of String)
            Dim Materias As New List(Of String)
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            sql = "select nombre from materias where idsemestre = '" & semestre & "' and idcarrera = '" & idlicenciatura & "'"
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    Materias.Add(F("nombre").ToString)
                Next
            End If
            Return Materias
        End Function
        Public Function getEstados() As List(Of String)

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim Estados As New List(Of String)
            Dim sql As String

            sql = "SELECT UPPER(NOMBRE) AS 'NOMBRE' FROM CATALOGO_ESTADOS ORDER BY NOMBRE;"
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    Estados.Add(F("nombre").ToString)
                Next
            End If
            Return Estados

        End Function

        Public Function getCampus() As List(Of String)
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            Dim Campus As New List(Of String)

            b.abrirConexion()
            sql = "SELECT IDCAMPUS AS 'CAMPUS' " & _
                "FROM ALUMNO GROUP BY IDCAMPUS ORDER BY IDCAMPUS ASC;"
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each f As DataRow In ds.Tables(0).Rows
                    Campus.Add(f("CAMPUS").ToString)
                Next
            Else
                Campus = Nothing
            End If
            Return Campus
        End Function
        Public Function getparciales() As List(Of String)
            Dim parcial As New List(Of String)
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            sql = "select idparcial,descripcion from parciales"
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each f As DataRow In ds.Tables(0).Rows
                    parcial.Add(f(1).ToString)
                Next
            End If
            Return parcial
        End Function
        Public Function getMaestros() As List(Of String)
            Dim Maestros As New List(Of String)
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            sql = "select nombre,apellido_paterno,apellido_materno from maestro"
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each f As DataRow In ds.Tables(0).Rows
                    Maestros.Add(f(0).ToString & " " & f(1).ToString & " " & f(2).ToString)
                Next
            End If
            Return Maestros

        End Function
        Public Function getLicenciaturas() As List(Of String)
            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            Dim Licenciaturas As New List(Of String)

            b.abrirConexion()
            sql = "SELECT UPPER(IDLICENCIATURA) AS LICENCIATURA " & _
                "FROM ALUMNO GROUP BY IDLICENCIATURA " & _
                "ORDER BY IDLICENCIATURA;"
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each f As DataRow In ds.Tables(0).Rows
                    Licenciaturas.Add(f("LICENCIATURA").ToString)
                Next
            Else
                Licenciaturas = Nothing
            End If

            Return Licenciaturas
        End Function
        Public Function getidlicenciatura(ByVal licenciatura As String)
            Dim sql As String
            Dim idlicenciaturas As Integer
            Dim b As New BaseDatos
            Dim ds As New DataSet
            sql = "select idlicenciatura from licenciaturas where nombre = '" & licenciatura & "'"
            b.abrirConexion()
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each F As DataRow In ds.Tables(0).Rows
                    idlicenciaturas = Integer.Parse(F(0))
                Next
            End If
            Return idlicenciaturas
        End Function
        Public Function getGrupos() As List(Of String)

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            Dim Grupos As New List(Of String)

            b.abrirConexion()
            sql = "SELECT IDGRUPO AS GRUPO FROM ALUMNO " & _
                "GROUP BY IDGRUPO ORDER BY IDGRUPO;"
            ds = b.getDataSet(sql)
            b.cerrarConexion()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each f As DataRow In ds.Tables(0).Rows
                    Grupos.Add(f("GRUPO").ToString)
                Next
            Else
                Grupos = Nothing
            End If
            Return Grupos
        End Function

        Public Function getSemestres() As List(Of String)

            Dim Semestres As New List(Of String)

            Semestres.Add("1")
            Semestres.Add("2")
            Semestres.Add("3")
            Semestres.Add("4")
            Semestres.Add("5")
            Semestres.Add("6")
            Semestres.Add("7")
            Semestres.Add("8")
            Semestres.Add("9")
            Semestres.Add("10")
            Semestres.Add("11")

            Return Semestres

        End Function

        Public Function getGeneros() As List(Of String)

            Dim generos As New List(Of String)

            generos.Add("F")
            generos.Add("M")

            Return generos

        End Function

        Public Function getEspecialidades() As List(Of String)

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim sql As String
            Dim Especialidades As New List(Of String)

            b.abrirConexion()
            ' se cambio por el sql gmh
            sql = "SELECT UPPER(IDESPECIALIDAD) AS 'ESPECIALIDAD' " & _
                    "FROM ALUMNO " & _
                    "WHERE IDESPECIALIDAD <> 'NULL' AND LEN(LTRIM(RTRIM(IDESPECIALIDAD))) > 0 " & _
                    "GROUP BY IDESPECIALIDAD " & _
                    "ORDER BY IDESPECIALIDAD"
            sql = "select upper(descripcion) from especialidades" 'gmh
            ds = b.getDataSet(sql)

            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then
                For Each f As DataRow In ds.Tables(0).Rows
                    Especialidades.Add(f(0).ToString)
                Next
            Else
                Especialidades = Nothing
            End If

            Return Especialidades

        End Function

        Public Function getModalidades() As List(Of String)

            Dim Modalidades As New List(Of String)

            Modalidades.Add("E")
            '  Modalidades.Add("M")

            Return Modalidades

        End Function

        Public Function getTurnos() As List(Of String)

            Dim Turnos As New List(Of String)

            Turnos.Add("TM")
            Turnos.Add("TV")

            Return Turnos

        End Function

        Public Function getEstatusAlumno() As List(Of String)

            Dim b As New BaseDatos
            Dim ds As New DataSet
            Dim Estatus As New List(Of String)
            Dim sql As String

            sql = "SELECT DESCRIPCION FROM STATUS_ALUMNO ORDER BY DESCRIPCION ASC;"

            b.abrirConexion()

            ds = b.getDataSet(sql)

            b.cerrarConexion()

            If ds.Tables(0).Rows.Count > 0 Then

                For Each F As DataRow In ds.Tables(0).Rows

                    Estatus.Add(F("DESCRIPCION").ToString)

                Next

            End If

            Return Estatus

        End Function

        Public Function validarEmail(ByVal Email As String) As Boolean

            Return Regex.IsMatch(Email, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

        End Function

        Public Function validarCURP(ByVal CURP As String) As Boolean

            Dim expresion As String

            expresion = "^[a-zA-Z]{4}((\d{2}((0[13578]|1[02])(0[1-9]|[12]\d|3[01])|(0[13456789]|1[012])(0[1-9]|[12]\d|30)|02(0[1-9]|1\d|2[0-8])))|([02468][048]|[13579][26])0229)(H|M)(AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|SM|NE)([a-zA-Z]{3})([a-zA-Z0-9\s]{1})\d{1}$+"

            Return Regex.IsMatch(CURP, expresion)

        End Function

    End Class

    Public Class Alumno

        Public IdAlumno As String
        Public Nombre As String
        Public ApellidoPaterno As String
        Public ApellidoMaterno As String
        Public Genero As String
        Public Calle As String
        Public NumExterior As String
        Public NumInterior As String
        Public Colonia As String
        Public Municipio As String
        Public Estado As String
        Public CodigoPostal As String
        Public Curp As String
        Public TelefonoCasa As String
        Public TelefonoCel As String
        Public CorreoElectronico As String
        Public FechaNacimiento As String
        Public FechaIngreso As String
        Public FechaSalida As String
        Public TipoSangre As String
        Public Observaciones As String
        Public ContactoEmergencia As String
        Public TelefonoEmergencia As String
        Public Matricula As String
        Public Campus As String
        Public Turno As String
        Public Estatus As String
        Public Area As String
        Public Modalidad As String
        Public Especialidad As String
        Public Semestre As String
        Public Grupo As String
        Public Licenciatura As String
        Public Foto As String
        Public PlanEst As String
        Public Generacion As String
        Public Beca As String
        Public NoSS As String
        Public AdeudoLibrosMaterial As String

        Public Sub New(ByVal IdAlumno As String, _
                        ByVal Nombre As String, _
                        ByVal ApellidoPaterno As String, _
                        ByVal ApellidoMaterno As String, _
                        ByVal Genero As String, _
                        ByVal Calle As String, _
                        ByVal NumExterior As String, _
                        ByVal NumInterior As String, _
                        ByVal Colonia As String, _
                        ByVal Municipio As String, _
                        ByVal Estado As String, _
                        ByVal CodigoPostal As String, _
                        ByVal Curp As String, _
                        ByVal TelefonoCasa As String, _
                        ByVal TelefonoCel As String, _
                        ByVal CorreoElectronico As String, _
                        ByVal FechaNacimiento As String, _
                        ByVal FechaIngreso As String, _
                        ByVal FechaSalida As String, _
                        ByVal TipoSangre As String, _
                        ByVal Observaciones As String, _
                        ByVal ContactoEmergencia As String, _
                        ByVal TelefonoEmergencia As String, _
                        ByVal Matricula As String, _
                        ByVal Campus As String, _
                        ByVal Turno As String, _
                        ByVal Estatus As String, _
                        ByVal Area As String, _
                        ByVal Modalidad As String, _
                        ByVal Especialidad As String, _
                        ByVal Semestre As String, _
                        ByVal Grupo As String, _
                        ByVal Licenciatura As String, _
                        ByVal Foto As String, _
                        ByVal PlanEst As String, _
                        ByVal Generacion As String, _
                        ByVal Beca As String, _
                        ByVal NoSS As String,
                        ByVal AdeudoLibrosMaterial As String)

            Me.IdAlumno = IdAlumno
            Me.Nombre = Nombre
            Me.ApellidoPaterno = ApellidoPaterno
            Me.ApellidoMaterno = ApellidoMaterno
            Me.Genero = Genero
            Me.Calle = Calle
            Me.NumExterior = NumExterior
            Me.NumInterior = NumInterior
            Me.Colonia = Colonia
            Me.Municipio = Municipio
            Me.Estado = Estado
            Me.CodigoPostal = CodigoPostal
            Me.Curp = Curp
            Me.TelefonoCasa = TelefonoCasa
            Me.TelefonoCel = TelefonoCel
            Me.CorreoElectronico = CorreoElectronico
            Me.FechaNacimiento = FechaNacimiento
            Me.FechaIngreso = FechaIngreso
            Me.FechaSalida = FechaSalida
            Me.TipoSangre = TipoSangre
            Me.Observaciones = Observaciones
            Me.ContactoEmergencia = ContactoEmergencia
            Me.TelefonoEmergencia = TelefonoEmergencia
            Me.Matricula = Matricula
            Me.Campus = Campus
            Me.Turno = Turno
            Me.Estatus = Estatus
            Me.Area = Area
            Me.Modalidad = Modalidad
            Me.Especialidad = Especialidad
            Me.Semestre = Semestre
            Me.Grupo = Grupo
            Me.Licenciatura = Licenciatura
            Me.Foto = Foto
            Me.PlanEst = PlanEst
            Me.Generacion = Generacion
            Me.Beca = Beca
            Me.NoSS = NoSS
            Me.AdeudoLibrosMaterial = AdeudoLibrosMaterial

        End Sub

    End Class

End Namespace