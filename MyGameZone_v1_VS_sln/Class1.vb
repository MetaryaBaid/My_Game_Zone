'SubRoutines for navigation
Public Class Class1
    'Declaring variables
    'First/Opening/Starting Form
    Public Shared StrScr As StartScreen = StartScreen

    'Tile Matching Games' forms-> Starting Form
    Public Shared TMGs As TileMatchingGames = TileMatchingGames

    'Tile Matching Games' forms-> 4x4, 6x6, 8x8 size game boards
    Public Shared TG4x4 As TileMatchingGame4x4 = TileMatchingGame4x4
    Public Shared TG6x6 As TileMatchingGame6x6 = TileMatchingGame6x6
    Public Shared TG8x8 As TileMatchingGame8x8 = TileMatchingGame8x8

    'Rock Paper Scissor Game Form
    Public Shared RPS As RockPaperScissor = RockPaperScissor

    'Ending/Closing Form
    Public Shared TFP As Thanks_For_Playing = Thanks_For_Playing

    'SubRoutine for entering Tile Matching Games' Starting form(line:8)
    Public Shared Sub TMGStart()
        TMGs.Show()
        StrScr.Hide()
    End Sub
    'SubRoutine for exiting Tile Matching Games' starting form(line:8)
    Public Shared Sub TMGEnd()
        TMGs.Dispose()
        TMGs = New TileMatchingGames
        TMGs.Show()
        TMGs.Hide()
        StrScr.Show()
    End Sub

    'SubRoutine for entering 4x4 board of tile matching game(line:11)
    Public Shared Sub TG4x4Start()
        TG4x4.Show()
        TMGs.Hide()
    End Sub

    'SubRoutine for exiting 4x4 board of tile matching game(line:11)
    Public Shared Sub TG4x4End()
        TG4x4.Dispose()
        TG4x4 = New TileMatchingGame4x4
        TG4x4.Show()
        TG4x4.Hide()
        TMGs.Show()
    End Sub

    'SubRoutine for entering 6x6 board of tile matching game(line:12)
    Public Shared Sub TG6x6Start()
        TG6x6.Show()
        TMGs.Hide()
    End Sub

    'SubRoutine for exiting 6x6 board of tile matching game(line:12)
    Public Shared Sub TG6x6End()
        TG6x6.Dispose()
        TG6x6 = New TileMatchingGame6x6
        TG6x6.Show()
        TG6x6.Hide()
        TMGs.Show()
    End Sub

    'SubRoutine for entering 8x8 board of tile matching game(line:13)
    Public Shared Sub TG8x8Start()
        TG8x8.Show()
        TMGs.Hide()
    End Sub

    'SubRoutine for exiting 8x8 board of tile matching game(line:13)
    Public Shared Sub TG8x8End()
        TG8x8.Dispose()
        TG8x8 = New TileMatchingGame8x8
        TG8x8.Show()
        TG8x8.Hide()
        TMGs.Show()
    End Sub

    'SubRoutine for entering Rock Paper Scissor Game(line:16)
    Public Shared Sub RPSStart()
        RPS.Show()
        StrScr.Hide()
    End Sub

    'SubRoutine for exiting Rock Paper Scissor Game(line:16)
    Public Shared Sub RPSEnd()
        StrScr.Show()
        RPS.Hide()
    End Sub

    'SubRoutine for closing the game.
    'Showing Thanks and Credit Form(line:19)
    Public Shared Sub Exits()
        TFP.Show()
    End Sub
End Class
