Public Class FormPropiedades

    Dim nombre1 As String
    Dim nombre2 As String
    Dim imagen1 As Image
    Dim imagen2 As Image
    Dim tablero As Integer
    Dim vsComputer As Boolean

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click

        nombre1 = TextBox1.Text
        nombre2 = TextBox2.Text
        imagen1 = PictureBox1.Image
        imagen2 = PictureBox2.Image

        If RadioButton1.Checked Then
            tablero = 3
        ElseIf RadioButton2.Checked Then
            tablero = 4
        End If

        Form1.BorrarTablero()
        Form1.setConfig(nombre1, nombre2, imagen1, imagen2, tablero, vsComputer)
        Form1.CargarTablero(tablero)

        Close()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub

    Private Sub FormPropiedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefault1()
        setDefault2()
        RadioButton1.Checked = True


    End Sub

    Private Sub setDefault1()
        nombre1 = "Jugador 1"
        TextBox1.Text = "Jugador 1"
        imagen1 = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
        PictureBox1.Image = imagen1
    End Sub

    Private Sub setDefault2()
        nombre2 = "Jugador 2"
        TextBox2.Text = "Jugador 2"
        imagen2 = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
        PictureBox2.Image = imagen2
    End Sub

    Private Sub btImagen1_Click(sender As Object, e As EventArgs) Handles btImagen1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btImagen2_Click(sender As Object, e As EventArgs) Handles btImagen2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox2.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            setDefault1()
            TextBox1.Enabled = False
            btImagen1.Enabled = False
        Else
            TextBox1.Enabled = True
            btImagen1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            setDefault2()
            TextBox2.Enabled = False
            btImagen2.Enabled = False
        Else
            TextBox2.Enabled = True
            btImagen2.Enabled = True
        End If
    End Sub

    Private Sub cbOrdenador_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrdenador.CheckedChanged
        If cbOrdenador.Checked Then
            nombre2 = "Ordenador"
            TextBox2.Text = nombre2
            TextBox2.Enabled = False
            btImagen2.Enabled = False
            vsComputer = True
        Else
            nombre2 = "Jugador 2"
            TextBox2.Text = nombre2
            TextBox2.Enabled = True
            btImagen2.Enabled = True
            vsComputer = False
        End If
    End Sub
End Class