Public Class handlebars
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles HandlebarsBack.Click
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
            ModelComboBox.Items.Add("KLX110R")
            ModelComboBox.Items.Add("KLX140R")
            ModelComboBox.Items.Add("KLX230R")
            ModelComboBox.Items.Add("KLX300R")
            ModelComboBox.Items.Add("KX250")
            ModelComboBox.Items.Add("KX250X")
            ModelComboBox.Items.Add("KX450")
            ModelComboBox.Items.Add("KX450X")
            ModelComboBox.Items.Add("KX450SR")
        End If

        If MakeComboBox.SelectedIndex = 2 Then
            ModelComboBox.Items.Clear()
            ModelComboBox.Items.Add("PW50")
            ModelComboBox.Items.Add("TT-R50E")
            ModelComboBox.Items.Add("TT-R110E")
            ModelComboBox.Items.Add("TT-R125LE")
            ModelComboBox.Items.Add("TT-R230")
            ModelComboBox.Items.Add("WR250F")
            ModelComboBox.Items.Add("WR450F")
            ModelComboBox.Items.Add("YZ250FX")
            ModelComboBox.Items.Add("YZ450FX")
            ModelComboBox.Items.Add("TT-R50E")
            ModelComboBox.Items.Add("TT-R50E")
            ModelComboBox.Items.Add("YZ250F")
            ModelComboBox.Items.Add("YZ450F")
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


        Cart.YearTB.Text = YearComboBox.Text
        Cart.ModelTB.Text = ModelComboBox.Text
        Cart.MakeTB.Text = MakeComboBox.Text
        Cart.TextBox1.Text = Label3.Text
        Cart.PictureBox1.Image = PictureBox1.Image
        Cart.TextBox2.Text = ComboBox4.Text
        Cart.Label2.Text = Label2.Text


        Cart.ShowDialog()
        Me.Show()


    End Sub

    Private Sub EngineBack_Click(sender As Object, e As EventArgs) Handles EngineBack.Click
        Me.Hide()
        Dim Engines As New engines
        Engines.ShowDialog()
        Me.Show()
    End Sub

    Private Sub WheelsBack_Click(sender As Object, e As EventArgs) Handles WheelsBack.Click
        Me.Hide()
        Dim Wheels As New Wheels
        Wheels.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GraphicsBack_Click(sender As Object, e As EventArgs) Handles GraphicsBack.Click
        Me.Hide()
        Dim Graphics As New Graphics
        Graphics.ShowDialog()
        Me.Show()
    End Sub

    Private Sub GripsBack_Click(sender As Object, e As EventArgs) Handles GripsBack.Click
        Me.Hide()
        Dim Grips As New Grips
        Grips.ShowDialog()
        Me.Show()
    End Sub

    Private Sub LeversBack_Click(sender As Object, e As EventArgs) Handles LeversBack.Click
        Me.Hide()
        Dim Levers As New Levers
        Levers.ShowDialog()
        Me.Show()
    End Sub

    Private Sub handlebars_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class