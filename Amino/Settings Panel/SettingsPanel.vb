Public Class SettingsPanel
    Private Sub AminoSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load update settings.
        If My.Settings.Updates = 0 Then
            EnableUpdates.Checked = True
        End If

        If My.Settings.Updates = 1 Then
            DisableUpdates.Checked = True
        End If

    End Sub

    Private Sub EnableUpdates_CheckedChanged(sender As Object, e As EventArgs) Handles EnableUpdates.CheckedChanged
        If EnableUpdates.Checked = True Then
            My.Settings.Updates = 0
        End If
    End Sub

    Private Sub DisableUpdates_CheckedChanged(sender As Object, e As EventArgs) Handles DisableUpdates.CheckedChanged
        If DisableUpdates.Checked = True Then
            My.Settings.Updates = 1
        End If
    End Sub

    Private Sub GeneralSettingsButton_Click(sender As Object, e As EventArgs) Handles GeneralSettingsButton.Click
        SettingsPanelGeneral.Show()
        Me.Close()
    End Sub
End Class