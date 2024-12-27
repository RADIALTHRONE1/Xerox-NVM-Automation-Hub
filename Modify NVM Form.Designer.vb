<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyNVMForm
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
        btnCompareNVM = New Button()
        btnResetNVMRead = New Button()
        lbxAccessFiles = New ListBox()
        ckbCleanNVM2 = New CheckBox()
        txtNVM2Filename = New TextBox()
        txtNVM1Filename = New TextBox()
        DataB_ImportSingle = New Button()
        DataB_RemoveEmpty = New Button()
        DataB_ExportData = New Button()
        DataA_RemoveEmpty = New Button()
        ckbCleanNVM1 = New CheckBox()
        DataA_ExportData = New Button()
        DataA_ImportSingle = New Button()
        GroupBox1 = New GroupBox()
        DataA_ImportFolder = New Button()
        GroupBox2 = New GroupBox()
        DataB_ImportFolder = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dataGridViewB = New DataGridView()
        dataGridViewResultB = New DataGridView()
        dataGridViewResultA = New DataGridView()
        dataGridViewA = New DataGridView()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dataGridViewB, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridViewResultB, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridViewResultA, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridViewA, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCompareNVM
        ' 
        btnCompareNVM.Enabled = False
        btnCompareNVM.Location = New Point(41, 422)
        btnCompareNVM.Name = "btnCompareNVM"
        btnCompareNVM.Size = New Size(286, 23)
        btnCompareNVM.TabIndex = 20
        btnCompareNVM.Text = "Compare Sets A and B"
        btnCompareNVM.UseVisualStyleBackColor = True
        ' 
        ' btnResetNVMRead
        ' 
        btnResetNVMRead.Enabled = False
        btnResetNVMRead.Location = New Point(399, 422)
        btnResetNVMRead.Name = "btnResetNVMRead"
        btnResetNVMRead.Size = New Size(286, 23)
        btnResetNVMRead.TabIndex = 18
        btnResetNVMRead.Text = "Reset NVM Data"
        btnResetNVMRead.UseVisualStyleBackColor = True
        ' 
        ' lbxAccessFiles
        ' 
        lbxAccessFiles.FormattingEnabled = True
        lbxAccessFiles.ItemHeight = 15
        lbxAccessFiles.Location = New Point(15, 451)
        lbxAccessFiles.Name = "lbxAccessFiles"
        lbxAccessFiles.Size = New Size(762, 139)
        lbxAccessFiles.TabIndex = 15
        ' 
        ' ckbCleanNVM2
        ' 
        ckbCleanNVM2.AutoSize = True
        ckbCleanNVM2.Location = New Point(162, 51)
        ckbCleanNVM2.Name = "ckbCleanNVM2"
        ckbCleanNVM2.Size = New Size(136, 34)
        ckbCleanNVM2.TabIndex = 35
        ckbCleanNVM2.Text = "Remove Empty NVM" & vbCrLf & "While Loading"
        ckbCleanNVM2.UseVisualStyleBackColor = True
        ' 
        ' txtNVM2Filename
        ' 
        txtNVM2Filename.Location = New Point(6, 109)
        txtNVM2Filename.Name = "txtNVM2Filename"
        txtNVM2Filename.ReadOnly = True
        txtNVM2Filename.Size = New Size(306, 23)
        txtNVM2Filename.TabIndex = 33
        ' 
        ' txtNVM1Filename
        ' 
        txtNVM1Filename.Location = New Point(6, 109)
        txtNVM1Filename.Name = "txtNVM1Filename"
        txtNVM1Filename.ReadOnly = True
        txtNVM1Filename.Size = New Size(306, 23)
        txtNVM1Filename.TabIndex = 32
        ' 
        ' DataB_ImportSingle
        ' 
        DataB_ImportSingle.Location = New Point(6, 22)
        DataB_ImportSingle.Name = "DataB_ImportSingle"
        DataB_ImportSingle.Size = New Size(150, 23)
        DataB_ImportSingle.TabIndex = 19
        DataB_ImportSingle.Text = "Import Single File"
        DataB_ImportSingle.UseVisualStyleBackColor = True
        ' 
        ' DataB_RemoveEmpty
        ' 
        DataB_RemoveEmpty.Enabled = False
        DataB_RemoveEmpty.Location = New Point(6, 51)
        DataB_RemoveEmpty.Name = "DataB_RemoveEmpty"
        DataB_RemoveEmpty.Size = New Size(150, 23)
        DataB_RemoveEmpty.TabIndex = 27
        DataB_RemoveEmpty.Text = "Remove Empty Values"
        DataB_RemoveEmpty.UseVisualStyleBackColor = True
        ' 
        ' DataB_ExportData
        ' 
        DataB_ExportData.Enabled = False
        DataB_ExportData.Location = New Point(6, 80)
        DataB_ExportData.Name = "DataB_ExportData"
        DataB_ExportData.Size = New Size(150, 23)
        DataB_ExportData.TabIndex = 29
        DataB_ExportData.Text = "Export Cleaned Data"
        DataB_ExportData.UseVisualStyleBackColor = True
        ' 
        ' DataA_RemoveEmpty
        ' 
        DataA_RemoveEmpty.Enabled = False
        DataA_RemoveEmpty.Location = New Point(6, 51)
        DataA_RemoveEmpty.Name = "DataA_RemoveEmpty"
        DataA_RemoveEmpty.Size = New Size(150, 23)
        DataA_RemoveEmpty.TabIndex = 24
        DataA_RemoveEmpty.Text = "Remove Empty Values"
        DataA_RemoveEmpty.UseVisualStyleBackColor = True
        ' 
        ' ckbCleanNVM1
        ' 
        ckbCleanNVM1.AutoSize = True
        ckbCleanNVM1.Location = New Point(162, 51)
        ckbCleanNVM1.Name = "ckbCleanNVM1"
        ckbCleanNVM1.Size = New Size(136, 34)
        ckbCleanNVM1.TabIndex = 34
        ckbCleanNVM1.Text = "Remove Empty NVM" & vbCrLf & "While Loading"
        ckbCleanNVM1.UseVisualStyleBackColor = True
        ' 
        ' DataA_ExportData
        ' 
        DataA_ExportData.Enabled = False
        DataA_ExportData.Location = New Point(6, 80)
        DataA_ExportData.Name = "DataA_ExportData"
        DataA_ExportData.Size = New Size(150, 23)
        DataA_ExportData.TabIndex = 28
        DataA_ExportData.Text = "Export Cleaned Data"
        DataA_ExportData.UseVisualStyleBackColor = True
        ' 
        ' DataA_ImportSingle
        ' 
        DataA_ImportSingle.Location = New Point(6, 22)
        DataA_ImportSingle.Name = "DataA_ImportSingle"
        DataA_ImportSingle.Size = New Size(150, 23)
        DataA_ImportSingle.TabIndex = 11
        DataA_ImportSingle.Text = "Import Single File"
        DataA_ImportSingle.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.Controls.Add(DataA_ImportFolder)
        GroupBox1.Controls.Add(DataA_ImportSingle)
        GroupBox1.Controls.Add(DataA_RemoveEmpty)
        GroupBox1.Controls.Add(DataA_ExportData)
        GroupBox1.Controls.Add(ckbCleanNVM1)
        GroupBox1.Controls.Add(txtNVM1Filename)
        GroupBox1.Location = New Point(15, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(318, 154)
        GroupBox1.TabIndex = 39
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Set 'A'"
        ' 
        ' DataA_ImportFolder
        ' 
        DataA_ImportFolder.Location = New Point(162, 22)
        DataA_ImportFolder.Name = "DataA_ImportFolder"
        DataA_ImportFolder.Size = New Size(150, 23)
        DataA_ImportFolder.TabIndex = 29
        DataA_ImportFolder.Text = "Import Folder"
        DataA_ImportFolder.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.AutoSize = True
        GroupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox2.Controls.Add(DataB_ImportFolder)
        GroupBox2.Controls.Add(DataB_ImportSingle)
        GroupBox2.Controls.Add(DataB_RemoveEmpty)
        GroupBox2.Controls.Add(DataB_ExportData)
        GroupBox2.Controls.Add(ckbCleanNVM2)
        GroupBox2.Controls.Add(txtNVM2Filename)
        GroupBox2.Location = New Point(339, 15)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(318, 154)
        GroupBox2.TabIndex = 40
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Set 'B'"
        ' 
        ' DataB_ImportFolder
        ' 
        DataB_ImportFolder.Location = New Point(162, 22)
        DataB_ImportFolder.Name = "DataB_ImportFolder"
        DataB_ImportFolder.Size = New Size(150, 23)
        DataB_ImportFolder.TabIndex = 30
        DataB_ImportFolder.Text = "Import Folder"
        DataB_ImportFolder.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(399, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(239, 15)
        Label5.TabIndex = 48
        Label5.Text = "NVM Data Set 'B' Cleaned/Compared Values"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(399, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 15)
        Label4.TabIndex = 47
        Label4.Text = "NVM Data Set 'B' Source"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 15)
        Label3.TabIndex = 45
        Label3.Text = "NVM Data Set 'A' Cleaned/Compared Values"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 15)
        Label2.TabIndex = 46
        Label2.Text = "NVM Data Set 'A' Source"
        ' 
        ' dataGridViewB
        ' 
        dataGridViewB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewB.Location = New Point(399, 190)
        dataGridViewB.Name = "dataGridViewB"
        dataGridViewB.ReadOnly = True
        dataGridViewB.Size = New Size(378, 100)
        dataGridViewB.TabIndex = 42
        ' 
        ' dataGridViewResultB
        ' 
        dataGridViewResultB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewResultB.Location = New Point(399, 316)
        dataGridViewResultB.Name = "dataGridViewResultB"
        dataGridViewResultB.ReadOnly = True
        dataGridViewResultB.Size = New Size(378, 100)
        dataGridViewResultB.TabIndex = 44
        ' 
        ' dataGridViewResultA
        ' 
        dataGridViewResultA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewResultA.Location = New Point(15, 316)
        dataGridViewResultA.Name = "dataGridViewResultA"
        dataGridViewResultA.ReadOnly = True
        dataGridViewResultA.Size = New Size(378, 100)
        dataGridViewResultA.TabIndex = 43
        ' 
        ' dataGridViewA
        ' 
        dataGridViewA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewA.Location = New Point(15, 190)
        dataGridViewA.Name = "dataGridViewA"
        dataGridViewA.ReadOnly = True
        dataGridViewA.Size = New Size(378, 100)
        dataGridViewA.TabIndex = 41
        ' 
        ' ModifyNVMForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(870, 864)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dataGridViewB)
        Controls.Add(dataGridViewResultB)
        Controls.Add(dataGridViewResultA)
        Controls.Add(dataGridViewA)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lbxAccessFiles)
        Controls.Add(btnCompareNVM)
        Controls.Add(btnResetNVMRead)
        Name = "ModifyNVMForm"
        Padding = New Padding(12)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Modify NVM's"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dataGridViewB, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridViewResultB, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridViewResultA, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridViewA, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbxAccessFiles As ListBox
    Friend WithEvents DataA_ImportSingle As Button
    Friend WithEvents ckbCleanNVM2 As CheckBox
    Friend WithEvents btnCompareNVM As Button
    Friend WithEvents DataA_RemoveEmpty As Button
    Friend WithEvents ckbCleanNVM1 As CheckBox
    Friend WithEvents DataB_ImportSingle As Button
    Friend WithEvents btnResetNVMRead As Button
    Friend WithEvents txtNVM2Filename As TextBox
    Friend WithEvents DataB_RemoveEmpty As Button
    Friend WithEvents DataA_ExportData As Button
    Friend WithEvents txtNVM1Filename As TextBox
    Friend WithEvents DataB_ExportData As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataA_ImportFolder As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataB_ImportFolder As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dataGridViewB As DataGridView
    Friend WithEvents dataGridViewResultB As DataGridView
    Friend WithEvents dataGridViewResultA As DataGridView
    Friend WithEvents dataGridViewA As DataGridView
End Class
