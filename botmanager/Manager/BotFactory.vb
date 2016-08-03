Imports BotManager.Properties

Namespace Manager
    Public Class BotFactory
        Public Shared Function GetBot(ByRef botProperties As BotInformation) As Generic
            Select Case botProperties.BotClass
                Case "BotManager.Manager.HaxtonBot"
                    Return New HaxtonBot(botProperties)
                Case "BotManager.Manager.SpegeliBot"
                    Return New SpegeliBot(botProperties)
                Case "BotManager.Manager.NecroBot"
                    Return New NecroBot(botProperties)
                Case "BotManager.Manager.PokeMobBot"
                    Return New PokeMobBot(botProperties)
            End Select

            Throw New Exception("Uknown Bot Class!")
        End Function
    End Class
End NameSpace