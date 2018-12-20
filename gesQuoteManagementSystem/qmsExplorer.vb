'QMS - Explorer
'12th Jan 2016
Imports System.Data
'Imports FileOperation = System.IO
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel 'c:\Program Files\Microsoft Visual Studio 12.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Excel.dll

Imports System.Runtime.InteropServices
Imports System.Net.Mail

'Imports Outlook = Microsoft.Office.Interop.Outlook
'This code is in GitHub repository now.

Public Class qmsExplorer

    Dim PreparedByCellLocation As String
    Dim AuthorizedByCellLocation As String
    Dim TemplateName As String

    Private Sub qmsExplorer_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub qmsExplorer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbSearchBy.Tag = -1
        qmsFunctions.fillComboBox(cmbSearchBy, "id", "Name", "searchfields", "sortid", "where id>=0", "name")
        cmbSearchBy.Tag = 0

        cmbSearchBy.Focus()
        txtSearchValue.Text = "Enter search value"
        Me.Left = 1
        Me.Top = 1
        chkShowMyQuotes.Checked = True

    End Sub

    Private Sub txtSearchValue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchValue.Click
        txtSearchValue.SelectAll()
    End Sub

    Private Sub txtSearchValue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchValue.GotFocus
        txtSearchValue.SelectAll()

    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        txtSearchValue.Focus()
    End Sub

    Private Sub showEvents()
        Me.Cursor = Cursors.WaitCursor
        Dim ds As New DataSet
        Dim rowCount As Integer
        rowCount = 0
        Try
            ds = getEventList(qmsQUOTE_ID)

            rowCount = ds.Tables("qdata").Rows.Count
            If rowCount > 0 Then
                With dgvEvents
                    .DataSource = Nothing
                    .AllowUserToDeleteRows = False : .AllowUserToAddRows = False
                    .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .DataSource = ds.Tables(0)
                    .BackgroundColor = Color.Gray
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .ReadOnly = True
                    .RowHeadersWidth = 5
                    '.Columns(0).Frozen = True : .Columns(1).Frozen = True : .Columns(2).Frozen = True
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .Columns("event").Width = 114
                    .Columns("created").Width = 165
                    .Columns("user").Width = 53

                    .RowsDefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
                End With
            Else
                dgvEvents.DataSource = Nothing
                ds.Clear()
            End If
            Me.Cursor = Cursors.Default


        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation, "showEvents")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub showQuotes()
        Me.Cursor = Cursors.WaitCursor
        Dim ds As New DataSet
        Dim rowCount As Integer
        Dim fldName As String = ""
        Try
            initFormViewData()
            If cmbSearchBy.SelectedIndex = 0 Or cmbSearchBy.SelectedIndex = 1 Then fldName = "QNumber"
            If cmbSearchBy.SelectedIndex = 2 Then fldName = "customer"
            If cmbSearchBy.SelectedIndex = 3 Then fldName = "title"
            If cmbSearchBy.SelectedIndex = 4 Then fldName = "type"
            If cmbSearchBy.SelectedIndex = 5 Then fldName = "[created by]"

            'cmbShowOption.SelectedIndex
            ds = quoteExplorer(fldName, txtSearchValue.Text.ToString, 0, IIf(chkShowMyQuotes.Checked, LOGGED_USER_CODE, ""))

            rowCount = ds.Tables("cdata").Rows.Count
            If rowCount > 0 Then
                With DGView1
                    .DataSource = Nothing
                    .AllowUserToDeleteRows = False : .AllowUserToAddRows = False
                    .DefaultCellStyle.WrapMode = DataGridViewTriState.False
                    .DataSource = ds.Tables("cdata")
                    .BackgroundColor = Color.Gray
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .ReadOnly = True
                    .RowHeadersWidth = 5

                    '.Columns(0).Frozen = True : .Columns(1).Frozen = True : .Columns(2).Frozen = True
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .Columns("qnumber").Width = 85
                    .Columns("type").Width = 90
                    .Columns("title").Width = 307
                    .Columns("created by").Width = 110
                    .Columns("quote date").Width = 83
                    .Columns("validity").Width = 80
                    .Columns("customer").Width = 327
                    .Columns("quoteid").Visible = False 
                    .Columns("clientid").Visible = False
                    ' .Columns(4).DefaultCellStyle.Font = New Font(FontStyle.Bold, FontStyle.Italic)

                    .RowsDefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew

                    .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point)
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point)
                    '.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red


                End With
                lblMsg.Text = "Found " & rowCount & " Items"
            Else
                lblMsg.Text = "No matching records found, Try again"
                DGView1.DataSource = Nothing
                ds.Clear()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation, "showQuotes")
            Me.Cursor = Cursors.Default
        Finally
            Me.Cursor = Cursors.Default

        End Try

        'gesMDI.ToolStripStatusLabel.Text = "Found : " & DGView1.Rows.Count
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        If Not String.IsNullOrEmpty(txtSearchValue.Text) Then Call showQuotes()
    End Sub

    Private Sub DGView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGView1.CellClick
        'fill form-view 
        initFormViewData()
        With DGView1
            TabControl1.SelectedIndex = 0
            lblFileMissing.Visible = False
            lblCreatedByEmailID.Text = ""
            lblQTitle1.Text = "Quote # - " & .Rows(DGView1.CurrentRow.Index).Cells("QNumber").Value & "   " & Mid((.Rows(DGView1.CurrentRow.Index).Cells("customer").Value), 6, 9999)
            lblQTitle2.Text = lblQTitle1.Text
            lblQTitle3.Text = lblQTitle1.Text
            qmsQUOTE_ID = .Rows(DGView1.CurrentRow.Index).Cells("quoteid").Value
            txtQuoteNo.Text = .Rows(DGView1.CurrentRow.Index).Cells("QNumber").Value
            txtQuoteDate.Text = .Rows(DGView1.CurrentRow.Index).Cells("Quote Date").Value
            txtQType.Text = .Rows(DGView1.CurrentRow.Index).Cells("type").Value
            txtQuoteStatus.Text = .Rows(DGView1.CurrentRow.Index).Cells("status").Value
            txtQuoteValidDate.Text = .Rows(DGView1.CurrentRow.Index).Cells("validity").Value
            txtQuoteDescription.Text = .Rows(DGView1.CurrentRow.Index).Cells("title").Value

            txtClientName.Text = (.Rows(DGView1.CurrentRow.Index).Cells("customer").Value)
            txtClientAddress1.Text = .Rows(DGView1.CurrentRow.Index).Cells("Address").Value
            txtDepartment1.Text = .Rows(DGView1.CurrentRow.Index).Cells("department").Value
            txtClientContactPerson1.Text = .Rows(DGView1.CurrentRow.Index).Cells("Submitted To").Value
            txtClientEmail1.Text = .Rows(DGView1.CurrentRow.Index).Cells("email").Value
            txtContact1.Text = .Rows(DGView1.CurrentRow.Index).Cells("Contact").Value
            txtQuoteFileName.Text = .Rows(DGView1.CurrentRow.Index).Cells("filename").Value


            PreparedByCellLocation = .Rows(DGView1.CurrentRow.Index).Cells("pcellid").Value
            AuthorizedByCellLocation = .Rows(DGView1.CurrentRow.Index).Cells("acellid").Value
            TemplateName = .Rows(DGView1.CurrentRow.Index).Cells("TemplateName").Value

            txtPreparedBy.Text = .Rows(DGView1.CurrentRow.Index).Cells("created by").Value
            lblCreatedByEmailID.Text = .Rows(DGView1.CurrentRow.Index).Cells("userEmailID").Value
            lblQuoteRequest.Text = "Request a copy of this Quote from [" & DGView1.Rows(DGView1.CurrentRow.Index).Cells("shortname").Value & "]"
            If DGView1.Rows(DGView1.CurrentRow.Index).Cells("shortname").Value <> LOGGED_USER_CODE Then
                btnOpenQuote.Enabled = False
                btnEmailQuote.Enabled = False
                btnMakeCopy.Enabled = False
                lblQuoteRequest.Visible = True
            Else
                btnOpenQuote.Enabled = True
                btnEmailQuote.Enabled = True
                btnMakeCopy.Enabled = True
                lblQuoteRequest.Visible = False
            End If



            '            Call showEvents()
            'If Not qmsFunctions.verifyFileLocation() Then
            '    txtQuoteFileName.Text = "File missing, renamed or moved..."
            '    txtQuoteFileName.ForeColor = Color.Maroon
            'Else
            '    'show only fullpath and filename of logged user
            '    txtQuoteFileName.Text = 0
            '    txtQuoteFileName.ForeColor = Color.Black
            'End If


        End With
    End Sub

    Private Sub initFormViewData()
        qmsQUOTE_ID = 0
        lblQTitle1.Text = ""
        lblMsg1.Visible = False
        txtQuoteNo.Clear()
        txtQuoteDate.Clear()
        txtQType.Clear()
        txtQuoteStatus.Clear()
        txtQuoteValidDate.Clear()
        txtQuoteDescription.Clear()
        txtClientName.Clear()
        txtClientAddress1.Clear()
        txtDepartment1.Clear()
        txtClientContactPerson1.Clear()
        txtClientEmail1.Clear()
        txtContact1.Clear()
        txtPreparedBy.Clear()
        txtQuoteFileName.Clear()
        PreparedByCellLocation = ""
        AuthorizedByCellLocation = ""
        TemplateName = ""
    End Sub

    Private Sub DGView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGView1.CellEnter
        Call DGView1_CellClick(sender, e)
    End Sub

    Private Sub btnOpenQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenQuote.Click
        'verify file existance
        Dim quoteFile As String
        Dim fe As Boolean = False
        Dim shellString As String = ""
        quoteFile = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & txtQuoteFileName.Text.ToString
        'quoteFile = "c:\qmsdata\adm\ss.txt"

        fe = File.Exists(quoteFile)
        lblMsg1.Visible = False

        If Not File.Exists(quoteFile) Then
            lblFileMissing.Visible = True
            txtQuoteFileName.ForeColor = Color.Maroon
        Else
            lblFileMissing.Visible = False
            txtQuoteFileName.ForeColor = Color.Black
            If String.IsNullOrEmpty(qmsEXCEL_APP) Then MsgBox("Missing Excel Application path in Settings", MsgBoxStyle.Critical, Me.Text) : Exit Sub

            Try
                'My.Computer.FileSystem.GetFiles("c:\", True, quoteFile)
                'Shell(qmsEXCEL_APP & " " & quoteFile, AppWinStyle.MaximizedFocus)
                'Shell(qmsEXCEL_APP & " ""C:\Users\admin\Google Drive\QMS\SH\1002-SH-004-1748.xls""", AppWinStyle.MaximizedFocus)
                qmsEXCEL_APP = GetAppExePath("excel.exe")
                shellString = qmsEXCEL_APP & " """ & quoteFile & """"
                ' MsgBox(shellString.ToString)
                Shell(shellString, AppWinStyle.MaximizedFocus)

                Call qmsFunctions.addEvent(qmsQUOTE_ID, 2, "Open")

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Open Excel File Error")

            End Try

        End If
    End Sub



    Private Sub btnMakeCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeCopy.Click
        lblMsg1.Visible = False
        Dim quoteFile As String

        Dim fe As Boolean = False
        quoteFile = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & txtQuoteFileName.Text.ToString
        fe = File.Exists(quoteFile)


        If Not File.Exists(quoteFile) Then
            lblFileMissing.Visible = True
            txtQuoteFileName.ForeColor = Color.Maroon


        Else
            lblFileMissing.Visible = False
            txtQuoteFileName.ForeColor = Color.Black
            If qmsQUOTE_ID > 0 Then
                If MsgBox("You are about to make a copy of this Quote [" & txtQuoteNo.Text.ToString & "], Proceed ? (Yes/No)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, btnMakeCopy.Text) = MsgBoxResult.No Then Exit Sub
                'call qmsAddForm
                Me.Cursor = Cursors.WaitCursor
                Dim qfrm As New qmsAddForm(qmsQUOTE_ID)
                With qfrm
                    .MdiParent = qmsMenu
                    .Show()
                    .BringToFront()
                End With

                Call qmsFunctions.addEvent(qmsQUOTE_ID, 6, "Make a copy")

                Me.Cursor = Cursors.Default

            End If
        End If


    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        lblMsg1.Visible = False
        Dim quoteFile As String
        Dim fe As Boolean = False
        quoteFile = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & txtQuoteFileName.Text.ToString
        '        fe = File.Exists(quoteFile)


        If Not File.Exists(quoteFile) Then
            lblFileMissing.Visible = True
            txtQuoteFileName.ForeColor = Color.Maroon

        Else

            frmWaitForm.lblTitle.Text = "Converting to PDF. please wait..!"
            frmWaitForm.Show()
            frmWaitForm.Refresh()
            Me.Cursor = Cursors.WaitCursor

            lblFileMissing.Visible = False
            txtQuoteFileName.ForeColor = Color.Black
            quoteFile = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & txtQuoteFileName.Text.ToString


            fe = qmsFunctions.exportQMSDataToPDF(quoteFile, False)
            frmWaitForm.Close()
            Me.Cursor = Cursors.Default

        End If


    End Sub

   
    Private Sub btnEmailQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailQuote.Click
        'chk for pdf if not exists then alert user to make pdf file
        lblMsg1.Visible = False
        Dim quoteFile As String
        Dim htmlCode As String
        Dim sign As String = ""


        frmWaitForm.lblTitle.Text = "Generating Email Draft. Please wait..!"
        frmWaitForm.Show()
        frmWaitForm.Refresh()
        Me.Cursor = Cursors.WaitCursor
        sign = ReadSignature(QmsWSheetLocation.qEmailSignatureFile.ToString)

        htmlCode = "<table  style=""border: 1px solid #999999; width: 90%; font-family:Segoe UI"">"
        htmlCode += "    <tr><td><img alt="""" src=""http://gesksa.com/ksaquotes/geslogowithtitle.jpg""/></td></tr>"
        htmlCode += "    <tr><td bgcolor=""#617D8B""><img alt="""" src=""http://gesksa.com/ksaquotes/gestitle0.jpg""/></td></tr>"
        htmlCode += "    <tr ><td style=""color:black;  font-size: large; vertical-align:top"">"
        htmlCode += "    <table style=""width:80%;"" cellpadding=""0"" cellspacing=""0"">"
        htmlCode += "    <tr style=""color: rgb(0, 120, 215);font-family:Segoe UI""><td><b>Quotation</b></td><td>&nbsp;</td><td align=""left"">Quote Reference # <b>" & txtQuoteNo.Text.ToString & "</b></td></tr>"
        htmlCode += "    <tr><td colspan=""3"">&nbsp;</td></tr>"
        htmlCode += "        <tr style=""color:#333333; font-size:15px;font-family:Segoe UI""><td bgcolor=""#E0E0E0""><b>" & Mid(txtClientName.Text, 6, 999) & "</b></td><td>&nbsp;</td><td>&nbsp;</td></tr>"
        htmlCode += "        <tr style=""color:#333333; font-size:15px;font-family:Segoe UI""><td bgcolor=""#E0E0E0"" >" & txtClientAddress1.Text & " </td><td>&nbsp;</td><td>&nbsp;</td></tr>"
        htmlCode += "        <tr style=""color:#333333; font-size:15px""><td bgcolor=""#E0E0E0"" >&nbsp;</td><td>&nbsp;</td><td>     </td></tr>"
        htmlCode += "        <tr style=""color:#333333; font-size:15px;font-family:Segoe UI""><td bgcolor=""#E0E0E0"" >Attn: Mr. " & txtClientContactPerson1.Text & "</td><td>&nbsp;</td><td>&nbsp;</td></tr>"
        htmlCode += "        <tr style=""color:#333333; font-size:15px;font-family:Segoe UI""><td bgcolor=""#E0E0E0"" >" & txtDepartment1.Text & "</td><td>&nbsp;</td><td>&nbsp;</td></tr></table></td></tr><tr><td></td></tr>"
        htmlCode += "    <tr><td style=""color:black;  font-size:15px;font-family:Segoe UI"">" & qmsEmailTitle1 & "</td></tr><tr><td>&nbsp;</td></tr>    "
        htmlCode += "    <tr><td style=""color:black;  font-size:15px;font-family:Segoe UI"">" & txtQuoteDescription.Text & "</td></tr><tr><td>&nbsp;</td></tr>    "
        htmlCode += "    <tr><td style=""color:black;  font-size:15px;"">&nbsp;</td></tr>"
        htmlCode += "    <tr><td style=""color:black;  font-size:15px;font-family:Segoe UI"">" & qmsEmailTitle2 & "</td></tr>"
        htmlCode += "    <tr><td>&nbsp;</td></tr>"
        htmlCode += "    <tr><td style=""color:black;  font-size:13px;font-family:Segoe UI"">Please reply to this email with our Quote Reference Number</td></tr>"
        htmlCode += "    <tr style=""font-family:Segoe UI; font-size:13px;color:White"" ><td  bgcolor=""#617D8B""><span>© Globe Express Services, LLC</span>&nbsp;&nbsp;<a href=""http://www.globeexpress.com/en/"">www.globeexpress.com</a> <br /></td></tr></table>"


        If String.IsNullOrEmpty(sign) Then
            htmlCode += "<tr><td colspan=""3"">Thanks & Regards,</td></tr>"
            htmlCode += "<tr><td colspan=""3"">" & LOGGED_USER_NAME.ToString & ",</td></tr>"
            htmlCode += "<tr><td colspan=""3"">&nbsp;</td></tr>"
            htmlCode += "</table></td></tr></table>"
        Else
            htmlCode += sign
        End If

        quoteFile = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & txtQuoteFileName.Text.ToString
        quoteFile = Replace(quoteFile, ".xls", ".pdf")
        If File.Exists(quoteFile) Then

            Call StartOutlook(txtClientEmail1.Text, (qmsEMAIL_CC1 & ";" & qmsEMAIL_CC2), _
                              qmsEMAIL_CC2, _
                              (qmsEmailSubject.ToString & txtQuoteNo.Text.ToString), _
                              htmlCode.ToString, _
                              quoteFile)

        Else
            lblMsg1.Text = "First Convert this Quote to PDF and try again..."
            lblMsg1.Visible = True
        End If

        frmWaitForm.Close()
        Me.Cursor = Cursors.Default


    End Sub


    Public Shared Function GetActiveOutlookApplication() As Microsoft.Office.Interop.Outlook.Application
        Return DirectCast(System.Runtime.InteropServices.Marshal.GetActiveObject("Outlook.Application"), Microsoft.Office.Interop.Outlook.Application)
    End Function

#Region "Email Discarded code"

    ' If File.Exists(quoteFile) Then


    ''Dim mail As Outlook.MailItem = Nothing
    'Try

    '    Dim app As New Outlook.Application
    '    Dim tsk As Outlook.TaskItem
    '    tsk = app.Application.CreateItem(Outlook.OlItemType.olMailItem)
    '    tsk.Save()
    '    tsk.Display(False)
    '    Exit Sub

    ''Outlook.Application app = new Outlook.Application();

    'Catch ex As Exception
    '    System.Windows.Forms.MessageBox.Show(ex.Message)
    'Finally
    '    'If Not IsNothing(mail) Then Marshal.ReleaseComObject(mail)
    'End Try

    'Try

    '    'Dim app As Outlook.Application = GetActiveOutlookApplication()
    '    'Dim tsk As Outlook.TaskItem = DirectCast(app.CreateItem(Outlook.OlItemType.olTaskItem), Outlook.TaskItem)
    '    'tsk.Save()
    '    'tsk.Display(False)
    '    'Exit Sub

    '    Dim Outl As Object
    '    'Outlook.Application app = GetActiveOutlookApplication();

    '    Outl = GetActiveOutlookApplication()

    '    Outl = CreateObject("Outlook.Application")
    '    Outl = New Outlook.Application
    '    Outl = GetObject("Outlook.Application")


    '    If Outl IsNot Nothing Then
    '        Dim omsg As Object
    '        omsg = Outl.CreateItem(0)
    '        omsg.To = txtClientEmail1.Text
    '        'omsg.from = qmsUserRow.email
    '        omsg.cc = qmsEMAIL_CC1 & ";" & qmsEMAIL_CC2
    '        omsg.bcc = qmsEMAIL_CC2
    '        omsg.subject = qmsEmailSubject.ToString & txtQuoteNo.Text.ToString
    '        omsg.HtmlBody = htmlCode.ToString
    '        omsg.Attachments.Add(quoteFile)
    '        'set message properties here...'
    '        frmWaitForm.Close()
    '        Me.Cursor = Cursors.Default
    '        omsg.Display(False) 'will display message to user
    '    End If
    'Catch ex As Exception
    '    lblMsg1.Text = ex.ToString
    '    lblMsg1.Visible = True
    'End Try

    '    Imports System.Net.Mail

    'Public Function SendEmail(ByVal EmailBody As String, ByVal EmailSubject As String, ByVal EmailTo As String, ByVal AttachmentPath As String, ByVal EmailAsHTML As Boolean)

    '    Dim Mail As New MailMessage

    '    Try
    '        Dim SMTP As New SmtpClient("smtp.gmail.com")
    '        SMTP.EnableSsl = True
    '        SMTP.Credentials = New System.Net.NetworkCredential("[your gmail address@gmail.com]", "[the associated password]")
    '        SMTP.Port = 587

    '        Mail.From = New MailAddress("""[Friendly Name]"" <[your gmail address@gmail.com>")

    '        'Split Multiple Addresses
    '        If EmailTo.Contains(";") Then
    '            For Each EmailAddress In EmailTo.Split(";")
    '                Mail.To.Add(Trim(EmailAddress))
    '            Next
    '        Else
    '            Mail.To.Add(Trim(EmailTo))
    '        End If

    '        Mail.Subject = EmailSubject
    '        Mail.Body = EmailBody
    '        If AttachmentPath <> "" Then Mail.Attachments.Add(New Mail.Attachment(AttachmentPath))
    '        Mail.IsBodyHtml = EmailAsHTML

    '        SMTP.Send(Mail)

    '        'Clear Mail Object
    '        Mail.Dispose()

    '        'Function Return
    '        Return True

    '    Catch ex As Exception

    '        'Function Return
    '        Return False

    '    End Try
    'End Function


#End Region

    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        lblDirectory.Text = ""
        lblDirectory.Visible = True
        If TabControl1.SelectedIndex = 2 Then
            Try
                If Not String.IsNullOrEmpty(txtQuoteFileName.Text.ToString) Then
                    Dim folderName As String
                    'folderName = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & txtQuoteFileName.Text.ToString
                    'folderName = "D:\qmsdata\ADM\1023-Najah Jamil Addas & partner Trd.co"

                    folderName = qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\" & Microsoft.VisualBasic.Left(txtQuoteFileName.Text, (txtQuoteFileName.Text.IndexOf("\")))
                    'folderName += "\" & txtQuoteNo.Text.ToString & "*.*"
                    With ListView1
                        .View = View.Details
                        .Items.Clear()
                        .Columns.Clear()
                        .GridLines = True
                        .Sorting = Windows.Forms.SortOrder.Descending
                        .FullRowSelect = True
                        .Columns.Add("Filename", 350, HorizontalAlignment.Left) 'CREATE COLOUMS AT RUN TIME
                        .Columns.Add("Create Time", 180, HorizontalAlignment.Left)
                        ' .Columns.Add("Location", 100, HorizontalAlignment.Left)

                    End With

                    Dim dFolder As DirectoryInfo = New DirectoryInfo(folderName)
                    Dim fFileArray() As FileInfo = dFolder.GetFiles(txtQuoteNo.Text.ToString & "*.*")
                    lblDirectory.Text = dFolder.FullName

                    Dim fFile As FileInfo
                    Dim lCurrent As ListViewItem
                    For Each fFile In fFileArray
                        ImageList1.Images.Add(Icon.ExtractAssociatedIcon(fFile.FullName.ToString))
                        lCurrent = ListView1.Items.Add(fFile.Name, ImageList1.Images.Count - 1)
                        '                        lCurrent = ListView1.Items.Add(fFile.DirectoryName, ImageList1.Images.Count - 1)
                        'lCurrent.SubItems.Add(fFile.Extension)
                        'lCurrent.SubItems.Add(fFile.Length \ 1024 + 1) 'CONVERT BYTES TO KB
                        lCurrent.SubItems.Add(fFile.CreationTime)
                    Next

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Check the folder exists...")

            End Try
        End If

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            If Microsoft.VisualBasic.Right(ListView1.SelectedItems(0).Text.ToString, 3) = "xls" Then MsgBox("Open this file From main tab", MsgBoxStyle.Information, "Access denied") : Exit Sub
            Process.Start((lblDirectory.Text & "\" & ListView1.SelectedItems(0).Text.ToString()))
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error opening file")
        End Try
    End Sub


    Private Sub lblQuoteRequest_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblQuoteRequest.LinkClicked
        If String.IsNullOrEmpty(lblCreatedByEmailID.Text) Then MsgBox("User/Receipent eMail ID not found", MsgBoxStyle.Exclamation, "Cannot send email") : Exit Sub
        Dim htmlCode As String
        Dim sign As String
        Try

            frmWaitForm.lblTitle.Text = "Generating Email Draft. Please wait..!"
            frmWaitForm.Show()
            frmWaitForm.Refresh()
            Me.Cursor = Cursors.WaitCursor
            sign = ReadSignature(QmsWSheetLocation.qEmailSignatureFile.ToString)

            htmlCode = "<table  style=""border: 1px solid #999999; width: 90%; font-family:Segoe UI"">"
            htmlCode += "<tr ><td style=""color:black;font-size: large; font-family:Segoe UI;vertical-align:top"">"
            htmlCode += "<table style=""width:50%;"" cellpadding=""0"" cellspacing=""0"">"
            htmlCode += " <tr style=""color: rgb(0, 120, 215)""><td><b>Quote Request</b></td><td>&nbsp;</td><td align=""left"">Quote Reference # <b>" & txtQuoteNo.Text.ToString & "</b></td></tr>"
            htmlCode += " <tr><td colspan=""3"">Dear <b>" & txtPreparedBy.Text & "</b>, </td></tr><tr><td>&nbsp</td></tr>"
            htmlCode += " <tr><td colspan=""3"">Kindly send me the latest copy of this Quote to review.</td></tr>"
            htmlCode += "<tr><td colspan=""3"">&nbsp</td></tr>"

            If String.IsNullOrEmpty(sign) Then
                htmlCode += "<tr><td colspan=""3"">Thanks & Regards,</td></tr>"
                htmlCode += "<tr><td colspan=""3"">" & LOGGED_USER_NAME.ToString & ",</td></tr>"
                htmlCode += "<tr><td colspan=""3"">&nbsp;</td></tr>"
                htmlCode += "</table></td></tr></table>"
            Else
                htmlCode += sign
            End If


            ' MsgBox(htmlCode)
            Call StartOutlook(lblCreatedByEmailID.Text, "", "", ("Quote Request - " & txtQuoteNo.Text.ToString), htmlCode.ToString, "")

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Email Load Error")
        Finally
            frmWaitForm.Close()
            Me.Cursor = Cursors.Default
        End Try


    End Sub


    Private Sub btnViewPDFQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewPDFQuote.Click
        'open file from Google-Drive 
        Dim viewPDFFile As String = ""
        Try
            viewPDFFile = qmsGoogleDrivePath & "" & Microsoft.VisualBasic.Mid(txtQuoteFileName.Text, txtQuoteFileName.Text.IndexOf("\") + 1, 9999)
            viewPDFFile = Replace(viewPDFFile, ".xls", ".pdf")
            ' MsgBox(viewPDFFile)
            Process.Start(viewPDFFile)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error opening file")
        End Try
    End Sub
End Class