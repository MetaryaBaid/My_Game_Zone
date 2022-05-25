Public Class RockPaperScissor
    'Declaring Variables
    Private rndm As New Random
    Private PlayerScore As New Integer
    Private CompScore As New Integer
    Private Time As Integer = 3
    Private CompAtt As String
    Private PlayerAtt As String

    Private Sub RockPaperScissor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RockButton.Enabled = False
        PaperButton.Enabled = False
        ScissorButton.Enabled = False
        PlayButton.Enabled = True
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        If Time > 0 Then
            Time = Time - 1
        End If
        TimerLabel.Text = Time.ToString
    End Sub

    Private Sub Play(sender As Object, e As EventArgs) Handles PlayButton.Click
        CompPlay()
    End Sub

    Private Sub PlayerRock(sender As Object, e As EventArgs) Handles RockButton.Click
        PlayerAtt = "Rock"
        PlayerPlay()
    End Sub

    Private Sub PlayerPaper(sender As Object, e As EventArgs) Handles PaperButton.Click
        PlayerAtt = "Paper"
        PlayerPlay()
    End Sub

    Private Sub PlayerScissor(sender As Object, e As EventArgs) Handles ScissorButton.Click
        PlayerAtt = "Scissor"
        PlayerPlay()
    End Sub

    Private Sub CompPlay()
        TimerLabel.Text = "3"
        RockButton.Enabled = True
        PaperButton.Enabled = True
        ScissorButton.Enabled = True
        PlayButton.Enabled = False
        PlayButton.Visible = False
        GameTimer.Start()
    End Sub

    Private Sub PlayerPlay()
        Dim CompSel As Integer = rndm.Next(1, 4)
        Select Case CompSel
            Case 1
                CompAtt = "Rock"
            Case 2
                CompAtt = "Paper"
            Case 3
                CompAtt = "Scissor"
        End Select
        PlayerLabel.Text = PlayerAtt
        CompLabel.Text = CompAtt
        If PlayerAtt = "Rock" Then
            PlayerLabel.Text = RockLabel.Text
            If CompAtt = "Rock" Then
                CompLabel.Text = RockLabel.Text
                AnnouncementLabel.Text = "Tie!"
                PlayerPos.BackColor = Color.White
                CompPos.BackColor = Color.White
            ElseIf CompAtt = "Paper" Then
                CompLabel.Text = PaperLabel.Text
                AnnouncementLabel.Text = "Computer Wins!"
                CompScore = CompScore + 1
                PlayerPos.BackColor = Color.DarkRed
                CompPos.BackColor = Color.LightGreen
            ElseIf CompAtt = "Scissor" Then
                CompLabel.Text = ScissorLabel.Text
                AnnouncementLabel.Text = "Player Wins!"
                PlayerScore = PlayerScore + 1
                PlayerPos.BackColor = Color.LightGreen
                CompPos.BackColor = Color.DarkRed
            End If
        ElseIf PlayerAtt = "Paper" Then
            PlayerLabel.Text = PaperLabel.Text
            If CompAtt = "Rock" Then
                CompLabel.Text = RockLabel.Text
                AnnouncementLabel.Text = "Player Wins!"
                PlayerScore = PlayerScore + 1
                PlayerPos.BackColor = Color.LightGreen
                CompPos.BackColor = Color.DarkRed
            ElseIf CompAtt = "Paper" Then
                CompLabel.Text = PaperLabel.Text
                AnnouncementLabel.Text = "Tie!"
                PlayerPos.BackColor = Color.White
                CompPos.BackColor = Color.White
            ElseIf CompAtt = "Scissor" Then
                CompLabel.Text = ScissorLabel.Text
                AnnouncementLabel.Text = "Computer Wins!"
                CompScore = CompScore + 1
                PlayerPos.BackColor = Color.DarkRed
                CompPos.BackColor = Color.LightGreen
            End If
        ElseIf PlayerAtt = "Scissor" Then
            PlayerLabel.Text = ScissorLabel.Text
            If CompAtt = "Rock" Then
                CompLabel.Text = RockLabel.Text
                AnnouncementLabel.Text = "Computer Wins!"
                CompScore = CompScore + 1
                PlayerPos.BackColor = Color.DarkRed
                CompPos.BackColor = Color.LightGreen
            ElseIf CompAtt = "Paper" Then
                CompLabel.Text = PaperLabel.Text
                AnnouncementLabel.Text = "Player Wins!"
                PlayerScore = PlayerScore + 1
                PlayerPos.BackColor = Color.LightGreen
                CompPos.BackColor = Color.DarkRed
            ElseIf CompAtt = "Scissor" Then
                CompLabel.Text = ScissorLabel.Text
                AnnouncementLabel.Text = "Tie!"
                PlayerPos.BackColor = Color.White
                CompPos.BackColor = Color.White
            End If
        End If
        GameTimer.Stop()
        Time = 3
        PlayButton.Text = "Continue?"
        PlayButton.Enabled = True
        PlayButton.Visible = True
        RockButton.Enabled = False
        PaperButton.Enabled = False
        ScissorButton.Enabled = False
        CompAtt = ""
        PlayerAtt = ""
        PlayerScoreLabel.Text = PlayerScore.ToString
        CompScoreLabel.Text = CompScore.ToString
    End Sub

    Private Sub RockPaperScissor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Class1.RPSEnd()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Class1.RPSEnd()
    End Sub
End Class