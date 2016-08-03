﻿Imports BotManager.Interfaces

Namespace Properties
    Public Class SupportedBotInformation
        Implements ISettings
        Public Property Name As String
        Public Property ZipName As String
        Public Property UnZipDirectory As String
        Public Property DownloadUrl As String
        Public Property WorkingDirectory As String
        Public Property ExecutablePath As String
        Public Property DisplayAsBot As Boolean = True
        Public Property BotClass As String

        Public Property SettingKeys As New List(Of String) Implements ISettings.SettingKeys

        Public Property SettingValues As New List(Of String) Implements ISettings.SettingValues


        Public Sub AddKeyValue(key As String, value As String) Implements ISettings.AddKeyValue
            If SettingKeys.Contains(key) Then
                SettingValues.Item(SettingKeys.IndexOf(key)) = Value
            Else
                SettingKeys.Add(key)
                SettingValues.Add(value)
            End If
        End Sub

        Public Function GetSettingValue(key As String) As String Implements ISettings.GetSettingValue
            Dim indexOfKey As Integer = SettingKeys.IndexOf(key)
            Return SettingValues.Item(indexOfKey)
        End Function
    End Class
End NameSpace