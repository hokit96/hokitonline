Imports System.Data.OleDb

' Global Variables
Module GV
    Public constring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\VBN - Assignment.mdb"
    Public connection As New OleDbConnection(constring)
    Public dataadapter As OleDbDataAdapter
    Public dataset As New DataSet
    Public command As New OleDbCommand
End Module

