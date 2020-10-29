Public Class ModificarRoles
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Gestionar_Roles.Show()
        Close()
    End Sub
    Private Sub ModificarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub

    Private Sub inicializar()
        ListaPersonas.Items.Clear()
        ListaRoles.Items.Clear()
        ListaPeliculas.Items.Clear()
        ListaRolesAñadidos.Items.Clear()
        ListaPeliculasAñadidas.Items.Clear()
        ListaPersonasAñadidas.Items.Clear()
        Dim newPeliculas As New Pelicula
        newPeliculas.leerTitulo(Form3.ListBoxPeliculas.SelectedItem)
        Dim newRoles As New Rol
        Dim listarol As Collection
        Dim i As Integer = 1
        listarol = newRoles.leertodos()
        While i <= listarol.Count

            ListaRoles.Items.Add(listarol.Item(i).DescRol)
            i = i + 1
        End While
        Dim newPersonas As New Persona
        Dim listaper As Collection
        Dim j As Integer = 1
        listaper = newPersonas.leertodos()
        While j <= listaper.Count

            ListaPersonas.Items.Add(listaper.Item(j).Nombre + " " + listaper.Item(j).Apellido)
            j = j + 1
        End While
        Dim newGenero As New Genero
        Dim lista As Collection
        Dim k As Integer = 1
        lista = newPeliculas.leertodos()
        While k <= lista.Count

            ListaPeliculas.Items.Add(lista.Item(k).Titulo)
            k = k + 1
        End While
        listaper.Clear()
        i = 1
        Dim aux As Integer = 0
        newPeliculas.leerPersonas()
        listaper = newPeliculas.ListaPersonas
        ListaPersonasAñadidas.Items.Clear()
        While i <= listaper.Count

            newPersonas.leerPersona(listaper.Item(i).IdPersona)
            ListaPersonasAñadidas.Items.Add(newPersonas.Nombre + " " + newPersonas.Apellido)
            i = i + 1
        End While

    End Sub


    Private Sub ListaRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaRoles.SelectedIndexChanged

    End Sub


End Class