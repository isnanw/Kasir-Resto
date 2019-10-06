Imports System.Data.OleDb
Public Class FormLogin
    Sub Awal()
        TUsername.Text = ""
        TPassword.Text = ""
        TUsername.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        CMD = New OleDbCommand("select * from TblUser where username='" & TUsername.Text & "' and password='" & TPassword.Text & "'", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            MsgBox("Login gagal")
            Exit Sub
        Else
            Me.Visible = False
            FormPetugas.Show()


        End If
    End Sub
End Class