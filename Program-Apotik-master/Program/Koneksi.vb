Imports System.Data.OleDb
Imports mysql.data.mysqlclient
Module Koneksi
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public str, sql As String
    Public hasil As Integer
    Public database As New MySqlConnection
    Public dr As MySqlDataReader
    Public tampil As New MySql.Data.MySqlClient.MySqlCommand
    Public tampikan As MySql.Data.MySqlClient.MySqlDataReader
    Public cari As OleDbDataReader
    Public simpan, ubah, hapus, edit, batal As String
    Public dml As OleDbCommand
    Public jrex As Integer

    Public Sub koneksi_oke()
        Try
            Dim con As New MySqlConnection("server=localhost; username=root; password=; database=dbapotik; SslMode=;")
            Dim str As String = "Server=localhost;username=root;password=;database=dbapotik;Convert Zero Datetime=True"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
