Imports BotManager.Interfaces
Imports BotManager.List
Imports BotManager.Properties
Imports BotManager.UserInterface.Download

Namespace UserInterface.Settings
    Public Class Bot
        Private ReadOnly _botProperties As BotInformation
        Public BatchAddProperties As List(Of BotInformation)

        Public Sub New(ByRef botProperties As BotInformation)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _botProperties = botProperties
        End Sub

        Private Sub SettingsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
               AddToGridView(_botProperties.BotSettings)
        End Sub

        Private Sub AddToGridView(botSettings As BotSettings)
            Dim newTable As New DataTable
            newTable.Columns.Add("Name")
            newTable.Columns.Add("Value")
            For Each setting As String In botSettings.Keys
                newTable.Rows.Add(setting, botSettings(setting))
            Next

            txtRestartTimer.Text = _botProperties.RestartTimer
            chkHide.Checked = _botProperties.Hide
            DataGridView1.DataSource = newTable
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            BatchAddProperties = New List(Of BotInformation)

            For row = 0 To DataGridView1.Rows.Count - 2
                _botProperties.BotSettings(DataGridView1.Rows(row).Cells(0).Value.ToString()) = DataGridView1.Rows(row).Cells(1).Value.ToString()
            Next

            If Not Integer.TryParse(txtRestartTimer.Text, _botProperties.RestartTimer) Then
                _botProperties.RestartTimer = 0
            End If
            _botProperties.Hide = chkHide.Checked
            If chkBatchAdd.Checked Then
                Dim currentLineIndex As String = ""
                Dim currentLine As String = 0
                Dim currentField As String = ""
                Try
                    Dim reader As New StreamReader(fileLoc.Text)
                    Dim content = reader.ReadToEnd().Trim().Split(vbCrLf)
                    reader.Dispose()
                    Dim newBotProperty As BotInformation


                    For j As Integer = 0 To content.Length - 1
                        currentLine = content(j)
                        currentLineIndex = j
                        newBotProperty = New BotInformation(_botProperties.SupportedBot)
                        newBotProperty.Hide = _botProperties.Hide
                        newBotProperty.RestartTimer = _botProperties.RestartTimer

                        newBotProperty.BotSettings = _botProperties.BotSettings.Clone()

                        Dim settings As String() = currentLine.Trim(vbLf).Split(",")
                        If settings.Length = 0 Then Continue For
                        For Each setting As String In settings
                            Dim field As String = setting.Split(":")(0)
                            Dim value As String = setting.Split(":")(1)
                            If field = "" OrElse value = "" Then Continue For

                            currentField = field
                            If newBotProperty.BotSettings.ContainsKey(field) Then
                                newBotProperty.BotSettings(field) = value
                            Else 
                                Throw New Exception("YOU BIG DUMBY, THAT FIELD DOESN'T EXISTS")
                            End If
                        Next

                        BatchAddProperties.Add(newBotProperty)
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & vbCrLf &
                           "Line Index: " & currentLineIndex & vbCrLf &
                           "Field: " & currentField)
                    Exit Sub
                End Try
            Else
                BatchAddProperties.Add(_botProperties)
            End If

            DialogResult = DialogResult.OK
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            DialogResult = DialogResult.Cancel
        End Sub

        Private Sub chkBatchAdd_CheckedChanged(sender As Object, e As EventArgs) Handles chkBatchAdd.CheckedChanged
            browseBtn.Enabled = chkBatchAdd.Checked
            fileLoc.Enabled = chkBatchAdd.Checked
        End Sub

        Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click
            Using LD As New OpenFileDialog()
                LD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                If LD.ShowDialog = DialogResult.OK Then
                    fileLoc.Text = LD.FileName
                End If
            End Using
        End Sub
    End Class
End NameSpace