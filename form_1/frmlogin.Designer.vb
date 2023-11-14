<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ctusuario = New System.Windows.Forms.TextBox()
        Me.ctclave = New System.Windows.Forms.TextBox()
        Me.btingresar = New System.Windows.Forms.Button()
        Me.Btcancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(422, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CLAVE"
        '
        'ctusuario
        '
        Me.ctusuario.Location = New System.Drawing.Point(181, 205)
        Me.ctusuario.Name = "ctusuario"
        Me.ctusuario.Size = New System.Drawing.Size(143, 20)
        Me.ctusuario.TabIndex = 2
        '
        'ctclave
        '
        Me.ctclave.Location = New System.Drawing.Point(370, 205)
        Me.ctclave.Name = "ctclave"
        Me.ctclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ctclave.Size = New System.Drawing.Size(143, 20)
        Me.ctclave.TabIndex = 3
        '
        'btingresar
        '
        Me.btingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btingresar.FlatAppearance.BorderSize = 2
        Me.btingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btingresar.Location = New System.Drawing.Point(212, 283)
        Me.btingresar.Name = "btingresar"
        Me.btingresar.Size = New System.Drawing.Size(84, 30)
        Me.btingresar.TabIndex = 4
        Me.btingresar.Text = "ingresar"
        Me.btingresar.UseVisualStyleBackColor = True
        '
        'Btcancelar
        '
        Me.Btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btcancelar.FlatAppearance.BorderSize = 2
        Me.Btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btcancelar.Location = New System.Drawing.Point(411, 283)
        Me.Btcancelar.Name = "Btcancelar"
        Me.Btcancelar.Size = New System.Drawing.Size(79, 30)
        Me.Btcancelar.TabIndex = 5
        Me.Btcancelar.Text = "cancelar"
        Me.Btcancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(242, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(632, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(719, 347)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btcancelar)
        Me.Controls.Add(Me.btingresar)
        Me.Controls.Add(Me.ctclave)
        Me.Controls.Add(Me.ctusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmlogin"
        Me.Text = "frmlogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ctusuario As TextBox
    Friend WithEvents ctclave As TextBox
    Friend WithEvents btingresar As Button
    Friend WithEvents Btcancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
