Imports System.Data
Imports System.Data.OleDb
Public Class stocksales
    Dim table As New DataTable("table")
    Private Sub stocksales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        Dim cmd As OleDbDataAdapter
        Dim dset As New DataSet
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\stock.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from inventory ", con)
        cmd.Fill(dset, "inventory")
        If (dset.Tables("inventory").Rows.Count) > 0 Then
            stockView.DataSource = dset.Tables("inventory").DefaultView
        End If
    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        If icode.Text = "" Then
            MsgBox("please Enter the Item Code")
            icode.Focus()
        ElseIf iname.Text = "" Then
            MsgBox("Please Enter the Item Name")
            iname.Focus()
        ElseIf description.Text = "" Then
            MsgBox("Please Enter the Description")
            description.Focus()
        ElseIf category.Text = "" Then
            MsgBox("Please Enter the Category")
            categoryBox.Focus()
        ElseIf price.Text = "" Then
            MsgBox("Please Enter the Item Price")
            price.Focus()
        ElseIf stocks.Text = "" Then
            MsgBox("Please Enter the Item Stocks")
            stocks.Focus()
        Else
            Dim scon As New OleDbConnection
            Dim updata As New OleDbCommand
            scon = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\stock.mdb;")
            scon.Open()
            updata.Connection = scon
            updata.CommandText = "insert into inventory" & "(itemcode,itemname,description,category,price,stock,dattime)" & "values('" & icode.Text & "','" & iname.Text & "','" & description.Text & "','" & category.Text & "','" & price.Text & "','" & stocks.Text & "','" & dattime.Value.Date & "')"
            updata.ExecuteNonQuery()
            MsgBox("Successfully Added")
        End If

    End Sub





    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim con As New OleDbConnection
        Dim updata As New OleDbCommand
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\stock.mdb;")
        con.Open()
        updata.Connection = con
        updata.CommandText = "Delete from inventory where itemname = " & "'" & iname.Text & "'"
        updata.ExecuteNonQuery()
        MsgBox("Successfully deleted ")

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Dim con As New OleDbConnection
        Dim cmd As OleDbDataAdapter
        Dim dset As New DataSet
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\stock.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from inventory where itemname= " & "'" & sitem.Text & "'", con)
        cmd.Fill(dset, "inventory")
        If (dset.Tables("inventory").Rows.Count > 0) Then
            stockView.DataSource = dset.Tables("inventory").DefaultView
        Else
            status.Visible = True
            status.Text = "invalid"
        End If

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim con As New OleDbConnection
        Dim updata As New OleDbCommand
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\stock.mdb;")
        con.Open()
        updata.Connection = con
        updata.CommandText = "update inventory set stock= " & "'" & stocks.Text & "',itemname=" & "'" & iname.Text & "', description = " & " '" & description.Text & "',category = " & "'" & category.Text & "', price=" & "'" & price.Text & "' where itemname =" & "'" & iname.Text & "'"
        updata.ExecuteNonQuery()
        MsgBox("Successfully Updated ")
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        Dim con As New OleDbConnection
        Dim cmd As OleDbDataAdapter
        Dim dset As New DataSet
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\stock.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from inventory ", con)
        cmd.Fill(dset, "inventory")
        If (dset.Tables("inventory").Rows.Count) > 0 Then
            stockView.DataSource = dset.Tables("inventory").DefaultView
        End If
    End Sub

    Private Sub stockView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = stockView.Rows(index)
        icode.Text = selectedrow.Cells(0).Value.ToString()
        iname.Text = selectedrow.Cells(1).Value.ToString()
        description.Text = selectedrow.Cells(2).Value.ToString()
        category.Text = selectedrow.Cells(3).Value.ToString()
        price.Text = selectedrow.Cells(4).Value.ToString()
        stocks.Text = selectedrow.Cells(5).Value.ToString()

    End Sub

    Private Sub categoryBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoryBox.SelectedIndexChanged

    End Sub

    Private Sub stockView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockView.CellContentClick

    End Sub
End Class