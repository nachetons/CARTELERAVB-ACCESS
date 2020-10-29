Imports WindowsApp1

Public Class Gestionar_Generos
    Friend Sub read(idGenero As Integer, genero As Genero)
        Throw New NotImplementedException()
    End Sub
    Private Sub actualizar()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        TextBox1.Clear()
        Iniciar()
    End Sub

    Private Sub Iniciar() Handles MyBase.Load
        Dim Genero As New Genero
        Dim lista As Collection
        Dim i As Integer = 1
        Menu_Gestionar.Hide()
        lista = Genero.leertodos()

        While i <= lista.Count
            ListBox1.Items.Add(lista.Item(i).DescGenero)
            i = i + 1
        End While

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Menu_Gestionar.Show()
        Close()
    End Sub




    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim newGenero As New Genero
            Dim newPelicula As New Pelicula
            Dim num As Integer
            num = InStr(ListBox1.SelectedItem, " ")
            newGenero.leerdescGenero(ListBox1.SelectedItem)
            TextBox1.Text = newGenero.DescGenero

            Dim datos As Collection
            Dim x As Integer = 1
            Dim num2 As Integer = 0
            newGenero.leerPeliculas()
            datos = newGenero.ListaPeliculas
            ListBox2.Items.Clear()
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
                    ListBox2.Items.Add(newPelicula.Titulo)
                End If
                x = x + 1
            End While
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ModificarGeneros.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seguir As Boolean = True
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim newGenero As New Genero
            newGenero.leerdescGenero(ListBox1.SelectedItem)
            If seguir = True Then
                If ListBox1.Text = "" Then
                    MessageBox.Show("Genero vacio", "Error en la introduccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    newGenero.DescGenero = TextBox1.Text
                    newGenero.modificarGenero()
                    actualizar()
                End If
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox1.SelectedItem() IsNot Nothing Then
            Dim messageText As String = ("¿Estás seguro de querer eliminar a " + ListBox1.SelectedItem().ToString + " de la lista?")
            Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim popupCaption As String = "Advertencia"
            Dim popupResult As DialogResult
            popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
            If popupResult = System.Windows.Forms.DialogResult.Yes Then
                Dim newGenero As New Genero
                newGenero.leerdescGenero(ListBox1.SelectedItem)
                newGenero.eliminarPeliGen()
                newGenero.eliminarGenero()
                TextBox1.Text = ""

                actualizar()
            End If
        Else
            MessageBox.Show("No ha seleccionado ningún Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newGenero As New Genero
        Dim subGenero As New Genero
        Dim validar As Boolean = True
        If ListBox1.Items.Count = 0 Then
            newGenero.IdGenero = 1
        Else
            subGenero.leerdescGenero(ListBox1.Items(ListBox1.Items.Count - 1))
            newGenero.IdGenero = subGenero.IdGenero + 1
        End If

        If validar = True Then
            If TextBox1.Text = "" Then
                MessageBox.Show("Inserte datos en la Descripcion de Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                newGenero.DescGenero = TextBox1.Text
                newGenero.insertarGenero()
                actualizar()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        actualizar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim messageText As String = ("¿Estás seguro de querer eliminar la lista?")
        Dim responseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim popupCaption As String = "Advertencia"
        Dim popupResult As DialogResult
        popupResult = MessageBox.Show(messageText, popupCaption, responseButtons, MessageBoxIcon.Information)
        If popupResult = System.Windows.Forms.DialogResult.Yes Then
            Dim newGenero As New Genero
            newGenero.eliminarTodoGen()
            newGenero.eliminarTodoPeliGen()
            newGenero.eliminarTodoGen()
            actualizar()
        End If
    End Sub

End Class