Imports System.Data.SqlClient

Module funcionesLocales
    'Public Sub guardarCampus(ByVal modelo As modelos.modeloCampus)
    '    Try
    '        variables.conexion.abrirConexion()

    '        Dim sql As String = "insert into campus(NOMBRE,CALLE,NUMERO,COLONIA," & _
    '            "MUNICIPIO,CODIGO_POSTAL,CCT,TELEFONO)" & _
    '                     "values (@NOMBRE,@CALLE,@NUMERO,@COLONIA," & _
    '            "@MUNICIPIO,@CODIGO_POSTAL,@CCT,@TELEFONO)"

    '        Dim cmd As New SqlCommand(Sql, variables.conexion.Conexion)
    '        With cmd
    '            .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
    '            .Parameters.AddWithValue("@CALLE", modelo.CALLE)
    '            .Parameters.AddWithValue("@NUMERO", modelo.NUMERO)
    '            .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
    '            .Parameters.AddWithValue("@MUNICIPIO", modelo.MUNICIPIO)
    '            .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
    '            .Parameters.AddWithValue("@CCT", modelo.CCT)
    '            .Parameters.AddWithValue("@TELEFONO", modelo.TELEFONO)
    '        End With

    '        cmd.ExecuteNonQuery()
    '        MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
    '    Catch exc As Exception
    '        Throw exc
    '    End Try
    'End Sub
    ''Public Function traerUltimaMateria() As modelos.modeloMateria
    '    Dim modelo As New modelos.modeloMateria
    '    Try
    '        variables.conexion.abrirConexion()
    '        variables.sql = "select * from materias order by IDMATERIA DESC"
    '        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
    '        variables.SQLdr = cmd.ExecuteReader()

    '        While (variables.SQLdr.Read())
    '            modelo.IDMATERIA = Val(variables.SQLdr("IDMATERIA").ToString)
    '            modelo.IDCARRERA = Val(variables.SQLdr("IDCARRERA").ToString)
    '            modelo.IDESPECIALIDAD = Val(variables.SQLdr("IDESPECIALIDAD").ToString)
    '            modelo.IDMAESTRO = Val(variables.SQLdr("IDMAESTRO").ToString)
    '            modelo.IDSEMESTRE = Val(variables.SQLdr("IDSEMESTRE").ToString)
    '            modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
    '            modelo.PLANDEESTUDIOS = variables.SQLdr("PLANDEESTUDIOS").ToString
    '            modelo.CLAVEISENCO = variables.SQLdr("CLAVEISENCO").ToString
    '            modelo.ACTIVA = Val(variables.SQLdr("ACTIVA").ToString)
    '            Exit While
    '        End While
    '        variables.conexion.cerrarConexion()
    '        Return modelo
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        variables.conexion.cerrarConexion()
    '    End Try
    'End Function
    'Public Function traerUltimoCampus() As modelos.modeloCampus
    '    Dim modelo As New modelos.modeloCampus
    '    Try
    '        variables.conexion.abrirConexion()
    '        variables.sql = "select * from campus order by IDCAMPUS DESC"
    '        Dim cmd As New SqlCommand(variables.sql, variables.conexion.Conexion)
    '        variables.SQLdr = cmd.ExecuteReader()

    '        While (variables.SQLdr.Read())
    '            modelo.CALLE = variables.SQLdr("CALLE").ToString
    '            modelo.CCT = variables.SQLdr("CCT").ToString
    '            modelo.CODIGO_POSTAL = variables.SQLdr("CODIGO_POSTAL").ToString
    '            modelo.COLONIA = variables.SQLdr("COLONIA").ToString
    '            modelo.IDCAMPUS = variables.SQLdr("IDCAMPUS").ToString
    '            modelo.NOMBRE = variables.SQLdr("NOMBRE").ToString
    '            modelo.NUMERO = variables.SQLdr("NUMERO").ToString
    '            modelo.TELEFONO = variables.SQLdr("TELEFONO").ToString
    '            modelo.MUNICIPIO = variables.SQLdr("MUNICIPIO").ToString
    '            Exit While
    '        End While
    '        variables.conexion.cerrarConexion()
    '        Return modelo
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        variables.conexion.cerrarConexion()
    '    End Try
    'End Function
    'Public Sub actualizarCampus(ByVal modelo As modelos.modeloCampus)
    '    Try
    '        variables.conexion.abrirConexion()

    '        Dim sql As String = "UPDATE campus SET NOMBRE=@NOMBRE,CALLE=@CALLE,NUMERO=@NUMERO,COLONIA=@COLONIA," & _
    '            "MUNICIPIO=@MUNICIPIO,CODIGO_POSTAL=@CODIGO_POSTAL,CCT=@CCT,TELEFONO=@TELEFONO " & _
    '                     "where IDCAMPUS = @IDCAMPUS"

    '        Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
    '        With cmd
    '            .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
    '            .Parameters.AddWithValue("@CALLE", modelo.CALLE)
    '            .Parameters.AddWithValue("@NUMERO", modelo.NUMERO)
    '            .Parameters.AddWithValue("@COLONIA", modelo.COLONIA)
    '            .Parameters.AddWithValue("@MUNICIPIO", modelo.MUNICIPIO)
    '            .Parameters.AddWithValue("@CODIGO_POSTAL", modelo.CODIGO_POSTAL)
    '            .Parameters.AddWithValue("@CCT", modelo.CCT)
    '            .Parameters.AddWithValue("@TELEFONO", modelo.TELEFONO)
    '            .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
    '        End With

    '        cmd.ExecuteNonQuery()
    '        MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
    '    Catch exc As Exception
    '        Throw exc
    '    End Try
    'End Sub
    'Public Sub eliminarCampus(ByVal modelo As modelos.modeloCampus)
    '    Try
    '        variables.conexion.abrirConexion()

    '        Dim sql As String = "DELETE  FROM campus where IDCAMPUS = @IDCAMPUS"

    '        Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
    '        With cmd
    '            .Parameters.AddWithValue("@IDCAMPUS", modelo.IDCAMPUS)
    '        End With

    '        cmd.ExecuteNonQuery()
    '        MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
    '    Catch exc As Exception
    '        Throw exc
    '    End Try
    'End Sub
    'Public Sub guardarMaterias(ByVal modelo As modelos.modeloMateria)
    '    Try
    '        variables.conexion.abrirConexion()

    '        Dim sql As String = "insert into materias(NOMBRE,IDCARRERA,IDESPECIALIDAD,IDSEMESTRE," & _
    '            "PLANDEESTUDIOS,IDMAESTRO,CLAVEISENCO,ACTIVA)" & _
    '                     "values (@NOMBRE,@IDCARRERA,@IDESPECIALIDAD,@IDSEMESTRE," & _
    '            "@PLANDEESTUDIOS,@IDMAESTRO,@CLAVEISENCO,@ACTIVA)"

    '        Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
    '        With cmd
    '            .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
    '            .Parameters.AddWithValue("@IDCARRERA", modelo.IDCARRERA)
    '            .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
    '            .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
    '            .Parameters.AddWithValue("@PLANDEESTUDIOS", modelo.PLANDEESTUDIOS)
    '            .Parameters.AddWithValue("@IDMAESTRO", modelo.IDMAESTRO)
    '            .Parameters.AddWithValue("@CLAVEISENCO", modelo.CLAVEISENCO)
    '            .Parameters.AddWithValue("@ACTIVA", modelo.ACTIVA)
    '        End With

    '        cmd.ExecuteNonQuery()
    '        MsgBox("REGISTRO INSERTADO CORRECTAMENTE")
    '    Catch exc As Exception
    '        Throw exc
    '    End Try
    'End Sub
    'Public Sub actualizarMaterias(ByVal modelo As modelos.modeloMateria)
    '    Try
    '        variables.conexion.abrirConexion()

    '        Dim sql As String = "UPDATE materias SET NOMBRE=@NOMBRE,IDCARRERA=@IDCARRERA,IDESPECIALIDAD=@IDESPECIALIDAD,IDSEMESTRE=@IDSEMESTRE," & _
    '            "PLANDEESTUDIOS=@PLANDEESTUDIOS,IDMAESTRO=@IDMAESTRO,CLAVEISENCO=@CLAVEISENCO,ACTIVA=@ACTIVA " & _
    '                     "where IDMATERIA = @IDMATERIA"

    '        Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
    '        With cmd
    '            .Parameters.AddWithValue("@NOMBRE", modelo.NOMBRE)
    '            .Parameters.AddWithValue("@IDCARRERA", modelo.IDCARRERA)
    '            .Parameters.AddWithValue("@IDESPECIALIDAD", modelo.IDESPECIALIDAD)
    '            .Parameters.AddWithValue("@IDSEMESTRE", modelo.IDSEMESTRE)
    '            .Parameters.AddWithValue("@PLANDEESTUDIOS", modelo.PLANDEESTUDIOS)
    '            .Parameters.AddWithValue("@IDMAESTRO", modelo.IDMAESTRO)
    '            .Parameters.AddWithValue("@CLAVEISENCO", modelo.CLAVEISENCO)
    '            .Parameters.AddWithValue("@IDMATERIA", modelo.IDMATERIA)
    '            .Parameters.AddWithValue("@ACTIVA", modelo.ACTIVA)
    '        End With

    '        cmd.ExecuteNonQuery()
    '        MsgBox("REGISTRO ACTUALIZADO CORRECTAMENTE")
    '    Catch exc As Exception
    '        Throw exc
    '    End Try
    'End Sub
    'Public Sub eliminarMaterias(ByVal modelo As modelos.modeloMateria)
    '    Try
    '        variables.conexion.abrirConexion()

    '        Dim sql As String = "DELETE  FROM materias where IDMATERIA = @IDMATERIA"

    '        Dim cmd As New SqlCommand(sql, variables.conexion.Conexion)
    '        With cmd
    '            .Parameters.AddWithValue("@IDMATERIA", modelo.IDMATERIA)
    '        End With

    '        cmd.ExecuteNonQuery()
    '        MsgBox("REGISTRO ELIMINADO CORRECTAMENTE", vbCritical)
    '    Catch exc As Exception
    '        Throw exc
    '    End Try
    'End Sub
    Public Function validarReceptor(ByVal GbxDatos As GroupBox) As Boolean
        Dim res As Boolean = True

        funcionesLocales.pintarControles(GbxDatos)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                If String.IsNullOrEmpty(ctl.Text) Then
                    If ctl.Name <> "txtidCampus" And ctl.Name <> "txtidMateria" Then
                        ctl.BackColor = Drawing.Color.Aqua()
                        res = False
                    End If
                End If
            End If
        Next ctl

        Return res
    End Function
    Public Sub pintarControles(ByVal GbxDatos As GroupBox)
        Dim ctl As Control

        For Each ctl In GbxDatos.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox Then
                ctl.BackColor = Drawing.Color.White
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
        If variables.banderaAccion = "Alumno" Then
            variables.dt = variables.conexion.getDataSet("select matricula,nombre,apellido_paterno,apellido_materno,idlicenciatura,idespecialidad from alumno where (NOMBRE + ' ' + APELLIDO_PATERNO + ' ' + APELLIDO_MATERNO) LIKE '%" + busqueda + "%' order by apellido_paterno")
        End If

    End Sub

End Module
