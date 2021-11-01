Public Class Updater
#Region "Updater"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label1.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            CheckForUpdates()
        End If
    End Sub

    Public Sub CheckForUpdates()
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Variables.vertext)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                TitleText.Text = "You're on the latest version."
                StatusText.Text = "No updates available."
                CloseButton.Text = "OK"
            Else
                WebBrowser1.Navigate(Variables.setup)
                StatusText.Text = ("Downloading updates...")
                Me.Hide()
                ProgressBar1.Value = 0
            End If
        End If
    End Sub
#End Region
#Region "Load Settings"
    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        TitleText.Parent = PictureBox2
        PictureBox1.Parent = PictureBox2

        'Start checking for updates
        Timer1.Start()
        Label1.Text = ProgressBar1.Value
        CheckForUpdates()
    End Sub
#End Region
#Region "Buttons"

    Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
#End Region
End Class