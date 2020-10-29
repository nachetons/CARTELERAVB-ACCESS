Public Class Form14
    Dim persona As Persona

    Private Sub Inicializar()
        Dim newPersona As New Persona()
        Dim lista As Collection
        Dim i As Integer = 1
        lista = newPersona.leertodos()
        While i <= lista.Count
            ListBox1.Items.Add(lista.Item(i).dni)
            i = i + 1
        End While
    End Sub
    Private Sub actualizar()
        ListBox1.Items.Clear()
        Inicializar()

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim per As New Persona()
        per.leerPersona(ListBox1.SelectedItem)
        TextBox1.Text = per.DNI
        TextBox2.Text = per.Nombre
    End Sub
    'Boton nueva persona
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim per As New Persona(TextBox1.Text, TextBox2.Text)
        per.insertarPersona()
        actualizar()
    End Sub
    'Boton eliminar datos
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim si As Byte
        Dim per As New Persona(TextBox1.Text, TextBox2.Text)

        If TextBox1.Text <> "" = 0 And TextBox2.Text <> "" = 0 Then
            MessageBox.Show("Seleccione una fila")
            Exit Sub

        End If
        si = MsgBox("¿Desea eliminar?", vbYesNo, "Eliminar")
        If si Then
            per.eliminarPersona()
            TextBox1.Text = ""
            TextBox2.Text = ""
            actualizar()
        End If

    End Sub
    'Boton limpiar datos
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        actualizar()
    End Sub
    'Boton salir del programa
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
    'Boton borrar base de datos
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim per As New Persona
        Dim b As String
        Dim c As String
        b = MsgBox("Estas seguro de que desea borrar la base de datos", vbQuestion + vbYesNo)
        If b = vbYes Then
            c = MsgBox("CUIDADO ESTA APUNTO DE BORRAR TODO, Si se quiere asi mismo no lo haga", vbQuestion + vbYesNo, "ATENCION!!!")
        End If
        If c = vbYes Then
            TextBox1.Text = per.DNI
            TextBox2.Text = per.Nombre
            per.eliminarTodo()
            actualizar()
        End If


    End Sub
    'Boton modificar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String
        a = MsgBox("Estas seguro de que desea modificar los registros", vbQuestion + vbYesNo, "Actualizar")
        If a = vbYes Then
            Dim per As New Persona(TextBox1.Text, TextBox2.Text)
            per.modificarPersona()
            actualizar()
        End If

    End Sub
End Class
