Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mont As Double
        Dim desc As Double
        Dim cuentt As Double
        mont = Me.TextBox1.Text

        If mont <= 1000 Then
            desc = 5
            cuentt = mont * 0.95
        ElseIf mont > 1000 And mont <= 7000 Then
            desc = 11
            cuentt = mont * 0.89
        ElseIf mont > 7000 And mont <= 1500 Then
            desc = 18
            cuentt = mont * 0.82
        ElseIf mont > 1500 Then
            desc = 25
            cuentt = mont * 0.75
        End If
        TextBox2.Text = CStr(desc)
        TextBox3.Text = CStr(cuentt)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = “ ”
        TextBox2.Text = “ ”
        TextBox3.Text = “ ”

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class
