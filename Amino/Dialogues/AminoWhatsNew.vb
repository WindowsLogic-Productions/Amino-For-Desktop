Public Class AminoWhatsNew
    Private Sub AminoWhatsNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            ListBox1.BackColor = My.Settings.CustomColour
        End If

    End Sub
End Class