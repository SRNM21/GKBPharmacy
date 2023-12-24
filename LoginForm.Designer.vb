<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        Me.FooterPnl = New System.Windows.Forms.Panel()
        Me.CpyRight = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.PsswrdLbl = New System.Windows.Forms.Label()
        Me.UsrnmTxtBxPnl = New System.Windows.Forms.Panel()
        Me.UsrnmTxtBxPddng = New System.Windows.Forms.Panel()
        Me.UsrnmTxtBx = New System.Windows.Forms.TextBox()
        Me.UsrnmLbl = New System.Windows.Forms.Label()
        Me.LoginTitle = New System.Windows.Forms.Label()
        Me.PsswrdTxtBxPddng = New System.Windows.Forms.Panel()
        Me.HidePssBtn = New System.Windows.Forms.Button()
        Me.PsswrdTxtBx = New System.Windows.Forms.TextBox()
        Me.PsswrdTxtBxPnl = New System.Windows.Forms.Panel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FooterPnl.SuspendLayout()
        Me.UsrnmTxtBxPnl.SuspendLayout()
        Me.UsrnmTxtBxPddng.SuspendLayout()
        Me.PsswrdTxtBxPddng.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FooterPnl
        '
        Me.FooterPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FooterPnl.Controls.Add(Me.CpyRight)
        Me.FooterPnl.Location = New System.Drawing.Point(-8, 538)
        Me.FooterPnl.Name = "FooterPnl"
        Me.FooterPnl.Size = New System.Drawing.Size(530, 62)
        Me.FooterPnl.TabIndex = 20
        '
        'CpyRight
        '
        Me.CpyRight.ForeColor = System.Drawing.Color.White
        Me.CpyRight.Location = New System.Drawing.Point(20, 0)
        Me.CpyRight.Name = "CpyRight"
        Me.CpyRight.Size = New System.Drawing.Size(490, 62)
        Me.CpyRight.TabIndex = 0
        Me.CpyRight.Text = "@2023 Group 8"
        Me.CpyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Location = New System.Drawing.Point(60, 390)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(391, 57)
        Me.LoginBtn.TabIndex = 0
        Me.LoginBtn.Text = "Log in"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'PsswrdLbl
        '
        Me.PsswrdLbl.AutoSize = True
        Me.PsswrdLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PsswrdLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PsswrdLbl.Location = New System.Drawing.Point(63, 302)
        Me.PsswrdLbl.Name = "PsswrdLbl"
        Me.PsswrdLbl.Size = New System.Drawing.Size(94, 22)
        Me.PsswrdLbl.TabIndex = 0
        Me.PsswrdLbl.Text = "Password"
        '
        'UsrnmTxtBxPnl
        '
        Me.UsrnmTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UsrnmTxtBxPnl.Controls.Add(Me.UsrnmTxtBxPddng)
        Me.UsrnmTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.UsrnmTxtBxPnl.Location = New System.Drawing.Point(62, 246)
        Me.UsrnmTxtBxPnl.Name = "UsrnmTxtBxPnl"
        Me.UsrnmTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.UsrnmTxtBxPnl.TabIndex = 0
        '
        'UsrnmTxtBxPddng
        '
        Me.UsrnmTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.UsrnmTxtBxPddng.Controls.Add(Me.UsrnmTxtBx)
        Me.UsrnmTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.UsrnmTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.UsrnmTxtBxPddng.Name = "UsrnmTxtBxPddng"
        Me.UsrnmTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.UsrnmTxtBxPddng.TabIndex = 0
        '
        'UsrnmTxtBx
        '
        Me.UsrnmTxtBx.BackColor = System.Drawing.Color.White
        Me.UsrnmTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsrnmTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrnmTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UsrnmTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.UsrnmTxtBx.Name = "UsrnmTxtBx"
        Me.UsrnmTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.UsrnmTxtBx.TabIndex = 1
        '
        'UsrnmLbl
        '
        Me.UsrnmLbl.AutoSize = True
        Me.UsrnmLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrnmLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UsrnmLbl.Location = New System.Drawing.Point(63, 223)
        Me.UsrnmLbl.Name = "UsrnmLbl"
        Me.UsrnmLbl.Size = New System.Drawing.Size(97, 22)
        Me.UsrnmLbl.TabIndex = 0
        Me.UsrnmLbl.Text = "Username"
        '
        'LoginTitle
        '
        Me.LoginTitle.AutoSize = True
        Me.LoginTitle.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LoginTitle.Location = New System.Drawing.Point(70, 121)
        Me.LoginTitle.Name = "LoginTitle"
        Me.LoginTitle.Size = New System.Drawing.Size(375, 56)
        Me.LoginTitle.TabIndex = 12
        Me.LoginTitle.Text = "GKB Pharmacy"
        '
        'PsswrdTxtBxPddng
        '
        Me.PsswrdTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.PsswrdTxtBxPddng.Controls.Add(Me.HidePssBtn)
        Me.PsswrdTxtBxPddng.Controls.Add(Me.PsswrdTxtBx)
        Me.PsswrdTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.PsswrdTxtBxPddng.Location = New System.Drawing.Point(63, 329)
        Me.PsswrdTxtBxPddng.Name = "PsswrdTxtBxPddng"
        Me.PsswrdTxtBxPddng.Size = New System.Drawing.Size(388, 34)
        Me.PsswrdTxtBxPddng.TabIndex = 22
        '
        'HidePssBtn
        '
        Me.HidePssBtn.BackColor = System.Drawing.Color.Transparent
        Me.HidePssBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.HidePass
        Me.HidePssBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HidePssBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HidePssBtn.FlatAppearance.BorderSize = 0
        Me.HidePssBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HidePssBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HidePssBtn.ForeColor = System.Drawing.Color.White
        Me.HidePssBtn.Location = New System.Drawing.Point(359, 5)
        Me.HidePssBtn.Name = "HidePssBtn"
        Me.HidePssBtn.Size = New System.Drawing.Size(25, 25)
        Me.HidePssBtn.TabIndex = 23
        Me.HidePssBtn.UseVisualStyleBackColor = False
        '
        'PsswrdTxtBx
        '
        Me.PsswrdTxtBx.BackColor = System.Drawing.Color.White
        Me.PsswrdTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PsswrdTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PsswrdTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PsswrdTxtBx.Location = New System.Drawing.Point(4, 5)
        Me.PsswrdTxtBx.Name = "PsswrdTxtBx"
        Me.PsswrdTxtBx.Size = New System.Drawing.Size(349, 25)
        Me.PsswrdTxtBx.TabIndex = 2
        Me.PsswrdTxtBx.UseSystemPasswordChar = True
        '
        'PsswrdTxtBxPnl
        '
        Me.PsswrdTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PsswrdTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.PsswrdTxtBxPnl.Location = New System.Drawing.Point(61, 327)
        Me.PsswrdTxtBxPnl.Name = "PsswrdTxtBxPnl"
        Me.PsswrdTxtBxPnl.Size = New System.Drawing.Size(392, 38)
        Me.PsswrdTxtBxPnl.TabIndex = 0
        '
        'Logo
        '
        Me.Logo.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.GKB_pharmacy_logo
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(169, 34)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(177, 84)
        Me.Logo.TabIndex = 11
        Me.Logo.TabStop = False
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'LogInForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(514, 597)
        Me.Controls.Add(Me.PsswrdTxtBxPddng)
        Me.Controls.Add(Me.PsswrdTxtBxPnl)
        Me.Controls.Add(Me.FooterPnl)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PsswrdLbl)
        Me.Controls.Add(Me.UsrnmTxtBxPnl)
        Me.Controls.Add(Me.UsrnmLbl)
        Me.Controls.Add(Me.LoginTitle)
        Me.Controls.Add(Me.Logo)
        Me.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LogInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GKB Pharmacy"
        Me.FooterPnl.ResumeLayout(False)
        Me.UsrnmTxtBxPnl.ResumeLayout(False)
        Me.UsrnmTxtBxPddng.ResumeLayout(False)
        Me.UsrnmTxtBxPddng.PerformLayout()
        Me.PsswrdTxtBxPddng.ResumeLayout(False)
        Me.PsswrdTxtBxPddng.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FooterPnl As Panel
    Friend WithEvents CpyRight As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PsswrdLbl As Label
    Friend WithEvents UsrnmTxtBxPnl As Panel
    Friend WithEvents UsrnmTxtBx As TextBox
    Friend WithEvents UsrnmLbl As Label
    Friend WithEvents LoginTitle As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents UsrnmTxtBxPddng As Panel
    Friend WithEvents PsswrdTxtBxPddng As Panel
    Friend WithEvents PsswrdTxtBxPnl As Panel
    Friend WithEvents HidePssBtn As Button
    Friend WithEvents PsswrdTxtBx As TextBox
    Friend WithEvents ErrProvider As ErrorProvider
End Class
