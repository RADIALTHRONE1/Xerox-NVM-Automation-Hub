<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompareCSVFiles_Form
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
        btn_SaveComparison_Dif = New Button()
        txbImportCSVData2 = New TextBox()
        txbImportCSVData1 = New TextBox()
        btn_Compare_Dif = New Button()
        btnImportCSVDataB = New Button()
        btnImportCSVDataA = New Button()
        GroupBox1 = New GroupBox()
        DataA_DataGrid = New DataGridView()
        DataA_ChainLinkGrid = New DataGridViewTextBoxColumn()
        DataA_NVMGrid = New DataGridViewTextBoxColumn()
        DataB_DataGrid = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataC_Dif_Comparison = New DataGridView()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        DataC_Sim_Comparison = New DataGridView()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        btn_Compare_Sim = New Button()
        btn_SaveComparison_Sim = New Button()
        GroupBox1.SuspendLayout()
        CType(DataA_DataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataB_DataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataC_Dif_Comparison, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataC_Sim_Comparison, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_SaveComparison_Dif
        ' 
        btn_SaveComparison_Dif.Location = New Point(15, 473)
        btn_SaveComparison_Dif.Name = "btn_SaveComparison_Dif"
        btn_SaveComparison_Dif.Size = New Size(300, 23)
        btn_SaveComparison_Dif.TabIndex = 51
        btn_SaveComparison_Dif.Text = "Save Difference Comparison"
        btn_SaveComparison_Dif.UseVisualStyleBackColor = True
        ' 
        ' txbImportCSVData2
        ' 
        txbImportCSVData2.Location = New Point(156, 22)
        txbImportCSVData2.Name = "txbImportCSVData2"
        txbImportCSVData2.ReadOnly = True
        txbImportCSVData2.Size = New Size(140, 23)
        txbImportCSVData2.TabIndex = 40
        ' 
        ' txbImportCSVData1
        ' 
        txbImportCSVData1.Location = New Point(154, 22)
        txbImportCSVData1.Name = "txbImportCSVData1"
        txbImportCSVData1.ReadOnly = True
        txbImportCSVData1.Size = New Size(140, 23)
        txbImportCSVData1.TabIndex = 39
        ' 
        ' btn_Compare_Dif
        ' 
        btn_Compare_Dif.Location = New Point(6, 22)
        btn_Compare_Dif.Name = "btn_Compare_Dif"
        btn_Compare_Dif.Size = New Size(288, 23)
        btn_Compare_Dif.TabIndex = 38
        btn_Compare_Dif.Text = "Compare By Differences"
        btn_Compare_Dif.UseVisualStyleBackColor = True
        ' 
        ' btnImportCSVDataB
        ' 
        btnImportCSVDataB.Location = New Point(6, 22)
        btnImportCSVDataB.Name = "btnImportCSVDataB"
        btnImportCSVDataB.Size = New Size(140, 23)
        btnImportCSVDataB.TabIndex = 37
        btnImportCSVDataB.Text = "Import CSV Data B"
        btnImportCSVDataB.UseVisualStyleBackColor = True
        ' 
        ' btnImportCSVDataA
        ' 
        btnImportCSVDataA.Location = New Point(6, 22)
        btnImportCSVDataA.Name = "btnImportCSVDataA"
        btnImportCSVDataA.Size = New Size(140, 23)
        btnImportCSVDataA.TabIndex = 36
        btnImportCSVDataA.Text = "Import CSV Data A"
        btnImportCSVDataA.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.Controls.Add(DataA_DataGrid)
        GroupBox1.Controls.Add(btnImportCSVDataA)
        GroupBox1.Controls.Add(txbImportCSVData1)
        GroupBox1.Location = New Point(15, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 223)
        GroupBox1.TabIndex = 52
        GroupBox1.TabStop = False
        GroupBox1.Text = "CSV Dataset A"
        ' 
        ' DataA_DataGrid
        ' 
        DataA_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataA_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataA_DataGrid.Columns.AddRange(New DataGridViewColumn() {DataA_ChainLinkGrid, DataA_NVMGrid})
        DataA_DataGrid.Location = New Point(6, 51)
        DataA_DataGrid.Name = "DataA_DataGrid"
        DataA_DataGrid.Size = New Size(288, 150)
        DataA_DataGrid.TabIndex = 50
        ' 
        ' DataA_ChainLinkGrid
        ' 
        DataA_ChainLinkGrid.HeaderText = "ChainLink"
        DataA_ChainLinkGrid.Name = "DataA_ChainLinkGrid"
        DataA_ChainLinkGrid.ReadOnly = True
        ' 
        ' DataA_NVMGrid
        ' 
        DataA_NVMGrid.HeaderText = "NVM Value"
        DataA_NVMGrid.Name = "DataA_NVMGrid"
        DataA_NVMGrid.ReadOnly = True
        ' 
        ' DataB_DataGrid
        ' 
        DataB_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataB_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataB_DataGrid.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn4})
        DataB_DataGrid.Location = New Point(6, 51)
        DataB_DataGrid.Name = "DataB_DataGrid"
        DataB_DataGrid.Size = New Size(288, 150)
        DataB_DataGrid.TabIndex = 53
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ChainLink"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "NVM Value"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        ' 
        ' DataC_Dif_Comparison
        ' 
        DataC_Dif_Comparison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataC_Dif_Comparison.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataC_Dif_Comparison.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn8, Column1})
        DataC_Dif_Comparison.Location = New Point(6, 51)
        DataC_Dif_Comparison.Name = "DataC_Dif_Comparison"
        DataC_Dif_Comparison.Size = New Size(288, 150)
        DataC_Dif_Comparison.TabIndex = 54
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "ChainLink"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.HeaderText = "NVM Values A"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        DataGridViewTextBoxColumn8.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NVM Values B"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnImportCSVDataB)
        GroupBox2.Controls.Add(txbImportCSVData2)
        GroupBox2.Controls.Add(DataB_DataGrid)
        GroupBox2.Location = New Point(321, 15)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 223)
        GroupBox2.TabIndex = 55
        GroupBox2.TabStop = False
        GroupBox2.Text = "CSV Dataset B"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.AutoSize = True
        GroupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox3.Controls.Add(btn_Compare_Dif)
        GroupBox3.Controls.Add(DataC_Dif_Comparison)
        GroupBox3.Location = New Point(15, 244)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(300, 223)
        GroupBox3.TabIndex = 56
        GroupBox3.TabStop = False
        GroupBox3.Text = "Difference Comparison"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.AutoSize = True
        GroupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox4.Controls.Add(DataC_Sim_Comparison)
        GroupBox4.Controls.Add(btn_Compare_Sim)
        GroupBox4.Location = New Point(321, 244)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(300, 223)
        GroupBox4.TabIndex = 57
        GroupBox4.TabStop = False
        GroupBox4.Text = "Similarity Comparison"
        ' 
        ' DataC_Sim_Comparison
        ' 
        DataC_Sim_Comparison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataC_Sim_Comparison.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataC_Sim_Comparison.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn6})
        DataC_Sim_Comparison.Location = New Point(6, 51)
        DataC_Sim_Comparison.Name = "DataC_Sim_Comparison"
        DataC_Sim_Comparison.Size = New Size(288, 150)
        DataC_Sim_Comparison.TabIndex = 58
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "ChainLink"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "NVM Values A"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "NVM Values B"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        ' 
        ' btn_Compare_Sim
        ' 
        btn_Compare_Sim.Location = New Point(6, 22)
        btn_Compare_Sim.Name = "btn_Compare_Sim"
        btn_Compare_Sim.Size = New Size(288, 23)
        btn_Compare_Sim.TabIndex = 1
        btn_Compare_Sim.Text = "Compare By Similarities"
        btn_Compare_Sim.UseVisualStyleBackColor = True
        ' 
        ' btn_SaveComparison_Sim
        ' 
        btn_SaveComparison_Sim.Location = New Point(321, 473)
        btn_SaveComparison_Sim.Name = "btn_SaveComparison_Sim"
        btn_SaveComparison_Sim.Size = New Size(300, 23)
        btn_SaveComparison_Sim.TabIndex = 58
        btn_SaveComparison_Sim.Text = "Save Similarity Comparison"
        btn_SaveComparison_Sim.UseVisualStyleBackColor = True
        ' 
        ' CompareCSVFiles_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(833, 567)
        Controls.Add(btn_SaveComparison_Sim)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btn_SaveComparison_Dif)
        Name = "CompareCSVFiles_Form"
        Padding = New Padding(12)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Compare CSV Files"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataA_DataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(DataB_DataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(DataC_Dif_Comparison, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(DataC_Sim_Comparison, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_SaveComparison_Dif As Button
    Friend WithEvents txbImportCSVData2 As TextBox
    Friend WithEvents txbImportCSVData1 As TextBox
    Friend WithEvents btn_Compare_Dif As Button
    Friend WithEvents btnImportCSVDataB As Button
    Friend WithEvents btnImportCSVDataA As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataA_DataGrid As DataGridView
    Friend WithEvents DataB_DataGrid As DataGridView
    Friend WithEvents DataC_Dif_Comparison As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataA_ChainLinkGrid As DataGridViewTextBoxColumn
    Friend WithEvents DataA_NVMGrid As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_Compare_Sim As Button
    Friend WithEvents DataC_Sim_Comparison As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_SaveComparison_Sim As Button
End Class
