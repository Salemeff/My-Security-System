Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtPass.PasswordChar = ""
        txtUser.Text = "Username"
        txtPass.Text = "Password"
        txtUser.ForeColor = Color.LightGray
        txtPass.ForeColor = Color.LightGray
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        txtPass.PasswordChar = "*"
        If txtPass.ForeColor = Color.LightGray Then
            lblPass.Visible = True
            txtPass.Text = ""
            txtPass.ForeColor = Color.Black
        End If
        If txtUser.Text = "" Then
            txtUser.ForeColor = Color.LightGray
            txtUser.Text = "Username"
            lblUser.Visible = False
        End If
    End Sub

    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        If txtUser.ForeColor = Color.LightGray Then
            lblUser.Visible = True
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
        If txtPass.Text = "" Then
            txtPass.ForeColor = Color.LightGray
            txtPass.PasswordChar = ""
            txtPass.Text = "Password"
            lblPass.Visible = False
        End If
    End Sub
    Private Sub ShwPass_CheckedChanged(sender As Object, e As EventArgs) Handles ShwPass.CheckedChanged
        If ShwPass.Checked = True Then
            txtPass.PasswordChar = ""
            txtPass.Text = txtPass.Text
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "Username" And txtPass.Text = "Password" Then
            MsgBox("please fill all empty fields")
        ElseIf txtUser.Text = "Username" Or txtPass.Text = "Password" Then
            MsgBox("Fill the empty field")
        ElseIf txtUser.Text = "" Then
            MsgBox("Field cannot be empty")
        ElseIf txtPass.Text = "" Then
            MsgBox("Field cannot be empty")
        ElseIf txtUser.Text <> "salemeff" And txtPass.text <> "0#0" Then
            MsgBox("INCORRECT LOGIN DETAILS")
        ElseIf txtUser.Text <> "salemeff" And txtPass.Text = "0#0" Then
            MsgBox("INCORRECT USERNAME")
        ElseIf txtPass.text <> "0#0" And txtUser.Text = "salemeff" Then
            MsgBox("INCORRECT PASSWORD")
        ElseIf txtUser.Text = "salemeff" And txtPass.Text = "0#0" Then
            Dashboard.Show()
            Me.Close()



        End If


    End Sub

    Private Sub lblUserLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblUserLogin.LinkClicked
        Ticket_Entry.Show()
        Me.Close()
    End Sub

    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus

    End Sub
End Class
