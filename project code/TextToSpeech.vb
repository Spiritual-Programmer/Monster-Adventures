Public Class TextToSpeech
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSpeak.Click
        Dim sapi
        sapi = CreateObject("sapi.spvoice")
        sapi.speak(TbSpeak.Text)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.BloodBorne, AudioPlayMode.BackgroundLoop)
        BrickLdsc.Show()
    End Sub
End Class