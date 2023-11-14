<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class centroat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(centroat))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.insertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliotecarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosvencidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosmultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FureaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PorpaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertarToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.PrestamosToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'insertarToolStripMenuItem
        '
        Me.insertarToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText
        Me.insertarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorialToolStripMenuItem, Me.AutoresToolStripMenuItem, Me.LibrosToolStripMenuItem, Me.BibliotecarioToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem"
        Me.insertarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.insertarToolStripMenuItem.Text = "insertar"
        '
        'EditorialToolStripMenuItem
        '
        Me.EditorialToolStripMenuItem.Name = "EditorialToolStripMenuItem"
        Me.EditorialToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditorialToolStripMenuItem.Text = "editorial"
        '
        'AutoresToolStripMenuItem
        '
        Me.AutoresToolStripMenuItem.Name = "AutoresToolStripMenuItem"
        Me.AutoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AutoresToolStripMenuItem.Text = "autores"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LibrosToolStripMenuItem.Text = "libros"
        '
        'BibliotecarioToolStripMenuItem
        '
        Me.BibliotecarioToolStripMenuItem.Name = "BibliotecarioToolStripMenuItem"
        Me.BibliotecarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BibliotecarioToolStripMenuItem.Text = "bibliotecario"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuariosToolStripMenuItem.Text = "usuarios"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrestamosvencidosToolStripMenuItem, Me.UsuariosmultasToolStripMenuItem, Me.FureaDeToolStripMenuItem, Me.PorpaisToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'PrestamosvencidosToolStripMenuItem
        '
        Me.PrestamosvencidosToolStripMenuItem.Name = "PrestamosvencidosToolStripMenuItem"
        Me.PrestamosvencidosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PrestamosvencidosToolStripMenuItem.Text = "prestamos_vencidos"
        '
        'UsuariosmultasToolStripMenuItem
        '
        Me.UsuariosmultasToolStripMenuItem.Name = "UsuariosmultasToolStripMenuItem"
        Me.UsuariosmultasToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.UsuariosmultasToolStripMenuItem.Text = "usuarios_multas"
        '
        'FureaDeToolStripMenuItem
        '
        Me.FureaDeToolStripMenuItem.Name = "FureaDeToolStripMenuItem"
        Me.FureaDeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.FureaDeToolStripMenuItem.Text = "fuera_ de_ rango"
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ConsultarToolStripMenuItem.Text = "stock_de_libros"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 426)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PorpaisToolStripMenuItem
        '
        Me.PorpaisToolStripMenuItem.Name = "PorpaisToolStripMenuItem"
        Me.PorpaisToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PorpaisToolStripMenuItem.Text = "por_pais"
        '
        'centroat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "centroat"
        Me.Text = "centroat"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents insertarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosvencidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosmultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FureaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorpaisToolStripMenuItem As ToolStripMenuItem
End Class
