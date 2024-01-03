<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.AmountPnl = New System.Windows.Forms.Panel()
        Me.ChartPnl = New System.Windows.Forms.Panel()
        Me.ChartSplitCntnr = New System.Windows.Forms.SplitContainer()
        Me.YearPieChartPnl = New System.Windows.Forms.Panel()
        Me.PieChartPnl = New System.Windows.Forms.Panel()
        Me.PieChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.YearIncomePnl = New System.Windows.Forms.Panel()
        Me.TotalIncomePnl = New System.Windows.Forms.Panel()
        Me.TotalIncomePddng = New System.Windows.Forms.Panel()
        Me.TotalIncPhpLbl = New System.Windows.Forms.Label()
        Me.TotalIncLbl = New System.Windows.Forms.Label()
        Me.YearColPnl = New System.Windows.Forms.Panel()
        Me.ColChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.HeaderPnl = New System.Windows.Forms.Panel()
        Me.YearCmbBxPnl = New System.Windows.Forms.Panel()
        Me.YearCmbBx = New System.Windows.Forms.ComboBox()
        Me.AmountPnl.SuspendLayout()
        Me.ChartPnl.SuspendLayout()
        CType(Me.ChartSplitCntnr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChartSplitCntnr.Panel1.SuspendLayout()
        Me.ChartSplitCntnr.Panel2.SuspendLayout()
        Me.ChartSplitCntnr.SuspendLayout()
        Me.YearPieChartPnl.SuspendLayout()
        Me.PieChartPnl.SuspendLayout()
        CType(Me.PieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.YearIncomePnl.SuspendLayout()
        Me.TotalIncomePnl.SuspendLayout()
        Me.TotalIncomePddng.SuspendLayout()
        Me.YearColPnl.SuspendLayout()
        CType(Me.ColChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPnl.SuspendLayout()
        Me.YearCmbBxPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'AmountPnl
        '
        Me.AmountPnl.Controls.Add(Me.ChartPnl)
        Me.AmountPnl.Controls.Add(Me.HeaderPnl)
        Me.AmountPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmountPnl.Location = New System.Drawing.Point(0, 0)
        Me.AmountPnl.Name = "AmountPnl"
        Me.AmountPnl.Size = New System.Drawing.Size(1184, 721)
        Me.AmountPnl.TabIndex = 0
        '
        'ChartPnl
        '
        Me.ChartPnl.Controls.Add(Me.ChartSplitCntnr)
        Me.ChartPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartPnl.Location = New System.Drawing.Point(0, 68)
        Me.ChartPnl.Name = "ChartPnl"
        Me.ChartPnl.Padding = New System.Windows.Forms.Padding(20)
        Me.ChartPnl.Size = New System.Drawing.Size(1184, 653)
        Me.ChartPnl.TabIndex = 2
        '
        'ChartSplitCntnr
        '
        Me.ChartSplitCntnr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartSplitCntnr.IsSplitterFixed = True
        Me.ChartSplitCntnr.Location = New System.Drawing.Point(20, 20)
        Me.ChartSplitCntnr.Name = "ChartSplitCntnr"
        '
        'ChartSplitCntnr.Panel1
        '
        Me.ChartSplitCntnr.Panel1.Controls.Add(Me.YearPieChartPnl)
        Me.ChartSplitCntnr.Panel1.Controls.Add(Me.YearIncomePnl)
        '
        'ChartSplitCntnr.Panel2
        '
        Me.ChartSplitCntnr.Panel2.Controls.Add(Me.YearColPnl)
        Me.ChartSplitCntnr.Panel2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ChartSplitCntnr.Size = New System.Drawing.Size(1144, 613)
        Me.ChartSplitCntnr.SplitterDistance = 649
        Me.ChartSplitCntnr.TabIndex = 1
        '
        'YearPieChartPnl
        '
        Me.YearPieChartPnl.Controls.Add(Me.PieChartPnl)
        Me.YearPieChartPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YearPieChartPnl.Location = New System.Drawing.Point(0, 143)
        Me.YearPieChartPnl.Name = "YearPieChartPnl"
        Me.YearPieChartPnl.Size = New System.Drawing.Size(649, 470)
        Me.YearPieChartPnl.TabIndex = 1
        '
        'PieChartPnl
        '
        Me.PieChartPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PieChartPnl.Controls.Add(Me.PieChart)
        Me.PieChartPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PieChartPnl.Location = New System.Drawing.Point(0, 0)
        Me.PieChartPnl.Name = "PieChartPnl"
        Me.PieChartPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.PieChartPnl.Size = New System.Drawing.Size(649, 470)
        Me.PieChartPnl.TabIndex = 2
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
        Me.PieChart.Size = New System.Drawing.Size(645, 466)
        Me.PieChart.TabIndex = 18
        Me.PieChart.Text = "Chart1"
        '
        'YearIncomePnl
        '
        Me.YearIncomePnl.Controls.Add(Me.TotalIncomePnl)
        Me.YearIncomePnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.YearIncomePnl.Location = New System.Drawing.Point(0, 0)
        Me.YearIncomePnl.Name = "YearIncomePnl"
        Me.YearIncomePnl.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.YearIncomePnl.Size = New System.Drawing.Size(649, 143)
        Me.YearIncomePnl.TabIndex = 0
        '
        'TotalIncomePnl
        '
        Me.TotalIncomePnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalIncomePnl.Controls.Add(Me.TotalIncomePddng)
        Me.TotalIncomePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalIncomePnl.Location = New System.Drawing.Point(0, 0)
        Me.TotalIncomePnl.Name = "TotalIncomePnl"
        Me.TotalIncomePnl.Padding = New System.Windows.Forms.Padding(2)
        Me.TotalIncomePnl.Size = New System.Drawing.Size(649, 123)
        Me.TotalIncomePnl.TabIndex = 8
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
        Me.TotalIncomePddng.Size = New System.Drawing.Size(645, 119)
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
        Me.TotalIncPhpLbl.Size = New System.Drawing.Size(504, 55)
        Me.TotalIncPhpLbl.TabIndex = 1
        Me.TotalIncPhpLbl.Text = "PHP 0"
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
        'YearColPnl
        '
        Me.YearColPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.YearColPnl.Controls.Add(Me.ColChart)
        Me.YearColPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YearColPnl.Location = New System.Drawing.Point(20, 0)
        Me.YearColPnl.Name = "YearColPnl"
        Me.YearColPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.YearColPnl.Size = New System.Drawing.Size(471, 613)
        Me.YearColPnl.TabIndex = 0
        '
        'ColChart
        '
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Name = "ChartArea1"
        Me.ColChart.ChartAreas.Add(ChartArea2)
        Me.ColChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.ColChart.Legends.Add(Legend2)
        Me.ColChart.Location = New System.Drawing.Point(2, 2)
        Me.ColChart.Margin = New System.Windows.Forms.Padding(0)
        Me.ColChart.Name = "ColChart"
        Me.ColChart.Size = New System.Drawing.Size(467, 609)
        Me.ColChart.TabIndex = 8
        Me.ColChart.Text = "Chart1"
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
        'Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.AmountPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.AmountPnl.ResumeLayout(False)
        Me.ChartPnl.ResumeLayout(False)
        Me.ChartSplitCntnr.Panel1.ResumeLayout(False)
        Me.ChartSplitCntnr.Panel2.ResumeLayout(False)
        CType(Me.ChartSplitCntnr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChartSplitCntnr.ResumeLayout(False)
        Me.YearPieChartPnl.ResumeLayout(False)
        Me.PieChartPnl.ResumeLayout(False)
        CType(Me.PieChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.YearIncomePnl.ResumeLayout(False)
        Me.TotalIncomePnl.ResumeLayout(False)
        Me.TotalIncomePddng.ResumeLayout(False)
        Me.TotalIncomePddng.PerformLayout()
        Me.YearColPnl.ResumeLayout(False)
        CType(Me.ColChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPnl.ResumeLayout(False)
        Me.YearCmbBxPnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AmountPnl As Panel
    Friend WithEvents HeaderPnl As Panel
    Friend WithEvents YearCmbBxPnl As Panel
    Friend WithEvents YearCmbBx As ComboBox
    Friend WithEvents ChartPnl As Panel
    Friend WithEvents ChartSplitCntnr As SplitContainer
    Friend WithEvents YearPieChartPnl As Panel
    Friend WithEvents YearIncomePnl As Panel
    Friend WithEvents TotalIncomePnl As Panel
    Friend WithEvents TotalIncomePddng As Panel
    Friend WithEvents TotalIncPhpLbl As Label
    Friend WithEvents TotalIncLbl As Label
    Friend WithEvents YearColPnl As Panel
    Friend WithEvents ColChart As DataVisualization.Charting.Chart
    Friend WithEvents PieChartPnl As Panel
    Friend WithEvents PieChart As DataVisualization.Charting.Chart
End Class
