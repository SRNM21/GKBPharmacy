<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageCustomersForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MCContentDockPnl = New System.Windows.Forms.Panel()
        Me.MCDGVPnl = New System.Windows.Forms.Panel()
        Me.MCContentPnl = New System.Windows.Forms.Panel()
        Me.MCDGV = New System.Windows.Forms.DataGridView()
        Me.MCHeaderPnl = New System.Windows.Forms.Panel()
        Me.MCSearchPnl = New System.Windows.Forms.Panel()
        Me.MCSearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.MCSearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.MCSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.MCSearchBtn = New System.Windows.Forms.Button()
        Me.MCFormTitle = New System.Windows.Forms.Label()
        Me.MCBtnPnl = New System.Windows.Forms.Panel()
        Me.MCNewBtn = New System.Windows.Forms.Button()
        Me.MCDeleteBtn = New System.Windows.Forms.Button()
        Me.MCEditBtn = New System.Windows.Forms.Button()
        Me.MCContentDockPnl.SuspendLayout()
        Me.MCDGVPnl.SuspendLayout()
        Me.MCContentPnl.SuspendLayout()
        CType(Me.MCDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MCHeaderPnl.SuspendLayout()
        Me.MCSearchPnl.SuspendLayout()
        Me.MCSearchTxtBxPnl.SuspendLayout()
        Me.MCSearchTxtBxPddng.SuspendLayout()
        Me.MCBtnPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MCContentDockPnl
        '
        Me.MCContentDockPnl.BackColor = System.Drawing.Color.Gainsboro
        Me.MCContentDockPnl.Controls.Add(Me.MCDGVPnl)
        Me.MCContentDockPnl.Controls.Add(Me.MCBtnPnl)
        Me.MCContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MCContentDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.MCContentDockPnl.Name = "MCContentDockPnl"
        Me.MCContentDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.MCContentDockPnl.TabIndex = 8
        '
        'MCDGVPnl
        '
        Me.MCDGVPnl.BackColor = System.Drawing.Color.White
        Me.MCDGVPnl.Controls.Add(Me.MCContentPnl)
        Me.MCDGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MCDGVPnl.Location = New System.Drawing.Point(0, 0)
        Me.MCDGVPnl.Name = "MCDGVPnl"
        Me.MCDGVPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 20)
        Me.MCDGVPnl.Size = New System.Drawing.Size(962, 721)
        Me.MCDGVPnl.TabIndex = 0
        '
        'MCContentPnl
        '
        Me.MCContentPnl.BackColor = System.Drawing.Color.White
        Me.MCContentPnl.Controls.Add(Me.MCDGV)
        Me.MCContentPnl.Controls.Add(Me.MCHeaderPnl)
        Me.MCContentPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MCContentPnl.Location = New System.Drawing.Point(20, 0)
        Me.MCContentPnl.Name = "MCContentPnl"
        Me.MCContentPnl.Size = New System.Drawing.Size(922, 701)
        Me.MCContentPnl.TabIndex = 3
        '
        'MCDGV
        '
        Me.MCDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MCDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MCDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MCDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MCDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MCDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.MCDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MCDGV.EnableHeadersVisualStyles = False
        Me.MCDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCDGV.Location = New System.Drawing.Point(0, 90)
        Me.MCDGV.Name = "MCDGV"
        Me.MCDGV.ReadOnly = True
        Me.MCDGV.RowHeadersVisible = False
        Me.MCDGV.Size = New System.Drawing.Size(922, 611)
        Me.MCDGV.TabIndex = 1
        '
        'MCHeaderPnl
        '
        Me.MCHeaderPnl.BackColor = System.Drawing.Color.White
        Me.MCHeaderPnl.Controls.Add(Me.MCSearchPnl)
        Me.MCHeaderPnl.Controls.Add(Me.MCFormTitle)
        Me.MCHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MCHeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.MCHeaderPnl.Name = "MCHeaderPnl"
        Me.MCHeaderPnl.Size = New System.Drawing.Size(922, 90)
        Me.MCHeaderPnl.TabIndex = 0
        '
        'MCSearchPnl
        '
        Me.MCSearchPnl.BackColor = System.Drawing.Color.White
        Me.MCSearchPnl.Controls.Add(Me.MCSearchTxtBxPnl)
        Me.MCSearchPnl.Controls.Add(Me.MCSearchBtn)
        Me.MCSearchPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MCSearchPnl.Location = New System.Drawing.Point(375, 0)
        Me.MCSearchPnl.Name = "MCSearchPnl"
        Me.MCSearchPnl.Size = New System.Drawing.Size(547, 90)
        Me.MCSearchPnl.TabIndex = 1
        '
        'MCSearchTxtBxPnl
        '
        Me.MCSearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCSearchTxtBxPnl.Controls.Add(Me.MCSearchTxtBxPddng)
        Me.MCSearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.MCSearchTxtBxPnl.Location = New System.Drawing.Point(105, 26)
        Me.MCSearchTxtBxPnl.Name = "MCSearchTxtBxPnl"
        Me.MCSearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.MCSearchTxtBxPnl.TabIndex = 0
        '
        'MCSearchTxtBxPddng
        '
        Me.MCSearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.MCSearchTxtBxPddng.Controls.Add(Me.MCSearchTxtBx)
        Me.MCSearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.MCSearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.MCSearchTxtBxPddng.Name = "MCSearchTxtBxPddng"
        Me.MCSearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.MCSearchTxtBxPddng.TabIndex = 0
        '
        'MCSearchTxtBx
        '
        Me.MCSearchTxtBx.BackColor = System.Drawing.Color.White
        Me.MCSearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MCSearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCSearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCSearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.MCSearchTxtBx.Name = "MCSearchTxtBx"
        Me.MCSearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.MCSearchTxtBx.TabIndex = 0
        '
        'MCSearchBtn
        '
        Me.MCSearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCSearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.MCSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MCSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MCSearchBtn.FlatAppearance.BorderSize = 0
        Me.MCSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MCSearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCSearchBtn.ForeColor = System.Drawing.Color.White
        Me.MCSearchBtn.Location = New System.Drawing.Point(507, 26)
        Me.MCSearchBtn.Name = "MCSearchBtn"
        Me.MCSearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.MCSearchBtn.TabIndex = 1
        Me.MCSearchBtn.UseVisualStyleBackColor = False
        '
        'MCFormTitle
        '
        Me.MCFormTitle.AutoSize = True
        Me.MCFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCFormTitle.Location = New System.Drawing.Point(4, 28)
        Me.MCFormTitle.Name = "MCFormTitle"
        Me.MCFormTitle.Size = New System.Drawing.Size(167, 34)
        Me.MCFormTitle.TabIndex = 0
        Me.MCFormTitle.Text = "Customers"
        '
        'MCBtnPnl
        '
        Me.MCBtnPnl.BackColor = System.Drawing.Color.White
        Me.MCBtnPnl.Controls.Add(Me.MCNewBtn)
        Me.MCBtnPnl.Controls.Add(Me.MCDeleteBtn)
        Me.MCBtnPnl.Controls.Add(Me.MCEditBtn)
        Me.MCBtnPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MCBtnPnl.Location = New System.Drawing.Point(962, 0)
        Me.MCBtnPnl.Name = "MCBtnPnl"
        Me.MCBtnPnl.Size = New System.Drawing.Size(222, 721)
        Me.MCBtnPnl.TabIndex = 1
        '
        'MCNewBtn
        '
        Me.MCNewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCNewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MCNewBtn.FlatAppearance.BorderSize = 0
        Me.MCNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MCNewBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCNewBtn.ForeColor = System.Drawing.Color.White
        Me.MCNewBtn.Location = New System.Drawing.Point(22, 90)
        Me.MCNewBtn.Name = "MCNewBtn"
        Me.MCNewBtn.Size = New System.Drawing.Size(178, 44)
        Me.MCNewBtn.TabIndex = 0
        Me.MCNewBtn.Text = "New"
        Me.MCNewBtn.UseVisualStyleBackColor = False
        '
        'MCDeleteBtn
        '
        Me.MCDeleteBtn.BackColor = System.Drawing.Color.White
        Me.MCDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MCDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCDeleteBtn.FlatAppearance.BorderSize = 2
        Me.MCDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MCDeleteBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCDeleteBtn.Location = New System.Drawing.Point(22, 218)
        Me.MCDeleteBtn.Name = "MCDeleteBtn"
        Me.MCDeleteBtn.Size = New System.Drawing.Size(178, 44)
        Me.MCDeleteBtn.TabIndex = 2
        Me.MCDeleteBtn.Text = "Delete"
        Me.MCDeleteBtn.UseVisualStyleBackColor = False
        '
        'MCEditBtn
        '
        Me.MCEditBtn.BackColor = System.Drawing.Color.White
        Me.MCEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MCEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCEditBtn.FlatAppearance.BorderSize = 2
        Me.MCEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MCEditBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCEditBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MCEditBtn.Location = New System.Drawing.Point(22, 154)
        Me.MCEditBtn.Name = "MCEditBtn"
        Me.MCEditBtn.Size = New System.Drawing.Size(178, 44)
        Me.MCEditBtn.TabIndex = 1
        Me.MCEditBtn.Text = "Edit"
        Me.MCEditBtn.UseVisualStyleBackColor = False
        '
        'ManageCustomersForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.MCContentDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageCustomersForm"
        Me.Text = "ManagePharmacistForm"
        Me.MCContentDockPnl.ResumeLayout(False)
        Me.MCDGVPnl.ResumeLayout(False)
        Me.MCContentPnl.ResumeLayout(False)
        CType(Me.MCDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MCHeaderPnl.ResumeLayout(False)
        Me.MCHeaderPnl.PerformLayout()
        Me.MCSearchPnl.ResumeLayout(False)
        Me.MCSearchTxtBxPnl.ResumeLayout(False)
        Me.MCSearchTxtBxPddng.ResumeLayout(False)
        Me.MCSearchTxtBxPddng.PerformLayout()
        Me.MCBtnPnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MCContentDockPnl As Panel
    Friend WithEvents MCDGVPnl As Panel
    Friend WithEvents MCBtnPnl As Panel
    Friend WithEvents MCNewBtn As Button
    Friend WithEvents MCDeleteBtn As Button
    Friend WithEvents MCEditBtn As Button
    Friend WithEvents MCContentPnl As Panel
    Friend WithEvents MCHeaderPnl As Panel
    Friend WithEvents MCFormTitle As Label
    Friend WithEvents MCSearchPnl As Panel
    Friend WithEvents MCSearchBtn As Button
    Friend WithEvents MCSearchTxtBxPnl As Panel
    Friend WithEvents MCSearchTxtBxPddng As Panel
    Friend WithEvents MCSearchTxtBx As TextBox
    Friend WithEvents MCDGV As DataGridView
End Class
