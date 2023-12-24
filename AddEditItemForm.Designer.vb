<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditItemForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditItemForm))
        Me.IContentPnl = New System.Windows.Forms.Panel()
        Me.SupplierDLbl = New System.Windows.Forms.Label()
        Me.WarningIndicatorLbl = New System.Windows.Forms.Label()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.StockTxtBxPnl = New System.Windows.Forms.Panel()
        Me.StockTxtBxPddng = New System.Windows.Forms.Panel()
        Me.StockTxtBx = New System.Windows.Forms.TextBox()
        Me.StockLbl = New System.Windows.Forms.Label()
        Me.PricePnl = New System.Windows.Forms.Panel()
        Me.PricePddng = New System.Windows.Forms.Panel()
        Me.PriceTxtBx = New System.Windows.Forms.TextBox()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.SupplierLbl = New System.Windows.Forms.Label()
        Me.SupplierPnl = New System.Windows.Forms.Panel()
        Me.SupplierCmbBx = New System.Windows.Forms.ComboBox()
        Me.CategoryLbl = New System.Windows.Forms.Label()
        Me.CategoryCmbBxPnl = New System.Windows.Forms.Panel()
        Me.CategoryCmbBx = New System.Windows.Forms.ComboBox()
        Me.CostTxtBxPnl = New System.Windows.Forms.Panel()
        Me.CostTxtBxPddng = New System.Windows.Forms.Panel()
        Me.CostTxtBx = New System.Windows.Forms.TextBox()
        Me.LnameLbl = New System.Windows.Forms.Label()
        Me.ItemTxtBxPnl = New System.Windows.Forms.Panel()
        Me.ItemTxtBxPddng = New System.Windows.Forms.Panel()
        Me.ItemTxtBx = New System.Windows.Forms.TextBox()
        Me.ItemLbl = New System.Windows.Forms.Label()
        Me.IPrimaryBtn = New System.Windows.Forms.Button()
        Me.IFormTitle = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Filler = New System.Windows.Forms.PictureBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.IContentPnl.SuspendLayout()
        Me.StockTxtBxPnl.SuspendLayout()
        Me.StockTxtBxPddng.SuspendLayout()
        Me.PricePnl.SuspendLayout()
        Me.PricePddng.SuspendLayout()
        Me.SupplierPnl.SuspendLayout()
        Me.CategoryCmbBxPnl.SuspendLayout()
        Me.CostTxtBxPnl.SuspendLayout()
        Me.CostTxtBxPddng.SuspendLayout()
        Me.ItemTxtBxPnl.SuspendLayout()
        Me.ItemTxtBxPddng.SuspendLayout()
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IContentPnl
        '
        Me.IContentPnl.Controls.Add(Me.SupplierDLbl)
        Me.IContentPnl.Controls.Add(Me.WarningIndicatorLbl)
        Me.IContentPnl.Controls.Add(Me.IDLbl)
        Me.IContentPnl.Controls.Add(Me.StockTxtBxPnl)
        Me.IContentPnl.Controls.Add(Me.StockLbl)
        Me.IContentPnl.Controls.Add(Me.PricePnl)
        Me.IContentPnl.Controls.Add(Me.PriceLbl)
        Me.IContentPnl.Controls.Add(Me.SupplierLbl)
        Me.IContentPnl.Controls.Add(Me.SupplierPnl)
        Me.IContentPnl.Controls.Add(Me.CategoryLbl)
        Me.IContentPnl.Controls.Add(Me.CategoryCmbBxPnl)
        Me.IContentPnl.Controls.Add(Me.CostTxtBxPnl)
        Me.IContentPnl.Controls.Add(Me.LnameLbl)
        Me.IContentPnl.Controls.Add(Me.ItemTxtBxPnl)
        Me.IContentPnl.Controls.Add(Me.ItemLbl)
        Me.IContentPnl.Controls.Add(Me.IPrimaryBtn)
        Me.IContentPnl.Controls.Add(Me.IFormTitle)
        Me.IContentPnl.Controls.Add(Me.BackBtn)
        Me.IContentPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.IContentPnl.Location = New System.Drawing.Point(0, 0)
        Me.IContentPnl.Name = "IContentPnl"
        Me.IContentPnl.Size = New System.Drawing.Size(727, 721)
        Me.IContentPnl.TabIndex = 0
        '
        'SupplierDLbl
        '
        Me.SupplierDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierDLbl.ForeColor = System.Drawing.Color.Red
        Me.SupplierDLbl.Location = New System.Drawing.Point(376, 305)
        Me.SupplierDLbl.Name = "SupplierDLbl"
        Me.SupplierDLbl.Size = New System.Drawing.Size(265, 22)
        Me.SupplierDLbl.TabIndex = 10
        Me.SupplierDLbl.Text = "Not Found"
        Me.SupplierDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WarningIndicatorLbl
        '
        Me.WarningIndicatorLbl.AutoSize = True
        Me.WarningIndicatorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningIndicatorLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningIndicatorLbl.Location = New System.Drawing.Point(92, 544)
        Me.WarningIndicatorLbl.Name = "WarningIndicatorLbl"
        Me.WarningIndicatorLbl.Size = New System.Drawing.Size(223, 20)
        Me.WarningIndicatorLbl.TabIndex = 17
        Me.WarningIndicatorLbl.Text = "* You have 1 warning(s) on this form"
        Me.WarningIndicatorLbl.Visible = False
        '
        'IDLbl
        '
        Me.IDLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.IDLbl.Location = New System.Drawing.Point(390, 62)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.Size = New System.Drawing.Size(251, 34)
        Me.IDLbl.TabIndex = 2
        Me.IDLbl.Text = "ITM-AAA-AAA-000"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IDLbl.Visible = False
        '
        'StockTxtBxPnl
        '
        Me.StockTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.StockTxtBxPnl.Controls.Add(Me.StockTxtBxPddng)
        Me.StockTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.StockTxtBxPnl.Location = New System.Drawing.Point(390, 238)
        Me.StockTxtBxPnl.Name = "StockTxtBxPnl"
        Me.StockTxtBxPnl.Size = New System.Drawing.Size(251, 38)
        Me.StockTxtBxPnl.TabIndex = 8
        '
        'StockTxtBxPddng
        '
        Me.StockTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.StockTxtBxPddng.Controls.Add(Me.StockTxtBx)
        Me.StockTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.StockTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.StockTxtBxPddng.Name = "StockTxtBxPddng"
        Me.StockTxtBxPddng.Size = New System.Drawing.Size(247, 34)
        Me.StockTxtBxPddng.TabIndex = 0
        '
        'StockTxtBx
        '
        Me.StockTxtBx.BackColor = System.Drawing.Color.White
        Me.StockTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StockTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.StockTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.StockTxtBx.Name = "StockTxtBx"
        Me.StockTxtBx.ShortcutsEnabled = False
        Me.StockTxtBx.Size = New System.Drawing.Size(241, 25)
        Me.StockTxtBx.TabIndex = 0
        '
        'StockLbl
        '
        Me.StockLbl.AutoSize = True
        Me.StockLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.StockLbl.Location = New System.Drawing.Point(396, 213)
        Me.StockLbl.Name = "StockLbl"
        Me.StockLbl.Size = New System.Drawing.Size(58, 22)
        Me.StockLbl.TabIndex = 7
        Me.StockLbl.Text = "Stock"
        '
        'PricePnl
        '
        Me.PricePnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PricePnl.Controls.Add(Me.PricePddng)
        Me.PricePnl.ForeColor = System.Drawing.Color.Chocolate
        Me.PricePnl.Location = New System.Drawing.Point(390, 425)
        Me.PricePnl.Name = "PricePnl"
        Me.PricePnl.Size = New System.Drawing.Size(251, 38)
        Me.PricePnl.TabIndex = 15
        '
        'PricePddng
        '
        Me.PricePddng.BackColor = System.Drawing.Color.White
        Me.PricePddng.Controls.Add(Me.PriceTxtBx)
        Me.PricePddng.ForeColor = System.Drawing.Color.Chocolate
        Me.PricePddng.Location = New System.Drawing.Point(2, 2)
        Me.PricePddng.Name = "PricePddng"
        Me.PricePddng.Size = New System.Drawing.Size(247, 34)
        Me.PricePddng.TabIndex = 0
        '
        'PriceTxtBx
        '
        Me.PriceTxtBx.BackColor = System.Drawing.Color.White
        Me.PriceTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PriceTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PriceTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.PriceTxtBx.Name = "PriceTxtBx"
        Me.PriceTxtBx.ShortcutsEnabled = False
        Me.PriceTxtBx.Size = New System.Drawing.Size(241, 25)
        Me.PriceTxtBx.TabIndex = 0
        '
        'PriceLbl
        '
        Me.PriceLbl.AutoSize = True
        Me.PriceLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PriceLbl.Location = New System.Drawing.Point(391, 400)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(54, 22)
        Me.PriceLbl.TabIndex = 14
        Me.PriceLbl.Text = "Price"
        '
        'SupplierLbl
        '
        Me.SupplierLbl.AutoSize = True
        Me.SupplierLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SupplierLbl.Location = New System.Drawing.Point(92, 305)
        Me.SupplierLbl.Name = "SupplierLbl"
        Me.SupplierLbl.Size = New System.Drawing.Size(80, 22)
        Me.SupplierLbl.TabIndex = 9
        Me.SupplierLbl.Text = "Supplier"
        '
        'SupplierPnl
        '
        Me.SupplierPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SupplierPnl.Controls.Add(Me.SupplierCmbBx)
        Me.SupplierPnl.Location = New System.Drawing.Point(91, 330)
        Me.SupplierPnl.Name = "SupplierPnl"
        Me.SupplierPnl.Size = New System.Drawing.Size(550, 36)
        Me.SupplierPnl.TabIndex = 11
        '
        'SupplierCmbBx
        '
        Me.SupplierCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SupplierCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SupplierCmbBx.BackColor = System.Drawing.Color.White
        Me.SupplierCmbBx.Enabled = False
        Me.SupplierCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SupplierCmbBx.FormattingEnabled = True
        Me.SupplierCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.SupplierCmbBx.Name = "SupplierCmbBx"
        Me.SupplierCmbBx.Size = New System.Drawing.Size(546, 32)
        Me.SupplierCmbBx.TabIndex = 0
        '
        'CategoryLbl
        '
        Me.CategoryLbl.AutoSize = True
        Me.CategoryLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryLbl.Location = New System.Drawing.Point(92, 213)
        Me.CategoryLbl.Name = "CategoryLbl"
        Me.CategoryLbl.Size = New System.Drawing.Size(87, 22)
        Me.CategoryLbl.TabIndex = 5
        Me.CategoryLbl.Text = "Category"
        '
        'CategoryCmbBxPnl
        '
        Me.CategoryCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryCmbBxPnl.Controls.Add(Me.CategoryCmbBx)
        Me.CategoryCmbBxPnl.Location = New System.Drawing.Point(91, 238)
        Me.CategoryCmbBxPnl.Name = "CategoryCmbBxPnl"
        Me.CategoryCmbBxPnl.Size = New System.Drawing.Size(251, 36)
        Me.CategoryCmbBxPnl.TabIndex = 6
        '
        'CategoryCmbBx
        '
        Me.CategoryCmbBx.BackColor = System.Drawing.Color.White
        Me.CategoryCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoryCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryCmbBx.FormattingEnabled = True
        Me.CategoryCmbBx.Items.AddRange(New Object() {"Branded", "Galenicals", "Generic", "Milk Supplements"})
        Me.CategoryCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.CategoryCmbBx.Name = "CategoryCmbBx"
        Me.CategoryCmbBx.Size = New System.Drawing.Size(247, 32)
        Me.CategoryCmbBx.TabIndex = 0
        '
        'CostTxtBxPnl
        '
        Me.CostTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CostTxtBxPnl.Controls.Add(Me.CostTxtBxPddng)
        Me.CostTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.CostTxtBxPnl.Location = New System.Drawing.Point(91, 425)
        Me.CostTxtBxPnl.Name = "CostTxtBxPnl"
        Me.CostTxtBxPnl.Size = New System.Drawing.Size(251, 38)
        Me.CostTxtBxPnl.TabIndex = 13
        '
        'CostTxtBxPddng
        '
        Me.CostTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.CostTxtBxPddng.Controls.Add(Me.CostTxtBx)
        Me.CostTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.CostTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.CostTxtBxPddng.Name = "CostTxtBxPddng"
        Me.CostTxtBxPddng.Size = New System.Drawing.Size(247, 34)
        Me.CostTxtBxPddng.TabIndex = 0
        '
        'CostTxtBx
        '
        Me.CostTxtBx.BackColor = System.Drawing.Color.White
        Me.CostTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CostTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CostTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.CostTxtBx.Name = "CostTxtBx"
        Me.CostTxtBx.ShortcutsEnabled = False
        Me.CostTxtBx.Size = New System.Drawing.Size(241, 25)
        Me.CostTxtBx.TabIndex = 0
        '
        'LnameLbl
        '
        Me.LnameLbl.AutoSize = True
        Me.LnameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LnameLbl.Location = New System.Drawing.Point(92, 400)
        Me.LnameLbl.Name = "LnameLbl"
        Me.LnameLbl.Size = New System.Drawing.Size(50, 22)
        Me.LnameLbl.TabIndex = 12
        Me.LnameLbl.Text = "Cost"
        '
        'ItemTxtBxPnl
        '
        Me.ItemTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemTxtBxPnl.Controls.Add(Me.ItemTxtBxPddng)
        Me.ItemTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.ItemTxtBxPnl.Location = New System.Drawing.Point(91, 147)
        Me.ItemTxtBxPnl.Name = "ItemTxtBxPnl"
        Me.ItemTxtBxPnl.Size = New System.Drawing.Size(550, 38)
        Me.ItemTxtBxPnl.TabIndex = 4
        '
        'ItemTxtBxPddng
        '
        Me.ItemTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.ItemTxtBxPddng.Controls.Add(Me.ItemTxtBx)
        Me.ItemTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.ItemTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.ItemTxtBxPddng.Name = "ItemTxtBxPddng"
        Me.ItemTxtBxPddng.Size = New System.Drawing.Size(546, 34)
        Me.ItemTxtBxPddng.TabIndex = 0
        '
        'ItemTxtBx
        '
        Me.ItemTxtBx.BackColor = System.Drawing.Color.White
        Me.ItemTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.ItemTxtBx.Name = "ItemTxtBx"
        Me.ItemTxtBx.Size = New System.Drawing.Size(540, 25)
        Me.ItemTxtBx.TabIndex = 0
        '
        'ItemLbl
        '
        Me.ItemLbl.AutoSize = True
        Me.ItemLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemLbl.Location = New System.Drawing.Point(92, 122)
        Me.ItemLbl.Name = "ItemLbl"
        Me.ItemLbl.Size = New System.Drawing.Size(48, 22)
        Me.ItemLbl.TabIndex = 3
        Me.ItemLbl.Text = "Item"
        '
        'IPrimaryBtn
        '
        Me.IPrimaryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.IPrimaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IPrimaryBtn.FlatAppearance.BorderSize = 0
        Me.IPrimaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IPrimaryBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPrimaryBtn.ForeColor = System.Drawing.Color.White
        Me.IPrimaryBtn.Location = New System.Drawing.Point(91, 497)
        Me.IPrimaryBtn.Name = "IPrimaryBtn"
        Me.IPrimaryBtn.Size = New System.Drawing.Size(550, 44)
        Me.IPrimaryBtn.TabIndex = 16
        Me.IPrimaryBtn.Text = "Create"
        Me.IPrimaryBtn.UseVisualStyleBackColor = False
        '
        'IFormTitle
        '
        Me.IFormTitle.AutoSize = True
        Me.IFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.IFormTitle.Location = New System.Drawing.Point(85, 62)
        Me.IFormTitle.Name = "IFormTitle"
        Me.IFormTitle.Size = New System.Drawing.Size(143, 34)
        Me.IFormTitle.TabIndex = 1
        Me.IFormTitle.Text = "New Item"
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
        Me.BackBtn.TabIndex = 0
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'Filler
        '
        Me.Filler.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Filler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Filler.Location = New System.Drawing.Point(727, 0)
        Me.Filler.Name = "Filler"
        Me.Filler.Size = New System.Drawing.Size(457, 721)
        Me.Filler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Filler.TabIndex = 21
        Me.Filler.TabStop = False
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'AddEditItemForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.Filler)
        Me.Controls.Add(Me.IContentPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEditItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEditItemForm"
        Me.IContentPnl.ResumeLayout(False)
        Me.IContentPnl.PerformLayout()
        Me.StockTxtBxPnl.ResumeLayout(False)
        Me.StockTxtBxPddng.ResumeLayout(False)
        Me.StockTxtBxPddng.PerformLayout()
        Me.PricePnl.ResumeLayout(False)
        Me.PricePddng.ResumeLayout(False)
        Me.PricePddng.PerformLayout()
        Me.SupplierPnl.ResumeLayout(False)
        Me.CategoryCmbBxPnl.ResumeLayout(False)
        Me.CostTxtBxPnl.ResumeLayout(False)
        Me.CostTxtBxPddng.ResumeLayout(False)
        Me.CostTxtBxPddng.PerformLayout()
        Me.ItemTxtBxPnl.ResumeLayout(False)
        Me.ItemTxtBxPddng.ResumeLayout(False)
        Me.ItemTxtBxPddng.PerformLayout()
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Filler As PictureBox
    Friend WithEvents IContentPnl As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents WarningIndicatorLbl As Label
    Friend WithEvents IDLbl As Label
    Friend WithEvents StockTxtBxPnl As Panel
    Friend WithEvents StockTxtBxPddng As Panel
    Friend WithEvents StockTxtBx As TextBox
    Friend WithEvents StockLbl As Label
    Friend WithEvents PricePnl As Panel
    Friend WithEvents PricePddng As Panel
    Friend WithEvents PriceTxtBx As TextBox
    Friend WithEvents PriceLbl As Label
    Friend WithEvents SupplierLbl As Label
    Friend WithEvents SupplierPnl As Panel
    Friend WithEvents SupplierCmbBx As ComboBox
    Friend WithEvents CategoryLbl As Label
    Friend WithEvents CategoryCmbBxPnl As Panel
    Friend WithEvents CategoryCmbBx As ComboBox
    Friend WithEvents CostTxtBxPnl As Panel
    Friend WithEvents CostTxtBxPddng As Panel
    Friend WithEvents CostTxtBx As TextBox
    Friend WithEvents LnameLbl As Label
    Friend WithEvents ItemTxtBxPnl As Panel
    Friend WithEvents ItemTxtBxPddng As Panel
    Friend WithEvents ItemTxtBx As TextBox
    Friend WithEvents ItemLbl As Label
    Friend WithEvents IPrimaryBtn As Button
    Friend WithEvents IFormTitle As Label
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents SupplierDLbl As Label
End Class
