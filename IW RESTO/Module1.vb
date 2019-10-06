Imports System.Data.OleDb
Module Module1
    Public Kon As OleDbConnection
    Public DS As DataSet
    Public DA As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public CMD As OleDbCommand
    Public klik, harga, jumlah, total, i As Integer

    Sub koneksi()
        Kon = New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=db_resto.mdb")
        Try
            If Kon.State = ConnectionState.Closed Then
                Kon.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal")
        End Try
    End Sub
End Module
