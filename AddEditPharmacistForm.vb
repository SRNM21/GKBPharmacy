Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AddEditPharmacistForm
    Private AddFlag As Boolean

    Public Sub AddMode()
        'Update form
        AddFlag = True

        PFormTitle.Text = "New Pharmacist"
        PPrimaryBtn.Text = "Create"
        ChangeMainWindowForm(Me)
    End Sub

    Public Sub EditMode(Info As List(Of String))
        'Update form
        AddFlag = False

        PFormTitle.Text = "Edit Pharmacist"
        PPrimaryBtn.Text = "Update"

        BirthDatePckr.Format = DateTimePickerFormat.Short

        'Retrieval of data from ManagePharmacistForm
        IDLbl.Visible = True
        IDLbl.Text = Info(0)
        FnameTxtBx.Text = Info(1)
        LnameTxtBx.Text = Info(2)
        BirthDatePckr.Value = Info(3)
        GenderCmbBx.SelectedItem = Info(4)
        EmailTxtBx.Text = Info(5)
        PhoneNumTxtBx.Text = Info(6)

        BirthDatePckr.Select()

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub PhoneNumTxtBx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneNumTxtBx.KeyPress
        'Don't accept if the input is not a number
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then e.Handled = True

        'Don't accept any further input if the character length reached 11 
        If PhoneNumTxtBx.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(ManagePharmacistsForm)
    End Sub

    Private Sub BirthDatePckr_ValueChanged(sender As Object, e As EventArgs) Handles BirthDatePckr.ValueChanged
        BirthDatePckr.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub PPrimaryBtn_Click(sender As Object, e As EventArgs) Handles PPrimaryBtn.Click
        If IsValidForm() Then
            ProcessRecord()
            ChangeMainWindowForm(ManagePharmacistsForm)
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

        'Validate Birthdate
        If String.IsNullOrWhiteSpace(BirthDatePckr.Text) Then
            ErrProvider.SetError(BirthDatePnl, "Birth date must not be null")

        ElseIf BirthDatePckr.Value <= Date.Now.AddYears(-150) Or BirthDatePckr.Value > Date.Now Then
            ErrProvider.SetError(BirthDatePnl, "Invalid Birth date")

        ElseIf BirthDatePckr.Value >= Date.Now.AddYears(-21) Then
            ErrProvider.SetError(BirthDatePnl, "A Pharmacist must be 21 Years old and above")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(BirthDatePnl)) Then Warnings += 1

        'Validate Gender
        If GenderCmbBx.SelectedIndex = -1 Then
            Warnings += 1
            ErrProvider.SetError(GenderCmbBxPnl, "Gender must not be null")
        End If

        'Validate Email
        If String.IsNullOrWhiteSpace(EmailTxtBx.Text) Then
            ErrProvider.SetError(EmailPnl, "Email must not be null")

        ElseIf Not Regex.IsMatch(EmailTxtBx.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            ErrProvider.SetError(EmailPnl, "Invalid Email Format")

        ElseIf EmailTxtBx.Text.Length > 200 Then
            ErrProvider.SetError(EmailPnl, "Email must be below 200 characters")

        ElseIf HasDuplicate("pharmacists", "email", EmailTxtBx.Text,
                                If(AddFlag, Nothing, New List(Of String) From {"phrmcst_id", IDLbl.Text})) Then

            ErrProvider.SetError(EmailPnl, "Email is already in use")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(EmailPnl)) Then Warnings += 1

        'Validate Phone number
        If String.IsNullOrWhiteSpace(PhoneNumTxtBx.Text) Then
            ErrProvider.SetError(PhoneNumPnl, "Phone number must not be null")

        ElseIf PhoneNumTxtBx.Text.Length <> 11 Then
            ErrProvider.SetError(PhoneNumPnl, "Phone number must be 11 digits long")

        ElseIf Not Regex.IsMatch(PhoneNumTxtBx.Text, "^09") Then
            ErrProvider.SetError(PhoneNumPnl, "Phone number must start with '09'")

        ElseIf HasDuplicate("pharmacists", "phone_num", PhoneNumTxtBx.Text,
                                If(AddFlag, Nothing, New List(Of String) From {"phrmcst_id", IDLbl.Text})) Then

            ErrProvider.SetError(PhoneNumPnl, "Phone number is already in use")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(PhoneNumPnl)) Then Warnings += 1

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

        'Generate Pharmacist ID if creating a new Pharmacist
        If AddFlag Then
            Dim Attempt As Integer = 10

            ID = GenerateID("PHA-")

            'Regenerate Pharmacist ID if the previous Pharmacist ID is already exist 
            While HasDuplicate("pharmacists", "phrmcst_id", ID, Nothing) AndAlso Attempt > 0
                ID = GenerateID("PHA-")
                Attempt -= 1
            End While

            'Prompt pharmacist is full If after 10 attemps and the ID is still has duplicate
            If HasDuplicate("pharmacists", "phrmcst_id", ID, Nothing) Then
                MessageBox.Show("Pharmacists is already full", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Prompt = "A New Pharmacist is Successfully Added"
        Else
            'Use the given Pharmacist ID if in edit mode
            ID = IDLbl.Text
            Prompt = "Pharmacist's Record is Successfully Updated"
        End If

        'Identify the sql syntax based on the form mode
        If AddFlag Then
            Sql = "INSERT INTO 
                        pharmacists 
                            (phrmcst_id, first_name, last_name, birth_date, gender, email, phone_num) 
                    VALUES 
                        (@id, @fn, @ln, @bd, @gndr, @eml, @pn)"
        Else
            Sql = "UPDATE 
                        pharmacists 
                    SET 
                        first_name=@fn, 
                        last_name=@ln, 
                        birth_date=@bd, 
                        gender=@gndr, 
                        email=@eml,     
                        phone_num=@pn 
                    WHERE 
                        phrmcst_id=@id"
        End If

        myCmd = New MySqlCommand(Sql, myConn)

        myConn.Open()

        'Attach all given values from the form to the parameters of the command
        myCmd.Parameters.AddWithValue("@id", ID)
        myCmd.Parameters.AddWithValue("@fn", FnameTxtBx.Text)
        myCmd.Parameters.AddWithValue("@ln", LnameTxtBx.Text)
        myCmd.Parameters.AddWithValue("@bd", BirthDatePckr.Value.ToString("yyyy-MM-dd"))
        myCmd.Parameters.AddWithValue("@gndr", GenderCmbBx.SelectedItem)
        myCmd.Parameters.AddWithValue("@eml", EmailTxtBx.Text)
        myCmd.Parameters.AddWithValue("@pn", PhoneNumTxtBx.Text)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        MessageBox.Show(Prompt, "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class