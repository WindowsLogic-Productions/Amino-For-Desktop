Public Class SettingsPanelUpdates
    Private Sub SettingsPanelUpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load update settings.
        If My.Settings.Updates = 0 Then
            EnableUpdates.Checked = True
            PictureBox3.Image = My.Resources.GoodGradient
        End If

        If My.Settings.Updates = 1 Then
            DisableUpdates.Checked = True
            PictureBox3.Image = My.Resources.BadGradient
        End If

    End Sub

    Private Sub EnableUpdates_CheckedChanged(sender As Object, e As EventArgs)
        If EnableUpdates.Checked = True Then
            PictureBox3.Image = My.Resources.GoodGradient
            My.Settings.Updates = 0
        End If
    End Sub

    Private Sub DisableUpdates_CheckedChanged(sender As Object, e As EventArgs)
        If DisableUpdates.Checked = True Then
            PictureBox3.Image = My.Resources.BadGradient
            My.Settings.Updates = 1
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Close()
    End Sub

    Private Sub ManualUpdateButton_Click(sender As Object, e As EventArgs) Handles ManualUpdateButton.Click
        Updater.Show()
        Me.Close()
    End Sub
End Class