<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libro
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ctcod_libro = New System.Windows.Forms.TextBox()
        Me.cttitulo = New System.Windows.Forms.TextBox()
        Me.ctejemplares = New System.Windows.Forms.TextBox()
        Me.ctnpag = New System.Windows.Forms.TextBox()
        Me.cbeditorial = New System.Windows.Forms.ComboBox()
        Me.cbidioma = New System.Windows.Forms.ComboBox()
        Me.cbedicion = New System.Windows.Forms.ComboBox()
        Me.cbautor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfechapub = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbautores = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(714, 159)
        Me.DataGridView1.TabIndex = 0
        '
        'ctcod_libro
        '
        Me.ctcod_libro.Location = New System.Drawing.Point(64, 193)
        Me.ctcod_libro.Name = "ctcod_libro"
        Me.ctcod_libro.Size = New System.Drawing.Size(86, 20)
        Me.ctcod_libro.TabIndex = 1
        Me.ctcod_libro.Visible = False
        '
        'cttitulo
        '
        Me.cttitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cttitulo.Location = New System.Drawing.Point(64, 230)
        Me.cttitulo.Name = "cttitulo"
        Me.cttitulo.Size = New System.Drawing.Size(181, 20)
        Me.cttitulo.TabIndex = 2
        '
        'ctejemplares
        '
        Me.ctejemplares.Location = New System.Drawing.Point(64, 312)
        Me.ctejemplares.Name = "ctejemplares"
        Me.ctejemplares.Size = New System.Drawing.Size(104, 20)
        Me.ctejemplares.TabIndex = 3
        '
        'ctnpag
        '
        Me.ctnpag.Location = New System.Drawing.Point(278, 315)
        Me.ctnpag.Name = "ctnpag"
        Me.ctnpag.Size = New System.Drawing.Size(86, 20)
        Me.ctnpag.TabIndex = 4
        '
        'cbeditorial
        '
        Me.cbeditorial.FormattingEnabled = True
        Me.cbeditorial.Location = New System.Drawing.Point(64, 255)
        Me.cbeditorial.Name = "cbeditorial"
        Me.cbeditorial.Size = New System.Drawing.Size(181, 21)
        Me.cbeditorial.TabIndex = 5
        '
        'cbidioma
        '
        Me.cbidioma.FormattingEnabled = True
        Me.cbidioma.Items.AddRange(New Object() {"Español", "Ingles", "Frances", "Latin"})
        Me.cbidioma.Location = New System.Drawing.Point(64, 345)
        Me.cbidioma.Name = "cbidioma"
        Me.cbidioma.Size = New System.Drawing.Size(104, 21)
        Me.cbidioma.TabIndex = 6
        '
        'cbedicion
        '
        Me.cbedicion.FormattingEnabled = True
        Me.cbedicion.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbedicion.Location = New System.Drawing.Point(64, 370)
        Me.cbedicion.Name = "cbedicion"
        Me.cbedicion.Size = New System.Drawing.Size(104, 21)
        Me.cbedicion.TabIndex = 7
        '
        'cbautor
        '
        Me.cbautor.FormattingEnabled = True
        Me.cbautor.Location = New System.Drawing.Point(393, 206)
        Me.cbautor.Name = "cbautor"
        Me.cbautor.Size = New System.Drawing.Size(123, 21)
        Me.cbautor.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 40)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(530, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 40)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btnuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(596, 307)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 126)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(16, 99)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 20)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 74)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 20)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Borrar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 43)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 20)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnuevo
        '
        Me.btnuevo.Location = New System.Drawing.Point(16, 18)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(64, 20)
        Me.btnuevo.TabIndex = 0
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Titulo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Editorial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha pub:"
        '
        'dtpfechapub
        '
        Me.dtpfechapub.Location = New System.Drawing.Point(64, 280)
        Me.dtpfechapub.Name = "dtpfechapub"
        Me.dtpfechapub.Size = New System.Drawing.Size(181, 20)
        Me.dtpfechapub.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ejemplares:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Idioma:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Edicion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(337, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Autores:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Numero de paginas:"
        '
        'lbautores
        '
        Me.lbautores.FormattingEnabled = True
        Me.lbautores.Location = New System.Drawing.Point(393, 231)
        Me.lbautores.Name = "lbautores"
        Me.lbautores.Size = New System.Drawing.Size(123, 82)
        Me.lbautores.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(393, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 47)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Exportar Datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(735, 457)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbautores)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpfechapub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbautor)
        Me.Controls.Add(Me.cbedicion)
        Me.Controls.Add(Me.cbidioma)
        Me.Controls.Add(Me.cbeditorial)
        Me.Controls.Add(Me.ctnpag)
        Me.Controls.Add(Me.ctejemplares)
        Me.Controls.Add(Me.cttitulo)
        Me.Controls.Add(Me.ctcod_libro)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "libro"
        Me.Text = "PanelLibros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ctcod_libro As TextBox
    Friend WithEvents cttitulo As TextBox
    Friend WithEvents ctejemplares As TextBox
    Friend WithEvents ctnpag As TextBox
    Friend WithEvents cbeditorial As ComboBox
    Friend WithEvents cbidioma As ComboBox
    Friend WithEvents cbedicion As ComboBox
    Friend WithEvents cbautor As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfechapub As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbautores As ListBox
    Friend WithEvents Button3 As Button
End Class
