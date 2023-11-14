Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Security.Permissions

Public Class frmlogin
    Dim conexion As conexion = New conexion()
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub
    Private Sub btingresar_Click(sender As Object, e As EventArgs) Handles btingresar.Click
        Dim sql As String
        If ctusuario.Text = "" Then
            MessageBox.Show("Digite el usuario")
            ctusuario.Focus()
            Exit Sub
        End If
        If ctclave.Text = "" Then
            MessageBox.Show("Digite la clave")
            ctclave.Focus()
            Exit Sub
        End If
        sql = "call consultar_login('" & ctusuario.Text & "','" & ctclave.Text &
"')"
        conexion.fila(sql)
        If conexion.lector.HasRows Then
            centroat.Show()
        Else
            MessageBox.Show("Usuario o Clave Inválido")
            conexion.lector.Close()
            Exit Sub
        End If
        conexion.lector.Close()
        Me.Hide()
    End Sub

    Private Sub Btcancelar_Click(sender As Object, e As EventArgs) Handles Btcancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consultar_libros.Show()
    End Sub
End Class