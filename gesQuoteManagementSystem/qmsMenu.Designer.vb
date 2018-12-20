<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qmsMenu
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qmsMenu))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.QMSFolderSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CreateNewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblWelcome = New System.Windows.Forms.Label
        Me.lblCoName = New System.Windows.Forms.Label
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 770)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1785, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ToolsMenu, Me.ClientMenu, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1785, 40)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.FileMenu.Image = CType(resources.GetObject("FileMenu.Image"), System.Drawing.Image)
        Me.FileMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileMenu.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(143, 36)
        Me.FileMenu.Text = "&New Quote"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolsMenu.Image = CType(resources.GetObject("ToolsMenu.Image"), System.Drawing.Image)
        Me.ToolsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(174, 36)
        Me.ToolsMenu.Text = "&Quote Explorer"
        Me.ToolsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClientMenu
        '
        Me.ClientMenu.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ClientMenu.Image = CType(resources.GetObject("ClientMenu.Image"), System.Drawing.Image)
        Me.ClientMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientMenu.Name = "ClientMenu"
        Me.ClientMenu.Size = New System.Drawing.Size(130, 36)
        Me.ClientMenu.Text = "&Customer"
        Me.ClientMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.ToolStripMenuItem4})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(204, 36)
        Me.ToolStripMenuItem2.Text = "Setup Master Files"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripMenuItem3.Text = "Manage Rates"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(220, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripMenuItem4.Text = "Create New Users"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QMSFolderSettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.CreateNewUsersToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 36)
        Me.ToolStripMenuItem1.Text = "&Admin"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QMSFolderSettingsToolStripMenuItem
        '
        Me.QMSFolderSettingsToolStripMenuItem.Image = CType(resources.GetObject("QMSFolderSettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QMSFolderSettingsToolStripMenuItem.Name = "QMSFolderSettingsToolStripMenuItem"
        Me.QMSFolderSettingsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.QMSFolderSettingsToolStripMenuItem.Text = "QMS Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'CreateNewUsersToolStripMenuItem
        '
        Me.CreateNewUsersToolStripMenuItem.Image = CType(resources.GetObject("CreateNewUsersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateNewUsersToolStripMenuItem.Name = "CreateNewUsersToolStripMenuItem"
        Me.CreateNewUsersToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CreateNewUsersToolStripMenuItem.Text = "Create New Users"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Blue
        Me.lblWelcome.Location = New System.Drawing.Point(1212, 22)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(289, 18)
        Me.lblWelcome.TabIndex = 10
        Me.lblWelcome.Text = "Logged user - <user_name>"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCoName
        '
        Me.lblCoName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCoName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblCoName.Location = New System.Drawing.Point(1212, 4)
        Me.lblCoName.Name = "lblCoName"
        Me.lblCoName.Size = New System.Drawing.Size(289, 18)
        Me.lblCoName.TabIndex = 12
        Me.lblCoName.Text = "<Company Name>"
        Me.lblCoName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'qmsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1785, 792)
        Me.Controls.Add(Me.lblCoName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "qmsMenu"
        Me.Text = "Quote Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QMSFolderSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCoName As System.Windows.Forms.Label

End Class
