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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pokemonLabel = New MetroFramework.Controls.MetroLabel()
        Me.lvlLabel = New MetroFramework.Controls.MetroLabel()
        Me.showLvl = New MetroFramework.Controls.MetroToggle()
        Me.xpLabel = New MetroFramework.Controls.MetroLabel()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.showExp = New MetroFramework.Controls.MetroToggle()
        Me.showPokemon = New MetroFramework.Controls.MetroToggle()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.btnRestart = New MetroFramework.Controls.MetroButton()
        Me.botTree = New MetroFramework.Controls.MetroListView()
        Me.btnStop = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.selectedBotTab = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Key = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batchConfigTab = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl4 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroGrid3 = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botUpdateTab = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl3 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.botSelect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.globalSettingsTab = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        CType(Me.MetroStyleManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.MetroTabControl1.SuspendLayout
        Me.selectedBotTab.SuspendLayout
        Me.MetroTabControl2.SuspendLayout
        Me.TabPage6.SuspendLayout
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.batchConfigTab.SuspendLayout
        Me.MetroTabControl4.SuspendLayout
        CType(Me.MetroGrid3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.botUpdateTab.SuspendLayout
        Me.MetroTabControl3.SuspendLayout
        CType(Me.MetroGrid2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.globalSettingsTab.SuspendLayout
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.pokemonLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvlLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.showLvl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.xpLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.showExp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.showPokemon)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRemove)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRestart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.botTree)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnStop)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MetroTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1103, 502)
        Me.SplitContainer1.SplitterDistance = 367
        Me.SplitContainer1.TabIndex = 27
        '
        'pokemonLabel
        '
        Me.pokemonLabel.AutoSize = true
        Me.pokemonLabel.Location = New System.Drawing.Point(259, 475)
        Me.pokemonLabel.Name = "pokemonLabel"
        Me.pokemonLabel.Size = New System.Drawing.Size(31, 19)
        Me.pokemonLabel.TabIndex = 23
        Me.pokemonLabel.Text = "P/H"
        '
        'lvlLabel
        '
        Me.lvlLabel.AutoSize = true
        Me.lvlLabel.Location = New System.Drawing.Point(143, 475)
        Me.lvlLabel.Name = "lvlLabel"
        Me.lvlLabel.Size = New System.Drawing.Size(28, 19)
        Me.lvlLabel.TabIndex = 22
        Me.lvlLabel.Text = "LVL"
        '
        'showLvl
        '
        Me.showLvl.AutoSize = true
        Me.showLvl.DisplayStatus = false
        Me.showLvl.Location = New System.Drawing.Point(178, 477)
        Me.showLvl.Name = "showLvl"
        Me.showLvl.Size = New System.Drawing.Size(50, 17)
        Me.showLvl.TabIndex = 0
        Me.showLvl.Text = "Off"
        Me.showLvl.UseSelectable = true
        '
        'xpLabel
        '
        Me.xpLabel.AutoSize = true
        Me.xpLabel.Location = New System.Drawing.Point(15, 475)
        Me.xpLabel.Name = "xpLabel"
        Me.xpLabel.Size = New System.Drawing.Size(45, 19)
        Me.xpLabel.TabIndex = 21
        Me.xpLabel.Text = "XP/Hr."
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(15, 437)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 25)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseSelectable = true
        '
        'showExp
        '
        Me.showExp.AutoSize = true
        Me.showExp.DisplayStatus = false
        Me.showExp.Location = New System.Drawing.Point(68, 477)
        Me.showExp.Name = "showExp"
        Me.showExp.Size = New System.Drawing.Size(50, 17)
        Me.showExp.TabIndex = 1
        Me.showExp.Text = "Off"
        Me.showExp.UseSelectable = true
        '
        'showPokemon
        '
        Me.showPokemon.AutoSize = true
        Me.showPokemon.DisplayStatus = false
        Me.showPokemon.Location = New System.Drawing.Point(296, 477)
        Me.showPokemon.Name = "showPokemon"
        Me.showPokemon.Size = New System.Drawing.Size(50, 17)
        Me.showPokemon.TabIndex = 2
        Me.showPokemon.Text = "Off"
        Me.showPokemon.UseSelectable = true
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(177, 437)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 25)
        Me.btnRemove.TabIndex = 16
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseSelectable = true
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(258, 437)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(88, 25)
        Me.btnRestart.TabIndex = 20
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseSelectable = true
        '
        'botTree
        '
        Me.botTree.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.botTree.FullRowSelect = true
        Me.botTree.Location = New System.Drawing.Point(0, 0)
        Me.botTree.Name = "botTree"
        Me.botTree.OwnerDraw = true
        Me.botTree.Size = New System.Drawing.Size(367, 431)
        Me.botTree.TabIndex = 0
        Me.botTree.UseCompatibleStateImageBehavior = false
        Me.botTree.UseSelectable = true
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(96, 437)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 25)
        Me.btnStop.TabIndex = 19
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseSelectable = true
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.selectedBotTab)
        Me.MetroTabControl1.Controls.Add(Me.batchConfigTab)
        Me.MetroTabControl1.Controls.Add(Me.botUpdateTab)
        Me.MetroTabControl1.Controls.Add(Me.globalSettingsTab)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(732, 502)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = true
        '
        'selectedBotTab
        '
        Me.selectedBotTab.Controls.Add(Me.MetroTabControl2)
        Me.selectedBotTab.HorizontalScrollbarBarColor = true
        Me.selectedBotTab.HorizontalScrollbarHighlightOnWheel = false
        Me.selectedBotTab.HorizontalScrollbarSize = 10
        Me.selectedBotTab.Location = New System.Drawing.Point(4, 38)
        Me.selectedBotTab.Name = "selectedBotTab"
        Me.selectedBotTab.Size = New System.Drawing.Size(724, 460)
        Me.selectedBotTab.TabIndex = 5
        Me.selectedBotTab.Text = "Selected Bot"
        Me.selectedBotTab.VerticalScrollbarBarColor = true
        Me.selectedBotTab.VerticalScrollbarHighlightOnWheel = false
        Me.selectedBotTab.VerticalScrollbarSize = 10
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl2.Controls.Add(Me.TabPage6)
        Me.MetroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 1
        Me.MetroTabControl2.Size = New System.Drawing.Size(724, 460)
        Me.MetroTabControl2.TabIndex = 2
        Me.MetroTabControl2.UseSelectable = true
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.MetroGrid1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(716, 418)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Settings"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = false
        Me.MetroGrid1.AllowUserToDeleteRows = false
        Me.MetroGrid1.AllowUserToResizeColumns = false
        Me.MetroGrid1.AllowUserToResizeRows = false
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Key, Me.Value})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = false
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 0)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(716, 418)
        Me.MetroGrid1.TabIndex = 0
        '
        'Key
        '
        Me.Key.HeaderText = "Key"
        Me.Key.Name = "Key"
        Me.Key.ReadOnly = true
        '
        'Value
        '
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        Me.Value.ReadOnly = true
        '
        'batchConfigTab
        '
        Me.batchConfigTab.Controls.Add(Me.MetroTabControl4)
        Me.batchConfigTab.Controls.Add(Me.MetroGrid3)
        Me.batchConfigTab.HorizontalScrollbarBarColor = true
        Me.batchConfigTab.HorizontalScrollbarHighlightOnWheel = false
        Me.batchConfigTab.HorizontalScrollbarSize = 10
        Me.batchConfigTab.Location = New System.Drawing.Point(4, 38)
        Me.batchConfigTab.Name = "batchConfigTab"
        Me.batchConfigTab.Size = New System.Drawing.Size(724, 460)
        Me.batchConfigTab.TabIndex = 4
        Me.batchConfigTab.Text = "Batch Config Settings"
        Me.batchConfigTab.VerticalScrollbarBarColor = true
        Me.batchConfigTab.VerticalScrollbarHighlightOnWheel = false
        Me.batchConfigTab.VerticalScrollbarSize = 10
        '
        'MetroTabControl4
        '
        Me.MetroTabControl4.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl4.Location = New System.Drawing.Point(333, 1)
        Me.MetroTabControl4.Name = "MetroTabControl4"
        Me.MetroTabControl4.SelectedIndex = 0
        Me.MetroTabControl4.Size = New System.Drawing.Size(389, 456)
        Me.MetroTabControl4.TabIndex = 3
        Me.MetroTabControl4.UseSelectable = true
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.HorizontalScrollbarBarColor = true
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(381, 414)
        Me.MetroTabPage3.TabIndex = 0
        Me.MetroTabPage3.Text = "Settings"
        Me.MetroTabPage3.VerticalScrollbarBarColor = true
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroGrid3
        '
        Me.MetroGrid3.AllowUserToAddRows = false
        Me.MetroGrid3.AllowUserToDeleteRows = false
        Me.MetroGrid3.AllowUserToResizeColumns = false
        Me.MetroGrid3.AllowUserToResizeRows = false
        Me.MetroGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MetroGrid3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid3.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid3.EnableHeadersVisualStyles = false
        Me.MetroGrid3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid3.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid3.Location = New System.Drawing.Point(3, 3)
        Me.MetroGrid3.Name = "MetroGrid3"
        Me.MetroGrid3.ReadOnly = true
        Me.MetroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid3.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid3.Size = New System.Drawing.Size(327, 457)
        Me.MetroGrid3.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Select Bot"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = true
        '
        'botUpdateTab
        '
        Me.botUpdateTab.Controls.Add(Me.MetroTabControl3)
        Me.botUpdateTab.Controls.Add(Me.MetroGrid2)
        Me.botUpdateTab.HorizontalScrollbarBarColor = true
        Me.botUpdateTab.HorizontalScrollbarHighlightOnWheel = false
        Me.botUpdateTab.HorizontalScrollbarSize = 10
        Me.botUpdateTab.Location = New System.Drawing.Point(4, 38)
        Me.botUpdateTab.Name = "botUpdateTab"
        Me.botUpdateTab.Size = New System.Drawing.Size(724, 460)
        Me.botUpdateTab.TabIndex = 6
        Me.botUpdateTab.Text = "Bot Update Settings"
        Me.botUpdateTab.VerticalScrollbarBarColor = true
        Me.botUpdateTab.VerticalScrollbarHighlightOnWheel = false
        Me.botUpdateTab.VerticalScrollbarSize = 10
        '
        'MetroTabControl3
        '
        Me.MetroTabControl3.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl3.Location = New System.Drawing.Point(333, 1)
        Me.MetroTabControl3.Name = "MetroTabControl3"
        Me.MetroTabControl3.SelectedIndex = 0
        Me.MetroTabControl3.Size = New System.Drawing.Size(389, 456)
        Me.MetroTabControl3.TabIndex = 3
        Me.MetroTabControl3.UseSelectable = true
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.HorizontalScrollbarBarColor = true
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(381, 414)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Settings"
        Me.MetroTabPage1.VerticalScrollbarBarColor = true
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroGrid2
        '
        Me.MetroGrid2.AllowUserToAddRows = false
        Me.MetroGrid2.AllowUserToDeleteRows = false
        Me.MetroGrid2.AllowUserToResizeColumns = false
        Me.MetroGrid2.AllowUserToResizeRows = false
        Me.MetroGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MetroGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.botSelect})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid2.EnableHeadersVisualStyles = false
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(3, 3)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.ReadOnly = true
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(327, 450)
        Me.MetroGrid2.TabIndex = 2
        '
        'botSelect
        '
        Me.botSelect.HeaderText = "Select Bot"
        Me.botSelect.Name = "botSelect"
        Me.botSelect.ReadOnly = true
        '
        'globalSettingsTab
        '
        Me.globalSettingsTab.Controls.Add(Me.MetroLabel3)
        Me.globalSettingsTab.Controls.Add(Me.MetroComboBox3)
        Me.globalSettingsTab.Controls.Add(Me.MetroLabel2)
        Me.globalSettingsTab.Controls.Add(Me.MetroComboBox2)
        Me.globalSettingsTab.Controls.Add(Me.MetroLabel1)
        Me.globalSettingsTab.Controls.Add(Me.MetroComboBox1)
        Me.globalSettingsTab.HorizontalScrollbarBarColor = true
        Me.globalSettingsTab.HorizontalScrollbarHighlightOnWheel = false
        Me.globalSettingsTab.HorizontalScrollbarSize = 10
        Me.globalSettingsTab.Location = New System.Drawing.Point(4, 38)
        Me.globalSettingsTab.Name = "globalSettingsTab"
        Me.globalSettingsTab.Size = New System.Drawing.Size(724, 460)
        Me.globalSettingsTab.TabIndex = 7
        Me.globalSettingsTab.Text = "Global Settings"
        Me.globalSettingsTab.VerticalScrollbarBarColor = true
        Me.globalSettingsTab.VerticalScrollbarHighlightOnWheel = false
        Me.globalSettingsTab.VerticalScrollbarSize = 10
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = true
        Me.MetroLabel3.Location = New System.Drawing.Point(22, 123)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(141, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Auto Update Manager"
        '
        'MetroComboBox3
        '
        Me.MetroComboBox3.FormattingEnabled = true
        Me.MetroComboBox3.ItemHeight = 23
        Me.MetroComboBox3.Items.AddRange(New Object() {"On Start", "On Exit", "Never"})
        Me.MetroComboBox3.Location = New System.Drawing.Point(169, 119)
        Me.MetroComboBox3.Name = "MetroComboBox3"
        Me.MetroComboBox3.Size = New System.Drawing.Size(199, 29)
        Me.MetroComboBox3.TabIndex = 7
        Me.MetroComboBox3.UseSelectable = true
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = true
        Me.MetroLabel2.Location = New System.Drawing.Point(22, 76)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Form Theme"
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FormattingEnabled = true
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Items.AddRange(New Object() {"Light", "Dark"})
        Me.MetroComboBox2.Location = New System.Drawing.Point(169, 66)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(199, 29)
        Me.MetroComboBox2.TabIndex = 5
        Me.MetroComboBox2.UseSelectable = true
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Form Style"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = true
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(169, 17)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(199, 29)
        Me.MetroComboBox1.TabIndex = 3
        Me.MetroComboBox1.UseSelectable = true
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.HorizontalScrollbarBarColor = true
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(716, 418)
        Me.MetroTabPage2.TabIndex = 2
        Me.MetroTabPage2.Text = "Console"
        Me.MetroTabPage2.VerticalScrollbarBarColor = true
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 582)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Main"
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Pokemon Go Bot Manager"
        CType(Me.MetroStyleManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.MetroTabControl1.ResumeLayout(false)
        Me.selectedBotTab.ResumeLayout(false)
        Me.MetroTabControl2.ResumeLayout(false)
        Me.TabPage6.ResumeLayout(false)
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).EndInit
        Me.batchConfigTab.ResumeLayout(false)
        Me.MetroTabControl4.ResumeLayout(false)
        CType(Me.MetroGrid3,System.ComponentModel.ISupportInitialize).EndInit
        Me.botUpdateTab.ResumeLayout(false)
        Me.MetroTabControl3.ResumeLayout(false)
        CType(Me.MetroGrid2,System.ComponentModel.ISupportInitialize).EndInit
        Me.globalSettingsTab.ResumeLayout(false)
        Me.globalSettingsTab.PerformLayout
        Me.ResumeLayout(false)

End Sub
        Friend WithEvents Timer As Timer
        Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
        Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents MetroTabControl1 As MetroTabControl
        Friend WithEvents botTree As MetroListView
        Friend WithEvents showPokemon As MetroToggle
        Friend WithEvents showExp As MetroToggle
        Friend WithEvents showLvl As MetroToggle
        Friend WithEvents btnAdd As MetroButton
        Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
        Friend WithEvents btnRestart As MetroFramework.Controls.MetroButton
        Friend WithEvents btnStop As MetroFramework.Controls.MetroButton
        Friend WithEvents pokemonLabel As MetroFramework.Controls.MetroLabel
        Friend WithEvents lvlLabel As MetroFramework.Controls.MetroLabel
        Friend WithEvents xpLabel As MetroFramework.Controls.MetroLabel
        Friend WithEvents batchConfigTab As MetroFramework.Controls.MetroTabPage
        Friend WithEvents MetroTabControl4 As MetroFramework.Controls.MetroTabControl
        Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
        Friend WithEvents MetroGrid3 As MetroFramework.Controls.MetroGrid
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents selectedBotTab As MetroFramework.Controls.MetroTabPage
        Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
        Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
        Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
        Friend WithEvents Key As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Value As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents botUpdateTab As MetroFramework.Controls.MetroTabPage
        Friend WithEvents MetroTabControl3 As MetroFramework.Controls.MetroTabControl
        Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
        Friend WithEvents MetroGrid2 As MetroFramework.Controls.MetroGrid
        Friend WithEvents botSelect As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents globalSettingsTab As MetroFramework.Controls.MetroTabPage
        Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
        Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
        Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
        Friend WithEvents MetroTabPage2 As MetroTabPage
    End Class
End NameSpace