'Opening/First/Starting Form
Public Class StartScreen
    'Opening Tile Matching Games Main Form
    Private Sub TMGStart(sender As Object, e As EventArgs) Handles TMGStartButton.Click
        Class1.TMGStart()
    End Sub

    'Opening Rock Paper Scissor Form
    Private Sub RPSStart(sender As Object, e As EventArgs) Handles RPSStartButton.Click
        Class1.RPSStart()
    End Sub

    'Closing App(Way1)
    Private Sub AppClosing(sender As Object, e As EventArgs) Handles Close_Button.Click
        Class1.Exits()
    End Sub

    'Closing App(Way2)
    Private Sub Form_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Class1.Exits()
    End Sub
End Class