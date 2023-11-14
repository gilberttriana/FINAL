Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class conexion
    Public cx As MySqlConnection = New MySqlConnection("Server=localhost;Database=biblioteca; Uid=root;Pwd=gilbert12*/;")
    Public cmb As MySqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As MySqlDataAdapter
    Public comando As MySqlCommand
    Public lector As MySqlDataReader
    Public Sub conectar()
        Try
            cx.Open()
            ' MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error en la conexion")
        Finally
            cx.Close()
        End Try
    End Sub
    Public Sub consulta(ByVal sql As String)
        ds.Tables.Clear()
        da = New MySqlDataAdapter(sql, cx)
        cmb = New MySqlCommandBuilder(da)
        da.Fill(ds)
    End Sub
    Public Sub fila(ByVal sql As String)
        If cx.State = ConnectionState.Closed Then
            cx.Open()
        End If
        ds.Tables.Clear()
        comando = New MySqlCommand(sql, cx)
        comando.CommandType = CommandType.Text
        lector = comando.ExecuteReader
    End Sub
    Public Function ejecutar(ByVal sql As String)
        If cx.State = ConnectionState.Closed Then
            cx.Open()
        End If
        comando = New MySqlCommand(sql, cx)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
