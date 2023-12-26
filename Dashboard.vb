Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YearCmbBx.Items.Clear()

        Sql = $"SELECT 
                    DISTINCT YEAR(date_ord_cmplt) AS year_ord
                FROM 
                    reference"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            YearCmbBx.Items.Add(myRdr("year_ord"))
        End While

        myConn.Close()

        YearCmbBx.SelectedIndex = 0
    End Sub

    Private Sub YearCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles YearCmbBx.SelectedValueChanged
        DrawChart()
        GetTotalIncome()
        GetTotalExpenses()
    End Sub

    Private Sub DrawChart()
        Dim ColorPallete() As Color = {Color.FromArgb(22, 72, 99), Color.FromArgb(33, 97, 132), Color.FromArgb(36, 116, 159), Color.FromArgb(42, 130, 176)}

        Dim series As New Series("AllCat") With {
            .ChartType = SeriesChartType.Pie
        }

        PieChart.Series.Clear()

        Sql = $"SELECT
                     items.category,
                     COUNT(order_items.item_id) AS item_count
                 FROM
                     items
                 JOIN
                     order_items ON order_items.item_id = items.item_id
                 GROUP BY
                     items.category"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        Dim ColorIndex As Integer = 0

        While myRdr.Read()
            Dim point As New DataPoint()
            point.SetValueXY(myRdr("category"), myRdr("item_count"))
            point.Color = ColorPallete(ColorIndex)
            point.IsValueShownAsLabel = True
            point.Label = "#PERCENT{P0}"
            point.LabelForeColor = Color.White
            point.LegendText = myRdr("category")
            series.Points.Add(point)

            ColorIndex += 1
        End While

        myConn.Close()

        Sql = $"SELECT 
                    COUNT(*) AS item_count
                FROM 
                    order_items 
                JOIN 
                    orders ON orders.order_id = order_items.order_id 
                WHERE 
                    orders.status = 'Done' AND order_items.item_id is null"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read Then
            Dim point As New DataPoint()
            point.SetValueXY("Not Available", myRdr("item_count"))
            point.Color = Color.Gray
            point.IsValueShownAsLabel = True
            point.Label = "#PERCENT{P0}"
            point.LabelForeColor = Color.White
            point.LegendText = "Not Available"
            series.Points.Add(point)
        End If

        myConn.Close()

        PieChart.Series.Add(series)
        PieChart.Series("AllCat").Font = New Font("Arial", 16)

        For Each legend As Legend In PieChart.Legends
            legend.Font = New Font("Arial", 12, FontStyle.Bold)
            legend.ForeColor = Color.FromArgb(22, 72, 99)
        Next
    End Sub

    Private Sub GetTotalIncome()
        Sql = $"SELECT
                    SUM(total_amount) AS total
                FROM
                    reference
                WHERE
                    date_ord_cmplt LIKE '{YearCmbBx.Text}%'"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read Then
            TotalIncPhpLbl.Text = $"PHP {If(myRdr("total") IsNot DBNull.Value, myRdr("total"), 0):N2}"
        End If

        myConn.Close()
    End Sub

    Private Sub GetTotalExpenses()
        Sql = $"SELECT
                    SUM(total_amount) AS total
                FROM
                    supply
                WHERE
                    date_ordered LIKE '{YearCmbBx.Text}%'"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read Then
            TotalExpPhpLbl.Text = $"PHP {If(myRdr("total") IsNot DBNull.Value, myRdr("total"), 0):N2}"
        End If

        myConn.Close()
    End Sub
End Class