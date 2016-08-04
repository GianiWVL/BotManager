Imports BotManager.Helpers
Imports BotManager.UserInterface.Download

Public Class BotSettings
    Inherits Dictionary(Of String, String)
     Public Sub New()

     End Sub
    Public Sub New(ByRef supportedBot As SupportedBot)
        Select Case supportedBot.ReaderType
            Case ReaderType.JsonSettings
                BotConfigReader.JsonSettings(supportedBot)
            Case ReaderType.AppSetting
                BotConfigReader.AppSettings(supportedBot)
            Case ReaderType.UserSetting
                BotConfigReader.UserSettings(supportedBot)
            Case ReaderType.XmlSettings
                BotConfigReader.XmlSettings(supportedBot)
        End Select
    End Sub

    Public Function Clone() As BotSettings
        Dim newBotSettings As New BotSettings
        For Each key As String In Me.Keys
            newBotSettings.Add(key, Me(key))
        Next

        Return newBotSettings
    End Function
End Class

Public Enum ReaderType
    JsonSettings = 0
    UserSetting = 1
    AppSetting = 2
    XmlSettings = 3
End Enum