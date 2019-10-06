Imports System.Data.OleDb
Public Class Pemesanan
    Sub awal()
        koneksi()
        DA = New OleDbDataAdapter("SELECT ID_MASAKAN, HARGA, JUMLAH, TOTAL FROM TblDetailOrder where id_order = '" & LidOrder.Text & "'", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblDetailOrder")
        DGVPesanan.DataSource = (DS.Tables("TblDetailOrder"))

        LidOrder.Text = FormLoginPelanggan.STidOrder.Text
        LNamaPelanggan.Text = FormLoginPelanggan.Tnama.Text
        LnoMeja.Text = FormLoginPelanggan.CBMeja.Text

        hitungTotal()
    End Sub
    Sub hitungTotal()
        koneksi()
        total = 0
        For i = 0 To DGVPesanan.RowCount() - 1
            total += DGVPesanan.Rows(i).Cells(3).Value
        Next
        TotalBayar.Text = total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormLoginPelanggan.awal()
        FormLoginPelanggan.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub

    Private Sub Pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormEntriOrder.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Keluar ?", vbInformation + vbYesNo) = vbYes Then
            FormLoginPelanggan.WindowState = FormWindowState.Normal
            Me.Close()
            FormLoginPelanggan.awal()
        End If
    End Sub
End Class