Imports System.Data
Imports System.Data.OleDb
Public Class loginform
    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles bgPictureBox.Click

    End Sub



    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        username.Text = ""
        password.Text = ""
        result_lbl.Text = ""

    End Sub



    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbDataAdapter
        Dim dset As New DataSet
        Dim uname, pwd As String
        con = New OleDbConnection("PROVIDER=MICROSOFT.Jet.OLEDB.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\login.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from adminlogin where username=" & "'" & username.Text & "'", con)
        cmd.Fill(dset, "adminlogin")
        If (dset.Tables("adminlogin").Rows.Count > 0) Then
            uname = dset.Tables("adminlogin").Rows(0).Item("username")
            pwd = dset.Tables("adminlogin").Rows(0).Item("password")
            If (uname = username.Text And pwd = password.Text) Then
                result_lbl.Visible = True
                result_lbl.Text = "You are an Authenticated User"
                bakery.Show()
            Else
                result_lbl.Visible = True
                If password.Text = " " Then
                    result_lbl.Text = "You did not enter the password"
                Else
                    result_lbl.Text = "Check the password you have entered"
                End If
            End If
        Else
            result_lbl.Visible = True
            result_lbl.Text = "Invalid UserName , Please Register"
        End If
    End Sub
End Class
