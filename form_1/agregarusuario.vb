Public Class agregarusuario
    Dim conexion As conexion = New conexion()

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub agregarusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()
    End Sub
    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_usuarios()"
        conexion.consulta(sql)
        Me.DataGridUsuarios.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Me.ctCod_ident.Text = ""
        Me.ctNombres.Text = ""
        Me.ctApellidos.Text = ""
        Me.ctTel.Text = ""
        Me.ctDir.Text = ""
        Me.FechaNac.Text = ""
        Me.cbSexo.Text = ""
        Me.ctEstadoCivil.Text = ""
        Me.ctCentroEstudio.Text = ""
        Me.ctNombres.Focus()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim sql, rot As String
        Dim res As Boolean
        Dim codigo As Integer
        If ctNombres.Text = "" Then
            MessageBox.Show("Digite el nombre del usuario")
            ctNombres.Focus()
            Exit Sub
        End If
        If ctApellidos.Text = "" Then
            MessageBox.Show("Digite el apellido del usuario")
            ctApellidos.Focus()
            Exit Sub
        End If
        If ctTel.Text = "" Then
            MessageBox.Show("Digite el teléfono del usuario")
            ctTel.Focus()
            Exit Sub
        End If
        If ctDir.Text = "" Then
            MessageBox.Show("Digite la direccion del usuario")
            ctDir.Focus()
            Exit Sub
        End If
        If FechaNac.Text = "" Then
            MessageBox.Show("Digite la fecha de nacimiento del usuario")
            FechaNac.Focus()
            Exit Sub
        End If
        If cbSexo.Text = "" Then
            MessageBox.Show("Digite el sexo del usuario")
            cbSexo.Focus()
            Exit Sub
        End If
        If ctEstadoCivil.Text = "" Then
            MessageBox.Show("Digite el estado civil del usuario")
            ctEstadoCivil.Focus()
            Exit Sub
        End If
        If ctCentroEstudio.Text = "" Then
            MessageBox.Show("Digite el centro de estudio del usuario")
            ctCentroEstudio.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Desea guardar el registro?", "Sistema de Biblioteca ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'verificar si existe el registro
        If ctCod_ident.Text = "" Then
            ctCod_ident.Text = 0
        End If

        sql = "call ver_usuario(" + ctCod_ident.Text + ")"
        conexion.fila(sql)

        If conexion.lector.HasRows Then
            rot = "Actualizado"
            codigo = ctCod_ident.Text
        Else
            rot = "Guardado"
            codigo = ctCod_ident.Text
        End If

        conexion.lector.Close()

        sql = "call insertar_usuario(" & codigo & ",'" & ctNombres.Text & "',
                                     '" & ctApellidos.Text & "',
                                     '" & ctTel.Text & "',
                                     '" & ctDir.Text & "',
                                     '" & FechaNac.Text & "',
                                     '" & cbSexo.Text & "',
                                     '" & ctEstadoCivil.Text & "',
                                     '" & ctCentroEstudio.Text & "')"
        res = conexion.ejecutar(sql)

        If res Then
            MessageBox.Show("Registro " & rot)
        Else
            MessageBox.Show("Error en el proceso de " & rot)
        End If
        ButtonNuevo_Click(Nothing, Nothing)
        RenderData()
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Dim SQL As String
        Dim res As Boolean
        If ctCod_ident.Text = "" Then
            MessageBox.Show("Seleccione un usuario")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        SQL = "call borrar_usuario(" & ctCod_ident.Text & ")"
        res = conexion.ejecutar(SQL)

        If res Then
            MessageBox.Show("Registro Borrado")
        Else
            MessageBox.Show("Error al borrar el registro")
        End If
        ButtonNuevo_Click(Nothing, Nothing)
        RenderData()
    End Sub

    Private Sub DataGridUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuarios.CellContentClick
        Dim codigo As String
        codigo = DataGridUsuarios.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "call ver_usuario(" & codigo & ")"
        conexion.fila(SQL)
        If conexion.lector.Read = True Then
            Me.ctCod_ident.Text = conexion.lector("cod_ident").ToString
            Me.ctNombres.Text = conexion.lector("nombres").ToString
            Me.ctApellidos.Text = conexion.lector("apellidos").ToString
            Me.ctTel.Text = conexion.lector("telefono").ToString
            Me.ctDir.Text = conexion.lector("direccion").ToString
            Me.FechaNac.Text = conexion.lector("fecha_nac").ToString
            Me.cbSexo.Text = conexion.lector("sexo").ToString
            Me.ctEstadoCivil.Text = conexion.lector("estado_civil").ToString
            Me.ctCentroEstudio.Text = conexion.lector("centro_estudio").ToString
        End If
        conexion.lector.Close()
    End Sub
End Class