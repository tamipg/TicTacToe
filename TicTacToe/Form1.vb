' Implementar el conocido juego del 3 en raya.
' En esta primera versión deberemos implementar:
' - Las nueve casilla creadas en tiempo de ejecución y formando un 3x3
' - Menu que permita salir del juego, iniciar uno nuevo y tener una ayuda.
' - Jugaremos 2 humanos, asi que cada clic pondrá una imagen distinta en una casilla vacía.
' - El sistema elegirá de forma aleatoria que jugador (1 ó 2) es el primero en jugar e indicará quien ha ganado
'   o si ha terminado en empate, dando la posibilidad de volver a jugar o salir.

Public Class Form1

    Dim checker As Boolean
    Dim btnTic1 As String
    Dim btnTic2 As String
    Dim btnTic3 As String
    Dim btnTic4 As String
    Dim btnTic5 As String
    Dim btnTic6 As String
    Dim btnTic7 As String
    Dim btnTic8 As String
    Dim btnTic9 As String
    Dim plusone As Integer
    Dim contador As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTablero()
    End Sub


    Private Sub CargarTablero()

        Dim j As Integer
        For j = 1 To 9
            Dim casilla As New System.Windows.Forms.Button
            With casilla
                .Name = "btnTic" & j
                .Left = .Width * (j - 1)
                .Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\casilla.png"))
                .Dock = DockStyle.Fill
                .Parent = Me.Tablero
                Controls.Add(casilla) 'Esto añade la LABEL al formulario
                Tablero.Controls.Add(casilla)
                AddHandler casilla.Click, AddressOf clickGame
            End With
        Next
        checker = False
        contador = 0
    End Sub




    Private Sub clickGame(sender As Button, e As MouseEventArgs) Handles Tablero.Click
        Dim casilla As Button = sender
        contador += 1

        Select Case casilla.Name
            Case "btnTic1"
                If checker = True Then
                    btnTic1 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic1 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If

            Case "btnTic2"
                If checker = True Then
                    btnTic2 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic2 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If

            Case "btnTic3"
                If checker = True Then
                    btnTic3 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic3 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If
            Case "btnTic4"
                If checker = True Then
                    btnTic4 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic4 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If
            Case "btnTic5"
                If checker = True Then
                    btnTic5 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic5 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If
            Case "btnTic6"
                If checker = True Then
                    btnTic6 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic6 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If
            Case "btnTic7"
                If checker = True Then
                    btnTic7 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic7 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If
            Case "btnTic8"
                If checker = True Then
                    btnTic8 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic8 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If
            Case "btnTic9"
                If checker = True Then
                    btnTic9 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                Else
                    btnTic9 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                End If

        End Select
        score()
    End Sub

    Private Sub BorrarTablero()
        Tablero.Controls.Clear()
        btnTic1 = ""
        btnTic2 = ""
        btnTic3 = ""
        btnTic4 = ""
        btnTic5 = ""
        btnTic6 = ""
        btnTic7 = ""
        btnTic8 = ""
        btnTic9 = ""
    End Sub

    Private Sub score()
        If contador < 9 Then
            If btnTic1 = "X" And btnTic2 = "X" And btnTic3 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic4 = "X" And btnTic5 = "X" And btnTic6 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic7 = "X" And btnTic8 = "X" And btnTic9 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic1 = "X" And btnTic4 = "X" And btnTic7 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic2 = "X" And btnTic5 = "X" And btnTic8 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic3 = "X" And btnTic6 = "X" And btnTic9 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic1 = "X" And btnTic5 = "X" And btnTic9 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic3 = "X" And btnTic5 = "X" And btnTic7 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic1 = "O" And btnTic2 = "O" And btnTic3 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic4 = "O" And btnTic5 = "O" And btnTic6 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic7 = "O" And btnTic8 = "O" And btnTic9 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic1 = "O" And btnTic4 = "O" And btnTic7 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic2 = "O" And btnTic5 = "O" And btnTic8 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic3 = "O" And btnTic6 = "O" And btnTic9 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic1 = "O" And btnTic5 = "O" And btnTic9 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            ElseIf btnTic3 = "O" And btnTic5 = "O" And btnTic7 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                BorrarTablero()
                CargarTablero()

            End If
        Else
            MessageBox.Show("¡¡ EMPATE !!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarTablero()
            CargarTablero()
        End If




    End Sub
End Class
