Imports System.Data.OleDb

Public Class DataForm
    Dim cnt As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EMEM-OBONG\Documents\Security System.accdb")
    Dim dt As New DataTable
    Dim com As New OleDbDataAdapter


    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CurrentTime.Enabled = True
        Me.Text = Format(Now, "hh:mm:ss") & "    " & "View - Registered Users"
        cnt.Open()
        com = New OleDbDataAdapter("select * From Registration", cnt)
        com.Fill(dt)
        DB.DataSource = dt.DefaultView
        cnt.Close()

    End Sub

    Private Sub DB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DB.CellContentClick

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub CurrentTime_Tick(sender As Object, e As EventArgs) Handles CurrentTime.Tick
        Me.Text = Format(Now, "hh:mm:ss") & "    " & "View - Registered Users"
    End Sub
End Class