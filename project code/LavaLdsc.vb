Public Class LavaLdsc
    Private Sub LavaLdsc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Declare variables
        Dim prevx As Integer = MainMonster.Left
        Dim prevy As Integer = MainMonster.Top
        Dim Button As DialogResult

        'Menu KeyPress Options
        If e.KeyCode = Keys.M Then
            Me.Hide()
            Menu1.Show()
        End If

        'Monster Movement with keyboard

        Select Case e.KeyCode
            Case Keys.D
                MainMonster.Left += 9
            Case Keys.A
                MainMonster.Left -= 9
            Case Keys.W
                MainMonster.Top -= 9
            Case Keys.S
                MainMonster.Top += 9

            'Movement with arrow keys
            Case Keys.Right
                MainMonster.Left += 9
            Case Keys.Left
                MainMonster.Left -= 9
            Case Keys.Up
                MainMonster.Top -= 9
            Case Keys.Down
                MainMonster.Top += 9
        End Select

        'setting collision with walls

        If testcollision(MainMonster, WallBlock1) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock2) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock3) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock4) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If
        'Black Vortex Entrance
        If testcollision(MainMonster, BlackVortex) = True Then
            Me.Hide()
            Lava2.Show()

        End If
        'Lava Fall


        If testcollision(MainMonster, LavaFall1) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                My.Computer.Audio.Stop()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, LavaFall2) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                My.Computer.Audio.Stop()
                MainForm.Show()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, LavaFall3) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                My.Computer.Audio.Stop()
                MainForm.Show()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, LavaFall4) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then


                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                My.Computer.Audio.Stop()
                MainForm.Show()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If


        'Entrance Collision
        If MainMonster.Bounds.IntersectsWith(EntranceFirstLand.Bounds) Then
            Me.Hide()
            FirstLand.Show()
        End If
    End Sub
    'Function For collisions
    Function testcollision(ByVal pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean
        If pic1.Top < pic2.Bottom And
           pic1.Left < pic2.Right And
           pic1.Bottom > pic2.Top And
            pic1.Right > pic2.Left Then
            Return True
        End If
        Return False

    End Function

    Private Sub LavaLdsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMonster.Parent = pbBackground
        monsterLightening.Parent = pbBackground
        monsterFire.Parent = pbBackground
        BlackVortex.Parent = pbBackground

    End Sub


End Class