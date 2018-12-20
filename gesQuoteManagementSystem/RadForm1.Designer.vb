<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox
        Me.RadWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel
        Me.RadPdfViewer1 = New Telerik.WinControls.UI.RadPdfViewer
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(229, 273)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "RadButton1"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(485, 83)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(236, 20)
        Me.RadTextBox1.TabIndex = 2
        '
        'RadWaitingBar1
        '
        Me.RadWaitingBar1.Location = New System.Drawing.Point(173, 359)
        Me.RadWaitingBar1.Name = "RadWaitingBar1"
        Me.RadWaitingBar1.Size = New System.Drawing.Size(130, 24)
        Me.RadWaitingBar1.TabIndex = 3
        Me.RadWaitingBar1.Text = "RadWaitingBar1"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RadPanel1.Location = New System.Drawing.Point(243, 57)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(200, 100)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.Text = "RadPanel1"
        '
        'RadPdfViewer1
        '
        Me.RadPdfViewer1.Location = New System.Drawing.Point(373, 187)
        Me.RadPdfViewer1.Name = "RadPdfViewer1"
        Me.RadPdfViewer1.Size = New System.Drawing.Size(430, 552)
        Me.RadPdfViewer1.TabIndex = 4
        Me.RadPdfViewer1.Text = "RadPdfViewer1"
        Me.RadPdfViewer1.ThumbnailsScaleFactor = 0.15!
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(485, 146)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(110, 24)
        Me.RadButton2.TabIndex = 5
        Me.RadButton2.Text = "Upload File"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Location = New System.Drawing.Point(485, 57)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(348, 20)
        Me.RadTextBox2.TabIndex = 6
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 783)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadPdfViewer1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadWaitingBar1)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
End Class

