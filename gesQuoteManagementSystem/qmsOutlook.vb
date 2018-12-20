Module qmsOutlook

    '---------------------------------------------------------------------------------------
    ' Procedure : StartOutlook
    ' Author    : Daniel Pineault, CARDA Consultants Inc.
    ' Website   : http://www.cardaconsultants.com
    ' Purpose   : Demonstration of how one can start outlook if it isn't already started
    '             considering CreateObject("Outlook.Application") not longer works!
    ' Copyright : The following may be altered and reused as you wish so long as the
    '             copyright notice is left unchanged (including Author, Website and
    '             Copyright).  It may not be sold/resold or reposted on other sites (links
    '             back to this site are allowed).
    '
    ' Usage:
    ' ~~~~~~
    '
    '
    ' Revision History:
    ' Rev       Date(yyyy/mm/dd)        Description
    ' **************************************************************************************
    ' 1         2014-Oct-31                 Initial Release
    '---------------------------------------------------------------------------------------
    Public Function StartOutlook(ByVal toEmail As String, ByVal ccEmail As String, ByVal bccEmail As String, ByVal subject As String, ByVal body As String, ByVal attachFile As String)
        On Error GoTo Error_Handler
        Dim oOutlook As Object
        Dim sAPPPath As String

        Dim htmlCode As String
        htmlCode = "<table  style=""border: 10px solid #999999; width: 90%; font-family:Segoe UI"">"" </table>"

        If IsAppRunning("Outlook.Application") = True Then    'Outlook was already running
            oOutlook = GetObject(, "Outlook.Application")    'Bind to existing instance of Outlook
        Else    'Could not get instance of Outlook, so create a new one
            sAPPPath = GetAppExePath("outlook.exe")    'determine outlook's installation path
            Shell(sAPPPath)    'start outlook
            Do While Not IsAppRunning("Outlook.Application")
                Application.DoEvents()
            Loop
            oOutlook = GetObject(, "Outlook.Application")    'Bind to existing instance of Outlook
        End If

        '    MsgBox "Outlook Should be running now, let's do something"
        Const olMailItem = 0
        Dim oOutlookMsg As Object
        oOutlookMsg = oOutlook.CreateItem(olMailItem)    'Start a new e-mail message
        oOutlookMsg.To = toEmail.ToString
        oOutlookMsg.cc = ccEmail.ToString
        oOutlookMsg.bcc = bccEmail.ToString
        oOutlookMsg.subject = subject.ToString
        oOutlookMsg.HtmlBody = body.ToString

        If Not String.IsNullOrEmpty(attachFile.ToString) Then oOutlookMsg.Attachments.Add(attachFile.ToString)
        oOutlookMsg.Display()    'Show the message to the user


Error_Handler_Exit:
        On Error Resume Next
        oOutlook = Nothing
        Exit Function

Error_Handler:
        MsgBox("The following error has occured" & vbCrLf & vbCrLf & _
               "Error Number: " & Err.Number & vbCrLf & _
               "Error Source: StartOutlook" & vbCrLf & _
               "Error Description: " & Err.Description _
               , vbOKOnly + vbCritical, "An Error has Occured!")
        Resume Error_Handler_Exit
    End Function


    Public Function ReadSignature(ByVal sigName As String) As String

        Dim S As String
        Try
            S = Environ("appdata") & "\Microsoft\Signatures\" & sigName
            'If Dir(S, vbDirectory) <> vbNullString Then S = S & Dir$("atqsign" & "*.htm") Else S = ""
            S = CreateObject("Scripting.FileSystemObject").GetFile(S).OpenAsTextStream(1, -2).ReadAll
            Return S
        Catch ex As Exception
            Return ""
        End Try
        S = Environ("appdata") & "\Microsoft\Signatures\" & sigName
        'WMBody = "<br>Hi All,<br><br>" & _
        ' "Last line,<br><br>" & S 'Add the Signature to end of HTML Body

        'MsgBox(WMBody)
        'Dim Signature_Dir As String
        'Signature_Dir = Environ("APPDATA") & "\Microsoft\Signatures\"
        'Dim oFSO, oTextStream As Object
        'oFSO = CreateObject("Scripting.FileSystemObject")
        'oTextStream = oFSO.OpenTextFile(Signature_Dir & sigName)
        'Signature = oTextStream.ReadAll
        'HTM_Dir = Replace(sigName, ".htm", "_files\")
        'Signature = Replace(Signature, sigName, Signature_Dir & HTM_Dir)
        'Signature = Replace(Signature, "Teqhou_logo.jpg", Signature_Dir & "Teqhou_logo.jpg") 'These four lines set the full path to the four pictures.
        'Signature = Replace(Signature, "MS_Partners.jpg", Signature_Dir & "MS_Partners.jpg")
        'Signature = Replace(Signature, "Teqhou_files/image001.png", Signature_Dir & HTM_Dir & "image001.png")
        'Signature = Replace(Signature, "Teqhou_files/image002.png", Signature_Dir & HTM_Dir & "image002.png")
        'ReadSignature = Signature
    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : IsAppRunning
    ' Author    : Daniel Pineault, CARDA Consultants Inc.
    ' Website   : http://www.cardaconsultants.com
    ' Purpose   : Determine is an App is running or not
    ' Copyright : The following may be altered and reused as you wish so long as the
    '             copyright notice is left unchanged (including Author, Website and
    '             Copyright).  It may not be sold/resold or reposted on other sites (links
    '             back to this site are allowed).
    '
    ' Input Variables:
    ' ~~~~~~~~~~~~~~~~
    ' sApp      : GetObject Application to verify if it is running or not
    '
    ' Usage:
    ' ~~~~~~
    ' IsAppRunning("Outlook.Application")
    ' IsAppRunning("Excel.Application")
    ' IsAppRunning("Word.Application")
    '
    ' Revision History:
    ' Rev       Date(yyyy/mm/dd)        Description
    ' **************************************************************************************
    ' 1         2014-Oct-31                 Initial Release
    '---------------------------------------------------------------------------------------
    Function IsAppRunning(ByVal sApp As String) As Boolean
        On Error GoTo Error_Handler
        Dim oApp As Object

        oApp = GetObject(, sApp)
        IsAppRunning = True

Error_Handler_Exit:
        On Error Resume Next
        oApp = Nothing
        Exit Function

Error_Handler:
        Resume Error_Handler_Exit
    End Function

    '---------------------------------------------------------------------------------------
    ' Procedure : GetAppExePath
    ' Author    : Daniel Pineault, CARDA Consultants Inc.
    ' Website   : http://www.cardaconsultants.com
    ' Purpose   : Determine the path for a given exe installed on the local computer
    ' Copyright : The following may be altered and reused as you wish so long as the
    '             copyright notice is left unchanged (including Author, Website and
    '             Copyright).  It may not be sold/resold or reposted on other sites (links
    '             back to this site are allowed).
    '
    ' Input Variables:
    ' ~~~~~~~~~~~~~~~~
    ' sEXEName  : Name of the exe to locate
    '
    ' Usage:
    ' ~~~~~~
    ' Call GetAppExePath("msaccess.exe")
    ' GetAppExePath("firefox.exe")
    ' GetAppExePath("outlook.exe")
    '
    ' Revision History:
    ' Rev       Date(yyyy/mm/dd)        Description
    ' **************************************************************************************
    ' 1         2014-Oct-31                 Initial Release
    '---------------------------------------------------------------------------------------
    Function GetAppExePath(ByVal sExeName As String) As String
        On Error GoTo Error_Handler
        Dim WSHShell As Object

        WSHShell = CreateObject("Wscript.Shell")
        GetAppExePath = WSHShell.RegRead("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" & sExeName & "\")

Error_Handler_Exit:
        On Error Resume Next
        WSHShell = Nothing
        Exit Function

Error_Handler:
        If Err.Number = -2147024894 Then
            'Cannot locate requested exe????
        Else
            MsgBox("The following error has occured." & vbCrLf & vbCrLf & _
                   "Error Number: " & Err.Number & vbCrLf & _
                   "Error Source: GetAppExePath" & vbCrLf & _
                   "Error Description: " & Err.Description, _
                   vbCritical, "An Error has Occured!")
        End If
        Resume Error_Handler_Exit
    End Function
End Module
