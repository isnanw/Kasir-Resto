Imports System.Data.OleDb
Public Class FormCamilan
    Sub awal()
        CbCamilan.Items.Clear()
        Ltotal.Text = "0"
        Lharga.Text = "0"
        Tket.Text = ""
        Tjumlah.Text = ""

        TampilCamilan()
        Pemesanan.awal()
        FormEntriOrder.awal()
    End Sub
    Sub TampilCamilan()
        koneksi()
        CMD = New OleDbCommand("SELECT nama_masakan FROM TblMasakan WHERE kategori='Camilan' AND id_masakan > '0' ORDER BY id_masakan ASC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Do While DR.Read
                CbCamilan.Items.Add(DR("nama_masakan"))
            Loop
        End If
    End Sub

    Private Sub FormCamilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Tjumlah_TextChanged(sender As Object, e As EventArgs) Handles Tjumlah.TextChanged
        harga = Val(Lharga.Text)
        jumlah = Val(Tjumlah.Text)
        total = harga * jumlah
        Ltotal.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CbCamilan.Text = "" Or Tjumlah.Text = "" Then
            MsgBox("Isikan Data Dengan Lengkap")
        Else
            koneksi()
            CMD = New OleDbCommand("INSERT INTO TblDetailOrder (id_order,id_masakan,harga,jumlah,total,keterangan) VALUES ('" & Pemesanan.LidOrder.Text & "','" & CbCamilan.Text & "','" & Lharga.Text & "','" & Tjumlah.Text & "','" & Ltotal.Text & "','" & Tket.Text & "')", Kon)
            CMD.ExecuteNonQuery()
            MsgBox("Menu Ditambahkan")
            awal()
            Pemesanan.awal()
            FormEntriOrder.awal()
        End If
    End Sub

    Private Sub CbCamilan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCamilan.SelectedIndexChanged
        koneksi()
        CMD = New OleDbCommand("SELECT harga FROM TblMasakan WHERE nama_masakan = '" & CbCamilan.Text & "'", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Lharga.Text = DR.Item("harga")
        End If
    End Sub
End Class