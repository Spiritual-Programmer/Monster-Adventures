Public Class Menu1
    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbMenu.Parent = pbbackground
    End Sub

    Private Sub BtnQuitGame_Click(sender As Object, e As EventArgs) Handles BtnQuitGame.Click
        Me.Close()
        MainForm.Close()
        CharacterSel.Close()
        WelcomeForm.Close()
        FirstLand.Close()
        GreenLdsc.Close()
        BrickLdsc.Close()
        LavaLdsc.Close()
        Lava2.Close()
        LavaLevel2.Close()
        LavaLevel3.Close()
        Twilight2.Close()
        Phantum.Close()
        Lava3.Close()
        CrackParty.Close()
        TrasureChest.Close()
        Gamble.Close()
        MonsterLoan.Close()
        TextToSpeech.Close()
        My.Computer.Audio.Stop()

    End Sub

    Private Sub BtnCloseMenu_Click(sender As Object, e As EventArgs) Handles BtnCloseMenu.Click
        Me.Hide()
        FirstLand.Show()
    End Sub

    Private Sub BtnStartOver_Click(sender As Object, e As EventArgs) Handles BtnStartOver.Click
        Me.Close()
        CharacterSel.Close()
        WelcomeForm.Close()
        FirstLand.Close()
        GreenLdsc.Close()
        BrickLdsc.Close()
        LavaLdsc.Close()
        Lava2.Close()
        Lava3.Close()
        LavaLevel2.Close()
        LavaLevel3.Close()
        Twilight2.Close()
        Phantum.Close()
        CrackParty.Close()
        TrasureChest.Close()
        Gamble.Close()
        MonsterLoan.Close()
        TextToSpeech.Close()
        My.Computer.Audio.Stop()

        MainForm.Show()
        My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Menu1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Menu KeyPress Options
        If e.KeyCode = Keys.M Then
            Me.Hide()
            FirstLand.Show()
        End If
    End Sub
End Class