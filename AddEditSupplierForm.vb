Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AddEditSupplierForm
    Private AddFLag As Boolean

    Public Sub AddMode()
        'Update form
        AddFLag = True

        SFormTitle.Text = "New Supplier"
        SPrimaryBtn.Text = "Create"
        ChangeMainWindowForm(Me)
    End Sub

    Public Sub EditMode(Info As List(Of String))
        'Update form
        AddFLag = False

        SFormTitle.Text = "Edit Suppplier"
        SPrimaryBtn.Text = "Update"

        'Retrieval of data from ManageSupplierForm
        IDLbl.Visible = True
        IDLbl.Text = Info(0)
        SupplierTxtBx.Text = Info(1)
        CategoryCmbBx.SelectedItem = Info(2)
        PhoneNumTxtBx.Text = Info(3)
        EmailTxtBx.Text = Info(4)

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(ManageSupplierForm)
    End Sub

    Private Sub PhoneNumTxtBx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneNumTxtBx.KeyPress
        'Don't accept if the input is not a number
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then e.Handled = True

        'Don't accept any further input if the character length reached 11 
        If PhoneNumTxtBx.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub SPrimaryBtn_Click(sender As Object, e As EventArgs) Handles SPrimaryBtn.Click
        If IsValidForm() Then
            ProcessRecord()
            ChangeMainWindowForm(ManageSupplierForm)
        End If
    End Sub

    Private Function IsValidForm() As Boolean
        Dim Warnings As Integer = 0

        ErrProvider.Clear()
        WarningIndicatorLbl.Visible = False

        'Validate Supplier name
        If String.IsNullOrWhiteSpace(SupplierTxtBx.Text) Then
            ErrProvider.SetError(SupplierTxtBxPnl, "Supplier name must not be null")

        ElseIf SupplierTxtBx.Text.Length > 200 Then
            ErrProvider.SetError(SupplierTxtBxPnl, "Supplier name must be below 200 characters")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(SupplierTxtBxPnl)) Then Warnings += 1

        'Validate Category
        If CategoryCmbBx.SelectedIndex = -1 Then
            Warnings += 1
            ErrProvider.SetError(CategoryCmbBxPnl, "Category must not be null")
        End If

        'Validate Email
        If String.IsNullOrWhiteSpace(EmailTxtBx.Text) Then
            ErrProvider.SetError(EmailTxtBxPnl, "Email must not be null")

        ElseIf Not Regex.IsMatch(EmailTxtBx.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            ErrProvider.SetError(EmailTxtBxPnl, "Invalid Email Format")

        ElseIf EmailTxtBx.Text.Length > 200 Then
            ErrProvider.SetError(EmailTxtBxPnl, "Email must be below 200 characters")

        ElseIf HasDuplicate("suppliers", "email", EmailTxtBx.Text,
                                If(AddFlag, Nothing, New List(Of String) From {"supp_id", IDLbl.Text})) Then

            ErrProvider.SetError(EmailTxtBxPnl, "Email is already in use")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(EmailTxtBxPnl)) Then Warnings += 1

        'Validate Phone number
        If String.IsNullOrWhiteSpace(PhoneNumTxtBx.Text) Then
            ErrProvider.SetError(PhoneNumTxtBxPnl, "Phone number must not be null")

        ElseIf PhoneNumTxtBx.Text.Length <> 11 Then
            ErrProvider.SetError(PhoneNumTxtBxPnl, "Phone number must be 11 digits long")

        ElseIf Not Regex.IsMatch(PhoneNumTxtBx.Text, "^09") Then
            ErrProvider.SetError(PhoneNumTxtBxPnl, "Phone number must start with '09'")

        ElseIf HasDuplicate("suppliers", "phone_number", PhoneNumTxtBx.Text,
                                If(AddFlag, Nothing, New List(Of String) From {"supp_id", IDLbl.Text})) Then

            ErrProvider.SetError(PhoneNumTxtBxPnl, "Phone number is already in use")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(PhoneNumTxtBxPnl)) Then Warnings += 1

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

        'Generate Supplier ID if creating a new Supplier
        If AddFLag Then
            Dim Attempt As Integer = 10

            ID = GenerateID("SUP-")

            'Regenerate Supplier ID if the previous Supplier ID is already in the database
            While HasDuplicate("suppliers", "supp_id", ID, Nothing) AndAlso Attempt > 0
                ID = GenerateID("SUP-")
                Attempt -= 1
            End While

            'Prompt supplier is full If after 10 attemps and the ID is still has duplicate
            If HasDuplicate("suppliers", "supp_id", ID, Nothing) Then
                MessageBox.Show("Suppliers is already full", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Prompt = "A New Supplier is Successfully Added"
        Else
            'Use the given Supplier ID if in edit mode
            ID = IDLbl.Text
            Prompt = "Supplier's Record is Successfully Updated"
        End If

        'Identify the sql syntax based on the form mode
        If AddFLag Then
            Sql = "INSERT INTO 
                        suppliers 
                            (supp_id, supp_name, category, phone_number, email) 
                    VALUES 
                        (@id, @sn, @ct, @pn, @em)"
        Else
            Sql = "UPDATE 
                        suppliers 
                    SET 
                        supp_name=@sn, 
                        category=@ct, 
                        phone_number=@pn, 
                        email=@em 
                    WHERE 
                        supp_id=@id"

        End If

        myCmd = New MySqlCommand(Sql, myConn)

        myConn.Open()

        'Attach all given values from the form to the parameters of the command
        myCmd.Parameters.AddWithValue("@id", ID)
        myCmd.Parameters.AddWithValue("@sn", SupplierTxtBx.Text)
        myCmd.Parameters.AddWithValue("@ct", CategoryCmbBx.SelectedItem)
        myCmd.Parameters.AddWithValue("@pn", PhoneNumTxtBx.Text)
        myCmd.Parameters.AddWithValue("@em", EmailTxtBx.Text)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        MessageBox.Show(Prompt, "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class