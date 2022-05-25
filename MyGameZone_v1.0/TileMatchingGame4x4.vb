'The 4x4 board of Tile Metching Game
Public Class TileMatchingGame4x4

    'Random number generator
    Private Random As New Random

    'List of all the icons
    Private Icons As New List(Of String) From {"e", "e", "H", "H", "N", "N", "P", "P", "!", "!", "w", "w", "M", "M", "@", "@"}

    'First clicked tile
    Private FirstTile As Label = Nothing

    'Second clicked tile
    Private SecondTile As Label = Nothing

    'Puts icons on labels
    Private Sub IconsToLabels()
        FirstTile = Nothing
        SecondTile = Nothing
        'Runs through all the labels
        For Each Control In TableLayoutPanel1.Controls
            Dim IcoLbl = TryCast(Control, Label)
            'Puts icons in each label
            If IcoLbl IsNot Nothing Then
                Dim RandomNumber = Random.Next(Icons.Count)
                IcoLbl.Text = Icons(RandomNumber)
                IcoLbl.ForeColor = IcoLbl.BackColor
                Icons.RemoveAt(RandomNumber)
            End If
        Next
    End Sub

    'Calls IconsToLabels() on form load
    Private Sub TileMatchingGame4x4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IconsToLabels()
    End Sub

    'Runs when a label is clicked.
    ''' <summary>
    ''' Handles the click event of labels.
    ''' Starts the timer if wrong pairs are clicked,
    ''' else calls the CheckAnswer() method.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LabelClick(ByVal sender As Object, ByVal e As EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click
        'If two unmatched icons are still being displayed, exits sub
        If Timer1.Enabled Then Exit Sub
        'If two unmatched icons are not displayed, then proceeds
        Dim ClickedLabel = TryCast(sender, Label)
        'If the TryCast fails then doesn't continue
        If ClickedLabel IsNot Nothing Then
            'If the tile is already facing up then exits
            If ClickedLabel.ForeColor = Color.Black Then Exit Sub
            'Else turns it 
            ClickedLabel.ForeColor = Color.Black
            'If no other tile is selected then this is the first tile
            If FirstTile Is Nothing Then
                FirstTile = ClickedLabel
                FirstTile.ForeColor = Color.Black
                Exit Sub
            End If
            'Else the second the tile, as more than two tiles can't be selected at once
            SecondTile = ClickedLabel
            SecondTile.ForeColor = Color.Black
            'Check if all the tiles match and the board is solved
            CheckAnswer()
            'And empty the variables if the answer is correct
            If FirstTile.Text = SecondTile.Text Then
                FirstTile = Nothing
                SecondTile = Nothing
                Exit Sub
            End If
            'Start the cooldown for selecting the next pair
            Timer1.Start()
        End If
    End Sub

    'Timer for cooldown
    ''' <summary>
    ''' If the pair clicked by user is not matching,
    ''' then it hides it again.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Cooldown end
        Timer1.Stop()
        'Turn the tiles back if the pair doesn't match
        FirstTile.ForeColor = FirstTile.BackColor
        SecondTile.ForeColor = SecondTile.BackColor
        'Empty the variables
        FirstTile = Nothing
        SecondTile = Nothing
    End Sub

    'Checking if the board is cleared
    ''' <summary>
    ''' Checks if all the icons are matched or not. If yes, it tells the user.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CheckAnswer()
        'Check all the tiles and see if they are all up
        For Each control In TableLayoutPanel1.Controls
            Dim Icon = TryCast(control, Label)
            'If any tile is facing down, then exit
            If Icon IsNot Nothing AndAlso
                Icon.ForeColor = Icon.BackColor Then Exit Sub
        Next
        'If all are up then show congratulations message and move to the next board
        MessageBox.Show("You matched all the Tiles!", "Congratulations!")
        Class1.TG4x4End()
        Class1.TG6x6Start()
    End Sub

    'Run when the user exits the app
    Public Shared Sub Game_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Class1.TG4x4 IsNot Nothing Then
            Dim Msg As DialogResult = MessageBox.Show("Are you sure you want to exit?", "End", MessageBoxButtons.YesNo)
            Select Case Msg
                Case DialogResult.Yes
                    Class1.Exits()
                Case DialogResult.No
                    e.Cancel = True
                    Exit Sub
            End Select
        Else
            Exit Sub
        End If
    End Sub

    'Home button:Returns to the start screen
    Private Sub Home_Button_Click(sender As Object, e As EventArgs) Handles Home_Button.Click
        Class1.TG4x4End()
        Class1.TMGEnd()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Class1.TG4x4End()
    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        IconsToLabels()
    End Sub
End Class
