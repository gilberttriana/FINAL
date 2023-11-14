Imports MySql.Data.MySqlClient

Public Class reporterangofech

    Dim conn As New MySqlConnection
    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        conn = conectar()
        Dim SQL As String

        Dim fechaPrestamo As String = Inicio.Value.ToString("yyyy-MM-dd")
        Dim fechaEntrega As String = Final.Value.ToString("yyyy-MM-dd")

        SQL = "call prestamoRfechas('" & fechaPrestamo & "','" & fechaEntrega & "')"

        DVG.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcel(DVG)
    End Sub
End Class