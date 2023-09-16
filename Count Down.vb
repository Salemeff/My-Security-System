Public Class Count_Down


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lblTimer.Visible = False
        If lblTimer.Visible = False Then
            LinkLabel2.Visible = True
            LinkLabel1.Visible = False
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        lblTimer.Visible = True
        If lblTimer.Visible = True Then
            LinkLabel1.Visible = True
            LinkLabel2.Visible = False
        End If
    End Sub


    Private Sub Count_Down_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True

        ss = ss - 1
        If ss < 0 Then
            ss = 59
            z = z - 1
        End If
        If z < 0 Then
            z = 59
            u = u - 1
        End If
        If u < 0 Then
            u = 0
        End If

        'this disables the hide/show countdown lables And alerts the user
        'u is the variable for hour, z is the variable for minutes
        If u = 0 And z = 5 And ss = 0 Then
            If lblTimer.Visible = False Then
                lblTimer.Visible = True
                LinkLabel1.Visible = False
                LinkLabel2.Visible = False
                MsgBox("YOU HAVE LESS THAN 5 MINUTES LEFT !!!", MsgBoxStyle.Critical)
            ElseIf lblTimer.Visible = True Then
                LinkLabel1.Visible = False
                LinkLabel2.Visible = False
                MsgBox("YOU HAVE LESS THAN 5 MINUTES LEFT !!!", MsgBoxStyle.Critical)
            End If
        ElseIf u = 0 And z = 1 And ss = 0 Then
            lblTimer.Visible = True
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            MsgBox("YOUR TIME IS ALMOST UP !!!", MsgBoxStyle.Critical)
        End If

        'this disables the timer once the time Is up
        If u = 0 And z = 0 And ss = 0 Then
            Timer1.Enabled = False
            ' l = "TIME UP"
            ' MsgBox("TIME UP !!!")
            LoginUser.Show()
            Me.Close()
        End If

        'this outputs the time on the timer label
        em = u & ":" & z & ":" & ss
        lblTimer.Text = em




    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ss = ss - 1
        If ss < 0 Then
            ss = 59
            z = z - 1
        End If
        If z < 0 Then
            z = 59
            u = u - 1
        End If
        If u < 0 Then
            u = 0
        End If

        'this disables the hide/show countdown lables And alerts the user
        'u is the variable for hour, z is the variable for minutes
        If u = 0 And z = 5 And ss = 0 Then
            If lblTimer.Visible = False Then
                lblTimer.Visible = True
                LinkLabel1.Visible = False
                LinkLabel2.Visible = False
                MsgBox("YOU HAVE LESS THAN 5 MINUTES LEFT !!!", MsgBoxStyle.Critical)
            ElseIf lblTimer.Visible = True Then
                LinkLabel1.Visible = False
                LinkLabel2.Visible = False
                MsgBox("YOU HAVE LESS THAN 5 MINUTES LEFT !!!", MsgBoxStyle.Critical)
            End If
        ElseIf u = 0 And z = 1 And ss = 0 Then
            lblTimer.Visible = True
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            MsgBox("YOUR TIME IS ALMOST UP !!!", MsgBoxStyle.Critical)
        End If

        'this disables the timer once the time Is up
        If u = 0 And z = 0 And ss = 0 Then
            Timer1.Enabled = False
            'l = "TIME UP"
            'MssgBox("TIME UP !!!")
            LoginUser.Show()
            Me.Close()
        End If

        'this outputs the time on the timer label
        em = u & ":" & z & ":" & ss
        lblTimer.Text = em
    End Sub
End Class