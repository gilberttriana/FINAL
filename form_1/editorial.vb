Imports System.Data.SqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class editorial
    Dim conexion As conexion = New conexion()
    Private Sub editorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()

        mostrardatos()

        'cargar los datos del combo pais
        Dim SQL As String
        SQL = "call seleccionar_paises()"
        conexion.consulta(SQL)
        If conexion.ds.Tables(0).Rows.Count > 0 Then
            With Me.CBpais
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = conexion.ds.Tables(0)
                .DisplayMember = "nombre_pais"
                .ValueMember = "cod_pais"
                .SelectedIndex = -1
            End With
        End If
    End Sub
    Public Sub mostrardatos()
        Dim sql As String
        sql = "call seleccionar_editorial()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub Btnuevo_Click(sender As Object, e As EventArgs) Handles Btnuevo.Click
        Me.ctcod_editorial.Text = ""
        Me.cteditorial.Text = ""
        Me.CBpais.SelectedIndex = -1
        Me.cteditorial.Focus()
    End Sub

    Private Sub Btguardar_Click(sender As Object, e As EventArgs) Handles Btguardar.Click
        Dim sql, rot As String
        Dim res As Boolean
        Dim codigo As Integer
        If cteditorial.Text = "" Then
            MessageBox.Show("Digite el nombre del editorial")
            cteditorial.Focus()
            Exit Sub
        End If
        If CBpais.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el pais")
            CBpais.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Desea guardar el registro?", "Sistema de Biblioteca ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
       MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'verificar si existe el registro
        If ctcod_editorial.Text = "" Then
            ctcod_editorial.Text = 0
        End If
        sql = "call ver_editorial(" + ctcod_editorial.Text + ")"
        conexion.fila(sql)
        If conexion.lector.HasRows Then
            rot = "Actualizado"
            codigo = ctcod_editorial.Text
        Else
            rot = "Guardado"
            codigo = ctcod_editorial.Text
        End If
        conexion.lector.Close()
        sql = "call insertar_editorial(" & codigo & ",'" & cteditorial.Text & "'," & CBpais.SelectedValue & ")"
        res = conexion.ejecutar(sql)
        If res Then
            MessageBox.Show("Registro " & rot)
        Else
            MessageBox.Show("Error en el proceso de " & rot)
        End If
        Btnuevo_Click(Nothing, Nothing)
        mostrardatos()
    End Sub

    Private Sub Btborrar_Click(sender As Object, e As EventArgs) Handles Btborrar.Click
        Dim SQL As String
        Dim res As Boolean
        If ctcod_editorial.Text = "" Then
            MessageBox.Show("Seleccione un autor")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        SQL = "call borrar_autor(" & ctcod_editorial.Text & ")"
        res = conexion.ejecutar(SQL)
        If res Then
            MessageBox.Show("Registro Borrado")
        Else
            MessageBox.Show("Error al borrar el registro")
        End If
        Btnuevo_Click(Nothing, Nothing)
        mostrardatos()
    End Sub

    Private Sub Btsalir_Click(sender As Object, e As EventArgs) Handles Btsalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim codigo As String
        codigo = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "call ver_editorial(" & codigo & ")"
        conexion.fila(SQL)
        If conexion.lector.Read = True Then
            Me.ctcod_editorial.Text = conexion.lector("cod_editorial").ToString
            Me.cteditorial.Text = conexion.lector("nombre_editorial").ToString
            Me.CBpais.SelectedValue = conexion.lector("cod_pais").ToString
        End If
        conexion.lector.Close()
    End Sub
End Class