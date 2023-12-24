Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class SuppliersForm
    'Paging Essentials
    Private Count As Integer
    Private TotalPage As Integer
    Private CurrentPage As Integer = 1
    Private First As Integer
    Private Last As Integer

    Private Sub SuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterCmbBx.SelectedIndex = 0
        SortCmbBx.SelectedIndex = 0
        myConn.Open()

        'Check if there are one supplier per category
        Sql = "SELECT 
                    category, 
                    count(*) as total_suppliers
                FROM 
                    suppliers 
                GROUP BY
                    category"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            Select Case myRdr("category")
                Case "Branded"
                    BrandedItemsLbl.Text = $"{myRdr("total_suppliers")} suppliers"
                Case "Galenicals"
                    GalenicalsItemsLbl.Text = $"{myRdr("total_suppliers")} suppliers"
                Case "Generic"
                    GenericItemsLbl.Text = $"{myRdr("total_suppliers")} suppliers"
                Case "Milk Supplements"
                    MSItemsLbl.Text = $"{myRdr("total_suppliers")} suppliers"
            End Select
        End While

        myConn.Close()

        UpdatePage()
        AddHandler SortCmbBx.SelectedValueChanged, AddressOf FilterAndSortEvent
        AddHandler FilterCmbBx.SelectedValueChanged, AddressOf FilterAndSortEvent
    End Sub

    Private Sub UpdatePage()
        Dim sqlBuilder As New StringBuilder()
        'Count the number of itemss
        sqlBuilder.Append("SELECT 
                                COUNT(*) 
                            FROM 
                                suppliers")

        If FilterCmbBx.SelectedIndex <> 0 Then
            sqlBuilder.Append($" WHERE category='{FilterCmbBx.Text}'")
        End If

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)

        myConn.Open()

        'Pagify
        Count = CInt(myCmd.ExecuteScalar)
        TotalPage = Math.Ceiling(Count / 10)
        LastBtn.Text = Count

        myConn.Close()

        'Update the page numbers
        First = CurrentPage * 10 - 10 + 1
        Last = CurrentPage * 10
        CurrentOrdNumLbl.Text = $"{First}-{If(Last >= Count, Count, Last)} of {Count}"

        sqlBuilder = New StringBuilder()

        sqlBuilder.Append(SuppliersQuery())
        sqlBuilder.Append("row_num BETWEEN @f AND @l")

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@f", First)
        myCmd.Parameters.AddWithValue("@l", Last)
        myRdr = myCmd.ExecuteReader()

        'Clear the inventory table layout
        InventoryTblLyt.Controls.Clear()
        InventoryTblLyt.RowStyles.Clear()
        InventoryTblLyt.RowCount = 0

        Dim CurrentRowRecord As List(Of String)
        Dim CurrentColumn As Integer

        'Make row of details on each items
        While myRdr.Read()
            InventoryTblLyt.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
            InventoryTblLyt.RowCount += 1
            Dim AlternateColor As Color = If(InventoryTblLyt.RowCount Mod 2 = 0, Color.White, Color.FromArgb(229, 244, 252))

            'Get all info from the item
            CurrentRowRecord = New List(Of String) From {myRdr("supp_id"), myRdr("supp_name"), myRdr("category"), myRdr("item_count")}
            CurrentColumn = 0

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
                    .ForeColor = Color.FromArgb(22, 72, 99),
                    .Text = CurrentRowRecord(CurrentColumn),
                    .TextAlign = ContentAlignment.MiddleCenter
                }

                'Add the item info row in table layout
                ItemInfoTextWrapper.Controls.Add(ItemInfoLbl)
                InventoryTblLyt.Controls.Add(ItemInfoTextWrapper, CurrentColumn, InventoryTblLyt.RowCount - 1)
                CurrentColumn += 1
            End While

            Dim ViewOrderWrapper As New Panel With {
               .Dock = DockStyle.Top,
               .BackColor = AlternateColor,
               .Margin = New Padding(0)
            }

            Dim ViewOrderButton As New Button With {
                .FlatStyle = FlatStyle.Flat,
                .BackColor = Color.FromArgb(22, 72, 99),
                .ForeColor = Color.White,
                .Font = New Font("Arial", 12, FontStyle.Regular),
                .Cursor = Cursors.Hand,
                .Text = "Order",
                .Tag = myRdr("supp_id"),
                .Size = New Size(140, 40),
                .Location = New Point(38, 30)
            }

            AddHandler ViewOrderButton.Click, AddressOf ViewSupplierButton_Click

            ViewOrderWrapper.Controls.Add(ViewOrderButton)

            InventoryTblLyt.Controls.Add(ViewOrderWrapper, 4, InventoryTblLyt.RowCount - 1)
        End While
        myConn.Close()
    End Sub

    Private Sub ViewSupplierButton_Click(sender As Object, e As EventArgs)
        Dim Btn As Button = DirectCast(sender, Button)

        Dim Supplier As String = CStr(Btn.Tag)

        SupplyItemsForm.ReStock(Supplier)
    End Sub

    Private Function SuppliersQuery() As String
        Dim SortBy As String = ""

        Select Case SortCmbBx.SelectedIndex
            Case 0
                SortBy = "suppliers.supp_name ASC"
            Case 1
                SortBy = "suppliers.supp_name DESC"
            Case 2
                SortBy = "suppliers.category ASC"
            Case 3
                SortBy = "suppliers.category DESC"
            Case 4
                SortBy = "item_count ASC"
            Case 5
                SortBy = "item_count DESC"
        End Select

        Dim sqlBuilder As New StringBuilder()

        'Select the orders from the given page ex:(1-10, 11-20, 21-30, ....)
        sqlBuilder.Append($"SELECT 
                                *
                            FROM 
                                (SELECT
                                        ROW_NUMBER() OVER (ORDER BY {SortBy}) AS row_num,
                                        suppliers.supp_id,
                                        suppliers.supp_name,
                                        suppliers.category,
                                        COUNT(items.item_id) AS item_count
                                    FROM
                                        suppliers
                                    LEFT JOIN
                                        items ON suppliers.supp_id = items.supp_id")

        If FilterCmbBx.SelectedIndex <> 0 Then
            sqlBuilder.Append($" WHERE suppliers.category='{FilterCmbBx.Text}'")
        End If

        sqlBuilder.Append($"  GROUP BY
                                    suppliers.supp_id, suppliers.supp_name, suppliers.category
                                ORDER BY {SortBy} )TABLEROW WHERE ")

        Return sqlBuilder.ToString()
    End Function

    Private Sub FilterAndSortEvent(sender As Object, e As EventArgs)
        CurrentPage = 1
        UpdatePage()
    End Sub
    Private Sub FirstBtn_Click(sender As Object, e As EventArgs) Handles FirstBtn.Click
        'Direct to the first page
        If CurrentPage <> 1 Then
            CurrentPage = 1
            UpdatePage()
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'Increment the page
        If CurrentPage < TotalPage Then
            CurrentPage += 1
            UpdatePage()
        End If
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        'Decrement the page
        If CurrentPage > 1 Then
            CurrentPage -= 1
            UpdatePage()
        End If
    End Sub

    Private Sub LastBtn_Click(sender As Object, e As EventArgs) Handles LastBtn.Click
        'Direct to the last page
        If CurrentPage <> TotalPage Then
            CurrentPage = TotalPage
            UpdatePage()
        End If
    End Sub
    Private Sub SupplierSearchBtn_Click(sender As Object, e As EventArgs) Handles SupplierSearchBtn.Click
        ErrProvider.Clear()

        'Don't proceed if the search box is empty
        If String.IsNullOrWhiteSpace(SupplierSearchTxtBx.Text) Then
            Return
        End If

        'Don't proceed if the search box's text does not match with the order ID format
        If Not Regex.IsMatch(SupplierSearchTxtBx.Text, "^SUP-[A-Z]{3}-[A-Z]{3}-\d{3}$") Then
            ErrProvider.SetError(SupplierSearchBtn, "Invalid Supplier ID")
            Return
        End If

        Dim sqlBuilder As New StringBuilder()

        sqlBuilder.Append(SuppliersQuery())
        sqlBuilder.Append("supp_id=@i_id")

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@i_id", SupplierSearchTxtBx.Text)
        myRdr = myCmd.ExecuteReader()

        Dim RowNum As Integer

        'Show the page of the searched item
        If myRdr.Read() Then
            RowNum = CInt(myRdr("row_num"))
            CurrentPage = Math.Ceiling(RowNum / 10)
            myConn.Close()
            UpdatePage()

            MessageBox.Show($"Supplier Found at Page: {CurrentPage} - Index: {(RowNum Mod 10) - 1}", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            myConn.Close()
            MessageBox.Show($"Supplier does not exist", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class