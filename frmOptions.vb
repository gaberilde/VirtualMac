Option Strict Off
Option Explicit On
Friend Class frmOptions
	Inherits System.Windows.Forms.Form
    Function SelectFolder(Optional ByRef DialogTitle As String = "", Optional ByRef IntialPath As Object = Nothing) As String
        Dim InitialPath As Object
        On Error GoTo errFunction
        On Error Resume Next
        Exit Function
        'Error Handler
errFunction:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        SelectFolder = vbNullString
    End Function
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        My.Settings.DefaultROM = ROMFile.Text
        My.Settings.Save()
        Me.Close()
    End Sub
    Private Sub BrowseFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrowseFolder.Click
        FolderBrowser.ShowDialog()
        DefaultMacFolder.Text = FolderBrowser.SelectedPath
    End Sub
    Private Sub BrowseROM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrowseROM.Click
        BrowseOpen.Filter = "ROM File (*.rom)|*.rom|All files (*.*)|*.*"
        If BrowseOpen.ShowDialog() = DialogResult.OK Then
            ROMFile.Text = BrowseOpen.FileName
        End If
    End Sub
    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ROMFile.Text = My.Settings.DefaultROM
    End Sub
End Class