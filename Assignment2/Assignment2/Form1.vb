Public Class Form1
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles blue.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles yellow.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generateMessage()
    End Sub

    Private Sub generateMessage()
        Dim nameStr As String = ""
        Dim mySex As String = ""
        Dim colorArr As String = ""
        Dim birthDate As String = ""
        Dim age As String = ""

        nameStr = TextBox1.Text.ToString()
        birthDate = dateOfBirth.Text.ToString()
        age = ComboBox1.Text.ToString()
        If (male.Checked) Then
            mySex = "male"
        End If
        If (female.Checked) Then
            mySex = "female"
        End If
        If (red.Checked) Then
            colorArr += "red "
        End If
        If (blue.Checked) Then
            colorArr += "blue "
        End If
        If (yellow.Checked) Then
            colorArr += "yellow "
        End If
        If (green.Checked) Then
            colorArr += "green "
        End If

        MessageBox.Show("My name is " + nameStr + " I am " + age + " years old, I am a " + mySex + " Born on " + birthDate + " My favorite colors are " + colorArr)
    End Sub
End Class
