<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultar_libros
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
        Me.btbuscar = New System.Windows.Forms.Button()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.ctbusq = New System.Windows.Forms.TextBox()
        Me.btvolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(64, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(569, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'btbuscar
        '
        Me.btbuscar.Location = New System.Drawing.Point(465, 269)
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btbuscar.TabIndex = 1
        Me.btbuscar.Text = "Buscar"
        Me.btbuscar.UseVisualStyleBackColor = True
        '
        'cbtipo
        '
        Me.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Location = New System.Drawing.Point(275, 246)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(121, 21)
        Me.cbtipo.TabIndex = 2
        '
        'ctbusq
        '
        Me.ctbusq.Location = New System.Drawing.Point(275, 285)
        Me.ctbusq.Name = "ctbusq"
        Me.ctbusq.Size = New System.Drawing.Size(121, 20)
        Me.ctbusq.TabIndex = 3
        '
        'btvolver
        '
        Me.btvolver.Location = New System.Drawing.Point(22, 320)
        Me.btvolver.Name = "btvolver"
        Me.btvolver.Size = New System.Drawing.Size(75, 23)
        Me.btvolver.TabIndex = 4
        Me.btvolver.Text = "Volver"
        Me.btvolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Buscar"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 355)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btvolver)
        Me.Controls.Add(Me.ctbusq)
        Me.Controls.Add(Me.cbtipo)
        Me.Controls.Add(Me.btbuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btbuscar As Button
    Friend WithEvents cbtipo As ComboBox
    Friend WithEvents ctbusq As TextBox
    Friend WithEvents btvolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
