<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.LBtitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btnstart = New System.Windows.Forms.Button()
        Me.Btnquit = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PBintroMonster = New System.Windows.Forms.PictureBox()
        Me.PBintroskull = New System.Windows.Forms.PictureBox()
        Me.PBintromonsterfly = New System.Windows.Forms.PictureBox()
        Me.pbstartbackground = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PBintroMonster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBintroskull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBintromonsterfly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbstartbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBtitle
        '
        Me.LBtitle.BackColor = System.Drawing.Color.Transparent
        Me.LBtitle.Font = New System.Drawing.Font("Snap ITC", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBtitle.ForeColor = System.Drawing.Color.Red
        Me.LBtitle.Location = New System.Drawing.Point(287, 2)
        Me.LBtitle.Name = "LBtitle"
        Me.LBtitle.Size = New System.Drawing.Size(320, 300)
        Me.LBtitle.TabIndex = 1
        Me.LBtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Btnstart
        '
        Me.Btnstart.BackColor = System.Drawing.Color.Black
        Me.Btnstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnstart.CausesValidation = False
        Me.Btnstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnstart.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnstart.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnstart.Location = New System.Drawing.Point(203, 385)
        Me.Btnstart.Name = "Btnstart"
        Me.Btnstart.Size = New System.Drawing.Size(145, 43)
        Me.Btnstart.TabIndex = 2
        Me.Btnstart.Text = "Start"
        Me.Btnstart.UseVisualStyleBackColor = False
        '
        'Btnquit
        '
        Me.Btnquit.BackColor = System.Drawing.Color.Black
        Me.Btnquit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnquit.CausesValidation = False
        Me.Btnquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnquit.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnquit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnquit.Location = New System.Drawing.Point(513, 385)
        Me.Btnquit.Name = "Btnquit"
        Me.Btnquit.Size = New System.Drawing.Size(145, 43)
        Me.Btnquit.TabIndex = 3
        Me.Btnquit.Text = "Quit"
        Me.Btnquit.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 200
        '
        'PBintroMonster
        '
        Me.PBintroMonster.BackColor = System.Drawing.Color.Transparent
        Me.PBintroMonster.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_devil_image_0172
        Me.PBintroMonster.Location = New System.Drawing.Point(645, 64)
        Me.PBintroMonster.Name = "PBintroMonster"
        Me.PBintroMonster.Size = New System.Drawing.Size(172, 149)
        Me.PBintroMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBintroMonster.TabIndex = 6
        Me.PBintroMonster.TabStop = False
        '
        'PBintroskull
        '
        Me.PBintroskull.BackColor = System.Drawing.Color.Transparent
        Me.PBintroskull.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.animated_monster_image_0190
        Me.PBintroskull.Location = New System.Drawing.Point(105, 64)
        Me.PBintroskull.Name = "PBintroskull"
        Me.PBintroskull.Size = New System.Drawing.Size(152, 149)
        Me.PBintroskull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBintroskull.TabIndex = 5
        Me.PBintroskull.TabStop = False
        '
        'PBintromonsterfly
        '
        Me.PBintromonsterfly.BackColor = System.Drawing.Color.Transparent
        Me.PBintromonsterfly.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.Monster
        Me.PBintromonsterfly.Location = New System.Drawing.Point(12, 270)
        Me.PBintromonsterfly.Name = "PBintromonsterfly"
        Me.PBintromonsterfly.Size = New System.Drawing.Size(881, 211)
        Me.PBintromonsterfly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBintromonsterfly.TabIndex = 4
        Me.PBintromonsterfly.TabStop = False
        '
        'pbstartbackground
        '
        Me.pbstartbackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.grey_tiles
        Me.pbstartbackground.Location = New System.Drawing.Point(1, 2)
        Me.pbstartbackground.Name = "pbstartbackground"
        Me.pbstartbackground.Size = New System.Drawing.Size(881, 522)
        Me.pbstartbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbstartbackground.TabIndex = 0
        Me.pbstartbackground.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(779, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Twilight Zone"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(670, 571)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Lava2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(883, 524)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PBintroMonster)
        Me.Controls.Add(Me.PBintroskull)
        Me.Controls.Add(Me.PBintromonsterfly)
        Me.Controls.Add(Me.Btnquit)
        Me.Controls.Add(Me.Btnstart)
        Me.Controls.Add(Me.LBtitle)
        Me.Controls.Add(Me.pbstartbackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.Opacity = 0.01R
        Me.ShowIcon = False
        Me.Text = "Monster Adventures"
        CType(Me.PBintroMonster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBintroskull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBintromonsterfly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbstartbackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbstartbackground As PictureBox
    Friend WithEvents LBtitle As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btnstart As Button
    Friend WithEvents Btnquit As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PBintromonsterfly As PictureBox
    Friend WithEvents PBintroskull As PictureBox
    Friend WithEvents PBintroMonster As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
