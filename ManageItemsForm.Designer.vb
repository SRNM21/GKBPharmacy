<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageItemsForm
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
        Me.MIHeaderPnl = New System.Windows.Forms.Panel()
        Me.MISearchPnl = New System.Windows.Forms.Panel()
        Me.MISearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.MISearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.MISearchTxtBx = New System.Windows.Forms.TextBox()
        Me.MISearchBtn = New System.Windows.Forms.Button()
        Me.MIFormTitle = New System.Windows.Forms.Label()
        Me.MIContentDockPnl = New System.Windows.Forms.Panel()
        Me.MIDGVPnl = New System.Windows.Forms.Panel()
        Me.MIContentPnl = New System.Windows.Forms.Panel()
        Me.MIDGV = New System.Windows.Forms.DataGridView()
        Me.MIBtnPnl = New System.Windows.Forms.Panel()
        Me.MINewBtn = New System.Windows.Forms.Button()
        Me.MIDeleteBtn = New System.Windows.Forms.Button()
        Me.MIEditBtn = New System.Windows.Forms.Button()
        Me.MIHeaderPnl.SuspendLayout()
        Me.MISearchPnl.SuspendLayout()
        Me.MISearchTxtBxPnl.SuspendLayout()
        Me.MISearchTxtBxPddng.SuspendLayout()
        Me.MIContentDockPnl.SuspendLayout()
        Me.MIDGVPnl.SuspendLayout()
        Me.MIContentPnl.SuspendLayout()
        CType(Me.MIDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MIBtnPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MIHeaderPnl
        '
        Me.MIHeaderPnl.BackColor = System.Drawing.Color.White
        Me.MIHeaderPnl.Controls.Add(Me.MISearchPnl)
        Me.MIHeaderPnl.Controls.Add(Me.MIFormTitle)
        Me.MIHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MIHeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.MIHeaderPnl.Name = "MIHeaderPnl"
        Me.MIHeaderPnl.Size = New System.Drawing.Size(922, 90)
        Me.MIHeaderPnl.TabIndex = 0
        '
        'MISearchPnl
        '
        Me.MISearchPnl.BackColor = System.Drawing.Color.White
        Me.MISearchPnl.Controls.Add(Me.MISearchTxtBxPnl)
        Me.MISearchPnl.Controls.Add(Me.MISearchBtn)
        Me.MISearchPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MISearchPnl.Location = New System.Drawing.Point(375, 0)
        Me.MISearchPnl.Name = "MISearchPnl"
        Me.MISearchPnl.Size = New System.Drawing.Size(547, 90)
        Me.MISearchPnl.TabIndex = 1
        '
        'MISearchTxtBxPnl
        '
        Me.MISearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MISearchTxtBxPnl.Controls.Add(Me.MISearchTxtBxPddng)
        Me.MISearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.MISearchTxtBxPnl.Location = New System.Drawing.Point(105, 26)
        Me.MISearchTxtBxPnl.Name = "MISearchTxtBxPnl"
        Me.MISearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.MISearchTxtBxPnl.TabIndex = 0
        '
        'MISearchTxtBxPddng
        '
        Me.MISearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.MISearchTxtBxPddng.Controls.Add(Me.MISearchTxtBx)
        Me.MISearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.MISearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.MISearchTxtBxPddng.Name = "MISearchTxtBxPddng"
        Me.MISearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.MISearchTxtBxPddng.TabIndex = 0
        '
        'MISearchTxtBx
        '
        Me.MISearchTxtBx.BackColor = System.Drawing.Color.White
        Me.MISearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MISearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MISearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MISearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.MISearchTxtBx.Name = "MISearchTxtBx"
        Me.MISearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.MISearchTxtBx.TabIndex = 0
        '
        'MISearchBtn
        '
        Me.MISearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MISearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.MISearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MISearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MISearchBtn.FlatAppearance.BorderSize = 0
        Me.MISearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MISearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MISearchBtn.ForeColor = System.Drawing.Color.White
        Me.MISearchBtn.Location = New System.Drawing.Point(507, 26)
        Me.MISearchBtn.Name = "MISearchBtn"
        Me.MISearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.MISearchBtn.TabIndex = 1
        Me.MISearchBtn.UseVisualStyleBackColor = False
        '
        'MIFormTitle
        '
        Me.MIFormTitle.AutoSize = True
        Me.MIFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MIFormTitle.Location = New System.Drawing.Point(4, 28)
        Me.MIFormTitle.Name = "MIFormTitle"
        Me.MIFormTitle.Size = New System.Drawing.Size(91, 34)
        Me.MIFormTitle.TabIndex = 0
        Me.MIFormTitle.Text = "Items"
        '
        'MIContentDockPnl
        '
        Me.MIContentDockPnl.BackColor = System.Drawing.Color.Gainsboro
        Me.MIContentDockPnl.Controls.Add(Me.MIDGVPnl)
        Me.MIContentDockPnl.Controls.Add(Me.MIBtnPnl)
        Me.MIContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MIContentDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.MIContentDockPnl.Name = "MIContentDockPnl"
        Me.MIContentDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.MIContentDockPnl.TabIndex = 10
        '
        'MIDGVPnl
        '
        Me.MIDGVPnl.BackColor = System.Drawing.Color.White
        Me.MIDGVPnl.Controls.Add(Me.MIContentPnl)
        Me.MIDGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MIDGVPnl.Location = New System.Drawing.Point(0, 0)
        Me.MIDGVPnl.Name = "MIDGVPnl"
        Me.MIDGVPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 20)
        Me.MIDGVPnl.Size = New System.Drawing.Size(962, 721)
        Me.MIDGVPnl.TabIndex = 0
        '
        'MIContentPnl
        '
        Me.MIContentPnl.BackColor = System.Drawing.Color.White
        Me.MIContentPnl.Controls.Add(Me.MIDGV)
        Me.MIContentPnl.Controls.Add(Me.MIHeaderPnl)
        Me.MIContentPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MIContentPnl.Location = New System.Drawing.Point(20, 0)
        Me.MIContentPnl.Name = "MIContentPnl"
        Me.MIContentPnl.Size = New System.Drawing.Size(922, 701)
        Me.MIContentPnl.TabIndex = 3
        '
        'MIDGV
        '
        Me.MIDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MIDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MIDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MIDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MIDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MIDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MIDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.MIDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MIDGV.EnableHeadersVisualStyles = False
        Me.MIDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MIDGV.Location = New System.Drawing.Point(0, 90)
        Me.MIDGV.Name = "MIDGV"
        Me.MIDGV.ReadOnly = True
        Me.MIDGV.RowHeadersVisible = False
        Me.MIDGV.Size = New System.Drawing.Size(922, 611)
        Me.MIDGV.TabIndex = 1
        '
        'MIBtnPnl
        '
        Me.MIBtnPnl.BackColor = System.Drawing.Color.White
        Me.MIBtnPnl.Controls.Add(Me.MINewBtn)
        Me.MIBtnPnl.Controls.Add(Me.MIDeleteBtn)
        Me.MIBtnPnl.Controls.Add(Me.MIEditBtn)
        Me.MIBtnPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MIBtnPnl.Location = New System.Drawing.Point(962, 0)
        Me.MIBtnPnl.Name = "MIBtnPnl"
        Me.MIBtnPnl.Size = New System.Drawing.Size(222, 721)
        Me.MIBtnPnl.TabIndex = 1
        '
        'MINewBtn
        '
        Me.MINewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MINewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MINewBtn.FlatAppearance.BorderSize = 0
        Me.MINewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MINewBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MINewBtn.ForeColor = System.Drawing.Color.White
        Me.MINewBtn.Location = New System.Drawing.Point(22, 90)
        Me.MINewBtn.Name = "MINewBtn"
        Me.MINewBtn.Size = New System.Drawing.Size(178, 44)
        Me.MINewBtn.TabIndex = 0
        Me.MINewBtn.Text = "New"
        Me.MINewBtn.UseVisualStyleBackColor = False
        '
        'MIDeleteBtn
        '
        Me.MIDeleteBtn.BackColor = System.Drawing.Color.White
        Me.MIDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MIDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MIDeleteBtn.FlatAppearance.BorderSize = 2
        Me.MIDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MIDeleteBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MIDeleteBtn.Location = New System.Drawing.Point(22, 218)
        Me.MIDeleteBtn.Name = "MIDeleteBtn"
        Me.MIDeleteBtn.Size = New System.Drawing.Size(178, 44)
        Me.MIDeleteBtn.TabIndex = 2
        Me.MIDeleteBtn.Text = "Delete"
        Me.MIDeleteBtn.UseVisualStyleBackColor = False
        '
        'MIEditBtn
        '
        Me.MIEditBtn.BackColor = System.Drawing.Color.White
        Me.MIEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MIEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MIEditBtn.FlatAppearance.BorderSize = 2
        Me.MIEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MIEditBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIEditBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MIEditBtn.Location = New System.Drawing.Point(22, 154)
        Me.MIEditBtn.Name = "MIEditBtn"
        Me.MIEditBtn.Size = New System.Drawing.Size(178, 44)
        Me.MIEditBtn.TabIndex = 1
        Me.MIEditBtn.Text = "Edit"
        Me.MIEditBtn.UseVisualStyleBackColor = False
        '
        'ManageItemsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.MIContentDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageItemsForm"
        Me.Text = "ManageItemsForm"
        Me.MIHeaderPnl.ResumeLayout(False)
        Me.MIHeaderPnl.PerformLayout()
        Me.MISearchPnl.ResumeLayout(False)
        Me.MISearchTxtBxPnl.ResumeLayout(False)
        Me.MISearchTxtBxPddng.ResumeLayout(False)
        Me.MISearchTxtBxPddng.PerformLayout()
        Me.MIContentDockPnl.ResumeLayout(False)
        Me.MIDGVPnl.ResumeLayout(False)
        Me.MIContentPnl.ResumeLayout(False)
        CType(Me.MIDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MIBtnPnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MIHeaderPnl As Panel
    Friend WithEvents MISearchPnl As Panel
    Friend WithEvents MISearchTxtBxPnl As Panel
    Friend WithEvents MISearchTxtBxPddng As Panel
    Friend WithEvents MISearchTxtBx As TextBox
    Friend WithEvents MISearchBtn As Button
    Friend WithEvents MIFormTitle As Label
    Friend WithEvents MIContentDockPnl As Panel
    Friend WithEvents MIDGVPnl As Panel
    Friend WithEvents MIContentPnl As Panel
    Friend WithEvents MIBtnPnl As Panel
    Friend WithEvents MINewBtn As Button
    Friend WithEvents MIDeleteBtn As Button
    Friend WithEvents MIEditBtn As Button
    Friend WithEvents MIDGV As DataGridView
End Class
