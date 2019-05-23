<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonsterLoan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LbMonsterLoanTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        Me.LbLoan = New System.Windows.Forms.Label()
        Me.LbTerm = New System.Windows.Forms.Label()
        Me.LbMonthly = New System.Windows.Forms.Label()
        Me.ListMontlyPayments = New System.Windows.Forms.ListBox()
        Me.TbLoan = New System.Windows.Forms.TextBox()
        Me.CbTerm = New System.Windows.Forms.ComboBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbMonsterLoanTitle
        '
        Me.LbMonsterLoanTitle.AutoSize = True
        Me.LbMonsterLoanTitle.BackColor = System.Drawing.Color.Transparent
        Me.LbMonsterLoanTitle.Font = New System.Drawing.Font("Comic Sans MS", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMonsterLoanTitle.ForeColor = System.Drawing.Color.Firebrick
        Me.LbMonsterLoanTitle.Location = New System.Drawing.Point(297, 33)
        Me.LbMonsterLoanTitle.Name = "LbMonsterLoanTitle"
        Me.LbMonsterLoanTitle.Size = New System.Drawing.Size(248, 49)
        Me.LbMonsterLoanTitle.TabIndex = 1
        Me.LbMonsterLoanTitle.Text = "Monster Loan"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0038
        Me.PictureBox1.Location = New System.Drawing.Point(27, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.loan_tile
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(871, 515)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'LbLoan
        '
        Me.LbLoan.AutoSize = True
        Me.LbLoan.BackColor = System.Drawing.Color.Transparent
        Me.LbLoan.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLoan.ForeColor = System.Drawing.Color.White
        Me.LbLoan.Location = New System.Drawing.Point(405, 125)
        Me.LbLoan.Name = "LbLoan"
        Me.LbLoan.Size = New System.Drawing.Size(65, 29)
        Me.LbLoan.TabIndex = 3
        Me.LbLoan.Text = "Loan:"
        '
        'LbTerm
        '
        Me.LbTerm.AutoSize = True
        Me.LbTerm.BackColor = System.Drawing.Color.Transparent
        Me.LbTerm.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTerm.ForeColor = System.Drawing.Color.White
        Me.LbTerm.Location = New System.Drawing.Point(606, 125)
        Me.LbTerm.Name = "LbTerm"
        Me.LbTerm.Size = New System.Drawing.Size(149, 29)
        Me.LbTerm.TabIndex = 4
        Me.LbTerm.Text = "Term (years):"
        '
        'LbMonthly
        '
        Me.LbMonthly.AutoSize = True
        Me.LbMonthly.BackColor = System.Drawing.Color.Transparent
        Me.LbMonthly.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMonthly.ForeColor = System.Drawing.Color.White
        Me.LbMonthly.Location = New System.Drawing.Point(45, 268)
        Me.LbMonthly.Name = "LbMonthly"
        Me.LbMonthly.Size = New System.Drawing.Size(196, 29)
        Me.LbMonthly.TabIndex = 5
        Me.LbMonthly.Text = "Monthly Payments:"
        '
        'ListMontlyPayments
        '
        Me.ListMontlyPayments.BackColor = System.Drawing.Color.Maroon
        Me.ListMontlyPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListMontlyPayments.ForeColor = System.Drawing.Color.White
        Me.ListMontlyPayments.FormattingEnabled = True
        Me.ListMontlyPayments.ItemHeight = 18
        Me.ListMontlyPayments.Location = New System.Drawing.Point(50, 320)
        Me.ListMontlyPayments.Name = "ListMontlyPayments"
        Me.ListMontlyPayments.Size = New System.Drawing.Size(177, 148)
        Me.ListMontlyPayments.TabIndex = 6
        '
        'TbLoan
        '
        Me.TbLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbLoan.Location = New System.Drawing.Point(376, 194)
        Me.TbLoan.Multiline = True
        Me.TbLoan.Name = "TbLoan"
        Me.TbLoan.Size = New System.Drawing.Size(125, 31)
        Me.TbLoan.TabIndex = 7
        Me.TbLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CbTerm
        '
        Me.CbTerm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTerm.FormattingEnabled = True
        Me.CbTerm.Location = New System.Drawing.Point(611, 204)
        Me.CbTerm.Name = "CbTerm"
        Me.CbTerm.Size = New System.Drawing.Size(121, 24)
        Me.CbTerm.TabIndex = 8
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.Color.Brown
        Me.BtnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(376, 320)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(150, 40)
        Me.BtnCalculate.TabIndex = 9
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Brown
        Me.BtnExit.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(376, 420)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(150, 40)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "Close"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'MonsterLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 512)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.CbTerm)
        Me.Controls.Add(Me.TbLoan)
        Me.Controls.Add(Me.ListMontlyPayments)
        Me.Controls.Add(Me.LbMonthly)
        Me.Controls.Add(Me.LbTerm)
        Me.Controls.Add(Me.LbLoan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LbMonsterLoanTitle)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MonsterLoan"
        Me.Text = "Monster Adventures"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents LbMonsterLoanTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LbLoan As Label
    Friend WithEvents LbTerm As Label
    Friend WithEvents LbMonthly As Label
    Friend WithEvents ListMontlyPayments As ListBox
    Friend WithEvents TbLoan As TextBox
    Friend WithEvents CbTerm As ComboBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnExit As Button
End Class
