Public Class LavaLevel2
    Dim score As Integer
    Dim scorenumber As Integer
    Dim lives As Integer = 3
    Dim button As DialogResult



    Private Sub LavaLevel2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Declare variables
        Dim prevx As Integer = MainMonster.Left
        Dim prevy As Integer = MainMonster.Top
        Dim prevGemX As Integer = Gem.Top
        Dim prevGemY As Integer = Gem.Top
        Dim randGen As New Random
        Dim randomx As Integer
        Dim randomy As Integer


        randomx = randGen.Next(64, 781)
        randomy = randGen.Next(20, 439)
        'Inventory Menu Key press
        If e.KeyCode = Keys.I Then
            'Monster Movement with keyboard
        End If



        'Menu KeyPress Options
        If e.KeyCode = Keys.M Then
            Me.Hide()
            Menu1.Show()
        End If

        'Collsion with SlowDown pits

        If testcollision(MainMonster, SlowDown1) = True Then

            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown2) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown3) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown4) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown5) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown6) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown7) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown8) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown9) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown10) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown11) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown12) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown13) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        ElseIf testcollision(MainMonster, SlowDown14) = True Then
            Select Case e.KeyCode
                Case Keys.D
                    MainMonster.Left += 4.5
                Case Keys.A
                    MainMonster.Left -= 4.5
                Case Keys.W
                    MainMonster.Top -= 4.5
                Case Keys.S
                    MainMonster.Top += 4.5

                'Movement with arrow keys
                Case Keys.Right
                    MainMonster.Left += 4.5
                Case Keys.Left
                    MainMonster.Left -= 4.5
                Case Keys.Up
                    MainMonster.Top -= 4.5
                Case Keys.Down
                    MainMonster.Top += 4.5
            End Select

        Else
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
        End If

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





        'Collision with LavaFall

        If testcollision(MainMonster, LavaFall1) = True Then
            If lives >= 1 Then
                lives -= 1
                LbLives.Text = "Lives: " & lives.ToString
                'reset position of main monster
                MainMonster.Top = 107
                MainMonster.Left = 41



                If lives < 1 Then
                    lives -= 1
                    LbLives.Text = "Lives: 0 "
                    button = MessageBox.Show("Your Highest Score is " & score, "Game Over",
               MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
                    If button = DialogResult.OK Then


                        'Closes all open forms and starts from the beginning
                        Me.Close()
                        CharacterSel.Close()
                        WelcomeForm.Close()
                        FirstLand.Close()
                        GreenLdsc.Close()
                        LavaLdsc.Close()
                        BrickLdsc.Close()
                        Lava3.Close()
                        Lava2.Close()
                        LavaLevel3.Close()
                        MainForm.Show()
                        My.Computer.Audio.Stop()
                        My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                        Me.Focus()

                    End If
                End If
                End If
            End If


            'Collision with entrance Lava3
            If testcollision(MainMonster, EntranceLavaLevel3) = True Then
            button = MessageBox.Show("Congratulations, would you like to move on to Level 3", "Level 3",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If button = DialogResult.Yes Then
                MainMonster.Top = prevy
                MainMonster.Left = prevx
                Me.Hide()
                LavaLevel3.Show()
            Else
                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                LavaLdsc.Close()
                BrickLdsc.Close()
                Lava3.Close()
                Lava2.Close()
                LavaLevel3.Close()
                MainForm.Show()
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                Me.Focus()

            End If
        End If



        'Collsion with gem
        If testcollision(MainMonster, Gem) = True Then
            Gem.Top = randomy
            Gem.Left = randomx
            scorenumber += 2
            score = scorenumber
            LbInstructions1.Hide()

            LbScore.Text = "Score: " & score.ToString

        End If
        ' When score is 25
        If score = 4 Then
            WalkingMonster1.Visible = False
            Timer1.Enabled = False
            Gem.Visible = False
            EntranceLavaLevel3.Hide()
            LbInstructions1.Hide()
            EntranceLavaLevel3.Visible = True
            EntranceLavaLevel3.Top = 187
            EntranceLavaLevel3.Left = 787
            Timer2.Enabled = True
            LbWellDone.Visible = True

        End If
        'Gem and lava collsion
        If testcollision(Gem, LavaFall1) = True Then
            Gem.Top = prevGemY
            Gem.Left = prevGemX
        End If

    End Sub


    Function testcollision(ByVal pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean
        If pic1.Top < pic2.Bottom And
           pic1.Left < pic2.Right And
           pic1.Bottom > pic2.Top And
            pic1.Right > pic2.Left Then
            Return True
        End If
        Return False

    End Function

    Function Chase(ByRef object1 As Object, ByRef object2 As Object)
        'if the enemy object is to the right of the player chracter, the enemy will move to the left
        If object1.left + object1.width > object2.left Then
            object1.left -= 5
        End If

        'if the enemy object is to the left of the player chracter, the enemy object will move tot he right
        If object1.left + object1.width < object2.left Then
            object1.left += 5
        End If

        'if the enemy object is lower than the player chracter, the enemy object will move up
        If object1.top + object1.height > object2.top Then
            object1.top -= 5
        End If

        'if the enemy object is higher than the player character, the enemy object will move down
        If object1.top + object1.height < object2.top Then
            object1.top += 5

        End If


    End Function

    Private Sub Lavalevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMonster.Parent = PbBackground
        EntranceLavaLevel3.Parent = PbBackground
        WalkingMonster1.Parent = PbBackground
        Gem.Parent = PbBackground
        LbScore.Parent = PbBackground
        LbLives.Parent = PbBackground

        LbWellDone.Parent = PbBackground
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        'walking monster chasing you
        Chase(WalkingMonster1, MainMonster)

        'Collsion with walking monster and lives 

        If testcollision(MainMonster, WalkingMonster1) = True Then
            If lives >= 1 Then
                lives -= 1
                LbLives.Text = "Lives: " & lives.ToString
                'reset position of main monster
                MainMonster.Top = 215
                MainMonster.Left = 21
                'reset position of Walking Monster
                WalkingMonster1.Top = 384
                WalkingMonster1.Left = 644


                If lives < 1 Then
                    lives -= 1
                    LbLives.Text = "Lives: 0 "
                    button = MessageBox.Show("Your Highest Score is " & score, "Game Over",
               MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
                    If button = DialogResult.OK Then


                        'Closes all open forms and starts from the beginning
                        Me.Close()
                        CharacterSel.Close()
                        WelcomeForm.Close()
                        FirstLand.Close()
                        GreenLdsc.Close()
                        LavaLdsc.Close()
                        BrickLdsc.Close()
                        Lava3.Close()
                        MainForm.Show()
                        My.Computer.Audio.Stop()
                        My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
                        Me.Focus()

                    End If
                End If
                End If
            End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LbWellDone.Text = " Well Done Now Move on to Level 3"
        LbWellDone.Visible = Not (LbWellDone.Visible)
    End Sub
End Class