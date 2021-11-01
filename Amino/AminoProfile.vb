Public Class AminoProfile
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox1.Text = Nothing Then
            errordiag.Show()
            errordiag.Label1.Text = "No Amino profile ID has been entered."
        Else
            My.Settings.ProfileName = TextBox1.Text
            My.Settings.OCA = 1
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub AminoProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

    End Sub
End Class