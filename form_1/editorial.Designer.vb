<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editorial
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
        Me.ctcod_editorial = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btguardar = New System.Windows.Forms.Button()
        Me.Btnuevo = New System.Windows.Forms.Button()
        Me.Btborrar = New System.Windows.Forms.Button()
        Me.Btsalir = New System.Windows.Forms.Button()
        Me.cteditorial = New System.Windows.Forms.TextBox()
        Me.CBpais = New System.Windows.Forms.ComboBox()
        Me.PAIS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(441, 150)
        Me.DataGridView1.TabIndex = 19
        '
        'ctcod_editorial
        '
        Me.ctcod_editorial.Location = New System.Drawing.Point(122, 181)
        Me.ctcod_editorial.Name = "ctcod_editorial"
        Me.ctcod_editorial.Size = New System.Drawing.Size(121, 20)
        Me.ctcod_editorial.TabIndex = 18
        Me.ctcod_editorial.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btguardar)
        Me.GroupBox1.Controls.Add(Me.Btnuevo)
        Me.GroupBox1.Controls.Add(Me.Btborrar)
        Me.GroupBox1.Controls.Add(Me.Btsalir)
        Me.GroupBox1.Location = New System.Drawing.Point(308, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 147)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Btguardar
        '
        Me.Btguardar.Location = New System.Drawing.Point(38, 112)
        Me.Btguardar.Name = "Btguardar"
        Me.Btguardar.Size = New System.Drawing.Size(75, 23)
        Me.Btguardar.TabIndex = 5
        Me.Btguardar.Text = "guardar"
        Me.Btguardar.UseVisualStyleBackColor = True
        '
        'Btnuevo
        '
        Me.Btnuevo.Location = New System.Drawing.Point(38, 83)
        Me.Btnuevo.Name = "Btnuevo"
        Me.Btnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btnuevo.TabIndex = 4
        Me.Btnuevo.Text = "nuevo"
        Me.Btnuevo.UseVisualStyleBackColor = True
        '
        'Btborrar
        '
        Me.Btborrar.Location = New System.Drawing.Point(38, 22)
        Me.Btborrar.Name = "Btborrar"
        Me.Btborrar.Size = New System.Drawing.Size(75, 23)
        Me.Btborrar.TabIndex = 3
        Me.Btborrar.Text = "borrar"
        Me.Btborrar.UseVisualStyleBackColor = True
        '
        'Btsalir
        '
        Me.Btsalir.Location = New System.Drawing.Point(38, 54)
        Me.Btsalir.Name = "Btsalir"
        Me.Btsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btsalir.TabIndex = 2
        Me.Btsalir.Text = "salir"
        Me.Btsalir.UseVisualStyleBackColor = True
        '
        'cteditorial
        '
        Me.cteditorial.Location = New System.Drawing.Point(122, 219)
        Me.cteditorial.Name = "cteditorial"
        Me.cteditorial.Size = New System.Drawing.Size(121, 20)
        Me.cteditorial.TabIndex = 16
        '
        'CBpais
        '
        Me.CBpais.FormattingEnabled = True
        Me.CBpais.Location = New System.Drawing.Point(122, 257)
        Me.CBpais.Name = "CBpais"
        Me.CBpais.Size = New System.Drawing.Size(121, 21)
        Me.CBpais.TabIndex = 15
        '
        'PAIS
        '
        Me.PAIS.AutoSize = True
        Me.PAIS.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAIS.Location = New System.Drawing.Point(31, 259)
        Me.PAIS.Name = "PAIS"
        Me.PAIS.Size = New System.Drawing.Size(44, 19)
        Me.PAIS.TabIndex = 14
        Me.PAIS.Text = "PAIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Editorial"
        '
        'editorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ctcod_editorial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cteditorial)
        Me.Controls.Add(Me.CBpais)
        Me.Controls.Add(Me.PAIS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "editorial"
        Me.Text = "editorial"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ctcod_editorial As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btguardar As Button
    Friend WithEvents Btnuevo As Button
    Friend WithEvents Btborrar As Button
    Friend WithEvents Btsalir As Button
    Friend WithEvents cteditorial As TextBox
    Friend WithEvents CBpais As ComboBox
    Friend WithEvents PAIS As Label
    Friend WithEvents Label1 As Label
End Class
