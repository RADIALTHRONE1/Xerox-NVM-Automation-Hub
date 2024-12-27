<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PWSLock_SettingsForm
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
        PWSLock_UsePassword = New CheckBox()
        Label2 = New Label()
        Label6 = New Label()
        PWSLock_Password = New TextBox()
        PWSLock_Path = New TextBox()
        PWS_Done = New Button()
        PWSLock_OpenPath = New Button()
        SuspendLayout()
        ' 
        ' PWSLock_UsePassword
        ' 
        PWSLock_UsePassword.AutoSize = True
        PWSLock_UsePassword.Location = New Point(221, 81)
        PWSLock_UsePassword.Name = "PWSLock_UsePassword"
        PWSLock_UsePassword.Size = New Size(98, 19)
        PWSLock_UsePassword.TabIndex = 5
        PWSLock_UsePassword.Text = "Use Password"
        PWSLock_UsePassword.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 15)
        Label2.TabIndex = 4
        Label2.Text = "PWS Lock Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 15)
        Label6.TabIndex = 3
        Label6.Text = "PWS Lock Location:"
        ' 
        ' PWSLock_Password
        ' 
        PWSLock_Password.Location = New Point(15, 79)
        PWSLock_Password.Name = "PWSLock_Password"
        PWSLock_Password.Size = New Size(200, 23)
        PWSLock_Password.TabIndex = 2
        ' 
        ' PWSLock_Path
        ' 
        PWSLock_Path.Location = New Point(15, 30)
        PWSLock_Path.Name = "PWSLock_Path"
        PWSLock_Path.Size = New Size(359, 23)
        PWSLock_Path.TabIndex = 1
        ' 
        ' PWS_Done
        ' 
        PWS_Done.Location = New Point(328, 79)
        PWS_Done.Name = "PWS_Done"
        PWS_Done.Size = New Size(75, 23)
        PWS_Done.TabIndex = 0
        PWS_Done.Text = "Done"
        PWS_Done.UseVisualStyleBackColor = True
        ' 
        ' PWSLock_OpenPath
        ' 
        PWSLock_OpenPath.ForeColor = SystemColors.MenuHighlight
        PWSLock_OpenPath.Location = New Point(380, 30)
        PWSLock_OpenPath.Name = "PWSLock_OpenPath"
        PWSLock_OpenPath.Size = New Size(23, 23)
        PWSLock_OpenPath.TabIndex = 6
        PWSLock_OpenPath.Text = "🗀"
        PWSLock_OpenPath.UseVisualStyleBackColor = True
        ' 
        ' PWSLock_SettingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(449, 135)
        Controls.Add(PWSLock_OpenPath)
        Controls.Add(PWS_Done)
        Controls.Add(PWSLock_UsePassword)
        Controls.Add(PWSLock_Password)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(PWSLock_Path)
        Name = "PWSLock_SettingsForm"
        Padding = New Padding(12)
        StartPosition = FormStartPosition.CenterScreen
        Text = "PWS Lock Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PWSLock_UsePassword As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PWSLock_Password As TextBox
    Friend WithEvents PWSLock_Path As TextBox
    Friend WithEvents PWS_Done As Button
    Friend WithEvents PWSLock_OpenPath As Button
End Class
