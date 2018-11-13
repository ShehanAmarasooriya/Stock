Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class LoginInventoryHolder
    Dim con As SqlConnection = New SqlConnection("Data Source=SHEHAN-PC;Initial Catalog=CRISMS;Integrated Security=True")
    Private Sub LoginInventoryHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub ComboBox1_Click_1(sender As Object, e As EventArgs) Handles ComboBox1.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Table_Login", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "UserName"
        'ComboBox1.ValueMember = "Password"
        con.Close()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Table_Login where UserName=@username and Password=@password", con)
        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = ComboBox1.Text
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = TxtPassword.Text

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("Invaild User Name or Password")
            ComboBox1.SelectedIndex = -1
            TxtPassword.Clear()
            con.Close()
        Else
            inventoryHolder.Show()
            Me.Hide()
            ComboBox1.SelectedIndex = -1
            TxtPassword.Clear()
            con.Close()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub
End Class