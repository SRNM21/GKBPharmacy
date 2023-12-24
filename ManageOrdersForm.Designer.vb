<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageOrdersForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MOHeaderPnl = New System.Windows.Forms.Panel()
        Me.MOSearchPnl = New System.Windows.Forms.Panel()
        Me.MOSearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.MOSearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.MOSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.MOSearchBtn = New System.Windows.Forms.Button()
        Me.MOFormTitle = New System.Windows.Forms.Label()
        Me.MOContentDockPnl = New System.Windows.Forms.Panel()
        Me.MODGVPnl = New System.Windows.Forms.Panel()
        Me.MOContentPnl = New System.Windows.Forms.Panel()
        Me.MODGVItems = New System.Windows.Forms.DataGridView()
        Me.MOSplitter = New System.Windows.Forms.Splitter()
        Me.MODGVOrdersPnl = New System.Windows.Forms.Panel()
        Me.MODGVOrders = New System.Windows.Forms.DataGridView()
        Me.MOBtnPnl = New System.Windows.Forms.Panel()
        Me.MONewBtn = New System.Windows.Forms.Button()
        Me.MODeleteBtn = New System.Windows.Forms.Button()
        Me.MOEditBtn = New System.Windows.Forms.Button()
        Me.MOHeaderPnl.SuspendLayout()
        Me.MOSearchPnl.SuspendLayout()
        Me.MOSearchTxtBxPnl.SuspendLayout()
        Me.MOSearchTxtBxPddng.SuspendLayout()
        Me.MOContentDockPnl.SuspendLayout()
        Me.MODGVPnl.SuspendLayout()
        Me.MOContentPnl.SuspendLayout()
        CType(Me.MODGVItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MODGVOrdersPnl.SuspendLayout()
        CType(Me.MODGVOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MOBtnPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MOHeaderPnl
        '
        Me.MOHeaderPnl.BackColor = System.Drawing.Color.White
        Me.MOHeaderPnl.Controls.Add(Me.MOSearchPnl)
        Me.MOHeaderPnl.Controls.Add(Me.MOFormTitle)
        Me.MOHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MOHeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.MOHeaderPnl.Name = "MOHeaderPnl"
        Me.MOHeaderPnl.Size = New System.Drawing.Size(922, 90)
        Me.MOHeaderPnl.TabIndex = 0
        '
        'MOSearchPnl
        '
        Me.MOSearchPnl.BackColor = System.Drawing.Color.White
        Me.MOSearchPnl.Controls.Add(Me.MOSearchTxtBxPnl)
        Me.MOSearchPnl.Controls.Add(Me.MOSearchBtn)
        Me.MOSearchPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MOSearchPnl.Location = New System.Drawing.Point(375, 0)
        Me.MOSearchPnl.Name = "MOSearchPnl"
        Me.MOSearchPnl.Size = New System.Drawing.Size(547, 90)
        Me.MOSearchPnl.TabIndex = 1
        '
        'MOSearchTxtBxPnl
        '
        Me.MOSearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MOSearchTxtBxPnl.Controls.Add(Me.MOSearchTxtBxPddng)
        Me.MOSearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.MOSearchTxtBxPnl.Location = New System.Drawing.Point(105, 26)
        Me.MOSearchTxtBxPnl.Name = "MOSearchTxtBxPnl"
        Me.MOSearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.MOSearchTxtBxPnl.TabIndex = 0
        '
        'MOSearchTxtBxPddng
        '
        Me.MOSearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.MOSearchTxtBxPddng.Controls.Add(Me.MOSearchTxtBx)
        Me.MOSearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.MOSearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.MOSearchTxtBxPddng.Name = "MOSearchTxtBxPddng"
        Me.MOSearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.MOSearchTxtBxPddng.TabIndex = 0
        '
        'MOSearchTxtBx
        '
        Me.MOSearchTxtBx.BackColor = System.Drawing.Color.White
        Me.MOSearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MOSearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOSearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MOSearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.MOSearchTxtBx.Name = "MOSearchTxtBx"
        Me.MOSearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.MOSearchTxtBx.TabIndex = 0
        '
        'MOSearchBtn
        '
        Me.MOSearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MOSearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.MOSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MOSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MOSearchBtn.FlatAppearance.BorderSize = 0
        Me.MOSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MOSearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOSearchBtn.ForeColor = System.Drawing.Color.White
        Me.MOSearchBtn.Location = New System.Drawing.Point(507, 26)
        Me.MOSearchBtn.Name = "MOSearchBtn"
        Me.MOSearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.MOSearchBtn.TabIndex = 1
        Me.MOSearchBtn.UseVisualStyleBackColor = False
        '
        'MOFormTitle
        '
        Me.MOFormTitle.AutoSize = True
        Me.MOFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MOFormTitle.Location = New System.Drawing.Point(4, 28)
        Me.MOFormTitle.Name = "MOFormTitle"
        Me.MOFormTitle.Size = New System.Drawing.Size(109, 34)
        Me.MOFormTitle.TabIndex = 0
        Me.MOFormTitle.Text = "Orders"
        '
        'MOContentDockPnl
        '
        Me.MOContentDockPnl.BackColor = System.Drawing.Color.Gainsboro
        Me.MOContentDockPnl.Controls.Add(Me.MODGVPnl)
        Me.MOContentDockPnl.Controls.Add(Me.MOBtnPnl)
        Me.MOContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MOContentDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.MOContentDockPnl.Name = "MOContentDockPnl"
        Me.MOContentDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.MOContentDockPnl.TabIndex = 10
        '
        'MODGVPnl
        '
        Me.MODGVPnl.BackColor = System.Drawing.Color.White
        Me.MODGVPnl.Controls.Add(Me.MOContentPnl)
        Me.MODGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MODGVPnl.Location = New System.Drawing.Point(0, 0)
        Me.MODGVPnl.Name = "MODGVPnl"
        Me.MODGVPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 20)
        Me.MODGVPnl.Size = New System.Drawing.Size(962, 721)
        Me.MODGVPnl.TabIndex = 0
        '
        'MOContentPnl
        '
        Me.MOContentPnl.BackColor = System.Drawing.Color.White
        Me.MOContentPnl.Controls.Add(Me.MODGVItems)
        Me.MOContentPnl.Controls.Add(Me.MOSplitter)
        Me.MOContentPnl.Controls.Add(Me.MODGVOrdersPnl)
        Me.MOContentPnl.Controls.Add(Me.MOHeaderPnl)
        Me.MOContentPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MOContentPnl.Location = New System.Drawing.Point(20, 0)
        Me.MOContentPnl.Name = "MOContentPnl"
        Me.MOContentPnl.Size = New System.Drawing.Size(922, 701)
        Me.MOContentPnl.TabIndex = 3
        '
        'MODGVItems
        '
        Me.MODGVItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MODGVItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MODGVItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MODGVItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MODGVItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MODGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MODGVItems.DefaultCellStyle = DataGridViewCellStyle2
        Me.MODGVItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MODGVItems.EnableHeadersVisualStyles = False
        Me.MODGVItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MODGVItems.Location = New System.Drawing.Point(419, 90)
        Me.MODGVItems.Name = "MODGVItems"
        Me.MODGVItems.ReadOnly = True
        Me.MODGVItems.RowHeadersVisible = False
        Me.MODGVItems.Size = New System.Drawing.Size(503, 611)
        Me.MODGVItems.TabIndex = 1
        '
        'MOSplitter
        '
        Me.MOSplitter.Location = New System.Drawing.Point(399, 90)
        Me.MOSplitter.Name = "MOSplitter"
        Me.MOSplitter.Size = New System.Drawing.Size(20, 611)
        Me.MOSplitter.TabIndex = 2
        Me.MOSplitter.TabStop = False
        '
        'MODGVOrdersPnl
        '
        Me.MODGVOrdersPnl.Controls.Add(Me.MODGVOrders)
        Me.MODGVOrdersPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.MODGVOrdersPnl.Location = New System.Drawing.Point(0, 90)
        Me.MODGVOrdersPnl.Name = "MODGVOrdersPnl"
        Me.MODGVOrdersPnl.Size = New System.Drawing.Size(399, 611)
        Me.MODGVOrdersPnl.TabIndex = 27
        '
        'MODGVOrders
        '
        Me.MODGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MODGVOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MODGVOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MODGVOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MODGVOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MODGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MODGVOrders.DefaultCellStyle = DataGridViewCellStyle4
        Me.MODGVOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MODGVOrders.EnableHeadersVisualStyles = False
        Me.MODGVOrders.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MODGVOrders.Location = New System.Drawing.Point(0, 0)
        Me.MODGVOrders.Name = "MODGVOrders"
        Me.MODGVOrders.ReadOnly = True
        Me.MODGVOrders.RowHeadersVisible = False
        Me.MODGVOrders.Size = New System.Drawing.Size(399, 611)
        Me.MODGVOrders.TabIndex = 0
        '
        'MOBtnPnl
        '
        Me.MOBtnPnl.BackColor = System.Drawing.Color.White
        Me.MOBtnPnl.Controls.Add(Me.MONewBtn)
        Me.MOBtnPnl.Controls.Add(Me.MODeleteBtn)
        Me.MOBtnPnl.Controls.Add(Me.MOEditBtn)
        Me.MOBtnPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MOBtnPnl.Location = New System.Drawing.Point(962, 0)
        Me.MOBtnPnl.Name = "MOBtnPnl"
        Me.MOBtnPnl.Size = New System.Drawing.Size(222, 721)
        Me.MOBtnPnl.TabIndex = 1
        '
        'MONewBtn
        '
        Me.MONewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MONewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MONewBtn.FlatAppearance.BorderSize = 0
        Me.MONewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MONewBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MONewBtn.ForeColor = System.Drawing.Color.White
        Me.MONewBtn.Location = New System.Drawing.Point(22, 90)
        Me.MONewBtn.Name = "MONewBtn"
        Me.MONewBtn.Size = New System.Drawing.Size(178, 44)
        Me.MONewBtn.TabIndex = 0
        Me.MONewBtn.Text = "New"
        Me.MONewBtn.UseVisualStyleBackColor = False
        '
        'MODeleteBtn
        '
        Me.MODeleteBtn.BackColor = System.Drawing.Color.White
        Me.MODeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MODeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MODeleteBtn.FlatAppearance.BorderSize = 2
        Me.MODeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MODeleteBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MODeleteBtn.Location = New System.Drawing.Point(22, 218)
        Me.MODeleteBtn.Name = "MODeleteBtn"
        Me.MODeleteBtn.Size = New System.Drawing.Size(178, 44)
        Me.MODeleteBtn.TabIndex = 2
        Me.MODeleteBtn.Text = "Delete"
        Me.MODeleteBtn.UseVisualStyleBackColor = False
        '
        'MOEditBtn
        '
        Me.MOEditBtn.BackColor = System.Drawing.Color.White
        Me.MOEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MOEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MOEditBtn.FlatAppearance.BorderSize = 2
        Me.MOEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MOEditBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOEditBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MOEditBtn.Location = New System.Drawing.Point(22, 154)
        Me.MOEditBtn.Name = "MOEditBtn"
        Me.MOEditBtn.Size = New System.Drawing.Size(178, 44)
        Me.MOEditBtn.TabIndex = 1
        Me.MOEditBtn.Text = "Edit"
        Me.MOEditBtn.UseVisualStyleBackColor = False
        '
        'ManageOrdersForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.MOContentDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageOrdersForm"
        Me.Text = "ManageOrders"
        Me.MOHeaderPnl.ResumeLayout(False)
        Me.MOHeaderPnl.PerformLayout()
        Me.MOSearchPnl.ResumeLayout(False)
        Me.MOSearchTxtBxPnl.ResumeLayout(False)
        Me.MOSearchTxtBxPddng.ResumeLayout(False)
        Me.MOSearchTxtBxPddng.PerformLayout()
        Me.MOContentDockPnl.ResumeLayout(False)
        Me.MODGVPnl.ResumeLayout(False)
        Me.MOContentPnl.ResumeLayout(False)
        CType(Me.MODGVItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MODGVOrdersPnl.ResumeLayout(False)
        CType(Me.MODGVOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MOBtnPnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MOHeaderPnl As Panel
    Friend WithEvents MOSearchPnl As Panel
    Friend WithEvents MOSearchTxtBxPnl As Panel
    Friend WithEvents MOSearchTxtBxPddng As Panel
    Friend WithEvents MOSearchTxtBx As TextBox
    Friend WithEvents MOSearchBtn As Button
    Friend WithEvents MOFormTitle As Label
    Friend WithEvents MOContentDockPnl As Panel
    Friend WithEvents MODGVPnl As Panel
    Friend WithEvents MOContentPnl As Panel
    Friend WithEvents MOBtnPnl As Panel
    Friend WithEvents MONewBtn As Button
    Friend WithEvents MODeleteBtn As Button
    Friend WithEvents MOEditBtn As Button
    Friend WithEvents MODGVOrdersPnl As Panel
    Friend WithEvents MOSplitter As Splitter
    Friend WithEvents MODGVOrders As DataGridView
    Friend WithEvents MODGVItems As DataGridView
End Class
