Imports MetroFramework.Controls

Namespace UserInterface
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Main
        Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MetroListView1 = New MetroFramework.Controls.MetroListView()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.selectedOptionsGroup = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnStop = New MetroFramework.Controls.MetroButton()
        Me.btnRestart = New MetroFramework.Controls.MetroButton()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.showPokemon = New MetroFramework.Controls.MetroToggle()
        Me.showExp = New MetroFramework.Controls.MetroToggle()
        Me.showLvl = New MetroFramework.Controls.MetroToggle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.botSelectBox = New MetroFramework.Controls.MetroComboBox()
        Me.batchOptionsGroup = New System.Windows.Forms.GroupBox()
        Me.btnRemoveAll = New MetroFramework.Controls.MetroButton()
        Me.btnStartAll = New MetroFramework.Controls.MetroButton()
        Me.btnStopAll = New MetroFramework.Controls.MetroButton()
        Me.btnRestartAll = New MetroFramework.Controls.MetroButton()
        Me.donationGroup = New System.Windows.Forms.GroupBox()
        Me.paypalLabel = New System.Windows.Forms.LinkLabel()
        Me.repLabel = New System.Windows.Forms.LinkLabel()
        CType(Me.MetroStyleManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.MetroTabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.MetroTabControl2.SuspendLayout
        Me.TabPage5.SuspendLayout
        Me.selectedOptionsGroup.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.batchOptionsGroup.SuspendLayout
        Me.donationGroup.SuspendLayout
        Me.SuspendLayout
        '
        'Timer
        '
        Me.Timer.Enabled = true
        Me.Timer.Interval = 500
        '
        'BackgroundWorker
        '
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 60)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MetroListView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MetroTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1102, 502)
        Me.SplitContainer1.SplitterDistance = 367
        Me.SplitContainer1.TabIndex = 27
        '
        'MetroListView1
        '
        Me.MetroListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroListView1.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.MetroListView1.FullRowSelect = true
        Me.MetroListView1.Location = New System.Drawing.Point(0, 0)
        Me.MetroListView1.Name = "MetroListView1"
        Me.MetroListView1.OwnerDraw = true
        Me.MetroListView1.Size = New System.Drawing.Size(367, 502)
        Me.MetroListView1.TabIndex = 0
        Me.MetroListView1.UseCompatibleStateImageBehavior = false
        Me.MetroListView1.UseSelectable = true
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Controls.Add(Me.TabPage3)
        Me.MetroTabControl1.Controls.Add(Me.TabPage4)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(731, 502)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = true
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MetroTabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(723, 460)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Selected Bot"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(723, 460)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Batch Operation"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(723, 460)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Updates"
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(723, 460)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Settings"
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Controls.Add(Me.TabPage5)
        Me.MetroTabControl2.Controls.Add(Me.TabPage6)
        Me.MetroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(723, 460)
        Me.MetroTabControl2.TabIndex = 0
        Me.MetroTabControl2.UseSelectable = true
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.selectedOptionsGroup)
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Controls.Add(Me.batchOptionsGroup)
        Me.TabPage5.Controls.Add(Me.donationGroup)
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(715, 418)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "View"
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(715, 418)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Settings"
        '
        'selectedOptionsGroup
        '
        Me.selectedOptionsGroup.Controls.Add(Me.btnEdit)
        Me.selectedOptionsGroup.Controls.Add(Me.btnStop)
        Me.selectedOptionsGroup.Controls.Add(Me.btnRestart)
        Me.selectedOptionsGroup.Controls.Add(Me.btnRemove)
        Me.selectedOptionsGroup.Location = New System.Drawing.Point(208, 100)
        Me.selectedOptionsGroup.Name = "selectedOptionsGroup"
        Me.selectedOptionsGroup.Size = New System.Drawing.Size(293, 54)
        Me.selectedOptionsGroup.TabIndex = 32
        Me.selectedOptionsGroup.TabStop = false
        Me.selectedOptionsGroup.Text = "Selected Bot Operations"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(6, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(65, 25)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseSelectable = true
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(77, 19)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(65, 25)
        Me.btnStop.TabIndex = 15
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseSelectable = true
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(148, 19)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(65, 25)
        Me.btnRestart.TabIndex = 11
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseSelectable = true
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(219, 19)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(65, 25)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseSelectable = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.showPokemon)
        Me.GroupBox2.Controls.Add(Me.showExp)
        Me.GroupBox2.Controls.Add(Me.showLvl)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 340)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 54)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Info to show"
        '
        'showPokemon
        '
        Me.showPokemon.AutoSize = true
        Me.showPokemon.Location = New System.Drawing.Point(131, 23)
        Me.showPokemon.Name = "showPokemon"
        Me.showPokemon.Size = New System.Drawing.Size(80, 17)
        Me.showPokemon.TabIndex = 2
        Me.showPokemon.Text = "Off"
        Me.showPokemon.UseSelectable = true
        '
        'showExp
        '
        Me.showExp.AutoSize = true
        Me.showExp.Location = New System.Drawing.Point(57, 23)
        Me.showExp.Name = "showExp"
        Me.showExp.Size = New System.Drawing.Size(80, 17)
        Me.showExp.TabIndex = 1
        Me.showExp.Text = "Off"
        Me.showExp.UseSelectable = true
        '
        'showLvl
        '
        Me.showLvl.AutoSize = true
        Me.showLvl.Location = New System.Drawing.Point(6, 21)
        Me.showLvl.Name = "showLvl"
        Me.showLvl.Size = New System.Drawing.Size(80, 17)
        Me.showLvl.TabIndex = 0
        Me.showLvl.Text = "Off"
        Me.showLvl.UseSelectable = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.botSelectBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 54)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Select Type"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(614, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 25)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseSelectable = true
        '
        'botSelectBox
        '
        Me.botSelectBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.botSelectBox.DisplayMember = "1"
        Me.botSelectBox.FormattingEnabled = true
        Me.botSelectBox.ItemHeight = 23
        Me.botSelectBox.Location = New System.Drawing.Point(472, 15)
        Me.botSelectBox.Name = "botSelectBox"
        Me.botSelectBox.Size = New System.Drawing.Size(136, 29)
        Me.botSelectBox.TabIndex = 10
        Me.botSelectBox.UseSelectable = true
        '
        'batchOptionsGroup
        '
        Me.batchOptionsGroup.Controls.Add(Me.btnRemoveAll)
        Me.batchOptionsGroup.Controls.Add(Me.btnStartAll)
        Me.batchOptionsGroup.Controls.Add(Me.btnStopAll)
        Me.batchOptionsGroup.Controls.Add(Me.btnRestartAll)
        Me.batchOptionsGroup.Location = New System.Drawing.Point(208, 160)
        Me.batchOptionsGroup.Name = "batchOptionsGroup"
        Me.batchOptionsGroup.Size = New System.Drawing.Size(299, 54)
        Me.batchOptionsGroup.TabIndex = 34
        Me.batchOptionsGroup.TabStop = false
        Me.batchOptionsGroup.Text = "Batch Operations"
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRemoveAll.Location = New System.Drawing.Point(219, 19)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(65, 25)
        Me.btnRemoveAll.TabIndex = 23
        Me.btnRemoveAll.Text = "Remove"
        Me.btnRemoveAll.UseSelectable = true
        '
        'btnStartAll
        '
        Me.btnStartAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnStartAll.Location = New System.Drawing.Point(6, 19)
        Me.btnStartAll.Name = "btnStartAll"
        Me.btnStartAll.Size = New System.Drawing.Size(65, 25)
        Me.btnStartAll.TabIndex = 22
        Me.btnStartAll.Text = "Start"
        Me.btnStartAll.UseSelectable = true
        '
        'btnStopAll
        '
        Me.btnStopAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnStopAll.Location = New System.Drawing.Point(77, 19)
        Me.btnStopAll.Name = "btnStopAll"
        Me.btnStopAll.Size = New System.Drawing.Size(65, 25)
        Me.btnStopAll.TabIndex = 20
        Me.btnStopAll.Text = "Stop"
        Me.btnStopAll.UseSelectable = true
        '
        'btnRestartAll
        '
        Me.btnRestartAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRestartAll.Location = New System.Drawing.Point(148, 19)
        Me.btnRestartAll.Name = "btnRestartAll"
        Me.btnRestartAll.Size = New System.Drawing.Size(65, 25)
        Me.btnRestartAll.TabIndex = 21
        Me.btnRestartAll.Text = "Restart"
        Me.btnRestartAll.UseSelectable = true
        '
        'donationGroup
        '
        Me.donationGroup.Controls.Add(Me.paypalLabel)
        Me.donationGroup.Controls.Add(Me.repLabel)
        Me.donationGroup.Location = New System.Drawing.Point(208, 280)
        Me.donationGroup.Name = "donationGroup"
        Me.donationGroup.Size = New System.Drawing.Size(155, 54)
        Me.donationGroup.TabIndex = 35
        Me.donationGroup.TabStop = false
        Me.donationGroup.Text = "Help Developer"
        '
        'paypalLabel
        '
        Me.paypalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.paypalLabel.AutoSize = true
        Me.paypalLabel.Location = New System.Drawing.Point(51, 25)
        Me.paypalLabel.Name = "paypalLabel"
        Me.paypalLabel.Size = New System.Drawing.Size(95, 13)
        Me.paypalLabel.TabIndex = 13
        Me.paypalLabel.TabStop = true
        Me.paypalLabel.Text = "Donate via PayPal"
        '
        'repLabel
        '
        Me.repLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.repLabel.AutoSize = true
        Me.repLabel.Location = New System.Drawing.Point(6, 25)
        Me.repLabel.Name = "repLabel"
        Me.repLabel.Size = New System.Drawing.Size(35, 13)
        Me.repLabel.TabIndex = 12
        Me.repLabel.TabStop = true
        Me.repLabel.Text = "Help?"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 582)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Main"
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Pokemon Go Bot Manager"
        CType(Me.MetroStyleManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.MetroTabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.MetroTabControl2.ResumeLayout(false)
        Me.TabPage5.ResumeLayout(false)
        Me.selectedOptionsGroup.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.batchOptionsGroup.ResumeLayout(false)
        Me.donationGroup.ResumeLayout(false)
        Me.donationGroup.PerformLayout
        Me.ResumeLayout(false)

End Sub
        Friend WithEvents Timer As Timer
        Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
        Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
        Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents MetroTabControl1 As MetroTabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents TabPage4 As TabPage
        Friend WithEvents MetroListView1 As MetroListView
        Friend WithEvents MetroTabControl2 As MetroTabControl
        Friend WithEvents TabPage5 As TabPage
        Friend WithEvents selectedOptionsGroup As GroupBox
        Friend WithEvents btnEdit As MetroButton
        Friend WithEvents btnStop As MetroButton
        Friend WithEvents btnRestart As MetroButton
        Friend WithEvents btnRemove As MetroButton
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents showPokemon As MetroToggle
        Friend WithEvents showExp As MetroToggle
        Friend WithEvents showLvl As MetroToggle
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents btnAdd As MetroButton
        Friend WithEvents botSelectBox As MetroComboBox
        Friend WithEvents batchOptionsGroup As GroupBox
        Friend WithEvents btnRemoveAll As MetroButton
        Friend WithEvents btnStartAll As MetroButton
        Friend WithEvents btnStopAll As MetroButton
        Friend WithEvents btnRestartAll As MetroButton
        Friend WithEvents donationGroup As GroupBox
        Friend WithEvents paypalLabel As LinkLabel
        Friend WithEvents repLabel As LinkLabel
        Friend WithEvents TabPage6 As TabPage
    End Class
End NameSpace