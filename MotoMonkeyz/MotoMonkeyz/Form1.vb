﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub
End Class
