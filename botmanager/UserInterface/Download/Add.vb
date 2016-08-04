Namespace UserInterface.Download
    Public Class Add
        Public SupportedBot As SupportedBot
        Public Sub New(ByRef supportedBot As SupportedBot)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            If supportedBot Is Nothing Then
                Me.SupportedBot = New SupportedBot()
            Else
                Me.SupportedBot = supportedBot
            End If

            txtName.Text = Me.SupportedBot.RootDirectory
            lbConfigPaths.Items.AddRange(Me.SupportedBot.ConfigPaths)
            txtDownloadUrl.Text = Me.SupportedBot.DownloadUrl
            txtExecutablePath.Text = Me.SupportedBot.ExecutablePath

            Select Case supportedBot.ReaderType
                Case ReaderType.JsonSettings
                    rbJsonSetting.Checked = True
                Case ReaderType.AppSetting
                    rbAppSetting.Checked = True
                Case ReaderType.UserSetting
                    rbUserSettings.Checked = True
                Case ReaderType.XmlSettings
                    rbXmlSetting.Checked = True
            End Select

            ckAutoUpdate.Checked = supportedBot.AutoUpdate
        End Sub

        Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
                        txtName.Text = Me.SupportedBot.RootDirectory

            SupportedBot.ConfigPaths = {}
            lbConfigPaths.Items.CopyTo(SupportedBot.ConfigPaths, 0)
            SupportedBot.DownloadUrl = txtDownloadUrl.Text
            SupportedBot.ExecutablePath = txtExecutablePath.Text

            Select Case True
                Case rbJsonSetting.Checked
                    SupportedBot.ReaderType = ReaderType.JsonSettings
                Case rbAppSetting.Checked
                    SupportedBot.ReaderType = ReaderType.AppSetting
                Case rbUserSettings.Checked
                    SupportedBot.ReaderType = ReaderType.UserSetting
                Case rbXmlSetting.Checked
                    SupportedBot.ReaderType = ReaderType.XmlSettings
            End Select

            supportedBot.AutoUpdate = ckAutoUpdate.Checked
        End Sub
    End Class
End NameSpace