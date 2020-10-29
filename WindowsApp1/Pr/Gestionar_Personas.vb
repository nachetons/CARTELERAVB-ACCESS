Public Class Gestionar_Personas

    Dim imagen As String = vbNull
    Private Sub actualizar()
        ListaPersonas.Items.Clear()
        ListaPeliculas.Items.Clear()
        ListaRoles.Items.Clear()
        Foto.Image = Nothing
        Comienzo()
    End Sub
    Private Sub Gestionar_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Comienzo()
    End Sub
    Private Sub Comienzo()
        Dim personass As New Persona
        Dim dato As Collection
        dato = personass.leertodos()
        For Each personass In dato
            ListaPersonas.Items.Add(personass.Nombre + " " + personass.Apellido)
        Next
    End Sub

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPersonas.SelectedIndexChanged
        If ListaPersonas.SelectedItem IsNot Nothing Then
            Dim newPersona As New Persona
            Dim newPelicula As New Pelicula
            Dim num As Integer
            num = InStr(ListaPersonas.SelectedItem, " ")
            newPersona.leerNombreApellido(LSet(ListaPersonas.SelectedItem, num - 1), Mid(ListaPersonas.SelectedItem, num + 1, Len(ListaPersonas.SelectedItem)))
            If newPersona.FotoPersona = "1" Then
                Foto.Image = Nothing
            Else
                Foto.Load(newPersona.FotoPersona)
                imagen = newPersona.FotoPersona
            End If
            Nombre.Text = newPersona.Nombre
            Apellido.Text = newPersona.Apellido
            Nacionalidad.Text = newPersona.Nacionalidad
            F_Nacimiento.Text = newPersona.FechaNacimiento
            CiudadNacimiento.Text = newPersona.CiudadNacimiento
            PaisNacimiento.Text = newPersona.PaisNacimiento
            ListaRoles.Items.Clear()
            Dim datos As Collection
            Dim x As Integer = 1
            Dim num2 As Integer = 0
            newPersona.leerPeliculas()
            datos = newPersona.ListaPeliculas
            ListaPeliculas.Items.Clear()
            While x <= datos.Count
                Dim l As Integer = 1
                While l < x
                    If datos.Item(x).IdPelicula.ToString = datos.Item(l).IdPelicula.ToString Then
                        num2 = 1
                    End If
                    l = l + 1
                End While
                If num2 = 0 Then
                    newPelicula.leerPelicula(datos.Item(x).IdPelicula)
                    ListaPeliculas.Items.Add(newPelicula.Titulo)
                End If
                x = x + 1
            End While
        End If
    End Sub

    Public Sub ListaPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPeliculas.SelectedIndexChanged
        If ListaPeliculas.SelectedItem IsNot Nothing Then
            Dim newPersona As New Persona
            Dim num As Integer
            num = InStr(ListaPersonas.SelectedItem, " ")
            newPersona.leerNombreApellido(LSet(ListaPersonas.SelectedItem, num - 1), Mid(ListaPersonas.SelectedItem, num + 1, Len(ListaPersonas.SelectedItem)))
            Dim newPelicula As New Pelicula
            newPelicula.leerTitulo(ListaPeliculas.SelectedItem)
            Dim newRol As New Rol
            ListaRoles.Items.Clear()
            Dim datos As Collection
            Dim i As Integer = 1
            newPersona.leerRoles(newPelicula)
            datos = newPersona.ListaRoles
            ListaRoles.Items.Clear()
            While i <= datos.Count
                newRol.leerRol(datos.Item(i).IdRol)
                ListaRoles.Items.Add(newRol.DescRol)
                i = i + 1
            End While
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Menu_Gestionar.Show()
        Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim OpenFileDialog As New OpenFileDialog
        Dim filename As String
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenFileDialog.Filter = "Archivos de imagen (*.JPEG)|*.jpg"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            filename = OpenFileDialog.FileName
            imagen = filename
        End If
        Foto.Image = New Bitmap(imagen)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Nombre.Text = ""
        Apellido.Text = ""
        Nacionalidad.Text = ""
        F_Nacimiento.Text = ""
        CiudadNacimiento.Text = ""
        PaisNacimiento.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim messageText As String = ("¿Estás seguro de querer eliminar la lista?")
        Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim popupCaption As String = "Advertencia"
        Dim popupResult As DialogResult
        popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
        If popupResult = System.Windows.Forms.DialogResult.Yes Then
            Dim newPersona As New Persona

            newPersona.eliminarTodoPar()
            newPersona.eliminarTodo()
            actualizar()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newPersonas As New Persona
        Dim subPersonas As New Persona
        Dim validar As Boolean = True
        If ListaPersonas.Items.Count = 0 Then
            newPersonas.IdPersona = 1
        Else
            Dim num As Integer
            num = InStr(ListaPersonas.Items(ListaPersonas.Items.Count - 1), " ")
            subPersonas.leerNombreApellido(LSet(ListaPersonas.Items(ListaPersonas.Items.Count - 1), num - 1), Mid(ListaPersonas.Items(ListaPersonas.Items.Count - 1), num + 1, Len(ListaPersonas.Items(ListaPersonas.Items.Count - 1))))
            newPersonas.IdPersona = subPersonas.IdPersona + 1

        End If
        Try
            newPersonas.FechaNacimiento = F_Nacimiento.Text

        Catch ex As InvalidCastException
            MessageBox.Show("Datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            validar = False
        End Try
        If validar = True Then
            If Nombre.Text = "" Or Apellido.Text = "" Then
                MessageBox.Show("Inserte datos, campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Foto.Image Is Nothing Then
                    newPersonas.FotoPersona = vbNull
                Else
                    newPersonas.FotoPersona = imagen
                End If
                newPersonas.Nombre = Nombre.Text
                newPersonas.Apellido = Apellido.Text
                newPersonas.Nacionalidad = Nacionalidad.Text
                newPersonas.CiudadNacimiento = CiudadNacimiento.Text
                newPersonas.PaisNacimiento = PaisNacimiento.Text
                newPersonas.insertarPersona()
                actualizar()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seguir As Boolean = True
        If ListaPersonas.SelectedItem IsNot Nothing Then
            Dim newPersona As New Persona
            Dim num As Integer
            newPersona.leerNombreApellido(LSet(ListaPersonas.SelectedItem, num + 1), Mid(ListaPersonas.SelectedItem, num + 1, Len(ListaPersonas.SelectedItem)))
            Try
                newPersona.FechaNacimiento = F_Nacimiento.Text

            Catch ex As InvalidCastException
                MessageBox.Show("Variables con caracteres incompatibles", "Error en la introduccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                seguir = False
            End Try
            If seguir = True Then
                If Nombre.Text = "" Then
                    MessageBox.Show("Titulo vacio", "Error en la introduccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If Foto.Image Is Nothing Then
                        newPersona.FotoPersona = vbNull
                    Else
                        newPersona.FotoPersona = imagen
                    End If
                    newPersona.Nombre = Nombre.Text
                    newPersona.Apellido = Apellido.Text
                    newPersona.Nacionalidad = Nacionalidad.Text
                    newPersona.CiudadNacimiento = CiudadNacimiento.Text
                    newPersona.PaisNacimiento = PaisNacimiento.Text
                    newPersona.modificarPersona()
                    actualizar()
                End If
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListaPersonas.SelectedItem IsNot Nothing Then
            ModificarPersonas.Show()
            Me.Hide()
        Else
            MessageBox.Show("Selecciona a una persona", "Error", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListaPersonas.SelectedItem() IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar a " + ListaPersonas.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            Dim num As Integer
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPersona As New Persona
                newPersona.leerNombreApellido(LSet(ListaPersonas.SelectedItem, num + 1), Mid(ListaPersonas.SelectedItem, num + 1, Len(ListaPersonas.SelectedItem)))
                newPersona.eliminarPar()
                newPersona.eliminarPersona()
                Nombre.Text = ""
                Apellido.Text = ""
                Nacionalidad.Text = ""
                F_Nacimiento.Text = ""
                CiudadNacimiento.Text = ""
                PaisNacimiento.Text = ""
                actualizar()
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class