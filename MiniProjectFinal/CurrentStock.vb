Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class CurrentStock
    Dim con As SqlConnection = New SqlConnection("Data Source=SHEHAN-PC;Initial Catalog=CRISMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim reader As SqlDataReader
    Private Sub CurrentStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
    End Sub
    Public Sub DisplayData()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select *  from Table_CurrentStock", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_CurrentStock")
        CurrentStockView.DataSource = ds.Tables("Table_CurrentStock")
        sda.Dispose()
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub
End Class