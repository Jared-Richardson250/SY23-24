Public Class handlebars
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()





        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MakeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MakeComboBox.SelectedIndexChanged
        If MakeComboBox.SelectedIndex = 0 Then
            ModelComboBox.Items.Clear()
            ModelComboBox.Items.Add("CR250")
            ModelComboBox.Items.Add("CRF250R")
        End If

        If MakeComboBox.SelectedIndex = 1 Then
            ModelComboBox.Items.Clear()
            ModelComboBox.Items.Add("KX250")
            ModelComboBox.Items.Add("KX450")
        End If

        If MakeComboBox.SelectedIndex = 2 Then
            ModelComboBox.Items.Clear()
            ModelComboBox.Items.Add("YZ125")
            ModelComboBox.Items.Add("YZ250F")
        End If

        If MakeComboBox.SelectedIndex = 3 Then
            ModelComboBox.Items.Clear()
            ModelComboBox.Items.Add("KTM")
            ModelComboBox.Items.Add("KTM")
        End If

        If MakeComboBox.SelectedIndex = 4 Then
            ModelComboBox.Items.Clear()
            ModelComboBox.Items.Add("Husq")
            ModelComboBox.Items.Add("Husq")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim Cart As New Cart


        Cart.TextBox1.Text = Label3.Text
        Cart.PictureBox1.Image = PictureBox1.Image
        Cart.TextBox2.Text = ComboBox4.Text
        Cart.Label2.Text = Label2.Text


        Cart.ShowDialog()
        Me.Show()


    End Sub

    Private Sub handlebars_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class