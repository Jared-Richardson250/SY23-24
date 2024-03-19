Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        ReelControl1.Spin()
        ReelControl2.Spin()
        ReelControl3.Spin()
        Label1.Text = ReelControl1.ItemValue
        Label2.Text = ReelControl2.ItemValue
        Label3.Text = ReelControl3.ItemValue
        Label4.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ReelControl1.ItemValue
        Label2.Text = ReelControl2.ItemValue
        Label3.Text = ReelControl3.ItemValue
        Timer1.Enabled = False
        If Label1.Text = Label2.Text And Label2.Text = Label3.Text Then
            Label4.Visible = True
        End If
    End Sub
End Class
