<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReferenceInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReferenceInfoForm))
        Me.PHPLbl = New System.Windows.Forms.Label()
        Me.TotalItemsLb = New System.Windows.Forms.Label()
        Me.OrderTotalLbl = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.CustomerIDLbl = New System.Windows.Forms.Label()
        Me.RefNoLbl = New System.Windows.Forms.Label()
        Me.OrderInfoPnl = New System.Windows.Forms.Panel()
        Me.PharmacistIDLbl = New System.Windows.Forms.Label()
        Me.PharmacistNameLbl = New System.Windows.Forms.Label()
        Me.PharmacistLbl = New System.Windows.Forms.Label()
        Me.DCLbl = New System.Windows.Forms.Label()
        Me.DOLbl = New System.Windows.Forms.Label()
        Me.DateCompLbl = New System.Windows.Forms.Label()
        Me.DateOrdLbl = New System.Windows.Forms.Label()
        Me.OrderIDLbl = New System.Windows.Forms.Label()
        Me.CustomerAvatarPctrBx = New System.Windows.Forms.PictureBox()
        Me.ReferenceLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.SortCmbBx = New System.Windows.Forms.ComboBox()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.SortPnl = New System.Windows.Forms.Panel()
        Me.QtyLbl = New System.Windows.Forms.Label()
        Me.ItemNameLbl = New System.Windows.Forms.Label()
        Me.ItemIDLbl = New System.Windows.Forms.Label()
        Me.OrderItemsTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.OrderItemsPnl = New System.Windows.Forms.Panel()
        Me.OrderItemsDockPnl = New System.Windows.Forms.Panel()
        Me.SortDockPnl = New System.Windows.Forms.Panel()
        Me.OCDockPnl = New System.Windows.Forms.Panel()
        Me.OrderInfoPnl.SuspendLayout()
        CType(Me.CustomerAvatarPctrBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SortPnl.SuspendLayout()
        Me.HeaderTblLyt.SuspendLayout()
        Me.OrderItemsPnl.SuspendLayout()
        Me.OrderItemsDockPnl.SuspendLayout()
        Me.SortDockPnl.SuspendLayout()
        Me.OCDockPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PHPLbl
        '
        Me.PHPLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PHPLbl.AutoSize = True
        Me.PHPLbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHPLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PHPLbl.Location = New System.Drawing.Point(44, 636)
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
        Me.TotalItemsLb.Location = New System.Drawing.Point(204, 597)
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
        Me.OrderTotalLbl.Location = New System.Drawing.Point(44, 598)
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
        Me.NameLbl.Location = New System.Drawing.Point(156, 188)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(0, 24)
        Me.NameLbl.TabIndex = 52
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
        'RefNoLbl
        '
        Me.RefNoLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefNoLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RefNoLbl.Location = New System.Drawing.Point(205, 74)
        Me.RefNoLbl.Name = "RefNoLbl"
        Me.RefNoLbl.Size = New System.Drawing.Size(251, 34)
        Me.RefNoLbl.TabIndex = 48
        Me.RefNoLbl.Text = "REF-AAA-AAA-000"
        Me.RefNoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderInfoPnl
        '
        Me.OrderInfoPnl.Controls.Add(Me.PharmacistIDLbl)
        Me.OrderInfoPnl.Controls.Add(Me.PharmacistNameLbl)
        Me.OrderInfoPnl.Controls.Add(Me.PharmacistLbl)
        Me.OrderInfoPnl.Controls.Add(Me.DCLbl)
        Me.OrderInfoPnl.Controls.Add(Me.DOLbl)
        Me.OrderInfoPnl.Controls.Add(Me.DateCompLbl)
        Me.OrderInfoPnl.Controls.Add(Me.DateOrdLbl)
        Me.OrderInfoPnl.Controls.Add(Me.OrderIDLbl)
        Me.OrderInfoPnl.Controls.Add(Me.PHPLbl)
        Me.OrderInfoPnl.Controls.Add(Me.TotalItemsLb)
        Me.OrderInfoPnl.Controls.Add(Me.OrderTotalLbl)
        Me.OrderInfoPnl.Controls.Add(Me.NameLbl)
        Me.OrderInfoPnl.Controls.Add(Me.CustomerAvatarPctrBx)
        Me.OrderInfoPnl.Controls.Add(Me.CustomerIDLbl)
        Me.OrderInfoPnl.Controls.Add(Me.RefNoLbl)
        Me.OrderInfoPnl.Controls.Add(Me.ReferenceLbl)
        Me.OrderInfoPnl.Controls.Add(Me.BackBtn)
        Me.OrderInfoPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.OrderInfoPnl.Location = New System.Drawing.Point(0, 0)
        Me.OrderInfoPnl.Name = "OrderInfoPnl"
        Me.OrderInfoPnl.Size = New System.Drawing.Size(496, 721)
        Me.OrderInfoPnl.TabIndex = 37
        '
        'PharmacistIDLbl
        '
        Me.PharmacistIDLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PharmacistIDLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PharmacistIDLbl.Location = New System.Drawing.Point(191, 463)
        Me.PharmacistIDLbl.Name = "PharmacistIDLbl"
        Me.PharmacistIDLbl.Size = New System.Drawing.Size(251, 34)
        Me.PharmacistIDLbl.TabIndex = 69
        Me.PharmacistIDLbl.Text = "PHA-AAA-AAA-000"
        Me.PharmacistIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PharmacistNameLbl
        '
        Me.PharmacistNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PharmacistNameLbl.AutoSize = True
        Me.PharmacistNameLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PharmacistNameLbl.Location = New System.Drawing.Point(44, 494)
        Me.PharmacistNameLbl.Name = "PharmacistNameLbl"
        Me.PharmacistNameLbl.Size = New System.Drawing.Size(0, 27)
        Me.PharmacistNameLbl.TabIndex = 68
        '
        'PharmacistLbl
        '
        Me.PharmacistLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PharmacistLbl.AutoSize = True
        Me.PharmacistLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PharmacistLbl.Location = New System.Drawing.Point(44, 465)
        Me.PharmacistLbl.Name = "PharmacistLbl"
        Me.PharmacistLbl.Size = New System.Drawing.Size(141, 29)
        Me.PharmacistLbl.TabIndex = 67
        Me.PharmacistLbl.Text = "Pharmacist"
        '
        'DCLbl
        '
        Me.DCLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DCLbl.AutoSize = True
        Me.DCLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DCLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DCLbl.Location = New System.Drawing.Point(45, 400)
        Me.DCLbl.Name = "DCLbl"
        Me.DCLbl.Size = New System.Drawing.Size(130, 27)
        Me.DCLbl.TabIndex = 64
        Me.DCLbl.Text = "00/00/0000"
        '
        'DOLbl
        '
        Me.DOLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DOLbl.AutoSize = True
        Me.DOLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DOLbl.Location = New System.Drawing.Point(44, 308)
        Me.DOLbl.Name = "DOLbl"
        Me.DOLbl.Size = New System.Drawing.Size(130, 27)
        Me.DOLbl.TabIndex = 63
        Me.DOLbl.Text = "00/00/0000"
        '
        'DateCompLbl
        '
        Me.DateCompLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DateCompLbl.AutoSize = True
        Me.DateCompLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCompLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DateCompLbl.Location = New System.Drawing.Point(44, 371)
        Me.DateCompLbl.Name = "DateCompLbl"
        Me.DateCompLbl.Size = New System.Drawing.Size(251, 29)
        Me.DateCompLbl.TabIndex = 62
        Me.DateCompLbl.Text = "Date Order Complete"
        '
        'DateOrdLbl
        '
        Me.DateOrdLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DateOrdLbl.AutoSize = True
        Me.DateOrdLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOrdLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DateOrdLbl.Location = New System.Drawing.Point(44, 279)
        Me.DateOrdLbl.Name = "DateOrdLbl"
        Me.DateOrdLbl.Size = New System.Drawing.Size(163, 29)
        Me.DateOrdLbl.TabIndex = 61
        Me.DateOrdLbl.Text = "Date Ordered"
        '
        'OrderIDLbl
        '
        Me.OrderIDLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OrderIDLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.OrderIDLbl.Location = New System.Drawing.Point(45, 563)
        Me.OrderIDLbl.Name = "OrderIDLbl"
        Me.OrderIDLbl.Size = New System.Drawing.Size(251, 34)
        Me.OrderIDLbl.TabIndex = 60
        Me.OrderIDLbl.Text = "ORD-AAA-AAA-000"
        Me.OrderIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ReferenceLbl
        '
        Me.ReferenceLbl.AutoSize = True
        Me.ReferenceLbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenceLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ReferenceLbl.Location = New System.Drawing.Point(44, 72)
        Me.ReferenceLbl.Name = "ReferenceLbl"
        Me.ReferenceLbl.Size = New System.Drawing.Size(155, 34)
        Me.ReferenceLbl.TabIndex = 47
        Me.ReferenceLbl.Text = "Reference"
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
        'QtyLbl
        '
        Me.QtyLbl.AutoSize = True
        Me.QtyLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QtyLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.QtyLbl.Location = New System.Drawing.Point(315, 0)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(150, 40)
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
        Me.ItemNameLbl.Location = New System.Drawing.Point(159, 0)
        Me.ItemNameLbl.Name = "ItemNameLbl"
        Me.ItemNameLbl.Size = New System.Drawing.Size(150, 40)
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
        Me.ItemIDLbl.Size = New System.Drawing.Size(150, 40)
        Me.ItemIDLbl.TabIndex = 0
        Me.ItemIDLbl.Text = "Item ID"
        Me.ItemIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderItemsTblLyt
        '
        Me.OrderItemsTblLyt.AutoScroll = True
        Me.OrderItemsTblLyt.ColumnCount = 4
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.44795!))
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.92113!))
        Me.OrderItemsTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.86751!))
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
        Me.HeaderTblLyt.ColumnCount = 5
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9999979!))
        Me.HeaderTblLyt.Controls.Add(Me.QtyLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.ItemNameLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.ItemIDLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.TotalLbl, 3, 0)
        Me.HeaderTblLyt.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderTblLyt.Location = New System.Drawing.Point(2, 2)
        Me.HeaderTblLyt.Name = "HeaderTblLyt"
        Me.HeaderTblLyt.RowCount = 1
        Me.HeaderTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HeaderTblLyt.Size = New System.Drawing.Size(634, 40)
        Me.HeaderTblLyt.TabIndex = 1
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalLbl.Location = New System.Drawing.Point(471, 0)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(150, 40)
        Me.TotalLbl.TabIndex = 8
        Me.TotalLbl.Text = "Total"
        Me.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'ReferenceInfoForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.OCDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReferenceInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ReferenceInfoForm"
        Me.OrderInfoPnl.ResumeLayout(False)
        Me.OrderInfoPnl.PerformLayout()
        CType(Me.CustomerAvatarPctrBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SortPnl.ResumeLayout(False)
        Me.HeaderTblLyt.ResumeLayout(False)
        Me.HeaderTblLyt.PerformLayout()
        Me.OrderItemsPnl.ResumeLayout(False)
        Me.OrderItemsDockPnl.ResumeLayout(False)
        Me.SortDockPnl.ResumeLayout(False)
        Me.SortDockPnl.PerformLayout()
        Me.OCDockPnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PHPLbl As Label
    Friend WithEvents TotalItemsLb As Label
    Friend WithEvents OrderTotalLbl As Label
    Friend WithEvents NameLbl As Label
    Friend WithEvents CustomerAvatarPctrBx As PictureBox
    Friend WithEvents CustomerIDLbl As Label
    Friend WithEvents RefNoLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents OrderInfoPnl As Panel
    Friend WithEvents ReferenceLbl As Label
    Friend WithEvents SortCmbBx As ComboBox
    Friend WithEvents SortLbl As Label
    Friend WithEvents SortPnl As Panel
    Friend WithEvents QtyLbl As Label
    Friend WithEvents ItemNameLbl As Label
    Friend WithEvents ItemIDLbl As Label
    Friend WithEvents OrderItemsTblLyt As TableLayoutPanel
    Friend WithEvents HeaderTblLyt As TableLayoutPanel
    Friend WithEvents OrderItemsPnl As Panel
    Friend WithEvents OrderItemsDockPnl As Panel
    Friend WithEvents SortDockPnl As Panel
    Friend WithEvents OCDockPnl As Panel
    Friend WithEvents OrderIDLbl As Label
    Friend WithEvents DCLbl As Label
    Friend WithEvents DOLbl As Label
    Friend WithEvents DateCompLbl As Label
    Friend WithEvents DateOrdLbl As Label
    Friend WithEvents PharmacistNameLbl As Label
    Friend WithEvents PharmacistLbl As Label
    Friend WithEvents PharmacistIDLbl As Label
    Friend WithEvents TotalLbl As Label
End Class
