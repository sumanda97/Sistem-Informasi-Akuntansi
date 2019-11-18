Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Public Class FormPenjualan
    Dim stokc As Integer

    Sub tampil()
        da = New MySqlDataAdapter("select * from tbpenjualan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbpenjualan")
        Info.DataSource = (ds.Tables("tbpenjualan"))
        Info.Columns(0).Width = 120
        Info.Columns(1).Width = 80
        Info.Columns(3).Width = 50
        Info.Columns(4).Width = 80
        Info.Columns(5).Width = 80
        Info.Columns(6).Width = 100
        Info.Columns(7).Width = 120


    End Sub
    Sub bersih()
        Kode.Text = ""
        NamaObat.Text = ""
        Satuan.Text = ""
        Stok.Text = ""
        HrgJual.Text = ""
        Qty.Text = ""
        Total.Text = ""
        Kode.Focus()
    End Sub
    Private Sub AutoNomor()
        Call koneksi_oke()

        cmd = New MySqlCommand("Select * From tbpenjualan where Nota in(select max(Nota) from tbpenjualan) ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            nota.Text = Format(Today, "yyMMdd") +
            "001"
        Else
            If Microsoft.VisualBasic.Left(dr.Item("Nota"), 6) = Format(Today, "yyMMdd") Then
                nota.Text = dr.Item("Nota") + 1
            Else
                nota.Text = Format(Today, "yyMMdd") +
                "001"
            End If
        End If

    End Sub
    Private Sub Totalobat()
        Dim Tabel As New FormInformasiObat
        Call koneksi_oke()
        FormInformasiObat.ShowDialog()
    End Sub
    Private Sub showProduk()

        Dim Tabel As New FormInformasiObat
        Call koneksi_oke()
        FormInformasiObat.ShowDialog()
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub nota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nota.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        Call AutoNomor()
        simpan.Enabled = True
        batal.Enabled = True
    End Sub

    Private Sub FormPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        koneksi_oke()
        Call tampil()
        tambah.Enabled = True
        tambah.Focus()
        simpan.Enabled = False
        batal.Enabled = False
        nota.Enabled = False

    End Sub

    Private Sub cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.Click
        Call showProduk()
        tgljual.Text = Date.Now
    End Sub

    Private Sub Jenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Qty_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qty.Click
    End Sub

    Private Sub Qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty.TextChanged
        Total.Text = Format(Val(HrgJual.Text) * Val(Qty.Text), "Rp,###,###.")


    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        stokc = Stok.Text - Qty.Text
        Try
            sql = "insert into tbpenjualan value('" & nota.Text & "','" & Kode.Text & "','" & NamaObat.Text & "','" & Satuan.Text & "','" & stokc & "','" & HrgJual.Text & "','" & Qty.Text & "','" & Total.Text & "')"

            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")


            Call bersih()
            Call tampil()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Info_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Info.CellContentClick

    End Sub

    Private Sub Qty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Qty.KeyPress

    End Sub
End Class
