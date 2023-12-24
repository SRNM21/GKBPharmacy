<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplyItemsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplyItemsForm))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PHPLbl = New System.Windows.Forms.Label()
        Me.TotalItemsLb = New System.Windows.Forms.Label()
        Me.OrderTotalLbl = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.SuppIDLbl = New System.Windows.Forms.Label()
        Me.OrderInfoPnl = New System.Windows.Forms.Panel()
        Me.PricePHPLbl = New System.Windows.Forms.Label()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.ClearOrderBtn = New System.Windows.Forms.Button()
        Me.SupplyItemIDLbl = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.QtyTxtBxPnl = New System.Windows.Forms.Panel()
        Me.QtyTxtBxPddng = New System.Windows.Forms.Panel()
        Me.QtyTxtBx = New System.Windows.Forms.TextBox()
        Me.QtyIncreaseBtn = New System.Windows.Forms.Button()
        Me.QtyDecreaseBtn = New System.Windows.Forms.Button()
        Me.QuantityLbl = New System.Windows.Forms.Label()
        Me.ItemCmbBxPnl = New System.Windows.Forms.Panel()
        Me.ItemCmbBx = New System.Windows.Forms.ComboBox()
        Me.ItemLbl = New System.Windows.Forms.Label()
        Me.CategoryLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.SortDockPnl = New System.Windows.Forms.Panel()
        Me.OrderItemsDockPnl = New System.Windows.Forms.Panel()
        Me.OrderBtnPnl = New System.Windows.Forms.Panel()
        Me.OCDockPnl = New System.Windows.Forms.Panel()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.WarningIndicatorLbl = New System.Windows.Forms.Label()
        Me.ODGV = New System.Windows.Forms.DataGridView()
        Me.item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.OrderInfoPnl.SuspendLayout()
        Me.QtyTxtBxPnl.SuspendLayout()
        Me.QtyTxtBxPddng.SuspendLayout()
        Me.ItemCmbBxPnl.SuspendLayout()
        Me.OrderItemsDockPnl.SuspendLayout()
        Me.OrderBtnPnl.SuspendLayout()
        Me.OCDockPnl.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ODGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PHPLbl
        '
        Me.PHPLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PHPLbl.AutoSize = True
        Me.PHPLbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHPLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PHPLbl.Location = New System.Drawing.Point(44, 628)
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
        Me.TotalItemsLb.Location = New System.Drawing.Point(219, 583)
        Me.TotalItemsLb.Name = "TotalItemsLb"
        Me.TotalItemsLb.Size = New System.Drawing.Size(130, 33)
        Me.TotalItemsLb.TabIndex = 58
        Me.TotalItemsLb.Text = "(0 items)"
        '
        'OrderTotalLbl
        '
        Me.OrderTotalLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OrderTotalLbl.AutoSize = True
        Me.OrderTotalLbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTotalLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderTotalLbl.Location = New System.Drawing.Point(44, 583)
        Me.OrderTotalLbl.Name = "OrderTotalLbl"
        Me.OrderTotalLbl.Size = New System.Drawing.Size(169, 34)
        Me.OrderTotalLbl.TabIndex = 57
        Me.OrderTotalLbl.Text = "Order Total"
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.NameLbl.Location = New System.Drawing.Point(46, 110)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(0, 24)
        Me.NameLbl.TabIndex = 52
        '
        'SuppIDLbl
        '
        Me.SuppIDLbl.AutoSize = True
        Me.SuppIDLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SuppIDLbl.Location = New System.Drawing.Point(46, 86)
        Me.SuppIDLbl.Name = "SuppIDLbl"
        Me.SuppIDLbl.Size = New System.Drawing.Size(199, 24)
        Me.SuppIDLbl.TabIndex = 50
        Me.SuppIDLbl.Text = "SUP-AAA-AAA-000"
        '
        'OrderInfoPnl
        '
        Me.OrderInfoPnl.Controls.Add(Me.WarningIndicatorLbl)
        Me.OrderInfoPnl.Controls.Add(Me.PricePHPLbl)
        Me.OrderInfoPnl.Controls.Add(Me.PriceLbl)
        Me.OrderInfoPnl.Controls.Add(Me.ClearOrderBtn)
        Me.OrderInfoPnl.Controls.Add(Me.SupplyItemIDLbl)
        Me.OrderInfoPnl.Controls.Add(Me.AddBtn)
        Me.OrderInfoPnl.Controls.Add(Me.RemoveBtn)
        Me.OrderInfoPnl.Controls.Add(Me.QtyTxtBxPnl)
        Me.OrderInfoPnl.Controls.Add(Me.QtyIncreaseBtn)
        Me.OrderInfoPnl.Controls.Add(Me.QtyDecreaseBtn)
        Me.OrderInfoPnl.Controls.Add(Me.QuantityLbl)
        Me.OrderInfoPnl.Controls.Add(Me.ItemCmbBxPnl)
        Me.OrderInfoPnl.Controls.Add(Me.ItemLbl)
        Me.OrderInfoPnl.Controls.Add(Me.CategoryLbl)
        Me.OrderInfoPnl.Controls.Add(Me.PHPLbl)
        Me.OrderInfoPnl.Controls.Add(Me.TotalItemsLb)
        Me.OrderInfoPnl.Controls.Add(Me.OrderTotalLbl)
        Me.OrderInfoPnl.Controls.Add(Me.NameLbl)
        Me.OrderInfoPnl.Controls.Add(Me.SuppIDLbl)
        Me.OrderInfoPnl.Controls.Add(Me.BackBtn)
        Me.OrderInfoPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.OrderInfoPnl.Location = New System.Drawing.Point(0, 0)
        Me.OrderInfoPnl.Name = "OrderInfoPnl"
        Me.OrderInfoPnl.Size = New System.Drawing.Size(585, 721)
        Me.OrderInfoPnl.TabIndex = 37
        '
        'PricePHPLbl
        '
        Me.PricePHPLbl.AutoSize = True
        Me.PricePHPLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PricePHPLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PricePHPLbl.Location = New System.Drawing.Point(121, 363)
        Me.PricePHPLbl.Name = "PricePHPLbl"
        Me.PricePHPLbl.Size = New System.Drawing.Size(0, 24)
        Me.PricePHPLbl.TabIndex = 69
        '
        'PriceLbl
        '
        Me.PriceLbl.AutoSize = True
        Me.PriceLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PriceLbl.Location = New System.Drawing.Point(51, 365)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(64, 22)
        Me.PriceLbl.TabIndex = 68
        Me.PriceLbl.Text = "Price: "
        '
        'ClearOrderBtn
        '
        Me.ClearOrderBtn.BackColor = System.Drawing.Color.White
        Me.ClearOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClearOrderBtn.FlatAppearance.BorderSize = 2
        Me.ClearOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearOrderBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearOrderBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClearOrderBtn.Location = New System.Drawing.Point(50, 434)
        Me.ClearOrderBtn.Name = "ClearOrderBtn"
        Me.ClearOrderBtn.Size = New System.Drawing.Size(224, 44)
        Me.ClearOrderBtn.TabIndex = 70
        Me.ClearOrderBtn.Text = "Clear Order"
        Me.ClearOrderBtn.UseVisualStyleBackColor = False
        '
        'SupplyItemIDLbl
        '
        Me.SupplyItemIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplyItemIDLbl.ForeColor = System.Drawing.Color.Red
        Me.SupplyItemIDLbl.Location = New System.Drawing.Point(262, 186)
        Me.SupplyItemIDLbl.Name = "SupplyItemIDLbl"
        Me.SupplyItemIDLbl.Size = New System.Drawing.Size(255, 22)
        Me.SupplyItemIDLbl.TabIndex = 62
        Me.SupplyItemIDLbl.Text = "Not Found"
        Me.SupplyItemIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(50, 493)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(467, 44)
        Me.AddBtn.TabIndex = 72
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'RemoveBtn
        '
        Me.RemoveBtn.BackColor = System.Drawing.Color.White
        Me.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.RemoveBtn.FlatAppearance.BorderSize = 2
        Me.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.RemoveBtn.Location = New System.Drawing.Point(293, 434)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(224, 44)
        Me.RemoveBtn.TabIndex = 71
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.UseVisualStyleBackColor = False
        '
        'QtyTxtBxPnl
        '
        Me.QtyTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyTxtBxPnl.Controls.Add(Me.QtyTxtBxPddng)
        Me.QtyTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.QtyTxtBxPnl.Location = New System.Drawing.Point(189, 285)
        Me.QtyTxtBxPnl.Name = "QtyTxtBxPnl"
        Me.QtyTxtBxPnl.Size = New System.Drawing.Size(63, 38)
        Me.QtyTxtBxPnl.TabIndex = 66
        '
        'QtyTxtBxPddng
        '
        Me.QtyTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.QtyTxtBxPddng.Controls.Add(Me.QtyTxtBx)
        Me.QtyTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.QtyTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.QtyTxtBxPddng.Name = "QtyTxtBxPddng"
        Me.QtyTxtBxPddng.Size = New System.Drawing.Size(59, 34)
        Me.QtyTxtBxPddng.TabIndex = 0
        '
        'QtyTxtBx
        '
        Me.QtyTxtBx.BackColor = System.Drawing.Color.White
        Me.QtyTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QtyTxtBx.Enabled = False
        Me.QtyTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.QtyTxtBx.Name = "QtyTxtBx"
        Me.QtyTxtBx.ShortcutsEnabled = False
        Me.QtyTxtBx.Size = New System.Drawing.Size(53, 25)
        Me.QtyTxtBx.TabIndex = 0
        Me.QtyTxtBx.Text = "1"
        Me.QtyTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QtyIncreaseBtn
        '
        Me.QtyIncreaseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyIncreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QtyIncreaseBtn.FlatAppearance.BorderSize = 0
        Me.QtyIncreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QtyIncreaseBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyIncreaseBtn.ForeColor = System.Drawing.Color.White
        Me.QtyIncreaseBtn.Location = New System.Drawing.Point(258, 285)
        Me.QtyIncreaseBtn.Name = "QtyIncreaseBtn"
        Me.QtyIncreaseBtn.Size = New System.Drawing.Size(38, 38)
        Me.QtyIncreaseBtn.TabIndex = 67
        Me.QtyIncreaseBtn.Text = "+"
        Me.QtyIncreaseBtn.UseVisualStyleBackColor = False
        '
        'QtyDecreaseBtn
        '
        Me.QtyDecreaseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyDecreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QtyDecreaseBtn.FlatAppearance.BorderSize = 0
        Me.QtyDecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QtyDecreaseBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyDecreaseBtn.ForeColor = System.Drawing.Color.White
        Me.QtyDecreaseBtn.Location = New System.Drawing.Point(145, 285)
        Me.QtyDecreaseBtn.Name = "QtyDecreaseBtn"
        Me.QtyDecreaseBtn.Size = New System.Drawing.Size(38, 38)
        Me.QtyDecreaseBtn.TabIndex = 65
        Me.QtyDecreaseBtn.Text = "-"
        Me.QtyDecreaseBtn.UseVisualStyleBackColor = False
        '
        'QuantityLbl
        '
        Me.QuantityLbl.AutoSize = True
        Me.QuantityLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QuantityLbl.Location = New System.Drawing.Point(51, 293)
        Me.QuantityLbl.Name = "QuantityLbl"
        Me.QuantityLbl.Size = New System.Drawing.Size(88, 22)
        Me.QuantityLbl.TabIndex = 64
        Me.QuantityLbl.Text = "Quantity: "
        '
        'ItemCmbBxPnl
        '
        Me.ItemCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemCmbBxPnl.Controls.Add(Me.ItemCmbBx)
        Me.ItemCmbBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.ItemCmbBxPnl.Location = New System.Drawing.Point(50, 211)
        Me.ItemCmbBxPnl.Name = "ItemCmbBxPnl"
        Me.ItemCmbBxPnl.Size = New System.Drawing.Size(467, 36)
        Me.ItemCmbBxPnl.TabIndex = 63
        '
        'ItemCmbBx
        '
        Me.ItemCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ItemCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ItemCmbBx.BackColor = System.Drawing.Color.White
        Me.ItemCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemCmbBx.FormattingEnabled = True
        Me.ItemCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.ItemCmbBx.Name = "ItemCmbBx"
        Me.ItemCmbBx.Size = New System.Drawing.Size(463, 32)
        Me.ItemCmbBx.TabIndex = 0
        '
        'ItemLbl
        '
        Me.ItemLbl.AutoSize = True
        Me.ItemLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemLbl.Location = New System.Drawing.Point(51, 186)
        Me.ItemLbl.Name = "ItemLbl"
        Me.ItemLbl.Size = New System.Drawing.Size(48, 22)
        Me.ItemLbl.TabIndex = 61
        Me.ItemLbl.Text = "Item"
        '
        'CategoryLbl
        '
        Me.CategoryLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.CategoryLbl.Location = New System.Drawing.Point(293, 80)
        Me.CategoryLbl.Name = "CategoryLbl"
        Me.CategoryLbl.Size = New System.Drawing.Size(224, 34)
        Me.CategoryLbl.TabIndex = 60
        Me.CategoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'SortDockPnl
        '
        Me.SortDockPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.SortDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.SortDockPnl.Name = "SortDockPnl"
        Me.SortDockPnl.Size = New System.Drawing.Size(549, 50)
        Me.SortDockPnl.TabIndex = 0
        '
        'OrderItemsDockPnl
        '
        Me.OrderItemsDockPnl.Controls.Add(Me.ODGV)
        Me.OrderItemsDockPnl.Controls.Add(Me.OrderBtnPnl)
        Me.OrderItemsDockPnl.Controls.Add(Me.SortDockPnl)
        Me.OrderItemsDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderItemsDockPnl.Location = New System.Drawing.Point(585, 0)
        Me.OrderItemsDockPnl.Name = "OrderItemsDockPnl"
        Me.OrderItemsDockPnl.Padding = New System.Windows.Forms.Padding(0, 0, 50, 50)
        Me.OrderItemsDockPnl.Size = New System.Drawing.Size(599, 721)
        Me.OrderItemsDockPnl.TabIndex = 38
        '
        'OrderBtnPnl
        '
        Me.OrderBtnPnl.Controls.Add(Me.OrderBtn)
        Me.OrderBtnPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OrderBtnPnl.Location = New System.Drawing.Point(0, 594)
        Me.OrderBtnPnl.Name = "OrderBtnPnl"
        Me.OrderBtnPnl.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.OrderBtnPnl.Size = New System.Drawing.Size(549, 77)
        Me.OrderBtnPnl.TabIndex = 1
        '
        'OCDockPnl
        '
        Me.OCDockPnl.Controls.Add(Me.OrderItemsDockPnl)
        Me.OCDockPnl.Controls.Add(Me.OrderInfoPnl)
        Me.OCDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OCDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.OCDockPnl.Name = "OCDockPnl"
        Me.OCDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.OCDockPnl.TabIndex = 1
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'WarningIndicatorLbl
        '
        Me.WarningIndicatorLbl.AutoSize = True
        Me.WarningIndicatorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningIndicatorLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningIndicatorLbl.Location = New System.Drawing.Point(51, 540)
        Me.WarningIndicatorLbl.Name = "WarningIndicatorLbl"
        Me.WarningIndicatorLbl.Size = New System.Drawing.Size(223, 20)
        Me.WarningIndicatorLbl.TabIndex = 73
        Me.WarningIndicatorLbl.Text = "* You have 1 warning(s) on this form"
        Me.WarningIndicatorLbl.Visible = False
        '
        'ODGV
        '
        Me.ODGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ODGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ODGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ODGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ODGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.ODGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ODGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_id, Me.item_name, Me.qty, Me.total})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ODGV.DefaultCellStyle = DataGridViewCellStyle16
        Me.ODGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ODGV.EnableHeadersVisualStyles = False
        Me.ODGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ODGV.Location = New System.Drawing.Point(0, 50)
        Me.ODGV.Name = "ODGV"
        Me.ODGV.ReadOnly = True
        Me.ODGV.RowHeadersVisible = False
        Me.ODGV.Size = New System.Drawing.Size(549, 544)
        Me.ODGV.TabIndex = 2
        '
        'item_id
        '
        Me.item_id.FillWeight = 99.61929!
        Me.item_id.HeaderText = "item_id"
        Me.item_id.Name = "item_id"
        Me.item_id.ReadOnly = True
        '
        'item_name
        '
        Me.item_name.FillWeight = 99.61929!
        Me.item_name.HeaderText = "item_name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        '
        'qty
        '
        Me.qty.FillWeight = 101.5229!
        Me.qty.HeaderText = "qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'total
        '
        Me.total.FillWeight = 99.61929!
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'OrderBtn
        '
        Me.OrderBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderBtn.FlatAppearance.BorderSize = 0
        Me.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderBtn.ForeColor = System.Drawing.Color.White
        Me.OrderBtn.Location = New System.Drawing.Point(0, 30)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Size = New System.Drawing.Size(549, 47)
        Me.OrderBtn.TabIndex = 57
        Me.OrderBtn.Text = "Order"
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'SupplyItemsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.OCDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SupplyItemsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SupplyItemsForm"
        Me.OrderInfoPnl.ResumeLayout(False)
        Me.OrderInfoPnl.PerformLayout()
        Me.QtyTxtBxPnl.ResumeLayout(False)
        Me.QtyTxtBxPddng.ResumeLayout(False)
        Me.QtyTxtBxPddng.PerformLayout()
        Me.ItemCmbBxPnl.ResumeLayout(False)
        Me.OrderItemsDockPnl.ResumeLayout(False)
        Me.OrderBtnPnl.ResumeLayout(False)
        Me.OCDockPnl.ResumeLayout(False)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ODGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PHPLbl As Label
    Friend WithEvents TotalItemsLb As Label
    Friend WithEvents OrderTotalLbl As Label
    Friend WithEvents NameLbl As Label
    Friend WithEvents SuppIDLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents OrderInfoPnl As Panel
    Friend WithEvents SortDockPnl As Panel
    Friend WithEvents OrderItemsDockPnl As Panel
    Friend WithEvents OCDockPnl As Panel
    Friend WithEvents CategoryLbl As Label
    Friend WithEvents PricePHPLbl As Label
    Friend WithEvents PriceLbl As Label
    Friend WithEvents ClearOrderBtn As Button
    Friend WithEvents SupplyItemIDLbl As Label
    Friend WithEvents AddBtn As Button
    Friend WithEvents RemoveBtn As Button
    Friend WithEvents QtyTxtBxPnl As Panel
    Friend WithEvents QtyTxtBxPddng As Panel
    Friend WithEvents QtyTxtBx As TextBox
    Friend WithEvents QtyIncreaseBtn As Button
    Friend WithEvents QtyDecreaseBtn As Button
    Friend WithEvents QuantityLbl As Label
    Friend WithEvents ItemCmbBxPnl As Panel
    Friend WithEvents ItemCmbBx As ComboBox
    Friend WithEvents ItemLbl As Label
    Friend WithEvents OrderBtnPnl As Panel
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents WarningIndicatorLbl As Label
    Friend WithEvents ODGV As DataGridView
    Friend WithEvents item_id As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents OrderBtn As Button
End Class
