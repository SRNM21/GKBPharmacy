Imports MySql.Data.MySqlClient

Public Class OrdersCheckOutForm
    Private TotalAmount As Decimal
    Private OutOfStock As Boolean = False

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(OrdersForm)
    End Sub

    Public Sub ShowOrder(OrderID As String)
        OrderIDLbl.Text = OrderID
        SortCmbBx.SelectedIndex = 0

        'Get the customer info
        Sql = $"SELECT 
                    customers.cstmr_id,
                    customers.first_name, 
                    customers.last_name,
                    customers.gender
                FROM 
                    orders
                JOIN 
                    customers ON orders.cstmr_id = customers.cstmr_id
                WHERE 
                    orders.order_id=@id;"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", OrderID)
        myRdr = myCmd.ExecuteReader()

        'Display the customer info
        If myRdr.Read() Then
            CustomerIDLbl.Text = myRdr("cstmr_id")
            NameLbl.Text = $"{myRdr("first_name")} {myRdr("last_name")}"
            CustomerAvatarPctrBx.BackgroundImage = If(myRdr("gender") = "Male",
                                            My.Resources.CUST_M_AVA,
                                            My.Resources.CUST_F_AVA)
        End If

        myConn.Close()

        'Sum up the total number of items and the total amount of the order
        Sql = $"SELECT
                    SUM(qty) AS total_qty,
                    SUM(total_amount) AS total_amount
                FROM 
                    order_items
                WHERE 
                    order_id=@id;"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", OrderID)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read() Then
            TotalItemsLb.Text = $"({myRdr("total_qty")}) items"
            TotalAmount = CDec(myRdr("total_amount"))
            PHPLbl.Text = $"PHP {TotalAmount:N2}"
        End If

        myConn.Close()

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub UpdateOrderItems()
        Dim SortBy As String = ""

        Select Case SortCmbBx.SelectedIndex
            Case 0
                SortBy = "items.name ASC"
            Case 1
                SortBy = "items.name DESC"
            Case 2
                SortBy = "order_items.qty ASC"
            Case 3
                SortBy = "order_items.qty DESC"
            Case 4
                SortBy = "order_items.total_amount ASC"
            Case 5
                SortBy = "order_items.total_amount DESC"
        End Select

        'Get all the order items of the passed order ID
        Sql = $"SELECT 
                    items.name,
                    items.item_id,
                    items.stock, 
                    order_items.qty, 
                    order_items.total_amount
                FROM 
                    order_items
                JOIN 
                    items ON order_items.item_id = items.item_id
                WHERE 
                    order_items.order_id=@id
                ORDER BY {SortBy}"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", OrderIDLbl.Text)
        myRdr = myCmd.ExecuteReader()

        OrderItemsTblLyt.Controls.Clear()
        OrderItemsTblLyt.RowStyles.Clear()
        OrderItemsTblLyt.RowCount = 0

        Dim CurrentRowRecord As List(Of String)
        Dim CurrentColumn As Integer

        'Programmatically create each row of order items
        While myRdr.Read()
            OrderItemsTblLyt.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            OrderItemsTblLyt.RowCount += 1
            Dim AlternateColor As Color = If(OrderItemsTblLyt.RowCount Mod 2 = 0, Color.White, Color.FromArgb(229, 244, 252))

            'Get all info from the item
            CurrentRowRecord = New List(Of String) From {myRdr("item_id"), myRdr("name"), myRdr("qty"), myRdr("stock"), myRdr("total_amount")}
            CurrentColumn = 0

            Dim TextColor As Color = Color.FromArgb(22, 72, 99)

            'Put each item info in specified column
            While CurrentColumn < 5

                'Make OutOfStock to true if the item qty is greater than the stock
                If CInt(CurrentRowRecord(2)) > CInt(CurrentRowRecord(3)) Then
                    TextColor = Color.Red
                    OutOfStock = True
                End If

                Dim ItemInfoTextWrapper As New Panel With {
                    .Height = 100,
                    .Margin = New Padding(0),
                    .Dock = DockStyle.Top,
                    .BackColor = AlternateColor
                }

                Dim ItemInfoLbl As New Label With {
                    .Dock = DockStyle.Fill,
                    .Font = New Font("Arial", 14, FontStyle.Regular),
                    .ForeColor = TextColor,
                    .Text = CurrentRowRecord(CurrentColumn),
                    .TextAlign = ContentAlignment.MiddleCenter
                }

                'Add the item info row in table layout
                ItemInfoTextWrapper.Controls.Add(ItemInfoLbl)
                OrderItemsTblLyt.Controls.Add(ItemInfoTextWrapper, CurrentColumn, OrderItemsTblLyt.RowCount - 1)
                CurrentColumn += 1
            End While
        End While

        myConn.Close()
    End Sub

    Private Sub CheckOutBtn_Click(sender As Object, e As EventArgs) Handles CheckOutBtn.Click
        'Don't proceed if one of the items does not have any stock
        If OutOfStock Then
            Dim result As DialogResult = MessageBox.Show("insufficient stock. Do you want to restock first?", "GKB Pharmacy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            'Procced to supplier if Yes
            If result = DialogResult.Yes Then
                ChangeMainWindowForm(SuppliersForm)
                Return
            End If

            Return
        End If

        Dim Attempt As Integer = 10
        Dim ID As String = GenerateID("REF-")

        'Regenerate Reference No. if the previous Item ID is already in the database
        While HasDuplicate("reference", "rfrnce_no", ID, Nothing) AndAlso Attempt > 0
            ID = GenerateID("REF-")
            Attempt -= 1
        End While

        'Prompt orders is full If after 10 attemps and the ID is still has duplicate
        If HasDuplicate("reference", "rfrnce_no", ID, Nothing) Then
            MessageBox.Show("Order History is already full", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If


        'Update the status of the order
        Sql = "UPDATE 
                    orders 
                SET 
                    status='Done' 
                WHERE 
                    order_id=@o_id"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@o_id", OrderIDLbl.Text)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        'Put the order in the reference
        Sql = "INSERT INTO 
                    reference 
                        (rfrnce_no, order_id, phrmcst_id, date_ord_cmplt, total_amount) 
                VALUES 
                    (@r_no, @o_id, @p_id, @dc, @ta)"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@r_no", ID)
        myCmd.Parameters.AddWithValue("@o_id", OrderIDLbl.Text)
        myCmd.Parameters.AddWithValue("@p_id", UserID)
        myCmd.Parameters.AddWithValue("@dc", Date.Now)
        myCmd.Parameters.AddWithValue("@ta", TotalAmount)

        myCmd.ExecuteNonQuery()
        myConn.Close()

        ProcessStock()

        MessageBox.Show("Order's Record is Successfully processed", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ChangeMainWindowForm(OrdersForm)
    End Sub

    Private Sub ProcessStock()
        Dim BoughtItems As New List(Of List(Of String))()

        Sql = "SELECT 
                    item_id, 
                    qty 
                FROM 
                    order_items 
                WHERE 
                    order_id=@id"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", OrderIDLbl.Text)
        myRdr = myCmd.ExecuteReader()


        While myRdr.Read()
            Dim itemID As String = myRdr("item_id").ToString()
            Dim qty As Integer = myRdr("qty")

            BoughtItems.Add(New List(Of String) From {itemID, qty})
        End While

        myConn.Close()

        DeductStockForItem(BoughtItems)
    End Sub

    Private Sub DeductStockForItem(BoughtItems As List(Of List(Of String)))
        'Deduct each item according to the qty of items in order
        For Each Item As List(Of String) In BoughtItems
            Sql = "UPDATE 
                        items 
                    SET 
                        stock=stock-@qty 
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

    Private Sub SortCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles SortCmbBx.SelectedValueChanged
        UpdateOrderItems()
    End Sub
End Class