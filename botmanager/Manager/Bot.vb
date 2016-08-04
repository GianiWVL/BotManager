Imports System.Timers
Imports BotManager.Helpers
Imports BotManager.Properties
Imports BotManager.Windows

Namespace Manager
    Public Class Bot
        Implements IDisposable
        Public IsSelected As Boolean = False
        Public Shared PanelHandle As Integer
        Public Level As String = ""
        Private _hasRan As Boolean = False
        Public ExperiencePerHour As String = ""
        Public PokeStopsPerHour As String

        Public ReadOnly Property ProcessId As Integer
            Get
                If IsRunning Then
                    Return _p.Id
                Else 
                    Return Nothing
                End If
            End Get
        End Property

        Public ReadOnly Property Handle As IntPtr
            Get
                If IsRunning Then
                    Return _p.MainWindowHandle
                Else 
                    Return Nothing
                End If
            End Get
        End Property
        Public ReadOnly Property IsRunning As Boolean
            Get
                If _p Is Nothing Then
                    Return False
                Else 
                    Return Not _p.HasExited
                End If
            End Get
        End Property
        Public BotInformation As BotInformation

        Protected ExecutablePath As String = ""
        Private _p As Process
        Private ReadOnly _timer As New Timer(500)
        Private _startTime As Date = Nothing


        Public Sub New(ByRef botInformation As BotInformation)
            Me.botInformation = botInformation
            _timer.Stop()
            AddHandler _timer.Elapsed, AddressOf HandleTimer
        End Sub

        Protected Function Initialize() As Boolean
            If File.Exists(ExecutablePath) Then
                BotInformation.TempExecutablePath = IO.CopyFolder(
                    Path.GetDirectoryName(ExecutablePath), BotInformation.SupportedBot.InstanceDirectory) & "\" &
                                                    Path.GetFileName(ExecutablePath)
                Return True
            Else
                MsgBox("Path doesn't Exists")
                My.Settings.ListOfPropertiesBots.Items.Remove(BotInformation)
                Return False
            End If
        End Function
        Public Sub WriteSettings()
            Select Case BotInformation.SupportedBot.ReaderType
                Case ReaderType.JsonSettings
                    BotConfigWriter.JsonSettings(BotInformation)
                Case ReaderType.AppSetting
                    BotConfigWriter.AppSettings(BotInformation)
                Case ReaderType.UserSetting
                    BotConfigWriter.UserSettings(BotInformation)
                Case ReaderType.XmlSettings
                    BotConfigWriter.XmlSettings(BotInformation)
            End Select
        End Sub
        Public Sub Start()
            If Not _hasRan Then 
                Initialize()
                _hasRan = True
            End If
            WriteSettings()

            Dim pInfo As New ProcessStartInfo
            pInfo.WorkingDirectory = Path.GetDirectoryName(BotInformation.TempExecutablePath)
            pInfo.FileName = Path.GetFileName(BotInformation.TempExecutablePath)
            pInfo.WindowStyle = ProcessWindowStyle.Maximized
            Dim p As Process = CmdLine.Run(pInfo)

            _p = Nothing
            _p = p


            Do Until Not IsRunning OrElse Api.GetChildWindows(PanelHandle).Contains(Handle)
                PutConsoleInPanel(Handle)
            Loop


            If IsRunning Then 
                Api.SendMessage(Handle, &H100, 13, 0)
            End If
            _timer.Start()
        End Sub
        Private Sub PutConsoleInPanel(pHandle As Intptr)
            Api.SetParent(pHandle, PanelHandle)

            If IsSelected Then
                Api.ShowWindow(pHandle, 5)
                Api.SetWindowPos(pHandle, 1, 0, 0, Control.FromHandle(PanelHandle).Width,
                                 Control.FromHandle(PanelHandle).Height, 0)
            Else
                Api.ShowWindow(pHandle, 0)
            End If
        End Sub

        Public Sub Kill(Optional delete As Boolean = True)
            If IsRunning Then
                _timer.Stop()
                If Not _p.HasExited Then
                    _p.Kill()
                End If
                _startTime = Nothing
            End If

            If delete Then
                Dim directory As String = Path.GetDirectoryName(BotInformation.TempExecutablePath)

                While Not IO.DirectoryIsEmpty(directory)
                    IO.DeleteFilesFromFolder(directory)
                End While

                _hasRan = False
            End If
        End Sub

        Private Sub HandleTimer(sender As Object, e As EventArgs)
            If _p.HasExited Then
                Start()
            End If

            If botInformation.RestartTimer > 0 Then
                If _startTime = Nothing Then
                    _startTime = Now()
                End If

                If Now() >= _startTime.AddMinutes(botInformation.RestartTimer)
                    Kill(False)
                    Start()
                    _startTime = Now()
                End If
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            If IsRunning Then Kill(True)
            _hasRan = Nothing
            IsSelected = Nothing
            ExecutablePath = Nothing
            If Not _p Is Nothing Then _p.Dispose()
            If Not _timer Is Nothing Then _timer.Dispose()
            _startTime = Nothing
        End Sub
    End Class
End NameSpace