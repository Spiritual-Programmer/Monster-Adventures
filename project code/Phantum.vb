Public Class Phantum
    Dim randGen As New Random
    Dim randomx As Integer
    Dim randomy As Integer

    Private Sub Phantum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        MainMonster.Parent = PbBackground
        Portal.Parent = PbBackground
    End Sub
    Private Sub Phantum_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Declare variables
        Dim prevx As Integer = MainMonster.Left
        Dim prevy As Integer = MainMonster.Top

        'Menu KeyPress Options
        If e.KeyCode = Keys.M Then
            Me.Hide()
            Menu1.Show()
        End If

        'Monster Movement with keyboard w,a,s,d keys
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





        'Collision with portal
        If testcollision(MainMonster, Portal) = True Then
            Me.Hide()


            Twilight2.Show()
            Me.Focus()


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
        randomx = randGen.Next(64, 781)
        randomy = randGen.Next(20, 439)
        'if the enemy object is to the right of the player chracter, the enemy will move to the left
        If object1.left + object1.width > object2.left Then
            object1.left = randomx
            object1.top = randomy


        End If

        'if the enemy object is to the left of the player chracter, the enemy object will move to the right
        If object1.left + object1.width < object2.left Then
            object1.left = randomx
            object1.top = randomy

        End If

        'if the enemy object is lower than the player chracter, the enemy object will move up
        If object1.top + object1.height > object2.top Then
            object1.left = randomx
            object1.top = randomy

        End If

        'if the enemy object is higher than the player character, the enemy object will move down
        If object1.top + object1.height < object2.top Then
            object1.left = randomx
            object1.top = randomy


        End If

    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Chase(Portal, MainMonster)
    End Sub
End Class