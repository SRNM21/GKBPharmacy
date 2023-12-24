Public Class ManageSupplierForm
    Private DGQuery As String = "SELECT 
                                    * 
                                FROM 
                                    suppliers"

    Private Sub ManageSupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDataGrid(DGQuery, MSDGV) 'Add all suppliers in datagridview

        EnableSecondaryButton(MSEditBtn, False)
        EnableSecondaryButton(MSDeleteBtn, False)
    End Sub

    Private Sub MSNewBtn_Click(sender As Object, e As EventArgs) Handles MSNewBtn.Click
        AddEditSupplierForm.AddMode()
    End Sub

    Private Sub MSEditBtn_Click(sender As Object, e As EventArgs) Handles MSEditBtn.Click
        Dim Index = MSDGV.CurrentCell.RowIndex

        'Proceeds to edit supplier mode with a selected record row
        AddEditSupplierForm.EditMode(New List(Of String) From {
                                        MSDGV.Rows(Index).Cells(0).Value, 'Supplier ID (supp_id)
                                        MSDGV.Rows(Index).Cells(1).Value, 'Supplier name (supp_name)
                                        MSDGV.Rows(Index).Cells(2).Value, 'Category
                                        MSDGV.Rows(Index).Cells(3).Value, 'Phone number
                                        MSDGV.Rows(Index).Cells(4).Value  'Email
                                    })
    End Sub

    Private Sub MSDeleteBtn_Click(sender As Object, e As EventArgs) Handles MSDeleteBtn.Click
        Dim Index = MSDGV.CurrentCell.RowIndex

        'Give warning and show a record before deleting a supplier
        Dim Message As String = $"Are you sure you want to delete this Supplier's Record? {vbCrLf}{vbCrLf}" &
                        $"Index: {Index} {vbCrLf}" &
                        $"Supplier ID: {MSDGV.Rows(Index).Cells(0).Value} {vbCrLf}" &
                        $"Supplier name: {MSDGV.Rows(Index).Cells(1).Value} {vbCrLf}" &
                        $"Category: {MSDGV.Rows(Index).Cells(2).Value} {vbCrLf}" &
                        $"Phone number: {MSDGV.Rows(Index).Cells(3).Value} {vbCrLf}" &
                        $"Email: {MSDGV.Rows(Index).Cells(4).Value} "

        Dim result As DialogResult = MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete supplier if confirmed
        If result = DialogResult.Yes Then
            myConn.Open()

            Sql = "DELETE FROM 
                        suppliers 
                    WHERE 
                        supp_id=@id"

            myCmd.Parameters.Clear()
            myCmd.Parameters.AddWithValue("@id", MSDGV.Rows(Index).Cells(0).Value)

            myCmd.Connection = myConn
            myCmd.CommandText = Sql

            myCmd.ExecuteNonQuery()
            myConn.Close()

            MessageBox.Show("Supplier's Record is Successfully Deleted", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateDataGrid(DGQuery, MSDGV)
        End If
    End Sub

    Private Sub MSSearchBtn_Click(sender As Object, e As EventArgs) Handles MSSearchBtn.Click
        SearchInDataGrid(MSDGV, MSSearchTxtBx.Text)
    End Sub

    Private Sub MSDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MSDGV.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or String.IsNullOrWhiteSpace(MSDGV.SelectedCells(0).Value.ToString()) Then
            EnableSecondaryButton(MSEditBtn, False)
            EnableSecondaryButton(MSDeleteBtn, False)
            Return
        End If

        EnableSecondaryButton(MSEditBtn, True)
        EnableSecondaryButton(MSDeleteBtn, True)
    End Sub
End Class