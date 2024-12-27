Imports System.IO
Imports System.Text

Public Class Xerox_NVM_Automation_Hub

    Public Desktop As String = (My.Computer.FileSystem.SpecialDirectories.Desktop) & "\"

    Public encodingASCII As Encoding = System.Text.Encoding.ASCII

    Public PWSLockProcess() As Process = Process.GetProcessesByName("PWSLock")

    Public TimestampFirst As Boolean = True
    Public TimestampCount As Integer = 0
    Public TimestampToWrite As String
    Public TimestampFileName As String = "Timestamp.txt"
    Public objWriter As System.IO.StreamWriter
    Public append As Boolean = True

    Declare Sub Sleep Lib "kernel32.dll" (ByVal milliseconds As Long)

    Private Sub Xerox_NVM_Automation_Hub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.Version = My.Application.Info.Version.ToString Then
            My.Settings.Upgrade()
            My.Settings.Version = My.Application.Info.Version.ToString
            My.Settings.Save()
        End If

        My.Settings.CurrentEXEPath = Application.ExecutablePath

        Version_Label.Text = "v" & My.Application.Info.Version.ToString
        github_Logo.Image = My.Resources.ResourceManager.GetObject("github-mark")

        PopulateDiagnosticTools()
        PopulateNVMDirectories()

        If Environment.Is64BitOperatingSystem And Not Debugger.IsAttached Then
            MsgBox("It looks like you're using a 64-Bit Operating System" & vbCrLf &
                   "If you have a 64-Bit version of the Xerox PWS Driver, please share it with me!", MsgBoxStyle.OkOnly)

        End If
    End Sub

    '========================================
    '========== Check for PWS Lock ==========
    '========================================

    'This checks to see if the PWSLock process is running. This is because the Diagnostic Tool won't start if PWSLock isn't running
    'If it's not running, it will start PWSLock and offer to autofill your password
    Function RunPWSLock()
        If (My.Computer.FileSystem.FileExists(My.Settings.PWSLock_Path)) And (PWSLockProcess.Count < 1) = True Then
            Dim StartPWSLock As Integer = Shell(My.Settings.PWSLock_Path, AppWinStyle.NormalFocus)

            If My.Settings.PWSLock_Password.Length = 0 And My.Settings.PWSLock_Password_EnterAsked = False Then
                Dim SavePWSPassword = MsgBox("Would you like to save your PWSLock Password for easy startup?", MsgBoxStyle.YesNo)
                My.Settings.PWSLock_Password_EnterAsked = True
                If SavePWSPassword = vbYes Then
                    My.Settings.PWSLock_Password = InputBox("Enter password:")
                    Try
                        AppActivate(StartPWSLock)
                    Catch ex As Exception

                    End Try

                    My.Computer.Keyboard.SendKeys(My.Settings.PWSLock_Password, True)
                    My.Computer.Keyboard.SendKeys("~")
                Else
                    AppActivate(StartPWSLock)
                End If
            ElseIf My.Settings.PWSLock_Password_Enter = True And My.Settings.PWSLock_Password.Length > 0 Then
                AppActivate(StartPWSLock)
                My.Computer.Keyboard.SendKeys(My.Settings.PWSLock_Password, True)
                My.Computer.Keyboard.SendKeys("~")
            Else
                AppActivate(StartPWSLock)
            End If
        ElseIf (Not My.Computer.FileSystem.FileExists(My.Settings.PWSLock_Path)) Or (My.Settings.PWSLock_Path.Length = 0) Then
            MsgBox("The path to PWS Lock doesn't seem to be set correctly")
            OpenPWSLockSettings.PerformClick()
            Return False
        End If
        Return True
    End Function

    '========================================
    '======= Diagnostic Tool Functions ======
    '========================================

    Public Sub PopulateDiagnosticTools()
        DiagnosticToolDropdown.DataSource = Nothing
        DiagnosticToolDropdown.Items.Clear()
        DiagnosticToolDropdown.DataSource = My.Settings.DiagnosticTools_Machines
    End Sub

    Private Sub RunDiagnosticTool(Mode)
        If My.Settings.NVMScriptDirectories_Paths.Count = 0 Then
            MsgBox("You haven't set up any of the Diagnostic Tools yet!")
            Exit Sub
        End If
        If RunPWSLock() = False Then
            Exit Sub
        End If

        Dim DiagnosticToolSelected = DiagnosticToolDropdown.SelectedIndex
        Dim NVMScriptDirectorySelected = NVMScriptsDropdown.SelectedIndex

        If My.Computer.FileSystem.FileExists(My.Settings.DiagnosticTools_Paths(DiagnosticToolSelected)) Then
            If Mode = "Normal" Then
                Process.Start(My.Settings.DiagnosticTools_Paths(DiagnosticToolSelected), My.Settings.DiagnosticTools_Arguments(DiagnosticToolSelected))
                Me.WindowState = FormWindowState.Minimized
            ElseIf Mode = "Automatic" Then
                If CheckForNVMScripts(NVMScriptDirectorySelected) = False Then
                    Exit Sub
                End If

                Dim DiagnosticToolProcess() As Process = Process.GetProcessesByName(My.Settings.DiagnosticTools_Paths(DiagnosticToolSelected))
                If DiagnosticToolProcess.Count < 1 Then
                    Dim StartDiagnosticToolProcess As Integer = Shell(Chr(34) & My.Settings.DiagnosticTools_Paths(DiagnosticToolSelected) & Chr(34) & " " & My.Settings.DiagnosticTools_Arguments(DiagnosticToolSelected), AppWinStyle.NormalFocus)
                    Sleep(500)
                    Try
                        AppActivate(StartDiagnosticToolProcess)
                    Catch ex As Exception

                    End Try
                End If

                Invoke(Sub() RunAutoNVMCaptureBase(My.Settings.DiagnosticTools_TitleBar(DiagnosticToolSelected), My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected)))

            End If
        Else
            MsgBox("The tool you selected seems to be missing")
            'Add options
        End If
    End Sub

    Private Sub AddNewDiagnosticTool()
        Dim OpenFileDialog_DiagnosticToolPath As New OpenFileDialog()

        OpenFileDialog_DiagnosticToolPath.InitialDirectory = "C:\Xerox\PWS Diagnostic Tool\"
        OpenFileDialog_DiagnosticToolPath.Filter = "PWSDiagnosticsTool.exe|*.exe"

        If OpenFileDialog_DiagnosticToolPath.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim SelectedToolPath = New FileInfo(OpenFileDialog_DiagnosticToolPath.FileName).FullName.ToString()

            If My.Settings.DiagnosticTools_Paths.Contains(SelectedToolPath) Then
                Dim ExistingIndex = My.Settings.DiagnosticTools_Paths.IndexOf(SelectedToolPath)
                Dim Duplicate = MsgBox("That path is already registered as " & My.Settings.DiagnosticTools_Machines(ExistingIndex) & "; Register Again?", MsgBoxStyle.YesNo)
                If Duplicate = MsgBoxResult.Yes Then
                    NewDiagnosticTool.SelectedToolPath = SelectedToolPath
                    NewDiagnosticTool.Show()
                End If
            Else
                NewDiagnosticTool.SelectedToolPath = SelectedToolPath
                NewDiagnosticTool.Show()
                Me.Hide()
                NewDiagnosticTool.Focus()
            End If
        End If
    End Sub

    Private Sub DiagnosticTool_Delete_Click(sender As Object, e As EventArgs) Handles DiagnosticTool_Delete.Click
        If My.Settings.NVMScriptDirectories_Paths.Count = 0 Then
            MsgBox("You haven't set up any of the Diagnostic Tools yet!")
            Exit Sub
        End If

        Dim SelectedEntry = DiagnosticToolDropdown.SelectedIndex
        Dim Confirm = MsgBox("Are you sure you want to delete the entry '" & My.Settings.DiagnosticTools_Machines(SelectedEntry) & "'?", MsgBoxStyle.YesNo)
        If Confirm = MsgBoxResult.Yes Then
            My.Settings.DiagnosticTools_Paths.RemoveAt(SelectedEntry)
            My.Settings.DiagnosticTools_Machines.RemoveAt(SelectedEntry)
            My.Settings.DiagnosticTools_Arguments.RemoveAt(SelectedEntry)
            My.Settings.DiagnosticTools_TitleBar.RemoveAt(SelectedEntry)
            PopulateDiagnosticTools()
        End If
    End Sub

    Private Sub DiagnosticTool_EditEntry_Click(sender As Object, e As EventArgs) Handles DiagnosticTool_EditEntry.Click
        If My.Settings.NVMScriptDirectories_Paths.Count = 0 Then
            MsgBox("You haven't set up any of the Diagnostic Tools yet!")
            Exit Sub
        End If

        Dim SelectedEntry = DiagnosticToolDropdown.SelectedIndex

        NewDiagnosticTool.Updating = True
        NewDiagnosticTool.UpdatingIndex = SelectedEntry

        NewDiagnosticTool.SelectedToolPath = My.Settings.DiagnosticTools_Paths(SelectedEntry)
        NewDiagnosticTool.DiagnosticTool_MachineName.Text = My.Settings.DiagnosticTools_Machines(SelectedEntry)
        NewDiagnosticTool.DiagnosticTool_MachineArgument.Text = My.Settings.DiagnosticTools_Arguments(SelectedEntry)
        NewDiagnosticTool.DiagnosticTool_TitleBar.Text = My.Settings.DiagnosticTools_TitleBar(SelectedEntry)

        NewDiagnosticTool.DiagnosticTool_CurrentPath.ReadOnly = False

        NewDiagnosticTool.Show()
        Me.Hide()
        NewDiagnosticTool.Focus()
    End Sub
    '========================================
    '======== NVM Directory Functions =======
    '========================================
    Private Sub PopulateNVMDirectories()
        NVMScriptsDropdown.DataSource = Nothing
        NVMScriptsDropdown.Items.Clear()
        NVMScriptsDropdown.DataSource = My.Settings.NVMScriptDirectories_Names
    End Sub

    Function CheckForNVMScripts(NVMScriptDirectorySelected)
        lbxAllNVMScripts.Items.Clear()

        If My.Settings.NVMScriptDirectories_Paths.Count = 0 Then
            MsgBox("You haven't added any NVM Directories yet!")
            Return False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected)) Then
            MsgBox("Can't find the selected NVM Script Directory")
            Return False
        End If

        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected) & "\Done") Then
            My.Computer.FileSystem.CreateDirectory(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected) & "\Done")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected) & "\SaveFiles") Then
            My.Computer.FileSystem.CreateDirectory(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected) & "\SaveFiles")
        End If

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected), FileIO.SearchOption.SearchTopLevelOnly, "*.csv")
            Dim FileName As String = Path.GetFileName(foundFile)
            lbxAllNVMScripts.Items.Add(FileName)
        Next

        Return True
    End Function

    Private Sub NVMScripts_Reset_Click(sender As Object, e As EventArgs) Handles NVMScripts_Reset.Click
        If My.Settings.NVMScriptDirectories_Paths.Count = 0 Then
            MsgBox("You haven't added any NVM Directories yet!")
            Exit Sub
        End If
        Dim NVMScriptDirectorySelected = NVMScriptsDropdown.SelectedIndex
        lbxAllNVMScripts.Items.Clear()

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected) & "\Done", FileIO.SearchOption.SearchTopLevelOnly, "*.csv")
            Dim FileName As String = Path.GetFileName(foundFile)
            lbxAllNVMScripts.Items.Add(FileName)
        Next

        For X As Integer = 0 To lbxAllNVMScripts.Items.Count - 1
            My.Computer.FileSystem.MoveFile(My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected) & "\Done\" & lbxAllNVMScripts.Items(0).ToString, My.Settings.NVMScriptDirectories_Paths(NVMScriptDirectorySelected) & "\" & lbxAllNVMScripts.Items(0).ToString)
            lbxAllNVMScripts.Items.RemoveAt(0)
        Next

        CheckForNVMScripts(NVMScriptDirectorySelected)
    End Sub

    Private Sub AddNewNVMScriptDirectory()
        Dim FolderBrowserDialog_ScriptDirectoryPath As New FolderBrowserDialog()

        FolderBrowserDialog_ScriptDirectoryPath.InitialDirectory = "C:\"

        If FolderBrowserDialog_ScriptDirectoryPath.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim SelectedNVMScriptPath = New FileInfo(FolderBrowserDialog_ScriptDirectoryPath.SelectedPath).FullName.ToString()

            If My.Settings.NVMScriptDirectories_Paths.Contains(SelectedNVMScriptPath) Then
                Dim ExistingIndex = My.Settings.NVMScriptDirectories_Paths.IndexOf(SelectedNVMScriptPath)
                Dim Duplicate = MsgBox("That path is already registered as " & My.Settings.NVMScriptDirectories_Names(ExistingIndex) & "; Register Again?", MsgBoxStyle.YesNo)
                If Duplicate = MsgBoxResult.Yes Then
                    Dim DirectoryName = InputBox("What should this directory be called?", "Enter Directory Alias")
                    My.Settings.NVMScriptDirectories_Paths.Add(SelectedNVMScriptPath)
                    My.Settings.NVMScriptDirectories_Names.Add(DirectoryName.Trim)

                    PopulateNVMDirectories()
                End If
            Else
                Dim DirectoryName = InputBox("What should this directory be called?", "Enter Directory Alias")
                My.Settings.NVMScriptDirectories_Paths.Add(SelectedNVMScriptPath)
                My.Settings.NVMScriptDirectories_Names.Add(DirectoryName.Trim)

                PopulateNVMDirectories()
            End If
        End If
    End Sub

    Private Sub NVMScripts_DeleteEntry_Click(sender As Object, e As EventArgs) Handles NVMScripts_DeleteEntry.Click
        If My.Settings.NVMScriptDirectories_Paths.Count = 0 Then
            MsgBox("You haven't added any NVM Directories yet!")
            Exit Sub
        End If
        Dim SelectedEntry = NVMScriptsDropdown.SelectedIndex
        Dim Confirm = MsgBox("Are you sure you want to delete the entry " & My.Settings.NVMScriptDirectories_Names(SelectedEntry) & "?", MsgBoxStyle.YesNo)
        If Confirm = MsgBoxResult.Yes Then
            My.Settings.NVMScriptDirectories_Paths.RemoveAt(SelectedEntry)
            My.Settings.NVMScriptDirectories_Names.RemoveAt(SelectedEntry)
            PopulateNVMDirectories()
        End If
    End Sub

    '========================================
    '=========== NVM Auto Capture ===========
    '========================================

    Private Sub RunAutoNVMCaptureBase(MachineTitleBar, NVMScriptDirectorySelected)
        Dim ScriptDialog As Integer
        Dim DiagToolEntry As Integer
        Dim DiagToolNVM As Integer
        Dim DiagToolReadingNVM As Integer
        Dim DiagToolDoneReading As Integer
        Dim SaveDialog As Integer


        Do Until DiagToolEntry > 0
            DiagToolEntry = FindWindow(Nothing, "Diagnostics")
            Sleep(1)
        Loop
        SetForegroundWindow(DiagToolEntry)

        Sleep(10000) 'Wait for initial program to start

        My.Computer.Keyboard.SendKeys("{TAB}")
        Sleep(500)
        My.Computer.Keyboard.SendKeys("~")

        Do
            Sleep(10000) 'Wait for NVM read section to load

            My.Computer.Keyboard.SendKeys("{TAB 5}")
            Sleep(500)
            My.Computer.Keyboard.SendKeys("~")
            Sleep(1000)

            ScriptDialog = FindWindow(Nothing, "Select NVM Access Script File")
            Sleep(1)
        Loop Until ScriptDialog > 0
        SetForegroundWindow(ScriptDialog)

        Sleep(500)
        My.Computer.Keyboard.SendKeys("{TAB 4}") 'CREATE IF FOR WINDOWS 10 WITH 5 TABS
        Sleep(500)
        My.Computer.Keyboard.SendKeys("~") 'Now in File Path Navigator
        Sleep(500)
        My.Computer.Keyboard.SendKeys(NVMScriptDirectorySelected)
        Sleep(500)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(500)
        My.Computer.Keyboard.SendKeys("+{TAB 6}") 'CREATE IF FOR WINDOWS 10 WITH 9 TABS
        Sleep(500)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(500)
        My.Computer.Keyboard.SendKeys("{DOWN 2}")
        Sleep(500)
        My.Computer.Keyboard.SendKeys("~") 'Select file and load script

        Sleep(5000) 'Wait for NVM read values to propegate

        My.Computer.Keyboard.SendKeys("{TAB 3}")
        Sleep(500)
        My.Computer.Keyboard.SendKeys("~") 'Read All NVMs

        Do
            DiagToolReadingNVM = FindWindow(Nothing, MachineTitleBar & " - NVM Access Create Snapshot In progress ...")
            Sleep(1)
        Loop Until DiagToolReadingNVM > 0
        Do
            DiagToolReadingNVM = FindWindow(Nothing, MachineTitleBar & " - NVM Access Create Snapshot In progress ...")
            Sleep(1)
        Loop Until DiagToolReadingNVM < 1
        Do
            DiagToolNVM = FindWindow(Nothing, MachineTitleBar)
            Sleep(1)
        Loop Until DiagToolNVM > 1

        SetForegroundWindow(DiagToolNVM)

        Dim InfoLoop As Integer = 0
        Do
            DiagToolDoneReading = FindWindow(Nothing, "Information")
            Sleep(1)
            InfoLoop += 1
        Loop Until DiagToolDoneReading > 0 Or InfoLoop > 3000

        If DiagToolDoneReading > 0 Then
            SetForegroundWindow(DiagToolDoneReading)

            My.Computer.Keyboard.SendKeys("{TAB}")
            Sleep(100)
            My.Computer.Keyboard.SendKeys("~")

            Sleep(100)
        ElseIf InfoLoop > 3000 Then
            Sleep(1000)
        End If

        SetForegroundWindow(DiagToolNVM)

        My.Computer.Keyboard.SendKeys("{TAB 6}")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")

        Do
            Sleep(1000)
            SaveDialog = FindWindow(Nothing, "Save NVM Access Snapshot DB")
            Sleep(1)
        Loop Until SaveDialog > 0
        SetForegroundWindow(SaveDialog)

        My.Computer.Keyboard.SendKeys("{TAB 5}")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(100)
        My.Computer.Keyboard.SendKeys(NVMScriptDirectorySelected & "\SaveFiles")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("+{TAB 2}")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")

        If DiagnosticTool_Timestamp.Checked Then
            Timestamp(NVMScriptDirectorySelected)
        End If

        My.Computer.FileSystem.MoveFile(NVMScriptDirectorySelected & "\" & lbxAllNVMScripts.Items(0).ToString, NVMScriptDirectorySelected & "\Done\" & lbxAllNVMScripts.Items(0).ToString)
        lbxAllNVMScripts.Items.RemoveAt(0)

        For X As Integer = 0 To lbxAllNVMScripts.Items.Count - 1
            Invoke(Sub() RunAutoNVMReading(MachineTitleBar, NVMScriptDirectorySelected))
        Next

    End Sub

    Private Sub RunAutoNVMReading(MachineTitleBar, NVMScriptDirectorySelected)
        Dim ScriptDialog As Integer
        Dim DiagToolNVM As Integer
        Dim DiagToolReadingNVM As Integer
        Dim DiagToolDoneReading As Integer
        Dim SaveDialog As Integer
        Dim SaveDialogOverwrite As Integer
        Dim SaveDialogDone As Boolean = False


        DiagToolNVM = FindWindow(Nothing, MachineTitleBar)
        SetForegroundWindow(DiagToolNVM)

        Sleep(200)

        My.Computer.Keyboard.SendKeys("{TAB 6}")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")

        Do
            Sleep(1000)
            ScriptDialog = FindWindow(Nothing, "Select NVM Access Script File")
            Sleep(1)
        Loop Until ScriptDialog > 0
        SetForegroundWindow(ScriptDialog)

        Sleep(100)
        My.Computer.Keyboard.SendKeys("{TAB 4}") 'CREATE IF FOR WINDOWS 10 WITH 5 TABS
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~") 'Now in File Path Navigator
        Sleep(100)
        My.Computer.Keyboard.SendKeys(NVMScriptDirectorySelected)
        Sleep(250)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(250)
        My.Computer.Keyboard.SendKeys("+{TAB 6}") 'CREATE IF FOR WINDOWS 10 WITH 9 TABS
        'Sleep(500)
        'My.Computer.Keyboard.SendKeys("~")
        Sleep(250)
        My.Computer.Keyboard.SendKeys("{DOWN}")
        Sleep(250)
        My.Computer.Keyboard.SendKeys("~") 'Select file and load script

        Sleep(2000) 'Wait for NVM read values to propegate

        My.Computer.Keyboard.SendKeys("{TAB 3}")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~") 'Read All NVMs

        Do
            DiagToolReadingNVM = FindWindow(Nothing, MachineTitleBar & " - NVM Access Create Snapshot In progress ...")
            Sleep(1)
        Loop Until DiagToolReadingNVM > 0
        Do
            DiagToolReadingNVM = FindWindow(Nothing, MachineTitleBar & " - NVM Access Create Snapshot In progress ...")
            Sleep(1)
        Loop Until DiagToolReadingNVM < 1
        Do
            DiagToolNVM = FindWindow(Nothing, MachineTitleBar)
            Sleep(1)
        Loop Until DiagToolNVM > 1

        SetForegroundWindow(DiagToolNVM)
        Dim InfoLoop As Integer = 0

        Do
            DiagToolDoneReading = FindWindow(Nothing, "Information")
            Sleep(1)
            InfoLoop += 1
        Loop Until DiagToolDoneReading > 0 Or InfoLoop > 3000

        If DiagToolDoneReading > 0 Then
            SetForegroundWindow(DiagToolDoneReading)

            My.Computer.Keyboard.SendKeys("{TAB}")
            Sleep(100)
            My.Computer.Keyboard.SendKeys("~")

            Sleep(100)
        ElseIf InfoLoop > 3000 Then
            Sleep(1000)
        End If

        SetForegroundWindow(DiagToolNVM)

        My.Computer.Keyboard.SendKeys("{TAB 6}")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")

        Do
            Sleep(500)
            SaveDialog = FindWindow(Nothing, "Save NVM Access Snapshot DB")
            Sleep(1)
        Loop Until SaveDialog > 0
        SetForegroundWindow(SaveDialog)

        My.Computer.Keyboard.SendKeys("{TAB 5}")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(100)
        My.Computer.Keyboard.SendKeys(NVMScriptDirectorySelected & "\SaveFiles")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("~")
        Sleep(100)
        My.Computer.Keyboard.SendKeys("+{TAB 2}")
        Sleep(200)
        My.Computer.Keyboard.SendKeys("~")

        Dim OverwriteCounter As Integer = 0
        Do
            Sleep(250)
            SaveDialogOverwrite = FindWindow(Nothing, "Confirm Save As")
            If SaveDialogOverwrite > 0 Then
                SetForegroundWindow(SaveDialogOverwrite)
                Sleep(100)
                My.Computer.Keyboard.SendKeys("{TAB}")
                Sleep(100)
                My.Computer.Keyboard.SendKeys("~")

                My.Computer.FileSystem.MoveFile(NVMScriptDirectorySelected & "\" & lbxAllNVMScripts.Items(0).ToString, NVMScriptDirectorySelected & "\Done\" & lbxAllNVMScripts.Items(0).ToString)
                lbxAllNVMScripts.Items.RemoveAt(0)
                Exit Sub
            End If
            OverwriteCounter += 1
        Loop Until OverwriteCounter >= 4

        Do
            Sleep(250)
            SaveDialog = FindWindow(Nothing, "Save NVM Access Snapshot DB")
            If SaveDialog > 0 Then
                My.Computer.Keyboard.SendKeys("~")
            End If
        Loop Until SaveDialog = 0

        If DiagnosticTool_Timestamp.Checked And (TimestampFirst = True Or TimestampCount >= 50) Then
            Timestamp(NVMScriptDirectorySelected)
            TimestampCount += 1
        End If

        My.Computer.FileSystem.MoveFile(NVMScriptDirectorySelected & "\" & lbxAllNVMScripts.Items(0).ToString, NVMScriptDirectorySelected & "\Done\" & lbxAllNVMScripts.Items(0).ToString)
        lbxAllNVMScripts.Items.RemoveAt(0)
    End Sub


    '========================================
    '========== Generate Timestamps =========
    '========================================
    Private Sub Timestamp(NVMScriptDirectorySelected)
        If TimestampFirst = True Then
            lbxTimestamps.Items.Add(Now & " - Starting NVM Read With " & lbxAllNVMScripts.Items(0))
            TimestampToWrite = Now & " - Starting NVM Read With " & lbxAllNVMScripts.Items(0) & vbCrLf
            TimestampFirst = False
        ElseIf TimestampCount >= 50 Then
            lbxTimestamps.Items.Add(Now & " - " & lbxAllNVMScripts.Items(0).ToString)
            TimestampToWrite = Now & " - " & lbxAllNVMScripts.Items(0).ToString & vbCrLf
            TimestampCount = 0
        End If

        If TimestampToWrite.Length > 0 Then
            objWriter = New System.IO.StreamWriter(NVMScriptDirectorySelected & "\SaveFiles\" & TimestampFileName, append, encodingASCII)
            objWriter.Write(TimestampToWrite)
            objWriter.Close()
            TimestampToWrite = ""
        End If
    End Sub

    Declare Function FindWindow Lib "user32" Alias "FindWindowA" _
                    (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" _
                     (ByVal hWnd As IntPtr, ByVal hWndChildAfterA As IntPtr, ByVal lpszClass As String, ByVal lpszWindow As String) As IntPtr
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
                     (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As String) As IntPtr
    Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer

    Const WM_SETTEXT As Integer = &HC



    Private Sub debug_Click(sender As Object, e As EventArgs) Handles debugButton.Click

    End Sub

    Private Sub DiagnosticTool_AddNew_Click(sender As Object, e As EventArgs) Handles DiagnosticTool_AddNew.Click
        AddNewDiagnosticTool()
    End Sub
    Private Sub DiagnosticTool_Run_Normal_Click(sender As Object, e As EventArgs) Handles DiagnosticTool_Run_Normal.Click
        RunDiagnosticTool("Normal")
    End Sub
    Private Sub DiagnosticTool_Run_Auto_Click(sender As Object, e As EventArgs) Handles DiagnosticTool_Run_Auto.Click
        Dim AreYouSure = MsgBox("This will run the automatic NVM reading system." & vbCrLf &
                                "You will be unable to use the PC while this is running." & vbCrLf &
                                "(Remember to open an interlock on the machine, and plug in your laptop)" & vbCrLf & vbCrLf &
                                "Are you sure you want to do this?", MsgBoxStyle.YesNo)
        If AreYouSure = MsgBoxResult.Yes Then
            RunDiagnosticTool("Automatic")
        End If
    End Sub
    Private Sub NVMScripts_AddNew_Click(sender As Object, e As EventArgs) Handles NVMScripts_AddNew.Click
        AddNewNVMScriptDirectory()
    End Sub
    Private Sub NVMScripts_Preview_Click(sender As Object, e As EventArgs) Handles NVMScripts_Preview.Click
        Dim NVMScriptDirectorySelected = NVMScriptsDropdown.SelectedIndex
        CheckForNVMScripts(NVMScriptDirectorySelected)
    End Sub
    Private Sub NVMScriptsDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NVMScriptsDropdown.SelectedIndexChanged
        NVMScripts_CurrentPath.Text = My.Settings.NVMScriptDirectories_Paths(NVMScriptsDropdown.SelectedIndex)
    End Sub
    Private Sub OpenPWSLockSettings_Click(sender As Object, e As EventArgs) Handles OpenPWSLockSettings.Click
        PWSLock_SettingsForm.Show()
        Me.Hide()
        PWSLock_SettingsForm.Focus()
    End Sub

    Private Sub github_Logo_Click(sender As Object, e As EventArgs) Handles github_Logo.Click
        Dim open_github_repo = New Process()
        open_github_repo.StartInfo.UseShellExecute = True
        open_github_repo.StartInfo.FileName = "https://github.com/RADIALTHRONE1/Xerox-NVM-Automation-Hub"
        open_github_repo.Start()
    End Sub

    Private Sub OpenModifyNVMForm_Click(sender As Object, e As EventArgs) Handles OpenModifyNVMForm.Click
        ModifyNVMForm.Show()
        Me.Hide()
        ModifyNVMForm.Focus()
    End Sub
End Class
