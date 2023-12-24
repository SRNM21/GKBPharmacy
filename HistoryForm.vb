Imports System.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class HistoryForm
    'Paging Essentials
    Private Count As Integer
    Private TotalPage As Integer
    Private CurrentPage As Integer = 1
    Private First As Integer
    Private Last As Integer

    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Count the number of pending orders
        Sql = "SELECT 
                    COUNT(*) 
                FROM 
                    orders 
                WHERE 
                    status='Done'"

        myCmd = New MySqlCommand(Sql, myConn)

        myConn.Open()

        'Pagify
        Count = Convert.ToString(myCmd.ExecuteScalar)
        TotalPage = Math.Ceiling(Count / 10)
        LastBtn.Text = Count

        myConn.Close()

        FilterCmbBx.SelectedIndex = 1
    End Sub

    Private Sub UpdatePage()
        Dim sqlBuilder As New StringBuilder()

        'Update the page numbers
        First = CurrentPage * 10 - 10 + 1
        Last = CurrentPage * 10
        CurrentOrdNumLbl.Text = $"{First}-{If(Last >= Count, Count, Last)} of {Count}"

        sqlBuilder.Append(HistoryQuery())
        sqlBuilder.Append("row_num BETWEEN @f AND @l")

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@f", First)
        myCmd.Parameters.AddWithValue("@l", Last)
        myRdr = myCmd.ExecuteReader()

        'Clear the inventory table layout
        HistoryTblLyt.Controls.Clear()
        HistoryTblLyt.RowStyles.Clear()
        HistoryTblLyt.RowCount = 0

        Dim CurrentRowRecord As List(Of String)
        Dim CurrentColumn As Integer

        'Make row of details on each items
        While myRdr.Read()
            If myRdr("rfrnce_no") Is DBNull.Value Then Exit While

            HistoryTblLyt.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
            HistoryTblLyt.RowCount += 1
            Dim AlternateColor As Color = If(HistoryTblLyt.RowCount Mod 2 = 0, Color.White, Color.FromArgb(229, 244, 252))

            'Get all info from the item
            CurrentRowRecord = New List(Of String) From {myRdr("rfrnce_no"), myRdr("order_id"), myRdr("total_items"), myRdr("total_amount"), myRdr("order_date"), myRdr("date_ord_cmplt")}
            CurrentColumn = 0

            'Put each item info in specified column
            While CurrentColumn < 6
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
                HistoryTblLyt.Controls.Add(ItemInfoTextWrapper, CurrentColumn, HistoryTblLyt.RowCount - 1)
                CurrentColumn += 1
            End While

            Dim ViewDetailsWrapper As New Panel With {
               .Dock = DockStyle.Top,
               .BackColor = AlternateColor,
               .Margin = New Padding(0)
           }

            Dim ViewDetailsButton As New Button With {
                .FlatStyle = FlatStyle.Flat,
                .BackColor = Color.FromArgb(22, 72, 99),
                .ForeColor = Color.White,
                .Font = New Font("Arial", 12, FontStyle.Regular),
                .Cursor = Cursors.Hand,
                .Text = "View Details",
                .Tag = myRdr("rfrnce_no"),
                .Size = New Size(140, 40),
                .Location = New Point(25, 30)
            }

            AddHandler ViewDetailsButton.Click, AddressOf ViewDetailsButton_Click

            ViewDetailsWrapper.Controls.Add(ViewDetailsButton)

            HistoryTblLyt.Controls.Add(ViewDetailsWrapper, 6, HistoryTblLyt.RowCount - 1)
        End While
        myConn.Close()
    End Sub

    Private Sub ViewDetailsButton_Click(sender As Object, e As EventArgs)
        'Direct to the OrdersCheckOutForm after clicking 'View order'
        Dim Btn As Button = DirectCast(sender, Button)

        Dim Reference As String = CStr(Btn.Tag)

        ReferenceInfoForm.ShowDetails(Reference)
    End Sub

    Private Function HistoryQuery() As String
        Dim SortBy As String = ""

        Select Case FilterCmbBx.SelectedIndex
            Case 0
                SortBy = "o.order_date DESC"
            Case 1
                SortBy = "o.order_date ASC"
            Case 2
                SortBy = "r.date_ord_cmplt DESC"
            Case 3
                SortBy = "r.date_ord_cmplt ASC"
            Case 4
                SortBy = "total_items ASC"
            Case 5
                SortBy = "total_items DESC"
            Case 6
                SortBy = "total_amount ASC"
            Case 7
                SortBy = "total_amount DESC"
        End Select

        Dim sqlBuilder As New StringBuilder()

        'Select the orders from the given page ex:(1-10, 11-20, 21-30, ....)
        sqlBuilder.Append($"SELECT 
                                *
                            FROM 
                                (SELECT
                                    ROW_NUMBER() OVER (ORDER BY {SortBy}) AS row_num,
                                    r.rfrnce_no,
                                    r.order_id,
                                    r.phrmcst_id,
                                    r.date_ord_cmplt,
                                    r.total_amount,
                                    o.order_date,
                                    COALESCE(SUM(oi.qty), 0) AS total_items
                                FROM
                                    reference r
                                JOIN
                                    orders o ON r.order_id = o.order_id
                                LEFT JOIN
                                    order_items oi ON r.order_id = oi.order_id
                                GROUP BY
                                    r.rfrnce_no, r.order_id, r.phrmcst_id, r.date_ord_cmplt, r.total_amount, o.order_date
                                ORDER BY
                                    row_num
                            )TABLEROW WHERE ")

        Return sqlBuilder.ToString()
    End Function

    Private Sub FilterCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles FilterCmbBx.SelectedValueChanged
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

    Private Sub HistorySearchBtn_Click(sender As Object, e As EventArgs) Handles HistorySearchBtn.Click
        ErrProvider.Clear()

        'Don't proceed if the search box is empty
        If String.IsNullOrWhiteSpace(HistorySearchTxtBx.Text) Then
            Return
        End If

        'Don't proceed if the search box's text does not match with the order ID format
        If Not Regex.IsMatch(HistorySearchTxtBx.Text, "^REF-[A-Z]{3}-[A-Z]{3}-\d{3}$") Then
            ErrProvider.SetError(HistorySearchBtn, "Invalid Reference Number")
            Return
        End If

        Dim sqlBuilder As New StringBuilder()

        sqlBuilder.Append(HistoryQuery())
        sqlBuilder.Append("rfrnce_no=@r_no")

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@r_no", HistorySearchTxtBx.Text)
        myRdr = myCmd.ExecuteReader()

        Dim RowNum As Integer

        'Show the page of the searched item
        If myRdr.Read() Then
            RowNum = CInt(myRdr("row_num"))
            CurrentPage = Math.Ceiling(RowNum / 10)
            myConn.Close()
            UpdatePage()

            MessageBox.Show($"Reference Number Found at Page: {CurrentPage} - Index: {(RowNum Mod 10) - 1}", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            myConn.Close()
            MessageBox.Show($"Reference Number does not exist", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class