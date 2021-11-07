Public Class AminoSearch
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If SearchBox.Text = Nothing Then
            errordiag.Show()
            errordiag.Label1.Text = "No search terms have been entered."
        Else
            If Me.Text = "Topic Search" Then
                AminoMain.GeckoWebBrowser1.Navigate("http://www.google.com/search?q=" + "site:aminoapps.com " + SearchBox.Text)
                Me.Close()
            ElseIf Me.Text = "User Search" Then
                AminoMain.GeckoWebBrowser1.Navigate("http://www.google.com/search?q=" + "site:aminoapps.com user:" + SearchBox.Text)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub AminoSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

    End Sub
End Class