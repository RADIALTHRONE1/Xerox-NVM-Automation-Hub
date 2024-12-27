<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Xerox_NVM_Automation_Hub
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Xerox_NVM_Automation_Hub))
        lbxTimestamps = New ListBox()
        lbxAllNVMScripts = New ListBox()
        debugButton = New Button()
        DiagnosticToolDropdown = New ComboBox()
        DiagnosticTool_AddNew = New Button()
        DiagnosticTool_Run_Normal = New Button()
        DiagnosticTool_Run_Auto = New Button()
        Group_NVMScript = New GroupBox()
        NVMScripts_CurrentPath = New Label()
        Label1 = New Label()
        NVMScripts_Reset = New Button()
        NVMScripts_Preview = New Button()
        NVMScripts_DeleteEntry = New Button()
        NVMScripts_AddNew = New Button()
        NVMScriptsDropdown = New ComboBox()
        DiagnosticTool_Delete = New Button()
        Group_DiagnosticTools = New GroupBox()
        DiagnosticTool_StandAloneMode = New CheckBox()
        DiagnosticTool_EditEntry = New Button()
        DiagnosticTool_Timestamp = New CheckBox()
        Version_Label = New Label()
        OpenPWSLockSettings = New Button()
        github_Logo = New PictureBox()
        OpenModifyNVMForm = New Button()
        Group_NVMScript.SuspendLayout()
        Group_DiagnosticTools.SuspendLayout()
        CType(github_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbxTimestamps
        ' 
        lbxTimestamps.FormattingEnabled = True
        lbxTimestamps.ItemHeight = 15
        lbxTimestamps.Location = New Point(6, 139)
        lbxTimestamps.Name = "lbxTimestamps"
        lbxTimestamps.Size = New Size(180, 139)
        lbxTimestamps.TabIndex = 14
        ' 
        ' lbxAllNVMScripts
        ' 
        lbxAllNVMScripts.FormattingEnabled = True
        lbxAllNVMScripts.ItemHeight = 15
        lbxAllNVMScripts.Location = New Point(6, 139)
        lbxAllNVMScripts.Name = "lbxAllNVMScripts"
        lbxAllNVMScripts.Size = New Size(180, 139)
        lbxAllNVMScripts.TabIndex = 12
        ' 
        ' debugButton
        ' 
        debugButton.Location = New Point(232, 148)
        debugButton.Name = "debugButton"
        debugButton.Size = New Size(75, 23)
        debugButton.TabIndex = 38
        debugButton.Text = "DEBUG"
        debugButton.UseVisualStyleBackColor = True
        debugButton.Visible = False
        ' 
        ' DiagnosticToolDropdown
        ' 
        DiagnosticToolDropdown.FormattingEnabled = True
        DiagnosticToolDropdown.Location = New Point(6, 22)
        DiagnosticToolDropdown.Name = "DiagnosticToolDropdown"
        DiagnosticToolDropdown.Size = New Size(388, 23)
        DiagnosticToolDropdown.TabIndex = 39
        ' 
        ' DiagnosticTool_AddNew
        ' 
        DiagnosticTool_AddNew.Location = New Point(6, 81)
        DiagnosticTool_AddNew.Name = "DiagnosticTool_AddNew"
        DiagnosticTool_AddNew.Size = New Size(180, 23)
        DiagnosticTool_AddNew.TabIndex = 40
        DiagnosticTool_AddNew.Text = "Add New Tool"
        DiagnosticTool_AddNew.UseVisualStyleBackColor = True
        ' 
        ' DiagnosticTool_Run_Normal
        ' 
        DiagnosticTool_Run_Normal.Location = New Point(6, 52)
        DiagnosticTool_Run_Normal.Name = "DiagnosticTool_Run_Normal"
        DiagnosticTool_Run_Normal.Size = New Size(180, 23)
        DiagnosticTool_Run_Normal.TabIndex = 41
        DiagnosticTool_Run_Normal.Text = "Run Tool (Normal)"
        DiagnosticTool_Run_Normal.UseVisualStyleBackColor = True
        ' 
        ' DiagnosticTool_Run_Auto
        ' 
        DiagnosticTool_Run_Auto.Location = New Point(214, 52)
        DiagnosticTool_Run_Auto.Name = "DiagnosticTool_Run_Auto"
        DiagnosticTool_Run_Auto.Size = New Size(180, 23)
        DiagnosticTool_Run_Auto.TabIndex = 42
        DiagnosticTool_Run_Auto.Text = "Run Tool (Automatic)"
        DiagnosticTool_Run_Auto.UseVisualStyleBackColor = True
        ' 
        ' Group_NVMScript
        ' 
        Group_NVMScript.AutoSize = True
        Group_NVMScript.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Group_NVMScript.Controls.Add(NVMScripts_CurrentPath)
        Group_NVMScript.Controls.Add(Label1)
        Group_NVMScript.Controls.Add(NVMScripts_Reset)
        Group_NVMScript.Controls.Add(debugButton)
        Group_NVMScript.Controls.Add(NVMScripts_Preview)
        Group_NVMScript.Controls.Add(NVMScripts_DeleteEntry)
        Group_NVMScript.Controls.Add(NVMScripts_AddNew)
        Group_NVMScript.Controls.Add(lbxAllNVMScripts)
        Group_NVMScript.Controls.Add(NVMScriptsDropdown)
        Group_NVMScript.Location = New Point(15, 321)
        Group_NVMScript.Name = "Group_NVMScript"
        Group_NVMScript.Size = New Size(400, 300)
        Group_NVMScript.TabIndex = 43
        Group_NVMScript.TabStop = False
        Group_NVMScript.Text = "NVM Script Directory (For Auto Reading)"
        ' 
        ' NVMScripts_CurrentPath
        ' 
        NVMScripts_CurrentPath.AutoSize = True
        NVMScripts_CurrentPath.Location = New Point(6, 48)
        NVMScripts_CurrentPath.Name = "NVMScripts_CurrentPath"
        NVMScripts_CurrentPath.Size = New Size(31, 15)
        NVMScripts_CurrentPath.TabIndex = 39
        NVMScripts_CurrentPath.Text = "Path"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 15)
        Label1.TabIndex = 13
        Label1.Text = "Files to Read NVM's From (.csv)"
        ' 
        ' NVMScripts_Reset
        ' 
        NVMScripts_Reset.Location = New Point(214, 95)
        NVMScripts_Reset.Name = "NVMScripts_Reset"
        NVMScripts_Reset.Size = New Size(180, 23)
        NVMScripts_Reset.TabIndex = 4
        NVMScripts_Reset.Text = "Reset Finished Files"
        NVMScripts_Reset.UseVisualStyleBackColor = True
        ' 
        ' NVMScripts_Preview
        ' 
        NVMScripts_Preview.Location = New Point(6, 95)
        NVMScripts_Preview.Name = "NVMScripts_Preview"
        NVMScripts_Preview.Size = New Size(180, 23)
        NVMScripts_Preview.TabIndex = 3
        NVMScripts_Preview.Text = "Preview NVM Files"
        NVMScripts_Preview.UseVisualStyleBackColor = True
        ' 
        ' NVMScripts_DeleteEntry
        ' 
        NVMScripts_DeleteEntry.Location = New Point(214, 66)
        NVMScripts_DeleteEntry.Name = "NVMScripts_DeleteEntry"
        NVMScripts_DeleteEntry.Size = New Size(180, 23)
        NVMScripts_DeleteEntry.TabIndex = 2
        NVMScripts_DeleteEntry.Text = "Delete Script Directory"
        NVMScripts_DeleteEntry.UseVisualStyleBackColor = True
        ' 
        ' NVMScripts_AddNew
        ' 
        NVMScripts_AddNew.Location = New Point(6, 66)
        NVMScripts_AddNew.Name = "NVMScripts_AddNew"
        NVMScripts_AddNew.Size = New Size(180, 23)
        NVMScripts_AddNew.TabIndex = 1
        NVMScripts_AddNew.Text = "Add New Script Directory"
        NVMScripts_AddNew.UseVisualStyleBackColor = True
        ' 
        ' NVMScriptsDropdown
        ' 
        NVMScriptsDropdown.FormattingEnabled = True
        NVMScriptsDropdown.Location = New Point(6, 22)
        NVMScriptsDropdown.Name = "NVMScriptsDropdown"
        NVMScriptsDropdown.Size = New Size(388, 23)
        NVMScriptsDropdown.TabIndex = 0
        ' 
        ' DiagnosticTool_Delete
        ' 
        DiagnosticTool_Delete.Location = New Point(214, 81)
        DiagnosticTool_Delete.Name = "DiagnosticTool_Delete"
        DiagnosticTool_Delete.Size = New Size(180, 23)
        DiagnosticTool_Delete.TabIndex = 44
        DiagnosticTool_Delete.Text = "Delete Tool"
        DiagnosticTool_Delete.UseVisualStyleBackColor = True
        ' 
        ' Group_DiagnosticTools
        ' 
        Group_DiagnosticTools.AutoSize = True
        Group_DiagnosticTools.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Group_DiagnosticTools.Controls.Add(DiagnosticTool_StandAloneMode)
        Group_DiagnosticTools.Controls.Add(DiagnosticTool_EditEntry)
        Group_DiagnosticTools.Controls.Add(DiagnosticTool_Timestamp)
        Group_DiagnosticTools.Controls.Add(lbxTimestamps)
        Group_DiagnosticTools.Controls.Add(DiagnosticToolDropdown)
        Group_DiagnosticTools.Controls.Add(DiagnosticTool_Delete)
        Group_DiagnosticTools.Controls.Add(DiagnosticTool_Run_Normal)
        Group_DiagnosticTools.Controls.Add(DiagnosticTool_Run_Auto)
        Group_DiagnosticTools.Controls.Add(DiagnosticTool_AddNew)
        Group_DiagnosticTools.Location = New Point(15, 15)
        Group_DiagnosticTools.Name = "Group_DiagnosticTools"
        Group_DiagnosticTools.Size = New Size(400, 300)
        Group_DiagnosticTools.TabIndex = 45
        Group_DiagnosticTools.TabStop = False
        Group_DiagnosticTools.Text = "NVM Diagnostic Tool"
        ' 
        ' DiagnosticTool_StandAloneMode
        ' 
        DiagnosticTool_StandAloneMode.AutoSize = True
        DiagnosticTool_StandAloneMode.Location = New Point(232, 250)
        DiagnosticTool_StandAloneMode.Name = "DiagnosticTool_StandAloneMode"
        DiagnosticTool_StandAloneMode.Size = New Size(124, 19)
        DiagnosticTool_StandAloneMode.TabIndex = 47
        DiagnosticTool_StandAloneMode.Text = "Stand Alone Mode"
        DiagnosticTool_StandAloneMode.UseVisualStyleBackColor = True
        DiagnosticTool_StandAloneMode.Visible = False
        ' 
        ' DiagnosticTool_EditEntry
        ' 
        DiagnosticTool_EditEntry.Location = New Point(214, 110)
        DiagnosticTool_EditEntry.Name = "DiagnosticTool_EditEntry"
        DiagnosticTool_EditEntry.Size = New Size(180, 23)
        DiagnosticTool_EditEntry.TabIndex = 46
        DiagnosticTool_EditEntry.Text = "Edit Entry"
        DiagnosticTool_EditEntry.UseVisualStyleBackColor = True
        ' 
        ' DiagnosticTool_Timestamp
        ' 
        DiagnosticTool_Timestamp.AutoSize = True
        DiagnosticTool_Timestamp.Location = New Point(21, 113)
        DiagnosticTool_Timestamp.Name = "DiagnosticTool_Timestamp"
        DiagnosticTool_Timestamp.Size = New Size(140, 19)
        DiagnosticTool_Timestamp.TabIndex = 45
        DiagnosticTool_Timestamp.Text = "Generate Timestamps"
        DiagnosticTool_Timestamp.UseVisualStyleBackColor = True
        ' 
        ' Version_Label
        ' 
        Version_Label.AutoSize = True
        Version_Label.Location = New Point(15, 624)
        Version_Label.Name = "Version_Label"
        Version_Label.Size = New Size(45, 15)
        Version_Label.TabIndex = 46
        Version_Label.Text = "Version"
        ' 
        ' OpenPWSLockSettings
        ' 
        OpenPWSLockSettings.Location = New Point(265, 627)
        OpenPWSLockSettings.Name = "OpenPWSLockSettings"
        OpenPWSLockSettings.Size = New Size(150, 23)
        OpenPWSLockSettings.TabIndex = 47
        OpenPWSLockSettings.Text = "PWS Lock Settings"
        OpenPWSLockSettings.UseVisualStyleBackColor = True
        ' 
        ' github_Logo
        ' 
        github_Logo.Cursor = Cursors.Hand
        github_Logo.Location = New Point(66, 627)
        github_Logo.MaximumSize = New Size(50, 50)
        github_Logo.Name = "github_Logo"
        github_Logo.Size = New Size(23, 23)
        github_Logo.SizeMode = PictureBoxSizeMode.Zoom
        github_Logo.TabIndex = 48
        github_Logo.TabStop = False
        ' 
        ' OpenModifyNVMForm
        ' 
        OpenModifyNVMForm.Location = New Point(95, 627)
        OpenModifyNVMForm.Name = "OpenModifyNVMForm"
        OpenModifyNVMForm.Size = New Size(164, 23)
        OpenModifyNVMForm.TabIndex = 49
        OpenModifyNVMForm.Text = "Clean/Compare NVM Reads"
        OpenModifyNVMForm.UseVisualStyleBackColor = True
        ' 
        ' Xerox_NVM_Automation_Hub
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(437, 661)
        Controls.Add(OpenModifyNVMForm)
        Controls.Add(github_Logo)
        Controls.Add(OpenPWSLockSettings)
        Controls.Add(Version_Label)
        Controls.Add(Group_DiagnosticTools)
        Controls.Add(Group_NVMScript)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Xerox_NVM_Automation_Hub"
        Padding = New Padding(12)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Xerox NVM Automation Hub"
        Group_NVMScript.ResumeLayout(False)
        Group_NVMScript.PerformLayout()
        Group_DiagnosticTools.ResumeLayout(False)
        Group_DiagnosticTools.PerformLayout()
        CType(github_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbxAllNVMScripts As ListBox
    Friend WithEvents lbxAccessFiles As ListBox
    Friend WithEvents lbxWriteNVMScript As ListBox
    Friend WithEvents lbxTimestamps As ListBox
    Friend WithEvents gbxNVMCleaningTools As GroupBox
    Friend WithEvents R0C0 As ListBox
    Friend WithEvents R2C5 As ListBox
    Friend WithEvents R1C5 As ListBox
    Friend WithEvents R2C0 As ListBox
    Friend WithEvents R1C0 As ListBox
    Friend WithEvents D2C2 As ListBox
    Friend WithEvents D1C2 As ListBox
    Friend WithEvents D2C5 As ListBox
    Friend WithEvents D2C1 As ListBox
    Friend WithEvents D1C5 As ListBox
    Friend WithEvents D1C1 As ListBox
    Friend WithEvents txbImportCSVData2 As TextBox
    Friend WithEvents txbImportCSVData1 As TextBox
    Friend WithEvents btnCompareCSVData As Button
    Friend WithEvents btnImportCSVDataB As Button
    Friend WithEvents btnImportCSVDataA As Button
    Friend WithEvents btnImportAccessNVM1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ckbCleanNVM2 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCompareNVM As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConvertNVM1 As Button
    Friend WithEvents ckbCleanNVM1 As CheckBox
    Friend WithEvents btnImportAccessNVM2 As Button
    Friend WithEvents dataGridViewB As DataGridView
    Friend WithEvents btnResetNVMRead As Button
    Friend WithEvents dataGridViewResultB As DataGridView
    Friend WithEvents txtNVM2Filename As TextBox
    Friend WithEvents btnConvertNVM2 As Button
    Friend WithEvents dataGridViewResultA As DataGridView
    Friend WithEvents btnExportNVM1 As Button
    Friend WithEvents txtNVM1Filename As TextBox
    Friend WithEvents dataGridViewA As DataGridView
    Friend WithEvents btnExportNVM2 As Button
    Friend WithEvents btnNVMHelp As Button
    Friend WithEvents debugButton As Button
    Friend WithEvents DiagnosticToolDropdown As ComboBox
    Friend WithEvents DiagnosticTool_AddNew As Button
    Friend WithEvents DiagnosticTool_Run_Normal As Button
    Friend WithEvents DiagnosticTool_Run_Auto As Button
    Friend WithEvents Group_NVMScript As GroupBox
    Friend WithEvents NVMScripts_AddNew As Button
    Friend WithEvents DiagnosticTool_Delete As Button
    Friend WithEvents NVMScripts_DeleteEntry As Button
    Friend WithEvents Group_DiagnosticTools As GroupBox
    Friend WithEvents NVMScripts_Preview As Button
    Friend WithEvents NVMScripts_Reset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DiagnosticTool_Timestamp As CheckBox
    Friend WithEvents DiagnosticTool_EditEntry As Button
    Friend WithEvents DiagnosticTool_StandAloneMode As CheckBox
    Friend WithEvents NVMScripts_CurrentPath As Label
    Friend WithEvents NVMScriptsDropdown As ComboBox
    Friend WithEvents Version_Label As Label
    Friend WithEvents OpenPWSLockSettings As Button
    Friend WithEvents github_Logo As PictureBox
    Friend WithEvents OpenModifyNVMForm As Button

End Class
