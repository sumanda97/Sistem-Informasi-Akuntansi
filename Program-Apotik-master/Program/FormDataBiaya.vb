Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FormDataBiaya
    Sub tampil()
        da = New MySqlDataAdapter("select * from tbdatabiaya", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbdatabiaya")
        databiaya.DataSource = (ds.Tables("tbdatabiaya"))
        databiaya.Columns(0).Width = 50
        databiaya.Columns(1).Width = 100
        databiaya.Columns(2).Width = 750

    End Sub
    Private Sub showBiaya()
        Dim Tabel As New FormInputBiaya
        Call koneksi_oke()
        FormInputBiaya.ShowDialog()
    End Sub
    Private Sub FormDataBiaya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        koneksi_oke()
        Call tampil()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call showBiaya()
        Call tampil()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormEditBiaya.Kode.Text = databiaya.Item(0, databiaya.CurrentRow.Index).Value
        Try
            FormEditBiaya.ShowDialog()
            Call tampil()
        Catch ex As Exception
            Call tampil()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String = databiaya.Item(0, databiaya.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Yang Akan di hapus belum DIPILIH")
        Else
            Try
                If (MessageBox.Show("Anda Yakin Ingin Menghapus Data Dengan Kode = " & a & "....?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                    koneksi_oke()
                    cmd = New MySqlCommand("delete from tbdatabiaya where kode='" & a & "'", conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Menghapus data BERHASIL", vbInformation, "Informasi")
                    conn.Close()
                    tampil()
                End If
            Catch ex As Exception
                MsgBox("Menghapus data GAGAL", vbInformation, "Informasi")
            End Try

        End If
    End Sub

    Private Sub databiaya_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles databiaya.CellContentClick

    End Sub
End Class