Public Class modelos
    Public Class modeloCampus
        Public IDCAMPUS As Integer
        Public NOMBRE As String
        Public CALLE As String
        Public NUMERO As String
        Public COLONIA As String
        Public MUNICIPIO As String
        Public CODIGO_POSTAL As String
        Public CCT As String
        Public TELEFONO As String
    End Class
    Public Class modeloMateria
        Public IDMATERIA As Integer
        Public NOMBRE As String
        Public IDCARRERA As Integer
        Public IDESPECIALIDAD As Integer
        Public IDSEMESTRE As Integer
        Public PLANDEESTUDIOS As String
        Public IDMAESTRO As Integer
        Public CLAVEISENCO As String
        Public ACTIVA As Integer
        Public TIPOCHECK As Integer
    End Class
    Public Class modeloMaestro
        Public ID As Integer
        Public NOMBRE As String
        Public APELLIDO_PATERNO As String
        Public APELLIDO_MATERNO As String
        Public CALLE As String
        Public NUMERO As String
        Public COLONIA As String
        Public MUNICIPIO As String
        Public ESTADO As String
        Public CP As String
        Public CURP As String
        Public TELEFONO_CASA As String
        Public TELEFONO_CEL As String
        Public EMAIL As String
        Public FECHA_NACIMIENTO As Date
        Public FECHA_INGRESO As Date
        Public FECHA_SALIDA As Date
        Public TIPO_SANGRE As String
        Public OBSERVACIONES As String
        Public CONTACTO_EMERGENCIA As String
        Public TELEFONO_EMERGENCIA As String
        Public ACTIVO As Integer
    End Class
    Public Class modeloAdministrativo
        Public IDDIRECTIVO As Integer
        Public NOMBRE As String
        Public PUESTO As String
        Public CAMPUS As String
    End Class
    Public Class modeloCicloEscolar
        Public IDCICLOESCOLAR As Integer
        Public INICIO As Date
        Public FIN As Date
        Public ACTUAL As Integer
        Public DESCRIPCION As String
    End Class
    Public Class modeloAlumno
        Public IDALUMNO As Integer
        Public NOMBRE As String
        Public APELLIDO_PATERNO As String
        Public APELLIDO_MATERNO As String
        Public GENERO As String
        Public CALLE As String
        Public NUMERO_EXTERIOR As String
        Public NUMERO_INTERIOR As String
        Public COLONIA As String
        Public IDMUNICIPIO As String
        Public IDESTADO As String
        Public CODIGO_POSTAL As String
        Public CURP As String
        Public TELEFONO_CASA As String
        Public TELEFONO_CEL As String
        Public CORREO_ELECTRONICO As String
        Public FECHA_NACIMIENTO As Date
        Public FECHA_INGRESO As Date
        Public FECHA_SALIDA As Date
        Public TIPO_SANGRE As String
        Public OBSERVACIONES As String
        Public CONTACTO_EMERGENCIA As String
        Public TELEFONO_EMERGENCIA As String
        Public MATRICULA As String
        Public IDCAMPUS As String
        Public IDturno As String
        Public IDSTATUS As String
        Public IDAREA As String
        Public IDMODALIDAD As String
        Public IDESPECIALIDAD As String
        Public IDSEMESTRE As String
        Public IDGRUPO As String
        Public IDLICENCIATURA As String
        Public FOTO As Array
        Public PLANEST As String
        Public GENERACION As String
        Public BECA As String
        Public NO_SS As String
        Public ADEUDO_LIBROS As String
        Public PUNTAJECENEVAL As String
        Public PROMEDIObACHILLERATO As String
        Public BACHILLERATOPROCEDENCIA As String
        Public ADEUDO_MATERIAL As String
        Public SECUNDARIAPROCEDENCIA As String
        Public CLINICA_IMSS As String
        Public TIENE_DISCAPACIDAD As String
        Public TIPO_DISCAPACIDAD As String
        Public DISCAPACIDAD_OBSERV As String
        Public CLINICA_DIRECCION As String
        Public ESCUELA_PRACTICA As String
    End Class
    Public Class modeloRegistro
        Public id As Integer
        Public curp As String
        Public apellido_paterno As String
        Public apellido_materno As String
        Public nombre As String
        Public edad As String
        Public colonia As String
        Public calle As String
        Public num_ext As String
        Public localidad As String
        Public municipio As String
        Public telefono As String
        Public mail As String
        Public campus As String
        Public licenciatura As String
        Public bach_anterior_cct As String
        Public bach_anterior As String
        Public promedio As Decimal
        Public promedio_alt As Decimal
        Public folio_preregistro As String
        Public segunda_opcion As String
        Public fecha_registro As Date
        Public folio_isenco As String
        Public validado As String
        Public fecha_validado As Date
        Public validado_por As String
        Public observaciones As String
        Public fecha_nacimiento As Date
        Public aula As String
        Public tipo_folio As Integer
        Public turno As String
        Public autorizado_por As String
        Public vino_psico As Integer
        Public vino_ceneval As Integer
        Public resultado_psico As Decimal
        Public resultado_ceneval As Decimal
    End Class
End Class
