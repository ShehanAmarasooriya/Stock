Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class SysAdmin
    Dim con As SqlConnection = New SqlConnection("Data Source=SHEHAN-PC;Initial Catalog=CRISMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Public Sub DisplayData()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select * from Table_User", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_User")
        AdminDisplay.DataSource = ds.Tables("Table_User")
        sda.Dispose()
        con.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con.Open()
            cmd = New SqlCommand("insert into Table_User (UserID,Rank,Name,UserType,UserName,Password) values ('" + TxtUserID.Text + "','" + CmbRank.Text + "','" + TxtName.Text + "','" + CmbUserType.Text + "','" + TxtUserName.Text + "','" + TxtPassword.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData()
            MessageBox.Show("Save Successfully")
        Catch ex As Exception
            MessageBox.Show("cannot open the connection")
        End Try
    End Sub
    Private Sub SysAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            con.Open()
            cmd = New SqlCommand("delete from Table_User where (UserID='" + TxtUserID.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData()
            MessageBox.Show("Delete Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
        End Try
    End Sub
    Private Sub AdminDisplay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminDisplay.CellClick
        If e.RowIndex >= 0 Then
            Dim n As DataGridViewRow
            n = Me.AdminDisplay.Rows(e.RowIndex)
            TxtUserID.Text = n.Cells("UserID").Value.ToString
            CmbRank.Text = n.Cells("Rank").Value.ToString
            TxtName.Text = n.Cells("Name").Value.ToString
            CmbUserType.Text = n.Cells("UserType").Value.ToString
            TxtUserName.Text = n.Cells("UserName").Value.ToString
            TxtPassword.Text = n.Cells("Password").Value.ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con.Open()
            cmd = New SqlCommand("update Table_User set UserID='" + TxtUserID.Text + "',Rank='" + CmbRank.Text + "', Name='" + TxtName.Text + "',UserType='" + CmbUserType.Text + "',UserName='" + TxtUserName.Text + "',Password='" + TxtPassword.Text + "' where ( UserID='" + TxtUserID.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData()
            MessageBox.Show("Update Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TxtUserID.Clear()
        CmbRank.SelectedIndex = -1
        TxtName.Clear()
        CmbUserType.SelectedIndex = -1
        TxtUserName.Clear()
        TxtPassword.Clear()
    End Sub
End Class