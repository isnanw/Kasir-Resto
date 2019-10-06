Imports System.Data.OleDb
Public Class FormPetugas
    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        awal()
        ButtonHome.PerformClick()
    End Sub

    Sub awal()
        Call koneksi()
        DA = New OleDbDataAdapter("SELECT * FROM TblMeja WHERE id_meja > '0'", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblMeja")
        DGVMEja.DataSource = (DS.Tables("TblMeja"))

        DA = New OleDbDataAdapter("SELECT * FROM TblMasakan WHERE id_masakan > '3'", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblMasakan")
        DGVMasakan.DataSource = (DS.Tables("TblMasakan"))

        DA = New OleDbDataAdapter("SELECT id_pelanggan, no_meja FROM TblPelanggan", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblPelanggan")
        DGVPelanggan.DataSource = (DS.Tables("TblPelanggan"))

        DA = New OleDbDataAdapter("SELECT * FROM TblOrder", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblOrder")
        DGVOrder.DataSource = (DS.Tables("TblOrder"))

        DA = New OleDbDataAdapter("SELECT ID_ORDER,NO_MEJA,ID_USER FROM TblOrder WHERE status_order = 'Menunggu Dianter'", Kon)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TblOrder")
        DGVOederMasuk.DataSource = (DS.Tables("TblOrder"))

        TnamaMeja.Text = ""
        TnamaMasakan.Text = ""
        ThargaMasakan.Text = ""
        LId.Text = ""
        LMeja.Text = ""
        LNama.Text = ""
        CBKategori.Items.Clear()
        CBMeja.Items.Clear()
        CBstatusMasakan.Items.Clear()
        kodeOtoMeja()
        kodeOtoMasakan()
        tampilKategori()
        tampilStatusMeja()
        tampilStatusMasakan()
    End Sub

    Sub kodeOtoMeja()
        koneksi()
        CMD = New OleDbCommand("SELECT * FROM TblMeja ORDER BY id_meja DESC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            TidMeja.Text = "M001"
        Else
            TidMeja.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("id_Meja").ToString, 3, 3)) + 1
            If Len(TidMeja.Text) = 1 Then
                TidMeja.Text = "M00" & TidMeja.Text & ""
            ElseIf Len(TidMeja.Text) = 2 Then
                TidMeja.Text = "M0" & TidMeja.Text & ""
            End If
        End If
        DR.Close()
    End Sub

    Sub kodeOtoMasakan()
        koneksi()
        CMD = New OleDbCommand("SELECT * FROM TblMasakan ORDER BY id_masakan DESC", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            TidMasakan.Text = "MS001"
        Else
            TidMasakan.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("id_masakan").ToString, 3, 3)) + 1
            If Len(TidMasakan.Text) = 1 Then
                TidMasakan.Text = "MS00" & TidMasakan.Text & ""
            ElseIf Len(TidMasakan.Text) = 2 Then
                TidMasakan.Text = "MS0" & TidMasakan.Text & ""
            End If
        End If
        DR.Close()
    End Sub

    Sub tampilKategori()
        CBKategori.Items.Add("Makanan")
        CBKategori.Items.Add("Minuman")
        CBKategori.Items.Add("Camilan")
    End Sub
    Sub tampilStatusMeja()
        CBMeja.Items.Add("Kosong")
        CBMeja.Items.Add("Penuh")
    End Sub
    Sub tampilStatusMasakan()
        CBstatusMasakan.Items.Add("Habis")
        CBstatusMasakan.Items.Add("Tersedia")
    End Sub


    Sub pilihPanel()
        PanelHome.Visible = False
        PanelrEFERENSI.Visible = False
        PanelOrder.Visible = False
        PanelTransaksi.Visible = False
        PanelLaporan.Visible = False
        PanelPetugas.Visible = False
        ButtonHome.BackColor = Color.FromArgb(0, 96, 100)
        ButtonReferensi.BackColor = Color.FromArgb(0, 96, 100)
        ButtonOrder.BackColor = Color.FromArgb(0, 96, 100)
        ButtonTransaksi.BackColor = Color.FromArgb(0, 96, 100)
        ButtonLaporan.BackColor = Color.FromArgb(0, 96, 100)
        ButtonPetugas.BackColor = Color.FromArgb(0, 96, 100)
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        pilihPanel()
        PanelPilih.Height = ButtonHome.Height
        PanelPilih.Top = ButtonHome.Top
        PanelHome.Visible = True
        ButtonHome.BackColor = Color.FromArgb(0, 105, 92)
    End Sub

    Private Sub ButtonReferensi_Click(sender As Object, e As EventArgs) Handles ButtonReferensi.Click
        pilihPanel()
        PanelPilih.Height = ButtonReferensi.Height
        PanelPilih.Top = ButtonReferensi.Top
        PanelrEFERENSI.Visible = True
        ButtonReferensi.BackColor = Color.FromArgb(0, 105, 92)
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        pilihPanel()
        PanelPilih.Height = ButtonOrder.Height
        PanelPilih.Top = ButtonOrder.Top
        PanelOrder.Visible = True
        ButtonOrder.BackColor = Color.FromArgb(0, 105, 92)
    End Sub

    Private Sub ButtonTransaksi_Click(sender As Object, e As EventArgs) Handles ButtonTransaksi.Click
        pilihPanel()
        PanelPilih.Height = ButtonTransaksi.Height
        PanelPilih.Top = ButtonTransaksi.Top
        PanelTransaksi.Visible = True
        ButtonTransaksi.BackColor = Color.FromArgb(0, 105, 92)
    End Sub

    Private Sub ButtonPetugas_Click(sender As Object, e As EventArgs) Handles ButtonPetugas.Click
        pilihPanel()
        PanelPilih.Height = ButtonPetugas.Height
        PanelPilih.Top = ButtonPetugas.Top
        PanelPetugas.Visible = True
        ButtonPetugas.BackColor = Color.FromArgb(0, 105, 92)
    End Sub

    Private Sub ButtonLaporan_Click(sender As Object, e As EventArgs) Handles ButtonLaporan.Click
        pilihPanel()
        PanelPilih.Height = ButtonLaporan.Height
        PanelPilih.Top = ButtonLaporan.Top
        PanelLaporan.Visible = True
        ButtonLaporan.BackColor = Color.FromArgb(0, 105, 92)
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        If MsgBox("Keluar ?", vbInformation + vbYesNo) = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        FormLoginPelanggan.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        If TnamaMeja.Text = "" Or CBMeja.Text = "" Then
            MsgBox("Isi Semua Data dengan Lengkap")
        Else
            CMD = New OleDbCommand("INSERT INTO TblMeja (id_meja,nama_meja,status_meja) VALUES ('" & TidMeja.Text & "','" & TnamaMeja.Text & "','" & CBMeja.Text & "')", Kon)
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Data Meja Berhasil Di Tambah")
                awal()
            Catch ex As Exception
                MsgBox("Data Telah Ada Silahkan Update Data")
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        koneksi()
        If TnamaMasakan.Text = "" Or ThargaMasakan.Text = "" Or CBKategori.Text = "" Or CBstatusMasakan.Text = "" Then
            MsgBox("Isi Semua Data dengan Lengkap")
        Else
            CMD = New OleDbCommand("INSERT INTO TblMasakan (id_masakan,nama_masakan,harga,kategori,status_masakan) VALUES ('" & TidMasakan.Text & "','" & TnamaMasakan.Text & "','" & ThargaMasakan.Text & "','" & CBKategori.Text & "','" & CBstatusMasakan.Text & "')", Kon)
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Data Masakan Berhasil di Tambah")
                awal()
            Catch ex As Exception
                MsgBox("Data Telah Ada Silahkan Update Data")
            End Try
        End If
    End Sub

    Private Sub DGVMEja_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMEja.CellClick
        klik = DGVMEja.CurrentRow.Index
        TidMeja.Text = DGVMEja(0, klik).Value
        TnamaMeja.Text = DGVMEja(1, klik).Value
        CBMeja.Text = DGVMEja(2, klik).Value
    End Sub

    Private Sub DGVMasakan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMasakan.CellClick
        klik = DGVMasakan.CurrentRow.Index
        TidMasakan.Text = DGVMasakan(0, klik).Value
        TnamaMasakan.Text = DGVMasakan(1, klik).Value
        ThargaMasakan.Text = DGVMasakan(2, klik).Value
        CBKategori.Text = DGVMasakan(3, klik).Value
        CBstatusMasakan.Text = DGVMasakan(4, klik).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TnamaMeja.Text = "" Or CBMeja.Text = "" Then
            MsgBox("Pilih Data yang Akan diubah")
        Else
            CMD = New OleDbCommand("UPDATE TblMeja SET nama_meja='" & TnamaMeja.Text & "', status_meja = '" & CBMeja.Text & "' WHERE id_meja = '" & TidMeja.Text & "'", Kon)
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diubah")
                awal()
            Catch ex As Exception
                MsgBox("Error, Harap Restart Aplikasi")
            End Try
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TnamaMasakan.Text = "" Or ThargaMasakan.Text = "" Then
            MsgBox("Pilih Data yang Akan Diubah")
        Else
            CMD = New OleDbCommand("UPDATE TblMasakan SET nama_masakan = '" & TnamaMasakan.Text & "', harga = '" & ThargaMasakan.Text & "', kategori='" & CBKategori.Text & "', status_masakan = '" & CBstatusMasakan.Text & "' WHERE id_masakan = '" & TidMasakan.Text & "'", Kon)
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diubah")
                awal()
            Catch ex As Exception
                MsgBox("Error, Harap Restart Aplikasi")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Yakin Hapus?", vbInformation + vbYesNo) = vbYes Then
            CMD = New OleDbCommand("DELETE FROM TblMeja WHERE id_meja = '" & TidMeja.Text & "'", Kon)
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Data Dihapus")
                awal()
            Catch ex As Exception
                MsgBox("Error, Harap Restart Aplikasi")
            End Try

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If MsgBox("Yakin Hapus?", vbInformation + vbYesNo) = vbYes Then
            CMD = New OleDbCommand("DELETE FROM TblMasakan WHERE id_masakan = '" & TidMasakan.Text & "'", Kon)
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Data Dihapus")
                awal()
            Catch ex As Exception
                MsgBox("Error, Harap Restart Aplikasi")
            End Try
        End If
    End Sub

    Private Sub DGVOederMasuk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOederMasuk.CellClick
        Dim namaPelanggan As String
        klik = DGVOederMasuk.CurrentRow.Index
        LId.Text = DGVOederMasuk(0, klik).Value
        LMeja.Text = DGVOederMasuk(1, klik).Value
        namaPelanggan = DGVOederMasuk(2, klik).Value
        koneksi()
        CMD = New OleDbCommand("SELECT nama_pelanggan FROM TblPelanggan WHERE id_pelanggan = '" & namaPelanggan & "'", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        LNama.Text = DR("nama_pelanggan")
        DR.Close()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If LMeja.Text = "" Then
            MsgBox("Pilih Data bYang Akan Dikonfirmasi")
        Else
            FormKonfirmasiOrder.Show()
        End If

    End Sub
End Class