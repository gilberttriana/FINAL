Public Class centroat
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Reporteusuario.Show()
    End Sub

    Private Sub LibroxpaisToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub EditorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorialToolStripMenuItem.Click
        editorial.Show()
    End Sub

    Private Sub AutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoresToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        libro.Show()
    End Sub

    Private Sub BibliotecarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecarioToolStripMenuItem.Click
        bibliotecario.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        agregarusuario.Show()
    End Sub
    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click
        prestamos.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        stockdlibros.Show()
    End Sub

    Private Sub PrestamosvencidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosvencidosToolStripMenuItem.Click
        reportevencidos.Show()
    End Sub

    Private Sub UsuariosmultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosmultasToolStripMenuItem.Click
        Reporteusuario.Show()
    End Sub

    Private Sub FureaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FureaDeToolStripMenuItem.Click
        reporterangofech.Show()
    End Sub
    Private Sub PorpaisToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PorpaisToolStripMenuItem.Click
        Reporteporpais.Show()
    End Sub
End Class