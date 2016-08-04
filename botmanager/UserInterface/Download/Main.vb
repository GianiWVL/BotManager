Imports System.Net
Imports BotManager.Helpers

Namespace UserInterface.Download
    Public Class Main

        ' Private Sub checkForUpdate(ByRef supportedBotInformation As SupportedBotInformation)
        '    Dim client = New System.Net.WebClient
        '    client.Headers.Add("user-agent", " Mozilla/5.0 (Windows NT 6.1; WOW64; rv:25.0) Gecko/20100101 Firefox/25.0")
        '    Dim commmitHistory = client.DownloadString(supportedBotInformation.commitsUrl)
        '    Dim jObjectCommits As JArray = JArray.Parse(commmitHistory)
        '    Dim lastVerSha As String = jObjectCommits(0)("sha").ToString
        '    Dim currentVerSha As String = My.Settings(supportedBotInformation.Name & "sha")
        '
        '    If Not currentVerSha = lastVerSha Then
        '        newVerAvailable = True
        '        My.Settings(supportedBotInformation.Name & "sha") = lastVerSha
        '        My.Settings.Save()
        '    End If
        'End Sub

        Private Sub CheckForUpdates()
            Dim githubVersion = ""
            Try
                Dim request As HttpWebRequest =
                        HttpWebRequest.Create("https://raw.githubusercontent.com/chancity/BotManagerBots/master/VERSION")
                request.Proxy = Nothing
                request.UserAgent = "Pokemon"
                Dim response As HttpWebResponse = request.GetResponse
                Dim responseStream As Stream = response.GetResponseStream
                Dim streamReader As New StreamReader(responseStream)
                Dim data As String = streamReader.ReadToEnd
                streamReader.Close()
                githubVersion = data.ToString.Trim()
            Catch ex As Exception

            End Try
            If githubVersion = "" = False Then
                If Application.ProductVersion = githubVersion = False Then

                    Dim result As DialogResult = MessageBox.Show("Program has been updated! Would you like to update now?","",
                                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If result = DialogResult.Yes Then
                       My.Computer.FileSystem.RenameFile("BotManager.exe", "BotManager.exe.old")
                       Http.DownloadRepository("https://github.com/chancity/BotManagerBots/raw/master/Download/BotManager.exe",
                                            "BotManager.exe")
                        Process.Start("BotManager.exe")
                        End
                    End If
                End If
            End If
        End Sub

        Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            DataGridView1.Columns.Insert(0, New DataGridViewTextboxColumn With { .Name = "Name"})
            DataGridView1.Columns.Insert(1, New DataGridViewCheckBoxColumn() With { .Name = "Auto Update"})
            DataGridView1.Columns.Insert(2, New DataGridViewCheckBoxColumn() With { .Name = "Installed"})
            DataGridView1.Columns.Insert(3, New DataGridViewButtonColumn() With { .Name = "Update"})

            For Each key As String In SupportedBots.Bots.Keys
                DataGridView1.Rows.Insert(0, key, 
                                          SupportedBots.Bots(key).AutoUpdate, 
                                          SupportedBots.Bots(key).Installed(), "Update")
            Next

        End Sub
        Private Sub DataGridView1_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                                Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            SupportedBots.Bots(DataGridView1.SelectedRows(0).Cells(0).Value.ToString()).Download()
        End If

        End Sub

        Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
            Dim addDialog As New Add(SupportedBots.Bots(DataGridView1.SelectedRows(0).Cells(0).Value.ToString()))
            addDialog.ShowDialog()
            addDialog.Dispose()

        End Sub
    End Class
End NameSpace