Public Class About

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        OpenFileDialog1.Filter = "PDF Files |*.pdf"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()

    End Sub
End Class