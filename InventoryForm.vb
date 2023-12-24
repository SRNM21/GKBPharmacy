Imports System.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class InventoryForm
    'Paging Essentials
    Private Count As Integer
    Private TotalPage As Integer
    Private CurrentPage As Integer = 1
    Private First As Integer
    Private Last As Integer

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterCmbBx.SelectedIndex = 0
        SortCmbBx.SelectedIndex = 0

        myConn.Open()

        'Check if there are one supplier per category
        Sql = "SELECT 
                    category, 
                    count(*) as total_items 
                FROM 
                    items 
                GROUP BY
                    category"

        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            Select Case myRdr("category")
                Case "Branded"
                    BrandedItemsLbl.Text = $"{myRdr("total_items")} items"
                Case "Galenicals"
                    GalenicalsItemsLbl.Text = $"{myRdr("total_items")} items"
                Case "Generic"
                    GenericItemsLbl.Text = $"{myRdr("total_items")} items"
                Case "Milk Supplements"
                    MSItemsLbl.Text = $"{myRdr("total_items")} items"
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
                                items")

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

        sqlBuilder.Append(InventoryQuery())
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
            CurrentRowRecord = New List(Of String) From {myRdr("item_id"), myRdr("name"), myRdr("category"), myRdr("stock"), myRdr("supp_name")}
            CurrentColumn = 0

            'Put each item info in specified column
            While CurrentColumn < 5
                Dim ItemInfoTextWrapper As New Panel With {
                    .Height = 100,
                    .Margin = New Padding(0),
                    .Dock = DockStyle.Top,
                    .BackColor = AlternateColor
                }

                Dim StockColor = If(CurrentColumn = 3 AndAlso CInt(CurrentRowRecord(CurrentColumn)) < 20, Color.Red, Color.FromArgb(22, 72, 99))

                Dim ItemInfoLbl As New Label With {
                    .Dock = DockStyle.Fill,
                    .Font = New Font("Arial", 14, FontStyle.Regular),
                    .ForeColor = StockColor,
                    .Text = CurrentRowRecord(CurrentColumn),
                    .TextAlign = ContentAlignment.MiddleCenter
                }

                'Add the item info row in table layout
                ItemInfoTextWrapper.Controls.Add(ItemInfoLbl)
                InventoryTblLyt.Controls.Add(ItemInfoTextWrapper, CurrentColumn, InventoryTblLyt.RowCount - 1)
                CurrentColumn += 1
            End While
        End While
        myConn.Close()
    End Sub

    Private Function InventoryQuery() As String
        Dim SortBy As String = ""

        Select Case SortCmbBx.SelectedIndex
            Case 0
                SortBy = "items.name ASC"
            Case 1
                SortBy = "items.name DESC"
            Case 2
                SortBy = "items.category ASC"
            Case 3
                SortBy = "items.category DESC"
            Case 4
                SortBy = "items.stock ASC"
            Case 5
                SortBy = "items.stock DESC"
        End Select

        Dim sqlBuilder As New StringBuilder()

        'Select the orders from the given page ex:(1-10, 11-20, 21-30, ....)
        sqlBuilder.Append($"SELECT 
                                *
                            FROM 
                                (SELECT 
                                        row_number() OVER (ORDER BY {SortBy}) AS row_num,
                                        items.item_id, 
                                        items.name, 
                                        items.category, 
                                        items.stock, 
                                        suppliers.supp_name
                                    FROM 
                                        items
                                    JOIN 
                                        suppliers ON items.supp_id = suppliers.supp_id")

        If FilterCmbBx.SelectedIndex <> 0 Then
            sqlBuilder.Append($" WHERE items.category='{FilterCmbBx.Text}'")
        End If

        sqlBuilder.Append(")TABLEROW WHERE ")

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

    Private Sub InventorySearchBtn_Click(sender As Object, e As EventArgs) Handles InventorySearchBtn.Click
        ErrProvider.Clear()

        'Don't proceed if the search box is empty
        If String.IsNullOrWhiteSpace(InventorySearchTxtBx.Text) Then
            Return
        End If

        'Don't proceed if the search box's text does not match with the order ID format
        If Not Regex.IsMatch(InventorySearchTxtBx.Text, "^ITM-[A-Z]{3}-[A-Z]{3}-\d{3}$") Then
            ErrProvider.SetError(InventorySearchBtn, "Invalid Item ID")
            Return
        End If

        Dim sqlBuilder As New StringBuilder()

        sqlBuilder.Append(InventoryQuery)
        sqlBuilder.Append("item_id=@i_id")

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@i_id", InventorySearchTxtBx.Text)
        myRdr = myCmd.ExecuteReader()

        Dim RowNum As Integer

        'Show the page of the searched item
        If myRdr.Read() Then
            RowNum = CInt(myRdr("row_num"))
            CurrentPage = Math.Ceiling(RowNum / 10)
            myConn.Close()
            UpdatePage()

            MessageBox.Show($"Item Found at Page: {CurrentPage} - Index: {(RowNum Mod 10) - 1}", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            myConn.Close()
            MessageBox.Show($"Item does not exist", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class