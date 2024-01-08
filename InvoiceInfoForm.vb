Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class InvoiceInfoForm

    Private Sub InvoiceInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeMainWindowForm(HistoryForm)
    End Sub

    Private Sub DisplayPharmacistInfo()
        Sql = $"SELECT 
                    pharmacists.phrmcst_id,
                    pharmacists.first_name,
                    pharmacists.last_name,
                    pharmacists.gender,
                    pharmacists.email,
                    pharmacists.phone_num
                FROM 
                    pharmacists
                LEFT JOIN 
                    invoice ON invoice.phrmcst_id = pharmacists.phrmcst_id
                WHERE 
                    invoice.invoice_no=@inv"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@inv", Invoice.Text)
        myRdr = myCmd.ExecuteReader()

        PharmacistID.ForeColor = Color.FromArgb(22, 72, 99)
        PharmacitsName.ForeColor = Color.FromArgb(22, 72, 99)

        If myRdr.Read Then
            If myRdr("phrmcst_id") Is DBNull.Value Then
                PharmacistID.ForeColor = Color.Red
                PharmacitsName.ForeColor = Color.Red

                PharmacistID.Text = "PHA-404-NOT-FOUND"
                PharmacitsName.Text = "NOT FOUND"
                PGender.Text = ""
                Email.Text = ""
                PhoneNum.Text = ""
            Else
                PharmacistID.Text = myRdr("phrmcst_id")
                PharmacitsName.Text = $"{myRdr("first_name")} {myRdr("last_name")}"
                PGender.Text = myRdr("gender")
                Email.Text = myRdr("email")
                PhoneNum.Text = myRdr("phone_num")
            End If
        End If

        myConn.Close()
    End Sub

    Private Sub DisplayCustomerInfo()
        Sql = $"SELECT
                    customers.cstmr_id,
                    customers.first_name,
                    customers.last_name,
                    customers.gender,
                    invoice.order_id
                FROM
                    invoice
                JOIN
                    orders ON invoice.order_id = orders.order_id
                LEFT JOIN
                    customers ON orders.cstmr_id = customers.cstmr_id
                WHERE 
                    invoice.invoice_no=@inv"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@inv", Invoice.Text)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read Then
            If myRdr("cstmr_id") Is DBNull.Value Then
                CustomerID.ForeColor = Color.Red
                CustomerName.ForeColor = Color.Red

                CustomerID.Text = "CST-404-NOT-FOUND"
                CustomerName.Text = "NOT FOUND"
                CGender.Text = ""
            Else
                CustomerID.ForeColor = Color.FromArgb(22, 72, 99)
                CustomerName.ForeColor = Color.FromArgb(22, 72, 99)

                CustomerID.Text = myRdr("cstmr_id")
                CustomerName.Text = $"{myRdr("first_name")} {myRdr("last_name")}"
                CGender.Text = myRdr("gender")
            End If

            OrderID.Text = myRdr("order_id")
        End If

        myConn.Close()
    End Sub

    Private Sub DisplayOrder()
        Sql = $"SELECT
                    COALESCE(supplier, 'DELETED') AS supplier,
                    COALESCE(item_name, 'DELETED') AS item_name,
                    COALESCE(item_id, 'DELETED') AS item_id,
                    COALESCE(category, 'DELETED') AS category,
                    price,
                    quantity,
                    total_amount
                FROM
                    v_order_details
                WHERE 
                    invoice_no='{Invoice.Text}'"

        UpdateDataGrid(Sql, IDGV)
    End Sub

    Private Sub DisplayOrderDetails()
        Sql = $"SELECT
                    date_ord_cmplt,
                    total_amount
                FROM
                    invoice
                WHERE 
                    invoice_no=@inv"

        myConn.Open()

        myCmd = New MySqlCommand(Sql, myConn)
        myCmd.Parameters.AddWithValue("@inv", Invoice.Text)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read Then
            DateOrdCmplt.Text = myRdr("date_ord_cmplt")
            TotalAmount.Text = $"PHP {CDec(myRdr("total_amount")):N2}"
        End If

        myConn.Close()
    End Sub

    Public Sub ShowDetails(Inv As String)
        Invoice.Text = Inv

        DisplayPharmacistInfo()
        DisplayCustomerInfo()
        DisplayOrder()
        DisplayOrderDetails()

        ChangeMainWindowForm(Me)
    End Sub

End Class