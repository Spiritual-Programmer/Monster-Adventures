<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextToSpeech
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
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        Me.TbSpeak = New System.Windows.Forms.TextBox()
        Me.BtnSpeak = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.blue_tiles
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(869, 515)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'TbSpeak
        '
        Me.TbSpeak.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSpeak.Location = New System.Drawing.Point(232, 121)
        Me.TbSpeak.Multiline = True
        Me.TbSpeak.Name = "TbSpeak"
        Me.TbSpeak.Size = New System.Drawing.Size(392, 295)
        Me.TbSpeak.TabIndex = 2
        Me.TbSpeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSpeak
        '
        Me.BtnSpeak.BackColor = System.Drawing.Color.Aqua
        Me.BtnSpeak.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSpeak.Location = New System.Drawing.Point(354, 49)
        Me.BtnSpeak.Name = "BtnSpeak"
        Me.BtnSpeak.Size = New System.Drawing.Size(143, 41)
        Me.BtnSpeak.TabIndex = 3
        Me.BtnSpeak.Text = "Speak"
        Me.BtnSpeak.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnExit.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(365, 454)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(111, 35)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TextToSpeech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 512)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSpeak)
        Me.Controls.Add(Me.TbSpeak)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TextToSpeech"
        Me.Text = "Monster Adventures"
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents TbSpeak As TextBox
    Friend WithEvents BtnSpeak As Button
    Friend WithEvents BtnExit As Button
End Class
