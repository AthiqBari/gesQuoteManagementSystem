<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qmsExplorer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qmsExplorer))
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cmbShowOption = New System.Windows.Forms.ComboBox()
        Me.chkShowMyQuotes = New System.Windows.Forms.CheckBox()
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtSearchValue = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGView1 = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMakeCopy = New System.Windows.Forms.Button()
        Me.btnEmailQuote = New System.Windows.Forms.Button()
        Me.btnOpenQuote = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnViewPDFQuote = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblCreatedByEmailID = New System.Windows.Forms.Label()
        Me.lblQuoteRequest = New System.Windows.Forms.LinkLabel()
        Me.lblMsg1 = New System.Windows.Forms.Label()
        Me.dgvEvents = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFileMissing = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQuoteFileName = New System.Windows.Forms.TextBox()
        Me.txtPreparedBy = New System.Windows.Forms.TextBox()
        Me.txtQType = New System.Windows.Forms.TextBox()
        Me.txtQuoteStatus = New System.Windows.Forms.TextBox()
        Me.txtDepartment1 = New System.Windows.Forms.TextBox()
        Me.txtQuoteDescription = New System.Windows.Forms.TextBox()
        Me.txtContact1 = New System.Windows.Forms.TextBox()
        Me.txtClientEmail1 = New System.Windows.Forms.TextBox()
        Me.txtClientContactPerson1 = New System.Windows.Forms.TextBox()
        Me.txtClientAddress1 = New System.Windows.Forms.TextBox()
        Me.txtQuoteNo = New System.Windows.Forms.TextBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblQTitle1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuoteValidDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtQuoteDate = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblQTitle2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblQTitle3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel10.Controls.Add(Me.cmbShowOption)
        Me.Panel10.Controls.Add(Me.chkShowMyQuotes)
        Me.Panel10.Controls.Add(Me.cmbSearchBy)
        Me.Panel10.Controls.Add(Me.lblMsg)
        Me.Panel10.Controls.Add(Me.btnRun)
        Me.Panel10.Controls.Add(Me.txtSearchValue)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1293, 59)
        Me.Panel10.TabIndex = 85
        '
        'cmbShowOption
        '
        Me.cmbShowOption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbShowOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShowOption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShowOption.FormattingEnabled = True
        Me.cmbShowOption.Items.AddRange(New Object() {"Recent Quotes", "This Month", "Last Month", "All Quotes"})
        Me.cmbShowOption.Location = New System.Drawing.Point(849, 20)
        Me.cmbShowOption.Name = "cmbShowOption"
        Me.cmbShowOption.Size = New System.Drawing.Size(161, 27)
        Me.cmbShowOption.TabIndex = 91
        Me.cmbShowOption.Visible = False
        '
        'chkShowMyQuotes
        '
        Me.chkShowMyQuotes.AutoSize = True
        Me.chkShowMyQuotes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowMyQuotes.ForeColor = System.Drawing.Color.White
        Me.chkShowMyQuotes.Location = New System.Drawing.Point(1119, 16)
        Me.chkShowMyQuotes.Name = "chkShowMyQuotes"
        Me.chkShowMyQuotes.Size = New System.Drawing.Size(205, 27)
        Me.chkShowMyQuotes.TabIndex = 90
        Me.chkShowMyQuotes.Text = "Show Only My Quotes"
        Me.chkShowMyQuotes.UseVisualStyleBackColor = True
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Location = New System.Drawing.Point(159, 19)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(161, 27)
        Me.cmbSearchBy.TabIndex = 89
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.lblMsg.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMsg.Location = New System.Drawing.Point(205, 46)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(19, 14)
        Me.lblMsg.TabIndex = 88
        Me.lblMsg.Text = "..."
        '
        'btnRun
        '
        Me.btnRun.AutoSize = True
        Me.btnRun.BackColor = System.Drawing.Color.Transparent
        Me.btnRun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRun.FlatAppearance.BorderSize = 0
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRun.Location = New System.Drawing.Point(610, 10)
        Me.btnRun.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(39, 38)
        Me.btnRun.TabIndex = 86
        Me.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'txtSearchValue
        '
        Me.txtSearchValue.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchValue.Location = New System.Drawing.Point(320, 19)
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.Size = New System.Drawing.Size(284, 27)
        Me.txtSearchValue.TabIndex = 65
        Me.txtSearchValue.Text = "Enter Search Value"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(12, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 18)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Search Quote By -"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1293, 248)
        Me.Panel1.TabIndex = 86
        '
        'DGView1
        '
        Me.DGView1.AllowUserToAddRows = False
        Me.DGView1.AllowUserToDeleteRows = False
        Me.DGView1.AllowUserToOrderColumns = True
        Me.DGView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGView1.Location = New System.Drawing.Point(0, 0)
        Me.DGView1.MultiSelect = False
        Me.DGView1.Name = "DGView1"
        Me.DGView1.ReadOnly = True
        Me.DGView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGView1.Size = New System.Drawing.Size(1293, 248)
        Me.DGView1.TabIndex = 87
        '
        'btnMakeCopy
        '
        Me.btnMakeCopy.AutoSize = True
        Me.btnMakeCopy.BackColor = System.Drawing.Color.Transparent
        Me.btnMakeCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMakeCopy.FlatAppearance.BorderSize = 0
        Me.btnMakeCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakeCopy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeCopy.Image = CType(resources.GetObject("btnMakeCopy.Image"), System.Drawing.Image)
        Me.btnMakeCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMakeCopy.Location = New System.Drawing.Point(997, 92)
        Me.btnMakeCopy.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnMakeCopy.Name = "btnMakeCopy"
        Me.btnMakeCopy.Size = New System.Drawing.Size(97, 60)
        Me.btnMakeCopy.TabIndex = 132
        Me.btnMakeCopy.Text = "Make a Copy"
        Me.btnMakeCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnMakeCopy, "Make a copy of this quote")
        Me.btnMakeCopy.UseVisualStyleBackColor = False
        '
        'btnEmailQuote
        '
        Me.btnEmailQuote.AutoSize = True
        Me.btnEmailQuote.BackColor = System.Drawing.Color.Transparent
        Me.btnEmailQuote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmailQuote.FlatAppearance.BorderSize = 0
        Me.btnEmailQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmailQuote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmailQuote.Image = CType(resources.GetObject("btnEmailQuote.Image"), System.Drawing.Image)
        Me.btnEmailQuote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmailQuote.Location = New System.Drawing.Point(1076, 92)
        Me.btnEmailQuote.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnEmailQuote.Name = "btnEmailQuote"
        Me.btnEmailQuote.Size = New System.Drawing.Size(79, 60)
        Me.btnEmailQuote.TabIndex = 133
        Me.btnEmailQuote.Text = "Email"
        Me.btnEmailQuote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEmailQuote, "Email this Quote")
        Me.btnEmailQuote.UseVisualStyleBackColor = False
        '
        'btnOpenQuote
        '
        Me.btnOpenQuote.AutoSize = True
        Me.btnOpenQuote.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenQuote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenQuote.FlatAppearance.BorderSize = 0
        Me.btnOpenQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenQuote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenQuote.Image = CType(resources.GetObject("btnOpenQuote.Image"), System.Drawing.Image)
        Me.btnOpenQuote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOpenQuote.Location = New System.Drawing.Point(917, 92)
        Me.btnOpenQuote.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnOpenQuote.Name = "btnOpenQuote"
        Me.btnOpenQuote.Size = New System.Drawing.Size(83, 60)
        Me.btnOpenQuote.TabIndex = 134
        Me.btnOpenQuote.Text = "Edit Quote"
        Me.btnOpenQuote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnOpenQuote, "Open Quote")
        Me.btnOpenQuote.UseVisualStyleBackColor = False
        '
        'btnPDF
        '
        Me.btnPDF.AutoSize = True
        Me.btnPDF.BackColor = System.Drawing.Color.Transparent
        Me.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPDF.FlatAppearance.BorderSize = 0
        Me.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPDF.Location = New System.Drawing.Point(1161, 92)
        Me.btnPDF.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(114, 60)
        Me.btnPDF.TabIndex = 135
        Me.btnPDF.Text = "Convert to PDF"
        Me.btnPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnPDF, "Send to PDF")
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'btnViewPDFQuote
        '
        Me.btnViewPDFQuote.AutoSize = True
        Me.btnViewPDFQuote.BackColor = System.Drawing.Color.Transparent
        Me.btnViewPDFQuote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewPDFQuote.FlatAppearance.BorderSize = 0
        Me.btnViewPDFQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPDFQuote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPDFQuote.Image = CType(resources.GetObject("btnViewPDFQuote.Image"), System.Drawing.Image)
        Me.btnViewPDFQuote.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewPDFQuote.Location = New System.Drawing.Point(920, 176)
        Me.btnViewPDFQuote.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnViewPDFQuote.Name = "btnViewPDFQuote"
        Me.btnViewPDFQuote.Size = New System.Drawing.Size(116, 60)
        Me.btnViewPDFQuote.TabIndex = 143
        Me.btnViewPDFQuote.Text = "View PDF Quote"
        Me.btnViewPDFQuote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnViewPDFQuote, "Open Quote")
        Me.btnViewPDFQuote.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1293, 11)
        Me.Panel2.TabIndex = 124
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Controls.Add(Me.TabControl1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 318)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1293, 394)
        Me.Panel5.TabIndex = 125
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1293, 394)
        Me.TabControl1.TabIndex = 123
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.btnViewPDFQuote)
        Me.TabPage1.Controls.Add(Me.lblCreatedByEmailID)
        Me.TabPage1.Controls.Add(Me.lblQuoteRequest)
        Me.TabPage1.Controls.Add(Me.lblMsg1)
        Me.TabPage1.Controls.Add(Me.dgvEvents)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lblFileMissing)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnPDF)
        Me.TabPage1.Controls.Add(Me.btnOpenQuote)
        Me.TabPage1.Controls.Add(Me.btnEmailQuote)
        Me.TabPage1.Controls.Add(Me.btnMakeCopy)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtQuoteFileName)
        Me.TabPage1.Controls.Add(Me.txtPreparedBy)
        Me.TabPage1.Controls.Add(Me.txtQType)
        Me.TabPage1.Controls.Add(Me.txtQuoteStatus)
        Me.TabPage1.Controls.Add(Me.txtDepartment1)
        Me.TabPage1.Controls.Add(Me.txtQuoteDescription)
        Me.TabPage1.Controls.Add(Me.txtContact1)
        Me.TabPage1.Controls.Add(Me.txtClientEmail1)
        Me.TabPage1.Controls.Add(Me.txtClientContactPerson1)
        Me.TabPage1.Controls.Add(Me.txtClientAddress1)
        Me.TabPage1.Controls.Add(Me.txtQuoteNo)
        Me.TabPage1.Controls.Add(Me.txtClientName)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtQuoteValidDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtQuoteDate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1285, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Quote Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblCreatedByEmailID
        '
        Me.lblCreatedByEmailID.AutoSize = True
        Me.lblCreatedByEmailID.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblCreatedByEmailID.ForeColor = System.Drawing.Color.Gray
        Me.lblCreatedByEmailID.Location = New System.Drawing.Point(313, 333)
        Me.lblCreatedByEmailID.Name = "lblCreatedByEmailID"
        Me.lblCreatedByEmailID.Size = New System.Drawing.Size(114, 17)
        Me.lblCreatedByEmailID.TabIndex = 142
        Me.lblCreatedByEmailID.Text = "createdByEmail"
        '
        'lblQuoteRequest
        '
        Me.lblQuoteRequest.AutoSize = True
        Me.lblQuoteRequest.LinkColor = System.Drawing.Color.Blue
        Me.lblQuoteRequest.Location = New System.Drawing.Point(569, 255)
        Me.lblQuoteRequest.Name = "lblQuoteRequest"
        Me.lblQuoteRequest.Size = New System.Drawing.Size(233, 17)
        Me.lblQuoteRequest.TabIndex = 141
        Me.lblQuoteRequest.TabStop = True
        Me.lblQuoteRequest.Text = "Request a copy of this Quote"
        Me.lblQuoteRequest.Visible = False
        '
        'lblMsg1
        '
        Me.lblMsg1.AutoSize = True
        Me.lblMsg1.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lblMsg1.ForeColor = System.Drawing.Color.Red
        Me.lblMsg1.Location = New System.Drawing.Point(914, 155)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(407, 17)
        Me.lblMsg1.TabIndex = 140
        Me.lblMsg1.Text = "Email Error - Convert this Quote to PDF and try again... "
        Me.lblMsg1.Visible = False
        '
        'dgvEvents
        '
        Me.dgvEvents.AllowUserToAddRows = False
        Me.dgvEvents.AllowUserToDeleteRows = False
        Me.dgvEvents.AllowUserToOrderColumns = True
        Me.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEvents.Location = New System.Drawing.Point(920, 401)
        Me.dgvEvents.MultiSelect = False
        Me.dgvEvents.Name = "dgvEvents"
        Me.dgvEvents.ReadOnly = True
        Me.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvEvents.Size = New System.Drawing.Size(354, 111)
        Me.dgvEvents.TabIndex = 139
        Me.dgvEvents.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(920, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 22)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Quote Events"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'lblFileMissing
        '
        Me.lblFileMissing.AutoSize = True
        Me.lblFileMissing.BackColor = System.Drawing.Color.Transparent
        Me.lblFileMissing.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lblFileMissing.ForeColor = System.Drawing.Color.Red
        Me.lblFileMissing.Location = New System.Drawing.Point(11, 333)
        Me.lblFileMissing.Name = "lblFileMissing"
        Me.lblFileMissing.Size = New System.Drawing.Size(363, 17)
        Me.lblFileMissing.TabIndex = 137
        Me.lblFileMissing.Text = "Unable to open File.  Missing,Renamed or Moved..."
        Me.lblFileMissing.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(917, 266)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(354, 99)
        Me.DataGridView1.TabIndex = 136
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(914, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(356, 22)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Action Items"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQuoteFileName
        '
        Me.txtQuoteFileName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuoteFileName.Location = New System.Drawing.Point(12, 309)
        Me.txtQuoteFileName.MaxLength = 10
        Me.txtQuoteFileName.Name = "txtQuoteFileName"
        Me.txtQuoteFileName.ReadOnly = True
        Me.txtQuoteFileName.Size = New System.Drawing.Size(295, 24)
        Me.txtQuoteFileName.TabIndex = 130
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedBy.Location = New System.Drawing.Point(313, 309)
        Me.txtPreparedBy.MaxLength = 10
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.ReadOnly = True
        Me.txtPreparedBy.Size = New System.Drawing.Size(205, 24)
        Me.txtPreparedBy.TabIndex = 127
        '
        'txtQType
        '
        Me.txtQType.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtQType.Location = New System.Drawing.Point(86, 124)
        Me.txtQType.MaxLength = 10
        Me.txtQType.Name = "txtQType"
        Me.txtQType.ReadOnly = True
        Me.txtQType.Size = New System.Drawing.Size(101, 24)
        Me.txtQType.TabIndex = 125
        '
        'txtQuoteStatus
        '
        Me.txtQuoteStatus.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtQuoteStatus.Location = New System.Drawing.Point(86, 151)
        Me.txtQuoteStatus.MaxLength = 10
        Me.txtQuoteStatus.Name = "txtQuoteStatus"
        Me.txtQuoteStatus.ReadOnly = True
        Me.txtQuoteStatus.Size = New System.Drawing.Size(101, 24)
        Me.txtQuoteStatus.TabIndex = 123
        '
        'txtDepartment1
        '
        Me.txtDepartment1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDepartment1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment1.Location = New System.Drawing.Point(543, 176)
        Me.txtDepartment1.MaxLength = 10
        Me.txtDepartment1.Name = "txtDepartment1"
        Me.txtDepartment1.ReadOnly = True
        Me.txtDepartment1.Size = New System.Drawing.Size(355, 24)
        Me.txtDepartment1.TabIndex = 118
        Me.txtDepartment1.Text = "[Department]"
        '
        'txtQuoteDescription
        '
        Me.txtQuoteDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuoteDescription.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuoteDescription.Location = New System.Drawing.Point(11, 222)
        Me.txtQuoteDescription.Multiline = True
        Me.txtQuoteDescription.Name = "txtQuoteDescription"
        Me.txtQuoteDescription.ReadOnly = True
        Me.txtQuoteDescription.Size = New System.Drawing.Size(507, 59)
        Me.txtQuoteDescription.TabIndex = 120
        '
        'txtContact1
        '
        Me.txtContact1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContact1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact1.Location = New System.Drawing.Point(543, 218)
        Me.txtContact1.MaxLength = 10
        Me.txtContact1.Name = "txtContact1"
        Me.txtContact1.ReadOnly = True
        Me.txtContact1.Size = New System.Drawing.Size(355, 24)
        Me.txtContact1.TabIndex = 116
        Me.txtContact1.Text = "[Contact1]"
        '
        'txtClientEmail1
        '
        Me.txtClientEmail1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClientEmail1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientEmail1.Location = New System.Drawing.Point(543, 197)
        Me.txtClientEmail1.MaxLength = 10
        Me.txtClientEmail1.Name = "txtClientEmail1"
        Me.txtClientEmail1.ReadOnly = True
        Me.txtClientEmail1.Size = New System.Drawing.Size(355, 24)
        Me.txtClientEmail1.TabIndex = 115
        Me.txtClientEmail1.Text = "[Email]"
        '
        'txtClientContactPerson1
        '
        Me.txtClientContactPerson1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClientContactPerson1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientContactPerson1.Location = New System.Drawing.Point(543, 155)
        Me.txtClientContactPerson1.MaxLength = 10
        Me.txtClientContactPerson1.Name = "txtClientContactPerson1"
        Me.txtClientContactPerson1.ReadOnly = True
        Me.txtClientContactPerson1.Size = New System.Drawing.Size(355, 24)
        Me.txtClientContactPerson1.TabIndex = 114
        Me.txtClientContactPerson1.Text = "[Contact Person]"
        '
        'txtClientAddress1
        '
        Me.txtClientAddress1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClientAddress1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientAddress1.Location = New System.Drawing.Point(543, 113)
        Me.txtClientAddress1.MaxLength = 10
        Me.txtClientAddress1.Multiline = True
        Me.txtClientAddress1.Name = "txtClientAddress1"
        Me.txtClientAddress1.ReadOnly = True
        Me.txtClientAddress1.Size = New System.Drawing.Size(355, 42)
        Me.txtClientAddress1.TabIndex = 113
        Me.txtClientAddress1.Text = "[Address1]"
        '
        'txtQuoteNo
        '
        Me.txtQuoteNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQuoteNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuoteNo.ForeColor = System.Drawing.Color.Maroon
        Me.txtQuoteNo.Location = New System.Drawing.Point(86, 97)
        Me.txtQuoteNo.MaxLength = 10
        Me.txtQuoteNo.Name = "txtQuoteNo"
        Me.txtQuoteNo.ReadOnly = True
        Me.txtQuoteNo.Size = New System.Drawing.Size(101, 24)
        Me.txtQuoteNo.TabIndex = 89
        Me.txtQuoteNo.Text = "Quote#"
        '
        'txtClientName
        '
        Me.txtClientName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClientName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientName.Location = New System.Drawing.Point(543, 92)
        Me.txtClientName.MaxLength = 10
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(355, 24)
        Me.txtClientName.TabIndex = 112
        Me.txtClientName.Text = "[FullName]"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Gainsboro
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(11, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(296, 22)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "File Information"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(916, 246)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(354, 22)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Attachments"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(15, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 18)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(15, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 18)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Type:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblQTitle1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1279, 44)
        Me.Panel3.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1138, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 29)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Quote View"
        '
        'lblQTitle1
        '
        Me.lblQTitle1.AutoSize = True
        Me.lblQTitle1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblQTitle1.Location = New System.Drawing.Point(12, 13)
        Me.lblQTitle1.Name = "lblQTitle1"
        Me.lblQTitle1.Size = New System.Drawing.Size(158, 29)
        Me.lblQTitle1.TabIndex = 64
        Me.lblQTitle1.Text = " Quote # - "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 22)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Quote Header"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(313, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 22)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Quote Leader"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Quote #:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(11, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(507, 22)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Quote / Project Description"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(309, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Prepared On:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(309, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 18)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Quote Validity:"
        '
        'txtQuoteValidDate
        '
        Me.txtQuoteValidDate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtQuoteValidDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQuoteValidDate.Location = New System.Drawing.Point(417, 124)
        Me.txtQuoteValidDate.Mask = "00/00/0000"
        Me.txtQuoteValidDate.Name = "txtQuoteValidDate"
        Me.txtQuoteValidDate.ReadOnly = True
        Me.txtQuoteValidDate.Size = New System.Drawing.Size(101, 24)
        Me.txtQuoteValidDate.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(542, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(356, 22)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Customer Information"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQuoteDate
        '
        Me.txtQuoteDate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtQuoteDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQuoteDate.Location = New System.Drawing.Point(417, 97)
        Me.txtQuoteDate.Mask = "00/00/0000"
        Me.txtQuoteDate.Name = "txtQuoteDate"
        Me.txtQuoteDate.ReadOnly = True
        Me.txtQuoteDate.Size = New System.Drawing.Size(101, 24)
        Me.txtQuoteDate.TabIndex = 91
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1285, 364)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Quote Followup"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.lblQTitle2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1285, 44)
        Me.Panel4.TabIndex = 86
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(1169, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 29)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Followup"
        '
        'lblQTitle2
        '
        Me.lblQTitle2.AutoSize = True
        Me.lblQTitle2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblQTitle2.Location = New System.Drawing.Point(12, 13)
        Me.lblQTitle2.Name = "lblQTitle2"
        Me.lblQTitle2.Size = New System.Drawing.Size(158, 29)
        Me.lblQTitle2.TabIndex = 64
        Me.lblQTitle2.Text = " Quote # - "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblDirectory)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1285, 364)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.BackColor = System.Drawing.Color.Transparent
        Me.lblDirectory.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lblDirectory.ForeColor = System.Drawing.Color.Gray
        Me.lblDirectory.Location = New System.Drawing.Point(20, 320)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(363, 17)
        Me.lblDirectory.TabIndex = 141
        Me.lblDirectory.Text = "Unable to open File.  Missing,Renamed or Moved..."
        Me.lblDirectory.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.lblQTitle3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1279, 44)
        Me.Panel6.TabIndex = 140
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(1174, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 29)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "History"
        '
        'lblQTitle3
        '
        Me.lblQTitle3.AutoSize = True
        Me.lblQTitle3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTitle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblQTitle3.Location = New System.Drawing.Point(12, 13)
        Me.lblQTitle3.Name = "lblQTitle3"
        Me.lblQTitle3.Size = New System.Drawing.Size(158, 29)
        Me.lblQTitle3.TabIndex = 64
        Me.lblQTitle3.Text = " Quote # - "
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(19, 90)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(666, 227)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 139
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Gainsboro
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(19, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(666, 30)
        Me.Label17.TabIndex = 137
        Me.Label17.Text = "Quote History"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'qmsExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 712)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel10)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "qmsExplorer"
        Me.Text = "QMS Explorer"
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents txtSearchValue As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DGView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents chkShowMyQuotes As System.Windows.Forms.CheckBox
    Friend WithEvents cmbShowOption As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents dgvEvents As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFileMissing As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnOpenQuote As System.Windows.Forms.Button
    Friend WithEvents btnEmailQuote As System.Windows.Forms.Button
    Friend WithEvents btnMakeCopy As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtQuoteFileName As System.Windows.Forms.TextBox
    Friend WithEvents txtPreparedBy As System.Windows.Forms.TextBox
    Friend WithEvents txtQType As System.Windows.Forms.TextBox
    Friend WithEvents txtQuoteStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuoteDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtContact1 As System.Windows.Forms.TextBox
    Friend WithEvents txtClientEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents txtClientContactPerson1 As System.Windows.Forms.TextBox
    Friend WithEvents txtClientAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuoteNo As System.Windows.Forms.TextBox
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblQTitle1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQuoteValidDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtQuoteDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblQTitle2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblQTitle3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblDirectory As System.Windows.Forms.Label
    Friend WithEvents lblQuoteRequest As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCreatedByEmailID As System.Windows.Forms.Label
    Friend WithEvents btnViewPDFQuote As System.Windows.Forms.Button
End Class
