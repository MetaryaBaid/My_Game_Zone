<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartScreen))
        Me.TMGStartButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.TG4x4_Image = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RPSStartButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TG4x4_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TMGStartButton
        '
        Me.TMGStartButton.AutoSize = True
        Me.TMGStartButton.BackColor = System.Drawing.Color.Gold
        Me.TMGStartButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TMGStartButton.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMGStartButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.TMGStartButton.Location = New System.Drawing.Point(3, 112)
        Me.TMGStartButton.Name = "TMGStartButton"
        Me.TMGStartButton.Size = New System.Drawing.Size(189, 26)
        Me.TMGStartButton.TabIndex = 0
        Me.TMGStartButton.Text = "Tile Matching Games"
        Me.TMGStartButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(42, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to the 'My Game Zone' !"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(42, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Choose any of the games you want to play!"
        '
        'Close_Button
        '
        Me.Close_Button.AutoSize = True
        Me.Close_Button.Location = New System.Drawing.Point(747, 451)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(75, 23)
        Me.Close_Button.TabIndex = 3
        Me.Close_Button.Text = " Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'TG4x4_Image
        '
        Me.TG4x4_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TG4x4_Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG4x4_Image.Image = CType(resources.GetObject("TG4x4_Image.Image"), System.Drawing.Image)
        Me.TG4x4_Image.ImageLocation = ""
        Me.TG4x4_Image.Location = New System.Drawing.Point(3, 3)
        Me.TG4x4_Image.Name = "TG4x4_Image"
        Me.TG4x4_Image.Size = New System.Drawing.Size(189, 103)
        Me.TG4x4_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TG4x4_Image.TabIndex = 4
        Me.TG4x4_Image.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(42, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(337, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Please mail me on---, for feedback and suggestions."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TG4x4_Image, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TMGStartButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RPSStartButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(45, 105)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(728, 141)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'RPSStartButton
        '
        Me.RPSStartButton.BackColor = System.Drawing.Color.Gold
        Me.RPSStartButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RPSStartButton.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPSStartButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.RPSStartButton.Location = New System.Drawing.Point(198, 112)
        Me.RPSStartButton.Name = "RPSStartButton"
        Me.RPSStartButton.Size = New System.Drawing.Size(189, 26)
        Me.RPSStartButton.TabIndex = 6
        Me.RPSStartButton.Text = "Rock Paper Scissor"
        Me.RPSStartButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(198, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(783, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "v1.0"
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(834, 486)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 525)
        Me.MinimumSize = New System.Drawing.Size(850, 525)
        Me.Name = "StartScreen"
        Me.Text = "My Game Zone"
        CType(Me.TG4x4_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TMGStartButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Close_Button As Button
    Friend WithEvents TG4x4_Image As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents RPSStartButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
