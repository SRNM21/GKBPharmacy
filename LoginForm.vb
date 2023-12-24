Imports MySql.Data.MySqlClient

Public Class LogInForm
    Private ShowPassFlag As Boolean = True

    Private Function IsAdmin(user As String, pass As String) As List(Of String)
        myConn.Open()

        'Find account in admin
        Sql = "SELECT * FROM admin"
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            'Return the info of admin if found
            If user = myRdr("username").ToString() AndAlso pass = myRdr("password").ToString() Then

                Dim info As New List(Of String) From {
                        myRdr("admin_id").ToString(),
                        user
                }

                myConn.Close()
                Return info
            End If
        End While

        myConn.Close()
        Return Nothing
    End Function

    Private Function IsPharmacist(user As String, pass As String) As List(Of String)
        Dim Found As Boolean = False
        Dim ID As String = ""

        'Find accoun in pharmacist accounts
        Sql = "SELECT * FROM pharmacist_accounts"
        myConn.Open()
        myCmd = New MySqlCommand(Sql, myConn)
        myRdr = myCmd.ExecuteReader()

        While myRdr.Read()
            If user = myRdr("username").ToString() AndAlso pass = myRdr("password").ToString() Then
                ID = myRdr("phrmcst_id")
                Found = True
                Exit While
            End If
        End While

        myConn.Close()

        'Return the info of pharmacist if found
        If Found Then
            Sql = $"SELECT * FROM pharmacists WHERE phrmcst_id = '{ID}'"
            myConn.Open()
            myCmd = New MySqlCommand(Sql, myConn)
            myRdr = myCmd.ExecuteReader()

            If myRdr.Read Then
                Dim info As New List(Of String) From {
                        myRdr("phrmcst_id").ToString(),
                        myRdr("last_name").ToString(),
                        myRdr("gender").ToString()
                }

                myConn.Close()
                Return info
            End If
        End If

        myConn.Close()
        Return Nothing
    End Function

    Private Sub HidePssBtn_Click(sender As Object, e As EventArgs) Handles HidePssBtn.Click
        If ShowPassFlag Then
            PsswrdTxtBx.UseSystemPasswordChar = False
            HidePssBtn.BackgroundImage = My.Resources.ShowPass
        Else
            PsswrdTxtBx.UseSystemPasswordChar = True
            HidePssBtn.BackgroundImage = My.Resources.HidePass
        End If

        ShowPassFlag = Not ShowPassFlag
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        'Check all Text Box if empty
        ErrProvider.Clear()

        If String.IsNullOrWhiteSpace(UsrnmTxtBx.Text) Then
            ErrProvider.SetError(UsrnmTxtBxPnl, "Username must not be null")
        ElseIf String.IsNullOrWhiteSpace(PsswrdTxtBx.Text) Then
            ErrProvider.SetError(PsswrdTxtBxPnl, "Password must not be null")
        Else
            'Check Account
            Dim HashedPass As String = GetHash(PsswrdTxtBx.Text)
            Dim Adm As List(Of String) = IsAdmin(UsrnmTxtBx.Text, HashedPass)

            If Adm IsNot Nothing Then
                IsAdminUser = True

                UserAvatar = My.Resources.ADM_Ava
                Username = Adm(1)
                UserID = Adm(0)

                Hide()
                MainWindow.LoadAcount()
                MainWindow.Show()
                Return
            End If

            Dim Pha As List(Of String) = IsPharmacist(UsrnmTxtBx.Text, PsswrdTxtBx.Text)

            If Pha IsNot Nothing Then
                IsAdminUser = False

                UserAvatar = If(Pha(2) = "Male", My.Resources.PHA_M_ava, My.Resources.PHA_F_ava)
                Username = Pha(1)
                UserID = Pha(0)

                Hide()
                MainWindow.LoadAcount()
                MainWindow.Show()
                Return
            End If

            MessageBox.Show("Account does not registered", "GKB Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LogInForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim response As DialogResult = MessageBox.Show("Are you sure you want to exit?", "GKB Pharmacy", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.No Then
            e.Cancel = True
        End If

        MainWindow.Dispose()
        Dispose()
    End Sub
End Class
