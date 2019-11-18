Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi_oke()
    End Sub

    Private Sub masuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles masuk.Click
        Dim username, password, level As String
        username = vuser.Text
        password = vpass.Text
        level = vlevel.SelectedItem
        sql = "select * from user where username='" + username + "' and password= '" + password + "' and level= '" + level + "'"
        cmd = New MySqlCommand(sql, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
        If level = "Karyawan" Then
            FormMenu.DATAToolStripMenuItem.Enabled = True
            FormMenu.TRANSAKSIToolStripMenuItem.Enabled = True
            FormMenu.LAPORANToolStripMenuItem.Enabled = False
            FormMenu.Show()
            Me.Hide()
        ElseIf level = "Pimpinan" Then
            FormMenu.DATAToolStripMenuItem.Enabled = False
            FormMenu.TRANSAKSIToolStripMenuItem.Enabled = True
            FormMenu.LAPORANToolStripMenuItem.Enabled = True
            FormMenu.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Hak Akses Salah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        rd.Close()
        cmd.Dispose()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If vpass.UseSystemPasswordChar = True Then
            ' Sembunyikan Password
            vpass.UseSystemPasswordChar = False
        Else
            ' Menampilkan Password
            vpass.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

    Private Sub vuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuser.TextChanged

    End Sub
End Class