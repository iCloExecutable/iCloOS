Public Class iclomenu
    Public Function isConnectionAvailable() As Boolean
        Dim objURL As New System.Uri("http://iclostudios.ml")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objURL)
        Dim objResp As System.Net.WebResponse
        Try
            objResp = objWebReq.GetResponse
            objResp.Close()
            objResp = Nothing
            Return True
        Catch ex As Exception
            objResp = Nothing
            objWebReq = Nothing
            Return False


        End Try
    End Function
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Date.Now.ToString("HH:mm:ss")
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
        ayarlar.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ayarlar.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        mail.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        mail.Show()

    End Sub

    Private Sub İCloMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İCloMailToolStripMenuItem.Click
        mail.Show()

    End Sub

    Private Sub AssistantbetaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        assistant.Show()


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        assistant.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        assistant.Show()

    End Sub

    Private Sub ProgramlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramlarToolStripMenuItem.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Form3.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        browser.Show()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        browser.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If isConnectionAvailable() = True Then
            MsgBox("You are connected to internet")
        Else
            MsgBox("No wifi")
        End If
    End Sub

    Private Sub FileBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileBrowserToolStripMenuItem.Click
        browser.Show()
    End Sub
End Class