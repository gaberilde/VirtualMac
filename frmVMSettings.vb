Option Strict Off
Option Explicit On
Friend Class frmVMSettings
    Inherits System.Windows.Forms.Form
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close() 'Saves nothing and closes the dialog
    End Sub
    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
SaveSettings:
        'Save settings in a file
        Me.Close()
    End Sub
    Private Sub frmVMSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MachineName.Dock = DockStyle.Fill
        Me.Text = "Settings for " + frmMain.MacToEdit
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Label2.Hide()
            If ListView1.SelectedItems(0).Text = "Machine Name" Then
                MachineName.Show()
            Else
                MachineName.Hide()
                Label2.Show()
            End If
        End If
    End Sub
End Class