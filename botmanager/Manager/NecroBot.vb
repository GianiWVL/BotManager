Imports BotManager.List
Imports BotManager.Properties
Imports Newtonsoft.Json.Linq

Namespace Manager
    Public Class NecroBot
        Inherits Generic

        Public Sub New(ByRef botInformation As BotInformation)
            MyBase.New(botInformation)
            ExecutablePath = OfSupportedBots.GetInstance()("Necro").ExecutablePath
        End Sub

        Public Overrides Sub WriteSettings()
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

            For Each setting As String In botInformation.SettingKeys
                If _
                    setting.Equals("AuthType") OrElse setting.Equals("GoogleUsername") OrElse
                    setting.Equals("GooglePassword") OrElse setting.Equals("PtcUsername") OrElse
                    setting.Equals("PtcPassword") Then
                    jObjectAuth(setting) = botInformation.GetSettingValue(setting).ToString()
                Else
                    If  setting.Equals("AutoUpdate") Then
                        jObjectSettings(setting) = "false"
                    Else 
                        jObjectSettings(setting) = botInformation.GetSettingValue(setting).ToString()
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

        Public Shared Sub ReadSettings(ByRef supportedBotInformation As SupportedBotInformation)
            Dim settings As String =
                    New StreamReader(
                        Path.GetDirectoryName(supportedBotInformation.ExecutablePath) & "\Config\config.json").ReadToEnd()
            Dim auth As String =
                    New StreamReader(Path.GetDirectoryName(supportedBotInformation.ExecutablePath) & "\Config\auth.json") _
                    .ReadToEnd()
            Dim jObjectSettings As JObject = JObject.Parse(settings)
            Dim jObjectAuth As JObject = JObject.Parse(auth)

            For each jO As JProperty IN jObjectAuth.Children()
                If (jO.Value.GetType().ToString().Contains("Newtonsoft.Json.Linq.JValue")) Then
                    supportedBotInformation.AddKeyValue(jo.Name, jo.Value.ToString())
                End If
            Next

            For each jO As JProperty IN jObjectSettings.Children()
                If (jO.Value.GetType().ToString().Contains("Newtonsoft.Json.Linq.JValue")) Then
                    supportedBotInformation.AddKeyValue(jo.Name, jo.Value.ToString())
                End If
            Next
        End Sub
    End Class
End NameSpace