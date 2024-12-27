<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDiagnosticTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewDiagnosticTool))
        Label1 = New Label()
        DiagnosticTool_MachineName = New TextBox()
        DiagnosticTool_DoneNew = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        DiagnosticTool_MachineArgument = New TextBox()
        Label3 = New Label()
        DiagnosticTool_TitleBar = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        DiagnosticTool_CurrentPath = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter Machine Name (Shown in the Dropdown)"
        ' 
        ' DiagnosticTool_MachineName
        ' 
        DiagnosticTool_MachineName.Location = New Point(12, 100)
        DiagnosticTool_MachineName.Name = "DiagnosticTool_MachineName"
        DiagnosticTool_MachineName.Size = New Size(500, 23)
        DiagnosticTool_MachineName.TabIndex = 1
        ' 
        ' DiagnosticTool_DoneNew
        ' 
        DiagnosticTool_DoneNew.Location = New Point(12, 568)
        DiagnosticTool_DoneNew.Name = "DiagnosticTool_DoneNew"
        DiagnosticTool_DoneNew.Size = New Size(500, 23)
        DiagnosticTool_DoneNew.TabIndex = 2
        DiagnosticTool_DoneNew.Text = "Done"
        DiagnosticTool_DoneNew.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter Machine Argument:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(12, 225)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(500, 82)
        TextBox1.TabIndex = 4
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' DiagnosticTool_MachineArgument
        ' 
        DiagnosticTool_MachineArgument.Location = New Point(12, 173)
        DiagnosticTool_MachineArgument.Multiline = True
        DiagnosticTool_MachineArgument.Name = "DiagnosticTool_MachineArgument"
        DiagnosticTool_MachineArgument.Size = New Size(500, 46)
        DiagnosticTool_MachineArgument.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 339)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 15)
        Label3.TabIndex = 6
        Label3.Text = "Enter Window Title Bar:"
        ' 
        ' DiagnosticTool_TitleBar
        ' 
        DiagnosticTool_TitleBar.Location = New Point(12, 357)
        DiagnosticTool_TitleBar.Multiline = True
        DiagnosticTool_TitleBar.Name = "DiagnosticTool_TitleBar"
        DiagnosticTool_TitleBar.Size = New Size(500, 46)
        DiagnosticTool_TitleBar.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(12, 409)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(500, 124)
        TextBox2.TabIndex = 8
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(133, 539)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 23)
        TextBox3.TabIndex = 9
        TextBox3.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 15)
        Label4.TabIndex = 10
        Label4.Text = "Diagnostic Tool Path:"
        ' 
        ' DiagnosticTool_CurrentPath
        ' 
        DiagnosticTool_CurrentPath.Location = New Point(12, 27)
        DiagnosticTool_CurrentPath.Name = "DiagnosticTool_CurrentPath"
        DiagnosticTool_CurrentPath.ReadOnly = True
        DiagnosticTool_CurrentPath.Size = New Size(500, 23)
        DiagnosticTool_CurrentPath.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 53)
        Label5.Name = "Label5"
        Label5.Size = New Size(332, 15)
        Label5.TabIndex = 12
        Label5.Text = "Please note this has only been tested with Versant series Tools."
        ' 
        ' NewDiagnosticTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(647, 676)
        Controls.Add(Label5)
        Controls.Add(DiagnosticTool_CurrentPath)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(DiagnosticTool_TitleBar)
        Controls.Add(Label3)
        Controls.Add(DiagnosticTool_MachineArgument)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(DiagnosticTool_DoneNew)
        Controls.Add(DiagnosticTool_MachineName)
        Controls.Add(Label1)
        Name = "NewDiagnosticTool"
        Padding = New Padding(0, 0, 12, 12)
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Diagnostic Tool Info"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DiagnosticTool_MachineName As TextBox
    Friend WithEvents DiagnosticTool_DoneNew As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DiagnosticTool_MachineArgument As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DiagnosticTool_TitleBar As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DiagnosticTool_CurrentPath As TextBox
    Friend WithEvents Label5 As Label
End Class
