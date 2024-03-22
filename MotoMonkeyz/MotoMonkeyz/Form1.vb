Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = False
        Button2.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Visible = True
        Button2.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub
End Class
