Public Class AminoJump
    Private Sub AminoJump_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox1.Text = Nothing Then
            errordiag.Show()
            errordiag.Label1.Text = "No Amino ID has been entered."
        Else
            AminoMain.GeckoWebBrowser1.Navigate("https://aminoapps.com/c/" & TextBox1.Text)
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class