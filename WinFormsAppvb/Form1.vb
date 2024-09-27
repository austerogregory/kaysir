Public Class Form1
    Dim usernames() As String = {"mark", "rashed", "user3", "user4", "user5"}
    Dim passwords() As String = {"austero", "carnain", "pass3", "pass4", "pass5"}
    Dim attempts As Integer = 3

    Private Function IsLoginValid(ByVal username As String, ByVal password As String) As Boolean
        For i As Integer = 0 To usernames.Length - 1
            If username = usernames(i) AndAlso password = passwords(i) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If attempts > 0 Then
            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text

            If IsLoginValid(username, password) Then
                lblMessage.Text = "LOGIN SUCCESSFUL!"
                lblMessage.ForeColor = Color.Green
            Else
                attempts -= 1
                lblMessage.Text = "INCORRECT USERNAME OR PASSWORD! " & attempts & " ATTEMPTS LEFT!"
                lblMessage.ForeColor = Color.Red
            End If

            If attempts = 0 Then
                btnLogin.Enabled = False
                lblMessage.Text = "HACKER GET OUT!"
            End If
        End If
    End Sub
End Class
