Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim F1 As New Form1
        F1.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseClick
        Me.Hide()
        Dim f3 As New handelbars1
        f3.ShowDialog()
        Me.Show()
    End Sub
End Class