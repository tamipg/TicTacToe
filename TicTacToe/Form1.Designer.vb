<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Tablero = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Juego = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaButton = New System.Windows.Forms.ToolStripButton()
        Me.jugador1Label = New System.Windows.Forms.Label()
        Me.Jugador2Label = New System.Windows.Forms.Label()
        Me.puntuacion1 = New System.Windows.Forms.Label()
        Me.Puntuacion2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tablero
        '
        Me.Tablero.ColumnCount = 3
        Me.Tablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.Tablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.Tablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.Tablero.Location = New System.Drawing.Point(16, 106)
        Me.Tablero.Name = "Tablero"
        Me.Tablero.RowCount = 3
        Me.Tablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.Tablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.Tablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.Tablero.Size = New System.Drawing.Size(330, 330)
        Me.Tablero.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Juego, Me.ToolStripSeparator1, Me.AyudaButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(363, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Juego
        '
        Me.Juego.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Juego.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.Juego.Image = CType(resources.GetObject("Juego.Image"), System.Drawing.Image)
        Me.Juego.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Juego.Name = "Juego"
        Me.Juego.Size = New System.Drawing.Size(51, 22)
        Me.Juego.Text = "Juego"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AyudaButton
        '
        Me.AyudaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AyudaButton.Image = CType(resources.GetObject("AyudaButton.Image"), System.Drawing.Image)
        Me.AyudaButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaButton.Name = "AyudaButton"
        Me.AyudaButton.Size = New System.Drawing.Size(45, 22)
        Me.AyudaButton.Text = "Ayuda"
        '
        'jugador1Label
        '
        Me.jugador1Label.AutoSize = True
        Me.jugador1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jugador1Label.Location = New System.Drawing.Point(12, 40)
        Me.jugador1Label.Name = "jugador1Label"
        Me.jugador1Label.Size = New System.Drawing.Size(107, 24)
        Me.jugador1Label.TabIndex = 0
        Me.jugador1Label.Text = "JugadorX:"
        '
        'Jugador2Label
        '
        Me.Jugador2Label.AutoSize = True
        Me.Jugador2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador2Label.Location = New System.Drawing.Point(12, 73)
        Me.Jugador2Label.Name = "Jugador2Label"
        Me.Jugador2Label.Size = New System.Drawing.Size(108, 24)
        Me.Jugador2Label.TabIndex = 2
        Me.Jugador2Label.Text = "JugadorO:"
        '
        'puntuacion1
        '
        Me.puntuacion1.AutoSize = True
        Me.puntuacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puntuacion1.Location = New System.Drawing.Point(115, 40)
        Me.puntuacion1.Name = "puntuacion1"
        Me.puntuacion1.Size = New System.Drawing.Size(21, 24)
        Me.puntuacion1.TabIndex = 3
        Me.puntuacion1.Text = "0"
        '
        'Puntuacion2
        '
        Me.Puntuacion2.AutoSize = True
        Me.Puntuacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntuacion2.Location = New System.Drawing.Point(115, 73)
        Me.Puntuacion2.Name = "Puntuacion2"
        Me.Puntuacion2.Size = New System.Drawing.Size(21, 24)
        Me.Puntuacion2.TabIndex = 4
        Me.Puntuacion2.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(363, 448)
        Me.Controls.Add(Me.Puntuacion2)
        Me.Controls.Add(Me.puntuacion1)
        Me.Controls.Add(Me.Jugador2Label)
        Me.Controls.Add(Me.jugador1Label)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Tablero)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tic Tac Toe"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tablero As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Juego As ToolStripDropDownButton
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AyudaButton As ToolStripButton
    Friend WithEvents jugador1Label As Label
    Friend WithEvents Jugador2Label As Label
    Friend WithEvents puntuacion1 As Label
    Friend WithEvents Puntuacion2 As Label
End Class
