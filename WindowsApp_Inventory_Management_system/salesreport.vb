Imports System.Data
Imports System.Data.OleDb
Public Class salesreport
    Private Sub viewsales_Click(sender As Object, e As EventArgs) Handles viewsales.Click
        Dim con As New OleDbConnection
        Dim cmd As OleDbDataAdapter
        Dim dset As New DataSet
        con = New OleDbConnection("PROVIDER=Microsoft.Jet.OleDb.4.0;" & "DATA SOURCE=" & "G:\Gijo project\WindowsApp_Inventory_Management_system\sales.mdb;")
        con.Open()
        cmd = New OleDbDataAdapter("Select * from payment ", con)
        cmd.Fill(dset, "payment")
        If (dset.Tables("payment").Rows.Count) > 0 Then
            salesGridView.DataSource = dset.Tables("payment").DefaultView
        End If
    End Sub
End Class