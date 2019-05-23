<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Phantum
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
        Me.WallBlock4 = New System.Windows.Forms.PictureBox()
        Me.WallBlock2 = New System.Windows.Forms.PictureBox()
        Me.WallBlock3 = New System.Windows.Forms.PictureBox()
        Me.WallBlock1 = New System.Windows.Forms.PictureBox()
        Me.MainMonster = New System.Windows.Forms.PictureBox()
        Me.Portal = New System.Windows.Forms.PictureBox()
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.WallBlock4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMonster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WallBlock4
        '
        Me.WallBlock4.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock4.Location = New System.Drawing.Point(8, 491)
        Me.WallBlock4.Name = "WallBlock4"
        Me.WallBlock4.Size = New System.Drawing.Size(669, 5)
        Me.WallBlock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock4.TabIndex = 6
        Me.WallBlock4.TabStop = False
        Me.WallBlock4.Visible = False
        '
        'WallBlock2
        '
        Me.WallBlock2.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock2.Location = New System.Drawing.Point(-3, -2)
        Me.WallBlock2.Name = "WallBlock2"
        Me.WallBlock2.Size = New System.Drawing.Size(669, 5)
        Me.WallBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock2.TabIndex = 5
        Me.WallBlock2.TabStop = False
        Me.WallBlock2.Visible = False
        '
        'WallBlock3
        '
        Me.WallBlock3.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock3.Location = New System.Drawing.Point(655, -39)
        Me.WallBlock3.Name = "WallBlock3"
        Me.WallBlock3.Size = New System.Drawing.Size(5, 535)
        Me.WallBlock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock3.TabIndex = 4
        Me.WallBlock3.TabStop = False
        Me.WallBlock3.Visible = False
        '
        'WallBlock1
        '
        Me.WallBlock1.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.red
        Me.WallBlock1.Location = New System.Drawing.Point(-3, -39)
        Me.WallBlock1.Name = "WallBlock1"
        Me.WallBlock1.Size = New System.Drawing.Size(5, 535)
        Me.WallBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallBlock1.TabIndex = 3
        Me.WallBlock1.TabStop = False
        Me.WallBlock1.Visible = False
        '
        'MainMonster
        '
        Me.MainMonster.BackColor = System.Drawing.Color.Transparent
        Me.MainMonster.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0083
        Me.MainMonster.Location = New System.Drawing.Point(296, 214)
        Me.MainMonster.Name = "MainMonster"
        Me.MainMonster.Size = New System.Drawing.Size(35, 32)
        Me.MainMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainMonster.TabIndex = 2
        Me.MainMonster.TabStop = False
        '
        'Portal
        '
        Me.Portal.BackColor = System.Drawing.Color.Transparent
        Me.Portal.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_effect_image_0062
        Me.Portal.Location = New System.Drawing.Point(39, 26)
        Me.Portal.Name = "Portal"
        Me.Portal.Size = New System.Drawing.Size(62, 53)
        Me.Portal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Portal.TabIndex = 1
        Me.Portal.TabStop = False
        '
        'PbBackground
        '
        Me.PbBackground.BackColor = System.Drawing.Color.Black
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_effect_image_0063
        Me.PbBackground.Location = New System.Drawing.Point(-112, -77)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(876, 660)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'Phantum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(654, 483)
        Me.Controls.Add(Me.WallBlock4)
        Me.Controls.Add(Me.WallBlock2)
        Me.Controls.Add(Me.WallBlock3)
        Me.Controls.Add(Me.WallBlock1)
        Me.Controls.Add(Me.MainMonster)
        Me.Controls.Add(Me.Portal)
        Me.Controls.Add(Me.PbBackground)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Phantum"
        Me.Text = "Monster Adventures"
        CType(Me.WallBlock4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMonster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents Portal As PictureBox
    Friend WithEvents MainMonster As PictureBox
    Friend WithEvents WallBlock1 As PictureBox
    Friend WithEvents WallBlock3 As PictureBox
    Friend WithEvents WallBlock2 As PictureBox
    Friend WithEvents WallBlock4 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
