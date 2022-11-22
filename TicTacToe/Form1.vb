
Public Class Form1

    Dim checker As Boolean
    Dim btnTic(16) As String
    Dim tableroX(16) As Boolean
    Dim tableroO(16) As Boolean
    Dim plusone As Integer
    Dim contador As Integer
    Dim turno1, turno2 As Integer
    Dim name1, name2 As String
    Dim turno As Integer
    Dim jugador As Integer
    Dim foto1, foto2 As Image
    Dim tablero As New TableLayoutPanel
    Dim numTablero As Integer
    Dim numFila As Integer
    Dim vsOrdenador As Boolean
    Dim tabJuego(16) As Button
    Dim finJuego As Boolean


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numFila = 3
        numTablero = numFila * numFila
        CargarTablero(numFila)
        turno1 = 1
        turno2 = 2
        name1 = "X"
        name2 = "O"
        turnoX.Visible = False
        turnoO.Visible = False
        AsignaTurno()
        tablero.Enabled = False
        vsOrdenador = False
        finJuego = False
        foto1 = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\x.png"))
        foto2 = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\o.png"))
    End Sub

    ' CONFIGURACION DE PARTIDA
    Public Sub setConfig(nombre1 As String, nombre2 As String, imagen1 As Image, imagen2 As Image, tablero As Integer, vsComputer As Boolean)
        jugador1Label.Text = nombre1
        Jugador2Label.Text = nombre2
        foto1 = imagen1
        foto2 = imagen2
        name1 = nombre1
        name2 = nombre2
        numFila = tablero
        numTablero = numFila * numFila
        vsOrdenador = vsComputer
    End Sub

    ' ELIGE QUIEN EMPIEZA
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

    ' CAMBIA DE JUGADOR
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

    ' CREA TABLERO
    Public Sub CargarTablero(sender As Integer)
        turnoX.Visible = False
        turnoO.Visible = False

        ' Tamaño de tablero
        With tablero
            .AutoSize = False
            .RowCount = numFila
            .Size = New Size(330, 330)
            .ColumnCount = numFila
            .RowCount = numFila
        End With

        numTablero = numFila * numFila

        ' Generar casillas
        Dim j As Integer
        For j = 1 To numTablero
            Dim casilla As New System.Windows.Forms.Button
            With casilla
                .Name = "boton" & j
                btnTic(j - 1) = .Name
                .Left = .Width * (j - 1)
                .Image = Image.FromFile(IO.Path.Combine(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Application.StartupPath)), "imagenes\casilla.png"))
                .Dock = DockStyle.Fill
                .Parent = Me.tablero
                If numFila = 3 Then
                    .Width = 104
                    .Height = 104
                ElseIf numFila = 4 Then
                    .Width = 76
                    .Height = 76
                End If
                tablero.Controls.Add(casilla)
                tabJuego(j - 1) = casilla
                AddHandler casilla.Click, AddressOf clickGame
            End With
        Next

        FlowLayoutPanel1.Controls.Add(tablero)

        checker = False
        contador = 0
        tablero.Enabled = True
        AsignaTurno()
        finJuego = False
        newGame()
    End Sub

    ' COMIENZA PARTIDA
    Private Sub newGame()
        If vsOrdenador = True Then
            If checker = True Then
                JuegaPC()
            End If
        End If
    End Sub

    ' CLICK EN EL TABLERO
    Private Sub clickGame(sender As Button, e As MouseEventArgs)
        ' juego manual
        If vsOrdenador = False Then
            Jugada(sender)
        End If

        ' juego vs ordenador
        If vsOrdenador = True Then
            If checker = False Then
                Jugada(sender)
            End If

            If finJuego = False Then
                JuegaPC()
            End If

        End If
    End Sub

    ' PRIORIDADES JUEGO VS ORDENADOR
    Private Sub JuegaPC()
        If BuscaCasilla("O") = False Then
            If BuscaCasilla("X") = False Then
                CualquierCasilla()
            End If
        End If
    End Sub

    ' BUSCA CASILLA PARA BLOQUEAR O GANAR 
    Private Function BuscaCasilla(sender As String)
        Dim count As Integer
        Dim vacio As Integer

        ' horizontal
        For i As Integer = 1 To numTablero Step numFila
            count = 0
            For e As Integer = i To i + (numFila - 1)
                Dim bt = tablero.Controls.Find("boton" & e, True)
                If bt.Length > 0 Then
                    If bt(0).Text = sender Then
                        count += 1
                    Else
                        vacio = e
                    End If
                End If
            Next

            If count = (numFila - 1) Then
                Dim bt = tablero.Controls.Find("boton" & vacio, True)
                If bt.Length > 0 Then
                    If bt(0).Text = String.Empty Then
                        Jugada(bt(0))
                        Return True
                    End If
                End If

            End If
        Next

        ' vertical
        For i As Integer = 1 To numFila
            count = 0
            For e As Integer = 1 To numTablero Step numFila
                Dim bt = tablero.Controls.Find("boton" & e, True)
                If bt.Length > 0 Then
                    If bt(0).Text = sender Then
                        count += 1
                    Else
                        vacio = e
                    End If
                End If
            Next
            If count = (numFila - 1) Then
                Dim bt = tablero.Controls.Find("boton" & vacio, True)
                If bt.Length > 0 Then
                    If bt(0).Text = String.Empty Then
                        Jugada(bt(0))
                        Return True
                    End If
                End If
            End If
        Next

        ' diagonal
        count = 0
        For e As Integer = 1 To numTablero Step numFila + 1
            Dim bt = tablero.Controls.Find("boton" & e, True)
            If bt.Length > 0 Then
                If bt(0).Text = sender Then
                    count += 1
                Else
                    vacio = e
                End If
            End If
        Next
        If count = numFila - 1 Then
            Dim bt = tablero.Controls.Find("boton" & vacio, True)
            If bt.Length > 0 Then
                If bt(0).Text = String.Empty Then
                    Jugada(bt(0))
                    Return True
                End If
            End If
        End If

        count = 0
        For e As Integer = numFila To numTablero Step numFila - 1
            Dim bt = tablero.Controls.Find("boton" & e, True)
            If bt.Length > 0 Then
                If bt(0).Text = sender Then
                    count += 1
                Else
                    vacio = e
                End If
            End If
        Next
        If count = numFila - 1 Then
            Dim bt = tablero.Controls.Find("boton" & vacio, True)
            If bt.Length > 0 Then
                If bt(0).Text = String.Empty Then
                    Jugada(bt(0))
                    Return True
                End If
            End If
        End If

        Return False
    End Function

    ' ELIGE UNA CASILLA AL AZAR
    Private Sub CualquierCasilla()
        Dim numero As New Random

        While True And contador < numTablero
            Dim seleccion As Integer = numero.Next(1, numTablero + 1)
            Dim boton = Me.Controls.Find("boton" & seleccion, True)
            If boton.Length > 0 Then
                If boton(0).Text = String.Empty Then
                    boton(0).Text = "O"
                    Jugada(boton(0))
                    Exit While
                End If
            End If
        End While
    End Sub

    ' MAECA LA CASILLA SELECCIONADA
    Private Sub Jugada(sender As Button)
        Dim casilla As Button = sender

        For i = 0 To numTablero - 1
            If casilla.Name.Equals(btnTic(i)) Then
                If checker = True Then
                    btnTic(i) = "O"
                    tableroO(i) = True
                    tabJuego(i).Text = "O"
                    casilla.Image = foto2
                    casilla.Enabled = False
                ElseIf checker = False Then
                    btnTic(i) = "X"
                    tableroX(i) = True
                    tabJuego(i).Text = "X"
                    casilla.Image = foto1
                    casilla.Enabled = False
                End If
            End If
        Next
        score()
        CambiaTurno()
    End Sub


    ' BORRA EL TABLERO
    Public Sub BorrarTablero()
        tablero.Controls.Clear()
        For i = 1 To numTablero
            btnTic(i - 1) = "btnTic" & i
            tabJuego(i - 1).Text = vbEmpty
        Next
        For i = 1 To numTablero
            tableroX(i - 1) = False
            tableroO(i - 1) = False
        Next
        For i = 0 To numTablero - 1
            tabJuego(i).Text = ""
        Next
    End Sub


    ' COMPRUEBA SI UNO DE LOS 2 HA GANADO O HAY EMPATE
    Private Sub score()
        contador += 1

        If numFila = 3 Then
            If contador <= 9 Then
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
                ElseIf contador = 9 Then
                    MessageBox.Show("¡¡ EMPATE !!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tablero.Enabled = False
                    finJuego = True
                End If
            End If
        ElseIf numFila = 4 Then
            If contador <= 16 Then
                If tableroX(0) And tableroX(1) And tableroX(2) And tableroX(3) Or
                    tableroX(4) And tableroX(5) And tableroX(6) And tableroX(7) Or
                    tableroX(8) And tableroX(9) And tableroX(10) And tableroX(11) Or
                    tableroX(12) And tableroX(13) And tableroX(14) And tableroX(15) Or
                    tableroX(0) And tableroX(4) And tableroX(8) And tableroX(12) Or
                    tableroX(1) And tableroX(5) And tableroX(9) And tableroX(13) Or
                    tableroX(2) And tableroX(6) And tableroX(10) And tableroX(14) Or
                    tableroX(3) And tableroX(7) And tableroX(11) And tableroX(15) Or
                    tableroX(0) And tableroX(5) And tableroX(10) And tableroX(15) Or
                    tableroX(3) And tableroX(6) And tableroX(9) And tableroX(12) Then
                    ShowGanador()
                ElseIf tableroO(0) And tableroO(1) And tableroO(2) And tableroO(3) Or
                    tableroO(4) And tableroO(5) And tableroO(6) And tableroO(7) Or
                    tableroO(8) And tableroO(9) And tableroO(10) And tableroO(11) Or
                    tableroO(12) And tableroO(13) And tableroO(14) And tableroO(15) Or
                    tableroO(0) And tableroO(4) And tableroO(8) And tableroO(12) Or
                    tableroO(1) And tableroO(5) And tableroO(9) And tableroO(13) Or
                    tableroO(2) And tableroO(6) And tableroO(10) And tableroO(14) Or
                    tableroO(3) And tableroO(7) And tableroO(11) And tableroO(15) Or
                    tableroO(0) And tableroO(5) And tableroO(10) And tableroO(15) Or
                    tableroO(3) And tableroO(6) And tableroO(9) And tableroO(12) Then
                    ShowGanador()
                ElseIf contador = 16 Then
                    MessageBox.Show("¡¡ EMPATE !!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tablero.Enabled = False
                    finJuego = True
                End If
            End If
        End If
    End Sub

    ' MUESTRA UN MENSAJE CON EL GANADOR
    Private Sub ShowGanador()
        If checker = True Then
            mostrarGanador("O")
        ElseIf checker = False Then
            mostrarGanador("X")
        End If
    End Sub

    Private Sub mostrarGanador(sender As String)
        If sender = "X" Then
            MessageBox.Show("El ganador es " + name1, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(puntuacion1.Text)
            puntuacion1.Text = Convert.ToString(plusone + 1)
            tablero.Enabled = False
        Else
            MessageBox.Show("El ganador es " + name2, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Puntuacion2.Text)
            Puntuacion2.Text = Convert.ToString(plusone + 1)
            tablero.Enabled = False
        End If
        finJuego = True
    End Sub

    ' NUEVA PARTIDA
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        BorrarTablero()
        CargarTablero(numFila)
    End Sub

    ' CERRAR EL JUEGO
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    ' REINICIAR EL MARCADOR
    Private Sub botonBorrar_Click(sender As Object, e As EventArgs) Handles botonBorrar.Click
        puntuacion1.Text = 0
        Puntuacion2.Text = 0
    End Sub

    ' ABRIR VENTANA DE AYUDA
    Private Sub AyudaButton_Click(sender As Object, e As EventArgs) Handles AyudaButton.Click
        My.Forms.FormAyuda.Show()
    End Sub

    ' ABRIR VENTANA DE CONFIGURACION
    Private Sub PropiedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropiedadesToolStripMenuItem.Click
        My.Forms.FormPropiedades.Show()
    End Sub
End Class
