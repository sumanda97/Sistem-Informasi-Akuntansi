<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInformasiObat
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
        Me.Jns = New System.Windows.Forms.Label()
        Me.GridInfo = New System.Windows.Forms.DataGridView()
        Me.cari = New System.Windows.Forms.Button()
        Me.Criobt = New System.Windows.Forms.TextBox()
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Jns
        '
        Me.Jns.AutoSize = True
        Me.Jns.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jns.ForeColor = System.Drawing.Color.White
        Me.Jns.Location = New System.Drawing.Point(12, 31)
        Me.Jns.Name = "Jns"
        Me.Jns.Size = New System.Drawing.Size(122, 22)
        Me.Jns.TabIndex = 0
        Me.Jns.Text = "Nama Obat"
        '
        'GridInfo
        '
        Me.GridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridInfo.Location = New System.Drawing.Point(12, 56)
        Me.GridInfo.Name = "GridInfo"
        Me.GridInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridInfo.Size = New System.Drawing.Size(749, 324)
        Me.GridInfo.TabIndex = 1
        '
        'cari
        '
        Me.cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cari.Image = Global.Program_Apotik.My.Resources.Resources.magnifying_glass_with_check_mark_2_
        Me.cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cari.Location = New System.Drawing.Point(378, 12)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(34, 36)
        Me.cari.TabIndex = 20
        Me.cari.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cari.UseVisualStyleBackColor = True
        '
        'Criobt
        '
        Me.Criobt.Location = New System.Drawing.Point(138, 28)
        Me.Criobt.Name = "Criobt"
        Me.Criobt.Size = New System.Drawing.Size(234, 20)
        Me.Criobt.TabIndex = 21
        '
        'FormInformasiObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 390)
        Me.Controls.Add(Me.Criobt)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.GridInfo)
        Me.Controls.Add(Me.Jns)
        Me.Name = "FormInformasiObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInformasiObat"
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Jns As System.Windows.Forms.Label
    Friend WithEvents GridInfo As System.Windows.Forms.DataGridView
    Friend WithEvents cari As System.Windows.Forms.Button
    Friend WithEvents Criobt As System.Windows.Forms.TextBox
End Class
