
Imports System.Data
Imports System.Data.OleDb

Public Class newuser
    Private Sub newuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim scon As New OleDbConnection
        Dim updata As New OleDbCommand
        scon = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\login.mdb;")
        scon.Open()
        updata.Connection = scon
        updata.CommandText = "insert into admilogin" & "(aname,uname,employeeid,mobileno,passwrd,enail)" & "values('" & aname.Text & "','" & username.Text & "','" & eid.Text & "','" & mobno.Text & "','" & password.Text & "','" & email.Text & "')"
        updata.ExecuteNonQuery()
        MsgBox("Successfully Added as New User")
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        aname.Text = ""
        username.Text = ""
        eid.Text = ""
        mobno.Text = ""
        password.Text = ""
        aaddress.Text = ""
        email.Text = ""

    End Sub


End Class