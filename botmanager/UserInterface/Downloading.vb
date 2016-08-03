Imports System.ComponentModel
Imports System.Net
Imports System.Threading
Imports BotManager.Helpers
Imports BotManager.List
Imports BotManager.Properties

Namespace UserInterface
    Public Class Downloading
        Private _forceUpdate As Boolean = False
        Public WriteOnly Property ForceUpdate() As Boolean
            Set
                _forceUpdate = value
            End Set
        End Property
        Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) _
            Handles BackgroundWorker1.DoWork

            For Each supportedBotInformation As SupportedBotInformation In OfSupportedBots.GetInstance().Values
                If e.Argument OrElse Not Installed(supportedBotInformation) Then
                    InstallBot(supportedBotInformation)
                End If

                If Installed(supportedBotInformation) Then
                    AddSettings(supportedBotInformation)
                End If
            Next


            IO.DeleteFilesFromFolder(IO.AppData)
            BackgroundWorker1.ReportProgress(0, "Complete")
            Thread.Sleep(100)
        End Sub

        Private Sub BackgroundWorker1_ReportProgress(sender As Object,
                                                     e As ProgressChangedEventArgs) _
            Handles BackgroundWorker1.ProgressChanged

            downloadLabel.Text = e.UserState.ToString()
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object,
                                                         e As RunWorkerCompletedEventArgs) _
            Handles BackgroundWorker1.RunWorkerCompleted

            If Not e.Error Is Nothing Then
                Dim objWriter As New StreamWriter("error.log")
                objWriter.Write(e.Error.Message & vbCrLf & e.Error.StackTrace)
                objWriter.Dispose()
                Process.Start("error.log")
            End If

            DialogResult = DialogResult.OK

            Main.Show()
            Me.Close()
        End Sub

        Private Sub InstallBot(ByRef supportedBotInformation As SupportedBotInformation)
            DeleteOldBot(supportedBotInformation)
            DownloadBot(supportedBotInformation)
            UnZipBot(supportedBotInformation)
        End Sub

        Private Sub DeleteOldBot(ByRef supportedBotInformation As SupportedBotInformation)
            BackgroundWorker1.ReportProgress(1, "Deleting " & supportedBotInformation.Name & "directory")
            IO.DeleteFilesFromFolder(supportedBotInformation.Name)
        End Sub

        Private Sub DownloadBot(ByRef supportedBotInformation As SupportedBotInformation)
            BackgroundWorker1.ReportProgress(1, "Downloading " & supportedBotInformation.Name)
            Http.DownloadRepository(supportedBotInformation.DownloadUrl, supportedBotInformation.ZipName)
        End Sub

        Private Sub UnZipBot(ByRef supportedBotInformation As SupportedBotInformation)
            BackgroundWorker1.ReportProgress(1, "Unzipping " & supportedBotInformation.Name)
            IO.Unzip(supportedBotInformation.ZipName, supportedBotInformation.UnZipDirectory)
            File.Delete(supportedBotInformation.ZipName)
        End Sub

        Private Sub AddSettings(ByRef supportedBotInformation As SupportedBotInformation)
            BackgroundWorker1.ReportProgress(1, "Reading " & supportedBotInformation.Name & "settings")
            If File.Exists(supportedBotInformation.ExecutablePath) Then
                Select Case supportedBotInformation.Name
                    Case "SpegeliBot"
                        Manager.SpegeliBot.ReadSettings(supportedBotInformation)
                    Case "HaxtonBot"
                        Manager.HaxtonBot.ReadSettings(supportedBotInformation)
                    Case "NecroBot"
                        Manager.NecroBot.ReadSettings(supportedBotInformation)
                    Case "PokeMobBot"
                        Manager.PokeMobBot.ReadSettings(supportedBotInformation)
                End Select
            End If
        End Sub
        Private Sub Downloading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Main.Hide()
            If File.Exists("BotManager.exe.old") Then File.Delete("BotManager.exe.old")
            If My.Settings.AutoUpdate Then CheckForUpdates()
            BackgroundWorker1.RunWorkerAsync(_forceUpdate)
        End Sub
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
                        HttpWebRequest.Create("https://raw.githubusercontent.com/chancity/BotManager/master/version")
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
                       Http.DownloadRepository("https://github.com/chancity/BotManager/raw/master/download/BotManager.exe",
                                            "BotManager.exe")
                        Process.Start("BotManager.exe")
                        End
                    End If
                End If
            End If
        End Sub

        Private Function Installed(ByRef supportedBotInformation As SupportedBotInformation) As Boolean
            Return File.Exists(supportedBotInformation.ExecutablePath)
        End Function
    End Class
End NameSpace