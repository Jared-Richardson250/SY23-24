Class MainWindow
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        Dim EL As New Ellipse
        EL.Width = WidthSlider.Value
        EL.Height = HeightSlider.Value
        EL.Fill = ColorRectangle1.Fill

        Dim P As Point = Mouse.GetPosition(DrawingCanvas)
        Canvas.SetLeft(EL, P.X)
        Canvas.SetTop(EL, P.Y)
        DrawingCanvas.Children.Add(EL)
    End Sub

    Private Sub ColorRectangle2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ColorRectangle2.MouseDown, ColorRectangle3.MouseDown, ColorRectangle4.MouseDown, ColorRectangle5.MouseDown, ColorRectangle6.MouseDown, ColorRectangle7.MouseDown, ColorRectangle8.MouseDown, ColorRectangle1_Copy.MouseDown
        ColorRectangle1.Fill = sender.fill
    End Sub
End Class
