Public Class AminoAbout

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Me.Close()

    End Sub

    Private Sub TweeterAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load version number and licence.
        Variables.ParseVariables(VerInfo)
        Variables.ParseVariables(Copyright)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        AminoHelp.Show()
        AminoHelp.Text = "Software Agreement"
        AminoHelp.GeckoWebBrowser1.Navigate("https://windowslogic.co.uk/appagreement.php")

    End Sub
End Class