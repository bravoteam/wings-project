Imports datosCompartidos.funciones
Imports datosCompartidos.Datos
Imports datosCompartidos
Public Class pruebaFrm
    Private model As New datosCompartidos.Modelos.AlumnosModel
    Private Sub cargarCombos()
        Dim ds As New DataSet
        ds = getCampus()
        loadComboBox(ds, cmbCampus, "IDCAMPUS", "campus")
        ds = getLicenciaturas()
        loadComboBox(ds, cmbLicenciatura, "IDLICENCIATURA", "licenciatura")
        ds = getEspecialidades()
        loadComboBox(ds, cmbEspecialidad, "IDESPECIALIDAD", "especialidad")
        ds = getGrados()
        loadComboBox(ds, cmbSemestre, "IDSEMESTRE", "grado")
        ds = getGrupos()
        loadComboBox(ds, cmbGrupo, "nombre", "nombre")
        cmbCampus.Text = ""
        cmbLicenciatura.Text = ""
        cmbEspecialidad.Text = ""
    End Sub

    Private Sub pruebaFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarCombos()
    End Sub

    Private Sub consultarcmd_Click(sender As System.Object, e As System.EventArgs) Handles consultarcmd.Click
        Dim b As New BaseDatos
        Dim ds As New DataSet
        variables.sql = "select " & _
                "C.idcalificacion,a.MATRICULA, a.apellido_paterno, a.apellido_materno, a.nombre as nombre_alumno," & _
                "m.IDMATERIA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.extra1, c.extra2,c.extra3,c.extra4 " & _
                "from alumno a " & _
                "inner join calificaciones c on c.Matricula = a.MATRICULA " & _
                "inner join materias m on m.IDMATERIA = c.IDMATERIA " & _
                "where a.IDCAMPUS = '" & cmbCampus.Text & "' and a.IDLICENCIATURA = '" & cmbLicenciatura.Text & "' " & _
                "and a.IDESPECIALIDAD = '" & cmbEspecialidad.Text & "' and a.IDturno = '" & cmbTurno.Text & "' and a.IDSEMESTRE = '" & cmbSemestre.Text & "' and a.IDGRUPO = '" & cmbGrupo.Text & "' " & _
                "and c.IDSEMESTRE='" & cmbSemestre.Text & "' and c.idgrupo='" & cmbGrupo.Text & "' " & _
                "AND c.idlicenciatura='" & cmbLicenciatura.SelectedValue & "'" & _
                "and M.activa=1  " & _
                "group by a.MATRICULA, m.NOMBRE, c.CALIFICACION, c.calificacion2, c.extra1, c.extra2 , c.extra3,c.extra4, m.IDMATERIA, " & _
                " a.apellido_paterno, a.apellido_materno, a.nombre,C.idcalificacion " & _
                "order by a.apellido_paterno,a.apellido_materno, a.nombre"
        b.abrirConexion()
        ds = b.getDataSet(variables.sql)
        Grid.DataSource = ds.Tables(0)
        b.cerrarConexion()
    End Sub
End Class