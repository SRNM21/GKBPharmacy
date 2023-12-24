Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module Util
    'SQL Connection Essentials
    Public myCmd As New MySqlCommand
    Public myRdr As MySqlDataReader
    Public myDA As New MySqlDataAdapter
    Public myConn As New MySqlConnection("server=localhost;userid=root;password=;database=gkb_pharmacy")
    Public Sql As String

    Private Admin As Boolean
    Private Avatar As Bitmap
    Private User As String
    Private ID As String

    Public Property IsAdminUser() As Boolean
        Get
            Return Admin
        End Get

        Set(val As Boolean)
            Admin = val
        End Set
    End Property

    Public Property UserAvatar() As Bitmap
        Get
            Return Avatar
        End Get

        Set(ava As Bitmap)
            Avatar = ava
        End Set
    End Property

    Public Property Username() As String
        Get
            Return User
        End Get

        Set(us As String)
            User = us
        End Set
    End Property

    Public Property UserID() As String
        Get
            Return ID
        End Get

        Set(val As String)
            ID = val
        End Set
    End Property

    'Change the docked form in the MainWindowForm
    Public Sub ChangeMainWindowForm(panel As Form)
        If Not MainWindow.SwitchWindowPnl.Controls.Contains(panel) Then
            For Each control As Control In MainWindow.SwitchWindowPnl.Controls
                control.Dispose()
            Next

            panel.TopLevel = False
            panel.TopMost = True
            panel.Dock = DockStyle.Fill
            MainWindow.SwitchWindowPnl.Controls.Add(panel)
            panel.Show()
        End If
    End Sub

    'Enable or Disable the secondary button with style
    Public Sub EnableSecondaryButton(btn As Button, enable As Boolean)
        If enable Then
            btn.Enabled = True
            btn.FlatAppearance.BorderColor = Color.FromArgb(22, 72, 99)
        Else
            btn.Enabled = False
            btn.FlatAppearance.BorderColor = Color.Gray
        End If
    End Sub

    'Enable or Disable the primary button with style
    Public Sub EnablePrimaryButton(btn As Button, enable As Boolean)
        If enable Then
            btn.Enabled = True
            btn.BackColor = Color.FromArgb(22, 72, 99)
        Else
            btn.Enabled = False
            btn.BackColor = Color.Gray
        End If
    End Sub

    'Return a Hashed/Encrypted text (Only used to check if the account logging in is admin)
    Public Function GetHash(Input As String) As String
        Using hasher As MD5 = MD5.Create()
            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(Input))
            Return Convert.ToBase64String(dbytes)
        End Using
    End Function

    'Helps the system to automatically generate our "(AAA)-AAA-AAA-000" ID's format
    Public Function GenerateID(Header As String) As String
        Dim rand As New Random()
        Dim randomLetters = Enumerable.Range(1, 3).Select(Function(x) ChrW(rand.Next(65, 91)))
        Dim randomDigits = Enumerable.Range(1, 3).Select(Function(x) rand.Next(10))
        Return New String(Header & String.Join("", randomLetters) & "-" & String.Join("", randomLetters) & "-" & String.Join("", randomDigits))
    End Function

    'Used to check if the given value has a duplicate in a given table/field (usually used in IDs, username, email, phone number)
    Public Function HasDuplicate(Table As String, Field As String, Value As String, IDInfo As List(Of String)) As Boolean
        Dim sqlBuilder As New StringBuilder()

        sqlBuilder.Append($"SELECT {Field} FROM {Table}")

        If IDInfo IsNot Nothing Then
            sqlBuilder.Append($" WHERE {IDInfo(0)} <> @id")
        End If

        myConn.Open()

        Sql = sqlBuilder.ToString()
        myCmd = New MySqlCommand(Sql, myConn)

        If IDInfo IsNot Nothing Then
            myCmd.Parameters.AddWithValue("@id", IDInfo(1))
        End If

        myRdr = myCmd.ExecuteReader()

        'Return true if the given value has a duplicate in the database
        While myRdr.Read()
            If Value = myRdr(0).ToString() Then
                myConn.Close()
                Return True
            End If
        End While

        myConn.Close()
        Return False
    End Function

    'Automatically update the datagridview after the operations
    Public Sub UpdateDataGrid(Query As String, DGV As DataGridView)
        Dim DataTable As New DataTable()
        myConn.Open()

        Sql = Query

        myCmd = New MySqlCommand(Sql, myConn)

        myDA.SelectCommand = myCmd
        myDA.Fill(DataTable)

        DGV.DataSource = DataTable
        myConn.Close()

        DGV.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        DGV.DefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Regular)
    End Sub

    'Highlight the datagridview cells that matches the passed value in the passed datagridview
    Public Sub SearchInDataGrid(DG As DataGridView, Value As String)
        If Not String.IsNullOrWhiteSpace(Value) Then
            DG.ClearSelection()

            For Each row As DataGridViewRow In DG.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString().Contains(Value) Then
                        cell.Selected = True
                    End If
                Next
            Next
        End If
    End Sub
End Module
