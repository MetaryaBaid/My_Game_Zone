<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RockPaperScissor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PlayerLabel = New System.Windows.Forms.Label()
        Me.PlayerScoreLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CompLabel = New System.Windows.Forms.Label()
        Me.CompScoreLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RockButton = New System.Windows.Forms.Button()
        Me.PaperButton = New System.Windows.Forms.Button()
        Me.ScissorButton = New System.Windows.Forms.Button()
        Me.RockLabel = New System.Windows.Forms.Label()
        Me.PaperLabel = New System.Windows.Forms.Label()
        Me.ScissorLabel = New System.Windows.Forms.Label()
        Me.PlayerPos = New System.Windows.Forms.Label()
        Me.CompPos = New System.Windows.Forms.Label()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.AnnouncementLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PlayerLabel)
        Me.GroupBox1.Controls.Add(Me.PlayerScoreLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "You"
        '
        'PlayerLabel
        '
        Me.PlayerLabel.BackColor = System.Drawing.Color.IndianRed
        Me.PlayerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlayerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerLabel.Location = New System.Drawing.Point(6, 19)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(191, 135)
        Me.PlayerLabel.TabIndex = 4
        Me.PlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerScoreLabel
        '
        Me.PlayerScoreLabel.BackColor = System.Drawing.Color.Salmon
        Me.PlayerScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerScoreLabel.Location = New System.Drawing.Point(6, 157)
        Me.PlayerScoreLabel.Name = "PlayerScoreLabel"
        Me.PlayerScoreLabel.Size = New System.Drawing.Size(188, 73)
        Me.PlayerScoreLabel.TabIndex = 3
        Me.PlayerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CompLabel)
        Me.GroupBox2.Controls.Add(Me.CompScoreLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(514, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 233)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Computer"
        '
        'CompLabel
        '
        Me.CompLabel.BackColor = System.Drawing.Color.IndianRed
        Me.CompLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompLabel.Location = New System.Drawing.Point(6, 19)
        Me.CompLabel.Name = "CompLabel"
        Me.CompLabel.Size = New System.Drawing.Size(191, 135)
        Me.CompLabel.TabIndex = 5
        Me.CompLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompScoreLabel
        '
        Me.CompScoreLabel.BackColor = System.Drawing.Color.LightCoral
        Me.CompScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CompScoreLabel.Location = New System.Drawing.Point(6, 157)
        Me.CompScoreLabel.Name = "CompScoreLabel"
        Me.CompScoreLabel.Size = New System.Drawing.Size(188, 73)
        Me.CompScoreLabel.TabIndex = 1
        Me.CompScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(73, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(641, 57)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Player VS Computer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RockButton
        '
        Me.RockButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RockButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RockButton.Location = New System.Drawing.Point(179, 407)
        Me.RockButton.Name = "RockButton"
        Me.RockButton.Size = New System.Drawing.Size(85, 21)
        Me.RockButton.TabIndex = 2
        Me.RockButton.Text = "Rock"
        Me.RockButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RockButton.UseVisualStyleBackColor = False
        '
        'PaperButton
        '
        Me.PaperButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PaperButton.Location = New System.Drawing.Point(356, 407)
        Me.PaperButton.Name = "PaperButton"
        Me.PaperButton.Size = New System.Drawing.Size(85, 21)
        Me.PaperButton.TabIndex = 3
        Me.PaperButton.Text = "Paper"
        Me.PaperButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PaperButton.UseVisualStyleBackColor = True
        '
        'ScissorButton
        '
        Me.ScissorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ScissorButton.Location = New System.Drawing.Point(520, 407)
        Me.ScissorButton.Name = "ScissorButton"
        Me.ScissorButton.Size = New System.Drawing.Size(85, 21)
        Me.ScissorButton.TabIndex = 4
        Me.ScissorButton.Text = "Scissor"
        Me.ScissorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ScissorButton.UseVisualStyleBackColor = True
        '
        'RockLabel
        '
        Me.RockLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RockLabel.Location = New System.Drawing.Point(179, 333)
        Me.RockLabel.Name = "RockLabel"
        Me.RockLabel.Size = New System.Drawing.Size(85, 68)
        Me.RockLabel.TabIndex = 9
        Me.RockLabel.Text = "👊"
        Me.RockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaperLabel
        '
        Me.PaperLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PaperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaperLabel.Location = New System.Drawing.Point(356, 333)
        Me.PaperLabel.Name = "PaperLabel"
        Me.PaperLabel.Size = New System.Drawing.Size(85, 68)
        Me.PaperLabel.TabIndex = 10
        Me.PaperLabel.Text = "✋"
        Me.PaperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScissorLabel
        '
        Me.ScissorLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ScissorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScissorLabel.Location = New System.Drawing.Point(520, 333)
        Me.ScissorLabel.Name = "ScissorLabel"
        Me.ScissorLabel.Size = New System.Drawing.Size(85, 68)
        Me.ScissorLabel.TabIndex = 11
        Me.ScissorLabel.Text = "✌️"
        Me.ScissorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerPos
        '
        Me.PlayerPos.Location = New System.Drawing.Point(276, 143)
        Me.PlayerPos.Name = "PlayerPos"
        Me.PlayerPos.Size = New System.Drawing.Size(75, 80)
        Me.PlayerPos.TabIndex = 12
        Me.PlayerPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompPos
        '
        Me.CompPos.Location = New System.Drawing.Point(440, 143)
        Me.CompPos.Name = "CompPos"
        Me.CompPos.Size = New System.Drawing.Size(68, 80)
        Me.CompPos.TabIndex = 13
        Me.CompPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'TimerLabel
        '
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(357, 159)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(74, 64)
        Me.TimerLabel.TabIndex = 14
        Me.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(356, 226)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(75, 23)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play!"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'AnnouncementLabel
        '
        Me.AnnouncementLabel.BackColor = System.Drawing.Color.Firebrick
        Me.AnnouncementLabel.Location = New System.Drawing.Point(279, 88)
        Me.AnnouncementLabel.Name = "AnnouncementLabel"
        Me.AnnouncementLabel.Size = New System.Drawing.Size(229, 23)
        Me.AnnouncementLabel.TabIndex = 16
        Me.AnnouncementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(724, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RockPaperScissor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AnnouncementLabel)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.CompPos)
        Me.Controls.Add(Me.PlayerPos)
        Me.Controls.Add(Me.ScissorLabel)
        Me.Controls.Add(Me.PaperLabel)
        Me.Controls.Add(Me.RockLabel)
        Me.Controls.Add(Me.ScissorButton)
        Me.Controls.Add(Me.PaperButton)
        Me.Controls.Add(Me.RockButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "RockPaperScissor"
        Me.Text = "RockPaperScissor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PlayerScoreLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CompScoreLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RockButton As Button
    Friend WithEvents PaperButton As Button
    Friend WithEvents ScissorButton As Button
    Friend WithEvents PlayerLabel As Label
    Friend WithEvents CompLabel As Label
    Friend WithEvents RockLabel As Label
    Friend WithEvents PaperLabel As Label
    Friend WithEvents ScissorLabel As Label
    Friend WithEvents PlayerPos As Label
    Friend WithEvents CompPos As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents TimerLabel As Label
    Friend WithEvents PlayButton As Button
    Friend WithEvents AnnouncementLabel As Label
    Friend WithEvents Button1 As Button
End Class
