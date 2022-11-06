
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
    Dim turno1 As Integer
    Dim turno2 As Integer
    Dim turno As Integer
    Dim jugador As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTablero()
        turno1 = 1
        turno2 = 2
        turnoX.Visible = False
        turnoO.Visible = False
        AsignaTurno()
    End Sub

    Private Sub AsignaTurno()
        turno = Int((30 * Rnd()) + 1)

        If turno Mod 2 = 0 Then
            jugador = 1
        Else
            jugador = 2
        End If

        If jugador = 1 Then
            turnoX.Visible = True
            checker = False
        ElseIf jugador = 2 Then
            turnoO.Visible = True
            checker = True
        End If
    End Sub


    Private Sub CargarTablero()
        turnoX.Visible = False
        turnoO.Visible = False

        Dim j As Integer
        For j = 1 To 9
            Dim casilla As New System.Windows.Forms.Button
            With casilla
                .Name = "btnTic" & j
                .Left = .Width * (j - 1)
                .Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\casilla.png"))
                .Dock = DockStyle.Fill
                .Parent = Me.Tablero
                Tablero.Controls.Add(casilla)
                AddHandler casilla.Click, AddressOf clickGame
            End With
        Next
        checker = False
        contador = 0
        Tablero.Enabled = True
        AsignaTurno()
    End Sub


    Private Sub clickGame(sender As Button, e As MouseEventArgs)
        Dim casilla As Button = sender
        contador += 1

        Select Case casilla.Name
            Case "btnTic1"
                If checker = True Then
                    btnTic1 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic1 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If

            Case "btnTic2"
                If checker = True Then
                    btnTic2 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic2 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If

            Case "btnTic3"
                If checker = True Then
                    btnTic3 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic3 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If
            Case "btnTic4"
                If checker = True Then
                    btnTic4 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic4 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If
            Case "btnTic5"
                If checker = True Then
                    btnTic5 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic5 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If
            Case "btnTic6"
                If checker = True Then
                    btnTic6 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic6 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If
            Case "btnTic7"
                If checker = True Then
                    btnTic7 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic7 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If
            Case "btnTic8"
                If checker = True Then
                    btnTic8 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic8 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If
            Case "btnTic9"
                If checker = True Then
                    btnTic9 = "O"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic9 = "X"
                    casilla.Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
                    checker = True
                    casilla.Enabled = False
                End If

        End Select
        score()
        CambiaTurno()

    End Sub

    Private Sub CambiaTurno()
        If jugador = 1 Then
            jugador = 2
            turnoO.Visible = True
            turnoX.Visible = False
            checker = True
        ElseIf jugador = 2 Then
            jugador = 1
            turnoX.Visible = True
            turnoO.Visible = False
            checker = False
        End If
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
                Tablero.Enabled = False
            ElseIf btnTic4 = "X" And btnTic5 = "X" And btnTic6 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic7 = "X" And btnTic8 = "X" And btnTic9 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic1 = "X" And btnTic4 = "X" And btnTic7 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic2 = "X" And btnTic5 = "X" And btnTic8 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic3 = "X" And btnTic6 = "X" And btnTic9 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic1 = "X" And btnTic5 = "X" And btnTic9 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic3 = "X" And btnTic5 = "X" And btnTic7 = "X" Then
                MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(puntuacion1.Text)
                puntuacion1.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic1 = "O" And btnTic2 = "O" And btnTic3 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic4 = "O" And btnTic5 = "O" And btnTic6 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic7 = "O" And btnTic8 = "O" And btnTic9 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic1 = "O" And btnTic4 = "O" And btnTic7 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic2 = "O" And btnTic5 = "O" And btnTic8 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic3 = "O" And btnTic6 = "O" And btnTic9 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic1 = "O" And btnTic5 = "O" And btnTic9 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            ElseIf btnTic3 = "O" And btnTic5 = "O" And btnTic7 = "O" Then
                MessageBox.Show("El ganador es el jugador O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                plusone = Convert.ToInt64(Puntuacion2.Text)
                Puntuacion2.Text = Convert.ToString(plusone + 1)
                Tablero.Enabled = False
            End If
        Else
            If contador = 9 Then
                contador = 8
                score()
            Else
                MessageBox.Show("¡¡ EMPATE !!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tablero.Enabled = False
            End If

        End If



    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        BorrarTablero()
        CargarTablero()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AyudaButton_Click(sender As Object, e As EventArgs) Handles AyudaButton.Click
        My.Forms.FormAyuda.Show()
    End Sub
End Class
