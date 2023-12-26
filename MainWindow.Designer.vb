<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TitleNLogoPnl = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.HeaderPnl = New System.Windows.Forms.Panel()
        Me.CurrentPnlLbl = New System.Windows.Forms.Label()
        Me.DateAndTimePnl = New System.Windows.Forms.Panel()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.TimerTick = New System.Windows.Forms.Timer(Me.components)
        Me.SideMenuPnl = New System.Windows.Forms.Panel()
        Me.AccountPnl = New System.Windows.Forms.Panel()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.LastNameLbl = New System.Windows.Forms.Label()
        Me.MenuPnlFlwLyt = New System.Windows.Forms.FlowLayoutPanel()
        Me.AdminFlwLyt = New System.Windows.Forms.FlowLayoutPanel()
        Me.MngPhrmcstBtn = New System.Windows.Forms.Button()
        Me.MngAccntBtn = New System.Windows.Forms.Button()
        Me.MngCstmrBtn = New System.Windows.Forms.Button()
        Me.MngOrdersBtn = New System.Windows.Forms.Button()
        Me.MngItemsBtn = New System.Windows.Forms.Button()
        Me.MngSpplr = New System.Windows.Forms.Button()
        Me.Seperator = New System.Windows.Forms.Label()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.OrdersBtn = New System.Windows.Forms.Button()
        Me.InvntryBtn = New System.Windows.Forms.Button()
        Me.SpplrBtn = New System.Windows.Forms.Button()
        Me.HstryBtn = New System.Windows.Forms.Button()
        Me.LogOutBtn = New System.Windows.Forms.Button()
        Me.SwitchWindowPnl = New System.Windows.Forms.Panel()
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.TitleNLogoPnl.SuspendLayout()
        Me.HeaderPnl.SuspendLayout()
        Me.DateAndTimePnl.SuspendLayout()
        Me.SideMenuPnl.SuspendLayout()
        Me.AccountPnl.SuspendLayout()
        Me.MenuPnlFlwLyt.SuspendLayout()
        Me.AdminFlwLyt.SuspendLayout()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleNLogoPnl
        '
        Me.TitleNLogoPnl.BackColor = System.Drawing.Color.White
        Me.TitleNLogoPnl.Controls.Add(Me.Title)
        Me.TitleNLogoPnl.Controls.Add(Me.Logo)
        Me.TitleNLogoPnl.Location = New System.Drawing.Point(0, 0)
        Me.TitleNLogoPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.TitleNLogoPnl.Name = "TitleNLogoPnl"
        Me.TitleNLogoPnl.Size = New System.Drawing.Size(262, 91)
        Me.TitleNLogoPnl.TabIndex = 0
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(102, 23)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(150, 44)
        Me.Title.TabIndex = 1
        Me.Title.Text = "GKB Pharmacy"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HeaderPnl
        '
        Me.HeaderPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.HeaderPnl.Controls.Add(Me.TitleNLogoPnl)
        Me.HeaderPnl.Controls.Add(Me.CurrentPnlLbl)
        Me.HeaderPnl.Controls.Add(Me.DateAndTimePnl)
        Me.HeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPnl.Name = "HeaderPnl"
        Me.HeaderPnl.Size = New System.Drawing.Size(1444, 90)
        Me.HeaderPnl.TabIndex = 1
        '
        'CurrentPnlLbl
        '
        Me.CurrentPnlLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPnlLbl.ForeColor = System.Drawing.Color.White
        Me.CurrentPnlLbl.Location = New System.Drawing.Point(285, 3)
        Me.CurrentPnlLbl.Name = "CurrentPnlLbl"
        Me.CurrentPnlLbl.Size = New System.Drawing.Size(523, 84)
        Me.CurrentPnlLbl.TabIndex = 2
        Me.CurrentPnlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateAndTimePnl
        '
        Me.DateAndTimePnl.Controls.Add(Me.DateLbl)
        Me.DateAndTimePnl.Controls.Add(Me.TimeLbl)
        Me.DateAndTimePnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateAndTimePnl.Location = New System.Drawing.Point(851, 0)
        Me.DateAndTimePnl.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.DateAndTimePnl.Name = "DateAndTimePnl"
        Me.DateAndTimePnl.Size = New System.Drawing.Size(593, 90)
        Me.DateAndTimePnl.TabIndex = 0
        '
        'DateLbl
        '
        Me.DateLbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.ForeColor = System.Drawing.Color.White
        Me.DateLbl.Location = New System.Drawing.Point(11, 12)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.DateLbl.Size = New System.Drawing.Size(579, 33)
        Me.DateLbl.TabIndex = 1
        Me.DateLbl.Text = "Day, Month 00, 0000"
        Me.DateLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TimeLbl
        '
        Me.TimeLbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.ForeColor = System.Drawing.Color.White
        Me.TimeLbl.Location = New System.Drawing.Point(11, 45)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TimeLbl.Size = New System.Drawing.Size(579, 33)
        Me.TimeLbl.TabIndex = 0
        Me.TimeLbl.Text = "Time"
        Me.TimeLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TimerTick
        '
        Me.TimerTick.Enabled = True
        '
        'SideMenuPnl
        '
        Me.SideMenuPnl.Controls.Add(Me.AccountPnl)
        Me.SideMenuPnl.Controls.Add(Me.MenuPnlFlwLyt)
        Me.SideMenuPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideMenuPnl.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.SideMenuPnl.Location = New System.Drawing.Point(0, 90)
        Me.SideMenuPnl.Name = "SideMenuPnl"
        Me.SideMenuPnl.Size = New System.Drawing.Size(263, 721)
        Me.SideMenuPnl.TabIndex = 4
        '
        'AccountPnl
        '
        Me.AccountPnl.Controls.Add(Me.IDLbl)
        Me.AccountPnl.Controls.Add(Me.LastNameLbl)
        Me.AccountPnl.Controls.Add(Me.Avatar)
        Me.AccountPnl.Location = New System.Drawing.Point(0, 0)
        Me.AccountPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.AccountPnl.Name = "AccountPnl"
        Me.AccountPnl.Size = New System.Drawing.Size(261, 151)
        Me.AccountPnl.TabIndex = 3
        '
        'IDLbl
        '
        Me.IDLbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.IDLbl.Location = New System.Drawing.Point(101, 80)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.Size = New System.Drawing.Size(157, 29)
        Me.IDLbl.TabIndex = 2
        Me.IDLbl.Text = "PHA-AAA-AAA-000"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LastNameLbl
        '
        Me.LastNameLbl.AutoEllipsis = True
        Me.LastNameLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LastNameLbl.Location = New System.Drawing.Point(101, 42)
        Me.LastNameLbl.Name = "LastNameLbl"
        Me.LastNameLbl.Size = New System.Drawing.Size(157, 29)
        Me.LastNameLbl.TabIndex = 1
        Me.LastNameLbl.Text = "Lastname"
        Me.LastNameLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MenuPnlFlwLyt
        '
        Me.MenuPnlFlwLyt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuPnlFlwLyt.AutoScroll = True
        Me.MenuPnlFlwLyt.Controls.Add(Me.AdminFlwLyt)
        Me.MenuPnlFlwLyt.Controls.Add(Me.DashboardBtn)
        Me.MenuPnlFlwLyt.Controls.Add(Me.OrdersBtn)
        Me.MenuPnlFlwLyt.Controls.Add(Me.InvntryBtn)
        Me.MenuPnlFlwLyt.Controls.Add(Me.SpplrBtn)
        Me.MenuPnlFlwLyt.Controls.Add(Me.HstryBtn)
        Me.MenuPnlFlwLyt.Controls.Add(Me.LogOutBtn)
        Me.MenuPnlFlwLyt.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MenuPnlFlwLyt.Location = New System.Drawing.Point(0, 151)
        Me.MenuPnlFlwLyt.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuPnlFlwLyt.Name = "MenuPnlFlwLyt"
        Me.MenuPnlFlwLyt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuPnlFlwLyt.Size = New System.Drawing.Size(264, 568)
        Me.MenuPnlFlwLyt.TabIndex = 4
        Me.MenuPnlFlwLyt.WrapContents = False
        '
        'AdminFlwLyt
        '
        Me.AdminFlwLyt.Controls.Add(Me.MngPhrmcstBtn)
        Me.AdminFlwLyt.Controls.Add(Me.MngAccntBtn)
        Me.AdminFlwLyt.Controls.Add(Me.MngCstmrBtn)
        Me.AdminFlwLyt.Controls.Add(Me.MngOrdersBtn)
        Me.AdminFlwLyt.Controls.Add(Me.MngItemsBtn)
        Me.AdminFlwLyt.Controls.Add(Me.MngSpplr)
        Me.AdminFlwLyt.Controls.Add(Me.Seperator)
        Me.AdminFlwLyt.Location = New System.Drawing.Point(0, 0)
        Me.AdminFlwLyt.Margin = New System.Windows.Forms.Padding(0)
        Me.AdminFlwLyt.Name = "AdminFlwLyt"
        Me.AdminFlwLyt.Size = New System.Drawing.Size(233, 342)
        Me.AdminFlwLyt.TabIndex = 17
        '
        'MngPhrmcstBtn
        '
        Me.MngPhrmcstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MngPhrmcstBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MngPhrmcstBtn.FlatAppearance.BorderSize = 0
        Me.MngPhrmcstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MngPhrmcstBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngPhrmcstBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MngPhrmcstBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Phrmcst
        Me.MngPhrmcstBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngPhrmcstBtn.Location = New System.Drawing.Point(3, 3)
        Me.MngPhrmcstBtn.Name = "MngPhrmcstBtn"
        Me.MngPhrmcstBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.MngPhrmcstBtn.Size = New System.Drawing.Size(230, 50)
        Me.MngPhrmcstBtn.TabIndex = 6
        Me.MngPhrmcstBtn.Text = "Manage Pharmacist"
        Me.MngPhrmcstBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngPhrmcstBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MngPhrmcstBtn.UseVisualStyleBackColor = True
        '
        'MngAccntBtn
        '
        Me.MngAccntBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MngAccntBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MngAccntBtn.FlatAppearance.BorderSize = 0
        Me.MngAccntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MngAccntBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngAccntBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MngAccntBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Sttngs
        Me.MngAccntBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngAccntBtn.Location = New System.Drawing.Point(3, 59)
        Me.MngAccntBtn.Name = "MngAccntBtn"
        Me.MngAccntBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.MngAccntBtn.Size = New System.Drawing.Size(230, 50)
        Me.MngAccntBtn.TabIndex = 16
        Me.MngAccntBtn.Text = "Manage Account"
        Me.MngAccntBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngAccntBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MngAccntBtn.UseVisualStyleBackColor = True
        '
        'MngCstmrBtn
        '
        Me.MngCstmrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MngCstmrBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MngCstmrBtn.FlatAppearance.BorderSize = 0
        Me.MngCstmrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MngCstmrBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngCstmrBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MngCstmrBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Cstmr
        Me.MngCstmrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngCstmrBtn.Location = New System.Drawing.Point(3, 115)
        Me.MngCstmrBtn.Name = "MngCstmrBtn"
        Me.MngCstmrBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.MngCstmrBtn.Size = New System.Drawing.Size(230, 50)
        Me.MngCstmrBtn.TabIndex = 7
        Me.MngCstmrBtn.Text = "Manage Customer"
        Me.MngCstmrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngCstmrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MngCstmrBtn.UseVisualStyleBackColor = True
        '
        'MngOrdersBtn
        '
        Me.MngOrdersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MngOrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MngOrdersBtn.FlatAppearance.BorderSize = 0
        Me.MngOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MngOrdersBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngOrdersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MngOrdersBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Order
        Me.MngOrdersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngOrdersBtn.Location = New System.Drawing.Point(3, 171)
        Me.MngOrdersBtn.Name = "MngOrdersBtn"
        Me.MngOrdersBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.MngOrdersBtn.Size = New System.Drawing.Size(230, 50)
        Me.MngOrdersBtn.TabIndex = 8
        Me.MngOrdersBtn.Text = "Manage Orders"
        Me.MngOrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngOrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MngOrdersBtn.UseVisualStyleBackColor = True
        '
        'MngItemsBtn
        '
        Me.MngItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MngItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MngItemsBtn.FlatAppearance.BorderSize = 0
        Me.MngItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MngItemsBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngItemsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MngItemsBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Items
        Me.MngItemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngItemsBtn.Location = New System.Drawing.Point(3, 227)
        Me.MngItemsBtn.Name = "MngItemsBtn"
        Me.MngItemsBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.MngItemsBtn.Size = New System.Drawing.Size(230, 50)
        Me.MngItemsBtn.TabIndex = 9
        Me.MngItemsBtn.Text = "Manage Items"
        Me.MngItemsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngItemsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MngItemsBtn.UseVisualStyleBackColor = True
        '
        'MngSpplr
        '
        Me.MngSpplr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MngSpplr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MngSpplr.FlatAppearance.BorderSize = 0
        Me.MngSpplr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MngSpplr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MngSpplr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MngSpplr.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Spplr
        Me.MngSpplr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngSpplr.Location = New System.Drawing.Point(3, 283)
        Me.MngSpplr.Name = "MngSpplr"
        Me.MngSpplr.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.MngSpplr.Size = New System.Drawing.Size(230, 50)
        Me.MngSpplr.TabIndex = 10
        Me.MngSpplr.Text = "Manage Supplier"
        Me.MngSpplr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngSpplr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MngSpplr.UseVisualStyleBackColor = True
        '
        'Seperator
        '
        Me.Seperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Seperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Seperator.Location = New System.Drawing.Point(5, 336)
        Me.Seperator.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Seperator.Name = "Seperator"
        Me.Seperator.Size = New System.Drawing.Size(230, 2)
        Me.Seperator.TabIndex = 11
        '
        'DashboardBtn
        '
        Me.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DashboardBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Dshbrd
        Me.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.Location = New System.Drawing.Point(3, 345)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.DashboardBtn.Size = New System.Drawing.Size(230, 50)
        Me.DashboardBtn.TabIndex = 7
        Me.DashboardBtn.Text = "Dashboard"
        Me.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardBtn.UseVisualStyleBackColor = True
        '
        'OrdersBtn
        '
        Me.OrdersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrdersBtn.FlatAppearance.BorderSize = 0
        Me.OrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrdersBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrdersBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Order
        Me.OrdersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrdersBtn.Location = New System.Drawing.Point(3, 401)
        Me.OrdersBtn.Name = "OrdersBtn"
        Me.OrdersBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.OrdersBtn.Size = New System.Drawing.Size(230, 50)
        Me.OrdersBtn.TabIndex = 12
        Me.OrdersBtn.Text = "Orders"
        Me.OrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OrdersBtn.UseVisualStyleBackColor = True
        '
        'InvntryBtn
        '
        Me.InvntryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.InvntryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InvntryBtn.FlatAppearance.BorderSize = 0
        Me.InvntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InvntryBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvntryBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.InvntryBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Items
        Me.InvntryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InvntryBtn.Location = New System.Drawing.Point(3, 457)
        Me.InvntryBtn.Name = "InvntryBtn"
        Me.InvntryBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.InvntryBtn.Size = New System.Drawing.Size(230, 50)
        Me.InvntryBtn.TabIndex = 13
        Me.InvntryBtn.Text = "Inventory"
        Me.InvntryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InvntryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InvntryBtn.UseVisualStyleBackColor = True
        '
        'SpplrBtn
        '
        Me.SpplrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SpplrBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SpplrBtn.FlatAppearance.BorderSize = 0
        Me.SpplrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpplrBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpplrBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SpplrBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Spplr
        Me.SpplrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SpplrBtn.Location = New System.Drawing.Point(3, 513)
        Me.SpplrBtn.Name = "SpplrBtn"
        Me.SpplrBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.SpplrBtn.Size = New System.Drawing.Size(230, 50)
        Me.SpplrBtn.TabIndex = 14
        Me.SpplrBtn.Text = "Supplier"
        Me.SpplrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SpplrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SpplrBtn.UseVisualStyleBackColor = True
        '
        'HstryBtn
        '
        Me.HstryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HstryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HstryBtn.FlatAppearance.BorderSize = 0
        Me.HstryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HstryBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HstryBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.HstryBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_Hstry
        Me.HstryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HstryBtn.Location = New System.Drawing.Point(3, 569)
        Me.HstryBtn.Name = "HstryBtn"
        Me.HstryBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.HstryBtn.Size = New System.Drawing.Size(230, 50)
        Me.HstryBtn.TabIndex = 15
        Me.HstryBtn.Text = "History"
        Me.HstryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HstryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.HstryBtn.UseVisualStyleBackColor = True
        '
        'LogOutBtn
        '
        Me.LogOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOutBtn.FlatAppearance.BorderSize = 0
        Me.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LogOutBtn.Image = Global.GKBPharmacy.My.Resources.Resources.Ico_LogOut
        Me.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogOutBtn.Location = New System.Drawing.Point(3, 625)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LogOutBtn.Size = New System.Drawing.Size(230, 50)
        Me.LogOutBtn.TabIndex = 17
        Me.LogOutBtn.Text = "Log Out"
        Me.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogOutBtn.UseVisualStyleBackColor = True
        '
        'SwitchWindowPnl
        '
        Me.SwitchWindowPnl.BackColor = System.Drawing.Color.White
        Me.SwitchWindowPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SwitchWindowPnl.Location = New System.Drawing.Point(263, 90)
        Me.SwitchWindowPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.SwitchWindowPnl.Name = "SwitchWindowPnl"
        Me.SwitchWindowPnl.Size = New System.Drawing.Size(1181, 721)
        Me.SwitchWindowPnl.TabIndex = 5
        '
        'Avatar
        '
        Me.Avatar.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.ADM_Ava
        Me.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Avatar.Location = New System.Drawing.Point(15, 35)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(80, 80)
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        '
        'Logo
        '
        Me.Logo.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.GKB_pharmacy_logo
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(12, 23)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(84, 44)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'MainWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1444, 811)
        Me.Controls.Add(Me.SwitchWindowPnl)
        Me.Controls.Add(Me.SideMenuPnl)
        Me.Controls.Add(Me.HeaderPnl)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1460, 850)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GKB Pharmacy"
        Me.TitleNLogoPnl.ResumeLayout(False)
        Me.HeaderPnl.ResumeLayout(False)
        Me.DateAndTimePnl.ResumeLayout(False)
        Me.SideMenuPnl.ResumeLayout(False)
        Me.AccountPnl.ResumeLayout(False)
        Me.MenuPnlFlwLyt.ResumeLayout(False)
        Me.AdminFlwLyt.ResumeLayout(False)
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleNLogoPnl As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents HeaderPnl As Panel
    Friend WithEvents DateAndTimePnl As Panel
    Friend WithEvents DateLbl As Label
    Friend WithEvents TimeLbl As Label
    Friend WithEvents TimerTick As Timer
    Friend WithEvents CurrentPnlLbl As Label
    Friend WithEvents SideMenuPnl As Panel
    Friend WithEvents MenuPnlFlwLyt As FlowLayoutPanel
    Friend WithEvents MngPhrmcstBtn As Button
    Friend WithEvents MngCstmrBtn As Button
    Friend WithEvents MngOrdersBtn As Button
    Friend WithEvents MngItemsBtn As Button
    Friend WithEvents MngSpplr As Button
    Friend WithEvents Seperator As Label
    Friend WithEvents OrdersBtn As Button
    Friend WithEvents InvntryBtn As Button
    Friend WithEvents SpplrBtn As Button
    Friend WithEvents HstryBtn As Button
    Friend WithEvents MngAccntBtn As Button
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents SwitchWindowPnl As Panel
    Friend WithEvents AccountPnl As Panel
    Friend WithEvents IDLbl As Label
    Friend WithEvents LastNameLbl As Label
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents AdminFlwLyt As FlowLayoutPanel
    Friend WithEvents DashboardBtn As Button
End Class
