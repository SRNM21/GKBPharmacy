<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditAccountForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditAccountForm))
        Me.APrimaryBtn = New System.Windows.Forms.Button()
        Me.PasswordTxtBxPnl = New System.Windows.Forms.Panel()
        Me.PasswordTxtBxPddng = New System.Windows.Forms.Panel()
        Me.PassShowHideBtn = New System.Windows.Forms.Button()
        Me.PasswordTxtBx = New System.Windows.Forms.TextBox()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.UsernameTxtBxPnl = New System.Windows.Forms.Panel()
        Me.UsernameTxtBxPddng = New System.Windows.Forms.Panel()
        Me.UsernameTxtBx = New System.Windows.Forms.TextBox()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.PhrmcstLbl = New System.Windows.Forms.Label()
        Me.AFormTitle = New System.Windows.Forms.Label()
        Me.AContentPnl = New System.Windows.Forms.Panel()
        Me.PharmacistIDLbl = New System.Windows.Forms.Label()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.WarningIndicatorLbl = New System.Windows.Forms.Label()
        Me.PassStrengthIndicator = New System.Windows.Forms.Label()
        Me.PassStrengthPnl = New System.Windows.Forms.Panel()
        Me.PassStrength = New System.Windows.Forms.Panel()
        Me.ConfirmPassTxtBxPnl = New System.Windows.Forms.Panel()
        Me.ConfirmPassTxtBxPddng = New System.Windows.Forms.Panel()
        Me.ConfirmPassShowHideBtn = New System.Windows.Forms.Button()
        Me.ConfirmPassTxtBx = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordLbl = New System.Windows.Forms.Label()
        Me.PhrmcstCmbBxPnl = New System.Windows.Forms.Panel()
        Me.PharmacistCmbBx = New System.Windows.Forms.ComboBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Filler = New System.Windows.Forms.PictureBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PasswordTxtBxPnl.SuspendLayout()
        Me.PasswordTxtBxPddng.SuspendLayout()
        Me.UsernameTxtBxPnl.SuspendLayout()
        Me.UsernameTxtBxPddng.SuspendLayout()
        Me.AContentPnl.SuspendLayout()
        Me.PassStrengthPnl.SuspendLayout()
        Me.ConfirmPassTxtBxPnl.SuspendLayout()
        Me.ConfirmPassTxtBxPddng.SuspendLayout()
        Me.PhrmcstCmbBxPnl.SuspendLayout()
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'APrimaryBtn
        '
        Me.APrimaryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.APrimaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.APrimaryBtn.FlatAppearance.BorderSize = 0
        Me.APrimaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.APrimaryBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APrimaryBtn.ForeColor = System.Drawing.Color.White
        Me.APrimaryBtn.Location = New System.Drawing.Point(91, 524)
        Me.APrimaryBtn.Name = "APrimaryBtn"
        Me.APrimaryBtn.Size = New System.Drawing.Size(550, 44)
        Me.APrimaryBtn.TabIndex = 13
        Me.APrimaryBtn.Text = "Create"
        Me.APrimaryBtn.UseVisualStyleBackColor = False
        '
        'PasswordTxtBxPnl
        '
        Me.PasswordTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PasswordTxtBxPnl.Controls.Add(Me.PasswordTxtBxPddng)
        Me.PasswordTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.PasswordTxtBxPnl.Location = New System.Drawing.Point(91, 329)
        Me.PasswordTxtBxPnl.Name = "PasswordTxtBxPnl"
        Me.PasswordTxtBxPnl.Size = New System.Drawing.Size(550, 38)
        Me.PasswordTxtBxPnl.TabIndex = 9
        '
        'PasswordTxtBxPddng
        '
        Me.PasswordTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.PasswordTxtBxPddng.Controls.Add(Me.PassShowHideBtn)
        Me.PasswordTxtBxPddng.Controls.Add(Me.PasswordTxtBx)
        Me.PasswordTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.PasswordTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.PasswordTxtBxPddng.Name = "PasswordTxtBxPddng"
        Me.PasswordTxtBxPddng.Size = New System.Drawing.Size(546, 34)
        Me.PasswordTxtBxPddng.TabIndex = 0
        '
        'PassShowHideBtn
        '
        Me.PassShowHideBtn.BackColor = System.Drawing.Color.Transparent
        Me.PassShowHideBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.HidePass
        Me.PassShowHideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PassShowHideBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PassShowHideBtn.FlatAppearance.BorderSize = 0
        Me.PassShowHideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassShowHideBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassShowHideBtn.ForeColor = System.Drawing.Color.White
        Me.PassShowHideBtn.Location = New System.Drawing.Point(518, 5)
        Me.PassShowHideBtn.Name = "PassShowHideBtn"
        Me.PassShowHideBtn.Size = New System.Drawing.Size(25, 25)
        Me.PassShowHideBtn.TabIndex = 1
        Me.PassShowHideBtn.UseVisualStyleBackColor = False
        '
        'PasswordTxtBx
        '
        Me.PasswordTxtBx.BackColor = System.Drawing.Color.White
        Me.PasswordTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PasswordTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.PasswordTxtBx.Name = "PasswordTxtBx"
        Me.PasswordTxtBx.Size = New System.Drawing.Size(509, 25)
        Me.PasswordTxtBx.TabIndex = 0
        Me.PasswordTxtBx.UseSystemPasswordChar = True
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PasswordLbl.Location = New System.Drawing.Point(92, 304)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(94, 22)
        Me.PasswordLbl.TabIndex = 8
        Me.PasswordLbl.Text = "Password"
        '
        'UsernameTxtBxPnl
        '
        Me.UsernameTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UsernameTxtBxPnl.Controls.Add(Me.UsernameTxtBxPddng)
        Me.UsernameTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.UsernameTxtBxPnl.Location = New System.Drawing.Point(91, 237)
        Me.UsernameTxtBxPnl.Name = "UsernameTxtBxPnl"
        Me.UsernameTxtBxPnl.Size = New System.Drawing.Size(550, 38)
        Me.UsernameTxtBxPnl.TabIndex = 7
        '
        'UsernameTxtBxPddng
        '
        Me.UsernameTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.UsernameTxtBxPddng.Controls.Add(Me.UsernameTxtBx)
        Me.UsernameTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.UsernameTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.UsernameTxtBxPddng.Name = "UsernameTxtBxPddng"
        Me.UsernameTxtBxPddng.Size = New System.Drawing.Size(546, 34)
        Me.UsernameTxtBxPddng.TabIndex = 0
        '
        'UsernameTxtBx
        '
        Me.UsernameTxtBx.BackColor = System.Drawing.Color.White
        Me.UsernameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UsernameTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.UsernameTxtBx.Name = "UsernameTxtBx"
        Me.UsernameTxtBx.Size = New System.Drawing.Size(540, 25)
        Me.UsernameTxtBx.TabIndex = 0
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UsernameLbl.Location = New System.Drawing.Point(92, 212)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(97, 22)
        Me.UsernameLbl.TabIndex = 6
        Me.UsernameLbl.Text = "Username"
        '
        'PhrmcstLbl
        '
        Me.PhrmcstLbl.AutoSize = True
        Me.PhrmcstLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhrmcstLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhrmcstLbl.Location = New System.Drawing.Point(92, 122)
        Me.PhrmcstLbl.Name = "PhrmcstLbl"
        Me.PhrmcstLbl.Size = New System.Drawing.Size(104, 22)
        Me.PhrmcstLbl.TabIndex = 3
        Me.PhrmcstLbl.Text = "Pharmacist"
        '
        'AFormTitle
        '
        Me.AFormTitle.AutoSize = True
        Me.AFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.AFormTitle.Location = New System.Drawing.Point(85, 62)
        Me.AFormTitle.Name = "AFormTitle"
        Me.AFormTitle.Size = New System.Drawing.Size(197, 34)
        Me.AFormTitle.TabIndex = 1
        Me.AFormTitle.Text = "New Account"
        '
        'AContentPnl
        '
        Me.AContentPnl.Controls.Add(Me.PharmacistIDLbl)
        Me.AContentPnl.Controls.Add(Me.IDLbl)
        Me.AContentPnl.Controls.Add(Me.WarningIndicatorLbl)
        Me.AContentPnl.Controls.Add(Me.PassStrengthIndicator)
        Me.AContentPnl.Controls.Add(Me.PassStrengthPnl)
        Me.AContentPnl.Controls.Add(Me.ConfirmPassTxtBxPnl)
        Me.AContentPnl.Controls.Add(Me.ConfirmPasswordLbl)
        Me.AContentPnl.Controls.Add(Me.PhrmcstCmbBxPnl)
        Me.AContentPnl.Controls.Add(Me.APrimaryBtn)
        Me.AContentPnl.Controls.Add(Me.PasswordTxtBxPnl)
        Me.AContentPnl.Controls.Add(Me.PasswordLbl)
        Me.AContentPnl.Controls.Add(Me.UsernameTxtBxPnl)
        Me.AContentPnl.Controls.Add(Me.UsernameLbl)
        Me.AContentPnl.Controls.Add(Me.PhrmcstLbl)
        Me.AContentPnl.Controls.Add(Me.AFormTitle)
        Me.AContentPnl.Controls.Add(Me.BackBtn)
        Me.AContentPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.AContentPnl.Location = New System.Drawing.Point(0, 0)
        Me.AContentPnl.Name = "AContentPnl"
        Me.AContentPnl.Size = New System.Drawing.Size(727, 721)
        Me.AContentPnl.TabIndex = 0
        '
        'PharmacistIDLbl
        '
        Me.PharmacistIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistIDLbl.ForeColor = System.Drawing.Color.Red
        Me.PharmacistIDLbl.Location = New System.Drawing.Point(376, 122)
        Me.PharmacistIDLbl.Name = "PharmacistIDLbl"
        Me.PharmacistIDLbl.Size = New System.Drawing.Size(265, 22)
        Me.PharmacistIDLbl.TabIndex = 4
        Me.PharmacistIDLbl.Text = "Not Found"
        Me.PharmacistIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IDLbl
        '
        Me.IDLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.IDLbl.Location = New System.Drawing.Point(390, 62)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.Size = New System.Drawing.Size(251, 34)
        Me.IDLbl.TabIndex = 2
        Me.IDLbl.Text = "PHAC-AAA-AAA-000"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IDLbl.Visible = False
        '
        'WarningIndicatorLbl
        '
        Me.WarningIndicatorLbl.AutoSize = True
        Me.WarningIndicatorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningIndicatorLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningIndicatorLbl.Location = New System.Drawing.Point(92, 571)
        Me.WarningIndicatorLbl.Name = "WarningIndicatorLbl"
        Me.WarningIndicatorLbl.Size = New System.Drawing.Size(223, 20)
        Me.WarningIndicatorLbl.TabIndex = 14
        Me.WarningIndicatorLbl.Text = "* You have 1 warning(s) on this form"
        Me.WarningIndicatorLbl.Visible = False
        '
        'PassStrengthIndicator
        '
        Me.PassStrengthIndicator.AutoSize = True
        Me.PassStrengthIndicator.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassStrengthIndicator.ForeColor = System.Drawing.Color.Red
        Me.PassStrengthIndicator.Location = New System.Drawing.Point(92, 383)
        Me.PassStrengthIndicator.Name = "PassStrengthIndicator"
        Me.PassStrengthIndicator.Size = New System.Drawing.Size(52, 23)
        Me.PassStrengthIndicator.TabIndex = 10
        Me.PassStrengthIndicator.Text = "Weak"
        Me.PassStrengthIndicator.Visible = False
        '
        'PassStrengthPnl
        '
        Me.PassStrengthPnl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PassStrengthPnl.Controls.Add(Me.PassStrength)
        Me.PassStrengthPnl.Location = New System.Drawing.Point(91, 375)
        Me.PassStrengthPnl.Name = "PassStrengthPnl"
        Me.PassStrengthPnl.Size = New System.Drawing.Size(549, 5)
        Me.PassStrengthPnl.TabIndex = 17
        '
        'PassStrength
        '
        Me.PassStrength.BackColor = System.Drawing.Color.Red
        Me.PassStrength.Dock = System.Windows.Forms.DockStyle.Left
        Me.PassStrength.Location = New System.Drawing.Point(0, 0)
        Me.PassStrength.Name = "PassStrength"
        Me.PassStrength.Size = New System.Drawing.Size(0, 5)
        Me.PassStrength.TabIndex = 0
        '
        'ConfirmPassTxtBxPnl
        '
        Me.ConfirmPassTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ConfirmPassTxtBxPnl.Controls.Add(Me.ConfirmPassTxtBxPddng)
        Me.ConfirmPassTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.ConfirmPassTxtBxPnl.Location = New System.Drawing.Point(91, 454)
        Me.ConfirmPassTxtBxPnl.Name = "ConfirmPassTxtBxPnl"
        Me.ConfirmPassTxtBxPnl.Size = New System.Drawing.Size(550, 38)
        Me.ConfirmPassTxtBxPnl.TabIndex = 12
        '
        'ConfirmPassTxtBxPddng
        '
        Me.ConfirmPassTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.ConfirmPassTxtBxPddng.Controls.Add(Me.ConfirmPassShowHideBtn)
        Me.ConfirmPassTxtBxPddng.Controls.Add(Me.ConfirmPassTxtBx)
        Me.ConfirmPassTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.ConfirmPassTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.ConfirmPassTxtBxPddng.Name = "ConfirmPassTxtBxPddng"
        Me.ConfirmPassTxtBxPddng.Size = New System.Drawing.Size(546, 34)
        Me.ConfirmPassTxtBxPddng.TabIndex = 0
        '
        'ConfirmPassShowHideBtn
        '
        Me.ConfirmPassShowHideBtn.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmPassShowHideBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.HidePass
        Me.ConfirmPassShowHideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfirmPassShowHideBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmPassShowHideBtn.FlatAppearance.BorderSize = 0
        Me.ConfirmPassShowHideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmPassShowHideBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassShowHideBtn.ForeColor = System.Drawing.Color.White
        Me.ConfirmPassShowHideBtn.Location = New System.Drawing.Point(518, 5)
        Me.ConfirmPassShowHideBtn.Name = "ConfirmPassShowHideBtn"
        Me.ConfirmPassShowHideBtn.Size = New System.Drawing.Size(25, 25)
        Me.ConfirmPassShowHideBtn.TabIndex = 1
        Me.ConfirmPassShowHideBtn.UseVisualStyleBackColor = False
        '
        'ConfirmPassTxtBx
        '
        Me.ConfirmPassTxtBx.BackColor = System.Drawing.Color.White
        Me.ConfirmPassTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConfirmPassTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ConfirmPassTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.ConfirmPassTxtBx.Name = "ConfirmPassTxtBx"
        Me.ConfirmPassTxtBx.Size = New System.Drawing.Size(509, 25)
        Me.ConfirmPassTxtBx.TabIndex = 0
        Me.ConfirmPassTxtBx.UseSystemPasswordChar = True
        '
        'ConfirmPasswordLbl
        '
        Me.ConfirmPasswordLbl.AutoSize = True
        Me.ConfirmPasswordLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ConfirmPasswordLbl.Location = New System.Drawing.Point(92, 429)
        Me.ConfirmPasswordLbl.Name = "ConfirmPasswordLbl"
        Me.ConfirmPasswordLbl.Size = New System.Drawing.Size(164, 22)
        Me.ConfirmPasswordLbl.TabIndex = 11
        Me.ConfirmPasswordLbl.Text = "Confirm password"
        '
        'PhrmcstCmbBxPnl
        '
        Me.PhrmcstCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhrmcstCmbBxPnl.Controls.Add(Me.PharmacistCmbBx)
        Me.PhrmcstCmbBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.PhrmcstCmbBxPnl.Location = New System.Drawing.Point(91, 147)
        Me.PhrmcstCmbBxPnl.Name = "PhrmcstCmbBxPnl"
        Me.PhrmcstCmbBxPnl.Size = New System.Drawing.Size(550, 36)
        Me.PhrmcstCmbBxPnl.TabIndex = 5
        '
        'PharmacistCmbBx
        '
        Me.PharmacistCmbBx.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Others"})
        Me.PharmacistCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PharmacistCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PharmacistCmbBx.BackColor = System.Drawing.Color.White
        Me.PharmacistCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PharmacistCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacistCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PharmacistCmbBx.FormattingEnabled = True
        Me.PharmacistCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.PharmacistCmbBx.Name = "PharmacistCmbBx"
        Me.PharmacistCmbBx.Size = New System.Drawing.Size(546, 32)
        Me.PharmacistCmbBx.TabIndex = 0
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
        Me.Filler.TabIndex = 4
        Me.Filler.TabStop = False
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'AddEditAccountForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.Filler)
        Me.Controls.Add(Me.AContentPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEditAccountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AddEditAccount"
        Me.PasswordTxtBxPnl.ResumeLayout(False)
        Me.PasswordTxtBxPddng.ResumeLayout(False)
        Me.PasswordTxtBxPddng.PerformLayout()
        Me.UsernameTxtBxPnl.ResumeLayout(False)
        Me.UsernameTxtBxPddng.ResumeLayout(False)
        Me.UsernameTxtBxPddng.PerformLayout()
        Me.AContentPnl.ResumeLayout(False)
        Me.AContentPnl.PerformLayout()
        Me.PassStrengthPnl.ResumeLayout(False)
        Me.ConfirmPassTxtBxPnl.ResumeLayout(False)
        Me.ConfirmPassTxtBxPddng.ResumeLayout(False)
        Me.ConfirmPassTxtBxPddng.PerformLayout()
        Me.PhrmcstCmbBxPnl.ResumeLayout(False)
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Filler As PictureBox
    Friend WithEvents APrimaryBtn As Button
    Friend WithEvents PasswordTxtBxPnl As Panel
    Friend WithEvents PasswordTxtBxPddng As Panel
    Friend WithEvents PasswordTxtBx As TextBox
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents UsernameTxtBxPnl As Panel
    Friend WithEvents UsernameTxtBxPddng As Panel
    Friend WithEvents UsernameTxtBx As TextBox
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents PhrmcstLbl As Label
    Friend WithEvents AFormTitle As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents AContentPnl As Panel
    Friend WithEvents PhrmcstCmbBxPnl As Panel
    Friend WithEvents PassShowHideBtn As Button
    Friend WithEvents PharmacistCmbBx As ComboBox
    Friend WithEvents ConfirmPassTxtBxPnl As Panel
    Friend WithEvents ConfirmPassTxtBxPddng As Panel
    Friend WithEvents ConfirmPassShowHideBtn As Button
    Friend WithEvents ConfirmPassTxtBx As TextBox
    Friend WithEvents ConfirmPasswordLbl As Label
    Friend WithEvents PassStrengthPnl As Panel
    Friend WithEvents PassStrength As Panel
    Friend WithEvents PassStrengthIndicator As Label
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents WarningIndicatorLbl As Label
    Friend WithEvents IDLbl As Label
    Friend WithEvents PharmacistIDLbl As Label
End Class
