<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Lbinstructions = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbInstructionsTitle = New System.Windows.Forms.Label()
        Me.Btnnext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbinstructions
        '
        Me.Lbinstructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbinstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbinstructions.ForeColor = System.Drawing.Color.White
        Me.Lbinstructions.Location = New System.Drawing.Point(233, 105)
        Me.Lbinstructions.Name = "Lbinstructions"
        Me.Lbinstructions.Size = New System.Drawing.Size(432, 324)
        Me.Lbinstructions.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LbInstructionsTitle
        '
        Me.LbInstructionsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstructionsTitle.ForeColor = System.Drawing.Color.Red
        Me.LbInstructionsTitle.Location = New System.Drawing.Point(290, 22)
        Me.LbInstructionsTitle.Name = "LbInstructionsTitle"
        Me.LbInstructionsTitle.Size = New System.Drawing.Size(319, 43)
        Me.LbInstructionsTitle.TabIndex = 1
        Me.LbInstructionsTitle.Text = "Welcome"
        Me.LbInstructionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnnext
        '
        Me.Btnnext.BackColor = System.Drawing.Color.DarkRed
        Me.Btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnext.ForeColor = System.Drawing.Color.White
        Me.Btnnext.Location = New System.Drawing.Point(533, 422)
        Me.Btnnext.Name = "Btnnext"
        Me.Btnnext.Size = New System.Drawing.Size(144, 54)
        Me.Btnnext.TabIndex = 2
        Me.Btnnext.Text = "Next"
        Me.Btnnext.UseVisualStyleBackColor = False
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(877, 521)
        Me.Controls.Add(Me.Btnnext)
        Me.Controls.Add(Me.LbInstructionsTitle)
        Me.Controls.Add(Me.Lbinstructions)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WelcomeForm"
        Me.ShowIcon = False
        Me.Text = "Monster Adventures"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbinstructions As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LbInstructionsTitle As Label
    Friend WithEvents Btnnext As Button
End Class
