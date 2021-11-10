Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > Val(TextBox2.Text) Then
            TextBox3.Text = "El primer valoor es mayor que el segundo"
        ElseIf Val(TextBox1.Text) < Val(TextBox2.Text) Then
            TextBox3.Text = "El segundo valor es mayor que el segundo"
        ElseIf Val(TextBox1.Text) = Val(TextBox2.Text) Then
            TextBox3.Text = "Ambos tienen el mismo valor"


        End If
    End Sub
End Class
