Imports System.IO
Imports System.Text

Public Class CompareCSVFiles_Form

    Public DataA_FileName
    Public DataB_FileName

    Public DataA_ChainLinkValues As New List(Of String)
    Public DataA_NVMValues As New List(Of String)
    Public DataA_ChainLinkCompare_Dif As New List(Of String)
    Public DataA_NVMCompare_Dif As New List(Of String)

    Public DataB_ChainLinkValues As New List(Of String)
    Public DataB_NVMValues As New List(Of String)
    Public DataB_ChainLinkCompare_Dif As New List(Of String)
    Public DataB_NVMCompare_Dif As New List(Of String)

    Public DataC_ChainLinkCompare_Sim As New List(Of String)



    Private Sub CompareCSVForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CompareCSVForm_DisgracefulClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Xerox_NVM_Automation_Hub.Show()
        Xerox_NVM_Automation_Hub.Focus()
    End Sub



    Private Sub btnImportCSVDataA_Click(sender As Object, e As EventArgs) Handles btnImportCSVDataA.Click
        ' Clear existing items in listboxes
        DataA_DataGrid.Rows.Clear()

        Dim ImportCSVDataSet1 As New OpenFileDialog
        ImportCSVDataSet1.InitialDirectory = "Y:\NVM Archive\"
        ImportCSVDataSet1.Filter = "Excel Files | *.csv"
        Dim filePath As String

        If ImportCSVDataSet1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DataA_FileName = ImportCSVDataSet1.SafeFileName
            filePath = ImportCSVDataSet1.FileName
            txbImportCSVData1.Text = ImportCSVDataSet1.SafeFileName
            Try
                ' Read all lines from the CSV file
                Dim lines As String() = System.IO.File.ReadAllLines(filePath)


                ' Loop through the lines, starting from the second line and excluding the last two lines
                For i As Integer = 1 To lines.Length - 3
                    ' Split the line into columns using a comma as the delimiter
                    Dim columns As String() = lines(i).Split(","c, 7)

                    If columns(0) = "" Then
                        Continue For
                    End If

                    ' Apply leading zeros with a maximum length of 3 digits
                    Dim column1Value As String = columns(1).PadLeft(3, "0"c)
                    Dim column2Value As String = columns(2).PadLeft(3, "0"c)

                    ' Add column 1 to Array
                    DataA_ChainLinkValues.Add(column1Value & column2Value)
                    DataA_NVMValues.Add(columns(5))

                    DataA_DataGrid.Rows.Add(New String() {column1Value & column2Value, columns(5)})
                Next
            Catch ex As Exception
                ' Handle any exceptions that may occur during file reading
                MessageBox.Show("Error reading the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If

        DataA_DataGrid.Sort(DataA_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btnImportCSVDataB_Click(sender As Object, e As EventArgs) Handles btnImportCSVDataB.Click
        DataB_DataGrid.Rows.Clear()

        Dim ImportCSVDataSet2 As New OpenFileDialog
        ImportCSVDataSet2.InitialDirectory = "Y:\NVM Archive\"
        ImportCSVDataSet2.Filter = "Excel Files | *.csv"
        Dim filePath As String = ""

        If ImportCSVDataSet2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DataB_FileName = ImportCSVDataSet2.SafeFileName
            filePath = ImportCSVDataSet2.FileName
            txbImportCSVData2.Text = ImportCSVDataSet2.SafeFileName
            Try
                ' Read all lines from the CSV file
                Dim lines As String() = System.IO.File.ReadAllLines(filePath)

                ' Loop through the lines, starting from the second line and excluding the last two lines
                For i As Integer = 1 To lines.Length - 3
                    ' Split the line into columns using a comma as the delimiter
                    Dim columns As String() = lines(i).Split(","c, 7)

                    If columns(0) = "" Then
                        Continue For
                    End If

                    ' Apply leading zeros with a maximum length of 3 digits
                    Dim column1Value As String = columns(1).PadLeft(3, "0"c)
                    Dim column2Value As String = columns(2).PadLeft(3, "0"c)

                    DataB_ChainLinkValues.Add(column1Value & column2Value)
                    DataB_NVMValues.Add(columns(5))

                    DataB_DataGrid.Rows.Add(New String() {column1Value & column2Value, columns(5)})
                Next
            Catch ex As Exception
                ' Handle any exceptions that may occur during file reading
                MessageBox.Show("Error reading the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If

        DataB_DataGrid.Sort(DataB_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub CompareCSV_Difference()
        ' Initialize indices for D1C0 and D2C0
        Dim indexD1C0 As Integer = 0
        Dim indexD2C0 As Integer = 0

        ' Compare D1C0 and D2C0
        While indexD1C0 < DataA_ChainLinkValues.Count - 1 AndAlso indexD2C0 < DataB_ChainLinkValues.Count - 1
            If DataA_ChainLinkValues(indexD1C0) = DataB_ChainLinkValues(indexD2C0) Then
                ' Both lists have the same item, add it to both result lists
                DataA_ChainLinkCompare_Dif.Add(DataA_ChainLinkValues(indexD1C0))
                DataB_ChainLinkCompare_Dif.Add(DataB_ChainLinkValues(indexD2C0))

                ' Move to the next items in D1C0 and D2C0
                indexD1C0 += 1
                indexD2C0 += 1
            ElseIf String.Compare(DataA_ChainLinkValues(indexD1C0), DataB_ChainLinkValues(indexD2C0)) < 0 Then
                ' D1C0 item is smaller, add it to R1C0 and add a blank to R2C0
                DataA_ChainLinkCompare_Dif.Add(DataA_ChainLinkValues(indexD1C0))
                DataB_ChainLinkCompare_Dif.Add("")

                ' Move to the next item in D1C0
                indexD1C0 += 1
            Else
                ' D2C0 item is smaller, add it to R2C0 and add a blank to R1C0
                DataA_ChainLinkCompare_Dif.Add("")
                DataB_ChainLinkCompare_Dif.Add(DataB_ChainLinkValues(indexD2C0))

                ' Move to the next item in D2C0
                indexD2C0 += 1
            End If
        End While

        ' Fill in any remaining items in D1C0 to R1C0 with blanks in R2C0
        While indexD1C0 < DataA_ChainLinkValues.Count - 1
            DataA_ChainLinkCompare_Dif.Add(DataA_ChainLinkValues(indexD1C0))
            DataB_ChainLinkCompare_Dif.Add("")
            indexD1C0 += 1
        End While

        ' Fill in any remaining items in D2C0 to R2C0 with blanks in R1C0
        While indexD2C0 < DataB_DataGrid.Rows.Count - 2
            DataA_ChainLinkCompare_Dif.Add("")
            DataB_ChainLinkCompare_Dif.Add(DataB_ChainLinkValues(indexD2C0))
            indexD2C0 += 1
        End While

        SortR_C5()
    End Sub
    Private Sub CompareCSV_Similarity()
        For DataA_Index = 0 To DataA_ChainLinkValues.Count - 1
            If Not DataB_ChainLinkValues.Contains(DataA_ChainLinkValues(DataA_Index)) Then
                Continue For
            End If

            For DataB_Index = 0 To DataB_ChainLinkValues.Count - 1
                If DataA_ChainLinkValues(DataA_Index) = DataB_ChainLinkValues(DataB_Index) Then
                    If DataA_NVMValues(DataA_Index) = DataB_NVMValues(DataB_Index) Then
                        If Not DataC_ChainLinkCompare_Sim.Contains(DataA_ChainLinkValues(DataA_Index)) Then
                            DataC_ChainLinkCompare_Sim.Add(DataA_ChainLinkValues(DataA_Index))
                            DataC_Sim_Comparison.Rows.Add(New String() {DataA_ChainLinkValues(DataA_Index), DataA_NVMValues(DataA_Index), DataB_NVMValues(DataB_Index)})
                            DataB_ChainLinkValues.RemoveAt(DataB_Index)
                            DataB_NVMValues.RemoveAt(DataB_Index)
                        End If
                        Exit For
                    ElseIf Not DataA_NVMValues(DataA_Index) = DataB_NVMValues(DataB_Index) Then
                        DataB_ChainLinkValues.RemoveAt(DataB_Index)
                        DataB_NVMValues.RemoveAt(DataB_Index)
                        Exit For
                    End If
                    Exit For
                End If
            Next
        Next

        DataC_Sim_Comparison.Sort(DataC_Sim_Comparison.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub


    Private Sub CompareCSV_Other()
        For DataA_Index = 0 To DataA_ChainLinkValues.Count - 1
            If Not DataB_ChainLinkValues.Contains(DataA_ChainLinkValues(DataA_Index)) Then
                Continue For
            End If

            For DataB_Index = 0 To DataB_DataGrid.Rows.Count - 2
                If DataA_ChainLinkValues(DataA_Index) = DataB_ChainLinkValues(DataB_Index) Then
                    If Not DataC_ChainLinkCompare_Sim.Contains(DataA_DataGrid.Rows(DataA_Index).Cells(0).Value.ToString) Then
                        DataC_ChainLinkCompare_Sim.Add(DataA_DataGrid.Rows(DataA_Index).Cells(0).Value.ToString)
                        DataC_Sim_Comparison.Rows.Add(New String() {DataA_DataGrid.Rows(DataA_Index).Cells(0).Value.ToString, DataA_DataGrid.Rows(DataA_Index).Cells(1).Value.ToString, DataB_DataGrid.Rows(DataB_Index).Cells(1).Value.ToString})
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub SortR_C5()
        Dim Y As Integer = 0
        Dim Z As Integer = 0

        For X As Integer = 0 To DataA_ChainLinkCompare_Dif.Count - 1
            If DataA_ChainLinkCompare_Dif(X).ToString.Length < 4 Then
                DataA_NVMCompare_Dif.Add("")
            Else
                DataA_NVMCompare_Dif.Add(DataA_DataGrid.Rows(Y).Cells(1).Value)
                Y += 1
            End If

            If DataB_ChainLinkCompare_Dif(X).ToString.Length < 4 Then
                DataB_NVMCompare_Dif.Add("")
            Else
                DataB_NVMCompare_Dif.Add(DataB_DataGrid.Rows(Z).Cells(1).Value)
                Z += 1
            End If
        Next

        For X As Integer = 0 To DataA_ChainLinkCompare_Dif.Count - 1
            If DataA_ChainLinkCompare_Dif(X) = DataB_ChainLinkCompare_Dif(X) Then
                If DataA_NVMCompare_Dif(X) = DataB_NVMCompare_Dif(X) Then
                Else
                    DataC_Dif_Comparison.Rows.Add(New String() {DataA_ChainLinkCompare_Dif(X).ToString, DataA_NVMCompare_Dif(X), DataB_NVMCompare_Dif(X)})
                End If
            ElseIf DataA_ChainLinkCompare_Dif(X).ToString.Length < 4 Then
                DataC_Dif_Comparison.Rows.Add(New String() {DataB_ChainLinkCompare_Dif(X).ToString, DataA_NVMCompare_Dif(X), DataB_NVMCompare_Dif(X)})
            ElseIf DataB_ChainLinkCompare_Dif(X).ToString.Length < 4 Then
                DataC_Dif_Comparison.Rows.Add(New String() {DataA_ChainLinkCompare_Dif(X).ToString, DataA_NVMCompare_Dif(X), DataB_NVMCompare_Dif(X)})
            Else
                DataC_Dif_Comparison.Rows.Add(New String() {DataA_ChainLinkCompare_Dif(X).ToString & "-" & DataB_ChainLinkCompare_Dif(X), DataA_NVMCompare_Dif(X), DataB_NVMCompare_Dif(X)})
            End If
        Next

    End Sub

    Private Sub SaveCSVCompare(Chart)
        Dim saveFileDialog As New SaveFileDialog()
        If Chart = "Difference" Then
            saveFileDialog.FileName = txbImportCSVData1.Text & "-" & txbImportCSVData2.Text & "-Dif"
        ElseIf Chart = "Similarity" Then
            saveFileDialog.FileName = txbImportCSVData1.Text & "-" & txbImportCSVData2.Text & "-Sim"
        End If
        saveFileDialog.Filter = "CSV Files|*.csv"
        saveFileDialog.Title = "Save CSV File"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim csvFilePath As String = saveFileDialog.FileName

            Try
                ' Create a StreamWriter to write data to the CSV file
                Using writer As New StreamWriter(csvFilePath, False, Encoding.UTF8)
                    ' Write the header row with column names
                    writer.Write("Chain-Link," & DataA_FileName & "," & DataB_FileName & ",")
                    writer.WriteLine()
                    If Chart = "Difference" Then
                        For X As Integer = 0 To DataC_Dif_Comparison.Rows.Count - 2
                            Dim csvString = DataC_Dif_Comparison.Rows(X).Cells(0).Value.ToString & "," & DataC_Dif_Comparison.Rows(X).Cells(1).Value.ToString & "," & DataC_Dif_Comparison.Rows(X).Cells(2).Value.ToString & ","
                            writer.Write(csvString & vbCrLf)
                        Next
                    ElseIf Chart = "Similarity" Then
                        For X As Integer = 0 To DataC_Sim_Comparison.Rows.Count - 2
                            Dim csvString = DataC_Sim_Comparison.Rows(X).Cells(0).Value.ToString & "," & DataC_Sim_Comparison.Rows(X).Cells(1).Value.ToString & "," & DataC_Sim_Comparison.Rows(X).Cells(2).Value.ToString & ","
                            writer.Write(csvString & vbCrLf)
                        Next
                    End If
                    writer.WriteLine()
                End Using
                MessageBox.Show("Data exported to CSV successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_Compare_Dif_Click(sender As Object, e As EventArgs) Handles btn_Compare_Dif.Click
        CompareCSV_Difference()
    End Sub
    Private Sub btn_Compare_Sim_Click(sender As Object, e As EventArgs) Handles btn_Compare_Sim.Click
        CompareCSV_Similarity()
    End Sub

    Private Sub btn_SaveComparison_Dif_Click(sender As Object, e As EventArgs) Handles btn_SaveComparison_Dif.Click
        SaveCSVCompare("Difference")
    End Sub
    Private Sub btn_SaveComparison_Sim_Click(sender As Object, e As EventArgs) Handles btn_SaveComparison_Sim.Click
        SaveCSVCompare("Similarity")
    End Sub
End Class