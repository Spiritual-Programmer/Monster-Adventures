Public Class FirstLand

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MainMonster.Parent = pbBackground

        'play  background music
        My.Computer.Audio.Play(My.Resources.BloodBorne, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        'setting instructions

        If testcollision(MainMonster, instructions1) = True Then
            lbinstructions1.Visible = True

        ElseIf testcollision(MainMonster, instructions2) = True Then
            lbinstructions2.Visible = True

        ElseIf testcollision(MainMonster, instructions3) = True Then
            lbinstructions3.Visible = True

        ElseIf testcollision(MainMonster, instructions4) = True Then
            lbinstructions4.Visible = True

        ElseIf testcollision(MainMonster, instructions5) = True Then
            lbinstructions3.Visible = True

        Else
            lbinstructions1.Visible = False
            lbinstructions2.Visible = False
            lbinstructions3.Visible = False
            lbinstructions4.Visible = False
            lbinstructions3.Visible = False
        End If

        'being invisible under grass and tree
        If testcollision(MainMonster, grass1) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, grass2) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, grass2) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, grass3) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, tree1) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, tree2) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, tree3) = True Then
            MainMonster.Visible = False
        Else MainMonster.Visible = True





        End If
        'setting collision with walls

        If testcollision(MainMonster, WallBlock1) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, Wallblock2) = True Then
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

        'First EntranceBlock

        If testcollision(MainMonster, EntranceBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        'Collision with rocks and trees

        If testcollision(MainMonster, RockBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, TreeBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If


        'Creating entrance to other maps
        If MainMonster.Bounds.IntersectsWith(EntanceGreenLdsc.Bounds) Then
            Me.Hide()
            GreenLdsc.Show()
        ElseIf MainMonster.Bounds.IntersectsWith(EntranceLava.Bounds) Then
            Me.Hide()
            LavaLdsc.Show()
        ElseIf MainMonster.Bounds.IntersectsWith(EntranceBrickLdsc.Bounds) Then
            Me.Hide()
            BrickLdsc.Show()
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

End Class