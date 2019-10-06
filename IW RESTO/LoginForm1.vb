Imports System.Data.OleDb
Public Class LoginForm1
    Sub Awal()
        Tusername.Text = ""
        Tpassword.Text = ""
        Tusername.Focus()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Call koneksi()
        CMD = New OleDbCommand("select * from TblUser where user_name='" & Tusername.Text & "' and pwd_user='" & Tpassword.Text & "'", Kon)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            MsgBox("Login gagal")
            Awal()
            Exit Sub
        Else
            Me.Visible = False
            FormPetugas.Show()
            Awal()

            
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
