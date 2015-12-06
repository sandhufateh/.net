Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Registration' table. You can move, or remove it, as needed.

        Me.RegistrationTableAdapter.Fill(Me.StudentDataSet.Registration)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Data Source=LAPTOP-2AI7V3MM\SQLEXPRESS;Initial Catalog=Student;Integrated Security=trueì
        Dim queryString As String = "INSERT INTO Registration (Firstname, Lastname) values (@FName,@LName)ì
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim command As New SqlCommand(queryString, connection)
                command.Parameters.AddWithValue("@FName", TextBox1.Text)
                command.Parameters.AddWithValue("@LName", TextBox2.Text)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Exception : " + ex.ToString)
        End Try
        Me.RegistrationTableAdapter.Fill(Me.StudentDataSet.Registration)
    End Sub
End Class
