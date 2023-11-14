<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarusuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Text = "agregarusuario"
        Me.DataGridUsuarios = New System.Windows.Forms.DataGridView()
        Me.TextBoxEmpty = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonBorrar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ctNombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ctApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ctTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ctDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ctCentroEstudio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ctEstadoCivil = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.ctCod_ident = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridUsuarios
        '
        Me.DataGridUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsuarios.Location = New System.Drawing.Point(24, 288)
        Me.DataGridUsuarios.Name = "DataGridUsuarios"
        Me.DataGridUsuarios.Size = New System.Drawing.Size(485, 229)
        Me.DataGridUsuarios.TabIndex = 20
        '
        'TextBoxEmpty
        '
        Me.TextBoxEmpty.Location = New System.Drawing.Point(359, 542)
        Me.TextBoxEmpty.Name = "TextBoxEmpty"
        Me.TextBoxEmpty.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxEmpty.TabIndex = 19
        Me.TextBoxEmpty.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonNuevo)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.ButtonBorrar)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 71)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Location = New System.Drawing.Point(20, 25)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(120, 30)
        Me.ButtonNuevo.TabIndex = 5
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(183, 25)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonGuardar.TabIndex = 6
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.Location = New System.Drawing.Point(337, 25)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonBorrar.TabIndex = 7
        Me.ButtonBorrar.Text = "Borrar"
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(24, 536)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(120, 30)
        Me.ButtonSalir.TabIndex = 16
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ctNombres
        '
        Me.ctNombres.Location = New System.Drawing.Point(24, 37)
        Me.ctNombres.Name = "ctNombres"
        Me.ctNombres.Size = New System.Drawing.Size(150, 20)
        Me.ctNombres.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombres"
        '
        'ctApellidos
        '
        Me.ctApellidos.Location = New System.Drawing.Point(191, 37)
        Me.ctApellidos.Name = "ctApellidos"
        Me.ctApellidos.Size = New System.Drawing.Size(150, 20)
        Me.ctApellidos.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(191, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Apellidos"
        '
        'ctTel
        '
        Me.ctTel.Location = New System.Drawing.Point(364, 37)
        Me.ctTel.Name = "ctTel"
        Me.ctTel.Size = New System.Drawing.Size(150, 20)
        Me.ctTel.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(364, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Teléfono"
        '
        'ctDir
        '
        Me.ctDir.Location = New System.Drawing.Point(24, 94)
        Me.ctDir.Name = "ctDir"
        Me.ctDir.Size = New System.Drawing.Size(150, 20)
        Me.ctDir.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(24, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(191, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(364, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Sexo"
        '
        'ctCentroEstudio
        '
        Me.ctCentroEstudio.Location = New System.Drawing.Point(191, 156)
        Me.ctCentroEstudio.Name = "ctCentroEstudio"
        Me.ctCentroEstudio.Size = New System.Drawing.Size(150, 20)
        Me.ctCentroEstudio.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(191, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Centro de Estudio"
        '
        'ctEstadoCivil
        '
        Me.ctEstadoCivil.Location = New System.Drawing.Point(24, 155)
        Me.ctEstadoCivil.Name = "ctEstadoCivil"
        Me.ctEstadoCivil.Size = New System.Drawing.Size(150, 20)
        Me.ctEstadoCivil.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(24, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Estado civil"
        '
        'FechaNac
        '
        Me.FechaNac.CustomFormat = "yyyy-MM-dd"
        Me.FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaNac.Location = New System.Drawing.Point(195, 98)
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.Size = New System.Drawing.Size(146, 20)
        Me.FechaNac.TabIndex = 35
        '
        'ctCod_ident
        '
        Me.ctCod_ident.Location = New System.Drawing.Point(364, 155)
        Me.ctCod_ident.Name = "ctCod_ident"
        Me.ctCod_ident.Size = New System.Drawing.Size(150, 20)
        Me.ctCod_ident.TabIndex = 37
        Me.ctCod_ident.Visible = False
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cbSexo.Location = New System.Drawing.Point(364, 97)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(121, 21)
        Me.cbSexo.TabIndex = 38
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 582)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.ctCod_ident)
        Me.Controls.Add(Me.FechaNac)
        Me.Controls.Add(Me.ctCentroEstudio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ctEstadoCivil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ctDir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ctTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ctApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridUsuarios)
        Me.Controls.Add(Me.TextBoxEmpty)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ctNombres)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Usuario"
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridUsuarios As DataGridView
    Friend WithEvents TextBoxEmpty As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ctNombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ctApellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ctTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ctDir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ctCentroEstudio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ctEstadoCivil As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents FechaNac As DateTimePicker
    Friend WithEvents ctCod_ident As TextBox
    Friend WithEvents cbSexo As ComboBox
End Class
