Imports MySql.Data.MySqlClient

Public Class SupplyItemsForm
    Private CurrentPrice As Decimal
    Private Orders As New List(Of List(Of String))()

    Private Sub SupplyItemsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnablePrimaryButton(OrderBtn, False)
        EnableSecondaryButton(ClearOrderBtn, False)
        EnableSecondaryButton(RemoveBtn, False)
        EnablePrimaryButton(QtyIncreaseBtn, False)
        EnablePrimaryButton(QtyDecreaseBtn, False)
        UpdateTotalAmount()

        'Keeps the data grid view orders items in style 
        ODGV.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        ODGV.DefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Regular)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(SuppliersForm)
    End Sub

    Public Sub ReStock(Supplier As String)
        SuppIDLbl.Text = Supplier

        'Get the supplier info
        Sql = $"SELECT 
                    supp_name,
                    category
                FROM 
                    suppliers
                WHERE 
                    supp_id=@id"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", Supplier)
        myRdr = myCmd.ExecuteReader()

        'Display the supplier info
        If myRdr.Read() Then
            NameLbl.Text = myRdr("supp_name")
            CategoryLbl.Text = myRdr("category")
        End If

        myConn.Close()

        'Get the supplier info
        Sql = $"SELECT 
                    name
                FROM 
                    items
                WHERE 
                    supp_id=@id"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", Supplier)
        myRdr = myCmd.ExecuteReader()

        'Display the supplier info
        While myRdr.Read()
            ItemCmbBx.Items.Add(myRdr("name"))
        End While

        myConn.Close()

        ChangeMainWindowForm(Me)
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

        PricePHPLbl.Text = $"{CurrentPrice * CInt(QtyTxtBx.Text):N2}"
    End Sub

    Private Sub QtyDecreaseBtn_Click(sender As Object, e As EventArgs) Handles QtyDecreaseBtn.Click
        'Decrement the number of quantity While its greater than 1
        If CInt(QtyTxtBx.Text) > 1 Then
            QtyTxtBx.Text = CInt(QtyTxtBx.Text) - 1
            PricePHPLbl.Text = $"{CurrentPrice * CInt(QtyTxtBx.Text):N2}"
        End If
    End Sub

    Private Sub QtyIncreaseBtn_Click(sender As Object, e As EventArgs) Handles QtyIncreaseBtn.Click
        'Increment the number of quantity While its less than 1000
        If CInt(QtyTxtBx.Text) < 1000 Then
            QtyTxtBx.Text = CInt(QtyTxtBx.Text) + 1
            PricePHPLbl.Text = $"{CurrentPrice * CInt(QtyTxtBx.Text):N2}"
        End If
    End Sub

    Private Sub ItemCmbBx_TextChanged(sender As Object, e As EventArgs) Handles ItemCmbBx.TextChanged
        'Keeps the Item ID Label in input stage
        SupplyItemIDLbl.ForeColor = Color.Red
        SupplyItemIDLbl.Text = "Not Found"

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
                SupplyItemIDLbl.ForeColor = Color.FromArgb(155, 190, 200)
                SupplyItemIDLbl.Text = myRdr("item_id").ToString()
                QtyTxtBx.Text = 1
                CurrentPrice = CDec(myRdr("cost"))
                PricePHPLbl.Text = $"{CurrentPrice:N2}"
            End If

            myConn.Close()
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If IsValidForm() Then
            AddOrderItems()
        End If
    End Sub

    Private Function IsValidForm() As Boolean
        Dim Warnings As Integer = 0

        ErrProvider.Clear()
        WarningIndicatorLbl.Visible = False

        'Validate Item
        If String.IsNullOrWhiteSpace(ItemCmbBx.Text) Then
            ErrProvider.SetError(ItemCmbBxPnl, "Item must not be null")

        ElseIf SupplyItemIDLbl.Text = "Not Found" Then
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
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = SupplyItemIDLbl.Text Then
                row.Cells(2).Value = CInt(row.Cells(2).Value) + CInt(QtyTxtBx.Text)
                row.Cells(3).Value = CDec(row.Cells(3).Value) + TotalItemAmount
                Found = True
                Exit For
            End If
        Next

        'Add a new Item record if the item does not already exist in data grid view order items
        If Not Found Then ODGV.Rows.Add(SupplyItemIDLbl.Text, ItemCmbBx.Text, QtyTxtBx.Text, TotalItemAmount)

        UpdateTotalAmount()

        'Keeps the data grid view orders items in style 
        ODGV.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        ODGV.DefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Regular)
    End Sub

    Private Sub UpdateTotalAmount()
        'Keeps the Create/Update button invisible
        EnablePrimaryButton(OrderBtn, False)
        EnableSecondaryButton(ClearOrderBtn, False)

        'Make the Create/Update button visible if the orde has 1 or more items
        If ODGV.RowCount > 1 Then
            EnablePrimaryButton(OrderBtn, True)
            EnableSecondaryButton(ClearOrderBtn, True)
        End If

        Dim TotalAmount As Decimal
        Dim TotalItems As Integer

        'Sum up all the total 
        For Each row As DataGridViewRow In ODGV.Rows
            If row.Cells(0).Value IsNot Nothing Then
                TotalAmount += CDec(row.Cells(3).Value.ToString())
                TotalItems += CInt(row.Cells(2).Value)
            End If
        Next

        'Update the Total amount with a format "1,000,000.00"
        PHPLbl.Text = $"PHP {TotalAmount:N2}"
        TotalItemsLb.Text = $"({TotalItems} items)"
    End Sub

    Private Sub ODGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ODGV.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or ODGV.SelectedCells(0).Value Is Nothing Then
            EnableSecondaryButton(RemoveBtn, False)
            Return
        End If

        EnableSecondaryButton(RemoveBtn, True)
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

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Dim OrderedItems As New List(Of List(Of String))()

        For Each row As DataGridViewRow In ODGV.Rows
            If row.Cells(0).Value IsNot Nothing Then
                Dim itemID As String = row.Cells(0).Value
                Dim qty As Integer = row.Cells(2).Value

                OrderedItems.Add(New List(Of String) From {itemID, qty})
            End If
        Next

        myConn.Close()

        AddStockForItem(OrderedItems)

        MessageBox.Show("Supply Record is Successfully processed", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ChangeMainWindowForm(SuppliersForm)
    End Sub

    Private Sub AddStockForItem(OrderedItems As List(Of List(Of String)))
        'Deduct each item according to the qty of items in order
        For Each Item As List(Of String) In OrderedItems
            Sql = "UPDATE 
                        items 
                    SET 
                        stock=stock+@qty 
                    WHERE 
                        item_id=@item_id"

            myConn.Open()

            myCmd = New MySqlCommand(Sql, myConn)
            myCmd.Parameters.AddWithValue("@item_id", Item(0))
            myCmd.Parameters.AddWithValue("@qty", Item(1))
            myRdr = myCmd.ExecuteReader()

            myConn.Close()
        Next
    End Sub

End Class