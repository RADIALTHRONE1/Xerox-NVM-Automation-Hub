Imports System.IO
Imports System.Text
Imports System.Data.OleDb


Public Class ModifyNVMForm



    Public CompareButtonA As Boolean = False
    Public CompareButtonB As Boolean = False
    Public CompareButtonC As Boolean = True
    Public NVM1Filename As String
    Public NVM2Filename As String

    Public objConn As OleDbConnection 'Used for the Access Database stuff

    Private Sub ModifyNVMForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ModifyNVMForm_DisgracefulClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Xerox_NVM_Automation_Hub.Show()
        Xerox_NVM_Automation_Hub.Focus()
    End Sub

    Private Sub Data_ImportAccess_Single(DataCaller)

        Dim Data_AccessFile As String
        Dim Data_SelectAccessFile As New OpenFileDialog
        Data_SelectAccessFile.InitialDirectory = My.Settings.NVMModify_LastFolder
        Data_SelectAccessFile.Filter = "Access Files | *.accdb"

        If Data_SelectAccessFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Data_AccessFile = New FileInfo(Data_SelectAccessFile.FileName).FullName.ToString
            My.Settings.NVMModify_LastFolder = New FileInfo(Data_SelectAccessFile.FileName).DirectoryName
        Else
            Exit Sub
        End If

        If DataCaller = "A" Then
            txtNVM1Filename.Text = Data_AccessFile
        ElseIf DataCaller = "B" Then
            txtNVM2Filename.Text = Data_AccessFile
        Else
            Exit Sub
        End If

        Dim allDataTables As New List(Of DataTable)()

        Try
            ' Connection string for the current Access database file
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Data_AccessFile};"

            ' Create a connection to the current Access database
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' List of table names in the current Access database (customize as needed)
                Dim tableNames As String() = {"NVM Access Machine Data"} ' Replace with your table names

                ' Loop through each table in the current database
                For Each tableName As String In tableNames
                    ' Retrieve data from the Access table
                    Using adapter As New OleDbDataAdapter($"SELECT * FROM [{tableName}]", connection)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Add the data table to the list
                        allDataTables.Add(dataTable)
                    End Using
                Next
            End Using

            ' Combine all DataTables into a single DataTable
            Dim combinedDataTable As New DataTable()
            If allDataTables.Count > 0 Then
                combinedDataTable = allDataTables(0).Clone()
                For Each dt As DataTable In allDataTables
                    combinedDataTable.Merge(dt)
                Next
            End If

            ' Bind the combined data to the DataGridView
            If DataCaller = "A" Then
                dataGridViewA.DataSource = combinedDataTable

                DataA_ImportSingle.Enabled = False
                CompareButtonA = True
                If CompareButtonA = True And CompareButtonB = True And CompareButtonC = True Then
                    btnCompareNVM.Enabled = True
                End If
                DataA_RemoveEmpty.Enabled = True
            ElseIf DataCaller = "B" Then
                dataGridViewB.DataSource = combinedDataTable

                DataB_ImportSingle.Enabled = False
                CompareButtonB = True
                If CompareButtonA = True And CompareButtonB = True And CompareButtonC = True Then
                    btnCompareNVM.Enabled = True
                End If
                DataB_RemoveEmpty.Enabled = True
            End If

            btnResetNVMRead.Enabled = True
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub Data_ImportAccess_Folder(DataCaller)
        lbxAccessFiles.Items.Clear()
        Dim Data_AccessFolder
        Dim Data_SelectAccessFolder As New FolderBrowserDialog
        Data_SelectAccessFolder.InitialDirectory = My.Settings.NVMModify_LastFolder

        If Data_SelectAccessFolder.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Data_AccessFolder = New FileInfo(Data_SelectAccessFolder.SelectedPath).FullName.ToString()
        Else
            Exit Sub
        End If
        If DataCaller = "A" Then
            txtNVM1Filename.Text = Data_AccessFolder
        ElseIf DataCaller = "B" Then
            txtNVM2Filename.Text = Data_AccessFolder
        Else
            Exit Sub
        End If

        Dim allDataTables As New List(Of DataTable)()

        For Each file As String In Directory.GetFiles(Data_AccessFolder, "*.accdb")
            lbxAccessFiles.Items.Add(file)
        Next

        Try
            ' Loop through each .accdb file in the directory
            For Each item In lbxAccessFiles.Items
                ' Connection string for the current Access database file
                Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={item};"

                ' Create a connection to the current Access database
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()

                    ' List of table names in the current Access database (customize as needed)
                    Dim tableNames As String() = {"NVM Access Machine Data"} ' Replace with your table names

                    ' Loop through each table in the current database
                    For Each tableName As String In tableNames
                        ' Retrieve data from the Access table
                        Using adapter As New OleDbDataAdapter($"SELECT * FROM [{tableName}]", connection)
                            Dim dataTable As New DataTable()
                            adapter.Fill(dataTable)

                            ' Add the data table to the list
                            allDataTables.Add(dataTable)
                        End Using
                    Next
                End Using
            Next

            ' Combine all DataTables into a single DataTable
            Dim combinedDataTable As New DataTable()
            If allDataTables.Count > 0 Then
                combinedDataTable = allDataTables(0).Clone()
                For Each dt As DataTable In allDataTables
                    combinedDataTable.Merge(dt)
                Next
            End If

            If DataCaller = "A" Then
                dataGridViewA.DataSource = combinedDataTable

                DataA_ImportSingle.Enabled = False
                DataA_ImportFolder.Enabled = False
                CompareButtonA = True
                If CompareButtonA = True And CompareButtonB = True And CompareButtonC = True Then
                    btnCompareNVM.Enabled = True
                End If
                DataA_RemoveEmpty.Enabled = True
            ElseIf DataCaller = "B" Then
                dataGridViewB.DataSource = combinedDataTable

                DataB_ImportSingle.Enabled = False
                DataB_ImportFolder.Enabled = False
                CompareButtonB = True
                If CompareButtonA = True And CompareButtonB = True And CompareButtonC = True Then
                    btnCompareNVM.Enabled = True
                End If
                DataB_RemoveEmpty.Enabled = True
            End If

            btnResetNVMRead.Enabled = True
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub Data_RemoveEmptyValues(DataCaller)
        CompareButtonC = False
        btnCompareNVM.Enabled = False

        Dim columnIndexChainLink As Integer = 0
        Dim columnIndexValue As Integer = 5
        Dim columnIndexStatus As Integer = 7

        Dim GridRowCount As Integer

        If DataCaller = "A" Then
            DataA_RemoveEmpty.Enabled = False

            For Each dgvColumn As DataGridViewColumn In dataGridViewA.Columns
                Dim newColumn As New DataGridViewTextBoxColumn()
                newColumn.Name = dgvColumn.Name
                newColumn.HeaderText = dgvColumn.HeaderText
                newColumn.DataPropertyName = dgvColumn.DataPropertyName
                dataGridViewResultA.Columns.Add(newColumn)
                'DataGridView4.Columns.Add(newColumn)
            Next

            GridRowCount = dataGridViewA.Rows.Count

            For X As Integer = 0 To GridRowCount - 1
                Dim cellStatusGrid1 As Object = dataGridViewA.Rows(X).Cells(columnIndexStatus).Value

                If cellStatusGrid1 = 13 Or cellStatusGrid1 = 14 Then

                Else
                    Dim newRowGrid3 As DataGridViewRow = New DataGridViewRow()
                    For columnIndexCopy As Integer = 0 To dataGridViewA.Columns.Count - 1
                        Dim cellValue As Object = dataGridViewA.Rows(X).Cells(columnIndexCopy).Value
                        newRowGrid3.Cells.Add(New DataGridViewTextBoxCell With {.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)})
                    Next
                    dataGridViewResultA.Rows.Add(newRowGrid3)
                End If
            Next

            DataA_ExportData.Enabled = True
        ElseIf DataCaller = "B" Then
            DataB_RemoveEmpty.Enabled = False

            For Each dgvColumn As DataGridViewColumn In dataGridViewB.Columns
                Dim newColumn As New DataGridViewTextBoxColumn()
                newColumn.Name = dgvColumn.Name
                newColumn.HeaderText = dgvColumn.HeaderText
                newColumn.DataPropertyName = dgvColumn.DataPropertyName
                dataGridViewResultB.Columns.Add(newColumn)
                'DataGridView4.Columns.Add(newColumn)
            Next

            GridRowCount = dataGridViewB.Rows.Count

            For X As Integer = 0 To GridRowCount - 1
                Dim cellStatusGrid1 As Object = dataGridViewB.Rows(X).Cells(columnIndexStatus).Value

                If cellStatusGrid1 = 13 Or cellStatusGrid1 = 14 Then

                Else
                    Dim newRowGrid3 As DataGridViewRow = New DataGridViewRow()
                    For columnIndexCopy As Integer = 0 To dataGridViewB.Columns.Count - 1
                        Dim cellValue As Object = dataGridViewB.Rows(X).Cells(columnIndexCopy).Value
                        newRowGrid3.Cells.Add(New DataGridViewTextBoxCell With {.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)})
                    Next
                    dataGridViewResultB.Rows.Add(newRowGrid3)
                End If
            Next

            DataB_ExportData.Enabled = True
        End If
    End Sub

    Private Sub Data_ExportCleanedData(DataCaller)

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV Files|*.csv"
        saveFileDialog.Title = "Save CSV File"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim csvFilePath As String = saveFileDialog.FileName

            Try
                ' Create a StreamWriter to write data to the CSV file
                Using writer As New StreamWriter(csvFilePath, False, Encoding.UTF8)
                    If DataCaller = "A" Then
                        ' Write the header row with column names
                        For colIndex As Integer = 0 To dataGridViewResultA.ColumnCount - 1
                            writer.Write(dataGridViewResultA.Columns(colIndex).HeaderText)

                            ' Add a comma except for the last column
                            If colIndex < dataGridViewResultA.ColumnCount - 1 Then
                                writer.Write(",")
                            End If
                        Next
                        writer.WriteLine()

                        ' Write the data rows
                        For rowIndex As Integer = 0 To dataGridViewResultA.RowCount - 1
                            For colIndex As Integer = 0 To dataGridViewResultA.ColumnCount - 1
                                writer.Write(dataGridViewResultA.Rows(rowIndex).Cells(colIndex).Value)

                                ' Add a comma except for the last column
                                If colIndex < dataGridViewResultA.ColumnCount - 1 Then
                                    writer.Write(",")
                                End If
                            Next
                            writer.WriteLine()
                        Next
                    ElseIf DataCaller = "B" Then
                        ' Write the header row with column names
                        For colIndex As Integer = 0 To dataGridViewResultB.ColumnCount - 1
                            writer.Write(dataGridViewResultB.Columns(colIndex).HeaderText)

                            ' Add a comma except for the last column
                            If colIndex < dataGridViewResultB.ColumnCount - 1 Then
                                writer.Write(",")
                            End If
                        Next
                        writer.WriteLine()

                        ' Write the data rows
                        For rowIndex As Integer = 0 To dataGridViewResultB.RowCount - 1
                            For colIndex As Integer = 0 To dataGridViewResultB.ColumnCount - 1
                                writer.Write(dataGridViewResultB.Rows(rowIndex).Cells(colIndex).Value)

                                ' Add a comma except for the last column
                                If colIndex < dataGridViewResultB.ColumnCount - 1 Then
                                    writer.Write(",")
                                End If
                            Next
                            writer.WriteLine()
                        Next
                    End If
                End Using

                MessageBox.Show("Data exported to CSV successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If
    End Sub


    '========================================
    '============                ============
    '========================================

    Private Sub btnResetNVMRead_Click(sender As Object, e As EventArgs) Handles btnResetNVMRead.Click
        NVM1Filename = ""
        NVM2Filename = ""

        txtNVM1Filename.Text = ""
        txtNVM2Filename.Text = ""

        dataGridViewA.DataSource = Nothing
        dataGridViewB.DataSource = Nothing
        dataGridViewResultA.DataSource = Nothing
        dataGridViewResultB.DataSource = Nothing

        dataGridViewA.Rows.Clear()
        dataGridViewB.Rows.Clear()
        dataGridViewResultA.Rows.Clear()
        dataGridViewResultA.Columns.Clear()
        dataGridViewResultB.Rows.Clear()
        dataGridViewResultB.Columns.Clear()

        DataA_ImportSingle.Enabled = True
        DataB_ImportSingle.Enabled = True
        DataA_RemoveEmpty.Enabled = False
        DataB_RemoveEmpty.Enabled = False
        btnCompareNVM.Enabled = False
        DataA_ExportData.Enabled = False
        DataB_ExportData.Enabled = False

        ckbCleanNVM1.Enabled = True
        ckbCleanNVM1.CheckState = False
        ckbCleanNVM2.Enabled = True
        ckbCleanNVM2.CheckState = False

        CompareButtonA = False
        CompareButtonB = False
        CompareButtonC = True

        btnResetNVMRead.Enabled = False
    End Sub

    Private Sub Data_ComparedCleanedValues()

        DataA_RemoveEmpty.Enabled = False
        DataB_RemoveEmpty.Enabled = False

        For Each dgvColumn As DataGridViewColumn In dataGridViewA.Columns
            Dim newColumn As New DataGridViewTextBoxColumn()
            newColumn.Name = dgvColumn.Name
            newColumn.HeaderText = dgvColumn.HeaderText
            newColumn.DataPropertyName = dgvColumn.DataPropertyName
            dataGridViewResultA.Columns.Add(newColumn)
            'DataGridView4.Columns.Add(newColumn)
        Next
        For Each dgvColumn As DataGridViewColumn In dataGridViewA.Columns
            Dim newColumn As New DataGridViewTextBoxColumn()
            newColumn.Name = dgvColumn.Name
            newColumn.HeaderText = dgvColumn.HeaderText
            newColumn.DataPropertyName = dgvColumn.DataPropertyName
            'DataGridView3.Columns.Add(newColumn)
            dataGridViewResultB.Columns.Add(newColumn)
        Next

        Dim columnIndexCahinLink As Integer = 0
        Dim columnIndexValue As Integer = 5
        Dim columnIndexStatus As Integer = 7

        Dim Grid1RowCount As Integer = dataGridViewA.Rows.Count
        Dim Grid2RowCount As Integer = dataGridViewB.Rows.Count
        Dim MaxRows As Integer = Math.Max(Grid1RowCount, Grid2RowCount)


        For X As Integer = 0 To MaxRows - 1

            'Dim cellValueGrid1 As Object = DataGridView1.Rows(X).Cells(columnIndexChainLink).Value
            'Dim cellValueGrid2 As Object = DataGridView2.Rows(X).Cells(columnIndexChainLink).Value

            'If cellValueGrid1 = cellValueGrid2 Then

            Dim cellValueGrid1 As Object = dataGridViewA.Rows(X).Cells(columnIndexValue).Value
            Dim cellValueGrid2 As Object = dataGridViewB.Rows(X).Cells(columnIndexValue).Value

            Dim cellStatusGrid1 As Object = dataGridViewA.Rows(X).Cells(columnIndexStatus).Value
            Dim cellStatusGrid2 As Object = dataGridViewB.Rows(X).Cells(columnIndexStatus).Value

            'cellValueGrid1 = DataGridView1.Rows(X).Cells(columnIndex).Value
            'cellValueGrid2 = DataGridView2.Rows(X).Cells(columnIndex).Value

            If (cellStatusGrid1 = 13 And cellStatusGrid2 = 13) Or (cellStatusGrid1 = 14 And cellStatusGrid2 = 14) Then

            ElseIf cellValueGrid1 <> cellValueGrid2 Then
                Dim newRowGrid3 As DataGridViewRow = New DataGridViewRow()
                For columnIndexCopy As Integer = 0 To dataGridViewA.Columns.Count - 1
                    Dim cellValue As Object = dataGridViewA.Rows(X).Cells(columnIndexCopy).Value
                    newRowGrid3.Cells.Add(New DataGridViewTextBoxCell With {.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)})
                Next
                dataGridViewResultA.Rows.Add(newRowGrid3)

                Dim newRowGrid4 As DataGridViewRow = New DataGridViewRow()
                For columnIndexCopy As Integer = 0 To dataGridViewB.Columns.Count - 1
                    Dim cellValue As Object = dataGridViewB.Rows(X).Cells(columnIndexCopy).Value
                    newRowGrid4.Cells.Add(New DataGridViewTextBoxCell With {.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)})
                Next
                dataGridViewResultB.Rows.Add(newRowGrid4)

            End If

        Next

        DataA_ExportData.Enabled = True
        DataB_ExportData.Enabled = True

    End Sub

    '========================================
    '================ Buttons ===============
    '========================================

    Private Sub DataA_ImportSingle_Click(sender As Object, e As EventArgs) Handles DataA_ImportSingle.Click
        If ckbCleanNVM1.Checked = True Then
            ckbCleanNVM1.Enabled = False
            Data_ImportAccess_Single("A")
            Data_RemoveEmptyValues("A")
        Else
            Data_ImportAccess_Single("A")
        End If
    End Sub
    Private Sub DataB_ImportSingle_Click(sender As Object, e As EventArgs) Handles DataB_ImportSingle.Click
        If ckbCleanNVM2.Checked = True Then
            ckbCleanNVM2.Enabled = False
            Data_ImportAccess_Single("B")
            Data_RemoveEmptyValues("B")
        Else
            Data_ImportAccess_Single("B")
        End If
    End Sub
    Private Sub DataA_ImportFolder_Click(sender As Object, e As EventArgs) Handles DataA_ImportFolder.Click
        Dim ConfirmAction = MsgBox("This may take a while, and it will look like it froze or crashed. Proceed?", MsgBoxStyle.OkCancel)
        If ConfirmAction = MsgBoxResult.Ok Then
            If ckbCleanNVM1.Checked = True Then
                ckbCleanNVM1.Enabled = False
                Data_ImportAccess_Folder("A")
                Data_RemoveEmptyValues("A")
            Else
                Data_ImportAccess_Folder("A")
            End If
        End If
    End Sub
    Private Sub DataB_ImportFolder_Click(sender As Object, e As EventArgs) Handles DataB_ImportFolder.Click
        Dim ConfirmAction = MsgBox("This may take a while, and it will look like it froze or crashed. Proceed?", MsgBoxStyle.OkCancel)
        If ConfirmAction = MsgBoxResult.Ok Then
            If ckbCleanNVM2.Checked = True Then
                ckbCleanNVM2.Enabled = False
                Data_ImportAccess_Folder("B")
                Data_RemoveEmptyValues("B")
            Else
                Data_ImportAccess_Folder("B")
            End If
        End If
    End Sub
    Private Sub DataA_RemoveEmpty_Click(sender As Object, e As EventArgs) Handles DataA_RemoveEmpty.Click
        Data_RemoveEmptyValues("A")
    End Sub
    Private Sub DataB_RemoveEmpty_Click(sender As Object, e As EventArgs) Handles DataB_RemoveEmpty.Click
        Data_RemoveEmptyValues("B")
    End Sub
    Private Sub DataA_ExportData_Click(sender As Object, e As EventArgs) Handles DataA_ExportData.Click
        Data_ExportCleanedData("A")
    End Sub
    Private Sub btnExportNVM2_Click(sender As Object, e As EventArgs) Handles DataB_ExportData.Click
        Data_ExportCleanedData("B")
    End Sub

    Private Sub btnCompareNVM_Click(sender As Object, e As EventArgs) Handles btnCompareNVM.Click
        If CompareButtonA = False Or CompareButtonB = False Then
            Exit Sub
        Else
            Data_ComparedCleanedValues()
        End If
    End Sub

End Class