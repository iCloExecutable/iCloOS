﻿Public Class Form2

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.kullanıcı = TextBox3.Text
        My.Settings.şifre = TextBox2.Text
        My.Settings.doğum = TextBox1.Text
        My.Settings.Save()
        MsgBox("Aramıza Hoşgeldin" & My.Settings.kullanıcı)


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class