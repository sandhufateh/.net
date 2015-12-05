Public Class Form1
    Private Sub opration_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub result1_TextChanged(sender As Object, e As EventArgs) Handles result1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        result1.Text = Val(num1.Text) / Val(num2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        result1.Text = Val(num1.Text) + Val(num2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        result1.Text = Val(num1.Text) * Val(num2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        result1.Text = Val(num1.Text) - Val(num2.Text)
    End Sub

    Private Sub operation_CheckedChanged(sender As Object, e As EventArgs)
        result1.Text = Val(num1.Text) + Val(num2.Text)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim int1 = Val(num1_1.Text) + 1
        Dim int2 = Val(num2_1.Text) - 1
        Dim int = 0
        Dim sum = 0
        For int = int1 To int2
            sum = int + sum
        Next
        result2.Text = sum
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        calculate()
    End Sub

    Private Sub calculate()
        Dim result = 0
        Dim int1_1 = Val(num1.Text)
        Dim int2_1 = Val(num2.Text)
        If (RadioButton1.Checked) Then
            result = int1_1 + int2_1
        End If
        If (RadioButton2.Checked) Then
            result = int1_1 - int2_1
        End If
        If (RadioButton3.Checked) Then
            result = int1_1 * int2_1
        End If
        If (RadioButton4.Checked) Then
            result = int1_1 / int2_1
        End If

        result1.Text = result
    End Sub
End Class
