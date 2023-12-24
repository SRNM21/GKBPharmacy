<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersCheckOutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersCheckOutForm))
        Me.OCDockPnl = New System.Windows.Forms.Panel()
        Me.OrderItemsDockPnl = New System.Windows.Forms.Panel()
        Me.OrderItemsPnl = New System.Windows.Forms.Panel()
        Me.OrderItemsTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.QtyLbl = New System.Windows.Forms.Label()
        Me.ItemNameLbl = New System.Windows.Forms.Label()
        Me.ItemIDLbl = New System.Windows.Forms.Label()
        Me.StockLbl = New System.Windows.Forms.Label()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.SortDockPnl = New System.Windows.Forms.Panel()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.SortPnl = New System.Windows.Forms.Panel()
        Me.SortCmbBx = New System.Windows.Forms.ComboBox()
        Me.OrderInfoPnl = New System.Windows.Forms.Panel()
        Me.PHPLbl = New System.Windows.Forms.Label()
        Me.TotalItemsLb = New System.Windows.Forms.Label()
        Me.OrderTotalLbl = New System.Windows.Forms.Label()
        Me.CheckOutBtn = New System.Windows.Forms.Button()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.CustomerAvatarPctrBx = New System.Windows.Forms.PictureBox()
        Me.CustomerIDLbl = New System.Windows.Forms.Label()
        Me.OrderIDLbl = New System.Windows.Forms.Label()
        Me.OrderLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.OCDockPnl.SuspendLayout()
        Me.OrderItemsDockPnl.SuspendLayout()
        Me.OrderItemsPnl.SuspendLayout()
        Me.HeaderTblLyt.SuspendLayout()
        Me.SortDockPnl.SuspendLayout()
        Me.SortPnl.SuspendLayout()
        Me.OrderInfoPnl.SuspendLayout()
        CType(Me.CustomerAvatarPctrBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OCDockPnl
        '
        Me.OCDockPnl.Controls.Add(Me.OrderItemsDockPnl)
        Me.OCDockPnl.Controls.Add(Me.OrderInfoPnl)
        Me.OCDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OCDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.OCDockPnl.Name = "OCDockPnl"
        Me.OCDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.OCDockPnl.TabIndex = 0
        '
        'OrderItemsDockPnl
        '
        Me.OrderItemsDockPnl.Controls.Add(Me.OrderItemsPnl)
        Me.OrderItemsDockPnl.Controls.Add(Me.SortDockPnl)
        Me.OrderItemsDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderItemsDockPnl.Location = New System.Drawing.Point(496, 0)
        Me.OrderItemsDockPnl.Name = "OrderItemsDockPnl"
        Me.OrderItemsDockPnl.Padding = New System.Windows.Forms.Padding(0, 0, 50, 50)
        Me.OrderItemsDockPnl.Size = New System.Drawing.Size(688, 721)
        Me.OrderItemsDockPnl.TabIndex = 38
        '
        'OrderItemsPnl
        '
        Me.OrderItemsPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderItemsPnl.Controls.Add(Me.OrderItemsTblLyt)
        Me.OrderItemsPnl.Controls.Add(Me.HeaderTblLyt)
        Me.OrderItemsPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderItemsPnl.Location = New System.Drawing.Point(0, 84)
        Me.OrderItemsPnl.Name = "OrderItemsPnl"
        Me.OrderItemsPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.OrderItemsPnl.Size = New System.Drawing.Size(638, 587)
        Me.OrderItemsPnl.TabIndex = 2
        '
        'OrderItemsTblLyt
        '
        Me.OrderItemsTblLyt.AutoScroll = True
        Me.OrderItemsTblLyt.ColumnCount = 5
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OrderItemsTblLyt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderItemsTblLyt.Location = New System.Drawing.Point(2, 42)
        Me.OrderItemsTblLyt.Name = "OrderItemsTblLyt"
        Me.OrderItemsTblLyt.RowCount = 1
        Me.OrderItemsTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OrderItemsTblLyt.Size = New System.Drawing.Size(634, 543)
        Me.OrderItemsTblLyt.TabIndex = 2
        '
        'HeaderTblLyt
        '
        Me.HeaderTblLyt.BackColor = System.Drawing.Color.White
        Me.HeaderTblLyt.ColumnCount = 6
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83968!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83968!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83968!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83968!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83968!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8016016!))
        Me.HeaderTblLyt.Controls.Add(Me.QtyLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.ItemNameLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.ItemIDLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.StockLbl, 3, 0)
        Me.HeaderTblLyt.Controls.Add(Me.TotalLbl, 4, 0)
        Me.HeaderTblLyt.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderTblLyt.Location = New System.Drawing.Point(2, 2)
        Me.HeaderTblLyt.Name = "HeaderTblLyt"
        Me.HeaderTblLyt.RowCount = 1
        Me.HeaderTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HeaderTblLyt.Size = New System.Drawing.Size(634, 40)
        Me.HeaderTblLyt.TabIndex = 1
        '
        'QtyLbl
        '
        Me.QtyLbl.AutoSize = True
        Me.QtyLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QtyLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyLbl.Location = New System.Drawing.Point(253, 0)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(119, 40)
        Me.QtyLbl.TabIndex = 6
        Me.QtyLbl.Text = "Quantity"
        Me.QtyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemNameLbl
        '
        Me.ItemNameLbl.AutoSize = True
        Me.ItemNameLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemNameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemNameLbl.Location = New System.Drawing.Point(128, 0)
        Me.ItemNameLbl.Name = "ItemNameLbl"
        Me.ItemNameLbl.Size = New System.Drawing.Size(119, 40)
        Me.ItemNameLbl.TabIndex = 5
        Me.ItemNameLbl.Text = "Item name"
        Me.ItemNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemIDLbl
        '
        Me.ItemIDLbl.AutoSize = True
        Me.ItemIDLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemIDLbl.Location = New System.Drawing.Point(3, 0)
        Me.ItemIDLbl.Name = "ItemIDLbl"
        Me.ItemIDLbl.Size = New System.Drawing.Size(119, 40)
        Me.ItemIDLbl.TabIndex = 0
        Me.ItemIDLbl.Text = "Item ID"
        Me.ItemIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StockLbl
        '
        Me.StockLbl.AutoSize = True
        Me.StockLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.StockLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.StockLbl.Location = New System.Drawing.Point(378, 0)
        Me.StockLbl.Name = "StockLbl"
        Me.StockLbl.Size = New System.Drawing.Size(119, 40)
        Me.StockLbl.TabIndex = 7
        Me.StockLbl.Text = "Stock"
        Me.StockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalLbl.Location = New System.Drawing.Point(503, 0)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(119, 40)
        Me.TotalLbl.TabIndex = 8
        Me.TotalLbl.Text = "Total"
        Me.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SortDockPnl
        '
        Me.SortDockPnl.Controls.Add(Me.SortLbl)
        Me.SortDockPnl.Controls.Add(Me.SortPnl)
        Me.SortDockPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.SortDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.SortDockPnl.Name = "SortDockPnl"
        Me.SortDockPnl.Size = New System.Drawing.Size(638, 84)
        Me.SortDockPnl.TabIndex = 0
        '
        'SortLbl
        '
        Me.SortLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SortLbl.AutoSize = True
        Me.SortLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SortLbl.Location = New System.Drawing.Point(365, 27)
        Me.SortLbl.Name = "SortLbl"
        Me.SortLbl.Size = New System.Drawing.Size(49, 24)
        Me.SortLbl.TabIndex = 45
        Me.SortLbl.Text = "Sort"
        '
        'SortPnl
        '
        Me.SortPnl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SortPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SortPnl.Controls.Add(Me.SortCmbBx)
        Me.SortPnl.Location = New System.Drawing.Point(420, 23)
        Me.SortPnl.Name = "SortPnl"
        Me.SortPnl.Size = New System.Drawing.Size(218, 34)
        Me.SortPnl.TabIndex = 44
        '
        'SortCmbBx
        '
        Me.SortCmbBx.BackColor = System.Drawing.Color.White
        Me.SortCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SortCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SortCmbBx.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SortCmbBx.FormattingEnabled = True
        Me.SortCmbBx.Items.AddRange(New Object() {"Item (A-Z)", "Item (Z-A)", "Quantity ((Ascending))", "Quantity ((Descending))", "Total (Ascending)", "Total (Descending)"})
        Me.SortCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.SortCmbBx.Name = "SortCmbBx"
        Me.SortCmbBx.Size = New System.Drawing.Size(214, 30)
        Me.SortCmbBx.TabIndex = 0
        '
        'OrderInfoPnl
        '
        Me.OrderInfoPnl.Controls.Add(Me.PHPLbl)
        Me.OrderInfoPnl.Controls.Add(Me.TotalItemsLb)
        Me.OrderInfoPnl.Controls.Add(Me.OrderTotalLbl)
        Me.OrderInfoPnl.Controls.Add(Me.CheckOutBtn)
        Me.OrderInfoPnl.Controls.Add(Me.NameLbl)
        Me.OrderInfoPnl.Controls.Add(Me.CustomerAvatarPctrBx)
        Me.OrderInfoPnl.Controls.Add(Me.CustomerIDLbl)
        Me.OrderInfoPnl.Controls.Add(Me.OrderIDLbl)
        Me.OrderInfoPnl.Controls.Add(Me.OrderLbl)
        Me.OrderInfoPnl.Controls.Add(Me.BackBtn)
        Me.OrderInfoPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.OrderInfoPnl.Location = New System.Drawing.Point(0, 0)
        Me.OrderInfoPnl.Name = "OrderInfoPnl"
        Me.OrderInfoPnl.Size = New System.Drawing.Size(496, 721)
        Me.OrderInfoPnl.TabIndex = 37
        '
        'PHPLbl
        '
        Me.PHPLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PHPLbl.AutoSize = True
        Me.PHPLbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHPLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PHPLbl.Location = New System.Drawing.Point(44, 576)
        Me.PHPLbl.Name = "PHPLbl"
        Me.PHPLbl.Size = New System.Drawing.Size(81, 33)
        Me.PHPLbl.TabIndex = 59
        Me.PHPLbl.Text = "PHP "
        '
        'TotalItemsLb
        '
        Me.TotalItemsLb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TotalItemsLb.AutoSize = True
        Me.TotalItemsLb.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalItemsLb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalItemsLb.Location = New System.Drawing.Point(204, 530)
        Me.TotalItemsLb.Name = "TotalItemsLb"
        Me.TotalItemsLb.Size = New System.Drawing.Size(146, 33)
        Me.TotalItemsLb.TabIndex = 58
        Me.TotalItemsLb.Text = "(00 items)"
        '
        'OrderTotalLbl
        '
        Me.OrderTotalLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OrderTotalLbl.AutoSize = True
        Me.OrderTotalLbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTotalLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderTotalLbl.Location = New System.Drawing.Point(44, 531)
        Me.OrderTotalLbl.Name = "OrderTotalLbl"
        Me.OrderTotalLbl.Size = New System.Drawing.Size(169, 34)
        Me.OrderTotalLbl.TabIndex = 57
        Me.OrderTotalLbl.Text = "Order Total"
        '
        'CheckOutBtn
        '
        Me.CheckOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CheckOutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CheckOutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckOutBtn.FlatAppearance.BorderSize = 0
        Me.CheckOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckOutBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutBtn.ForeColor = System.Drawing.Color.White
        Me.CheckOutBtn.Location = New System.Drawing.Point(50, 625)
        Me.CheckOutBtn.Name = "CheckOutBtn"
        Me.CheckOutBtn.Size = New System.Drawing.Size(407, 44)
        Me.CheckOutBtn.TabIndex = 56
        Me.CheckOutBtn.Text = "Check out"
        Me.CheckOutBtn.UseVisualStyleBackColor = False
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.NameLbl.Location = New System.Drawing.Point(156, 188)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(0, 24)
        Me.NameLbl.TabIndex = 52
        '
        'CustomerAvatarPctrBx
        '
        Me.CustomerAvatarPctrBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomerAvatarPctrBx.Location = New System.Drawing.Point(50, 135)
        Me.CustomerAvatarPctrBx.Name = "CustomerAvatarPctrBx"
        Me.CustomerAvatarPctrBx.Size = New System.Drawing.Size(100, 100)
        Me.CustomerAvatarPctrBx.TabIndex = 51
        Me.CustomerAvatarPctrBx.TabStop = False
        '
        'CustomerIDLbl
        '
        Me.CustomerIDLbl.AutoSize = True
        Me.CustomerIDLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerIDLbl.Location = New System.Drawing.Point(156, 164)
        Me.CustomerIDLbl.Name = "CustomerIDLbl"
        Me.CustomerIDLbl.Size = New System.Drawing.Size(198, 24)
        Me.CustomerIDLbl.TabIndex = 50
        Me.CustomerIDLbl.Text = "CST-AAA-AAA-000"
        '
        'OrderIDLbl
        '
        Me.OrderIDLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.OrderIDLbl.Location = New System.Drawing.Point(143, 74)
        Me.OrderIDLbl.Name = "OrderIDLbl"
        Me.OrderIDLbl.Size = New System.Drawing.Size(251, 34)
        Me.OrderIDLbl.TabIndex = 48
        Me.OrderIDLbl.Text = "ORD-AAA-AAA-000"
        Me.OrderIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderLbl
        '
        Me.OrderLbl.AutoSize = True
        Me.OrderLbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderLbl.Location = New System.Drawing.Point(44, 72)
        Me.OrderLbl.Name = "OrderLbl"
        Me.OrderLbl.Size = New System.Drawing.Size(93, 34)
        Me.OrderLbl.TabIndex = 47
        Me.OrderLbl.Text = "Order"
        '
        'BackBtn
        '
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackBtn.FlatAppearance.BorderSize = 0
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Location = New System.Drawing.Point(20, 20)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(30, 30)
        Me.BackBtn.TabIndex = 36
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'OrdersCheckOutForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.OCDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrdersCheckOutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdersCheckOutForm"
        Me.OCDockPnl.ResumeLayout(False)
        Me.OrderItemsDockPnl.ResumeLayout(False)
        Me.OrderItemsPnl.ResumeLayout(False)
        Me.HeaderTblLyt.ResumeLayout(False)
        Me.HeaderTblLyt.PerformLayout()
        Me.SortDockPnl.ResumeLayout(False)
        Me.SortDockPnl.PerformLayout()
        Me.SortPnl.ResumeLayout(False)
        Me.OrderInfoPnl.ResumeLayout(False)
        Me.OrderInfoPnl.PerformLayout()
        CType(Me.CustomerAvatarPctrBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OCDockPnl As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents OrderInfoPnl As Panel
    Friend WithEvents PHPLbl As Label
    Friend WithEvents TotalItemsLb As Label
    Friend WithEvents OrderTotalLbl As Label
    Friend WithEvents CheckOutBtn As Button
    Friend WithEvents NameLbl As Label
    Friend WithEvents CustomerAvatarPctrBx As PictureBox
    Friend WithEvents CustomerIDLbl As Label
    Friend WithEvents OrderIDLbl As Label
    Friend WithEvents OrderLbl As Label
    Friend WithEvents OrderItemsDockPnl As Panel
    Friend WithEvents OrderItemsPnl As Panel
    Friend WithEvents OrderItemsTblLyt As TableLayoutPanel
    Friend WithEvents HeaderTblLyt As TableLayoutPanel
    Friend WithEvents QtyLbl As Label
    Friend WithEvents ItemNameLbl As Label
    Friend WithEvents ItemIDLbl As Label
    Friend WithEvents StockLbl As Label
    Friend WithEvents TotalLbl As Label
    Friend WithEvents SortDockPnl As Panel
    Friend WithEvents SortLbl As Label
    Friend WithEvents SortPnl As Panel
    Friend WithEvents SortCmbBx As ComboBox
End Class
