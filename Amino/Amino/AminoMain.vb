Imports Gecko

Public Class AminoMain

    Public Sub New()

        InitializeComponent()
        Xpcom.Initialize("Firefox")

        Dim sUserAgent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0 (.NET CLR 3.5.30729)"
        Gecko.GeckoPreferences.User("general.useragent.override") = sUserAgent

    End Sub

    Private Sub AminoMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GeckoWebBrowser1.Navigate("https://aminoapps.com/explore/")
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        GeckoWebBrowser1.Navigate("https://aminoapps.com/c/INAV")
    End Sub
End Class
