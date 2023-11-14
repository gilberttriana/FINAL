Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports MySql.Data
Public Class consultar_libros
    Dim conexion As conexion = New conexion()
    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        cbtipo.Items.Add("libro")
        cbtipo.Items.Add("Autor")
        cbtipo.Items.Add("Editorial")
    End Sub


    Private Sub btvolver_Click(sender As Object, e As EventArgs) Handles btvolver.Click
        frmlogin.Show()
        Me.Close()
    End Sub


    Private Sub cbtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipo.SelectedIndexChanged
        Dim opcionSeleccionada As String = cbtipo.Text

        Select Case opcionSeleccionada
            Case "libro"
                mostrarlibros()
            Case "Autor"
                mostrarautores()
            Case "Editorial"
                MostrarEditoriales()
            Case Else
                ' Acciones para un caso por defecto si no se selecciona una de las opciones anteriores.
                DataGridView1.DataSource = Nothing ' Limpia el DataGridView si es necesario.
        End Select
    End Sub

    Private Sub mostrarlibros()
        Dim sql As String
        sql = "call seleccionar_libro()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub mostrarautores()
        Dim sql As String
        sql = "call seleccionar_autores()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub MostrarEditoriales()
        Dim sql As String
        sql = "call seleccionar_editorial()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub


    Private Sub librostitulos(filtro As String)
        Dim sql As String
        sql = "call librostitulos('" & filtro & "')"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub AutoresPorNombre(filtro As String)
        Dim sql As String
        sql = "call AutoresPorNombre('" & filtro & "')"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub editorialesPorNombre(filtro As String)
        Dim sql As String
        sql = "call editorialesPorNombre('" & filtro & "')"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub
    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btbuscar.Click
        Dim opcionSeleccionada As String = cbtipo.Text
        Dim filtro As String = ctbusq.Text

        Select Case opcionSeleccionada
            Case "libro"
                librostitulos(filtro)
            Case "Autor"
                AutoresPorNombre(filtro)
            Case "Editorial"
                editorialesPorNombre(filtro)
            Case Else
                ' Acciones para un caso por defecto si no se selecciona una de las opciones anteriores.
                DataGridView1.DataSource = Nothing
        End Select
        DataGridView1.Refresh()

    End Sub

End Class