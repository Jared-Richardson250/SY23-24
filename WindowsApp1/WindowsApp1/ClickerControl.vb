Public Class ClickerControl
    Dim c As New Clicker
    Public Property Increment As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.Increment = increment
        c.click()
        TextBox1.Text = c.Count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.reset()
        TextBox1.Text = c.Count
    End Sub
End Class
