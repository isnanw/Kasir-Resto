Imports System.Data.OleDb
Public Class FormEntriOrder
    Sub awal()
        koneksi()
        DA = New OleDbDataAdapter("SELECT ID_MASAKAN, HARGA, JUMLAH, TOTAL FROM TblDetailOrder WHERE id_order = '" & Pemesanan.LidOrder.Text & "'", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblDetailOrder")
        DGVPesanan.DataSource = (DS.Tables("TblDetailOrder"))

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
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FormMakanan.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FormMinuman.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FormCamilan.Show()
    End Sub

    Private Sub FormEntriOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        CMD = New OleDbCommand("UPDATE TblOrder SET status_order = 'Menunggu Dianter' WHERE id_order = '" & Pemesanan.LidOrder.Text & "'", Kon)
        CMD.ExecuteNonQuery()
        MsgBox("Order Selesai")
        Pemesanan.awal()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class