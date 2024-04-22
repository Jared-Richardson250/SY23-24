Imports System.Reflection.Emit

Class MainWindow
    Private Sub CardNumberTB_TextChanged(sender As Object, e As TextChangedEventArgs) Handles CardNumberTB.TextChanged, ExpDateTB.TextChanged, CVCTB.TextChanged, CardholderTB.TextChanged, EmailTB.TextChanged
        If Not PayButton Is Nothing Then
            If CardNumberTB.Text Like "#### #### #### ####" And CardholderTB.Text Like "?*" And CVCTB.Text Like "###" And ExpDateTB.Text Like "##/##" And EmailTB.Text Like "*@*.com" Then
                PayButton.IsEnabled = True
            Else
                PayButton.IsEnabled = False
            End If
        End If
    End Sub


    Private Sub CardNumberTB_GotFocus(sender As Object, e As RoutedEventArgs) Handles CardNumberTB.GotFocus
        CardNumberTB.Text = Nothing
    End Sub
    Private Sub CardholderTB_GotFocus(sender As Object, e As RoutedEventArgs) Handles CardholderTB.GotFocus
        CardholderTB.Text = Nothing
    End Sub
    Private Sub CVCTB_GotFocus(sender As Object, e As RoutedEventArgs) Handles CVCTB.GotFocus
        CVCTB.Text = Nothing
    End Sub
    Private Sub ExpDateTB_GotFocus(sender As Object, e As RoutedEventArgs) Handles ExpDateTB.GotFocus
        ExpDateTB.Text = Nothing
    End Sub
    Private Sub PayButton_Click(sender As Object, e As RoutedEventArgs) Handles PayButton.Click
        CardNumberTB.Text = "Card Number"
        ExpDateTB.Text = "Expiration Date"
        CVCTB.Text = "CVC"
        EmailTB.Text = "Email"
        CardNumberTB.Text = "Cardholder's Name"
    End Sub

    Private Sub EmailTB_GotFocus(sender As Object, e As RoutedEventArgs) Handles EmailTB.GotFocus
        EmailTB.Text = Nothing
    End Sub
End Class
