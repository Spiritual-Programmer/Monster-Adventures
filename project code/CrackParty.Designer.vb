<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrackParty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        Me.LbNumberOfGuests = New System.Windows.Forms.Label()
        Me.TbNumberOfGuests = New System.Windows.Forms.TextBox()
        Me.LbTotalChargeTitle = New System.Windows.Forms.Label()
        Me.LbTotalCharge = New System.Windows.Forms.Label()
        Me.LbSpecies = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.btnGenerateTestData = New System.Windows.Forms.Button()
        Me.ListBoxSpecies = New System.Windows.Forms.ListBox()
        Me.LbGenerateTestData = New System.Windows.Forms.Label()
        Me.LbCrackTitle = New System.Windows.Forms.Label()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.CrackLounge
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(875, 515)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'LbNumberOfGuests
        '
        Me.LbNumberOfGuests.AutoSize = True
        Me.LbNumberOfGuests.BackColor = System.Drawing.Color.Transparent
        Me.LbNumberOfGuests.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumberOfGuests.ForeColor = System.Drawing.Color.White
        Me.LbNumberOfGuests.Location = New System.Drawing.Point(104, 223)
        Me.LbNumberOfGuests.Name = "LbNumberOfGuests"
        Me.LbNumberOfGuests.Size = New System.Drawing.Size(147, 23)
        Me.LbNumberOfGuests.TabIndex = 1
        Me.LbNumberOfGuests.Text = "Number of Guests:"
        '
        'TbNumberOfGuests
        '
        Me.TbNumberOfGuests.BackColor = System.Drawing.Color.Firebrick
        Me.TbNumberOfGuests.ForeColor = System.Drawing.Color.White
        Me.TbNumberOfGuests.Location = New System.Drawing.Point(124, 269)
        Me.TbNumberOfGuests.Multiline = True
        Me.TbNumberOfGuests.Name = "TbNumberOfGuests"
        Me.TbNumberOfGuests.Size = New System.Drawing.Size(80, 34)
        Me.TbNumberOfGuests.TabIndex = 2
        '
        'LbTotalChargeTitle
        '
        Me.LbTotalChargeTitle.BackColor = System.Drawing.Color.Transparent
        Me.LbTotalChargeTitle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalChargeTitle.ForeColor = System.Drawing.Color.White
        Me.LbTotalChargeTitle.Location = New System.Drawing.Point(120, 378)
        Me.LbTotalChargeTitle.Name = "LbTotalChargeTitle"
        Me.LbTotalChargeTitle.Size = New System.Drawing.Size(114, 25)
        Me.LbTotalChargeTitle.TabIndex = 3
        Me.LbTotalChargeTitle.Text = "Total Charge:"
        '
        'LbTotalCharge
        '
        Me.LbTotalCharge.BackColor = System.Drawing.Color.Firebrick
        Me.LbTotalCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalCharge.ForeColor = System.Drawing.Color.White
        Me.LbTotalCharge.Location = New System.Drawing.Point(121, 422)
        Me.LbTotalCharge.Name = "LbTotalCharge"
        Me.LbTotalCharge.Size = New System.Drawing.Size(105, 34)
        Me.LbTotalCharge.TabIndex = 4
        '
        'LbSpecies
        '
        Me.LbSpecies.BackColor = System.Drawing.Color.Transparent
        Me.LbSpecies.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSpecies.ForeColor = System.Drawing.Color.White
        Me.LbSpecies.Location = New System.Drawing.Point(406, 221)
        Me.LbSpecies.Name = "LbSpecies"
        Me.LbSpecies.Size = New System.Drawing.Size(54, 25)
        Me.LbSpecies.TabIndex = 5
        Me.LbSpecies.Text = "Type:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(477, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 41)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(293, 415)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(125, 41)
        Me.BtnCalculate.TabIndex = 7
        Me.BtnCalculate.Text = "&Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'btnGenerateTestData
        '
        Me.btnGenerateTestData.BackColor = System.Drawing.Color.Goldenrod
        Me.btnGenerateTestData.Font = New System.Drawing.Font("Comic Sans MS", 9.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateTestData.Location = New System.Drawing.Point(646, 415)
        Me.btnGenerateTestData.Name = "btnGenerateTestData"
        Me.btnGenerateTestData.Size = New System.Drawing.Size(148, 44)
        Me.btnGenerateTestData.TabIndex = 8
        Me.btnGenerateTestData.Text = "&Generate Test Data"
        Me.btnGenerateTestData.UseVisualStyleBackColor = False
        '
        'ListBoxSpecies
        '
        Me.ListBoxSpecies.BackColor = System.Drawing.Color.Firebrick
        Me.ListBoxSpecies.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSpecies.ForeColor = System.Drawing.Color.White
        Me.ListBoxSpecies.FormattingEnabled = True
        Me.ListBoxSpecies.ItemHeight = 18
        Me.ListBoxSpecies.Location = New System.Drawing.Point(369, 260)
        Me.ListBoxSpecies.Name = "ListBoxSpecies"
        Me.ListBoxSpecies.Size = New System.Drawing.Size(147, 130)
        Me.ListBoxSpecies.TabIndex = 9
        '
        'LbGenerateTestData
        '
        Me.LbGenerateTestData.BackColor = System.Drawing.Color.Transparent
        Me.LbGenerateTestData.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGenerateTestData.ForeColor = System.Drawing.Color.White
        Me.LbGenerateTestData.Location = New System.Drawing.Point(631, 192)
        Me.LbGenerateTestData.Name = "LbGenerateTestData"
        Me.LbGenerateTestData.Size = New System.Drawing.Size(173, 198)
        Me.LbGenerateTestData.TabIndex = 10
        '
        'LbCrackTitle
        '
        Me.LbCrackTitle.BackColor = System.Drawing.Color.Transparent
        Me.LbCrackTitle.Font = New System.Drawing.Font("Forte", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCrackTitle.Location = New System.Drawing.Point(226, 71)
        Me.LbCrackTitle.Name = "LbCrackTitle"
        Me.LbCrackTitle.Size = New System.Drawing.Size(423, 83)
        Me.LbCrackTitle.TabIndex = 11
        Me.LbCrackTitle.Text = "Hookah Party"
        '
        'CrackParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 508)
        Me.Controls.Add(Me.LbCrackTitle)
        Me.Controls.Add(Me.LbGenerateTestData)
        Me.Controls.Add(Me.ListBoxSpecies)
        Me.Controls.Add(Me.btnGenerateTestData)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.LbSpecies)
        Me.Controls.Add(Me.LbTotalCharge)
        Me.Controls.Add(Me.LbTotalChargeTitle)
        Me.Controls.Add(Me.TbNumberOfGuests)
        Me.Controls.Add(Me.LbNumberOfGuests)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CrackParty"
        Me.Text = "Monster Adventures"
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents LbNumberOfGuests As Label
    Friend WithEvents TbNumberOfGuests As TextBox
    Friend WithEvents LbTotalChargeTitle As Label
    Friend WithEvents LbTotalCharge As Label
    Friend WithEvents LbSpecies As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents btnGenerateTestData As Button
    Friend WithEvents ListBoxSpecies As ListBox
    Friend WithEvents LbGenerateTestData As Label
    Friend WithEvents LbCrackTitle As Label
End Class
