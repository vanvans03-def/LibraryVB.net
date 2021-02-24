Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Public con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Database\Member.accdb")
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String = ""

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("pls Enter user name and password")

        End If
        sql = "select * from Member where ID = '" & TextBox1.Text & "' AND Mpass = '" & TextBox2.Text & "' "
        da = New OleDbDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "datatable")
        If ds.Tables("datatable").Rows.Count <= 0 Then
            MsgBox("Is wrong")
        Else
            If ds.Tables("datatable").Rows(0)("Mlevel") = "3" Then
                AdminDashboard.AdminMain = TextBox1.Text
                AdminDashboard.Show()

            Else
                UserDashboard.UserMain = TextBox1.Text
                UserDashboard.Show()

            End If

        End If

    End Sub
End Class
