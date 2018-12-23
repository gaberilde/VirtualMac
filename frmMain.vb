Option Strict Off
Option Explicit On
Friend Class frmMain
	Inherits System.Windows.Forms.Form
    'Private Declare Function SetParent Lib "user32" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer

    '===Declarations===
    Dim retF As Integer 'To set the parent of the Frame
    Dim retS As Integer 'To set the parent of the VMSnap
    Dim i As Integer 'Used to identify the graphic being handled
    Dim x As Integer 'Used to know which and where was the last graphic
    Dim division As Integer
    Public Shared MacToEdit As String ' Used for settings window to know which one to edit
    Public Shared MacToEditPath As String ' Used for settings window to know path of which one to edit
    Public Shared listnumber As Integer = 0 ' Used to keep track of items in list for new list
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        VirtualMacTray.Visible = True
        VMListnew.BeginUpdate()
        For Each mac As Object In My.Settings.MacList
            Dim name As String = mac.ToString.Trim(Chr(34))
            If IO.File.Exists(After(name, ",").Trim(Chr(34))) Then
                VMListnew.Items.Add(Before(name, ",").Trim(Chr(34)) + frmMain.listnumber.ToString + frmMain.listnumber.ToString + Environment.NewLine + "Not running", Before(name, ",").Trim(Chr(34)), frmMain.listnumber)
            Else
                MsgBox("Cant find the '" & After(name, ",").Trim(Chr(34)) & "' VM on the computer. If you are sure it exists, check that you have permsissions to access it.", MsgBoxStyle.Exclamation)
                VMListnew.Items.Add(Before(name, ",").Trim(Chr(34)) + frmMain.listnumber.ToString + frmMain.listnumber.ToString + Environment.NewLine + "Not running", Before(name, ",").Trim(Chr(34)) & " (inaccessible)", frmMain.listnumber)
            End If
            VMListnew.Items(frmMain.listnumber).SubItems.Add(After(name, ",").Trim(Chr(34)))
            Dim bmp As New Bitmap(58, 82)
            Dim flagGraphics As Graphics = Graphics.FromImage(bmp)
            flagGraphics.FillRectangle(Brushes.Gray, 0, 10, 58, 56)
            ImageList1.Images.Add(bmp)
            listnumber += 1
        Next
        VMListnew.EndUpdate()
    End Sub
    Function Before(value As String, a As String) As String
        ' Get index of argument and return substring up to that point.
        Dim posA As Integer = value.IndexOf(a)
        If posA = -1 Then
            Return ""
        End If
        Return value.Substring(0, posA)
    End Function

    Function After(value As String, a As String) As String
        ' Get index of argument and return substring after its position.
        Dim posA As Integer = value.LastIndexOf(a)
        If posA = -1 Then
            Return ""
        End If
        Dim adjustedPosA As Integer = posA + a.Length
        If adjustedPosA >= value.Length Then
            Return ""
        End If
        Return value.Substring(adjustedPosA)
    End Function
    Private Sub frmMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.WindowState <> System.Windows.Forms.FormWindowState.Minimized Then
            SaveSetting(My.Application.Info.Title, "Settings", "MainLeft", CStr(VB6.PixelsToTwipsX(Me.Left)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainTop", CStr(VB6.PixelsToTwipsY(Me.Top)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainWidth", CStr(VB6.PixelsToTwipsX(Me.Width)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainHeight", CStr(VB6.PixelsToTwipsY(Me.Height)))
        End If
    End Sub
    Public Sub Start68kEmulation()
        MsgBox("Virtual Mac © " & "Beta. Virtualization isn't supported (again). Only fake OS X screen plus example stuff avaible")
        'Shell (App.Path & "\68k.exe"), vbNormalFocus
        frmVirtualMacintosh.Text = VMListnew.SelectedItems(0).Text & " - Virtual Mac"
        frmVirtualMacintosh.Show()
    End Sub
    Public Sub EnableButtons()
        mnuActionStart.Enabled = True
        'mnuActionPause.Enabled = True
        'mnuActionRestart.Enabled = True
        mnuActionRemove.Enabled = True
        mnuActionSettings.Enabled = True
        'mnuActionProperties.Enabled = True
        Settings.Enabled = True
        Remove.Enabled = True
        Start.Enabled = True
    End Sub
    Private Sub StartPPCEmulation()
        MsgBox("PPC.exe MUST be in the same directory as VirtualMac. Launching SheepShaver WITHOUT PREFS (Expect errors)", MsgBoxStyle.Information)
        Shell(My.Application.Info.DirectoryPath & "\PPC.exe", AppWinStyle.NormalFocus)
    End Sub
    Public Sub mnuActionRemove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionRemove.Click
        RemoveSelectedMac()
    End Sub
    Public Sub RemoveSelectedMac()
        'Declarations
        'Checks that you have a machine selected
        If VMListnew.SelectedIndices.Count = 1 Then
            'Asks you if you really want to delete the machine
            Dim Answer As Short = MsgBox("You have choosen to remove '" & VMListnew.SelectedItems(0).Text & "' from the Virtual Mac Console. Removing items from this list will not delete the .mcc or .dsk files from your physical computer. Do you want to remove this Virtual Mac from the Virtual Mac Console?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Virtual Mac")
            My.Settings.MacList.Remove("""" & VMListnew.SelectedItems(0).Text.Replace(" (inaccessible)", "") & """" & "," & """" & VMListnew.SelectedItems(0).SubItems(1).Text & """")
            My.Settings.Save()
            'If you don't want that old Mac Plus, this
            'is where it's deleted and recycled (Maybe)
            If Answer = 6 Then
                VMListnew.Items.Remove(VMListnew.SelectedItems(0))
                DisableButtons()
            End If
        End If
    End Sub
    Public Sub mnuActionStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionStart.Click
        Start68kEmulation()
    End Sub
    Public Sub mnuFileOptions_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileOptions.Click
        frmOptions.ShowDialog()
    End Sub
    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub
    Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
        End
    End Sub
    Public Sub mnuNewDisk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewDisk.Click
        frmNewDisk.Show()
    End Sub
    Public Sub mnuNewMac_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewMac.Click
        frmNewMac.Show()
    End Sub
    Private Sub NewMac_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles NewMac.Click
        frmNewMac.Show()
    End Sub
    Private Sub MacRemove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Remove.Click
        RemoveSelectedMac()
    End Sub
    Private Sub Settings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Settings.Click
        OpenSettingsFor(VMListnew.SelectedItems(0).Text)
    End Sub
    Public Sub OpenSettingsFor(ByRef MacName As String)
        MacToEdit = MacName
        MacToEditPath = VMListnew.SelectedItems(0).SubItems(1).Text
        frmVMSettings.Text = "Settings for " & MacName
        frmVMSettings.Show()
    End Sub
    Private Sub Start_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Start.Click
        Start68kEmulation()
    End Sub
    Public Sub DisableButtons()
        mnuActionStart.Enabled = False
        mnuActionPause.Enabled = False
        mnuActionRestart.Enabled = False
        mnuActionRemove.Enabled = False
        mnuActionSettings.Enabled = False
        mnuActionProperties.Enabled = False
        Settings.Enabled = False
        Remove.Enabled = False
        Start.Enabled = False
    End Sub
    Private Sub VM_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = VMListnew.SelectedItems(0).Index
        Start68kEmulation()
    End Sub
    Private Sub VMDescription_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = VMListnew.SelectedItems(0).Index
        Start68kEmulation()
    End Sub
    Private Sub IconNewMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconNewMac.Click
        frmNewMac.Show()
    End Sub
    Private Sub IconNewDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconNewDisk.Click
        frmNewDisk.Show()
    End Sub
    Private Sub IconOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconOptions.Click
        frmOptions.Show()
    End Sub
    Private Sub IconExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconExit.Click
        frmVirtualMacintosh.Close()
        frmNewMac.Close()
        frmNewDisk.Close()
        frmSplash.Close()
        frmVMSettings.Close()
        frmOptions.Close()
        frmAbout.Close()
        Me.Close()
    End Sub
    Private Sub ShowVMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowVMC.Click
        Me.ShowInTaskbar = True
        Me.Visible = True
        Me.Show()
        Me.Focus()
    End Sub
    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Me.ShowInTaskbar = False
            Me.Visible = False
        End If
    End Sub
    Private Sub VirtualMacTray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VirtualMacTray.MouseDoubleClick
        Me.ShowInTaskbar = True
        Me.Visible = True
        Me.Show()
        Me.Focus()
    End Sub
    Private Sub VMListnew_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VMListnew.SelectedIndexChanged
        If VMListnew.SelectedIndices.Count = 1 Then
            '===Makes it look like you selected an object===
            'When you make a single click, you'll select the element

            'This selects the current item
            VMListnew.SelectedItems(0).BackColor = ColorTranslator.FromOle(&H8000000D)

            'Let's enable those buttons and select the
            'corresponding item in the hidden list
            EnableButtons()
        Else
            'This makes all the items 'un-select', in other words, makes them white
            For x As Integer = 0 To VMListnew.Items.Count - 1
                VMListnew.Items(x).BackColor = Color.White
            Next

            DisableButtons()
        End If
    End Sub
End Class