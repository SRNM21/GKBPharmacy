Imports MySql.Data.MySqlClient

Public Class ReferenceInfoForm

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(HistoryForm)
    End Sub

    Private Sub ShowCustomerInfo()
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
                    orders.order_id=(SELECT 
                                            order_id 
                                        FROM 
                                            reference 
                                        WHERE 
                                            rfrnce_no=@ref)"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@ref", RefNoLbl.Text)
        myRdr = myCmd.ExecuteReader()

        'Display the customer info
        If myRdr.Read() Then
            CustomerIDLbl.Text = myRdr("cstmr_id")
            NameLbl.Text = $"{myRdr("first_name")} {myRdr("last_name")}"
            CustomerAvatarPctrBx.BackgroundImage = If(myRdr("gender") = "Male",
                                        My.Resources.CUST_M_AVA,
                                        My.Resources.CUST_F_AVA)
        Else
            CustomerIDLbl.Text = "CST-404-NOT-FOUND"
            NameLbl.ForeColor = Color.Red
            NameLbl.Text = "Customer Does Not Exist"
            CustomerAvatarPctrBx.BackgroundImage = My.Resources.CUST_404_AVA
        End If

        myConn.Close()
    End Sub

    Private Sub ShowPharmacistInfo()
        Sql = $"SELECT 
                    reference.phrmcst_id,
                    CONCAT(pharmacists.first_name, ' ',pharmacists.last_name) AS full_name
                FROM 
                    reference
                 JOIN 
                    pharmacists ON reference.phrmcst_id=pharmacists.phrmcst_id
                 WHERE 
                    rfrnce_no=@ref"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@ref", RefNoLbl.Text)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read() Then
            PharmacistIDLbl.Text = myRdr("phrmcst_id")
            PharmacistNameLbl.Text = myRdr("full_name")
        Else
            PharmacistIDLbl.Text = "PHA-404-NOT-FOUND"
            PharmacistNameLbl.ForeColor = Color.Red
            PharmacistNameLbl.Text = "Pharmacist Does Not Exist"
        End If

        myConn.Close()
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
                    order_items.order_id,
                    COALESCE(order_items.item_id, 'ITM-404-NOTFOUND') AS item_id,
                    COALESCE(items.name, 'Not Available') AS item_name,
                    order_items.qty,
                    order_items.total_amount
                FROM
                    order_items
                JOIN
                    reference ON order_items.order_id = reference.order_id
                LEFT JOIN
                    items ON order_items.item_id = items.item_id
                WHERE
                    reference.rfrnce_no = @id
                ORDER BY {SortBy}"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@id", RefNoLbl.Text)
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
            CurrentRowRecord = New List(Of String) From {myRdr("item_id"), myRdr("item_name"), myRdr("qty"), myRdr("total_amount")}
            CurrentColumn = 0

            Dim TextColor As Color = If(myRdr("item_id").ToString() = "ITM-404-NOTFOUND", Color.Red, Color.FromArgb(22, 72, 99))

            'Put each item info in specified column
            While CurrentColumn < 4

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

    Public Sub ShowDetails(Ref As String)
        RefNoLbl.Text = Ref
        SortCmbBx.SelectedIndex = 0

        ShowCustomerInfo()

        'Sum up the total number of items and the total amount of the order
        Sql = $"SELECT 
                    reference.order_id,
                    orders.order_date, 
                    reference.date_ord_cmplt, 
                    SUM(order_items.qty) AS total_items, 
                    reference.total_amount
                FROM 
                    reference
                 JOIN 
                    orders ON reference.order_id=orders.order_id
                 JOIN 
                    order_items ON reference.order_id=order_items.order_id
                 WHERE 
                    rfrnce_no=@ref"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@ref", Ref)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read() Then
            DOLbl.Text = myRdr("order_date")
            DCLbl.Text = myRdr("date_ord_cmplt")
            OrderIDLbl.Text = myRdr("order_id")

            TotalItemsLb.Text = $"({myRdr("total_items")}) items"

            Dim TotalAmount As Decimal = myRdr("total_amount")
            PHPLbl.Text = $"PHP {TotalAmount:N2}"
        End If

        myConn.Close()

        ShowPharmacistInfo()

        ChangeMainWindowForm(Me)
    End Sub

    Private Sub SortCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles SortCmbBx.SelectedValueChanged
        UpdateOrderItems()
    End Sub
End Class