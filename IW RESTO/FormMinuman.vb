Imports System.Data.OleDb
Public Class FormMinuman
    Sub awal()
        CBMinuman.Items.Clear()
        Tjumlah.Text = ""
        Lharga.Text = "0"
        Ltotal.Text = "0"
        Tket.Text = ""

        TampilMinuman()
        Pemesanan.awal()
        FormEntriOrder.awal()
    End Sub
    Sub TampilMinuman()
        koneksi()
        CMD = New OleDbCommand("SELECT nama_masakan FROM TblMasakan WHERE kategori = 'Minuman' ORDER BY id_masakan ASC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Do While DR.Read
                CBMinuman.Items.Add(DR("nama_masakan"))
            Loop
        End If
    End Sub

    Private Sub FormMinuman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub CBMinuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMinuman.SelectedIndexChanged
        koneksi()
        CMD = New OleDbCommand("SELECT harga FROM TblMasakan where nama_masakan='" & CBMinuman.Text & "'", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Lharga.Text = (DR("harga"))
        End If
    End Sub

    Private Sub Tjumlah_TextChanged(sender As Object, e As EventArgs) Handles Tjumlah.TextChanged
        harga = Val(Lharga.Text)
        jumlah = Val(Tjumlah.Text)
        total = harga * jumlah
        Ltotal.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        If CBMinuman.Text = "" Or Tjumlah.Text = "" Then
            MsgBox("Isikan Data dengan Lengkap")
        Else
            CMD = New OleDbCommand("INSERT INTO TblDetailOrder (id_order,id_masakan,harga,jumlah,total,keterangan) VALUES ('" & Pemesanan.LidOrder.Text & "','" & CBMinuman.Text & "','" & Lharga.Text & "','" & Tjumlah.Text & "','" & Ltotal.Text & "','" & Tket.Text & "')", Kon)
            CMD.ExecuteNonQuery()
            MsgBox("Menu Minuman Ditambhakan")
            awal()
            Pemesanan.awal()
            FormEntriOrder.awal()
        End If
    End Sub
End Class