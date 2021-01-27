Public Class welform
    Dim ga As Integer
    Private Sub welform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do Until (ga = 80)
            ga = ga + 1
            timer1.Text = ga
            Me.Refresh()
        Loop
        Me.Hide()
        loginform.Show()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class