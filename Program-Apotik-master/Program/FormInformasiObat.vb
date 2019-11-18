Imports MySql.Data.MySqlClient
Public Class FormInformasiObat
    Sub tampil()
        da = New MySqlDataAdapter("select * from tbobat", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbobat")
        GridInfo.DataSource = (ds.Tables("tbobat"))
    End Sub
    Private Sub cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.Click
        
    End Sub
    Private Sub FormInformasiObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi_oke()
        Call tampil()
    End Sub


    Private Sub Jns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jns.Click

    End Sub

    Private Sub Criobt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Criobt.TextChanged
        Call koneksi_oke()
        cmd = New MySqlCommand("select * from tbobat where NamaObat like '%" & Criobt.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi_oke()
            da = New MySqlDataAdapter("select* from tbobat where NamaObat like '%" & Criobt.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            GridInfo.DataSource = ds.Tables(0)
        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub GridInfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridInfo.CellContentClick
        Call koneksi_oke()
        Dim i As Integer
        i = Me.GridInfo.CurrentRow.Index
        cmd = New MySqlCommand("Select * from tbobat where NamaObat='" & GridInfo.Item(0, i).Value & "'", conn)
        If GridInfo.Rows.Count > 0 Then
            Dim f As New FormPenjualan
        End If
        On Error Resume Next
        FormPenjualan.Kode.Text = GridInfo.Rows(e.RowIndex).Cells(0).Value
        FormPenjualan.NamaObat.Text = GridInfo.Rows(e.RowIndex).Cells(1).Value
        FormPenjualan.Satuan.Text = GridInfo.Rows(e.RowIndex).Cells(4).Value
        FormPenjualan.HrgJual.Text = GridInfo.Rows(e.RowIndex).Cells(5).Value
        FormPenjualan.Stok.Text = GridInfo.Rows(e.RowIndex).Cells(7).Value
        FormPenjualan.NamaObat.Enabled = False
        FormPenjualan.Satuan.Enabled = False
        FormPenjualan.Stok.Enabled = False
        FormPenjualan.Show()
        Me.Close()
    End Sub

End Class

