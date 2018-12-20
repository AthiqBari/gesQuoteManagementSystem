Imports System.Data
Imports System.Data.SqlClient

Public Class qmsListOfValues
    Dim rowIDX As Integer
    Private Sub qmsListOfValues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lovSelectedID = 0
        initClientData()
    End Sub


    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        fillCustomerList()

    End Sub

    Private Sub fillCustomerList()
        Me.Cursor = Cursors.WaitCursor
        Dim ds As New DataSet
        Dim rowCount As Integer
        rowIDX = 0
        btnSelect.Visible = False
        lblMsg.Text = ""
        ds = qmsFunctions.getClientList(txtSearchValue.Text.ToString)
        rowCount = ds.Tables("cdata").Rows.Count
        If rowCount > 0 Then


            With DGView1
                .DataSource = Nothing
                .AllowUserToDeleteRows = False : .AllowUserToAddRows = False
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .DataSource = ds.Tables("cdata")
                .BackgroundColor = Color.Gray
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ReadOnly = True
                .RowHeadersWidth = 5
                '.Columns(0).Frozen = True : .Columns(1).Frozen = True : .Columns(2).Frozen = True
                DGridFormat()
                lblMsg.Text = .Rows.Count
            End With
        Else
            DGView1.DataSource = Nothing
            lblMsg.Text = "No matching clients found"


        End If
        Me.Cursor = Cursors.Default
        'gesMDI.ToolStripStatusLabel.Text = "Found : " & DGView1.Rows.Count
    End Sub

    Private Sub DGridFormat()
        With DGView1
            'For i = 0 To .Columns.Count - 1
            '    .Columns(i).ReadOnly = True
            '    .Columns(i).DefaultCellStyle.BackColor = Color.LightGray
            'Next i
            '<format cell widths
            .Columns("code").Width = 46
            .Columns("FullName").Width = 364
            .Columns("ContactPerson1").Width = 213
            .Columns("Email1").Width = 172
            .Columns("ContactPerson2").Width = 213
            .Columns("Email2").Width = 172
            .Columns("id").Width = 0

            .RowsDefaultCellStyle.BackColor = Color.Bisque
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub DGView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGView1.CellClick
        btnSelect.Visible = True
    End Sub


    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        '<goto row
        Dim ds As New DataSet
        Try
            DGView1.CurrentCell = Me.DGView1(0, DGView1.CurrentRow.Index)
            txtSearchValue.Text = DGView1.Rows(DGView1.CurrentRow.Index).Cells("fullname").Value
            rowIDX = DGView1.Rows(DGView1.CurrentRow.Index).Cells("id").Value

            If rowIDX > 0 Then
                Call qmsFunctions.getClientInfo(DGView1.Rows(DGView1.CurrentRow.Index).Cells("Code").Value, "")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub txtSearchValue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchValue.GotFocus
        txtSearchValue.SelectAll()
    End Sub



    Private Sub DGView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGView1.CellContentClick

    End Sub
End Class