<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditPharmacistForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditPharmacistForm))
        Me.PContentPnl = New System.Windows.Forms.Panel()
        Me.WarningIndicatorLbl = New System.Windows.Forms.Label()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.PPrimaryBtn = New System.Windows.Forms.Button()
        Me.GenderLbl = New System.Windows.Forms.Label()
        Me.PhoneNumPnl = New System.Windows.Forms.Panel()
        Me.PhoneNumPddng = New System.Windows.Forms.Panel()
        Me.PhoneNumTxtBx = New System.Windows.Forms.TextBox()
        Me.PhoneNumLbl = New System.Windows.Forms.Label()
        Me.EmailPnl = New System.Windows.Forms.Panel()
        Me.EmailPddng = New System.Windows.Forms.Panel()
        Me.EmailTxtBx = New System.Windows.Forms.TextBox()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.GenderCmbBxPnl = New System.Windows.Forms.Panel()
        Me.GenderCmbBx = New System.Windows.Forms.ComboBox()
        Me.BirthDatePnl = New System.Windows.Forms.Panel()
        Me.BirthDatePckr = New System.Windows.Forms.DateTimePicker()
        Me.BirthDateLbl = New System.Windows.Forms.Label()
        Me.LnameTxtBxPnl = New System.Windows.Forms.Panel()
        Me.LnameTxtBxPddng = New System.Windows.Forms.Panel()
        Me.LnameTxtBx = New System.Windows.Forms.TextBox()
        Me.LnameLbl = New System.Windows.Forms.Label()
        Me.FnameTxtBxPnl = New System.Windows.Forms.Panel()
        Me.FnameTxtBxPddng = New System.Windows.Forms.Panel()
        Me.FnameTxtBx = New System.Windows.Forms.TextBox()
        Me.FnameLbl = New System.Windows.Forms.Label()
        Me.PFormTitle = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Filler = New System.Windows.Forms.Panel()
        Me.PContentPnl.SuspendLayout()
        Me.PhoneNumPnl.SuspendLayout()
        Me.PhoneNumPddng.SuspendLayout()
        Me.EmailPnl.SuspendLayout()
        Me.EmailPddng.SuspendLayout()
        Me.GenderCmbBxPnl.SuspendLayout()
        Me.BirthDatePnl.SuspendLayout()
        Me.LnameTxtBxPnl.SuspendLayout()
        Me.LnameTxtBxPddng.SuspendLayout()
        Me.FnameTxtBxPnl.SuspendLayout()
        Me.FnameTxtBxPddng.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PContentPnl
        '
        Me.PContentPnl.Controls.Add(Me.WarningIndicatorLbl)
        Me.PContentPnl.Controls.Add(Me.IDLbl)
        Me.PContentPnl.Controls.Add(Me.PPrimaryBtn)
        Me.PContentPnl.Controls.Add(Me.GenderLbl)
        Me.PContentPnl.Controls.Add(Me.PhoneNumPnl)
        Me.PContentPnl.Controls.Add(Me.PhoneNumLbl)
        Me.PContentPnl.Controls.Add(Me.EmailPnl)
        Me.PContentPnl.Controls.Add(Me.EmailLbl)
        Me.PContentPnl.Controls.Add(Me.GenderCmbBxPnl)
        Me.PContentPnl.Controls.Add(Me.BirthDatePnl)
        Me.PContentPnl.Controls.Add(Me.BirthDateLbl)
        Me.PContentPnl.Controls.Add(Me.LnameTxtBxPnl)
        Me.PContentPnl.Controls.Add(Me.LnameLbl)
        Me.PContentPnl.Controls.Add(Me.FnameTxtBxPnl)
        Me.PContentPnl.Controls.Add(Me.FnameLbl)
        Me.PContentPnl.Controls.Add(Me.PFormTitle)
        Me.PContentPnl.Controls.Add(Me.BackBtn)
        Me.PContentPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.PContentPnl.Location = New System.Drawing.Point(0, 0)
        Me.PContentPnl.Name = "PContentPnl"
        Me.PContentPnl.Size = New System.Drawing.Size(727, 721)
        Me.PContentPnl.TabIndex = 0
        '
        'WarningIndicatorLbl
        '
        Me.WarningIndicatorLbl.AutoSize = True
        Me.WarningIndicatorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningIndicatorLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningIndicatorLbl.Location = New System.Drawing.Point(92, 539)
        Me.WarningIndicatorLbl.Name = "WarningIndicatorLbl"
        Me.WarningIndicatorLbl.Size = New System.Drawing.Size(223, 20)
        Me.WarningIndicatorLbl.TabIndex = 16
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
        Me.IDLbl.TabIndex = 3
        Me.IDLbl.Text = "PHA-AAA-AAA-000"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IDLbl.Visible = False
        '
        'PPrimaryBtn
        '
        Me.PPrimaryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PPrimaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PPrimaryBtn.FlatAppearance.BorderSize = 0
        Me.PPrimaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PPrimaryBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPrimaryBtn.ForeColor = System.Drawing.Color.White
        Me.PPrimaryBtn.Location = New System.Drawing.Point(91, 492)
        Me.PPrimaryBtn.Name = "PPrimaryBtn"
        Me.PPrimaryBtn.Size = New System.Drawing.Size(550, 44)
        Me.PPrimaryBtn.TabIndex = 15
        Me.PPrimaryBtn.Text = "Create"
        Me.PPrimaryBtn.UseVisualStyleBackColor = False
        '
        'GenderLbl
        '
        Me.GenderLbl.AutoSize = True
        Me.GenderLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenderLbl.Location = New System.Drawing.Point(391, 214)
        Me.GenderLbl.Name = "GenderLbl"
        Me.GenderLbl.Size = New System.Drawing.Size(74, 22)
        Me.GenderLbl.TabIndex = 9
        Me.GenderLbl.Text = "Gender"
        '
        'PhoneNumPnl
        '
        Me.PhoneNumPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNumPnl.Controls.Add(Me.PhoneNumPddng)
        Me.PhoneNumPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.PhoneNumPnl.Location = New System.Drawing.Point(91, 421)
        Me.PhoneNumPnl.Name = "PhoneNumPnl"
        Me.PhoneNumPnl.Size = New System.Drawing.Size(550, 38)
        Me.PhoneNumPnl.TabIndex = 14
        '
        'PhoneNumPddng
        '
        Me.PhoneNumPddng.BackColor = System.Drawing.Color.White
        Me.PhoneNumPddng.Controls.Add(Me.PhoneNumTxtBx)
        Me.PhoneNumPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.PhoneNumPddng.Location = New System.Drawing.Point(2, 2)
        Me.PhoneNumPddng.Name = "PhoneNumPddng"
        Me.PhoneNumPddng.Size = New System.Drawing.Size(546, 34)
        Me.PhoneNumPddng.TabIndex = 0
        '
        'PhoneNumTxtBx
        '
        Me.PhoneNumTxtBx.BackColor = System.Drawing.Color.White
        Me.PhoneNumTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneNumTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNumTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.PhoneNumTxtBx.Name = "PhoneNumTxtBx"
        Me.PhoneNumTxtBx.ShortcutsEnabled = False
        Me.PhoneNumTxtBx.Size = New System.Drawing.Size(540, 25)
        Me.PhoneNumTxtBx.TabIndex = 0
        '
        'PhoneNumLbl
        '
        Me.PhoneNumLbl.AutoSize = True
        Me.PhoneNumLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNumLbl.Location = New System.Drawing.Point(92, 396)
        Me.PhoneNumLbl.Name = "PhoneNumLbl"
        Me.PhoneNumLbl.Size = New System.Drawing.Size(134, 22)
        Me.PhoneNumLbl.TabIndex = 13
        Me.PhoneNumLbl.Text = "Phone number"
        '
        'EmailPnl
        '
        Me.EmailPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.EmailPnl.Controls.Add(Me.EmailPddng)
        Me.EmailPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.EmailPnl.Location = New System.Drawing.Point(91, 329)
        Me.EmailPnl.Name = "EmailPnl"
        Me.EmailPnl.Size = New System.Drawing.Size(550, 38)
        Me.EmailPnl.TabIndex = 12
        '
        'EmailPddng
        '
        Me.EmailPddng.BackColor = System.Drawing.Color.White
        Me.EmailPddng.Controls.Add(Me.EmailTxtBx)
        Me.EmailPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.EmailPddng.Location = New System.Drawing.Point(2, 2)
        Me.EmailPddng.Name = "EmailPddng"
        Me.EmailPddng.Size = New System.Drawing.Size(546, 34)
        Me.EmailPddng.TabIndex = 0
        '
        'EmailTxtBx
        '
        Me.EmailTxtBx.BackColor = System.Drawing.Color.White
        Me.EmailTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.EmailTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.EmailTxtBx.Name = "EmailTxtBx"
        Me.EmailTxtBx.Size = New System.Drawing.Size(540, 25)
        Me.EmailTxtBx.TabIndex = 0
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.EmailLbl.Location = New System.Drawing.Point(92, 304)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(57, 22)
        Me.EmailLbl.TabIndex = 11
        Me.EmailLbl.Text = "Email"
        '
        'GenderCmbBxPnl
        '
        Me.GenderCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenderCmbBxPnl.Controls.Add(Me.GenderCmbBx)
        Me.GenderCmbBxPnl.Location = New System.Drawing.Point(390, 239)
        Me.GenderCmbBxPnl.Name = "GenderCmbBxPnl"
        Me.GenderCmbBxPnl.Size = New System.Drawing.Size(251, 36)
        Me.GenderCmbBxPnl.TabIndex = 10
        '
        'GenderCmbBx
        '
        Me.GenderCmbBx.BackColor = System.Drawing.Color.White
        Me.GenderCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenderCmbBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenderCmbBx.FormattingEnabled = True
        Me.GenderCmbBx.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.GenderCmbBx.Name = "GenderCmbBx"
        Me.GenderCmbBx.Size = New System.Drawing.Size(247, 32)
        Me.GenderCmbBx.TabIndex = 0
        '
        'BirthDatePnl
        '
        Me.BirthDatePnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BirthDatePnl.Controls.Add(Me.BirthDatePckr)
        Me.BirthDatePnl.ForeColor = System.Drawing.Color.Chocolate
        Me.BirthDatePnl.Location = New System.Drawing.Point(91, 239)
        Me.BirthDatePnl.Name = "BirthDatePnl"
        Me.BirthDatePnl.Size = New System.Drawing.Size(249, 37)
        Me.BirthDatePnl.TabIndex = 8
        '
        'BirthDatePckr
        '
        Me.BirthDatePckr.CalendarFont = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDatePckr.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BirthDatePckr.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BirthDatePckr.CustomFormat = " "
        Me.BirthDatePckr.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDatePckr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BirthDatePckr.Location = New System.Drawing.Point(1, 1)
        Me.BirthDatePckr.Name = "BirthDatePckr"
        Me.BirthDatePckr.Size = New System.Drawing.Size(247, 35)
        Me.BirthDatePckr.TabIndex = 0
        '
        'BirthDateLbl
        '
        Me.BirthDateLbl.AutoSize = True
        Me.BirthDateLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDateLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BirthDateLbl.Location = New System.Drawing.Point(92, 214)
        Me.BirthDateLbl.Name = "BirthDateLbl"
        Me.BirthDateLbl.Size = New System.Drawing.Size(90, 22)
        Me.BirthDateLbl.TabIndex = 7
        Me.BirthDateLbl.Text = "Birth date"
        '
        'LnameTxtBxPnl
        '
        Me.LnameTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LnameTxtBxPnl.Controls.Add(Me.LnameTxtBxPddng)
        Me.LnameTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.LnameTxtBxPnl.Location = New System.Drawing.Point(390, 147)
        Me.LnameTxtBxPnl.Name = "LnameTxtBxPnl"
        Me.LnameTxtBxPnl.Size = New System.Drawing.Size(251, 38)
        Me.LnameTxtBxPnl.TabIndex = 6
        '
        'LnameTxtBxPddng
        '
        Me.LnameTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.LnameTxtBxPddng.Controls.Add(Me.LnameTxtBx)
        Me.LnameTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.LnameTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.LnameTxtBxPddng.Name = "LnameTxtBxPddng"
        Me.LnameTxtBxPddng.Size = New System.Drawing.Size(247, 34)
        Me.LnameTxtBxPddng.TabIndex = 0
        '
        'LnameTxtBx
        '
        Me.LnameTxtBx.BackColor = System.Drawing.Color.White
        Me.LnameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LnameTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LnameTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.LnameTxtBx.Name = "LnameTxtBx"
        Me.LnameTxtBx.Size = New System.Drawing.Size(241, 25)
        Me.LnameTxtBx.TabIndex = 0
        '
        'LnameLbl
        '
        Me.LnameLbl.AutoSize = True
        Me.LnameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LnameLbl.Location = New System.Drawing.Point(391, 122)
        Me.LnameLbl.Name = "LnameLbl"
        Me.LnameLbl.Size = New System.Drawing.Size(98, 22)
        Me.LnameLbl.TabIndex = 5
        Me.LnameLbl.Text = "Last name"
        '
        'FnameTxtBxPnl
        '
        Me.FnameTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FnameTxtBxPnl.Controls.Add(Me.FnameTxtBxPddng)
        Me.FnameTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.FnameTxtBxPnl.Location = New System.Drawing.Point(91, 147)
        Me.FnameTxtBxPnl.Name = "FnameTxtBxPnl"
        Me.FnameTxtBxPnl.Size = New System.Drawing.Size(251, 38)
        Me.FnameTxtBxPnl.TabIndex = 5
        '
        'FnameTxtBxPddng
        '
        Me.FnameTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.FnameTxtBxPddng.Controls.Add(Me.FnameTxtBx)
        Me.FnameTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.FnameTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.FnameTxtBxPddng.Name = "FnameTxtBxPddng"
        Me.FnameTxtBxPddng.Size = New System.Drawing.Size(247, 34)
        Me.FnameTxtBxPddng.TabIndex = 0
        '
        'FnameTxtBx
        '
        Me.FnameTxtBx.BackColor = System.Drawing.Color.White
        Me.FnameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FnameTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FnameTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.FnameTxtBx.Name = "FnameTxtBx"
        Me.FnameTxtBx.Size = New System.Drawing.Size(241, 25)
        Me.FnameTxtBx.TabIndex = 0
        '
        'FnameLbl
        '
        Me.FnameLbl.AutoSize = True
        Me.FnameLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FnameLbl.Location = New System.Drawing.Point(92, 122)
        Me.FnameLbl.Name = "FnameLbl"
        Me.FnameLbl.Size = New System.Drawing.Size(99, 22)
        Me.FnameLbl.TabIndex = 4
        Me.FnameLbl.Text = "First name"
        '
        'PFormTitle
        '
        Me.PFormTitle.AutoSize = True
        Me.PFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PFormTitle.Location = New System.Drawing.Point(85, 62)
        Me.PFormTitle.Name = "PFormTitle"
        Me.PFormTitle.Size = New System.Drawing.Size(255, 34)
        Me.PFormTitle.TabIndex = 2
        Me.PFormTitle.Text = "New Pharmacists"
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
        Me.BackBtn.TabIndex = 1
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkRate = 100
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'Filler
        '
        Me.Filler.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Filler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Filler.Location = New System.Drawing.Point(727, 0)
        Me.Filler.Name = "Filler"
        Me.Filler.Size = New System.Drawing.Size(457, 721)
        Me.Filler.TabIndex = 1
        '
        'AddEditPharmacistForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.Filler)
        Me.Controls.Add(Me.PContentPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(30, 30)
        Me.Name = "AddEditPharmacistForm"
        Me.Text = "AddEditPharmacistForm"
        Me.PContentPnl.ResumeLayout(False)
        Me.PContentPnl.PerformLayout()
        Me.PhoneNumPnl.ResumeLayout(False)
        Me.PhoneNumPddng.ResumeLayout(False)
        Me.PhoneNumPddng.PerformLayout()
        Me.EmailPnl.ResumeLayout(False)
        Me.EmailPddng.ResumeLayout(False)
        Me.EmailPddng.PerformLayout()
        Me.GenderCmbBxPnl.ResumeLayout(False)
        Me.BirthDatePnl.ResumeLayout(False)
        Me.LnameTxtBxPnl.ResumeLayout(False)
        Me.LnameTxtBxPddng.ResumeLayout(False)
        Me.LnameTxtBxPddng.PerformLayout()
        Me.FnameTxtBxPnl.ResumeLayout(False)
        Me.FnameTxtBxPddng.ResumeLayout(False)
        Me.FnameTxtBxPddng.PerformLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PContentPnl As Panel
    Friend WithEvents PFormTitle As Label
    Friend WithEvents FnameTxtBxPnl As Panel
    Friend WithEvents FnameTxtBxPddng As Panel
    Friend WithEvents FnameTxtBx As TextBox
    Friend WithEvents FnameLbl As Label
    Friend WithEvents LnameTxtBxPnl As Panel
    Friend WithEvents LnameTxtBxPddng As Panel
    Friend WithEvents LnameTxtBx As TextBox
    Friend WithEvents LnameLbl As Label
    Friend WithEvents BirthDatePnl As Panel
    Friend WithEvents BirthDatePckr As DateTimePicker
    Friend WithEvents BirthDateLbl As Label
    Friend WithEvents GenderCmbBxPnl As Panel
    Friend WithEvents GenderCmbBx As ComboBox
    Friend WithEvents EmailPnl As Panel
    Friend WithEvents EmailPddng As Panel
    Friend WithEvents EmailTxtBx As TextBox
    Friend WithEvents EmailLbl As Label
    Friend WithEvents PhoneNumPnl As Panel
    Friend WithEvents PhoneNumPddng As Panel
    Friend WithEvents PhoneNumTxtBx As TextBox
    Friend WithEvents PhoneNumLbl As Label
    Friend WithEvents GenderLbl As Label
    Friend WithEvents PPrimaryBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents IDLbl As Label
    Friend WithEvents WarningIndicatorLbl As Label
    Friend WithEvents Filler As Panel
End Class
