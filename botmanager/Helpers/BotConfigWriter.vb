Imports System.Configuration
Imports System.Globalization
Imports BotManager.Properties
Imports Newtonsoft.Json.Linq

Namespace Helpers
    Public Class BotConfigWriter
        Public Shared Sub JsonSettings(ByRef botInformation As BotInformation)
            Dim _
                srSettings As _
                    New StreamReader(Path.GetDirectoryName(BotInformation.TempExecutablePath) & "\Config\config.json")
            Dim settings As String = srSettings.ReadToEnd()
            srSettings.Dispose()

            Dim _
                srAuth As _
                    New StreamReader(Path.GetDirectoryName(BotInformation.TempExecutablePath) & "\Config\auth.json")
            Dim auth As String = srAuth.ReadToEnd()
            srAuth.Dispose()

            Dim jObjectSettings As JObject = JObject.Parse(settings)
            Dim jObjectAuth As JObject = JObject.Parse(auth)

            For Each setting As String In botInformation.BotSettings.Keys
                If _
                    setting.Equals("AuthType") OrElse setting.Equals("GoogleUsername") OrElse
                    setting.Equals("GooglePassword") OrElse setting.Equals("PtcUsername") OrElse
                    setting.Equals("PtcPassword") Then
                    jObjectAuth(setting) = botInformation.BotSettings(setting).ToString()
                Else
                    If setting.Equals("AutoUpdate") Then
                        jObjectSettings(setting) = "false"
                    Else
                         If jObjectSettings(setting).Type = JTokenType.Float OrElse jObjectSettings(setting).Type = JTokenType.Integer Then
                            jObjectSettings(setting) = String.Format(CultureInfo.InvariantCulture, "{0}",
                                                                              botInformation.BotSettings(setting).ToString())
                         End If
                    End If
                End If

            Next

            Using _
                outputFile As _
                    New StreamWriter(Path.GetDirectoryName(BotInformation.TempExecutablePath) & "\Config\auth.json")
                outputFile.Write(jObjectAuth.ToString())
            End Using

            Using _
                outputFile As _
                    New StreamWriter(Path.GetDirectoryName(BotInformation.TempExecutablePath) & "\Config\config.json")
                outputFile.Write(jObjectSettings.ToString())
            End Using
        End Sub

        Public Shared Sub XmlSettings(ByRef botInformation As BotInformation)
        End Sub

        Public Shared Sub AppSettings(ByRef botInformation As BotInformation)
            Dim fileMap As New ExeConfigurationFileMap()
            fileMap.ExeConfigFilename =
                botInformation.TempExecutablePath & ".config"
            Dim config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                                                                                          ConfigurationUserLevel.None)
            Dim settingsSection
            Dim tempSetting

            settingsSection = config.AppSettings
            tempSetting = new KeyValueConfigurationElement("TempSetting", "temp")

            settingsSection.Settings.Add(tempSetting)

            For Each setting As String In botInformation.BotSettings.Keys
                DirectCast(settingsSection, AppSettingsSection).Settings.Item(setting).Value =
                    botInformation.BotSettings(setting).ToString()
            Next
            DirectCast(settingsSection, AppSettingsSection).Settings.Remove("TempSetting")

            config.Save(ConfigurationSaveMode.Full)
        End Sub

        Public Shared Sub UserSettings(ByRef botInformation As BotInformation)
            Dim fileMap As New ExeConfigurationFileMap()
            fileMap.ExeConfigFilename =
                botInformation.TempExecutablePath & ".config"
            Dim config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                                                                                          ConfigurationUserLevel.None)
            Dim settingsSection
            Dim tempSetting

            settingsSection = config.GetSection("userSettings/PokemonGo.RocketAPI.Console.UserSettings")
            tempSetting = new SettingElement("TempSetting", SettingsSerializeAs.String)

            settingsSection.Settings.Add(tempSetting)
            For Each setting As String In botInformation.BotSettings.Keys
                settingsSection.Settings.Get(Setting).Value.ValueXml.LastChild.InnerText =
                    botInformation.BotSettings(setting).ToString()
            Next
            settingsSection.Settings.Remove(tempSetting)

            config.Save(ConfigurationSaveMode.Full)
        End Sub
    End Class
End NameSpace