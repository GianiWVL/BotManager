Namespace UserInterface.Download
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Main
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpInformation = New System.Windows.Forms.GroupBox()
        Me.lblUpToDate = New System.Windows.Forms.Label()
        Me.lblProductVersion = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpInformation.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = true
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(607, 393)
        Me.DataGridView1.TabIndex = 0
        '
        'grpInformation
        '
        Me.grpInformation.Controls.Add(Me.lblUpToDate)
        Me.grpInformation.Controls.Add(Me.lblProductVersion)
        Me.grpInformation.Location = New System.Drawing.Point(14, 27)
        Me.grpInformation.Name = "grpInformation"
        Me.grpInformation.Size = New System.Drawing.Size(189, 68)
        Me.grpInformation.TabIndex = 1
        Me.grpInformation.TabStop = false
        Me.grpInformation.Text = "Info"
        '
        'lblUpToDate
        '
        Me.lblUpToDate.AutoSize = true
        Me.lblUpToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblUpToDate.ForeColor = System.Drawing.Color.Green
        Me.lblUpToDate.Location = New System.Drawing.Point(4, 43)
        Me.lblUpToDate.Name = "lblUpToDate"
        Me.lblUpToDate.Size = New System.Drawing.Size(116, 16)
        Me.lblUpToDate.TabIndex = 1
        Me.lblUpToDate.Text = "Newest Version"
        '
        'lblProductVersion
        '
        Me.lblProductVersion.AutoSize = true
        Me.lblProductVersion.Location = New System.Drawing.Point(6, 18)
        Me.lblProductVersion.Name = "lblProductVersion"
        Me.lblProductVersion.Size = New System.Drawing.Size(114, 16)
        Me.lblProductVersion.TabIndex = 0
        Me.lblProductVersion.Text = "lblProductVersion"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(633, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 519)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpInformation)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "Main"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Manager"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpInformation.ResumeLayout(false)
        Me.grpInformation.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents DataGridView1 As DataGridView
        Friend WithEvents grpInformation As GroupBox
        Friend WithEvents lblUpToDate As Label
        Friend WithEvents lblProductVersion As Label
        Friend WithEvents StatusStrip1 As StatusStrip
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    End Class
End NameSpace