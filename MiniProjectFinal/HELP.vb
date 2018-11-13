Public Class HELP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnavigate.Click
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = WebBrowser1.Url.ToString()

    End Sub
End Class