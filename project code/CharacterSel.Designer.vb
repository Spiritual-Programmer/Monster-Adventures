<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CharacterSel
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
        Me.Monster2 = New System.Windows.Forms.PictureBox()
        Me.Mainmonster = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Monster2RadBtn = New System.Windows.Forms.RadioButton()
        Me.Monster1RadBtn = New System.Windows.Forms.RadioButton()
        Me.LbChooseMonster = New System.Windows.Forms.Label()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monster2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mainmonster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.backtiles
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(871, 514)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 5
        Me.PbBackground.TabStop = False
        '
        'Monster2
        '
        Me.Monster2.BackColor = System.Drawing.Color.Transparent
        Me.Monster2.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0065
        Me.Monster2.Location = New System.Drawing.Point(165, 264)
        Me.Monster2.Name = "Monster2"
        Me.Monster2.Size = New System.Drawing.Size(129, 126)
        Me.Monster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Monster2.TabIndex = 6
        Me.Monster2.TabStop = False
        '
        'Mainmonster
        '
        Me.Mainmonster.BackColor = System.Drawing.Color.Transparent
        Me.Mainmonster.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0083
        Me.Mainmonster.Location = New System.Drawing.Point(165, 96)
        Me.Mainmonster.Name = "Mainmonster"
        Me.Mainmonster.Size = New System.Drawing.Size(129, 126)
        Me.Mainmonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mainmonster.TabIndex = 7
        Me.Mainmonster.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Crimson
        Me.btnOk.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(529, 431)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(147, 57)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Monster2RadBtn)
        Me.GroupBox1.Controls.Add(Me.Monster1RadBtn)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(441, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 294)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Monster2RadBtn
        '
        Me.Monster2RadBtn.AutoSize = True
        Me.Monster2RadBtn.Location = New System.Drawing.Point(20, 257)
        Me.Monster2RadBtn.Name = "Monster2RadBtn"
        Me.Monster2RadBtn.Size = New System.Drawing.Size(14, 13)
        Me.Monster2RadBtn.TabIndex = 1
        Me.Monster2RadBtn.TabStop = True
        Me.Monster2RadBtn.UseVisualStyleBackColor = True
        '
        'Monster1RadBtn
        '
        Me.Monster1RadBtn.AutoSize = True
        Me.Monster1RadBtn.Location = New System.Drawing.Point(20, 68)
        Me.Monster1RadBtn.Name = "Monster1RadBtn"
        Me.Monster1RadBtn.Size = New System.Drawing.Size(14, 13)
        Me.Monster1RadBtn.TabIndex = 0
        Me.Monster1RadBtn.TabStop = True
        Me.Monster1RadBtn.UseVisualStyleBackColor = True
        '
        'LbChooseMonster
        '
        Me.LbChooseMonster.AutoSize = True
        Me.LbChooseMonster.BackColor = System.Drawing.Color.Transparent
        Me.LbChooseMonster.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbChooseMonster.ForeColor = System.Drawing.Color.Red
        Me.LbChooseMonster.Location = New System.Drawing.Point(243, 19)
        Me.LbChooseMonster.Name = "LbChooseMonster"
        Me.LbChooseMonster.Size = New System.Drawing.Size(349, 45)
        Me.LbChooseMonster.TabIndex = 10
        Me.LbChooseMonster.Text = "Choose Your Monster"
        '
        'CharacterSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 511)
        Me.Controls.Add(Me.LbChooseMonster)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Mainmonster)
        Me.Controls.Add(Me.Monster2)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CharacterSel"
        Me.Text = "Monster Adventures"
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monster2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mainmonster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents Monster2 As PictureBox
    Friend WithEvents Mainmonster As PictureBox
    Friend WithEvents btnOk As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Monster2RadBtn As RadioButton
    Friend WithEvents Monster1RadBtn As RadioButton
    Friend WithEvents LbChooseMonster As Label
End Class
