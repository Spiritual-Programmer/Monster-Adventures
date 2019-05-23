Public Class CharacterSel

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If Monster1RadBtn.Checked Then
            'replace character selection in each map
            GreenLdsc.MainMonster.Image = Mainmonster.Image
            FirstLand.MainMonster.Image = Mainmonster.Image
            LavaLdsc.MainMonster.Image = Mainmonster.Image
            BrickLdsc.MainMonster.Image = Mainmonster.Image
            Lava2.MainMonster.Image = Mainmonster.Image
            Lava3.MainMonster.Image = Mainmonster.Image
            Phantum.MainMonster.Image = Mainmonster.Image

            GroupBox1.Visible = False
            btnOk.Visible = False
            Me.Focus()
            Me.Hide()
            WelcomeForm.Show()

        ElseIf Monster2RadBtn.Checked Then
            'replace character selection in each map
            GreenLdsc.MainMonster.Image = Monster2.Image
            FirstLand.MainMonster.Image = Monster2.Image
            LavaLdsc.MainMonster.Image = Monster2.Image
            BrickLdsc.MainMonster.Image = Monster2.Image
            Lava2.MainMonster.Image = Monster2.Image
            Lava3.MainMonster.Image = Monster2.Image
            Phantum.MainMonster.Image = Monster2.Image

            GroupBox1.Visible = False
            Mainmonster.Image = Monster2.Image
            btnOk.Visible = False
            Me.Focus()
            Me.Hide()
            WelcomeForm.Show()
        End If
        Mainmonster.Visible = True
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make transparent with the background picture
        Mainmonster.Parent = PbBackground
        Monster2.Parent = PbBackground
        GroupBox1.Parent = PbBackground
        LbChooseMonster.Parent = PbBackground


    End Sub


End Class