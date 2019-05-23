Public Class MonsterLoan
    Private Sub MonsterLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbMonsterLoanTitle.Parent = PbBackground
        LbLoan.Parent = PbBackground
        LbMonthly.Parent = PbBackground
        LbTerm.Parent = PbBackground

        'fills the termComboBox
        For term As Integer = 1 To 30
            CbTerm.Items.Add(term.ToString)

        Next term
        CbTerm.SelectedItem = "4"


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
        BrickLdsc.Show()

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        'calculates the monthly payments on a loan using
        'interest rates of 3% to 6% in increments of 0.5%

        Dim loan, monthlyPayment As Double
        Dim term As Integer

        'assign input to variables
        Double.TryParse(TbLoan.Text, loan)
        term = Convert.ToInt32(CbTerm.Text)

        ListMontlyPayments.Items.Clear()
        'calculate and display monthly payments
        For rate As Double = 0.03 To 0.06 Step 0.005
            monthlyPayment =
            -Financial.Pmt(rate / 12, term * 12, loan)
            ListMontlyPayments.Items.Add(rate.ToString("P1") &
                    ":  " & monthlyPayment.ToString("C2"))
        Next rate
        TbLoan.Focus()

    End Sub

    Private Sub TbLoan_enter(sender As Object, e As EventArgs) Handles TbLoan.Enter
        'select existing text when text box recieves the focus

        TbLoan.SelectAll()

    End Sub

    Private Sub TbLoan_TextChanged(sender As Object, e As EventArgs) Handles TbLoan.TextChanged
        'clears the lsit box
        ListMontlyPayments.Items.Clear()

    End Sub

    Private Sub CbTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTerm.SelectedIndexChanged
        'clears list box
        ListMontlyPayments.Items.Clear()
    End Sub
End Class