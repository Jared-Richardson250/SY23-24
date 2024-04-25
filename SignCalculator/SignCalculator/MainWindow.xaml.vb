Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Dim D As Integer
        Dim M As Integer
        M = Cal1.SelectedDate.Value.Month
        D = Cal1.SelectedDate.Value.Day
        If M = 12 And D > 21 Then
            Label1.Content = "Capricorn"
            CapricornPB.Visibility = Visibility.Visible
        End If
        If M = 1 And D < 20 Then
            Label1.Content = "Capricorn"
            CapricornPB.Visibility = Visibility.Visible
        End If
        If M = 1 And D > 19 Then
            Label1.Content = "Aquarius"
            AquariusPB.Visibility = Visibility.Visible
        End If
        If M = 2 And D < 19 Then
            Label1.Content = "Aquarius"
            AquariusPB.Visibility = Visibility.Visible
        End If
        If M = 2 And D > 18 Then
            Label1.Content = "Pisces"
            PiscesPB.Visibility = Visibility.Visible
        End If
        If M = 3 And D < 21 Then
            Label1.Content = "Pisces"
            PiscesPB.Visibility = Visibility.Visible
        End If
        If M = 3 And D > 20 Then
            Label1.Content = "Aries"
            AriesPB.Visibility = Visibility.Visible
        End If
        If M = 4 And D < 20 Then
            Label1.Content = "Aries"
            AriesPB.Visibility = Visibility.Visible
        End If
        If M = 4 And D < 19 Then
            Label1.Content = "Taurus"
            TaurusPB.Visibility = Visibility.Visible
        End If
        If M = 5 And D < 21 Then
            Label1.Content = "Taurus"
            TaurusPB.Visibility = Visibility.Visible
        End If
        If M = 5 And D > 20 Then
            Label1.Content = "Gemini"
            GeminiPB.Visibility = Visibility.Visible
        End If
        If M = 6 And D < 21 Then
            Label1.Content = "Gemini"
            GeminiPB.Visibility = Visibility.Visible
        End If
        If M = 6 And D > 20 Then
            Label1.Content = "Cancer"
            CancerPB.Visibility = Visibility.Visible
        End If
        If M = 7 And D < 23 Then
            Label1.Content = "Cancer"
            CancerPB.Visibility = Visibility.Visible
        End If
        If M = 7 And D > 22 Then
            Label1.Content = "Leo"
            LeoPB.Visibility = Visibility.Visible
        End If
        If M = 8 And D < 23 Then
            Label1.Content = "Leo"
            LeoPB.Visibility = Visibility.Visible
        End If
        If M = 8 And D > 22 Then
            Label1.Content = "Virgo"
            VirgoPB.Visibility = Visibility.Visible
        End If
        If M = 9 And D < 23 Then
            Label1.Content = "Virgo"
            VirgoPB.Visibility = Visibility.Visible
        End If
        If M = 9 And D > 22 Then
            Label1.Content = "Libra"
            LibraPB.Visibility = Visibility.Visible
        End If
        If M = 10 And D < 23 Then
            Label1.Content = "Libra"
            LibraPB.Visibility = Visibility.Visible
        End If
        If M = 10 And D > 22 Then
            Label1.Content = "Scorpio"
            ScorpioPB.Visibility = Visibility.Visible
        End If
        If M = 11 And D < 22 Then
            Label1.Content = "Scorpio"
            ScorpioPB.Visibility = Visibility.Visible
        End If
        If M = 11 And D > 21 Then
            Label1.Content = "Sagittarius"
            SagittariusPB.Visibility = Visibility.Visible
        End If
        If M = 12 And D < 22 Then
            Label1.Content = "Sagittarius"
            SagittariusPB.Visibility = Visibility.Visible
        End If
    End Sub
End Class
