Public Class Mover
    Public Property Speed As Integer = 10
    Public Property Interval As Integer = 500
    Public Property Sprite As PictureBox
    Dim XDir As Integer = 1
    Dim YDir As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Sprite Is Nothing Then
            Sprite.Left += YDir * Speed
            Sprite.Top = YDir * Speed
            If Sprite.Left < Me.Left + Me.Width And XDir = 1 Then
                XDir = 0
                YDir = 1
            End If
            If Sprite.Left < Me.Left And XDir = -1 Then
                XDir = 0
                YDir = -1
            End If
            If Sprite.Top < Me.Top + Me.Height And YDir = 1 Then
                YDir = 0
                XDir = -1
            End If
            If Sprite.Top < Me.Top And YDir = -1 Then
                YDir = 0
                XDir = 1
            End If
        End If
    End Sub

    Private Sub Mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = Interval
        If Not Sprite Is Nothing Then
            Sprite.Left = Me.Left
            Sprite.Top = Me.Top
        End If
    End Sub
End Class
