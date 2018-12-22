Option Strict Off
Option Explicit On
Friend Class frmAbout
	Inherits System.Windows.Forms.Form
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		SystemInformation()
		
	End Sub

    Public Sub SystemInformation()
        'Obtain the system info

        OSName.Text = My.Computer.Info.OSFullName
        OSVersion.Text = My.Computer.Info.OSVersion
    End Sub
End Class