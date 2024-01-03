Imports MySql.Data.MySqlClient

Public Class AddEditItemForm
    Private AddFlag As Boolean

    Public Sub AddMode()
        'Update form
        AddFlag = True

        IFormTitle.Text = "New Item"
        IPrimaryBtn.Text = "Create"
        ChangeMainWindowForm(Me)
    End Sub

    Public Sub EditMode(Info As List(Of String))
        'Update form
        AddFlag = False

        IFormTitle.Text = "Edit Item"
        IPrimaryBtn.Text = "Update"

        'Retrieval of data from ManageCustomerForm
        CategoryCmbBx.SelectedItem = Info(2)

        If Info(1) IsNot Nothing Then
            'Find the name of the supplier
            myConn.Open()

            Sql = "SELECT 
                    supp_name 
                FROM 
                    suppliers 
                WHERE 
                    supp_id=@id"

            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.Clear()
            myCmd.Parameters.AddWithValue("@id", Info(1))
            myRdr = myCmd.ExecuteReader()

            If myRdr.Read() Then
                SupplierCmbBx.Enabled = True
                SupplierCmbBx.Text = myRdr("supp_name")
            End If
        Else
            SupplierCmbBx.Enabled = True
        End If

        myConn.Close()

        IDLbl.Visible = True
        IDLbl.Text = Info(0)
        ItemTxtBx.Text = Info(3)
        CostTxtBx.Text = Info(4)
        PriceTxtBx.Text = Info(5)
        StockTxtBx.Text = Info(6)

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(ManageItemsForm)
    End Sub

    Private Sub CategoryCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles CategoryCmbBx.SelectedValueChanged
        'Keep the Supplier Combo box Empty while changing category
        SupplierCmbBx.Items.Clear()
        SupplierCmbBx.Enabled = True
        SupplierCmbBx.Text = ""

        myConn.Close()
        myConn.Open()

        'Add all suppliers with the chosen category
        Sql = $"SELECT 
                    supp_name 
                FROM 
                    suppliers 
                WHERE 
                    category='{CategoryCmbBx.SelectedItem}'"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            SupplierCmbBx.Items.Add(myRdr("supp_name"))
        End While

        myConn.Close()
    End Sub

    Private Sub SupplierCmbBx_TextChanged(sender As Object, e As EventArgs) Handles SupplierCmbBx.TextChanged
        'Keeps the Supplier ID Label in input stage
        SupplierDLbl.ForeColor = Color.Red
        SupplierDLbl.Text = "Not Found"

        'Search the ID of the selected Supplier in Supplier Combo box
        If Not String.IsNullOrWhiteSpace(SupplierCmbBx.Text) Then
            myConn.Close()
            myConn.Open()

            Sql = "SELECT 
                        supp_id 
                    FROM 
                        suppliers 
                    WHERE 
                        supp_name=@name"

            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.Clear()
            myCmd.Parameters.AddWithValue("@name", SupplierCmbBx.Text)
            myRdr = myCmd.ExecuteReader()

            'Display the ID of Supplier if found
            If myRdr.Read() Then
                SupplierDLbl.ForeColor = Color.FromArgb(155, 190, 200)
                SupplierDLbl.Text = myRdr("supp_id").ToString()
            End If

            myConn.Close()
        End If
    End Sub

    Private Sub StockTxtBx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StockTxtBx.KeyPress
        'Don't accept non-digit inputs
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

        'Don't accept any further input if the length reached 3
        If StockTxtBx.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub StockTxtBx_TextChanged(sender As Object, e As EventArgs) Handles StockTxtBx.TextChanged
        'Keep the StockTxtBx text only 3 characters
        If StockTxtBx.Text.Length > 3 Then
            StockTxtBx.Text = StockTxtBx.Text.Substring(0, 3)
            StockTxtBx.SelectionStart = StockTxtBx.Text.Length
        End If

        'Change the given stock to the maximum of 200
        Dim number As Integer
        If Integer.TryParse(StockTxtBx.Text, number) AndAlso number > 200 Then
            StockTxtBx.Text = "200"
        End If
    End Sub

    Private Sub CostTxtBx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostTxtBx.KeyPress
        'Don't Accept non-digits and only one decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not (e.KeyChar = "." AndAlso Not CostTxtBx.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CostTxtBx_TextChanged(sender As Object, e As EventArgs) Handles CostTxtBx.TextChanged
        'Keep the StockTxtBx text only 15 characters
        If CostTxtBx.Text.Length > 15 Then
            CostTxtBx.Text = CostTxtBx.Text.Substring(0, 15)
            CostTxtBx.SelectionStart = CostTxtBx.Text.Length
        End If

        'Change the given cost to the maximum of 100000
        Dim number As Integer
        If Integer.TryParse(CostTxtBx.Text, number) AndAlso number > 100000 Then
            CostTxtBx.Text = "100000"
        End If
    End Sub

    Private Sub PriceTxtBx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceTxtBx.KeyPress
        'Don't Accept non-digits and only one decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not (e.KeyChar = "." AndAlso Not PriceTxtBx.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PriceTxtBx_TextChanged(sender As Object, e As EventArgs) Handles PriceTxtBx.TextChanged
        'Keep the PriceTxtBx text only 15 characters
        If PriceTxtBx.Text.Length > 15 Then
            PriceTxtBx.Text = PriceTxtBx.Text.Substring(0, 15)
            PriceTxtBx.SelectionStart = PriceTxtBx.Text.Length
        End If

        'Change the given price to the maximum of 100000
        Dim number As Integer
        If Integer.TryParse(PriceTxtBx.Text, number) AndAlso number > 100000 Then
            PriceTxtBx.Text = "100000"
        End If
    End Sub

    Private Sub IPrimaryBtn_Click(sender As Object, e As EventArgs) Handles IPrimaryBtn.Click
        If IsValidForm() Then
            ProcessRecord()
            ChangeMainWindowForm(ManageItemsForm)
        End If
    End Sub

    Private Function IsValidForm() As Boolean
        Dim Warnings As Integer = 0

        ErrProvider.Clear()
        WarningIndicatorLbl.Visible = False

        'Validate Item
        If String.IsNullOrWhiteSpace(ItemTxtBx.Text) Then
            ErrProvider.SetError(ItemTxtBxPnl, "Item must not be null")

        ElseIf ItemTxtBx.Text.Length > 200 Then
            ErrProvider.SetError(ItemTxtBxPnl, "Item must be below 200 characters")

        ElseIf HasDuplicate("items", "name", ItemTxtBx.Text.ToUpper().Trim(), Nothing) Then
            ErrProvider.SetError(ItemTxtBxPnl, "Item is already exist")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(ItemTxtBxPnl)) Then Warnings += 1

        'Validate Category
        If CategoryCmbBx.SelectedIndex = -1 Then
            Warnings += 1
            ErrProvider.SetError(CategoryCmbBxPnl, "Category must not be null")
        End If

        'Validate Stock
        If String.IsNullOrWhiteSpace(StockTxtBx.Text) Then
            ErrProvider.SetError(StockTxtBxPnl, "Stock must not be null")

        ElseIf Not Integer.TryParse(StockTxtBx.Text, Nothing) Then
            ErrProvider.SetError(StockTxtBxPnl, "Stock must contain numbers only")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(StockTxtBxPnl)) Then Warnings += 1

        'Validate Supplier
        If SupplierCmbBx.SelectedIndex = -1 Then
            ErrProvider.SetError(SupplierPnl, "Supplier must not be null")

        ElseIf SupplierDLbl.Text = "Not Found" Then
            ErrProvider.SetError(SupplierPnl, "Supplier does not exist")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(SupplierPnl)) Then Warnings += 1

        'Validate Cost
        Dim Cost As Decimal

        If String.IsNullOrWhiteSpace(CostTxtBx.Text) Then
            ErrProvider.SetError(CostTxtBxPnl, "Cost must not be null")

        ElseIf Not Decimal.TryParse(CostTxtBx.Text, Cost) Then
            ErrProvider.SetError(CostTxtBxPnl, "Cost must contain numbers only")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(CostTxtBxPnl)) Then Warnings += 1

        'Validate Price
        Dim Price As Decimal

        If String.IsNullOrWhiteSpace(PriceTxtBx.Text) Then
            ErrProvider.SetError(PricePnl, "Price must not be null")

        ElseIf Not Decimal.TryParse(PriceTxtBx.Text, Price) Then
            ErrProvider.SetError(PricePnl, "Price must contain numbers only")
        End If

        If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(PricePnl)) Then Warnings += 1

        If Warnings > 0 Then
            WarningIndicatorLbl.Text = $"* You have {Warnings} warning(s) on this form"
            WarningIndicatorLbl.Visible = True
            Return False
        End If

        If Cost >= Price Then
            If MessageBox.Show("The cost should be less than to the price. " & vbCrLf & vbCrLf &
                                "Explanation:" & vbCrLf &
                                "The cost represents the amount spent to acquire or produce an item, " &
                                "while the price is the amount at which the item is sold. " &
                                "For accurate financial representation, the cost should be less than or equal to the price." & vbCrLf & vbCrLf &
                                "Do you wish to continue creating this item?", "GKB Pharmacy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub ProcessRecord()
        Dim ID As String
        Dim Prompt As String

        'Generate Item ID if creating a new Item
        If AddFlag Then
            Dim Attempt As Integer = 10

            ID = GenerateID("ITM-")

            'Regenerate Item ID if the previous Item ID is already in the database
            While HasDuplicate("items", "item_id", ID, Nothing) AndAlso Attempt > 0
                ID = GenerateID("ITM-")
                Attempt -= 1
            End While

            'Prompt item is full If after 10 attemps and the ID is still has duplicate
            If HasDuplicate("items", "item_id", ID, Nothing) Then
                MessageBox.Show("Pharmacists is already full", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Prompt = "A New Item is Successfully Added"
        Else
            'Use the given Item ID if in edit mode
            ID = IDLbl.Text
            Prompt = "Item's Record is Successfully Updated"
        End If

        'Identify the sql syntax based on the form mode
        If AddFlag Then
            Sql = "INSERT INTO 
                        items 
                            (item_id, supp_id, category, name, cost, price, stock)  
                    VALUES 
                        (@i_id, @s_id, @ct, @nm, @cs, @pr, @st)"
        Else
            Sql = "UPDATE 
                        items 
                    SET 
                        supp_id=@s_id, 
                        category=@ct, 
                        name=@nm, 
                        cost=@cs, 
                        price=@pr, 
                        stock=@st  
                    WHERE 
                        item_id=@i_id"
        End If

        myCmd = New MySqlCommand(Sql, myConn)

        myConn.Open()

        'Attach all given values from the form to the parameters of the command
        myCmd.Parameters.AddWithValue("@i_id", ID)
        myCmd.Parameters.AddWithValue("@s_id", SupplierDLbl.Text)
        myCmd.Parameters.AddWithValue("@ct", CategoryCmbBx.SelectedItem)
        myCmd.Parameters.AddWithValue("@nm", ItemTxtBx.Text)
        myCmd.Parameters.AddWithValue("@cs", CostTxtBx.Text)
        myCmd.Parameters.AddWithValue("@pr", PriceTxtBx.Text)
        myCmd.Parameters.AddWithValue("@st", StockTxtBx.Text)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        MessageBox.Show(Prompt, "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class