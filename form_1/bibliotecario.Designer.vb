<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bibliotecario
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
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.btborrar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.ctcod_bibliotecario = New System.Windows.Forms.TextBox()
        Me.ctnombre = New System.Windows.Forms.TextBox()
        Me.ctapellido = New System.Windows.Forms.TextBox()
        Me.ctdireccion = New System.Windows.Forms.TextBox()
        Me.ctcargo = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'btnuevo
        '
        Me.btnuevo.Location = New System.Drawing.Point(16, 19)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnuevo.TabIndex = 1
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = True
        '
        'btborrar
        '
        Me.btborrar.Location = New System.Drawing.Point(16, 69)
        Me.btborrar.Name = "btborrar"
        Me.btborrar.Size = New System.Drawing.Size(75, 25)
        Me.btborrar.TabIndex = 2
        Me.btborrar.Text = "Eliminar"
        Me.btborrar.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(119, 19)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(75, 23)
        Me.btguardar.TabIndex = 3
        Me.btguardar.Text = "guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'btsalir
        '
        Me.btsalir.Location = New System.Drawing.Point(119, 69)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(75, 23)
        Me.btsalir.TabIndex = 4
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = True
        '
        'ctcod_bibliotecario
        '
        Me.ctcod_bibliotecario.Location = New System.Drawing.Point(152, 233)
        Me.ctcod_bibliotecario.Name = "ctcod_bibliotecario"
        Me.ctcod_bibliotecario.Size = New System.Drawing.Size(100, 20)
        Me.ctcod_bibliotecario.TabIndex = 5
        Me.ctcod_bibliotecario.Visible = False
        '
        'ctnombre
        '
        Me.ctnombre.Location = New System.Drawing.Point(152, 261)
        Me.ctnombre.Name = "ctnombre"
        Me.ctnombre.Size = New System.Drawing.Size(100, 20)
        Me.ctnombre.TabIndex = 6
        '
        'ctapellido
        '
        Me.ctapellido.Location = New System.Drawing.Point(152, 287)
        Me.ctapellido.Name = "ctapellido"
        Me.ctapellido.Size = New System.Drawing.Size(100, 20)
        Me.ctapellido.TabIndex = 7
        '
        'ctdireccion
        '
        Me.ctdireccion.Location = New System.Drawing.Point(152, 317)
        Me.ctdireccion.Name = "ctdireccion"
        Me.ctdireccion.Size = New System.Drawing.Size(171, 20)
        Me.ctdireccion.TabIndex = 8
        '
        'ctcargo
        '
        Me.ctcargo.Location = New System.Drawing.Point(152, 343)
        Me.ctcargo.Name = "ctcargo"
        Me.ctcargo.Size = New System.Drawing.Size(100, 20)
        Me.ctcargo.TabIndex = 9
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(35, 262)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(72, 19)
        Me.nombre.TabIndex = 10
        Me.nombre.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "cargo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnuevo)
        Me.GroupBox1.Controls.Add(Me.btguardar)
        Me.GroupBox1.Controls.Add(Me.btborrar)
        Me.GroupBox1.Controls.Add(Me.btsalir)
        Me.GroupBox1.Location = New System.Drawing.Point(396, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 104)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'bibliotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.ctcargo)
        Me.Controls.Add(Me.ctdireccion)
        Me.Controls.Add(Me.ctapellido)
        Me.Controls.Add(Me.ctnombre)
        Me.Controls.Add(Me.ctcod_bibliotecario)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "bibliotecario"
        Me.Text = "bibliotecario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnuevo As Button
    Friend WithEvents btborrar As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents btsalir As Button
    Friend WithEvents ctcod_bibliotecario As TextBox
    Friend WithEvents ctnombre As TextBox
    Friend WithEvents ctapellido As TextBox
    Friend WithEvents ctdireccion As TextBox
    Friend WithEvents ctcargo As TextBox
    Friend WithEvents nombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
