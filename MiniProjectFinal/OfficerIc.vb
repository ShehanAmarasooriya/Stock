Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class OfficerIc
    Dim con As SqlConnection = New SqlConnection("Data Source=SHEHAN-PC;Initial Catalog=CRISMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim reader As SqlDataReader
    Public Sub DisplayData()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select * from Table_ItemRequest", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_ItemRequest")
        UserRequestView.DataSource = ds.Tables("Table_ItemRequest")
        sda.Dispose()
        con.Close()
    End Sub

    Private Sub OfficerIc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
        DisplayData1()
    End Sub

    Private Sub UserRequestView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserRequestView.CellClick
        If e.RowIndex >= 0 Then
            Dim n As DataGridViewRow
            n = Me.UserRequestView.Rows(e.RowIndex)
            txtRequestID.Text = n.Cells("RequestID").Value.ToString
            txtItemCode.Text = n.Cells("ItemCode").Value.ToString
            txtQuantity.Text = n.Cells("ItemQuantity").Value.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con.Open()
            cmd = New SqlCommand("insert into Table_ItemCheck (RequestID,ItemCode,ItemQuantity,Status,RejectReason,Date) values ('" + txtRequestID.Text + "','" + txtItemCode.Text + "','" + txtQuantity.Text + "','" + cmbStatus.Text + "','" + txtReason.Text + "','" + DateTimePicker1.Value + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData1()
            MessageBox.Show("Save Successfully")
        Catch ex As Exception
            MessageBox.Show("cannot open the connection")
        End Try
    End Sub
    Public Sub DisplayData1()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select RequestID,ItemCode,ItemQuantity,Status,RejectReason,Date from Table_ItemCheck", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_ItemCheck")
        Checkview.DataSource = ds.Tables("Table_ItemCheck")
        sda.Dispose()
        con.Close()
    End Sub
End Class