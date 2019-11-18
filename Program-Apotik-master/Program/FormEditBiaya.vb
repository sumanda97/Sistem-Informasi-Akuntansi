Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FormEditBiaya
    Sub ketemu()
        koneksi_oke()
        cmd = New MySqlCommand("select * from tbdatabiaya where kode like '" & Kode.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Nama.Text = dr.Item(1)
            Ket.Text = dr.Item(2)
        Else
            MsgBox("Data TIDAK DITEMUKAN", vbInformation, "Informasi")
        End If
        conn.Close()
    End Sub
    Sub Reset()
        Kode.Text = ""
        Nama.Text = ""
        Ket.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi_oke()
        sql = "UPDATE tbdatabiaya SET nama='" & Nama.Text & "'," & _
            " keterangan='" & Ket.Text & "'" & _
        " Where Kode='" & Kode.Text & "'"

        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Data Berhasil Di Update")
            FormDataBiaya.tampil()
            Reset()
            Me.Close()
        Catch ex As Exception
            MsgBox("Data Gagal Di Update")
        End Try
        conn.Close()
    End Sub

    Private Sub FormEditBiaya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ketemu()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class