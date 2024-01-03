Imports MySql.Data.MySqlClient

Public Class AddEditOrderForm
    Private AddFlag As Boolean
    Private CurrentPrice As Decimal

    Private Sub AddEditOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnablePrimaryButton(OPrimaryBtn, False)
        EnableSecondaryButton(ClearOrderBtn, False)
        EnableSecondaryButton(RemoveBtn, False)
        EnablePrimaryButton(QtyIncreaseBtn, False)
        EnablePrimaryButton(QtyDecreaseBtn, False)
        UpdateTotalAmount()

        'Add all customers in the combo box 
        myConn.Open()

        Sql = "SELECT
                    * 
                FROM 
                    customers;"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            CustomerCmbBx.Items.Add($"{myRdr("first_name")} {myRdr("last_name")}")
        End While

        myConn.Close()
    End Sub

    Public Sub AddMode()
        'Update form
        AddFlag = True

        OFormTitle.Text = "New Order"
        OPrimaryBtn.Text = "Create"

        'Keeps the data grid view orders items in style
        ODGV.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        ODGV.DefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Regular)

        ChangeMainWindowForm(Me)
    End Sub

    Public Sub EditMode(Info As List(Of String))
        'Update form
        AddFlag = False

        OFormTitle.Text = "Edit Order"
        OPrimaryBtn.Text = "Update"

        'Retrieval of data from ManageOrdersForm

        'Get the name of customer based on the passed ID
        myConn.Open()

        Sql = "SELECT 
                    first_name, 
                    last_name 
                FROM 
                    customers 
                WHERE 
                    cstmr_id=@id"

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", Info(1))
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read() Then
            CustomerCmbBx.Text = $"{myRdr("first_name")} {myRdr("last_name")}"
            CustomerCmbBx.Enabled = False
        End If

        myConn.Close()

        'Get the order items of order based on the passed order ID
        myConn.Open()

        Sql = "SELECT 
                    order_items.item_id, 
                    items.name AS item_name, 
                    items.price AS item_price, 
                    order_items.qty, 
                    order_items.total_amount
                FROM 
                    order_items
                JOIN 
                    items ON order_items.item_id = items.item_id
                WHERE 
                    order_items.order_id=@id;"

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", Info(0))
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read
            ODGV.Rows.Add(myRdr("item_id"), myRdr("item_name"), myRdr("item_price"), myRdr("qty"), myRdr("total_amount"))
        End While

        'Keeps the data grid view orders items in style 
        ODGV.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        ODGV.DefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Regular)

        myConn.Close()

        IDLbl.Visible = True
        IDLbl.Text = Info(0)

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(ManageOrdersForm)
    End Sub

    Private Sub CustomerCmbBx_TextChanged(sender As Object, e As EventArgs) Handles CustomerCmbBx.TextChanged
        'Keeps the Customer ID Label in input stage
        CustomerIDLbl.ForeColor = Color.Red
        CustomerIDLbl.Text = "Not Found"

        'Search the ID of the selected customer in Customer Combo box
        If Not String.IsNullOrWhiteSpace(CustomerCmbBx.Text) Then
            myConn.Close()
            myConn.Open()

            Sql = "SELECT 
                        cstmr_id 
                    FROM 
                        customers 
                    WHERE 
                        CONCAT(first_name, ' ', last_name)=@fullname"

            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.Clear()
            myCmd.Parameters.AddWithValue("@fullname", CustomerCmbBx.Text)
            myRdr = myCmd.ExecuteReader()

            'Display the ID of customer if found else "Not Found"
            If myRdr.Read() Then
                CustomerIDLbl.ForeColor = Color.FromArgb(155, 190, 200)
                CustomerIDLbl.Text = myRdr("cstmr_id").ToString()
            End If

            myConn.Close()
        End If
    End Sub

    Private Sub CategoryCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles CategoryCmbBx.SelectedValueChanged
        'Reset the selection of Item Combo box
        ItemCmbBx.Items.Clear()
        ItemCmbBx.Enabled = True
        ItemCmbBx.Text = ""
        PricePHPLbl.Text = ""

        'Add all Items in Item Combo box based on the selected category
        myConn.Open()
        Sql = $"SELECT  
                    name 
                FROM 
                    items 
                WHERE 
                    category=@cat AND item_id <> 'ITM-DELETED'"

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.Clear()
        myCmd.Parameters.AddWithValue("@cat", CategoryCmbBx.SelectedItem)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            ItemCmbBx.Items.Add(myRdr("name"))
        End While

        myConn.Close()
    End Sub

    Private Sub ItemIDCmbBx_TextChanged(sender As Object, e As EventArgs) Handles ItemCmbBx.TextChanged
        'Keeps the Item ID Label in input stage
        ItemIDLbl.ForeColor = Color.Red
        ItemIDLbl.Text = "Not Found"

        'Search the ID of the selected Item in Item Combo box
        If Not String.IsNullOrWhiteSpace(ItemCmbBx.Text) Then
            QtyTxtBx.Enabled = True
            EnablePrimaryButton(QtyIncreaseBtn, True)
            EnablePrimaryButton(QtyDecreaseBtn, True)

            myConn.Open()

            Sql = "SELECT 
                        * 
                    FROM 
                        items 
                    WHERE 
                        name=@name"

            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.Clear()
            myCmd.Parameters.AddWithValue("@name", ItemCmbBx.Text)
            myRdr = myCmd.ExecuteReader()

            'Display the ID of Item if found
            If myRdr.Read() Then
                ItemIDLbl.ForeColor = Color.FromArgb(155, 190, 200)
                ItemIDLbl.Text = myRdr("item_id").ToString()
                QtyTxtBx.Text = 1
                CurrentPrice = CDec(myRdr("price"))
                PricePHPLbl.Text = $"PHP {CurrentPrice:N2}"
            End If

            myConn.Close()
        End If
    End Sub

    Private Sub QtyTxtBx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QtyTxtBx.KeyPress
        'Don't accept if the input is not a number
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        'Don't accept any further input if the character length reached 3 
        If QtyTxtBx.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub QtyTxtBx_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles QtyTxtBx.Validating
        If String.IsNullOrWhiteSpace(QtyTxtBx.Text) OrElse QtyTxtBx.Text = 0 Then
            QtyTxtBx.Text = 1
        End If

        PricePHPLbl.Text = $"PHP {CurrentPrice * CInt(QtyTxtBx.Text):N2}"
    End Sub

    Private Sub QtyDecreaseBtn_Click(sender As Object, e As EventArgs) Handles QtyDecreaseBtn.Click
        'Decrement the number of quantity While its greater than 1
        If CInt(QtyTxtBx.Text) > 1 Then
            QtyTxtBx.Text = CInt(QtyTxtBx.Text) - 1
            PricePHPLbl.Text = $"PHP {CurrentPrice * CInt(QtyTxtBx.Text):N2}"
        End If
    End Sub

    Private Sub QtyIncreaseBtn_Click(sender As Object, e As EventArgs) Handles QtyIncreaseBtn.Click
        'Increment the number of quantity While its less than 1000
        If CInt(QtyTxtBx.Text) < 1000 Then
            QtyTxtBx.Text = CInt(QtyTxtBx.Text) + 1
            PricePHPLbl.Text = $"PHP {CurrentPrice * CInt(QtyTxtBx.Text):N2}"
        End If
    End Sub

    Private Sub ClearOrderBtn_Click(sender As Object, e As EventArgs) Handles ClearOrderBtn.Click
        'Give warning before removing all order items
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete all order items?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete all order items if confirmed
        If result = DialogResult.Yes Then
            EnableSecondaryButton(RemoveBtn, False)
            ODGV.Rows.Clear()
            UpdateTotalAmount()
            MessageBox.Show("All Order items is Successfully Removed", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        Dim Index = ODGV.CurrentCell.RowIndex

        'Give warning and show a record before deleting an item
        Dim Message As String = $"Are you sure you want to delete this order item? {vbCrLf}{vbCrLf}" &
                        $"Index: {Index} {vbCrLf}" &
                        $"Item ID: {ODGV.Rows(Index).Cells(0).Value} {vbCrLf}" &
                        $"Item name: {ODGV.Rows(Index).Cells(1).Value} {vbCrLf}" &
                        $"Quantity: {ODGV.Rows(Index).Cells(2).Value} {vbCrLf}" &
                        $"Total: {ODGV.Rows(Index).Cells(3).Value}"

        Dim result As DialogResult = MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Delete item if confirmed
        If result = DialogResult.Yes Then
            EnableSecondaryButton(RemoveBtn, False)
            ODGV.Rows.RemoveAt(Index)
            UpdateTotalAmount()
            MessageBox.Show("Order item is Successfully Removed", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If IsValidForm(True) Then
            AddOrderItems()
        End If
    End Sub

    Private Function IsValidForm(AddOrder As Boolean) As Boolean
        Dim Warnings As Integer = 0

        ErrProvider.Clear()
        WarningIndicatorLbl.Visible = False

        If Not AddOrder Then
            'Validate Customer
            If String.IsNullOrWhiteSpace(CustomerCmbBx.Text) Then
                ErrProvider.SetError(CustomerCmbBxPnl, "Customer must not be null")

            ElseIf CustomerIDLbl.Text = "Not Found" Then
                ErrProvider.SetError(CustomerCmbBxPnl, "Customer does not exist")
            End If

            If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(CustomerCmbBxPnl)) Then Warnings += 1
        Else
            'Validate Category
            If CategoryCmbBx.SelectedIndex = -1 Then
                Warnings += 1
                ErrProvider.SetError(CategoryCmbBxPnl, "Category must not be null")
            End If

            'Validate Item
            If String.IsNullOrWhiteSpace(ItemCmbBx.Text) Then
                ErrProvider.SetError(ItemCmbBxPnl, "Item must not be null")

            ElseIf ItemIDLbl.Text = "Not Found" Then
                ErrProvider.SetError(ItemCmbBxPnl, "Item does not exist")
            End If

            If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(ItemCmbBxPnl)) Then Warnings += 1

            'Validate Quantity
            If String.IsNullOrWhiteSpace(QtyTxtBx.Text) Then
                ErrProvider.SetError(QtyIncreaseBtn, "Stock must not be null")

            ElseIf Not Integer.TryParse(QtyTxtBx.Text, Nothing) Then
                ErrProvider.SetError(QtyIncreaseBtn, "Stock must contain numbers only")
            End If

            If Not String.IsNullOrWhiteSpace(ErrProvider.GetError(QtyIncreaseBtn)) Then Warnings += 1
        End If

        'Return False (Invalid form) if it has 1 or more warning
        If Warnings > 0 Then
            WarningIndicatorLbl.Text = $"* You have {Warnings} warning(s) on this form"
            WarningIndicatorLbl.Visible = True
            Return False
        End If

        Return True
    End Function

    Private Sub AddOrderItems()
        'Multiply the price of an item to the quantity
        Dim TotalItemAmount As Decimal = CurrentPrice * CInt(QtyTxtBx.Text)

        Dim Found As Boolean = False

        'Search if the selected item is already in data grid view order items
        For Each row As DataGridViewRow In ODGV.Rows
            'Add the quantity and total price on the existing record if found in data grid view order items
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = ItemIDLbl.Text Then
                row.Cells(3).Value = CInt(row.Cells(3).Value) + CInt(QtyTxtBx.Text)
                row.Cells(4).Value = CDec(row.Cells(4).Value) + TotalItemAmount
                Found = True
                Exit For
            End If
        Next

        'Add a new Item record if the item does not already exist in data grid view order items
        If Not Found Then ODGV.Rows.Add(ItemIDLbl.Text, ItemCmbBx.Text, CurrentPrice, QtyTxtBx.Text, TotalItemAmount)

        UpdateTotalAmount()

        'Keeps the data grid view orders items in style 
        ODGV.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        ODGV.DefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Regular)
    End Sub

    Private Sub UpdateTotalAmount()
        'Keeps the Create/Update button invisible
        EnablePrimaryButton(OPrimaryBtn, False)
        EnableSecondaryButton(ClearOrderBtn, False)

        'Make the Create/Update button visible if the orde has 1 or more items
        If ODGV.RowCount > 1 Then
            EnablePrimaryButton(OPrimaryBtn, True)
            EnableSecondaryButton(ClearOrderBtn, True)
        End If

        Dim TotalAmount As Decimal

        'Sum up all the total 
        For Each row As DataGridViewRow In ODGV.Rows
            If row.Cells(3).Value IsNot Nothing Then
                TotalAmount += CDec(row.Cells(4).Value.ToString())
            End If
        Next

        'Update the Total amount with a format "1,000,000.00"
        TotalAmountPHPLbl.Text = $"PHP {TotalAmount:N2}"
    End Sub

    Private Sub OPrimaryBtn_Click(sender As Object, e As EventArgs) Handles OPrimaryBtn.Click
        If IsValidForm(False) Then
            ProcessRecord()
            ChangeMainWindowForm(ManageOrdersForm)
        End If
    End Sub

    Private Sub ProcessRecord()
        'Generate Order ID if creating a new Order
        If AddFlag Then
            Dim Attempt As Integer = 10

            Dim ID As String = GenerateID("ORD-")

            'Regenerate Order ID if the previous Item ID is already in the database
            While HasDuplicate("orders", "order_id", ID, Nothing) AndAlso Attempt > 0
                ID = GenerateID("ORD-")
                Attempt -= 1
            End While

            'Prompt orders is full If after 10 attemps and the ID is still has duplicate
            If HasDuplicate("orders", "order_id", ID, Nothing) Then
                MessageBox.Show("Orders is already full", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Sql = "INSERT INTO 
                        orders 
                            (order_id, cstmr_id, status, order_date) 
                    VALUES 
                        (@o_id, @c_id, @st, @od)"

            myConn.Open()
            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@o_id", ID)
            myCmd.Parameters.AddWithValue("@c_id", CustomerIDLbl.Text)
            myCmd.Parameters.AddWithValue("@st", "Pending")
            myCmd.Parameters.AddWithValue("@od", Date.Now)

            myCmd.ExecuteNonQuery()
            myConn.Close()

            UpdateOrderItems(ID)

            MessageBox.Show("A New Order is Successfully Added", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Use the given Order ID if in edit mode
            UpdateOrderItems(IDLbl.Text)

            MessageBox.Show("Order's Record is Successfully Updated", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub UpdateOrderItems(ID As String)
        'Delete all order items of the Order ID first
        myConn.Open()

        Sql = "DELETE FROM 
                    order_items 
                WHERE 
                    order_id=@id"

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", ID)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        'Add each order items of the Order ID from the data grid view order items to the database
        For Each row As DataGridViewRow In ODGV.Rows
            If row.Cells(0).Value IsNot Nothing Then
                myConn.Open()

                Sql = "INSERT INTO 
                            order_items 
                                (order_id, item_id, price, qty, total_amount) 
                        VALUES 
                            (@o_id, @i_id, @prc, @qty, @ta)"

                myCmd = New MySqlCommand(Sql, myConn)
                myCmd.Parameters.AddWithValue("@o_id", ID)
                myCmd.Parameters.AddWithValue("@i_id", row.Cells(0).Value.ToString())
                myCmd.Parameters.AddWithValue("@prc", row.Cells(2).Value.ToString())
                myCmd.Parameters.AddWithValue("@qty", row.Cells(3).Value.ToString())
                myCmd.Parameters.AddWithValue("@ta", row.Cells(4).Value.ToString())

                myCmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub ODGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ODGV.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or ODGV.SelectedCells(0).Value Is Nothing Then
            EnableSecondaryButton(RemoveBtn, False)
            Return
        End If

        EnableSecondaryButton(RemoveBtn, True)
    End Sub
End Class