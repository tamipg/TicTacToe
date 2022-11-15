Public Class FormPropiedades

    Dim nombre1 As String
    Dim nombre2 As String
    Dim imagen1 As Image
    Dim imagen2 As Image




    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        nombre1 = TextBox1.Text
        nombre2 = TextBox2.Text
        imagen1 = PictureBox1.Image
        imagen2 = PictureBox2.Image
        Close()
        Form1.setConfig(nombre1, nombre2, imagen1, imagen2)
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub
End Class