Imports System.Data
Imports System.Data.OleDb

Public Class Form2

    Public con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Database\Member.accdb")
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String = ""


    Sub connect()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MemberDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.MemberDataSet.Member)
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MemberBindingSource.EndEdit()
        MemberTableAdapter.Update(MemberDataSet.Member)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MemberBindingSource.RemoveCurrent()
        MemberBindingSource.EndEdit()
        MemberTableAdapter.Update(MemberDataSet.Member)

    End Sub

    Private Sub FillByMemberToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.MemberTableAdapter.FillBySID(Me.MemberDataSet.Member, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBySIDToolStripButton_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MemberBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        AdminDashboard.Show()
        Me.Close()

    End Sub

    Private Sub FillBySIDToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillBySIDToolStrip.ItemClicked

    End Sub
End Class