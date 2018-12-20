'qms login form
'5th Jan 2016
Public Class qmsLoginForm

    Private Sub qmsLoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.GotFocus
        UsernameTextBox.SelectAll()
    End Sub

    Private Sub PasswordTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.GotFocus
        PasswordTextBox.SelectAll()
    End Sub

    Private Sub UsernameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.LostFocus
        Me.Cursor = Cursors.WaitCursor
        '  getSettings()
        createConnection()
        If sql_CNN.State = ConnectionState.Closed Then lblMessage.Text = "Unable to contact remote server, due to network/internet issue" : Me.Cursor = Cursors.Default : Exit Sub

        If Not qmsFunctions.getUserInfo(UsernameTextBox.Text) Then
            lblMessage.Text = "Incorrect user/password, try again"
        Else 'on success of username
            lblMessage.Text = QmsUserRow.name & " - " & QmsBranchInfo.Name
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        lblMessage.Text = ""
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Me.Cursor = Cursors.WaitCursor
        'getSettings()
        'createConnection()

        If sql_CNN.State = ConnectionState.Closed Then createConnection()
        If sql_CNN.State = ConnectionState.Closed Then lblMessage.Text = "Unable to contact remote server, due to network/internet issue" : Me.Cursor = Cursors.Default : Exit Sub

        If Not qmsFunctions.getUserInfo(UsernameTextBox.Text) Then
            lblMessage.Text = "Incorrect user/password, try again"
            Exit Sub
        Else 'on success of username
            If PasswordTextBox.Text <> QmsUserRow.password Then
                lblMessage.Text = "Incorrect user/password, try again"
                PasswordTextBox.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            Else 'on success
                'check for user folder
                LOGGED_USER_CODE = QmsUserRow.shortname
                LOGGED_USER_ID = QmsUserRow.ID
                LOGGED_USER_NAME = QmsUserRow.name
                If Not verifyDirectoryLocation() Then
                    lblMessage.Text = "Cannot login with this user, Quote Folder is missing or not created. Contact Admin to assist you"
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
        End If
        Me.Cursor = Cursors.Default
        Me.Hide()
        qmsMenu.Show()
        qmsMenu.Focus()
    End Sub

    Private Sub qmsLoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Call GetSettings()
            UsernameTextBox.Text = qmsDEFAULT_USER

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error Reading Applicaton Setting")
        End Try
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then Call btnLogin_Click(sender, e)
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub
End Class
