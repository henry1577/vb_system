Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Hi! Welcome to visual basix " & TextBox1.Text)
        Label2.Text = "Hi! Welcome to visual basix " & TextBox1.Text & Label6.Text



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label6.Text = TextBox2.Text - TextBox3.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Clear()
        TextBox3.Clear()
        ' set the text property of label 6 to an empty string
        Label6.Text = "" 'or Label.16.Text= String.Empty

        'transfer the cursor to the textbox
        TextBox2.Focus()

    End Sub
End Class