<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarGeneros
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
        Me.ListBoxPeliculaAñadida = New System.Windows.Forms.ListBox()
        Me.ListBoxGeneroAñadido = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ListBoxPeliculas = New System.Windows.Forms.ListBox()
        Me.ListBoxGeneros = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxPeliculaAñadida
        '
        Me.ListBoxPeliculaAñadida.FormattingEnabled = True
        Me.ListBoxPeliculaAñadida.Location = New System.Drawing.Point(745, 230)
        Me.ListBoxPeliculaAñadida.Name = "ListBoxPeliculaAñadida"
        Me.ListBoxPeliculaAñadida.Size = New System.Drawing.Size(155, 147)
        Me.ListBoxPeliculaAñadida.TabIndex = 143
        '
        'ListBoxGeneroAñadido
        '
        Me.ListBoxGeneroAñadido.FormattingEnabled = True
        Me.ListBoxGeneroAñadido.Location = New System.Drawing.Point(53, 230)
        Me.ListBoxGeneroAñadido.Name = "ListBoxGeneroAñadido"
        Me.ListBoxGeneroAñadido.Size = New System.Drawing.Size(170, 147)
        Me.ListBoxGeneroAñadido.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(742, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Lista Pelicula Añadido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 201)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Lista Genero Añadida"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(761, 397)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 104)
        Me.Button7.TabIndex = 139
        Me.Button7.Text = "Regresar al Menu Anterior"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ListBoxPeliculas
        '
        Me.ListBoxPeliculas.FormattingEnabled = True
        Me.ListBoxPeliculas.Location = New System.Drawing.Point(745, 35)
        Me.ListBoxPeliculas.Name = "ListBoxPeliculas"
        Me.ListBoxPeliculas.Size = New System.Drawing.Size(155, 147)
        Me.ListBoxPeliculas.TabIndex = 138
        '
        'ListBoxGeneros
        '
        Me.ListBoxGeneros.FormattingEnabled = True
        Me.ListBoxGeneros.Location = New System.Drawing.Point(53, 35)
        Me.ListBoxGeneros.Name = "ListBoxGeneros"
        Me.ListBoxGeneros.Size = New System.Drawing.Size(170, 147)
        Me.ListBoxGeneros.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(611, -34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Lista Roles"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-69, -34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Lista Peliculas"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(527, 422)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(194, 79)
        Me.Button5.TabIndex = 134
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(303, 422)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 79)
        Me.Button3.TabIndex = 133
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 422)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 79)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.vegeta_brillo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(966, 538)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 144
        Me.PictureBox1.TabStop = False
        '
        'ModificarGeneros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 538)
        Me.Controls.Add(Me.ListBoxPeliculaAñadida)
        Me.Controls.Add(Me.ListBoxGeneroAñadido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ListBoxPeliculas)
        Me.Controls.Add(Me.ListBoxGeneros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ModificarGeneros"
        Me.Text = "ModificarGeneros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxPeliculaAñadida As ListBox
    Friend WithEvents ListBoxGeneroAñadido As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents ListBoxPeliculas As ListBox
    Friend WithEvents ListBoxGeneros As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
