Imports MySql.Data.MySqlClient

Public Class ManageOrdersForm
    Private DGQuery As String = "SELECT 
                                    orders.order_id, 
                                    orders.cstmr_id,
                                    CONCAT(customers.first_name, ' ', customers.last_name) AS customer_name,
                                    orders.order_date
                                FROM 
                                    orders 
                                JOIN 
                                    customers ON orders.cstmr_id = customers.cstmr_id
                                WHERE 
                                    status='Pending'"

    Private Sub ManageOrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDataGrid(DGQuery, MODGVOrders) 'Add all orders in datagridview (left side)

        EnableSecondaryButton(MOEditBtn, False)
        EnableSecondaryButton(MODeleteBtn, False)
    End Sub

    Private Sub MOSearchBtn_Click(sender As Object, e As EventArgs) Handles MOSearchBtn.Click
        SearchInDataGrid(MODGVOrders, MOSearchTxtBx.Text)
        SearchInDataGrid(MODGVItems, MOSearchTxtBx.Text)
    End Sub

    Private Sub MONewBtn_Click(sender As Object, e As EventArgs) Handles MONewBtn.Click
        Dim Row As Integer

        myConn.Open()

        'Check if there are one supplier per category
        Sql = "SELECT 
                    COUNT(*)
                FROM 
                    items 
                GROUP BY    
                    category"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            Row += 1
            If Row = 4 Then Exit While
        End While

        myConn.Close()

        If Row < 4 Then
            myConn.Close()
            MessageBox.Show("You should have at least one item per category to continue", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        AddEditOrderForm.AddMode()
    End Sub

    Private Sub MOEditBtn_Click(sender As Object, e As EventArgs) Handles MOEditBtn.Click
        Dim Index = MODGVOrders.CurrentCell.RowIndex

        'Proceeds to edit item mode with a selected record row
        AddEditOrderForm.EditMode(New List(Of String) From {
                                        MODGVOrders.Rows(Index).Cells(0).Value, 'Order ID (order_id)
                                        MODGVOrders.Rows(Index).Cells(1).Value, 'Customer ID (cstmr_id)
                                        MODGVOrders.Rows(Index).Cells(2).Value  'Status
                                    })
    End Sub

    Private Sub MODeleteBtn_Click(sender As Object, e As EventArgs) Handles MODeleteBtn.Click
        Dim Index = MODGVOrders.CurrentCell.RowIndex

        'Give warning and show a record before deleting an order
        Dim Message As String = $"Are you sure you want to delete this Order's Record? {vbCrLf}{vbCrLf}" &
                        $"Index: {Index} {vbCrLf}" &
                        $"Order ID: {MODGVOrders.Rows(Index).Cells(0).Value} {vbCrLf}" &
                        $"Customer ID: {MODGVOrders.Rows(Index).Cells(1).Value} {vbCrLf}" &
                        $"Total Orders: {MODGVItems.RowCount - 1}"

        Dim result As DialogResult = MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete order if confirmed
        If result = DialogResult.Yes Then
            myConn.Open()

            Sql = "DELETE FROM 
                        orders 
                    WHERE 
                        order_id=@id"

            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@id", MODGVOrders.Rows(Index).Cells(0).Value)

            myCmd.ExecuteNonQuery()
            myConn.Close()

            MessageBox.Show("Order's Record is Successfully Deleted", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateDataGrid(DGQuery, MODGVOrders)
            MODGVItems.DataSource = Nothing
        End If
    End Sub

    Private Sub MODGVOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MODGVOrders.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or String.IsNullOrWhiteSpace(MODGVOrders.SelectedCells(0).Value.ToString()) Then
            EnableSecondaryButton(MOEditBtn, False)
            EnableSecondaryButton(MODeleteBtn, False)
            MODGVItems.DataSource = Nothing 'Always clear all data in data grid view order items (right side)
            Return
        End If

        EnableSecondaryButton(MOEditBtn, True)
        EnableSecondaryButton(MODeleteBtn, True)

        'Display all order items in data grid view order items (right side) of the clicked row in data grid view orders (left side)
        Dim Index = MODGVOrders.CurrentCell.RowIndex

        Sql = $"SELECT 
                    order_items.item_id,
                    CASE WHEN items.item_id = 'ITM-DELETED' THEN 'Not Available' ELSE items.name END AS name,
                    CASE WHEN items.item_id = 'ITM-DELETED' THEN 'N/A' ELSE order_items.qty END AS qty,
                    CASE WHEN items.item_id = 'ITM-DELETED' THEN 'N/A' ELSE order_items.total_amount END AS total_amount
                FROM 
                    order_items 
                JOIN 
                    items ON order_items.item_id=items.item_id
                WHERE 
                    order_id='{MODGVOrders.Rows(Index).Cells(0).Value}'"

        UpdateDataGrid(Sql, MODGVItems)
    End Sub
End Class