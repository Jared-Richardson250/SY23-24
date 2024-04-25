Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Dim D As Integer
        Dim M As Integer
        M = Cal1.SelectedDate.Value.Month
        D = Cal1.SelectedDate.Value.Day
        If M = 12 And D > 21 Then
            Label1.Content = "Capricorn"
        End If
        If M = 1 And D < 20 Then
            Label1.Content = "Capricorn"
        End If
        If M = 1 And D > 19 Then
            Label1.Content = "Aquarius"
        End If
        If M = 2 And D < 19 Then
            Label1.Content = "Aquarius"
        End If
        If M = 2 And D > 18 Then
            Label1.Content = "Pisces"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Pisces"
        End If
        If M = 3 And D > 20 Then
            Label1.Content = "Aries"
        End If
        If M = 4 And D < 20 Then
            Label1.Content = "Aries"
        End If
        If M = 4 And D < 19 Then
            Label1.Content = "Taurus"
        End If
        If M = 5 And D < 21 Then
            Label1.Content = "Taurus"
        End If
        'If M = 3 And D < 21 Then
        Label1.Content = "Gemini"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Gemini"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Cancer"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Cancer"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Leo"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Leo"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Virgo"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Virgo"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Libra"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Libra"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Scorpio"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Scorpio"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Sagittarius"
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Sagittarius"
        End If
    End Sub
End Class
