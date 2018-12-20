<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qmsListOfValues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qmsListOfValues))
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.lblMsg = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnRun = New System.Windows.Forms.Button
        Me.txtSearchValue = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.DGView1 = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel10.SuspendLayout()
        CType(Me.DGView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel10.Controls.Add(Me.lblMsg)
        Me.Panel10.Controls.Add(Me.btnSelect)
        Me.Panel10.Controls.Add(Me.btnRun)
        Me.Panel10.Controls.Add(Me.txtSearchValue)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(747, 59)
        Me.Panel10.TabIndex = 84
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.lblMsg.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMsg.Location = New System.Drawing.Point(205, 46)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(17, 12)
        Me.lblMsg.TabIndex = 88
        Me.lblMsg.Text = "..."
        '
        'btnSelect
        '
        Me.btnSelect.AutoSize = True
        Me.btnSelect.BackColor = System.Drawing.Color.Transparent
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSelect.Location = New System.Drawing.Point(696, 10)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(39, 38)
        Me.btnSelect.TabIndex = 87
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSelect, "Select")
        Me.btnSelect.UseVisualStyleBackColor = False
        Me.btnSelect.Visible = False
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
        Me.btnRun.Location = New System.Drawing.Point(469, 15)
        Me.btnRun.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(39, 38)
        Me.btnRun.TabIndex = 86
        Me.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnRun, "Click to search")
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'txtSearchValue
        '
        Me.txtSearchValue.Location = New System.Drawing.Point(207, 22)
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.Size = New System.Drawing.Size(256, 21)
        Me.txtSearchValue.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.txtSearchValue, "Enter search value")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(9, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(192, 14)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Search by Customer Name -"
        '
        'DGView1
        '
        Me.DGView1.AllowUserToAddRows = False
        Me.DGView1.AllowUserToDeleteRows = False
        Me.DGView1.AllowUserToOrderColumns = True
        Me.DGView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGView1.Location = New System.Drawing.Point(0, 59)
        Me.DGView1.MultiSelect = False
        Me.DGView1.Name = "DGView1"
        Me.DGView1.ReadOnly = True
        Me.DGView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGView1.Size = New System.Drawing.Size(747, 298)
        Me.DGView1.TabIndex = 85
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'qmsListOfValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 357)
        Me.Controls.Add(Me.DGView1)
        Me.Controls.Add(Me.Panel10)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "qmsListOfValues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer List"
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.DGView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSearchValue As System.Windows.Forms.TextBox
    Friend WithEvents DGView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
End Class
