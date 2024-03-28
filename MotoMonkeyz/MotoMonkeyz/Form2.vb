Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim F1 As New Form1
        F1.ShowDialog()
        Me.Show()
    End Sub
    Private Sub GroupBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseClick
        Me.Hide()
        Dim F3 As New handlebars


        F3.Label3.Text = Label1.Text
        F3.PictureBox1.Image = PictureBox1.Image
        F3.Label2.Text = Label2.Text


        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseClick
        Me.Hide()
        Dim F3 As New handlebars


        F3.Label3.Text = Label4.Text
        F3.PictureBox1.Image = PictureBox2.Image
        F3.Label2.Text = Label3.Text


        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GroupBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox3.MouseClick
        Me.Hide()
        Dim F3 As New handlebars


        F3.Label3.Text = Label6.Text
        F3.PictureBox1.Image = PictureBox3.Image
        F3.Label2.Text = Label5.Text


        F3.ShowDialog()
        Me.Show()
    End Sub
End Class