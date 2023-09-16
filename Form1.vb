Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'Timer1.Enabled = True
        Label3.Text = Format(Now, "hh:mm:ss")
    End Sub
End Class