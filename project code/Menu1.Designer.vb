<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
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
        Me.LbMenu = New System.Windows.Forms.Label()
        Me.BtnStartOver = New System.Windows.Forms.Button()
        Me.BtnQuitGame = New System.Windows.Forms.Button()
        Me.BtnCloseMenu = New System.Windows.Forms.Button()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.backtiles
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(871, 508)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'LbMenu
        '
        Me.LbMenu.AutoSize = True
        Me.LbMenu.BackColor = System.Drawing.Color.Transparent
        Me.LbMenu.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMenu.ForeColor = System.Drawing.Color.Red
        Me.LbMenu.Location = New System.Drawing.Point(378, 52)
        Me.LbMenu.Name = "LbMenu"
        Me.LbMenu.Size = New System.Drawing.Size(114, 51)
        Me.LbMenu.TabIndex = 1
        Me.LbMenu.Text = "Menu"
        '
        'BtnStartOver
        '
        Me.BtnStartOver.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnStartOver.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartOver.ForeColor = System.Drawing.Color.White
        Me.BtnStartOver.Location = New System.Drawing.Point(317, 150)
        Me.BtnStartOver.Name = "BtnStartOver"
        Me.BtnStartOver.Size = New System.Drawing.Size(237, 57)
        Me.BtnStartOver.TabIndex = 2
        Me.BtnStartOver.Text = "Start Over"
        Me.BtnStartOver.UseVisualStyleBackColor = False
        '
        'BtnQuitGame
        '
        Me.BtnQuitGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnQuitGame.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitGame.ForeColor = System.Drawing.Color.White
        Me.BtnQuitGame.Location = New System.Drawing.Point(317, 263)
        Me.BtnQuitGame.Name = "BtnQuitGame"
        Me.BtnQuitGame.Size = New System.Drawing.Size(237, 57)
        Me.BtnQuitGame.TabIndex = 3
        Me.BtnQuitGame.Text = "Quit Game"
        Me.BtnQuitGame.UseVisualStyleBackColor = False
        '
        'BtnCloseMenu
        '
        Me.BtnCloseMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCloseMenu.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseMenu.ForeColor = System.Drawing.Color.White
        Me.BtnCloseMenu.Location = New System.Drawing.Point(317, 369)
        Me.BtnCloseMenu.Name = "BtnCloseMenu"
        Me.BtnCloseMenu.Size = New System.Drawing.Size(237, 57)
        Me.BtnCloseMenu.TabIndex = 4
        Me.BtnCloseMenu.Text = "Close Menu"
        Me.BtnCloseMenu.UseVisualStyleBackColor = False
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 501)
        Me.Controls.Add(Me.BtnCloseMenu)
        Me.Controls.Add(Me.BtnQuitGame)
        Me.Controls.Add(Me.BtnStartOver)
        Me.Controls.Add(Me.LbMenu)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Menu1"
        Me.Text = "Monster Adventures"
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents LbMenu As Label
    Friend WithEvents BtnStartOver As Button
    Friend WithEvents BtnQuitGame As Button
    Friend WithEvents BtnCloseMenu As Button
End Class
