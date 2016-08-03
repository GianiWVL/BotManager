Imports System.Configuration
Imports BotManager.List
Imports BotManager.Properties

Namespace Manager
    Public Class HaxtonBot
        Inherits Generic

        Public Sub New(ByRef botInformation As BotInformation)
            MyBase.New(botInformation)
            ExecutablePath = OfSupportedBots.GetInstance()("HaxtonBot").ExecutablePath
        End Sub

        Public Overrides Sub WriteSettings()
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

            For Each setting As String In botInformation.SettingKeys
                DirectCast(settingsSection, AppSettingsSection).Settings.Item(Setting).Value =
                    botInformation.GetSettingValue(setting).ToString()
            Next
            DirectCast(settingsSection, AppSettingsSection).Settings.Remove("TempSetting")

            config.Save(ConfigurationSaveMode.Full)
        End Sub

        Public Shared Sub ReadSettings(ByRef supportedBotInformation As SupportedBotInformation)
            Dim fileMap As New ExeConfigurationFileMap()
            fileMap.ExeConfigFilename =
                supportedBotInformation.ExecutablePath & ".config"
            Dim config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                                                                                          ConfigurationUserLevel.None)
            Dim settingsSection
            settingsSection = config.AppSettings

            For Each setting In settingsSection.Settings
                supportedBotInformation.AddKeyValue(setting.[Key], setting.Value.ToString())
            Next
        End Sub
    End Class
End NameSpace