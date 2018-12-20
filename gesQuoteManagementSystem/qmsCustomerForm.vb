Imports System.Data
Imports System.Data.SqlClient

Public Class qmsCustomerForm
    Dim recID As Integer = 0
    Dim fAction As String = ""

    Private Sub qmsCustomerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        qmsFunctions.initClientData()
        initForm()
        '        Me.Show()
        Call LockForm(True)
        btnAddNew.Enabled = True
        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnAddNew.Focus()

        Me.Left = 1
        Me.Top = 1

    End Sub

    Private Sub AddNew()
        Dim rtnVal As Integer
        qmsFunctions.initClientData()
        initForm()
        Try
            Me.Cursor = Cursors.WaitCursor
            rtnVal = getClientMaxCode()
            'rtnVal = 5555
            Me.Cursor = Cursors.Default

            If rtnVal > 0 Then txtClientCode.Text = rtnVal

            lnkEditClient.Visible = False
            lblCreatedBy.Text = "Created By - " & LOGGED_USER_NAME
            lblEditedBy.Tag = LOGGED_USER_ID
            lblEditedBy.Text = ""

            btnSave.Enabled = True
            btnSearch.Enabled = False
            btnCancel.Visible = True
            btnCancel.BringToFront()


            Call LockForm(False)
            txtClientCode.ReadOnly = True

            txtFullName.Focus()
            fAction = "A"
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error contacting cloud server")
        End Try


    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Call AddNew()
    End Sub



    Private Sub initForm()
        chkIsActive.Checked = False
        txtClientCode.Clear()
        txtClientCode.Tag = 0
        txtFullName.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtContact1.Clear()
        txtContact2.Clear()
        txtContact3.Clear()
        txtContactPerson1.Clear()
        txtContactPerson2.Clear()
        txtContactPerson3.Clear()
        txtEmail1.Clear()
        txtEmail2.Clear()
        txtEmail3.Clear()
        lblCreatedBy.Text = LOGGED_USER_NAME
        lblCreatedBy.Tag = LOGGED_USER_ID
        lblEditedBy.Text = ""
        lblEditedBy.Tag = 0
        txtDepartment1.Clear()
        txtDepartment2.Clear()
        txtDepartment3.Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'validation check
        If txtClientCode.Text < 1 Then MsgBox("Incorrect Client Code", MsgBoxStyle.Critical, "Cannot Save") : txtClientCode.Focus() : Exit Sub
        If String.IsNullOrEmpty(txtFullName.Text) Then MsgBox("Customer Name is mandatory", MsgBoxStyle.Critical, "Cannot Save") : txtFullName.Focus() : Exit Sub

        If fAction = "" Then Exit Sub

        If AddClient() Then
            Me.Cursor = Cursors.Default
            MsgBox("Data written sucessfully...", MsgBoxStyle.Information, "Confirmation")
            btnAddNew.BringToFront()
            btnSave.Enabled = False
            btnSearch.Enabled = True
            'lock text box
            Call LockForm(True)
            btnAddNew.Focus()
        End If


    End Sub




    Private Function AddClient() As Boolean
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim cmdbuilder As SqlCommandBuilder

        'Dim cmdbuilder As SqlCommandBuilder

        frmWaitForm.lblTitle.Text = "Sending data to cloud server. please wait..!"
        frmWaitForm.Show()
        frmWaitForm.Refresh()
        Me.Cursor = Cursors.WaitCursor
        sql_String = ""

        Try
            If fAction = "A" Then
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandText = "Insert into clients(code,fullname) values(" & txtClientCode.Text & ",'" & txtFullName.Text & "');"
                cmd.Connection = sql_CNN
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                cmd = Nothing
            End If


            'Call getSettings()
            'Call createConnection()
            If sql_CNN.State = ConnectionState.Closed Then createConnection()

            cmdbuilder = New SqlCommandBuilder(adapter) 'create command builder object to automatically generate insert,update and delete stmt
            '    ds = Nothing
            With adapter
                sql_String = "select * from clients where code=" & txtClientCode.Text
                .SelectCommand = New SqlCommand(sql_String, sql_CNN) 'add object select command
                .Fill(ds, "cdata")
            End With
            If ds.Tables("cdata").Rows.Count > 0 Then 'update
                With ds.Tables("cdata").Rows(0)
                    .Item("code") = txtClientCode.Text
                    .Item("fullname") = txtFullName.Text

                    .Item("Address1") = txtAddress1.Text
                    .Item("Address2") = txtAddress2.Text
                    .Item("ContactPerson1") = txtContactPerson1.Text
                    .Item("ContactPerson2") = txtContactPerson2.Text
                    .Item("ContactPerson3") = txtContactPerson3.Text

                    .Item("Email1") = txtEmail1.Text
                    .Item("Email2") = txtEmail2.Text
                    .Item("Email3") = txtEmail3.Text

                    .Item("Contact1") = txtContact1.Text
                    .Item("Contact2") = txtContact2.Text
                    .Item("Contact3") = txtContact3.Text

                    .Item("Department1") = txtDepartment1.Text
                    .Item("Department2") = txtDepartment2.Text
                    .Item("Department3") = txtDepartment3.Text

                    .Item("IsActive") = IIf(chkIsActive.Checked, 0, 1)
                    If fAction = "A" Then .Item("CreatedBy") = LOGGED_USER_NAME
                    .Item("EditedBy") = LOGGED_USER_NAME
                    .Item("EditedOn") = System.DateTime.Now.ToString

                End With
                adapter.Update(ds, "cdata")
                Return True
            End If

        Catch ex As Exception
            frmWaitForm.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Something went wrong while writing data to server...")
            Return False
        Finally
            frmWaitForm.Close()
            Me.Cursor = Cursors.Default
            adapter = Nothing
            cmdbuilder = Nothing
            ds.Dispose()
            ds = Nothing
            dr = Nothing
        End Try
    End Function

    'Private Function UpdateClient() As Boolean
    '    Dim adapter As New SqlDataAdapter
    '    Dim ds As New DataSet
    '    Dim dr As DataRow
    '    Dim cmdbuilder As SqlCommandBuilder

    '    'Dim cmdbuilder As SqlCommandBuilder

    '    frmWaitForm.lblTitle.Text = "Sending data to cloud server. please wait..!"
    '    frmWaitForm.Show()
    '    frmWaitForm.Refresh()
    '    Me.Cursor = Cursors.WaitCursor


    '    Try

    '        'Call getSettings()
    '        'Call createConnection()
    '        'Call getSettings()
    '        'Call createConnection()
    '        If sql_CNN.State = ConnectionState.Closed Then createConnection()

    '        cmdbuilder = New SqlCommandBuilder(adapter) 'create command builder object to automatically generate insert,update and delete stmt

    '        With adapter
    '            sql_String = "select * from clients where code=" & txtClientCode.Text
    '            .SelectCommand = New SqlCommand(sql_String, sql_CNN) 'add object select command
    '            .Fill(ds, "cdata")
    '        End With
    '        If ds.Tables("cdata").Rows.Count > 0 Then 'new row

    '            dr = ds.Tables("cdata").NewRow 'addnew
    '            ds.Tables("cdata").Rows.Add(dr) 'add the row to dataset
    '            With dr
    '                .Item("code") = txtClientCode.Text
    '                .Item("fullname") = txtFullName.Text

    '                .Item("Address1") = txtAddress1.Text
    '                .Item("Address2") = txtAddress2.Text
    '                .Item("ContactPerson1") = txtContactPerson1.Text
    '                .Item("ContactPerson2") = txtContactPerson2.Text
    '                .Item("ContactPerson3") = txtContactPerson3.Text

    '                .Item("Email1") = txtEmail1.Text
    '                .Item("Email2") = txtEmail2.Text
    '                .Item("Email3") = txtEmail3.Text

    '                .Item("Contact1") = txtContact1.Text
    '                .Item("Contact2") = txtContact2.Text
    '                .Item("Contact3") = txtContact3.Text

    '                .Item("Department1") = txtDepartment1.Text
    '                .Item("Department2") = txtDepartment2.Text
    '                .Item("Department3") = txtDepartment3.Text

    '                .Item("IsActive") = IIf(chkIsActive.Checked, 0, 1)
    '                .Item("CreatedBy") = LOGGED_USER_NAME
    '                .Item("EditedBy") = LOGGED_USER_NAME
    '                .Item("EditedOn") = System.DateTime.Now.ToString

    '                adapter.Update(ds, "cdata")

    '                Return True
    '            End With

    '        End If

    '    Catch ex As Exception
    '        frmWaitForm.Close()
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Something went wrong while writing data to server...")
    '        Return False
    '    Finally
    '        frmWaitForm.Close()
    '        Me.Cursor = Cursors.Default
    '        adapter = Nothing
    '        ds.Dispose()
    '        ds = Nothing
    '        dr = Nothing
    '    End Try
    'End Function

#Region "setfocusColor"

    Private Sub txtClientCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClientCode.GotFocus
        txtClientCode.SelectAll()
        '        txtClientCode.BackColor = Color.Bisque
    End Sub
    Private Sub txtClientCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClientCode.LostFocus
        '       txtClientCode.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtFullName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFullName.GotFocus
        txtFullName.SelectAll()
        txtFullName.BackColor = Color.Bisque
    End Sub
    Private Sub txtFullName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFullName.LostFocus
        txtFullName.BackColor = Color.WhiteSmoke
        txtFullName.Text = setPlainText_Name(txtFullName.Text)
    End Sub

    Private Sub txtAddress1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress1.GotFocus
        txtAddress1.SelectAll()
        txtAddress1.BackColor = Color.Bisque
    End Sub
    Private Sub txtAddress1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress1.LostFocus
        txtAddress1.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtAddress2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress2.GotFocus
        txtAddress2.SelectAll()
        txtAddress2.BackColor = Color.Bisque
    End Sub
    Private Sub txtAddress2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress2.LostFocus
        txtAddress2.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtContact1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact1.GotFocus
        txtContact1.SelectAll()
        txtContact1.BackColor = Color.Bisque
    End Sub
    Private Sub txtContact1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact1.LostFocus
        txtContact1.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtContact2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact2.GotFocus
        txtContact2.SelectAll()
        txtContact2.BackColor = Color.Bisque
    End Sub
    Private Sub txtContact2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact2.LostFocus
        txtContact2.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtContact3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact3.GotFocus
        txtContact3.SelectAll()
        txtContact3.BackColor = Color.Bisque
    End Sub
    Private Sub txtContact3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact3.LostFocus
        txtContact3.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtDepartment1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment1.GotFocus
        txtDepartment1.SelectAll()
        txtDepartment1.BackColor = Color.Bisque
    End Sub
    Private Sub txtDepartment1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment1.LostFocus
        txtDepartment1.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtDepartment2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment2.GotFocus
        txtDepartment2.SelectAll()
        txtDepartment2.BackColor = Color.Bisque
    End Sub
    Private Sub txtDepartment2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment2.LostFocus
        txtDepartment2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub txtDepartment3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment3.GotFocus
        txtDepartment3.SelectAll()
        txtDepartment3.BackColor = Color.Bisque
    End Sub
    Private Sub txtDepartment3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment3.LostFocus
        txtDepartment3.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtEmail1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail1.GotFocus
        txtEmail1.SelectAll()
        txtEmail1.BackColor = Color.Bisque
    End Sub
    Private Sub txtEmail1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail1.LostFocus
        txtEmail1.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtEmail2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail2.GotFocus
        txtEmail2.SelectAll()
        txtEmail2.BackColor = Color.Bisque
    End Sub
    Private Sub txtEmail2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail2.LostFocus
        txtEmail2.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtEmail3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail3.GotFocus
        txtEmail3.SelectAll()
        txtEmail3.BackColor = Color.Bisque
    End Sub
    Private Sub txtEmail3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail3.LostFocus
        txtEmail3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub txtContactPerson1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson1.GotFocus
        txtContactPerson1.SelectAll()
        txtContactPerson1.BackColor = Color.Bisque
    End Sub
    Private Sub txtContactPerson1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson1.LostFocus
        txtContactPerson1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub txtContactPerson2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson2.GotFocus
        txtContactPerson2.SelectAll()
        txtContactPerson2.BackColor = Color.Bisque
    End Sub
    Private Sub txtContactPerson2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson2.LostFocus
        txtContactPerson2.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtContactPerson3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson3.GotFocus
        txtContactPerson3.SelectAll()
        txtContactPerson3.BackColor = Color.Bisque
    End Sub
    Private Sub txtContactPerson3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson3.LostFocus
        txtContactPerson3.BackColor = Color.WhiteSmoke
    End Sub
#End Region

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If fAction <> "" Then
            If fAction = "A" Then
                If MsgBox("Are you sure, you want to cancel adding/editing new customer?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cancel Action") = MsgBoxResult.No Then Exit Sub
            End If
            fAction = ""
            lnkEditClient.Visible = False
            btnCancel.Visible = False
            btnAddNew.BringToFront()
            btnSave.Enabled = False
            btnSearch.Enabled = True
            initForm()
            Call LockForm(True)
            txtClientCode.Focus()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        fAction = ""
        qmsListOfValues.ShowDialog()

        If ClientData.ID > 0 Then
            txtClientCode.Tag = ClientData.ID
            txtClientCode.Text = ClientData.Code
            txtFullName.Text = ClientData.FullName
            txtAddress1.Text = ClientData.Address1
            txtAddress2.Text = ClientData.Address2

            txtContactPerson1.Text = ClientData.ContactPerson1
            txtContactPerson2.Text = ClientData.ContactPerson2
            txtContactPerson3.Text = ClientData.ContactPerson3
            txtDepartment1.Text = ClientData.Department1
            txtDepartment2.Text = ClientData.Department2
            txtDepartment3.Text = ClientData.Department3

            txtContact1.Text = ClientData.Contact1
            txtContact3.Text = ClientData.Contact2
            txtContact2.Text = ClientData.Contact3

            txtEmail1.Text = ClientData.Email1
            txtEmail2.Text = ClientData.Email2
            txtEmail3.Text = ClientData.Email3
            chkIsActive.Checked = ClientData.IsActive

            lblCreatedBy.Text = "Created By - " & ClientData.CreatedBy & " (" & ClientData.CreatedOn & ")"
            lblEditedBy.Text = "Edited By - " & ClientData.EditedBy & " (" & ClientData.EditedOn & ")"

            fAction = "E"
            btnCancel.Visible = True : btnCancel.BringToFront()
            btnSearch.Enabled = False
            btnSave.Enabled = True
            lnkEditClient.Visible = True
            txtFullName.Focus()
        End If

    End Sub

    Private Sub LockForm(ByVal stat As Boolean)
        txtFullName.ReadOnly = stat
        txtAddress1.ReadOnly = stat
        txtAddress2.ReadOnly = stat
        txtContact1.ReadOnly = stat
        txtContact2.ReadOnly = stat
        txtContact3.ReadOnly = stat
        txtDepartment1.ReadOnly = stat
        txtDepartment2.ReadOnly = stat
        txtDepartment3.ReadOnly = stat
        txtEmail1.ReadOnly = stat
        txtEmail2.ReadOnly = stat
        txtEmail3.ReadOnly = stat
        txtContactPerson1.ReadOnly = stat
        txtContactPerson2.ReadOnly = stat
        txtContactPerson3.ReadOnly = stat
        chkIsActive.Enabled = Not stat
    End Sub

    Private Sub lnkEditClient_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkEditClient.Click
        lnkEditClient.Visible = False
        Call LockForm(False)
        fAction = "E"
        txtFullName.Focus()
    End Sub


    Private Sub lnkEditClient_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEditClient.LinkClicked
        lnkEditClient.Visible = False
        Call LockForm(False)
        fAction = "E"
        txtFullName.Focus()
    End Sub

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub
End Class