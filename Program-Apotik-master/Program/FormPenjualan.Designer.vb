<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.Info = New System.Windows.Forms.DataGridView()
        Me.HrgJual = New System.Windows.Forms.TextBox()
        Me.Qty = New System.Windows.Forms.TextBox()
        Me.Stok = New System.Windows.Forms.TextBox()
        Me.Satuan = New System.Windows.Forms.TextBox()
        Me.NamaObat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tambah = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.cetak = New System.Windows.Forms.Button()
        Me.nota = New System.Windows.Forms.TextBox()
        Me.tgljual = New System.Windows.Forms.DateTimePicker()
        Me.cari = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Nota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Kode)
        Me.Panel1.Controls.Add(Me.cari)
        Me.Panel1.Controls.Add(Me.Info)
        Me.Panel1.Controls.Add(Me.HrgJual)
        Me.Panel1.Controls.Add(Me.Qty)
        Me.Panel1.Controls.Add(Me.Stok)
        Me.Panel1.Controls.Add(Me.Satuan)
        Me.Panel1.Controls.Add(Me.NamaObat)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(25, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 234)
        Me.Panel1.TabIndex = 2
        '
        'Kode
        '
        Me.Kode.Location = New System.Drawing.Point(20, 36)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(160, 20)
        Me.Kode.TabIndex = 21
        '
        'Info
        '
        Me.Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Info.Location = New System.Drawing.Point(20, 78)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(743, 118)
        Me.Info.TabIndex = 15
        '
        'HrgJual
        '
        Me.HrgJual.Location = New System.Drawing.Point(535, 36)
        Me.HrgJual.Name = "HrgJual"
        Me.HrgJual.Size = New System.Drawing.Size(102, 20)
        Me.HrgJual.TabIndex = 14
        '
        'Qty
        '
        Me.Qty.Location = New System.Drawing.Point(643, 36)
        Me.Qty.Name = "Qty"
        Me.Qty.Size = New System.Drawing.Size(120, 20)
        Me.Qty.TabIndex = 13
        '
        'Stok
        '
        Me.Stok.Location = New System.Drawing.Point(462, 36)
        Me.Stok.Name = "Stok"
        Me.Stok.Size = New System.Drawing.Size(67, 20)
        Me.Stok.TabIndex = 12
        '
        'Satuan
        '
        Me.Satuan.Location = New System.Drawing.Point(378, 36)
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Size = New System.Drawing.Size(78, 20)
        Me.Satuan.TabIndex = 11
        '
        'NamaObat
        '
        Me.NamaObat.Location = New System.Drawing.Point(257, 36)
        Me.NamaObat.Name = "NamaObat"
        Me.NamaObat.Size = New System.Drawing.Size(115, 20)
        Me.NamaObat.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(665, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Kuantitas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(558, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(472, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(378, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(266, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kode Obat"
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(617, 12)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(182, 29)
        Me.tambah.TabIndex = 3
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(617, 47)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(182, 29)
        Me.simpan.TabIndex = 4
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'batal
        '
        Me.batal.Location = New System.Drawing.Point(617, 82)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(182, 29)
        Me.batal.TabIndex = 5
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(522, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "TOTAL"
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(588, 363)
        Me.Total.Multiline = True
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(211, 62)
        Me.Total.TabIndex = 7
        '
        'cetak
        '
        Me.cetak.Location = New System.Drawing.Point(25, 365)
        Me.cetak.Name = "cetak"
        Me.cetak.Size = New System.Drawing.Size(227, 29)
        Me.cetak.TabIndex = 8
        Me.cetak.Text = "Cetak Nota"
        Me.cetak.UseVisualStyleBackColor = True
        '
        'nota
        '
        Me.nota.Location = New System.Drawing.Point(103, 27)
        Me.nota.Name = "nota"
        Me.nota.Size = New System.Drawing.Size(193, 20)
        Me.nota.TabIndex = 16
        '
        'tgljual
        '
        Me.tgljual.Location = New System.Drawing.Point(103, 75)
        Me.tgljual.Name = "tgljual"
        Me.tgljual.Size = New System.Drawing.Size(245, 20)
        Me.tgljual.TabIndex = 17
        '
        'cari
        '
        Me.cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cari.Image = Global.Program_Apotik.My.Resources.Resources.magnifying_glass_with_check_mark_2_
        Me.cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cari.Location = New System.Drawing.Point(186, 20)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(34, 36)
        Me.cari.TabIndex = 20
        Me.cari.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cari.UseVisualStyleBackColor = True
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 484)
        Me.Controls.Add(Me.tgljual)
        Me.Controls.Add(Me.nota)
        Me.Controls.Add(Me.cetak)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HrgJual As System.Windows.Forms.TextBox
    Friend WithEvents Qty As System.Windows.Forms.TextBox
    Friend WithEvents Stok As System.Windows.Forms.TextBox
    Friend WithEvents Satuan As System.Windows.Forms.TextBox
    Friend WithEvents NamaObat As System.Windows.Forms.TextBox
    Friend WithEvents tambah As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents batal As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Info As System.Windows.Forms.DataGridView
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents cetak As System.Windows.Forms.Button
    Friend WithEvents nota As System.Windows.Forms.TextBox
    Friend WithEvents tgljual As System.Windows.Forms.DateTimePicker
    Friend WithEvents cari As System.Windows.Forms.Button
    Friend WithEvents Kode As System.Windows.Forms.TextBox
End Class
