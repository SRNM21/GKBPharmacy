Imports MySql.Data.MySqlClient

Public Class ManageAccountForm
    Private DGQuery As String = "SELECT 
                                    * 
                                FROM 
                                    pharmacist_accounts;"

    Private Sub ManagePharmacistsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDataGrid(DGQuery, MADGV) 'Add all pharmacist accounts in datagridview

        EnableSecondaryButton(MAEditBtn, False)
        EnableSecondaryButton(MADeleteBtn, False)
    End Sub

    Private Sub MASearchBtn_Click(sender As Object, e As EventArgs) Handles MASearchBtn.Click
        SearchInDataGrid(MADGV, MASearchTxtBx.Text)
    End Sub

    Private Sub MANewBtn_Click(sender As Object, e As EventArgs) Handles MANewBtn.Click
        myConn.Open()

        'Check if there are pharmacists who don't have an account
        Sql = "SELECT 
                    phrmcst_id
                FROM 
                    pharmacists
                WHERE NOT EXISTS (
                    SELECT 
                        1
                    FROM 
                        pharmacist_accounts
                    WHERE 
                        pharmacist_accounts.phrmcst_id = pharmacists.phrmcst_id
                )"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        'Don't proceed to add account mode it all pharmacist has an account
        If Not myRdr.HasRows Then
            myConn.Close()
            MessageBox.Show("All pharmacist has account.", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        myConn.Close()

        AddEditAccountForm.AddMode()
    End Sub

    Private Sub MAEditBtn_Click(sender As Object, e As EventArgs) Handles MAEditBtn.Click
        Dim Index = MADGV.CurrentCell.RowIndex

        'Proceeds to edit account mode with a selected record row
        AddEditAccountForm.EditMode(New List(Of String) From {
                                        MADGV.Rows(Index).Cells(0).Value, 'Account ID (acc_id)
                                        MADGV.Rows(Index).Cells(1).Value, 'Pharmacist ID (phrmcst_id)
                                        MADGV.Rows(Index).Cells(3).Value, 'Username
                                        MADGV.Rows(Index).Cells(4).Value  'Password
                                    })
    End Sub

    Private Sub MADeleteBtn_Click(sender As Object, e As EventArgs) Handles MADeleteBtn.Click
        Dim Index = MADGV.CurrentCell.RowIndex

        'Give warning and show a record before deleting an account
        Dim Message As String = $"Are you sure you want to delete this Account's Record? {vbCrLf}{vbCrLf}" &
                        $"Index: {Index} {vbCrLf}" &
                        $"Account ID: {MADGV.Rows(Index).Cells(0).Value} {vbCrLf}" &
                        $"Pharmacist ID: {MADGV.Rows(Index).Cells(1).Value} {vbCrLf}" &
                        $"Admin ID: {MADGV.Rows(Index).Cells(2).Value} {vbCrLf}" &
                        $"Username: {MADGV.Rows(Index).Cells(3).Value} {vbCrLf}" &
                        $"Password: {MADGV.Rows(Index).Cells(4).Value} {vbCrLf}" &
                        $"Date Created: {MADGV.Rows(Index).Cells(5).Value}"

        Dim result As DialogResult = MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete account if confirmed
        If result = DialogResult.Yes Then
            myConn.Open()

            Sql = "DELETE FROM 
                        pharmacist_accounts 
                    WHERE 
                        acc_id=@id"

            myCmd.Parameters.Clear()
            myCmd.Parameters.AddWithValue("@id", MADGV.Rows(Index).Cells(0).Value)

            myCmd.Connection = myConn
            myCmd.CommandText = Sql

            myCmd.ExecuteNonQuery()
            myConn.Close()

            MessageBox.Show("Account's Record is Successfully Deleted", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpdateDataGrid(DGQuery, MADGV)
        End If
    End Sub

    Private Sub MADGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MADGV.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or String.IsNullOrWhiteSpace(MADGV.SelectedCells(0).Value.ToString()) Then
            EnableSecondaryButton(MAEditBtn, False)
            EnableSecondaryButton(MADeleteBtn, False)
            Return
        End If

        EnableSecondaryButton(MAEditBtn, True)
        EnableSecondaryButton(MADeleteBtn, True)
    End Sub
End Class