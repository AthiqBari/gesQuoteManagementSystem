Imports CrystalDecisions.CrystalReports.Engine

Public Class gesCRW
    Dim RptName As String
    Dim RptFormula As String
    Dim RightToPrintRpt As Boolean
    Dim RightToExportRpt As Boolean
    Dim RptStrParam As String
    Dim RptPath As String

    Dim RptSQLUser As String
    Dim RptSQLPwd As String

    'Dim wbClass As New octopusClass1
    Public Sub New(ByVal ReportPath As String, ByVal ReportName As String, _
                   ByVal Formula As String, ByVal RptId As Double, ByVal OthParam As String, _
                   ByVal NoPrint As Boolean, ByVal NoExport As Boolean, _
                   ByVal sqlUserName As String, ByVal sqlPassword As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        RptName = ReportName
        RptFormula = Formula
        RptStrParam = OthParam
        RightToPrintRpt = NoPrint
        RightToExportRpt = NoExport
        RptSQLUser = sqlUserName
        RptSQLPwd = sqlPassword



        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub OctRptFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If RptStrParam = "RP" Or RptStrParam = "RR" Then
            LoadReportWithParam()
        Else
            LoadReportWithoutParam()
        End If
    End Sub
    Private Sub LoadReportWithParam()
        Dim RptObj As New ReportDocument()
        RptObj.Load(RptPath + RptName)
        If RptSQLUser.Length > 0 Then RptObj.SetDatabaseLogon(RptSQLUser, RptSQLPwd)

        '        RptObj.SetDatabaseLogon("c53873_athiq", "msSQL123")
        CRV1.SelectionFormula = RptFormula
        CRV1.ReportSource = RptObj
        CRV1.Dock = DockStyle.Fill
        If Not RightToPrintRpt Then CRV1.ShowPrintButton = False
        If Not RightToExportRpt Then CRV1.ShowExportButton = False

        RptObj.Refresh()
        Me.Text = RptPath + RptName
    End Sub
    Private Sub LoadReportWithoutParam()
        Dim RptObj As New ReportDocument()

        RptPath = Application.StartupPath & "\"

        RptObj.Load(RptPath + RptName)
        '        RptObj.SetDatabaseLogon(_sqlUSER, _sqlPWD)
        If RptSQLUser.Length > 0 Then RptObj.SetDatabaseLogon(RptSQLUser, RptSQLPwd)
        Dim mySelectionFormula As String = RptFormula '
        'MsgBox(mySelectionFormula)
        CRV1.SelectionFormula = mySelectionFormula ' "" ' RptFormula
        CRV1.ReportSource = RptObj
        CRV1.Dock = DockStyle.Fill
        If Not RightToPrintRpt Then CRV1.ShowPrintButton = False
        If Not RightToExportRpt Then CRV1.ShowExportButton = False

        RptObj.Refresh()
        Me.Text = RptPath + RptName
        'CRV1.RefreshReport()
    End Sub
End Class