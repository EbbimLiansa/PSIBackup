Imports System.Data.OleDb
Module Module1
    Public cn As New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=PSI.accdb")

    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dr As OleDbDataReader

    Sub Koneksi()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub
End Module
