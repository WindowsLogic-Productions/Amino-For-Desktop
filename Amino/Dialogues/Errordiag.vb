Public Class errordiag
#Region "Load Settings"
    Private Sub errordiag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'If My.Settings.CCE = 1 Then
        'Me.BackColor = My.Settings.CustomColour
        'End If

        'Sound
        'If My.Settings.Sounds = "ON" Then
        'My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
        'End If

        'If My.Settings.Sounds = "OFF" Then
        'End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Dispose()
    End Sub
#End Region
End Class