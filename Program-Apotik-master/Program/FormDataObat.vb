Imports MySql.Data.MySqlClient
Public Class FormDataObat
    Private Sub FormDataObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        koneksi_oke()
        Call tampil()
    End Sub
    Sub delete()
        Call koneksi_oke()
        If tcari.Text = "" Then
            kdobat.Enabled = False
            nmobat.Enabled = False
            satuan.Enabled = False
            jenis.Enabled = False
            hrgbeli.Enabled = False
            hrgjual.Enabled = False
            stok.Enabled = False
            tambah.Enabled = False
            ubah.Enabled = False
            simpan.Enabled = False
            tcari.Focus()
            MessageBox.Show("Tolong Isi Kode Obat", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                cmd = New MySqlCommand("delete from tbobat where NamaObat = '" & tcari.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil DiHapus", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bersih()
                tampil()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
            
    Sub tampil()
        da = New MySqlDataAdapter("select * from tbobat", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbobat")
        DataGridView1.DataSource = (ds.Tables("tbobat"))
        DataGridView1.Columns(7).Width = 129
    End Sub
    Sub bersih()
        kdobat.Text = ""
        nmobat.Text = ""
        jenis.Text = ""
        satuan.Text = ""
        hrgbeli.Text = ""
        hrgjual.Text = ""
        stok.Text = ""
        kdobat.Focus()
    End Sub

    Sub Mulai()
        kdobat.Enabled = True
        nmobat.Enabled = True
        jenis.Enabled = True
        satuan.Enabled = True
        hrgbeli.Enabled = True
        hrgjual.Enabled = True
        stok.Enabled = True
        kdobat.Focus()
    End Sub



    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        kdobat.Enabled = True
        nmobat.Enabled = True
        jenis.Enabled = True
        satuan.Enabled = True
        hrgbeli.Enabled = True
        hrgjual.Enabled = True
        stok.Enabled = True
        Call bersih()
        kdobat.Focus()
    End Sub


    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        Try
            If kdobat.Text = "" Then MsgBox("Kode Obat Harus Diisi..!", MsgBoxStyle.Critical, "Pesan Kesalahan") : Exit Sub
            If nmobat.Text = "" Then MsgBox("Nama Obat Harus Diisi..!", MsgBoxStyle.Critical, "Pesan Kesalahan") : Exit Sub
            If jenis.Text = "" Then MsgBox("Jenis Obat Harus Diisi..!", MsgBoxStyle.Critical, "Pesan Kesalahan") : Exit Sub
            If satuan.Text = "" Then MsgBox("Satuan Obat Harus Diisi..!", MsgBoxStyle.Critical, "Pesan Kesalahan") : Exit Sub
            If hrgbeli.Text = "" Then MsgBox("Harga Beli Obat Harus Diisi..!", MsgBoxStyle.Critical, "Pesan Kesalahan") : Exit Sub
            If hrgjual.Text = "" Then MsgBox("Harga Jual Obat Harus Diisi..!", MsgBoxStyle.Critical, "Pesan Kesalahan") : Exit Sub
            If stok.Text = "" Then MsgBox("Stok Obat Harus Diisi..!", MsgBoxStyle.Critical, "Pesan Kesalahan") : Exit Sub
                sql = "insert into tbobat value('" & kdobat.Text & "','" & nmobat.Text & "','" & Format(tgl.Value, "yyyy-MM-dd") & "','" & jenis.Text & "','" & satuan.Text & "','" & hrgjual.Text & "','" & hrgbeli.Text & "','" & stok.Text & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan")
                Call bersih()
                Call tampil()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        Call delete()
    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        stok.Enabled = True
        tambah.Enabled = True
        ubah.Enabled = True
        simpan.Enabled = True
    End Sub

    Private Sub ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubah.Click
        sql = "UPDATE tbobat SET NamaObat='" & nmobat.Text & "'," & _
                    " Jenis='" & jenis.Text & "'," &
                    " Satuan='" & satuan.Text & "'," & _
                    " HargaJual='" & hrgjual.Text & "'," & _
                    " HargaBeli='" & hrgbeli.Text & "'," & _
                    " Stok='" & stok.Text & "' " & _
                    " Where KodeObat='" & kdobat.Text & "'"
        MsgBox("Data Berhasil Di Update")

        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        Call tambah_Click(sender, e)
        Call tampil()
    End Sub

    Private Sub cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.Click
        
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        Call koneksi_oke()
        cmd = New MySqlCommand("select * from tbobat where NamaObat like '%" & tcari.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi_oke()
            da = New MySqlDataAdapter("select* from tbobat where NamaObat like '%" & tcari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            kdobat.Clear()
            nmobat.Clear()

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            kdobat.Text = row.Cells(0).Value.ToString()
            nmobat.Text = row.Cells(1).Value.ToString()
            tgl.Text = row.Cells(2).Value.ToString()
            jenis.Text = row.Cells(3).Value.ToString()
            satuan.Text = row.Cells(4).Value.ToString()
            hrgjual.Text = row.Cells(5).Value.ToString()
            hrgbeli.Text = row.Cells(6).Value.ToString()
            stok.Text = row.Cells(7).Value.ToString()
        Catch ex As Exception
            Call tampil()
        End Try
    End Sub
End Class