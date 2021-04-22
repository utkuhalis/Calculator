Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Sonuç: " & Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = "Sonuç: " & Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = "Sonuç: " & Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label1.Text = "Sonuç: " & Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub
End Class
