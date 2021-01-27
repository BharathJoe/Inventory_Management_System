Imports System.Data
Imports System.Data.OleDb

Public Class sales
    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim con As New OleDbConnection
        Dim updata As New OleDbCommand
        Dim adp As New OleDbDataAdapter
        Dim dset As New DataSet
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system/stock.mdb;")
        con.Open()
        updata.Connection = con
        updata.CommandText = "Select itemcode,price from inventory where itemname='" & ComboBox1.Text & "'"
        updata.ExecuteNonQuery()
        adp.SelectCommand = updata
        adp.Fill(dset, "inventory")
        If (dset.Tables("inventory").Rows.Count) = 0 Then

            MsgBox("Product Not Found")
        Else
            id_TextBox.Text = dset.Tables("inventory").Rows(0).Item("itemcode")

            TextBox5.Text = dset.Tables("inventory").Rows(0).Item("price")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox1.Text = TextBox5.Text * TextBox6.Text
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles result_lbl.Click

    End Sub

    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles checkButton.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbDataAdapter
        Dim dset As New DataSet
        Dim uname, pwd As String
        con = New OleDbConnection("PROVIDER=MICROSOFT.Jet.OLEDB.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\sales.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from cusco where cusid=" & "'" & cusidTextBox.Text & "'", con)
        cmd.Fill(dset, "cusco")
        If (dset.Tables("cusco").Rows.Count > 0) Then
            uname = dset.Tables("cusco").Rows(0).Item("cusid")
            pwd = dset.Tables("cusco").Rows(0).Item("cusmob")
            If (uname = cusidTextBox.Text And pwd = cusmobTextBox.Text) Then
                result_lbl.Visible = True
                result_lbl.Text = "welcome"
                bakery.Show()
            Else
                result_lbl.Visible = True
                If cusmobTextBox.Text = " " Then
                    result_lbl.Text = "You did not enter the mobilenum"
                Else
                    result_lbl.Text = "please register"
                End If
            End If
        Else
            result_lbl.Visible = True
            result_lbl.Text = "Invalid UserName , Please Register"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim scon As New OleDbConnection
        Dim updata As New OleDbCommand
        scon = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\sales.mdb;")
        scon.Open()
        updata.Connection = scon
        updata.CommandText = "insert into cusco" & "(cusid,cusmob,cusname,cusaddress)" & "values('" & cusidTextBox.Text & "','" & cusmobTextBox.Text & "','" & cusnameTextBox.Text & "','" & cusaddressTextBox.Text & "')"
        updata.ExecuteNonQuery()
        MsgBox("Successfully Added")
    End Sub

    Private Sub pay_Click(sender As Object, e As EventArgs) Handles pay.Click
        Dim scon As New OleDbConnection
        Dim updata As New OleDbCommand
        scon = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\sales.mdb;")
        scon.Open()
        updata.Connection = scon
        updata.CommandText = "insert into payment" & "(cusid,cusname,productid,productname,price,stocks,amount)" & "values('" & cusidTextBox.Text & "','" & cusnameTextBox.Text & "','" & id_TextBox.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox1.Text & "')"
        updata.ExecuteNonQuery()
        MsgBox("proceed to print Bill")
        printButton.Visible = True
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        PrintDialogmjb.Document = PrintDocumentmjb
        PrintDialogmjb.PrinterSettings = PrintDialogmjb.PrinterSettings
        PrintDialogmjb.AllowSomePages = True
        PrintDialogmjb.AllowSelection = True
        PrintDialogmjb.AllowCurrentPage = True
        If PrintDialogmjb.ShowDialog = DialogResult.OK Then
            PrintDocumentmjb.Print()
        End If
    End Sub
End Class