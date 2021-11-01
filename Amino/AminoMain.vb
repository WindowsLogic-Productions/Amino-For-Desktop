Imports Gecko

Public Class AminoMain

    Public Sub New()

        InitializeComponent()
        Xpcom.Initialize("Firefox")


        Dim sUserAgent As String = "Mozilla/5.0 (Windows NT 4.0; Win64; x64; rv:63.0) Gecko/20100101 Firefox/80.0 (.NET CLR 3.5.30729)"
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
        AminoSettings.ShowDialog()
    End Sub

    Private Sub JoinButton_Click(sender As Object, e As EventArgs) Handles JoinButton.Click
        GeckoWebBrowser1.Navigate("https://aminoapps.com/c/INAV")
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

#End Region
End Class
