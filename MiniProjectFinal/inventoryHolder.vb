Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class inventoryHolder
    Dim con As SqlConnection = New SqlConnection("Data Source=SHEHAN-PC;Initial Catalog=CRISMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim reader As SqlDataReader


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        TxtItemCode.Clear()
        CmbItemCategroy.SelectedIndex = -1
        TxtItemName.Clear()
        TxtReOrderLimit.Clear()
        TxtWarrantyPeriod.Clear()
        TxtManufacture.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con.Open()
            cmd = New SqlCommand("insert into Table_Item (ItemCode,ItemCategory,ItemName,ReOrderLimit,WarrantyPeriod,Manufacture) values ('" + TxtItemCode.Text + "','" + CmbItemCategroy.Text + "','" + TxtItemName.Text + "','" + TxtReOrderLimit.Text + "','" + TxtWarrantyPeriod.Text + "','" + TxtManufacture.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData()
            MessageBox.Show("Save Successfully")
        Catch ex As Exception
            MessageBox.Show("cannot open the connection")
        End Try
    End Sub
    Public Sub DisplayData()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select * from Table_Item", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_Item")
        RegisterView.DataSource = ds.Tables("Table_Item")
        sda.Dispose()
        con.Close()
    End Sub

    Private Sub inventoryHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
        DisplayData1()
        DisplayData2()
        DisplayData3()
    End Sub

    Private Sub RegisterView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegisterView.CellClick
        If e.RowIndex >= 0 Then
            Dim n As DataGridViewRow
            n = Me.RegisterView.Rows(e.RowIndex)
            TxtItemCode.Text = n.Cells("ItemCode").Value.ToString
            CmbItemCategroy.Text = n.Cells("ItemCategory").Value.ToString
            TxtItemName.Text = n.Cells("ItemName").Value.ToString '
            TxtReOrderLimit.Text = n.Cells("ReOrderLimit").Value.ToString
            TxtWarrantyPeriod.Text = n.Cells("WarrantyPeriod").Value.ToString
            TxtManufacture.Text = n.Cells("Manufacture").Value.ToString
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con.Open()
            cmd = New SqlCommand("delete from Table_Item where (ItemCode='" + TxtItemCode.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData()
            MessageBox.Show("Delete Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
            con.Close()

        End Try
        'con.Open()
        'cmd = New SqlCommand("delete from Table_CurrentStock where (Itemcode='" + TxtItemCode.Text + "')", con)
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
        'con.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con.Open()
            cmd = New SqlCommand("update Table_Item set ItemCode='" + TxtItemCode.Text + "',ItemCategory='" + CmbItemCategroy.Text + "', ItemName='" + TxtItemName.Text + "',ReOrderLimit='" + TxtReOrderLimit.Text + "',WarrantyPeriod='" + TxtWarrantyPeriod.Text + "',Manufacture='" + TxtManufacture.Text + "' where ( ItemCode='" + TxtItemCode.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData()
            MessageBox.Show("Update Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        Try
            con.Open()
            cmd = New SqlCommand("insert into Table_StockIn (StockID,ItemCode,Quantity,Location,InDate) values ('" + TxtStockID.Text + "','" + cmbitemcode.Text + "','" + TxtQuantity.Text + "','" + CmbLocation.Text + "','" + DateTimePicker2.Value + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData1()
            MessageBox.Show("Save Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
        End Try
        con.Open()
        Try
            cmd = New SqlCommand("insert into Table_CurrentStock(ItemCode,Quantity) values ('" + cmbitemcode.Text + "','" + TxtQuantity.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'MessageBox.Show("Try")
        Catch ex As Exception
            cmd = New SqlCommand("update Table_CurrentStock set Quantity= Quantity+(" + TxtQuantity.Text + ") where (ItemCode='" + cmbitemcode.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'MessageBox.Show("catch")
        End Try
        con.Close()
    End Sub
    Public Sub DisplayData1()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select * from Table_StockIn", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_StockIn")
        StockView.DataSource = ds.Tables("Table_StockIn")
        sda.Dispose()
        con.Close()
    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        con.Open()
        cmd = New SqlCommand("select Quantity from Table_StockIn where StockID='" + TxtStockID.Text + "' and ItemCode='" + cmbitemcode.Text + "'", con)
        Dim a As String = cmd.ExecuteScalar().ToString()
        ' MessageBox.Show(a)
        con.Close()
        Try
            con.Open()
            cmd = New SqlCommand("update Table_StockIn set StockID='" + TxtStockID.Text + "',ItemCode='" + cmbitemcode.Text + "', Quantity='" + TxtQuantity.Text + "',Location='" + CmbLocation.Text + "',InDate='" + DateTimePicker2.Value + "' where ( StockID='" + TxtStockID.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData1()
            MessageBox.Show("Update Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
            con.Close()
        End Try
        'textbox value greater than database value
        If (TxtQuantity.Text > a) Then
            Dim b As String = TxtQuantity.Text - a
            con.Open()
            'MessageBox.Show(TxtQuantity.Text - a)
            cmd = New SqlCommand("update Table_CurrentStock set Quantity= Quantity+(" + b + ") where (ItemCode='" + cmbitemcode.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        Else
            Dim b As String = a - TxtQuantity.Text
            con.Open()
            cmd = New SqlCommand("update Table_CurrentStock set Quantity= Quantity-(" + b + ") where (ItemCode='" + cmbitemcode.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        End If
    End Sub

    Private Sub StockView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockView.CellClick
        If e.RowIndex >= 0 Then
            Dim n As DataGridViewRow
            n = Me.StockView.Rows(e.RowIndex)
            TxtStockID.Text = n.Cells("StockID").Value.ToString
            cmbitemcode.Text = n.Cells("ItemCode").Value.ToString
            TxtQuantity.Text = n.Cells("Quantity").Value.ToString
            CmbLocation.Text = n.Cells("Location").Value.ToString
            DateTimePicker2.Value = n.Cells("InDate").Value.ToString
        End If
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        con.Open()
        cmd = New SqlCommand("select Quantity from Table_StockIn where StockID='" + TxtStockID.Text + "' and ItemCode='" + cmbitemcode.Text + "'", con)
        Dim a As String = cmd.ExecuteScalar().ToString()
        con.Close()
        Try
            con.Open()
            cmd = New SqlCommand("delete from Table_StockIn where (StockID='" + TxtStockID.Text + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData1()
            MessageBox.Show("Delete Successfully")
        Catch ex As Exception
            MessageBox.Show("Cannot open the connection")
        End Try
        con.Open()
        cmd = New SqlCommand("update Table_CurrentStock set Quantity= Quantity-(" + a + ") where (ItemCode='" + cmbitemcode.Text + "')", con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btnnew1_Click(sender As Object, e As EventArgs) Handles btnnew1.Click
        TxtStockID.Clear()
        cmbitemcode.SelectedIndex = -1
        TxtQuantity.Clear()
        CmbLocation.SelectedIndex = -1
        DateTimePicker2.CustomFormat = " "
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbitemcode_Click(sender As Object, e As EventArgs) Handles cmbitemcode.Click
        con.Open()
        Dim cmd As New SqlCommand("select * from Table_Item", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        cmbitemcode.DataSource = table
        cmbitemcode.DisplayMember = "ItemCode"
        con.Close()
    End Sub
    Public Sub DisplayData2()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select RequestID,ItemCode,ItemQuantity,Date from Table_ItemCheck where Status='ACCEPT' ", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_ItemCheck")
        ReceivedView.DataSource = ds.Tables("Table_ItemCheck")
        sda.Dispose()
        con.Close()
    End Sub

    Private Sub ReceivedView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReceivedView.CellClick
        If e.RowIndex >= 0 Then
            Dim n As DataGridViewRow
            n = Me.ReceivedView.Rows(e.RowIndex)
            txtRequestID.Text = n.Cells("RequestID").Value.ToString
            TxtITeamCode.Text = n.Cells("ItemCode").Value.ToString
            TxQuantity.Text = n.Cells("ItemQuantity").Value.ToString
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnIssue.Click
        Try
            con.Open()
            cmd = New SqlCommand("insert into Table_IssueItem (IssueID,RequestID,ItemCode,ItemQuantity,IssueDate) values ('" + txtIssueID.Text + "','" + txtRequestID.Text + "','" + TxtITeamCode.Text + "','" + TxQuantity.Text + "','" + DateTimePicker1.Value + "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            DisplayData()
            MessageBox.Show("Issue Successfully")
        Catch ex As Exception
            MessageBox.Show("cannot open the connection")
        End Try
        Dim a As String = TxQuantity.Text
        'MessageBox.Show(2 * a)
        con.Open()
        cmd = New SqlCommand("update Table_CurrentStock set Quantity= Quantity-(" + a + ") where (ItemCode='" + TxtITeamCode.Text + "')", con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.Close()
    End Sub
    Public Sub DisplayData3()
        con.Open()
        Dim ds As New DataSet
        Dim sda As SqlDataAdapter = New SqlDataAdapter("select * from Table_IssueItem ", con)
        Dim dt As DataTable = New DataTable()
        sda.Fill(ds, "Table_IssueItem")
        Issueview.DataSource = ds.Tables("Table_IssueItem")
        sda.Dispose()
        con.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        CurrentStock.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        IssuedRequestvb.Show()
    End Sub

    Private Sub RegisterView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegisterView.CellContentClick

    End Sub
End Class