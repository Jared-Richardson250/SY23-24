Public Class ProductControl
    Public Property ProductName As String
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductImage As Image
    Public Property PropertyCount As Integer

    Public Event DispenseProduct(i As Image)
    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductImage
        Label1.Text = ProductID
        Label2.Text = ProductPrice.ToString("C2")
    End Sub
    Public Sub buy()
        If PropertyCount > 0 Then
            PropertyCount -= 1
            RaiseEvent DispenseProduct(ProductImage)
        End If
        If PropertyCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
