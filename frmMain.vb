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
    Public Shared configversion As Integer = 1.1 ' Used to keep track of the config version.
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        VirtualMacTray.Visible = True
        VMList.BeginUpdate()
        For Each mac As Object In My.Settings.MacList
            Dim name As String = mac.ToString.Trim(Chr(34))
            Dim extradata As String = ""
            If IO.File.Exists(After(name, ",").Trim(Chr(34))) Then
                Dim spaces As String = ""
                extradata = ""
                'temparaily disabled until i find a better solultion
                'For i As Integer = 0 To Before(name, ",").Trim(Chr(34)).Length
                '   spaces = spaces + " "
                '& spaces & "                             Not running"
                'Next
                Dim lines() As String = System.IO.File.ReadAllLines(After(name, ",").Trim(Chr(34)))
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).StartsWith("Version: ") Then
                        'CONFIG VERSION 1.1
                        If "Version: " & 1.1 > lines(i) Then
                            If MsgBox("Your config for """ & Before(name, ",").Trim(Chr(34)) & """ is outdated. Would you like to update? (Note this will mean you will be unable to use it with older VirtualMac versions.)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) Then
                                ' MsgBox(lines(i))
                                If lines(i) = "Version: 1.0" Then 'update to version 1.1
                                    lines(i) = "Version: 1.1"
                                    Dim errorsoccured = 0
                                    Try
                                        System.IO.File.WriteAllLines(After(name, ",").Trim(Chr(34)), lines)
                                        My.Computer.FileSystem.WriteAllText(After(name, ",").Trim(Chr(34)), "hddpath=", True)
                                    Catch ex As Exception
                                        errorsoccured = 1
                                    End Try
                                    If errorsoccured = 0 Then
                                        MsgBox("Successfully updated version.", MsgBoxStyle.Information)
                                    Else
                                        MsgBox("Failed to update config make sure you have permission to access it!", MsgBoxStyle.Critical)
                                    End If
                                End If
                            End If
                        End If
                        If "Version: " & 1.1 < lines(i) Then
                            MsgBox("The config is newer than your VirtualMac version, therefore it cannot be loaded.", MsgBoxStyle.Critical)
                            extradata = " (incompatible)"
                        End If
                    End If
                Next
                VMList.Items.Add(Before(name, ",").Trim(Chr(34)) + frmMain.listnumber.ToString + frmMain.listnumber.ToString, Before(name, ",").Trim(Chr(34)) & extradata, frmMain.listnumber)
            Else
                MsgBox("Cant find the '" & After(name, ",").Trim(Chr(34)) & "' VM on the computer. If you are sure it exists, check that you have permsissions to access it.", MsgBoxStyle.Exclamation)
                VMList.Items.Add(Before(name, ",").Trim(Chr(34)) + frmMain.listnumber.ToString + frmMain.listnumber.ToString + Environment.NewLine + "Not running", Before(name, ",").Trim(Chr(34)) & " (inaccessible)", frmMain.listnumber)
            End If
            VMList.Items(frmMain.listnumber).SubItems.Add(After(name, ",").Trim(Chr(34)))
            Dim bmp As New Bitmap(58, 82)
            Dim flagGraphics As Graphics = Graphics.FromImage(bmp)
            flagGraphics.FillRectangle(Brushes.Gray, 0, 10, 58, 56)
            ImageList1.Images.Add(bmp)
            listnumber += 1
        Next
        VMList.EndUpdate()
    End Sub
    Function Before(value As String, replace As String) As String
        ' Get index of argument and return substring up to that point.
        Dim posA As Integer = value.IndexOf(replace)
        If posA = -1 Then
            Return ""
        End If
        Return value.Substring(0, posA)
    End Function
    Function After(value As String, replace As String) As String
        ' Get index of argument and return substring after its position.
        Dim posA As Integer = value.LastIndexOf(replace)
        If posA = -1 Then
            Return ""
        End If
        Dim adjustedPosA As Integer = posA + replace.Length
        If adjustedPosA >= value.Length Then
            Return ""
        End If
        Return value.Substring(adjustedPosA)
    End Function
    Public Sub Start68kEmulation()
        MsgBox("Virtual Mac � " & "Beta. Virtualization isn't supported (again). Only fake OS X screen plus example stuff avaible")
        'Shell (App.Path & "\68k.exe"), vbNormalFocus
        frmVirtualMacintosh.Text = VMList.SelectedItems(0).Text.Replace("Not running", "").TrimEnd(" ") & " - Virtual Mac"
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
        If VMList.SelectedIndices.Count = 1 Then
            'Asks you if you really want to delete the machine
            Dim Answer As Short = MsgBox("You have choosen to remove '" & VMList.SelectedItems(0).Text.Replace("Not running", "").TrimEnd(" ") & "' from the Virtual Mac Console. Removing items from this list will not delete the .mcc or .dsk files from your physical computer. Do you want to remove this Virtual Mac from the Virtual Mac Console?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Virtual Mac")
            'If you don't want that old Mac Plus, this
            'is where it's deleted and recycled (Maybe)
            If Answer = 6 Then
                My.Settings.MacList.Remove("""" & VMList.SelectedItems(0).Text.Replace("Not running", "").TrimEnd(" ").Replace(" (inaccessible)", "").Replace(" (incompatible)", "") & """" & "," & """" & VMList.SelectedItems(0).SubItems(1).Text & """")
                My.Settings.Save()
                VMList.Items.Remove(VMList.SelectedItems(0))
                listnumber -= 1
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
        OpenSettingsFor(VMList.SelectedItems(0).Text.Replace("Not running", "").TrimEnd(" "))
    End Sub
    Public Sub OpenSettingsFor(ByRef MacName As String)
        If MacName.Contains("incompatible") Then
            MsgBox("Cant edit settings for incompatible machine.", MsgBoxStyle.Critical)
        Else
            MacToEdit = MacName
            MacToEditPath = VMList.SelectedItems(0).SubItems(1).Text
            frmVMSettings.Text = "Settings for " & MacName
            frmVMSettings.Show()
        End If
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
    Private Sub VM_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMList.DoubleClick
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
    Private Sub VMListnew_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VMList.SelectedIndexChanged
        If VMList.SelectedIndices.Count = 1 Then
            '===Makes it look like you selected an object===
            'When you make a single click, you'll select the element

            'This selects the current item
            VMList.SelectedItems(0).BackColor = ColorTranslator.FromOle(&H8000000D)

            'Let's enable those buttons and select the
            'corresponding item in the hidden list
            EnableButtons()
        Else
            'This makes all the items 'un-select', in other words, makes them white
            For x As Integer = 0 To VMList.Items.Count - 1
                VMList.Items(x).BackColor = Color.White
            Next

            DisableButtons()
        End If
    End Sub
End Class