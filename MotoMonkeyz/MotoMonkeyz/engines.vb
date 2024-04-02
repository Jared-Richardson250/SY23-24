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
        F3.MakeComboBox.SelectedIndex = 0
        F3.EngineBack.Visible = True
        F3.MakeComboBox.Visible = False
        F3.Label1.Visible = False
        F3.ComboBox4.Visible = False
        F3.PictureBox1.Image = PictureBox1.Image
        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        Me.Hide()
        Dim F3 As New handlebars
        F3.MakeComboBox.SelectedIndex = 1
        F3.EngineBack.Visible = True
        F3.MakeComboBox.Visible = False
        F3.Label1.Visible = False
        F3.ComboBox4.Visible = False
        F3.PictureBox1.Image = PictureBox2.Image
        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick
        Me.Hide()
        Dim F3 As New handlebars
        F3.MakeComboBox.SelectedIndex = 2
        F3.EngineBack.Visible = True
        F3.MakeComboBox.Visible = False
        F3.Label1.Visible = False
        F3.ComboBox4.Visible = False
        F3.PictureBox1.Image = PictureBox3.Image
        F3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        Me.Hide()
        Dim F3 As New handlebars
        F3.MakeComboBox.SelectedIndex = 4
        F3.EngineBack.Visible = True
        F3.ComboBox4.Visible = False
        F3.MakeComboBox.Visible = False
        F3.Label1.Visible = False
        F3.PictureBox1.Image = PictureBox4.Image
        F3.ShowDialog()
        Me.Show()
    End Sub
End Class