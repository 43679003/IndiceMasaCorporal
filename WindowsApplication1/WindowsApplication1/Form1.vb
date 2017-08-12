Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim peso, altura As Double
        peso = Val(TextBox1.Text)
        altura = Val(TextBox2.Text)


        TextBox3.Text = peso / (altura * altura)

        If TextBox3.Text > 18.5 And TextBox3.Text < 24.9 Then
            LinkLabel1.Text = "PROMEDIO"
        End If

        If TextBox3.Text > 25 And TextBox3.Text < 29.9 Then
            LinkLabel1.Text = "AUMENTADO"
        End If

        If TextBox3.Text > 30 And TextBox3.Text < 34.9 Then
            LinkLabel1.Text = "MODERADO"
        End If

        If TextBox3.Text > 35 And TextBox3.Text < 39.9 Then
            LinkLabel1.Text = "SEVERO"
        End If

        If TextBox3.Text >= 40 Then
            LinkLabel1.Text = "MUY SEVERO"
        End If










    End Sub
End Class
