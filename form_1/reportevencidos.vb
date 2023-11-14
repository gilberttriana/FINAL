Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.office.Interop.Excel
Public Class reportevencidos
    Dim conexion As conexion = New conexion()

    Private Sub Vencidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarPrestamosVencidos()
    End Sub

    Private Sub btexportar_Click(sender As Object, e As EventArgs) Handles btexportar.Click
        GridAExcel(DataGridView1)
    End Sub

    Private Sub MostrarPrestamosVencidos()
        Dim sql As String = "CALL prestamos_vencidos()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub
End Class