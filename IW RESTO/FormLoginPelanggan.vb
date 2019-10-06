Imports System.Data.OleDb
Public Class FormLoginPelanggan

    Sub awal()
        TSTanggal.Text = Format(Now, "dd/MM/yyyy")
        Tnama.Text = ""
        CBMeja.Items.Clear()
        Tstatus.Text = "Memilih Menu"
        TampilMeja()
        kodeOtoPelanggan()
        kodeOtoOrder()
    End Sub

    Sub TampilMeja()
        koneksi()
        CMD = New OleDbCommand("SELECT nama_meja FROM TblMeja WHERE status_meja='Kosong' ORDER BY id_meja ASC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Do While DR.Read
                CBMeja.Items.Add(DR("nama_meja"))
            Loop
        End If
    End Sub
    Sub kodeOtoPelanggan()
        koneksi()
        CMD = New OleDbCommand("SELECT * FROM TblPelanggan ORDER BY id_pelanggan DESC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            idPelanggan.Text = "P001"
        Else
            idPelanggan.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("id_pelanggan").ToString, 3, 3)) + 1
            If Len(idPelanggan.Text) = 1 Then
                idPelanggan.Text = "P00" & idPelanggan.Text & ""
            ElseIf Len(idPelanggan.Text) = 2 Then
                idPelanggan.Text = "P0" & idPelanggan.Text & ""
            End If
        End If
        DR.Close()
    End Sub
    Sub kodeOtoOrder()
        koneksi()
        CMD = New OleDbCommand("SELECT * FROM TblOrder ORDER BY id_order DESC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            STidOrder.Text = "O001"
        Else
            STidOrder.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("id_order").ToString, 3, 3)) + 1
            If Len(STidOrder.Text) = 1 Then
                STidOrder.Text = "O00" & STidOrder.Text & ""
            ElseIf Len(STidOrder.Text) = 2 Then
                STidOrder.Text = "O0" & STidOrder.Text & ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub FormLoginPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        awal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        koneksi()
        If Tnama.Text = "" Or CBMeja.Text = "" Then
            MsgBox("Harap Isi Data Dengan Lengkap !")
        Else
            CMD = New OleDbCommand("INSERT INTO TblPelanggan (id_pelanggan,nama_pelanggan,no_meja) VALUES ('" & idPelanggan.Text & "','" & Tnama.Text & "','" & CBMeja.Text & "')", Kon)
            CMD.ExecuteNonQuery()

            CMD = New OleDbCommand("INSERT INTO TblOrder (id_order,no_meja,tanggal,id_user,keterangan,status_order) VALUES ('" & STidOrder.Text & "','" & CBMeja.Text & "','" & TSTanggal.Text & "','" & idPelanggan.Text & "','NULL','Memilih Menu')", Kon)
            CMD.ExecuteNonQuery()

            CMD = New OleDbCommand("UPDATE TblMeja SET status_meja = 'Penuh' WHERE nama_meja = '" & CBMeja.Text & "'", Kon)
            Try
                CMD.ExecuteNonQuery()
                Pemesanan.Show()
                Me.WindowState = FormWindowState.Minimized
            Catch ex As Exception
                MsgBox("Gagal Masuk")
            End Try
            End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoginForm1.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class