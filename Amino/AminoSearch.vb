Public Class AminoSearch
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        AminoMain.GeckoWebBrowser1.Navigate("http://www.google.com/search?q=" + "site:aminoapps.com " + SearchBox.Text)
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class