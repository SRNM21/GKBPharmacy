<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistoryForm
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
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HistorySearchTxtBx = New System.Windows.Forms.TextBox()
        Me.HistorySearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.HistorySearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.FilterCmbBx = New System.Windows.Forms.ComboBox()
        Me.FilterLbl = New System.Windows.Forms.Label()
        Me.FilterCmbBxPnl = New System.Windows.Forms.Panel()
        Me.HeaderDockPnl = New System.Windows.Forms.Panel()
        Me.HistorySearchBtn = New System.Windows.Forms.Button()
        Me.LastBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.FirstBtn = New System.Windows.Forms.Button()
        Me.CurrentOrdNumLbl = New System.Windows.Forms.Label()
        Me.TotalItemsLbl = New System.Windows.Forms.Label()
        Me.OrderIDLbl = New System.Windows.Forms.Label()
        Me.ReferenceLbl = New System.Windows.Forms.Label()
        Me.HistoryTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalAmountLbl = New System.Windows.Forms.Label()
        Me.DateOrdLbl = New System.Windows.Forms.Label()
        Me.DateComLbl = New System.Windows.Forms.Label()
        Me.HistoryPnl = New System.Windows.Forms.Panel()
        Me.ContentDockPnl = New System.Windows.Forms.Panel()
        Me.FooterDockPnl = New System.Windows.Forms.Panel()
        Me.ODockPanel = New System.Windows.Forms.Panel()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistorySearchTxtBxPddng.SuspendLayout()
        Me.HistorySearchTxtBxPnl.SuspendLayout()
        Me.FilterCmbBxPnl.SuspendLayout()
        Me.HeaderDockPnl.SuspendLayout()
        Me.HeaderTblLyt.SuspendLayout()
        Me.HistoryPnl.SuspendLayout()
        Me.ContentDockPnl.SuspendLayout()
        Me.FooterDockPnl.SuspendLayout()
        Me.ODockPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'HistorySearchTxtBx
        '
        Me.HistorySearchTxtBx.BackColor = System.Drawing.Color.White
        Me.HistorySearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistorySearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorySearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.HistorySearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.HistorySearchTxtBx.Name = "HistorySearchTxtBx"
        Me.HistorySearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.HistorySearchTxtBx.TabIndex = 0
        '
        'HistorySearchTxtBxPddng
        '
        Me.HistorySearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.HistorySearchTxtBxPddng.Controls.Add(Me.HistorySearchTxtBx)
        Me.HistorySearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.HistorySearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.HistorySearchTxtBxPddng.Name = "HistorySearchTxtBxPddng"
        Me.HistorySearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.HistorySearchTxtBxPddng.TabIndex = 0
        '
        'HistorySearchTxtBxPnl
        '
        Me.HistorySearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.HistorySearchTxtBxPnl.Controls.Add(Me.HistorySearchTxtBxPddng)
        Me.HistorySearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.HistorySearchTxtBxPnl.Location = New System.Drawing.Point(20, 20)
        Me.HistorySearchTxtBxPnl.Name = "HistorySearchTxtBxPnl"
        Me.HistorySearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.HistorySearchTxtBxPnl.TabIndex = 0
        '
        'FilterCmbBx
        '
        Me.FilterCmbBx.BackColor = System.Drawing.Color.White
        Me.FilterCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FilterCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterCmbBx.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterCmbBx.FormattingEnabled = True
        Me.FilterCmbBx.Items.AddRange(New Object() {"Date Ordered (Newest to Oldest)", "Date Ordered (Oldest to Newest)", "Date Complete (Newest to Oldest)", "Date Complete (Oldest to Newest)", "Total Items (Ascending)", "Total Items Descending", "Total Amount (Ascending)", "Total Amount Descending"})
        Me.FilterCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.FilterCmbBx.Name = "FilterCmbBx"
        Me.FilterCmbBx.Size = New System.Drawing.Size(327, 30)
        Me.FilterCmbBx.TabIndex = 0
        '
        'FilterLbl
        '
        Me.FilterLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FilterLbl.AutoSize = True
        Me.FilterLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterLbl.Location = New System.Drawing.Point(770, 28)
        Me.FilterLbl.Name = "FilterLbl"
        Me.FilterLbl.Size = New System.Drawing.Size(57, 24)
        Me.FilterLbl.TabIndex = 2
        Me.FilterLbl.Text = "Filter"
        '
        'FilterCmbBxPnl
        '
        Me.FilterCmbBxPnl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FilterCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterCmbBxPnl.Controls.Add(Me.FilterCmbBx)
        Me.FilterCmbBxPnl.Location = New System.Drawing.Point(833, 23)
        Me.FilterCmbBxPnl.Name = "FilterCmbBxPnl"
        Me.FilterCmbBxPnl.Size = New System.Drawing.Size(331, 34)
        Me.FilterCmbBxPnl.TabIndex = 3
        '
        'HeaderDockPnl
        '
        Me.HeaderDockPnl.Controls.Add(Me.FilterLbl)
        Me.HeaderDockPnl.Controls.Add(Me.FilterCmbBxPnl)
        Me.HeaderDockPnl.Controls.Add(Me.HistorySearchTxtBxPnl)
        Me.HeaderDockPnl.Controls.Add(Me.HistorySearchBtn)
        Me.HeaderDockPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDockPnl.Name = "HeaderDockPnl"
        Me.HeaderDockPnl.Size = New System.Drawing.Size(1184, 80)
        Me.HeaderDockPnl.TabIndex = 0
        '
        'HistorySearchBtn
        '
        Me.HistorySearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.HistorySearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.HistorySearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HistorySearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistorySearchBtn.FlatAppearance.BorderSize = 0
        Me.HistorySearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistorySearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorySearchBtn.ForeColor = System.Drawing.Color.White
        Me.HistorySearchBtn.Location = New System.Drawing.Point(424, 20)
        Me.HistorySearchBtn.Name = "HistorySearchBtn"
        Me.HistorySearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.HistorySearchBtn.TabIndex = 1
        Me.HistorySearchBtn.UseVisualStyleBackColor = False
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
        Me.LastBtn.TabIndex = 4
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
        Me.NextBtn.TabIndex = 3
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
        Me.PrevBtn.TabIndex = 2
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
        Me.FirstBtn.TabIndex = 1
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
        Me.CurrentOrdNumLbl.TabIndex = 0
        Me.CurrentOrdNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalItemsLbl
        '
        Me.TotalItemsLbl.AutoSize = True
        Me.TotalItemsLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalItemsLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalItemsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalItemsLbl.Location = New System.Drawing.Point(341, 0)
        Me.TotalItemsLbl.Name = "TotalItemsLbl"
        Me.TotalItemsLbl.Size = New System.Drawing.Size(116, 40)
        Me.TotalItemsLbl.TabIndex = 2
        Me.TotalItemsLbl.Text = "Total Items"
        Me.TotalItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderIDLbl
        '
        Me.OrderIDLbl.AutoSize = True
        Me.OrderIDLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderIDLbl.Location = New System.Drawing.Point(172, 0)
        Me.OrderIDLbl.Name = "OrderIDLbl"
        Me.OrderIDLbl.Size = New System.Drawing.Size(163, 40)
        Me.OrderIDLbl.TabIndex = 1
        Me.OrderIDLbl.Text = "Order ID"
        Me.OrderIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReferenceLbl
        '
        Me.ReferenceLbl.AutoSize = True
        Me.ReferenceLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReferenceLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenceLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ReferenceLbl.Location = New System.Drawing.Point(3, 0)
        Me.ReferenceLbl.Name = "ReferenceLbl"
        Me.ReferenceLbl.Size = New System.Drawing.Size(163, 40)
        Me.ReferenceLbl.TabIndex = 0
        Me.ReferenceLbl.Text = "Reference No."
        Me.ReferenceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistoryTblLyt
        '
        Me.HistoryTblLyt.AutoScroll = True
        Me.HistoryTblLyt.ColumnCount = 7
        Me.HistoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HistoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HistoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71428!))
        Me.HistoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HistoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HistoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HistoryTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HistoryTblLyt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryTblLyt.Location = New System.Drawing.Point(2, 42)
        Me.HistoryTblLyt.Name = "HistoryTblLyt"
        Me.HistoryTblLyt.RowCount = 1
        Me.HistoryTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HistoryTblLyt.Size = New System.Drawing.Size(1140, 527)
        Me.HistoryTblLyt.TabIndex = 1
        '
        'HeaderTblLyt
        '
        Me.HeaderTblLyt.BackColor = System.Drawing.Color.White
        Me.HeaderTblLyt.ColumnCount = 7
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71428!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88095!))
        Me.HeaderTblLyt.Controls.Add(Me.TotalItemsLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.OrderIDLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.ReferenceLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.TotalAmountLbl, 3, 0)
        Me.HeaderTblLyt.Controls.Add(Me.DateOrdLbl, 4, 0)
        Me.HeaderTblLyt.Controls.Add(Me.DateComLbl, 5, 0)
        Me.HeaderTblLyt.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderTblLyt.Location = New System.Drawing.Point(2, 2)
        Me.HeaderTblLyt.Name = "HeaderTblLyt"
        Me.HeaderTblLyt.RowCount = 1
        Me.HeaderTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HeaderTblLyt.Size = New System.Drawing.Size(1140, 40)
        Me.HeaderTblLyt.TabIndex = 0
        '
        'TotalAmountLbl
        '
        Me.TotalAmountLbl.AutoSize = True
        Me.TotalAmountLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalAmountLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TotalAmountLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalAmountLbl.Location = New System.Drawing.Point(463, 0)
        Me.TotalAmountLbl.Name = "TotalAmountLbl"
        Me.TotalAmountLbl.Size = New System.Drawing.Size(163, 40)
        Me.TotalAmountLbl.TabIndex = 3
        Me.TotalAmountLbl.Text = "Total Amount"
        Me.TotalAmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateOrdLbl
        '
        Me.DateOrdLbl.AutoSize = True
        Me.DateOrdLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateOrdLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DateOrdLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DateOrdLbl.Location = New System.Drawing.Point(632, 0)
        Me.DateOrdLbl.Name = "DateOrdLbl"
        Me.DateOrdLbl.Size = New System.Drawing.Size(163, 40)
        Me.DateOrdLbl.TabIndex = 4
        Me.DateOrdLbl.Text = "Date Ordered"
        Me.DateOrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateComLbl
        '
        Me.DateComLbl.AutoSize = True
        Me.DateComLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateComLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DateComLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DateComLbl.Location = New System.Drawing.Point(801, 0)
        Me.DateComLbl.Name = "DateComLbl"
        Me.DateComLbl.Size = New System.Drawing.Size(163, 40)
        Me.DateComLbl.TabIndex = 5
        Me.DateComLbl.Text = "Date Complete"
        Me.DateComLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistoryPnl
        '
        Me.HistoryPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.HistoryPnl.Controls.Add(Me.HistoryTblLyt)
        Me.HistoryPnl.Controls.Add(Me.HeaderTblLyt)
        Me.HistoryPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryPnl.Location = New System.Drawing.Point(20, 0)
        Me.HistoryPnl.Name = "HistoryPnl"
        Me.HistoryPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.HistoryPnl.Size = New System.Drawing.Size(1144, 571)
        Me.HistoryPnl.TabIndex = 0
        '
        'ContentDockPnl
        '
        Me.ContentDockPnl.BackColor = System.Drawing.Color.White
        Me.ContentDockPnl.Controls.Add(Me.HistoryPnl)
        Me.ContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentDockPnl.Location = New System.Drawing.Point(0, 80)
        Me.ContentDockPnl.Name = "ContentDockPnl"
        Me.ContentDockPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ContentDockPnl.Size = New System.Drawing.Size(1184, 571)
        Me.ContentDockPnl.TabIndex = 1
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
        Me.FooterDockPnl.TabIndex = 2
        '
        'ODockPanel
        '
        Me.ODockPanel.Controls.Add(Me.ContentDockPnl)
        Me.ODockPanel.Controls.Add(Me.FooterDockPnl)
        Me.ODockPanel.Controls.Add(Me.HeaderDockPnl)
        Me.ODockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ODockPanel.Location = New System.Drawing.Point(0, 0)
        Me.ODockPanel.Name = "ODockPanel"
        Me.ODockPanel.Size = New System.Drawing.Size(1184, 721)
        Me.ODockPanel.TabIndex = 1
        '
        'HistoryForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.ODockPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HistoryForm"
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistorySearchTxtBxPddng.ResumeLayout(False)
        Me.HistorySearchTxtBxPddng.PerformLayout()
        Me.HistorySearchTxtBxPnl.ResumeLayout(False)
        Me.FilterCmbBxPnl.ResumeLayout(False)
        Me.HeaderDockPnl.ResumeLayout(False)
        Me.HeaderDockPnl.PerformLayout()
        Me.HeaderTblLyt.ResumeLayout(False)
        Me.HeaderTblLyt.PerformLayout()
        Me.HistoryPnl.ResumeLayout(False)
        Me.ContentDockPnl.ResumeLayout(False)
        Me.FooterDockPnl.ResumeLayout(False)
        Me.ODockPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents ODockPanel As Panel
    Friend WithEvents ContentDockPnl As Panel
    Friend WithEvents HistoryPnl As Panel
    Friend WithEvents HistoryTblLyt As TableLayoutPanel
    Friend WithEvents HeaderTblLyt As TableLayoutPanel
    Friend WithEvents TotalItemsLbl As Label
    Friend WithEvents OrderIDLbl As Label
    Friend WithEvents ReferenceLbl As Label
    Friend WithEvents FooterDockPnl As Panel
    Friend WithEvents LastBtn As Button
    Friend WithEvents NextBtn As Button
    Friend WithEvents PrevBtn As Button
    Friend WithEvents FirstBtn As Button
    Friend WithEvents CurrentOrdNumLbl As Label
    Friend WithEvents HeaderDockPnl As Panel
    Friend WithEvents FilterLbl As Label
    Friend WithEvents FilterCmbBxPnl As Panel
    Friend WithEvents FilterCmbBx As ComboBox
    Friend WithEvents HistorySearchTxtBxPnl As Panel
    Friend WithEvents HistorySearchTxtBxPddng As Panel
    Friend WithEvents HistorySearchTxtBx As TextBox
    Friend WithEvents HistorySearchBtn As Button
    Friend WithEvents TotalAmountLbl As Label
    Friend WithEvents DateOrdLbl As Label
    Friend WithEvents DateComLbl As Label
End Class
