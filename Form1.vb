Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstnumber As Double
        Dim secondnumber As Double

        firstnumber = Val(TextBox1.Text)
        secondnumber = Val(TextBox2.Text)

        If firstnumber > secondnumber Then
            TextBox3.Text = firstnumber
        Else
            TextBox3.Text = secondnumber
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
