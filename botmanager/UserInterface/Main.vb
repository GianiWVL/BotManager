Imports System.ComponentModel
Imports System.Management
Imports System.Reflection
Imports System.Text
Imports BotManager.List
Imports BotManager.Manager
Imports BotManager.Properties
Imports BotManager.Windows

Namespace UserInterface
    Public Class Main
        Private ReadOnly _
            _processSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE Name='WerFault.exe'")

        Private ReadOnly _bots As New ArrayList
        Dim batchRemove As Boolean = False

        Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                For Each supportedBotInformation As SupportedBotInformation In OfSupportedBots.GetInstance().Values
                    If Not supportedBotInformation.DisplayAsBot Then Continue For
                    botSelectBox.Items.Add(supportedBotInformation.Name)
                    botSelectBox.SelectedItem = botSelectBox.Items.Item(0)
                Next
            Catch ex As Exception
                MsgBox("Error at load " & ex.Message)
            End Try
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        End Sub

        Public Shared Sub SetDoubleBuffered(c As Control)
            If SystemInformation.TerminalServerSession Then
                Return
            End If

            Dim aProp As PropertyInfo = GetType(Control).GetProperty("DoubleBuffered",
                                                                     BindingFlags.NonPublic Or BindingFlags.Instance)

            aProp.SetValue(c, True, Nothing)
        End Sub

        Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
            ResizeCmd()
        End Sub

        Private Sub Main_HasLoad(sender As Object, e As EventArgs) Handles MyBase.Shown
            Generic.PanelHandle = botPanel.Handle
            If My.Settings.ListOfPropertiesBots Is Nothing Then
                My.Settings.ListOfPropertiesBots = New OfPropertiesBots
            Else
                For Each botInformation As BotInformation In My.Settings.ListOfPropertiesBots.Items
                    CreateTreeNode(botInformation)
                Next
            End If
        End Sub

        Private Sub Main_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
            Dim t As Task = Task.Run(Sub()
                For Each bot As Generic In _bots
                    bot.Dispose()
                Next
                                        End Sub)
            t.Wait()
            My.Settings.Save()
        End Sub

        Private Sub CreateTreeNode(ByRef botInformation As BotInformation)
            Dim newTreeNode As New TreeNode
            Dim title As String = botInformation.GetSettingValue("PtcUsername")
            If title.ToLower().Contains("username") Then title = botInformation.GetSettingValue("GoogleEmail")
            newTreeNode.Name = title
            newTreeNode.Text = title
            Dim bot As Generic = BotFactory.GetBot(botInformation)
            _bots.Add(bot)
            newTreeNode.Tag = bot
            botTree.Nodes.Add(newTreeNode)
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            Dim botInformation As New BotInformation()

            If botSelectBox.Text = "Haxton" Then
                botInformation.BotClass = "BotManager.Manager.Haxton"
            ElseIf botSelectBox.Text = "Spegeli" Then
                botInformation.BotClass = "BotManager.Manager.Spegeli"
            ElseIf botSelectBox.Text = "Necro" Then
                botInformation.BotClass = "BotManager.Manager.Necro"
            ElseIf botSelectBox.Text = "PokeMobBot" Then
                botInformation.BotClass = "BotManager.Manager.PokeMobBot"
            Else
                botInformation = Nothing
                MsgBox("Select bot type")
                Exit Sub
            End If
            Dim dialog As New SettingsEditor(botInformation)


            If dialog.ShowDialog() = DialogResult.OK Then
                For Each returnedBotInformation As BotInformation In dialog.BatchAddProperties
                    My.Settings.ListOfPropertiesBots.Items.Add(returnedBotInformation)
                    CreateTreeNode(returnedBotInformation)
                Next
                batchStarter.RunWorkerAsync()
            End If

            dialog = Nothing
        End Sub

        Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
            If botTree.SelectedNode Is Nothing Then Exit Sub
            Dim bot = DirectCast(botTree.SelectedNode.Tag, Generic)
            Dim dialog As New SettingsEditor(bot.BotInformation)

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim title As String = bot.BotInformation.GetSettingValue("PtcUsername")
                If title.ToLower().Contains("username") Then title = bot.BotInformation.GetSettingValue("GoogleEmail")
                If title = "" Then title = bot.BotInformation.GetSettingValue("GoogleUsername")

                botTree.SelectedNode.Text = title

                bot.Kill(False)
                bot.Start()
            End If
        End Sub

        Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
            If botTree.SelectedNode Is Nothing Then Exit Sub
            Dim bot = DirectCast(botTree.SelectedNode.Tag, Generic)
            _bots.Remove(bot)
            bot.Dispose()
            My.Settings.ListOfPropertiesBots.Items.Remove(bot.BotInformation)
            botTree.Nodes.Remove(botTree.SelectedNode)
        End Sub

        Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
            If botTree.SelectedNode Is Nothing Then Exit Sub
            Dim bot = DirectCast(botTree.SelectedNode.Tag, Generic)
            If bot.IsRunning Then bot.Kill(False)
            bot.Start()
        End Sub

        Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
            If botTree.SelectedNode Is Nothing Then Exit Sub
            Dim bot = DirectCast(botTree.SelectedNode.Tag, Generic)

            If bot.IsRunning Then
                bot.Kill(False)
            End If
        End Sub

        Private Sub btnRestartAll_Click(sender As Object, e As EventArgs) Handles btnRestartAll.Click
            batchKiller.RunWorkerAsync()
            batchStarter.RunWorkerAsync()
        End Sub

        Private Sub btnStopAll_Click(sender As Object, e As EventArgs) Handles btnStopAll.Click
            batchKiller.RunWorkerAsync()
        End Sub

        Private Sub repLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
            Handles repLabel.LinkClicked
            repLabel.LinkVisited = True
            Process.Start(
                "http://www.ownedcore.com/forums/pokemon-go/pokemon-go-hacks-cheats/568064-bot-manager-spegeli-necro-haxton-all-one-multi-account-1000-a.html")
        End Sub

        Private Sub paypalLabel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) _
            Handles paypalLabel.LinkClicked
            repLabel.LinkVisited = True

            Process.Start(
                "https://www.paypal.me/chancity")
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
            If Not BackgroundWorker.IsBusy Then
                BackgroundWorker.RunWorkerAsync()
            End If
        End Sub

        Private Sub botTree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles botTree.AfterSelect
            If Not e.Node.IsSelected Then Exit Sub
            Dim bot = DirectCast(e.Node.Tag, Generic)
            Api.ShowWindow(bot.Handle, 5)
            Api.SetWindowPos(bot.Handle, 1, 0, 0, botPanel.Width, botPanel.Height, 0)
            bot.IsSelected = True
        End Sub

        Private Sub botTree_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) _
            Handles botTree.BeforeSelect

            If botTree.SelectedNode Is Nothing Then
                Dim bot = DirectCast(e.Node.Tag, Generic)
                Api.ShowWindow(bot.Handle, 5)
                Api.SetWindowPos(bot.Handle, 1, 0, 0, botPanel.Width, botPanel.Height, 0)
            Else
                Dim bot = DirectCast(botTree.SelectedNode.Tag, Generic)
                Api.ShowWindow(bot.Handle, 0)
                bot.IsSelected = False
            End If
        End Sub

        Private Sub TimerTask()
            For Each process As ManagementObject In _processSearcher.Get()
                If ContainsProcess(process("CommandLine").ToString()) Then
                    process.InvokeMethod("Terminate", Nothing)
                End If
            Next
        End Sub
        Private Function StatusUpdate() As String
            Dim total As Double = 0
            For Each bot As Generic In _bots
                Dim contained = False
                Dim caption As New StringBuilder(256)
                If bot.IsRunning Then
                    For Each intr In Api.GetChildWindows(_botPanel.Handle)
                        If intr = bot.Handle Then
                            contained = True
                            Exit For
                        End If
                    Next
                    If Not contained Then
                        bot.PutConsoleInPanel()
                    End If
                    caption.Clear()
                    Api.GetWindowText(bot.Handle, caption, caption.Capacity)
                    Dim str As String() = caption.ToString.Split("|")
                    If str.Length >= 2 Then
                        Dim parts
                        If (bot.BotInformation.BotClass = "BotManager.Manager.Haxton") Then
                            parts = str(1).Split("-")(2)
                        ElseIf (bot.BotInformation.BotClass = "BotManager.Manager.Spegeli") Then
                            parts = str(0).Split("(")(0).Split("-")(2)
                        ElseIf (bot.BotInformation.BotClass = "BotManager.Manager.Necro") Then
                            parts = str(0).Split("-")(2).Split("(")(0)
                        ElseIf (bot.BotInformation.BotClass = "BotManager.Manager.PokeMobBot") Then
                            parts = str(0).Split("-")(2).Split("(")(0)
                        End If
                        bot.Level = parts
                        bot.ExperiencePerHour = str(2)
                        bot.PokeStopsPerHour = str(3)
                        
                        total += CDbl(str(2).Split(":")(1).Trim())
                    End If
                End If
            Next

            Return String.Format("Total Bots: {0}, Average EXP: {1}, Total EXP: {2}", botTree.Nodes.Count,
                                             total/botTree.Nodes.Count, total)
        End Function

        Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
            TimerTask()
            e.Result = StatusUpdate()
        End Sub
        Private Sub BackgroundWorker_Complete(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
            For Each treeNode As TreeNode In botTree.Nodes
                Dim bot = DirectCast(treeNode.Tag, Generic)
                treeNode.Text = treeNode.Name
                If showLvl.Checked Then
                    treeNode.Text &= " - " & bot.Level
                End If
                If showExp.Checked Then
                    treeNode.Text &= " - " & bot.ExperiencePerHour
                End If
                If showPokemon.Checked Then
                    treeNode.Text &= " - " & bot.PokeStopsPerHour
                End If
            Next

            statusLabel.Text = e.Result.ToString()
        End Sub
        Private Sub ResizeCmd()
            If botTree.SelectedNode Is Nothing Then Exit Sub
            Dim bot = DirectCast(botTree.SelectedNode.Tag, Generic)
            Api.SetWindowPos(bot.Handle, 1, 0, 0, botPanel.Width, botPanel.Height, 0)
        End Sub

        Private Sub StartAllBots()
            For Each bot As Generic In _bots
                If Not bot.IsRunning Then bot.Start()
                If Not bot.IsRunning Then
                    Application.DoEvents()
                End If
            Next
        End Sub

        Private Sub KillAllBots()
            Dim t As Task = Task.Run(Sub()
                For Each bot As Generic In _bots
                    If bot.IsRunning Then bot.Kill(False)
                Next
                                        End Sub)

            t.Wait()
        End Sub

        Private Function ContainsProcess(commandLine As String)
            Return _bots.Cast (Of Generic)().Any(Function(bot) commandLine.Contains(bot.ProcessId.ToString()))
        End Function

        Private Sub botsStarter_DoWork(sender As Object, e As DoWorkEventArgs) Handles batchStarter.DoWork
            StartAllBots()
        End Sub

        Private Sub batchKiller_DoWork(sender As Object, e As DoWorkEventArgs) Handles batchKiller.DoWork
            KillAllBots()
        End Sub

        Private Sub btnStartAll_Click(sender As Object, e As EventArgs) Handles btnStartAll.Click
            batchStarter.RunWorkerAsync()
        End Sub

        Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
            botTree.Nodes.Clear()
            KillAllBots()
            _bots.Clear()
            My.Settings.ListOfPropertiesBots = New OfPropertiesBots()
            My.Settings.Save()
        End Sub
    End Class
End Namespace