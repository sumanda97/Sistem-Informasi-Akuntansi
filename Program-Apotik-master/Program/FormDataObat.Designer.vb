<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataObat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kdobat = New System.Windows.Forms.TextBox()
        Me.nmobat = New System.Windows.Forms.TextBox()
        Me.jenis = New System.Windows.Forms.ComboBox()
        Me.satuan = New System.Windows.Forms.ComboBox()
        Me.hrgjual = New System.Windows.Forms.TextBox()
        Me.hrgbeli = New System.Windows.Forms.TextBox()
        Me.stok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tgl = New System.Windows.Forms.DateTimePicker()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.batal = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.cari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Kadaluarsa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(365, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Obat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(365, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(655, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Jual"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(655, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Harga Beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(655, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Stok Obat"
        '
        'kdobat
        '
        Me.kdobat.Enabled = False
        Me.kdobat.Location = New System.Drawing.Point(178, 37)
        Me.kdobat.Name = "kdobat"
        Me.kdobat.Size = New System.Drawing.Size(152, 20)
        Me.kdobat.TabIndex = 8
        '
        'nmobat
        '
        Me.nmobat.Enabled = False
        Me.nmobat.Location = New System.Drawing.Point(178, 66)
        Me.nmobat.Name = "nmobat"
        Me.nmobat.Size = New System.Drawing.Size(152, 20)
        Me.nmobat.TabIndex = 9
        '
        'jenis
        '
        Me.jenis.Enabled = False
        Me.jenis.FormattingEnabled = True
        Me.jenis.Items.AddRange(New Object() {"Kapsul", "Tablet", "Puyer", "Cair", "Krim", "Racikan", "OYEJOSS"})
        Me.jenis.Location = New System.Drawing.Point(461, 33)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(164, 21)
        Me.jenis.TabIndex = 11
        '
        'satuan
        '
        Me.satuan.Enabled = False
        Me.satuan.FormattingEnabled = True
        Me.satuan.Items.AddRange(New Object() {"Strip", "Botol", "Pcs", "Keping", "Kotak", "Racikan"})
        Me.satuan.Location = New System.Drawing.Point(461, 65)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(164, 21)
        Me.satuan.TabIndex = 12
        '
        'hrgjual
        '
        Me.hrgjual.Enabled = False
        Me.hrgjual.Location = New System.Drawing.Point(760, 33)
        Me.hrgjual.Name = "hrgjual"
        Me.hrgjual.Size = New System.Drawing.Size(150, 20)
        Me.hrgjual.TabIndex = 13
        '
        'hrgbeli
        '
        Me.hrgbeli.Enabled = False
        Me.hrgbeli.Location = New System.Drawing.Point(760, 65)
        Me.hrgbeli.Name = "hrgbeli"
        Me.hrgbeli.Size = New System.Drawing.Size(150, 20)
        Me.hrgbeli.TabIndex = 14
        '
        'stok
        '
        Me.stok.Enabled = False
        Me.stok.Location = New System.Drawing.Point(760, 96)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(150, 20)
        Me.stok.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(32, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cari Obat / Hapus"
        '
        'tgl
        '
        Me.tgl.Location = New System.Drawing.Point(178, 99)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(152, 20)
        Me.tgl.TabIndex = 17
        '
        'tcari
        '
        Me.tcari.Location = New System.Drawing.Point(35, 184)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(295, 20)
        Me.tcari.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(32, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(328, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "*) Silahkan Ketikan Berdasarkan Kode Atau Nama"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(801, 243)
        Me.DataGridView1.TabIndex = 26
        '
        'batal
        '
        Me.batal.Image = Global.Program_Apotik.My.Resources.Resources._error
        Me.batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.batal.Location = New System.Drawing.Point(831, 153)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(79, 51)
        Me.batal.TabIndex = 24
        Me.batal.Text = "  Batal"
        Me.batal.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Image = Global.Program_Apotik.My.Resources.Resources.save
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.simpan.Location = New System.Drawing.Point(746, 153)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(79, 51)
        Me.simpan.TabIndex = 23
        Me.simpan.Text = "      Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Image = Global.Program_Apotik.My.Resources.Resources.delete
        Me.hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hapus.Location = New System.Drawing.Point(663, 153)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(79, 51)
        Me.hapus.TabIndex = 22
        Me.hapus.Text = "    Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Image = Global.Program_Apotik.My.Resources.Resources.edit
        Me.ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ubah.Location = New System.Drawing.Point(578, 152)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(79, 51)
        Me.ubah.TabIndex = 21
        Me.ubah.Text = "  Ubah"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Image = Global.Program_Apotik.My.Resources.Resources.round_add_button
        Me.tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tambah.Location = New System.Drawing.Point(493, 152)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(79, 51)
        Me.tambah.TabIndex = 20
        Me.tambah.Text = "Tambah"
        Me.tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tambah.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cari.Image = Global.Program_Apotik.My.Resources.Resources.magnifying_glass_with_check_mark_2_
        Me.cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cari.Location = New System.Drawing.Point(336, 167)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(34, 36)
        Me.cari.TabIndex = 19
        Me.cari.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cari.UseVisualStyleBackColor = True
        '
        'FormDataObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(920, 521)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.tcari)
        Me.Controls.Add(Me.tgl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.hrgbeli)
        Me.Controls.Add(Me.hrgjual)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.jenis)
        Me.Controls.Add(Me.nmobat)
        Me.Controls.Add(Me.kdobat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDataObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDataObat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents kdobat As System.Windows.Forms.TextBox
    Friend WithEvents nmobat As System.Windows.Forms.TextBox
    Friend WithEvents jenis As System.Windows.Forms.ComboBox
    Friend WithEvents satuan As System.Windows.Forms.ComboBox
    Friend WithEvents hrgjual As System.Windows.Forms.TextBox
    Friend WithEvents hrgbeli As System.Windows.Forms.TextBox
    Friend WithEvents stok As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents cari As System.Windows.Forms.Button
    Friend WithEvents tambah As System.Windows.Forms.Button
    Friend WithEvents ubah As System.Windows.Forms.Button
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents batal As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
