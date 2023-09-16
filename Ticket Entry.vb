Imports System.Data.OleDb

Public Class Ticket_Entry
    Dim cnt As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EMEM-OBONG\Documents\Security System.accdb")
    Dim ag As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EMEM-OBONG\Documents\User Login.accdb")
    Dim endTime As Date
    Sub del()
        ' ag.Open()
        Try
            ag.Open()
            Dim remv As String
            Dim com As New OleDbCommand
            remv = "Delete from [User] where UName=@UName And Code=@Code"
            com = New OleDb.OleDbCommand(remv, ag)
            com.Parameters.AddWithValue("@UName", txtUserName.Text)
            com.Parameters.AddWithValue("@Code", txtCode.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            ' ag.Close()
        End Try
        ag.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cnt.Open()
            Dim gg As New OleDbCommand("Select * from Registration where Username = '" & txtUserName.Text & "' And Code = '" & txtCode.Text & "'", cnt)
            Dim oo As OleDbDataReader = gg.ExecuteReader
            If oo.Read Then
                If StrComp(txtCode.Text, oo.GetValue(3), 0) = 0 And StrComp(txtUserName.Text, oo.GetValue(2), 0) = 0 Then
                    'MsgBox("SUCCESSFUL", vbInformation)
                    del()
                    soln()
                    txtUserName.Clear()
                    txtCode.Clear()
                    Count_Down.Show()
                    Me.Close()
                ElseIf StrComp(txtCode.Text, oo.GetValue(3), 0) = 0 Or StrComp(txtUserName.Text, oo.GetValue(2), 0) = 0 Then
                    MsgBox("ENSURE TO TYPE IN THE CORRECT DETAILS", vbCritical)
                Else
                    MsgBox("INCORRECT LOGIN DETAILS", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cnt.Close()


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Ticket_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUserName.Select()
    End Sub

    Sub soln()
        Try
            Dim gii As New OleDbCommand("Select * from Registration where Username = '" & txtUserName.Text & "' And Code = '" & txtCode.Text & "'", cnt)
            Dim op As OleDbDataReader = gii.ExecuteReader
            If op.Read Then
                MsgBox("SUCCESSFUL", vbInformation)
                u = op.GetValue(4)
                z = op.GetValue(5)
            Else
                MsgBox("INCORRECT", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class