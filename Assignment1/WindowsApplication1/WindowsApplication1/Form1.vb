Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles multiply.Click
        result.Text = Val(num1.Text) * Val(num2.Text)
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        result.Text = Val(num1.Text) + Val(num2.Text)
    End Sub

    Private Sub subtract_Click(sender As Object, e As EventArgs) Handles subtract.Click
        result.Text = Val(num1.Text) - Val(num2.Text)
    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        result.Text = Val(num1.Text) / Val(num2.Text)
    End Sub
End Class
