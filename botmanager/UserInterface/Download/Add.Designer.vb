Namespace UserInterface.Download
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Add
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDownloadUrl = New System.Windows.Forms.TextBox()
        Me.txtExecutablePath = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpReaderType = New System.Windows.Forms.GroupBox()
        Me.rbUserSettings = New System.Windows.Forms.RadioButton()
        Me.rbAppSetting = New System.Windows.Forms.RadioButton()
        Me.rbXmlSetting = New System.Windows.Forms.RadioButton()
        Me.rbJsonSetting = New System.Windows.Forms.RadioButton()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ckAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbConfigPaths = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpReaderType.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Download Url:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Executable Path:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(6, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Config Path(s):"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name:"
        '
        'txtDownloadUrl
        '
        Me.txtDownloadUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDownloadUrl.Location = New System.Drawing.Point(130, 53)
        Me.txtDownloadUrl.Name = "txtDownloadUrl"
        Me.txtDownloadUrl.Size = New System.Drawing.Size(332, 22)
        Me.txtDownloadUrl.TabIndex = 5
        '
        'txtExecutablePath
        '
        Me.txtExecutablePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtExecutablePath.Location = New System.Drawing.Point(130, 81)
        Me.txtExecutablePath.Name = "txtExecutablePath"
        Me.txtExecutablePath.Size = New System.Drawing.Size(332, 22)
        Me.txtExecutablePath.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(130, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(332, 22)
        Me.txtName.TabIndex = 9
        '
        'grpReaderType
        '
        Me.grpReaderType.Controls.Add(Me.rbUserSettings)
        Me.grpReaderType.Controls.Add(Me.rbAppSetting)
        Me.grpReaderType.Controls.Add(Me.rbXmlSetting)
        Me.grpReaderType.Controls.Add(Me.rbJsonSetting)
        Me.grpReaderType.Location = New System.Drawing.Point(12, 200)
        Me.grpReaderType.Name = "grpReaderType"
        Me.grpReaderType.Size = New System.Drawing.Size(266, 74)
        Me.grpReaderType.TabIndex = 10
        Me.grpReaderType.TabStop = false
        Me.grpReaderType.Text = "Reader Type"
        '
        'rbUserSettings
        '
        Me.rbUserSettings.AutoSize = true
        Me.rbUserSettings.Location = New System.Drawing.Point(141, 19)
        Me.rbUserSettings.Name = "rbUserSettings"
        Me.rbUserSettings.Size = New System.Drawing.Size(106, 20)
        Me.rbUserSettings.TabIndex = 3
        Me.rbUserSettings.TabStop = true
        Me.rbUserSettings.Tag = "1"
        Me.rbUserSettings.Text = "User Settings"
        Me.rbUserSettings.UseVisualStyleBackColor = true
        '
        'rbAppSetting
        '
        Me.rbAppSetting.AutoSize = true
        Me.rbAppSetting.Location = New System.Drawing.Point(20, 45)
        Me.rbAppSetting.Name = "rbAppSetting"
        Me.rbAppSetting.Size = New System.Drawing.Size(102, 20)
        Me.rbAppSetting.TabIndex = 2
        Me.rbAppSetting.TabStop = true
        Me.rbAppSetting.Tag = "2"
        Me.rbAppSetting.Text = "App Settings"
        Me.rbAppSetting.UseVisualStyleBackColor = true
        '
        'rbXmlSetting
        '
        Me.rbXmlSetting.AutoSize = true
        Me.rbXmlSetting.Location = New System.Drawing.Point(141, 45)
        Me.rbXmlSetting.Name = "rbXmlSetting"
        Me.rbXmlSetting.Size = New System.Drawing.Size(48, 20)
        Me.rbXmlSetting.TabIndex = 1
        Me.rbXmlSetting.TabStop = true
        Me.rbXmlSetting.Tag = "3"
        Me.rbXmlSetting.Text = "Xml"
        Me.rbXmlSetting.UseVisualStyleBackColor = true
        '
        'rbJsonSetting
        '
        Me.rbJsonSetting.AutoSize = true
        Me.rbJsonSetting.Location = New System.Drawing.Point(20, 19)
        Me.rbJsonSetting.Name = "rbJsonSetting"
        Me.rbJsonSetting.Size = New System.Drawing.Size(55, 20)
        Me.rbJsonSetting.TabIndex = 0
        Me.rbJsonSetting.TabStop = true
        Me.rbJsonSetting.Tag = "0"
        Me.rbJsonSetting.Text = "Json"
        Me.rbJsonSetting.UseVisualStyleBackColor = true
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAccept.Location = New System.Drawing.Point(310, 245)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 26)
        Me.btnAccept.TabIndex = 11
        Me.btnAccept.Text = "Apply"
        Me.btnAccept.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(391, 245)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'ckAutoUpdate
        '
        Me.ckAutoUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ckAutoUpdate.AutoSize = true
        Me.ckAutoUpdate.Location = New System.Drawing.Point(333, 210)
        Me.ckAutoUpdate.Name = "ckAutoUpdate"
        Me.ckAutoUpdate.Size = New System.Drawing.Size(102, 20)
        Me.ckAutoUpdate.TabIndex = 13
        Me.ckAutoUpdate.Text = "Auto Update"
        Me.ckAutoUpdate.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lbConfigPaths)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDownloadUrl)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtExecutablePath)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 182)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Shit"
        '
        'lbConfigPaths
        '
        Me.lbConfigPaths.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbConfigPaths.FormattingEnabled = true
        Me.lbConfigPaths.ItemHeight = 16
        Me.lbConfigPaths.Location = New System.Drawing.Point(130, 137)
        Me.lbConfigPaths.Name = "lbConfigPaths"
        Me.lbConfigPaths.Size = New System.Drawing.Size(332, 36)
        Me.lbConfigPaths.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Instance Directory:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(130, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(332, 22)
        Me.TextBox1.TabIndex = 12
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 283)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ckAutoUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.grpReaderType)
        Me.Name = "Add"
        Me.Text = "Add"
        Me.grpReaderType.ResumeLayout(false)
        Me.grpReaderType.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents txtDownloadUrl As TextBox
        Friend WithEvents txtExecutablePath As TextBox
        Friend WithEvents txtName As TextBox
        Friend WithEvents grpReaderType As GroupBox
        Friend WithEvents rbUserSettings As RadioButton
        Friend WithEvents rbAppSetting As RadioButton
        Friend WithEvents rbXmlSetting As RadioButton
        Friend WithEvents rbJsonSetting As RadioButton
        Friend WithEvents btnAccept As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents ckAutoUpdate As CheckBox
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents lbConfigPaths As ListBox
        Friend WithEvents Label4 As Label
        Friend WithEvents TextBox1 As TextBox
    End Class
End NameSpace