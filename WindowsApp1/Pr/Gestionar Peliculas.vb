Public Class Form3
    Dim image As String = vbNull

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Menu_Gestionar.Show()
        Close()
    End Sub

    Private Sub actualizar()
        ListBoxPeliculas.Items.Clear()
        ListBoxRoles.Items.Clear()
        ListBoxGeneros.Items.Clear()
        ListBoxPersona.Items.Clear()
        PictureBoxFotoPelicula.Image = Nothing
        Iniciar()
    End Sub

    Private Sub Iniciar() Handles MyBase.Load
        Dim pel As New Pelicula
        Dim lista As Collection
        Dim i As Integer = 1
        Menu_Gestionar.Hide()
        lista = pel.leertodos()

        While i <= lista.Count
                ListBoxPeliculas.Items.Add(lista.Item(i).titulo)
                i = i + 1
            End While

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Añadir.Click
        Dim newPelicula As New Pelicula
        Dim subPelicula As New Pelicula
        Dim validar As Boolean = True
        If ListBoxPeliculas.Items.Count = 0 Then
            newPelicula.IdPelicula = 1
        Else
            subPelicula.leerTitulo(ListBoxPeliculas.Items(ListBoxPeliculas.Items.Count - 1))
            newPelicula.IdPelicula = subPelicula.IdPelicula + 1
        End If
        Try
            newPelicula.AñoEstreno = Estreno.Text
            newPelicula.Duracion = Duracion.Text
        Catch ex As InvalidCastException
            MessageBox.Show("Datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            validar = False
        End Try
        If validar = True Then
            If Titulo.Text = "" Then
                MessageBox.Show("Inserte datos en el titulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If PictureBoxFotoPelicula.Image Is Nothing Then
                    newPelicula.CartelPelicula = vbNull
                Else
                    newPelicula.CartelPelicula = image
                End If
                newPelicula.Sinopsis = Sinopsis.Text
                newPelicula.Titulo = Titulo.Text
                newPelicula.TituloOriginal = TituloOriginal.Text
                newPelicula.insertarPelicula()
                actualizar()
            End If
        End If
    End Sub

    Public Sub ListBoxPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPeliculas.SelectedIndexChanged
        If ListBoxPeliculas.SelectedItem IsNot Nothing Then
            Dim newPeliculas As New Pelicula
            Dim newPersona As New Persona
            newPeliculas.leerTitulo(ListBoxPeliculas.SelectedItem)
            ListBoxRoles.Items.Clear()
            Estreno.Text = newPeliculas.AñoEstreno
            Duracion.Text = newPeliculas.Duracion
            Sinopsis.Text = newPeliculas.Sinopsis
            If newPeliculas.CartelPelicula = "1" Then
                image = Nothing
            Else
                PictureBoxFotoPelicula.Load(newPeliculas.CartelPelicula)
                image = newPeliculas.CartelPelicula
            End If
            Titulo.Text = newPeliculas.Titulo
            TituloOriginal.Text = newPeliculas.TituloOriginal
            Dim datospeliculas As Collection
            Dim m As Integer = 1
            Dim subx As Integer = 0
            newPeliculas.leerPersonas()
            datospeliculas = newPeliculas.ListaPersonas
            ListBoxPersona.Items.Clear()
            While m <= datospeliculas.Count
                Dim l As Integer = 1
                While l < m
                    If datospeliculas.Item(m).IdPersona.ToString = datospeliculas.Item(l).IdPersona.ToString Then
                        subx = 1
                    End If
                    l = l + 1
                End While
                If subx = 0 Then
                    newPersona.leerPersona(datospeliculas.Item(m).IdPersona)
                    ListBoxPersona.Items.Add(newPersona.Nombre + " " + newPersona.Apellido)
                End If
                m = m + 1
            End While
            Dim newGenero As New Genero
            Dim datosgeneros As Collection
            Dim o As Integer = 1
            newPeliculas.leerGeneros()
            datosgeneros = newPeliculas.ListaGeneros
            ListBoxGeneros.Items.Clear()
            While o <= datosgeneros.Count
                newGenero.leerGenero(datosgeneros.Item(o).IdGenero)
                ListBoxGeneros.Items.Add(newGenero.DescGenero)
                o = o + 1
            End While
        End If
    End Sub
    Public Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPersona.SelectedIndexChanged
        If ListBoxPersona.SelectedItem IsNot Nothing Then
            Dim newPeliculas As New Pelicula
            Dim newRol As New Rol

            newPeliculas.leerTitulo(ListBoxPeliculas.SelectedItem)
            Dim newPersona As New Persona
            Dim lista As Collection
            Dim i As Integer = 1
            Dim x As Integer
            x = InStr(ListBoxPersona.SelectedItem, " ")
            newPersona.leerNombreApellido(LSet(ListBoxPersona.SelectedItem, x - 1), Mid(ListBoxPersona.SelectedItem, x + 1, Len(ListBoxPersona.SelectedItem)))
            newPeliculas.leerRoles(newPersona)
            lista = newPeliculas.ListaRoles
            ListBoxRoles.Items.Clear()

            While i <= lista.Count
                newRol.leerRol(lista.Item(i).IdRol)
                ListBoxRoles.Items.Add(newRol.DescRol)
                i = i + 1
            End While
        End If


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim OpenFileDialog As New OpenFileDialog
        Dim filename As String
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenFileDialog.Filter = "Archivos de imagen (*.JPEG)|*.jpg"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            filename = OpenFileDialog.FileName
            image = filename
        End If
        PictureBoxFotoPelicula.Image = New Bitmap(image)

    End Sub

    Public Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Titulo.Text = ""
        TituloOriginal.Text = ""
        Estreno.Text = ""
        Duracion.Text = ""
        Sinopsis.Text = ""
        actualizar()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim messageText As String = ("¿Estás seguro de querer eliminar la lista?")
        Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim popupCaption As String = "Advertencia"
        Dim popupResult As DialogResult
        popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
        If popupResult = System.Windows.Forms.DialogResult.Yes Then
            Dim newPelicula As New Pelicula
            newPelicula.eliminarTodoGen()
            newPelicula.eliminarTodoPar()
            newPelicula.eliminarTodo()
            actualizar()
        End If
    End Sub




    Private Sub Titulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Titulo.KeyPress

        If Char.IsDigit(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSymbol(e.KeyChar) Then

            e.Handled = True

        ElseIf Char.IsLetter(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If







    End Sub

    Private Sub Titulo_original_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TituloOriginal.KeyPress

        If Char.IsDigit(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSymbol(e.KeyChar) Then

            e.Handled = True

        ElseIf Char.IsLetter(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub



    Private Sub Duracion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Duracion.KeyPress




        If Char.IsDigit(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSymbol(e.KeyChar) Then

            e.Handled = True

        ElseIf Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        ElseIf Char.IsSeparator(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Me.Duracion.Text = Trim(Replace(Me.Duracion.Text, "  ", " "))

        Duracion.Select(Duracion.Text.Length, 0)
    End Sub


    ' Boton que nos envia al formulario para modificar las relaciones '


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seguir As Boolean = True
        If ListBoxPeliculas.SelectedItem IsNot Nothing Then
            Dim newPelicula As New Pelicula
            newPelicula.leerTitulo(ListBoxPeliculas.SelectedItem)
            Try
                newPelicula.AñoEstreno = Estreno.Text
                newPelicula.Duracion = Duracion.Text
            Catch ex As InvalidCastException
                MessageBox.Show("Variables con caracteres incompatibles", "Error en la introduccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                seguir = False
            End Try
            If seguir = True Then
                If Titulo.Text = "" Then
                    MessageBox.Show("Titulo vacio", "Error en la introduccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If PictureBoxFotoPelicula.Image Is Nothing Then
                        newPelicula.CartelPelicula = vbNull
                    Else
                        newPelicula.CartelPelicula = image
                    End If
                    newPelicula.Titulo = Titulo.Text
                    newPelicula.TituloOriginal = TituloOriginal.Text
                    newPelicula.Sinopsis = Sinopsis.Text
                    newPelicula.modificarPelicula()
                    actualizar()
                End If
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If ListBoxPeliculas.SelectedItem IsNot Nothing Then
            ModificarPeliculas.Show()
        Else
            MessageBox.Show("No se ha seleccionado pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBoxPeliculas.SelectedItem() IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar a " + ListBoxPeliculas.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPelicula As New Pelicula
                newPelicula.leerTitulo(ListBoxPeliculas.SelectedItem)
                newPelicula.eliminarPar()
                newPelicula.eliminarGen()
                newPelicula.eliminarPelicula()
                Titulo.Text = ""
                TituloOriginal.Text = ""
                Estreno.Text = ""
                Duracion.Text = ""
                Sinopsis.Text = ""
                actualizar()
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ListBoxPeliculas.SelectedItem() IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar a " + ListBoxPeliculas.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newPelicula As New Pelicula
                newPelicula.leerTitulo(ListBoxPeliculas.SelectedItem)
                newPelicula.eliminarPar()
                newPelicula.eliminarGen()
                newPelicula.eliminarPelicula()
                Titulo.Text = ""
                TituloOriginal.Text = ""
                Estreno.Text = ""
                Duracion.Text = ""
                Sinopsis.Text = ""
                actualizar()
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class