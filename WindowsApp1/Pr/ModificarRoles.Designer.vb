<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarRoles
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
        Me.ListaPeliculas = New System.Windows.Forms.ListBox()
        Me.ListaPersonas = New System.Windows.Forms.ListBox()
        Me.ListaRoles = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ListaPeliculasAñadidas = New System.Windows.Forms.ListBox()
        Me.ListaPersonasAñadidas = New System.Windows.Forms.ListBox()
        Me.ListaRolesAñadidos = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPeliculas
        '
        Me.ListaPeliculas.FormattingEnabled = True
        Me.ListaPeliculas.Location = New System.Drawing.Point(585, 35)
        Me.ListaPeliculas.Name = "ListaPeliculas"
        Me.ListaPeliculas.Size = New System.Drawing.Size(155, 108)
        Me.ListaPeliculas.TabIndex = 114
        '
        'ListaPersonas
        '
        Me.ListaPersonas.FormattingEnabled = True
        Me.ListaPersonas.Location = New System.Drawing.Point(314, 35)
        Me.ListaPersonas.Name = "ListaPersonas"
        Me.ListaPersonas.Size = New System.Drawing.Size(170, 108)
        Me.ListaPersonas.TabIndex = 113
        '
        'ListaRoles
        '
        Me.ListaRoles.FormattingEnabled = True
        Me.ListaRoles.Location = New System.Drawing.Point(57, 35)
        Me.ListaRoles.Name = "ListaRoles"
        Me.ListaRoles.Size = New System.Drawing.Size(170, 108)
        Me.ListaRoles.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(582, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Lista Peliculas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 8)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Lista Roles"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Lista Personas"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(511, 350)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 72)
        Me.Button5.TabIndex = 108
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 350)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 72)
        Me.Button3.TabIndex = 107
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 350)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 72)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(701, 331)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 105)
        Me.Button7.TabIndex = 115
        Me.Button7.Text = "Regresar al Menu Anterior"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ListaPeliculasAñadidas
        '
        Me.ListaPeliculasAñadidas.FormattingEnabled = True
        Me.ListaPeliculasAñadidas.Location = New System.Drawing.Point(585, 186)
        Me.ListaPeliculasAñadidas.Name = "ListaPeliculasAñadidas"
        Me.ListaPeliculasAñadidas.Size = New System.Drawing.Size(155, 95)
        Me.ListaPeliculasAñadidas.TabIndex = 118
        '
        'ListaPersonasAñadidas
        '
        Me.ListaPersonasAñadidas.FormattingEnabled = True
        Me.ListaPersonasAñadidas.Location = New System.Drawing.Point(314, 186)
        Me.ListaPersonasAñadidas.Name = "ListaPersonasAñadidas"
        Me.ListaPersonasAñadidas.Size = New System.Drawing.Size(170, 95)
        Me.ListaPersonasAñadidas.TabIndex = 117
        '
        'ListaRolesAñadidos
        '
        Me.ListaRolesAñadidos.FormattingEnabled = True
        Me.ListaRolesAñadidos.Location = New System.Drawing.Point(57, 186)
        Me.ListaRolesAñadidos.Name = "ListaRolesAñadidos"
        Me.ListaRolesAñadidos.Size = New System.Drawing.Size(170, 95)
        Me.ListaRolesAñadidos.TabIndex = 116
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.shenron
        Me.PictureBox1.Location = New System.Drawing.Point(153, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(543, 457)
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'ModificarRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListaPeliculasAñadidas)
        Me.Controls.Add(Me.ListaPersonasAñadidas)
        Me.Controls.Add(Me.ListaRolesAñadidos)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ListaPeliculas)
        Me.Controls.Add(Me.ListaPersonas)
        Me.Controls.Add(Me.ListaRoles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ModificarRoles"
        Me.Text = "ModificarRoles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaPeliculas As ListBox
    Friend WithEvents ListaPersonas As ListBox
    Friend WithEvents ListaRoles As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ListaPeliculasAñadidas As ListBox
    Friend WithEvents ListaPersonasAñadidas As ListBox
    Friend WithEvents ListaRolesAñadidos As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
