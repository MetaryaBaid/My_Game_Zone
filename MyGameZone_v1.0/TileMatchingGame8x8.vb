'To see what works how, look at the code for the 4x4 board
Public Class TileMatchingGame8x8

    Private Random As New Random

    Private Icons As New List(Of String) From {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "!", "@", "#", "M", "N",
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "!", "@", "#", "M", "N",
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "!", "@", "#", "M", "N",
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "!", "@", "#", "M", "N"}

    Private FstClk As Label = Nothing
    Private ScndClk As Label = Nothing

    Private Sub Icolables()
        FstClk = Nothing
        ScndClk = Nothing
        For Each control In TableLayoutPanel1.Controls
            Dim IcoLbl As Label = TryCast(control, Label)
            If IcoLbl IsNot Nothing Then
                Dim rndmnum = Random.Next(Icons.Count)
                IcoLbl.Text = Icons(rndmnum)
                IcoLbl.ForeColor = IcoLbl.BackColor
                Icons.RemoveAt(rndmnum)
            End If
        Next
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icolables()
    End Sub

    Private Sub Clk(sender As Object, e As EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label64.Click, Label63.Click, Label62.Click, Label61.Click, Label60.Click, Label6.Click, Label59.Click, Label58.Click, Label57.Click, Label56.Click, Label55.Click, Label54.Click, Label53.Click, Label52.Click, Label51.Click, Label50.Click, Label5.Click, Label49.Click, Label48.Click, Label47.Click, Label46.Click, Label45.Click, Label44.Click, Label43.Click, Label42.Click, Label41.Click, Label40.Click, Label4.Click, Label39.Click, Label38.Click, Label37.Click, Label36.Click, Label35.Click, Label34.Click, Label33.Click, Label32.Click, Label31.Click, Label30.Click, Label3.Click, Label29.Click, Label28.Click, Label27.Click, Label26.Click, Label25.Click, Label24.Click, Label23.Click, Label22.Click, Label21.Click, Label20.Click, Label2.Click, Label19.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click
        If Timer1.Enabled Then Exit Sub
        Dim ClkLbl = TryCast(sender, Label)
        If ClkLbl IsNot Nothing Then
            If ClkLbl.ForeColor = Color.Black Then Exit Sub
            ClkLbl.ForeColor = Color.Black
            If FstClk Is Nothing Then
                FstClk = ClkLbl
                FstClk.ForeColor = Color.Black
                Exit Sub
            End If
            ScndClk = ClkLbl
            ScndClk.ForeColor = Color.Black
            Verify()
            If FstClk.Text = ScndClk.Text Then
                FstClk = Nothing
                ScndClk = Nothing
                Exit Sub
            End If
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        FstClk.ForeColor = FstClk.BackColor
        ScndClk.ForeColor = ScndClk.BackColor
        FstClk = Nothing
        ScndClk = Nothing
    End Sub

    Private Sub Verify()
        For Each control In TableLayoutPanel1.Controls
            Dim icon = TryCast(control, Label)
            If icon IsNot Nothing AndAlso icon.ForeColor = icon.BackColor Then Exit Sub
        Next

        MessageBox.Show("You have matched all the tiles!", "Congratulations")
        Class1.TG8x8End()
    End Sub

    Private Sub Ending(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Class1.TG8x8 IsNot Nothing Then
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

    Private Sub Home_Button_Click(sender As Object, e As EventArgs) Handles Home_Button.Click
        Class1.TG8x8End()
        Class1.TMGEnd()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Class1.TG8x8End()
    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        Icolables()
    End Sub
End Class