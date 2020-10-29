<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestionar_Personas
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.F_Nacimiento = New System.Windows.Forms.TextBox()
        Me.Apellido = New System.Windows.Forms.TextBox()
        Me.Nacionalidad = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.CiudadNacimiento = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PaisNacimiento = New System.Windows.Forms.TextBox()
        Me.ListaPersonas = New System.Windows.Forms.ListBox()
        Me.ListaPeliculas = New System.Windows.Forms.ListBox()
        Me.ListaRoles = New System.Windows.Forms.ListBox()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(517, 242)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "CiudadNacimiento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Lista Personas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(169, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Lista Peliculas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Lista Roles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(541, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(523, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(545, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "(dd/mm/yyyy)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(541, 170)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nacionalidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(544, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nombre:"
        '
        'F_Nacimiento
        '
        Me.F_Nacimiento.Location = New System.Drawing.Point(619, 200)
        Me.F_Nacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.F_Nacimiento.Name = "F_Nacimiento"
        Me.F_Nacimiento.Size = New System.Drawing.Size(170, 20)
        Me.F_Nacimiento.TabIndex = 46
        '
        'Apellido
        '
        Me.Apellido.Location = New System.Drawing.Point(619, 131)
        Me.Apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(170, 20)
        Me.Apellido.TabIndex = 45
        '
        'Nacionalidad
        '
        Me.Nacionalidad.Location = New System.Drawing.Point(619, 163)
        Me.Nacionalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.Nacionalidad.Name = "Nacionalidad"
        Me.Nacionalidad.Size = New System.Drawing.Size(170, 20)
        Me.Nacionalidad.TabIndex = 44
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(622, 91)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(170, 20)
        Me.Nombre.TabIndex = 43
        '
        'CiudadNacimiento
        '
        Me.CiudadNacimiento.Location = New System.Drawing.Point(619, 235)
        Me.CiudadNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.CiudadNacimiento.Name = "CiudadNacimiento"
        Me.CiudadNacimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CiudadNacimiento.Size = New System.Drawing.Size(170, 20)
        Me.CiudadNacimiento.TabIndex = 42
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(582, 319)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(210, 107)
        Me.Button7.TabIndex = 41
        Me.Button7.Text = "Regresar al Menu Anterior"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(476, 377)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(79, 46)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Limpiar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(476, 316)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 46)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(359, 377)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 46)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Modificar Relacion"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(359, 316)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 46)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 380)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 40)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Borrar Peliculas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 319)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 40)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(533, 278)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "PaisNacimiento:"
        '
        'PaisNacimiento
        '
        Me.PaisNacimiento.Location = New System.Drawing.Point(619, 275)
        Me.PaisNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.PaisNacimiento.Name = "PaisNacimiento"
        Me.PaisNacimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PaisNacimiento.Size = New System.Drawing.Size(170, 20)
        Me.PaisNacimiento.TabIndex = 60
        '
        'ListaPersonas
        '
        Me.ListaPersonas.FormattingEnabled = True
        Me.ListaPersonas.Location = New System.Drawing.Point(17, 41)
        Me.ListaPersonas.Name = "ListaPersonas"
        Me.ListaPersonas.Size = New System.Drawing.Size(132, 199)
        Me.ListaPersonas.TabIndex = 62
        '
        'ListaPeliculas
        '
        Me.ListaPeliculas.FormattingEnabled = True
        Me.ListaPeliculas.Location = New System.Drawing.Point(172, 41)
        Me.ListaPeliculas.Name = "ListaPeliculas"
        Me.ListaPeliculas.Size = New System.Drawing.Size(137, 199)
        Me.ListaPeliculas.TabIndex = 63
        '
        'ListaRoles
        '
        Me.ListaRoles.FormattingEnabled = True
        Me.ListaRoles.Location = New System.Drawing.Point(347, 41)
        Me.ListaRoles.Name = "ListaRoles"
        Me.ListaRoles.Size = New System.Drawing.Size(137, 199)
        Me.ListaRoles.TabIndex = 64
        '
        'Foto
        '
        Me.Foto.Location = New System.Drawing.Point(17, 303)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(164, 117)
        Me.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto.TabIndex = 65
        Me.Foto.TabStop = False
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Añadir
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(198, 303)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(26, 26)
        Me.Button10.TabIndex = 58
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Papelera
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(198, 390)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(26, 28)
        Me.Button9.TabIndex = 57
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Actualizar
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(519, 41)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(36, 34)
        Me.Button8.TabIndex = 56
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.vegetta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 454)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Gestionar_Personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Foto)
        Me.Controls.Add(Me.ListaRoles)
        Me.Controls.Add(Me.ListaPeliculas)
        Me.Controls.Add(Me.ListaPersonas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PaisNacimiento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.F_Nacimiento)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.Nacionalidad)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.CiudadNacimiento)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Gestionar_Personas"
        Me.Text = "Gestionar_Personas"
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents F_Nacimiento As TextBox
    Friend WithEvents Apellido As TextBox
    Friend WithEvents Nacionalidad As TextBox
    Friend WithEvents Nombre As TextBox
    Friend WithEvents CiudadNacimiento As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PaisNacimiento As TextBox
    Friend WithEvents ListaPersonas As ListBox
    Friend WithEvents ListaPeliculas As ListBox
    Friend WithEvents ListaRoles As ListBox
    Friend WithEvents Foto As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
