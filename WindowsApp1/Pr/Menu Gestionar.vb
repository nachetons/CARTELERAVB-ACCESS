Public Class Menu_Gestionar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gestionar_Personas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Gestionar_Roles.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Gestionar_Generos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Form2.Show()
    End Sub

    Private Sub Menu_Gestionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class