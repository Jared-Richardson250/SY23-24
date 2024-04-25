Class MainWindow
    Private Sub InputTB_GotFocus(sender As Object, e As RoutedEventArgs) Handles InputTB.GotFocus
        InputTB.Text = Nothing
    End Sub
    Private Sub ClearB_Click(sender As Object, e As RoutedEventArgs) Handles ClearB.Click
        InputTB.Text = "Input Amount"
        OutputTB.Text = "Output Amount"
        OutputComboBox.Text = "Output Currency"
    End Sub

    Private Sub InputTB_TextChanged(sender As Object, e As TextChangedEventArgs) Handles InputTB.TextChanged
        If Not OutputComboBox Is Nothing Then
            If OutputComboBox.Text = "Euro" Then
                Dim x As Integer
                Integer.TryParse(InputTB.Text, x)
                OutputTB.Text = 0.935148 * x
            End If

            If OutputComboBox.Text = "Canadian Dollar" Then
                Dim x As Integer
                Integer.TryParse(InputTB.Text, x)
                OutputTB.Text = 1.370428 * x
            End If

            If OutputComboBox.Text = "AUD" Then
                Dim x As Integer
                Integer.TryParse(InputTB.Text, x)
                OutputTB.Text = 1.538521 * x
            End If

            If OutputComboBox.Text = "Yen" Then
                Dim x As Integer
                Integer.TryParse(InputTB.Text, x)
                OutputTB.Text = 154.91185207 * x
            End If

            If OutputComboBox.Text = "Peso" Then
                Dim x As Integer
                Integer.TryParse(InputTB.Text, x)
                OutputTB.Text = 17.054999 * x
            End If

            If OutputComboBox.Text = "Rupee" Then
                Dim x As Integer
                Integer.TryParse(InputTB.Text, x)
                OutputTB.Text = 83.348752 * x
            End If
        End If
    End Sub

    Private Sub OutputComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles OutputComboBox.SelectionChanged
        InputTB.Text = "Input Amount"
        OutputTB.Text = "Output Amount"
    End Sub
End Class
