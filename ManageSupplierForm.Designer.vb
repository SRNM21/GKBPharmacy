<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSupplierForm
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
        Me.MSBtnPnl = New System.Windows.Forms.Panel()
        Me.MSNewBtn = New System.Windows.Forms.Button()
        Me.MSDeleteBtn = New System.Windows.Forms.Button()
        Me.MSEditBtn = New System.Windows.Forms.Button()
        Me.MSHeaderPnl = New System.Windows.Forms.Panel()
        Me.MSSearchPnl = New System.Windows.Forms.Panel()
        Me.MSSearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.MSSearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.MSSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.MSSearchBtn = New System.Windows.Forms.Button()
        Me.MSFormTitle = New System.Windows.Forms.Label()
        Me.MSContentDockPnl = New System.Windows.Forms.Panel()
        Me.MSDGVPnl = New System.Windows.Forms.Panel()
        Me.MSContentPnl = New System.Windows.Forms.Panel()
        Me.MSDGV = New System.Windows.Forms.DataGridView()
        Me.MSBtnPnl.SuspendLayout()
        Me.MSHeaderPnl.SuspendLayout()
        Me.MSSearchPnl.SuspendLayout()
        Me.MSSearchTxtBxPnl.SuspendLayout()
        Me.MSSearchTxtBxPddng.SuspendLayout()
        Me.MSContentDockPnl.SuspendLayout()
        Me.MSDGVPnl.SuspendLayout()
        Me.MSContentPnl.SuspendLayout()
        CType(Me.MSDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSBtnPnl
        '
        Me.MSBtnPnl.BackColor = System.Drawing.Color.White
        Me.MSBtnPnl.Controls.Add(Me.MSNewBtn)
        Me.MSBtnPnl.Controls.Add(Me.MSDeleteBtn)
        Me.MSBtnPnl.Controls.Add(Me.MSEditBtn)
        Me.MSBtnPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MSBtnPnl.Location = New System.Drawing.Point(962, 0)
        Me.MSBtnPnl.Name = "MSBtnPnl"
        Me.MSBtnPnl.Size = New System.Drawing.Size(222, 721)
        Me.MSBtnPnl.TabIndex = 1
        '
        'MSNewBtn
        '
        Me.MSNewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSNewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSNewBtn.FlatAppearance.BorderSize = 0
        Me.MSNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MSNewBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSNewBtn.ForeColor = System.Drawing.Color.White
        Me.MSNewBtn.Location = New System.Drawing.Point(22, 90)
        Me.MSNewBtn.Name = "MSNewBtn"
        Me.MSNewBtn.Size = New System.Drawing.Size(178, 44)
        Me.MSNewBtn.TabIndex = 0
        Me.MSNewBtn.Text = "New"
        Me.MSNewBtn.UseVisualStyleBackColor = False
        '
        'MSDeleteBtn
        '
        Me.MSDeleteBtn.BackColor = System.Drawing.Color.White
        Me.MSDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSDeleteBtn.FlatAppearance.BorderSize = 2
        Me.MSDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MSDeleteBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSDeleteBtn.Location = New System.Drawing.Point(22, 218)
        Me.MSDeleteBtn.Name = "MSDeleteBtn"
        Me.MSDeleteBtn.Size = New System.Drawing.Size(178, 44)
        Me.MSDeleteBtn.TabIndex = 2
        Me.MSDeleteBtn.Text = "Delete"
        Me.MSDeleteBtn.UseVisualStyleBackColor = False
        '
        'MSEditBtn
        '
        Me.MSEditBtn.BackColor = System.Drawing.Color.White
        Me.MSEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSEditBtn.FlatAppearance.BorderSize = 2
        Me.MSEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MSEditBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSEditBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSEditBtn.Location = New System.Drawing.Point(22, 154)
        Me.MSEditBtn.Name = "MSEditBtn"
        Me.MSEditBtn.Size = New System.Drawing.Size(178, 44)
        Me.MSEditBtn.TabIndex = 1
        Me.MSEditBtn.Text = "Edit"
        Me.MSEditBtn.UseVisualStyleBackColor = False
        '
        'MSHeaderPnl
        '
        Me.MSHeaderPnl.BackColor = System.Drawing.Color.White
        Me.MSHeaderPnl.Controls.Add(Me.MSSearchPnl)
        Me.MSHeaderPnl.Controls.Add(Me.MSFormTitle)
        Me.MSHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MSHeaderPnl.Location = New System.Drawing.Point(0, 0)
        Me.MSHeaderPnl.Name = "MSHeaderPnl"
        Me.MSHeaderPnl.Size = New System.Drawing.Size(922, 90)
        Me.MSHeaderPnl.TabIndex = 0
        '
        'MSSearchPnl
        '
        Me.MSSearchPnl.BackColor = System.Drawing.Color.White
        Me.MSSearchPnl.Controls.Add(Me.MSSearchTxtBxPnl)
        Me.MSSearchPnl.Controls.Add(Me.MSSearchBtn)
        Me.MSSearchPnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.MSSearchPnl.Location = New System.Drawing.Point(375, 0)
        Me.MSSearchPnl.Name = "MSSearchPnl"
        Me.MSSearchPnl.Size = New System.Drawing.Size(547, 90)
        Me.MSSearchPnl.TabIndex = 1
        '
        'MSSearchTxtBxPnl
        '
        Me.MSSearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSSearchTxtBxPnl.Controls.Add(Me.MSSearchTxtBxPddng)
        Me.MSSearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.MSSearchTxtBxPnl.Location = New System.Drawing.Point(105, 26)
        Me.MSSearchTxtBxPnl.Name = "MSSearchTxtBxPnl"
        Me.MSSearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.MSSearchTxtBxPnl.TabIndex = 0
        '
        'MSSearchTxtBxPddng
        '
        Me.MSSearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.MSSearchTxtBxPddng.Controls.Add(Me.MSSearchTxtBx)
        Me.MSSearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.MSSearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.MSSearchTxtBxPddng.Name = "MSSearchTxtBxPddng"
        Me.MSSearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.MSSearchTxtBxPddng.TabIndex = 0
        '
        'MSSearchTxtBx
        '
        Me.MSSearchTxtBx.BackColor = System.Drawing.Color.White
        Me.MSSearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MSSearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSSearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSSearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.MSSearchTxtBx.Name = "MSSearchTxtBx"
        Me.MSSearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.MSSearchTxtBx.TabIndex = 0
        '
        'MSSearchBtn
        '
        Me.MSSearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSSearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.MSSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MSSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSSearchBtn.FlatAppearance.BorderSize = 0
        Me.MSSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MSSearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSSearchBtn.ForeColor = System.Drawing.Color.White
        Me.MSSearchBtn.Location = New System.Drawing.Point(507, 26)
        Me.MSSearchBtn.Name = "MSSearchBtn"
        Me.MSSearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.MSSearchBtn.TabIndex = 1
        Me.MSSearchBtn.UseVisualStyleBackColor = False
        '
        'MSFormTitle
        '
        Me.MSFormTitle.AutoSize = True
        Me.MSFormTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSFormTitle.Location = New System.Drawing.Point(4, 28)
        Me.MSFormTitle.Name = "MSFormTitle"
        Me.MSFormTitle.Size = New System.Drawing.Size(147, 34)
        Me.MSFormTitle.TabIndex = 0
        Me.MSFormTitle.Text = "Suppliers"
        '
        'MSContentDockPnl
        '
        Me.MSContentDockPnl.BackColor = System.Drawing.Color.Gainsboro
        Me.MSContentDockPnl.Controls.Add(Me.MSDGVPnl)
        Me.MSContentDockPnl.Controls.Add(Me.MSBtnPnl)
        Me.MSContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSContentDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.MSContentDockPnl.Name = "MSContentDockPnl"
        Me.MSContentDockPnl.Size = New System.Drawing.Size(1184, 721)
        Me.MSContentDockPnl.TabIndex = 11
        '
        'MSDGVPnl
        '
        Me.MSDGVPnl.BackColor = System.Drawing.Color.White
        Me.MSDGVPnl.Controls.Add(Me.MSContentPnl)
        Me.MSDGVPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSDGVPnl.Location = New System.Drawing.Point(0, 0)
        Me.MSDGVPnl.Name = "MSDGVPnl"
        Me.MSDGVPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 20)
        Me.MSDGVPnl.Size = New System.Drawing.Size(962, 721)
        Me.MSDGVPnl.TabIndex = 0
        '
        'MSContentPnl
        '
        Me.MSContentPnl.BackColor = System.Drawing.Color.White
        Me.MSContentPnl.Controls.Add(Me.MSDGV)
        Me.MSContentPnl.Controls.Add(Me.MSHeaderPnl)
        Me.MSContentPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSContentPnl.Location = New System.Drawing.Point(20, 0)
        Me.MSContentPnl.Name = "MSContentPnl"
        Me.MSContentPnl.Size = New System.Drawing.Size(922, 701)
        Me.MSContentPnl.TabIndex = 3
        '
        'MSDGV
        '
        Me.MSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MSDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MSDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MSDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MSDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.MSDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSDGV.EnableHeadersVisualStyles = False
        Me.MSDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MSDGV.Location = New System.Drawing.Point(0, 90)
        Me.MSDGV.Name = "MSDGV"
        Me.MSDGV.ReadOnly = True
        Me.MSDGV.RowHeadersVisible = False
        Me.MSDGV.Size = New System.Drawing.Size(922, 611)
        Me.MSDGV.TabIndex = 1
        '
        'ManageSupplierForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.MSContentDockPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageSupplierForm"
        Me.Text = "ManageSupplierForm"
        Me.MSBtnPnl.ResumeLayout(False)
        Me.MSHeaderPnl.ResumeLayout(False)
        Me.MSHeaderPnl.PerformLayout()
        Me.MSSearchPnl.ResumeLayout(False)
        Me.MSSearchTxtBxPnl.ResumeLayout(False)
        Me.MSSearchTxtBxPddng.ResumeLayout(False)
        Me.MSSearchTxtBxPddng.PerformLayout()
        Me.MSContentDockPnl.ResumeLayout(False)
        Me.MSDGVPnl.ResumeLayout(False)
        Me.MSContentPnl.ResumeLayout(False)
        CType(Me.MSDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MSBtnPnl As Panel
    Friend WithEvents MSNewBtn As Button
    Friend WithEvents MSDeleteBtn As Button
    Friend WithEvents MSEditBtn As Button
    Friend WithEvents MSHeaderPnl As Panel
    Friend WithEvents MSSearchPnl As Panel
    Friend WithEvents MSSearchTxtBxPnl As Panel
    Friend WithEvents MSSearchTxtBxPddng As Panel
    Friend WithEvents MSSearchTxtBx As TextBox
    Friend WithEvents MSSearchBtn As Button
    Friend WithEvents MSFormTitle As Label
    Friend WithEvents MSContentDockPnl As Panel
    Friend WithEvents MSDGVPnl As Panel
    Friend WithEvents MSContentPnl As Panel
    Friend WithEvents MSDGV As DataGridView
End Class
