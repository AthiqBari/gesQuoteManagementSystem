'Imports System.Reflection
'Imports System.IO

'Namespace Telerik.Examples.WinControls.PdfViewer.FirstLook
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports System.IO

Public Class RadForm1

    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    '    InitializeComponent()
    '    Dim stream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Sample.pdf")
    '    Me.radPdfViewer1.LoadDocument(stream)
    'End Sub

    Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        '        Dim fileName As String
        qmsFTP_USR = "c53873"
        qmsFTP_PWD = "Saodc123"

        '       fileName = RadTextBox2.Text
        '        justFileName = Replace(justFileName, ".xls", ".pdf")
        '        My.Computer.Network.UploadFile(fileName.ToString, qmsFTP_URL & RadTextBox1.Text.ToString, qmsFTP_USR, qmsFTP_PWD, True, 500, FileIO.UICancelOption.DoNothing)


        RadTextBox1.Text = "D:\qmsdata\ADM\1005-Saudi Perlite Co\1005-ADM-001-1040.xls"
        Application.DoEvents()
        Call uploadFile(RadTextBox2.Text, RadTextBox1.Text, qmsFTP_USR, qmsFTP_PWD)
    End Sub



    Private Sub uploadFile(ByVal FTPAddress As String, ByVal filePath As String, ByVal username As String, ByVal password As String)
        'Create FTP request
        Dim request As FtpWebRequest = DirectCast(FtpWebRequest.Create((FTPAddress & Convert.ToString("/")) + Path.GetFileName(filePath)), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.UploadFile
        request.Credentials = New NetworkCredential(username, password)
        request.UsePassive = True
        request.UseBinary = True
        request.KeepAlive = False

        'Load the file
        Dim stream As FileStream = File.OpenRead(filePath)
        Dim buffer As Byte() = New Byte(stream.Length - 1) {}

        stream.Read(buffer, 0, buffer.Length)
        stream.Close()

        'Upload file
        Dim reqStream As Stream = request.GetRequestStream()
        reqStream.Write(buffer, 0, buffer.Length)
        reqStream.Close()

        MessageBox.Show("Uploaded Successfully")
    End Sub

End Class

'End Namespace
