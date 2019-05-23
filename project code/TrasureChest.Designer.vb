<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrasureChest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrasureChest))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtncloseTreasureChest = New System.Windows.Forms.Button()
        Me.BtnFindTreasure = New System.Windows.Forms.Button()
        Me.Pbindex = New System.Windows.Forms.PictureBox()
        Me.PbBackground = New System.Windows.Forms.PictureBox()
        CType(Me.Pbindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "potion.png")
        Me.ImageList1.Images.SetKeyName(1, "book.jpg")
        Me.ImageList1.Images.SetKeyName(2, "lightinggif.gif")
        '
        'BtncloseTreasureChest
        '
        Me.BtncloseTreasureChest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtncloseTreasureChest.Location = New System.Drawing.Point(394, 452)
        Me.BtncloseTreasureChest.Name = "BtncloseTreasureChest"
        Me.BtncloseTreasureChest.Size = New System.Drawing.Size(91, 39)
        Me.BtncloseTreasureChest.TabIndex = 3
        Me.BtncloseTreasureChest.Text = "Close"
        Me.BtncloseTreasureChest.UseVisualStyleBackColor = False
        '
        'BtnFindTreasure
        '
        Me.BtnFindTreasure.BackColor = System.Drawing.Color.Gold
        Me.BtnFindTreasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFindTreasure.Location = New System.Drawing.Point(310, 376)
        Me.BtnFindTreasure.Name = "BtnFindTreasure"
        Me.BtnFindTreasure.Size = New System.Drawing.Size(255, 56)
        Me.BtnFindTreasure.TabIndex = 4
        Me.BtnFindTreasure.Text = "Find Treasure"
        Me.BtnFindTreasure.UseVisualStyleBackColor = False
        '
        'Pbindex
        '
        Me.Pbindex.BackColor = System.Drawing.Color.Black
        Me.Pbindex.Location = New System.Drawing.Point(349, 97)
        Me.Pbindex.Name = "Pbindex"
        Me.Pbindex.Size = New System.Drawing.Size(176, 226)
        Me.Pbindex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbindex.TabIndex = 5
        Me.Pbindex.TabStop = False
        '
        'PbBackground
        '
        Me.PbBackground.Image = Global.VB_Final_Exam_Project.My.Resources.Resources.TreasureChest2
        Me.PbBackground.Location = New System.Drawing.Point(0, 0)
        Me.PbBackground.Name = "PbBackground"
        Me.PbBackground.Size = New System.Drawing.Size(875, 515)
        Me.PbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBackground.TabIndex = 0
        Me.PbBackground.TabStop = False
        '
        'TrasureChest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 515)
        Me.Controls.Add(Me.Pbindex)
        Me.Controls.Add(Me.BtnFindTreasure)
        Me.Controls.Add(Me.BtncloseTreasureChest)
        Me.Controls.Add(Me.PbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TrasureChest"
        Me.Text = "Monster Adventures"
        CType(Me.Pbindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbBackground As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BtncloseTreasureChest As System.Windows.Forms.Button
    Friend WithEvents BtnFindTreasure As System.Windows.Forms.Button
    Friend WithEvents Pbindex As System.Windows.Forms.PictureBox
End Class
