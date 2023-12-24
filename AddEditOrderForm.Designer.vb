<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditOrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditOrderForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AContentPnl = New System.Windows.Forms.Panel()
        Me.HeaderFormPnl = New System.Windows.Forms.Panel()
        Me.PricePHPLbl = New System.Windows.Forms.Label()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.ClearOrderBtn = New System.Windows.Forms.Button()
        Me.ItemIDLbl = New System.Windows.Forms.Label()
        Me.CustomerIDLbl = New System.Windows.Forms.Label()
        Me.CustomerCmbBxPnl = New System.Windows.Forms.Panel()
        Me.CustomerCmbBx = New System.Windows.Forms.ComboBox()
        Me.CustomerLbl = New System.Windows.Forms.Label()
        Me.WarningIndicatorLbl = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.QtyTxtBxPnl = New System.Windows.Forms.Panel()
        Me.QtyTxtBxPddng = New System.Windows.Forms.Panel()
        Me.QtyTxtBx = New System.Windows.Forms.TextBox()
        Me.QtyIncreaseBtn = New System.Windows.Forms.Button()
        Me.QtyDecreaseBtn = New System.Windows.Forms.Button()
        Me.QtyLbl = New System.Windows.Forms.Label()
        Me.CategoryCmbBxPnl = New System.Windows.Forms.Panel()
        Me.CategoryCmbBx = New System.Windows.Forms.ComboBox()
        Me.ItemCmbBxPnl = New System.Windows.Forms.Panel()
        Me.ItemCmbBx = New System.Windows.Forms.ComboBox()
        Me.OPrimaryBtn = New System.Windows.Forms.Button()
        Me.ItemLbl = New System.Windows.Forms.Label()
        Me.CategoryLbl = New System.Windows.Forms.Label()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.OFormTitle = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.ODGVPnl = New System.Windows.Forms.Panel()
        Me.ODGVOrdersPnl = New System.Windows.Forms.Panel()
        Me.ODGV = New System.Windows.Forms.DataGridView()
        Me.item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountPnl = New System.Windows.Forms.Panel()
        Me.TotalAmountPHPLbl = New System.Windows.Forms.Label()
        Me.TotalAmountLbl = New System.Windows.Forms.Label()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AContentPnl.SuspendLayout()
        Me.HeaderFormPnl.SuspendLayout()
        Me.CustomerCmbBxPnl.SuspendLayout()
        Me.QtyTxtBxPnl.SuspendLayout()
        Me.QtyTxtBxPddng.SuspendLayout()
        Me.CategoryCmbBxPnl.SuspendLayout()
        Me.ItemCmbBxPnl.SuspendLayout()
        Me.ODGVPnl.SuspendLayout()
        Me.ODGVOrdersPnl.SuspendLayout()
        CType(Me.ODGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TotalAmountPnl.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AContentPnl
        '
        Me.AContentPnl.Controls.Add(Me.HeaderFormPnl)
        Me.AContentPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.AContentPnl.Location = New System.Drawing.Point(0, 0)
        Me.AContentPnl.Name = "AContentPnl"
        Me.AContentPnl.Size = New System.Drawing.Size(727, 721)
        Me.AContentPnl.TabIndex = 18
        '
        'HeaderFormPnl
        '
        Me.HeaderFormPnl.Controls.Add(Me.PricePHPLbl)
        Me.HeaderFormPnl.Controls.Add(Me.PriceLbl)
        Me.HeaderFormPnl.Controls.Add(Me.ClearOrderBtn)
        Me.HeaderFormPnl.Controls.Add(Me.ItemIDLbl)
        Me.HeaderFormPnl.Controls.Add(Me.CustomerIDLbl)
        Me.HeaderFormPnl.Controls.Add(Me.CustomerCmbBxPnl)
        Me.HeaderFormPnl.Controls.Add(Me.CustomerLbl)
        Me.HeaderFormPnl.Controls.Add(Me.WarningIndicatorLbl)
        Me.HeaderFormPnl.Controls.Add(Me.AddBtn)
        Me.HeaderFormPnl.Controls.Add(Me.RemoveBtn)
        Me.HeaderFormPnl.Controls.Add(Me.QtyTxtBxPnl)
        Me.HeaderFormPnl.Controls.Add(Me.QtyIncreaseBtn)
        Me.HeaderFormPnl.Controls.Add(Me.QtyDecreaseBtn)
        Me.HeaderFormPnl.Controls.Add(Me.QtyLbl)
        Me.HeaderFormPnl.Controls.Add(Me.CategoryCmbBxPnl)
        Me.HeaderFormPnl.Controls.Add(Me.ItemCmbBxPnl)
        Me.HeaderFormPnl.Controls.Add(Me.OPrimaryBtn)
        Me.HeaderFormPnl.Controls.Add(Me.ItemLbl)
        Me.HeaderFormPnl.Controls.Add(Me.CategoryLbl)
        Me.HeaderFormPnl.Controls.Add(Me.IDLbl)
        Me.HeaderFormPnl.Controls.Add(Me.OFormTitle)
        Me.HeaderFormPnl.Controls.Add(Me.BackBtn)
        Me.HeaderFormPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.HeaderFormPnl.Location = New System.Drawing.Point(0, 0)
        Me.HeaderFormPnl.Name = "HeaderFormPnl"
        Me.HeaderFormPnl.Size = New System.Drawing.Size(727, 721)
        Me.HeaderFormPnl.TabIndex = 0
        '
        'PricePHPLbl
        '
        Me.PricePHPLbl.AutoSize = True
        Me.PricePHPLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PricePHPLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PricePHPLbl.Location = New System.Drawing.Point(162, 480)
        Me.PricePHPLbl.Name = "PricePHPLbl"
        Me.PricePHPLbl.Size = New System.Drawing.Size(0, 24)
        Me.PricePHPLbl.TabIndex = 16
        '
        'PriceLbl
        '
        Me.PriceLbl.AutoSize = True
        Me.PriceLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PriceLbl.Location = New System.Drawing.Point(92, 482)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(64, 22)
        Me.PriceLbl.TabIndex = 15
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
        Me.ClearOrderBtn.Location = New System.Drawing.Point(91, 539)
        Me.ClearOrderBtn.Name = "ClearOrderBtn"
        Me.ClearOrderBtn.Size = New System.Drawing.Size(170, 44)
        Me.ClearOrderBtn.TabIndex = 17
        Me.ClearOrderBtn.Text = "Clear Order"
        Me.ClearOrderBtn.UseVisualStyleBackColor = False
        '
        'ItemIDLbl
        '
        Me.ItemIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemIDLbl.ForeColor = System.Drawing.Color.Red
        Me.ItemIDLbl.Location = New System.Drawing.Point(376, 303)
        Me.ItemIDLbl.Name = "ItemIDLbl"
        Me.ItemIDLbl.Size = New System.Drawing.Size(265, 22)
        Me.ItemIDLbl.TabIndex = 9
        Me.ItemIDLbl.Text = "Not Found"
        Me.ItemIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerIDLbl
        '
        Me.CustomerIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDLbl.ForeColor = System.Drawing.Color.Red
        Me.CustomerIDLbl.Location = New System.Drawing.Point(376, 122)
        Me.CustomerIDLbl.Name = "CustomerIDLbl"
        Me.CustomerIDLbl.Size = New System.Drawing.Size(265, 22)
        Me.CustomerIDLbl.TabIndex = 4
        Me.CustomerIDLbl.Text = "Not Found"
        Me.CustomerIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerCmbBxPnl
        '
        Me.CustomerCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerCmbBxPnl.Controls.Add(Me.CustomerCmbBx)
        Me.CustomerCmbBxPnl.Location = New System.Drawing.Point(91, 147)
        Me.CustomerCmbBxPnl.Name = "CustomerCmbBxPnl"
        Me.CustomerCmbBxPnl.Size = New System.Drawing.Size(550, 36)
        Me.CustomerCmbBxPnl.TabIndex = 5
        '
        'CustomerCmbBx
        '
        Me.CustomerCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustomerCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerCmbBx.BackColor = System.Drawing.Color.White
        Me.CustomerCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerCmbBx.FormattingEnabled = True
        Me.CustomerCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.CustomerCmbBx.Name = "CustomerCmbBx"
        Me.CustomerCmbBx.Size = New System.Drawing.Size(546, 32)
        Me.CustomerCmbBx.Sorted = True
        Me.CustomerCmbBx.TabIndex = 0
        '
        'CustomerLbl
        '
        Me.CustomerLbl.AutoSize = True
        Me.CustomerLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerLbl.Location = New System.Drawing.Point(92, 122)
        Me.CustomerLbl.Name = "CustomerLbl"
        Me.CustomerLbl.Size = New System.Drawing.Size(93, 22)
        Me.CustomerLbl.TabIndex = 3
        Me.CustomerLbl.Text = "Customer"
        '
        'WarningIndicatorLbl
        '
        Me.WarningIndicatorLbl.AutoSize = True
        Me.WarningIndicatorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningIndicatorLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningIndicatorLbl.Location = New System.Drawing.Point(89, 586)
        Me.WarningIndicatorLbl.Name = "WarningIndicatorLbl"
        Me.WarningIndicatorLbl.Size = New System.Drawing.Size(223, 20)
        Me.WarningIndicatorLbl.TabIndex = 20
        Me.WarningIndicatorLbl.Text = "* You have 1 warning(s) on this form"
        Me.WarningIndicatorLbl.Visible = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(471, 539)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(170, 44)
        Me.AddBtn.TabIndex = 19
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
        Me.RemoveBtn.Location = New System.Drawing.Point(281, 539)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(170, 44)
        Me.RemoveBtn.TabIndex = 18
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.UseVisualStyleBackColor = False
        '
        'QtyTxtBxPnl
        '
        Me.QtyTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyTxtBxPnl.Controls.Add(Me.QtyTxtBxPddng)
        Me.QtyTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.QtyTxtBxPnl.Location = New System.Drawing.Point(230, 402)
        Me.QtyTxtBxPnl.Name = "QtyTxtBxPnl"
        Me.QtyTxtBxPnl.Size = New System.Drawing.Size(63, 38)
        Me.QtyTxtBxPnl.TabIndex = 13
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
        Me.QtyIncreaseBtn.Location = New System.Drawing.Point(299, 402)
        Me.QtyIncreaseBtn.Name = "QtyIncreaseBtn"
        Me.QtyIncreaseBtn.Size = New System.Drawing.Size(38, 38)
        Me.QtyIncreaseBtn.TabIndex = 14
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
        Me.QtyDecreaseBtn.Location = New System.Drawing.Point(186, 402)
        Me.QtyDecreaseBtn.Name = "QtyDecreaseBtn"
        Me.QtyDecreaseBtn.Size = New System.Drawing.Size(38, 38)
        Me.QtyDecreaseBtn.TabIndex = 12
        Me.QtyDecreaseBtn.Text = "-"
        Me.QtyDecreaseBtn.UseVisualStyleBackColor = False
        '
        'QtyLbl
        '
        Me.QtyLbl.AutoSize = True
        Me.QtyLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyLbl.Location = New System.Drawing.Point(92, 410)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(88, 22)
        Me.QtyLbl.TabIndex = 11
        Me.QtyLbl.Text = "Quantity: "
        '
        'CategoryCmbBxPnl
        '
        Me.CategoryCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryCmbBxPnl.Controls.Add(Me.CategoryCmbBx)
        Me.CategoryCmbBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.CategoryCmbBxPnl.Location = New System.Drawing.Point(91, 238)
        Me.CategoryCmbBxPnl.Name = "CategoryCmbBxPnl"
        Me.CategoryCmbBxPnl.Size = New System.Drawing.Size(248, 36)
        Me.CategoryCmbBxPnl.TabIndex = 7
        '
        'CategoryCmbBx
        '
        Me.CategoryCmbBx.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Others"})
        Me.CategoryCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CategoryCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CategoryCmbBx.BackColor = System.Drawing.Color.White
        Me.CategoryCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoryCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryCmbBx.FormattingEnabled = True
        Me.CategoryCmbBx.Items.AddRange(New Object() {"Branded", "Galenicals", "Generic", "Milk Supplements"})
        Me.CategoryCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.CategoryCmbBx.Name = "CategoryCmbBx"
        Me.CategoryCmbBx.Size = New System.Drawing.Size(244, 32)
        Me.CategoryCmbBx.TabIndex = 0
        '
        'ItemCmbBxPnl
        '
        Me.ItemCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemCmbBxPnl.Controls.Add(Me.ItemCmbBx)
        Me.ItemCmbBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.ItemCmbBxPnl.Location = New System.Drawing.Point(91, 328)
        Me.ItemCmbBxPnl.Name = "ItemCmbBxPnl"
        Me.ItemCmbBxPnl.Size = New System.Drawing.Size(550, 36)
        Me.ItemCmbBxPnl.TabIndex = 10
        '
        'ItemCmbBx
        '
        Me.ItemCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ItemCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ItemCmbBx.BackColor = System.Drawing.Color.White
        Me.ItemCmbBx.Enabled = False
        Me.ItemCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemCmbBx.FormattingEnabled = True
        Me.ItemCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.ItemCmbBx.Name = "ItemCmbBx"
        Me.ItemCmbBx.Size = New System.Drawing.Size(546, 32)
        Me.ItemCmbBx.TabIndex = 0
        '
        'OPrimaryBtn
        '
        Me.OPrimaryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OPrimaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OPrimaryBtn.FlatAppearance.BorderSize = 0
        Me.OPrimaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OPrimaryBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPrimaryBtn.ForeColor = System.Drawing.Color.White
        Me.OPrimaryBtn.Location = New System.Drawing.Point(91, 635)
        Me.OPrimaryBtn.Name = "OPrimaryBtn"
        Me.OPrimaryBtn.Size = New System.Drawing.Size(550, 44)
        Me.OPrimaryBtn.TabIndex = 21
        Me.OPrimaryBtn.Text = "Create"
        Me.OPrimaryBtn.UseVisualStyleBackColor = False
        '
        'ItemLbl
        '
        Me.ItemLbl.AutoSize = True
        Me.ItemLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemLbl.Location = New System.Drawing.Point(92, 303)
        Me.ItemLbl.Name = "ItemLbl"
        Me.ItemLbl.Size = New System.Drawing.Size(48, 22)
        Me.ItemLbl.TabIndex = 8
        Me.ItemLbl.Text = "Item"
        '
        'CategoryLbl
        '
        Me.CategoryLbl.AutoSize = True
        Me.CategoryLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryLbl.Location = New System.Drawing.Point(92, 213)
        Me.CategoryLbl.Name = "CategoryLbl"
        Me.CategoryLbl.Size = New System.Drawing.Size(87, 22)
        Me.CategoryLbl.TabIndex = 6
        Me.CategoryLbl.Text = "Category"
        '
        'IDLbl
        '
        Me.IDLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.IDLbl.Location = New System.Drawing.Point(390, 62)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.Size = New System.Drawing.Size(251, 34)
        Me.IDLbl.TabIndex = 2
        Me.IDLbl.Text = "ORD-AAA-AAA-000"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IDLbl.Visible = False
        '
        'OFormTitle
        '
        Me.OFormTitle.AutoSize = True
        Me.OFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OFormTitle.Location = New System.Drawing.Point(85, 62)
        Me.OFormTitle.Name = "OFormTitle"
        Me.OFormTitle.Size = New System.Drawing.Size(161, 34)
        Me.OFormTitle.TabIndex = 1
        Me.OFormTitle.Text = "New Order"
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
        'ODGVPnl
        '
        Me.ODGVPnl.Controls.Add(Me.ODGVOrdersPnl)
        Me.ODGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ODGVPnl.Location = New System.Drawing.Point(727, 0)
        Me.ODGVPnl.Name = "ODGVPnl"
        Me.ODGVPnl.Padding = New System.Windows.Forms.Padding(30)
        Me.ODGVPnl.Size = New System.Drawing.Size(457, 721)
        Me.ODGVPnl.TabIndex = 0
        '
        'ODGVOrdersPnl
        '
        Me.ODGVOrdersPnl.Controls.Add(Me.ODGV)
        Me.ODGVOrdersPnl.Controls.Add(Me.TotalAmountPnl)
        Me.ODGVOrdersPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ODGVOrdersPnl.Location = New System.Drawing.Point(30, 30)
        Me.ODGVOrdersPnl.Name = "ODGVOrdersPnl"
        Me.ODGVOrdersPnl.Size = New System.Drawing.Size(397, 661)
        Me.ODGVOrdersPnl.TabIndex = 0
        '
        'ODGV
        '
        Me.ODGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ODGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ODGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ODGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ODGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ODGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ODGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_id, Me.item_name, Me.amount, Me.qty, Me.total})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ODGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.ODGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ODGV.EnableHeadersVisualStyles = False
        Me.ODGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ODGV.Location = New System.Drawing.Point(0, 0)
        Me.ODGV.Name = "ODGV"
        Me.ODGV.ReadOnly = True
        Me.ODGV.RowHeadersVisible = False
        Me.ODGV.Size = New System.Drawing.Size(397, 603)
        Me.ODGV.TabIndex = 1
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
        'amount
        '
        Me.amount.FillWeight = 99.61929!
        Me.amount.HeaderText = "amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
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
        'TotalAmountPnl
        '
        Me.TotalAmountPnl.Controls.Add(Me.TotalAmountPHPLbl)
        Me.TotalAmountPnl.Controls.Add(Me.TotalAmountLbl)
        Me.TotalAmountPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TotalAmountPnl.Location = New System.Drawing.Point(0, 603)
        Me.TotalAmountPnl.Name = "TotalAmountPnl"
        Me.TotalAmountPnl.Size = New System.Drawing.Size(397, 58)
        Me.TotalAmountPnl.TabIndex = 0
        '
        'TotalAmountPHPLbl
        '
        Me.TotalAmountPHPLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.TotalAmountPHPLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountPHPLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalAmountPHPLbl.Location = New System.Drawing.Point(173, 0)
        Me.TotalAmountPHPLbl.Name = "TotalAmountPHPLbl"
        Me.TotalAmountPHPLbl.Size = New System.Drawing.Size(224, 58)
        Me.TotalAmountPHPLbl.TabIndex = 1
        Me.TotalAmountPHPLbl.Text = "PHP 0"
        Me.TotalAmountPHPLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalAmountLbl
        '
        Me.TotalAmountLbl.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalAmountLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalAmountLbl.Location = New System.Drawing.Point(0, 0)
        Me.TotalAmountLbl.Name = "TotalAmountLbl"
        Me.TotalAmountLbl.Size = New System.Drawing.Size(167, 58)
        Me.TotalAmountLbl.TabIndex = 0
        Me.TotalAmountLbl.Text = "Total Amount"
        Me.TotalAmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'AddEditOrderForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.ODGVPnl)
        Me.Controls.Add(Me.AContentPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEditOrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEditOrderForm"
        Me.AContentPnl.ResumeLayout(False)
        Me.HeaderFormPnl.ResumeLayout(False)
        Me.HeaderFormPnl.PerformLayout()
        Me.CustomerCmbBxPnl.ResumeLayout(False)
        Me.QtyTxtBxPnl.ResumeLayout(False)
        Me.QtyTxtBxPddng.ResumeLayout(False)
        Me.QtyTxtBxPddng.PerformLayout()
        Me.CategoryCmbBxPnl.ResumeLayout(False)
        Me.ItemCmbBxPnl.ResumeLayout(False)
        Me.ODGVPnl.ResumeLayout(False)
        Me.ODGVOrdersPnl.ResumeLayout(False)
        CType(Me.ODGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TotalAmountPnl.ResumeLayout(False)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackBtn As Button
    Friend WithEvents AContentPnl As Panel
    Friend WithEvents ODGVPnl As Panel
    Friend WithEvents HeaderFormPnl As Panel
    Friend WithEvents OFormTitle As Label
    Friend WithEvents IDLbl As Label
    Friend WithEvents CustomerCmbBxPnl As Panel
    Friend WithEvents CustomerCmbBx As ComboBox
    Friend WithEvents CustomerLbl As Label
    Friend WithEvents WarningIndicatorLbl As Label
    Friend WithEvents AddBtn As Button
    Friend WithEvents RemoveBtn As Button
    Friend WithEvents QtyTxtBxPnl As Panel
    Friend WithEvents QtyTxtBxPddng As Panel
    Friend WithEvents QtyTxtBx As TextBox
    Friend WithEvents QtyIncreaseBtn As Button
    Friend WithEvents QtyDecreaseBtn As Button
    Friend WithEvents QtyLbl As Label
    Friend WithEvents CategoryCmbBxPnl As Panel
    Friend WithEvents CategoryCmbBx As ComboBox
    Friend WithEvents ItemCmbBxPnl As Panel
    Friend WithEvents ItemCmbBx As ComboBox
    Friend WithEvents OPrimaryBtn As Button
    Friend WithEvents ItemLbl As Label
    Friend WithEvents CategoryLbl As Label
    Friend WithEvents CustomerIDLbl As Label
    Friend WithEvents ItemIDLbl As Label
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents ODGVOrdersPnl As Panel
    Friend WithEvents TotalAmountPnl As Panel
    Friend WithEvents TotalAmountPHPLbl As Label
    Friend WithEvents TotalAmountLbl As Label
    Friend WithEvents ClearOrderBtn As Button
    Friend WithEvents ODGV As DataGridView
    Friend WithEvents PricePHPLbl As Label
    Friend WithEvents PriceLbl As Label
    Friend WithEvents item_id As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
