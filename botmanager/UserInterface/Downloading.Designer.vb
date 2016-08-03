Namespace UserInterface
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Downloading
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
        Me.downloadProgress = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.downloadLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'downloadProgress
        '
        Me.downloadProgress.Location = New System.Drawing.Point(11, 30)
        Me.downloadProgress.Name = "downloadProgress"
        Me.downloadProgress.Size = New System.Drawing.Size(258, 16)
        Me.downloadProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.downloadProgress.TabIndex = 1
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = true
        '
        'downloadLabel
        '
        Me.downloadLabel.AutoSize = true
        Me.downloadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.downloadLabel.Location = New System.Drawing.Point(8, 9)
        Me.downloadLabel.Name = "downloadLabel"
        Me.downloadLabel.Size = New System.Drawing.Size(142, 18)
        Me.downloadLabel.TabIndex = 0
        Me.downloadLabel.Text = "Get Latest Version ?"
        '
        'Downloading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 53)
        Me.Controls.Add(Me.downloadLabel)
        Me.Controls.Add(Me.downloadProgress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(296, 92)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(296, 69)
        Me.Name = "Downloading"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Manager"
        Me.TopMost = true
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents downloadProgress As ProgressBar
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents downloadLabel As Label
    End Class
End NameSpace