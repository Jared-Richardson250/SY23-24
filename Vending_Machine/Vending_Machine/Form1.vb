Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim WithEvents cs As New Coin_Slot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.Insert_Nickels()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.Insert_Dimes()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.Insert_Quarters()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.Insert_Dollars()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.Coin_Return()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.CoinReturnEvent
        If d > 0 Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If
        If q > 0 Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If
        If di > 0 Then
            PictureBox7.Visible = True
        Else
            PictureBox7.Visible = False
        End If
        If n > 0 Then
            PictureBox8.Visible = True
        Else
            PictureBox8.Visible = False
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Select Case IDTextBox.Text
            Case Product_Control1.ProductID
                cs.Buy(Product_Control1)
                Product_PictureBox.Visible = True

            Case Product_Control2.ProductID
                cs.Buy(Product_Control2)
                Product_PictureBox.Visible = True

            Case Product_Control3.ProductID
                cs.Buy(Product_Control3)
                Product_PictureBox.Visible = True

            Case Product_Control4.ProductID
                cs.Buy(Product_Control4)
                Product_PictureBox.Visible = True

            Case Product_Control5.ProductID
                cs.Buy(Product_Control5)
                Product_PictureBox.Visible = True

            Case Product_Control6.ProductID
                cs.Buy(Product_Control6)
                Product_PictureBox.Visible = True

            Case Product_Control7.ProductID
                cs.Buy(Product_Control7)
                Product_PictureBox.Visible = True

            Case Product_Control8.ProductID
                cs.Buy(Product_Control8)
                Product_PictureBox.Visible = True

            Case Product_Control9.ProductID
                cs.Buy(Product_Control9)
                Product_PictureBox.Visible = True

            Case Product_Control10.ProductID
                cs.Buy(Product_Control10)
                Product_PictureBox.Visible = True
        End Select
        TextBox1.Text = cs.Total.ToString("C2")
    End Sub
    Private Sub Product_Control1_DispenseProduct(i As Image) Handles Product_Control1.DispenseProduct, Product_Control2.DispenseProduct, Product_Control3.DispenseProduct, Product_Control4.DispenseProduct, Product_Control5.DispenseProduct, Product_Control6.DispenseProduct, Product_Control7.DispenseProduct, Product_Control8.DispenseProduct, Product_Control9.DispenseProduct, Product_Control10.DispenseProduct
        Product_PictureBox.Image = i
    End Sub
End Class
