<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagePharmacistsForm
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
        Me.MPContentDockPnl = New System.Windows.Forms.Panel()
        Me.MPDGVPnl = New System.Windows.Forms.Panel()
        Me.MPContentPnl = New System.Windows.Forms.Panel()
        Me.MPDGV = New System.Windows.Forms.DataGridView()
        Me.MPHeaderPnl = New System.Windows.Forms.Panel()
        Me.MPSearchPnl = New System.Windows.Forms.Panel()
        Me.MPSearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.MPSearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.MPSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.MPSearchBtn = New System.Windows.Forms.Button()
        Me.MPFormTitle = New System.Windows.Forms.Label()
        Me.MPBtnPnl = New System.Windows.Forms.Panel()
        Me.CreateAccBtn = New System.Windows.Forms.Button()
        Me.MPNewBtn = New System.Windows.Forms.Button()
        Me.MPDeleteBtn = New System.Windows.Forms.Button()
        Me.MPEditBtn = New System.Windows.Forms.Button()
        Me.MPContentDockPnl.SuspendLayout()
        Me.MPDGVPnl.SuspendLayout()
        Me.MPContentPnl.SuspendLayout()
        CType(Me.MPDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPHeaderPnl.SuspendLayout()
        Me.MPSearchPnl.SuspendLayout()
        Me.MPSearchTxtBxPnl.SuspendLayout()
        Me.MPSearchTxtBxPddng.SuspendLayout()
        Me.MPBtnPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MPContentDockPnl
        '
        Me.MPContentDockPnl.BackColor = System.Drawing.Color.Gainsboro
        Me.MPContentDockPnl.Controls.Add(Me.MPDGVPnl)
        Me.MPContentDockPnl.Controls.Add(Me.MPBtnPnl)
        Me.MPContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MPContentDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.MPContentDockPnl.Name = "MPContentDockPnl"
        Me.MPContentDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.MPContentDockPnl.TabIndex = 9
        '
        'MPDGVPnl
        '
        Me.MPDGVPnl.BackColor = System.Drawing.Color.White
        Me.MPDGVPnl.Controls.Add(Me.MPContentPnl)
        Me.MPDGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MPDGVPnl.Location = New System.Drawing.Point(0, 0)
        Me.MPDGVPnl.Name = "MPDGVPnl"
        Me.MPDGVPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 20)
        Me.MPDGVPnl.Size = New System.Drawing.Size(962, 721)
        Me.MPDGVPnl.TabIndex = 0
        '
        'MPContentPnl
        '
        Me.MPContentPnl.BackColor = System.Drawing.Color.White
        Me.MPContentPnl.Controls.Add(Me.MPDGV)
        Me.MPContentPnl.Controls.Add(Me.MPHeaderPnl)
        Me.MPContentPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MPContentPnl.Location = New System.Drawing.Point(20, 0)
        Me.MPContentPnl.Name = "MPContentPnl"
        Me.MPContentPnl.Size = New System.Drawing.Size(922, 701)
        Me.MPContentPnl.TabIndex = 3
        '
        'MPDGV
        '
        Me.MPDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MPDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MPDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MPDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MPDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MPDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.MPDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MPDGV.EnableHeadersVisualStyles = False
        Me.MPDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPDGV.Location = New System.Drawing.Point(0, 90)
        Me.MPDGV.Name = "MPDGV"
        Me.MPDGV.ReadOnly = True
        Me.MPDGV.RowHeadersVisible = False
        Me.MPDGV.Size = New System.Drawing.Size(922, 611)
        Me.MPDGV.TabIndex = 1
        '
        'MPHeaderPnl
        '
        Me.MPHeaderPnl.BackColor = System.Drawing.Color.White
        Me.MPHeaderPnl.Controls.Add(Me.MPSearchPnl)
        Me.MPHeaderPnl.Controls.Add(Me.MPFormTitle)
        Me.MPHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MPHeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.MPHeaderPnl.Name = "MPHeaderPnl"
        Me.MPHeaderPnl.Size = New System.Drawing.Size(922, 90)
        Me.MPHeaderPnl.TabIndex = 0
        '
        'MPSearchPnl
        '
        Me.MPSearchPnl.BackColor = System.Drawing.Color.White
        Me.MPSearchPnl.Controls.Add(Me.MPSearchTxtBxPnl)
        Me.MPSearchPnl.Controls.Add(Me.MPSearchBtn)
        Me.MPSearchPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MPSearchPnl.Location = New System.Drawing.Point(375, 0)
        Me.MPSearchPnl.Name = "MPSearchPnl"
        Me.MPSearchPnl.Size = New System.Drawing.Size(547, 90)
        Me.MPSearchPnl.TabIndex = 1
        '
        'MPSearchTxtBxPnl
        '
        Me.MPSearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPSearchTxtBxPnl.Controls.Add(Me.MPSearchTxtBxPddng)
        Me.MPSearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.MPSearchTxtBxPnl.Location = New System.Drawing.Point(105, 26)
        Me.MPSearchTxtBxPnl.Name = "MPSearchTxtBxPnl"
        Me.MPSearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.MPSearchTxtBxPnl.TabIndex = 0
        '
        'MPSearchTxtBxPddng
        '
        Me.MPSearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.MPSearchTxtBxPddng.Controls.Add(Me.MPSearchTxtBx)
        Me.MPSearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.MPSearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.MPSearchTxtBxPddng.Name = "MPSearchTxtBxPddng"
        Me.MPSearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.MPSearchTxtBxPddng.TabIndex = 0
        '
        'MPSearchTxtBx
        '
        Me.MPSearchTxtBx.BackColor = System.Drawing.Color.White
        Me.MPSearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MPSearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPSearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPSearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.MPSearchTxtBx.Name = "MPSearchTxtBx"
        Me.MPSearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.MPSearchTxtBx.TabIndex = 0
        '
        'MPSearchBtn
        '
        Me.MPSearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPSearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.MPSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MPSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MPSearchBtn.FlatAppearance.BorderSize = 0
        Me.MPSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MPSearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPSearchBtn.ForeColor = System.Drawing.Color.White
        Me.MPSearchBtn.Location = New System.Drawing.Point(507, 26)
        Me.MPSearchBtn.Name = "MPSearchBtn"
        Me.MPSearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.MPSearchBtn.TabIndex = 1
        Me.MPSearchBtn.UseVisualStyleBackColor = False
        '
        'MPFormTitle
        '
        Me.MPFormTitle.AutoSize = True
        Me.MPFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPFormTitle.Location = New System.Drawing.Point(4, 28)
        Me.MPFormTitle.Name = "MPFormTitle"
        Me.MPFormTitle.Size = New System.Drawing.Size(187, 34)
        Me.MPFormTitle.TabIndex = 0
        Me.MPFormTitle.Text = "Pharmacists"
        '
        'MPBtnPnl
        '
        Me.MPBtnPnl.BackColor = System.Drawing.Color.White
        Me.MPBtnPnl.Controls.Add(Me.CreateAccBtn)
        Me.MPBtnPnl.Controls.Add(Me.MPNewBtn)
        Me.MPBtnPnl.Controls.Add(Me.MPDeleteBtn)
        Me.MPBtnPnl.Controls.Add(Me.MPEditBtn)
        Me.MPBtnPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MPBtnPnl.Location = New System.Drawing.Point(962, 0)
        Me.MPBtnPnl.Name = "MPBtnPnl"
        Me.MPBtnPnl.Size = New System.Drawing.Size(222, 721)
        Me.MPBtnPnl.TabIndex = 1
        '
        'CreateAccBtn
        '
        Me.CreateAccBtn.BackColor = System.Drawing.Color.White
        Me.CreateAccBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateAccBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CreateAccBtn.FlatAppearance.BorderSize = 2
        Me.CreateAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateAccBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CreateAccBtn.Location = New System.Drawing.Point(22, 282)
        Me.CreateAccBtn.Name = "CreateAccBtn"
        Me.CreateAccBtn.Size = New System.Drawing.Size(178, 44)
        Me.CreateAccBtn.TabIndex = 3
        Me.CreateAccBtn.Text = "Create Account"
        Me.CreateAccBtn.UseVisualStyleBackColor = False
        Me.CreateAccBtn.Visible = False
        '
        'MPNewBtn
        '
        Me.MPNewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPNewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MPNewBtn.FlatAppearance.BorderSize = 0
        Me.MPNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MPNewBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPNewBtn.ForeColor = System.Drawing.Color.White
        Me.MPNewBtn.Location = New System.Drawing.Point(22, 90)
        Me.MPNewBtn.Name = "MPNewBtn"
        Me.MPNewBtn.Size = New System.Drawing.Size(178, 44)
        Me.MPNewBtn.TabIndex = 0
        Me.MPNewBtn.Text = "New"
        Me.MPNewBtn.UseVisualStyleBackColor = False
        '
        'MPDeleteBtn
        '
        Me.MPDeleteBtn.BackColor = System.Drawing.Color.White
        Me.MPDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MPDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPDeleteBtn.FlatAppearance.BorderSize = 2
        Me.MPDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MPDeleteBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPDeleteBtn.Location = New System.Drawing.Point(22, 218)
        Me.MPDeleteBtn.Name = "MPDeleteBtn"
        Me.MPDeleteBtn.Size = New System.Drawing.Size(178, 44)
        Me.MPDeleteBtn.TabIndex = 2
        Me.MPDeleteBtn.Text = "Delete"
        Me.MPDeleteBtn.UseVisualStyleBackColor = False
        '
        'MPEditBtn
        '
        Me.MPEditBtn.BackColor = System.Drawing.Color.White
        Me.MPEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MPEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPEditBtn.FlatAppearance.BorderSize = 2
        Me.MPEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MPEditBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPEditBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MPEditBtn.Location = New System.Drawing.Point(22, 154)
        Me.MPEditBtn.Name = "MPEditBtn"
        Me.MPEditBtn.Size = New System.Drawing.Size(178, 44)
        Me.MPEditBtn.TabIndex = 1
        Me.MPEditBtn.Text = "Edit"
        Me.MPEditBtn.UseVisualStyleBackColor = False
        '
        'ManagePharmacistsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.MPContentDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagePharmacistsForm"
        Me.Text = "ManageCustomersForm"
        Me.MPContentDockPnl.ResumeLayout(False)
        Me.MPDGVPnl.ResumeLayout(False)
        Me.MPContentPnl.ResumeLayout(False)
        CType(Me.MPDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPHeaderPnl.ResumeLayout(False)
        Me.MPHeaderPnl.PerformLayout()
        Me.MPSearchPnl.ResumeLayout(False)
        Me.MPSearchTxtBxPnl.ResumeLayout(False)
        Me.MPSearchTxtBxPddng.ResumeLayout(False)
        Me.MPSearchTxtBxPddng.PerformLayout()
        Me.MPBtnPnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MPContentDockPnl As Panel
    Friend WithEvents MPDGVPnl As Panel
    Friend WithEvents MPContentPnl As Panel
    Friend WithEvents MPHeaderPnl As Panel
    Friend WithEvents MPSearchPnl As Panel
    Friend WithEvents MPSearchTxtBxPnl As Panel
    Friend WithEvents MPSearchTxtBxPddng As Panel
    Friend WithEvents MPSearchTxtBx As TextBox
    Friend WithEvents MPSearchBtn As Button
    Friend WithEvents MPFormTitle As Label
    Friend WithEvents MPBtnPnl As Panel
    Friend WithEvents MPNewBtn As Button
    Friend WithEvents MPDeleteBtn As Button
    Friend WithEvents MPEditBtn As Button
    Friend WithEvents MPDGV As DataGridView
    Friend WithEvents CreateAccBtn As Button
End Class
