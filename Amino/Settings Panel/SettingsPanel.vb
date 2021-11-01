Public Class SettingsPanel
    Private Sub AminoSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

    End Sub

    Private Sub GeneralSettingsButton_Click(sender As Object, e As EventArgs) Handles GeneralSettingsButton.Click
        SettingsPanelGeneral.Show()
        Me.Close()
    End Sub

    Private Sub UpdatesSettingsButton_Click(sender As Object, e As EventArgs) Handles UpdatesSettingsButton.Click
        SettingsPanelUpdates.Show()
        Me.Close()
    End Sub

    Private Sub PersonaliseSettingsButton_Click(sender As Object, e As EventArgs) Handles PersonaliseSettingsButton.Click
        SettingsPanelPersonalise.Show()
        Me.Close()
    End Sub
End Class