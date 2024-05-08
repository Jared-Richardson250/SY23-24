Imports Microsoft.Win32
Imports System.IO

Class MainWindow
    Dim Grad1 As Color
    Dim Grad2 As Color
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        If ShapeLabel.Content = "Ellipse" Then
            Dim EL As New Ellipse
            EL.Width = WidthSlider.Value
            EL.Height = HeightSlider.Value
            EL.Fill = ColorMix.Fill

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
            EL.Fill = ColorMix.Fill

            Dim P As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(EL, P.X)
            Canvas.SetTop(EL, P.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(EL)
            End If
        End If
        If ShapeLabel.Content = "Polygon" Then
            Dim r As New Polygon
            r.Fill = ColorMix.Fill
            r.Points.Add(New Point(5 * WidthSlider.Value, 5 * WidthSlider.Value))
            r.Points.Add(New Point(-5 * WidthSlider.Value, -5 * WidthSlider.Value))
            r.Points.Add(New Point(-5 * WidthSlider.Value, 5 * WidthSlider.Value))
            r.Points.Add(New Point(5 * WidthSlider.Value, -5 * WidthSlider.Value))
            Dim P As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(r, P.X)
            Canvas.SetTop(r, P.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(r)
            End If
        End If
    End Sub

    Private Sub ColorRectangle2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ColorRectangle2.MouseDown, ColorRectangle3.MouseDown, ColorRectangle4.MouseDown, ColorRectangle5.MouseDown, ColorRectangle6.MouseDown, ColorRectangle7.MouseDown, ColorRectangle8.MouseDown, ColorRectangle1_Copy.MouseDown
        ColorMix.Fill = sender.fill
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
    Private Sub SaveButton_Click(sender As Object, e As RoutedEventArgs) Handles SaveButton.Click
        ExportToPng(DrawingCanvas)
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(DrawingCanvas, 200)

        Canvas.SetTop(DrawingCanvas, 10)

    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        ShapeLabel.Content = sender.content
    End Sub

    Private Sub Color1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color1.MouseDown
        Grad1 = Color.FromRgb(RSlider.Value, GSlider.Value, BSlider.Value)
        sender.fill = New SolidColorBrush(Grad1)
    End Sub
    Private Sub Color2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color2.MouseDown
        Grad2 = Color.FromRgb(RSlider.Value, GSlider.Value, BSlider.Value)
        sender.fill = New SolidColorBrush(Grad2)
    End Sub

    Private Sub AngleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles AngleSlider.ValueChanged
        ColorMix.Fill = New LinearGradientBrush(Grad1, Grad2, AngleSlider.Value)
    End Sub
End Class
