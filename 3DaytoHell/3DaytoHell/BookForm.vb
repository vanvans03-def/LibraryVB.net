Imports System.Data
Imports System.Data.OleDb

Public Class BookForm
    Public con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Database\Book.accdb")
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String = ""
    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookDataSet1.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter1.Fill(Me.BookDataSet1.Book)
        'TODO: This line of code loads data into the 'BookDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.BookDataSet.Book)
        'TODO: This line of code loads data into the 'MemberDataSet.Member' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookBindingSource1.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BookBindingSource1.EndEdit()
        BookTableAdapter1.Update(BookDataSet1.Book)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BookBindingSource1.RemoveCurrent()
        BookBindingSource1.EndEdit()
        BookTableAdapter1.Update(BookDataSet1.Book)

    End Sub

    Private Sub FillByBookToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IDToolStripTextBox_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.BookTableAdapter1.FillByBook(Me.BookDataSet1.Book, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub
End Class