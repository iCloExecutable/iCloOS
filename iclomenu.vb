Public Class iclomenu

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripMenuItem1.Text = TimeOfDay
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub İCloBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İCloBrowserToolStripMenuItem.Click
        iclobrowserapp.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        iclobrowserapp.Show()

    End Sub

    Private Sub AyarlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyarlarToolStripMenuItem.Click
        ayarlar.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class