Public Class Lava3
    Private Sub Lava3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Declare variables
        Dim prevx As Integer = MainMonster.Left
        Dim prevy As Integer = MainMonster.Top
        'Inventory Menu Key press
        If e.KeyCode = Keys.I Then
            'Monster Movement with keyboard
        End If

        'Menu KeyPress Options
        If e.KeyCode = Keys.M Then
            Me.Hide()
            Menu1.Show()
        End If

        Select Case e.KeyCode
            Case Keys.D
                MainMonster.Left += 5
            Case Keys.A
                MainMonster.Left -= 5
            Case Keys.W
                MainMonster.Top -= 5
            Case Keys.S
                MainMonster.Top += 5

            'Movement with arrow keys
            Case Keys.Right
                MainMonster.Left += 5
            Case Keys.Left
                MainMonster.Left -= 5
            Case Keys.Up
                MainMonster.Top -= 5
            Case Keys.Down
                MainMonster.Top += 5
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

        'Collision with entrance Lava2
        If testcollision(MainMonster, EntranceLava2) = True Then
            Me.Hide()
            LavaLdsc.Show()
        End If

        'Lava Fall

        Dim Button As DialogResult

        If testcollision(MainMonster, LavaFall1) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall2) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall3) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall4) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall5) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall6) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall7) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall8) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall9) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall10) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall11) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
        End If


        If testcollision(MainMonster, LavaFall12) = True Then
            Button = MessageBox.Show("Would You Like To Play Again", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If Button = DialogResult.Yes Then

                'Closes all open forms and starts from the beginning
                Me.Close()
                CharacterSel.Close()
                WelcomeForm.Close()
                FirstLand.Close()
                GreenLdsc.Close()
                BrickLdsc.Close()
                Lava2.Close()
                LavaLdsc.Close()
                MainForm.Show()
                Me.Focus()
            Else
                Me.Close()
            End If
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

    Private Sub Lava3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMonster.Parent = PbBackground
    End Sub


End Class