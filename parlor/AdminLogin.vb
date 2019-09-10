Public Class AdminLogin

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If username.Text = "admin" And password.Text = "passwordispassword" Then
            MsgBox("Login Successful")
            AdminPanel.Show()
        Else
            MsgBox("Check Username and Password")

        End If

        Me.Close()
    End Sub
End Class