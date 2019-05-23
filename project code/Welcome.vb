

Public Class WelcomeForm
    Dim Text As String
    Dim LL, II, PP As Integer

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles Btnnext.Click
        Me.Hide()
        My.Computer.Audio.Stop()
        FirstLand.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbinstructions.Text = Lbinstructions.Text + Mid(Text, II, 1)
        If II > LL Then
            II = 0
            Lbinstructions.Text = ""

        End If
        II = II + 1
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = "Hello Monster... Welcome to Monsteropia where you can explore a world full of adventure, thrill and excitement. Click the next Button to start your journey."
        LL = Len(Text)
        II = 1
        PP = 1

    End Sub
End Class