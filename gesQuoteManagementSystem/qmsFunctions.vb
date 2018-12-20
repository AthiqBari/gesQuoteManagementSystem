Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports FileOperation = System.IO
Imports Microsoft.Office.Interop
Imports System.IO
'Imports Microsoft.Office.Core
Imports System.Text.RegularExpressions

Module qmsFunctions

    Public qmsLOCAL_FOLDER As String ' = "C:\Users\admin\Google Drive\"
    Public qmsEXCEL_APP As String
    Public qmsGoogleDrivePath As String

    Public qmsREMOTE_SERVER As String = ""
    Public qmsREMOTE_USER As String
    Public qmsREMOTE_PWD As String
    Public qmsREMOTE_DB As String

    Public qmsFTP_URL As String
    Public qmsFTP_USR As String
    Public qmsFTP_PWD As String
    Public qmsDEFAULT_USER As String

    Public qmsEmailTitle1 As String
    Public qmsEmailTitle2 As String
    Public qmsEmailTitle3 As String
    Public qmsEmailTitle4 As String
    Public qmsEmailSubject As String


    Private sql_cnnSTR As String
    Public sql_CNN As New SqlConnection
    Public sql_String As String

    Public qmsEMAIL_CC1 As String
    Public qmsEMAIL_CC2 As String

    Public LOGGED_USER_ID As Integer
    Public LOGGED_USER_CODE As String 'SH
    Public LOGGED_USER_NAME As String

    Public lovSelectedID As Integer
    Public qmsQUOTE_ID As Integer

    Public QUOTE_AUTHORIZED_BY_NAME As String
    Public QuoteAuthorizedBYPosition As String


#Region "Structures"
    Public Structure ClientDetails
        Dim ID As Integer
        Dim Code As Integer
        Dim FullName As String
        Dim Address1 As String
        Dim Address2 As String
        Dim ContactPerson1 As String
        Dim ContactPerson2 As String
        Dim ContactPerson3 As String
        Dim Email1 As String
        Dim Email2 As String
        Dim Email3 As String
        Dim Department1 As String
        Dim Department2 As String
        Dim Department3 As String
        Dim Contact1 As String
        Dim Contact2 As String
        Dim Contact3 As String
        Dim CreatedBy As String
        Dim CreatedOn As String
        Dim EditedBy As String
        Dim EditedOn As String
        Dim IsActive As Boolean
    End Structure
    Public Structure qmsUser
        Dim ID As Integer
        Dim shortname As String
        Dim password As String
        Dim name As String
        Dim position As String
        Dim email As String
        Dim contactnumber1 As String
        Dim admin As Boolean
        Dim authorized_name As String
        Dim authorized_position As String
    End Structure
    Public Structure qmsData
        Dim ID As Integer
        Dim SerialNumber As Integer
        Dim ReferenceCode As String
        Dim ShipmentID As String
        Dim TemplateID As String
        Dim Currency As String
        Dim Title As String
        Dim QuoteDate As String
        Dim Validity As String
        Dim Attention As Integer
        Dim ShipmentType As String
        Dim TemplateName As String
    End Structure
    Public Structure qmsBranch
        Dim ID As Integer
        Dim Code As String
        Dim Name As String
        Dim Address1 As String
        Dim Address2 As String
        Dim ContactNumber1 As String
        Dim ContactNumber2 As String
        Dim CompanyName As String
    End Structure

    Public Structure WorkSheetDataCellLocation
        Dim qNo As String
        Dim qDate As String
        Dim qValidity As String
        Dim qFcy As String
        Dim qShpType As String
        Dim qTemplate As String
        Dim qClientName As String
        Dim qClientAddr As String
        Dim qClientEmail As String
        Dim qClientAttn As String
        Dim qClientDept As String
        Dim qUserName As String
        Dim qUserTitle As String
        Dim qBranchAddr As String
        Dim qTitle As String
        Dim qNote As String
        Dim qAuthorized_cellid As String
        Dim qAuthorized_title_cellid As String

        Dim qAuthorizedBy_Name As String
        Dim qAuthorizedBy_Title As String

        Dim qclientapproval_name_cell As String
        Dim qclientapproval_title_cell As String
        Dim qEmailSignatureFile As String
    End Structure

    Public Structure ActiveClientContact
        Dim Address1 As String
        Dim Address2 As String
        Dim ContactPerson As String
        Dim Department As String
        Dim Email As String
    End Structure
#End Region

    Public ClientData As New ClientDetails()
    Public QmsDataRow As New qmsData()
    Public QmsUserRow As New qmsUser()
    Public QmsBranchInfo As New qmsBranch
    Public QmsWSheetLocation As New WorkSheetDataCellLocation()
    Public QmsClientAddress As New ActiveClientContact()

#Region "initStructure"
    Public Sub initqmsClientAddress()
        With QmsClientAddress
            .Address1 = ""
            .Address2 = ""
            .ContactPerson = ""
            .Department = ""
            .Email = ""
        End With
    End Sub
    Public Sub initqmsUser()
        With QmsUserRow
            .ID = 0
            .password = ""
            .contactnumber1 = ""
            .email = ""
            .name = ""
            .position = ""
            .shortname = ""
            .admin = False
            .authorized_name = ""
            .authorized_position = ""
        End With
    End Sub
    Public Sub initqmsData()
        With QmsDataRow
            .ID = 0
            .SerialNumber = 0
            .ReferenceCode = ""
            .ShipmentID = 0
            .TemplateID = 0
            .Currency = ""
            .Title = ""
            .QuoteDate = ""
            .Validity = ""
            .Attention = 1
            .ShipmentType = ""
            .TemplateName = ""
        End With
    End Sub
    Public Sub initClientData()
        With ClientData
            .ID = 0
            .Code = 0
            .FullName = ""
            .Address1 = ""
            .Address2 = ""
            .ContactPerson1 = ""
            .ContactPerson2 = ""
            .ContactPerson3 = ""
            .Email1 = ""
            .Email2 = ""
            .Email3 = ""
            .Department1 = ""
            .Department2 = ""
            .Department3 = ""
            .Contact1 = ""
            .Contact2 = ""
            .Contact3 = ""
            .CreatedBy = "" : .CreatedOn = ""
            .EditedBy = "" : .EditedOn = ""
            .IsActive = False
        End With
    End Sub
    Public Sub initBranchInfo()
        With QmsBranchInfo
            .ID = 0
            .Code = 0
            .Name = ""
            .Address1 = ""
            .Address2 = ""
            .ContactNumber1 = ""
            .ContactNumber2 = ""
            .CompanyName = ""

        End With
    End Sub
    Public Sub initWorkSheetDataCellLocation()
        With QmsWSheetLocation
            .qNo = ""
            .qDate = ""
            .qValidity = ""
            .qFcy = ""
            .qShpType = ""
            .qTemplate = ""
            .qClientName = ""
            .qClientAddr = ""
            .qClientAttn = ""
            .qClientDept = ""
            .qClientEmail = ""
            .qUserName = ""
            .qUserTitle = ""
            .qBranchAddr = ""
            .qTitle = ""
            .qNote = ""
            .qAuthorized_cellid = ""
            .qAuthorized_title_cellid = ""
            .qAuthorizedBy_Name = ""
            .qAuthorizedBy_Title = ""
            .qclientapproval_name_cell = ""
            .qclientapproval_title_cell = ""
            .qEmailSignatureFile = ""
        End With
    End Sub
#End Region



    Public Sub GetSettings()
        Dim viewDs As New DataSet
        Try
            viewDs.ReadXml(Application.StartupPath + "\settings.xml")
            qmsLOCAL_FOLDER = viewDs.Tables(0).Rows(0).Item("local_qmsfolder")
            qmsREMOTE_SERVER = viewDs.Tables(0).Rows(0).Item("remoteserver")
            qmsREMOTE_USER = viewDs.Tables(0).Rows(0).Item("remoteuser")
            qmsREMOTE_PWD = viewDs.Tables(0).Rows(0).Item("remotepassword")
            qmsREMOTE_DB = viewDs.Tables(0).Rows(0).Item("remotedatabase")
            qmsEXCEL_APP = viewDs.Tables(0).Rows(0).Item("excel_app")

            qmsEMAIL_CC1 = viewDs.Tables(0).Rows(0).Item("email_cc1")
            qmsEMAIL_CC2 = viewDs.Tables(0).Rows(0).Item("email_cc2")

            qmsFTP_URL = viewDs.Tables(0).Rows(0).Item("ftp_url")
            qmsFTP_USR = viewDs.Tables(0).Rows(0).Item("ftp_usr")
            qmsFTP_PWD = viewDs.Tables(0).Rows(0).Item("ftp_pwd")
            qmsDEFAULT_USER = viewDs.Tables(0).Rows(0).Item("qmsuser")

            qmsEmailSubject = viewDs.Tables(0).Rows(0).Item("emailSubject")
            qmsEmailTitle1 = viewDs.Tables(0).Rows(0).Item("emailTitle1")
            qmsEmailTitle2 = viewDs.Tables(0).Rows(0).Item("emailTitle2")
            qmsEmailTitle3 = viewDs.Tables(0).Rows(0).Item("emailTitle3")
            qmsEmailTitle4 = viewDs.Tables(0).Rows(0).Item("emailTitle4")

            qmsGoogleDrivePath = viewDs.Tables(0).Rows(0).Item("gdrivepath")


            sql_cnnSTR = "server= " & qmsREMOTE_SERVER & ";database= " & qmsREMOTE_DB & ";user id=" & qmsREMOTE_USER & ";password=" & qmsREMOTE_PWD & ";"

            With QmsWSheetLocation
                .qNo = viewDs.Tables(0).Rows(0).Item("qno")
                .qDate = viewDs.Tables(0).Rows(0).Item("qdate")
                .qValidity = viewDs.Tables(0).Rows(0).Item("qvalidity")
                .qShpType = viewDs.Tables(0).Rows(0).Item("qshptype")
                .qTemplate = viewDs.Tables(0).Rows(0).Item("qtemplate")
                .qFcy = viewDs.Tables(0).Rows(0).Item("qfcy")
                .qClientName = viewDs.Tables(0).Rows(0).Item("qclientname")
                .qClientAddr = viewDs.Tables(0).Rows(0).Item("qclientaddr")
                .qClientAttn = viewDs.Tables(0).Rows(0).Item("qclientattn")
                .qClientDept = viewDs.Tables(0).Rows(0).Item("qclientdept")
                .qClientEmail = viewDs.Tables(0).Rows(0).Item("qclientemail")
                .qUserName = viewDs.Tables(0).Rows(0).Item("qusername")
                .qUserTitle = viewDs.Tables(0).Rows(0).Item("qusertitle")
                .qBranchAddr = viewDs.Tables(0).Rows(0).Item("qbranchaddr")
                .qTitle = viewDs.Tables(0).Rows(0).Item("qtitle")
                .qNote = viewDs.Tables(0).Rows(0).Item("qnote")
                .qBranchAddr = viewDs.Tables(0).Rows(0).Item("qBranchAddr")
                .qAuthorized_cellid = viewDs.Tables(0).Rows(0).Item("qauthorizedby_cell")
                .qAuthorized_title_cellid = viewDs.Tables(0).Rows(0).Item("qauthorizedsign_cell")
                .qAuthorizedBy_Name = viewDs.Tables(0).Rows(0).Item("authorizedby_name")
                .qAuthorizedBy_Title = viewDs.Tables(0).Rows(0).Item("authorizedby_title")
                .qclientapproval_name_cell = viewDs.Tables(0).Rows(0).Item("clientapproval_name_cell")
                .qclientapproval_title_cell = viewDs.Tables(0).Rows(0).Item("clientapproval_title_cell")
                .qEmailSignatureFile = viewDs.Tables(0).Rows(0).Item("emailSignFile")

            End With


        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "getSetting(...")
        Finally
            viewDs = Nothing
        End Try
    End Sub

    Public Sub createConnection()
        Try
            If qmsREMOTE_SERVER = "" Then GetSettings()
            sql_CNN = New SqlConnection(sql_cnnSTR)
            sql_CNN.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "DB Connection Error")
        End Try
    End Sub

    Public Function loadClientNamesInList() As AutoCompleteStringCollection
        Dim frmCMD As SqlCommand
        Dim frmDR As SqlDataReader
        Dim strCollection As New AutoCompleteStringCollection()
        Try

            '            qmsFunctions.getSettings()
            '           qmsFunctions.createConnection()
            If sql_CNN.State = ConnectionState.Closed Then createConnection()

            If qmsFunctions.sql_CNN.State = ConnectionState.Open Then
                frmCMD = New SqlCommand("select fullname from clients order by fullname", sql_CNN)
                frmDR = frmCMD.ExecuteReader()
                Do While frmDR.Read
                    strCollection.AddRange(New String() {frmDR.GetValue(0).ToString()}) ' + " - (" + frmDR.GetValue(1).ToString + ")"})  ' txteIDFind.AutoCompleteCustomSource.Add(frmDR.GetInt32(0).ToString)
                Loop
                frmDR.Close()
                Return strCollection
            Else
                frmDR.Close()
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "loadClientNamesInList(...")
            Return Nothing
        Finally

        End Try

    End Function

    'cmbCities2.Tag = -1
    'wbClass.fillComboBox(cmbCities, "cityrecid", "cityname", "gescities", "cityname", "where countrycode in ('SA','TR','AE','SY','EG','YE','KW','JO')", "cityname")
    Public Sub fillComboBox(ByVal objName As ComboBox, ByVal ValueMember As String, ByVal DisplayMember As String, _
                            ByVal TableName As String, ByVal sortField As String, ByVal whereClause As String, _
                            ByVal castDisplayMember As String)
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        objName.DataSource = Nothing
        objName.Items.Clear()
        objName.Items.Remove(objName.DisplayMember)

        If String.IsNullOrEmpty(castDisplayMember) Then castDisplayMember = DisplayMember

        '        qmsFunctions.getSettings()
        '       qmsFunctions.createConnection()
        If sql_CNN.State = ConnectionState.Closed Then createConnection()


        Try
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn
                sql = "select " & ValueMember & "," & DisplayMember
                sql += " from " & TableName & "  "
                If Not String.IsNullOrEmpty(whereClause) Then sql += whereClause
                sql += "  order by " & sortField
                command = New SqlCommand(sql, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds)
                adapter.Dispose()
                command.Dispose()
            End If
            '            closeConnection()

            objName.DataSource = ds.Tables(0)
            objName.ValueMember = ValueMember
            objName.DisplayMember = castDisplayMember
        Catch ex As Exception
            closeConnection()
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "fillcombox")
            '            MessageBox.Show("Open connection error! ")
        Finally

        End Try

    End Sub

    Public Sub closeConnection()
        Try
            If sql_CNN.State = ConnectionState.Open Then
                sql_CNN.Close()
            End If
        Catch ex As Exception
            Throw New Exception("closeConnection()", ex)

        End Try
    End Sub

    Public Function getClientInfo(ByVal code As Integer, ByVal fullname As String) As Boolean
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        'getSettings()
        'createConnection()
        If sql_CNN.State = ConnectionState.Closed Then createConnection()

        Try
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn

                sql_String = "select * from clients where isactive<>-1"
                If code > 0 Then sql_String += " and code = " & code
                If Not String.IsNullOrEmpty(fullname.ToString) Then sql_String += " and fullname like '%" & fullname & "%';"

                command = New SqlCommand(sql_String, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds, "cdata")
                If ds.Tables("cdata").Rows.Count > 0 Then Call setClientInfo(ds)
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "getClientInfo(...")
            Return False
        End Try
        'closeConnection()
    End Function

    Private Sub setClientInfo(ByVal ds As DataSet)
        initClientData()
        If ds.Tables("cdata").Rows.Count > 0 Then
            With ClientData
                .ID = ds.Tables("cdata").Rows(0).Item("id").ToString
                .Code = ds.Tables("cdata").Rows(0).Item("code").ToString
                .FullName = ds.Tables("cdata").Rows(0).Item("fullname").ToString
                .Address1 = ds.Tables("cdata").Rows(0).Item("address1").ToString
                .Address2 = ds.Tables("cdata").Rows(0).Item("address2").ToString
                .ContactPerson1 = ds.Tables("cdata").Rows(0).Item("contactperson1").ToString
                .ContactPerson2 = ds.Tables("cdata").Rows(0).Item("contactperson2").ToString
                .ContactPerson3 = ds.Tables("cdata").Rows(0).Item("contactperson3").ToString
                .Email1 = ds.Tables("cdata").Rows(0).Item("Email1").ToString
                .Email2 = ds.Tables("cdata").Rows(0).Item("Email2").ToString
                .Email3 = ds.Tables("cdata").Rows(0).Item("Email3").ToString
                .Contact1 = ds.Tables("cdata").Rows(0).Item("Contact1").ToString
                .Contact2 = ds.Tables("cdata").Rows(0).Item("Contact2").ToString
                .Contact3 = ds.Tables("cdata").Rows(0).Item("Contact3").ToString
                .Department1 = ds.Tables("cdata").Rows(0).Item("department1").ToString
                .Department2 = ds.Tables("cdata").Rows(0).Item("department2").ToString
                .Department3 = ds.Tables("cdata").Rows(0).Item("department3").ToString
                .CreatedBy = ds.Tables("cdata").Rows(0).Item("createdby").ToString
                .CreatedOn = ds.Tables("cdata").Rows(0).Item("CreatedOn").ToString
                .EditedBy = ds.Tables("cdata").Rows(0).Item("EditedBy").ToString
                .EditedOn = ds.Tables("cdata").Rows(0).Item("EditedOn").ToString
                .IsActive = IIf(ds.Tables("cdata").Rows(0).Item("isActive") = 0, True, False)
            End With
        End If
    End Sub

    Public Function getUserInfo(ByVal shortName As String) As Boolean
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter

        Try
            If sql_CNN.State = ConnectionState.Closed Then createConnection()

            If sql_CNN.State = ConnectionState.Open Then 'valid cnn
                sql_String = "select t1.*,t2.*,t2.contactnumber1 [c1], t2.contactnumber2 [c2],t3.name [coName] from users t1 inner join branch t2 on t1.branchid=t2.id inner join company t3 on t2.companyid=t3.id  where shortname='" & shortName & "';"
                command = New SqlCommand(sql_String, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds, "cdata")
                If ds.Tables("cdata").Rows.Count > 0 Then
                    Call setUserInfo(ds)
                    Call setBranchInfo(ds)
                    Return True
                Else
                    initqmsUser()
                    initBranchInfo()
                    Return False
                End If
            Else
                MsgBox("Unable to contact remote server, please check internet connectivity, Try again", MsgBoxStyle.Critical, "Connection Error")
                End
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "getUserInfo(...")
            Return False
        Finally
            adapter = Nothing
            ds.Dispose()
            ds = Nothing
        End Try
        '        closeConnection()
    End Function
    Private Sub setUserInfo(ByVal ds As DataSet)
        initqmsUser()
        If ds.Tables("cdata").Rows.Count > 0 Then
            With QmsUserRow
                .ID = ds.Tables("cdata").Rows(0).Item("id").ToString
                .password = ds.Tables("cdata").Rows(0).Item("password").ToString
                .shortname = ds.Tables("cdata").Rows(0).Item("shortname").ToString
                .name = ds.Tables("cdata").Rows(0).Item("fullname").ToString
                .position = ds.Tables("cdata").Rows(0).Item("position").ToString
                .email = ds.Tables("cdata").Rows(0).Item("emailaddress").ToString
                .contactnumber1 = ds.Tables("cdata").Rows(0).Item("contactnumber1").ToString
                .admin = IIf(ds.Tables("cdata").Rows(0).Item("admin") = 1, True, False)
            End With
        End If
        ds = Nothing
    End Sub
    Private Sub setBranchInfo(ByVal ds As DataSet)
        initBranchInfo()
        If ds.Tables("cdata").Rows.Count > 0 Then
            With QmsBranchInfo
                .ID = ds.Tables("cdata").Rows(0).Item("id").ToString
                .Code = ds.Tables("cdata").Rows(0).Item("code").ToString
                .Name = ds.Tables("cdata").Rows(0).Item("name").ToString
                .Address1 = ds.Tables("cdata").Rows(0).Item("Address1").ToString
                .Address2 = ds.Tables("cdata").Rows(0).Item("Address2").ToString
                .ContactNumber1 = ds.Tables("cdata").Rows(0).Item("c1").ToString
                .ContactNumber2 = ds.Tables("cdata").Rows(0).Item("c2").ToString
                .CompanyName = ds.Tables("cdata").Rows(0).Item("coname").ToString
            End With
        End If
        ds = Nothing
    End Sub

    Public Function setPlainText_Name(ByVal strValue As String) As String
        Dim strval As String
        strval = strValue
        strval = Replace(strval, ",", " ")
        strval = Replace(strval, ";", " ")
        strval = Replace(strval, "<", " ")
        strval = Replace(strval, ">", " ")
        strval = Replace(strval, "[", " ")
        strval = Replace(strval, "]", " ")
        strval = Replace(strval, "(", " ")
        strval = Replace(strval, ")", " ")
        strval = Replace(strval, "!", " ")
        strval = Replace(strval, "~", " ")
        strval = Replace(strval, "#", " ")
        strval = Replace(strval, "@", " ")
        strval = Replace(strval, "%", " ")
        strval = Replace(strval, "^", " ")
        strval = Replace(strval, "*", " ")
        strval = Replace(strval, "+", " ")
        strval = Replace(strval, "`", " ")
        strval = Replace(strval, "$", " ")
        strval = Replace(strval, ":", " ")
        strval = Replace(strval, "'", " ")
        strval = Replace(strval, "/", " ")
        strval = Replace(strval, "\", " ")
        strval = Replace(strval, "|", " ")
        Return Trim(strval)
    End Function


    Public Function getClientMaxCode() As Integer
        Dim rtnVal As Integer
        Dim tmpSQL As SqlDataReader
        Dim tmpDS As New DataSet
        Dim tmpCMD As New SqlCommand
        Dim tmpDA As New SqlDataAdapter
        rtnVal = 0
        Try

            If sql_CNN.State = ConnectionState.Closed Then createConnection()

            If sql_CNN.State = ConnectionState.Open Then 'valid cnn
                With tmpCMD
                    .Connection = sql_CNN
                    .CommandType = CommandType.Text
                    .CommandTimeout = (24 * 3600)
                    .CommandText = "select isnull(max(code),0)+1 as ccode  from [clients]"
                End With
                tmpSQL = tmpCMD.ExecuteReader()
                If tmpSQL.HasRows Then
                    While (tmpSQL.Read())
                        rtnVal = tmpSQL("ccode").ToString()
                    End While
                End If
                tmpSQL.Close()


            End If
        Catch ex As Exception
            rtnVal = -1
            tmpSQL = Nothing
            tmpDA = Nothing
            tmpDS.Dispose()
            tmpCMD = Nothing
        Finally
            tmpSQL = Nothing
            tmpDA = Nothing
            tmpDS.Dispose()
            tmpCMD = Nothing
        End Try
        Return rtnVal

        '        closeConnection()
    End Function

    Public Function getClientList(ByVal fullName As String) As DataSet
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        If sql_CNN.State = ConnectionState.Closed Then createConnection()
        Try
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn
                sql_String = "select Code, FullName, ContactPerson1, Department1, Contact1, Email1, ContactPerson2, Department2, Contact2,Email2,Address1,Address2,  id from Clients where isactive<>-1"
                If Not String.IsNullOrEmpty(fullName.ToString) Then sql_String += " and fullname like '%" & fullName & "%';"
                command = New SqlCommand(sql_String, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds, "cdata")
            End If
            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
        '  closeConnection()
    End Function
    Public Function getQuoteList(ByVal clientID As Integer) As DataSet
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        If sql_CNN.State = ConnectionState.Closed Then createConnection()
        Try
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn

                sql_String = "select * from [viewquotes] "
                If clientID > 0 Then sql_String += " where clientid=" & clientID
                sql_String += " order by quoteid desc"
                command = New SqlCommand(sql_String, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds, "cdata")
            End If
            adapter.Dispose()
            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
        '  closeConnection()
    End Function

    Public Function getEventList(ByVal quoteID As Integer) As DataSet
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        If sql_CNN.State = ConnectionState.Closed Then createConnection()
        Try
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn

                sql_String = "select note [Event], createdon [Created], usercode [User] from [events] "
                sql_String += " where quoteID=" & quoteID
                sql_String += " order by createdon desc"
                command = New SqlCommand(sql_String, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds, "qdata")
            End If
            adapter.Dispose()
            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
        '  closeConnection()
    End Function

    Public Function getQuoteDataByID(ByVal quoteID As Integer) As DataSet
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        If sql_CNN.State = ConnectionState.Closed Then createConnection()
        Try
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn

                sql_String = "select * from [viewquotes] where quoteid=" & quoteID
                command = New SqlCommand(sql_String, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds, "cdata")
            End If
            adapter.Dispose()
            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
        '  closeConnection()
    End Function

    Public Function quoteExplorer(ByVal fldName As String, ByVal fldValue As String, ByVal listOpt As Integer, ByVal listByLoggedUser As String) As DataSet
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        If sql_CNN.State = ConnectionState.Closed Then createConnection()
        Try
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn
                '0.Recent(Quotes) 1. This(Month) 2. Last(Month) 3.All(Quotes)

                sql_String = "select * from [viewquotes] where " & fldName & " like '%" & fldValue & "%' "
                '                sql_String += " order by quoteid desc"
                If Not String.IsNullOrEmpty(listByLoggedUser) Then sql_String += " and shortname='" & listByLoggedUser.ToString & "' "
                '                If listOpt = 0 Then sql_String += " and "


                command = New SqlCommand(sql_String, sql_CNN)
                command.CommandTimeout = (24 * 3600)
                adapter.SelectCommand = command
                adapter.Fill(ds, "cdata")
            End If
            adapter.Dispose()
            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
        '  closeConnection()
    End Function
    Public Function Integer_To_Date(ByVal IntDate As String) As String
        Dim StrDate As String
        StrDate = Mid(IntDate, 7, 2) & "/" & Mid(IntDate, 5, 2) & "/" & Mid(IntDate, 1, 4)
        Return StrDate
    End Function
    Public Function Date_To_Integer(ByVal IntDate As String) As String
        Dim StrYear As String
        Dim StrMonth As String
        Dim StrDay As String
        Dim StrDate As String
        If Len(IntDate) <> 10 Then MsgBox("Date Format should be dd/mm/yyyy ...") : Return False
        StrYear = Mid(IntDate, 7, 4)
        If Val(StrYear) < 1300 Then MsgBox("Year is in wrong format ...") : Return False
        StrMonth = Mid(IntDate, 4, 2)
        If Val(StrMonth) = 0 Or Val(StrMonth) > 12 Then MsgBox("Month in wrong format ") : Return False
        StrDay = Mid(IntDate, 1, 2)
        If Val(StrDay) > 31 Or Val(StrDay) = 0 Then MsgBox("Day in wrong format ...") : Return False
        StrDate = StrYear & StrMonth & StrDay
        Return StrDate
    End Function

    Public Sub ReadOnlyControls(ByRef frm As Form, ByVal stat As Boolean)
        Dim obj As Control
        Dim obj1 As Control
        Dim TxtBox As New TextBox
        Dim CmbBox As New ComboBox
        Dim ChkBox As New ComboBox
        Dim DGV As New DataGridView
        Dim i As Integer
        Dim a As Integer
        On Error GoTo a

        For i = 0 To frm.Controls.Count - 1
            obj = frm.Controls(i)
            If TypeOf frm.Controls(i) Is TextBox Then
                TxtBox = obj : TxtBox.ReadOnly = stat
                TxtBox.BackColor = IIf(stat, Drawing.Color.WhiteSmoke, Drawing.Color.White)
            ElseIf TypeOf frm.Controls(i) Is ComboBox Then
                CmbBox = obj : CmbBox.Enabled = stat
                CmbBox.BackColor = IIf(stat, Drawing.Color.WhiteSmoke, Drawing.Color.White)
            ElseIf TypeOf frm.Controls(i) Is CheckBox Then
                CmbBox = obj : CmbBox.Enabled = stat
                CmbBox.BackColor = IIf(stat, Drawing.Color.WhiteSmoke, Drawing.Color.White)
                '            Else
                '               frm.Controls(i).Enabled = False
            End If
        Next i
        Exit Sub
a:
        MsgBox(Err.Description, MsgBoxStyle.Critical, "Common Business Lib")
    End Sub

    Public Function verifyDirectoryLocation() As Boolean
        Return (FileOperation.Directory.Exists(qmsLOCAL_FOLDER & LOGGED_USER_CODE))
    End Function

    Public Function addEvent(ByVal quoteID As Integer, ByVal statusID As Integer, ByVal note As String) As Boolean
        Try
            'we need to mark this quote-item with last edited
            sql_String = "insert into [events](quoteid,statusid,note,usercode) values(" & quoteID & "," & statusID & ",'" & note & "','" & LOGGED_USER_CODE & "');"
            Dim cmdx As New System.Data.SqlClient.SqlCommand
            cmdx.CommandText = sql_String
            cmdx.Connection = sql_CNN
            Dim rwsx As Integer = cmdx.ExecuteNonQuery()
            cmdx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    'task include - 1.file copy from template to local userfolder 2.write to excel file 3.rename and copy to userlocal folder
    Public Function verifyFileLocation() As Boolean
        Try
            If FileOperation.File.Exists(qmsLOCAL_FOLDER & "template\qmstestfile.xls") Then
                If FileOperation.Directory.Exists(qmsLOCAL_FOLDER & LOGGED_USER_CODE) Then
                    FileOperation.File.Copy(qmsLOCAL_FOLDER & "template\qmstestfile.xls", qmsLOCAL_FOLDER & LOGGED_USER_CODE & "\testok.xls", True)
                    Return True
                Else
                    Return False
                End If
                'now open testok.xls to write 
            Else
                MsgBox("File qmstestfile.xls is missing from location [" & qmsLOCAL_FOLDER & "\template]" & vbCrLf & "Check Admin to assist you on this issue", MsgBoxStyle.Critical, "verifyFileLocation(...")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub setQMSData()
        Call initqmsData()
        'With qmsDataRow
        '    .SerialNumber = intQuoteNo
        '    .ReferenceCode = txtQuoteNo.Text
        '    .Currency = "SAR"
        '    .QuoteDate = txtQuoteDate.Text
        '    .Validity = txtQuoteValidDate.Text
        '    .ShipmentID = cmbShipmentType.SelectedValue
        '    .TemplateID = cmbTemplate.SelectedValue
        '    .Title = txtQuoteDescription.Text
        '    .Attention = cmbAttn.SelectedIndex
        '    .ShipmentType = cmbShipmentType.Text
        'End With

    End Sub

    Public Function createQuoteFolder(ByVal strDirectoryName As String) As Boolean
        Dim di As DirectoryInfo = New DirectoryInfo(strDirectoryName)
        Try
            If Not di.Exists Then
                di.Create()
            End If
            ' Delete the directory.
            '            di.Delete()
            Return True

        Catch e As Exception
            MsgBox(e.ToString, MsgBoxStyle.Critical, "createQuoteFolder") ' Console.WriteLine("The process failed: {0}", e.ToString())
            Return False
        End Try
    End Function

    'task include - 1.file copy from template to local userfolder 2.write to excel file 3.rename and copy to userlocal folder
    Public Function createQuoteFile(ByVal sourceFile As String, ByVal targetFile As String, ByVal folderName As String) As Boolean
        Try

            ' If FileOperation.File.Exists(qmsLOCAL_FOLDER & "template\qmstestfile.xls") Then

            'create folder by client-name if not exists, else create the file under client-name folder
            If createQuoteFolder(folderName) Then
                FileOperation.File.Copy(sourceFile, (folderName & "\" & targetFile), True)
                Return True
            Else
                Return False
            End If

            'now open testok.xls to write 
            'Else
            'MsgBox("File qmstestfile.xls is missing from location [" & qmsLOCAL_FOLDER & "\template]" & vbCrLf & "Check Admin to assist you on this issue", MsgBoxStyle.Critical, "verifyFileLocation(...")
            'Return False
            ''End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function exportQMSDataToPDF(ByVal fileName As String, ByVal UploadFile As Boolean) As Boolean
        Dim xlApp As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim pdfFile As String
        Dim justFileName As String
        Try
            pdfFile = Replace(fileName, ".xls", "")
            'make a copy of previous pdf before overwriting with new
            If FileOperation.File.Exists(pdfFile & ".pdf") Then
                justFileName = " copy (" & Today.Day.ToString & "" & Today.Month.ToString & "" & Today.Year.ToString & "_" & Now.Hour.ToString & "" & Now.Minute.ToString & "" & Now.Second.ToString & ")"
                justFileName += ".pdf"
                FileCopy(pdfFile & ".pdf", (pdfFile & " " & justFileName))
                FileOperation.File.Delete(pdfFile & ".pdf")
            End If


            xlWorkBook = xlApp.Workbooks.Open(fileName)           ' WORKBOOK TO OPEN THE EXCEL FILE.
            justFileName = xlWorkBook.Name()
            xlWorkSheet = xlWorkBook.Worksheets(1)    ' THE NAME OF THE WORK SHEET. 
            xlWorkSheet.ExportAsFixedFormat( _
                        Excel.XlFixedFormatType.xlTypePDF, _
                        pdfFile, _
                     Excel.XlFixedFormatQuality.xlQualityStandard, _
                         True, _
                        True, _
                       1, _
                       10, _
                         True)
            xlWorkBook.Close()

            'once done transfer a copy of PDF file  to google drive folder on workstation PC
            FileOperation.File.Copy((pdfFile & ".pdf"), (qmsGoogleDrivePath & "\" & Replace(justFileName, ".xls", ".pdf")), True)

            '            UploadFile = True
            If UploadFile Then '                'upload the file
                'My.Computer.Network.UploadFile("c:\users\admin\dd.txt", "ftp://gesksa.com/gesksa.com/ksaquotes/dd3.txt", "c53873", "Saodc123", True, 500, FileIO.UICancelOption.DoNothing)
                'check if pdf created then upload
                qmsFTP_USR = "c53873"
                qmsFTP_PWD = "Saodc123"

                If FileOperation.File.Exists(Replace(fileName, ".xls", ".pdf")) Then
                    justFileName = Replace(justFileName, ".xls", ".pdf")
                    My.Computer.Network.UploadFile(fileName.ToString, qmsFTP_URL & justFileName, qmsFTP_USR, qmsFTP_PWD, True, 500, FileIO.UICancelOption.DoNothing)
                    'WRITE TO EVENT Table
                    '                    Call updateQMSFileUpload(qmsFTP_URL & justFileName)
                End If
            End If



            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "exportQMSDataToPDF(...")
        Finally
            ' CLEAN UP. (CLOSE INSTANCES OF EXCEL OBJECTS.)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing
        End Try

    End Function

    Public Function updateQMSFileUpload(ByVal fileURL As String) As Boolean
        Try
            'we need to mark this quote-item with last edited
            sql_String = "update quotes set uploadfileurl='" & fileURL.ToString & "' where id=" & qmsQUOTE_ID & ";"
            Dim cmdx As New System.Data.SqlClient.SqlCommand
            cmdx.CommandText = sql_String
            cmdx.Connection = sql_CNN
            Dim rwsx As Integer = cmdx.ExecuteNonQuery()
            cmdx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function exportQMSDataToExcel(ByVal fileName As String, ByVal openFile As Boolean) As Boolean
        '<declare obj-special vars for excel
        Dim xlApp As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Try
            xlWorkBook = xlApp.Workbooks.Open(fileName)           ' WORKBOOK TO OPEN THE EXCEL FILE.
            xlWorkSheet = xlWorkBook.Worksheets(1)    ' THE NAME OF THE WORK SHEET. 

            'xlApp.Cells(1, 1) = qmsTitle

            xlApp.Range(QmsWSheetLocation.qFcy).Value = QmsDataRow.Currency
            xlApp.Range(QmsWSheetLocation.qTitle).Value = Left(QmsDataRow.Title, 80) & "..."
            xlApp.Range(QmsWSheetLocation.qDate).Value = QmsDataRow.QuoteDate
            xlApp.Range(QmsWSheetLocation.qNo).Value = QmsDataRow.ReferenceCode
            xlApp.Range(QmsWSheetLocation.qShpType).Value = QmsDataRow.ShipmentType
            xlApp.Range(QmsWSheetLocation.qTemplate).Value = QmsDataRow.TemplateName
            xlApp.Range(QmsWSheetLocation.qValidity).Value = QmsDataRow.Validity
            xlApp.Range(QmsWSheetLocation.qNote).Value = QmsDataRow.Title


            xlApp.Range(QmsWSheetLocation.qClientName).Value = ClientData.FullName
            xlApp.Range(QmsWSheetLocation.qClientAddr).Value = QmsClientAddress.Address1
            xlApp.Range(QmsWSheetLocation.qClientAttn).Value = QmsClientAddress.ContactPerson
            xlApp.Range(QmsWSheetLocation.qClientDept).Value = QmsClientAddress.Department & " (" & QmsClientAddress.Email & ")"

            xlApp.Range(QmsWSheetLocation.qUserName).Value = QmsUserRow.name
            xlApp.Range(QmsWSheetLocation.qUserTitle).Value = QmsUserRow.position

            'xlApp.Range(qmsWSheetLocation.qBranchAddr).Value = qmsBranchInfo.CompanyName & " / " & qmsBranchInfo.Address1 & " " & qmsBranchInfo.ContactNumber1 & " " & qmsBranchInfo.ContactNumber2

            xlApp.Range(QmsWSheetLocation.qAuthorized_cellid).Value = QmsWSheetLocation.qAuthorizedBy_Name
            xlApp.Range(QmsWSheetLocation.qAuthorized_title_cellid).Value = QmsWSheetLocation.qAuthorizedBy_Title


            xlApp.Range(QmsWSheetLocation.qclientapproval_name_cell).Value = ClientData.FullName
            xlApp.Range(QmsWSheetLocation.qclientapproval_title_cell).Value = QmsClientAddress.ContactPerson

            'insert userSignature file from 
            '  xlApp.Range("b81").Value = 0
            '            xlWorkSheet.Shapes.AddPicture("C:\xl_pic.JPG", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 50, 300, 45)
            '           xlWorkSheet.Shapes.AddPicture("D:\qmsdata\ADM\mysign.jpg")

            'xlApp.Range("e1").Value = qmsFileName : xlApp.Range("F1").Value = Today.Date.ToString + " - " + Today.Date.TimeOfDay.ToString
            'xlApp.DisplayAlerts = False
            'xlWorkBook.Close() ': xlApp.Quit()


            xlWorkBook.Save() 'open excel file 



            xlApp.Visible = openFile


            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "exportQMSDataToExcel(...")
        Finally
            ' CLEAN UP. (CLOSE INSTANCES OF EXCEL OBJECTS.)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing
        End Try
    End Function


    Public Function getTemplateFileName(ByVal templateID As Integer) As String
        Dim rtnVal As String
        Dim tmpSQL As SqlDataReader
        Dim tmpDS As New DataSet
        Dim tmpCMD As New SqlCommand
        Dim tmpDA As New SqlDataAdapter
        rtnVal = ""
        Try
            If sql_CNN.State = ConnectionState.Closed Then createConnection()


            If sql_CNN.State = ConnectionState.Open Then 'valid cnn
                With tmpCMD
                    .Connection = sql_CNN
                    .CommandType = CommandType.Text
                    .CommandTimeout = (24 * 3600)
                    .CommandText = "select filename from [templates] where id=" & templateID
                End With
                tmpSQL = tmpCMD.ExecuteReader()
                If tmpSQL.HasRows Then
                    While (tmpSQL.Read())
                        rtnVal = tmpSQL("filename").ToString()
                    End While
                    '                    tmpSQL.Close()
                End If
                tmpCMD.Dispose()
                tmpSQL.Close()
                tmpSQL = Nothing
            End If

            Return rtnVal
        Catch ex As Exception
            Return ""
        End Try
        ' closeConnection()
    End Function



    Public Function getNewQuoteNumberByClient(ByVal clientID As Integer) As Integer
        Dim rtnVal As Integer
        Dim tmpSQL As SqlDataReader
        Dim tmpDS As New DataSet
        Dim tmpCMD As New SqlCommand
        Dim tmpDA As New SqlDataAdapter
        rtnVal = 0
        Try
            If sql_CNN.State = ConnectionState.Closed Then createConnection()
            If sql_CNN.State = ConnectionState.Open Then 'valid cnn
                With tmpCMD
                    .Connection = sql_CNN
                    .CommandType = CommandType.Text
                    .CommandTimeout = (24 * 3600)
                    .CommandText = "select isnull(max(serialnumber),0)+1 as qcode  from [quotes] where ClientID=" & clientID
                End With
                tmpSQL = tmpCMD.ExecuteReader()
                If tmpSQL.HasRows Then
                    While (tmpSQL.Read())
                        rtnVal = tmpSQL("qcode").ToString()
                    End While
                End If
                tmpSQL.Close()
                Return rtnVal
            End If
        Catch ex As Exception
            Return -1
        End Try
        ' closeConnection()
    End Function




End Module
