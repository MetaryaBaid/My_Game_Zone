Public Class TileMatchingGames
    Private Sub TG4x4_Click(sender As Object, e As EventArgs) Handles TG4x4.Click
        Class1.TG4x4Start()
    End Sub

    Private Sub TG6x6_Click(sender As Object, e As EventArgs) Handles TG6x6.Click
        Class1.TG6x6Start()
    End Sub

    Private Sub TG8x8_Click(sender As Object, e As EventArgs) Handles TG8x8.Click
        Class1.TG8x8Start()
    End Sub

    Private Sub Ending(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Class1.TMGEnd()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Class1.TMGEnd()
    End Sub
End Class