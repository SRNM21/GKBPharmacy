Imports MySql.Data.MySqlClient

Public Class ManagePharmacistsForm
    Private DGQuery As String = "SELECT 
                                    p.*, 
                                    CASE WHEN 
                                        pa.phrmcst_id 
                                    IS NOT NULL THEN 
                                        'True' 
                                    ELSE 
                                        'False' 
                                    END 
                                    AS 
                                        has_account
                                FROM 
                                    pharmacists p
                                LEFT JOIN 
                                    pharmacist_accounts pa ON p.phrmcst_id = pa.phrmcst_id"

    Private Sub ManagePharmacistsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDataGrid(DGQuery, MPDGV) 'Add all pharmacists in datagridview

        EnableSecondaryButton(MPEditBtn, False)
        EnableSecondaryButton(MPDeleteBtn, False)
    End Sub

    Private Sub MPSearchBtn_Click(sender As Object, e As EventArgs) Handles MPSearchBtn.Click
        SearchInDataGrid(MPDGV, MPSearchTxtBx.Text)
    End Sub

    Private Sub MPNewBtn_Click(sender As Object, e As EventArgs) Handles MPNewBtn.Click
        AddEditPharmacistForm.AddMode()
    End Sub

    Private Sub MPEditBtn_Click(sender As Object, e As EventArgs) Handles MPEditBtn.Click
        Dim Index = MPDGV.CurrentCell.RowIndex

        If MPDGV.Rows(Index).Cells(0).Value = "PHA--ADMIN--123" Then
            Return
        End If

        'Proceeds to edit pharmacist mode with a selected record row
        AddEditPharmacistForm.EditMode(New List(Of String) From {
                                            MPDGV.Rows(Index).Cells(0).Value, 'Pharmacist ID (phrmcst_id)
                                            MPDGV.Rows(Index).Cells(1).Value, 'Firstname (first_name)
                                            MPDGV.Rows(Index).Cells(2).Value, 'Lastname (last_name)
                                            MPDGV.Rows(Index).Cells(3).Value, 'Birthdate (birth_date)
                                            MPDGV.Rows(Index).Cells(4).Value, 'Gender
                                            MPDGV.Rows(Index).Cells(5).Value, 'Email
                                            MPDGV.Rows(Index).Cells(6).Value  'Phone number
                                       })
    End Sub

    Private Sub MPDeleteBtn_Click(sender As Object, e As EventArgs) Handles MPDeleteBtn.Click
        Dim Index = MPDGV.CurrentCell.RowIndex

        If MPDGV.Rows(Index).Cells(0).Value = "PHA--ADMIN--123" Then
            Return
        End If

        'Give warning and show a record before deleting a pharmacist
        Dim Message As String = $"Are you sure you want to delete this Pharmacist's Record? {vbCrLf}{vbCrLf}" &
                        $"Index: {Index} {vbCrLf}" &
                        $"Pharmacist ID: {MPDGV.Rows(Index).Cells(0).Value} {vbCrLf}" &
                        $"First name: {MPDGV.Rows(Index).Cells(1).Value} {vbCrLf}" &
                        $"Last name: {MPDGV.Rows(Index).Cells(2).Value} {vbCrLf}" &
                        $"Birth date: {MPDGV.Rows(Index).Cells(3).Value} {vbCrLf}" &
                        $"Gender: {MPDGV.Rows(Index).Cells(4).Value} {vbCrLf}" &
                        $"Email: {MPDGV.Rows(Index).Cells(5).Value} {vbCrLf}" &
                        $"Phone number: {MPDGV.Rows(Index).Cells(6).Value}"

        Dim result As DialogResult = MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete pharmacist if confirmed
        If result = DialogResult.Yes Then
            Sql = $"DELETE FROM 
                        pharmacists    
                    WHERE 
                        phrmcst_id='{MPDGV.Rows(Index).Cells(0).Value}'"

            myConn.Open()
            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.ExecuteNonQuery()
            myConn.Close()

            MessageBox.Show("Pharmacist's Record is Successfully Deleted", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateDataGrid(DGQuery, MPDGV)
        End If
    End Sub

    Private Sub CreateAccBtn_Click(sender As Object, e As EventArgs) Handles CreateAccBtn.Click
        Dim Index = MPDGV.CurrentCell.RowIndex

        If MPDGV.Rows(Index).Cells(0).Value = "PHA--ADMIN--123" Then
            Return
        End If

        'Proceeds to add/direct create pharmacist account mode with a selected record row
        AddEditAccountForm.DirectCreateAccount(New List(Of String) From {
                                            MPDGV.Rows(Index).Cells(0).Value, 'Pharmacist ID (phrmcst_id)
                                            MPDGV.Rows(Index).Cells(1).Value, 'Firstname (first_name)
                                            MPDGV.Rows(Index).Cells(2).Value  'Lastname (last_name)
                                       })
    End Sub

    Private Sub MPDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MPDGV.CellClick
        CreateAccBtn.Visible = False
        EnableSecondaryButton(MPEditBtn, False)
        EnableSecondaryButton(MPDeleteBtn, False)

        'Keep the Edit/Delete button disabled if the selected cell has no record
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or String.IsNullOrWhiteSpace(MPDGV.SelectedCells(0).Value.ToString()) Then
            Return
        End If

        'Disable Modification buttons if clicked on the super account
        If MPDGV.Rows(e.RowIndex).Cells(0).Value = "PHA--ADMIN--123" Then
            Return
        End If

        'Show create account button if the pharmacist's does not have an account
        If MPDGV.Rows(e.RowIndex).Cells(7).Value = "False" Then
            CreateAccBtn.Visible = True
        End If

        EnableSecondaryButton(MPEditBtn, True)
        EnableSecondaryButton(MPDeleteBtn, True)
    End Sub

End Class