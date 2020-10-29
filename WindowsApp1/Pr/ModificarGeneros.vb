Public Class ModificarGeneros
    Private Sub ModificarGeneros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub
    Private Sub inicializar()
        ListBoxGeneros.Items.Clear()
        ListBoxGeneroAñadido.Items.Clear()
        ListBoxPeliculaAñadida.Items.Clear()
        ListBoxPeliculas.Items.Clear()
        Dim newGeneros As New Genero
        Dim newPelicula As New Pelicula
        Dim listageneros As Collection
        Dim d As Integer
        d = InStr(Gestionar_Generos.ListBox1.SelectedItem, " ")
        newPelicula.leerTitulo(ListBoxPeliculas.SelectedItem)
        Dim i As Integer = 1
        listageneros = newGeneros.leertodos()
        While i <= listageneros.Count
            ListBoxGeneros.Items.Add(listageneros.Item(i).DescGenero)
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
        newGeneros.leerPeliculas()
        lista = newGeneros.ListaPeliculas
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Gestionar_Generos.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBoxGeneros.SelectedItem IsNot Nothing And ListBoxPeliculas.SelectedItem IsNot Nothing Then
            Dim newPelicula As New Pelicula
            Dim newPersona As New Persona
            Dim newGenero As New Genero
            Dim newRol As New Rol
            Dim lon As Integer
            lon = InStr(Gestionar_Generos.ListBox1.SelectedItem, " ")
            newGenero.leerdescGenero(Gestionar_Generos.ListBox1.SelectedItem)
            newPelicula.leerTitulo(ListBoxPeliculas.SelectedItem)
            'newGenero.insertarGenero(newGenero, newPelicula)
        Else
            MessageBox.Show("No ha seleccionado ninguna Pelicula y Rol a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        inicializar()
        Gestionar_Generos.ListBox1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub ListBoxGeneroAñadido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxGeneroAñadido.SelectedIndexChanged

        Dim newPeliculas As New Pelicula
        Dim newRol As New Rol
        Dim newPersona As New Persona
        Dim lista As Collection
        Dim lon As Integer = InStr(Gestionar_Generos.ListBox1.SelectedItem, " ")
        newPeliculas.leerPelicula(Gestionar_Generos.ListBox2.SelectedItem)
        Dim i As Integer = 1

        newPeliculas.leerTitulo(ListBoxPeliculaAñadida.SelectedItem)
        newPeliculas.leerRoles(newPersona)
        lista = newPeliculas.ListaRoles
        ListBoxGeneroAñadido.Items.Clear()

        While i <= lista.Count

            newRol.leerRol(lista.Item(i).IdRol)
            ListBoxGeneroAñadido.Items.Add(newRol.DescRol)
            i = i + 1
        End While
    End Sub
End Class