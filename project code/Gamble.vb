Public Class Gamble

    ' declare class-level variable
    Private points As Integer = 10

    Private Sub Gamble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make title and label background color transparent to their background
        LbLuckyMonstersTitle.Parent = PbBackground
        LbPoints.Parent = PbBackground
        numberLabel.Parent = PbBackground
        DollarGif1.Parent = PbBackground
        DollarGif2.Parent = PbBackground
        DollarGif3.Parent = PbBackground
        DollarGif4.Parent = PbBackground
        DollarGif5.Parent = PbBackground
        DollarGif6.Parent = PbBackground

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Me.Hide()
        BrickLdsc.Show()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.BloodBorne, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub rollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        ' simulates the Lucky Number Game
        Dim ranGen As New Random
        Dim random1 As Integer
        Dim random2 As Integer

        'remove images
        FirstDiePictureBox.Image = Nothing
        SecondDiePictureBox.Image = Nothing

        'disable roll'em button
        RollButton.Enabled = False
        'refresh form and then delay execution
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        'generate two random integers from 1 through 6
        random1 = ranGen.Next(1, 7)
        random2 = ranGen.Next(1, 7)

        'display appropriate image in firstDiepicturebox
        Select Case random1
            Case 1
                FirstDiePictureBox.Image = Dot1PictureBox.Image
            Case 2
                FirstDiePictureBox.Image = Dot2PictureBox.Image
            Case 3
                FirstDiePictureBox.Image = Dot3PictureBox.Image
            Case 4
                FirstDiePictureBox.Image = Dot4PictureBox.Image
            Case 5
                FirstDiePictureBox.Image = Dot5PictureBox.Image
            Case 6
                FirstDiePictureBox.Image = Dot6PictureBox.Image

        End Select

        'display approtiate image insecond die picture box
        Select Case random2
            Case 1
                SecondDiePictureBox.Image = Dot1PictureBox.Image
            Case 2
                SecondDiePictureBox.Image = Dot2PictureBox.Image
            Case 3
                SecondDiePictureBox.Image = Dot3PictureBox.Image
            Case 4
                SecondDiePictureBox.Image = Dot4PictureBox.Image
            Case 5
                SecondDiePictureBox.Image = Dot5PictureBox.Image
            Case 6
                SecondDiePictureBox.Image = Dot6PictureBox.Image
        End Select

        'check sum of random numbers
        If random1 + random2 = 7 Then
            Dim count As Integer = 1
            Do While count <= 10
                numberLabel.Visible = Not numberLabel.Visible
                Me.Refresh()
                System.Threading.Thread.Sleep(200)
                count += 1
            Loop
            points += 2
        Else
            points -= 1
            If points = 0 Then
                MessageBox.Show("Looks like you have lost all of your coins!" &
                                 "Click the Start over button to try again.",
                                 "Lucky Monsters Game", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            End If
        End If
        'display points
        pointsLabel.Text = points.ToString
        'enable Roll'Em button
        RollButton.Enabled = True
    End Sub

    Private Sub startOverButton_Click(sender As Object, e As EventArgs) Handles StartOverButton.Click
        'START NEW GAME
        points = 10
        pointsLabel.Text = pointsLabel.ToString
        FirstDiePictureBox.Image = Nothing
        SecondDiePictureBox.Image = Nothing
    End Sub


End Class