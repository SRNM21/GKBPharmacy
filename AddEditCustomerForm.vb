Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AddEditCustomerForm
    Private AddFlag As Boolean

    Public Sub AddMode()
        'Update form
        AddFlag = True

        CFormTitle.Text = "New Customer"
        CPrimaryBtn.Text = "Create"
        ChangeMainWindowForm(Me)
    End Sub

    Public Sub EditMode(Info As List(Of String))
        'Update form
        AddFlag = False

        CFormTitle.Text = "Edit Customer"
        CPrimaryBtn.Text = "Update"

        'Retrieval of data from ManageCustomerForm
        IDLbl.Visible = True
        IDLbl.Text = Info(0)
        FnameTxtBx.Text = Info(1)
        LnameTxtBx.Text = Info(2)
        GenderCmbBx.SelectedItem = Info(3)

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(ManageCustomersForm)
    End Sub

    Private Sub CPrimaryBtn_Click(sender As Object, e As EventArgs) Handles CPrimaryBtn.Click
        If IsValidForm() Then
            ProcessRecord()
            ChangeMainWindowForm(ManageCustomersForm)
        End If
    End Sub

    Private Function IsValidForm() As Boolean
        Dim Warnings As Integer = 0

        ErrProvider.Clear()
        WarningIndicatorLbl.Visible = False

        'Validate Firstname
        If String.IsNullOrWhiteSpace(FnameTxtBx.Text) Then
            ErrProvider.SetError(FnameTxtBxPnl, "First name must not be null")

        ElseIf Not Regex.IsMatch(FnameTxtBx.Text, "\p{L}\b") Then
            ErrProvider.SetError(FnameTxtBxPnl, "First name must not contain numbers or any special characters")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(FnameTxtBxPnl)) Then Warnings += 1

        'Validate Lastname
        If String.IsNullOrWhiteSpace(LnameTxtBx.Text) Then
            ErrProvider.SetError(LnameTxtBxPnl, "Last name must not be null")

        ElseIf Not Regex.IsMatch(LnameTxtBx.Text, "\p{L}\b") Then
            ErrProvider.SetError(LnameTxtBxPnl, "Last name must not contain numbers or any special characters")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(LnameTxtBxPnl)) Then Warnings += 1

        'Validate Gender
        If GenderCmbBx.SelectedIndex = -1 Then
            Warnings += 1
            ErrProvider.SetError(GenderCmbBxPnl, "Gender must not be null")
        End If

        'Return False (Invalid form) if it has 1 or more warning
        If Warnings > 0 Then
            WarningIndicatorLbl.Text = $"* You have {Warnings} warning(s) on this form"
            WarningIndicatorLbl.Visible = True
            Return False
        End If

        Return True
    End Function

    Private Sub ProcessRecord()
        Dim ID As String
        Dim Prompt As String

        'Generate Customer ID if creating a new Customer
        If AddFlag Then
            Dim Attempt As Integer = 10

            ID = GenerateID("CST-")

            'Regenerate Customer ID if the previous Customer ID is already in the database
            While HasDuplicate("customers", "cstmr_id", ID, Nothing) AndAlso Attempt > 0
                ID = GenerateID("CST-")
                Attempt -= 1
            End While

            'Prompt customer is full If after 10 attemps and the ID is still has duplicate
            If HasDuplicate("customers", "cstmr_id", ID, Nothing) Then
                MessageBox.Show("Pharmacists is already full", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Prompt = "A New Customer is Successfully Added"
        Else
            'Use the given Customer ID if in edit mode
            ID = IDLbl.Text
            Prompt = "Customer's Record is Successfully Updated"
        End If

        'Identify the sql syntax based on the form mode
        If AddFlag Then
            Sql = "INSERT INTO 
                        customers 
                            (cstmr_id, first_name, last_name, gender) 
                    VALUES 
                        (@id, @fn, @ln, @gnd)"
        Else
            Sql = "UPDATE 
                        customers 
                    SET 
                        first_name=@fn, 
                        last_name=@ln, 
                        gender=@gnd 
                    WHERE 
                        cstmr_id=@id"
        End If

        myCmd = New MySqlCommand(Sql, myConn)

        myConn.Open()

        'Attach all given values from the form to the parameters of the command
        myCmd.Parameters.AddWithValue("@id", ID)
        myCmd.Parameters.AddWithValue("@fn", FnameTxtBx.Text)
        myCmd.Parameters.AddWithValue("@ln", LnameTxtBx.Text)
        myCmd.Parameters.AddWithValue("@gnd", GenderCmbBx.SelectedItem)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        MessageBox.Show(Prompt, "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class