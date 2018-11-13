Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Technician
    Dim con As SqlConnection = New SqlConnection("Data Source=SHEHAN-PC;Initial Catalog=CRISMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub btnViewCurrentStock_Click(sender As Object, e As EventArgs) Handles btnViewCurrentStock.Click
        CurrentStock.Show()

    End Sub
    Public Sub DisplayDataRequestItem()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select * from Table_ItemRequest", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_ItemRequest")
        RequestView.DataSource = ds.Tables("Table_ItemRequest")
        sda.Dispose()
        con.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddR.Click
        Try
            con.Open()
            cmd = New SqlCommand("insert into Table_ItemRequest (RequestID,ItemCode,ItemQuantity,RequestDate) values ('" + TxtRequestID.Text + "','" + CmbItemCode.Text + "','" + TxtItemQuantity.Text + "','" + DateTimeRequest.Value + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayDataRequestItem()
            MessageBox.Show("Save Successfully")
        Catch ex As Exception
            MessageBox.Show("cannot open the connection")
        End Try
    End Sub

    Private Sub Technician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDataRequestItem()
    End Sub

    Private Sub BtnNewR_Click(sender As Object, e As EventArgs) Handles BtnNewR.Click
        TxtRequestID.Clear()
        CmbItemCode.SelectedIndex = -1
        TxtItemQuantity.Clear()
        'DateTimeRequest .Value 
    End Sub

    Private Sub BtnDeleteR_Click(sender As Object, e As EventArgs) Handles BtnDeleteR.Click
        Try
            con.Open()
            cmd = New SqlCommand("delete from Table_ItemRequest where (RequestID='" + TxtRequestID.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayDataRequestItem()
            MessageBox.Show("Delete Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
        End Try
    End Sub

    Private Sub RequestView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RequestView.CellClick
        If e.RowIndex >= 0 Then
            Dim n As DataGridViewRow
            n = Me.RequestView.Rows(e.RowIndex)
            TxtRequestID.Text = n.Cells("RequestID").Value.ToString
            CmbItemCode.Text = n.Cells("ItemCode").Value.ToString
            TxtItemQuantity.Text = n.Cells("ItemQuantity").Value.ToString
            DateTimeRequest.Value = n.Cells("RequestDate").Value.ToString
        End If
    End Sub

    Private Sub btnUpdateR_Click(sender As Object, e As EventArgs) Handles btnUpdateR.Click
        Try
            con.Open()
            cmd = New SqlCommand("update Table_ItemRequest set RequestID='" + TxtRequestID.Text + "',ItemCode='" + CmbItemCode.Text + "',ItemQuantity='" + TxtItemQuantity.Text + "',RequestDate='" + DateTimeRequest.Value + "' where ( RequestID='" + TxtRequestID.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayDataRequestItem()
            MessageBox.Show("Update Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
        End Try
    End Sub

    Private Sub CmbItemCode_Click(sender As Object, e As EventArgs) Handles CmbItemCode.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Table_CurrentStock", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table1 As New DataTable()
        adapter.Fill(table1)
        CmbItemCode.DataSource = table1
        CmbItemCode.ValueMember = "ItemCode"
        CmbItemCode.DisplayMember = "ItemCode"
        con.Close()

        
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("select ItemCode,Quantity from Table_CurrentStock where ItemCode='" + CmbItemCode.SelectedValue + "'", con)
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter2.Fill(table)
        Label7.Text = table(0)(1)
        con.Close()
    End Sub
End Class