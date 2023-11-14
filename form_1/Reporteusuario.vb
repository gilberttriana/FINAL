Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class Reporteusuario
    Dim conexion As conexion = New conexion()
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub multados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarios_con_multa()
    End Sub
    Private Sub usuarios_con_multa()
        Dim sql As String
        sql = "call usuarios_con_multa()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub btexportar_Click(sender As Object, e As EventArgs) Handles btexportar.Click
        GridAExcel(DataGridView1)
    End Sub
End Class