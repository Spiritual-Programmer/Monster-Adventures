Public Class BrickLdsc
    Private Sub BrickLdsc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Declare variables
        Dim prevx As Integer = MainMonster.Left
        Dim prevy As Integer = MainMonster.Top
        Dim button As DialogResult

        'Menu KeyPress Options
        If e.KeyCode = Keys.M Then
            Me.Hide()
            Menu1.Show()
        End If

        'Monster Movement with keyboard w,a,s,d keys
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

        'setting collision with outside walls

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

        If testcollision(MainMonster, WallBlock5) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        'setting collision with inside walls

        If testcollision(MainMonster, WallBlock6) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock7) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock8) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock9) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock10) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock13) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock11) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock12) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock14) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock15) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock16) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock17) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock18) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock19) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock20) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock21) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock22) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock23) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock24) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If
        If MainMonster.Bounds.IntersectsWith(EntranceFirstLand.Bounds) Then
            Me.Hide()
            FirstLand.Show()
        End If


        'setting collision with canons
        If testcollision(MainMonster, Canon1) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon2) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon3) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        ElseIf testcollision(MainMonster, Canon4) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon5) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        ElseIf testcollision(MainMonster, Canon6) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon7) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        ElseIf testcollision(MainMonster, Canon2) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon8) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        ElseIf testcollision(MainMonster, Canon9) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon10) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        ElseIf testcollision(MainMonster, Canon11) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon12) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        ElseIf testcollision(MainMonster, Canon13) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx

        End If

        'Collsion with Gamble Monster
        If testcollision(MainMonster, GambleMonster) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            LbGamble.Visible = True
        Else
            LbGamble.Visible = False
        End If

        'Collsion with Gamble Block
        If testcollision(MainMonster, GambleBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            GambleMessage.Visible = True
            BtnNoGamble.Visible = True
            BtnYesGamble.Visible = True
            BtnNoGamble.BringToFront()
            BtnYesGamble.BringToFront()
        Else
            GambleMessage.Visible = False
            BtnNoGamble.Visible = False
            BtnYesGamble.Visible = False

        End If

        'Collision with Loan Monster
        If testcollision(MainMonster, LoanMonster) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            LbMonsterLoan.Visible = True
        Else
            LbMonsterLoan.Visible = False
        End If


        'Collsion with Loan Block
        If testcollision(MainMonster, LoanBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            LoanMessage.Visible = True
            BtnNoLoan.Visible = True
            BtnYesLoan.Visible = True
            BtnNoLoan.BringToFront()
            BtnYesLoan.BringToFront()
        Else
            LoanMessage.Visible = False
            BtnNoLoan.Visible = False
            BtnYesLoan.Visible = False

        End If

        'Collision with Computer TextTOSpeech Monster

        If testcollision(MainMonster, AIMonster) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            LbAIinfo.Visible = True

        Else
            LbAIinfo.Visible = False

        End If

        'Collision with Portal
        If testcollision(MainMonster, Portal) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            Me.Hide()
            Me.Focus()
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.TwlightZone, AudioPlayMode.BackgroundLoop)
            Phantum.Show()
        End If


        'Collsions with computer
        If testcollision(MainMonster, ComputerIA) = True Then
            button = MessageBox.Show("Enable text to speech form", "IA",
                MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)

            If button = DialogResult.Yes Then
                Me.Hide()
                Me.Focus()
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.AIVB2, AudioPlayMode.BackgroundLoop)
                TextToSpeech.Show()
            End If
        End If

        'setting collision with bullet

        If testcollision(MainMonster, bullet1) = True Then
            button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then


                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Show()
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, bullet2) = True Then
            button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Show()
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If


        If testcollision(MainMonster, bullet3) = True Then
            button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
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
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, bullet4) = True Then
            button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then


                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Show()
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, bullet5) = True Then
            button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then


                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Show()
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, bullet6) = True Then
            button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then


                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Show()
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()
            Else
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If

        If testcollision(MainMonster, bullet7) = True Then
            button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then


                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
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
                LavaLdsc.Close()
                Lava2.Close()
                Lava3.Close()
                MainForm.Close()
                My.Computer.Audio.Stop()
            End If
        End If


    End Sub

    Private Sub BtnNoGamble_Click(sender As Object, e As EventArgs) Handles BtnNoGamble.Click
        'No Button on Gamble Message
        GambleMessage.Visible = False
        BtnNoGamble.Visible = False
        BtnYesGamble.Visible = False
        Me.Focus()
    End Sub

    Private Sub BtnYesGamble_Click(sender As Object, e As EventArgs) Handles BtnYesGamble.Click
        'YES Button on Gamble Message
        GambleMessage.Visible = False
        BtnNoGamble.Visible = False
        BtnYesGamble.Visible = False
        Me.Focus()
        Me.Hide()
        My.Computer.Audio.Stop()

        Gamble.Show()
        My.Computer.Audio.Play(My.Resources.ThatsLifeVB, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub BtnNoLoan_Click(sender As Object, e As EventArgs) Handles BtnNoLoan.Click
        'No Button on Loan Message
        LoanMessage.Visible = False
        BtnNoLoan.Visible = False
        BtnYesLoan.Visible = False
        Me.Focus()
    End Sub

    Private Sub BtnYesLoan_Click(sender As Object, e As EventArgs) Handles BtnYesLoan.Click
        'YES  Button on Loan Message
        LoanMessage.Visible = False
        BtnNoLoan.Visible = False
        BtnYesLoan.Visible = False
        Me.Focus()
        Me.Hide()
        MonsterLoan.Show()
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

    Private Sub BrickLdsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'turn timer 1 on
        Timer1.Enabled = True



        'make objects transparent to their backgrounds
        MainMonster.Parent = pbBackground
        bullet1.Parent = pbBackground
        bullet2.Parent = pbBackground
        bullet3.Parent = pbBackground
        bullet4.Parent = pbBackground
        bullet5.Parent = pbBackground
        bullet6.Parent = pbBackground
        bullet7.Parent = pbBackground
        ComputerIA.Parent = pbBackground

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'make bullet move across
        bullet1.Top -= 1
        bullet2.Top -= 1
        bullet3.Top -= 1
        bullet4.Top -= 1
        bullet5.Top -= 1
        bullet6.Top -= 1
        bullet7.Top -= 1



        If bullet1.Bounds.IntersectsWith(canonblock1.Bounds) Then
            bullet1.Left = 117
            bullet1.Top = 490


        ElseIf bullet2.Bounds.IntersectsWith(canonblock1.Bounds) Then
            bullet2.Left = 224
            bullet2.Top = 490

        ElseIf bullet3.Bounds.IntersectsWith(canonblock1.Bounds) Then
            bullet3.Left = 330
            bullet3.Top = 490

        ElseIf bullet4.Bounds.IntersectsWith(canonblock1.Bounds) Then
            bullet4.Left = 433
            bullet4.Top = 490

        ElseIf bullet5.Bounds.IntersectsWith(canonblock1.Bounds) Then
            bullet5.Left = 540
            bullet5.Top = 490

        ElseIf bullet6.Bounds.IntersectsWith(canonblock1.Bounds) Then
            bullet6.Left = 646
            bullet6.Top = 490

        Else bullet7.Bounds.IntersectsWith(canonblock1.Bounds)
            bullet7.Left = 750
            bullet7.Top = 490



        End If
    End Sub




End Class