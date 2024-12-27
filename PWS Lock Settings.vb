Imports System.IO
Imports System.Runtime.CompilerServices

Public Class PWSLock_SettingsForm
    Private Sub PWSLock_SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PWSLock_Path.Text = My.Settings.PWSLock_Path
            PWSLock_Password.Text = My.Settings.PWSLock_Password
            If My.Settings.PWSLock_Password_Enter = True Then
                PWSLock_UsePassword.Checked = True
            Else
                PWSLock_UsePassword.Checked = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PWSLock_SettingsForm_DisgracefulClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Xerox_NVM_Automation_Hub.Show()
        Xerox_NVM_Automation_Hub.Focus()
    End Sub

    Private Sub OpenFileDialog_PWSLockPath()
        Dim OpenFileDialog_PWSLockPath As New OpenFileDialog()

        OpenFileDialog_PWSLockPath.InitialDirectory = "C:\Xerox\"
        OpenFileDialog_PWSLockPath.Filter = "PWSLOCK.exe|*.exe"

        If OpenFileDialog_PWSLockPath.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PWSLock_Path.Text = New FileInfo(OpenFileDialog_PWSLockPath.FileName).FullName.ToString
        End If
    End Sub

    Private Sub ClosePWSLockSettings_Click(sender As Object, e As EventArgs) Handles PWS_Done.Click
        My.Settings.PWSLock_Path = PWSLock_Path.Text
        My.Settings.PWSLock_Password = PWSLock_Password.Text
        If PWSLock_UsePassword.Checked Then
            My.Settings.PWSLock_Password_Enter = True
            My.Settings.PWSLock_Password_EnterAsked = True
        Else
            My.Settings.PWSLock_Password_Enter = False
        End If

        Xerox_NVM_Automation_Hub.Show()
        Me.Hide()
        Xerox_NVM_Automation_Hub.Focus()
    End Sub

    Private Sub OpenPWSLockPath_Click(sender As Object, e As EventArgs) Handles PWSLock_OpenPath.Click
        OpenFileDialog_PWSLockPath()
    End Sub

End Class
