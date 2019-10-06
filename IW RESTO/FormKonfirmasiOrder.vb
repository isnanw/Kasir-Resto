Imports System.Data.OleDb
Public Class FormKonfirmasiOrder
    Sub Awal()
        koneksi()
        DA = New OleDbDataAdapter("SELECT ID_MASAKAN,JUMLAH,TOTAL FROM TblDetailOrder where id_order = '" & FormPetugas.LId.Text & "'", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblDetailOrder")
        DGV2.DataSource = DS.Tables("TblDetailOrder")

        LId.Text = FormPetugas.LId.Text
        LNama.Text = FormPetugas.LNama.Text
    End Sub

    Private Sub FormKonfirmasiOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Awal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        koneksi()
        CMD = New OleDbCommand("UPDATE TblOrder SET status_order = 'Menunggu Pembayaran' WHERE id_order = '" & LId.Text & "'", Kon)
        CMD.ExecuteNonQuery()
        Awal()
        Me.Close()
        FormPetugas.awal()
    End Sub
End Class