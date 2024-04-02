Public Class Levers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim F1 As New Form1
        F1.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GroupBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseClick
        Me.Hide()
        Dim F3 As New handlebars

        F3.LeversBack.Visible = True
        F3.Label3.Text = Label1.Text
        F3.PictureBox1.Image = PictureBox1.Image
        F3.Label2.Text = Label2.Text


        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GroupBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseClick
        Me.Hide()
        Dim F3 As New handlebars

        F3.LeversBack.Visible = True
        F3.Label3.Text = Label1.Text
        F3.PictureBox1.Image = PictureBox1.Image
        F3.Label2.Text = Label2.Text


        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GroupBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox3.MouseClick
        Me.Hide()
        Dim F3 As New handlebars

        F3.LeversBack.Visible = True
        F3.Label3.Text = Label1.Text
        F3.PictureBox1.Image = PictureBox1.Image
        F3.Label2.Text = Label2.Text


        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GroupBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox4.MouseClick
        Me.Hide()
        Dim F3 As New handlebars

        F3.LeversBack.Visible = True
        F3.Label3.Text = Label1.Text
        F3.PictureBox1.Image = PictureBox1.Image
        F3.Label2.Text = Label2.Text


        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GroupBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox5.MouseClick
        Me.Hide()
        Dim F3 As New handlebars

        F3.LeversBack.Visible = True
        F3.Label3.Text = Label1.Text
        F3.PictureBox1.Image = PictureBox1.Image
        F3.Label2.Text = Label2.Text


        F3.ShowDialog()
        Me.Show()
    End Sub
End Class