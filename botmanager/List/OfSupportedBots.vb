Imports BotManager.Properties

Namespace List
    Public Class OfSupportedBots
        Inherits Dictionary(Of String, SupportedBotInformation)
        Private Shared _instances As OfSupportedBots

        Private Sub New()
        End Sub

        Public Shared Function GetInstance() As Dictionary(Of String, SupportedBotInformation)
            If _instances Is Nothing
                _instances = New OfSupportedBots()

                _instances.Add("SpegeliBot", New SupportedBotInformation() With {
                                  .Name = "SpegeliBot", 
                                  .DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/SpegeliBot/Release.zip",
                                  .WorkingDirectory = "SpegeliBot/Release",
                                  .ZipName = "SpegeliBot.zip",
                                  .UnZipDirectory = "SpegeliBot",
                                  .ExecutablePath = "SpegeliBot/Release/PokemonGo.RocketAPI.Console.exe",
                                  .BotClass = "BotManager.Manager.SpegeliBot"})

                _instances.Add("HaxtonBot", New SupportedBotInformation() With {
                                  .Name = "HaxtonBot", 
                                  .DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/HaxtonBot/Release.zip",
                                  .WorkingDirectory = "HaxtonBot/Release",
                                  .ZipName = "HaxtonBot.zip",
                                  .UnZipDirectory = "HaxtonBot",
                                  .ExecutablePath = "HaxtonBot/Release/PokemonGo.Haxton.Console.exe",
                                  .BotClass = "BotManager.Manager.HaxtonBot"})

                _instances.Add("PokeMobBot", New SupportedBotInformation() With {
                                  .Name = "PokeMobBot", 
                                  .DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/PokeMobBot/Release.zip",
                                  .WorkingDirectory = "PokeMobBot/Release",
                                  .ZipName = "PokeMobBot.zip",
                                  .UnZipDirectory = "PokeMobBot",
                                  .ExecutablePath = "PokeMobBot/Release/PokeMobBot.exe",
                                  .BotClass = "BotManager.Manager.PokeMobBot"})

               _instances.Add("NecroBot", New SupportedBotInformation() With {
                                  .Name = "NecroBot", 
                                  .DownloadUrl = "https://github.com/chancity/BotManagerBots/raw/master/Bots/NecroBot/Release.zip",
                                  .WorkingDirectory = "NecroBot/Release",
                                  .ZipName = "NecroBot.zip",
                                  .UnZipDirectory = "NecroBot",
                                  .ExecutablePath = "NecroBot/Release/NecroBot.exe",
                                  .BotClass = "BotManager.Manager.NecroBot"})

                Return _instances
            Else
                Return _instances
            End If
        End Function
    End Class
End NameSpace