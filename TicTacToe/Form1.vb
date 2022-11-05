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
    End Sub




    Private Sub clickGame(sender As Button, e As MouseEventArgs) Handles Tablero.Click
        Dim casilla As Button = sender

        If (checker = False) Then
            casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
            checker = True
        Else
            casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
            checker = False
        End If
        casilla.Enabled = False

        Select Case casilla.Name
            Case "btnTic1"
                If checker = True Then
                    btnTic1 = "O"
                Else
                    btnTic1 = "X"
                End If

            Case "btnTic2"
                If checker = True Then
                    btnTic2 = "O"
                Else
                    btnTic2 = "X"
                End If

            Case "btnTic3"
                If checker = True Then
                    btnTic3 = "O"
                Else
                    btnTic3 = "X"
                End If
            Case "btnTic4"
                If checker = True Then
                    btnTic4 = "O"
                Else
                    btnTic4 = "X"
                End If
            Case "btnTic5"
                If checker = True Then
                    btnTic5 = "O"
                Else
                    btnTic5 = "X"
                End If
            Case "btnTic6"
                If checker = True Then
                    btnTic6 = "O"
                Else
                    btnTic6 = "X"
                End If
            Case "btnTic7"
                If checker = True Then
                    btnTic7 = "O"
                Else
                    btnTic7 = "X"
                End If
            Case "btnTic8"
                If checker = True Then
                    btnTic8 = "O"
                Else
                    btnTic8 = "X"
                End If
            Case "btnTic9"
                If checker = True Then
                    btnTic9 = "O"
                Else
                    btnTic9 = "X"
                End If

        End Select

        score(casilla)
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

    Private Sub score(sender As Button)
        Dim casilla As Button = sender

        If (btnTic1 = "X" And btnTic2 = "X" And btnTic3 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic4 = "X" And btnTic5 = "X" And btnTic6 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic7 = "X" And btnTic8 = "X" And btnTic9 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic1 = "X" And btnTic4 = "X" And btnTic7 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic2 = "X" And btnTic5 = "X" And btnTic8 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic3 = "X" And btnTic6 = "X" And btnTic9 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic1 = "X" And btnTic5 = "X" And btnTic9 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic3 = "X" And btnTic5 = "X" And btnTic7 = "X") Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic1 = "O" And btnTic2 = "O" And btnTic3 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic4 = "O" And btnTic5 = "O" And btnTic6 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic7 = "O" And btnTic8 = "O" And btnTic9 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic1 = "O" And btnTic4 = "O" And btnTic7 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic2 = "O" And btnTic5 = "O" And btnTic8 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic3 = "O" And btnTic6 = "O" And btnTic9 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic1 = "O" And btnTic5 = "O" And btnTic9 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If

        If (btnTic3 = "O" And btnTic5 = "O" And btnTic7 = "O") Then
            MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            BorrarTablero()
            CargarTablero()
        End If
    End Sub
End Class
