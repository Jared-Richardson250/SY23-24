Class MainWindow
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        If ShapeLabel.Content = "Ellipse" Then
            Dim EL As New Ellipse
            EL.Width = WidthSlider.Value
            EL.Height = HeightSlider.Value
            EL.Fill = ColorRectangle1.Fill

            Dim P As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(EL, P.X)
            Canvas.SetTop(EL, P.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(EL)
            End If
        End If

        If ShapeLabel.Content = "Rectangle" Then
            Dim EL As New Rectangle
            EL.Width = WidthSlider.Value
            EL.Height = HeightSlider.Value
            EL.Fill = ColorRectangle1.Fill

            Dim P As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(EL, P.X)
            Canvas.SetTop(EL, P.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(EL)
            End If
        End If
    End Sub

    Private Sub ColorRectangle2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ColorRectangle2.MouseDown, ColorRectangle3.MouseDown, ColorRectangle4.MouseDown, ColorRectangle5.MouseDown, ColorRectangle6.MouseDown, ColorRectangle7.MouseDown, ColorRectangle8.MouseDown, ColorRectangle1_Copy.MouseDown
        ColorRectangle1.Fill = sender.fill
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveRange(1, DrawingCanvas.Children.Count)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveAt(DrawingCanvas.Children.Count - 1)
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        ShapeLabel.Content = sender.content
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        ShapeLabel.Content = sender.content
    End Sub
End Class
