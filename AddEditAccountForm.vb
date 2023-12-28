Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AddEditAccountForm
    Private ShowPassFlag As Boolean = False
    Private ShowConfirmPassFlag As Boolean = False
    Private Strength As Integer = 0
    Private AddFlag As Boolean
    Private PrevPharma As Boolean

    Public Sub AddMode()
        'Update form
        AddFlag = True

        AFormTitle.Text = "New Account"
        APrimaryBtn.Text = "Create"

        'Adding pharmacists who don't have account to the Form's ComboBox
        myConn.Open()

        Sql = "SELECT 
                    first_name, 
                    last_name
                FROM    
                    pharmacists
                WHERE NOT EXISTS (
                    SELECT 
                        1
                    FROM 
                        pharmacist_accounts
                    WHERE 
                        pharmacist_accounts.phrmcst_id = pharmacists.phrmcst_id
                ) AND pharmacists.phrmcst_id <> 'PHA--ADMIN--123'"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            PharmacistCmbBx.Items.Add($"{myRdr("first_name")} {myRdr("last_name")}")
        End While

        myConn.Close()

        ChangeMainWindowForm(Me)
    End Sub

    Public Sub EditMode(Info As List(Of String))
        'Update form
        AddFlag = False

        AFormTitle.Text = "Edit Account"
        APrimaryBtn.Text = "Update"

        'Retrieval of data from ManageAccountsForm
        myConn.Open()

        Sql = "SELECT 
                    first_name, 
                    last_name 
                FROM 
                    pharmacists     
                WHERE 
                    phrmcst_id=@id"

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", Info(1))
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read() Then
            PharmacistCmbBx.Text = $"{myRdr("first_name")} {myRdr("last_name")}"
            PharmacistCmbBx.Enabled = False
        End If

        myConn.Close()

        IDLbl.Visible = True
        IDLbl.Text = Info(0)
        PharmacistIDLbl.Text = Info(1)
        UsernameTxtBx.Text = Info(2)
        PasswordTxtBx.Text = Info(3)
        ConfirmPassTxtBx.Text = Info(3)

        ChangeMainWindowForm(Me)
    End Sub

    Public Sub DirectCreateAccount(Info As List(Of String))
        'Update Form
        AddFlag = True
        PrevPharma = True

        AFormTitle.Text = "Add Account"
        APrimaryBtn.Text = "Create"

        'Retrieval of data from ManagePharmacistsForm
        PharmacistIDLbl.Text = Info(0)
        PharmacistCmbBx.Text = $"{Info(1)} {Info(2)}"
        PharmacistCmbBx.Enabled = False

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        'Go back to the previous form before creating/direct creating an account
        ChangeMainWindowForm(If(PrevPharma, ManagePharmacistsForm, ManageAccountForm))
    End Sub

    Private Sub PassShowHideBtn_Click(sender As Object, e As EventArgs) Handles PassShowHideBtn.Click
        If ShowPassFlag Then
            PasswordTxtBx.UseSystemPasswordChar = True
            PassShowHideBtn.BackgroundImage = My.Resources.HidePass
        Else
            PasswordTxtBx.UseSystemPasswordChar = False
            PassShowHideBtn.BackgroundImage = My.Resources.ShowPass
        End If

        ShowPassFlag = Not ShowPassFlag
    End Sub

    Private Sub ConfirmPassShowHideBtn_Click(sender As Object, e As EventArgs) Handles ConfirmPassShowHideBtn.Click
        If ShowConfirmPassFlag Then
            ConfirmPassTxtBx.UseSystemPasswordChar = True
            ConfirmPassShowHideBtn.BackgroundImage = My.Resources.HidePass
        Else
            ConfirmPassTxtBx.UseSystemPasswordChar = False
            ConfirmPassShowHideBtn.BackgroundImage = My.Resources.ShowPass
        End If

        ShowConfirmPassFlag = Not ShowConfirmPassFlag
    End Sub

    Private Sub PasswordTxtBx_TextChanged(sender As Object, e As EventArgs) Handles PasswordTxtBx.TextChanged
        Dim Password As String = PasswordTxtBx.Text
        PassStrengthIndicator.Visible = False
        Strength = 0

        'Update the strength of password based on the inputs
        If Not String.IsNullOrEmpty(Password) Then
            PassStrengthIndicator.Visible = True

            If Password.Length >= 8 Then Strength += 20
            If Regex.IsMatch(Password, "[A-Z]") Then Strength += 20
            If Regex.IsMatch(Password, "[a-z]") Then Strength += 20
            If Regex.IsMatch(Password, "\d") Then Strength += 20
            If Regex.IsMatch(Password, "[!@#$%^&*()_+{}\[\]:;<>,.?~\\/\|`-]") Then Strength += 20
        End If

        'Change the color of strength indicator based on the strength
        Select Case Strength
            Case <= 20
                PassStrength.BackColor = Color.Gray
                PassStrengthIndicator.ForeColor = Color.Gray
                PassStrengthIndicator.Text = "Very Weak"
            Case <= 40
                PassStrength.BackColor = Color.Red
                PassStrengthIndicator.ForeColor = Color.Red
                PassStrengthIndicator.Text = "Weak"
            Case <= 60
                PassStrength.BackColor = Color.Orange
                PassStrengthIndicator.ForeColor = Color.Orange
                PassStrengthIndicator.Text = "Fair"
            Case <= 80
                PassStrength.BackColor = Color.Green
                PassStrengthIndicator.ForeColor = Color.Green
                PassStrengthIndicator.Text = "Good"
            Case <= 100
                PassStrength.BackColor = Color.FromArgb(66, 125, 157)
                PassStrengthIndicator.ForeColor = Color.FromArgb(66, 125, 157)
                PassStrengthIndicator.Text = "Strong"
        End Select

        'Update the width of Strength indicator 
        PassStrength.Width = CInt(PassStrengthPnl.Width * (Strength / 100))
    End Sub

    Private Sub APrimaryBtn_Click(sender As Object, e As EventArgs) Handles APrimaryBtn.Click
        If IsValidForm() Then
            ProcessRecord()
            ChangeMainWindowForm(ManageAccountForm)
        End If
    End Sub

    Private Function IsValidForm() As Boolean
        Dim Warnings As Integer = 0

        ErrProvider.Clear()
        WarningIndicatorLbl.Visible = False

        'Validate Pharmacist
        If String.IsNullOrWhiteSpace(PharmacistCmbBx.Text) Then
            ErrProvider.SetError(PhrmcstCmbBxPnl, "Pharmacist ID must not be null")

        ElseIf PharmacistIDLbl.Text = "Not found" Then
            ErrProvider.SetError(PhrmcstCmbBxPnl, "Pharmacist does not exist")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(PhrmcstCmbBxPnl)) Then Warnings += 1

        'Validate Username
        If String.IsNullOrWhiteSpace(UsernameTxtBx.Text) Then
            ErrProvider.SetError(UsernameTxtBxPnl, "Username must not be null")

        ElseIf Not Regex.IsMatch(UsernameTxtBx.Text, "^[a-zA-Z0-9_]+$") Then
            ErrProvider.SetError(UsernameTxtBxPnl, "Username must not contain spaces or invalid characters")

        ElseIf UsernameTxtBx.Text.Length < 5 OrElse UsernameTxtBx.Text.Length > 20 Then
            ErrProvider.SetError(UsernameTxtBxPnl, "Username must be 5 to 20 characters long")

        ElseIf HasDuplicate("pharmacist_accounts", "username", UsernameTxtBx.Text,
                                If(AddFlag, Nothing, New List(Of String) From {"acc_id", IDLbl.Text})) Then

            ErrProvider.SetError(UsernameTxtBxPnl, "Username is already taken")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(UsernameTxtBxPnl)) Then Warnings += 1

        'Validate Password
        If String.IsNullOrWhiteSpace(PasswordTxtBx.Text) Then
            ErrProvider.SetError(PasswordTxtBxPnl, "Password must not be null")

        ElseIf PasswordTxtBx.Text.Length < 5 Then
            ErrProvider.SetError(PasswordTxtBxPnl, "Password must be at least 5 characters long")

        ElseIf PasswordTxtBx.Text.Length > 200 Then
            ErrProvider.SetError(PasswordTxtBxPnl, "Password must be below 200 characters")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(PasswordTxtBxPnl)) Then Warnings += 1

        'Validate Confirm Password
        If String.IsNullOrWhiteSpace(ConfirmPassTxtBx.Text) Then
            ErrProvider.SetError(ConfirmPassTxtBxPnl, "Confirm password must not be null")

        ElseIf PasswordTxtBx.Text <> ConfirmPassTxtBx.Text Then
            ErrProvider.SetError(ConfirmPassTxtBxPnl, "Password does not match")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(ConfirmPassTxtBxPnl)) Then Warnings += 1

        'Return False (Invalid form) if it has 1 or more warning
        If Warnings > 0 Then
            WarningIndicatorLbl.Text = $"* You have {Warnings} warning(s) on this form"
            WarningIndicatorLbl.Visible = True
            Return False
        End If

        'Ask the creator to continue if the password is weak (40 and below password strength)
        If Strength <= 40 Then
            If MessageBox.Show("Are you sure to create an account with weak password?", "GKB Pharmacy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub ProcessRecord()
        Dim ID As String
        Dim Prompt As String

        'Generate Pharmacist Account ID if creating a new Pharmacist Account
        If AddFlag Then
            Dim Attempt As Integer = 10

            ID = GenerateID("PHAC-")

            'Regenerate Pharmacist Account ID if the previous Pharmacist Account ID is already exist 
            While HasDuplicate("pharmacist_accounts", "acc_id", ID, Nothing) AndAlso Attempt > 0
                ID = GenerateID("PHAC-")
                Attempt -= 1
            End While

            'Prompt pharmacist account is full If after 10 attemps and the ID is still has duplicate
            If HasDuplicate("pharmacist_accounts", "acc_id", ID, Nothing) Then
                MessageBox.Show("Pharmacist is already full", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Prompt = "A New Pharmacist Account is Successfully Added"
        Else
            'Use the given Pharmacist Account ID if in edit mode
            ID = IDLbl.Text
            Prompt = "Pharmacist Account's Record is Successfully Updated"
        End If

        'Identify the sql syntax based on the form mode
        If AddFlag Then
            Sql = "INSERT INTO 
                        pharmacist_accounts 
                            (acc_id, phrmcst_id, admin_id, username, password, date_created)    
                    VALUES  
                        (@a_id, @ph_id, @adm_id, @un, @pw, @dc)"

            'Attach all the related ID's when creating tje account
            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@adm_id", UserID)
            myCmd.Parameters.AddWithValue("@ph_id", PharmacistIDLbl.Text)
            myCmd.Parameters.AddWithValue("@dc", Date.Now)
        Else
            Sql = "UPDATE 
                        pharmacist_accounts 
                    SET 
                        username=@un, 
                        password=@pw 
                    WHERE 
                        acc_id=@a_id"

            myCmd = New MySqlCommand(Sql, myConn)
        End If

        myConn.Open()

        'Attach all given values from the form to the parameters of the command
        myCmd.Parameters.AddWithValue("@a_id", ID)
        myCmd.Parameters.AddWithValue("@un", UsernameTxtBx.Text)
        myCmd.Parameters.AddWithValue("@pw", PasswordTxtBx.Text)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        MessageBox.Show(Prompt, "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PharmacistCmbBx_TextChanged(sender As Object, e As EventArgs) Handles PharmacistCmbBx.TextChanged
        'Keeps the Pharmacist ID Label in input stage
        PharmacistIDLbl.ForeColor = Color.Red
        PharmacistIDLbl.Text = "Not Found"

        'Search the ID of the selected Pharmacist in Pharmacist Combo box
        If Not String.IsNullOrWhiteSpace(PharmacistCmbBx.Text) Then
            myConn.Close()
            myConn.Open()

            Sql = "SELECT
                        phrmcst_id 
                    FROM 
                        pharmacists 
                    WHERE 
                        CONCAT(first_name, ' ', last_name)=@fullname"

            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@fullname", PharmacistCmbBx.Text)
            myRdr = myCmd.ExecuteReader()

            'Display the ID of Pharmacist if found
            If myRdr.Read() Then
                PharmacistIDLbl.ForeColor = Color.FromArgb(155, 190, 200)
                PharmacistIDLbl.Text = myRdr("phrmcst_id").ToString()
            End If

            myConn.Close()
        End If
    End Sub
End Class