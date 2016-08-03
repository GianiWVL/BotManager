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
                _instances.Add("Nuget", New SupportedBotInformation() With {
                                  .Name = "Nuget", 
                                  .DownloadUrl = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe",
                                  .WorkingDirectory = "",
                                  .ExecutablePath = "Nuget.exe",
                                  .ZipName = "Nuget.exe",
                                  .DisplayAsBot = False,
                                  .DownloadPackages = False,
                                  .ReadSettings = False,
                                  .UnZip = False,
                                  .DeleteOld = False,
                                  .Compile = False})

                _instances.Add("Spegeli", New SupportedBotInformation() With {
                                  .Name = "Spegeli", 
                                  .DownloadUrl = "https://github.com/Spegeli/Pokemon-Go-Rocket-API/archive/master.zip",
                                  .WorkingDirectory = "Spegeli/PokemoGoBot-GottaCatchEmAll-master",
                                  .ZipName = "Spegeli.zip",
                                  .UnZipDirectory = "Spegeli",
                                  .ExecutablePath =
                                  "Spegeli/PokemoGoBot-GottaCatchEmAll-master/PokemonGo.RocketAPI.Console/bin/Debug/PokemonGo.RocketAPI.Console.exe",
                                  .BotClass = "BotManager.Manager.Spegeli"})

                _instances.Add("Haxton", New SupportedBotInformation() With {
                                  .Name = "Haxton", 
                                  .DownloadUrl = "https://github.com/d-haxton/HaxtonBot/archive/master.zip",
                                  .WorkingDirectory = "Haxton/HaxtonBot-master",
                                  .ZipName = "Haxton.zip",
                                  .UnZipDirectory = "Haxton",
                                  .ExecutablePath =
                                  "Haxton/HaxtonBot-master/PokemonGo.Haxton.Console/bin/Debug/PokemonGo.Haxton.Console.exe",
                                  .BotClass = "BotManager.Manager.Haxton"})

                _instances.Add("PokeMobBot", New SupportedBotInformation() With {
                                  .Name = "PokeMobBot", 
                                  .DownloadUrl = "https://github.com/PocketMobsters/PokeMobBot/releases/download/v1.1.3/Release.zip",
                                  .WorkingDirectory = "PokeMobBot/Release",
                                  .ZipName = "PokeMobBot.zip",
                                  .UnZipDirectory = "PokeMobBot",
                                  .ExecutablePath = "PokeMobBot/Release/PokeMobBot.exe",
                                  .BotClass = "BotManager.Manager.PokeMobBot",
                                  .Compile = False,
                                  .DownloadPackages = False})

               _instances.Add("Necro", New SupportedBotInformation() With {
                                  .Name = "Necro", 
                                  .DownloadUrl = "https://github.com/NECROBOTIO/NecroBot/releases/download/v0.6.2/Release.zip",
                                  .WorkingDirectory = "Necro/Release",
                                  .ZipName = "Necro.zip",
                                  .UnZipDirectory = "Necro",
                                  .ExecutablePath = "Necro/Release/NecroBot.exe",
                                  .BotClass = "BotManager.Manager.Necro",
                                  .Compile = False,
                                  .DownloadPackages = False})

                Return _instances
            Else
                Return _instances
            End If
        End Function
    End Class
End NameSpace