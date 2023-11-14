Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class libro

    Dim conn As New MySqlConnection
    Private Sub PanelLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'asignamos la conexión a la variable conn
        conn = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT
a.cod_libro,a.titulo,b.nombre_editorial,a.fecha_pub,a.ejemplares,a.n_pag,a.idioma
,a.edicion FROM libro a inner join editorial b on a.cod_editorial=b.cod_editorial
order by a.titulo"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        'cargar los datos del combo editorial
        SQL = "SELECT * FROM editorial order by nombre_editorial"
        Dim da1 As New MySqlDataAdapter(SQL, conn)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count > 0 Then
            With Me.cbeditorial
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = ds1.Tables(0)
                .DisplayMember = "nombre_editorial"
                .ValueMember = "cod_editorial"
                .SelectedIndex = -1
            End With
        End If
        'cargar los datos del combo autor
        SQL = "SELECT * FROM autor order by nombre_autor"
        da1 = New MySqlDataAdapter(SQL, conn)
        ds1 = New DataSet
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count > 0 Then
            With Me.cbautor
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = ds1.Tables(0)
                .DisplayMember = "nombre_autor"
                .ValueMember = "cod_autor"
                .SelectedIndex = -1
            End With
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbautor.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el autor")
            cbautor.Focus()
            Exit Sub
        End If
        lbautores.Items.Add(cbautor.Text + "-" + cbautor.SelectedValue.ToString)
        cbautor.SelectedValue = -1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lbautores.SelectedIndex <> -1 Then
            lbautores.Items.RemoveAt(lbautores.SelectedIndex)
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        ctcod_libro.Clear()
        cttitulo.Clear()
        cbeditorial.SelectedIndex = -1
        dtpfechapub.Text = Now
        ctejemplares.Clear()
        ctnpag.Clear()
        cbidioma.SelectedIndex = -1
        cbedicion.SelectedIndex = -1
        cttitulo.Focus()
        cbautor.SelectedIndex = -1
        lbautores.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cttitulo.Text = "" Then
            MessageBox.Show("Digite el título del libro")
            cttitulo.Focus()
            Exit Sub
        End If
        If cbeditorial.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la editorial")
            cbeditorial.Focus()
            Exit Sub
        End If
        If dtpfechapub.Text = "" Then
            MessageBox.Show("seleccione la fecha de publicación")
            dtpfechapub.Focus()
            Exit Sub
        End If
        If ctejemplares.Text = "" Then
            MessageBox.Show("Digite el número de ejemplares")
            ctejemplares.Focus()
            Exit Sub
        End If
        If ctnpag.Text = "" Then
            MessageBox.Show("Digite el número de ejemplares")
            ctnpag.Focus()
            Exit Sub
        End If
        If cbidioma.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el idioma")
            cbidioma.Focus()
            Exit Sub
        End If
        If cbedicion.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la edición")
            cbedicion.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Biblioteca",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) =
        Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL, var As String
        If (ctcod_libro.Text = "") Then
            ctcod_libro.Text = 0
        End If

        SQL = "select cod_libro from libro WHERE cod_libro = " + ctcod_libro.Text
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then

            Dim fechaMySQL As String = dtpfechapub.Value.ToString("yyyy-MM-dd")
            var = "Actualizado"
            SQL = "UPDATE libro set titulo='" + cttitulo.Text + "' " &
            ",cod_editorial=" + cbeditorial.SelectedValue.ToString +
           ",fecha_pub='" + fechaMySQL + "'" &
            ",ejemplares=" + ctejemplares.Text + ",n_pag='" + ctnpag.Text + "'" & ",idioma='" + cbidioma.Text + "',edicion='" + cbedicion.Text + "'" & " where cod_libro=" & ctcod_libro.Text
        Else

            Dim fechaMySQL As String = dtpfechapub.Value.ToString("yyyy-MM-dd")
            var = "Guardado"
            SQL = "INSERT INTO libro values(default,'" & cttitulo.Text & "'," & cbeditorial.SelectedValue & ",'" & fechaMySQL & "'," & ctejemplares.Text & "," & ctnpag.Text & ",'" & cbidioma.Text & "'," & cbedicion.Text & ")"
        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        Dim codigo_libro As Integer
        If ctcod_libro.Text = 0 Then
            'visualizar el último codigo insertado
            SQL = "SELECT last_insert_id() as id"
            Dim cmd2 As New MySqlCommand(SQL, conn)
            cmd2.CommandType = CommandType.Text
            lectura = cmd2.ExecuteReader()
            If lectura.Read = True Then
                codigo_libro = lectura("id").ToString
            End If
            lectura.Close()
        Else
            codigo_libro = ctcod_libro.Text
        End If
        Dim total, i As Integer
        Dim a() As String
        total = lbautores.Items.Count - 1
        'borrar los autores de ese libro en relacion_libro autor
        cmd.CommandText = "delete from relacion_libro_autor where cod_libro=" +
       ctcod_libro.Text
        cmd.ExecuteNonQuery()
        For i = 0 To total
            a = Split(lbautores.Items(i).ToString, "-")
            SQL = " insert into relacion_libro_autor values(" +
codigo_libro.ToString + "," + a(1).ToString + ")"
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()
        Next
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT
a.cod_libro,a.titulo,b.nombre_editorial,a.fecha_pub,a.ejemplares,a.n_pag,a.idioma
,a.edicion FROM libro a inner join editorial b on a.cod_editorial=b.cod_editorial
order by a.titulo"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
        MessageBox.Show("Registro " & var)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim libro As String
        libro = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "SELECT * FROM libro WHERE cod_libro = '" & libro & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            Me.ctcod_libro.Text = lectura("cod_libro").ToString
            Me.cttitulo.Text = lectura("titulo").ToString
            Me.cbeditorial.SelectedValue = lectura("cod_editorial").ToString
            Me.dtpfechapub.Text = lectura("fecha_pub").ToString
            Me.ctejemplares.Text = lectura("ejemplares").ToString
            Me.ctnpag.Text = lectura("n_pag").ToString
            Me.cbidioma.Text = lectura("idioma").ToString
            Me.cbedicion.Text = lectura("edicion").ToString
        End If
        lectura.Close()
        SQL = "select b.nombre_autor,a.cod_autor from relacion_libro_autor a
inner join autor b on a.cod_autor=b.cod_autor WHERE a.cod_libro = " +
ctcod_libro.Text
        cmd.CommandText = SQL
        lectura = cmd.ExecuteReader
        lbautores.Items.Clear()
        While lectura.Read
            lbautores.Items.Add(lectura("nombre_autor").ToString + "-" +
lectura("cod_autor").ToString)
        End While
        lectura.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GridAExcel(DataGridView1)
    End Sub
End Class