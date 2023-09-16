Imports System.Data.OleDb

Public Class Registration
    Dim Code As Integer
    Dim cnt As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EMEM-OBONG\Documents\Security System.accdb")
    Dim ag As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EMEM-OBONG\Documents\User Login.accdb")
    Sub Mine()
        Try
            cnt.Open()
            Dim g As New OleDb.OleDbCommand("Insert into Registration(`Full_Name`, `Username`, `Code`, `Hour`, `Minutes`) values (@Full_Name,@Username,@Code,@Hour,@Minutes)", cnt)
            Dim o As Integer
            g.Parameters.Clear()
            g.Parameters.AddWithValue("@Full_Name", txtName.Text)
            g.Parameters.AddWithValue("@Username", txtUsername.Text)
            g.Parameters.AddWithValue("@Code", txtGen.Text)
            g.Parameters.AddWithValue("@Hour", cbHour.Text)
            g.Parameters.AddWithValue("@Minutes", cbMin.Text)
            o = g.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cnt.Close()
    End Sub
    Sub Log()
        ag.Open()
        Try
            Dim j As New OleDb.OleDbCommand("Insert into [User](`UName`, `Code`, `Hour`, `Minute`, `FName`) values (@UName,@Code,@Hour,@Minute,@FName)", ag)
            Dim i As New Integer
            j.Parameters.Clear()
            j.Parameters.AddWithValue("@UName", txtUsername.Text)
            j.Parameters.AddWithValue("@Code", txtGen.Text)
            j.Parameters.AddWithValue("@Hour", cbHour.Text)
            j.Parameters.AddWithValue("@Minute", cbMin.Text)
            j.Parameters.AddWithValue("@FName", txtName.Text)
            i = j.ExecuteNonQuery
            If i > 0 Then
                MsgBox("SUCCESSFUL", vbInformation)
            Else
                MsgBox("FAILED", vbCritical)
            End If
            txtName.Clear()
            txtUsername.Clear()
            txtGen.Clear()
            cbHour.Text = ""
            cbMin.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ag.Close()
    End Sub
    Private Sub cbHour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHour.SelectedIndexChanged
        H = cbHour.Text
    End Sub

    Private Sub cbMin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMin.SelectedIndexChanged
        M = cbMin.Text
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        Dim random As New Random()
        Dim pass, z As String
        pass = ""
        z = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "abcdefghijklmnopqrstuvwxyz" + "0123456789" + "*#"
        While pass.Length < 6
            pass &= z.Substring(random.Next(0, z.Length), 1)
            '&= concatenates the string expression on the right to the variable or property 
            'on the left and assigns the result to the variable Or property on the left
        End While
        txtGen.Text = pass
    End Sub


    Private Sub Generate_Ticket_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtName.Select()
        CurrentTime.Enabled = True
        Me.Text = Format(Now, "hh:mm:ss") & "    " & "Registration"

        For H = 0 To 12
            cbHour.Items.Add(H)
        Next

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim z As String
        If txtName.Text = "" And txtUsername.Text = "" And txtGen.Text = "" _
           And cbHour.Text = "" And cbMin.Text = "" Then
            MsgBox("No record should be empty", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        ElseIf txtName.Text = "" Or txtUsername.Text = "" Or txtGen.Text = "" _
           And cbHour.Text = "" Or cbMin.Text = "" Then
            MsgBox("No record should be empty", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Else
            z = MsgBox("sure to save data?", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
            If z = vbYes Then
                Mine()
                Log()
            End If
        End If


    End Sub

    Private Sub txtGen_TextChanged(sender As Object, e As EventArgs) Handles txtGen.TextChanged
        q = txtGen.Text
    End Sub

    Private Sub CurrentTime_Tick(sender As Object, e As EventArgs) Handles CurrentTime.Tick
        Me.Text = Format(Now, "hh:mm:ss") & "    " & "Registration"
    End Sub
    Private Sub lblCode_Click(sender As Object, e As EventArgs) Handles lblCode.Click

    End Sub
End Class