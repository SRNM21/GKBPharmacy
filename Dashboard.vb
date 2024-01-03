Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get all years in the reference table
        Dim Years As New List(Of String)

        Sql = $"SELECT 
                    DISTINCT YEAR(date_ord_cmplt) AS year_ord
                FROM 
                    invoice"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            Years.Add(myRdr("year_ord"))
        End While

        myConn.Close()

        Years.Sort()
        Years.Reverse()
        YearCmbBx.Items.Clear()
        YearCmbBx.Items.AddRange(Years.ToArray())

        If YearCmbBx.Items.Count > 0 Then
            YearCmbBx.SelectedIndex = 0
        End If
    End Sub

    Private Sub YearCmbBx_SelectedValueChanged(sender As Object, e As EventArgs) Handles YearCmbBx.SelectedValueChanged
        DrawChart()
        GetTotalIncome()
    End Sub

    Private Sub DrawChart()
        Dim ColorPallete() As Color = {Color.FromArgb(22, 72, 99), Color.FromArgb(33, 97, 132), Color.FromArgb(36, 116, 159), Color.FromArgb(42, 130, 176)}

        'Set the data for pie and column chart
        Dim PieSeries As New Series("PieC") With {
            .ChartType = SeriesChartType.Pie
        }

        Dim ColSeries As New Series("ColC") With {
            .ChartType = SeriesChartType.Column
        }

        PieChart.Series.Clear()
        ColChart.Series.Clear()

        'Add all 4 categories data in the charts
        Sql = $"SELECT 
                    items.category,
                    COUNT(items.item_id) AS item_count
                FROM 
                    order_items 
                JOIN 
                    invoice ON invoice.order_id = order_items.order_id 
		        JOIN 
	  	            items ON order_items.item_id = items.item_id
                WHERE 
                    invoice.date_ord_cmplt LIKE '{YearCmbBx.Text}%'
		        GROUP BY 
		            items.category"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        Dim ColorIndex As Integer = 0

        While myRdr.Read()
            Dim PiePoint As New DataPoint()
            PiePoint.SetValueXY(myRdr("category"), myRdr("item_count"))
            PiePoint.Color = ColorPallete(ColorIndex)
            PiePoint.IsValueShownAsLabel = True
            PiePoint.Label = "#PERCENT{P2}"
            PiePoint.LabelForeColor = Color.White
            PiePoint.LegendText = myRdr("category")
            PieSeries.Points.Add(PiePoint)

            Dim ColPoint As New DataPoint()
            ColPoint.SetValueXY(myRdr("category"), myRdr("item_count"))
            ColPoint.Color = ColorPallete(ColorIndex)
            ColPoint.IsVisibleInLegend = False
            ColSeries.Points.Add(ColPoint)

            ColorIndex += 1
        End While

        myConn.Close()

        'Add all deleted items data in the charts
        Sql = $"SELECT 
                    COUNT(*) AS item_count
                FROM 
                    order_items 
                JOIN 
                    orders ON orders.order_id = order_items.order_id 
                WHERE 
                    (orders.status = 'Done' AND order_items.item_id is null)
                AND orders.order_date LIKE '{YearCmbBx.Text}%'"

        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        If myRdr.Read Then
            Dim PiePoint As New DataPoint()
            PiePoint.SetValueXY("Not Available", myRdr("item_count"))
            PiePoint.Color = Color.Gray
            PiePoint.IsValueShownAsLabel = True
            PiePoint.Label = "#PERCENT{P2}"
            PiePoint.LabelForeColor = Color.White
            PiePoint.LegendText = "Not Available"
            PieSeries.Points.Add(PiePoint)

            Dim ColPoint As New DataPoint()
            ColPoint.SetValueXY("Not Available", myRdr("item_count"))
            ColPoint.Color = Color.Gray
            ColPoint.IsVisibleInLegend = False
            ColSeries.Points.Add(ColPoint)
        End If

        myConn.Close()

        'Style the charts
        PieChart.Series.Add(PieSeries)
        ColChart.Series.Add(ColSeries)

        PieChart.Series("PieC").Font = New Font("Arial", 16)
        ColChart.Series("ColC").Font = New Font("Arial", 16)

        ColChart.Series("ColC").IsVisibleInLegend = False
        For Each legend As Legend In PieChart.Legends
            legend.Font = New Font("Arial", 12, FontStyle.Bold)
            legend.ForeColor = Color.FromArgb(22, 72, 99)
        Next
    End Sub

    Private Sub GetTotalIncome()
        'Get total income from the selected year
        Sql = $"SELECT
                    SUM(total_amount) AS total
                FROM
                    invoice
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
End Class