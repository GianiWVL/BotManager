Imports BotManager.Helpers

Namespace UserInterface.Download

    Public Class SupportedBots
        Public Shared Bots As New Dictionary(Of String, SupportedBot) From {
            {"SpegeliBot", New SupportedBot("SpegeliBot",
                                            "https://github.com/chancity/BotManagerBots/raw/master/Bots/SpegeliBot/Release.zip",
                                            "SpegeliBotInstances",
                                            {"SpegeliBot/Release/PokemonGo.RocketAPI.Console.exe.config"},
                                            "SpegeliBot/Release/PokemonGo.RocketAPI.Console.exe",
                                            ReaderType.AppSetting)},
            {"HaxtonBot", New SupportedBot("HaxtonBot",
                                           "https://github.com/chancity/BotManagerBots/raw/master/Bots/HaxtonBot/Release.zip",
                                           "HaxtonBotInstances",
                                           {"HaxtonBot/Release/PokemonGo.Haxton.Console.exe.config"},
                                           "HaxtonBot/Release/PokemonGo.Haxton.Console.exe",
                                           ReaderType.AppSetting)},
            {"PokeMobBot", New SupportedBot("PokeMobBot",
                                            "https://github.com/chancity/BotManagerBots/raw/master/Bots/PokeMobBot/Release.zip",
                                            "PokeMobBotInstances",
                                            {"PokeMobBot/Release/Config/Config.json", "PokeMobBot/Release/Config/Auth.json"},
                                            "PokeMobBot/Release/PokeMobBot.exe",
                                            ReaderType.JsonSettings)},
            {"NecroBot", New SupportedBot("NecroBot",
                                          "https://github.com/chancity/BotManagerBots/raw/master/Bots/NecroBot/Release.zip",
                                          "NecroBotInstances",
                                          {"NecroBot/Release/Config/Config.json", "NecroBot/Release/Config/Auth.json"},
                                          "NecroBot/Release/NecroBot.exe",
                                          ReaderType.JsonSettings)}}
    End Class

    Public Class SupportedBot
        Public RootDirectory As String = ""
        Friend DownloadUrl As String = ""
        Public ConfigPaths As String() = {}
        Public InstanceDirectory As String  = ""
        Public ExecutablePath As String  = ""
        Friend AutoUpdate As Boolean = True
        Public ReaderType As readerType = ReaderType.JsonSettings
        Public Settings As BotSettings
        Public Sub New()

        End Sub
        Public Sub New(rootDirectory As String, downloadUrl As String, instanceDirectory As String, configPaths() As String,
                       executablePath As String, readerType As ReaderType)
            Me.RootDirectory = rootDirectory
            Me.DownloadUrl = downloadUrl
            Me.InstanceDirectory = instanceDirectory
            Me.ConfigPaths = configPaths
            Me.ExecutablePath = executablePath
            Me.ReaderType = readerType
        End Sub
        Friend Function Installed() As Boolean
            Return File.Exists(ExecutablePath)
        End Function
        Friend Sub Delete()
            IO.DeleteFilesFromFolder(RootDirectory)
        End Sub
        Friend Sub Download()
            Http.DownloadRepository(DownloadUrl, RootDirectory & ".zip")
        End Sub
        Friend Sub UnZip()
            IO.Unzip(RootDirectory & ".zip", RootDirectory)
            File.Delete(RootDirectory & ".zip")
        End Sub
        Protected Sub SetSettings()
            Settings = New BotSettings(Me)
        End Sub
    End Class
End NameSpace