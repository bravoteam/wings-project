Imports System.Data.SqlClient
Imports System.Linq
Imports datosCompartidos.Datos
Imports System.IO
Imports System.Xml

Module funcionesLocales
    Public Sub guardarCampus(ByVal modelo As modelos.modeloCampus)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into campus(NOMBRE,CALLE,NUMERO,COLONIA," & _
                "MUNICIPIO,CODIGO_POSTAL,CCT,TELEFONO)" & _
                         "values (@NOMBRE,@CALLE,@NUMERO,@COLONIA," & _
                "@MUNICIPIO,@CODIGO_POSTAL,@CCT,@TELEFONO)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@NUMERO", modelo.NUMERO)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@MUNICIPIO", modelo.MUNICIPIO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
                .Parameters.AddWithValue("@CCT", modelo.CCT)
                .Parameters.AddWithValue("@TELEFONO", modelo.TELEFONO)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Function traerUltimaMateria() As modelos.modeloMateria
        Dim modelo As New modelos.modeloMateria
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from materias order by IDMATERIA DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.IDMATERIA = Val(variables.SQLdr("IDMATERIA").ToString)
                modelo.IDCARRERA = Val(variables.SQLdr("IDCARRERA").ToString)
                modelo.IDESPECIALIDAD = Val(variables.SQLdr("IDESPECIALIDAD").ToString)
                modelo.IDMAESTRO = Val(variables.SQLdr("IDMAESTRO").ToString)
                modelo.IDSEMESTRE = Val(variables.SQLdr("IDSEMESTRE").ToString)
                modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
                modelo.PLANDEESTUDIOS = variables.SQLdr("PLANDEESTUDIOS").ToString
                modelo.CLAVEISENCO = variables.SQLdr("CLAVEISENCO").ToString
                modelo.ACTIVA = Val(variables.SQLdr("ACTIVA").ToString)
                modelo.TIPOCHECK = Val(variables.SQLdr("TIPOCHECK").ToString)
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function traerUltimoMaestro() As modelos.modeloMaestro
        Dim modelo As New modelos.modeloMaestro
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from Personal order by id DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.ID = Val(variables.SQLdr("id"))
                modelo.ACTIVO = Val(variables.SQLdr("ACTIVO").ToString)
                modelo.APELLIDO_MATERNO = variables.SQLdr("APELLIDO_MATERNO").ToString
                modelo.APELLIDO_PATERNO = variables.SQLdr("APELLIDO_PATERNO").ToString
                modelo.CALLE = variables.SQLdr("CALLE").ToString
                modelo.CP = variables.SQLdr("CP").ToString
                modelo.COLONIA = variables.SQLdr("COLONIA").ToString
                modelo.CONTACTO_EMERGENCIA = variables.SQLdr("CONTACTO_EMERGENCIA").ToString
                modelo.EMAIL = variables.SQLdr("EMAIL").ToString
                modelo.CURP = variables.SQLdr("CURP").ToString
                modelo.ESTADO = variables.SQLdr("ESTADO").ToString
                modelo.FECHA_INGRESO = Date.Parse(variables.SQLdr("FECHA_INGRESO"))
                modelo.FECHA_NACIMIENTO = Date.Parse(variables.SQLdr("FECHA_NACIMIENTO"))
                modelo.FECHA_SALIDA = variables.SQLdr("FECHA_SALIDA").ToString
                modelo.MUNICIPIO = variables.SQLdr("APELLIDO_MATERNO").ToString
                modelo.NOMBRE = variables.SQLdr("APELLIDO_PATERNO").ToString
                modelo.NUMERO = variables.SQLdr("NUMERO").ToString
                modelo.OBSERVACIONES = variables.SQLdr("OBSERVACIONES").ToString
                modelo.TELEFONO_CASA = variables.SQLdr("TELEFONO_CASA").ToString
                modelo.TELEFONO_CEL = variables.SQLdr("TELEFONO_CEL").ToString
                modelo.TELEFONO_EMERGENCIA = variables.SQLdr("TELEFONO_EMERGENCIA").ToString
                modelo.TIPO_SANGRE = variables.SQLdr("TIPO_SANGRE").ToString
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function

    Public Function traerAlumno(ByVal variable As String) As modelos.modeloAlumno
        Dim modelo As New modelos.modeloAlumno
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from alumno where MATRICULA = '" + variable + "'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.IDALUMNO = Val(variables.SQLdr("IDALUMNO"))
                modelo.APELLIDO_MATERNO = variables.SQLdr("APELLIDO_MATERNO").ToString
                modelo.APELLIDO_PATERNO = variables.SQLdr("APELLIDO_PATERNO").ToString
                modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
                modelo.MATRICULA = variables.SQLdr("MATRICULA").ToString
                modelo.FOTO = variables.SQLdr("FOTO")
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function traerUltimoCampus() As modelos.modeloCampus
        Dim modelo As New modelos.modeloCampus
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from campus order by IDCAMPUS DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.CALLE = variables.SQLdr("CALLE").ToString
                modelo.CCT = variables.SQLdr("CCT").ToString
                modelo.CODIGO_POSTAL = variables.SQLdr("CODIGO_POSTAL").ToString
                modelo.COLONIA = variables.SQLdr("COLONIA").ToString
                modelo.IDCAMPUS = variables.SQLdr("IDCAMPUS").ToString
                modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
                modelo.NUMERO = variables.SQLdr("NUMERO").ToString
                modelo.TELEFONO = variables.SQLdr("TELEFONO").ToString
                modelo.MUNICIPIO = variables.SQLdr("MUNICIPIO").ToString
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function traerUltimoAdministrativo() As modelos.modeloAdministrativo
        Dim modelo As New modelos.modeloAdministrativo
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from directivos order by IDDIRECTIVO DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.IDDIRECTIVO = Val(variables.SQLdr("IDDIRECTIVO").ToString)
                modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
                modelo.CAMPUS = variables.SQLdr("CAMPUS").ToString
                modelo.PUESTO = variables.SQLdr("PUESTO").ToString

                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function traerUltimoCiclo() As modelos.modeloCicloEscolar
        Dim modelo As New modelos.modeloCicloEscolar
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from ciclo_escolar order by IDCICLOESCOLAR DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.IDCICLOESCOLAR = Val(variables.SQLdr("IDCICLOESCOLAR").ToString)
                modelo.INICIO = variables.SQLdr("INICIO")
                modelo.FIN = variables.SQLdr("FIN")
                modelo.ACTUAL = Val(variables.SQLdr("ACTUAL").ToString)

                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function

    Public Function traerUltimoAlumno() As modelos.modeloAlumno
        Dim modelo As New modelos.modeloAlumno
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from alumno order by IDALUMNO DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.IDALUMNO = Val(variables.SQLdr("IDALUMNO"))
                modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
                modelo.APELLIDO_PATERNO = variables.SQLdr("APELLIDO_PATERNO").ToString
                modelo.APELLIDO_MATERNO = variables.SQLdr("APELLIDO_MATERNO").ToString
                modelo.GENERO = variables.SQLdr("GENERO").ToString
                modelo.CALLE = variables.SQLdr("CALLE").ToString
                modelo.NUMERO_INTERIOR = variables.SQLdr("NUMERO_INTERIOR").ToString
                modelo.NUMERO_EXTERIOR = variables.SQLdr("NUMERO_EXTERIOR").ToString
                modelo.COLONIA = variables.SQLdr("COLONIA").ToString
                modelo.IDMUNICIPIO = variables.SQLdr("IDMUNICIPIO").ToString
                modelo.IDESTADO = variables.SQLdr("IDESTADO").ToString
                modelo.CODIGO_POSTAL = variables.SQLdr("CODIGO_POSTAL").ToString
                modelo.CURP = variables.SQLdr("CURP").ToString
                modelo.TELEFONO_CASA = variables.SQLdr("TELEFONO_CASA").ToString
                modelo.TELEFONO_CEL = variables.SQLdr("TELEFONO_CEL").ToString
                modelo.CORREO_ELECTRONICO = variables.SQLdr("CORREO_ELECTRONICO").ToString
                modelo.FECHA_NACIMIENTO = variables.SQLdr("FECHA_NACIMIENTO")
                modelo.FECHA_INGRESO = variables.SQLdr("FECHA_INGRESO")
                modelo.FECHA_SALIDA = variables.SQLdr("FECHA_SALIDA")
                modelo.TIPO_SANGRE = variables.SQLdr("TIPO_SANGRE").ToString
                modelo.OBSERVACIONES = variables.SQLdr("OBSERVACIONES").ToString
                modelo.CONTACTO_EMERGENCIA = variables.SQLdr("CONTACTO_EMERGENCIA").ToString
                modelo.TELEFONO_EMERGENCIA = variables.SQLdr("TELEFONO_EMERGENCIA").ToString
                modelo.MATRICULA = variables.SQLdr("MATRICULA").ToString
                modelo.IDCAMPUS = variables.SQLdr("IDCAMPUS").ToString
                modelo.IDturno = variables.SQLdr("IDturno").ToString
                modelo.IDSTATUS = variables.SQLdr("IDSTATUS").ToString
                modelo.IDMODALIDAD = variables.SQLdr("IDMODALIDAD").ToString
                modelo.IDESPECIALIDAD = variables.SQLdr("IDESPECIALIDAD").ToString
                modelo.IDSEMESTRE = variables.SQLdr("IDSEMESTRE").ToString
                modelo.IDGRUPO = variables.SQLdr("IDGRUPO").ToString
                modelo.IDLICENCIATURA = variables.SQLdr("IDLICENCIATURA").ToString
                modelo.FOTO = variables.SQLdr("FOTO")
                modelo.PLANEST = variables.SQLdr("PLANEST").ToString
                modelo.GENERACION = variables.SQLdr("GENERACION").ToString
                modelo.BECA = variables.SQLdr("BECA").ToString
                modelo.NO_SS = variables.SQLdr("NO_SS").ToString
                modelo.ADEUDO_LIBROS = variables.SQLdr("ADEUDO_LIBROS").ToString
                modelo.PUNTAJECENEVAL = variables.SQLdr("PUNTAJECENEVAL").ToString
                modelo.PROMEDIObACHILLERATO = variables.SQLdr("PROMEDIObACHILLERATO").ToString
                modelo.BACHILLERATOPROCEDENCIA = variables.SQLdr("BACHILLERATOPROCEDENCIA").ToString
                modelo.ADEUDO_MATERIAL = variables.SQLdr("ADEUDO_MATERIAL").ToString
                modelo.SECUNDARIAPROCEDENCIA = variables.SQLdr("SECUNDARIAPROCEDENCIA").ToString
                modelo.CLINICA_IMSS = variables.SQLdr("CLINICA_IMSS").ToString
                modelo.TIENE_DISCAPACIDAD = variables.SQLdr("TIENE_DISCAPACIDAD").ToString
                modelo.TIPO_DISCAPACIDAD = variables.SQLdr("TIPO_DISCAPACIDAD").ToString
                modelo.DISCAPACIDAD_OBSERV = variables.SQLdr("DISCAPACIDAD_OBSERV").ToString
                modelo.ESCUELA_PRACTICA = variables.SQLdr("ESCUELA_PRACTICA").ToString
                modelo.NOMBRE_PAPA = variables.SQLdr("NOMBRE_PAPA").ToString
                modelo.NOMBRE_MAMA = variables.SQLdr("NOMBRE_MAMA").ToString
                modelo.LUGAR_NACIMIENTO = variables.SQLdr("LUGAR_NACIMIENTO").ToString
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Function traerUltimoInscrito() As modelos.modeloAlumno
        Dim modelo As New modelos.modeloAlumno
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from alumno where usuario = '" & variables.usuario & "' order by IDALUMNO DESC"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.IDALUMNO = Val(variables.SQLdr("IDALUMNO"))
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Sub actualizarCampus(ByVal modelo As modelos.modeloCampus)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE campus SET NOMBRE=@NOMBRE,CALLE=@CALLE,NUMERO=@NUMERO,COLONIA=@COLONIA," & _
                "MUNICIPIO=@MUNICIPIO,CODIGO_POSTAL=@CODIGO_POSTAL,CCT=@CCT,TELEFONO=@TELEFONO " & _
                         "where IDCAMPUS = @IDCAMPUS"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@NUMERO", modelo.NUMERO)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@MUNICIPIO", modelo.MUNICIPIO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
                .Parameters.AddWithValue("@CCT", modelo.CCT)
                .Parameters.AddWithValue("@TELEFONO", modelo.TELEFONO)
                .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarCampus(ByVal modelo As modelos.modeloCampus)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "DELETE  FROM campus where IDCAMPUS = @IDCAMPUS"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub guardarMaterias(ByVal modelo As modelos.modeloMateria)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into materias(NOMBRE,IDCARRERA,IDESPECIALIDAD,IDSEMESTRE," & _
                "PLANDEESTUDIOS,CLAVEISENCO,ACTIVA,TIPOCHECK)" & _
                         "values (@NOMBRE,@IDCARRERA,@IDESPECIALIDAD,@IDSEMESTRE," & _
                "@PLANDEESTUDIOS,@CLAVEISENCO,@ACTIVA,@TIPOCHECK)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@IDCARRERA", modelo.IDCARRERA)
                .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
                .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
                .Parameters.AddWithValue("@PLANDEESTUDIOS", modelo.PLANDEESTUDIOS)
                .Parameters.AddWithValue("@CLAVEISENCO", modelo.CLAVEISENCO)
                .Parameters.AddWithValue("@ACTIVA", modelo.ACTIVA)
                .Parameters.AddWithValue("@TIPOCHECK", modelo.TIPOCHECK)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarMaterias(ByVal modelo As modelos.modeloMateria)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE materias SET NOMBRE=@NOMBRE,IDCARRERA=@IDCARRERA,IDESPECIALIDAD=@IDESPECIALIDAD,IDSEMESTRE=@IDSEMESTRE," & _
                "PLANDEESTUDIOS=@PLANDEESTUDIOS,CLAVEISENCO=@CLAVEISENCO,ACTIVA=@ACTIVA,TIPOCHECK=@TIPOCHECK " & _
                         "where IDMATERIA = @IDMATERIA"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@IDCARRERA", modelo.IDCARRERA)
                .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
                .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
                .Parameters.AddWithValue("@PLANDEESTUDIOS", modelo.PLANDEESTUDIOS)
                .Parameters.AddWithValue("@CLAVEISENCO", modelo.CLAVEISENCO)
                .Parameters.AddWithValue("@IDMATERIA", modelo.IDMATERIA)
                .Parameters.AddWithValue("@ACTIVA", modelo.ACTIVA)
                .Parameters.AddWithValue("@TIPOCHECK", modelo.TIPOCHECK)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarMaterias(ByVal modelo As modelos.modeloMateria)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "DELETE  FROM materias where IDMATERIA = @IDMATERIA"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@IDMATERIA", modelo.IDMATERIA)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub guardarMaestros(ByVal modelo As modelos.modeloMaestro)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into personal(NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,CALLE," & _
                "NUMERO,COLONIA,MUNICIPIO,ESTADO,CP,CURP,TELEFONO_CASA,TELEFONO_CEL,EMAIL,FECHA_NACIMIENTO, " & _
                "FECHA_INGRESO,FECHA_SALIDA,TIPO_SANGRE,OBSERVACIONES,CONTACTO_EMERGENCIA,TELEFONO_EMERGENCIA,ACTIVO)" & _
                         "values (@NOMBRE,@APELLIDO_PATERNO,@APELLIDO_MATERNO,@CALLE," & _
                "@NUMERO,@COLONIA,@MUNICIPIO,@ESTADO,@CODIGO_POSTAL,@CURP,@TELEFONO_CASA,@TELEFONO_CEL,@CORREO_ELECTRONICO,@FECHA_NACIMIENTO, " & _
                "@FECHA_INGRESO,@FECHA_SALIDA,@TIPO_SANGRE,@OBSERVACIONES,@CONTACTO_EMERGENCIA,@TELEFONO_EMERGENCIA,@ACTIVA)"


            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@APELLIDO_PATERNO", modelo.APELLIDO_PATERNO)
                .Parameters.AddWithValue("@APELLIDO_MATERNO", modelo.APELLIDO_MATERNO)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@NUMERO", modelo.NUMERO)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@MUNICIPIO", modelo.MUNICIPIO)
                .Parameters.AddWithValue("@ESTADO", modelo.ESTADO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CP)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@TELEFONO_CASA", modelo.TELEFONO_CASA)
                .Parameters.AddWithValue("@TELEFONO_CEL", modelo.TELEFONO_CEL)
                .Parameters.AddWithValue("@CORREO_ELECTRONICO", modelo.email)
                .Parameters.AddWithValue("@FECHA_NACIMIENTO", modelo.FECHA_NACIMIENTO)
                .Parameters.AddWithValue("@FECHA_INGRESO", modelo.FECHA_INGRESO)
                .Parameters.AddWithValue("@FECHA_SALIDA", modelo.FECHA_SALIDA)
                .Parameters.AddWithValue("@TIPO_SANGRE", modelo.TIPO_SANGRE)
                .Parameters.AddWithValue("@OBSERVACIONES", modelo.OBSERVACIONES)
                .Parameters.AddWithValue("@CONTACTO_EMERGENCIA", modelo.CONTACTO_EMERGENCIA)
                .Parameters.AddWithValue("@TELEFONO_EMERGENCIA", modelo.TELEFONO_EMERGENCIA)
                .Parameters.AddWithValue("@ACTIVA", modelo.ACTIVO)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarMaestros(ByVal modelo As modelos.modeloMaestro)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE personal SET NOMBRE=@NOMBRE,APELLIDO_PATERNO=@APELLIDO_PATERNO,APELLIDO_MATERNO=@APELLIDO_MATERNO," & _
                "CALLE=@CALLE,NUMERO=@NUMERO,COLONIA=@COLONIA,MUNICIPIO=@MUNICIPIO,ESTADO=@ESTADO,CP=@CODIGO_POSTAL,CURP=@CURP," & _
                "TELEFONO_CASA=@TELEFONO_CASA,TELEFONO_CEL=@TELEFONO_CEL,EMAIL=@CORREO_ELECTRONICO,FECHA_NACIMIENTO=@FECHA_NACIMIENTO," & _
                "FECHA_INGRESO=@FECHA_INGRESO,FECHA_SALIDA=@FECHA_SALIDA,TIPO_SANGRE=@TIPO_SANGRE,OBSERVACIONES=@OBSERVACIONES,CONTACTO_EMERGENCIA=@CONTACTO_EMERGENCIA," & _
                "TELEFONO_EMERGENCIA=@TELEFONO_EMERGENCIA,ACTIVO=@ACTIVA WHERE id = @IDMAESTRO"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@APELLIDO_PATERNO", modelo.APELLIDO_PATERNO)
                .Parameters.AddWithValue("@APELLIDO_MATERNO", modelo.APELLIDO_MATERNO)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@NUMERO", modelo.NUMERO)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@MUNICIPIO", modelo.MUNICIPIO)
                .Parameters.AddWithValue("@ESTADO", modelo.ESTADO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CP)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@TELEFONO_CASA", modelo.TELEFONO_CASA)
                .Parameters.AddWithValue("@TELEFONO_CEL", modelo.TELEFONO_CEL)
                .Parameters.AddWithValue("@CORREO_ELECTRONICO", modelo.email)
                .Parameters.AddWithValue("@FECHA_NACIMIENTO", modelo.FECHA_NACIMIENTO)
                .Parameters.AddWithValue("@FECHA_INGRESO", modelo.FECHA_INGRESO)
                .Parameters.AddWithValue("@FECHA_SALIDA", modelo.FECHA_SALIDA)
                .Parameters.AddWithValue("@TIPO_SANGRE", modelo.TIPO_SANGRE)
                .Parameters.AddWithValue("@OBSERVACIONES", modelo.OBSERVACIONES)
                .Parameters.AddWithValue("@CONTACTO_EMERGENCIA", modelo.CONTACTO_EMERGENCIA)
                .Parameters.AddWithValue("@TELEFONO_EMERGENCIA", modelo.TELEFONO_EMERGENCIA)
                .Parameters.AddWithValue("@ACTIVA", modelo.ACTIVO)
                .Parameters.AddWithValue("@IDMAESTRO", modelo.ID)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarMaestros(ByVal modelo As modelos.modeloMaestro)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "DELETE  FROM personal where id = @IDMAESTRO"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@IDMAESTRO", modelo.ID)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub guardarAdministrativo(ByVal modelo As modelos.modeloAdministrativo)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into directivos(NOMBRE,PUESTO,CAMPUS)" & _
                         "values (@NOMBRE,@PUESTO,@CAMPUS)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@PUESTO", modelo.PUESTO)
                .Parameters.AddWithValue("@CAMPUS", modelo.CAMPUS)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarAdministrativo(ByVal modelo As modelos.modeloAdministrativo)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE directivos SET NOMBRE=@NOMBRE,PUESTO=@PUESTO,CAMPUS=@CAMPUS " & _
                         "where IDDIRECTIVO = @IDDIRECTIVO"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@PUESTO", modelo.PUESTO)
                .Parameters.AddWithValue("@CAMPUS", modelo.CAMPUS)
                .Parameters.AddWithValue("@IDDIRECTIVO", modelo.IDDIRECTIVO)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarAdministrativo(ByVal modelo As modelos.modeloAdministrativo)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "DELETE  FROM directivos where IDDIRECTIVO = @IDDIRECTIVO"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@IDMATERIA", modelo.IDDIRECTIVO)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarPago(ByVal id As Integer)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "DELETE  FROM alumno_pago where idMovimiento = @ID"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@ID", id)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub guardarCiclo(ByVal modelo As modelos.modeloCicloEscolar)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "insert into ciclo_escolar(INICIO,FIN,ACTUAL,DESCRIPCION)" & _
                         "values (@INICIO,@FIN,@ACTUAL,@DESCRIPCION)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@INICIO", modelo.INICIO)
                .Parameters.AddWithValue("@FIN", modelo.FIN)
                .Parameters.AddWithValue("@ACTUAL", modelo.ACTUAL)
                .Parameters.AddWithValue("@DESCRIPCION", modelo.DESCRIPCION)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarCiclo(ByVal modelo As modelos.modeloCicloEscolar)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE ciclo_escolar SET INICIO=@INICIO,FIN=@FIN,ACTUAL=@ACTUAL,DESCRIPCION=@DESCRIPCION " & _
                         "where IDCICLOESCOLAR = @IDCICLOESCOLAR"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@INICIO", modelo.INICIO)
                .Parameters.AddWithValue("@FIN", modelo.FIN)
                .Parameters.AddWithValue("@ACTUAL", modelo.ACTUAL)
                .Parameters.AddWithValue("@DESCRIPCION", modelo.DESCRIPCION)
                .Parameters.AddWithValue("@IDCICLOESCOLAR", modelo.IDCICLOESCOLAR)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub eliminarCiclo(ByVal modelo As modelos.modeloCicloEscolar)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "DELETE FROM ciclo_escolar where IDCICLOESCOLAR = @IDCICLOESCOLAR"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@IDCICLOESCOLAR", modelo.IDCICLOESCOLAR)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Function validarReceptorGP(ByVal GbxDatos As GroupBox) As Boolean
        Dim res As Boolean = True

        funcionesLocales.pintarControles(GbxDatos)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If (TypeOf ctl Is System.Windows.Forms.TextBox) Or (TypeOf ctl Is System.Windows.Forms.ComboBox) Then
                If String.IsNullOrEmpty(ctl.Text) Then
                    If ctl.Name <> "cmbEspecialidad" Then
                        ctl.BackColor = Drawing.Color.Aqua()
                        res = False
                    End If
                End If
            End If
        Next ctl

        Return res
    End Function
    Public Function validarReceptor(ByVal GbxDatos As GroupBox) As Boolean
        Dim res As Boolean = True

        funcionesLocales.pintarControles(GbxDatos)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                If String.IsNullOrEmpty(ctl.Text) Then
                    If ctl.Name <> "txtidCampus" And ctl.Name <> "txtidMateria" And ctl.Name <> "especialidadTxt" Then
                        ctl.BackColor = Drawing.Color.Aqua()
                        res = False
                    End If
                End If
            End If
        Next ctl

        Return res
    End Function
    Public Function validarReceptorTabs(ByVal GbxDatos As TabPage) As Boolean
        Dim res As Boolean = True

        '   funcionesLocales.pintarControlesTabs(GbxDatos)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Or TypeOf ctl Is System.Windows.Forms.ComboBox Then
                If String.IsNullOrEmpty(ctl.Text) Then
                    If ctl.Name <> "txtidMaestro" Then
                        ctl.BackColor = Drawing.Color.Aqua()
                        res = False
                    End If
                End If
            End If
        Next ctl

        Return res
    End Function
    Public Sub limpiarReceptorTabs(ByVal GbxDatos As TabPage)
        funcionesLocales.pintarControlesTabs(GbxDatos)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.CheckBox Then
                ctl.Text = ""
            End If
        Next ctl
        alumnosFrm.chkFaltoActa.Checked = False
        alumnosFrm.chkFaltoCertificado.Checked = False
        alumnosFrm.chkFaltoComprobante.Checked = False
        alumnosFrm.chkFaltoCurp.Checked = False
        alumnosFrm.chkFaltoFotos.Checked = False
        alumnosFrm.chkFaltoMedico.Checked = False
        alumnosFrm.chkFaltoPago.Checked = False
    End Sub


    Public Sub pintarControles(ByVal GbxDatos As GroupBox)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.BackColor = Drawing.Color.White
            End If
        Next ctl
    End Sub
    Public Sub pintarControlesTabs(ByVal GbxDatos As TabPage)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Or TypeOf ctl Is System.Windows.Forms.ComboBox Then
                ctl.BackColor = Drawing.SystemColors.Info
            End If
        Next ctl
    End Sub
    Public Sub buscarXDescripcion(ByVal busqueda)

        variables.conexion.abrirConexion()
        If variables.banderaAccion = "campus" Then
            variables.dt = variables.conexion.getDataSet("select * from campus where nombre like '%" + busqueda + "%'")
        End If
        If variables.banderaAccion = "materias" Then
            variables.dt = variables.conexion.getDataSet("select * from materias where nombre like '%" + busqueda + "%'")
        End If
        If variables.banderaAccion = "maestros" Or variables.banderaAccion = "actaP" Or variables.banderaAccion = "actaS" Or variables.banderaAccion = "actaV" Then
            variables.dt = variables.conexion.getDataSet("select * from personal where nombre + apellido_paterno + apellido_materno like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "administrativos" Then
            variables.dt = variables.conexion.getDataSet("select * from directivos where nombre like '%" + busqueda + "%'  ORDER BY nombre")
        End If
        If variables.banderaAccion = "modifcalif" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "tituloActa" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "extracalif" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "ciclos" Then
            variables.dt = variables.conexion.getDataSet("select * from ciclo_escolar order by IDCICLOESCOLAR")
        End If
        If variables.banderaAccion = "alumnos" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "interno" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "preregistro" Then
            variables.dt = variables.conexion.getDataSet("select apellido_paterno,apellido_materno,nombre,curp,campus,licenciatura,id from preregistro where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "inscripcion" Then
            variables.dt = variables.conexion.getDataSet("select apellido_paterno,apellido_materno,nombre,curp,campus,licenciatura,id from preregistro where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%' AND vino_ceneval=1 ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "RPinscripcion" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "actualizaFoto" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "preregistro1" Then
            variables.dt = variables.conexion.getDataSet("select apellido_paterno,apellido_materno,nombre,curp,campus,licenciatura,id from preregistro where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
        If variables.banderaAccion = "certificados" Then
            variables.dt = variables.conexion.getDataSet("select * from alumno where (nombre + ' ' + apellido_paterno + ' ' + apellido_materno) like '%" + busqueda + "%'  ORDER BY apellido_paterno,apellido_materno,nombre")
        End If
    End Sub
    Public Sub leerXmlConfig(ByVal t1 As TextBox, ByVal t2 As TextBox, ByVal t3 As TextBox, ByVal t4 As TextBox)
        Dim m_xmlr As XmlTextReader
        'Create the XML Reader
        m_xmlr = New XmlTextReader("configuracion.xml")
        'Disable whitespace so that you don't have to read over whitespaces
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        'read the xml declaration and advance to family tag
        m_xmlr.Read()
        'read the family tag
        m_xmlr.Read()
        'Load the Loop
        While Not m_xmlr.EOF
            'Go to the name tag
            m_xmlr.Read()
            'if not start element exit while loop
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            'Get the Gender Attribute Value
            Dim conexion = m_xmlr.GetAttribute("conexion")
            m_xmlr.Read()
            t1.Text = m_xmlr.ReadElementString("server")
            t2.Text = m_xmlr.ReadElementString("database")
            t3.Text = m_xmlr.ReadElementString("user")
            t4.Text = m_xmlr.ReadElementString("pass")

        End While
        'close the reader
        m_xmlr.Close()
    End Sub

    Public Sub guardarAlumno(ByVal modelo As modelos.modeloAlumno)

        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO alumno(NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,GENERO,CALLE," & _
                "NUMERO_EXTERIOR,NUMERO_INTERIOR,COLONIA,IDMUNICIPIO,IDESTADO,CODIGO_POSTAL,CURP,TELEFONO_CASA,TELEFONO_CEL," & _
                "CORREO_ELECTRONICO, FECHA_NACIMIENTO,FECHA_INGRESO,FECHA_SALIDA,TIPO_SANGRE,OBSERVACIONES,CONTACTO_EMERGENCIA," & _
                "TELEFONO_EMERGENCIA,MATRICULA,IDCAMPUS,IDturno,IDSTATUS,IDAREA,IDMODALIDAD,IDESPECIALIDAD,IDSEMESTRE," & _
                "IDGRUPO,IDLICENCIATURA,FOTO,PLANEST,GENERACION,BECA,NO_SS,ADEUDO_LIBROS,PUNTAJECENEVAL,PROMEDIObACHILLERATO," & _
                "BACHILLERATOPROCEDENCIA,ADEUDO_MATERIAL,SECUNDARIAPROCEDENCIA,CLINICA_IMSS,TIENE_DISCAPACIDAD," & _
                "TIPO_DISCAPACIDAD,DISCAPACIDAD_OBSERV,CLINICA_DIRECCION,ESCUELA_PRACTICA,LUGAR_NACIMIENTO,NOMBRE_PAPA,NOMBRE_MAMA,USUARIO)" & _
                         "VALUES(@NOMBRE,@APELLIDO_PATERNO,@APELLIDO_MATERNO,@GENERO,@CALLE," & _
                "@NUMERO_EXTERIOR,@NUMERO_INTERIOR,@COLONIA,@IDMUNICIPIO,@IDESTADO,@CODIGO_POSTAL,@CURP,@TELEFONO_CASA,@TELEFONO_CEL," & _
                "@CORREO_ELECTRONICO,@FECHA_NACIMIENTO,@FECHA_INGRESO,@FECHA_SALIDA,@TIPO_SANGRE,@OBSERVACIONES,@CONTACTO_EMERGENCIA," & _
                "@TELEFONO_EMERGENCIA,@MATRICULA,@IDCAMPUS,@IDturno,@IDSTATUS,@IDAREA,@IDMODALIDAD,@IDESPECIALIDAD,@IDSEMESTRE," & _
                "@IDGRUPO,@IDLICENCIATURA,@FOTO,@PLANEST,@GENERACION,@BECA,@NO_SS,@ADEUDO_LIBROS,@PUNTAJECENEVAL,@PROMEDIObACHILLERATO," & _
                "@BACHILLERATOPROCEDENCIA,@ADEUDO_MATERIAL,@SECUNDARIAPROCEDENCIA,@CLINICA_IMSS,@TIENE_DISCAPACIDAD," & _
                "@TIPO_DISCAPACIDAD,@DISCAPACIDAD_OBSERV,@CLINICA_DIRECCION,@ESCUELA_PRACTICA,@LUGAR_NACIMIENTO,@NOMBRE_PAPA,@NOMBRE_MAMA,@USUARIO)"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@APELLIDO_PATERNO", modelo.APELLIDO_PATERNO)
                .Parameters.AddWithValue("@APELLIDO_MATERNO", modelo.APELLIDO_MATERNO)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@GENERO", modelo.GENERO)
                .Parameters.AddWithValue("@NUMERO_EXTERIOR", modelo.NUMERO_EXTERIOR)
                .Parameters.AddWithValue("@NUMERO_INTERIOR", modelo.NUMERO_INTERIOR)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@IDMUNICIPIO", modelo.IDMUNICIPIO)
                .Parameters.AddWithValue("@IDESTADO", modelo.IDESTADO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@TELEFONO_CASA", modelo.TELEFONO_CASA)
                .Parameters.AddWithValue("@TELEFONO_CEL", modelo.TELEFONO_CEL)
                .Parameters.AddWithValue("@CORREO_ELECTRONICO", modelo.CORREO_ELECTRONICO)
                .Parameters.AddWithValue("@FECHA_NACIMIENTO", modelo.FECHA_NACIMIENTO)
                .Parameters.AddWithValue("@FECHA_INGRESO", modelo.FECHA_INGRESO)
                .Parameters.AddWithValue("@FECHA_SALIDA", modelo.FECHA_SALIDA)
                .Parameters.AddWithValue("@TIPO_SANGRE", modelo.TIPO_SANGRE)
                .Parameters.AddWithValue("@OBSERVACIONES", modelo.OBSERVACIONES)
                .Parameters.AddWithValue("@CONTACTO_EMERGENCIA", modelo.CONTACTO_EMERGENCIA)
                .Parameters.AddWithValue("@TELEFONO_EMERGENCIA", modelo.TELEFONO_EMERGENCIA)
                .Parameters.AddWithValue("@MATRICULA", modelo.MATRICULA)
                .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
                .Parameters.AddWithValue("@IDturno", modelo.IDturno)
                .Parameters.AddWithValue("@IDSTATUS", modelo.IDSTATUS)
                .Parameters.AddWithValue("@IDAREA", modelo.IDAREA)
                .Parameters.AddWithValue("@IDMODALIDAD", modelo.IDMODALIDAD)
                .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
                .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
                .Parameters.AddWithValue("@IDGRUPO", modelo.IDGRUPO)
                .Parameters.AddWithValue("@IDLICENCIATURA", modelo.IDLICENCIATURA)
                .Parameters.AddWithValue("@FOTO", modelo.FOTO)
                .Parameters.AddWithValue("@PLANEST", modelo.PLANEST)
                .Parameters.AddWithValue("@GENERACION", modelo.GENERACION)
                .Parameters.AddWithValue("@BECA", modelo.BECA)
                .Parameters.AddWithValue("@NO_SS", modelo.NO_SS)
                .Parameters.AddWithValue("@ADEUDO_LIBROS", modelo.ADEUDO_LIBROS)
                .Parameters.AddWithValue("@PUNTAJECENEVAL", modelo.PUNTAJECENEVAL)
                .Parameters.AddWithValue("@PROMEDIObACHILLERATO", modelo.PROMEDIObACHILLERATO)
                .Parameters.AddWithValue("@BACHILLERATOPROCEDENCIA", modelo.BACHILLERATOPROCEDENCIA)
                .Parameters.AddWithValue("@ADEUDO_MATERIAL", modelo.ADEUDO_MATERIAL)
                .Parameters.AddWithValue("@SECUNDARIAPROCEDENCIA", modelo.SECUNDARIAPROCEDENCIA)
                .Parameters.AddWithValue("@CLINICA_IMSS", modelo.CLINICA_IMSS)
                .Parameters.AddWithValue("@TIENE_DISCAPACIDAD", modelo.TIENE_DISCAPACIDAD)
                .Parameters.AddWithValue("@TIPO_DISCAPACIDAD", modelo.TIPO_DISCAPACIDAD)
                .Parameters.AddWithValue("@DISCAPACIDAD_OBSERV", modelo.DISCAPACIDAD_OBSERV)
                .Parameters.AddWithValue("@CLINICA_DIRECCION", modelo.CLINICA_DIRECCION)
                .Parameters.AddWithValue("@ESCUELA_PRACTICA", modelo.ESCUELA_PRACTICA)
                .Parameters.AddWithValue("@LUGAR_NACIMIENTO", modelo.LUGAR_NACIMIENTO)
                .Parameters.AddWithValue("@NOMBRE_PAPA", modelo.NOMBRE_PAPA)
                .Parameters.AddWithValue("@NOMBRE_MAMA", modelo.NOMBRE_MAMA)
                .Parameters.AddWithValue("@USUARIO", modelo.usuario)

            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarAlumno(ByVal modelo As modelos.modeloAlumno)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE alumno SET NOMBRE=@NOMBRE,APELLIDO_PATERNO=@APELLIDO_PATERNO," & _
                "APELLIDO_MATERNO=@APELLIDO_MATERNO,GENERO=@GENERO,CALLE=@CALLE," & _
               "NUMERO_EXTERIOR=@NUMERO_EXTERIOR,NUMERO_INTERIOR=@NUMERO_INTERIOR,COLONIA=@COLONIA," & _
               "IDMUNICIPIO=@IDMUNICIPIO,IDESTADO=@IDESTADO,CODIGO_POSTAL=@CODIGO_POSTAL,CURP=@CURP," & _
               "TELEFONO_CASA=@TELEFONO_CASA,TELEFONO_CEL=@TELEFONO_CEL," & _
               "CORREO_ELECTRONICO=@CORREO_ELECTRONICO, FECHA_NACIMIENTO=@FECHA_NACIMIENTO,FECHA_INGRESO=@FECHA_INGRESO," & _
               "FECHA_SALIDA=@FECHA_SALIDA,TIPO_SANGRE=@TIPO_SANGRE,OBSERVACIONES=@OBSERVACIONES," & _
               "CONTACTO_EMERGENCIA=@CONTACTO_EMERGENCIA,TELEFONO_EMERGENCIA=@TELEFONO_EMERGENCIA," & _
               "MATRICULA=@MATRICULA,IDCAMPUS=@IDCAMPUS,IDturno=@IDturno,IDSTATUS=@IDSTATUS,IDAREA=@IDAREA," & _
               "IDMODALIDAD=@IDMODALIDAD,IDESPECIALIDAD=@IDESPECIALIDAD,IDSEMESTRE=@IDSEMESTRE," & _
               "IDGRUPO=@IDGRUPO,IDLICENCIATURA=@IDLICENCIATURA,FOTO=@FOTO,PLANEST=@PLANEST,GENERACION=@GENERACION," & _
               "BECA=@BECA,NO_SS=@NO_SS,ADEUDO_LIBROS=@ADEUDO_LIBROS,PUNTAJECENEVAL=@PUNTAJECENEVAL," & _
               "PROMEDIObACHILLERATO=@PROMEDIObACHILLERATO,BACHILLERATOPROCEDENCIA=@BACHILLERATOPROCEDENCIA," & _
               "ADEUDO_MATERIAL=@ADEUDO_MATERIAL,SECUNDARIAPROCEDENCIA=@SECUNDARIAPROCEDENCIA,CLINICA_IMSS=@CLINICA_IMSS, " & _
               "TIENE_DISCAPACIDAD=@TIENE_DISCAPACIDAD,TIPO_DISCAPACIDAD=@TIPO_DISCAPACIDAD,DISCAPACIDAD_OBSERV=@DISCAPACIDAD_OBSERV, " & _
               "CLINICA_DIRECCION=@CLINICA_DIRECCION,ESCUELA_PRACTICA=@ESCUELA_PRACTICA," & _
               "LUGAR_NACIMIENTO=@LUGAR_NACIMIENTO,NOMBRE_PAPA=@NOMBRE_PAPA,NOMBRE_MAMA=@NOMBRE_MAMA,USUARIO=@USUARIO WHERE IDALUMNO=@IDALUMNO"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@APELLIDO_PATERNO", modelo.APELLIDO_PATERNO)
                .Parameters.AddWithValue("@APELLIDO_MATERNO", modelo.APELLIDO_MATERNO)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@GENERO", modelo.GENERO)
                .Parameters.AddWithValue("@NUMERO_EXTERIOR", modelo.NUMERO_EXTERIOR)
                .Parameters.AddWithValue("@NUMERO_INTERIOR", modelo.NUMERO_INTERIOR)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@IDMUNICIPIO", modelo.IDMUNICIPIO)
                .Parameters.AddWithValue("@IDESTADO", modelo.IDESTADO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@TELEFONO_CASA", modelo.TELEFONO_CASA)
                .Parameters.AddWithValue("@TELEFONO_CEL", modelo.TELEFONO_CEL)
                .Parameters.AddWithValue("@CORREO_ELECTRONICO", modelo.CORREO_ELECTRONICO)
                .Parameters.AddWithValue("@FECHA_NACIMIENTO", modelo.FECHA_NACIMIENTO)
                .Parameters.AddWithValue("@FECHA_INGRESO", modelo.FECHA_INGRESO)
                .Parameters.AddWithValue("@FECHA_SALIDA", modelo.FECHA_SALIDA)
                .Parameters.AddWithValue("@TIPO_SANGRE", modelo.TIPO_SANGRE)
                .Parameters.AddWithValue("@OBSERVACIONES", modelo.OBSERVACIONES)
                .Parameters.AddWithValue("@CONTACTO_EMERGENCIA", modelo.CONTACTO_EMERGENCIA)
                .Parameters.AddWithValue("@TELEFONO_EMERGENCIA", modelo.TELEFONO_EMERGENCIA)
                .Parameters.AddWithValue("@MATRICULA", modelo.MATRICULA)
                .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
                .Parameters.AddWithValue("@IDturno", modelo.IDturno)
                .Parameters.AddWithValue("@IDSTATUS", modelo.IDSTATUS)
                .Parameters.AddWithValue("@IDAREA", modelo.IDAREA)
                .Parameters.AddWithValue("@IDMODALIDAD", modelo.IDMODALIDAD)
                .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
                .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
                .Parameters.AddWithValue("@IDGRUPO", modelo.IDGRUPO)
                .Parameters.AddWithValue("@IDLICENCIATURA", modelo.IDLICENCIATURA)
                .Parameters.AddWithValue("@FOTO", modelo.FOTO)
                .Parameters.AddWithValue("@PLANEST", modelo.PLANEST)
                .Parameters.AddWithValue("@GENERACION", modelo.GENERACION)
                .Parameters.AddWithValue("@BECA", modelo.BECA)
                .Parameters.AddWithValue("@NO_SS", modelo.NO_SS)
                .Parameters.AddWithValue("@ADEUDO_LIBROS", modelo.ADEUDO_LIBROS)
                .Parameters.AddWithValue("@PUNTAJECENEVAL", modelo.PUNTAJECENEVAL)
                .Parameters.AddWithValue("@PROMEDIObACHILLERATO", modelo.PROMEDIObACHILLERATO)
                .Parameters.AddWithValue("@BACHILLERATOPROCEDENCIA", modelo.BACHILLERATOPROCEDENCIA)
                .Parameters.AddWithValue("@ADEUDO_MATERIAL", modelo.ADEUDO_MATERIAL)
                .Parameters.AddWithValue("@SECUNDARIAPROCEDENCIA", modelo.SECUNDARIAPROCEDENCIA)
                .Parameters.AddWithValue("@CLINICA_IMSS", modelo.CLINICA_IMSS)
                .Parameters.AddWithValue("@TIENE_DISCAPACIDAD", modelo.TIENE_DISCAPACIDAD)
                .Parameters.AddWithValue("@TIPO_DISCAPACIDAD", modelo.TIPO_DISCAPACIDAD)
                .Parameters.AddWithValue("@DISCAPACIDAD_OBSERV", modelo.DISCAPACIDAD_OBSERV)
                .Parameters.AddWithValue("@IDALUMNO", modelo.IDALUMNO)
                .Parameters.AddWithValue("@CLINICA_DIRECCION", modelo.CLINICA_DIRECCION)
                .Parameters.AddWithValue("@ESCUELA_PRACTICA", modelo.ESCUELA_PRACTICA)
                .Parameters.AddWithValue("@LUGAR_NACIMIENTO", modelo.LUGAR_NACIMIENTO)
                .Parameters.AddWithValue("@NOMBRE_PAPA", modelo.NOMBRE_PAPA)
                .Parameters.AddWithValue("@NOMBRE_MAMA", modelo.NOMBRE_MAMA)
                .Parameters.AddWithValue("@USUARIO", modelo.usuario)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
            '=====================| alta de foto |==========================================
        Catch exc As Exception
            Throw exc
        End Try

    End Sub
    Public Function traerCampus(ByVal campus As String) As modelos.modeloCampus
        Dim modelo As New modelos.modeloCampus
        Try
            variables.conexion.abrirConexion()
            variables.sql = "select * from campus where nombre like '%" & Mid(campus, 1, 4) & "%'"
            Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
            variables.SQLdr = cmd.ExecuteReader()

            While (variables.SQLdr.Read())
                modelo.CALLE = variables.SQLdr("CALLE").ToString
                modelo.CCT = variables.SQLdr("CCT").ToString
                modelo.CODIGO_POSTAL = variables.SQLdr("CODIGO_POSTAL").ToString
                modelo.COLONIA = variables.SQLdr("COLONIA").ToString
                modelo.IDCAMPUS = variables.SQLdr("IDCAMPUS").ToString
                modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
                modelo.NUMERO = variables.SQLdr("NUMERO").ToString
                modelo.TELEFONO = variables.SQLdr("TELEFONO").ToString
                modelo.MUNICIPIO = variables.SQLdr("MUNICIPIO").ToString
                Exit While
            End While
            variables.conexion.cerrarConexion()
            Return modelo
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            variables.conexion.cerrarConexion()
        End Try
    End Function
    Public Sub CopiarArchivo(ByVal ArchivoOrigen As String, ByVal ArchivoDestino As String)
        Dim Capturista As String = ""
        Dim TipoMedio As String = ""
        Dim Ambito As String = ""
        Dim TipoPrensa As String = ""
        Dim Nombre As String = ""

        Dim ImagenBD As String = ""
        Using source As New IO.FileStream(ArchivoOrigen, IO.FileMode.Open)
            Using target As New IO.FileStream(ArchivoDestino, IO.FileMode.Create)
                Const BUFFER_SIZE As Integer = 1024
                Dim buffer(BUFFER_SIZE - 1) As Byte
                Dim bytesRead As Integer = source.Read(buffer, 0, BUFFER_SIZE)

                While bytesRead > 0
                    target.Write(buffer, 0, bytesRead)
                    bytesRead = source.Read(buffer, 0, BUFFER_SIZE)
                End While

                target.Close()
            End Using

            source.Close()
        End Using
    End Sub
    Public Sub inscribirAlumno(ByVal modelo As modelos.modeloAlumno)

        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO alumno(NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,GENERO,CALLE," & _
                "NUMERO_EXTERIOR,NUMERO_INTERIOR,COLONIA,IDMUNICIPIO,IDESTADO,CODIGO_POSTAL,CURP,TELEFONO_CASA,TELEFONO_CEL," & _
                "CORREO_ELECTRONICO, FECHA_NACIMIENTO,FECHA_INGRESO,FECHA_SALIDA,TIPO_SANGRE,OBSERVACIONES,CONTACTO_EMERGENCIA," & _
                "TELEFONO_EMERGENCIA,MATRICULA,IDCAMPUS,IDturno,IDSTATUS,IDAREA,IDMODALIDAD,IDESPECIALIDAD,IDSEMESTRE," & _
                "IDGRUPO,IDLICENCIATURA,PLANEST,GENERACION,BECA,NO_SS,ADEUDO_LIBROS,PUNTAJECENEVAL,PROMEDIObACHILLERATO," & _
                "BACHILLERATOPROCEDENCIA,SECUNDARIAPROCEDENCIA,LUGAR_NACIMIENTO,NOMBRE_PAPA,NOMBRE_MAMA,CICLOESCOLAR,SMCuenta,becaActual,usuario)" & _
                         "VALUES(@NOMBRE,@APELLIDO_PATERNO,@APELLIDO_MATERNO,@GENERO,@CALLE," & _
                "@NUMERO_EXTERIOR,@NUMERO_INTERIOR,@COLONIA,@IDMUNICIPIO,@IDESTADO,@CODIGO_POSTAL,@CURP,@TELEFONO_CASA,@TELEFONO_CEL," & _
                "@CORREO_ELECTRONICO,@FECHA_NACIMIENTO,@FECHA_INGRESO,@FECHA_SALIDA,@TIPO_SANGRE,@OBSERVACIONES,@CONTACTO_EMERGENCIA," & _
                "@TELEFONO_EMERGENCIA,@MATRICULA,@IDCAMPUS,@IDturno,@IDSTATUS,@IDAREA,@IDMODALIDAD,@IDESPECIALIDAD,@IDSEMESTRE," & _
                "@IDGRUPO,@IDLICENCIATURA,@PLANEST,@GENERACION,@BECA,@NO_SS,@ADEUDO_LIBROS,@PUNTAJECENEVAL,@PROMEDIObACHILLERATO," & _
                "@BACHILLERATOPROCEDENCIA,@SECUNDARIAPROCEDENCIA,@LUGAR_NACIMIENTO,@NOMBRE_PAPA,@NOMBRE_MAMA,@CICLOESCOLAR,@SMCuenta,@becaActual,@usuario)"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@APELLIDO_PATERNO", modelo.APELLIDO_PATERNO)
                .Parameters.AddWithValue("@APELLIDO_MATERNO", modelo.APELLIDO_MATERNO)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@GENERO", modelo.GENERO)
                .Parameters.AddWithValue("@NUMERO_EXTERIOR", modelo.NUMERO_EXTERIOR)
                .Parameters.AddWithValue("@NUMERO_INTERIOR", modelo.NUMERO_INTERIOR)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@IDMUNICIPIO", modelo.IDMUNICIPIO)
                .Parameters.AddWithValue("@IDESTADO", modelo.IDESTADO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@TELEFONO_CASA", modelo.TELEFONO_CASA)
                .Parameters.AddWithValue("@TELEFONO_CEL", modelo.TELEFONO_CEL)
                .Parameters.AddWithValue("@CORREO_ELECTRONICO", modelo.CORREO_ELECTRONICO)
                .Parameters.AddWithValue("@FECHA_NACIMIENTO", modelo.FECHA_NACIMIENTO)
                .Parameters.AddWithValue("@FECHA_INGRESO", modelo.FECHA_INGRESO)
                .Parameters.AddWithValue("@FECHA_SALIDA", modelo.FECHA_SALIDA)
                .Parameters.AddWithValue("@TIPO_SANGRE", modelo.TIPO_SANGRE)
                .Parameters.AddWithValue("@OBSERVACIONES", "")
                .Parameters.AddWithValue("@CONTACTO_EMERGENCIA", modelo.CONTACTO_EMERGENCIA)
                .Parameters.AddWithValue("@TELEFONO_EMERGENCIA", modelo.TELEFONO_EMERGENCIA)
                .Parameters.AddWithValue("@MATRICULA", modelo.MATRICULA)
                .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
                .Parameters.AddWithValue("@IDturno", modelo.IDturno)
                .Parameters.AddWithValue("@IDSTATUS", modelo.IDSTATUS)
                .Parameters.AddWithValue("@IDAREA", modelo.IDAREA)
                .Parameters.AddWithValue("@IDMODALIDAD", modelo.IDMODALIDAD)
                .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
                .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
                .Parameters.AddWithValue("@IDGRUPO", modelo.IDGRUPO)
                .Parameters.AddWithValue("@IDLICENCIATURA", modelo.IDLICENCIATURA)
                .Parameters.AddWithValue("@PLANEST", modelo.PLANEST)
                .Parameters.AddWithValue("@GENERACION", modelo.GENERACION)
                .Parameters.AddWithValue("@BECA", "")
                .Parameters.AddWithValue("@NO_SS", "")
                .Parameters.AddWithValue("@ADEUDO_LIBROS", "")
                .Parameters.AddWithValue("@PUNTAJECENEVAL", modelo.PUNTAJECENEVAL)
                .Parameters.AddWithValue("@PROMEDIObACHILLERATO", modelo.PROMEDIObACHILLERATO)
                .Parameters.AddWithValue("@BACHILLERATOPROCEDENCIA", modelo.BACHILLERATOPROCEDENCIA)
                .Parameters.AddWithValue("@SECUNDARIAPROCEDENCIA", modelo.SECUNDARIAPROCEDENCIA)
                .Parameters.AddWithValue("@LUGAR_NACIMIENTO", modelo.LUGAR_NACIMIENTO)
                .Parameters.AddWithValue("@NOMBRE_PAPA", modelo.NOMBRE_PAPA)
                .Parameters.AddWithValue("@NOMBRE_MAMA", modelo.NOMBRE_MAMA)
                .Parameters.AddWithValue("@CICLOESCOLAR", modelo.CICLOESCOLAR)
                .Parameters.AddWithValue("@SMCuenta", modelo.SMCuenta)
                .Parameters.AddWithValue("@becaActual", modelo.becaActual)
                .Parameters.AddWithValue("@usuario", modelo.usuario)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
            Exit Sub
        End Try
    End Sub
    Public Sub ActualizarinscripcionAlumno(ByVal modelo As modelos.modeloAlumno)

        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE alumno SET NOMBRE=@NOMBRE,APELLIDO_PATERNO=@APELLIDO_PATERNO,APELLIDO_MATERNO=@APELLIDO_MATERNO,GENERO=@GENERO,CALLE=@CALLE," & _
                "NUMERO_EXTERIOR=@NUMERO_EXTERIOR,NUMERO_INTERIOR=@NUMERO_INTERIOR,COLONIA=@COLONIA,IDMUNICIPIO=@IDMUNICIPIO,IDESTADO=@IDESTADO,CODIGO_POSTAL=@CODIGO_POSTAL," & _
                "CURP=@CURP,TELEFONO_CASA=@TELEFONO_CASA,TELEFONO_CEL=@TELEFONO_CEL," & _
                "CORREO_ELECTRONICO=@CORREO_ELECTRONICO, FECHA_NACIMIENTO=@FECHA_NACIMIENTO,FECHA_INGRESO=@FECHA_INGRESO,FECHA_SALIDA=@FECHA_SALIDA,TIPO_SANGRE=@TIPO_SANGRE," & _
                "OBSERVACIONES=@OBSERVACIONES,CONTACTO_EMERGENCIA=@CONTACTO_EMERGENCIA," & _
                "TELEFONO_EMERGENCIA=@TELEFONO_EMERGENCIA,MATRICULA=@MATRICULA,IDCAMPUS=@IDCAMPUS,IDturno=@IDTURNO,IDSTATUS=@IDSTATUS,IDAREA=@IDAREA,IDMODALIDAD=@IDMODALIDAD," & _
                "IDESPECIALIDAD=@IDESPECIALIDAD,IDSEMESTRE=@IDSEMESTRE," & _
                "IDGRUPO=@IDGRUPO,IDLICENCIATURA=@IDLICENCIATURA,PLANEST=@PLANEST,GENERACION=@GENERACION,BECA=@BECA,NO_SS=@NO_SS,ADEUDO_LIBROS=@ADEUDO_LIBROS,PUNTAJECENEVAL=@PUNTAJECENEVAL," & _
                "PROMEDIObACHILLERATO=@PROMEDIOBACHILLERATO," & _
                "BACHILLERATOPROCEDENCIA=@BACHILLERATOPROCEDENCIA,SECUNDARIAPROCEDENCIA=@SECUNDARIAPROCEDENCIA,LUGAR_NACIMIENTO=@LUGAR_NACIMIENTO,NOMBRE_PAPA=@NOMBRE_PAPA,NOMBRE_MAMA=@NOMBRE_MAMA," & _
                "CICLOESCOLAR=@CICLOESCOLAR,SMCuenta=@SMCUENTA,becaActual=@BECAACTUAL,usuario=@USUARIO WHERE IDALUMNO=@IDalumno"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
                .Parameters.AddWithValue("@APELLIDO_PATERNO", modelo.APELLIDO_PATERNO)
                .Parameters.AddWithValue("@APELLIDO_MATERNO", modelo.APELLIDO_MATERNO)
                .Parameters.AddWithValue("@CALLE", modelo.CALLE)
                .Parameters.AddWithValue("@GENERO", modelo.GENERO)
                .Parameters.AddWithValue("@NUMERO_EXTERIOR", modelo.NUMERO_EXTERIOR)
                .Parameters.AddWithValue("@NUMERO_INTERIOR", modelo.NUMERO_INTERIOR)
                .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
                .Parameters.AddWithValue("@IDMUNICIPIO", modelo.IDMUNICIPIO)
                .Parameters.AddWithValue("@IDESTADO", modelo.IDESTADO)
                .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
                .Parameters.AddWithValue("@CURP", modelo.CURP)
                .Parameters.AddWithValue("@TELEFONO_CASA", modelo.TELEFONO_CASA)
                .Parameters.AddWithValue("@TELEFONO_CEL", modelo.TELEFONO_CEL)
                .Parameters.AddWithValue("@CORREO_ELECTRONICO", modelo.CORREO_ELECTRONICO)
                .Parameters.AddWithValue("@FECHA_NACIMIENTO", modelo.FECHA_NACIMIENTO)
                .Parameters.AddWithValue("@FECHA_INGRESO", modelo.FECHA_INGRESO)
                .Parameters.AddWithValue("@FECHA_SALIDA", modelo.FECHA_SALIDA)
                .Parameters.AddWithValue("@TIPO_SANGRE", modelo.TIPO_SANGRE)
                .Parameters.AddWithValue("@OBSERVACIONES", "")
                .Parameters.AddWithValue("@CONTACTO_EMERGENCIA", modelo.CONTACTO_EMERGENCIA)
                .Parameters.AddWithValue("@TELEFONO_EMERGENCIA", modelo.TELEFONO_EMERGENCIA)
                .Parameters.AddWithValue("@MATRICULA", modelo.MATRICULA)
                .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
                .Parameters.AddWithValue("@IDturno", modelo.IDturno)
                .Parameters.AddWithValue("@IDSTATUS", modelo.IDSTATUS)
                .Parameters.AddWithValue("@IDALUMNO", variables.idalumno)
                .Parameters.AddWithValue("@IDAREA", modelo.IDAREA)
                .Parameters.AddWithValue("@IDMODALIDAD", modelo.IDMODALIDAD)
                .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
                .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
                .Parameters.AddWithValue("@IDGRUPO", modelo.IDGRUPO)
                .Parameters.AddWithValue("@IDLICENCIATURA", modelo.IDLICENCIATURA)
                .Parameters.AddWithValue("@PLANEST", modelo.PLANEST)
                .Parameters.AddWithValue("@GENERACION", modelo.GENERACION)
                .Parameters.AddWithValue("@BECA", "")
                .Parameters.AddWithValue("@NO_SS", "")
                .Parameters.AddWithValue("@ADEUDO_LIBROS", "")
                .Parameters.AddWithValue("@PUNTAJECENEVAL", modelo.PUNTAJECENEVAL)
                .Parameters.AddWithValue("@PROMEDIObACHILLERATO", modelo.PROMEDIObACHILLERATO)
                .Parameters.AddWithValue("@BACHILLERATOPROCEDENCIA", modelo.BACHILLERATOPROCEDENCIA)
                .Parameters.AddWithValue("@SECUNDARIAPROCEDENCIA", modelo.SECUNDARIAPROCEDENCIA)
                .Parameters.AddWithValue("@LUGAR_NACIMIENTO", modelo.LUGAR_NACIMIENTO)
                .Parameters.AddWithValue("@NOMBRE_PAPA", modelo.NOMBRE_PAPA)
                .Parameters.AddWithValue("@NOMBRE_MAMA", modelo.NOMBRE_MAMA)
                .Parameters.AddWithValue("@CICLOESCOLAR", modelo.CICLOESCOLAR)
                .Parameters.AddWithValue("@SMCuenta", modelo.SMCuenta)
                .Parameters.AddWithValue("@becaActual", modelo.becaActual)
                .Parameters.AddWithValue("@usuario", modelo.usuario)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
            Exit Sub
        End Try
    End Sub
    Public Sub almacenarFormatoIMSS(ByVal modelo As modelos.modeloIMSS)

        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO alumnoSeguro(idAlumno,fecha,clavePlantel,nivelEducativo,registroIMSS," & _
                "ESTUDIAS_TRABAJAS,DEPENDES_ECONOMICA,TRABAJA_DEPENDES,ESTA_PROTEGIDO_SS,INSTITUCION_PRO_SS,RESPONSABLE)" & _
                         "VALUES(@idAlumno,@fecha,@clavePlantel,@nivelEducativo,@registroIMSS," & _
                "@ESTUDIAS_TRABAJAS,@DEPENDES_ECONOMICA,@TRABAJA_DEPENDES,@ESTA_PROTEGIDO_SS,@INSTITUCION_PRO_SS,@RESPONSABLE)"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@idAlumno", modelo.idAlumno)
                .Parameters.AddWithValue("@fecha", modelo.fecha)
                .Parameters.AddWithValue("@clavePlantel", modelo.clavePlantel)
                .Parameters.AddWithValue("@nivelEducativo", modelo.nivelEducativo)
                .Parameters.AddWithValue("@registroIMSS", modelo.registroIMSS)
                .Parameters.AddWithValue("@ESTUDIAS_TRABAJAS", modelo.ESTUDIAS_TRABAJAS)
                .Parameters.AddWithValue("@DEPENDES_ECONOMICA", modelo.DEPENDES_ECONOMICA)
                .Parameters.AddWithValue("@TRABAJA_DEPENDES", modelo.TRABAJA_DEPENDES)
                .Parameters.AddWithValue("@ESTA_PROTEGIDO_SS", modelo.ESTA_PROTEGIDO_SS)
                .Parameters.AddWithValue("@INSTITUCION_PRO_SS", modelo.INSTITUCION_PRO_SS)
                .Parameters.AddWithValue("@RESPONSABLE", modelo.RESPONSABLE)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub almacenarAlumnoDocumentos(ByVal modelo As modelos.modeloAlumnoDocumentosInscripcion)

        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "INSERT INTO alumnoDocumentos(actaOriginal,actaCopia,actaObservaciones,curpOriginal,curpCopia," & _
                "curpObservaciones,certificadoOriginal,certificadoCopia,certificadoObservaciones,domicilioOriginal,domicilioCopia," & _
                "domicilioObservaciones,medicoOriginal,medicoCopia,medicoObservaciones,fotosOriginal,fotosObservaciones," & _
                "pagoOriginal,pagoCopia,pagoObservaciones,idAlumno,idUsuario,faltaActa,faltaCurp,faltaCertificado,faltaDomicilio,faltaMedico,faltaFotos,faltaPago)" & _
                         "VALUES(@actaOriginal,@actaCopia,@actaObservaciones,@curpOriginal,@curpCopia," & _
                "@curpObservaciones,@certificadoOriginal,@certificadoCopia,@certificadoObservaciones,@domicilioOriginal,@domicilioCopia," & _
                "@domicilioObservaciones,@medicoOriginal,@medicoCopia,@medicoObservaciones,@fotosOriginal,@fotosObservaciones," & _
                "@pagoOriginal,@pagoCopia,@pagoObservaciones,@idAlumno,@idUsuario,@faltaActa,@faltaCurp,@faltaCertificado,@faltaDomicilio,@faltaMedico,@faltaFotos,@faltaPago)"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@actaOriginal", modelo.actaOriginal)
                .Parameters.AddWithValue("@actaCopia", modelo.actaCopia)
                .Parameters.AddWithValue("@actaObservaciones", modelo.actaObservaciones)
                .Parameters.AddWithValue("@curpOriginal", modelo.curpOriginal)
                .Parameters.AddWithValue("@curpCopia", modelo.curpCopia)
                .Parameters.AddWithValue("@curpObservaciones", modelo.curpObservaciones)
                .Parameters.AddWithValue("@certificadoOriginal", modelo.certificadoOriginal)
                .Parameters.AddWithValue("@certificadoCopia", modelo.certificadoCopia)
                .Parameters.AddWithValue("@certificadoObservaciones", modelo.certificadoObservaciones)
                .Parameters.AddWithValue("@domicilioOriginal", modelo.domicilioOriginal)
                .Parameters.AddWithValue("@domicilioCopia", modelo.domicilioCopia)
                .Parameters.AddWithValue("@domicilioObservaciones", modelo.domicilioObservaciones)
                .Parameters.AddWithValue("@medicoOriginal", modelo.medicoOriginal)
                .Parameters.AddWithValue("@medicoCopia", modelo.medicoCopia)
                .Parameters.AddWithValue("@medicoObservaciones", modelo.medicoObservaciones)
                .Parameters.AddWithValue("@fotosOriginal", modelo.fotosOriginal)
                .Parameters.AddWithValue("@fotosObservaciones", modelo.fotosObservaciones)
                .Parameters.AddWithValue("@pagoOriginal", modelo.pagoOriginal)
                .Parameters.AddWithValue("@pagoCopia", modelo.pagoCopia)
                .Parameters.AddWithValue("@pagoObservaciones", modelo.pagoObservaciones)
                .Parameters.AddWithValue("@idAlumno", modelo.idAlumno)
                .Parameters.AddWithValue("@idUsuario", modelo.idUsuario)
                .Parameters.AddWithValue("@faltaActa", modelo.faltaActa)
                .Parameters.AddWithValue("@faltaCurp", modelo.faltaCurp)
                .Parameters.AddWithValue("@faltaCertificado", modelo.faltaCertificado)
                .Parameters.AddWithValue("@faltaDomicilio", modelo.faltaDomicilio)
                .Parameters.AddWithValue("@faltaMedico", modelo.faltaMedico)
                .Parameters.AddWithValue("@faltaFotos", modelo.faltaFotos)
                .Parameters.AddWithValue("@faltaPago", modelo.faltaPago)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
    Public Sub actualizarAlumnoDocumentos(ByVal modelo As modelos.modeloAlumnoDocumentosInscripcion)

        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE alumnoDocumentos set actaOriginal = @actaOriginal, actaCopia=@actaCopia, actaObservaciones = @actaObservaciones," & _
                                "curpOriginal = @curpOriginal, curpCopia=@curpCopia, curpObservaciones = @curpObservaciones," & _
                                "certificadoOriginal = @certificadoOriginal, certificadoCopia=@certificadoCopia, certificadoObservaciones = @certificadoObservaciones," & _
                                "domicilioOriginal = @domicilioOriginal, domicilioCopia=@domicilioCopia, domicilioObservaciones = @domicilioObservaciones," & _
                                "medicoOriginal = @medicoOriginal, medicoCopia=@medicoCopia, medicoObservaciones = @medicoObservaciones," & _
                                "fotosOriginal = @fotosOriginal, fotosObservaciones = @fotosObservaciones," & _
                                "pagoOriginal = @pagoOriginal, pagoCopia=@pagoCopia, pagoObservaciones = @pagoObservaciones," & _
                                "faltaActa = @faltaActa, faltaCurp = @faltaCurp, faltaCertificado = @faltaCertificado,faltaDomicilio = @faltaDomicilio," & _
                                "faltaMedico = @faltaMedico, faltaFotos= @faltaFotos, faltaPago = @faltaPago, idUsuario = @idUsuario " & _
                                "where idalumno = @idalumno"
            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@actaOriginal", modelo.actaOriginal)
                .Parameters.AddWithValue("@actaCopia", modelo.actaCopia)
                .Parameters.AddWithValue("@actaObservaciones", modelo.actaObservaciones)
                .Parameters.AddWithValue("@curpOriginal", modelo.curpOriginal)
                .Parameters.AddWithValue("@curpCopia", modelo.curpCopia)
                .Parameters.AddWithValue("@curpObservaciones", modelo.curpObservaciones)
                .Parameters.AddWithValue("@certificadoOriginal", modelo.certificadoOriginal)
                .Parameters.AddWithValue("@certificadoCopia", modelo.certificadoCopia)
                .Parameters.AddWithValue("@certificadoObservaciones", modelo.certificadoObservaciones)
                .Parameters.AddWithValue("@domicilioOriginal", modelo.domicilioOriginal)
                .Parameters.AddWithValue("@domicilioCopia", modelo.domicilioCopia)
                .Parameters.AddWithValue("@domicilioObservaciones", modelo.domicilioObservaciones)
                .Parameters.AddWithValue("@medicoOriginal", modelo.medicoOriginal)
                .Parameters.AddWithValue("@medicoCopia", modelo.medicoCopia)
                .Parameters.AddWithValue("@medicoObservaciones", modelo.medicoObservaciones)
                .Parameters.AddWithValue("@fotosOriginal", modelo.fotosOriginal)
                .Parameters.AddWithValue("@fotosObservaciones", modelo.fotosObservaciones)
                .Parameters.AddWithValue("@pagoOriginal", modelo.pagoOriginal)
                .Parameters.AddWithValue("@pagoCopia", modelo.pagoCopia)
                .Parameters.AddWithValue("@pagoObservaciones", modelo.pagoObservaciones)
                .Parameters.AddWithValue("@idAlumno", modelo.idAlumno)
                .Parameters.AddWithValue("@idUsuario", modelo.idUsuario)
                .Parameters.AddWithValue("@faltaActa", modelo.faltaActa)
                .Parameters.AddWithValue("@faltaCurp", modelo.faltaCurp)
                .Parameters.AddWithValue("@faltaCertificado", modelo.faltaCertificado)
                .Parameters.AddWithValue("@faltaDomicilio", modelo.faltaDomicilio)
                .Parameters.AddWithValue("@faltaMedico", modelo.faltaMedico)
                .Parameters.AddWithValue("@faltaFotos", modelo.faltaFotos)
                .Parameters.AddWithValue("@faltaPago", modelo.faltaPago)
            End With

            cmd.ExecuteNonQuery()
        Catch exc As Exception
            Throw exc
        End Try
    End Sub

    Public Sub actualizarFoto(ByVal modelo As modelos.modeloAlumno)
        Try
            variables.conexion.abrirConexion()

            Dim sql As String = "UPDATE alumno SET FOTO=@FOTO WHERE IDALUMNO=@IDALUMNO"

            Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
            With cmd
                .Parameters.AddWithValue("@FOTO", modelo.FOTO)
                .Parameters.AddWithValue("@IDALUMNO", modelo.IDALUMNO)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
            '=====================| alta de foto |==========================================
        Catch exc As Exception
            Throw exc
        End Try
    End Sub
End Module