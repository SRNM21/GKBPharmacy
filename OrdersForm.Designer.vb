<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrdersForm
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
        Me.ODockPanel = New System.Windows.Forms.Panel()
        Me.ContentDockPnl = New System.Windows.Forms.Panel()
        Me.OrderPnl = New System.Windows.Forms.Panel()
        Me.OrderTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderTblLyt = New System.Windows.Forms.TableLayoutPanel()
        Me.OrderIDLbl = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.CustomerLbl = New System.Windows.Forms.Label()
        Me.FooterDockPnl = New System.Windows.Forms.Panel()
        Me.LastBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.FirstBtn = New System.Windows.Forms.Button()
        Me.CurrentOrdNumLbl = New System.Windows.Forms.Label()
        Me.HeaderDockPnl = New System.Windows.Forms.Panel()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.FilterCmbBxPnl = New System.Windows.Forms.Panel()
        Me.FilterCmbBx = New System.Windows.Forms.ComboBox()
        Me.OrderSearchTxtBxPnl = New System.Windows.Forms.Panel()
        Me.OrderSearchTxtBxPddng = New System.Windows.Forms.Panel()
        Me.OrderSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.OrderSearchBtn = New System.Windows.Forms.Button()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ODockPanel.SuspendLayout()
        Me.ContentDockPnl.SuspendLayout()
        Me.OrderPnl.SuspendLayout()
        Me.HeaderTblLyt.SuspendLayout()
        Me.FooterDockPnl.SuspendLayout()
        Me.HeaderDockPnl.SuspendLayout()
        Me.FilterCmbBxPnl.SuspendLayout()
        Me.OrderSearchTxtBxPnl.SuspendLayout()
        Me.OrderSearchTxtBxPddng.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ODockPanel
        '
        Me.ODockPanel.Controls.Add(Me.ContentDockPnl)
        Me.ODockPanel.Controls.Add(Me.FooterDockPnl)
        Me.ODockPanel.Controls.Add(Me.HeaderDockPnl)
        Me.ODockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ODockPanel.Location = New System.Drawing.Point(0, 0)
        Me.ODockPanel.Name = "ODockPanel"
        Me.ODockPanel.Size = New System.Drawing.Size(1184, 721)
        Me.ODockPanel.TabIndex = 0
        '
        'ContentDockPnl
        '
        Me.ContentDockPnl.BackColor = System.Drawing.Color.White
        Me.ContentDockPnl.Controls.Add(Me.OrderPnl)
        Me.ContentDockPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentDockPnl.Location = New System.Drawing.Point(0, 80)
        Me.ContentDockPnl.Name = "ContentDockPnl"
        Me.ContentDockPnl.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ContentDockPnl.Size = New System.Drawing.Size(1184, 571)
        Me.ContentDockPnl.TabIndex = 1
        '
        'OrderPnl
        '
        Me.OrderPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderPnl.Controls.Add(Me.OrderTblLyt)
        Me.OrderPnl.Controls.Add(Me.HeaderTblLyt)
        Me.OrderPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderPnl.Location = New System.Drawing.Point(20, 0)
        Me.OrderPnl.Name = "OrderPnl"
        Me.OrderPnl.Padding = New System.Windows.Forms.Padding(2)
        Me.OrderPnl.Size = New System.Drawing.Size(1144, 571)
        Me.OrderPnl.TabIndex = 0
        '
        'OrderTblLyt
        '
        Me.OrderTblLyt.AutoScroll = True
        Me.OrderTblLyt.ColumnCount = 4
        Me.OrderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.22807!))
        Me.OrderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59649!))
        Me.OrderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.22807!))
        Me.OrderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.94737!))
        Me.OrderTblLyt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderTblLyt.Location = New System.Drawing.Point(2, 42)
        Me.OrderTblLyt.Name = "OrderTblLyt"
        Me.OrderTblLyt.RowCount = 1
        Me.OrderTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OrderTblLyt.Size = New System.Drawing.Size(1140, 527)
        Me.OrderTblLyt.TabIndex = 1
        '
        'HeaderTblLyt
        '
        Me.HeaderTblLyt.BackColor = System.Drawing.Color.White
        Me.HeaderTblLyt.ColumnCount = 4
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.32391!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.64933!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24806!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7787!))
        Me.HeaderTblLyt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.HeaderTblLyt.Controls.Add(Me.OrderIDLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.DateLbl, 0, 0)
        Me.HeaderTblLyt.Controls.Add(Me.CustomerLbl, 0, 0)
        Me.HeaderTblLyt.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderTblLyt.Location = New System.Drawing.Point(2, 2)
        Me.HeaderTblLyt.Name = "HeaderTblLyt"
        Me.HeaderTblLyt.RowCount = 1
        Me.HeaderTblLyt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HeaderTblLyt.Size = New System.Drawing.Size(1140, 40)
        Me.HeaderTblLyt.TabIndex = 0
        '
        'OrderIDLbl
        '
        Me.OrderIDLbl.AutoSize = True
        Me.OrderIDLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderIDLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderIDLbl.Location = New System.Drawing.Point(686, 0)
        Me.OrderIDLbl.Name = "OrderIDLbl"
        Me.OrderIDLbl.Size = New System.Drawing.Size(236, 40)
        Me.OrderIDLbl.TabIndex = 2
        Me.OrderIDLbl.Text = "Order ID"
        Me.OrderIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DateLbl.Location = New System.Drawing.Point(417, 0)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(263, 40)
        Me.DateLbl.TabIndex = 1
        Me.DateLbl.Text = "Date"
        Me.DateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerLbl
        '
        Me.CustomerLbl.AutoSize = True
        Me.CustomerLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CustomerLbl.Location = New System.Drawing.Point(3, 0)
        Me.CustomerLbl.Name = "CustomerLbl"
        Me.CustomerLbl.Size = New System.Drawing.Size(408, 40)
        Me.CustomerLbl.TabIndex = 0
        Me.CustomerLbl.Text = "Customer"
        Me.CustomerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FooterDockPnl
        '
        Me.FooterDockPnl.Controls.Add(Me.LastBtn)
        Me.FooterDockPnl.Controls.Add(Me.NextBtn)
        Me.FooterDockPnl.Controls.Add(Me.PrevBtn)
        Me.FooterDockPnl.Controls.Add(Me.FirstBtn)
        Me.FooterDockPnl.Controls.Add(Me.CurrentOrdNumLbl)
        Me.FooterDockPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterDockPnl.Location = New System.Drawing.Point(0, 651)
        Me.FooterDockPnl.Name = "FooterDockPnl"
        Me.FooterDockPnl.Size = New System.Drawing.Size(1184, 70)
        Me.FooterDockPnl.TabIndex = 2
        '
        'LastBtn
        '
        Me.LastBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LastBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LastBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LastBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastBtn.ForeColor = System.Drawing.Color.White
        Me.LastBtn.Location = New System.Drawing.Point(1044, 15)
        Me.LastBtn.Name = "LastBtn"
        Me.LastBtn.Size = New System.Drawing.Size(120, 40)
        Me.LastBtn.TabIndex = 4
        Me.LastBtn.UseVisualStyleBackColor = False
        '
        'NextBtn
        '
        Me.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.NextBtn.FlatAppearance.BorderSize = 2
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextBtn.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.NextBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.NextBtn.Location = New System.Drawing.Point(960, 15)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(70, 40)
        Me.NextBtn.TabIndex = 3
        Me.NextBtn.Text = ">>"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'PrevBtn
        '
        Me.PrevBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrevBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PrevBtn.FlatAppearance.BorderSize = 2
        Me.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrevBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PrevBtn.Location = New System.Drawing.Point(876, 15)
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(70, 40)
        Me.PrevBtn.TabIndex = 2
        Me.PrevBtn.Text = "<<"
        Me.PrevBtn.UseVisualStyleBackColor = True
        '
        'FirstBtn
        '
        Me.FirstBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FirstBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FirstBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FirstBtn.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.FirstBtn.ForeColor = System.Drawing.Color.White
        Me.FirstBtn.Location = New System.Drawing.Point(742, 15)
        Me.FirstBtn.Name = "FirstBtn"
        Me.FirstBtn.Size = New System.Drawing.Size(120, 40)
        Me.FirstBtn.TabIndex = 1
        Me.FirstBtn.Text = "1"
        Me.FirstBtn.UseVisualStyleBackColor = False
        '
        'CurrentOrdNumLbl
        '
        Me.CurrentOrdNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CurrentOrdNumLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentOrdNumLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CurrentOrdNumLbl.Location = New System.Drawing.Point(426, 15)
        Me.CurrentOrdNumLbl.Name = "CurrentOrdNumLbl"
        Me.CurrentOrdNumLbl.Size = New System.Drawing.Size(301, 40)
        Me.CurrentOrdNumLbl.TabIndex = 0
        Me.CurrentOrdNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HeaderDockPnl
        '
        Me.HeaderDockPnl.Controls.Add(Me.SortLbl)
        Me.HeaderDockPnl.Controls.Add(Me.FilterCmbBxPnl)
        Me.HeaderDockPnl.Controls.Add(Me.OrderSearchTxtBxPnl)
        Me.HeaderDockPnl.Controls.Add(Me.OrderSearchBtn)
        Me.HeaderDockPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderDockPnl.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDockPnl.Name = "HeaderDockPnl"
        Me.HeaderDockPnl.Size = New System.Drawing.Size(1184, 80)
        Me.HeaderDockPnl.TabIndex = 0
        '
        'SortLbl
        '
        Me.SortLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SortLbl.AutoSize = True
        Me.SortLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.SortLbl.Location = New System.Drawing.Point(883, 28)
        Me.SortLbl.Name = "SortLbl"
        Me.SortLbl.Size = New System.Drawing.Size(49, 24)
        Me.SortLbl.TabIndex = 2
        Me.SortLbl.Text = "Sort"
        '
        'FilterCmbBxPnl
        '
        Me.FilterCmbBxPnl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FilterCmbBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterCmbBxPnl.Controls.Add(Me.FilterCmbBx)
        Me.FilterCmbBxPnl.Location = New System.Drawing.Point(946, 23)
        Me.FilterCmbBxPnl.Name = "FilterCmbBxPnl"
        Me.FilterCmbBxPnl.Size = New System.Drawing.Size(218, 34)
        Me.FilterCmbBxPnl.TabIndex = 3
        '
        'FilterCmbBx
        '
        Me.FilterCmbBx.BackColor = System.Drawing.Color.White
        Me.FilterCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FilterCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterCmbBx.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FilterCmbBx.FormattingEnabled = True
        Me.FilterCmbBx.Items.AddRange(New Object() {"Newest to Oldest", "Oldest to Newest"})
        Me.FilterCmbBx.Location = New System.Drawing.Point(2, 2)
        Me.FilterCmbBx.Name = "FilterCmbBx"
        Me.FilterCmbBx.Size = New System.Drawing.Size(214, 30)
        Me.FilterCmbBx.TabIndex = 0
        '
        'OrderSearchTxtBxPnl
        '
        Me.OrderSearchTxtBxPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderSearchTxtBxPnl.Controls.Add(Me.OrderSearchTxtBxPddng)
        Me.OrderSearchTxtBxPnl.ForeColor = System.Drawing.Color.Chocolate
        Me.OrderSearchTxtBxPnl.Location = New System.Drawing.Point(20, 20)
        Me.OrderSearchTxtBxPnl.Name = "OrderSearchTxtBxPnl"
        Me.OrderSearchTxtBxPnl.Size = New System.Drawing.Size(391, 38)
        Me.OrderSearchTxtBxPnl.TabIndex = 0
        '
        'OrderSearchTxtBxPddng
        '
        Me.OrderSearchTxtBxPddng.BackColor = System.Drawing.Color.White
        Me.OrderSearchTxtBxPddng.Controls.Add(Me.OrderSearchTxtBx)
        Me.OrderSearchTxtBxPddng.ForeColor = System.Drawing.Color.Chocolate
        Me.OrderSearchTxtBxPddng.Location = New System.Drawing.Point(2, 2)
        Me.OrderSearchTxtBxPddng.Name = "OrderSearchTxtBxPddng"
        Me.OrderSearchTxtBxPddng.Size = New System.Drawing.Size(387, 34)
        Me.OrderSearchTxtBxPddng.TabIndex = 0
        '
        'OrderSearchTxtBx
        '
        Me.OrderSearchTxtBx.BackColor = System.Drawing.Color.White
        Me.OrderSearchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrderSearchTxtBx.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderSearchTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderSearchTxtBx.Location = New System.Drawing.Point(3, 5)
        Me.OrderSearchTxtBx.Name = "OrderSearchTxtBx"
        Me.OrderSearchTxtBx.Size = New System.Drawing.Size(380, 25)
        Me.OrderSearchTxtBx.TabIndex = 0
        '
        'OrderSearchBtn
        '
        Me.OrderSearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.OrderSearchBtn.BackgroundImage = Global.GKBPharmacy.My.Resources.Resources.Ico_Srch
        Me.OrderSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OrderSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderSearchBtn.FlatAppearance.BorderSize = 0
        Me.OrderSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderSearchBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderSearchBtn.ForeColor = System.Drawing.Color.White
        Me.OrderSearchBtn.Location = New System.Drawing.Point(424, 20)
        Me.OrderSearchBtn.Name = "OrderSearchBtn"
        Me.OrderSearchBtn.Size = New System.Drawing.Size(39, 38)
        Me.OrderSearchBtn.TabIndex = 1
        Me.OrderSearchBtn.UseVisualStyleBackColor = False
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProvider.ContainerControl = Me
        '
        'OrdersForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 721)
        Me.Controls.Add(Me.ODockPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrdersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdersForm"
        Me.ODockPanel.ResumeLayout(False)
        Me.ContentDockPnl.ResumeLayout(False)
        Me.OrderPnl.ResumeLayout(False)
        Me.HeaderTblLyt.ResumeLayout(False)
        Me.HeaderTblLyt.PerformLayout()
        Me.FooterDockPnl.ResumeLayout(False)
        Me.HeaderDockPnl.ResumeLayout(False)
        Me.HeaderDockPnl.PerformLayout()
        Me.FilterCmbBxPnl.ResumeLayout(False)
        Me.OrderSearchTxtBxPnl.ResumeLayout(False)
        Me.OrderSearchTxtBxPddng.ResumeLayout(False)
        Me.OrderSearchTxtBxPddng.PerformLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ODockPanel As Panel
    Friend WithEvents HeaderDockPnl As Panel
    Friend WithEvents ContentDockPnl As Panel
    Friend WithEvents FooterDockPnl As Panel
    Friend WithEvents LastBtn As Button
    Friend WithEvents NextBtn As Button
    Friend WithEvents PrevBtn As Button
    Friend WithEvents FirstBtn As Button
    Friend WithEvents CurrentOrdNumLbl As Label
    Friend WithEvents OrderSearchTxtBxPnl As Panel
    Friend WithEvents OrderSearchTxtBxPddng As Panel
    Friend WithEvents OrderSearchTxtBx As TextBox
    Friend WithEvents OrderSearchBtn As Button
    Friend WithEvents SortLbl As Label
    Friend WithEvents FilterCmbBxPnl As Panel
    Friend WithEvents FilterCmbBx As ComboBox
    Friend WithEvents OrderPnl As Panel
    Friend WithEvents HeaderTblLyt As TableLayoutPanel
    Friend WithEvents OrderIDLbl As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents CustomerLbl As Label
    Friend WithEvents OrderTblLyt As TableLayoutPanel
    Friend WithEvents ErrProvider As ErrorProvider
End Class
