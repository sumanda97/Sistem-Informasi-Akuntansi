Public Class FormMenu
    Sub switch(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Panel1.Dock = DockStyle.Fill
    End Sub

    Private Sub DATAOBATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAOBATToolStripMenuItem.Click
        switch(FormDataObat)
    End Sub

    Private Sub PENJUALANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENJUALANToolStripMenuItem.Click
        switch(FormPenjualan)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DATABIAYAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATABIAYAToolStripMenuItem.Click
        switch(FormDataBiaya)
    End Sub
End Class