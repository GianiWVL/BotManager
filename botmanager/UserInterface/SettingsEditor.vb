﻿Namespace UserInterface
    Public Class SettingsEditor
        Private ReadOnly _botProperties As Properties.BotInformation
        Public BatchAddProperties As List(Of Properties.BotInformation)

        Public Sub New (ByRef botProperties As Properties.BotInformation)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _botProperties = botProperties

        End Sub
        Private Sub SettingsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Select Case _botProperties.BotClass
                Case "BotManager.Manager.Type.Haxton"
                    AddToGridView(List.OfSupportedBots.GetInstance()("Haxton"))
                Case "BotManager.Manager.Type.Spegeli"
                    AddToGridView(List.OfSupportedBots.GetInstance()("Spegeli"))
            End Select
        End Sub
        Private Sub AddToGridView(supportedBotInformation As Properties.SupportedBotInformation)
            Dim newTable As New DataTable
            newTable.Columns.Add("Name")
            newTable.Columns.Add("Value")
            For i As Integer = 0 To supportedBotInformation.SettingKeys.Count - 1
                newTable.Rows.Add(supportedBotInformation.SettingKeys(i),supportedBotInformation.SettingValues(i))
                _botProperties.AddKeyValue(supportedBotInformation.SettingKeys(i), supportedBotInformation.SettingValues(i))
            Next
        
            txtRestartTimer.Text = _botProperties.RestartTimer
            DataGridView1.DataSource = newTable
        End Sub
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            batchAddProperties = New List(Of Properties.BotInformation)
            For row As Integer = 0 To DataGridView1.Rows.Count - 2
                _botProperties.SettingValues.Item(row) = DataGridView1.Rows(row).Cells(1).Value.ToString()
            Next

            If Not Integer.TryParse(txtRestartTimer.Text, _botProperties.RestartTimer) Then
                _botProperties.RestartTimer = 0
            End If

            If chkBatchAdd.Checked Then
                Dim reader As New StreamReader(TextBox1.Text)
                Dim content As String() = reader.ReadToEnd().Split(vbcrlf)
                Dim newBotProperty As Properties.BotInformation


                For Each line As String In content
                    newBotProperty = New Properties.BotInformation()
                    newBotProperty.RestartTimer = _botProperties.RestartTimer
                    newBotProperty.BotClass = _botProperties.BotClass
                    For i As Integer = 0 To _botProperties.SettingKeys.Count - 1
                        newBotProperty.AddKeyValue(_botProperties.SettingKeys(i), _botProperties.SettingValues(i))
                    Next

                    Dim settings As String() = line.Trim(vbLf).Split(",")

                    For Each setting As String In settings
                        Dim field As String = setting.Split(":")(0)
                        Dim value As String = setting.Split(":")(1)

                        newBotProperty.SettingValues(newBotProperty.SettingKeys.IndexOf(field)) = value
                    Next

                    batchAddProperties.Add(newBotProperty)
                Next
            Else 
                batchAddProperties.Add(_botProperties)
            End If

            DialogResult = DialogResult.OK
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            DialogResult = DialogResult.Cancel
        End Sub
        Private Sub chkBatchAdd_CheckedChanged(sender As Object, e As EventArgs) Handles chkBatchAdd.CheckedChanged
            TextBox1.Enabled = chkBatchAdd.Checked
        End Sub
    End Class
End NameSpace