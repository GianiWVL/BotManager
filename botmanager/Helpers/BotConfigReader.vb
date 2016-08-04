Imports System.Configuration
Imports System.Globalization
Imports BotManager.UserInterface.Download
Imports Newtonsoft.Json.Linq

Namespace Helpers
    Public Class BotConfigReader
        Public Shared Sub JsonSettings(ByRef supportedBot As SupportedBot)
            Dim settings As String
            Dim jObjectSettings As JObject
            For Each path As String In SupportedBot.ConfigPaths
                Using sr As StreamReader = New StreamReader(Path)
                    settings = sr.ReadToEnd()
                End Using

                jObjectSettings = JObject.Parse(settings)

                For each jO As JProperty IN jObjectSettings.Children()
                    If (jO.Value.GetType().ToString().Contains("Newtonsoft.Json.Linq.JValue")) Then
                        If jO.Value.Type = JTokenType.Float OrElse jO.Value.Type = JTokenType.Integer Then
                            supportedBot.Settings.Add(jo.Name,
                                                                String.Format(CultureInfo.InvariantCulture, "{0}",
                                                                              jo.Value.ToString()))
                        Else
                            supportedBot.Settings.Add(jo.Name, jo.Value.ToString())
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub XmlSettings(ByRef supportedBot As SupportedBot)

        End Sub

        Public Shared Sub AppSettings(ByRef supportedBot As SupportedBot)
             Dim fileMap As New ExeConfigurationFileMap()
            fileMap.ExeConfigFilename =
                supportedBot.ConfigPaths(0)
            Dim config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                                                                                          ConfigurationUserLevel.None)
            Dim settingsSection
            settingsSection = config.AppSettings

            For Each setting In settingsSection.Settings
                supportedBot.Settings.Add(setting.[Key], setting.Value.ToString())
            Next
        End Sub

        Public Shared Sub UserSettings(ByRef supportedBot As SupportedBot)
             Dim fileMap As New ExeConfigurationFileMap()
            fileMap.ExeConfigFilename =
                supportedBot.ConfigPaths(0)
            Dim config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                                                                                          ConfigurationUserLevel.None)
            Dim settingsSection
            settingsSection = config.GetSection("userSettings/PokemonGo.RocketAPI.Console.UserSettings")

            For Each setting In settingsSection.Settings
                 supportedBot.Settings.Add(setting.Name, setting.Value.ValueXml.InnerText)
            Next
        End Sub
    End Class
End NameSpace