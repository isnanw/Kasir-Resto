Imports System.Data.OleDb
Public Class FormMakanan
    Sub awal()
        LHarga.Text = "0"
        CBMakanan.Items.Clear()
        TJumlah.Text = ""
        LTotal.Text = "0"
        TKet.Text = ""
        TampilMakanan()
    End Sub
    Sub TampilMakanan()
        koneksi()
        CMD = New OleDbCommand("SELECT nama_masakan FROM TblMasakan WHERE kategori = 'Makanan' AND id_masakan >= '3' ORDER BY id_masakan ASC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Do While DR.Read
                CBMakanan.Items.Add(DR("nama_masakan"))
            Loop
        End If
    End Sub


    Private Sub FormMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilMakanan()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        FormEntriOrder.awal()
        Pemesanan.awal()
    End Sub

    Private Sub CBMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMakanan.SelectedIndexChanged
        koneksi()
        CMD = New OleDbCommand("SELECT harga FROM TblMasakan where nama_masakan = '" & CBMakanan.Text & "'", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            LHarga.Text = DR("harga")
        End If
    End Sub

    Private Sub TJumlah_TextChanged(sender As Object, e As EventArgs) Handles TJumlah.TextChanged
        harga = Val(LHarga.Text)
        jumlah = Val(TJumlah.Text)
        total = harga * jumlah
        LTotal.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        CMD = New OleDbCommand("INSERT INTO TblDetailOrder (id_order,id_masakan,harga,jumlah,total,keterangan) VALUES ('" & FormLoginPelanggan.STidOrder.Text & "','" & CBMakanan.Text & "','" & LHarga.Text & "','" & TJumlah.Text & "','" & LTotal.Text & "','" & TKet.Text & "')", Kon)
        CMD.ExecuteNonQuery()
        MsgBox("Order Makanan Selesai")
        awal()
        Pemesanan.awal()
        FormEntriOrder.awal()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class