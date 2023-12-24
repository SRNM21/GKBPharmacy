Public Class MainWindow
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerTick.Start()

        CurrentPnlLbl.Text = "Orders"
        ChangeMainWindowForm(OrdersForm)
    End Sub

    Public Sub LoadAcount()
        Avatar.BackgroundImage = UserAvatar
        LastNameLbl.Text = Username
        IDLbl.Text = UserID

        AdminFlwLyt.Visible = IsAdminUser
    End Sub

    Private Sub TimerTick_Tick(sender As Object, e As EventArgs) Handles TimerTick.Tick
        DateLbl.Text = $"{Today.DayOfWeek}, {Today,0:MMMM} {Today.Day} {Today.Year}"
        TimeLbl.Text = $"{Now.ToLongTimeString()}"
    End Sub

    Private Sub MngPhrmcstBtn_Click(sender As Object, e As EventArgs) Handles MngPhrmcstBtn.Click
        CurrentPnlLbl.Text = "Manage Pharmacist"
        ChangeMainWindowForm(ManagePharmacistsForm)
    End Sub

    Private Sub MngAccntBtn_Click(sender As Object, e As EventArgs) Handles MngAccntBtn.Click
        CurrentPnlLbl.Text = "Manage Account"
        ChangeMainWindowForm(ManageAccountForm)
    End Sub

    Private Sub MngCstmrBtn_Click(sender As Object, e As EventArgs) Handles MngCstmrBtn.Click
        CurrentPnlLbl.Text = "Manage Customer"
        ChangeMainWindowForm(ManageCustomersForm)
    End Sub

    Private Sub MngOrdersBtn_Click(sender As Object, e As EventArgs) Handles MngOrdersBtn.Click
        CurrentPnlLbl.Text = "Manage Orders"
        ChangeMainWindowForm(ManageOrdersForm)
    End Sub

    Private Sub MngItemsBtn_Click(sender As Object, e As EventArgs) Handles MngItemsBtn.Click
        CurrentPnlLbl.Text = "Manage Items"
        ChangeMainWindowForm(ManageItemsForm)
    End Sub

    Private Sub MngSpplr_Click(sender As Object, e As EventArgs) Handles MngSpplr.Click
        CurrentPnlLbl.Text = "Manage Supplier"
        ChangeMainWindowForm(ManageSupplierForm)
    End Sub

    Private Sub OrdersBtn_Click(sender As Object, e As EventArgs) Handles OrdersBtn.Click
        CurrentPnlLbl.Text = "Orders"
        ChangeMainWindowForm(OrdersForm)
    End Sub

    Private Sub InvntryBtn_Click(sender As Object, e As EventArgs) Handles InvntryBtn.Click
        CurrentPnlLbl.Text = "Inventory"
        ChangeMainWindowForm(InventoryForm)
    End Sub

    Private Sub SpplrBtn_Click(sender As Object, e As EventArgs) Handles SpplrBtn.Click
        CurrentPnlLbl.Text = "Supplier"
        ChangeMainWindowForm(SuppliersForm)
    End Sub

    Private Sub HstryBtn_Click(sender As Object, e As EventArgs) Handles HstryBtn.Click
        CurrentPnlLbl.Text = "History"
        ChangeMainWindowForm(HistoryForm)
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim response As DialogResult = MessageBox.Show("Are you sure you want to log out?", "GKB Pharmacy", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            LogInForm.UsrnmTxtBx.Text = ""
            LogInForm.PsswrdTxtBx.Text = ""
            Hide()
            LogInForm.Show()
        End If
    End Sub

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim response As DialogResult = MessageBox.Show("Are you sure you want to exit?", "GKB Pharmacy", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.No Then
            e.Cancel = True
            Return
        End If

        LogInForm.Dispose()
        Dispose()
    End Sub

End Class