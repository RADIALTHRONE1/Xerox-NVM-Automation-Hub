Imports System.IO
Imports System.Text

Public Class CompareCSVFiles_Form
    Private Sub ModifyNVMForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Function ParseCsvLine(line As String) As String()
        Dim fields As New List(Of String)

        ' Handle fields with double quotes
        Dim insideQuotes As Boolean = False
        Dim field As String = ""

        For Each c As Char In line
            If c = """" Then
                insideQuotes = Not insideQuotes
            ElseIf c = ","c AndAlso Not insideQuotes Then
                fields.Add(field)
                field = ""
            Else
                field &= c
            End If
        Next

        ' Add the last field
        fields.Add(field)

        Return fields.ToArray()
    End Function

    Private Sub btnImportCSVDataA_Click(sender As Object, e As EventArgs) Handles btnImportCSVDataA.Click
        ' Clear existing items in listboxes
        D1C1.Items.Clear()
        D1C2.Items.Clear()
        D1C5.Items.Clear()


        Dim ImportCSVDataSet1 As New OpenFileDialog
        ImportCSVDataSet1.InitialDirectory = "Y:\NVM Archive\"
        ImportCSVDataSet1.Filter = "Excel Files | *.csv"
        Dim filePath As String

        If ImportCSVDataSet1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            filePath = ImportCSVDataSet1.FileName
            txbImportCSVData1.Text = ImportCSVDataSet1.SafeFileName
            Try
                ' Read all lines from the CSV file
                Dim lines As String() = System.IO.File.ReadAllLines(filePath)

                ' Loop through the lines, starting from the second line and excluding the last two lines
                For i As Integer = 1 To lines.Length - 3
                    ' Split the line into columns using a comma as the delimiter
                    Dim columns As String() = lines(i).Split(","c)

                    ' Apply leading zeros to Column 1 with a maximum length of 3 digits
                    Dim column1Value As String = columns(1).PadLeft(3, "0"c)

                    ' Add column 1 to lbxImportCSVData1Column1
                    D1C1.Items.Add(column1Value)

                    ' Apply leading zeros to Column 1 with a maximum length of 3 digits
                    Dim column2Value As String = columns(2).PadLeft(3, "0"c)

                    ' Add column 2 to lbxImportCSVData1Column2
                    D1C2.Items.Add(column2Value)

                    ' Add column 5 to lbxImportCSVData1Column5
                    D1C5.Items.Add(columns(5))
                Next
            Catch ex As Exception
                ' Handle any exceptions that may occur during file reading
                MessageBox.Show("Error reading the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnImportCSVDataB_Click(sender As Object, e As EventArgs) Handles btnImportCSVDataB.Click
        D2C1.Items.Clear()
        D2C2.Items.Clear()
        D2C5.Items.Clear()

        Dim ImportCSVDataSet2 As New OpenFileDialog
        ImportCSVDataSet2.InitialDirectory = "Y:\NVM Archive\"
        ImportCSVDataSet2.Filter = "Excel Files | *.csv"
        Dim filePath As String = ""

        If ImportCSVDataSet2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            filePath = ImportCSVDataSet2.FileName
            txbImportCSVData2.Text = ImportCSVDataSet2.SafeFileName
            Try
                ' Read all lines from the CSV file
                Dim lines As String() = System.IO.File.ReadAllLines(filePath)

                ' Loop through the lines, starting from the second line and excluding the last two lines
                For i As Integer = 1 To lines.Length - 3
                    ' Split the line into columns using a comma as the delimiter
                    Dim columns As String() = lines(i).Split(","c)

                    ' Apply leading zeros to Column 1 with a maximum length of 3 digits
                    Dim column1Value As String = columns(1).PadLeft(3, "0"c)

                    ' Add column 1 to lbxImportCSVData1Column1
                    D2C1.Items.Add(column1Value)

                    ' Apply leading zeros to Column 1 with a maximum length of 3 digits
                    Dim column2Value As String = columns(2).PadLeft(3, "0"c)

                    ' Add column 2 to lbxImportCSVData1Column2
                    D2C2.Items.Add(column2Value)

                    ' Add column 5 to lbxImportCSVData1Column5
                    D2C5.Items.Add(columns(5))
                Next
            Catch ex As Exception
                ' Handle any exceptions that may occur during file reading
                MessageBox.Show("Error reading the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CompareCSV()
        ' Clear existing items in result list boxes
        R1C0.Items.Clear()
        R2C0.Items.Clear()

        ' Combine all items from D1C1 and D1C2 to create D1C0
        Dim D1C0 As List(Of String) = CombineListBoxItems(D1C1, D1C2)

        ' Combine all items from D2C1 and D2C2 to create D2C0
        Dim D2C0 As List(Of String) = CombineListBoxItems(D2C1, D2C2)

        ' Initialize indices for D1C0 and D2C0
        Dim indexD1C0 As Integer = 0
        Dim indexD2C0 As Integer = 0

        ' Compare D1C0 and D2C0
        While indexD1C0 < D1C0.Count AndAlso indexD2C0 < D2C0.Count
            If D1C0(indexD1C0) = D2C0(indexD2C0) Then
                ' Both lists have the same item, add it to both result lists
                R1C0.Items.Add(D1C0(indexD1C0))
                R2C0.Items.Add(D2C0(indexD2C0))

                ' Move to the next items in D1C0 and D2C0
                indexD1C0 += 1
                indexD2C0 += 1
            ElseIf String.Compare(D1C0(indexD1C0), D2C0(indexD2C0)) < 0 Then
                ' D1C0 item is smaller, add it to R1C0 and add a blank to R2C0
                R1C0.Items.Add(D1C0(indexD1C0))
                R2C0.Items.Add("")

                ' Move to the next item in D1C0
                indexD1C0 += 1
            Else
                ' D2C0 item is smaller, add it to R2C0 and add a blank to R1C0
                R1C0.Items.Add("")
                R2C0.Items.Add(D2C0(indexD2C0))

                ' Move to the next item in D2C0
                indexD2C0 += 1
            End If
        End While

        ' Fill in any remaining items in D1C0 to R1C0 with blanks in R2C0
        While indexD1C0 < D1C0.Count
            R1C0.Items.Add(D1C0(indexD1C0))
            R2C0.Items.Add("")
            indexD1C0 += 1
        End While

        ' Fill in any remaining items in D2C0 to R2C0 with blanks in R1C0
        While indexD2C0 < D2C0.Count
            R1C0.Items.Add("")
            R2C0.Items.Add(D2C0(indexD2C0))
            indexD2C0 += 1
        End While

        SortR_C5()
    End Sub
    Private Function CombineListBoxItems(listBox1 As ListBox, listBox2 As ListBox) As List(Of String)
        ' Combine all items from listBox1 and listBox2
        Dim combinedList As New List(Of String)()

        ' Assuming all items are being combined
        For i As Integer = 0 To Math.Min(listBox1.Items.Count - 1, listBox2.Items.Count - 1)
            Dim combinedItem As String = $"{listBox1.Items(i)}{listBox2.Items(i)}"
            combinedList.Add(combinedItem)
        Next

        Return combinedList
    End Function


    Private Sub SortR_C5()
        Dim Y As Integer = 0
        Dim Z As Integer = 0

        For X As Integer = 0 To R1C0.Items.Count - 1
            If R1C0.Items(X).ToString.Length < 4 Then
                R1C5.Items.Add("")
            Else
                R1C5.Items.Add(D1C5.Items(Y))
                Y += 1
            End If

            If R2C0.Items(X).ToString.Length < 4 Then
                R2C5.Items.Add("")
            Else
                R2C5.Items.Add(D2C5.Items(Z))
                Z += 1
            End If

        Next

        R0C0.Items.Add("Chain-Link,File A,NVM Value,File B,NVM Value")

        For X As Integer = 0 To R1C0.Items.Count - 1
            If R1C0.Items(X) = R2C0.Items(X) Then
                If R1C5.Items(X) = R2C5.Items(X) Then
                Else
                    R0C0.Items.Add(R1C0.Items(X).ToString & "," & txbImportCSVData1.Text & "," & R1C5.Items(X) & "," & txbImportCSVData2.Text & "," & R2C5.Items(X))
                End If
            ElseIf R1C0.Items(X).ToString.Length < 4 Then
                R0C0.Items.Add(R2C0.Items(X).ToString & "," & txbImportCSVData1.Text & "," & R1C5.Items(X) & "," & txbImportCSVData2.Text & "," & R2C5.Items(X))
            ElseIf R2C0.Items(X).ToString.Length < 4 Then
                R0C0.Items.Add(R1C0.Items(X).ToString & "," & txbImportCSVData1.Text & "," & R1C5.Items(X) & "," & txbImportCSVData2.Text & "," & R2C5.Items(X))
            Else
                R0C0.Items.Add(R1C0.Items(X).ToString & "-" & R2C0.Items(X) & "," & txbImportCSVData1.Text & "," & R1C5.Items(X) & "," & txbImportCSVData2.Text & "," & R2C5.Items(X))
            End If
        Next

    End Sub

    Private Sub SaveCSVCompare()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.FileName = txbImportCSVData1.Text & "-" & txbImportCSVData2.Text
        saveFileDialog.Filter = "CSV Files|*.csv"
        saveFileDialog.Title = "Save CSV File"



        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim csvFilePath As String = saveFileDialog.FileName

            Try
                ' Create a StreamWriter to write data to the CSV file
                Using writer As New StreamWriter(csvFilePath, False, Encoding.UTF8)
                    ' Write the header row with column names
                    For X As Integer = 0 To R0C0.Items.Count - 1
                        writer.Write(R0C0.Items(X) & vbCrLf)

                        ' Add a comma except for the last column
                        'If X < R0C0.Items.Count - 1 Then
                        '    writer.Write(",")
                        'End If
                    Next
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



    Private Sub btnCompareCSVData_Click(sender As Object, e As EventArgs) Handles btnCompareCSVData.Click
        CompareCSV()
    End Sub

    Private Sub R1C0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R1C0.SelectedIndexChanged
        R2C0.SelectedIndex = R1C0.SelectedIndex
        R1C5.SelectedIndex = R1C0.SelectedIndex
        R2C5.SelectedIndex = R1C0.SelectedIndex
        R0C0.SelectedIndex = R1C0.SelectedIndex
    End Sub

    Private Sub R2C0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles R2C0.SelectedIndexChanged
        R1C0.SelectedIndex = R2C0.SelectedIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveCSVCompare()
    End Sub

End Class