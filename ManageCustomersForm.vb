Imports MySql.Data.MySqlClient

Public Class ManageCustomersForm
    Private DGQuery As String = "SELECT 
                                    *, 
                                    (   
                                        SELECT 
                                            COUNT(*)    
                                        FROM 
                                            orders 
                                        WHERE 
                                            orders.cstmr_id = customers.cstmr_id
                                    ) AS 
                                        total_orders 
                                FROM 
                                    customers
                                WHERE 
                                    cstmr_id <> 'CST-DELETED'"

    Private Sub ManageCustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDataGrid(DGQuery, MCDGV) 'Add all customers and the number of thier orders in datagridview

        EnableSecondaryButton(MCEditBtn, False)
        EnableSecondaryButton(MCDeleteBtn, False)
    End Sub

    Private Sub MCSearchBtn_Click(sender As Object, e As EventArgs) Handles MCSearchBtn.Click
        SearchInDataGrid(MCDGV, MCSearchTxtBx.Text)
    End Sub

    Private Sub MCNewBtn_Click(sender As Object, e As EventArgs) Handles MCNewBtn.Click
        AddEditCustomerForm.AddMode()
    End Sub

    Private Sub MCEditBtn_Click(sender As Object, e As EventArgs) Handles MCEditBtn.Click
        Dim Index = MCDGV.CurrentCell.RowIndex

        'Proceeds to edit customer mode with a selected record row
        AddEditCustomerForm.EditMode(New List(Of String) From {
                                            MCDGV.Rows(Index).Cells(0).Value, 'Customer ID (cstmr_id)
                                            MCDGV.Rows(Index).Cells(1).Value, 'Firstname (first_name)
                                            MCDGV.Rows(Index).Cells(2).Value, 'Lastname (last_name)
                                            MCDGV.Rows(Index).Cells(3).Value  'gender
                                       })
    End Sub

    Private Sub MCDeleteBtn_Click(sender As Object, e As EventArgs) Handles MCDeleteBtn.Click
        Dim Index = MCDGV.CurrentCell.RowIndex

        'Give warning and show a record before deleting a customer
        Dim Message As String = $"Are you sure you want to delete this Customer's Record? {vbCrLf}{vbCrLf}" &
                        $"Index: {Index} {vbCrLf}" &
                        $"Customer ID: {MCDGV.Rows(Index).Cells(0).Value} {vbCrLf}" &
                        $"First name: {MCDGV.Rows(Index).Cells(1).Value} {vbCrLf}" &
                        $"Last name: {MCDGV.Rows(Index).Cells(2).Value} {vbCrLf}" &
                        $"Gender: {MCDGV.Rows(Index).Cells(3).Value} {vbCrLf}"

        Dim result As DialogResult = MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete customer if confirmed
        If result = DialogResult.Yes Then
            Sql = "DELETE FROM  
                        orders 
                    WHERE 
                        cstmr_id=@id AND status='Pending'"

            myConn.Open()
            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@id", MCDGV.Rows(Index).Cells(0).Value)
            myCmd.ExecuteNonQuery()
            myConn.Close()

            Sql = $"DELETE FROM   
                        customers 
                    WHERE 
                        cstmr_id=@id"

            myConn.Open()
            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@id", MCDGV.Rows(Index).Cells(0).Value)
            myCmd.ExecuteNonQuery()
            myConn.Close()

            MessageBox.Show("Customer's Record is Successfully Deleted", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateDataGrid(DGQuery, MCDGV)
        End If
    End Sub

    Private Sub MCDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MCDGV.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or String.IsNullOrWhiteSpace(MCDGV.SelectedCells(0).Value.ToString()) Then
            EnableSecondaryButton(MCEditBtn, False)
            EnableSecondaryButton(MCDeleteBtn, False)
            Return
        End If

        EnableSecondaryButton(MCEditBtn, True)
        EnableSecondaryButton(MCDeleteBtn, True)
    End Sub
End Class