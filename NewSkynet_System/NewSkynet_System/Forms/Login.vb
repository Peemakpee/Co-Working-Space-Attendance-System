Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username, password As String

        username = txtboxUsername.Text
        password = txtboxPassword.Text

        If username = "admin" And password = "admin" Then

            LoginSuccess(username)
            Me.Hide()
            Dashboard.Show()

        Else

            LoginFail(username)

        End If
    End Sub

End Class