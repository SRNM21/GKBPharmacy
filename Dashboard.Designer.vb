﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.AmountPnl = New System.Windows.Forms.Panel()
        Me.AmountSpltrPnl = New System.Windows.Forms.SplitContainer()
        Me.TotalIncomePnl = New System.Windows.Forms.Panel()
        Me.TotalIncomePddng = New System.Windows.Forms.Panel()
        Me.TotalIncPhpLbl = New System.Windows.Forms.Label()
        Me.TotalIncLbl = New System.Windows.Forms.Label()
        Me.TotalExpensesPnl = New System.Windows.Forms.Panel()
        Me.TotalExpensesPddng = New System.Windows.Forms.Panel()
        Me.TotalExpPhpLbl = New System.Windows.Forms.Label()
        Me.TotalExpLbl = New System.Windows.Forms.Label()
        Me.HeaderPnl = New System.Windows.Forms.Panel()
        Me.YearCmbBxPnl = New System.Windows.Forms.Panel()
        Me.YearCmbBx = New System.Windows.Forms.ComboBox()
        Me.ChartPnl = New System.Windows.Forms.Panel()
        Me.ChartSplitCntnr = New System.Windows.Forms.SplitContainer()
        Me.PieChartPnl = New System.Windows.Forms.Panel()
        Me.PieChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SideDashboardPnl = New System.Windows.Forms.TableLayoutPanel()
        Me.RecentOrdersPnl = New System.Windows.Forms.Panel()
        Me.RecentOrdersPddng = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StockPnl = New System.Windows.Forms.Panel()
        Me.StockPddng = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.NewOrdersPnl = New System.Windows.Forms.Panel()
        Me.NewOrdersPddng = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AmountPnl.SuspendLayout()
        CType(Me.AmountSpltrPnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AmountSpltrPnl.Panel1.SuspendLayout()
        Me.AmountSpltrPnl.Panel2.SuspendLayout()
        Me.AmountSpltrPnl.SuspendLayout()
        Me.TotalIncomePnl.SuspendLayout()
        Me.TotalIncomePddng.SuspendLayout()
        Me.TotalExpensesPnl.SuspendLayout()
        Me.TotalExpensesPddng.SuspendLayout()
        Me.HeaderPnl.SuspendLayout()
        Me.YearCmbBxPnl.SuspendLayout()
        Me.ChartPnl.SuspendLayout()
        CType(Me.ChartSplitCntnr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChartSplitCntnr.Panel1.SuspendLayout()
        Me.ChartSplitCntnr.Panel2.SuspendLayout()
        Me.ChartSplitCntnr.SuspendLayout()
        Me.PieChartPnl.SuspendLayout()
        CType(Me.PieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideDashboardPnl.SuspendLayout()
        Me.RecentOrdersPnl.SuspendLayout()
        Me.RecentOrdersPddng.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StockPnl.SuspendLayout()
        Me.StockPddng.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewOrdersPnl.SuspendLayout()
        Me.NewOrdersPddng.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmountPnl
        '
        Me.AmountPnl.Controls.Add(Me.AmountSpltrPnl)
        Me.AmountPnl.Controls.Add(Me.HeaderPnl)
        Me.AmountPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.AmountPnl.Location = New System.Drawing.Point(0, 0)
        Me.AmountPnl.Name = "AmountPnl"
        Me.AmountPnl.Size = New System.Drawing.Size(1184, 235)
        Me.AmountPnl.TabIndex = 0
        '
        'AmountSpltrPnl
        '
        Me.AmountSpltrPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmountSpltrPnl.IsSplitterFixed = True
        Me.AmountSpltrPnl.Location = New System.Drawing.Point(0, 68)
        Me.AmountSpltrPnl.Name = "AmountSpltrPnl"
        '
        'AmountSpltrPnl.Panel1
        '
        Me.AmountSpltrPnl.Panel1.Controls.Add(Me.TotalIncomePnl)
        Me.AmountSpltrPnl.Panel1.Padding = New System.Windows.Forms.Padding(20)
        '
        'AmountSpltrPnl.Panel2
        '
        Me.AmountSpltrPnl.Panel2.Controls.Add(Me.TotalExpensesPnl)
        Me.AmountSpltrPnl.Panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.AmountSpltrPnl.Size = New System.Drawing.Size(1184, 167)
        Me.AmountSpltrPnl.SplitterDistance = 591
        Me.AmountSpltrPnl.TabIndex = 2
        '
        'TotalIncomePnl
        '
        Me.TotalIncomePnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalIncomePnl.Controls.Add(Me.TotalIncomePddng)
        Me.TotalIncomePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalIncomePnl.Location = New System.Drawing.Point(20, 20)
        Me.TotalIncomePnl.Name = "TotalIncomePnl"
        Me.TotalIncomePnl.Padding = New System.Windows.Forms.Padding(2)
        Me.TotalIncomePnl.Size = New System.Drawing.Size(551, 127)
        Me.TotalIncomePnl.TabIndex = 3
        '
        'TotalIncomePddng
        '
        Me.TotalIncomePddng.BackColor = System.Drawing.Color.White
        Me.TotalIncomePddng.Controls.Add(Me.TotalIncPhpLbl)
        Me.TotalIncomePddng.Controls.Add(Me.TotalIncLbl)
        Me.TotalIncomePddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalIncomePddng.Location = New System.Drawing.Point(2, 2)
        Me.TotalIncomePddng.Name = "TotalIncomePddng"
        Me.TotalIncomePddng.Padding = New System.Windows.Forms.Padding(20)
        Me.TotalIncomePddng.Size = New System.Drawing.Size(547, 123)
        Me.TotalIncomePddng.TabIndex = 0
        '
        'TotalIncPhpLbl
        '
        Me.TotalIncPhpLbl.AutoEllipsis = True
        Me.TotalIncPhpLbl.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalIncPhpLbl.Font = New System.Drawing.Font("Arial", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalIncPhpLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalIncPhpLbl.Location = New System.Drawing.Point(20, 44)
        Me.TotalIncPhpLbl.Name = "TotalIncPhpLbl"
        Me.TotalIncPhpLbl.Size = New System.Drawing.Size(504, 59)
        Me.TotalIncPhpLbl.TabIndex = 1
        Me.TotalIncPhpLbl.Text = "PHP 1,000,000,000.00"
        '
        'TotalIncLbl
        '
        Me.TotalIncLbl.AutoSize = True
        Me.TotalIncLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TotalIncLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalIncLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalIncLbl.Location = New System.Drawing.Point(20, 20)
        Me.TotalIncLbl.Name = "TotalIncLbl"
        Me.TotalIncLbl.Size = New System.Drawing.Size(216, 24)
        Me.TotalIncLbl.TabIndex = 0
        Me.TotalIncLbl.Text = "Total Income this Year"
        '
        'TotalExpensesPnl
        '
        Me.TotalExpensesPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalExpensesPnl.Controls.Add(Me.TotalExpensesPddng)
        Me.TotalExpensesPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalExpensesPnl.Location = New System.Drawing.Point(20, 20)
        Me.TotalExpensesPnl.Name = "TotalExpensesPnl"
        Me.TotalExpensesPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.TotalExpensesPnl.Size = New System.Drawing.Size(549, 127)
        Me.TotalExpensesPnl.TabIndex = 3
        '
        'TotalExpensesPddng
        '
        Me.TotalExpensesPddng.BackColor = System.Drawing.Color.White
        Me.TotalExpensesPddng.Controls.Add(Me.TotalExpPhpLbl)
        Me.TotalExpensesPddng.Controls.Add(Me.TotalExpLbl)
        Me.TotalExpensesPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalExpensesPddng.Location = New System.Drawing.Point(2, 2)
        Me.TotalExpensesPddng.Name = "TotalExpensesPddng"
        Me.TotalExpensesPddng.Padding = New System.Windows.Forms.Padding(20)
        Me.TotalExpensesPddng.Size = New System.Drawing.Size(545, 123)
        Me.TotalExpensesPddng.TabIndex = 1
        '
        'TotalExpPhpLbl
        '
        Me.TotalExpPhpLbl.AutoEllipsis = True
        Me.TotalExpPhpLbl.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalExpPhpLbl.Font = New System.Drawing.Font("Arial", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalExpPhpLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalExpPhpLbl.Location = New System.Drawing.Point(20, 44)
        Me.TotalExpPhpLbl.Name = "TotalExpPhpLbl"
        Me.TotalExpPhpLbl.Size = New System.Drawing.Size(504, 59)
        Me.TotalExpPhpLbl.TabIndex = 3
        Me.TotalExpPhpLbl.Text = "PHP 1,000,000,000.00"
        '
        'TotalExpLbl
        '
        Me.TotalExpLbl.AutoSize = True
        Me.TotalExpLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TotalExpLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalExpLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalExpLbl.Location = New System.Drawing.Point(20, 20)
        Me.TotalExpLbl.Name = "TotalExpLbl"
        Me.TotalExpLbl.Size = New System.Drawing.Size(240, 24)
        Me.TotalExpLbl.TabIndex = 2
        Me.TotalExpLbl.Text = "Total Expenses this Year"
        '
        'HeaderPnl
        '
        Me.HeaderPnl.Controls.Add(Me.YearCmbBxPnl)
        Me.HeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPnl.Name = "HeaderPnl"
        Me.HeaderPnl.Size = New System.Drawing.Size(1184, 68)
        Me.HeaderPnl.TabIndex = 0
        '
        'YearCmbBxPnl
        '
        Me.YearCmbBxPnl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.YearCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.YearCmbBxPnl.Controls.Add(Me.YearCmbBx)
        Me.YearCmbBxPnl.Location = New System.Drawing.Point(20, 20)
        Me.YearCmbBxPnl.Name = "YearCmbBxPnl"
        Me.YearCmbBxPnl.Size = New System.Drawing.Size(103, 34)
        Me.YearCmbBxPnl.TabIndex = 5
        '
        'YearCmbBx
        '
        Me.YearCmbBx.BackColor = System.Drawing.Color.White
        Me.YearCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearCmbBx.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.YearCmbBx.FormattingEnabled = True
        Me.YearCmbBx.Items.AddRange(New Object() {"Date Ordered (Newest to Oldest)", "Date Ordered (Oldest to Newest)", "Date Complete (Newest to Oldest)", "Date Complete (Oldest to Newest)", "Total Items (Ascending)", "Total Items Descending", "Total Amount (Ascending)", "Total Amount Descending"})
        Me.YearCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.YearCmbBx.Name = "YearCmbBx"
        Me.YearCmbBx.Size = New System.Drawing.Size(99, 30)
        Me.YearCmbBx.TabIndex = 0
        '
        'ChartPnl
        '
        Me.ChartPnl.Controls.Add(Me.ChartSplitCntnr)
        Me.ChartPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartPnl.Location = New System.Drawing.Point(0, 235)
        Me.ChartPnl.Name = "ChartPnl"
        Me.ChartPnl.Padding = New System.Windows.Forms.Padding(20)
        Me.ChartPnl.Size = New System.Drawing.Size(1184, 486)
        Me.ChartPnl.TabIndex = 1
        '
        'ChartSplitCntnr
        '
        Me.ChartSplitCntnr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartSplitCntnr.Location = New System.Drawing.Point(20, 20)
        Me.ChartSplitCntnr.Name = "ChartSplitCntnr"
        '
        'ChartSplitCntnr.Panel1
        '
        Me.ChartSplitCntnr.Panel1.Controls.Add(Me.PieChartPnl)
        '
        'ChartSplitCntnr.Panel2
        '
        Me.ChartSplitCntnr.Panel2.Controls.Add(Me.SideDashboardPnl)
        Me.ChartSplitCntnr.Panel2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.ChartSplitCntnr.Size = New System.Drawing.Size(1144, 446)
        Me.ChartSplitCntnr.SplitterDistance = 695
        Me.ChartSplitCntnr.TabIndex = 1
        '
        'PieChartPnl
        '
        Me.PieChartPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PieChartPnl.Controls.Add(Me.PieChart)
        Me.PieChartPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PieChartPnl.Location = New System.Drawing.Point(0, 0)
        Me.PieChartPnl.Name = "PieChartPnl"
        Me.PieChartPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.PieChartPnl.Size = New System.Drawing.Size(695, 446)
        Me.PieChartPnl.TabIndex = 0
        '
        'PieChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.PieChart.ChartAreas.Add(ChartArea1)
        Me.PieChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.PieChart.Legends.Add(Legend1)
        Me.PieChart.Location = New System.Drawing.Point(2, 2)
        Me.PieChart.Name = "PieChart"
        Me.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.PieChart.Series.Add(Series1)
        Me.PieChart.Size = New System.Drawing.Size(691, 442)
        Me.PieChart.TabIndex = 18
        Me.PieChart.Text = "Chart1"
        '
        'SideDashboardPnl
        '
        Me.SideDashboardPnl.ColumnCount = 1
        Me.SideDashboardPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SideDashboardPnl.Controls.Add(Me.RecentOrdersPnl, 0, 2)
        Me.SideDashboardPnl.Controls.Add(Me.StockPnl, 0, 4)
        Me.SideDashboardPnl.Controls.Add(Me.NewOrdersPnl, 0, 0)
        Me.SideDashboardPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideDashboardPnl.Location = New System.Drawing.Point(35, 0)
        Me.SideDashboardPnl.Name = "SideDashboardPnl"
        Me.SideDashboardPnl.RowCount = 5
        Me.SideDashboardPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.SideDashboardPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.SideDashboardPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.SideDashboardPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.SideDashboardPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.SideDashboardPnl.Size = New System.Drawing.Size(410, 446)
        Me.SideDashboardPnl.TabIndex = 0
        '
        'RecentOrdersPnl
        '
        Me.RecentOrdersPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.RecentOrdersPnl.Controls.Add(Me.RecentOrdersPddng)
        Me.RecentOrdersPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecentOrdersPnl.Location = New System.Drawing.Point(0, 161)
        Me.RecentOrdersPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.RecentOrdersPnl.Name = "RecentOrdersPnl"
        Me.RecentOrdersPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.RecentOrdersPnl.Size = New System.Drawing.Size(410, 122)
        Me.RecentOrdersPnl.TabIndex = 19
        '
        'RecentOrdersPddng
        '
        Me.RecentOrdersPddng.BackColor = System.Drawing.Color.White
        Me.RecentOrdersPddng.Controls.Add(Me.PictureBox2)
        Me.RecentOrdersPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecentOrdersPddng.Location = New System.Drawing.Point(2, 2)
        Me.RecentOrdersPddng.Name = "RecentOrdersPddng"
        Me.RecentOrdersPddng.Size = New System.Drawing.Size(406, 118)
        Me.RecentOrdersPddng.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 118)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'StockPnl
        '
        Me.StockPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.StockPnl.Controls.Add(Me.StockPddng)
        Me.StockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockPnl.Location = New System.Drawing.Point(0, 323)
        Me.StockPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.StockPnl.Name = "StockPnl"
        Me.StockPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.StockPnl.Size = New System.Drawing.Size(410, 123)
        Me.StockPnl.TabIndex = 1
        '
        'StockPddng
        '
        Me.StockPddng.BackColor = System.Drawing.Color.White
        Me.StockPddng.Controls.Add(Me.PictureBox3)
        Me.StockPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockPddng.Location = New System.Drawing.Point(2, 2)
        Me.StockPddng.Name = "StockPddng"
        Me.StockPddng.Size = New System.Drawing.Size(406, 119)
        Me.StockPddng.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 119)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'NewOrdersPnl
        '
        Me.NewOrdersPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.NewOrdersPnl.Controls.Add(Me.NewOrdersPddng)
        Me.NewOrdersPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewOrdersPnl.Location = New System.Drawing.Point(0, 0)
        Me.NewOrdersPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.NewOrdersPnl.Name = "NewOrdersPnl"
        Me.NewOrdersPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.NewOrdersPnl.Size = New System.Drawing.Size(410, 121)
        Me.NewOrdersPnl.TabIndex = 0
        '
        'NewOrdersPddng
        '
        Me.NewOrdersPddng.BackColor = System.Drawing.Color.White
        Me.NewOrdersPddng.Controls.Add(Me.PictureBox1)
        Me.NewOrdersPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewOrdersPddng.Location = New System.Drawing.Point(2, 2)
        Me.NewOrdersPddng.Name = "NewOrdersPddng"
        Me.NewOrdersPddng.Size = New System.Drawing.Size(406, 117)
        Me.NewOrdersPddng.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 117)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.ChartPnl)
        Me.Controls.Add(Me.AmountPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.AmountPnl.ResumeLayout(False)
        Me.AmountSpltrPnl.Panel1.ResumeLayout(False)
        Me.AmountSpltrPnl.Panel2.ResumeLayout(False)
        CType(Me.AmountSpltrPnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AmountSpltrPnl.ResumeLayout(False)
        Me.TotalIncomePnl.ResumeLayout(False)
        Me.TotalIncomePddng.ResumeLayout(False)
        Me.TotalIncomePddng.PerformLayout()
        Me.TotalExpensesPnl.ResumeLayout(False)
        Me.TotalExpensesPddng.ResumeLayout(False)
        Me.TotalExpensesPddng.PerformLayout()
        Me.HeaderPnl.ResumeLayout(False)
        Me.YearCmbBxPnl.ResumeLayout(False)
        Me.ChartPnl.ResumeLayout(False)
        Me.ChartSplitCntnr.Panel1.ResumeLayout(False)
        Me.ChartSplitCntnr.Panel2.ResumeLayout(False)
        CType(Me.ChartSplitCntnr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChartSplitCntnr.ResumeLayout(False)
        Me.PieChartPnl.ResumeLayout(False)
        CType(Me.PieChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideDashboardPnl.ResumeLayout(False)
        Me.RecentOrdersPnl.ResumeLayout(False)
        Me.RecentOrdersPddng.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StockPnl.ResumeLayout(False)
        Me.StockPddng.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewOrdersPnl.ResumeLayout(False)
        Me.NewOrdersPddng.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AmountPnl As Panel
    Friend WithEvents AmountSpltrPnl As SplitContainer
    Friend WithEvents HeaderPnl As Panel
    Friend WithEvents YearCmbBxPnl As Panel
    Friend WithEvents YearCmbBx As ComboBox
    Friend WithEvents ChartPnl As Panel
    Friend WithEvents TotalIncomePnl As Panel
    Friend WithEvents TotalIncomePddng As Panel
    Friend WithEvents TotalIncPhpLbl As Label
    Friend WithEvents TotalIncLbl As Label
    Friend WithEvents TotalExpensesPnl As Panel
    Friend WithEvents TotalExpensesPddng As Panel
    Friend WithEvents TotalExpPhpLbl As Label
    Friend WithEvents TotalExpLbl As Label
    Friend WithEvents ChartSplitCntnr As SplitContainer
    Friend WithEvents PieChartPnl As Panel
    Friend WithEvents PieChart As DataVisualization.Charting.Chart
    Friend WithEvents SideDashboardPnl As TableLayoutPanel
    Friend WithEvents RecentOrdersPnl As Panel
    Friend WithEvents RecentOrdersPddng As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents StockPnl As Panel
    Friend WithEvents StockPddng As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NewOrdersPnl As Panel
    Friend WithEvents NewOrdersPddng As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class