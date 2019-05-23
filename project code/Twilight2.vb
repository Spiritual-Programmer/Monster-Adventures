Public Class Twilight2
    Private Sub Twilight2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Declare variables
        Dim prevx As Integer = MainMonster.Left
        Dim prevy As Integer = MainMonster.Top

        'Menu KeyPress Options
        If e.KeyCode = Keys.M Then
            Me.Hide()
            Menu1.Show()
        End If

        'Monster Movement with keyboard

        Select Case e.KeyCode
            Case Keys.D
                MainMonster.Left += 8
            Case Keys.A
                MainMonster.Left -= 8
            Case Keys.W
                MainMonster.Top -= 8
            Case Keys.S
                MainMonster.Top += 8

            'Movement with arrow keys
            Case Keys.Right
                MainMonster.Left += 8
            Case Keys.Left
                MainMonster.Left -= 8
            Case Keys.Up
                MainMonster.Top -= 8
            Case Keys.Down
                MainMonster.Top += 8
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

        'Collision with portal
        If testcollision(MainMonster, Portal) = True Then
            Me.Hide()
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)
            MainForm.Show()
            Me.Focus()
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

    Private Sub Twilight2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If testcollision(MainMonster, PbBackground) = True Then
            MainMonster.Parent = PbBackground
            MainMonster.BringToFront()
        End If

        If testcollision(MainMonster, PbBackground2) = True Then
            MainMonster.Parent = PbBackground2
            MainMonster.BringToFront()
        End If

        If testcollision(MainMonster, PbBackground3) = True Then
            MainMonster.Parent = PbBackground3
            MainMonster.BringToFront()
        End If

        If testcollision(MainMonster, PbBackground4) = True Then
            MainMonster.Parent = PbBackground4
            MainMonster.BringToFront()
        End If


        If testcollision(MainMonster, PbBackground5) = True Then
            MainMonster.Parent = PbBackground5
            MainMonster.BringToFront()
        End If



        Gem1.Parent = PbBackground4
        Gem2.Parent = PbBackground2
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick






        Gem1.Left = +1

        If Gem1.Bounds.IntersectsWith(GemBlock1.Bounds) Then
            Gem1.Left = -2
            Gem1.Top = 95
        End If
    End Sub
End Class
