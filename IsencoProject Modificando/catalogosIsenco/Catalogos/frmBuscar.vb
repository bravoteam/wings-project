Imports datosCompartidos.Datos

Public Class frmBuscarAlumno
    Private BD As New BaseDatos
    Private Sub filtrarCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrarCmd.Click
        buscarXDescripcion(txtBuscar.Text)
        Grid.DataSource = variables.dt.Tables(0)
        Grid.Update()
        Grid.Focus()
    End Sub

    Private Sub Grid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        If Grid.RowCount > 0 Then
            If variables.banderaAccion = "campus" Then
                Dim frm As New campusFrm(Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("CALLE").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("CCT").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("CODIGO_POSTAL").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("COLONIA").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("MUNICIPIO").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("NUMERO").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("TELEFONO").Value.ToString,
                                         Grid.Rows(e.RowIndex).Cells("IDCAMPUS").Value.ToString)
                frm.Show()
                Me.Close()
            End If
            If variables.banderaAccion = "materias" Then
                Dim frm As New materiasFrm(Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDCARRERA").Value.ToString,
                                           Grid.Rows(e.RowIndex).Cells("IDCARRERA").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDESPECIALIDAD").Value.ToString,
                                           Grid.Rows(e.RowIndex).Cells("IDESPECIALIDAD").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDSEMESTRE").Value.ToString,
                                           Grid.Rows(e.RowIndex).Cells("IDSEMESTRE").Value.ToString,
                                           Grid.Rows(e.RowIndex).Cells("PLANDEESTUDIOS").Value.ToString,
                                           Grid.Rows(e.RowIndex).Cells("CLAVEISENCO").Value.ToString, Grid.Rows(e.RowIndex).Cells("IDMATERIA").Value.ToString,
                                           Grid.Rows(e.RowIndex).Cells("ACTIVA").Value, Grid.Rows(e.RowIndex).Cells("TIPOCHECK").Value)

                frm.Show()
                Me.Close()
            End If
            If variables.banderaAccion = "maestros" Then
                Dim _modelo As New modelos.modeloMaestro
                _modelo.ACTIVO = Grid.Rows(e.RowIndex).Cells("ACTIVO").Value
                _modelo.APELLIDO_MATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_MATERNO").Value.ToString
                _modelo.APELLIDO_PATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_PATERNO").Value.ToString
                _modelo.CALLE = Grid.Rows(e.RowIndex).Cells("CALLE").Value.ToString
                _modelo.CP = Grid.Rows(e.RowIndex).Cells("CP").Value.ToString
                _modelo.COLONIA = Grid.Rows(e.RowIndex).Cells("COLONIA").Value.ToString
                _modelo.CONTACTO_EMERGENCIA = Grid.Rows(e.RowIndex).Cells("CONTACTO_EMERGENCIA").Value.ToString
                _modelo.email = Grid.Rows(e.RowIndex).Cells("EMAIL").Value.ToString
                _modelo.CURP = Grid.Rows(e.RowIndex).Cells("CURP").Value.ToString
                _modelo.ESTADO = Grid.Rows(e.RowIndex).Cells("ESTADO").Value.ToString
                _modelo.FECHA_INGRESO = Grid.Rows(e.RowIndex).Cells("FECHA_INGRESO").Value
                _modelo.FECHA_NACIMIENTO = Grid.Rows(e.RowIndex).Cells("FECHA_NACIMIENTO").Value
                _modelo.FECHA_SALIDA = Grid.Rows(e.RowIndex).Cells("FECHA_SALIDA").Value
                _modelo.ID = Grid.Rows(e.RowIndex).Cells("ID").Value
                _modelo.MUNICIPIO = Grid.Rows(e.RowIndex).Cells("MUNICIPIO").Value.ToString
                _modelo.NOMBRE = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                _modelo.NUMERO = Grid.Rows(e.RowIndex).Cells("NUMERO").Value.ToString
                _modelo.OBSERVACIONES = Grid.Rows(e.RowIndex).Cells("OBSERVACIONES").Value.ToString
                _modelo.TELEFONO_CASA = Grid.Rows(e.RowIndex).Cells("TELEFONO_CASA").Value.ToString
                _modelo.TELEFONO_CEL = Grid.Rows(e.RowIndex).Cells("TELEFONO_CEL").Value.ToString
                _modelo.TELEFONO_EMERGENCIA = Grid.Rows(e.RowIndex).Cells("TELEFONO_EMERGENCIA").Value.ToString
                _modelo.TIPO_SANGRE = Grid.Rows(e.RowIndex).Cells("TIPO_SANGRE").Value.ToString

                Dim frm As New maestrosFrm(_modelo)
                frm.Show()
                Me.Close()
            End If

            If variables.banderaAccion = "administrativos" Then
                Dim _modelo As New modelos.modeloAdministrativo
                _modelo.IDDIRECTIVO = Grid.Rows(e.RowIndex).Cells("IDDIRECTIVO").Value
                _modelo.NOMBRE = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                _modelo.CAMPUS = Grid.Rows(e.RowIndex).Cells("CAMPUS").Value.ToString
                _modelo.PUESTO = Grid.Rows(e.RowIndex).Cells("PUESTO").Value.ToString
                Dim frm As New administrativosFrm(_modelo)
                frm.Show()
                Me.Close()
            End If
            If variables.banderaAccion = "modifcalif" Then
                Dim _modelo As New modelos.modeloAlumno
                _modelo.IDALUMNO = Grid.Rows(e.RowIndex).Cells("IDALUMNO").Value
                _modelo.MATRICULA = Grid.Rows(e.RowIndex).Cells("MATRICULA").Value.ToString
                modificacionCalifFrm.Show()
                modificacionCalifFrm.txtmatricula.Text = _modelo.MATRICULA
                modificacionCalifFrm.generarConsultaPrincipal(1)
                Me.Close()
            End If
            If variables.banderaAccion = "tituloActa" Then
                Dim _modelo As New modelos.modeloAlumno
                _modelo.IDALUMNO = Grid.Rows(e.RowIndex).Cells("IDALUMNO").Value
                _modelo.MATRICULA = Grid.Rows(e.RowIndex).Cells("MATRICULA").Value.ToString
                titulosActasFrm.Show()
                titulosActasFrm.txtmatricula.Text = _modelo.MATRICULA
                titulosActasFrm.generarConsultaPrincipal()
                Me.Close()
            End If
            'agregue codigo para lo nuevo'
            If variables.banderaAccion = "extracalif" Then
                Dim _modelo As New modelos.modeloAlumno
                _modelo.IDALUMNO = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                _modelo.MATRICULA = Grid.Item("MATRICULA", Grid.CurrentRow.Index).Value.ToString
                ExtrasFrm.Show()
                ExtrasFrm.txtmatricula.Text = _modelo.MATRICULA
                ExtrasFrm.lblmatricula.Text = _modelo.MATRICULA
                ExtrasFrm.generarConsultaPrincipal(1)
                Me.Close()
            End If
            If variables.banderaAccion = "ciclos" Then
                Dim _modelo As New modelos.modeloCicloEscolar
                _modelo.IDCICLOESCOLAR = Grid.Rows(e.RowIndex).Cells("IDCICLOESCOLAR").Value
                _modelo.INICIO = Grid.Rows(e.RowIndex).Cells("INICIO").Value
                _modelo.FIN = Grid.Rows(e.RowIndex).Cells("FIN").Value
                _modelo.ACTUAL = Grid.Rows(e.RowIndex).Cells("ACTUAL").Value
                _modelo.DESCRIPCION = Grid.Rows(e.RowIndex).Cells("DESCRIPCION").Value.ToString
                Dim frm As New cicloEscolarFrm(_modelo)
                frm.Show()
                Me.Close()
            End If
            If variables.banderaAccion = "preregistro" Then
                Dim _modelo As New modelos.modeloRegistro
                _modelo.id = Grid.Rows(e.RowIndex).Cells("id").Value
                consultaPreregFrm.traerDatospre(_modelo.id)
                Me.Close()
            End If
            If variables.banderaAccion = "inscripcion" Then
                Dim _modelo As New modelos.modeloRegistro
                _modelo.id = Grid.Rows(e.RowIndex).Cells("id").Value
                procesoInscripcionFrm.traerDatospre(_modelo.id)
                Me.Close()
            End If
            If variables.banderaAccion = "RPinscripcion" Then
                variables.idalumno = Grid.Rows(e.RowIndex).Cells("IDALUMNO").Value
                impresionInscripcionFrm.actualizarReportes()
                impresionInscripcionFrm.PDF()
                Me.Close()
            End If
            If variables.banderaAccion = "actualizaFoto" Then
                variables.idalumno = Grid.Rows(e.RowIndex).Cells("IDALUMNO").Value
                tomarFotoFrm.txtidAlumno.Text = variables.idalumno
                tomarFotoFrm.txtNombre.Text = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                tomarFotoFrm.txtApellidoMaterno.Text = Grid.Rows(e.RowIndex).Cells("APELLIDO_MATERNO").Value.ToString
                tomarFotoFrm.txtApellidoPaterno.Text = Grid.Rows(e.RowIndex).Cells("APELLIDO_PATERNO").Value.ToString
                tomarFotoFrm.txtLicenciatura.Text = Grid.Rows(e.RowIndex).Cells("IDLICENCIATURA").Value.ToString
                tomarFotoFrm.txtCampus.Text = Grid.Rows(e.RowIndex).Cells("IDCAMPUS").Value.ToString
                Me.Close()
            End If
            If variables.banderaAccion = "preregistro1" Then
                Dim _modelo As New modelos.modeloRegistro
                _modelo.id = Grid.Rows(e.RowIndex).Cells("id").Value
                validarPreFrm.traerDatospre(_modelo.id)
                Me.Close()
            End If
            If variables.banderaAccion = "alumnos" Then
                Dim _modelo As New modelos.modeloAlumno
                _modelo.IDALUMNO = Grid.Rows(e.RowIndex).Cells("IDALUMNO").Value
                _modelo.NOMBRE = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                _modelo.APELLIDO_MATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_MATERNO").Value.ToString
                _modelo.APELLIDO_PATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_PATERNO").Value.ToString
                _modelo.GENERO = Grid.Rows(e.RowIndex).Cells("GENERO").Value.ToString
                _modelo.CALLE = Grid.Rows(e.RowIndex).Cells("CALLE").Value.ToString
                _modelo.NUMERO_EXTERIOR = Grid.Rows(e.RowIndex).Cells("NUMERO_EXTERIOR").Value.ToString
                _modelo.NUMERO_INTERIOR = Grid.Rows(e.RowIndex).Cells("NUMERO_INTERIOR").Value.ToString
                _modelo.COLONIA = Grid.Rows(e.RowIndex).Cells("COLONIA").Value.ToString
                _modelo.IDMUNICIPIO = Grid.Rows(e.RowIndex).Cells("IDMUNICIPIO").Value.ToString
                _modelo.IDESTADO = Grid.Rows(e.RowIndex).Cells("IDESTADO").Value.ToString
                _modelo.CODIGO_POSTAL = Grid.Rows(e.RowIndex).Cells("CODIGO_POSTAL").Value.ToString
                _modelo.CURP = Grid.Rows(e.RowIndex).Cells("CURP").Value.ToString
                _modelo.TELEFONO_CASA = Grid.Rows(e.RowIndex).Cells("TELEFONO_CASA").Value.ToString
                _modelo.TELEFONO_CEL = Grid.Rows(e.RowIndex).Cells("TELEFONO_CEL").Value.ToString
                _modelo.CORREO_ELECTRONICO = Grid.Rows(e.RowIndex).Cells("CORREO_ELECTRONICO").Value.ToString
                _modelo.FECHA_INGRESO = Grid.Rows(e.RowIndex).Cells("FECHA_INGRESO").Value
                _modelo.FECHA_NACIMIENTO = Grid.Rows(e.RowIndex).Cells("FECHA_NACIMIENTO").Value
                _modelo.FECHA_SALIDA = Grid.Rows(e.RowIndex).Cells("FECHA_SALIDA").Value
                _modelo.TIPO_SANGRE = Grid.Rows(e.RowIndex).Cells("TIPO_SANGRE").Value.ToString
                _modelo.OBSERVACIONES = Grid.Rows(e.RowIndex).Cells("OBSERVACIONES").Value.ToString
                _modelo.CONTACTO_EMERGENCIA = Grid.Rows(e.RowIndex).Cells("CONTACTO_EMERGENCIA").Value.ToString
                _modelo.TELEFONO_EMERGENCIA = Grid.Rows(e.RowIndex).Cells("TELEFONO_EMERGENCIA").Value.ToString
                _modelo.MATRICULA = Grid.Rows(e.RowIndex).Cells("MATRICULA").Value.ToString
                _modelo.IDCAMPUS = Grid.Rows(e.RowIndex).Cells("IDCAMPUS").Value.ToString
                _modelo.IDturno = Grid.Rows(e.RowIndex).Cells("IDturno").Value.ToString
                _modelo.IDSTATUS = Grid.Rows(e.RowIndex).Cells("IDSTATUS").Value.ToString
                _modelo.IDAREA = Grid.Rows(e.RowIndex).Cells("IDAREA").Value.ToString
                _modelo.IDMODALIDAD = Grid.Rows(e.RowIndex).Cells("IDMODALIDAD").Value.ToString
                _modelo.IDESPECIALIDAD = Grid.Rows(e.RowIndex).Cells("IDESPECIALIDAD").Value.ToString
                _modelo.IDSEMESTRE = Grid.Rows(e.RowIndex).Cells("IDSEMESTRE").Value.ToString
                _modelo.IDGRUPO = Grid.Rows(e.RowIndex).Cells("IDGRUPO").Value.ToString
                _modelo.IDLICENCIATURA = Grid.Rows(e.RowIndex).Cells("IDLICENCIATURA").Value.ToString
                _modelo.FOTO = Grid.Rows(e.RowIndex).Cells("FOTO").Value
                _modelo.PLANEST = Grid.Rows(e.RowIndex).Cells("PLANEST").Value.ToString
                _modelo.GENERACION = Grid.Rows(e.RowIndex).Cells("GENERACION").Value.ToString
                _modelo.BECA = Grid.Rows(e.RowIndex).Cells("BECA").Value.ToString
                _modelo.NO_SS = Grid.Rows(e.RowIndex).Cells("NO_SS").Value.ToString
                _modelo.ADEUDO_LIBROS = Grid.Rows(e.RowIndex).Cells("ADEUDO_LIBROS").Value.ToString
                _modelo.PUNTAJECENEVAL = Grid.Rows(e.RowIndex).Cells("PUNTAJECENEVAL").Value.ToString
                _modelo.PROMEDIObACHILLERATO = Grid.Rows(e.RowIndex).Cells("PROMEDIObACHILLERATO").Value.ToString
                _modelo.BACHILLERATOPROCEDENCIA = Grid.Rows(e.RowIndex).Cells("BACHILLERATOPROCEDENCIA").Value.ToString
                _modelo.ADEUDO_MATERIAL = Grid.Rows(e.RowIndex).Cells("ADEUDO_MATERIAL").Value.ToString
                _modelo.SECUNDARIAPROCEDENCIA = Grid.Rows(e.RowIndex).Cells("SECUNDARIAPROCEDENCIA").Value.ToString
                _modelo.CLINICA_IMSS = Grid.Rows(e.RowIndex).Cells("CLINICA_IMSS").Value.ToString
                _modelo.TIENE_DISCAPACIDAD = Grid.Rows(e.RowIndex).Cells("TIENE_DISCAPACIDAD").Value.ToString
                _modelo.TIPO_DISCAPACIDAD = Grid.Rows(e.RowIndex).Cells("TIPO_DISCAPACIDAD").Value.ToString
                _modelo.DISCAPACIDAD_OBSERV = Grid.Rows(e.RowIndex).Cells("DISCAPACIDAD_OBSERV").Value.ToString
                _modelo.CLINICA_DIRECCION = Grid.Rows(e.RowIndex).Cells("CLINICA_DIRECCION").Value.ToString
                _modelo.ESCUELA_PRACTICA = Grid.Rows(e.RowIndex).Cells("ESCUELA_PRACTICA").Value.ToString
                _modelo.NOMBRE_PAPA = Grid.Rows(e.RowIndex).Cells("NOMBRE_PAPA").Value.ToString
                _modelo.NOMBRE_MAMA = Grid.Rows(e.RowIndex).Cells("NOMBRE_MAMA").Value.ToString
                _modelo.LUGAR_NACIMIENTO = Grid.Rows(e.RowIndex).Cells("LUGAR_NACIMIENTO").Value.ToString
                ' Me.Hide()
                alumnosFrm.llenarAlumno(_modelo)
                alumnosFrm.Show()
                Me.Close()
            End If
            If variables.banderaAccion = "interno" Then
                Dim _modelo As New modelos.modeloAlumno
                _modelo.IDALUMNO = Grid.Rows(e.RowIndex).Cells("IDALUMNO").Value
                _modelo.NOMBRE = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                _modelo.APELLIDO_MATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_MATERNO").Value.ToString
                _modelo.APELLIDO_PATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_PATERNO").Value.ToString
                _modelo.GENERO = Grid.Rows(e.RowIndex).Cells("GENERO").Value.ToString
                _modelo.CALLE = Grid.Rows(e.RowIndex).Cells("CALLE").Value.ToString
                _modelo.NUMERO_EXTERIOR = Grid.Rows(e.RowIndex).Cells("NUMERO_EXTERIOR").Value.ToString
                _modelo.NUMERO_INTERIOR = Grid.Rows(e.RowIndex).Cells("NUMERO_INTERIOR").Value.ToString
                _modelo.COLONIA = Grid.Rows(e.RowIndex).Cells("COLONIA").Value.ToString
                _modelo.IDMUNICIPIO = Grid.Rows(e.RowIndex).Cells("IDMUNICIPIO").Value.ToString
                _modelo.IDESTADO = Grid.Rows(e.RowIndex).Cells("IDESTADO").Value.ToString
                _modelo.CODIGO_POSTAL = Grid.Rows(e.RowIndex).Cells("CODIGO_POSTAL").Value.ToString
                _modelo.CURP = Grid.Rows(e.RowIndex).Cells("CURP").Value.ToString
                _modelo.TELEFONO_CASA = Grid.Rows(e.RowIndex).Cells("TELEFONO_CASA").Value.ToString
                _modelo.TELEFONO_CEL = Grid.Rows(e.RowIndex).Cells("TELEFONO_CEL").Value.ToString
                _modelo.CORREO_ELECTRONICO = Grid.Rows(e.RowIndex).Cells("CORREO_ELECTRONICO").Value.ToString
                _modelo.FECHA_INGRESO = Grid.Rows(e.RowIndex).Cells("FECHA_INGRESO").Value
                _modelo.FECHA_NACIMIENTO = Grid.Rows(e.RowIndex).Cells("FECHA_NACIMIENTO").Value
                _modelo.FECHA_SALIDA = Grid.Rows(e.RowIndex).Cells("FECHA_SALIDA").Value
                _modelo.TIPO_SANGRE = Grid.Rows(e.RowIndex).Cells("TIPO_SANGRE").Value.ToString
                _modelo.OBSERVACIONES = Grid.Rows(e.RowIndex).Cells("OBSERVACIONES").Value.ToString
                _modelo.CONTACTO_EMERGENCIA = Grid.Rows(e.RowIndex).Cells("CONTACTO_EMERGENCIA").Value.ToString
                _modelo.TELEFONO_EMERGENCIA = Grid.Rows(e.RowIndex).Cells("TELEFONO_EMERGENCIA").Value.ToString
                _modelo.MATRICULA = Grid.Rows(e.RowIndex).Cells("MATRICULA").Value.ToString
                _modelo.IDCAMPUS = Grid.Rows(e.RowIndex).Cells("IDCAMPUS").Value.ToString
                _modelo.IDturno = Grid.Rows(e.RowIndex).Cells("IDturno").Value.ToString
                _modelo.IDSTATUS = Grid.Rows(e.RowIndex).Cells("IDSTATUS").Value.ToString
                _modelo.IDAREA = Grid.Rows(e.RowIndex).Cells("IDAREA").Value.ToString
                _modelo.IDMODALIDAD = Grid.Rows(e.RowIndex).Cells("IDMODALIDAD").Value.ToString
                _modelo.IDESPECIALIDAD = Grid.Rows(e.RowIndex).Cells("IDESPECIALIDAD").Value.ToString
                _modelo.IDSEMESTRE = Grid.Rows(e.RowIndex).Cells("IDSEMESTRE").Value.ToString
                _modelo.IDGRUPO = Grid.Rows(e.RowIndex).Cells("IDGRUPO").Value.ToString
                _modelo.IDLICENCIATURA = Grid.Rows(e.RowIndex).Cells("IDLICENCIATURA").Value.ToString
                consultaPreregFrm.llenarAlumnoInterno(_modelo)
                Me.Close()
            End If
            If variables.banderaAccion = "certificados" Then
                Dim _modelo As New modelos.modeloAlumno
                _modelo.IDALUMNO = Grid.Rows(e.RowIndex).Cells("IDALUMNO").Value
                _modelo.MATRICULA = Grid.Rows(e.RowIndex).Cells("MATRICULA").Value.ToString
                variables.matricula = _modelo.MATRICULA
                certificadosFrm.txtmatricula.Text = variables.matricula
                certificadosFrm.buscar_matricula(variables.matricula)
                certificadosFrm.Show()
                Me.Close()
            End If
            If variables.banderaAccion = "actaP" Then
                Dim _modelo As New modelos.modeloMaestro
                _modelo.APELLIDO_MATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_MATERNO").Value.ToString
                _modelo.APELLIDO_PATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_PATERNO").Value.ToString
                _modelo.NOMBRE = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                llenarActaExamen.txtPresidente.Text = _modelo.NOMBRE & " " & _modelo.APELLIDO_PATERNO & " " & _modelo.APELLIDO_MATERNO
                Me.Close()
            End If
            If variables.banderaAccion = "actaS" Then
                Dim _modelo As New modelos.modeloMaestro
                _modelo.APELLIDO_MATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_MATERNO").Value.ToString
                _modelo.APELLIDO_PATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_PATERNO").Value.ToString
                _modelo.NOMBRE = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                llenarActaExamen.txtSecretario.Text = _modelo.NOMBRE & " " & _modelo.APELLIDO_PATERNO & " " & _modelo.APELLIDO_MATERNO
                Me.Close()
            End If
            If variables.banderaAccion = "actaV" Then
                Dim _modelo As New modelos.modeloMaestro
                _modelo.APELLIDO_MATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_MATERNO").Value.ToString
                _modelo.APELLIDO_PATERNO = Grid.Rows(e.RowIndex).Cells("APELLIDO_PATERNO").Value.ToString
                _modelo.NOMBRE = Grid.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString
                llenarActaExamen.txtVocal.Text = _modelo.NOMBRE & " " & _modelo.APELLIDO_PATERNO & " " & _modelo.APELLIDO_MATERNO
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If Grid.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                If variables.banderaAccion = "campus" Then
                    Dim frm As New campusFrm(Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("CALLE", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("CCT", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("CODIGO_POSTAL", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("COLONIA", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("MUNICIPIO", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("NUMERO", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("TELEFONO", Grid.CurrentRow.Index).Value.ToString,
                                             Grid.Item("IDCAMPUS", Grid.CurrentRow.Index).Value.ToString)
                    frm.Show()
                    Me.Close()
                End If
                If variables.banderaAccion = "materias" Then
                    Dim frm As New materiasFrm(Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDCARRERA", Grid.CurrentRow.Index).Value.ToString,
                                          Grid.Item("IDCARRERA", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDESPECIALIDAD", Grid.CurrentRow.Index).Value.ToString,
                                          Grid.Item("IDESPECIALIDAD", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDSEMESTRE", Grid.CurrentRow.Index).Value.ToString,
                                          Grid.Item("IDSEMESTRE", Grid.CurrentRow.Index).Value.ToString,
                                          Grid.Item("PLANDEESTUDIOS", Grid.CurrentRow.Index).Value.ToString,
                                          Grid.Item("CLAVEISENCO", Grid.CurrentRow.Index).Value.ToString, Grid.Item("IDMATERIA", Grid.CurrentRow.Index).Value.ToString,
                                          Grid.Item("ACTIVA", Grid.CurrentRow.Index).Value, Grid.Item("TIPOCHECK", Grid.CurrentRow.Index).Value)

                    frm.Show()
                    Me.Close()
                End If
                If variables.banderaAccion = "maestros" Then
                    Dim _modelo As New modelos.modeloMaestro

                    _modelo.ACTIVO = Grid.Item("ACTIVO", Grid.CurrentRow.Index).Value
                    _modelo.APELLIDO_MATERNO = Grid.Item("APELLIDO_MATERNO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.APELLIDO_PATERNO = Grid.Item("APELLIDO_PATERNO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CALLE = Grid.Item("CALLE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CP = Grid.Item("CP", Grid.CurrentRow.Index).Value.ToString
                    _modelo.COLONIA = Grid.Item("COLONIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CONTACTO_EMERGENCIA = Grid.Item("CONTACTO_EMERGENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.EMAIL = Grid.Item("email", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CURP = Grid.Item("CURP", Grid.CurrentRow.Index).Value.ToString
                    _modelo.ESTADO = Grid.Item("ESTADO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.FECHA_INGRESO = Grid.Item("FECHA_INGRESO", Grid.CurrentRow.Index).Value
                    _modelo.FECHA_NACIMIENTO = Grid.Item("FECHA_NACIMIENTO", Grid.CurrentRow.Index).Value
                    _modelo.FECHA_SALIDA = Grid.Item("FECHA_SALIDA", Grid.CurrentRow.Index).Value
                    _modelo.ID = Grid.Item("ID", Grid.CurrentRow.Index).Value
                    _modelo.MUNICIPIO = Grid.Item("MUNICIPIO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NOMBRE = Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NUMERO = Grid.Item("NUMERO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.OBSERVACIONES = Grid.Item("OBSERVACIONES", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_CASA = Grid.Item("TELEFONO_CASA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_CEL = Grid.Item("TELEFONO_CEL", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_EMERGENCIA = Grid.Item("TELEFONO_EMERGENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TIPO_SANGRE = Grid.Item("TIPO_SANGRE", Grid.CurrentRow.Index).Value.ToString

                    Dim frm As New maestrosFrm(_modelo)
                    frm.Show()
                    Me.Close()
                End If
                If variables.banderaAccion = "administrativos" Then
                    Dim _modelo As New modelos.modeloAdministrativo

                    _modelo.IDDIRECTIVO = Grid.Item("IDDIRECTIVO", Grid.CurrentRow.Index).Value
                    _modelo.NOMBRE = Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.PUESTO = Grid.Item("PUESTO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CAMPUS = Grid.Item("CAMPUS", Grid.CurrentRow.Index).Value.ToString
                    Dim frm As New administrativosFrm(_modelo)
                    frm.Show()
                    Me.Close()
                End If
                If variables.banderaAccion = "modifcalif" Then
                    Dim _modelo As New modelos.modeloAlumno
                    _modelo.IDALUMNO = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    _modelo.MATRICULA = Grid.Item("MATRICULA", Grid.CurrentRow.Index).Value.ToString
                    modificacionCalifFrm.Show()
                    modificacionCalifFrm.txtmatricula.Text = _modelo.MATRICULA
                    modificacionCalifFrm.generarConsultaPrincipal(1)
                    Me.Close()
                End If
                If variables.banderaAccion = "tituloActa" Then
                    Dim _modelo As New modelos.modeloAlumno
                    _modelo.IDALUMNO = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    _modelo.MATRICULA = Grid.Item("MATRICULA", Grid.CurrentRow.Index).Value.ToString
                    titulosActasFrm.Show()
                    titulosActasFrm.txtmatricula.Text = _modelo.MATRICULA
                    titulosActasFrm.generarConsultaPrincipal()
                    Me.Close()
                End If
                'agregue codigo para lo nuevo'
                If variables.banderaAccion = "extracalif" Then
                    Dim _modelo As New modelos.modeloAlumno
                    _modelo.IDALUMNO = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    _modelo.MATRICULA = Grid.Item("MATRICULA", Grid.CurrentRow.Index).Value.ToString
                    ExtrasFrm.Show()
                    ExtrasFrm.txtmatricula.Text = _modelo.MATRICULA
                    ExtrasFrm.lblmatricula.Text = _modelo.MATRICULA
                    ExtrasFrm.generarConsultaPrincipal(1)
                    Me.Close()
                End If
                If variables.banderaAccion = "ciclos" Then
                    Dim _modelo As New modelos.modeloCicloEscolar

                    _modelo.IDCICLOESCOLAR = Grid.Item("IDCICLOESCOLAR", Grid.CurrentRow.Index).Value
                    _modelo.INICIO = Grid.Item("INICIO", Grid.CurrentRow.Index).Value
                    _modelo.FIN = Grid.Item("FIN", Grid.CurrentRow.Index).Value
                    _modelo.ACTUAL = Grid.Item("ACTUAL", Grid.CurrentRow.Index).Value
                    _modelo.DESCRIPCION = Grid.Item("DESCRIPCION", Grid.CurrentRow.Index).Value.ToString
                    Dim frm As New cicloEscolarFrm(_modelo)
                    frm.Show()
                    Me.Close()
                End If
                If variables.banderaAccion = "preregistro" Then
                    Dim _modelo As New modelos.modeloRegistro
                    _modelo.id = Grid.Item("id", Grid.CurrentRow.Index).Value
                    consultaPreregFrm.traerDatospre(_modelo.id)
                    Me.Close()
                End If
                If variables.banderaAccion = "inscripcion" Then
                    Dim _modelo As New modelos.modeloRegistro
                    _modelo.id = Grid.Item("id", Grid.CurrentRow.Index).Value
                    procesoInscripcionFrm.traerDatospre(_modelo.id)
                    Me.Close()
                End If
                If variables.banderaAccion = "RPinscripcion" Then
                    variables.idalumno = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    impresionInscripcionFrm.actualizarReportes()
                    impresionInscripcionFrm.PDF()
                    Me.Close()
                End If
                If variables.banderaAccion = "actualizaFoto" Then
                    variables.idalumno = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    tomarFotoFrm.txtidAlumno.Text = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    tomarFotoFrm.txtNombre.Text = Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value
                    tomarFotoFrm.txtApellidoMaterno.Text = Grid.Item("APELLIDO_MATERNO", Grid.CurrentRow.Index).Value
                    tomarFotoFrm.txtApellidoPaterno.Text = Grid.Item("APELLIDO_PATERNO", Grid.CurrentRow.Index).Value
                    tomarFotoFrm.txtLicenciatura.Text = Grid.Item("IDLICENCIATURA", Grid.CurrentRow.Index).Value
                    tomarFotoFrm.txtCampus.Text = Grid.Item("IDCAMPUS", Grid.CurrentRow.Index).Value
                    Me.Close()
                End If
                If variables.banderaAccion = "preregistro1" Then
                    Dim _modelo As New modelos.modeloRegistro
                    _modelo.id = Grid.Item("id", Grid.CurrentRow.Index).Value
                    validarPreFrm.traerDatospre(_modelo.id)
                    Me.Close()
                End If
                If variables.banderaAccion = "alumnos" Then
                    Dim _modelo As New modelos.modeloAlumno
                    _modelo.IDALUMNO = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    _modelo.NOMBRE = Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.APELLIDO_MATERNO = Grid.Item("APELLIDO_MATERNO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.APELLIDO_PATERNO = Grid.Item("APELLIDO_PATERNO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.GENERO = Grid.Item("GENERO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CALLE = Grid.Item("CALLE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NUMERO_EXTERIOR = Grid.Item("NUMERO_EXTERIOR", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NUMERO_INTERIOR = Grid.Item("NUMERO_INTERIOR", Grid.CurrentRow.Index).Value.ToString
                    _modelo.COLONIA = Grid.Item("COLONIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDMUNICIPIO = Grid.Item("IDMUNICIPIO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDESTADO = Grid.Item("IDESTADO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CODIGO_POSTAL = Grid.Item("CODIGO_POSTAL", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CURP = Grid.Item("CURP", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_CASA = Grid.Item("TELEFONO_CASA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_CEL = Grid.Item("TELEFONO_CEL", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CORREO_ELECTRONICO = Grid.Item("CORREO_ELECTRONICO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.FECHA_INGRESO = Grid.Item("FECHA_INGRESO", Grid.CurrentRow.Index).Value
                    _modelo.FECHA_NACIMIENTO = Grid.Item("FECHA_NACIMIENTO", Grid.CurrentRow.Index).Value
                    _modelo.FECHA_SALIDA = Grid.Item("FECHA_SALIDA", Grid.CurrentRow.Index).Value
                    _modelo.TIPO_SANGRE = Grid.Item("TIPO_SANGRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.OBSERVACIONES = Grid.Item("OBSERVACIONES", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CONTACTO_EMERGENCIA = Grid.Item("CONTACTO_EMERGENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_EMERGENCIA = Grid.Item("TELEFONO_EMERGENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.MATRICULA = Grid.Item("MATRICULA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDCAMPUS = Grid.Item("IDCAMPUS", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDturno = Grid.Item("IDturno", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDSTATUS = Grid.Item("IDSTATUS", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDAREA = Grid.Item("IDAREA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDMODALIDAD = Grid.Item("IDMODALIDAD", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDESPECIALIDAD = Grid.Item("IDESPECIALIDAD", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDSEMESTRE = Grid.Item("IDSEMESTRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDGRUPO = Grid.Item("IDGRUPO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDLICENCIATURA = Grid.Item("IDLICENCIATURA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.FOTO = Grid.Item("FOTO", Grid.CurrentRow.Index).Value
                    _modelo.PLANEST = Grid.Item("PLANEST", Grid.CurrentRow.Index).Value.ToString
                    _modelo.GENERACION = Grid.Item("GENERACION", Grid.CurrentRow.Index).Value.ToString
                    _modelo.BECA = Grid.Item("BECA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NO_SS = Grid.Item("NO_SS", Grid.CurrentRow.Index).Value.ToString
                    _modelo.ADEUDO_LIBROS = Grid.Item("ADEUDO_LIBROS", Grid.CurrentRow.Index).Value.ToString
                    _modelo.PUNTAJECENEVAL = Grid.Item("PUNTAJECENEVAL", Grid.CurrentRow.Index).Value.ToString
                    _modelo.PROMEDIObACHILLERATO = Grid.Item("PROMEDIObACHILLERATO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.BACHILLERATOPROCEDENCIA = Grid.Item("BACHILLERATOPROCEDENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.ADEUDO_MATERIAL = Grid.Item("ADEUDO_MATERIAL", Grid.CurrentRow.Index).Value.ToString
                    _modelo.SECUNDARIAPROCEDENCIA = Grid.Item("SECUNDARIAPROCEDENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CLINICA_IMSS = Grid.Item("CLINICA_IMSS", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TIENE_DISCAPACIDAD = Grid.Item("TIENE_DISCAPACIDAD", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TIPO_DISCAPACIDAD = Grid.Item("TIPO_DISCAPACIDAD", Grid.CurrentRow.Index).Value.ToString
                    _modelo.DISCAPACIDAD_OBSERV = Grid.Item("DISCAPACIDAD_OBSERV", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CLINICA_DIRECCION = Grid.Item("CLINICA_DIRECCION", Grid.CurrentRow.Index).Value.ToString
                    _modelo.ESCUELA_PRACTICA = Grid.Item("ESCUELA_PRACTICA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NOMBRE_MAMA = Grid.Item("NOMBRE_MAMA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NOMBRE_PAPA = Grid.Item("NOMBRE_PAPA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.LUGAR_NACIMIENTO = Grid.Item("LUGAR_NACIMIENTO", Grid.CurrentRow.Index).Value.ToString
                    alumnosFrm.llenarAlumno(_modelo)
                    alumnosFrm.Show()
                    Me.Close()
                End If
                If variables.banderaAccion = "interno" Then
                    Dim _modelo As New modelos.modeloAlumno
                    _modelo.IDALUMNO = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    _modelo.NOMBRE = Grid.Item("NOMBRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.APELLIDO_MATERNO = Grid.Item("APELLIDO_MATERNO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.APELLIDO_PATERNO = Grid.Item("APELLIDO_PATERNO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.GENERO = Grid.Item("GENERO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CALLE = Grid.Item("CALLE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NUMERO_EXTERIOR = Grid.Item("NUMERO_EXTERIOR", Grid.CurrentRow.Index).Value.ToString
                    _modelo.NUMERO_INTERIOR = Grid.Item("NUMERO_INTERIOR", Grid.CurrentRow.Index).Value.ToString
                    _modelo.COLONIA = Grid.Item("COLONIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDMUNICIPIO = Grid.Item("IDMUNICIPIO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDESTADO = Grid.Item("IDESTADO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CODIGO_POSTAL = Grid.Item("CODIGO_POSTAL", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CURP = Grid.Item("CURP", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_CASA = Grid.Item("TELEFONO_CASA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_CEL = Grid.Item("TELEFONO_CEL", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CORREO_ELECTRONICO = Grid.Item("CORREO_ELECTRONICO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.FECHA_INGRESO = Grid.Item("FECHA_INGRESO", Grid.CurrentRow.Index).Value
                    _modelo.FECHA_NACIMIENTO = Grid.Item("FECHA_NACIMIENTO", Grid.CurrentRow.Index).Value
                    _modelo.FECHA_SALIDA = Grid.Item("FECHA_SALIDA", Grid.CurrentRow.Index).Value
                    _modelo.TIPO_SANGRE = Grid.Item("TIPO_SANGRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.OBSERVACIONES = Grid.Item("OBSERVACIONES", Grid.CurrentRow.Index).Value.ToString
                    _modelo.CONTACTO_EMERGENCIA = Grid.Item("CONTACTO_EMERGENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.TELEFONO_EMERGENCIA = Grid.Item("TELEFONO_EMERGENCIA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.MATRICULA = Grid.Item("MATRICULA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDCAMPUS = Grid.Item("IDCAMPUS", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDturno = Grid.Item("IDturno", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDSTATUS = Grid.Item("IDSTATUS", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDAREA = Grid.Item("IDAREA", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDMODALIDAD = Grid.Item("IDMODALIDAD", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDESPECIALIDAD = Grid.Item("IDESPECIALIDAD", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDSEMESTRE = Grid.Item("IDSEMESTRE", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDGRUPO = Grid.Item("IDGRUPO", Grid.CurrentRow.Index).Value.ToString
                    _modelo.IDLICENCIATURA = Grid.Item("IDLICENCIATURA", Grid.CurrentRow.Index).Value.ToString
                    consultaPreregFrm.llenarAlumnoInterno(_modelo)
                    Me.Close()
                End If
                If variables.banderaAccion = "certificados" Then
                    Dim _modelo As New modelos.modeloAlumno
                    _modelo.IDALUMNO = Grid.Item("IDALUMNO", Grid.CurrentRow.Index).Value
                    _modelo.MATRICULA = Grid.Item("MATRICULA", Grid.CurrentRow.Index).Value.ToString
                    variables.matricula = _modelo.MATRICULA
                    certificadosFrm.txtmatricula.Text = variables.matricula
                    certificadosFrm.buscar_matricula(variables.matricula)
                    certificadosFrm.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            buscarXDescripcion(txtBuscar.Text)
            Grid.DataSource = variables.dt.Tables(0)
            Grid.Update()
            Grid.Focus()
        End If
    End Sub
    Private Sub frmBuscarAlumno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtBuscar.Focus()
        Grid.DataSource = Nothing
        txtBuscar.Text = ""
        txtBuscar.Focus()
    End Sub

    Private Sub Grid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class