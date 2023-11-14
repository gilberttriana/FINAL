Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class bibliotecario
    Dim conexion As conexion = New conexion()

    Private Sub bibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamar al método conectar para establecer la conexión con la base de datos
        conexion.conectar()
        ' Llamar a la función mostrardatos para visualizar los datos en el grid
        MostrarDatos()
        ' Cargar los datos del combo país
        Dim SQL As String
        SQL = "call seleccionar_bibliotecario()"
        conexion.consulta(SQL)
    End Sub
    Public Sub MostrarDatos()
        Dim sql As String
        sql = "call seleccionar_bibliotecario()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        Dim sql, rot As String
        Dim res As Boolean
        Dim codigo As Integer
        If ctnombre.Text = "" Then
            MessageBox.Show("Digite el nombre del bibliotecario")
            ctnombre.Focus()
            Exit Sub
        End If

        If ctapellido.Text = "" Then
            MessageBox.Show("Digite el apellido del bibliotecario")
            ctapellido.Focus()
            Exit Sub
        End If
        If ctdireccion.Text = "" Then
            MessageBox.Show("Digite la direccion del bibliotecario")
            ctdireccion.Focus()
            Exit Sub
        End If
        If ctcargo.Text = "" Then
            MessageBox.Show("Digite el cargo del bibliotecario")
            ctapellido.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Desea guardar el registro?", "Sistema de Biblioteca ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'verificar si existe el registro
        If ctcod_bibliotecario.Text = "" Then
            ctcod_bibliotecario.Text = 0
        End If
        sql = "call ver_bibliotecario(" + ctcod_bibliotecario.Text + ")"
        conexion.fila(sql)
        If conexion.lector.HasRows Then
            rot = "Actualizado"
            codigo = ctcod_bibliotecario.Text
        Else
            rot = "Guardado"
            codigo = ctcod_bibliotecario.Text
        End If
        conexion.lector.Close()
        sql = "call insertar_bibliotecario(" & codigo & ",'" & ctnombre.Text & "','" & ctapellido.Text & "','" & ctdireccion.Text & "','" & ctcargo.Text & "')"
        res = conexion.ejecutar(sql)
        If res Then
            MessageBox.Show("Registro " & rot)
        Else
            MessageBox.Show("Error en el proceso de " & rot)
        End If
        btnuevo_Click(Nothing, Nothing)
        MostrarDatos()
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.ctcod_bibliotecario.Text = ""
        Me.ctnombre.Text = ""
        Me.ctapellido.Text = ""
        Me.ctdireccion.Text = ""
        Me.ctcargo.Text = ""
        Me.ctnombre.Focus()
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        Dim SQL As String
        Dim res As Boolean
        If ctcod_bibliotecario.Text = "" Then
            MessageBox.Show("Seleccione un biblitecario")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        SQL = "call borrar_bibliotecario(" & ctcod_bibliotecario.Text & ")"
        res = conexion.ejecutar(SQL)
        If res Then
            MessageBox.Show("Registro Borrado")
        Else
            MessageBox.Show("Error al borrar el registro")
        End If
        btnuevo_Click(Nothing, Nothing)
        MostrarDatos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim codigo As String
        codigo = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "call ver_bibliotecario(" & codigo & ")"
        conexion.fila(SQL)

        If conexion.lector.Read = True Then
            Me.ctcod_bibliotecario.Text = conexion.lector("cod_bibliotecario").ToString
            Me.ctnombre.Text = conexion.lector("nombres").ToString
            Me.ctapellido.Text = conexion.lector("apellidos").ToString
            Me.ctdireccion.Text = conexion.lector("direccion").ToString
            Me.ctcargo.Text = conexion.lector("cargo").ToString
        End If
        conexion.lector.Close()
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub
End Class