Imports System.Data
Imports System.Data.OleDb

Public Class lendForm
    Public con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Database\status.accdb")
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String = ""
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select status from "
        StatusBindingSource.EndEdit()
        StatusTableAdapter.Update(StatusDataSet.status)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub lendForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdminDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.AdminDataSet.Admin)
        'TODO: This line of code loads data into the 'BookDataSet1.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.BookDataSet1.Book)
        'TODO: This line of code loads data into the 'MemberDataSet1.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.MemberDataSet1.Member)
        'TODO: This line of code loads data into the 'StatusDataSet.status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.StatusDataSet.status)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StatusBindingSource.AddNew()
    End Sub
End Class