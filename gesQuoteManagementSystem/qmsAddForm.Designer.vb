<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qmsAddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qmsAddForm))
        Me.lblAccountCode = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGView1 = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblQuoteHistory = New System.Windows.Forms.Label()
        Me.txtQuoteNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuoteDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtQuoteValidDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtQuoteStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuoteDescription = New System.Windows.Forms.TextBox()
        Me.btnGenerateQuote = New System.Windows.Forms.Button()
        Me.cmbTemplate = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbShipmentType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lnkShowHistory = New System.Windows.Forms.LinkLabel()
        Me.lnkHideHistory = New System.Windows.Forms.LinkLabel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtClientCode = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClientList = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtClientAddress1 = New System.Windows.Forms.TextBox()
        Me.txtClientContactPerson1 = New System.Windows.Forms.TextBox()
        Me.txtClientEmail1 = New System.Windows.Forms.TextBox()
        Me.cmbAttn = New System.Windows.Forms.ComboBox()
        Me.txtContact1 = New System.Windows.Forms.TextBox()
        Me.txtDepartment1 = New System.Windows.Forms.TextBox()
        Me.lnkFileLocation = New System.Windows.Forms.LinkLabel()
        Me.lblTemplateFile = New System.Windows.Forms.Label()
        Me.PanelTip = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAddNewQuote = New System.Windows.Forms.Button()
        Me.PanelConfirmation = New System.Windows.Forms.Panel()
        Me.lblOpenQuote = New System.Windows.Forms.LinkLabel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCopyQuote = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DGView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.PanelTip.SuspendLayout()
        Me.PanelConfirmation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAccountCode
        '
        Me.lblAccountCode.AutoSize = True
        Me.lblAccountCode.BackColor = System.Drawing.Color.Transparent
        Me.lblAccountCode.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAccountCode.Location = New System.Drawing.Point(5, 9)
        Me.lblAccountCode.Name = "lblAccountCode"
        Me.lblAccountCode.Size = New System.Drawing.Size(222, 29)
        Me.lblAccountCode.TabIndex = 64
        Me.lblAccountCode.Text = "Add New Quote"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.DGView1)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Location = New System.Drawing.Point(7, 443)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(855, 268)
        Me.Panel2.TabIndex = 74
        '
        'DGView1
        '
        Me.DGView1.AllowUserToAddRows = False
        Me.DGView1.AllowUserToDeleteRows = False
        Me.DGView1.AllowUserToOrderColumns = True
        Me.DGView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGView1.Location = New System.Drawing.Point(0, 23)
        Me.DGView1.MultiSelect = False
        Me.DGView1.Name = "DGView1"
        Me.DGView1.ReadOnly = True
        Me.DGView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGView1.Size = New System.Drawing.Size(855, 241)
        Me.DGView1.TabIndex = 86
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel10.Controls.Add(Me.lblQuoteHistory)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(855, 23)
        Me.Panel10.TabIndex = 83
        '
        'lblQuoteHistory
        '
        Me.lblQuoteHistory.AutoSize = True
        Me.lblQuoteHistory.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuoteHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblQuoteHistory.Location = New System.Drawing.Point(9, 2)
        Me.lblQuoteHistory.Name = "lblQuoteHistory"
        Me.lblQuoteHistory.Size = New System.Drawing.Size(122, 18)
        Me.lblQuoteHistory.TabIndex = 64
        Me.lblQuoteHistory.Text = "Quote History"
        '
        'txtQuoteNo
        '
        Me.txtQuoteNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQuoteNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuoteNo.ForeColor = System.Drawing.Color.Maroon
        Me.txtQuoteNo.Location = New System.Drawing.Point(638, 84)
        Me.txtQuoteNo.MaxLength = 10
        Me.txtQuoteNo.Name = "txtQuoteNo"
        Me.txtQuoteNo.ReadOnly = True
        Me.txtQuoteNo.Size = New System.Drawing.Size(131, 24)
        Me.txtQuoteNo.TabIndex = 81
        Me.txtQuoteNo.Text = "Quote#"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(559, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Quote #"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(588, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(545, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Valid Until"
        '
        'txtQuoteDate
        '
        Me.txtQuoteDate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtQuoteDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQuoteDate.Location = New System.Drawing.Point(638, 108)
        Me.txtQuoteDate.Mask = "00/00/0000"
        Me.txtQuoteDate.Name = "txtQuoteDate"
        Me.txtQuoteDate.Size = New System.Drawing.Size(131, 24)
        Me.txtQuoteDate.TabIndex = 3
        '
        'txtQuoteValidDate
        '
        Me.txtQuoteValidDate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtQuoteValidDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQuoteValidDate.Location = New System.Drawing.Point(638, 132)
        Me.txtQuoteValidDate.Mask = "00/00/0000"
        Me.txtQuoteValidDate.Name = "txtQuoteValidDate"
        Me.txtQuoteValidDate.Size = New System.Drawing.Size(131, 24)
        Me.txtQuoteValidDate.TabIndex = 4
        '
        'txtQuoteStatus
        '
        Me.txtQuoteStatus.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtQuoteStatus.Location = New System.Drawing.Point(638, 180)
        Me.txtQuoteStatus.MaxLength = 10
        Me.txtQuoteStatus.Name = "txtQuoteStatus"
        Me.txtQuoteStatus.ReadOnly = True
        Me.txtQuoteStatus.Size = New System.Drawing.Size(131, 24)
        Me.txtQuoteStatus.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(522, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Quote Status"
        '
        'txtQuoteDescription
        '
        Me.txtQuoteDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuoteDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuoteDescription.Location = New System.Drawing.Point(485, 301)
        Me.txtQuoteDescription.Multiline = True
        Me.txtQuoteDescription.Name = "txtQuoteDescription"
        Me.txtQuoteDescription.Size = New System.Drawing.Size(386, 104)
        Me.txtQuoteDescription.TabIndex = 7
        '
        'btnGenerateQuote
        '
        Me.btnGenerateQuote.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnGenerateQuote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateQuote.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateQuote.ForeColor = System.Drawing.Color.White
        Me.btnGenerateQuote.Location = New System.Drawing.Point(716, 406)
        Me.btnGenerateQuote.Name = "btnGenerateQuote"
        Me.btnGenerateQuote.Size = New System.Drawing.Size(146, 31)
        Me.btnGenerateQuote.TabIndex = 8
        Me.btnGenerateQuote.Text = "Generate Quote"
        Me.btnGenerateQuote.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGenerateQuote.UseVisualStyleBackColor = False
        '
        'cmbTemplate
        '
        Me.cmbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTemplate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTemplate.FormattingEnabled = True
        Me.cmbTemplate.Location = New System.Drawing.Point(155, 329)
        Me.cmbTemplate.Name = "cmbTemplate"
        Me.cmbTemplate.Size = New System.Drawing.Size(304, 29)
        Me.cmbTemplate.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(23, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 17)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Quote Template"
        '
        'cmbShipmentType
        '
        Me.cmbShipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShipmentType.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShipmentType.FormattingEnabled = True
        Me.cmbShipmentType.Location = New System.Drawing.Point(155, 298)
        Me.cmbShipmentType.Name = "cmbShipmentType"
        Me.cmbShipmentType.Size = New System.Drawing.Size(304, 33)
        Me.cmbShipmentType.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(29, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 17)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Shipment Type"
        '
        'lnkShowHistory
        '
        Me.lnkShowHistory.AutoSize = True
        Me.lnkShowHistory.LinkColor = System.Drawing.Color.Blue
        Me.lnkShowHistory.Location = New System.Drawing.Point(46, 805)
        Me.lnkShowHistory.Name = "lnkShowHistory"
        Me.lnkShowHistory.Size = New System.Drawing.Size(234, 17)
        Me.lnkShowHistory.TabIndex = 96
        Me.lnkShowHistory.TabStop = True
        Me.lnkShowHistory.Text = "View Quote History of this client"
        Me.lnkShowHistory.Visible = False
        '
        'lnkHideHistory
        '
        Me.lnkHideHistory.AutoSize = True
        Me.lnkHideHistory.LinkColor = System.Drawing.Color.Blue
        Me.lnkHideHistory.Location = New System.Drawing.Point(43, 805)
        Me.lnkHideHistory.Name = "lnkHideHistory"
        Me.lnkHideHistory.Size = New System.Drawing.Size(93, 17)
        Me.lnkHideHistory.TabIndex = 97
        Me.lnkHideHistory.TabStop = True
        Me.lnkHideHistory.Text = "Hide History"
        Me.lnkHideHistory.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
        Me.MonthCalendar1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(909, 144)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 98
        Me.MonthCalendar1.TitleBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MonthCalendar1.Visible = False
        '
        'txtClientCode
        '
        Me.txtClientCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtClientCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientCode.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtClientCode.Location = New System.Drawing.Point(12, 81)
        Me.txtClientCode.MaxLength = 4
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.ReadOnly = True
        Me.txtClientCode.Size = New System.Drawing.Size(63, 24)
        Me.txtClientCode.TabIndex = 111
        Me.txtClientCode.Text = "[Code]"
        Me.ToolTip1.SetToolTip(Me.txtClientCode, "Enter Client Number")
        '
        'btnClientList
        '
        Me.btnClientList.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClientList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientList.FlatAppearance.BorderSize = 0
        Me.btnClientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientList.ForeColor = System.Drawing.Color.White
        Me.btnClientList.Image = CType(resources.GetObject("btnClientList.Image"), System.Drawing.Image)
        Me.btnClientList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientList.Location = New System.Drawing.Point(434, 85)
        Me.btnClientList.Name = "btnClientList"
        Me.btnClientList.Size = New System.Drawing.Size(25, 21)
        Me.btnClientList.TabIndex = 1
        Me.btnClientList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnClientList, "List of Values")
        Me.btnClientList.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(265, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 38)
        Me.Button1.TabIndex = 105
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Button1, "List of Values")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 34)
        Me.Button2.TabIndex = 105
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Button2, "List of Values")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtClientName
        '
        Me.txtClientName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtClientName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientName.Location = New System.Drawing.Point(75, 81)
        Me.txtClientName.MaxLength = 10
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(355, 24)
        Me.txtClientName.TabIndex = 103
        Me.txtClientName.Text = "[FullName]"
        '
        'txtClientAddress1
        '
        Me.txtClientAddress1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtClientAddress1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientAddress1.Location = New System.Drawing.Point(75, 105)
        Me.txtClientAddress1.MaxLength = 10
        Me.txtClientAddress1.Multiline = True
        Me.txtClientAddress1.Name = "txtClientAddress1"
        Me.txtClientAddress1.ReadOnly = True
        Me.txtClientAddress1.Size = New System.Drawing.Size(355, 42)
        Me.txtClientAddress1.TabIndex = 105
        Me.txtClientAddress1.Text = "[Address1]"
        '
        'txtClientContactPerson1
        '
        Me.txtClientContactPerson1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtClientContactPerson1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientContactPerson1.Location = New System.Drawing.Point(75, 147)
        Me.txtClientContactPerson1.MaxLength = 10
        Me.txtClientContactPerson1.Name = "txtClientContactPerson1"
        Me.txtClientContactPerson1.ReadOnly = True
        Me.txtClientContactPerson1.Size = New System.Drawing.Size(355, 24)
        Me.txtClientContactPerson1.TabIndex = 107
        Me.txtClientContactPerson1.Text = "[Contact Person]"
        '
        'txtClientEmail1
        '
        Me.txtClientEmail1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtClientEmail1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientEmail1.Location = New System.Drawing.Point(75, 195)
        Me.txtClientEmail1.MaxLength = 10
        Me.txtClientEmail1.Name = "txtClientEmail1"
        Me.txtClientEmail1.ReadOnly = True
        Me.txtClientEmail1.Size = New System.Drawing.Size(355, 24)
        Me.txtClientEmail1.TabIndex = 108
        Me.txtClientEmail1.Text = "[Email]"
        '
        'cmbAttn
        '
        Me.cmbAttn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttn.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAttn.FormattingEnabled = True
        Me.cmbAttn.Items.AddRange(New Object() {"Attn. 1", "Attn. 2", "Attn. 3"})
        Me.cmbAttn.Location = New System.Drawing.Point(12, 144)
        Me.cmbAttn.Name = "cmbAttn"
        Me.cmbAttn.Size = New System.Drawing.Size(63, 26)
        Me.cmbAttn.TabIndex = 109
        '
        'txtContact1
        '
        Me.txtContact1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContact1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact1.Location = New System.Drawing.Point(75, 219)
        Me.txtContact1.MaxLength = 10
        Me.txtContact1.Name = "txtContact1"
        Me.txtContact1.ReadOnly = True
        Me.txtContact1.Size = New System.Drawing.Size(355, 24)
        Me.txtContact1.TabIndex = 110
        Me.txtContact1.Text = "[Contact1]"
        '
        'txtDepartment1
        '
        Me.txtDepartment1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDepartment1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment1.Location = New System.Drawing.Point(75, 171)
        Me.txtDepartment1.MaxLength = 10
        Me.txtDepartment1.Name = "txtDepartment1"
        Me.txtDepartment1.ReadOnly = True
        Me.txtDepartment1.Size = New System.Drawing.Size(355, 24)
        Me.txtDepartment1.TabIndex = 111
        Me.txtDepartment1.Text = "[Department]"
        '
        'lnkFileLocation
        '
        Me.lnkFileLocation.AutoSize = True
        Me.lnkFileLocation.BackColor = System.Drawing.Color.White
        Me.lnkFileLocation.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnkFileLocation.Location = New System.Drawing.Point(16, 727)
        Me.lnkFileLocation.Name = "lnkFileLocation"
        Me.lnkFileLocation.Size = New System.Drawing.Size(123, 17)
        Me.lnkFileLocation.TabIndex = 112
        Me.lnkFileLocation.TabStop = True
        Me.lnkFileLocation.Text = "Quotes Location"
        '
        'lblTemplateFile
        '
        Me.lblTemplateFile.AutoSize = True
        Me.lblTemplateFile.BackColor = System.Drawing.Color.Transparent
        Me.lblTemplateFile.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.lblTemplateFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTemplateFile.Location = New System.Drawing.Point(153, 369)
        Me.lblTemplateFile.Name = "lblTemplateFile"
        Me.lblTemplateFile.Size = New System.Drawing.Size(15, 14)
        Me.lblTemplateFile.TabIndex = 113
        Me.lblTemplateFile.Text = ".."
        '
        'PanelTip
        '
        Me.PanelTip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelTip.Controls.Add(Me.Button1)
        Me.PanelTip.Controls.Add(Me.Label10)
        Me.PanelTip.Location = New System.Drawing.Point(32, 759)
        Me.PanelTip.Name = "PanelTip"
        Me.PanelTip.Size = New System.Drawing.Size(306, 46)
        Me.PanelTip.TabIndex = 114
        Me.PanelTip.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(9, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(287, 17)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Start new Quote by selecting Customer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(11, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 29)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "1."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(495, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 29)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "2."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label14.ForeColor = System.Drawing.Color.DarkGray
        Me.Label14.Location = New System.Drawing.Point(12, 274)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 29)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "3."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label16.ForeColor = System.Drawing.Color.DarkGray
        Me.Label16.Location = New System.Drawing.Point(480, 274)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 29)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "4."
        '
        'btnAddNewQuote
        '
        Me.btnAddNewQuote.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddNewQuote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewQuote.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewQuote.ForeColor = System.Drawing.Color.White
        Me.btnAddNewQuote.Location = New System.Drawing.Point(693, 12)
        Me.btnAddNewQuote.Name = "btnAddNewQuote"
        Me.btnAddNewQuote.Size = New System.Drawing.Size(178, 31)
        Me.btnAddNewQuote.TabIndex = 119
        Me.btnAddNewQuote.Text = "Add Another New Quote"
        Me.btnAddNewQuote.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddNewQuote.UseVisualStyleBackColor = False
        Me.btnAddNewQuote.Visible = False
        '
        'PanelConfirmation
        '
        Me.PanelConfirmation.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.PanelConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelConfirmation.Controls.Add(Me.lblOpenQuote)
        Me.PanelConfirmation.Controls.Add(Me.Label17)
        Me.PanelConfirmation.Controls.Add(Me.Button2)
        Me.PanelConfirmation.Location = New System.Drawing.Point(344, 713)
        Me.PanelConfirmation.Name = "PanelConfirmation"
        Me.PanelConfirmation.Size = New System.Drawing.Size(518, 40)
        Me.PanelConfirmation.TabIndex = 120
        Me.PanelConfirmation.Visible = False
        '
        'lblOpenQuote
        '
        Me.lblOpenQuote.AutoSize = True
        Me.lblOpenQuote.LinkColor = System.Drawing.Color.Blue
        Me.lblOpenQuote.Location = New System.Drawing.Point(327, 16)
        Me.lblOpenQuote.Name = "lblOpenQuote"
        Me.lblOpenQuote.Size = New System.Drawing.Size(209, 17)
        Me.lblOpenQuote.TabIndex = 107
        Me.lblOpenQuote.TabStop = True
        Me.lblOpenQuote.Text = "Click here to open the quote"
        Me.lblOpenQuote.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label17.Location = New System.Drawing.Point(47, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(235, 17)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Quote Created Successfully..."
        '
        'lblCopyQuote
        '
        Me.lblCopyQuote.AutoSize = True
        Me.lblCopyQuote.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblCopyQuote.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCopyQuote.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCopyQuote.Location = New System.Drawing.Point(536, 30)
        Me.lblCopyQuote.Name = "lblCopyQuote"
        Me.lblCopyQuote.Size = New System.Drawing.Size(138, 17)
        Me.lblCopyQuote.TabIndex = 121
        Me.lblCopyQuote.Text = "Copy of Quote #"
        Me.lblCopyQuote.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtCurrency
        '
        Me.txtCurrency.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtCurrency.Location = New System.Drawing.Point(638, 156)
        Me.txtCurrency.MaxLength = 10
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(131, 24)
        Me.txtCurrency.TabIndex = 122
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Location = New System.Drawing.Point(552, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 17)
        Me.Label15.TabIndex = 123
        Me.Label15.Text = "Currency"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 27)
        Me.Panel1.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Customer"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Location = New System.Drawing.Point(485, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(386, 27)
        Me.Panel3.TabIndex = 125
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(7, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 18)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Quote Header"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(485, 251)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(386, 27)
        Me.Panel4.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 18)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Quote / Project Description"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(12, 251)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(447, 27)
        Me.Panel5.TabIndex = 127
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 18)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Shipment Type"
        '
        'qmsAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 759)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCurrency)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblCopyQuote)
        Me.Controls.Add(Me.PanelConfirmation)
        Me.Controls.Add(Me.btnAddNewQuote)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PanelTip)
        Me.Controls.Add(Me.lblTemplateFile)
        Me.Controls.Add(Me.lnkFileLocation)
        Me.Controls.Add(Me.txtDepartment1)
        Me.Controls.Add(Me.txtContact1)
        Me.Controls.Add(Me.cmbAttn)
        Me.Controls.Add(Me.txtClientEmail1)
        Me.Controls.Add(Me.txtClientContactPerson1)
        Me.Controls.Add(Me.txtClientAddress1)
        Me.Controls.Add(Me.btnClientList)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.txtClientCode)
        Me.Controls.Add(Me.btnGenerateQuote)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbTemplate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbShipmentType)
        Me.Controls.Add(Me.txtQuoteDescription)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuoteStatus)
        Me.Controls.Add(Me.txtQuoteDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuoteValidDate)
        Me.Controls.Add(Me.txtQuoteNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lnkHideHistory)
        Me.Controls.Add(Me.lnkShowHistory)
        Me.Controls.Add(Me.lblAccountCode)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "qmsAddForm"
        Me.Text = "Add New Quote"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.PanelTip.ResumeLayout(False)
        Me.PanelTip.PerformLayout()
        Me.PanelConfirmation.ResumeLayout(False)
        Me.PanelConfirmation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccountCode As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtQuoteNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQuoteDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtQuoteValidDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtQuoteDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtQuoteStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbShipmentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lblQuoteHistory As System.Windows.Forms.Label
    Friend WithEvents btnGenerateQuote As System.Windows.Forms.Button
    Friend WithEvents lnkShowHistory As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkHideHistory As System.Windows.Forms.LinkLabel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents txtClientCode As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents btnClientList As System.Windows.Forms.Button
    Friend WithEvents txtClientAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtClientContactPerson1 As System.Windows.Forms.TextBox
    Friend WithEvents txtClientEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbAttn As System.Windows.Forms.ComboBox
    Friend WithEvents txtContact1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment1 As System.Windows.Forms.TextBox
    Friend WithEvents lnkFileLocation As System.Windows.Forms.LinkLabel
    Friend WithEvents lblTemplateFile As System.Windows.Forms.Label
    Friend WithEvents PanelTip As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnAddNewQuote As System.Windows.Forms.Button
    Friend WithEvents PanelConfirmation As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblOpenQuote As System.Windows.Forms.LinkLabel
    Friend WithEvents DGView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblCopyQuote As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtCurrency As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
