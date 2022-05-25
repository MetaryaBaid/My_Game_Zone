'To see what works how, look at the code for the 4x4 board
Public Class TileMatchingGame6x6

    Private Random As New Random
    Private Icons As New List(Of String) From {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "!", "@", "#", "M", "N", "L", "V",
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "!", "@", "#", "M", "N", "L", "V"}
    Private First As Label = Nothing
    Private Second As Label = Nothing

    Private Sub IconsTolabel()
        First = Nothing
        Second = Nothing
        For Each Control In TableLayoutPanel1.Controls
            Dim IcoLbl = TryCast(Control, Label)
            If IcoLbl IsNot Nothing Then
                Dim RandomNumber = Random.Next(Icons.Count)
                IcoLbl.Text = Icons(RandomNumber)
                IcoLbl.ForeColor = IcoLbl.BackColor
                Icons.RemoveAt(RandomNumber)
            End If
        Next
    End Sub

    Private Sub TG6x6_Load(sendr As Object, e As EventArgs) Handles MyBase.Load
        IconsTolabel()
    End Sub

    Private Sub Show_Label(sender As Object, e As EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label36.Click, Label35.Click, Label34.Click, Label33.Click, Label32.Click, Label31.Click, Label30.Click, Label3.Click, Label29.Click, Label28.Click, Label27.Click, Label26.Click, Label25.Click, Label24.Click, Label23.Click, Label22.Click, Label21.Click, Label20.Click, Label2.Click, Label19.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

        If Timer.Enabled Then Exit Sub
        Dim ClkdLbl = TryCast(sender, Label)
        If ClkdLbl IsNot Nothing Then
            If ClkdLbl.ForeColor = Color.Black Then Exit Sub
            ClkdLbl.ForeColor = Color.Black
            If First Is Nothing Then
                First = ClkdLbl
                First.ForeColor = Color.Black
                Exit Sub
            End If
            Second = ClkdLbl
            Second.ForeColor = Color.Black
            Verification()
            If First.Text = Second.Text Then
                First = Nothing
                Second = Nothing
                Exit Sub
            End If
            Timer.Start()
        End If
    End Sub

    Private Sub Verification()
        For Each Control In TableLayoutPanel1.Controls
            Dim Icons = TryCast(Control, Label)
            If Icons IsNot Nothing AndAlso
                    Icons.ForeColor = Icons.BackColor Then Exit Sub
        Next

        MessageBox.Show("You have matched all tiles!", "Congratulatins")
        Class1.TG6x6End()
        Class1.TG8x8Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Stop()
        First.ForeColor = First.BackColor
        First = Nothing
        Second.ForeColor = Second.BackColor
        Second = Nothing
    End Sub

    Private Sub Game_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Class1.TG6x6 IsNot Nothing Then
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
        Class1.TG6x6End()
        Class1.TMGEnd()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Class1.TG6x6End()
    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        IconsTolabel()
    End Sub
End Class