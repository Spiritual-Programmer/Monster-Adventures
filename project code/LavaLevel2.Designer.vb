<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LavaLevel2
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
        Me.LbInstructions1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SlowDown14 = New System.Windows.Forms.PictureBox()
        Me.SlowDown13 = New System.Windows.Forms.PictureBox()
        Me.SlowDown11 = New System.Windows.Forms.PictureBox()
        Me.SlowDown12 = New System.Windows.Forms.PictureBox()
        Me.SlowDown10 = New System.Windows.Forms.PictureBox()
        Me.SlowDown8 = New System.Windows.Forms.PictureBox()
        Me.SlowDown9 = New System.Windows.Forms.PictureBox()
        Me.SlowDown7 = New System.Windows.Forms.PictureBox()
        Me.SlowDown6 = New System.Windows.Forms.PictureBox()
        Me.SlowDown5 = New System.Windows.Forms.PictureBox()
        Me.SlowDown4 = New System.Windows.Forms.PictureBox()
        Me.SlowDown3 = New System.Windows.Forms.PictureBox()
        Me.SlowDown2 = New System.Windows.Forms.PictureBox()
        Me.SlowDown1 = New System.Windows.Forms.PictureBox()
        Me.LavaFall1 = New System.Windows.Forms.PictureBox()
        Me.WallBlock3 = New System.Windows.Forms.PictureBox()
        Me.WallBlock4 = New System.Windows.Forms.PictureBox()
        Me.WallBlock2 = New System.Windows.Forms.PictureBox()
        Me.WallBlock1 = New System.Windows.Forms.PictureBox()
        Me.WalkingMonster1 = New System.Windows.Forms.PictureBox()
        Me.Gem = New System.Windows.Forms.PictureBox()
        Me.Instructions1 = New System.Windows.Forms.PictureBox()
        Me.EntranceLavaLevel3 = New System.Windows.Forms.PictureBox()
        Me.MainMonster = New System.Windows.Forms.PictureBox()
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        Me.LbWellDone = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SlowDown14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlowDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LavaFall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WalkingMonster1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Instructions1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntranceLavaLevel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMonster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbScore
        '
        Me.LbScore.BackColor = System.Drawing.Color.Transparent
        Me.LbScore.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbScore.ForeColor = System.Drawing.Color.White
        Me.LbScore.Location = New System.Drawing.Point(28, 18)
        Me.LbScore.Name = "LbScore"
        Me.LbScore.Size = New System.Drawing.Size(133, 31)
        Me.LbScore.TabIndex = 11
        Me.LbScore.Text = "Score:  0"
        '
        'LbLives
        '
        Me.LbLives.BackColor = System.Drawing.Color.Transparent
        Me.LbLives.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLives.ForeColor = System.Drawing.Color.White
        Me.LbLives.Location = New System.Drawing.Point(28, 71)
        Me.LbLives.Name = "LbLives"
        Me.LbLives.Size = New System.Drawing.Size(133, 31)
        Me.LbLives.TabIndex = 12
        Me.LbLives.Text = "Lives:  3       "
        '
        'LbInstructions1
        '
        Me.LbInstructions1.BackColor = System.Drawing.Color.Tan
        Me.LbInstructions1.Location = New System.Drawing.Point(349, 9)
        Me.LbInstructions1.Name = "LbInstructions1"
        Me.LbInstructions1.Size = New System.Drawing.Size(133, 73)
        Me.LbInstructions1.TabIndex = 14
        Me.LbInstructions1.Text = "Level 2:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Obtain 2 Red Gems without encountering the Monster and falling into lav" &
    "a!"
        Me.LbInstructions1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'SlowDown14
        '
        Me.SlowDown14.BackColor = System.Drawing.Color.Coral
        Me.SlowDown14.Location = New System.Drawing.Point(673, 47)
        Me.SlowDown14.Name = "SlowDown14"
        Me.SlowDown14.Size = New System.Drawing.Size(18, 35)
        Me.SlowDown14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown14.TabIndex = 38
        Me.SlowDown14.TabStop = False
        Me.SlowDown14.Visible = False
        '
        'SlowDown13
        '
        Me.SlowDown13.BackColor = System.Drawing.Color.Coral
        Me.SlowDown13.Location = New System.Drawing.Point(634, 34)
        Me.SlowDown13.Name = "SlowDown13"
        Me.SlowDown13.Size = New System.Drawing.Size(57, 27)
        Me.SlowDown13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown13.TabIndex = 37
        Me.SlowDown13.TabStop = False
        Me.SlowDown13.Visible = False
        '
        'SlowDown11
        '
        Me.SlowDown11.BackColor = System.Drawing.Color.Coral
        Me.SlowDown11.Location = New System.Drawing.Point(357, 134)
        Me.SlowDown11.Name = "SlowDown11"
        Me.SlowDown11.Size = New System.Drawing.Size(19, 44)
        Me.SlowDown11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown11.TabIndex = 36
        Me.SlowDown11.TabStop = False
        Me.SlowDown11.Visible = False
        '
        'SlowDown12
        '
        Me.SlowDown12.BackColor = System.Drawing.Color.Coral
        Me.SlowDown12.Location = New System.Drawing.Point(251, 108)
        Me.SlowDown12.Name = "SlowDown12"
        Me.SlowDown12.Size = New System.Drawing.Size(19, 70)
        Me.SlowDown12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown12.TabIndex = 35
        Me.SlowDown12.TabStop = False
        Me.SlowDown12.Visible = False
        '
        'SlowDown10
        '
        Me.SlowDown10.BackColor = System.Drawing.Color.Coral
        Me.SlowDown10.Location = New System.Drawing.Point(287, 168)
        Me.SlowDown10.Name = "SlowDown10"
        Me.SlowDown10.Size = New System.Drawing.Size(89, 44)
        Me.SlowDown10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown10.TabIndex = 34
        Me.SlowDown10.TabStop = False
        Me.SlowDown10.Visible = False
        '
        'SlowDown8
        '
        Me.SlowDown8.BackColor = System.Drawing.Color.Coral
        Me.SlowDown8.Location = New System.Drawing.Point(388, 335)
        Me.SlowDown8.Name = "SlowDown8"
        Me.SlowDown8.Size = New System.Drawing.Size(57, 39)
        Me.SlowDown8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown8.TabIndex = 33
        Me.SlowDown8.TabStop = False
        Me.SlowDown8.Visible = False
        '
        'SlowDown9
        '
        Me.SlowDown9.BackColor = System.Drawing.Color.Coral
        Me.SlowDown9.Location = New System.Drawing.Point(357, 325)
        Me.SlowDown9.Name = "SlowDown9"
        Me.SlowDown9.Size = New System.Drawing.Size(88, 17)
        Me.SlowDown9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown9.TabIndex = 32
        Me.SlowDown9.TabStop = False
        Me.SlowDown9.Visible = False
        '
        'SlowDown7
        '
        Me.SlowDown7.BackColor = System.Drawing.Color.Coral
        Me.SlowDown7.Location = New System.Drawing.Point(687, 451)
        Me.SlowDown7.Name = "SlowDown7"
        Me.SlowDown7.Size = New System.Drawing.Size(72, 46)
        Me.SlowDown7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown7.TabIndex = 31
        Me.SlowDown7.TabStop = False
        Me.SlowDown7.Visible = False
        '
        'SlowDown6
        '
        Me.SlowDown6.BackColor = System.Drawing.Color.Coral
        Me.SlowDown6.Location = New System.Drawing.Point(638, 424)
        Me.SlowDown6.Name = "SlowDown6"
        Me.SlowDown6.Size = New System.Drawing.Size(53, 73)
        Me.SlowDown6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown6.TabIndex = 30
        Me.SlowDown6.TabStop = False
        Me.SlowDown6.Visible = False
        '
        'SlowDown5
        '
        Me.SlowDown5.BackColor = System.Drawing.Color.Coral
        Me.SlowDown5.Location = New System.Drawing.Point(536, 492)
        Me.SlowDown5.Name = "SlowDown5"
        Me.SlowDown5.Size = New System.Drawing.Size(263, 21)
        Me.SlowDown5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown5.TabIndex = 29
        Me.SlowDown5.TabStop = False
        Me.SlowDown5.Visible = False
        '
        'SlowDown4
        '
        Me.SlowDown4.BackColor = System.Drawing.Color.Coral
        Me.SlowDown4.Location = New System.Drawing.Point(142, 490)
        Me.SlowDown4.Name = "SlowDown4"
        Me.SlowDown4.Size = New System.Drawing.Size(57, 23)
        Me.SlowDown4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown4.TabIndex = 28
        Me.SlowDown4.TabStop = False
        Me.SlowDown4.Visible = False
        '
        'SlowDown3
        '
        Me.SlowDown3.BackColor = System.Drawing.Color.Coral
        Me.SlowDown3.Location = New System.Drawing.Point(0, 472)
        Me.SlowDown3.Name = "SlowDown3"
        Me.SlowDown3.Size = New System.Drawing.Size(102, 31)
        Me.SlowDown3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown3.TabIndex = 27
        Me.SlowDown3.TabStop = False
        Me.SlowDown3.Visible = False
        '
        'SlowDown2
        '
        Me.SlowDown2.BackColor = System.Drawing.Color.Coral
        Me.SlowDown2.Location = New System.Drawing.Point(0, 424)
        Me.SlowDown2.Name = "SlowDown2"
        Me.SlowDown2.Size = New System.Drawing.Size(33, 23)
        Me.SlowDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown2.TabIndex = 26
        Me.SlowDown2.TabStop = False
        Me.SlowDown2.Visible = False
        '
        'SlowDown1
        '
        Me.SlowDown1.BackColor = System.Drawing.Color.Coral
        Me.SlowDown1.Location = New System.Drawing.Point(0, 451)
        Me.SlowDown1.Name = "SlowDown1"
        Me.SlowDown1.Size = New System.Drawing.Size(234, 23)
        Me.SlowDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlowDown1.TabIndex = 25
        Me.SlowDown1.TabStop = False
        Me.SlowDown1.Visible = False
        '
        'LavaFall1
        '
        Me.LavaFall1.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.LavaFall1.Location = New System.Drawing.Point(579, 82)
        Me.LavaFall1.Name = "LavaFall1"
        Me.LavaFall1.Size = New System.Drawing.Size(61, 57)
        Me.LavaFall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LavaFall1.TabIndex = 24
        Me.LavaFall1.TabStop = False
        Me.LavaFall1.Visible = False
        '
        'WallBlock3
        '
        Me.WallBlock3.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock3.Location = New System.Drawing.Point(877, 3)
        Me.WallBlock3.Name = "WallBlock3"
        Me.WallBlock3.Size = New System.Drawing.Size(3, 527)
        Me.WallBlock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock3.TabIndex = 23
        Me.WallBlock3.TabStop = False
        Me.WallBlock3.Visible = False
        '
        'WallBlock4
        '
        Me.WallBlock4.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock4.Location = New System.Drawing.Point(0, 519)
        Me.WallBlock4.Name = "WallBlock4"
        Me.WallBlock4.Size = New System.Drawing.Size(881, 3)
        Me.WallBlock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock4.TabIndex = 22
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
        Me.WallBlock2.TabIndex = 21
        Me.WallBlock2.TabStop = False
        Me.WallBlock2.Visible = False
        '
        'WallBlock1
        '
        Me.WallBlock1.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock1.Location = New System.Drawing.Point(0, -14)
        Me.WallBlock1.Name = "WallBlock1"
        Me.WallBlock1.Size = New System.Drawing.Size(5, 527)
        Me.WallBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock1.TabIndex = 19
        Me.WallBlock1.TabStop = False
        Me.WallBlock1.Visible = False
        '
        'WalkingMonster1
        '
        Me.WalkingMonster1.BackColor = System.Drawing.Color.Transparent
        Me.WalkingMonster1.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0007
        Me.WalkingMonster1.Location = New System.Drawing.Point(616, 281)
        Me.WalkingMonster1.Name = "WalkingMonster1"
        Me.WalkingMonster1.Size = New System.Drawing.Size(84, 93)
        Me.WalkingMonster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WalkingMonster1.TabIndex = 18
        Me.WalkingMonster1.TabStop = False
        '
        'Gem
        '
        Me.Gem.BackColor = System.Drawing.Color.Transparent
        Me.Gem.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_diamond_and_gem_image_0002
        Me.Gem.Location = New System.Drawing.Point(395, 229)
        Me.Gem.Name = "Gem"
        Me.Gem.Size = New System.Drawing.Size(19, 21)
        Me.Gem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Gem.TabIndex = 17
        Me.Gem.TabStop = False
        '
        'Instructions1
        '
        Me.Instructions1.Location = New System.Drawing.Point(395, 229)
        Me.Instructions1.Name = "Instructions1"
        Me.Instructions1.Size = New System.Drawing.Size(28, 33)
        Me.Instructions1.TabIndex = 16
        Me.Instructions1.TabStop = False
        Me.Instructions1.Visible = False
        '
        'EntranceLavaLevel3
        '
        Me.EntranceLavaLevel3.BackColor = System.Drawing.Color.Transparent
        Me.EntranceLavaLevel3.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_effect_image_0065
        Me.EntranceLavaLevel3.Location = New System.Drawing.Point(916, 207)
        Me.EntranceLavaLevel3.Name = "EntranceLavaLevel3"
        Me.EntranceLavaLevel3.Size = New System.Drawing.Size(68, 78)
        Me.EntranceLavaLevel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EntranceLavaLevel3.TabIndex = 15
        Me.EntranceLavaLevel3.TabStop = False
        Me.EntranceLavaLevel3.Visible = False
        '
        'MainMonster
        '
        Me.MainMonster.BackColor = System.Drawing.Color.Transparent
        Me.MainMonster.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0083
        Me.MainMonster.Location = New System.Drawing.Point(12, 207)
        Me.MainMonster.Name = "MainMonster"
        Me.MainMonster.Size = New System.Drawing.Size(35, 32)
        Me.MainMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainMonster.TabIndex = 13
        Me.MainMonster.TabStop = False
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.second_lava_3
        Me.PbBackground.Location = New System.Drawing.Point(0, -1)
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
        Me.LbWellDone.Location = New System.Drawing.Point(169, 9)
        Me.LbWellDone.Name = "LbWellDone"
        Me.LbWellDone.Size = New System.Drawing.Size(689, 74)
        Me.LbWellDone.TabIndex = 39
        Me.LbWellDone.Text = "                                     "
        Me.LbWellDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbWellDone.Visible = False
        '
        'Timer2
        '
        '
        'LavaLevel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 509)
        Me.Controls.Add(Me.LbWellDone)
        Me.Controls.Add(Me.SlowDown14)
        Me.Controls.Add(Me.SlowDown13)
        Me.Controls.Add(Me.SlowDown11)
        Me.Controls.Add(Me.SlowDown12)
        Me.Controls.Add(Me.SlowDown10)
        Me.Controls.Add(Me.SlowDown8)
        Me.Controls.Add(Me.SlowDown9)
        Me.Controls.Add(Me.SlowDown7)
        Me.Controls.Add(Me.SlowDown6)
        Me.Controls.Add(Me.SlowDown5)
        Me.Controls.Add(Me.SlowDown4)
        Me.Controls.Add(Me.SlowDown3)
        Me.Controls.Add(Me.SlowDown2)
        Me.Controls.Add(Me.SlowDown1)
        Me.Controls.Add(Me.LavaFall1)
        Me.Controls.Add(Me.WallBlock3)
        Me.Controls.Add(Me.WallBlock4)
        Me.Controls.Add(Me.WallBlock2)
        Me.Controls.Add(Me.WallBlock1)
        Me.Controls.Add(Me.WalkingMonster1)
        Me.Controls.Add(Me.Gem)
        Me.Controls.Add(Me.Instructions1)
        Me.Controls.Add(Me.EntranceLavaLevel3)
        Me.Controls.Add(Me.LbInstructions1)
        Me.Controls.Add(Me.MainMonster)
        Me.Controls.Add(Me.LbLives)
        Me.Controls.Add(Me.LbScore)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LavaLevel2"
        Me.Text = "Monster Adventures"
        CType(Me.SlowDown14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlowDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LavaFall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WalkingMonster1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Instructions1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntranceLavaLevel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMonster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents LbScore As Label
    Friend WithEvents LbLives As Label
    Friend WithEvents MainMonster As PictureBox
    Friend WithEvents LbInstructions1 As Label
    Friend WithEvents EntranceLavaLevel3 As PictureBox
    Friend WithEvents Instructions1 As PictureBox
    Friend WithEvents Gem As PictureBox
    Friend WithEvents WalkingMonster1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WallBlock1 As PictureBox
    Friend WithEvents WallBlock2 As PictureBox
    Friend WithEvents WallBlock4 As PictureBox
    Friend WithEvents WallBlock3 As PictureBox
    Friend WithEvents LavaFall1 As PictureBox
    Friend WithEvents SlowDown1 As PictureBox
    Friend WithEvents SlowDown2 As PictureBox
    Friend WithEvents SlowDown3 As PictureBox
    Friend WithEvents SlowDown4 As PictureBox
    Friend WithEvents SlowDown5 As PictureBox
    Friend WithEvents SlowDown6 As PictureBox
    Friend WithEvents SlowDown7 As PictureBox
    Friend WithEvents SlowDown9 As PictureBox
    Friend WithEvents SlowDown8 As PictureBox
    Friend WithEvents SlowDown10 As PictureBox
    Friend WithEvents SlowDown12 As PictureBox
    Friend WithEvents SlowDown11 As PictureBox
    Friend WithEvents SlowDown13 As PictureBox
    Friend WithEvents SlowDown14 As PictureBox
    Friend WithEvents LbWellDone As Label
    Friend WithEvents Timer2 As Timer
End Class
