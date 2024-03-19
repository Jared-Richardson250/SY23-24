Imports System.Reflection.Emit

Public Class Form2DPlatformer
    Dim MoveSpeed As Integer = 15
    Dim IsJumping As Boolean
    Private Sub Form2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Left
                TmrLeft.Start()
            Case Keys.Up
                TmrUp.Start()
                IsJumping = True
        End Select
    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PicPlayer.Left += MoveSpeed
    End Sub

    Private Sub Form2DPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Left
                TmrLeft.Stop()
            Case Keys.Up
                TmrUp.Stop()
                IsJumping = False
        End Select
    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        PicPlayer.Left -= MoveSpeed
    End Sub

    Private Sub TmrUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        PicPlayer.Top -= MoveSpeed
    End Sub

    Private Sub Form2DPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrGameLogic.Start()
    End Sub

    Private Sub TmrGameLogic_Tick(sender As Object, e As EventArgs) Handles TmrGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            TmrGravity.Stop()
        Else
            If IsJumping = False Then
                TmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bounds" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGravity.Stop()
                    End If
                End If
            End If
            If b.Tag = "Restart" Then
                If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    PicPlayer.Location = New Point(1, 340)
                End If
            End If
            If b.Tag = "Collectable" Then
                If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub TmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGravity.Tick
        PicPlayer.Top += MoveSpeed
    End Sub
End Class
