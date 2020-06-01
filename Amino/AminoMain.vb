Imports Gecko

Public Class AminoMain

    Public Sub New()

        InitializeComponent()
        Xpcom.Initialize("Firefox")


        Dim sUserAgent As String = "Mozilla/5.0 (Windows NT 4.0; Win64; x64; rv:63.0) Gecko/20100101 Firefox/76.0 (.NET CLR 3.5.30729)"
        Gecko.GeckoPreferences.User("general.useragent.override") = sUserAgent

    End Sub

#Region "Load Settings"
    Private Sub AminoMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load Amino website.
        GeckoWebBrowser1.Navigate("https://aminoapps.com/explore/")

        'Load update settings.
        Variables.Update_Settings()
    End Sub
#End Region
#Region "System Tray"
    Private Sub AminoMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If My.Settings.SysTrayMinimise = 0 Then
            GC.Collect()
        End If

        If My.Settings.SysTrayMinimise = 1 Then
            If WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                SysTrayIcon.Visible = True
                SysTrayIcon.ShowBalloonTip(1, "Amino For Desktop - Notification", "Amino For Desktop is now running in the background.", ToolTipIcon.Info)
                GC.Collect()
            End If
        End If
    End Sub

    Private Sub SysTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SysTrayIcon.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Buttons"

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        GeckoWebBrowser1.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        GeckoWebBrowser1.GoForward()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        GeckoWebBrowser1.Reload()
    End Sub

    Private Sub ExploreButton_Click(sender As Object, e As EventArgs) Handles ExploreButton.Click
        GeckoWebBrowser1.Navigate("https://aminoapps.com/explore/")
    End Sub

    Private Sub SettingsPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsPanelToolStripMenuItem.Click
        SettingsPanel.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        AminoHelp.Show()
        AminoHelp.GeckoWebBrowser1.Navigate("https://docs.windowslogic.co.uk/amino-index.php")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AminoAbout.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub WhatsNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsNewToolStripMenuItem.Click
        AminoWhatsNew.ShowDialog()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Updater.ShowDialog()
    End Sub

    Private Sub JumpButton_Click(sender As Object, e As EventArgs) Handles JumpButton.Click
        AminoJump.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        AminoSearch.ShowDialog()
    End Sub

    Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.ButtonClick
        If My.Settings.OCA = 0 Then
            AminoProfile.ShowDialog()
        End If
        If My.Settings.OCA = 1 Then
            GeckoWebBrowser1.Navigate("https://aminoapps.com/u/" + My.Settings.ProfileName)
        End If
    End Sub
#End Region
#Region "Functions"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = GeckoWebBrowser1.DocumentTitle & " - Amino For Desktop"
        'Me.SysTrayIcon.Text = GeckoWebBrowser1.DocumentTitle & " - Amino For Desktop"
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.F11) Then
            If Me.FormBorderStyle = FormBorderStyle.None Then
                My.Settings.Fullscreen = 0
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = FormBorderStyle.Sizable
            ElseIf Me.WindowState = FormWindowState.Normal Then
                My.Settings.Fullscreen = 1
                Me.FormBorderStyle = FormBorderStyle.None
                Me.WindowState = FormWindowState.Maximized
            End If
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub SettingsPanelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsPanelToolStripMenuItem1.Click
        SettingsPanel.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub FollowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FollowersToolStripMenuItem.Click
        GeckoWebBrowser1.Navigate("https://aminoapps.com/u/" + My.Settings.ProfileName + "/followers")
    End Sub
#End Region
End Class
