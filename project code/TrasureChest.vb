Public Class TrasureChest
    Private Sub TrasureChest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtncloseTreasureChest_Click(sender As Object, e As EventArgs) Handles BtncloseTreasureChest.Click
        Me.Hide()
        GreenLdsc.Show()
    End Sub

   
    Private Sub BtnFindTreasure_Click(sender As Object, e As EventArgs) Handles BtnFindTreasure.Click
        'Stimulate treasure Chest
        Dim RandGen As New Random
        Dim Index As Integer

        BtnFindTreasure.Enabled = False
        For spins As Integer = 1 To 25
            Index = RandGen.Next(0, 3)
            Pbindex.Image = ImageList1.Images.Item(Index)
            Me.Refresh()
            System.Threading.Thread.Sleep(50)

        Next spins
        MessageBox.Show("Congratulations, you have found a Monster's Treasure!", "Treasure Chest ", MessageBoxButtons.OK, MessageBoxIcon.None)

        BtnFindTreasure.Enabled = True
        BtnFindTreasure.Focus()


    End Sub
End Class