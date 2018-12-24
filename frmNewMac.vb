Option Strict Off
Option Explicit On
Imports System.IO

Friend Class frmNewMac
    Inherits System.Windows.Forms.Form
    Dim VMemory As Integer
    Dim VDisk As Integer
    Dim VArch As String
    Dim MacName As String
    'Honestly, the most complicated assistant (Here is where my hard work is :D)
    Private Sub BrowseA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BrowseA.Click
        'A for Add, that means 'Add an existing machine'.
        'Opens a 'Open dialog' to search VirtualMac config file
        BrowseOpen.Filter = "Virtual Mac Configuration File (*.mcc)|*.mcc|All files (*.*)|*.*"
        If BrowseOpen.ShowDialog() = DialogResult.OK Then
            FileNameA.Text = BrowseOpen.FileName
        End If
    End Sub
    Private Sub BrowseC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BrowseC.Click
        'C for Create, that means 'Create a new machine'
        'Opens the save dialog that let's you choose where
        'will the config file be saved
        BrowseSave.Filter = "Virtual Mac Configuration File (*.mcc)|*.mcc|All files (*.*)|*.*"
        If BrowseSave.ShowDialog() = DialogResult.OK Then
            BrowseOpen.FileName = BrowseSave.FileName
            FileNameC.Text = BrowseOpen.FileName
        End If
    End Sub
    Private Sub cmdBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBack.Click
        'This is the first part of the hard code, this makes
        'that the right Frame will be shown, this is in base
        'to which is the currently visible frame. This makes
        'visible the earlier Frame. The instruction
        '<GoTo EndNext> makes that you won't automatically jump
        'until the Start screen
        If NewMac2.Visible = True Then 'Go back to Start screen
            cmdBack.Enabled = False
            NewMac2.Visible = False
            NewMacWizard.Visible = False
            NewMac1.Visible = True
            GoTo EndNext
        End If
        'Both fo these go back to Page 2. But every one is different
        'since one creates a new Mac, the other adds a new one
        If NewMac3.Visible = True Then 'Back from the page 'Create a new one'
            NewMac3.Visible = False
            Action.Text = "Options"
            ActionDescription.Text = "You can create a new Virtual Mac or add an existing one to the Virtual Mac Console"
            NewMac2.Visible = True
            GoTo EndNext
        End If
        If NewMacFromExist.Visible = True Then 'Back from page 'Add a new one'
            NewMacFromExist.Visible = False
            Action.Text = "Options"
            ActionDescription.Text = "You can create a new Virtual Mac or add an existing one to the Virtual Mac Console"
            NewMac2.Visible = True
            GoTo EndNext
        End If
        If NewMac4.Visible = True Then 'Back from the page 'Name and Location'
            NewMac4.Visible = False
            Action.Text = "Virtual Macintosh Name and Location"
            ActionDescription.Text = "The name you specify will appear in the list of Virtual Macintoshes in the Virtual Mac Console"
            NewMac3.Visible = True
            GoTo EndNext
        End If
        If NewMac5.Visible = True Then 'Back from the page 'Select OS'
            NewMac5.Visible = False
            Action.Text = "Operating System"
            ActionDescription.Text = "Select the operating system you plan to install on this machine"
            NewMac4.Visible = True
            GoTo EndNext
        End If
        If NewMac6.Visible = True Then 'Back from the page 'RAM for this Mac'
            NewMac6.Visible = False
            Action.Text = "Memory"
            ActionDescription.Text = "You can configure the RAM on this Mac"
            NewMac5.Visible = True
            GoTo EndNext
        End If
        'Back from the page 'Finishing the New Mac Wizard'. Note: This changes as which option was choosen
        If NewMacEnd.Visible = True Then
            'If choosen the option 'Create a new Mac', this will return
            'to the 'RAM' page
            DescriptionEnd.Text = DescriptionEnd.Text.Replace(MacName, "")
            DescriptionEnd.Text = DescriptionEnd.Text.TrimEnd(" ")
            If CreateNew.Checked = True Then
                NewMacEnd.Visible = False
                cmdNext.Text = "Next >"
                NewMacWizard.Visible = True
                NewMac6.Visible = True
                GoTo EndNext
            End If
            'If choosen the option 'Use default settings to create a Virtual Mac'
            'this will return to the page 2
            If UseDefaults.Checked = True Then
                NewMacEnd.Visible = False
                AdviceNoHD.Visible = False
                cmdNext.Text = "Next >"
                NewMacWizard.Visible = True
                NewMac3.Visible = True
                GoTo EndNext
            End If
        End If
EndNext:
    End Sub
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        'If you change of opinion and you think you don't need
        'a New Mac, this will Unload the current Window
        Me.Close()
    End Sub
    Dim selectedpath As Integer = 0
    Dim savepath As String = ""
    Private Sub cmdNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.Click
        'Here is the REALLY HARD work. This code will make you advance
        'throught the assistant. This will check which page (Frame) is
        'shown and in base to your choices, it will show diferrent things

        'Let's install a error handler!
        On Error GoTo ErrorHandler

        'Declarations
        Dim RAM As Integer

        'Assigning values to the declarations
        RAM = CInt(Str(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024))

        If NewMac1.Visible = True Then 'Shows the assistant
            NewMacWizard.Visible = True
            NewMac1.Visible = False
            NewMac2.Visible = True
            cmdBack.Enabled = True
            CreateNew.Focus()
            GoTo EndNext
        End If

        If NewMac2.Visible = True Then 'This will differ as the option you choose
            If AddExist.Checked = True Then 'If you want to add from EXISTING file
                NewMac2.Visible = False
                Action.Text = "Existing Virtual Macintosh Name and Location"
                ActionDescription.Text = "You can add a .mcc file from this computer or another computer to the Virtual Mac Console"
                NewMacFromExist.Visible = True
                FileNameA.Focus()
                GoTo EndNext
            End If

            NewMac2.Visible = False 'If you want to create a NEW Mac
            Action.Text = "Virtual Macintosh Name and Location"
            ActionDescription.Text = "The name you specify will appear in the list of Virtual Macintoshes in the Virtual Mac Console"
            NewMac3.Visible = True
            CheckIfNameExist()
            FileNameC.Focus()
            GoTo EndNext
        End If

        If NewMac3.Visible = True Then 'This will differ too with the choice that you've made before
            MacName = FileNameC.Text
            MacName = Replace(FileNameC.Text, ".mcc", "")
            If Not Path.GetFileName(MacName) = MacName Then MacName = Path.GetFileName(MacName) : selectedpath = 1
            If Not FileNameC.Text.EndsWith(".mcc") Then FileNameC.Text = FileNameC.Text + ".mcc"
            If CreateNew.Checked = True Then 'If you choosed to Create a new thing and follow instruction step by step
                'HardwareEngineer(True)
                Action.Text = "Operating System"
                ActionDescription.Text = "Select the operating system you plan to install on this machine"
                NewMac3.Visible = False
                cmdNext.Select()
                cmdNext.Focus()
                NewMac4.Visible = True
                GoTo EndNext
            End If

            If UseDefaults.Checked = True Then 'If you don't wanna waste time and just want a new machine NOW
                'HardwareEngineer(True)
                'AutoConfigure 'This will be uncommented when implemmented
                DescriptionEnd.Text = DescriptionEnd.Text + " " + MacName
                NewMacWizard.Visible = False
                cmdNext.Text = "Finish"
                cmdNext.Select()
                AdviceNoHD.Visible = True
                NewMacEnd.Visible = True
                GoTo EndNext
            End If
        End If

        'Move away from the OS page and choose the RAM for you new Mac!
        '(Only avaible when creating new one, not when you choosed use defaults)
        If NewMac4.Visible = True Then
            NewMac4.Visible = False
            Action.Text = "Memory"
            ActionDescription.Text = "You can configure the RAM on this Mac"
            RAMAdjust.Maximum = FormatNumber(CDbl(My.Computer.Info.TotalPhysicalMemory / 1048576), 2)
            RAMAdjust.Value = VMemory
            RAMAdjust.TickFrequency = 2048 / 20
            RAMMegabyteNumber.Text = CStr(VMemory)
            RecRAM.Text = "Recommended RAM: [" & VMemory & " MB" & "]"
            NewMac5.Visible = True
            Recommend.Focus()
            GoTo EndNext
        End If

        If NewMac5.Visible = True Then 'Configure you new hard disk!
            VMemory = RAMAdjust.Value
            NewMac5.Visible = False
            Action.Text = "Virtual Hard Disk Location"
            ActionDescription.Text = "This wizard creates a fixed size virtual disk with the specified size"
            DiskSizeMB.Text = VDisk
            If selectedpath = 0 Then
                If My.Settings.DefaultMacFolder = "UserDocumentPath" Then
                    NewMac7VDName.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs\" & MacName & "\" & MacName & ".dsk"
                    savepath = NewMac7VDName.Text
                    savepath = Replace(savepath, ".dsk", ".mcc")
                    If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs\" & MacName) Then Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs\" & MacName)
                Else
                    NewMac7VDName.Text = My.Settings.DefaultMacFolder & "\" & MacName & ".dsk"
                    savepath = NewMac7VDName.Text
                    savepath = Replace(savepath, ".dsk", ".mcc")
                End If
            Else NewMac7VDName.Text = FileNameC.Text : savepath = FileNameC.Text
            End If
            If Not String.IsNullOrEmpty(BrowseOpen.FileName) Then
                NewMac7VDName.Text = Replace(BrowseOpen.FileName, ".mcc", ".dsk")
            End If
            NewMac6.Visible = True
            GoTo EndNext
        End If

        If NewMac6.Visible = True Then 'You'll see the Finish page
            VDisk = DiskSizeMB.Text
            DescriptionEnd.Text = DescriptionEnd.Text + " " + MacName
            NewMac6.Visible = False
            OpenSettingsAfterFinish.Visible = False
            NewMacWizard.Visible = False
            cmdNext.Text = "Finish"
            NewMacEnd.Visible = True
            GoTo EndNext
        End If

        If NewMacEnd.Visible = True Then
            If OpenSettingsAfterFinish.Visible = True Then
                If selectedpath = 0 Then
                    If My.Settings.DefaultMacFolder = "UserDocumentPath" Then
                        savepath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs\" & MacName & "\" & FileNameC.Text
                        If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs\" & MacName) Then Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs\" & MacName)
                    End If
                Else
                    savepath = FileNameC.Text & MacName
                End If
                AddVM(MacName)
                If OpenSettingsAfterFinish.CheckState = 1 Then
                    frmMain.MacToEdit = MacName
                    frmMain.MacToEditPath = savepath
                    frmVMSettings.ShowDialog()
                    Me.Close()
                    Exit Sub
                End If
            End If
            AddVM(MacName)
        End If

        GoTo EndNext

ErrorHandler:
        If Not Err.Number = 0 Then
            MsgBox(Err.Number & ". " & Err.Description, MsgBoxStyle.Critical)
        End If

EndNext:
    End Sub
    Sub HardwareEngineer(ByVal AutoDetect As Boolean)
        Dim FoundPosition As Long
        Dim OSType As String = "Other"

        If AutoDetect = False Then GoTo Catalog

        FoundPosition = OSList.SelectedIndex
        If FoundPosition = 0 Then
            VMemory = 8
            VDisk = 100
            VArch = "m680"
            GoTo Catalog
        End If
        If FoundPosition = 1 Then
            VMemory = 16
            VDisk = 200
            VArch = "m684"
            GoTo Catalog
        End If
        If FoundPosition = 3 Then
            VArch = "Mac75"
            GoTo Catalog
        End If
        If FoundPosition = 4 Then
            VArch = "Mac8"
            GoTo Catalog
        End If
        If FoundPosition = 5 Then
            VArch = "Mac9"
            GoTo Catalog
        End If
        If FoundPosition = 6 Then
            VMemory = 32
            VDisk = 500
            VArch = "PPC"
            GoTo Catalog
        End If
        If FoundPosition = 7 Then
            VMemory = 128
            VDisk = 256
            VArch = "Other"
            GoTo Catalog
        End If
Catalog:
        MemoryMB.Text = VMemory
        DiskMB.Text = VDisk
        CPUArch.Text = VArch
    End Sub
    Public Sub Labeler(ByVal Memory As Long, ByVal Disk As Long, ByVal Arch As String)
        MemoryMB.Text = Memory & " MB"
        DiskMB.Text = Disk & " MB"
        CPUArch.Text = Arch
    End Sub
    Private Sub DiskSizeMB_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DiskSizeMB.TextChanged
        'This is the tiny code that makes the slider and the textbox to synchronize
        On Error Resume Next

        If DiskSizeMB.Text = "" Then
            cmdNext.Enabled = False
            WarningLowerSize.Visible = True
            DiskSizeMB.Focus()
        Else
            cmdNext.Enabled = True
            WarningLowerSize.Visible = False
            DiskSizeMB.Focus()
        End If

        If CDbl(DiskSizeMB.Text) > 130557 Then
            cmdNext.Enabled = False
            WarningLowerSize.Visible = True
            DiskSizeMB.Focus()
        Else
            cmdNext.Enabled = True
            WarningLowerSize.Visible = False
            DiskSizeMB.Focus()
        End If
    End Sub
    Private Sub DiskSizeMB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DiskSizeMB.Click
        DiskSizeMB.Focus()
    End Sub
    Private Sub DiskSizeMB_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles DiskSizeMB.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        'Goes to a function that makes that you can only press numbers,
        'no letters, no dots, no special characters
        KeyAscii = VerifyKey(KeyAscii)

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub NewVDBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles NewVDBrowse.Click
        'Opens the dialog to let you choice the location of the new hard disk
        BrowseOpen.Filter = "Virtual Mac Disk (*.dsk)|*.dsk|All files (*.*)|*.*"
        BrowseSave.Filter = "Virtual Mac Disk (*.dsk)|*.dsk|All files (*.*)|*.*"
        BrowseSave.ShowDialog()
        BrowseOpen.FileName = BrowseSave.FileName
        NewMac7VDName.Text = BrowseOpen.FileName
    End Sub
    Private Sub FileNameC_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FileNameC.Enter
        'Selects all the text when you click in the machine FileName TextBox
        FileNameC.SelectionStart = 0
        FileNameC.SelectionLength = Len(FileNameC.Text)
    End Sub
    Function VerifyKey(ByRef PressedKey As Object) As Object
        'Lets only to send the keys assigned to numbers in the keyboard

        'Declarations
        Dim AllowedKeys As String

        'Here are listed the 'allowed' keys
        AllowedKeys = "1234567890" & Chr(System.Windows.Forms.Keys.Back)

        'Here is made the check with a 'If' instruction
        If InStr(1, AllowedKeys, Chr(PressedKey)) Then

            VerifyKey = PressedKey 'If the pressed key is one of the allowed
        Else
            VerifyKey = 0
        End If
    End Function
    Public Sub AddVM(s As String)
        'This procedure will, make place where at the end
        'of the assistant the machine is made and the config file
        'is written to disk. But for now it's complete
        Try
            IO.File.WriteAllText(savepath, ";VirtualMac Configuration File" & Environment.NewLine & ";DO NOT EDIT THIS FILE!" & Environment.NewLine & "Version: 1.1" & Environment.NewLine & "name=" & MacName & Environment.NewLine & "mem=" & VMemory & Environment.NewLine & "cpu=" & CPUArch.Text & Environment.NewLine & "desc=" & "Description." & Environment.NewLine & "hddpath=" & NewMac7VDName.Text)
            If UseDefaults.Checked = False Then
                IO.File.WriteAllText(NewMac7VDName.Text, ";PLACEHOLDER RAW DISK FILE" & Environment.NewLine & "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")
            End If
        Catch ex As Exception
            MsgBox("Cannot save the .mcc file. Make sure you have permissons to save to the folder you selected and that it exists.", MsgBoxStyle.Critical)
            Exit Sub
        End Try
        My.Settings.MacList.Add("""" & MacName & """" & "," & """" & savepath & """")
        My.Settings.Save()
        frmMain.VMList.Items.Add(MacName + frmMain.listnumber.ToString, MacName, frmMain.listnumber)
        frmMain.VMList.Items(frmMain.listnumber).SubItems.Add(savepath)
        Dim bmp As New Bitmap(58, 82)
        Dim flagGraphics As Graphics = Graphics.FromImage(bmp)
        flagGraphics.FillRectangle(Brushes.Gray, 0, 10, 58, 56)
        frmMain.ImageList1.Images.Add(bmp)
        frmMain.listnumber += 1
        Me.Close()
    End Sub
    Public Sub CheckIfNameExist()
        '===Check that we haven't a machine with the same name===
        'Declarations
        Dim i As Integer
        Dim x As Integer

        'Procedure
        For x = 0 To frmMain.VMList.Items.Count - 1
            i = InStr(frmMain.VMList.Items(x).Text & ".mcc", FileNameC.Text)
            If i <> 0 Then
                FileNameC.Text = "New Mac (" & x + 1 & ")" & ".mcc"
            End If
            If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs\" & FileNameC.Text.Replace(".mcc", "")) Then
                FileNameC.Text = "New Mac (" & x + 1 & ")" & ".mcc"
            End If
        Next
        MacName = Replace(FileNameC.Text, ".mcc", "")
    End Sub
    Private Sub RAMAdjust_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles RAMAdjust.Scroll
        RAMMegabyteNumber.Text = CStr(RAMAdjust.Value)
    End Sub
    Private Sub RAMMegabyteNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RAMMegabyteNumber.GotFocus
        RAMMegabyteNumber.SelectionStart = 0
        RAMMegabyteNumber.SelectionLength = Len(RAMMegabyteNumber.Text)
    End Sub
    Private Sub RAMMegabyteNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RAMMegabyteNumber.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        KeyAscii = VerifyKey(KeyAscii)

        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub RAMMegabyteNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RAMMegabyteNumber.TextChanged
        'Makes that the value of the TextBox will be represented in the slider
        On Error GoTo ErrorHandler
        RAMAdjust.Value = CInt(RAMMegabyteNumber.Text)
ErrorHandler:
        If Not Err.Number = 0 Then
            If Err.Number = 13 Then
                RAMAdjust.Value = 0
            End If

            If Err.Number <> 13 Then
                MsgBox(Err.Description, MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub Adjust_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Adjust.CheckedChanged
        If sender.Checked Then
            'This makes visible the Frame that shows the RAM slider to adjust the RAM
            If Adjust.Checked = True Then
                RAMAdjuster.Visible = True
                RAMAdjust.TabStop = True
                RAMMegabyteNumber.TabStop = True
            End If
        End If
    End Sub
    Private Sub Recommend_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Recommend.CheckedChanged
        If sender.Checked Then
            'Makes Invisible the Frame with the RAM Slider so you will use the default RAM for the machine
            If Recommend.Checked = True Then
                RAMAdjuster.Visible = False
                RAMAdjust.TabStop = False
                RAMMegabyteNumber.TabStop = False
            End If
        End If
    End Sub
    Private Sub OSList_SelectedValueChanged(sender As Object, e As EventArgs) Handles OSList.SelectedValueChanged
        HardwareEngineer(True)
    End Sub
    Private Sub frmNewMac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OSList.Text = "Other"
    End Sub
End Class