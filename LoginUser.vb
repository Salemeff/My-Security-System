Imports System.Data.OleDb

Public Class LoginUser
    Dim ag As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EMEM-OBONG\Documents\User Login.accdb")
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ag.Open()
            Dim gg As New OleDbCommand("Select * from [User] where UName = '" & txtUserName.Text & "' And Code = '" & txtCode.Text & "'", ag)
            Dim oo As OleDbDataReader = gg.ExecuteReader
            If oo.Read Then
                MsgBox("SUCCESSFUL", vbInformation)
                txtUserName.Clear()
                txtCode.Clear()
                Ticket_Entry.Show()
                Me.Close()
            Else
                MsgBox("INVALID", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ag.Close()
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub LoginUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Select()
    End Sub
End Class