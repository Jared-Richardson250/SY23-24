Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class engines
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim F1 As New Form1
        F1.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Me.Hide()
        Dim F3 As New handlebars
        F3.ComboBox4.Visible = False
        F3.PictureBox1.Image = PictureBox1.Image
        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class