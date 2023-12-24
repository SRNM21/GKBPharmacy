<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccountForm
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
        Me.MAContentDockPnl = New System.Windows.Forms.Panel()
        Me.MADGVPnl = New System.Windows.Forms.Panel()
        Me.MAContentPnl = New System.Windows.Forms.Panel()
        Me.MADGV = New System.Windows.Forms.DataGridView()
        Me.MAHeaderPnl = New System.Windows.Forms.Panel()
        Me.MASearchPnl = New System.Windows.Forms.Panel()
        Me.MASearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.MASearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.MASearchTxtBx = New System.Windows.Forms.TextBox()
        Me.MASearchBtn = New System.Windows.Forms.Button()
        Me.MAFormTitle = New System.Windows.Forms.Label()
        Me.MABtnPnl = New System.Windows.Forms.Panel()
        Me.MANewBtn = New System.Windows.Forms.Button()
        Me.MADeleteBtn = New System.Windows.Forms.Button()
        Me.MAEditBtn = New System.Windows.Forms.Button()
        Me.MAContentDockPnl.SuspendLayout()
        Me.MADGVPnl.SuspendLayout()
        Me.MAContentPnl.SuspendLayout()
        CType(Me.MADGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MAHeaderPnl.SuspendLayout()
        Me.MASearchPnl.SuspendLayout()
        Me.MASearchTxtBxPnl.SuspendLayout()
        Me.MASearchTxtBxPddng.SuspendLayout()
        Me.MABtnPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAContentDockPnl
        '
        Me.MAContentDockPnl.BackColor = System.Drawing.Color.Gainsboro
        Me.MAContentDockPnl.Controls.Add(Me.MADGVPnl)
        Me.MAContentDockPnl.Controls.Add(Me.MABtnPnl)
        Me.MAContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MAContentDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.MAContentDockPnl.Name = "MAContentDockPnl"
        Me.MAContentDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.MAContentDockPnl.TabIndex = 9
        '
        'MADGVPnl
        '
        Me.MADGVPnl.BackColor = System.Drawing.Color.White
        Me.MADGVPnl.Controls.Add(Me.MAContentPnl)
        Me.MADGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MADGVPnl.Location = New System.Drawing.Point(0, 0)
        Me.MADGVPnl.Name = "MADGVPnl"
        Me.MADGVPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 20)
        Me.MADGVPnl.Size = New System.Drawing.Size(962, 721)
        Me.MADGVPnl.TabIndex = 0
        '
        'MAContentPnl
        '
        Me.MAContentPnl.BackColor = System.Drawing.Color.White
        Me.MAContentPnl.Controls.Add(Me.MADGV)
        Me.MAContentPnl.Controls.Add(Me.MAHeaderPnl)
        Me.MAContentPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MAContentPnl.Location = New System.Drawing.Point(20, 0)
        Me.MAContentPnl.Name = "MAContentPnl"
        Me.MAContentPnl.Size = New System.Drawing.Size(922, 701)
        Me.MAContentPnl.TabIndex = 3
        '
        'MADGV
        '
        Me.MADGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MADGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MADGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MADGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MADGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MADGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MADGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.MADGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MADGV.EnableHeadersVisualStyles = False
        Me.MADGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MADGV.Location = New System.Drawing.Point(0, 90)
        Me.MADGV.Name = "MADGV"
        Me.MADGV.ReadOnly = True
        Me.MADGV.RowHeadersVisible = False
        Me.MADGV.Size = New System.Drawing.Size(922, 611)
        Me.MADGV.TabIndex = 1
        '
        'MAHeaderPnl
        '
        Me.MAHeaderPnl.BackColor = System.Drawing.Color.White
        Me.MAHeaderPnl.Controls.Add(Me.MASearchPnl)
        Me.MAHeaderPnl.Controls.Add(Me.MAFormTitle)
        Me.MAHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MAHeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.MAHeaderPnl.Name = "MAHeaderPnl"
        Me.MAHeaderPnl.Size = New System.Drawing.Size(922, 90)
        Me.MAHeaderPnl.TabIndex = 0
        '
        'MASearchPnl
        '
        Me.MASearchPnl.BackColor = System.Drawing.Color.White
        Me.MASearchPnl.Controls.Add(Me.MASearchTxtBxPnl)
        Me.MASearchPnl.Controls.Add(Me.MASearchBtn)
        Me.MASearchPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MASearchPnl.Location = New System.Drawing.Point(375, 0)
        Me.MASearchPnl.Name = "MASearchPnl"
        Me.MASearchPnl.Size = New System.Drawing.Size(547, 90)
        Me.MASearchPnl.TabIndex = 1
        '
        'MASearchTxtBxPnl
        '
        Me.MASearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MASearchTxtBxPnl.Controls.Add(Me.MASearchTxtBxPddng)
        Me.MASearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.MASearchTxtBxPnl.Location = New System.Drawing.Point(105, 26)
        Me.MASearchTxtBxPnl.Name = "MASearchTxtBxPnl"
        Me.MASearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.MASearchTxtBxPnl.TabIndex = 0
        '
        'MASearchTxtBxPddng
        '
        Me.MASearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.MASearchTxtBxPddng.Controls.Add(Me.MASearchTxtBx)
        Me.MASearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.MASearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.MASearchTxtBxPddng.Name = "MASearchTxtBxPddng"
        Me.MASearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.MASearchTxtBxPddng.TabIndex = 0
        '
        'MASearchTxtBx
        '
        Me.MASearchTxtBx.BackColor = System.Drawing.Color.White
        Me.MASearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MASearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MASearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.MASearchTxtBx.Name = "MASearchTxtBx"
        Me.MASearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.MASearchTxtBx.TabIndex = 0
        '
        'MASearchBtn
        '
        Me.MASearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MASearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.MASearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MASearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MASearchBtn.FlatAppearance.BorderSize = 0
        Me.MASearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MASearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASearchBtn.ForeColor = System.Drawing.Color.White
        Me.MASearchBtn.Location = New System.Drawing.Point(507, 26)
        Me.MASearchBtn.Name = "MASearchBtn"
        Me.MASearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.MASearchBtn.TabIndex = 1
        Me.MASearchBtn.UseVisualStyleBackColor = False
        '
        'MAFormTitle
        '
        Me.MAFormTitle.AutoSize = True
        Me.MAFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MAFormTitle.Location = New System.Drawing.Point(4, 28)
        Me.MAFormTitle.Name = "MAFormTitle"
        Me.MAFormTitle.Size = New System.Drawing.Size(146, 34)
        Me.MAFormTitle.TabIndex = 0
        Me.MAFormTitle.Text = "Accounts"
        '
        'MABtnPnl
        '
        Me.MABtnPnl.BackColor = System.Drawing.Color.White
        Me.MABtnPnl.Controls.Add(Me.MANewBtn)
        Me.MABtnPnl.Controls.Add(Me.MADeleteBtn)
        Me.MABtnPnl.Controls.Add(Me.MAEditBtn)
        Me.MABtnPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MABtnPnl.Location = New System.Drawing.Point(962, 0)
        Me.MABtnPnl.Name = "MABtnPnl"
        Me.MABtnPnl.Size = New System.Drawing.Size(222, 721)
        Me.MABtnPnl.TabIndex = 1
        '
        'MANewBtn
        '
        Me.MANewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MANewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MANewBtn.FlatAppearance.BorderSize = 0
        Me.MANewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MANewBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MANewBtn.ForeColor = System.Drawing.Color.White
        Me.MANewBtn.Location = New System.Drawing.Point(22, 90)
        Me.MANewBtn.Name = "MANewBtn"
        Me.MANewBtn.Size = New System.Drawing.Size(178, 44)
        Me.MANewBtn.TabIndex = 0
        Me.MANewBtn.Text = "New"
        Me.MANewBtn.UseVisualStyleBackColor = False
        '
        'MADeleteBtn
        '
        Me.MADeleteBtn.BackColor = System.Drawing.Color.White
        Me.MADeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MADeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MADeleteBtn.FlatAppearance.BorderSize = 2
        Me.MADeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MADeleteBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MADeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MADeleteBtn.Location = New System.Drawing.Point(22, 218)
        Me.MADeleteBtn.Name = "MADeleteBtn"
        Me.MADeleteBtn.Size = New System.Drawing.Size(178, 44)
        Me.MADeleteBtn.TabIndex = 2
        Me.MADeleteBtn.Text = "Delete"
        Me.MADeleteBtn.UseVisualStyleBackColor = False
        '
        'MAEditBtn
        '
        Me.MAEditBtn.BackColor = System.Drawing.Color.White
        Me.MAEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MAEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MAEditBtn.FlatAppearance.BorderSize = 2
        Me.MAEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MAEditBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAEditBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MAEditBtn.Location = New System.Drawing.Point(22, 154)
        Me.MAEditBtn.Name = "MAEditBtn"
        Me.MAEditBtn.Size = New System.Drawing.Size(178, 44)
        Me.MAEditBtn.TabIndex = 1
        Me.MAEditBtn.Text = "Edit"
        Me.MAEditBtn.UseVisualStyleBackColor = False
        '
        'ManageAccountForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.MAContentDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageAccountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageAccountForm"
        Me.MAContentDockPnl.ResumeLayout(False)
        Me.MADGVPnl.ResumeLayout(False)
        Me.MAContentPnl.ResumeLayout(False)
        CType(Me.MADGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MAHeaderPnl.ResumeLayout(False)
        Me.MAHeaderPnl.PerformLayout()
        Me.MASearchPnl.ResumeLayout(False)
        Me.MASearchTxtBxPnl.ResumeLayout(False)
        Me.MASearchTxtBxPddng.ResumeLayout(False)
        Me.MASearchTxtBxPddng.PerformLayout()
        Me.MABtnPnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MAContentDockPnl As Panel
    Friend WithEvents MADGVPnl As Panel
    Friend WithEvents MAContentPnl As Panel
    Friend WithEvents MAHeaderPnl As Panel
    Friend WithEvents MASearchPnl As Panel
    Friend WithEvents MASearchTxtBxPnl As Panel
    Friend WithEvents MASearchTxtBxPddng As Panel
    Friend WithEvents MASearchTxtBx As TextBox
    Friend WithEvents MASearchBtn As Button
    Friend WithEvents MAFormTitle As Label
    Friend WithEvents MABtnPnl As Panel
    Friend WithEvents MANewBtn As Button
    Friend WithEvents MADeleteBtn As Button
    Friend WithEvents MAEditBtn As Button
    Friend WithEvents MADGV As DataGridView
End Class
