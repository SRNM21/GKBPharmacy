Imports MySql.Data.MySqlClient
Imports System.Text

Imports System.Text.RegularExpressions

Public Class OrdersForm
    'Paging Essentials
    Private Count As Integer
    Private TotalPage As Integer
    Private CurrentPage As Integer = 1
    Private First As Integer
    Private Last As Integer

    Private Sub OrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Count the number of pending orders
        Sql = "SELECT 
                    COUNT(*) 
                FROM 
                    orders 
                WHERE 
                    status='Pending'"

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

        sqlBuilder.Append(OrderQuery())
        sqlBuilder.Append("row_num BETWEEN @f AND @l")

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@f", First)
        myCmd.Parameters.AddWithValue("@l", Last)
        myRdr = myCmd.ExecuteReader()

        OrderTblLyt.Controls.Clear()
        OrderTblLyt.RowStyles.Clear()
        OrderTblLyt.RowCount = 0

        'Create the order row programmatically
        While myRdr.Read()
            OrderTblLyt.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            OrderTblLyt.RowCount += 1
            Dim AlternateColor As Color = If(OrderTblLyt.RowCount Mod 2 = 0, Color.White, Color.FromArgb(229, 244, 252))

            Dim CustomerPnl As New Panel With {
                .Dock = DockStyle.Top,
                .BackColor = AlternateColor,
                .Height = 100,
                .Margin = New Padding(0),
                .Padding = New Padding(10)
            }

            Dim CustomerPicBox As New PictureBox With {
                .Dock = DockStyle.Left,
                .Size = New Size(80, 80),
                .BackgroundImage = If(myRdr("gender") = "Male",
                                            My.Resources.CUST_M_AVA,
                                            My.Resources.CUST_F_AVA),
                .BackgroundImageLayout = ImageLayout.Stretch
            }

            Dim CustomerTextWrapper As New Panel With {
                .Dock = DockStyle.Fill,
                .BackColor = AlternateColor
            }

            Dim CustomerIDLbl As New Label With {
                .Dock = DockStyle.Top,
                .Height = 37,
                .Font = New Font("Arial", 14, FontStyle.Bold),
                .ForeColor = Color.FromArgb(22, 72, 99),
                .Text = myRdr("cstmr_id"),
                .TextAlign = ContentAlignment.BottomCenter
            }

            Dim CustomerName As New Label With {
                .Dock = DockStyle.Bottom,
                .Height = 43,
                .Font = New Font("Arial", 14, FontStyle.Regular),
                .ForeColor = Color.FromArgb(22, 72, 99),
                .Text = $"{myRdr("first_name")} {myRdr("last_name")}",
                .TextAlign = ContentAlignment.TopCenter
            }

            CustomerPnl.Controls.Add(CustomerTextWrapper)
            CustomerPnl.Controls.Add(CustomerPicBox)

            CustomerTextWrapper.Controls.Add(CustomerIDLbl)
            CustomerTextWrapper.Controls.Add(CustomerName)

            OrderTblLyt.Controls.Add(CustomerPnl, 0, OrderTblLyt.RowCount - 1)

            Dim DateTextWrapper As New Panel With {
                .Dock = DockStyle.Top,
                .BackColor = AlternateColor,
                .Margin = New Padding(0)
            }

            Dim DateLbl As New Label With {
                .Dock = DockStyle.Fill,
                .Font = New Font("Arial", 14, FontStyle.Regular),
                .ForeColor = Color.FromArgb(22, 72, 99),
                .Text = myRdr("order_date"),
                .TextAlign = ContentAlignment.MiddleCenter
            }

            DateTextWrapper.Controls.Add(DateLbl)

            OrderTblLyt.Controls.Add(DateTextWrapper, 1, OrderTblLyt.RowCount - 1)

            Dim OrderIDTextWrapper As New Panel With {
                .Dock = DockStyle.Top,
                .BackColor = AlternateColor,
                .Margin = New Padding(0)
            }

            Dim OrderIDLbl As New Label With {
                .Dock = DockStyle.Fill,
                .Font = New Font("Arial", 14, FontStyle.Regular),
                .ForeColor = Color.FromArgb(22, 72, 99),
                .Text = myRdr("order_id"),
                .TextAlign = ContentAlignment.MiddleCenter
            }

            OrderIDTextWrapper.Controls.Add(OrderIDLbl)

            OrderTblLyt.Controls.Add(OrderIDTextWrapper, 2, OrderTblLyt.RowCount - 1)

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
                .Text = "View Order",
                .Tag = myRdr("order_id"),
                .Size = New Size(140, 40),
                .Location = New Point(38, 30)
            }

            AddHandler ViewOrderButton.Click, AddressOf ViewOrderButton_Click

            ViewOrderWrapper.Controls.Add(ViewOrderButton)

            OrderTblLyt.Controls.Add(ViewOrderWrapper, 3, OrderTblLyt.RowCount - 1)

        End While

        myConn.Close()
    End Sub

    Private Sub ViewOrderButton_Click(sender As Object, e As EventArgs)
        'Direct to the OrdersCheckOutForm after clicking 'View order'
        Dim Btn As Button = DirectCast(sender, Button)

        Dim Order As String = CStr(Btn.Tag)

        OrdersCheckOutForm.ShowOrder(Order)
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

    Private Sub FilterCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles FilterCmbBx.SelectedValueChanged
        CurrentPage = 1
        UpdatePage()
    End Sub

    Private Function OrderQuery() As String
        Dim SortBy As String = ""

        Select Case FilterCmbBx.SelectedIndex
            Case 0
                SortBy = "DESC"
            Case 1
                SortBy = "ASC"
        End Select

        Dim sqlBuilder As New StringBuilder()

        'Select the orders from the given page ex:(1-10, 11-20, 21-30, ....)
        sqlBuilder.Append($"SELECT 
                                *
                            FROM 
                                (SELECT row_number() OVER (ORDER BY order_date {SortBy}) AS row_num, 
                                    orders.order_id, 
                                    orders.cstmr_id, 
                                    orders.order_date,
                                    customers.gender,
                                    customers.first_name,
                                    customers.last_name
                                FROM 
                                    orders 
                                JOIN
                                    customers ON orders.cstmr_id=customers.cstmr_id
                                WHERE 
                                    status='Pending'
                            )TABLEROW 
                            WHERE ")

        Return sqlBuilder.ToString()
    End Function

    Private Sub OrderSearchBtn_Click(sender As Object, e As EventArgs) Handles OrderSearchBtn.Click
        ErrProvider.Clear()

        'Don't proceed if the search box is empty
        If String.IsNullOrWhiteSpace(OrderSearchTxtBx.Text) Then
            Return
        End If

        'Don't proceed if the search box's text does not match with the order ID format
        If Not Regex.IsMatch(OrderSearchTxtBx.Text, "^ORD-[A-Z]{3}-[A-Z]{3}-\d{3}$") Then
            ErrProvider.SetError(OrderSearchBtn, "Invalid Order ID")
            Return
        End If

        Dim sqlBuilder As New StringBuilder()

        sqlBuilder.Append(OrderQuery())
        sqlBuilder.Append("tablerow.order_id=@o_id")

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@o_id", OrderSearchTxtBx.Text)
        myRdr = myCmd.ExecuteReader()

        Dim RowNum As Integer

        'Show the page of the searched order
        If myRdr.Read() Then
            RowNum = CInt(myRdr("row_num"))
            CurrentPage = Math.Ceiling(RowNum / 10)
            myConn.Close()
            UpdatePage()

            MessageBox.Show($"Order Found at Page: {CurrentPage} - Index: {(RowNum Mod 10) - 1}", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            myConn.Close()
            MessageBox.Show($"Order does not exist", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class