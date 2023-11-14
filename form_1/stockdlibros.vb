Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class stockdlibros
    Dim conn As New MySqlConnection

    Private Sub StockLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = conectar()
        Dim SQL As String

        SQL = "call ver_stock()"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub
End Class