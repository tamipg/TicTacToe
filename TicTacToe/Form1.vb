
Public Class Form1

    Dim checker As Boolean
    Dim btnTic(8) As String
    Dim tableroX(8) As Boolean
    Dim tableroO(8) As Boolean
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

        For i = 1 To 9
            tableroX(i - 1) = False
            tableroO(i - 1) = False
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
                    tableroO(i) = True
                    casilla.Image = foto2
                    checker = False
                    casilla.Enabled = False
                Else
                    btnTic(i) = "X"
                    tableroX(i) = True
                    casilla.Image = foto1
                    checker = True
                    casilla.Enabled = False
                End If
            End If
        Next

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

    Public Sub BorrarTablero()
        Tablero.Controls.Clear()
        For i = 1 To 9
            btnTic(i - 1) = "btnTic" & i
        Next
    End Sub

    Private Sub ShowGanador()
        If checker = True Then
            mostrarGanador("X")
        ElseIf checker = False Then
            mostrarGanador("O")
        End If
    End Sub

    ' NO FUNCIONA
    Private Sub score()
        If contador < 9 Then
            If tableroX(0) And tableroX(1) And tableroX(2) Or
                tableroX(3) And tableroX(4) And tableroX(5) Or
                tableroX(6) And tableroX(7) And tableroX(8) Or
                tableroX(0) And tableroX(3) And tableroX(6) Or
                tableroX(1) And tableroX(4) And tableroX(7) Or
                tableroX(2) And tableroX(5) And tableroX(8) Or
                tableroX(0) And tableroX(4) And tableroX(8) Or
                tableroX(2) And tableroX(4) And tableroX(6) Then
                ShowGanador()
            ElseIf tableroO(0) And tableroO(1) And tableroO(2) Or
                tableroO(3) And tableroO(4) And tableroO(5) Or
                tableroO(6) And tableroO(7) And tableroO(8) Or
                tableroO(0) And tableroO(3) And tableroO(6) Or
                tableroO(1) And tableroO(4) And tableroO(7) Or
                tableroO(2) And tableroO(5) And tableroO(8) Or
                tableroO(0) And tableroO(4) And tableroO(8) Or
                tableroO(2) And tableroO(4) And tableroO(6) Then
                ShowGanador()
            End If
        ElseIf contador = 9 Then
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
