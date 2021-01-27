Imports System.Data
Imports System.Data.OleDb
Public Class supplier
    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        Dim cmd As OleDbDataAdapter
        Dim dset As New DataSet
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\supp.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from suppdet ", con)
        cmd.Fill(dset, "suppdet")
        If (dset.Tables("suppdet").Rows.Count) > 0 Then
            suppdGridView.DataSource = dset.Tables("suppdet").DefaultView
        End If
    End Sub





    Private Sub view_Click(sender As Object, e As EventArgs) Handles viewbtn.Click
        Dim con As New OleDbConnection
        Dim cmd As OleDbDataAdapter
        Dim dset As New DataSet
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\supp.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from suppdet ", con)
        cmd.Fill(dset, "suppdet")
        If (dset.Tables("suppdet").Rows.Count) > 0 Then
            suppdGridView.DataSource = dset.Tables("suppdet").DefaultView
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim con As New OleDbConnection
        Dim updata As New OleDbCommand
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\supp.mdb;")
        con.Open()
        updata.Connection = con
        updata.CommandText = "Delete from suppdet where sname = '" & cname.Text & "'"
        updata.ExecuteNonQuery()
        MsgBox("Successfully deleted ")
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        cname.Text = ""
        address.Text = ""
        mobnum.Text = ""
        state.Text = ""
        pcode.Text = ""
        city.Text = ""
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Dim scon As New OleDbConnection
        Dim updata As New OleDbCommand
        scon = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\supp.mdb;")
        scon.Open()
        updata.Connection = scon
        updata.CommandText = "insert into suppdet" & "(sname,address,city,state,postcode,mobile)" & "values('" & cname.Text & "','" & address.Text & "','" & city.Text & "','" & state.Text & "','" & pcode.Text & "','" & mobnum.Text & "')"
        updata.ExecuteNonQuery()
        MsgBox("Successfully Added")
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim con As New OleDbConnection
        Dim updata As New OleDbCommand
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\supp.mdb;")
        con.Open()
        updata.Connection = con
        updata.CommandText = "update suppdet set mobile= " & "'" & mobnum.Text & "',address=" & "'" & address.Text & "', city = " & " '" & city.Text & "',state = " & "'" & state.Text & "',postcode=" & "'" & pcode.Text & "' where sname=" & "'" & cname.Text & "'"
        updata.ExecuteNonQuery()
        MsgBox("Successfully Updated ")
    End Sub
End Class