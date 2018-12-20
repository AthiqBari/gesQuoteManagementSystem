'http://www.iconarchive.com/show/origami-colored-pencil-icons-by-double-j-design.html
Imports System.Data
Imports System.Data.SqlClient
Imports System.Exception
Imports Excel = Microsoft.Office.Interop.Excel 'c:\Program Files\Microsoft Visual Studio 12.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Excel.dll
Imports System.Text.RegularExpressions
'office 2010

Public Class qmsAddForm
    Const frmHideHistory As Integer = 752
    Const frmShowHistory As Integer = 799
    Dim mcVar As Integer = 0
    Dim ds As New DataSet
    Dim rowcount As Integer = 0

    Dim intQuoteNo As Integer = 0
    Dim intQuoteID As Integer = 0
    Dim bolSkipCodeCheck As Boolean = False

    Dim QuoteFileName As String = ""
    Dim TemplateFileName As String = ""
    Dim copyFileName As String = "" 
    Dim isCalled As Boolean

    Public Sub New(ByVal quoteID As Integer)
        InitializeComponent()
        isCalled = IIf(quoteID > 0, True, False)
        intQuoteID = quoteID
    End Sub

    'Sub New()
    '    ' TODO: Complete member initialization 
    'End Sub

    Private Sub qmsAddForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub qmsAddForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("Close this form?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Me.Hide()
            '            Me.Close()
        End If
    End Sub



    Private Sub qmsAddForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        ' Me.Height = 'frmHideHistory
        'nomoreinuse
        'Me.Tag = 0 'used to close form without warning msg
        lnkShowHistory.Visible = False
        lnkHideHistory.Visible = False
        Me.Left = 1
        Me.Top = 1
        initForm()
        txtQuoteDate.Text = Today.Date()
        txtQuoteStatus.Text = "<NEW>"

        LOGGED_USER_CODE = QmsUserRow.shortname
        LOGGED_USER_ID = QmsUserRow.id
        LOGGED_USER_NAME = QmsUserRow.name


        If Not verifyFileLocation() Then Me.Cursor = Cursors.Default : Me.Hide()
        Me.Cursor = Cursors.Default
        PanelTip.Visible = True

        cmbShipmentType.Tag = -1
        qmsFunctions.fillComboBox(cmbShipmentType, "id", "Name", "shipmenttype", "id", "where id>=0", "name")
        cmbShipmentType.Tag = 0
        lblTemplateFile.Text = ""
        QuoteFileName = ""
        TemplateFileName = ""


        '-----------------------------------------------------------------------------
        If isCalled Then
            Dim ds As New DataSet
            ds = getQuoteDataByID(intQuoteID)
            rowcount = ds.Tables("cdata").Rows.Count
            If rowcount > 0 Then
                Timer1.Enabled = True
                lblCopyQuote.Text = "Copy of Quote# [" & ds.Tables("cdata").Rows(0).Item("qnumber").ToString & "]"
                lblCopyQuote.Visible = True

                txtQuoteDate.Text = ds.Tables("cdata").Rows(0).Item("quote date").ToString
                txtQuoteValidDate.Text = ds.Tables("cdata").Rows(0).Item("validity").ToString
                txtQuoteStatus.Text = ds.Tables("cdata").Rows(0).Item("status").ToString
                txtQuoteDescription.Text = ds.Tables("cdata").Rows(0).Item("title").ToString
                copyFileName = ds.Tables("cdata").Rows(0).Item("filename").ToString


                Dim idx As Integer = 0
                '                cmbShipmentType.Tag = -1
                idx = cmbShipmentType.FindString(ds.Tables("cdata").Rows(0).Item("type").ToString)
                If idx >= 0 Then cmbShipmentType.SelectedIndex = idx
                cmbShipmentType.Tag = 0

                Call getClientInfo(ds.Tables("cdata").Rows(0).Item("cltcd").ToString, "")
                Call displayClient()
                PanelTip.Visible = False
                'show quote history
                Call generateQuoteNumber()
                Call showQuotes(ClientData.ID)
            End If
        End If
        '-----------------------------------------------------------------------------

        btnClientList.Focus()
        'txtClientCode.Focus()


    End Sub

    Private Sub initForm()
        Timer1.Enabled = False
        lblCopyQuote.Visible = False
        QuoteFileName = ""
        TemplateFileName = ""
        txtClientCode.Clear()
        txtClientName.Clear()
        txtClientAddress1.Clear()
        txtClientContactPerson1.Clear()
        txtClientEmail1.Clear()
        txtQuoteDescription.Clear()
        txtQuoteNo.Clear()
        txtQuoteDate.Text = "__/__/____"
        txtQuoteValidDate.Text = "__/__/____"
        txtQuoteDescription.Clear()
        txtCurrency.Text = "SAR"

        txtDepartment1.Clear()
        txtClientEmail1.Clear()
        txtContact1.Clear()
        lblTemplateFile.Text = ""
        Me.Height = frmHideHistory
        initClientData()
        initqmsData()
        lblQuoteHistory.Text = "Quote History"



    End Sub


    Private Sub lnkShowHistory_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkShowHistory.LinkClicked
        Me.Height = frmShowHistory
        lnkShowHistory.Visible = False
        lnkHideHistory.Visible = True
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub lnkHideHistory_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkHideHistory.LinkClicked
        Me.Height = frmHideHistory
        lnkShowHistory.Visible = True
        lnkHideHistory.Visible = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnGenerateQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateQuote.Click
        'form-level validations
        If Not verifyFileLocation() Then Me.Close() 'close when faile to locate qms folder


        If String.IsNullOrEmpty(TemplateFileName) Then MsgBox("You need to select template file", MsgBoxStyle.Exclamation, "Validation Checker") : cmbTemplate.Focus() : Exit Sub
        If MonthCalendar1.Visible = True Then MonthCalendar1.Visible = False
        If Not IsDate(txtQuoteDate.Text) Then txtQuoteDate.Text = Today.Date
        If Not IsDate(txtQuoteValidDate.Text) Then txtQuoteValidDate.Text = Today.Date

        '        txtClientName.Text = Regex.Replace(txtClientName.Text, "[^\w\\-]", "")

        txtClientName.Text = setPlainText_Name(txtClientName.Text)


        'yes part goes here...
        'validataio npart goes here
        If String.IsNullOrEmpty(txtQuoteDescription.Text) Then MsgBox("Please enter quote description", MsgBoxStyle.Exclamation, "Validataion Check") : txtQuoteDescription.Focus() : Exit Sub
        If String.IsNullOrEmpty(txtClientName.Text) Then MsgBox("Client details are missing", MsgBoxStyle.Exclamation, "Validataion Check") : txtClientCode.Focus() : Exit Sub
        If txtClientCode.Tag = 0 Then MsgBox("Select client from list", MsgBoxStyle.Exclamation, "Validataion Check") : txtClientCode.Focus() : Exit Sub
        If cmbShipmentType.SelectedIndex = 0 Then MsgBox("What is the Shipment Type..?", MsgBoxStyle.Exclamation, "Validataion Check") : cmbShipmentType.Focus() : Exit Sub
        If cmbTemplate.Text = "" Then MsgBox("You need to choose template from the list", MsgBoxStyle.Exclamation, "Validataion Check") : cmbTemplate.Focus() : Exit Sub

        If Trim(txtQuoteDescription.Text.Length) < 10 Then MsgBox("Quote Description looks improper or insufficient text", MsgBoxStyle.Exclamation, "Validataion Check") : txtQuoteDescription.Focus() : Exit Sub


        If MsgBox("You are about to Generate new Quote, Continue ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

        'here we need to regenerate the quote-number to check if already taken by any other user***
        Call generateQuoteNumber()

        Dim newFile As String
        Dim sourceFile As String = ""
        Dim folderName As String = ""

        QuoteFileName = txtQuoteNo.Text & "-" & Now.Hour.ToString & Now.Minute.ToString & ".xls"
        ' newFile = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & QuoteFileName

        Call setQMSData()
        Call setClientAddress()



        sourceFile = IIf(isCalled, qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & copyFileName, qmsLOCAL_FOLDER & "template\" & TemplateFileName)
        newFile = QuoteFileName.ToString
        folderName = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & ClientData.Code & "-" & ClientData.FullName


        If createQuoteFile(sourceFile, newFile, folderName) Then
            If exportQMSDataToExcel((folderName & "\" & newFile), True) Then
                If AddQuote((ClientData.Code & "-" & ClientData.FullName) & "\" & newFile) Then
                    lockcontrols(True)
                    btnAddNewQuote.Visible = True
                    PanelConfirmation.Visible = True
                    Me.Height = frmShowHistory
                    Call showQuotes(ClientData.ID)
                    If isCalled Then
                        btnAddNewQuote.Visible = False
                        MsgBox("Copy Quote created successfully!, Refresh your Quote-Explorer Form", MsgBoxStyle.Information, "Quote Copy")
                        Me.Hide()
                    End If
                Else
                    MsgBox("There was problem writing data, Please try again", MsgBoxStyle.Critical, Me.Text)

                End If
            End If
        Else
            MsgBox("System could not find template file at location " & vbCrLf & qmsLOCAL_FOLDER & "template\" & TemplateFileName & "  Make sure your QMS Folder is in proper format", MsgBoxStyle.Critical, "File not found")
            Exit Sub
        End If

    End Sub
    Private Sub setQMSData()
        Call initqmsData()
        With QmsDataRow
            .SerialNumber = intQuoteNo
            .ReferenceCode = txtQuoteNo.Text
            .Currency = "SAR"
            .QuoteDate = txtQuoteDate.Text
            .Validity = txtQuoteValidDate.Text
            .ShipmentID = cmbShipmentType.SelectedValue
            .TemplateID = cmbTemplate.SelectedValue
            .Title = txtQuoteDescription.Text
            .Attention = cmbAttn.SelectedIndex
            .ShipmentType = cmbShipmentType.Text
            .TemplateName = cmbTemplate.Text
        End With

    End Sub
    Private Sub setClientAddress()
        Call initqmsClientAddress()
        With QmsClientAddress
            .Address1 = txtClientAddress1.Text
            .Address2 = ""
            .ContactPerson = txtClientContactPerson1.Text
            .Department = txtDepartment1.Text
            .Email = txtClientEmail1.Text
        End With
    End Sub


    Private Sub txtQuoteDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuoteDate.GotFocus
        txtQuoteDate.BackColor = Color.Bisque
        With MonthCalendar1
            .Top = 129
            .Left = 638
            .Visible = True
            .BringToFront()
        End With
        mcVar = 1
    End Sub


    Private Sub txtQuoteValidDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuoteValidDate.GotFocus
        txtQuoteValidDate.BackColor = Color.Bisque
        With MonthCalendar1
            .Top = 151
            .Left = 638
            .Visible = True
            .BringToFront()
        End With
        mcVar = 2
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Select Case mcVar
            Case 1 : txtQuoteDate.Text = e.Start : txtQuoteValidDate.Focus()
            Case 2 : txtQuoteValidDate.Text = e.Start : bolSkipCodeCheck = True ': cmbShipmentType.Focus()
                MonthCalendar1.Visible = False
        End Select

    End Sub

    Private Sub txtQuoteValidDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuoteValidDate.LostFocus
        If MonthCalendar1.Visible Then MonthCalendar1.Visible = False
        txtQuoteValidDate.BackColor = Color.WhiteSmoke
    End Sub

 
    Private Sub cmbCustomer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If MonthCalendar1.Visible Then MonthCalendar1.Visible = False

    End Sub

    Private Sub txtQuoteDescription_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuoteDescription.GotFocus
        If MonthCalendar1.Visible Then MonthCalendar1.Visible = False
        txtQuoteDescription.BackColor = Color.Bisque
        'generate quote text

        Dim qText As String = ""
        ' If String.IsNullOrEmpty(txtQuoteDescription.Text) Then
        qText = "Offer for " & cmbShipmentType.Text & " Service - " & cmbTemplate.Text
        qText += " Under the following prices..."
        txtQuoteDescription.Text = qText
        ' End If

    End Sub

    Private Sub txtClientCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClientCode.GotFocus
        txtClientCode.BackColor = Color.Bisque
        If MonthCalendar1.Visible Then MonthCalendar1.Visible = False
    End Sub

    Private Sub txtClientCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClientCode.KeyDown
        bolSkipCodeCheck = False
    End Sub

    Private Sub txtClientCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClientCode.LostFocus
        'txtClientCode.BackColor = Color.WhiteSmoke
        'If bolSkipCodeCheck Then Exit Sub
        'If IsNumeric(txtClientCode.Text) Then
        '    Me.Cursor = Cursors.WaitCursor
        '    If qmsFunctions.getClientInfo(txtClientCode.Text, "") Then
        '        txtClientCode.Tag = clientData.ID
        '        txtClientName.Text = clientData.FullName
        '        txtClientAddress1.Text = clientData.Address1 & " - " & clientData.Address2

        '        txtClientContactPerson1.Text = clientData.ContactPerson1
        '        txtClientEmail1.Text = clientData.Email1
        '        txtDepartment1.Text = clientData.Department1
        '        txtContact1.Text = clientData.Contact1

        '        cmbAttn.Tag = -1 : cmbAttn.SelectedIndex = 0 : cmbAttn.Tag = 0
        '        Me.Cursor = Cursors.WaitCursor
        '        Call generateQuoteNumber()
        '        Me.Cursor = Cursors.Default

        '    Else
        '        txtClientCode.Tag = 0
        '        txtClientName.Text = "<NOT IN RECORDS>"
        '        txtClientAddress1.Clear()
        '        txtClientContactPerson1.Clear()
        '        txtClientEmail1.Clear()
        '        txtContact1.Clear()
        '        txtDepartment1.Clear()

        '    End If
        '    bolSkipCodeCheck = False
        '    Me.Cursor = Cursors.Default

        'End If
    End Sub

    Private Sub generateQuoteNumber()
        intQuoteNo = getNewQuoteNumberByClient(ClientData.ID)
        txtQuoteNo.Text = txtClientCode.Text & "-" & LOGGED_USER_CODE & "-" & Format(intQuoteNo, "000")

    End Sub

    Private Sub cmbShipmentType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbShipmentType.GotFocus
        txtClientCode.BackColor = Color.Bisque
    End Sub

    Private Sub cmbShipmentType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbShipmentType.LostFocus
        txtClientCode.BackColor = Color.WhiteSmoke
    End Sub


    Private Sub cmbShipmentType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShipmentType.SelectedIndexChanged
        If cmbShipmentType.Tag = -1 Then Exit Sub
        'fill in related templates
        lblTemplateFile.Text = "" : TemplateFileName = ""
        If cmbShipmentType.SelectedIndex > 0 Then
            Me.Cursor = Cursors.WaitCursor

            cmbTemplate.Tag = -1
            qmsFunctions.fillComboBox(cmbTemplate, "id", "title", "templates", "id", "where isactive=1 and ShipmentTypeID=" & cmbShipmentType.SelectedIndex, "title")
            cmbTemplate.Tag = 0

            TemplateFileName = getTemplateFileName(cmbTemplate.SelectedValue)
            lblTemplateFile.Text = TemplateFileName

            Me.Cursor = Cursors.Default
        Else
            cmbTemplate.DataSource = Nothing
            cmbTemplate.Items.Clear()
            cmbTemplate.Items.Remove(cmbTemplate.DisplayMember)
        End If


    End Sub


    Private Sub btnClientList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientList.Click
        If PanelTip.Visible Then PanelTip.Visible = False
        qmsListOfValues.ShowDialog()
        intQuoteNo = 0
        If ClientData.ID > 0 Then
            Call displayClient()
            Call generateQuoteNumber()
            'show quote history
            Call showQuotes(ClientData.ID)
        End If
    End Sub
    Private Sub displayClient()
        txtClientCode.Tag = ClientData.ID
        txtClientCode.Text = ClientData.Code
        txtClientName.Text = ClientData.FullName
        txtClientAddress1.Text = ClientData.Address1 & " - " & ClientData.Address2
        txtClientContactPerson1.Text = ClientData.ContactPerson1
        txtDepartment1.Text = ClientData.Department1
        txtClientEmail1.Text = ClientData.Email1
        txtContact1.Text = ClientData.Contact1
        cmbAttn.Tag = -1 : cmbAttn.SelectedIndex = 0 : cmbAttn.Tag = 0
    End Sub

    Private Sub showQuotes(ByVal clientID As Integer)
        Me.Cursor = Cursors.WaitCursor
        Dim ds As New DataSet
        Dim rowCount As Integer
        ds = qmsFunctions.getQuoteList(clientID)

        rowCount = ds.Tables("cdata").Rows.Count
        If rowCount > 0 Then
            lblQuoteHistory.Text = "Listing Quotes of - " & txtClientName.Text
            With DGView1
                .DataSource = Nothing
                .AllowUserToDeleteRows = False : .AllowUserToAddRows = False
                .DefaultCellStyle.WrapMode = DataGridViewTriState.False '  = DataGridViewTriState.True
                .DataSource = ds.Tables("cdata")
                .BackgroundColor = Color.Gray
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ReadOnly = True
                .RowHeadersWidth = 5
                '.Columns(0).Frozen = True : .Columns(1).Frozen = True : .Columns(2).Frozen = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .Columns("qnumber").Width = 85
                .Columns("type").Width = 90
                .Columns("title").Width = 253
                .Columns("created by").Width = 77
                .Columns("quote date").Width = 83
                .Columns("validity").Width = 80
                .Columns("quoteid").Visible = False
                .Columns("clientid").Visible = False
                .Columns("Address").Visible = False
                .Columns("Email").Visible = False
                .Columns("Contact").Visible = False
                .Columns("Department").Visible = False
                .Columns("shortname").Visible = False
                .DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular, GraphicsUnit.Point)
                .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold, GraphicsUnit.Point)

                .RowsDefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew

            End With
        Else
            DGView1.DataSource = Nothing
            ds.Clear()
        End If
        Me.Cursor = Cursors.Default
        'gesMDI.ToolStripStatusLabel.Text = "Found : " & DGView1.Rows.Count
    End Sub


    Private Sub cmbAttn_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAttn.SelectedIndexChanged
        If txtClientCode.Tag > 0 Then
            If cmbAttn.SelectedIndex = 0 Then
                txtClientContactPerson1.Text = ClientData.ContactPerson1
                txtClientEmail1.Text = ClientData.Email1
                txtDepartment1.Text = ClientData.Department1
                txtContact1.Text = ClientData.Contact1
            ElseIf cmbAttn.SelectedIndex = 1 Then
                txtClientContactPerson1.Text = ClientData.ContactPerson2
                txtClientEmail1.Text = ClientData.Email2
                txtDepartment1.Text = ClientData.Department2
                txtContact1.Text = ClientData.Contact2
            ElseIf cmbAttn.SelectedIndex = 2 Then
                txtClientContactPerson1.Text = ClientData.ContactPerson3
                txtClientEmail1.Text = ClientData.Email3
                txtDepartment1.Text = ClientData.Department3
                txtContact1.Text = ClientData.Contact3

            End If
        End If
    End Sub


    Private Sub txtQuoteDescription_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuoteDescription.LostFocus
        txtQuoteDescription.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub txtQuoteDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuoteDate.LostFocus
        txtQuoteDate.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub cmbTemplate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTemplate.GotFocus
        txtClientCode.BackColor = Color.Bisque
    End Sub

    Private Sub cmbTemplate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTemplate.LostFocus
        txtClientCode.BackColor = Color.WhiteSmoke
    End Sub


    Private Function AddQuote(ByVal newQuoteFile As String) As Boolean
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim cmdbuilder As SqlCommandBuilder

        'Dim cmdbuilder As SqlCommandBuilder

        frmWaitForm.lblTitle.Text = "Sending data to cloud server. please wait..!"
        frmWaitForm.Show()
        frmWaitForm.Refresh()
        Me.Cursor = Cursors.WaitCursor


        Try
            'Call getSettings()
            'Call createConnection()
            If sql_CNN.State = ConnectionState.Closed Then createConnection()
            If sql_CNN.State = ConnectionState.Open Then

                cmdbuilder = New SqlCommandBuilder(adapter) 'create command builder object to automatically generate insert,update and delete stmt

                With adapter
                    sql_String = "select * from quotes where id=0"
                    .SelectCommand = New SqlCommand(sql_String, sql_CNN) 'add object select command
                    .Fill(ds, "cdata")
                End With
                If ds.Tables("cdata").Rows.Count = 0 Then 'new row
                    dr = ds.Tables("cdata").NewRow 'addnew
                    ds.Tables("cdata").Rows.Add(dr) 'add the row to dataset
                    With dr
                        .Item("UserID") = LOGGED_USER_ID
                        .Item("ClientID") = ClientData.ID
                        .Item("SerialNumber") = QmsDataRow.SerialNumber
                        .Item("QNumber") = QmsDataRow.ReferenceCode
                        .Item("QType") = QmsDataRow.ShipmentID
                        .Item("Title") = QmsDataRow.Title
                        .Item("QDate") = QmsDataRow.QuoteDate
                        .Item("QDateValidity") = QmsDataRow.Validity
                        .Item("FileLocation") = newQuoteFile
                        .Item("Status") = 1 'new
                        .Item("TemplateID") = QmsDataRow.TemplateID



                        adapter.Update(ds, "cdata")

                        Return True
                    End With
                End If
            End If
        Catch ex As Exception
            frmWaitForm.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Something went wrong while writing data to server...")
            Return False
        Finally
            frmWaitForm.Close()
            Me.Cursor = Cursors.Default
            adapter = Nothing
            ds.Dispose()
            ds = Nothing
            dr = Nothing
        End Try
    End Function

    Private Sub processQuoteFile()
        MsgBox("process quote file")
    End Sub

    Private Sub lnkFileLocation_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFileLocation.LinkClicked
        Dim fileinfo As String
        fileinfo = "Local-Machine QMS Folder - [" & qmsLOCAL_FOLDER & "]" & vbCrLf
        fileinfo += "Logged User Folder - [" & qmsLOCAL_FOLDER & "\" & LOGGED_USER_CODE & "]" & vbCrLf
        fileinfo += "Template Folder - [" & qmsLOCAL_FOLDER & "\Template]"
        MsgBox(fileinfo, MsgBoxStyle.Information, lnkFileLocation.ToString)
    End Sub


    Private Sub cmbTemplate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTemplate.SelectedIndexChanged
        If cmbTemplate.Tag = -1 Then Exit Sub
        'get template file name from temp-id
        If cmbTemplate.SelectedIndex >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            TemplateFileName = getTemplateFileName(cmbTemplate.SelectedValue)
            lblTemplateFile.Text = TemplateFileName
            Me.Cursor = Cursors.Default
        End If
    End Sub


    Private Sub txtClientCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientCode.TextChanged
        If PanelTip.Visible Then PanelTip.Visible = False
    End Sub

    Private Sub btnAddNewQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewQuote.Click
        Me.Cursor = Cursors.Default
        btnAddNewQuote.Visible = False
        lockcontrols(False)
        initForm()
        txtQuoteDate.Text = Today.Date()
        txtQuoteStatus.Text = "<NEW>"
        PanelTip.Visible = True
        btnClientList.Focus()
        Call showQuotes(9999)

    End Sub


    Private Sub lockcontrols(ByVal stat As Boolean)
        txtClientCode.ReadOnly = stat
        txtQuoteValidDate.Enabled = Not stat
        txtQuoteDate.Enabled = Not stat
        txtQuoteDescription.ReadOnly = stat
        btnClientList.Enabled = Not stat
        cmbShipmentType.Enabled = Not stat
        btnGenerateQuote.Enabled = Not stat
        cmbTemplate.Enabled = Not stat


    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblCopyQuote.Visible = Not lblCopyQuote.Visible
    End Sub

    Private Sub txtQuoteDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuoteDescription.TextChanged

    End Sub

    Private Sub txtQuoteDate_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtQuoteDate.MaskInputRejected

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class
