Imports MySql.Data.MySqlClient

Public Class ManageItemsForm
    Private DGQuery As String = "SELECT 
                                    * 
                                FROM 
                                    items
                                WHERE 
                                    item_id <> 'ITM-DELETED'"

    Private Sub ManageItemsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDataGrid(DGQuery, MIDGV) 'Add all items in datagridview

        EnableSecondaryButton(MIEditBtn, False)
        EnableSecondaryButton(MIDeleteBtn, False)
    End Sub

    Private Sub MISearchBtn_Click(sender As Object, e As EventArgs) Handles MISearchBtn.Click
        SearchInDataGrid(MIDGV, MISearchTxtBx.Text)
    End Sub

    Private Sub MINewBtn_Click(sender As Object, e As EventArgs) Handles MINewBtn.Click
        Dim Row As Integer

        myConn.Open()

        'Check if there are one supplier per category
        Sql = "SELECT 
                    category, 
                    COUNT(supp_id) AS total_supplier 
                FROM 
                    suppliers 
                GROUP BY    
                    category"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            Row += 1
            If Row = 4 Then Exit While
        End While

        myConn.Close()

        'Don't proceed to add item mode if 
        If Row < 4 Then
            MessageBox.Show("You must have at least one supplier per category for comprehensive coverage.", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        AddEditItemForm.AddMode()
    End Sub

    Private Sub MIEditBtn_Click(sender As Object, e As EventArgs) Handles MIEditBtn.Click
        Dim Index = MIDGV.CurrentCell.RowIndex

        'Proceeds to edit item mode with a selected record row
        AddEditItemForm.EditMode(New List(Of String) From {
                                    MIDGV.Rows(Index).Cells(0).Value, 'Item ID (item_id)
                                    If(MIDGV.Rows(Index).Cells(1).Value IsNot DBNull.Value,
                                        MIDGV.Rows(Index).Cells(1).Value.ToString(), String.Empty), 'Supplier ID (supp_id)
                                    MIDGV.Rows(Index).Cells(2).Value, 'Category
                                    MIDGV.Rows(Index).Cells(3).Value, 'Item
                                    MIDGV.Rows(Index).Cells(4).Value, 'Cost
                                    MIDGV.Rows(Index).Cells(5).Value, 'Price
                                    MIDGV.Rows(Index).Cells(6).Value  'Stock
                                })
    End Sub

    Private Sub MIDeleteBtn_Click(sender As Object, e As EventArgs) Handles MIDeleteBtn.Click
        Dim Index = MIDGV.CurrentCell.RowIndex

        'Give warning and show a record before deleting a item
        Dim Message As String = $"Are you sure you want to delete this Item's Record? {vbCrLf}{vbCrLf}" &
                        $"Index: {Index} {vbCrLf}" &
                        $"Item ID: {MIDGV.Rows(Index).Cells(0).Value} {vbCrLf}" &
                        $"Supplier ID: {MIDGV.Rows(Index).Cells(1).Value} {vbCrLf}" &
                        $"Category: {MIDGV.Rows(Index).Cells(2).Value} {vbCrLf}" &
                        $"Item: {MIDGV.Rows(Index).Cells(3).Value} {vbCrLf}" &
                        $"Cost: {MIDGV.Rows(Index).Cells(4).Value} {vbCrLf}" &
                        $"Price: {MIDGV.Rows(Index).Cells(5).Value} {vbCrLf}" &
                        $"Stock: {MIDGV.Rows(Index).Cells(6).Value} {vbCrLf}"

        Dim result As DialogResult = MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete item if confirmed
        If result = DialogResult.Yes Then
            Sql = "DELETE FROM 
                        items 
                    WHERE 
                        item_id=@id"

            myConn.Open()
            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@id", MIDGV.Rows(Index).Cells(0).Value)
            myCmd.ExecuteNonQuery()
            myConn.Close()

            Sql = "DELETE FROM 
                        orders
                    WHERE 
                        order_id 
                            IN (SELECT 
                                    order_id
                                FROM 
                                    order_items
                                GROUP BY 
                                    order_id
                                HAVING 
                                    COUNT(item_id) < 1)"

            myConn.Open()
            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@id", MIDGV.Rows(Index).Cells(0).Value)
            myCmd.ExecuteNonQuery()
            myConn.Close()

            MessageBox.Show("Item's Record is Successfully Deleted", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateDataGrid(DGQuery, MIDGV)
        End If
    End Sub

    Private Sub MIDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MIDGV.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or String.IsNullOrWhiteSpace(MIDGV.SelectedCells(0).Value.ToString()) Then
            EnableSecondaryButton(MIEditBtn, False)
            EnableSecondaryButton(MIDeleteBtn, False)
            Return
        End If

        EnableSecondaryButton(MIEditBtn, True)
        EnableSecondaryButton(MIDeleteBtn, True)
    End Sub

End Class