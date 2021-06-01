Public Class ayarlar

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        güncellemesıfır.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        pchakkında.Show()

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub İCloBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AyarlarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        pchakkında.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        güncellemesıfır.Show()

    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dbs.Show()

    End Sub

    Private Sub PCHakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PCHakkındaToolStripMenuItem.Click
        pchakkında.Show()
    End Sub

    Private Sub GüncelleVeyaSıfırlaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GüncelleVeyaSıfırlaToolStripMenuItem.Click
        güncellemesıfır.Show()
    End Sub
End Class