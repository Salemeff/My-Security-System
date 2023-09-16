

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerWelcome.Enabled = True
        Me.Text = Format(Now, "hh:mm:ss") & "    " & "Admin Dashboard"
    End Sub
    Private Sub TimerWelcome_Tick(sender As Object, e As EventArgs) Handles TimerWelcome.Tick
        If lblWelcome.ForeColor = Color.Black Then
            lblWelcome.ForeColor = Color.White
        ElseIf lblWelcome.ForeColor = Color.White Then
            lblWelcome.ForeColor = Color.Red
        ElseIf lblWelcome.ForeColor = Color.Red Then
            lblWelcome.ForeColor = Color.Blue
        ElseIf lblWelcome.ForeColor = Color.Blue Then
            lblWelcome.ForeColor = Color.Yellow
        Else
            lblWelcome.ForeColor = Color.Black
        End If
        Me.Text = Format(Now, "hh:mm:ss") & "    " & "Admin Dashboard"
    End Sub

    Private Sub AboutSecloToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutSecloToolStripMenuItem1.Click
        MsgBox("This system is driven by the goal of attaining an efficient security system. It works with a timer and an OTP thereby ensuring its efficiency. This program is protected by the copyright law. Unauthorized reproduction, will result in severe civil and criminal penalties.")
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Registration.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SendFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendFeedbackToolStripMenuItem.Click
        DataForm.Show()
        Me.Close()
    End Sub
End Class