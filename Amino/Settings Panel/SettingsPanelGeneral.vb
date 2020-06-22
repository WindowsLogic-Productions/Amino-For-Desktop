Public Class SettingsPanelGeneral
#Region "Load Settings"
    Private Sub SettingsPanelGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GPSetLabel.Visible = False

        'Load System Tray Minimise settings.
        If My.Settings.SysTrayMinimise = 0 Then
            SysTrayMinimiseBox.Checked = False
        Else
            SysTrayMinimiseBox.Checked = True
        End If

        'Load Full Screen settings.
        If My.Settings.Fullscreen = 0 Then
            FullScreenBox.Checked = False
        Else
            FullScreenBox.Checked = True
        End If

        'Load one-click global profile access.
        If My.Settings.OCA = 0 Then
            GPText.Text = "No Global Profile Set"
        Else
            GPText.Text = My.Settings.ProfileName
            GPSetButton.Enabled = False
        End If

        'Load follower/following menu settings.
        If My.Settings.Follower = 0 Then
            FollowCheckBox.Checked = False
        Else
            FollowCheckBox.Checked = True
        End If

        'Load start-up settings.
        If My.Settings.Startup = 0 Then
            NothingButton.Checked = True
        End If

        If My.Settings.Startup = 1 Then
            SystemTrayButton.Checked = True
        End If

        If My.Settings.Startup = 2 Then
            SettingsPanelButton.Checked = True
        End If
    End Sub
#End Region
#Region "Amino"
    Private Sub SysTrayMinimiseBox_CheckedChanged(sender As Object, e As EventArgs) Handles SysTrayMinimiseBox.CheckedChanged
        If SysTrayMinimiseBox.Checked = False Then
            My.Settings.SysTrayMinimise = 0
        End If

        If SysTrayMinimiseBox.Checked = True Then
            My.Settings.SysTrayMinimise = 1
        End If
    End Sub

    Private Sub FullScreenBox_CheckedChanged(sender As Object, e As EventArgs) Handles FullScreenBox.CheckedChanged
        If FullScreenBox.Checked = False Then
            My.Settings.Fullscreen = 0
            AminoMain.WindowState = FormWindowState.Normal
            AminoMain.FormBorderStyle = FormBorderStyle.Sizable
        End If

        If FullScreenBox.Checked = True Then
            My.Settings.Fullscreen = 1
            AminoMain.FormBorderStyle = FormBorderStyle.None
            AminoMain.WindowState = FormWindowState.Maximized
        End If
    End Sub


#End Region
#Region "Global Profile"
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles GPText.TextChanged
        GPSetButton.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GPSetButton.Click
        My.Settings.ProfileName = GPText.Text()
        My.Settings.OCA = 1
        My.Settings.Save()
        GPSetButton.Enabled = False
        GPSetLabel.Visible = True
    End Sub


#End Region
#Region "Other"
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Close()
    End Sub

    Private Sub FollowCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FollowCheckBox.CheckedChanged
        If FollowCheckBox.Checked = False Then
            My.Settings.Follower = 0
            AminoMain.FollowersToolStripMenuItem.Visible = False
            AminoMain.FollowingToolStripMenuItem.Visible = False
            My.Settings.Save()
        End If

        If FollowCheckBox.Checked = True Then
            My.Settings.Follower = 1
            AminoMain.FollowersToolStripMenuItem.Visible = True
            AminoMain.FollowingToolStripMenuItem.Visible = True
            My.Settings.Save()
        End If


    End Sub

#End Region
End Class