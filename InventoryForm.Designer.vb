﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.InventorySearchBtn = New System.Windows.Forms.Button()
        Me.FooterDockPnl = New System.Windows.Forms.Panel()
        Me.LastBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.FirstBtn = New System.Windows.Forms.Button()
        Me.CurrentOrdNumLbl = New System.Windows.Forms.Label()
        Me.FilterLbl = New System.Windows.Forms.Label()
        Me.FilterCmbBx = New System.Windows.Forms.ComboBox()
        Me.FilterCmbBxPnl = New System.Windows.Forms.Panel()
        Me.InventorySearchTxtBx = New System.Windows.Forms.TextBox()
        Me.InventorySearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.InventorySearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.IDockPanel = New System.Windows.Forms.Panel()
        Me.ContentDockPnl = New System.Windows.Forms.Panel()
        Me.ContentPnl = New System.Windows.Forms.Panel()
        Me.InventoryTblLytPnl = New System.Windows.Forms.Panel()
        Me.InventoryPnl = New System.Windows.Forms.Panel()
        Me.InventoryTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.CategoryLbl = New System.Windows.Forms.Label()
        Me.ItemNameLbl = New System.Windows.Forms.Label()
        Me.ItemIDLbl = New System.Windows.Forms.Label()
        Me.StockLbl = New System.Windows.Forms.Label()
        Me.SupplierLbl = New System.Windows.Forms.Label()
        Me.CategoryTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.BrandedPnl = New System.Windows.Forms.Panel()
        Me.BrandedPddng = New System.Windows.Forms.Panel()
        Me.BrandedItemsLbl = New System.Windows.Forms.Label()
        Me.BrandedLbl = New System.Windows.Forms.Label()
        Me.MilkSupplementsPnl = New System.Windows.Forms.Panel()
        Me.MSPddng = New System.Windows.Forms.Panel()
        Me.MSItemsLbl = New System.Windows.Forms.Label()
        Me.MSLbl = New System.Windows.Forms.Label()
        Me.GenericPnl = New System.Windows.Forms.Panel()
        Me.GenericPddng = New System.Windows.Forms.Panel()
        Me.GenericItemsLbl = New System.Windows.Forms.Label()
        Me.GenericLbl = New System.Windows.Forms.Label()
        Me.GalenicalsPnl = New System.Windows.Forms.Panel()
        Me.GalenicalsPddng = New System.Windows.Forms.Panel()
        Me.GalenicalsItemsLbl = New System.Windows.Forms.Label()
        Me.GalenicalsLbl = New System.Windows.Forms.Label()
        Me.HeaderDockPnl = New System.Windows.Forms.Panel()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.SortPnl = New System.Windows.Forms.Panel()
        Me.SortCmbBx = New System.Windows.Forms.ComboBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FooterDockPnl.SuspendLayout()
        Me.FilterCmbBxPnl.SuspendLayout()
        Me.InventorySearchTxtBxPddng.SuspendLayout()
        Me.InventorySearchTxtBxPnl.SuspendLayout()
        Me.IDockPanel.SuspendLayout()
        Me.ContentDockPnl.SuspendLayout()
        Me.ContentPnl.SuspendLayout()
        Me.InventoryTblLytPnl.SuspendLayout()
        Me.InventoryPnl.SuspendLayout()
        Me.HeaderTblLyt.SuspendLayout()
        Me.CategoryTblLyt.SuspendLayout()
        Me.BrandedPnl.SuspendLayout()
        Me.BrandedPddng.SuspendLayout()
        Me.MilkSupplementsPnl.SuspendLayout()
        Me.MSPddng.SuspendLayout()
        Me.GenericPnl.SuspendLayout()
        Me.GenericPddng.SuspendLayout()
        Me.GalenicalsPnl.SuspendLayout()
        Me.GalenicalsPddng.SuspendLayout()
        Me.HeaderDockPnl.SuspendLayout()
        Me.SortPnl.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InventorySearchBtn
        '
        Me.InventorySearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.InventorySearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.InventorySearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.InventorySearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventorySearchBtn.FlatAppearance.BorderSize = 0
        Me.InventorySearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventorySearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventorySearchBtn.ForeColor = System.Drawing.Color.White
        Me.InventorySearchBtn.Location = New System.Drawing.Point(434, 19)
        Me.InventorySearchBtn.Name = "InventorySearchBtn"
        Me.InventorySearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.InventorySearchBtn.TabIndex = 34
        Me.InventorySearchBtn.UseVisualStyleBackColor = False
        '
        'FooterDockPnl
        '
        Me.FooterDockPnl.Controls.Add(Me.LastBtn)
        Me.FooterDockPnl.Controls.Add(Me.NextBtn)
        Me.FooterDockPnl.Controls.Add(Me.PrevBtn)
        Me.FooterDockPnl.Controls.Add(Me.FirstBtn)
        Me.FooterDockPnl.Controls.Add(Me.CurrentOrdNumLbl)
        Me.FooterDockPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterDockPnl.Location = New System.Drawing.Point(0, 651)
        Me.FooterDockPnl.Name = "FooterDockPnl"
        Me.FooterDockPnl.Size = New System.Drawing.Size(1184, 70)
        Me.FooterDockPnl.TabIndex = 33
        '
        'LastBtn
        '
        Me.LastBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LastBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LastBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LastBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastBtn.ForeColor = System.Drawing.Color.White
        Me.LastBtn.Location = New System.Drawing.Point(1044, 15)
        Me.LastBtn.Name = "LastBtn"
        Me.LastBtn.Size = New System.Drawing.Size(120, 40)
        Me.LastBtn.TabIndex = 16
        Me.LastBtn.UseVisualStyleBackColor = False
        '
        'NextBtn
        '
        Me.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.NextBtn.FlatAppearance.BorderSize = 2
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextBtn.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.NextBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.NextBtn.Location = New System.Drawing.Point(960, 15)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(70, 40)
        Me.NextBtn.TabIndex = 17
        Me.NextBtn.Text = ">>"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'PrevBtn
        '
        Me.PrevBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrevBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PrevBtn.FlatAppearance.BorderSize = 2
        Me.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrevBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PrevBtn.Location = New System.Drawing.Point(876, 15)
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(70, 40)
        Me.PrevBtn.TabIndex = 18
        Me.PrevBtn.Text = "<<"
        Me.PrevBtn.UseVisualStyleBackColor = True
        '
        'FirstBtn
        '
        Me.FirstBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FirstBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FirstBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FirstBtn.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.FirstBtn.ForeColor = System.Drawing.Color.White
        Me.FirstBtn.Location = New System.Drawing.Point(742, 15)
        Me.FirstBtn.Name = "FirstBtn"
        Me.FirstBtn.Size = New System.Drawing.Size(120, 40)
        Me.FirstBtn.TabIndex = 15
        Me.FirstBtn.Text = "1"
        Me.FirstBtn.UseVisualStyleBackColor = False
        '
        'CurrentOrdNumLbl
        '
        Me.CurrentOrdNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CurrentOrdNumLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentOrdNumLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CurrentOrdNumLbl.Location = New System.Drawing.Point(426, 15)
        Me.CurrentOrdNumLbl.Name = "CurrentOrdNumLbl"
        Me.CurrentOrdNumLbl.Size = New System.Drawing.Size(301, 40)
        Me.CurrentOrdNumLbl.TabIndex = 13
        Me.CurrentOrdNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FilterLbl
        '
        Me.FilterLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FilterLbl.AutoSize = True
        Me.FilterLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterLbl.Location = New System.Drawing.Point(873, 27)
        Me.FilterLbl.Name = "FilterLbl"
        Me.FilterLbl.Size = New System.Drawing.Size(57, 24)
        Me.FilterLbl.TabIndex = 37
        Me.FilterLbl.Text = "Filter"
        '
        'FilterCmbBx
        '
        Me.FilterCmbBx.BackColor = System.Drawing.Color.White
        Me.FilterCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FilterCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterCmbBx.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterCmbBx.FormattingEnabled = True
        Me.FilterCmbBx.Items.AddRange(New Object() {"All", "Branded", "Galenicals", "Generic", "Milk Supplements"})
        Me.FilterCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.FilterCmbBx.Name = "FilterCmbBx"
        Me.FilterCmbBx.Size = New System.Drawing.Size(214, 30)
        Me.FilterCmbBx.TabIndex = 0
        '
        'FilterCmbBxPnl
        '
        Me.FilterCmbBxPnl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FilterCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterCmbBxPnl.Controls.Add(Me.FilterCmbBx)
        Me.FilterCmbBxPnl.Location = New System.Drawing.Point(936, 22)
        Me.FilterCmbBxPnl.Name = "FilterCmbBxPnl"
        Me.FilterCmbBxPnl.Size = New System.Drawing.Size(218, 34)
        Me.FilterCmbBxPnl.TabIndex = 36
        '
        'InventorySearchTxtBx
        '
        Me.InventorySearchTxtBx.BackColor = System.Drawing.Color.White
        Me.InventorySearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InventorySearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventorySearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.InventorySearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.InventorySearchTxtBx.Name = "InventorySearchTxtBx"
        Me.InventorySearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.InventorySearchTxtBx.TabIndex = 1
        '
        'InventorySearchTxtBxPddng
        '
        Me.InventorySearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.InventorySearchTxtBxPddng.Controls.Add(Me.InventorySearchTxtBx)
        Me.InventorySearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.InventorySearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.InventorySearchTxtBxPddng.Name = "InventorySearchTxtBxPddng"
        Me.InventorySearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.InventorySearchTxtBxPddng.TabIndex = 0
        '
        'InventorySearchTxtBxPnl
        '
        Me.InventorySearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.InventorySearchTxtBxPnl.Controls.Add(Me.InventorySearchTxtBxPddng)
        Me.InventorySearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.InventorySearchTxtBxPnl.Location = New System.Drawing.Point(30, 19)
        Me.InventorySearchTxtBxPnl.Name = "InventorySearchTxtBxPnl"
        Me.InventorySearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.InventorySearchTxtBxPnl.TabIndex = 35
        '
        'IDockPanel
        '
        Me.IDockPanel.Controls.Add(Me.ContentDockPnl)
        Me.IDockPanel.Controls.Add(Me.FooterDockPnl)
        Me.IDockPanel.Controls.Add(Me.HeaderDockPnl)
        Me.IDockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.IDockPanel.Name = "IDockPanel"
        Me.IDockPanel.Size = New System.Drawing.Size(1184, 721)
        Me.IDockPanel.TabIndex = 4
        '
        'ContentDockPnl
        '
        Me.ContentDockPnl.BackColor = System.Drawing.Color.White
        Me.ContentDockPnl.Controls.Add(Me.ContentPnl)
        Me.ContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentDockPnl.Location = New System.Drawing.Point(0, 80)
        Me.ContentDockPnl.Name = "ContentDockPnl"
        Me.ContentDockPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ContentDockPnl.Size = New System.Drawing.Size(1184, 571)
        Me.ContentDockPnl.TabIndex = 34
        '
        'ContentPnl
        '
        Me.ContentPnl.BackColor = System.Drawing.Color.White
        Me.ContentPnl.Controls.Add(Me.InventoryTblLytPnl)
        Me.ContentPnl.Controls.Add(Me.CategoryTblLyt)
        Me.ContentPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPnl.Location = New System.Drawing.Point(20, 0)
        Me.ContentPnl.Name = "ContentPnl"
        Me.ContentPnl.Size = New System.Drawing.Size(1144, 571)
        Me.ContentPnl.TabIndex = 4
        '
        'InventoryTblLytPnl
        '
        Me.InventoryTblLytPnl.BackColor = System.Drawing.Color.White
        Me.InventoryTblLytPnl.Controls.Add(Me.InventoryPnl)
        Me.InventoryTblLytPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryTblLytPnl.Location = New System.Drawing.Point(0, 100)
        Me.InventoryTblLytPnl.Name = "InventoryTblLytPnl"
        Me.InventoryTblLytPnl.Padding = New System.Windows.Forms.Padding(10)
        Me.InventoryTblLytPnl.Size = New System.Drawing.Size(1144, 471)
        Me.InventoryTblLytPnl.TabIndex = 8
        '
        'InventoryPnl
        '
        Me.InventoryPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.InventoryPnl.Controls.Add(Me.InventoryTblLyt)
        Me.InventoryPnl.Controls.Add(Me.HeaderTblLyt)
        Me.InventoryPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryPnl.Location = New System.Drawing.Point(10, 10)
        Me.InventoryPnl.Name = "InventoryPnl"
        Me.InventoryPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.InventoryPnl.Size = New System.Drawing.Size(1124, 451)
        Me.InventoryPnl.TabIndex = 1
        '
        'InventoryTblLyt
        '
        Me.InventoryTblLyt.AutoScroll = True
        Me.InventoryTblLyt.ColumnCount = 5
        Me.InventoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.InventoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.InventoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.InventoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.InventoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.InventoryTblLyt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryTblLyt.Location = New System.Drawing.Point(2, 42)
        Me.InventoryTblLyt.Name = "InventoryTblLyt"
        Me.InventoryTblLyt.RowCount = 1
        Me.InventoryTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InventoryTblLyt.Size = New System.Drawing.Size(1120, 407)
        Me.InventoryTblLyt.TabIndex = 2
        '
        'HeaderTblLyt
        '
        Me.HeaderTblLyt.BackColor = System.Drawing.Color.White
        Me.HeaderTblLyt.ColumnCount = 6
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77672!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77671!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77671!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77671!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77671!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.116443!))
        Me.HeaderTblLyt.Controls.Add(Me.CategoryLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.ItemNameLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.ItemIDLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.StockLbl, 3, 0)
        Me.HeaderTblLyt.Controls.Add(Me.SupplierLbl, 4, 0)
        Me.HeaderTblLyt.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderTblLyt.Location = New System.Drawing.Point(2, 2)
        Me.HeaderTblLyt.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderTblLyt.Name = "HeaderTblLyt"
        Me.HeaderTblLyt.RowCount = 1
        Me.HeaderTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HeaderTblLyt.Size = New System.Drawing.Size(1120, 40)
        Me.HeaderTblLyt.TabIndex = 0
        '
        'CategoryLbl
        '
        Me.CategoryLbl.AutoSize = True
        Me.CategoryLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryLbl.Location = New System.Drawing.Point(445, 0)
        Me.CategoryLbl.Name = "CategoryLbl"
        Me.CategoryLbl.Size = New System.Drawing.Size(215, 40)
        Me.CategoryLbl.TabIndex = 2
        Me.CategoryLbl.Text = "Category"
        Me.CategoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemNameLbl
        '
        Me.ItemNameLbl.AutoSize = True
        Me.ItemNameLbl.BackColor = System.Drawing.Color.White
        Me.ItemNameLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemNameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ItemNameLbl.Location = New System.Drawing.Point(221, 0)
        Me.ItemNameLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.ItemNameLbl.Name = "ItemNameLbl"
        Me.ItemNameLbl.Size = New System.Drawing.Size(221, 40)
        Me.ItemNameLbl.TabIndex = 1
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
        Me.ItemIDLbl.Size = New System.Drawing.Size(215, 40)
        Me.ItemIDLbl.TabIndex = 0
        Me.ItemIDLbl.Text = "Item ID"
        Me.ItemIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StockLbl
        '
        Me.StockLbl.AutoSize = True
        Me.StockLbl.BackColor = System.Drawing.Color.White
        Me.StockLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.StockLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.StockLbl.Location = New System.Drawing.Point(663, 0)
        Me.StockLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.StockLbl.Name = "StockLbl"
        Me.StockLbl.Size = New System.Drawing.Size(221, 40)
        Me.StockLbl.TabIndex = 3
        Me.StockLbl.Text = "Stock"
        Me.StockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierLbl
        '
        Me.SupplierLbl.AutoSize = True
        Me.SupplierLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SupplierLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SupplierLbl.Location = New System.Drawing.Point(887, 0)
        Me.SupplierLbl.Name = "SupplierLbl"
        Me.SupplierLbl.Size = New System.Drawing.Size(215, 40)
        Me.SupplierLbl.TabIndex = 4
        Me.SupplierLbl.Text = "Supplier"
        Me.SupplierLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CategoryTblLyt
        '
        Me.CategoryTblLyt.ColumnCount = 4
        Me.CategoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CategoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CategoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CategoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CategoryTblLyt.Controls.Add(Me.BrandedPnl, 0, 0)
        Me.CategoryTblLyt.Controls.Add(Me.MilkSupplementsPnl, 3, 0)
        Me.CategoryTblLyt.Controls.Add(Me.GenericPnl, 2, 0)
        Me.CategoryTblLyt.Controls.Add(Me.GalenicalsPnl, 1, 0)
        Me.CategoryTblLyt.Dock = System.Windows.Forms.DockStyle.Top
        Me.CategoryTblLyt.Location = New System.Drawing.Point(0, 0)
        Me.CategoryTblLyt.Name = "CategoryTblLyt"
        Me.CategoryTblLyt.RowCount = 1
        Me.CategoryTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CategoryTblLyt.Size = New System.Drawing.Size(1144, 100)
        Me.CategoryTblLyt.TabIndex = 7
        '
        'BrandedPnl
        '
        Me.BrandedPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BrandedPnl.Controls.Add(Me.BrandedPddng)
        Me.BrandedPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.BrandedPnl.Location = New System.Drawing.Point(10, 10)
        Me.BrandedPnl.Margin = New System.Windows.Forms.Padding(10)
        Me.BrandedPnl.Name = "BrandedPnl"
        Me.BrandedPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.BrandedPnl.Size = New System.Drawing.Size(266, 80)
        Me.BrandedPnl.TabIndex = 4
        '
        'BrandedPddng
        '
        Me.BrandedPddng.BackColor = System.Drawing.Color.White
        Me.BrandedPddng.Controls.Add(Me.BrandedItemsLbl)
        Me.BrandedPddng.Controls.Add(Me.BrandedLbl)
        Me.BrandedPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrandedPddng.Location = New System.Drawing.Point(2, 2)
        Me.BrandedPddng.Name = "BrandedPddng"
        Me.BrandedPddng.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.BrandedPddng.Size = New System.Drawing.Size(262, 76)
        Me.BrandedPddng.TabIndex = 1
        '
        'BrandedItemsLbl
        '
        Me.BrandedItemsLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.BrandedItemsLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandedItemsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BrandedItemsLbl.Location = New System.Drawing.Point(10, 36)
        Me.BrandedItemsLbl.Name = "BrandedItemsLbl"
        Me.BrandedItemsLbl.Size = New System.Drawing.Size(247, 31)
        Me.BrandedItemsLbl.TabIndex = 4
        Me.BrandedItemsLbl.Text = "0 items"
        '
        'BrandedLbl
        '
        Me.BrandedLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.BrandedLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandedLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BrandedLbl.Location = New System.Drawing.Point(10, 5)
        Me.BrandedLbl.Name = "BrandedLbl"
        Me.BrandedLbl.Size = New System.Drawing.Size(247, 31)
        Me.BrandedLbl.TabIndex = 3
        Me.BrandedLbl.Text = "Branded"
        Me.BrandedLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MilkSupplementsPnl
        '
        Me.MilkSupplementsPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MilkSupplementsPnl.Controls.Add(Me.MSPddng)
        Me.MilkSupplementsPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MilkSupplementsPnl.Location = New System.Drawing.Point(868, 10)
        Me.MilkSupplementsPnl.Margin = New System.Windows.Forms.Padding(10)
        Me.MilkSupplementsPnl.Name = "MilkSupplementsPnl"
        Me.MilkSupplementsPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.MilkSupplementsPnl.Size = New System.Drawing.Size(266, 80)
        Me.MilkSupplementsPnl.TabIndex = 3
        '
        'MSPddng
        '
        Me.MSPddng.BackColor = System.Drawing.Color.White
        Me.MSPddng.Controls.Add(Me.MSItemsLbl)
        Me.MSPddng.Controls.Add(Me.MSLbl)
        Me.MSPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSPddng.Location = New System.Drawing.Point(2, 2)
        Me.MSPddng.Name = "MSPddng"
        Me.MSPddng.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.MSPddng.Size = New System.Drawing.Size(262, 76)
        Me.MSPddng.TabIndex = 2
        '
        'MSItemsLbl
        '
        Me.MSItemsLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MSItemsLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSItemsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSItemsLbl.Location = New System.Drawing.Point(10, 36)
        Me.MSItemsLbl.Name = "MSItemsLbl"
        Me.MSItemsLbl.Size = New System.Drawing.Size(247, 31)
        Me.MSItemsLbl.TabIndex = 5
        Me.MSItemsLbl.Text = "0 items"
        '
        'MSLbl
        '
        Me.MSLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MSLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSLbl.Location = New System.Drawing.Point(10, 5)
        Me.MSLbl.Name = "MSLbl"
        Me.MSLbl.Size = New System.Drawing.Size(247, 31)
        Me.MSLbl.TabIndex = 2
        Me.MSLbl.Text = "Milk Supplements"
        Me.MSLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GenericPnl
        '
        Me.GenericPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenericPnl.Controls.Add(Me.GenericPddng)
        Me.GenericPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenericPnl.Location = New System.Drawing.Point(582, 10)
        Me.GenericPnl.Margin = New System.Windows.Forms.Padding(10)
        Me.GenericPnl.Name = "GenericPnl"
        Me.GenericPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.GenericPnl.Size = New System.Drawing.Size(266, 80)
        Me.GenericPnl.TabIndex = 2
        '
        'GenericPddng
        '
        Me.GenericPddng.BackColor = System.Drawing.Color.White
        Me.GenericPddng.Controls.Add(Me.GenericItemsLbl)
        Me.GenericPddng.Controls.Add(Me.GenericLbl)
        Me.GenericPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GenericPddng.Location = New System.Drawing.Point(2, 2)
        Me.GenericPddng.Name = "GenericPddng"
        Me.GenericPddng.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.GenericPddng.Size = New System.Drawing.Size(262, 76)
        Me.GenericPddng.TabIndex = 2
        '
        'GenericItemsLbl
        '
        Me.GenericItemsLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenericItemsLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericItemsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenericItemsLbl.Location = New System.Drawing.Point(10, 36)
        Me.GenericItemsLbl.Name = "GenericItemsLbl"
        Me.GenericItemsLbl.Size = New System.Drawing.Size(247, 31)
        Me.GenericItemsLbl.TabIndex = 5
        Me.GenericItemsLbl.Text = "0 items"
        '
        'GenericLbl
        '
        Me.GenericLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenericLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenericLbl.Location = New System.Drawing.Point(10, 5)
        Me.GenericLbl.Name = "GenericLbl"
        Me.GenericLbl.Size = New System.Drawing.Size(247, 31)
        Me.GenericLbl.TabIndex = 2
        Me.GenericLbl.Text = "Generic"
        Me.GenericLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GalenicalsPnl
        '
        Me.GalenicalsPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GalenicalsPnl.Controls.Add(Me.GalenicalsPddng)
        Me.GalenicalsPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.GalenicalsPnl.Location = New System.Drawing.Point(296, 10)
        Me.GalenicalsPnl.Margin = New System.Windows.Forms.Padding(10)
        Me.GalenicalsPnl.Name = "GalenicalsPnl"
        Me.GalenicalsPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.GalenicalsPnl.Size = New System.Drawing.Size(266, 80)
        Me.GalenicalsPnl.TabIndex = 1
        '
        'GalenicalsPddng
        '
        Me.GalenicalsPddng.BackColor = System.Drawing.Color.White
        Me.GalenicalsPddng.Controls.Add(Me.GalenicalsItemsLbl)
        Me.GalenicalsPddng.Controls.Add(Me.GalenicalsLbl)
        Me.GalenicalsPddng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GalenicalsPddng.Location = New System.Drawing.Point(2, 2)
        Me.GalenicalsPddng.Name = "GalenicalsPddng"
        Me.GalenicalsPddng.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.GalenicalsPddng.Size = New System.Drawing.Size(262, 76)
        Me.GalenicalsPddng.TabIndex = 2
        '
        'GalenicalsItemsLbl
        '
        Me.GalenicalsItemsLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.GalenicalsItemsLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GalenicalsItemsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GalenicalsItemsLbl.Location = New System.Drawing.Point(10, 36)
        Me.GalenicalsItemsLbl.Name = "GalenicalsItemsLbl"
        Me.GalenicalsItemsLbl.Size = New System.Drawing.Size(247, 31)
        Me.GalenicalsItemsLbl.TabIndex = 5
        Me.GalenicalsItemsLbl.Text = "0 items"
        '
        'GalenicalsLbl
        '
        Me.GalenicalsLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.GalenicalsLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GalenicalsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GalenicalsLbl.Location = New System.Drawing.Point(10, 5)
        Me.GalenicalsLbl.Name = "GalenicalsLbl"
        Me.GalenicalsLbl.Size = New System.Drawing.Size(247, 31)
        Me.GalenicalsLbl.TabIndex = 2
        Me.GalenicalsLbl.Text = "Galenicals"
        Me.GalenicalsLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'HeaderDockPnl
        '
        Me.HeaderDockPnl.BackColor = System.Drawing.Color.White
        Me.HeaderDockPnl.Controls.Add(Me.SortLbl)
        Me.HeaderDockPnl.Controls.Add(Me.SortPnl)
        Me.HeaderDockPnl.Controls.Add(Me.FilterLbl)
        Me.HeaderDockPnl.Controls.Add(Me.FilterCmbBxPnl)
        Me.HeaderDockPnl.Controls.Add(Me.InventorySearchTxtBxPnl)
        Me.HeaderDockPnl.Controls.Add(Me.InventorySearchBtn)
        Me.HeaderDockPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDockPnl.Name = "HeaderDockPnl"
        Me.HeaderDockPnl.Size = New System.Drawing.Size(1184, 80)
        Me.HeaderDockPnl.TabIndex = 0
        '
        'SortLbl
        '
        Me.SortLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SortLbl.AutoSize = True
        Me.SortLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SortLbl.Location = New System.Drawing.Point(580, 27)
        Me.SortLbl.Name = "SortLbl"
        Me.SortLbl.Size = New System.Drawing.Size(49, 24)
        Me.SortLbl.TabIndex = 39
        Me.SortLbl.Text = "Sort"
        '
        'SortPnl
        '
        Me.SortPnl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SortPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SortPnl.Controls.Add(Me.SortCmbBx)
        Me.SortPnl.Location = New System.Drawing.Point(635, 23)
        Me.SortPnl.Name = "SortPnl"
        Me.SortPnl.Size = New System.Drawing.Size(218, 34)
        Me.SortPnl.TabIndex = 38
        '
        'SortCmbBx
        '
        Me.SortCmbBx.BackColor = System.Drawing.Color.White
        Me.SortCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SortCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SortCmbBx.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SortCmbBx.FormattingEnabled = True
        Me.SortCmbBx.Items.AddRange(New Object() {"Item (A-Z)", "Item (Z-A)", "Category (A-Z)", "Category (Z-A)", "Stock (Ascending)", "Stock (Descending)"})
        Me.SortCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.SortCmbBx.Name = "SortCmbBx"
        Me.SortCmbBx.Size = New System.Drawing.Size(214, 30)
        Me.SortCmbBx.TabIndex = 0
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'InventoryForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.IDockPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryForm"
        Me.FooterDockPnl.ResumeLayout(False)
        Me.FilterCmbBxPnl.ResumeLayout(False)
        Me.InventorySearchTxtBxPddng.ResumeLayout(False)
        Me.InventorySearchTxtBxPddng.PerformLayout()
        Me.InventorySearchTxtBxPnl.ResumeLayout(False)
        Me.IDockPanel.ResumeLayout(False)
        Me.ContentDockPnl.ResumeLayout(False)
        Me.ContentPnl.ResumeLayout(False)
        Me.InventoryTblLytPnl.ResumeLayout(False)
        Me.InventoryPnl.ResumeLayout(False)
        Me.HeaderTblLyt.ResumeLayout(False)
        Me.HeaderTblLyt.PerformLayout()
        Me.CategoryTblLyt.ResumeLayout(False)
        Me.BrandedPnl.ResumeLayout(False)
        Me.BrandedPddng.ResumeLayout(False)
        Me.MilkSupplementsPnl.ResumeLayout(False)
        Me.MSPddng.ResumeLayout(False)
        Me.GenericPnl.ResumeLayout(False)
        Me.GenericPddng.ResumeLayout(False)
        Me.GalenicalsPnl.ResumeLayout(False)
        Me.GalenicalsPddng.ResumeLayout(False)
        Me.HeaderDockPnl.ResumeLayout(False)
        Me.HeaderDockPnl.PerformLayout()
        Me.SortPnl.ResumeLayout(False)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InventorySearchBtn As Button
    Friend WithEvents FooterDockPnl As Panel
    Friend WithEvents LastBtn As Button
    Friend WithEvents NextBtn As Button
    Friend WithEvents PrevBtn As Button
    Friend WithEvents FirstBtn As Button
    Friend WithEvents CurrentOrdNumLbl As Label
    Friend WithEvents FilterLbl As Label
    Friend WithEvents FilterCmbBx As ComboBox
    Friend WithEvents FilterCmbBxPnl As Panel
    Friend WithEvents InventorySearchTxtBx As TextBox
    Friend WithEvents InventorySearchTxtBxPddng As Panel
    Friend WithEvents InventorySearchTxtBxPnl As Panel
    Friend WithEvents IDockPanel As Panel
    Friend WithEvents ContentDockPnl As Panel
    Friend WithEvents HeaderDockPnl As Panel
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents ContentPnl As Panel
    Friend WithEvents InventoryTblLytPnl As Panel
    Friend WithEvents InventoryPnl As Panel
    Friend WithEvents CategoryTblLyt As TableLayoutPanel
    Friend WithEvents BrandedPnl As Panel
    Friend WithEvents BrandedPddng As Panel
    Friend WithEvents BrandedItemsLbl As Label
    Friend WithEvents BrandedLbl As Label
    Friend WithEvents MilkSupplementsPnl As Panel
    Friend WithEvents MSPddng As Panel
    Friend WithEvents MSItemsLbl As Label
    Friend WithEvents MSLbl As Label
    Friend WithEvents GenericPnl As Panel
    Friend WithEvents GenericPddng As Panel
    Friend WithEvents GenericItemsLbl As Label
    Friend WithEvents GenericLbl As Label
    Friend WithEvents GalenicalsPnl As Panel
    Friend WithEvents GalenicalsPddng As Panel
    Friend WithEvents GalenicalsItemsLbl As Label
    Friend WithEvents GalenicalsLbl As Label
    Friend WithEvents SortLbl As Label
    Friend WithEvents SortPnl As Panel
    Friend WithEvents SortCmbBx As ComboBox
    Friend WithEvents InventoryTblLyt As TableLayoutPanel
    Friend WithEvents HeaderTblLyt As TableLayoutPanel
    Friend WithEvents CategoryLbl As Label
    Friend WithEvents ItemNameLbl As Label
    Friend WithEvents SupplierLbl As Label
    Friend WithEvents ItemIDLbl As Label
    Friend WithEvents StockLbl As Label
End Class
