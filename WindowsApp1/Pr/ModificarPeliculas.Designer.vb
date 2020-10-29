<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPeliculas
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
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Añadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListaRolesAñadidos = New System.Windows.Forms.ListBox()
        Me.ListaPersonasAñadidas = New System.Windows.Forms.ListBox()
        Me.ListaGenerosAñadidos = New System.Windows.Forms.ListBox()
        Me.Actualiza = New System.Windows.Forms.Button()
        Me.lbl_ListaGeneros = New System.Windows.Forms.Label()
        Me.lbl_ListaPersonas = New System.Windows.Forms.Label()
        Me.lbl_ListaRoles = New System.Windows.Forms.Label()
        Me.ListaRoles = New System.Windows.Forms.ListBox()
        Me.ListaPersonas = New System.Windows.Forms.ListBox()
        Me.Notificacion = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.ListaGeneros = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Limpiar
        '
        Me.Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.Location = New System.Drawing.Point(921, 254)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(100, 50)
        Me.Limpiar.TabIndex = 102
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Regresar
        '
        Me.Regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.Location = New System.Drawing.Point(864, 347)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(157, 54)
        Me.Regresar.TabIndex = 103
        Me.Regresar.Text = "Regresar al Menu Anterior"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(921, 170)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(100, 50)
        Me.Eliminar.TabIndex = 101
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Añadir
        '
        Me.Añadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Añadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Añadir.Location = New System.Drawing.Point(921, 86)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(100, 50)
        Me.Añadir.TabIndex = 100
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Lista Generos Añadidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Lista Personas Añadidas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(636, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Lista Roles Añadidos"
        '
        'ListaRolesAñadidos
        '
        Me.ListaRolesAñadidos.FormattingEnabled = True
        Me.ListaRolesAñadidos.Location = New System.Drawing.Point(639, 254)
        Me.ListaRolesAñadidos.Name = "ListaRolesAñadidos"
        Me.ListaRolesAñadidos.Size = New System.Drawing.Size(200, 147)
        Me.ListaRolesAñadidos.TabIndex = 98
        '
        'ListaPersonasAñadidas
        '
        Me.ListaPersonasAñadidas.FormattingEnabled = True
        Me.ListaPersonasAñadidas.Location = New System.Drawing.Point(283, 282)
        Me.ListaPersonasAñadidas.Name = "ListaPersonasAñadidas"
        Me.ListaPersonasAñadidas.Size = New System.Drawing.Size(200, 147)
        Me.ListaPersonasAñadidas.TabIndex = 97
        '
        'ListaGenerosAñadidos
        '
        Me.ListaGenerosAñadidos.FormattingEnabled = True
        Me.ListaGenerosAñadidos.Location = New System.Drawing.Point(12, 282)
        Me.ListaGenerosAñadidos.Name = "ListaGenerosAñadidos"
        Me.ListaGenerosAñadidos.Size = New System.Drawing.Size(200, 147)
        Me.ListaGenerosAñadidos.TabIndex = 96
        '
        'Actualiza
        '
        Me.Actualiza.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actualiza.Location = New System.Drawing.Point(864, 86)
        Me.Actualiza.Name = "Actualiza"
        Me.Actualiza.Size = New System.Drawing.Size(30, 30)
        Me.Actualiza.TabIndex = 99
        Me.Actualiza.Text = " "
        Me.Actualiza.UseVisualStyleBackColor = True
        '
        'lbl_ListaGeneros
        '
        Me.lbl_ListaGeneros.AutoSize = True
        Me.lbl_ListaGeneros.Location = New System.Drawing.Point(18, 55)
        Me.lbl_ListaGeneros.Name = "lbl_ListaGeneros"
        Me.lbl_ListaGeneros.Size = New System.Drawing.Size(72, 13)
        Me.lbl_ListaGeneros.TabIndex = 108
        Me.lbl_ListaGeneros.Text = "Lista Generos"
        '
        'lbl_ListaPersonas
        '
        Me.lbl_ListaPersonas.AutoSize = True
        Me.lbl_ListaPersonas.Location = New System.Drawing.Point(280, 55)
        Me.lbl_ListaPersonas.Name = "lbl_ListaPersonas"
        Me.lbl_ListaPersonas.Size = New System.Drawing.Size(76, 13)
        Me.lbl_ListaPersonas.TabIndex = 107
        Me.lbl_ListaPersonas.Text = "Lista Personas"
        '
        'lbl_ListaRoles
        '
        Me.lbl_ListaRoles.AutoSize = True
        Me.lbl_ListaRoles.Location = New System.Drawing.Point(636, 70)
        Me.lbl_ListaRoles.Name = "lbl_ListaRoles"
        Me.lbl_ListaRoles.Size = New System.Drawing.Size(59, 13)
        Me.lbl_ListaRoles.TabIndex = 106
        Me.lbl_ListaRoles.Text = "Lista Roles"
        '
        'ListaRoles
        '
        Me.ListaRoles.FormattingEnabled = True
        Me.ListaRoles.Location = New System.Drawing.Point(639, 86)
        Me.ListaRoles.Name = "ListaRoles"
        Me.ListaRoles.Size = New System.Drawing.Size(200, 147)
        Me.ListaRoles.TabIndex = 95
        '
        'ListaPersonas
        '
        Me.ListaPersonas.FormattingEnabled = True
        Me.ListaPersonas.Location = New System.Drawing.Point(283, 88)
        Me.ListaPersonas.Name = "ListaPersonas"
        Me.ListaPersonas.Size = New System.Drawing.Size(200, 147)
        Me.ListaPersonas.TabIndex = 94
        '
        'Notificacion
        '
        Me.Notificacion.AutoSize = True
        Me.Notificacion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notificacion.Location = New System.Drawing.Point(431, 18)
        Me.Notificacion.Name = "Notificacion"
        Me.Notificacion.Size = New System.Drawing.Size(170, 19)
        Me.Notificacion.TabIndex = 105
        Me.Notificacion.Text = "Seleccionar para modificar"
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(412, 0)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(223, 18)
        Me.Titulo.TabIndex = 104
        Me.Titulo.Text = "IMDB - Internet Movie Data Base"
        '
        'ListaGeneros
        '
        Me.ListaGeneros.FormattingEnabled = True
        Me.ListaGeneros.Location = New System.Drawing.Point(21, 86)
        Me.ListaGeneros.Name = "ListaGeneros"
        Me.ListaGeneros.Size = New System.Drawing.Size(200, 147)
        Me.ListaGeneros.TabIndex = 93
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.VegettaRage
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1036, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'ModificarPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 450)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListaRolesAñadidos)
        Me.Controls.Add(Me.ListaPersonasAñadidas)
        Me.Controls.Add(Me.ListaGenerosAñadidos)
        Me.Controls.Add(Me.Actualiza)
        Me.Controls.Add(Me.lbl_ListaGeneros)
        Me.Controls.Add(Me.lbl_ListaPersonas)
        Me.Controls.Add(Me.lbl_ListaRoles)
        Me.Controls.Add(Me.ListaRoles)
        Me.Controls.Add(Me.ListaPersonas)
        Me.Controls.Add(Me.Notificacion)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.ListaGeneros)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ModificarPeliculas"
        Me.Text = "ModificarPeliculas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Limpiar As Button
    Friend WithEvents Regresar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Añadir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListaRolesAñadidos As ListBox
    Friend WithEvents ListaPersonasAñadidas As ListBox
    Friend WithEvents ListaGenerosAñadidos As ListBox
    Friend WithEvents Actualiza As Button
    Friend WithEvents lbl_ListaGeneros As Label
    Friend WithEvents lbl_ListaPersonas As Label
    Friend WithEvents lbl_ListaRoles As Label
    Friend WithEvents ListaRoles As ListBox
    Friend WithEvents ListaPersonas As ListBox
    Friend WithEvents Notificacion As Label
    Friend WithEvents Titulo As Label
    Friend WithEvents ListaGeneros As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
