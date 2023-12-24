<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEditCustomerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditCustomerForm))
        Me.Filler = New System.Windows.Forms.PictureBox()
        Me.CContentPnl = New System.Windows.Forms.Panel()
        Me.WarningIndicatorLbl = New System.Windows.Forms.Label()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.GenderLbl = New System.Windows.Forms.Label()
        Me.GenderCmbBxPnl = New System.Windows.Forms.Panel()
        Me.GenderCmbBx = New System.Windows.Forms.ComboBox()
        Me.LnameTxtBxPnl = New System.Windows.Forms.Panel()
        Me.LnameTxtBxPddng = New System.Windows.Forms.Panel()
        Me.LnameTxtBx = New System.Windows.Forms.TextBox()
        Me.LnameLbl = New System.Windows.Forms.Label()
        Me.FnameTxtBxPnl = New System.Windows.Forms.Panel()
        Me.FnameTxtBxPddng = New System.Windows.Forms.Panel()
        Me.FnameTxtBx = New System.Windows.Forms.TextBox()
        Me.FnameLbl = New System.Windows.Forms.Label()
        Me.CPrimaryBtn = New System.Windows.Forms.Button()
        Me.CFormTitle = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CContentPnl.SuspendLayout()
        Me.GenderCmbBxPnl.SuspendLayout()
        Me.LnameTxtBxPnl.SuspendLayout()
        Me.LnameTxtBxPddng.SuspendLayout()
        Me.FnameTxtBxPnl.SuspendLayout()
        Me.FnameTxtBxPddng.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'CContentPnl
        '
        Me.CContentPnl.Controls.Add(Me.WarningIndicatorLbl)
        Me.CContentPnl.Controls.Add(Me.IDLbl)
        Me.CContentPnl.Controls.Add(Me.GenderLbl)
        Me.CContentPnl.Controls.Add(Me.GenderCmbBxPnl)
        Me.CContentPnl.Controls.Add(Me.LnameTxtBxPnl)
        Me.CContentPnl.Controls.Add(Me.LnameLbl)
        Me.CContentPnl.Controls.Add(Me.FnameTxtBxPnl)
        Me.CContentPnl.Controls.Add(Me.FnameLbl)
        Me.CContentPnl.Controls.Add(Me.CPrimaryBtn)
        Me.CContentPnl.Controls.Add(Me.CFormTitle)
        Me.CContentPnl.Controls.Add(Me.BackBtn)
        Me.CContentPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.CContentPnl.Location = New System.Drawing.Point(0, 0)
        Me.CContentPnl.Name = "CContentPnl"
        Me.CContentPnl.Size = New System.Drawing.Size(727, 721)
        Me.CContentPnl.TabIndex = 0
        '
        'WarningIndicatorLbl
        '
        Me.WarningIndicatorLbl.AutoSize = True
        Me.WarningIndicatorLbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningIndicatorLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningIndicatorLbl.Location = New System.Drawing.Point(92, 353)
        Me.WarningIndicatorLbl.Name = "WarningIndicatorLbl"
        Me.WarningIndicatorLbl.Size = New System.Drawing.Size(223, 20)
        Me.WarningIndicatorLbl.TabIndex = 10
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
        Me.IDLbl.Text = "CST-AAA-AAA-000"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IDLbl.Visible = False
        '
        'GenderLbl
        '
        Me.GenderLbl.AutoSize = True
        Me.GenderLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenderLbl.Location = New System.Drawing.Point(92, 213)
        Me.GenderLbl.Name = "GenderLbl"
        Me.GenderLbl.Size = New System.Drawing.Size(74, 22)
        Me.GenderLbl.TabIndex = 7
        Me.GenderLbl.Text = "Gender"
        '
        'GenderCmbBxPnl
        '
        Me.GenderCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GenderCmbBxPnl.Controls.Add(Me.GenderCmbBx)
        Me.GenderCmbBxPnl.Location = New System.Drawing.Point(91, 238)
        Me.GenderCmbBxPnl.Name = "GenderCmbBxPnl"
        Me.GenderCmbBxPnl.Size = New System.Drawing.Size(251, 36)
        Me.GenderCmbBxPnl.TabIndex = 8
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
        Me.FnameTxtBxPnl.TabIndex = 4
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
        Me.FnameLbl.TabIndex = 3
        Me.FnameLbl.Text = "First name"
        '
        'CPrimaryBtn
        '
        Me.CPrimaryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CPrimaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CPrimaryBtn.FlatAppearance.BorderSize = 0
        Me.CPrimaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPrimaryBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPrimaryBtn.ForeColor = System.Drawing.Color.White
        Me.CPrimaryBtn.Location = New System.Drawing.Point(91, 306)
        Me.CPrimaryBtn.Name = "CPrimaryBtn"
        Me.CPrimaryBtn.Size = New System.Drawing.Size(550, 44)
        Me.CPrimaryBtn.TabIndex = 9
        Me.CPrimaryBtn.Text = "Create"
        Me.CPrimaryBtn.UseVisualStyleBackColor = False
        '
        'CFormTitle
        '
        Me.CFormTitle.AutoSize = True
        Me.CFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CFormTitle.Location = New System.Drawing.Point(85, 62)
        Me.CFormTitle.Name = "CFormTitle"
        Me.CFormTitle.Size = New System.Drawing.Size(219, 34)
        Me.CFormTitle.TabIndex = 1
        Me.CFormTitle.Text = "New Customer"
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
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'AddEditCustomerForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.Filler)
        Me.Controls.Add(Me.CContentPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEditCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEditCustomerForm"
        CType(Me.Filler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CContentPnl.ResumeLayout(False)
        Me.CContentPnl.PerformLayout()
        Me.GenderCmbBxPnl.ResumeLayout(False)
        Me.LnameTxtBxPnl.ResumeLayout(False)
        Me.LnameTxtBxPddng.ResumeLayout(False)
        Me.LnameTxtBxPddng.PerformLayout()
        Me.FnameTxtBxPnl.ResumeLayout(False)
        Me.FnameTxtBxPddng.ResumeLayout(False)
        Me.FnameTxtBxPddng.PerformLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Filler As PictureBox
    Friend WithEvents CContentPnl As Panel
    Friend WithEvents CPrimaryBtn As Button
    Friend WithEvents CFormTitle As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents LnameTxtBxPnl As Panel
    Friend WithEvents LnameTxtBxPddng As Panel
    Friend WithEvents LnameTxtBx As TextBox
    Friend WithEvents LnameLbl As Label
    Friend WithEvents FnameTxtBxPnl As Panel
    Friend WithEvents FnameTxtBxPddng As Panel
    Friend WithEvents FnameTxtBx As TextBox
    Friend WithEvents FnameLbl As Label
    Friend WithEvents GenderLbl As Label
    Friend WithEvents GenderCmbBxPnl As Panel
    Friend WithEvents GenderCmbBx As ComboBox
    Friend WithEvents IDLbl As Label
    Friend WithEvents WarningIndicatorLbl As Label
    Friend WithEvents ErrProvider As ErrorProvider
End Class
