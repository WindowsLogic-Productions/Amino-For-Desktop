Public Class UpdaterPrompt
#Region "Load Settings"
    Private Sub UpdaterPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Parent = PictureBox2
        Label1.Parent = PictureBox2

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Updater.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PostponeButton_Click(sender As Object, e As EventArgs) Handles PostponeButton.Click
        Me.Close()
    End Sub
#End Region
End Class