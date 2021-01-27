Public Class bakery


    Private Sub stock_Click(sender As Object, e As EventArgs) Handles supplierpic.Click
        Dim stk As New supplier
        stk.MdiParent = Me
        stk.Show()
    End Sub
    Private Sub newuser_Click(sender As Object, e As EventArgs) Handles newuser.Click
        Dim stk As New newuser
        stk.MdiParent = Me
        stk.Show()
    End Sub
    Private Sub stockPictureBox_Click(sender As Object, e As EventArgs) Handles stockPictureBox.Click
        Dim stk As New stocksales
        stk.MdiParent = Me
        stk.Show()
    End Sub

    Private Sub logout_Click_1(sender As Object, e As EventArgs) Handles logout.Click
        Application.Exit()
    End Sub

    Private Sub servicedesk_Click(sender As Object, e As EventArgs) Handles servicedesk.Click
        Dim stk As New servicedesk
        stk.MdiParent = Me
        stk.Show()
    End Sub

    Private Sub changeuser_Click(sender As Object, e As EventArgs) Handles changeuser.Click
        Dim stk As New loginform
        stk.MdiParent = Me
        stk.Show()
    End Sub

    Private Sub salesreport_Click(sender As Object, e As EventArgs) Handles salesreport.Click
        Dim stk As New salesreport
        stk.MdiParent = Me
        stk.Show()
    End Sub

    Private Sub sales_Click(sender As Object, e As EventArgs) Handles sales.Click
        Dim stk As New sales
        stk.MdiParent = Me
        stk.Show()

    End Sub

    Private Sub bakery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class