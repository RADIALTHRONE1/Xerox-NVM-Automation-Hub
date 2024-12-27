<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyNVM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        gbxNVMCleaningTools = New GroupBox()
        Button1 = New Button()
        R0C0 = New ListBox()
        R2C5 = New ListBox()
        R1C5 = New ListBox()
        lbxAccessFiles = New ListBox()
        lbxWriteNVMScript = New ListBox()
        R2C0 = New ListBox()
        R1C0 = New ListBox()
        D2C2 = New ListBox()
        D1C2 = New ListBox()
        D2C5 = New ListBox()
        D2C1 = New ListBox()
        D1C5 = New ListBox()
        D1C1 = New ListBox()
        txbImportCSVData2 = New TextBox()
        txbImportCSVData1 = New TextBox()
        btnCompareCSVData = New Button()
        btnImportCSVDataB = New Button()
        btnImportCSVDataA = New Button()
        btnImportAccessNVM1 = New Button()
        Label5 = New Label()
        ckbCleanNVM2 = New CheckBox()
        Label4 = New Label()
        btnCompareNVM = New Button()
        Label3 = New Label()
        btnConvertNVM1 = New Button()
        Label2 = New Label()
        ckbCleanNVM1 = New CheckBox()
        btnImportAccessNVM2 = New Button()
        dataGridViewB = New DataGridView()
        btnResetNVMRead = New Button()
        dataGridViewResultB = New DataGridView()
        txtNVM2Filename = New TextBox()
        btnConvertNVM2 = New Button()
        dataGridViewResultA = New DataGridView()
        btnExportNVM1 = New Button()
        txtNVM1Filename = New TextBox()
        dataGridViewA = New DataGridView()
        btnExportNVM2 = New Button()
        btnNVMHelp = New Button()
        gbxNVMCleaningTools.SuspendLayout()
        CType(dataGridViewB, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridViewResultB, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridViewResultA, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridViewA, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbxNVMCleaningTools
        ' 
        gbxNVMCleaningTools.Controls.Add(Button1)
        gbxNVMCleaningTools.Controls.Add(R0C0)
        gbxNVMCleaningTools.Controls.Add(R2C5)
        gbxNVMCleaningTools.Controls.Add(R1C5)
        gbxNVMCleaningTools.Controls.Add(lbxAccessFiles)
        gbxNVMCleaningTools.Controls.Add(lbxWriteNVMScript)
        gbxNVMCleaningTools.Controls.Add(R2C0)
        gbxNVMCleaningTools.Controls.Add(R1C0)
        gbxNVMCleaningTools.Controls.Add(D2C2)
        gbxNVMCleaningTools.Controls.Add(D1C2)
        gbxNVMCleaningTools.Controls.Add(D2C5)
        gbxNVMCleaningTools.Controls.Add(D2C1)
        gbxNVMCleaningTools.Controls.Add(D1C5)
        gbxNVMCleaningTools.Controls.Add(D1C1)
        gbxNVMCleaningTools.Controls.Add(txbImportCSVData2)
        gbxNVMCleaningTools.Controls.Add(txbImportCSVData1)
        gbxNVMCleaningTools.Controls.Add(btnCompareCSVData)
        gbxNVMCleaningTools.Controls.Add(btnImportCSVDataB)
        gbxNVMCleaningTools.Controls.Add(btnImportCSVDataA)
        gbxNVMCleaningTools.Controls.Add(btnImportAccessNVM1)
        gbxNVMCleaningTools.Controls.Add(Label5)
        gbxNVMCleaningTools.Controls.Add(ckbCleanNVM2)
        gbxNVMCleaningTools.Controls.Add(Label4)
        gbxNVMCleaningTools.Controls.Add(btnCompareNVM)
        gbxNVMCleaningTools.Controls.Add(Label3)
        gbxNVMCleaningTools.Controls.Add(btnConvertNVM1)
        gbxNVMCleaningTools.Controls.Add(Label2)
        gbxNVMCleaningTools.Controls.Add(ckbCleanNVM1)
        gbxNVMCleaningTools.Controls.Add(btnImportAccessNVM2)
        gbxNVMCleaningTools.Controls.Add(dataGridViewB)
        gbxNVMCleaningTools.Controls.Add(btnResetNVMRead)
        gbxNVMCleaningTools.Controls.Add(dataGridViewResultB)
        gbxNVMCleaningTools.Controls.Add(txtNVM2Filename)
        gbxNVMCleaningTools.Controls.Add(btnConvertNVM2)
        gbxNVMCleaningTools.Controls.Add(dataGridViewResultA)
        gbxNVMCleaningTools.Controls.Add(btnExportNVM1)
        gbxNVMCleaningTools.Controls.Add(txtNVM1Filename)
        gbxNVMCleaningTools.Controls.Add(dataGridViewA)
        gbxNVMCleaningTools.Controls.Add(btnExportNVM2)
        gbxNVMCleaningTools.Controls.Add(btnNVMHelp)
        gbxNVMCleaningTools.Location = New Point(12, 12)
        gbxNVMCleaningTools.Name = "gbxNVMCleaningTools"
        gbxNVMCleaningTools.Size = New Size(690, 650)
        gbxNVMCleaningTools.TabIndex = 38
        gbxNVMCleaningTools.TabStop = False
        gbxNVMCleaningTools.Text = "NVM Cleaning/Comparing Tools"
        gbxNVMCleaningTools.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 625)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 51
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' R0C0
        ' 
        R0C0.FormattingEnabled = True
        R0C0.ItemHeight = 15
        R0C0.Location = New Point(462, 526)
        R0C0.Name = "R0C0"
        R0C0.Size = New Size(222, 94)
        R0C0.TabIndex = 50
        ' 
        ' R2C5
        ' 
        R2C5.FormattingEnabled = True
        R2C5.ItemHeight = 15
        R2C5.Location = New Point(336, 526)
        R2C5.Name = "R2C5"
        R2C5.Size = New Size(120, 94)
        R2C5.TabIndex = 49
        ' 
        ' R1C5
        ' 
        R1C5.FormattingEnabled = True
        R1C5.ItemHeight = 15
        R1C5.Location = New Point(108, 525)
        R1C5.Name = "R1C5"
        R1C5.Size = New Size(120, 94)
        R1C5.TabIndex = 48
        ' 
        ' lbxAccessFiles
        ' 
        lbxAccessFiles.FormattingEnabled = True
        lbxAccessFiles.ItemHeight = 15
        lbxAccessFiles.Location = New Point(355, 167)
        lbxAccessFiles.Name = "lbxAccessFiles"
        lbxAccessFiles.Size = New Size(140, 139)
        lbxAccessFiles.TabIndex = 15
        ' 
        ' lbxWriteNVMScript
        ' 
        lbxWriteNVMScript.FormattingEnabled = True
        lbxWriteNVMScript.ItemHeight = 15
        lbxWriteNVMScript.Location = New Point(277, 333)
        lbxWriteNVMScript.Name = "lbxWriteNVMScript"
        lbxWriteNVMScript.ScrollAlwaysVisible = True
        lbxWriteNVMScript.Size = New Size(140, 139)
        lbxWriteNVMScript.TabIndex = 13
        ' 
        ' R2C0
        ' 
        R2C0.FormattingEnabled = True
        R2C0.ItemHeight = 15
        R2C0.Location = New Point(234, 526)
        R2C0.Name = "R2C0"
        R2C0.Size = New Size(96, 94)
        R2C0.TabIndex = 47
        ' 
        ' R1C0
        ' 
        R1C0.FormattingEnabled = True
        R1C0.ItemHeight = 15
        R1C0.Location = New Point(6, 525)
        R1C0.Name = "R1C0"
        R1C0.Size = New Size(96, 94)
        R1C0.TabIndex = 46
        ' 
        ' D2C2
        ' 
        D2C2.FormattingEnabled = True
        D2C2.ItemHeight = 15
        D2C2.Location = New Point(57, 425)
        D2C2.Name = "D2C2"
        D2C2.Size = New Size(45, 94)
        D2C2.TabIndex = 45
        ' 
        ' D1C2
        ' 
        D1C2.FormattingEnabled = True
        D1C2.ItemHeight = 15
        D1C2.Location = New Point(57, 325)
        D1C2.Name = "D1C2"
        D1C2.Size = New Size(45, 94)
        D1C2.TabIndex = 44
        ' 
        ' D2C5
        ' 
        D2C5.FormattingEnabled = True
        D2C5.ItemHeight = 15
        D2C5.Location = New Point(108, 426)
        D2C5.Name = "D2C5"
        D2C5.Size = New Size(184, 94)
        D2C5.TabIndex = 43
        ' 
        ' D2C1
        ' 
        D2C1.FormattingEnabled = True
        D2C1.ItemHeight = 15
        D2C1.Location = New Point(6, 425)
        D2C1.Name = "D2C1"
        D2C1.Size = New Size(45, 94)
        D2C1.TabIndex = 42
        ' 
        ' D1C5
        ' 
        D1C5.FormattingEnabled = True
        D1C5.ItemHeight = 15
        D1C5.Location = New Point(108, 326)
        D1C5.Name = "D1C5"
        D1C5.Size = New Size(184, 94)
        D1C5.TabIndex = 41
        ' 
        ' D1C1
        ' 
        D1C1.FormattingEnabled = True
        D1C1.ItemHeight = 15
        D1C1.Location = New Point(6, 325)
        D1C1.Name = "D1C1"
        D1C1.Size = New Size(45, 94)
        D1C1.TabIndex = 38
        ' 
        ' txbImportCSVData2
        ' 
        txbImportCSVData2.Location = New Point(152, 267)
        txbImportCSVData2.Name = "txbImportCSVData2"
        txbImportCSVData2.ReadOnly = True
        txbImportCSVData2.Size = New Size(140, 23)
        txbImportCSVData2.TabIndex = 40
        ' 
        ' txbImportCSVData1
        ' 
        txbImportCSVData1.Location = New Point(6, 267)
        txbImportCSVData1.Name = "txbImportCSVData1"
        txbImportCSVData1.ReadOnly = True
        txbImportCSVData1.Size = New Size(140, 23)
        txbImportCSVData1.TabIndex = 39
        ' 
        ' btnCompareCSVData
        ' 
        btnCompareCSVData.Location = New Point(6, 296)
        btnCompareCSVData.Name = "btnCompareCSVData"
        btnCompareCSVData.Size = New Size(286, 23)
        btnCompareCSVData.TabIndex = 38
        btnCompareCSVData.Text = "Compare Sets A and B"
        btnCompareCSVData.UseVisualStyleBackColor = True
        ' 
        ' btnImportCSVDataB
        ' 
        btnImportCSVDataB.Location = New Point(152, 238)
        btnImportCSVDataB.Name = "btnImportCSVDataB"
        btnImportCSVDataB.Size = New Size(140, 23)
        btnImportCSVDataB.TabIndex = 37
        btnImportCSVDataB.Text = "Import CSV Data B"
        btnImportCSVDataB.UseVisualStyleBackColor = True
        ' 
        ' btnImportCSVDataA
        ' 
        btnImportCSVDataA.Location = New Point(6, 238)
        btnImportCSVDataA.Name = "btnImportCSVDataA"
        btnImportCSVDataA.Size = New Size(140, 23)
        btnImportCSVDataA.TabIndex = 36
        btnImportCSVDataA.Text = "Import CSV Data A"
        btnImportCSVDataA.UseVisualStyleBackColor = True
        ' 
        ' btnImportAccessNVM1
        ' 
        btnImportAccessNVM1.Location = New Point(6, 22)
        btnImportAccessNVM1.Name = "btnImportAccessNVM1"
        btnImportAccessNVM1.Size = New Size(140, 23)
        btnImportAccessNVM1.TabIndex = 11
        btnImportAccessNVM1.Text = "Import NVM Values A"
        btnImportAccessNVM1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(306, 397)
        Label5.Name = "Label5"
        Label5.Size = New Size(239, 15)
        Label5.TabIndex = 31
        Label5.Text = "NVM Data Set 'B' Cleaned/Compared Values"
        ' 
        ' ckbCleanNVM2
        ' 
        ckbCleanNVM2.AutoSize = True
        ckbCleanNVM2.Location = New Point(277, 85)
        ckbCleanNVM2.Name = "ckbCleanNVM2"
        ckbCleanNVM2.Size = New Size(15, 14)
        ckbCleanNVM2.TabIndex = 35
        ckbCleanNVM2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(306, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 15)
        Label4.TabIndex = 30
        Label4.Text = "NVM Data Set 'B' Source"
        ' 
        ' btnCompareNVM
        ' 
        btnCompareNVM.Enabled = False
        btnCompareNVM.Location = New Point(6, 109)
        btnCompareNVM.Name = "btnCompareNVM"
        btnCompareNVM.Size = New Size(286, 23)
        btnCompareNVM.TabIndex = 20
        btnCompareNVM.Text = "Compare Sets A and B"
        btnCompareNVM.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(306, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 15)
        Label3.TabIndex = 26
        Label3.Text = "NVM Data Set 'A' Cleaned/Compared Values"
        ' 
        ' btnConvertNVM1
        ' 
        btnConvertNVM1.Enabled = False
        btnConvertNVM1.Location = New Point(27, 80)
        btnConvertNVM1.Name = "btnConvertNVM1"
        btnConvertNVM1.Size = New Size(119, 23)
        btnConvertNVM1.TabIndex = 24
        btnConvertNVM1.Text = "Clean Data A"
        btnConvertNVM1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(306, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 15)
        Label2.TabIndex = 26
        Label2.Text = "NVM Data Set 'A' Source"
        ' 
        ' ckbCleanNVM1
        ' 
        ckbCleanNVM1.AutoSize = True
        ckbCleanNVM1.Location = New Point(6, 84)
        ckbCleanNVM1.Name = "ckbCleanNVM1"
        ckbCleanNVM1.Size = New Size(15, 14)
        ckbCleanNVM1.TabIndex = 34
        ckbCleanNVM1.UseVisualStyleBackColor = True
        ' 
        ' btnImportAccessNVM2
        ' 
        btnImportAccessNVM2.Location = New Point(152, 22)
        btnImportAccessNVM2.Name = "btnImportAccessNVM2"
        btnImportAccessNVM2.Size = New Size(140, 23)
        btnImportAccessNVM2.TabIndex = 19
        btnImportAccessNVM2.Text = "Import NVM Values B"
        btnImportAccessNVM2.UseVisualStyleBackColor = True
        ' 
        ' dataGridViewB
        ' 
        dataGridViewB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewB.Location = New Point(306, 289)
        dataGridViewB.Name = "dataGridViewB"
        dataGridViewB.ReadOnly = True
        dataGridViewB.Size = New Size(378, 100)
        dataGridViewB.TabIndex = 21
        ' 
        ' btnResetNVMRead
        ' 
        btnResetNVMRead.Enabled = False
        btnResetNVMRead.Location = New Point(6, 167)
        btnResetNVMRead.Name = "btnResetNVMRead"
        btnResetNVMRead.Size = New Size(286, 23)
        btnResetNVMRead.TabIndex = 18
        btnResetNVMRead.Text = "Reset NVM Data"
        btnResetNVMRead.UseVisualStyleBackColor = True
        ' 
        ' dataGridViewResultB
        ' 
        dataGridViewResultB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewResultB.Location = New Point(306, 415)
        dataGridViewResultB.Name = "dataGridViewResultB"
        dataGridViewResultB.ReadOnly = True
        dataGridViewResultB.Size = New Size(378, 100)
        dataGridViewResultB.TabIndex = 23
        ' 
        ' txtNVM2Filename
        ' 
        txtNVM2Filename.Location = New Point(152, 51)
        txtNVM2Filename.Name = "txtNVM2Filename"
        txtNVM2Filename.ReadOnly = True
        txtNVM2Filename.Size = New Size(140, 23)
        txtNVM2Filename.TabIndex = 33
        ' 
        ' btnConvertNVM2
        ' 
        btnConvertNVM2.Enabled = False
        btnConvertNVM2.Location = New Point(152, 80)
        btnConvertNVM2.Name = "btnConvertNVM2"
        btnConvertNVM2.Size = New Size(119, 23)
        btnConvertNVM2.TabIndex = 27
        btnConvertNVM2.Text = "Clean Data B"
        btnConvertNVM2.UseVisualStyleBackColor = True
        ' 
        ' dataGridViewResultA
        ' 
        dataGridViewResultA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewResultA.Location = New Point(306, 163)
        dataGridViewResultA.Name = "dataGridViewResultA"
        dataGridViewResultA.ReadOnly = True
        dataGridViewResultA.Size = New Size(378, 100)
        dataGridViewResultA.TabIndex = 22
        ' 
        ' btnExportNVM1
        ' 
        btnExportNVM1.Enabled = False
        btnExportNVM1.Location = New Point(6, 138)
        btnExportNVM1.Name = "btnExportNVM1"
        btnExportNVM1.Size = New Size(140, 23)
        btnExportNVM1.TabIndex = 28
        btnExportNVM1.Text = "Export NVM A"
        btnExportNVM1.UseVisualStyleBackColor = True
        ' 
        ' txtNVM1Filename
        ' 
        txtNVM1Filename.Location = New Point(6, 51)
        txtNVM1Filename.Name = "txtNVM1Filename"
        txtNVM1Filename.ReadOnly = True
        txtNVM1Filename.Size = New Size(140, 23)
        txtNVM1Filename.TabIndex = 32
        ' 
        ' dataGridViewA
        ' 
        dataGridViewA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewA.Location = New Point(306, 37)
        dataGridViewA.Name = "dataGridViewA"
        dataGridViewA.ReadOnly = True
        dataGridViewA.Size = New Size(378, 100)
        dataGridViewA.TabIndex = 16
        ' 
        ' btnExportNVM2
        ' 
        btnExportNVM2.Enabled = False
        btnExportNVM2.Location = New Point(152, 138)
        btnExportNVM2.Name = "btnExportNVM2"
        btnExportNVM2.Size = New Size(140, 23)
        btnExportNVM2.TabIndex = 29
        btnExportNVM2.Text = "Export NVM B"
        btnExportNVM2.UseVisualStyleBackColor = True
        ' 
        ' btnNVMHelp
        ' 
        btnNVMHelp.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNVMHelp.Location = New Point(242, 196)
        btnNVMHelp.Name = "btnNVMHelp"
        btnNVMHelp.Size = New Size(50, 23)
        btnNVMHelp.TabIndex = 26
        btnNVMHelp.Text = "Help"
        btnNVMHelp.UseVisualStyleBackColor = True
        ' 
        ' ModifyNVM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(968, 699)
        Controls.Add(gbxNVMCleaningTools)
        Name = "ModifyNVM"
        Text = "Modify NVM's"
        gbxNVMCleaningTools.ResumeLayout(False)
        gbxNVMCleaningTools.PerformLayout()
        CType(dataGridViewB, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridViewResultB, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridViewResultA, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridViewA, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbxNVMCleaningTools As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents R0C0 As ListBox
    Friend WithEvents R2C5 As ListBox
    Friend WithEvents R1C5 As ListBox
    Friend WithEvents lbxAccessFiles As ListBox
    Friend WithEvents lbxWriteNVMScript As ListBox
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
    Friend WithEvents Label2 As Label
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
End Class
