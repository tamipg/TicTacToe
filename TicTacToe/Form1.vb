
Public Class Form1

    Dim checker As Boolean
    Dim btnTic(8) As String
    Dim plusone As Integer
    Dim contador As Integer
    Dim turno1, turno2 As Integer
    Dim turno As Integer
    Dim jugador As Integer
    Dim foto1, foto2 As Image



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTablero()
        turno1 = 1
        turno2 = 2
        turnoX.Visible = False
        turnoO.Visible = False
        AsignaTurno()
        Tablero.Enabled = False
        foto1 = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
        foto2 = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
    End Sub

    Public Sub setConfig(nombre1 As String, nombre2 As String, imagen1 As Image, imagen2 As Image)
        jugador1Label.Text = nombre1
        Jugador2Label.Text = nombre2
        foto1 = imagen1
        foto2 = imagen2
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


    Public Sub CargarTablero()
        turnoX.Visible = False
        turnoO.Visible = False

        Dim j As Integer
        For j = 1 To 9
            Dim casilla As New System.Windows.Forms.Button
            With casilla
                .Name = "btnTic" & j
                btnTic(j - 1) = .Name
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

        For i = 0 To 8
            If casilla.Name.Equals(btnTic(i)) Then
                If checker = True Then
                    btnTic(i) = "O"
                    casilla.Image = foto2
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic(i) = "X"
                    casilla.Image = foto1
                    checker = True
                    casilla.Enabled = False
                End If
            End If
        Next

        score(casilla)

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

    Public Sub BorrarTablero()
        Tablero.Controls.Clear()
        For i = 1 To 9
            btnTic(i - 1) = "btnTic" & i
        Next
    End Sub

    ' NO FUNCIONA
    Private Sub score(sender As Button)
        If contador < 9 Then
            If btnTic(0).Equals(btnTic(1)).Equals(btnTic(2)) Then
                If checker = False Then
                    mostrarGanador("X")
                ElseIf checker = True Then
                    mostrarGanador("O")
                End If
            ElseIf btnTic(3).Equals(btnTic(4)).Equals(btnTic(5)) Then
                If jugador = 1 Then
                    mostrarGanador("X")
                ElseIf jugador = 2 Then
                    mostrarGanador("O")
                End If
            ElseIf btnTic(6).Equals(btnTic(7)).Equals(btnTic(8)) Then
                If jugador = 1 Then
                    mostrarGanador("X")
                ElseIf jugador = 2 Then
                    mostrarGanador("O")
                End If
            ElseIf btnTic(0).Equals(btnTic(3)).Equals(btnTic(6)) Then
                If jugador = 1 Then
                    mostrarGanador("X")
                ElseIf jugador = 2 Then
                    mostrarGanador("O")
                End If
            ElseIf btnTic(1).Equals(btnTic(4)).Equals(btnTic(7)) Then
                If jugador = 1 Then
                    mostrarGanador("X")
                ElseIf jugador = 2 Then
                    mostrarGanador("O")
                End If
            ElseIf btnTic(2).Equals(btnTic(5)).Equals(btnTic(8)) Then
                If jugador = 1 Then
                    mostrarGanador("X")
                ElseIf jugador = 2 Then
                    mostrarGanador("O")
                End If
            ElseIf btnTic(0).Equals(btnTic(4)).Equals(btnTic(8)) Then
                If jugador = 1 Then
                    mostrarGanador("X")
                ElseIf jugador = 2 Then
                    mostrarGanador("O")
                End If
            ElseIf btnTic(2).Equals(btnTic(4)).Equals(btnTic(6)) Then
                If jugador = 1 Then
                    mostrarGanador("X")
                ElseIf jugador = 2 Then
                    mostrarGanador("O")
                End If
            End If
        Else
            MessageBox.Show("¡¡ EMPATE !!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tablero.Enabled = False
        End If

    End Sub

    Private Sub mostrarGanador(sender As String)
        If sender = "X" Then
            MessageBox.Show("El ganador es el jugador X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            Tablero.Enabled = False
        Else
            MessageBox.Show("El ganador es el jugador 0", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            Tablero.Enabled = False
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

    Private Sub PropiedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropiedadesToolStripMenuItem.Click
        My.Forms.FormPropiedades.Show()
    End Sub
End Class
