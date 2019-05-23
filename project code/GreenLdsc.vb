Public Class GreenLdsc
    Private Sub GreenLdsc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        'setting collision with outsidewalls

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

        'setting collision with treasurebox walls

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

        If testcollision(MainMonster, WallBlock11) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If
        'setting collision with higherplatform walls

        If testcollision(MainMonster, WallBlock12) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WallBlock13) = True Then
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

        'Collsions with trees and other objects


        If testcollision(MainMonster, TreeBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, TreeBlock2) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, LampBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, PillowBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, WoodBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, FountainBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, woodblock2) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, woodblock3) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, woodblock4) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, woodblock5) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        If testcollision(MainMonster, TableBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
        End If

        'Concealing monster under trees and bushes

        If testcollision(MainMonster, TreeConceal) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, TreeConceal2) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, TreasureChest) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, BushConceal) = True Then
            MainMonster.Visible = False
        ElseIf testcollision(MainMonster, BushConceal2) = True Then
            MainMonster.Visible = False
        Else : MainMonster.Visible = True

        End If



        'Collision with treasure Chest Message Box


        If testcollision(MainMonster, TreasureChest) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            BtnTreasureNo.Visible = True
            BtnTreasureYes.Visible = True
            LbTreasurechest.Visible = True
        Else
            BtnTreasureNo.Visible = False
            BtnTreasureYes.Visible = False
            LbTreasurechest.Visible = False


        End If

        'Collision with  Crack Monster

        If testcollision(MainMonster, CrackMonster) = True Then
            Lbcrackinfo.Visible = True
        Else
            Lbcrackinfo.Visible = False
        End If

        'Collision with Crack station Message Box

        If testcollision(MainMonster, CrackBlock) = True Then
            MainMonster.Top = prevy
            MainMonster.Left = prevx
            BtnCrackNo.Visible = True
            BtnCrackYes.Visible = True
            LbCrackStation.Visible = True
        Else
            BtnCrackNo.Visible = False
            BtnCrackYes.Visible = False
            LbCrackStation.Visible = False
        End If
        'Creating entrance to firstland

        If MainMonster.Bounds.IntersectsWith(EntranceFirstLand.Bounds) Then
            Me.Hide()
            FirstLand.Show()
        End If
    End Sub
    Private Sub BtnCrackNo_Click(sender As Object, e As EventArgs) Handles BtnCrackNo.Click
        ' Crack Station button NO
        BtnCrackNo.Visible = False
        BtnCrackYes.Visible = False
        LbCrackStation.Visible = False

        Me.Focus()
    End Sub

    Private Sub BtnCrackYes_Click(sender As Object, e As EventArgs) Handles BtnCrackYes.Click
        ' Crack Station button YES
        BtnCrackNo.Visible = False
        BtnCrackYes.Visible = False
        LbCrackStation.Visible = False
        Me.Focus()
        Me.Hide()
        CrackParty.Show()
    End Sub

    Private Sub BtnTreasureNo_Click(sender As Object, e As EventArgs) Handles BtnTreasureNo.Click
        'TreasureChest Message btn NO
        BtnTreasureNo.Visible = False
        BtnTreasureYes.Visible = False
        LbTreasurechest.Visible = False

        'keep focus on the form
        Me.Focus()
    End Sub

    Private Sub BtnTreasureYes_Click(sender As Object, e As EventArgs) Handles BtnTreasureYes.Click
        'TreasureChest Message btn YES
        BtnTreasureNo.Visible = False
        BtnTreasureYes.Visible = False
        LbTreasurechest.Visible = False
        Me.Focus()
        Me.Hide()
        TrasureChest.Show()

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

    Private Sub GreenLdsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMonster.Parent = pbBackground

    End Sub

End Class