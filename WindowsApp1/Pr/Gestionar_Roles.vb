Public Class Gestionar_Roles
    Private Sub Gestionar_Roles_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Menu_Gestionar.Show()
        Close()
    End Sub

    Private Sub actualizar()
        ListBoxRol.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        TextBox7.Clear()
        Iniciar()
    End Sub

    Private Sub Iniciar() Handles MyBase.Load
        Dim rol As New Rol
        Dim lista As Collection
        Dim i As Integer = 1
        Menu_Gestionar.Hide()
        lista = rol.leertodos()

        While i <= lista.Count
            ListBoxRol.Items.Add(lista.Item(i).DescRol)
            i = i + 1
        End While

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxRol.SelectedIndexChanged
        If ListBoxRol.SelectedItem IsNot Nothing Then
            Dim newRoles As New Rol
            Dim newPersona As New Persona

            newRoles.leerdescrol(ListBoxRol.SelectedItem)
            newRoles.leerPersonas(newRoles.IdRol)

            TextBox7.Text = newRoles.DescRol
            Dim datos As Collection
            Dim x As Integer = 1
            Dim num2 As Integer = 0

            datos = newRoles.ListaPersonas
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            While x <= datos.Count
                Dim l As Integer = 1
                While l < x
                    If datos.Item(x).IdPersona.ToString = datos.Item(l).IdPersona.ToString Then
                        num2 = 1
                    End If
                    l = l + 1
                End While
                If num2 = 0 Then
                    newPersona.leerPersona(datos.Item(x).IdPersona)
                    ListBox2.Items.Add(newPersona.Nombre + " " + newPersona.Apellido)
                End If
                x = x + 1
            End While
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedItem IsNot Nothing Then
            Dim newPersona As New Persona
            Dim newPelicula As New Pelicula
            Dim newRol As New Rol
            Dim datos As Collection
            Dim x As Integer = 1
            newRol.leerdescrol(ListBoxRol.SelectedItem)

            Dim seleccionado As String = ListBox2.SelectedItem()
            Dim nombre As String = seleccionado.Substring(0, seleccionado.IndexOf(" "))
            Dim apellido As String = seleccionado.Substring(seleccionado.IndexOf(" ") + 1)
            newPersona.leerNombreApellido(nombre, apellido)

            newRol.leerPeliculas(newPersona)

            datos = newRol.ListaPeliculas
            ListBox3.Items.Clear()

            While x <= datos.Count

                newPelicula.leerPelicula(datos.Item(x).IdPelicula)
                ListBox3.Items.Add(newPelicula.Titulo)
                x = x + 1
            End While
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newRol As New Rol
        Dim subRol As New Rol
        Dim validar As Boolean = True
        If ListBoxRol.Items.Count = 0 Then
            newRol.IdRol = 1
        Else
            subRol.leerdescrol(ListBoxRol.Items(ListBoxRol.Items.Count - 1))
            newRol.IdRol = subRol.IdRol + 1
        End If

        If validar = True Then
            If TextBox7.Text = "" Then
                MessageBox.Show("Inserte datos en la Descripcion de Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                newRol.DescRol = TextBox7.Text
                newRol.insertarRol()
                actualizar()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seguir As Boolean = True
        If ListBoxRol.SelectedItem IsNot Nothing Then
            Dim newRol As New Rol
            newRol.leerdescrol(ListBoxRol.SelectedItem)
            If seguir = True Then
                If ListBoxRol.Text = "" Then
                    MessageBox.Show("Rol vacio", "Error en la introduccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    newRol.DescRol = TextBox7.Text
                    newRol.modificarRol()
                    actualizar()
                End If
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ModificarRoles.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBoxRol.SelectedItem() IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar a " + ListBoxRol.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newrol As New Rol
                newrol.leerdescrol(ListBoxRol.SelectedItem)
                newrol.eliminarPar()
                newrol.eliminarRol()
                TextBox7.Text = ""

                actualizar()
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim messageText As String = ("¿Estás seguro de querer eliminar la lista?")
        Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim popupCaption As String = "Advertencia"
        Dim popupResult As DialogResult
        popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
        If popupResult = System.Windows.Forms.DialogResult.Yes Then
            Dim newRol As New Pelicula
            newRol.eliminarTodoGen()
            newRol.eliminarTodoPar()
            newRol.eliminarTodo()
            actualizar()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox7.Text = ""
        actualizar()
    End Sub
End Class