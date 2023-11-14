<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prestamos
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
        Panel3 = New Panel()
        btnuevo = New Button()
        ctcod_prestamo = New TextBox()
        cttipo_prestamo = New ComboBox()
        ctentregado = New ComboBox()
        cbusuario = New ComboBox()
        BtnPrestar = New Button()
        Label11 = New Label()
        Label10 = New Label()
        ctmulta = New TextBox()
        CbBibliotecario = New ComboBox()
        dtfecha2 = New DateTimePicker()
        dtfecha = New DateTimePicker()
        CbLibro = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        btborrar = New Button()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btborrar)
        Panel3.Controls.Add(btnuevo)
        Panel3.Controls.Add(ctcod_prestamo)
        Panel3.Controls.Add(cttipo_prestamo)
        Panel3.Controls.Add(ctentregado)
        Panel3.Controls.Add(cbusuario)
        Panel3.Controls.Add(BtnPrestar)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(ctmulta)
        Panel3.Controls.Add(CbBibliotecario)
        Panel3.Controls.Add(dtfecha2)
        Panel3.Controls.Add(dtfecha)
        Panel3.Controls.Add(CbLibro)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(12, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(358, 459)
        Panel3.TabIndex = 2
        ' 
        ' btnuevo
        ' 
        btnuevo.Location = New Point(251, 402)
        btnuevo.Name = "btnuevo"
        btnuevo.Size = New Size(75, 23)
        btnuevo.TabIndex = 23
        btnuevo.Text = "nuevo"
        btnuevo.UseVisualStyleBackColor = True
        ' 
        ' ctcod_prestamo
        ' 
        ctcod_prestamo.Location = New Point(80, 401)
        ctcod_prestamo.Name = "ctcod_prestamo"
        ctcod_prestamo.Size = New Size(100, 23)
        ctcod_prestamo.TabIndex = 22
        ctcod_prestamo.Visible = False
        ' 
        ' cttipo_prestamo
        ' 
        cttipo_prestamo.FormattingEnabled = True
        cttipo_prestamo.Items.AddRange(New Object() {"Normal", "Estudiante"})
        cttipo_prestamo.Location = New Point(124, 211)
        cttipo_prestamo.Name = "cttipo_prestamo"
        cttipo_prestamo.Size = New Size(202, 23)
        cttipo_prestamo.TabIndex = 21
        ' 
        ' ctentregado
        ' 
        ctentregado.FormattingEnabled = True
        ctentregado.Items.AddRange(New Object() {"Si", "No"})
        ctentregado.Location = New Point(124, 280)
        ctentregado.Name = "ctentregado"
        ctentregado.Size = New Size(202, 23)
        ctentregado.TabIndex = 20
        ' 
        ' cbusuario
        ' 
        cbusuario.FormattingEnabled = True
        cbusuario.Location = New Point(126, 168)
        cbusuario.Name = "cbusuario"
        cbusuario.Size = New Size(200, 23)
        cbusuario.TabIndex = 19
        ' 
        ' BtnPrestar
        ' 
        BtnPrestar.Location = New Point(251, 373)
        BtnPrestar.Name = "BtnPrestar"
        BtnPrestar.Size = New Size(75, 23)
        BtnPrestar.TabIndex = 17
        BtnPrestar.Text = "Efectuar"
        BtnPrestar.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(14, 322)
        Label11.Name = "Label11"
        Label11.Size = New Size(41, 15)
        Label11.TabIndex = 16
        Label11.Text = "Multa:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(14, 283)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 15)
        Label10.TabIndex = 15
        Label10.Text = "Estado Entregado:"
        ' 
        ' ctmulta
        ' 
        ctmulta.Location = New Point(126, 314)
        ctmulta.Name = "ctmulta"
        ctmulta.Size = New Size(200, 23)
        ctmulta.TabIndex = 14
        ctmulta.Text = "0"
        ' 
        ' CbBibliotecario
        ' 
        CbBibliotecario.FormattingEnabled = True
        CbBibliotecario.Location = New Point(126, 241)
        CbBibliotecario.Name = "CbBibliotecario"
        CbBibliotecario.Size = New Size(200, 23)
        CbBibliotecario.TabIndex = 12
        ' 
        ' dtfecha2
        ' 
        dtfecha2.Location = New Point(126, 136)
        dtfecha2.Name = "dtfecha2"
        dtfecha2.Size = New Size(200, 23)
        dtfecha2.TabIndex = 9
        ' 
        ' dtfecha
        ' 
        dtfecha.Location = New Point(126, 98)
        dtfecha.Name = "dtfecha"
        dtfecha.Size = New Size(200, 23)
        dtfecha.TabIndex = 8
        ' 
        ' CbLibro
        ' 
        CbLibro.FormattingEnabled = True
        CbLibro.Location = New Point(126, 55)
        CbLibro.Name = "CbLibro"
        CbLibro.Size = New Size(200, 23)
        CbLibro.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(14, 249)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 15)
        Label9.TabIndex = 6
        Label9.Text = "Bibliotecario:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 214)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 15)
        Label8.TabIndex = 5
        Label8.Text = "Tipo de prestamo:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 168)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 15)
        Label7.TabIndex = 4
        Label7.Text = "Nombre Usuario:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 15)
        Label6.TabIndex = 3
        Label6.Text = "Fecha Entrega:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 2
        Label5.Text = "Fecha Prestamo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 15)
        Label4.TabIndex = 1
        Label4.Text = "Libro:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(109, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 0
        Label3.Text = "Realizar Prestamo:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(376, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(655, 459)
        DataGridView1.TabIndex = 3
        ' 
        ' btborrar
        ' 
        btborrar.Location = New Point(251, 344)
        btborrar.Name = "btborrar"
        btborrar.Size = New Size(75, 23)
        btborrar.TabIndex = 24
        btborrar.Text = "borrar"
        btborrar.UseVisualStyleBackColor = True
        ' 
        ' Prestamo
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 493)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Name = "Prestamo"
        Text = "Prestamos"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ctmulta As TextBox
    Friend WithEvents CbBibliotecario As ComboBox
    Friend WithEvents dtfecha2 As DateTimePicker
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents CbLibro As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnPrestar As Button
    Friend WithEvents cttipo_prestamo As ComboBox
    Friend WithEvents ctentregado As ComboBox
    Friend WithEvents cbusuario As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ctcod_prestamo As TextBox
    Friend WithEvents btnuevo As Button
    Friend WithEvents btborrar As Button
End Class
