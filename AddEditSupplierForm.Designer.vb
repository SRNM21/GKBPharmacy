<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditSupplierForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditSupplierForm))
        Me.SPrimaryBtn = New System.Windows.Forms.Button()
        Me.PhoneNumTxtBx = New System.Windows.Forms.TextBox()
        Me.PhoneNumTxtBxPddng = New System.Windows.Forms.Panel()
        Me.PhoneNumTxtBxPnl = New System.Windows.Forms.Panel()
        Me.EmailTxtBxPnl = New System.Windows.Forms.Panel()
        Me.EmailTxtBxPddng = New System.Windows.Forms.Panel()
        Me.EmailTxtBx = New System.Windows.Forms.TextBox()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.PhoneNumLbl = New System.Windows.Forms.Label()
        Me.SFormTitle = New System.Windows.Forms.Label()
        Me.SupplierLbl = New System.Windows.Forms.Label()
        Me.SContentPnl = New System.Windows.Forms.Panel()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.WarningIndicatorLbl = New System.Windows.Forms.Label()
        Me.SupplierTxtBxPnl = New System.Windows.Forms.Panel()
        Me.SupplierTxtBxPddng = New System.Windows.Forms.Panel()
        Me.SupplierTxtBx = New System.Windows.Forms.TextBox()
        Me.CategoryCmbBxPnl = New System.Windows.Forms.Panel()
        Me.CategoryCmbBx = New System.Windows.Forms.ComboBox()
        Me.CategoryLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Filler = New System.Windows.Forms.PictureBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PhoneNumTxtBxPddng.SuspendLayout()
        Me.PhoneNumTxtBxPnl.SuspendLayout()
        Me.EmailTxtBxPnl.SuspendLayout()
        Me.EmailTxtBxPddng.SuspendLayout()
        Me.SContentPnl.SuspendLayout()
        Me.SupplierTxtBxPnl.SuspendLayout()
        Me.SupplierTxtBxPddng.SuspendLayout()
        Me.CategoryCmbBxPnl.SuspendLayout()
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPrimaryBtn
        '
        Me.SPrimaryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SPrimaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SPrimaryBtn.FlatAppearance.BorderSize = 0
        Me.SPrimaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SPrimaryBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPrimaryBtn.ForeColor = System.Drawing.Color.White
        Me.SPrimaryBtn.Location = New System.Drawing.Point(91, 488)
        Me.SPrimaryBtn.Name = "SPrimaryBtn"
        Me.SPrimaryBtn.Size = New System.Drawing.Size(550, 44)
        Me.SPrimaryBtn.TabIndex = 10
        Me.SPrimaryBtn.Text = "Create"
        Me.SPrimaryBtn.UseVisualStyleBackColor = False
        '
        'PhoneNumTxtBx
        '
        Me.PhoneNumTxtBx.BackColor = System.Drawing.Color.White
        Me.PhoneNumTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneNumTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNumTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.PhoneNumTxtBx.Name = "PhoneNumTxtBx"
        Me.PhoneNumTxtBx.Size = New System.Drawing.Size(540, 25)
        Me.PhoneNumTxtBx.TabIndex = 0
        '
        'PhoneNumTxtBxPddng
        '
        Me.PhoneNumTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.PhoneNumTxtBxPddng.Controls.Add(Me.PhoneNumTxtBx)
        Me.PhoneNumTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.PhoneNumTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.PhoneNumTxtBxPddng.Name = "PhoneNumTxtBxPddng"
        Me.PhoneNumTxtBxPddng.Size = New System.Drawing.Size(546, 34)
        Me.PhoneNumTxtBxPddng.TabIndex = 0
        '
        'PhoneNumTxtBxPnl
        '
        Me.PhoneNumTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNumTxtBxPnl.Controls.Add(Me.PhoneNumTxtBxPddng)
        Me.PhoneNumTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.PhoneNumTxtBxPnl.Location = New System.Drawing.Point(91, 326)
        Me.PhoneNumTxtBxPnl.Name = "PhoneNumTxtBxPnl"
        Me.PhoneNumTxtBxPnl.Size = New System.Drawing.Size(550, 38)
        Me.PhoneNumTxtBxPnl.TabIndex = 8
        '
        'EmailTxtBxPnl
        '
        Me.EmailTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.EmailTxtBxPnl.Controls.Add(Me.EmailTxtBxPddng)
        Me.EmailTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.EmailTxtBxPnl.Location = New System.Drawing.Point(91, 418)
        Me.EmailTxtBxPnl.Name = "EmailTxtBxPnl"
        Me.EmailTxtBxPnl.Size = New System.Drawing.Size(550, 38)
        Me.EmailTxtBxPnl.TabIndex = 9
        '
        'EmailTxtBxPddng
        '
        Me.EmailTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.EmailTxtBxPddng.Controls.Add(Me.EmailTxtBx)
        Me.EmailTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.EmailTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.EmailTxtBxPddng.Name = "EmailTxtBxPddng"
        Me.EmailTxtBxPddng.Size = New System.Drawing.Size(546, 34)
        Me.EmailTxtBxPddng.TabIndex = 0
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
        Me.EmailLbl.Location = New System.Drawing.Point(92, 393)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(57, 22)
        Me.EmailLbl.TabIndex = 9
        Me.EmailLbl.Text = "Email"
        '
        'PhoneNumLbl
        '
        Me.PhoneNumLbl.AutoSize = True
        Me.PhoneNumLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PhoneNumLbl.Location = New System.Drawing.Point(92, 301)
        Me.PhoneNumLbl.Name = "PhoneNumLbl"
        Me.PhoneNumLbl.Size = New System.Drawing.Size(134, 22)
        Me.PhoneNumLbl.TabIndex = 7
        Me.PhoneNumLbl.Text = "Phone number"
        '
        'SFormTitle
        '
        Me.SFormTitle.AutoSize = True
        Me.SFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SFormTitle.Location = New System.Drawing.Point(85, 62)
        Me.SFormTitle.Name = "SFormTitle"
        Me.SFormTitle.Size = New System.Drawing.Size(199, 34)
        Me.SFormTitle.TabIndex = 1
        Me.SFormTitle.Text = "New Supplier"
        '
        'SupplierLbl
        '
        Me.SupplierLbl.AutoSize = True
        Me.SupplierLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SupplierLbl.Location = New System.Drawing.Point(92, 122)
        Me.SupplierLbl.Name = "SupplierLbl"
        Me.SupplierLbl.Size = New System.Drawing.Size(132, 22)
        Me.SupplierLbl.TabIndex = 3
        Me.SupplierLbl.Text = "Supplier name"
        '
        'SContentPnl
        '
        Me.SContentPnl.Controls.Add(Me.IDLbl)
        Me.SContentPnl.Controls.Add(Me.WarningIndicatorLbl)
        Me.SContentPnl.Controls.Add(Me.SupplierTxtBxPnl)
        Me.SContentPnl.Controls.Add(Me.CategoryCmbBxPnl)
        Me.SContentPnl.Controls.Add(Me.CategoryLbl)
        Me.SContentPnl.Controls.Add(Me.PhoneNumTxtBxPnl)
        Me.SContentPnl.Controls.Add(Me.SPrimaryBtn)
        Me.SContentPnl.Controls.Add(Me.EmailTxtBxPnl)
        Me.SContentPnl.Controls.Add(Me.EmailLbl)
        Me.SContentPnl.Controls.Add(Me.PhoneNumLbl)
        Me.SContentPnl.Controls.Add(Me.SupplierLbl)
        Me.SContentPnl.Controls.Add(Me.SFormTitle)
        Me.SContentPnl.Controls.Add(Me.BackBtn)
        Me.SContentPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.SContentPnl.Location = New System.Drawing.Point(0, 0)
        Me.SContentPnl.Name = "SContentPnl"
        Me.SContentPnl.Size = New System.Drawing.Size(727, 721)
        Me.SContentPnl.TabIndex = 0
        '
        'IDLbl
        '
        Me.IDLbl.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.IDLbl.Location = New System.Drawing.Point(390, 62)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.Size = New System.Drawing.Size(251, 34)
        Me.IDLbl.TabIndex = 2
        Me.IDLbl.Text = "SUP-AAA-AAA-000"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IDLbl.Visible = False
        '
        'WarningIndicatorLbl
        '
        Me.WarningIndicatorLbl.AutoSize = True
        Me.WarningIndicatorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningIndicatorLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningIndicatorLbl.Location = New System.Drawing.Point(92, 535)
        Me.WarningIndicatorLbl.Name = "WarningIndicatorLbl"
        Me.WarningIndicatorLbl.Size = New System.Drawing.Size(223, 20)
        Me.WarningIndicatorLbl.TabIndex = 11
        Me.WarningIndicatorLbl.Text = "* You have 1 warning(s) on this form"
        Me.WarningIndicatorLbl.Visible = False
        '
        'SupplierTxtBxPnl
        '
        Me.SupplierTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SupplierTxtBxPnl.Controls.Add(Me.SupplierTxtBxPddng)
        Me.SupplierTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.SupplierTxtBxPnl.Location = New System.Drawing.Point(91, 147)
        Me.SupplierTxtBxPnl.Name = "SupplierTxtBxPnl"
        Me.SupplierTxtBxPnl.Size = New System.Drawing.Size(550, 38)
        Me.SupplierTxtBxPnl.TabIndex = 4
        '
        'SupplierTxtBxPddng
        '
        Me.SupplierTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.SupplierTxtBxPddng.Controls.Add(Me.SupplierTxtBx)
        Me.SupplierTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.SupplierTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.SupplierTxtBxPddng.Name = "SupplierTxtBxPddng"
        Me.SupplierTxtBxPddng.Size = New System.Drawing.Size(546, 34)
        Me.SupplierTxtBxPddng.TabIndex = 0
        '
        'SupplierTxtBx
        '
        Me.SupplierTxtBx.BackColor = System.Drawing.Color.White
        Me.SupplierTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SupplierTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SupplierTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.SupplierTxtBx.Name = "SupplierTxtBx"
        Me.SupplierTxtBx.Size = New System.Drawing.Size(540, 25)
        Me.SupplierTxtBx.TabIndex = 0
        '
        'CategoryCmbBxPnl
        '
        Me.CategoryCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryCmbBxPnl.Controls.Add(Me.CategoryCmbBx)
        Me.CategoryCmbBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.CategoryCmbBxPnl.Location = New System.Drawing.Point(91, 236)
        Me.CategoryCmbBxPnl.Name = "CategoryCmbBxPnl"
        Me.CategoryCmbBxPnl.Size = New System.Drawing.Size(248, 36)
        Me.CategoryCmbBxPnl.TabIndex = 6
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
        'CategoryLbl
        '
        Me.CategoryLbl.AutoSize = True
        Me.CategoryLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CategoryLbl.Location = New System.Drawing.Point(92, 211)
        Me.CategoryLbl.Name = "CategoryLbl"
        Me.CategoryLbl.Size = New System.Drawing.Size(87, 22)
        Me.CategoryLbl.TabIndex = 5
        Me.CategoryLbl.Text = "Category"
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
        Me.Filler.TabIndex = 19
        Me.Filler.TabStop = False
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'AddEditSupplierForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.Filler)
        Me.Controls.Add(Me.SContentPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEditSupplierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEditSupplierForm"
        Me.PhoneNumTxtBxPddng.ResumeLayout(False)
        Me.PhoneNumTxtBxPddng.PerformLayout()
        Me.PhoneNumTxtBxPnl.ResumeLayout(False)
        Me.EmailTxtBxPnl.ResumeLayout(False)
        Me.EmailTxtBxPddng.ResumeLayout(False)
        Me.EmailTxtBxPddng.PerformLayout()
        Me.SContentPnl.ResumeLayout(False)
        Me.SContentPnl.PerformLayout()
        Me.SupplierTxtBxPnl.ResumeLayout(False)
        Me.SupplierTxtBxPddng.ResumeLayout(False)
        Me.SupplierTxtBxPddng.PerformLayout()
        Me.CategoryCmbBxPnl.ResumeLayout(False)
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SPrimaryBtn As Button
    Friend WithEvents PhoneNumTxtBx As TextBox
    Friend WithEvents PhoneNumTxtBxPddng As Panel
    Friend WithEvents PhoneNumTxtBxPnl As Panel
    Friend WithEvents EmailTxtBxPnl As Panel
    Friend WithEvents EmailTxtBxPddng As Panel
    Friend WithEvents EmailTxtBx As TextBox
    Friend WithEvents EmailLbl As Label
    Friend WithEvents PhoneNumLbl As Label
    Friend WithEvents SFormTitle As Label
    Friend WithEvents Filler As PictureBox
    Friend WithEvents SupplierLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents SContentPnl As Panel
    Friend WithEvents CategoryCmbBxPnl As Panel
    Friend WithEvents CategoryCmbBx As ComboBox
    Friend WithEvents CategoryLbl As Label
    Friend WithEvents SupplierTxtBxPnl As Panel
    Friend WithEvents SupplierTxtBxPddng As Panel
    Friend WithEvents SupplierTxtBx As TextBox
    Friend WithEvents ErrProvider As ErrorProvider
    Friend WithEvents WarningIndicatorLbl As Label
    Friend WithEvents IDLbl As Label
End Class
