Public Class CrackParty
    Private Sub CrackParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Make label Titles transparent to their backgrounds
        LbNumberOfGuests.Parent = PbBackground
        LbSpecies.Parent = PbBackground
        LbTotalChargeTitle.Parent = PbBackground
        LbGenerateTestData.Parent = PbBackground
        LbCrackTitle.Parent = PbBackground

        'fills the species listbox and then selects the first item

        ListBoxSpecies.Items.Add("Monsters")
        ListBoxSpecies.Items.Add("Demons")
        ListBoxSpecies.Items.Add("Klingons")
        ListBoxSpecies.Items.Add("Cardassions")
        ListBoxSpecies.Items.Add("Ferengi")
        ListBoxSpecies.Items.Add("Changelings")
        ListBoxSpecies.Items.Add("Grand Nagus Trump")
        ListBoxSpecies.SelectedIndex = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        GreenLdsc.Show()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        'Declare variables
        Dim guests As Integer
        Dim species As Integer
        Dim guestPrice As Integer
        Dim totalCharge As Integer

        Integer.TryParse(TbNumberOfGuests.Text, guests)
        species = ListBoxSpecies.SelectedIndex

        'determine the price per guest
        Select Case species
            Case 0 'Monsters'
                guestPrice = 25
            Case 1 'Demons
                guestPrice = 35
            Case 2 'Klingons
                guestPrice = 40
            Case 3 'Cardassians
                guestPrice = 40
            Case 4 'Ferengi
                guestPrice = 235
            Case 5 'Changelings
                guestPrice = 220
            Case 6 'Grand Nagus Trump
                guestPrice = 10000

        End Select

        'calculate and display the total charge
        totalCharge = guests * guestPrice
        LbTotalCharge.Text = totalCharge.ToString("C0")

    End Sub

    Private Sub TbNumberOfGuests_keypress(sender As Object, e As KeyPressEventArgs) Handles TbNumberOfGuests.KeyPress
        'allows only numbers and the backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If


    End Sub

    Private Sub btnGenerateTestData_Click(sender As Object, e As EventArgs) Handles btnGenerateTestData.Click
        'Declare variables
        Dim guests As Integer
        Dim species As Integer
        Dim guestPrice As Integer
        Dim totalCharge As Integer
        Dim randGen As New Random
        Dim setsOfDataCounter As Integer = 1

        LbGenerateTestData.Text = String.Empty

        'Create a posttest Do While Loop

        Do
            guests = randGen.Next(1, 51)
            species = randGen.Next(0, 7)

            'determine price per guest
            Select Case species
                Case 0 'Monsters'
                    guestPrice = 25
                Case 1 'Demons
                    guestPrice = 35
                Case 2 'Klingons
                    guestPrice = 40
                Case 3 'Cardassians
                    guestPrice = 40
                Case 4 'Ferengi
                    guestPrice = 235
                Case 5 'Changelings
                    guestPrice = 220
                Case 6 'Grand Nagus Trump
                    guestPrice = 10000
            End Select

            'Calculate and display the total charge
            totalCharge = guests * guestPrice
            LbGenerateTestData.Text = LbGenerateTestData.Text &
                species.ToString & "      " &
                guests.ToString & "      " &
                totalCharge.ToString("C0") &
                ControlChars.NewLine
            setsOfDataCounter += 1

        Loop Until setsOfDataCounter > 10

    End Sub
End Class