Public Class NewDiagnosticTool

    Public SelectedToolPath
    Public Updating = False
    Public UpdatingIndex


    Private Sub NewDiagnosticTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiagnosticTool_CurrentPath.Text = SelectedToolPath
    End Sub

    Private Sub NewDiagnosticTool_DisgracefulClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Xerox_NVM_Automation_Hub.Show()
        Xerox_NVM_Automation_Hub.Focus()
    End Sub

    Private Sub DiagnosticTool_DoneNew_Click(sender As Object, e As EventArgs) Handles DiagnosticTool_DoneNew.Click
        Dim MachineName = DiagnosticTool_MachineName.Text
        Dim MachineArgument = DiagnosticTool_MachineArgument.Text
        Dim SplitArgument
        If MachineArgument.Contains(Chr(34)) Then
            SplitArgument = MachineArgument.Split(Chr(34))(2)
        Else
            SplitArgument = MachineArgument
        End If
        Dim MachineTitleBar = DiagnosticTool_TitleBar.Text


        If DiagnosticTool_MachineName.Text.Length = 0 Or DiagnosticTool_MachineArgument.Text.Length = 0 Or DiagnosticTool_TitleBar.Text.Length = 0 Then
            MsgBox("Missing Info")
        ElseIf Updating = False Then
            My.Settings.DiagnosticTools_Paths.Add(SelectedToolPath)
            My.Settings.DiagnosticTools_Machines.Add(MachineName.Trim)
            My.Settings.DiagnosticTools_Arguments.Add(SplitArgument.Trim)
            My.Settings.DiagnosticTools_TitleBar.Add(MachineTitleBar.Trim)
            DiagnosticTool_CurrentPath.ReadOnly = True
            Xerox_NVM_Automation_Hub.PopulateDiagnosticTools()
            Me.Hide()
        ElseIf Updating = True Then
            My.Settings.DiagnosticTools_Paths.RemoveAt(UpdatingIndex)
            My.Settings.DiagnosticTools_Paths.Insert(UpdatingIndex, SelectedToolPath)
            My.Settings.DiagnosticTools_Machines.RemoveAt(UpdatingIndex)
            My.Settings.DiagnosticTools_Machines.Insert(UpdatingIndex, MachineName.Trim)
            My.Settings.DiagnosticTools_Arguments.RemoveAt(UpdatingIndex)
            My.Settings.DiagnosticTools_Arguments.Insert(UpdatingIndex, SplitArgument.Trim)
            My.Settings.DiagnosticTools_TitleBar.RemoveAt(UpdatingIndex)
            My.Settings.DiagnosticTools_TitleBar.Insert(UpdatingIndex, MachineTitleBar.Trim)
            DiagnosticTool_CurrentPath.ReadOnly = True
            Xerox_NVM_Automation_Hub.PopulateDiagnosticTools()
            Me.Hide()
        End If
    End Sub



End Class