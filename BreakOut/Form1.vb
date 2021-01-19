Public Class Form1
    Dim X As Integer = 2
    Dim Y As Integer = -2
    Dim quantosblocos As Integer = 5
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            If pb_barra.Left > 0 Then
                pb_barra.Left = pb_barra.Left - 5
            ElseIf pb_barra.Left <= 0 Then
                pb_barra.Left = pb_barra.Left
            End If
        End If
        If e.KeyCode = Keys.Right Then
            If pb_barra.Right < 816 Then
                pb_barra.Left = pb_barra.Left + 5
            ElseIf pb_barra.Right >= 816 Then
                pb_barra.Left = pb_barra.Left
            End If
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim blocoNome As String
        Dim blocoNumero As Integer
        Dim loc_bola, loc_barra, loc_deathzone, loc_bloco As Point
        loc_bola = pb_bola.Location
        loc_barra = pb_barra.Location
        loc_deathzone = pb_deathzone.Location
        loc_bloco = pb_block1.Location

        'Bola bate no topo e muda de Y
        If pb_bola.Top <= 0 Then
            Y = -Y
        End If
        'Bola vem de cima e para a direita e vai para a esquerda e para baixo
        If pb_bola.Right >= 816 Then
            X = -X
        End If
        'Bola bate na parede da esquerda e vai para baixo e para a direita
        If pb_bola.Left <= 0 Then
            X = -X
        End If
        'Bola passa pela zona debaixo da barra
        If loc_bola.Y >= loc_deathzone.Y Then
            Timer1.Stop()
            MessageBox.Show("Perdeu")
            Close()
        End If

        blocoNumero = 1
        blocoNome = "pb_block" & blocoNumero

        Do While Me.Controls.Find(blocoNome, True).Count() > 0
            bateBloco(Me.Controls(blocoNome), pb_bola)
            blocoNumero = blocoNumero + 1
            blocoNome = "pb_block" & blocoNumero
        Loop

        If quantosblocos = 0 Then
            Timer1.Stop()
            MessageBox.Show("Ganhaste")
            Close()
        End If


        'Bola bate na barra e muda de Y
        If loc_bola.Y + pb_bola.Height >= loc_barra.Y And loc_barra.X <= loc_bola.X + pb_bola.Width And loc_barra.X + pb_barra.Width >= loc_bola.X And loc_bola.Y + pb_bola.Height <= loc_barra.Y + pb_barra.Height / 2 Then
            Y = -Y
        End If
        'Bola bate no lado esquerdo da barra
        If loc_bola.Y + pb_bola.Height >= loc_barra.Y And loc_barra.X <= loc_bola.X And loc_barra.X + (pb_barra.Width / 8) >= loc_bola.X And loc_bola.Y < loc_barra.Y + pb_barra.Height Then
            X = -X
        End If
        'Bola bate no lado direito da barra
        If loc_bola.Y + pb_bola.Height >= loc_barra.Y And loc_barra.X + pb_barra.Width >= loc_bola.X And loc_barra.X + (pb_barra.Width - (pb_barra.Width / 8)) <= loc_bola.X And loc_bola.Y <= loc_barra.Y + pb_barra.Height Then
            X = -X
        End If
        loc_bola.Offset(X, Y)
        pb_bola.Location = loc_bola
    End Sub

    Private Sub bateBloco(bloco As PictureBox, bola As PictureBox)
        Dim bateu As Boolean
        If bloco.Visible = False Then
            Return
        End If
        bateu = False
        'Bola bate em cima da bloco
        If bola.Location.X + bola.Width >= bloco.Location.X And bola.Location.Y + bola.Height >= bloco.Location.Y And bola.Location.Y + bola.Height <= bloco.Location.Y + (bloco.Height / 2) And bola.Location.X <= bloco.Location.X + bloco.Width Then
            bateu = True
            Y = -Y
        End If
        'Bola bate em baixo da bloco
        If bola.Location.X + bola.Width >= bloco.Location.X And bola.Location.Y >= bloco.Location.Y + (bloco.Height / 2) And bola.Location.Y <= bloco.Location.Y + bloco.Height And bola.Location.X <= bloco.Location.X + bloco.Width Then
            bateu = True
            Y = -Y
        End If
        'Bola bate na parte esquerda do bloco
        If bola.Location.X + bola.Width >= bloco.Location.X And bola.Location.Y + bola.Height >= bloco.Location.Y And bola.Location.Y <= bloco.Location.Y + bloco.Height And bola.Location.X + bola.Width <= bloco.Location.X + (bloco.Width / 8) Then
            bateu = True
            X = -X
        End If
        'Bola bate na parte direita do bloco
        If bola.Location.X <= bloco.Location.X + bloco.Width And bola.Location.Y + bola.Height >= bloco.Location.Y And bola.Location.Y <= bloco.Location.Y + bloco.Height And bola.Location.X >= bloco.Location.X + (bloco.Width - (bloco.Width / 8)) Then
            bateu = True
            X = -X
        End If

        If bateu = True Then
            bloco.Visible = False
            quantosblocos = quantosblocos - 1
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        Button1.Enabled = False
        Timer1.Enabled = True
    End Sub
End Class
