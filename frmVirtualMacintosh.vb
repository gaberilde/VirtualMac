Option Strict Off
Option Explicit On
Friend Class frmVirtualMacintosh
    Inherits System.Windows.Forms.Form
    Public Sub mnuActionCloseVM_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionCloseVM.Click
        Me.Close()
    End Sub
    Public Sub mnuCDCapture_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCDCapture.Click
        BrowserOpen.Filter = "Disc Images (*.iso)|*.iso|All files (*.*)|*.*"
        If BrowserOpen.ShowDialog() = DialogResult.OK Then
            'dostuff
        End If
    End Sub
    Public Sub mnuFloppyCapture_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFloppyCapture.Click
        BrowserOpen.Filter = "Floppy Images (*.img;*.ima)|*.img;*.ima|All files (*.*)|*.*"
        If BrowserOpen.ShowDialog() = DialogResult.OK Then
            'dostuff
        End If
    End Sub
    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub
End Class