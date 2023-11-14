Imports System.Data.SqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class prestamos
    Dim conn As New MySqlConnection

    Private Sub Prestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'asignamos la conexión a la variable conn
        conn = conectar()


        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * FROM prestamo;"
        DataGridView1.DataSource = cargar_grid(SQL, conn)

        'cargar los datos del combo libro
        SQL = "SELECT cod_libro, titulo FROM libro where ejemplares >= 1 "
        Dim da1 As New MySqlDataAdapter(SQL, conn)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count > 0 Then
            With Me.CbLibro
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = ds1.Tables(0)
                .DisplayMember = "titulo"
                .ValueMember = "cod_libro"
                .SelectedIndex = -1
            End With
        End If

        'cargar los datos del combo Usuario
        SQL = "SELECT cod_ident, nombres FROM usuario "
        Dim da2 As New MySqlDataAdapter(SQL, conn)
        Dim ds2 As New DataSet
        da2.Fill(ds2)
        If ds2.Tables(0).Rows.Count > 0 Then
            With Me.cbusuario
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = ds2.Tables(0)
                .DisplayMember = "nombres"
                .ValueMember = "cod_ident"
                .SelectedIndex = -1
            End With
        End If

        'cargar los datos del combo bibliotecario
        SQL = "SELECT cod_bibliotecario, nombres FROM bibliotecario "
        Dim da3 As New MySqlDataAdapter(SQL, conn)
        Dim ds3 As New DataSet
        da3.Fill(ds3)
        If ds3.Tables(0).Rows.Count > 0 Then
            With Me.CbBibliotecario
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = ds3.Tables(0)
                .DisplayMember = "nombres"
                .ValueMember = "cod_bibliotecario"
                .SelectedIndex = -1
            End With
        End If
    End Sub
    Dim conexion As conexion = New conexion()
    Public Sub mostrardatos()
        Dim sql As String
        sql = "call seleccionar_prestamo()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub
    Private Sub BtnPrestar_Click(sender As Object, e As EventArgs) Handles BtnPrestar.Click

        Dim fechaSeleccionada As Date = dtfecha.Value
        Dim fechaFormateada As String = fechaSeleccionada.ToString("yyyy-MM-dd")
        Dim fechaSeleccionada2 As Date = dtfecha2.Value
        Dim fechaFormateada2 As String = fechaSeleccionada2.ToString("yyyy-MM-dd")
        Dim sql, rot As String
        Dim res As Boolean
        Dim codigo As Integer
        Dim multa As Double = 0
        If cttipo_prestamo.Text = "" Then
            MessageBox.Show("Asigne un Tipo de Prestamo")
            cttipo_prestamo.Focus()
            Exit Sub
        End If
        If CbLibro.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un libro")
            CbLibro.Focus()
            Exit Sub
        End If
        If cbusuario.SelectedIndex = -1 Then
            MessageBox.Show("Registre al usuario")
            cbusuario.Focus()
            Exit Sub
        End If
        If CbBibliotecario.SelectedIndex = -1 Then
            MessageBox.Show("Registre al bibliotecario")
            CbBibliotecario.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Biblioteca ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'verificar si existe el registro 
        If ctcod_prestamo.Text = "" Then
            ctcod_prestamo.Text = 0
        End If
        ' multa 
        If dtfecha2.Value < DateTime.Now Then
            multa = 100
        Else
            multa = 0
        End If
        sql = "call ver_prestamo(" + ctcod_prestamo.Text + ")"
        conexion.fila(sql)
        If conexion.lector.HasRows Then
            rot = "Actualizado"
            codigo = ctcod_prestamo.Text
        Else
            rot = "Guardado"
            codigo = ctcod_prestamo.Text
        End If
        If ctmulta.Text = "" Then
            ctmulta.Text = 0
        End If
        conexion.lector.Close()
        sql = "call insertar_prestamo(" & codigo & ",'" & CbLibro.SelectedValue & "','" & fechaFormateada & "','" & fechaFormateada2 & "','" & cbusuario.SelectedValue & "','" & cttipo_prestamo.Text & "','" & CbBibliotecario.SelectedValue & "','" & ctentregado.Text & "','" & multa & "')"
        res = conexion.ejecutar(sql)
        If res Then
            MessageBox.Show("Registro " & rot)
        Else
            MessageBox.Show("Error en el proceso de " & rot)
        End If
        btnuevo_Click(Nothing, Nothing)
        mostrardatos()
    End Sub

    Private Sub DGVprestamos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim codigo As String
        codigo = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "call ver_prestamo(" & codigo & ")"
        conexion.fila(SQL)
        If conexion.lector.Read = True Then
            Me.ctcod_prestamo.Text = conexion.lector("cod_prestamo").ToString
            Me.CbLibro.SelectedValue = conexion.lector("cod_libro").ToString
            Me.dtfecha.Text = conexion.lector("fecha_pres")
            Me.dtfecha2.Text = conexion.lector("fecha_ent")
            Me.cbusuario.SelectedValue = conexion.lector("cod_ident").ToString
            Me.cttipo_prestamo.Text = conexion.lector("tipo_prestamo").ToString
            Me.CbBibliotecario.SelectedValue = conexion.lector("cod_bibliotecario").ToString
            Me.ctentregado.Text = conexion.lector("entregado").ToString
            Me.ctmulta.Text = conexion.lector("multa").ToString
        End If
        conexion.lector.Close()
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.dtfecha.Text = ""
        Me.dtfecha2.Text = ""
        Me.ctmulta.Text = ""
        Me.cbusuario.SelectedItem = ""
        Me.CbLibro.SelectedIndex = -1
        Me.CbBibliotecario.SelectedItem = ""
        Me.ctcod_prestamo.Text = ""
        Me.ctentregado.Text = ""
        Me.cttipo_prestamo.SelectedIndex = -1
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        Dim SQL As String
        Dim res As Boolean
        If ctcod_prestamo.Text = "" Then
            MessageBox.Show("Seleccione un prestamo")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        SQL = "call borrar_prestamo(" & ctcod_prestamo.Text & ")"
        res = conexion.ejecutar(SQL)
        If res Then
            MessageBox.Show("Registro Borrado")
        Else
            MessageBox.Show("Error al borrar el registro")
        End If
        btnuevo_Click(Nothing, Nothing)
        mostrardatos()

    End Sub
End Class