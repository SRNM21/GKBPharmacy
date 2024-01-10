<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceInfoForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceInfoForm))
        Me.IDGVPnl = New System.Windows.Forms.Panel()
        Me.IDGV = New System.Windows.Forms.DataGridView()
        Me.HeaderPnl = New System.Windows.Forms.Panel()
        Me.InfoPnl = New System.Windows.Forms.Panel()
        Me.TranInfoSeperator = New System.Windows.Forms.SplitContainer()
        Me.PharmacistPnl = New System.Windows.Forms.Panel()
        Me.PharmacitsName = New System.Windows.Forms.Label()
        Me.PhoneNum = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.PhoneNumLbl = New System.Windows.Forms.Label()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.PGenderLbl = New System.Windows.Forms.Label()
        Me.PGender = New System.Windows.Forms.Label()
        Me.PharmacistID = New System.Windows.Forms.Label()
        Me.PharmacistNameLbl = New System.Windows.Forms.Label()
        Me.PharmacistIDLbl = New System.Windows.Forms.Label()
        Me.CustomerPnl = New System.Windows.Forms.Panel()
        Me.OrderID = New System.Windows.Forms.Label()
        Me.OrderIDLbl = New System.Windows.Forms.Label()
        Me.CustomerName = New System.Windows.Forms.Label()
        Me.CGenderLbl = New System.Windows.Forms.Label()
        Me.CGender = New System.Windows.Forms.Label()
        Me.CustomerID = New System.Windows.Forms.Label()
        Me.CustomerNameLbl = New System.Windows.Forms.Label()
        Me.CustomerIDLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.FooterPnl = New System.Windows.Forms.Panel()
        Me.DetailsSplitter = New System.Windows.Forms.SplitContainer()
        Me.InvoicePnl = New System.Windows.Forms.Panel()
        Me.DateOrdCmplt = New System.Windows.Forms.Label()
        Me.Invoice = New System.Windows.Forms.Label()
        Me.DateOrdCmpltLbl = New System.Windows.Forms.Label()
        Me.InvoiceNoLbl = New System.Windows.Forms.Label()
        Me.TotalAmountPnl = New System.Windows.Forms.Panel()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.TotalAmountLbl = New System.Windows.Forms.Label()
        Me.IDGVPnl.SuspendLayout()
        CType(Me.IDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPnl.SuspendLayout()
        Me.InfoPnl.SuspendLayout()
        CType(Me.TranInfoSeperator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TranInfoSeperator.Panel1.SuspendLayout()
        Me.TranInfoSeperator.Panel2.SuspendLayout()
        Me.TranInfoSeperator.SuspendLayout()
        Me.PharmacistPnl.SuspendLayout()
        Me.CustomerPnl.SuspendLayout()
        Me.FooterPnl.SuspendLayout()
        CType(Me.DetailsSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsSplitter.Panel1.SuspendLayout()
        Me.DetailsSplitter.Panel2.SuspendLayout()
        Me.DetailsSplitter.SuspendLayout()
        Me.InvoicePnl.SuspendLayout()
        Me.TotalAmountPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDGVPnl
        '
        Me.IDGVPnl.Controls.Add(Me.IDGV)
        Me.IDGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDGVPnl.Location = New System.Drawing.Point(0, 277)
        Me.IDGVPnl.Name = "IDGVPnl"
        Me.IDGVPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.IDGVPnl.Size = New System.Drawing.Size(1184, 444)
        Me.IDGVPnl.TabIndex = 43
        '
        'IDGV
        '
        Me.IDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.IDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.IDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.IDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.IDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDGV.EnableHeadersVisualStyles = False
        Me.IDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.IDGV.Location = New System.Drawing.Point(20, 0)
        Me.IDGV.Name = "IDGV"
        Me.IDGV.ReadOnly = True
        Me.IDGV.RowHeadersVisible = False
        Me.IDGV.Size = New System.Drawing.Size(1144, 444)
        Me.IDGV.TabIndex = 2
        '
        'HeaderPnl
        '
        Me.HeaderPnl.Controls.Add(Me.InfoPnl)
        Me.HeaderPnl.Controls.Add(Me.BackBtn)
        Me.HeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPnl.Name = "HeaderPnl"
        Me.HeaderPnl.Size = New System.Drawing.Size(1184, 277)
        Me.HeaderPnl.TabIndex = 41
        '
        'InfoPnl
        '
        Me.InfoPnl.Controls.Add(Me.TranInfoSeperator)
        Me.InfoPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InfoPnl.Location = New System.Drawing.Point(0, 56)
        Me.InfoPnl.Name = "InfoPnl"
        Me.InfoPnl.Padding = New System.Windows.Forms.Padding(20)
        Me.InfoPnl.Size = New System.Drawing.Size(1184, 221)
        Me.InfoPnl.TabIndex = 39
        '
        'TranInfoSeperator
        '
        Me.TranInfoSeperator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TranInfoSeperator.IsSplitterFixed = True
        Me.TranInfoSeperator.Location = New System.Drawing.Point(20, 20)
        Me.TranInfoSeperator.Name = "TranInfoSeperator"
        '
        'TranInfoSeperator.Panel1
        '
        Me.TranInfoSeperator.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TranInfoSeperator.Panel1.Controls.Add(Me.PharmacistPnl)
        Me.TranInfoSeperator.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'TranInfoSeperator.Panel2
        '
        Me.TranInfoSeperator.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TranInfoSeperator.Panel2.Controls.Add(Me.CustomerPnl)
        Me.TranInfoSeperator.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.TranInfoSeperator.Size = New System.Drawing.Size(1144, 181)
        Me.TranInfoSeperator.SplitterDistance = 552
        Me.TranInfoSeperator.SplitterWidth = 40
        Me.TranInfoSeperator.TabIndex = 43
        '
        'PharmacistPnl
        '
        Me.PharmacistPnl.BackColor = System.Drawing.Color.White
        Me.PharmacistPnl.Controls.Add(Me.PharmacitsName)
        Me.PharmacistPnl.Controls.Add(Me.PhoneNum)
        Me.PharmacistPnl.Controls.Add(Me.Email)
        Me.PharmacistPnl.Controls.Add(Me.PhoneNumLbl)
        Me.PharmacistPnl.Controls.Add(Me.EmailLbl)
        Me.PharmacistPnl.Controls.Add(Me.PGenderLbl)
        Me.PharmacistPnl.Controls.Add(Me.PGender)
        Me.PharmacistPnl.Controls.Add(Me.PharmacistID)
        Me.PharmacistPnl.Controls.Add(Me.PharmacistNameLbl)
        Me.PharmacistPnl.Controls.Add(Me.PharmacistIDLbl)
        Me.PharmacistPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PharmacistPnl.Location = New System.Drawing.Point(2, 2)
        Me.PharmacistPnl.Name = "PharmacistPnl"
        Me.PharmacistPnl.Size = New System.Drawing.Size(548, 177)
        Me.PharmacistPnl.TabIndex = 0
        '
        'PharmacitsName
        '
        Me.PharmacitsName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacitsName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PharmacitsName.Location = New System.Drawing.Point(190, 47)
        Me.PharmacitsName.Name = "PharmacitsName"
        Me.PharmacitsName.Size = New System.Drawing.Size(343, 22)
        Me.PharmacitsName.TabIndex = 63
        Me.PharmacitsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PhoneNum
        '
        Me.PhoneNum.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNum.Location = New System.Drawing.Point(190, 146)
        Me.PhoneNum.Name = "PhoneNum"
        Me.PhoneNum.Size = New System.Drawing.Size(343, 22)
        Me.PhoneNum.TabIndex = 62
        Me.PhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Email.Location = New System.Drawing.Point(190, 113)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(343, 22)
        Me.Email.TabIndex = 61
        Me.Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PhoneNumLbl
        '
        Me.PhoneNumLbl.AutoSize = True
        Me.PhoneNumLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNumLbl.Location = New System.Drawing.Point(12, 146)
        Me.PhoneNumLbl.Name = "PhoneNumLbl"
        Me.PhoneNumLbl.Size = New System.Drawing.Size(147, 22)
        Me.PhoneNumLbl.TabIndex = 60
        Me.PhoneNumLbl.Text = "Phone number"
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.EmailLbl.Location = New System.Drawing.Point(12, 113)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(61, 22)
        Me.EmailLbl.TabIndex = 59
        Me.EmailLbl.Text = "Email"
        '
        'PGenderLbl
        '
        Me.PGenderLbl.AutoSize = True
        Me.PGenderLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PGenderLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PGenderLbl.Location = New System.Drawing.Point(12, 80)
        Me.PGenderLbl.Name = "PGenderLbl"
        Me.PGenderLbl.Size = New System.Drawing.Size(79, 22)
        Me.PGenderLbl.TabIndex = 57
        Me.PGenderLbl.Text = "Gender"
        '
        'PGender
        '
        Me.PGender.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PGender.Location = New System.Drawing.Point(190, 80)
        Me.PGender.Name = "PGender"
        Me.PGender.Size = New System.Drawing.Size(343, 22)
        Me.PGender.TabIndex = 56
        Me.PGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PharmacistID
        '
        Me.PharmacistID.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PharmacistID.Location = New System.Drawing.Point(190, 14)
        Me.PharmacistID.Name = "PharmacistID"
        Me.PharmacistID.Size = New System.Drawing.Size(343, 22)
        Me.PharmacistID.TabIndex = 55
        Me.PharmacistID.Text = "PHA-AAA-AAA-000"
        Me.PharmacistID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PharmacistNameLbl
        '
        Me.PharmacistNameLbl.AutoSize = True
        Me.PharmacistNameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PharmacistNameLbl.Location = New System.Drawing.Point(12, 47)
        Me.PharmacistNameLbl.Name = "PharmacistNameLbl"
        Me.PharmacistNameLbl.Size = New System.Drawing.Size(172, 22)
        Me.PharmacistNameLbl.TabIndex = 54
        Me.PharmacistNameLbl.Text = "Pharmacist Name"
        '
        'PharmacistIDLbl
        '
        Me.PharmacistIDLbl.AutoSize = True
        Me.PharmacistIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PharmacistIDLbl.Location = New System.Drawing.Point(12, 14)
        Me.PharmacistIDLbl.Name = "PharmacistIDLbl"
        Me.PharmacistIDLbl.Size = New System.Drawing.Size(139, 22)
        Me.PharmacistIDLbl.TabIndex = 53
        Me.PharmacistIDLbl.Text = "Pharmacist ID"
        '
        'CustomerPnl
        '
        Me.CustomerPnl.BackColor = System.Drawing.Color.White
        Me.CustomerPnl.Controls.Add(Me.OrderID)
        Me.CustomerPnl.Controls.Add(Me.OrderIDLbl)
        Me.CustomerPnl.Controls.Add(Me.CustomerName)
        Me.CustomerPnl.Controls.Add(Me.CGenderLbl)
        Me.CustomerPnl.Controls.Add(Me.CGender)
        Me.CustomerPnl.Controls.Add(Me.CustomerID)
        Me.CustomerPnl.Controls.Add(Me.CustomerNameLbl)
        Me.CustomerPnl.Controls.Add(Me.CustomerIDLbl)
        Me.CustomerPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerPnl.Location = New System.Drawing.Point(2, 2)
        Me.CustomerPnl.Name = "CustomerPnl"
        Me.CustomerPnl.Size = New System.Drawing.Size(548, 177)
        Me.CustomerPnl.TabIndex = 1
        '
        'OrderID
        '
        Me.OrderID.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderID.Location = New System.Drawing.Point(170, 113)
        Me.OrderID.Name = "OrderID"
        Me.OrderID.Size = New System.Drawing.Size(364, 22)
        Me.OrderID.TabIndex = 71
        Me.OrderID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderIDLbl
        '
        Me.OrderIDLbl.AutoSize = True
        Me.OrderIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderIDLbl.Location = New System.Drawing.Point(11, 113)
        Me.OrderIDLbl.Name = "OrderIDLbl"
        Me.OrderIDLbl.Size = New System.Drawing.Size(88, 22)
        Me.OrderIDLbl.TabIndex = 69
        Me.OrderIDLbl.Text = "Order ID"
        '
        'CustomerName
        '
        Me.CustomerName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerName.Location = New System.Drawing.Point(170, 47)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(364, 22)
        Me.CustomerName.TabIndex = 68
        Me.CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CGenderLbl
        '
        Me.CGenderLbl.AutoSize = True
        Me.CGenderLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CGenderLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CGenderLbl.Location = New System.Drawing.Point(11, 80)
        Me.CGenderLbl.Name = "CGenderLbl"
        Me.CGenderLbl.Size = New System.Drawing.Size(79, 22)
        Me.CGenderLbl.TabIndex = 67
        Me.CGenderLbl.Text = "Gender"
        '
        'CGender
        '
        Me.CGender.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CGender.Location = New System.Drawing.Point(170, 80)
        Me.CGender.Name = "CGender"
        Me.CGender.Size = New System.Drawing.Size(364, 22)
        Me.CGender.TabIndex = 66
        Me.CGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomerID
        '
        Me.CustomerID.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerID.Location = New System.Drawing.Point(170, 14)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(364, 22)
        Me.CustomerID.TabIndex = 65
        Me.CustomerID.Text = "CST-AAA-AAA-000"
        Me.CustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomerNameLbl
        '
        Me.CustomerNameLbl.AutoSize = True
        Me.CustomerNameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerNameLbl.Location = New System.Drawing.Point(11, 47)
        Me.CustomerNameLbl.Name = "CustomerNameLbl"
        Me.CustomerNameLbl.Size = New System.Drawing.Size(158, 22)
        Me.CustomerNameLbl.TabIndex = 64
        Me.CustomerNameLbl.Text = "Customer Name"
        '
        'CustomerIDLbl
        '
        Me.CustomerIDLbl.AutoSize = True
        Me.CustomerIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerIDLbl.Location = New System.Drawing.Point(11, 14)
        Me.CustomerIDLbl.Name = "CustomerIDLbl"
        Me.CustomerIDLbl.Size = New System.Drawing.Size(125, 22)
        Me.CustomerIDLbl.TabIndex = 63
        Me.CustomerIDLbl.Text = "Customer ID"
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
        Me.BackBtn.TabIndex = 38
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'FooterPnl
        '
        Me.FooterPnl.Controls.Add(Me.DetailsSplitter)
        Me.FooterPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterPnl.Location = New System.Drawing.Point(0, 589)
        Me.FooterPnl.Name = "FooterPnl"
        Me.FooterPnl.Padding = New System.Windows.Forms.Padding(20)
        Me.FooterPnl.Size = New System.Drawing.Size(1184, 132)
        Me.FooterPnl.TabIndex = 42
        '
        'DetailsSplitter
        '
        Me.DetailsSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailsSplitter.IsSplitterFixed = True
        Me.DetailsSplitter.Location = New System.Drawing.Point(20, 20)
        Me.DetailsSplitter.Name = "DetailsSplitter"
        '
        'DetailsSplitter.Panel1
        '
        Me.DetailsSplitter.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DetailsSplitter.Panel1.Controls.Add(Me.InvoicePnl)
        Me.DetailsSplitter.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'DetailsSplitter.Panel2
        '
        Me.DetailsSplitter.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DetailsSplitter.Panel2.Controls.Add(Me.TotalAmountPnl)
        Me.DetailsSplitter.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.DetailsSplitter.Size = New System.Drawing.Size(1144, 92)
        Me.DetailsSplitter.SplitterDistance = 552
        Me.DetailsSplitter.SplitterWidth = 40
        Me.DetailsSplitter.TabIndex = 44
        '
        'InvoicePnl
        '
        Me.InvoicePnl.BackColor = System.Drawing.Color.White
        Me.InvoicePnl.Controls.Add(Me.DateOrdCmplt)
        Me.InvoicePnl.Controls.Add(Me.Invoice)
        Me.InvoicePnl.Controls.Add(Me.DateOrdCmpltLbl)
        Me.InvoicePnl.Controls.Add(Me.InvoiceNoLbl)
        Me.InvoicePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InvoicePnl.Location = New System.Drawing.Point(2, 2)
        Me.InvoicePnl.Name = "InvoicePnl"
        Me.InvoicePnl.Size = New System.Drawing.Size(548, 88)
        Me.InvoicePnl.TabIndex = 0
        '
        'DateOrdCmplt
        '
        Me.DateOrdCmplt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOrdCmplt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DateOrdCmplt.Location = New System.Drawing.Point(230, 47)
        Me.DateOrdCmplt.Name = "DateOrdCmplt"
        Me.DateOrdCmplt.Size = New System.Drawing.Size(282, 22)
        Me.DateOrdCmplt.TabIndex = 58
        Me.DateOrdCmplt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Invoice
        '
        Me.Invoice.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Invoice.Location = New System.Drawing.Point(226, 14)
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Size = New System.Drawing.Size(286, 22)
        Me.Invoice.TabIndex = 55
        Me.Invoice.Text = "INV-AAA-AAA-000"
        Me.Invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOrdCmpltLbl
        '
        Me.DateOrdCmpltLbl.AutoSize = True
        Me.DateOrdCmpltLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOrdCmpltLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DateOrdCmpltLbl.Location = New System.Drawing.Point(12, 47)
        Me.DateOrdCmpltLbl.Name = "DateOrdCmpltLbl"
        Me.DateOrdCmpltLbl.Size = New System.Drawing.Size(204, 22)
        Me.DateOrdCmpltLbl.TabIndex = 54
        Me.DateOrdCmpltLbl.Text = "Date Order Complete"
        '
        'InvoiceNoLbl
        '
        Me.InvoiceNoLbl.AutoSize = True
        Me.InvoiceNoLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceNoLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.InvoiceNoLbl.Location = New System.Drawing.Point(12, 14)
        Me.InvoiceNoLbl.Name = "InvoiceNoLbl"
        Me.InvoiceNoLbl.Size = New System.Drawing.Size(112, 22)
        Me.InvoiceNoLbl.TabIndex = 53
        Me.InvoiceNoLbl.Text = "Invoice No."
        '
        'TotalAmountPnl
        '
        Me.TotalAmountPnl.BackColor = System.Drawing.Color.White
        Me.TotalAmountPnl.Controls.Add(Me.TotalAmount)
        Me.TotalAmountPnl.Controls.Add(Me.TotalAmountLbl)
        Me.TotalAmountPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalAmountPnl.Location = New System.Drawing.Point(2, 2)
        Me.TotalAmountPnl.Name = "TotalAmountPnl"
        Me.TotalAmountPnl.Size = New System.Drawing.Size(548, 88)
        Me.TotalAmountPnl.TabIndex = 1
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalAmount.Location = New System.Drawing.Point(9, 40)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(70, 32)
        Me.TotalAmount.TabIndex = 64
        Me.TotalAmount.Text = "PHP"
        '
        'TotalAmountLbl
        '
        Me.TotalAmountLbl.AutoSize = True
        Me.TotalAmountLbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TotalAmountLbl.Location = New System.Drawing.Point(11, 14)
        Me.TotalAmountLbl.Name = "TotalAmountLbl"
        Me.TotalAmountLbl.Size = New System.Drawing.Size(109, 19)
        Me.TotalAmountLbl.TabIndex = 63
        Me.TotalAmountLbl.Text = "Total Amount"
        '
        'InvoiceInfoForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.FooterPnl)
        Me.Controls.Add(Me.IDGVPnl)
        Me.Controls.Add(Me.HeaderPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InvoiceInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ReferenceInfoForm"
        Me.IDGVPnl.ResumeLayout(False)
        CType(Me.IDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPnl.ResumeLayout(False)
        Me.InfoPnl.ResumeLayout(False)
        Me.TranInfoSeperator.Panel1.ResumeLayout(False)
        Me.TranInfoSeperator.Panel2.ResumeLayout(False)
        CType(Me.TranInfoSeperator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TranInfoSeperator.ResumeLayout(False)
        Me.PharmacistPnl.ResumeLayout(False)
        Me.PharmacistPnl.PerformLayout()
        Me.CustomerPnl.ResumeLayout(False)
        Me.CustomerPnl.PerformLayout()
        Me.FooterPnl.ResumeLayout(False)
        Me.DetailsSplitter.Panel1.ResumeLayout(False)
        Me.DetailsSplitter.Panel2.ResumeLayout(False)
        CType(Me.DetailsSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsSplitter.ResumeLayout(False)
        Me.InvoicePnl.ResumeLayout(False)
        Me.InvoicePnl.PerformLayout()
        Me.TotalAmountPnl.ResumeLayout(False)
        Me.TotalAmountPnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IDGVPnl As Panel
    Friend WithEvents IDGV As DataGridView
    Friend WithEvents HeaderPnl As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents FooterPnl As Panel
    Friend WithEvents InfoPnl As Panel
    Friend WithEvents TranInfoSeperator As SplitContainer
    Friend WithEvents PharmacistPnl As Panel
    Friend WithEvents PharmacitsName As Label
    Friend WithEvents PhoneNum As Label
    Friend WithEvents Email As Label
    Friend WithEvents PhoneNumLbl As Label
    Friend WithEvents EmailLbl As Label
    Friend WithEvents PGenderLbl As Label
    Friend WithEvents PGender As Label
    Friend WithEvents PharmacistID As Label
    Friend WithEvents PharmacistNameLbl As Label
    Friend WithEvents PharmacistIDLbl As Label
    Friend WithEvents CustomerPnl As Panel
    Friend WithEvents OrderID As Label
    Friend WithEvents OrderIDLbl As Label
    Friend WithEvents CustomerName As Label
    Friend WithEvents CGenderLbl As Label
    Friend WithEvents CGender As Label
    Friend WithEvents CustomerID As Label
    Friend WithEvents CustomerNameLbl As Label
    Friend WithEvents CustomerIDLbl As Label
    Friend WithEvents DetailsSplitter As SplitContainer
    Friend WithEvents InvoicePnl As Panel
    Friend WithEvents DateOrdCmplt As Label
    Friend WithEvents Invoice As Label
    Friend WithEvents DateOrdCmpltLbl As Label
    Friend WithEvents InvoiceNoLbl As Label
    Friend WithEvents TotalAmountPnl As Panel
    Friend WithEvents TotalAmount As Label
    Friend WithEvents TotalAmountLbl As Label
End Class
