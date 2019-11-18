Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormInputBiaya
    Sub Bersih()
        Kode.Text = ""
        Nama.Text = ""
        Ket.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sql = "insert into tbdatabiaya value('" & Kode.Text & "','" & Nama.Text & "','" & Ket.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            Call Bersih()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class