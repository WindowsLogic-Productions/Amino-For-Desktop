Imports Gecko

Public Class AminoMain

    Public Sub New()

        InitializeComponent()
        Xpcom.Initialize("Firefox")

        Dim sUserAgent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0 (.NET CLR 3.5.30729)"
        Gecko.GeckoPreferences.User("general.useragent.override") = sUserAgent

    End Sub

#Region "Load Settings"
    Private Sub AminoMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GeckoWebBrowser1.Navigate("https://aminoapps.com/explore/")
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

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        AminoSettings.ShowDialog()
    End Sub

    Private Sub JoinButton_Click(sender As Object, e As EventArgs) Handles JoinButton.Click
        GeckoWebBrowser1.Navigate("https://aminoapps.com/c/INAV")
    End Sub
#End Region
End Class
