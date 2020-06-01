Public Class AminoAbout

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Me.Close()

    End Sub

    Private Sub AminoAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sound

        'Load personalisation settings.

        'Load version number and license.
        Variables.ParseVariables(VerInfo)
        Variables.ParseVariables(Copyright)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        AminoHelp.Show()
        AminoHelp.Text = "Software Agreement"
        AminoHelp.GeckoWebBrowser1.Navigate("https://windowslogic.co.uk/appagreement.php")

    End Sub

    Private Sub MoreButton_Click(sender As Object, e As EventArgs) Handles MoreButton.Click
        Dedicate.ShowDialog()
    End Sub
End Class