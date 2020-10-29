Public Class ModificarPeliculas
    ' Al arrancar el formulario cargar la base de datos '
    Private Sub ModificarPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub

    ' Metodo para inicializar la aplicacion '
    Private Sub inicializar()
        ListaPersonas.Items.Clear()
        ListaRoles.Items.Clear()
        ListaGeneros.Items.Clear()
        ListaRolesAñadidos.Items.Clear()
        ListaGenerosAñadidos.Items.Clear()
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
        lista = newGenero.leertodos()
        While k <= lista.Count

            ListaGeneros.Items.Add(lista.Item(k).DescGenero)
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
        j = 1
        newPeliculas.leerGeneros()
        lista = newPeliculas.ListaGeneros
        ListaGenerosAñadidos.Items.Clear()
        While j <= lista.Count

            newGenero.leerGenero(lista.Item(j).IdGenero)
            ListaGenerosAñadidos.Items.Add(newGenero.DescGenero)
            j = j + 1
        End While
    End Sub

    ' Boton para añadir una nueva relacion 
    Private Sub Añadir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Añadir.Click
        If ListaPersonas.SelectedItem IsNot Nothing And ListaRoles.SelectedItem IsNot Nothing Then
            Dim newPelicula As New Pelicula
            Dim newPersona As New Persona
            Dim newRol As New Rol
            Dim lon As Integer
            lon = InStr(ListaPersonas.SelectedItem, " ")
            newPersona.leerNombreApellido(LSet(ListaPersonas.SelectedItem, lon - 1), Mid(ListaPersonas.SelectedItem, lon + 1, Len(ListaPersonas.SelectedItem)))
            newPelicula.leerTitulo(Form3.ListBoxPeliculas.SelectedItem)
            newRol.leerdescrol(ListaRoles.SelectedItem)
            newPelicula.insertarPersonaRol(newPersona, newRol)
        ElseIf ListaGeneros.SelectedItem Is Nothing Then
            MessageBox.Show("No ha seleccionado ninguna Persona y Rol a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ListaGeneros.SelectedItem IsNot Nothing Then
            Dim newPelicula As New Pelicula
            Dim newGenero As New Genero
            newGenero.leerdescGenero(ListaGeneros.SelectedItem)
            newPelicula.leerTitulo(Form3.ListBoxPeliculas.SelectedItem)
            newPelicula.insertarGenero(newGenero)
        ElseIf ListaPersonas.SelectedItem Is Nothing And ListaRoles.SelectedItem Is Nothing Then
            MessageBox.Show("No ha seleccionado ningun Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ListaPersonasAñadidas.Items.Clear()
        ListaPersonas.Items.Clear()
        ListaRoles.Items.Clear()
        ListaGeneros.Items.Clear()
        ListaRolesAñadidos.Items.Clear()
        ListaGenerosAñadidos.Items.Clear()
        inicializar()
        Form3.ListBoxPeliculas_SelectedIndexChanged(sender, e)
    End Sub

    ' Boton para eliminar una relacion '
    Private Sub Eliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Eliminar.Click
        If ListaPersonas.SelectedItem() IsNot Nothing And ListaRoles.SelectedItem IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar la relacion con " + ListaPersonas.SelectedItem().ToString + " y " + ListaRoles.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPelicula As New Pelicula
                Dim newPersona As New Persona
                Dim newRol As New Rol
                Dim lon As Integer
                lon = InStr(ListaPersonas.SelectedItem, " ")
                newPersona.leerNombreApellido(LSet(ListaPersonas.SelectedItem, lon - 1), Mid(ListaPersonas.SelectedItem, lon + 1, Len(ListaPersonas.SelectedItem)))
                newPelicula.leerTitulo(Form3.ListBoxPeliculas.SelectedItem)
                newRol.leerdescrol(ListaRoles.SelectedItem)
                newPelicula.eliminarPersonaRol(newPersona, newRol)
            End If
        ElseIf ListaGeneros.SelectedItem Is Nothing Then
            MessageBox.Show("No ha seleccionado ninguna Persona y Rol a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ListaGeneros.SelectedItem() IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar la relacion con " + ListaGeneros.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPelicula As New Pelicula
                Dim newGenero As New Genero
                newPelicula.leerTitulo(Form3.ListBoxPeliculas.SelectedItem)
                newGenero.leerdescGenero(ListaGeneros.SelectedItem)
                newPelicula.eliminarGenero(newGenero)
            End If
        ElseIf ListaPersonas.SelectedItem Is Nothing And ListaRoles.SelectedItem Is Nothing Then
            MessageBox.Show("No ha seleccionado ningun Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ListaPersonasAñadidas.Items.Clear()
        ListaPersonas.Items.Clear()
        ListaRoles.Items.Clear()
        ListaGeneros.Items.Clear()
        ListaRolesAñadidos.Items.Clear()
        ListaGenerosAñadidos.Items.Clear()
        inicializar()
        Form3.ListBoxPeliculas_SelectedIndexChanged(sender, e)

    End Sub

    ' Boton para regresar al menu anterior '
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Close()
    End Sub

    ' Boton para limpiar los TextBox '
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        ListaGeneros.ClearSelected()
        ListaPersonas.ClearSelected()
        ListaRoles.ClearSelected()
        ListaGenerosAñadidos.ClearSelected()
        ListaRolesAñadidos.Items.Clear()
        ListaPersonasAñadidas.ClearSelected()
    End Sub

    ' Boton para actualizar las listas '
    Private Sub Actualiza_Click(sender As Object, e As EventArgs) Handles Actualiza.Click
        inicializar()
    End Sub

    Private Sub ListaRolesAñadidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPersonasAñadidas.SelectedIndexChanged
        If ListaPersonasAñadidas.SelectedItem IsNot Nothing Then
            Dim newPeliculas As New Pelicula
            Dim newRol As New Rol
            newPeliculas.leerTitulo(Form3.ListBoxPeliculas.SelectedItem)
            Dim newPersona As New Persona
            Dim lista As Collection
            Dim i As Integer = 1
            Dim lon As Integer
            lon = InStr(ListaPersonasAñadidas.SelectedItem, " ")
            newPersona.leerNombreApellido(LSet(ListaPersonasAñadidas.SelectedItem, lon - 1), Mid(ListaPersonasAñadidas.SelectedItem, lon + 1, Len(ListaPersonasAñadidas.SelectedItem)))
            newPeliculas.leerRoles(newPersona)
            lista = newPeliculas.ListaRoles
            ListaRolesAñadidos.Items.Clear()
            While i <= lista.Count
                newRol.leerRol(lista.Item(i).IdRol)
                ListaRolesAñadidos.Items.Add(newRol.DescRol)
                i = i + 1
            End While
        End If
    End Sub
End Class