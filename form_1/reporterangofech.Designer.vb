<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporterangofech
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
        Me.Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Final = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DVG = New System.Windows.Forms.DataGridView()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DVG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Inicio
        '
        Me.Inicio.Location = New System.Drawing.Point(37, 24)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(187, 20)
        Me.Inicio.TabIndex = 0
        '
        'Final
        '
        Me.Final.Location = New System.Drawing.Point(266, 24)
        Me.Final.Name = "Final"
        Me.Final.Size = New System.Drawing.Size(184, 20)
        Me.Final.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "De"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'DVG
        '
        Me.DVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVG.Location = New System.Drawing.Point(10, 60)
        Me.DVG.Name = "DVG"
        Me.DVG.RowTemplate.Height = 25
        Me.DVG.Size = New System.Drawing.Size(621, 320)
        Me.DVG.TabIndex = 4
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(458, 24)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(64, 20)
        Me.BtnFiltrar.TabIndex = 5
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exportar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'reporterangofech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(641, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnFiltrar)
        Me.Controls.Add(Me.DVG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Final)
        Me.Controls.Add(Me.Inicio)
        Me.Name = "reporterangofech"
        Me.Text = "RangoFechas"
        CType(Me.DVG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Inicio As DateTimePicker
    Friend WithEvents Final As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DVG As DataGridView
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents Button1 As Button

End Class
