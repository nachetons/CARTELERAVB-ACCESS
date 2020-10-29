Public Class ModificarPersonas
    Private Sub ModificarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicializar()
    End Sub
    Private Sub inicializar()
        ListBoxPeliculas.Items.Clear()
        ListBoxRoles.Items.Clear()
        ListBoxPeliculaAñadida.Items.Clear()
        ListBoxRolAñadido.Items.Clear()
        Dim newRoles As New Rol
        Dim newPersona As New Persona
        Dim listaroles As Collection
        Dim d As Integer
        d = InStr(Gestionar_Personas.ListaPersonas.SelectedItem, " ")
        newPersona.leerNombreApellido(LSet(Gestionar_Personas.ListaPersonas.SelectedItem, d - 1), Mid(Gestionar_Personas.ListaPersonas.SelectedItem, d + 1, Len(Gestionar_Personas.ListaPersonas.SelectedItem)))
        Dim i As Integer = 1
        listaroles = newRoles.leertodos()
        While i <= listaroles.Count
            ListBoxRoles.Items.Add(listaroles.Item(i).DescRol)
            i = i + 1
        End While
        Dim newPeliculas As New Pelicula
        Dim listapeliculas As Collection
        Dim j As Integer = 1
        listapeliculas = newPeliculas.leertodos()
        While j <= listapeliculas.Count
            ListBoxPeliculas.Items.Add(listapeliculas.Item(j).Titulo)
            j = j + 1
        End While
        Dim lista As Collection
        i = 1
        Dim aux As Integer = 0
        newPersona.leerPeliculas()
        lista = newPersona.ListaPeliculas
        ListBoxPeliculaAñadida.Items.Clear()
        While i <= lista.Count
            Dim l As Integer = 1
            While l < i
                If lista.Item(i).IdPelicula.ToString = lista.Item(l).IdPelicula.ToString Then
                    aux = 1
                End If
                l = l + 1
            End While
            If aux = 0 Then
                newPeliculas.leerPelicula(lista.Item(i).IdPelicula)
                ListBoxPeliculaAñadida.Items.Add(newPeliculas.Titulo)
            End If
            i = i + 1
        End While
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBoxPeliculas.SelectedItem IsNot Nothing And ListBoxRoles.SelectedItem IsNot Nothing Then
            Dim newPelicula As New Pelicula
            Dim newPersona As New Persona
            Dim newRol As New Rol
            Dim lon As Integer
            lon = InStr(Gestionar_Personas.ListaPersonas.SelectedItem, " ")
            newPersona.leerNombreApellido(LSet(Gestionar_Personas.ListaPersonas.SelectedItem, lon - 1), Mid(Gestionar_Personas.ListaPersonas.SelectedItem, lon + 1, Len(Gestionar_Personas.ListaPersonas.SelectedItem)))
            newPelicula.leerTitulo(ListBoxPeliculas.SelectedItem)
            newRol.leerdescrol(ListBoxRoles.SelectedItem)
            newPersona.insertarPeliculaRol(newPelicula, newRol)
        Else
            MessageBox.Show("No ha seleccionado ninguna Pelicula y Rol a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        inicializar()
        Gestionar_Personas.ListBox1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub ListBoxPeliculaAñadida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPeliculaAñadida.SelectedIndexChanged

        Dim newPeliculas As New Pelicula
        Dim newRol As New Rol
        Dim newPersona As New Persona
        Dim lista As Collection
        Dim lon As Integer = InStr(Gestionar_Personas.ListaPersonas.SelectedItem, " ")
        newPersona.leerNombreApellido(LSet(Gestionar_Personas.ListaPersonas.SelectedItem, lon - 1), Mid(Gestionar_Personas.ListaPersonas.SelectedItem, lon + 1, Len(Gestionar_Personas.ListaPersonas.SelectedItem)))
        Dim i As Integer = 1

        newPeliculas.leerTitulo(ListBoxPeliculaAñadida.SelectedItem)
            newPeliculas.leerRoles(newPersona)
            lista = newPeliculas.ListaRoles
            ListBoxRolAñadido.Items.Clear()

        While i <= lista.Count

            newRol.leerRol(lista.Item(i).IdRol)
            ListBoxRolAñadido.Items.Add(newRol.DescRol)
                i = i + 1
            End While


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Gestionar_Personas.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBoxPeliculaAñadida.SelectedItem() IsNot Nothing And ListBoxRolAñadido.SelectedItem IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar la relacion con " + ListBoxPeliculaAñadida.SelectedItem().ToString + " y " + ListBoxRolAñadido.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPelicula As New Pelicula
                Dim newPersona As New Persona
                Dim newRol As New Rol
                Dim lon As Integer
                lon = InStr(ListBoxPeliculaAñadida.SelectedItem, " ")
                newPelicula.leerTitulo(Gestionar_Personas.ListaPeliculas.SelectedItem)
                newRol.leerdescrol(ListBoxRoles.SelectedItem)
                'newPersona.eliminarPersona(newPelicula, newRol)

            ElseIf ListBoxRoles.SelectedItem Is Nothing Then
                MessageBox.Show("No ha seleccionado ninguna Persona y Rol a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        End If

        ListBoxPeliculas.Items.Clear()
        ListBoxRoles.Items.Clear()
        ListBoxPeliculaAñadida.Items.Clear()
        ListBoxRolAñadido.Items.Clear()
        inicializar()
        Gestionar_Personas.ListaPeliculas_SelectedIndexChanged(sender, e)

    End Sub


End Class