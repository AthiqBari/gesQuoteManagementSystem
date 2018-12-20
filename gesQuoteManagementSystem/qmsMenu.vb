Imports System.Windows.Forms

Public Class qmsMenu
    Private mChildFormNumber As Integer


    Private Sub qmsMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load

        'temp-code
        'frmWaitForm.lblTitle.Text = "Reading data from cloud server. please wait..!"
        'frmWaitForm.Show()
        'frmWaitForm.Refresh()
        'Me.Cursor = Cursors.WaitCursor

        'frmWaitForm.Close()
        Me.Cursor = Cursors.Default

        lblWelcome.Text = QmsUserRow.name & "(" & QmsUserRow.position & ")"
        lblCoName.Text = QmsBranchInfo.CompanyName
        Me.Text = "Quote Management System - " & QmsUserRow.name

    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Do you want to close this Application?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Quit Request") = MsgBoxResult.Yes Then End

    End Sub

    Private Sub qmsMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Close QMS Application?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Quit Request") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu.Click
        On Error GoTo A


        '        On Error Resume Next
        'Me.Cursor = Cursors.WaitCursor
        'qmsAddForm.MdiParent = Me
        'qmsAddForm.Show()

        'With qmsExplorer
        '    .MdiParent = Me
        '    .Show()
        '    .BringToFront()
        'End With
        'Me.Cursor = Cursors.Default

        'Me.Cursor = Cursors.WaitCursor

        'Dim frm As New qmsAddForm()
        'frm.MdiParent = Me
        'frm.Show()
        'frm.BringToFront()


        'qmsAddForm.Show()

        'With qmsAddForm
        '    .MdiParent = Me
        '    .Show()
        '    .BringToFront()
        'End With
        'Me.Cursor = Cursors.Default


        'On Error Resume Next
        ' On Error GoTo A

        Me.Cursor = Cursors.WaitCursor

        Dim frm As New qmsAddForm(0)
        With frm
            .MdiParent = Me
            .Show()
            '.BringToFront()
        End With
        Me.Cursor = Cursors.Default

        Exit Sub
A:
        Me.Cursor = Cursors.Default
        MsgBox(Err.Description, MsgBoxStyle.Exclamation, Me.Text)
    End Sub

    Private Sub qmsMenu_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        lblWelcome.Left = Me.MenuStrip.Width - lblWelcome.Width
        lblCoName.Left = Me.MenuStrip.Width - lblCoName.Width
    End Sub

    Private Sub CreateNewUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewUsersToolStripMenuItem.Click
        'RadForm1.Show()

        'If Not qmsUserRow.admin Then MsgBox("Access denied", MsgBoxStyle.Exclamation, Me.Text)
    End Sub

    Private Sub QMSFolderSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QMSFolderSettingsToolStripMenuItem.Click
        MsgBox(qmsLOCAL_FOLDER, MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub ClientMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientMenu.Click
        On Error Resume Next
        Me.Cursor = Cursors.WaitCursor
        With qmsCustomerForm
            .MdiParent = Me
            .Show()
            .BringToFront()
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenu.Click
        On Error Resume Next
        Me.Cursor = Cursors.WaitCursor
        With qmsExplorer
            .MdiParent = Me
            .Show()
            .BringToFront()
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub
End Class
