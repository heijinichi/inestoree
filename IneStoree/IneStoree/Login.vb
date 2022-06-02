Public Class Login

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub LblSeller_Click(sender As Object, e As EventArgs) Handles LblSeller.Click
        Dim Obj = New Billing
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If TbUname.Text = "" Or TbPass.Text = "" Then
            MsgBox("Enter Username and Paassword")
        ElseIf TbUname.Text = "Admin" Or TbPass.Text = "inestore123" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
            TbUname.Text = ""
            TbPass.Text = ""
        End If
    End Sub
End Class