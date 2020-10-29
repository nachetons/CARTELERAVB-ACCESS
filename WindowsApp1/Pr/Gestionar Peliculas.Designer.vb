<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Añadir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Sinopsis = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.TextBox()
        Me.Duracion = New System.Windows.Forms.TextBox()
        Me.TituloOriginal = New System.Windows.Forms.TextBox()
        Me.Estreno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBoxPeliculas = New System.Windows.Forms.ListBox()
        Me.ListBoxGeneros = New System.Windows.Forms.ListBox()
        Me.ListBoxPersona = New System.Windows.Forms.ListBox()
        Me.ListBoxRoles = New System.Windows.Forms.ListBox()
        Me.PictureBoxFotoPelicula = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Añadir
        '
        Me.Añadir.Location = New System.Drawing.Point(302, 367)
        Me.Añadir.Margin = New System.Windows.Forms.Padding(2)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(105, 68)
        Me.Añadir.TabIndex = 5
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 460)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 72)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Borrar Peliculas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(443, 364)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 71)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(443, 460)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 72)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Modificar Relacion"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(588, 364)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 71)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(577, 460)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 72)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Limpiar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(707, 364)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(122, 168)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Regresar al Menu Anterior"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Sinopsis
        '
        Me.Sinopsis.Location = New System.Drawing.Point(659, 202)
        Me.Sinopsis.Margin = New System.Windows.Forms.Padding(2)
        Me.Sinopsis.Multiline = True
        Me.Sinopsis.Name = "Sinopsis"
        Me.Sinopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Sinopsis.Size = New System.Drawing.Size(170, 154)
        Me.Sinopsis.TabIndex = 12
        '
        'Titulo
        '
        Me.Titulo.Location = New System.Drawing.Point(659, 107)
        Me.Titulo.Margin = New System.Windows.Forms.Padding(2)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(170, 20)
        Me.Titulo.TabIndex = 13
        '
        'Duracion
        '
        Me.Duracion.Location = New System.Drawing.Point(659, 176)
        Me.Duracion.Margin = New System.Windows.Forms.Padding(2)
        Me.Duracion.Name = "Duracion"
        Me.Duracion.Size = New System.Drawing.Size(170, 20)
        Me.Duracion.TabIndex = 14
        '
        'TituloOriginal
        '
        Me.TituloOriginal.Location = New System.Drawing.Point(659, 130)
        Me.TituloOriginal.Margin = New System.Windows.Forms.Padding(2)
        Me.TituloOriginal.Name = "TituloOriginal"
        Me.TituloOriginal.Size = New System.Drawing.Size(170, 20)
        Me.TituloOriginal.TabIndex = 15
        '
        'Estreno
        '
        Me.Estreno.Location = New System.Drawing.Point(659, 154)
        Me.Estreno.Margin = New System.Windows.Forms.Padding(2)
        Me.Estreno.Name = "Estreno"
        Me.Estreno.Size = New System.Drawing.Size(170, 20)
        Me.Estreno.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(581, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Titulo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(581, 183)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Duracion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(585, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "(dd/mm/yyyy)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(581, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fecha estreno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(581, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Titulo Original:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(269, 218)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Lista Roles"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Lista Generos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Lista Peliculas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 218)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Lista Personas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(581, 205)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Sinopsis:"
        '
        'ListBoxPeliculas
        '
        Me.ListBoxPeliculas.FormattingEnabled = True
        Me.ListBoxPeliculas.Location = New System.Drawing.Point(49, 87)
        Me.ListBoxPeliculas.Name = "ListBoxPeliculas"
        Me.ListBoxPeliculas.Size = New System.Drawing.Size(174, 121)
        Me.ListBoxPeliculas.TabIndex = 30
        '
        'ListBoxGeneros
        '
        Me.ListBoxGeneros.FormattingEnabled = True
        Me.ListBoxGeneros.Location = New System.Drawing.Point(268, 87)
        Me.ListBoxGeneros.Name = "ListBoxGeneros"
        Me.ListBoxGeneros.Size = New System.Drawing.Size(174, 121)
        Me.ListBoxGeneros.TabIndex = 32
        '
        'ListBoxPersona
        '
        Me.ListBoxPersona.FormattingEnabled = True
        Me.ListBoxPersona.Location = New System.Drawing.Point(49, 234)
        Me.ListBoxPersona.Name = "ListBoxPersona"
        Me.ListBoxPersona.Size = New System.Drawing.Size(174, 121)
        Me.ListBoxPersona.TabIndex = 33
        '
        'ListBoxRoles
        '
        Me.ListBoxRoles.FormattingEnabled = True
        Me.ListBoxRoles.Location = New System.Drawing.Point(268, 234)
        Me.ListBoxRoles.Name = "ListBoxRoles"
        Me.ListBoxRoles.Size = New System.Drawing.Size(174, 121)
        Me.ListBoxRoles.TabIndex = 34
        '
        'PictureBoxFotoPelicula
        '
        Me.PictureBoxFotoPelicula.Location = New System.Drawing.Point(49, 364)
        Me.PictureBoxFotoPelicula.Name = "PictureBoxFotoPelicula"
        Me.PictureBoxFotoPelicula.Size = New System.Drawing.Size(174, 168)
        Me.PictureBoxFotoPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFotoPelicula.TabIndex = 31
        Me.PictureBoxFotoPelicula.TabStop = False
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Añadir
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(244, 364)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(26, 26)
        Me.Button10.TabIndex = 28
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Papelera
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(244, 504)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(26, 28)
        Me.Button9.TabIndex = 27
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.AutoSize = True
        Me.Button8.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Actualizar
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(460, 85)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 42)
        Me.Button8.TabIndex = 26
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Trunks
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(877, 566)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 564)
        Me.Controls.Add(Me.ListBoxRoles)
        Me.Controls.Add(Me.ListBoxPersona)
        Me.Controls.Add(Me.ListBoxGeneros)
        Me.Controls.Add(Me.PictureBoxFotoPelicula)
        Me.Controls.Add(Me.ListBoxPeliculas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Estreno)
        Me.Controls.Add(Me.TituloOriginal)
        Me.Controls.Add(Me.Duracion)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.Sinopsis)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBoxFotoPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Añadir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Sinopsis As TextBox
    Friend WithEvents Titulo As TextBox
    Friend WithEvents Duracion As TextBox
    Friend WithEvents TituloOriginal As TextBox
    Friend WithEvents Estreno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBoxPeliculas As ListBox
    Friend WithEvents PictureBoxFotoPelicula As PictureBox
    Friend WithEvents ListBoxGeneros As ListBox
    Friend WithEvents ListBoxPersona As ListBox
    Friend WithEvents ListBoxRoles As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
