<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			Static fTerminateCalled As Boolean
			If Not fTerminateCalled Then
                fTerminateCalled = True
            End If
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Start As System.Windows.Forms.Button
	Public WithEvents Remove As System.Windows.Forms.Button
	Public WithEvents Settings As System.Windows.Forms.Button
	Public WithEvents NewMac As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Start = New System.Windows.Forms.Button()
        Me.Remove = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.NewMac = New System.Windows.Forms.Button()
        Me.VirtualMacTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowVMC = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconNewMac = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconNewDisk = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBar0 = New System.Windows.Forms.ToolStripSeparator()
        Me.IconOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBar1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuBar2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IconExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuNewMac = New System.Windows.Forms.MenuItem()
        Me.mnuNewDisk = New System.Windows.Forms.MenuItem()
        Me.mnuFileBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuFileOptions = New System.Windows.Forms.MenuItem()
        Me.mnuFileBar1 = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuAction = New System.Windows.Forms.MenuItem()
        Me.mnuActionStart = New System.Windows.Forms.MenuItem()
        Me.mnuActionBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuActionPause = New System.Windows.Forms.MenuItem()
        Me.mnuActionRestart = New System.Windows.Forms.MenuItem()
        Me.mnuActionBar1 = New System.Windows.Forms.MenuItem()
        Me.mnuActionRemove = New System.Windows.Forms.MenuItem()
        Me.mnuActionBar2 = New System.Windows.Forms.MenuItem()
        Me.mnuActionSettings = New System.Windows.Forms.MenuItem()
        Me.mnuActionProperties = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuHelpContents = New System.Windows.Forms.MenuItem()
        Me.mnuHelpSearchForHelpOn = New System.Windows.Forms.MenuItem()
        Me.mnuHelpBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.VMListnew = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.SystemColors.Control
        Me.Start.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Start, "Start")
        Me.Start.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Start.Name = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Remove
        '
        Me.Remove.BackColor = System.Drawing.SystemColors.Control
        Me.Remove.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Remove, "Remove")
        Me.Remove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Remove.Name = "Remove"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.SystemColors.Control
        Me.Settings.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Settings, "Settings")
        Me.Settings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Settings.Name = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'NewMac
        '
        Me.NewMac.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac, "NewMac")
        Me.NewMac.Name = "NewMac"
        Me.NewMac.UseVisualStyleBackColor = True
        '
        'VirtualMacTray
        '
        Me.VirtualMacTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.VirtualMacTray, "VirtualMacTray")
        Me.VirtualMacTray.ContextMenuStrip = Me.ContextMenuStrip1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowVMC, Me.IconNewMac, Me.IconNewDisk, Me.MenuBar0, Me.IconOptions, Me.MenuBar1, Me.MenuBar2, Me.IconExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'ShowVMC
        '
        resources.ApplyResources(Me.ShowVMC, "ShowVMC")
        Me.ShowVMC.Name = "ShowVMC"
        '
        'IconNewMac
        '
        Me.IconNewMac.Name = "IconNewMac"
        resources.ApplyResources(Me.IconNewMac, "IconNewMac")
        '
        'IconNewDisk
        '
        Me.IconNewDisk.Name = "IconNewDisk"
        resources.ApplyResources(Me.IconNewDisk, "IconNewDisk")
        '
        'MenuBar0
        '
        Me.MenuBar0.Name = "MenuBar0"
        resources.ApplyResources(Me.MenuBar0, "MenuBar0")
        '
        'IconOptions
        '
        Me.IconOptions.Name = "IconOptions"
        resources.ApplyResources(Me.IconOptions, "IconOptions")
        '
        'MenuBar1
        '
        Me.MenuBar1.Name = "MenuBar1"
        resources.ApplyResources(Me.MenuBar1, "MenuBar1")
        '
        'MenuBar2
        '
        Me.MenuBar2.Name = "MenuBar2"
        resources.ApplyResources(Me.MenuBar2, "MenuBar2")
        '
        'IconExit
        '
        Me.IconExit.Name = "IconExit"
        resources.ApplyResources(Me.IconExit, "IconExit")
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAction, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNewMac, Me.mnuNewDisk, Me.mnuFileBar0, Me.mnuFileOptions, Me.mnuFileBar1, Me.mnuFileExit})
        resources.ApplyResources(Me.mnuFile, "mnuFile")
        '
        'mnuNewMac
        '
        Me.mnuNewMac.Index = 0
        resources.ApplyResources(Me.mnuNewMac, "mnuNewMac")
        '
        'mnuNewDisk
        '
        Me.mnuNewDisk.Index = 1
        resources.ApplyResources(Me.mnuNewDisk, "mnuNewDisk")
        '
        'mnuFileBar0
        '
        Me.mnuFileBar0.Index = 2
        resources.ApplyResources(Me.mnuFileBar0, "mnuFileBar0")
        '
        'mnuFileOptions
        '
        Me.mnuFileOptions.Index = 3
        resources.ApplyResources(Me.mnuFileOptions, "mnuFileOptions")
        '
        'mnuFileBar1
        '
        Me.mnuFileBar1.Index = 4
        resources.ApplyResources(Me.mnuFileBar1, "mnuFileBar1")
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 5
        resources.ApplyResources(Me.mnuFileExit, "mnuFileExit")
        '
        'mnuAction
        '
        Me.mnuAction.Index = 1
        Me.mnuAction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuActionStart, Me.mnuActionBar0, Me.mnuActionPause, Me.mnuActionRestart, Me.mnuActionBar1, Me.mnuActionRemove, Me.mnuActionBar2, Me.mnuActionSettings, Me.mnuActionProperties})
        resources.ApplyResources(Me.mnuAction, "mnuAction")
        '
        'mnuActionStart
        '
        resources.ApplyResources(Me.mnuActionStart, "mnuActionStart")
        Me.mnuActionStart.Index = 0
        '
        'mnuActionBar0
        '
        Me.mnuActionBar0.Index = 1
        resources.ApplyResources(Me.mnuActionBar0, "mnuActionBar0")
        '
        'mnuActionPause
        '
        resources.ApplyResources(Me.mnuActionPause, "mnuActionPause")
        Me.mnuActionPause.Index = 2
        '
        'mnuActionRestart
        '
        resources.ApplyResources(Me.mnuActionRestart, "mnuActionRestart")
        Me.mnuActionRestart.Index = 3
        '
        'mnuActionBar1
        '
        Me.mnuActionBar1.Index = 4
        resources.ApplyResources(Me.mnuActionBar1, "mnuActionBar1")
        '
        'mnuActionRemove
        '
        resources.ApplyResources(Me.mnuActionRemove, "mnuActionRemove")
        Me.mnuActionRemove.Index = 5
        '
        'mnuActionBar2
        '
        Me.mnuActionBar2.Index = 6
        resources.ApplyResources(Me.mnuActionBar2, "mnuActionBar2")
        '
        'mnuActionSettings
        '
        resources.ApplyResources(Me.mnuActionSettings, "mnuActionSettings")
        Me.mnuActionSettings.Index = 7
        '
        'mnuActionProperties
        '
        resources.ApplyResources(Me.mnuActionProperties, "mnuActionProperties")
        Me.mnuActionProperties.Index = 8
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpContents, Me.mnuHelpSearchForHelpOn, Me.mnuHelpBar0, Me.mnuHelpAbout})
        resources.ApplyResources(Me.mnuHelp, "mnuHelp")
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Index = 0
        resources.ApplyResources(Me.mnuHelpContents, "mnuHelpContents")
        '
        'mnuHelpSearchForHelpOn
        '
        Me.mnuHelpSearchForHelpOn.Index = 1
        resources.ApplyResources(Me.mnuHelpSearchForHelpOn, "mnuHelpSearchForHelpOn")
        '
        'mnuHelpBar0
        '
        Me.mnuHelpBar0.Index = 2
        resources.ApplyResources(Me.mnuHelpBar0, "mnuHelpBar0")
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 3
        resources.ApplyResources(Me.mnuHelpAbout, "mnuHelpAbout")
        '
        'VMListnew
        '
        resources.ApplyResources(Me.VMListnew, "VMListnew")
        Me.VMListnew.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {CType(resources.GetObject("VMListnew.Groups"), System.Windows.Forms.ListViewGroup)})
        Me.VMListnew.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.VMListnew.HideSelection = False
        Me.VMListnew.LargeImageList = Me.ImageList1
        Me.VMListnew.MultiSelect = False
        Me.VMListnew.Name = "VMListnew"
        Me.VMListnew.ShowGroups = False
        Me.VMListnew.TileSize = New System.Drawing.Size(230, 30)
        Me.VMListnew.UseCompatibleStateImageBehavior = False
        Me.VMListnew.View = System.Windows.Forms.View.Tile
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        resources.ApplyResources(Me.ImageList1, "ImageList1")
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmMain
        '
        Me.AcceptButton = Me.Start
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.VMListnew)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.NewMac)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VirtualMacTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowVMC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBar0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IconNewDisk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBar1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IconOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconNewMac As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBar2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainMenu1 As MainMenu
    Friend WithEvents mnuFile As MenuItem
    Friend WithEvents mnuNewMac As MenuItem
    Friend WithEvents mnuNewDisk As MenuItem
    Friend WithEvents mnuFileBar0 As MenuItem
    Friend WithEvents mnuFileOptions As MenuItem
    Friend WithEvents mnuFileBar1 As MenuItem
    Friend WithEvents mnuFileExit As MenuItem
    Friend WithEvents mnuAction As MenuItem
    Friend WithEvents mnuActionStart As MenuItem
    Friend WithEvents mnuActionBar0 As MenuItem
    Friend WithEvents mnuActionPause As MenuItem
    Friend WithEvents mnuActionRestart As MenuItem
    Friend WithEvents mnuActionBar1 As MenuItem
    Friend WithEvents mnuActionRemove As MenuItem
    Friend WithEvents mnuActionBar2 As MenuItem
    Friend WithEvents mnuActionSettings As MenuItem
    Friend WithEvents mnuActionProperties As MenuItem
    Friend WithEvents mnuHelp As MenuItem
    Friend WithEvents mnuHelpContents As MenuItem
    Friend WithEvents mnuHelpSearchForHelpOn As MenuItem
    Friend WithEvents mnuHelpBar0 As MenuItem
    Friend WithEvents mnuHelpAbout As MenuItem
    Friend WithEvents VMListnew As ListView
    Friend WithEvents ImageList1 As ImageList
#End Region
End Class
