Imports BotManager.UserInterface.Download

Namespace Properties
    <Serializable>
    Public Class BotInformation
        Public TempExecutablePath As String = ""
        Public RestartTimer As Integer
        Public Hide As Boolean = False
        Public SupportedBot As SupportedBot
        Public BotSettings As BotSettings

        Public Sub New(supportedBot As SupportedBot)
            Me.SupportedBot = supportedBot
            Me.BotSettings = supportedBot.Settings.Clone()
        End Sub
    End Class
End NameSpace