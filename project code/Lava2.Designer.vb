<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lava2
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
        Me.components = New System.ComponentModel.Container()
        Me.LbScore = New System.Windows.Forms.Label()
        Me.LbLives = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbInstructions1 = New System.Windows.Forms.Label()
        Me.Instructions1 = New System.Windows.Forms.PictureBox()
        Me.Gem = New System.Windows.Forms.PictureBox()
        Me.WalkingMonster1 = New System.Windows.Forms.PictureBox()
        Me.MainMonster = New System.Windows.Forms.PictureBox()
        Me.EntranceLavaLevel2 = New System.Windows.Forms.PictureBox()
        Me.WallBlock3 = New System.Windows.Forms.PictureBox()
        Me.WallBlock1 = New System.Windows.Forms.PictureBox()
        Me.WallBlock4 = New System.Windows.Forms.PictureBox()
        Me.WallBlock2 = New System.Windows.Forms.PictureBox()
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        Me.LbWellDone = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Instructions1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WalkingMonster1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMonster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntranceLavaLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbScore
        '
        Me.LbScore.BackColor = System.Drawing.Color.Transparent
        Me.LbScore.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbScore.ForeColor = System.Drawing.Color.White
        Me.LbScore.Location = New System.Drawing.Point(28, 20)
        Me.LbScore.Name = "LbScore"
        Me.LbScore.Size = New System.Drawing.Size(109, 31)
        Me.LbScore.TabIndex = 10
        Me.LbScore.Text = "Score:  0"
        '
        'LbLives
        '
        Me.LbLives.BackColor = System.Drawing.Color.Transparent
        Me.LbLives.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLives.ForeColor = System.Drawing.Color.White
        Me.LbLives.Location = New System.Drawing.Point(28, 73)
        Me.LbLives.Name = "LbLives"
        Me.LbLives.Size = New System.Drawing.Size(109, 31)
        Me.LbLives.TabIndex = 11
        Me.LbLives.Text = "Lives:  3       "
        '
        'Timer1
        '
        '
        'LbInstructions1
        '
        Me.LbInstructions1.BackColor = System.Drawing.Color.Tan
        Me.LbInstructions1.Location = New System.Drawing.Point(376, 9)
        Me.LbInstructions1.Name = "LbInstructions1"
        Me.LbInstructions1.Size = New System.Drawing.Size(122, 64)
        Me.LbInstructions1.TabIndex = 13
        Me.LbInstructions1.Text = "Level 1:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Obtain 5 Red Gems without encountering the Monster!"
        Me.LbInstructions1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Instructions1
        '
        Me.Instructions1.Location = New System.Drawing.Point(396, 214)
        Me.Instructions1.Name = "Instructions1"
        Me.Instructions1.Size = New System.Drawing.Size(28, 33)
        Me.Instructions1.TabIndex = 12
        Me.Instructions1.TabStop = False
        Me.Instructions1.Visible = False
        '
        'Gem
        '
        Me.Gem.BackColor = System.Drawing.Color.Transparent
        Me.Gem.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_diamond_and_gem_image_0002
        Me.Gem.Location = New System.Drawing.Point(396, 226)
        Me.Gem.Name = "Gem"
        Me.Gem.Size = New System.Drawing.Size(19, 21)
        Me.Gem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Gem.TabIndex = 9
        Me.Gem.TabStop = False
        '
        'WalkingMonster1
        '
        Me.WalkingMonster1.BackColor = System.Drawing.Color.Transparent
        Me.WalkingMonster1.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0007
        Me.WalkingMonster1.Location = New System.Drawing.Point(663, 384)
        Me.WalkingMonster1.Name = "WalkingMonster1"
        Me.WalkingMonster1.Size = New System.Drawing.Size(84, 93)
        Me.WalkingMonster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WalkingMonster1.TabIndex = 8
        Me.WalkingMonster1.TabStop = False
        '
        'MainMonster
        '
        Me.MainMonster.BackColor = System.Drawing.Color.Transparent
        Me.MainMonster.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0083
        Me.MainMonster.Location = New System.Drawing.Point(32, 215)
        Me.MainMonster.Name = "MainMonster"
        Me.MainMonster.Size = New System.Drawing.Size(35, 32)
        Me.MainMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainMonster.TabIndex = 7
        Me.MainMonster.TabStop = False
        '
        'EntranceLavaLevel2
        '
        Me.EntranceLavaLevel2.BackColor = System.Drawing.Color.Transparent
        Me.EntranceLavaLevel2.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_effect_image_0065
        Me.EntranceLavaLevel2.Location = New System.Drawing.Point(903, 184)
        Me.EntranceLavaLevel2.Name = "EntranceLavaLevel2"
        Me.EntranceLavaLevel2.Size = New System.Drawing.Size(68, 78)
        Me.EntranceLavaLevel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EntranceLavaLevel2.TabIndex = 6
        Me.EntranceLavaLevel2.TabStop = False
        Me.EntranceLavaLevel2.Visible = False
        '
        'WallBlock3
        '
        Me.WallBlock3.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock3.Location = New System.Drawing.Point(868, 0)
        Me.WallBlock3.Name = "WallBlock3"
        Me.WallBlock3.Size = New System.Drawing.Size(3, 527)
        Me.WallBlock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock3.TabIndex = 4
        Me.WallBlock3.TabStop = False
        Me.WallBlock3.Visible = False
        '
        'WallBlock1
        '
        Me.WallBlock1.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock1.Location = New System.Drawing.Point(0, 0)
        Me.WallBlock1.Name = "WallBlock1"
        Me.WallBlock1.Size = New System.Drawing.Size(5, 527)
        Me.WallBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock1.TabIndex = 3
        Me.WallBlock1.TabStop = False
        Me.WallBlock1.Visible = False
        '
        'WallBlock4
        '
        Me.WallBlock4.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock4.Location = New System.Drawing.Point(-5, 511)
        Me.WallBlock4.Name = "WallBlock4"
        Me.WallBlock4.Size = New System.Drawing.Size(881, 3)
        Me.WallBlock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock4.TabIndex = 2
        Me.WallBlock4.TabStop = False
        Me.WallBlock4.Visible = False
        '
        'WallBlock2
        '
        Me.WallBlock2.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock2.Location = New System.Drawing.Point(-5, 0)
        Me.WallBlock2.Name = "WallBlock2"
        Me.WallBlock2.Size = New System.Drawing.Size(881, 3)
        Me.WallBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock2.TabIndex = 1
        Me.WallBlock2.TabStop = False
        Me.WallBlock2.Visible = False
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.map
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(871, 514)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'LbWellDone
        '
        Me.LbWellDone.BackColor = System.Drawing.Color.Transparent
        Me.LbWellDone.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbWellDone.ForeColor = System.Drawing.Color.OrangeRed
        Me.LbWellDone.Location = New System.Drawing.Point(153, 9)
        Me.LbWellDone.Name = "LbWellDone"
        Me.LbWellDone.Size = New System.Drawing.Size(689, 74)
        Me.LbWellDone.TabIndex = 14
        Me.LbWellDone.Text = "                                     "
        Me.LbWellDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbWellDone.Visible = False
        '
        'Timer2
        '
        '
        'Lava2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 512)
        Me.Controls.Add(Me.LbWellDone)
        Me.Controls.Add(Me.LbInstructions1)
        Me.Controls.Add(Me.Instructions1)
        Me.Controls.Add(Me.LbLives)
        Me.Controls.Add(Me.LbScore)
        Me.Controls.Add(Me.Gem)
        Me.Controls.Add(Me.WalkingMonster1)
        Me.Controls.Add(Me.MainMonster)
        Me.Controls.Add(Me.EntranceLavaLevel2)
        Me.Controls.Add(Me.WallBlock3)
        Me.Controls.Add(Me.WallBlock1)
        Me.Controls.Add(Me.WallBlock4)
        Me.Controls.Add(Me.WallBlock2)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Lava2"
        Me.Text = "Monster Adventures"
        CType(Me.Instructions1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WalkingMonster1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMonster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntranceLavaLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents WallBlock2 As PictureBox
    Friend WithEvents WallBlock4 As PictureBox
    Friend WithEvents WallBlock1 As PictureBox
    Friend WithEvents WallBlock3 As PictureBox
    Friend WithEvents EntranceLavaLevel2 As PictureBox
    Friend WithEvents MainMonster As PictureBox
    Friend WithEvents WalkingMonster1 As PictureBox
    Friend WithEvents Gem As PictureBox
    Friend WithEvents LbScore As Label
    Friend WithEvents LbLives As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Instructions1 As PictureBox
    Friend WithEvents LbInstructions1 As Label
    Friend WithEvents LbWellDone As Label
    Friend WithEvents Timer2 As Timer
End Class
