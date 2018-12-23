<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewMac
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
    Public WithEvents FileNameC As System.Windows.Forms.TextBox
    Public WithEvents BrowseC As System.Windows.Forms.Button
	Public WithEvents FileNameTitleC As System.Windows.Forms.Label
	Public WithEvents HelpC As System.Windows.Forms.Label
	Public WithEvents NewMac3 As System.Windows.Forms.Panel
    Public WithEvents WizardPictureSmall As System.Windows.Forms.PictureBox
    Public WithEvents ActionDescription As System.Windows.Forms.Label
    Public WithEvents Action As System.Windows.Forms.Label
    Public WithEvents DescriptionBox As System.Windows.Forms.GroupBox
    Public WithEvents NewMacWizard As System.Windows.Forms.Panel
    Public WithEvents OpenSettingsAfterFinish As System.Windows.Forms.CheckBox
    Public WithEvents WizardEnd As System.Windows.Forms.PictureBox
    Public WithEvents AdviceClickFinish As System.Windows.Forms.Label
    Public WithEvents AdviceNoHD As System.Windows.Forms.Label
    Public WithEvents VMName As System.Windows.Forms.Label
    Public WithEvents DescriptionEnd As System.Windows.Forms.Label
    Public WithEvents TitleEnd As System.Windows.Forms.Label
    Public WithEvents NewMacEnd As System.Windows.Forms.Panel
    Public BrowseOpen As System.Windows.Forms.OpenFileDialog
    Public BrowseSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdNext As System.Windows.Forms.Button
    Public WithEvents cmdBack As System.Windows.Forms.Button
    Public WithEvents ButtonBox As System.Windows.Forms.GroupBox
    Public WithEvents WizardStart As System.Windows.Forms.PictureBox
    Public WithEvents TitleStart As System.Windows.Forms.Label
    Public WithEvents DescriptionStart As System.Windows.Forms.Label
    Public WithEvents NewMac1 As System.Windows.Forms.Panel
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewMac))
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.NewMacWizard = New System.Windows.Forms.Panel()
        Me.DescriptionBox = New System.Windows.Forms.GroupBox()
        Me.WizardPictureSmall = New System.Windows.Forms.PictureBox()
        Me.ActionDescription = New System.Windows.Forms.Label()
        Me.Action = New System.Windows.Forms.Label()
        Me.NewMac3 = New System.Windows.Forms.Panel()
        Me.FileNameC = New System.Windows.Forms.TextBox()
        Me.BrowseC = New System.Windows.Forms.Button()
        Me.FileNameTitleC = New System.Windows.Forms.Label()
        Me.HelpC = New System.Windows.Forms.Label()
        Me.NewMacEnd = New System.Windows.Forms.Panel()
        Me.OpenSettingsAfterFinish = New System.Windows.Forms.CheckBox()
        Me.WizardEnd = New System.Windows.Forms.PictureBox()
        Me.AdviceClickFinish = New System.Windows.Forms.Label()
        Me.AdviceNoHD = New System.Windows.Forms.Label()
        Me.VMName = New System.Windows.Forms.Label()
        Me.DescriptionEnd = New System.Windows.Forms.Label()
        Me.TitleEnd = New System.Windows.Forms.Label()
        Me.BrowseOpen = New System.Windows.Forms.OpenFileDialog()
        Me.BrowseSave = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonBox = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.NewMac1 = New System.Windows.Forms.Panel()
        Me.WizardStart = New System.Windows.Forms.PictureBox()
        Me.TitleStart = New System.Windows.Forms.Label()
        Me.DescriptionStart = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpA = New System.Windows.Forms.Label()
        Me.FileNameTitleA = New System.Windows.Forms.Label()
        Me.BrowseA = New System.Windows.Forms.Button()
        Me.FileNameA = New System.Windows.Forms.TextBox()
        Me.NewMacFromExist = New System.Windows.Forms.Panel()
        Me.NewMac60ButtonFix = New System.Windows.Forms.Panel()
        Me.NewMac60About = New System.Windows.Forms.Label()
        Me.NewMac60Use = New System.Windows.Forms.Label()
        Me.NewMac60Help = New System.Windows.Forms.Label()
        Me.AddExistingVD = New System.Windows.Forms.RadioButton()
        Me.CreateNewVD = New System.Windows.Forms.RadioButton()
        Me.NewMac60 = New System.Windows.Forms.Panel()
        Me.NewVDTitleHelp = New System.Windows.Forms.Label()
        Me.NewVDHelp = New System.Windows.Forms.Label()
        Me.InfoVDSize = New System.Windows.Forms.Label()
        Me.MaxVDSize = New System.Windows.Forms.Label()
        Me.VDMBInfo = New System.Windows.Forms.Label()
        Me.VDInfoMaxMBSize = New System.Windows.Forms.Label()
        Me.VDInfoAboutVD = New System.Windows.Forms.Label()
        Me.WarningLowerSize = New System.Windows.Forms.Label()
        Me.NewMac7VDName = New System.Windows.Forms.TextBox()
        Me.NewVDBrowse = New System.Windows.Forms.Button()
        Me.DiskSizeMB = New System.Windows.Forms.TextBox()
        Me.NewMac6 = New System.Windows.Forms.Panel()
        Me.Help4 = New System.Windows.Forms.Label()
        Me.OSListTitle = New System.Windows.Forms.Label()
        Me.DefaultHardware = New System.Windows.Forms.Label()
        Me.Memory = New System.Windows.Forms.Label()
        Me.Disk = New System.Windows.Forms.Label()
        Me.CPUType = New System.Windows.Forms.Label()
        Me.MemoryMB = New System.Windows.Forms.Label()
        Me.DiskMB = New System.Windows.Forms.Label()
        Me.CPUArch = New System.Windows.Forms.Label()
        Me.OSList = New System.Windows.Forms.ComboBox()
        Me.NewMac4 = New System.Windows.Forms.Panel()
        Me.RAMHelp = New System.Windows.Forms.Label()
        Me.RAMHelpTitle = New System.Windows.Forms.Label()
        Me.RecRAM = New System.Windows.Forms.Label()
        Me.Adjust = New System.Windows.Forms.RadioButton()
        Me.Recommend = New System.Windows.Forms.RadioButton()
        Me.RAMAdjuster = New System.Windows.Forms.Panel()
        Me.RAMDescription = New System.Windows.Forms.Label()
        Me.MegaByte = New System.Windows.Forms.Label()
        Me.RAMMegabyteNumber = New System.Windows.Forms.TextBox()
        Me.RAMAdjust = New System.Windows.Forms.TrackBar()
        Me.NewMac5 = New System.Windows.Forms.Panel()
        Me.AddExistDescription2 = New System.Windows.Forms.Label()
        Me.UseDefaultsDescription2 = New System.Windows.Forms.Label()
        Me.NewDescription2 = New System.Windows.Forms.Label()
        Me.HelpSelect = New System.Windows.Forms.Label()
        Me.AddExist = New System.Windows.Forms.RadioButton()
        Me.UseDefaults = New System.Windows.Forms.RadioButton()
        Me.CreateNew = New System.Windows.Forms.RadioButton()
        Me.NewMac2 = New System.Windows.Forms.Panel()
        Me.NewMacWizard.SuspendLayout()
        Me.DescriptionBox.SuspendLayout()
        CType(Me.WizardPictureSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewMac3.SuspendLayout()
        Me.NewMacEnd.SuspendLayout()
        CType(Me.WizardEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonBox.SuspendLayout()
        Me.NewMac1.SuspendLayout()
        CType(Me.WizardStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewMacFromExist.SuspendLayout()
        Me.NewMac60ButtonFix.SuspendLayout()
        Me.NewMac60.SuspendLayout()
        Me.NewMac6.SuspendLayout()
        Me.NewMac4.SuspendLayout()
        Me.RAMAdjuster.SuspendLayout()
        CType(Me.RAMAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewMac5.SuspendLayout()
        Me.NewMac2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.cmdBack, "cmdBack")
        Me.cmdBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'NewMacWizard
        '
        Me.NewMacWizard.BackColor = System.Drawing.SystemColors.Control
        Me.NewMacWizard.Controls.Add(Me.NewMac2)
        Me.NewMacWizard.Controls.Add(Me.NewMac5)
        Me.NewMacWizard.Controls.Add(Me.DescriptionBox)
        Me.NewMacWizard.Controls.Add(Me.NewMac4)
        Me.NewMacWizard.Controls.Add(Me.NewMac6)
        Me.NewMacWizard.Controls.Add(Me.NewMac60)
        Me.NewMacWizard.Controls.Add(Me.NewMacFromExist)
        Me.NewMacWizard.Controls.Add(Me.NewMac3)
        Me.NewMacWizard.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMacWizard.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMacWizard, "NewMacWizard")
        Me.NewMacWizard.Name = "NewMacWizard"
        '
        'DescriptionBox
        '
        Me.DescriptionBox.BackColor = System.Drawing.Color.White
        Me.DescriptionBox.Controls.Add(Me.WizardPictureSmall)
        Me.DescriptionBox.Controls.Add(Me.ActionDescription)
        Me.DescriptionBox.Controls.Add(Me.Action)
        Me.DescriptionBox.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DescriptionBox, "DescriptionBox")
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.TabStop = False
        '
        'WizardPictureSmall
        '
        Me.WizardPictureSmall.BackColor = System.Drawing.SystemColors.Control
        Me.WizardPictureSmall.Cursor = System.Windows.Forms.Cursors.Default
        Me.WizardPictureSmall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WizardPictureSmall.Image = Global.VirtualMac.My.Resources.Resources.WizardPicture
        resources.ApplyResources(Me.WizardPictureSmall, "WizardPictureSmall")
        Me.WizardPictureSmall.Name = "WizardPictureSmall"
        Me.WizardPictureSmall.TabStop = False
        '
        'ActionDescription
        '
        Me.ActionDescription.BackColor = System.Drawing.Color.Transparent
        Me.ActionDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.ActionDescription.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ActionDescription, "ActionDescription")
        Me.ActionDescription.Name = "ActionDescription"
        '
        'Action
        '
        Me.Action.BackColor = System.Drawing.Color.Transparent
        Me.Action.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Action, "Action")
        Me.Action.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Action.Name = "Action"
        '
        'NewMac3
        '
        Me.NewMac3.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac3.Controls.Add(Me.FileNameC)
        Me.NewMac3.Controls.Add(Me.BrowseC)
        Me.NewMac3.Controls.Add(Me.FileNameTitleC)
        Me.NewMac3.Controls.Add(Me.HelpC)
        Me.NewMac3.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac3.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac3, "NewMac3")
        Me.NewMac3.Name = "NewMac3"
        '
        'FileNameC
        '
        Me.FileNameC.AcceptsReturn = True
        Me.FileNameC.BackColor = System.Drawing.SystemColors.Window
        Me.FileNameC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FileNameC.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.FileNameC, "FileNameC")
        Me.FileNameC.Name = "FileNameC"
        '
        'BrowseC
        '
        Me.BrowseC.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseC.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseC.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseC, "BrowseC")
        Me.BrowseC.Name = "BrowseC"
        Me.BrowseC.UseVisualStyleBackColor = True
        '
        'FileNameTitleC
        '
        Me.FileNameTitleC.BackColor = System.Drawing.SystemColors.Control
        Me.FileNameTitleC.Cursor = System.Windows.Forms.Cursors.Default
        Me.FileNameTitleC.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.FileNameTitleC, "FileNameTitleC")
        Me.FileNameTitleC.Name = "FileNameTitleC"
        '
        'HelpC
        '
        Me.HelpC.BackColor = System.Drawing.SystemColors.Control
        Me.HelpC.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpC.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.HelpC, "HelpC")
        Me.HelpC.Name = "HelpC"
        '
        'NewMacEnd
        '
        Me.NewMacEnd.BackColor = System.Drawing.Color.White
        Me.NewMacEnd.Controls.Add(Me.OpenSettingsAfterFinish)
        Me.NewMacEnd.Controls.Add(Me.WizardEnd)
        Me.NewMacEnd.Controls.Add(Me.AdviceClickFinish)
        Me.NewMacEnd.Controls.Add(Me.AdviceNoHD)
        Me.NewMacEnd.Controls.Add(Me.VMName)
        Me.NewMacEnd.Controls.Add(Me.DescriptionEnd)
        Me.NewMacEnd.Controls.Add(Me.TitleEnd)
        Me.NewMacEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMacEnd.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMacEnd, "NewMacEnd")
        Me.NewMacEnd.Name = "NewMacEnd"
        '
        'OpenSettingsAfterFinish
        '
        Me.OpenSettingsAfterFinish.BackColor = System.Drawing.Color.White
        Me.OpenSettingsAfterFinish.Checked = True
        Me.OpenSettingsAfterFinish.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OpenSettingsAfterFinish.Cursor = System.Windows.Forms.Cursors.Default
        Me.OpenSettingsAfterFinish.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OpenSettingsAfterFinish, "OpenSettingsAfterFinish")
        Me.OpenSettingsAfterFinish.Name = "OpenSettingsAfterFinish"
        Me.OpenSettingsAfterFinish.UseVisualStyleBackColor = False
        '
        'WizardEnd
        '
        Me.WizardEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WizardEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.WizardEnd.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.WizardEnd, "WizardEnd")
        Me.WizardEnd.Name = "WizardEnd"
        Me.WizardEnd.TabStop = False
        '
        'AdviceClickFinish
        '
        Me.AdviceClickFinish.BackColor = System.Drawing.Color.Transparent
        Me.AdviceClickFinish.Cursor = System.Windows.Forms.Cursors.Default
        Me.AdviceClickFinish.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AdviceClickFinish, "AdviceClickFinish")
        Me.AdviceClickFinish.Name = "AdviceClickFinish"
        '
        'AdviceNoHD
        '
        Me.AdviceNoHD.BackColor = System.Drawing.Color.Transparent
        Me.AdviceNoHD.Cursor = System.Windows.Forms.Cursors.Default
        Me.AdviceNoHD.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AdviceNoHD, "AdviceNoHD")
        Me.AdviceNoHD.Name = "AdviceNoHD"
        '
        'VMName
        '
        resources.ApplyResources(Me.VMName, "VMName")
        Me.VMName.BackColor = System.Drawing.Color.Transparent
        Me.VMName.Cursor = System.Windows.Forms.Cursors.Default
        Me.VMName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VMName.Name = "VMName"
        '
        'DescriptionEnd
        '
        Me.DescriptionEnd.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.DescriptionEnd.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DescriptionEnd, "DescriptionEnd")
        Me.DescriptionEnd.Name = "DescriptionEnd"
        '
        'TitleEnd
        '
        Me.TitleEnd.BackColor = System.Drawing.Color.Transparent
        Me.TitleEnd.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.TitleEnd, "TitleEnd")
        Me.TitleEnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleEnd.Name = "TitleEnd"
        '
        'ButtonBox
        '
        Me.ButtonBox.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonBox.Controls.Add(Me.cmdCancel)
        Me.ButtonBox.Controls.Add(Me.cmdNext)
        Me.ButtonBox.Controls.Add(Me.cmdBack)
        Me.ButtonBox.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ButtonBox, "ButtonBox")
        Me.ButtonBox.Name = "ButtonBox"
        Me.ButtonBox.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.cmdNext, "cmdNext")
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'NewMac1
        '
        Me.NewMac1.BackColor = System.Drawing.Color.White
        Me.NewMac1.Controls.Add(Me.WizardStart)
        Me.NewMac1.Controls.Add(Me.TitleStart)
        Me.NewMac1.Controls.Add(Me.DescriptionStart)
        Me.NewMac1.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac1.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac1, "NewMac1")
        Me.NewMac1.Name = "NewMac1"
        '
        'WizardStart
        '
        Me.WizardStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.WizardStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.WizardStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WizardStart.Image = Global.VirtualMac.My.Resources.Resources.NewMac
        resources.ApplyResources(Me.WizardStart, "WizardStart")
        Me.WizardStart.Name = "WizardStart"
        Me.WizardStart.TabStop = False
        '
        'TitleStart
        '
        Me.TitleStart.BackColor = System.Drawing.Color.Transparent
        Me.TitleStart.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.TitleStart, "TitleStart")
        Me.TitleStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleStart.Name = "TitleStart"
        '
        'DescriptionStart
        '
        Me.DescriptionStart.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.DescriptionStart.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DescriptionStart, "DescriptionStart")
        Me.DescriptionStart.Name = "DescriptionStart"
        '
        'HelpA
        '
        Me.HelpA.BackColor = System.Drawing.Color.Transparent
        Me.HelpA.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpA.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.HelpA, "HelpA")
        Me.HelpA.Name = "HelpA"
        '
        'FileNameTitleA
        '
        Me.FileNameTitleA.BackColor = System.Drawing.SystemColors.Control
        Me.FileNameTitleA.Cursor = System.Windows.Forms.Cursors.Default
        Me.FileNameTitleA.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.FileNameTitleA, "FileNameTitleA")
        Me.FileNameTitleA.Name = "FileNameTitleA"
        '
        'BrowseA
        '
        Me.BrowseA.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseA.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseA.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseA, "BrowseA")
        Me.BrowseA.Name = "BrowseA"
        Me.BrowseA.UseVisualStyleBackColor = True
        '
        'FileNameA
        '
        Me.FileNameA.AcceptsReturn = True
        Me.FileNameA.BackColor = System.Drawing.SystemColors.Window
        Me.FileNameA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FileNameA.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.FileNameA, "FileNameA")
        Me.FileNameA.Name = "FileNameA"
        '
        'NewMacFromExist
        '
        Me.NewMacFromExist.BackColor = System.Drawing.SystemColors.Control
        Me.NewMacFromExist.Controls.Add(Me.FileNameA)
        Me.NewMacFromExist.Controls.Add(Me.BrowseA)
        Me.NewMacFromExist.Controls.Add(Me.FileNameTitleA)
        Me.NewMacFromExist.Controls.Add(Me.HelpA)
        Me.NewMacFromExist.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMacFromExist.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMacFromExist, "NewMacFromExist")
        Me.NewMacFromExist.Name = "NewMacFromExist"
        '
        'NewMac60ButtonFix
        '
        Me.NewMac60ButtonFix.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac60ButtonFix.Controls.Add(Me.CreateNewVD)
        Me.NewMac60ButtonFix.Controls.Add(Me.AddExistingVD)
        Me.NewMac60ButtonFix.Controls.Add(Me.NewMac60Help)
        Me.NewMac60ButtonFix.Controls.Add(Me.NewMac60Use)
        Me.NewMac60ButtonFix.Controls.Add(Me.NewMac60About)
        Me.NewMac60ButtonFix.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac60ButtonFix.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac60ButtonFix, "NewMac60ButtonFix")
        Me.NewMac60ButtonFix.Name = "NewMac60ButtonFix"
        '
        'NewMac60About
        '
        Me.NewMac60About.BackColor = System.Drawing.Color.Transparent
        Me.NewMac60About.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac60About.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac60About, "NewMac60About")
        Me.NewMac60About.Name = "NewMac60About"
        '
        'NewMac60Use
        '
        Me.NewMac60Use.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac60Use.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac60Use.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac60Use, "NewMac60Use")
        Me.NewMac60Use.Name = "NewMac60Use"
        '
        'NewMac60Help
        '
        Me.NewMac60Help.BackColor = System.Drawing.Color.Transparent
        Me.NewMac60Help.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac60Help.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac60Help, "NewMac60Help")
        Me.NewMac60Help.Name = "NewMac60Help"
        '
        'AddExistingVD
        '
        Me.AddExistingVD.BackColor = System.Drawing.SystemColors.Control
        Me.AddExistingVD.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddExistingVD.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AddExistingVD, "AddExistingVD")
        Me.AddExistingVD.Name = "AddExistingVD"
        Me.AddExistingVD.TabStop = True
        Me.AddExistingVD.UseVisualStyleBackColor = False
        '
        'CreateNewVD
        '
        Me.CreateNewVD.BackColor = System.Drawing.SystemColors.Control
        Me.CreateNewVD.Checked = True
        Me.CreateNewVD.Cursor = System.Windows.Forms.Cursors.Default
        Me.CreateNewVD.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CreateNewVD, "CreateNewVD")
        Me.CreateNewVD.Name = "CreateNewVD"
        Me.CreateNewVD.TabStop = True
        Me.CreateNewVD.UseVisualStyleBackColor = False
        '
        'NewMac60
        '
        Me.NewMac60.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac60.Controls.Add(Me.NewMac60ButtonFix)
        Me.NewMac60.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac60.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac60, "NewMac60")
        Me.NewMac60.Name = "NewMac60"
        '
        'NewVDTitleHelp
        '
        Me.NewVDTitleHelp.BackColor = System.Drawing.SystemColors.Control
        Me.NewVDTitleHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewVDTitleHelp.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewVDTitleHelp, "NewVDTitleHelp")
        Me.NewVDTitleHelp.Name = "NewVDTitleHelp"
        '
        'NewVDHelp
        '
        Me.NewVDHelp.BackColor = System.Drawing.SystemColors.Control
        Me.NewVDHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewVDHelp.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewVDHelp, "NewVDHelp")
        Me.NewVDHelp.Name = "NewVDHelp"
        '
        'InfoVDSize
        '
        Me.InfoVDSize.BackColor = System.Drawing.SystemColors.Control
        Me.InfoVDSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.InfoVDSize.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.InfoVDSize, "InfoVDSize")
        Me.InfoVDSize.Name = "InfoVDSize"
        '
        'MaxVDSize
        '
        Me.MaxVDSize.BackColor = System.Drawing.SystemColors.Control
        Me.MaxVDSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaxVDSize.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.MaxVDSize, "MaxVDSize")
        Me.MaxVDSize.Name = "MaxVDSize"
        '
        'VDMBInfo
        '
        Me.VDMBInfo.BackColor = System.Drawing.SystemColors.Control
        Me.VDMBInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.VDMBInfo.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.VDMBInfo, "VDMBInfo")
        Me.VDMBInfo.Name = "VDMBInfo"
        '
        'VDInfoMaxMBSize
        '
        Me.VDInfoMaxMBSize.BackColor = System.Drawing.SystemColors.Control
        Me.VDInfoMaxMBSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.VDInfoMaxMBSize.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.VDInfoMaxMBSize, "VDInfoMaxMBSize")
        Me.VDInfoMaxMBSize.Name = "VDInfoMaxMBSize"
        '
        'VDInfoAboutVD
        '
        Me.VDInfoAboutVD.BackColor = System.Drawing.SystemColors.Control
        Me.VDInfoAboutVD.Cursor = System.Windows.Forms.Cursors.Default
        Me.VDInfoAboutVD.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.VDInfoAboutVD, "VDInfoAboutVD")
        Me.VDInfoAboutVD.Name = "VDInfoAboutVD"
        '
        'WarningLowerSize
        '
        Me.WarningLowerSize.BackColor = System.Drawing.SystemColors.Control
        Me.WarningLowerSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.WarningLowerSize.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.WarningLowerSize, "WarningLowerSize")
        Me.WarningLowerSize.Name = "WarningLowerSize"
        '
        'NewMac7VDName
        '
        Me.NewMac7VDName.AcceptsReturn = True
        Me.NewMac7VDName.BackColor = System.Drawing.SystemColors.Window
        Me.NewMac7VDName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NewMac7VDName.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.NewMac7VDName, "NewMac7VDName")
        Me.NewMac7VDName.Name = "NewMac7VDName"
        '
        'NewVDBrowse
        '
        Me.NewVDBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.NewVDBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewVDBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewVDBrowse, "NewVDBrowse")
        Me.NewVDBrowse.Name = "NewVDBrowse"
        Me.NewVDBrowse.UseVisualStyleBackColor = True
        '
        'DiskSizeMB
        '
        Me.DiskSizeMB.AcceptsReturn = True
        Me.DiskSizeMB.BackColor = System.Drawing.SystemColors.Window
        Me.DiskSizeMB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DiskSizeMB.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.DiskSizeMB, "DiskSizeMB")
        Me.DiskSizeMB.Name = "DiskSizeMB"
        '
        'NewMac6
        '
        Me.NewMac6.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac6.Controls.Add(Me.DiskSizeMB)
        Me.NewMac6.Controls.Add(Me.NewVDBrowse)
        Me.NewMac6.Controls.Add(Me.NewMac7VDName)
        Me.NewMac6.Controls.Add(Me.WarningLowerSize)
        Me.NewMac6.Controls.Add(Me.VDInfoAboutVD)
        Me.NewMac6.Controls.Add(Me.VDInfoMaxMBSize)
        Me.NewMac6.Controls.Add(Me.VDMBInfo)
        Me.NewMac6.Controls.Add(Me.MaxVDSize)
        Me.NewMac6.Controls.Add(Me.InfoVDSize)
        Me.NewMac6.Controls.Add(Me.NewVDHelp)
        Me.NewMac6.Controls.Add(Me.NewVDTitleHelp)
        Me.NewMac6.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac6.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac6, "NewMac6")
        Me.NewMac6.Name = "NewMac6"
        '
        'Help4
        '
        Me.Help4.BackColor = System.Drawing.SystemColors.Control
        Me.Help4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Help4.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Help4, "Help4")
        Me.Help4.Name = "Help4"
        '
        'OSListTitle
        '
        Me.OSListTitle.BackColor = System.Drawing.SystemColors.Control
        Me.OSListTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSListTitle.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OSListTitle, "OSListTitle")
        Me.OSListTitle.Name = "OSListTitle"
        '
        'DefaultHardware
        '
        Me.DefaultHardware.BackColor = System.Drawing.SystemColors.Control
        Me.DefaultHardware.Cursor = System.Windows.Forms.Cursors.Default
        Me.DefaultHardware.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DefaultHardware, "DefaultHardware")
        Me.DefaultHardware.Name = "DefaultHardware"
        '
        'Memory
        '
        Me.Memory.BackColor = System.Drawing.SystemColors.Control
        Me.Memory.Cursor = System.Windows.Forms.Cursors.Default
        Me.Memory.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Memory, "Memory")
        Me.Memory.Name = "Memory"
        '
        'Disk
        '
        Me.Disk.BackColor = System.Drawing.SystemColors.Control
        Me.Disk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Disk.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Disk, "Disk")
        Me.Disk.Name = "Disk"
        '
        'CPUType
        '
        Me.CPUType.BackColor = System.Drawing.SystemColors.Control
        Me.CPUType.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUType.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CPUType, "CPUType")
        Me.CPUType.Name = "CPUType"
        '
        'MemoryMB
        '
        Me.MemoryMB.BackColor = System.Drawing.SystemColors.Control
        Me.MemoryMB.Cursor = System.Windows.Forms.Cursors.Default
        Me.MemoryMB.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.MemoryMB, "MemoryMB")
        Me.MemoryMB.Name = "MemoryMB"
        '
        'DiskMB
        '
        Me.DiskMB.BackColor = System.Drawing.SystemColors.Control
        Me.DiskMB.Cursor = System.Windows.Forms.Cursors.Default
        Me.DiskMB.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DiskMB, "DiskMB")
        Me.DiskMB.Name = "DiskMB"
        '
        'CPUArch
        '
        Me.CPUArch.BackColor = System.Drawing.SystemColors.Control
        Me.CPUArch.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUArch.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CPUArch, "CPUArch")
        Me.CPUArch.Name = "CPUArch"
        '
        'OSList
        '
        Me.OSList.BackColor = System.Drawing.SystemColors.Window
        Me.OSList.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OSList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OSList.Items.AddRange(New Object() {resources.GetString("OSList.Items"), resources.GetString("OSList.Items1"), resources.GetString("OSList.Items2"), resources.GetString("OSList.Items3"), resources.GetString("OSList.Items4"), resources.GetString("OSList.Items5"), resources.GetString("OSList.Items6"), resources.GetString("OSList.Items7")})
        resources.ApplyResources(Me.OSList, "OSList")
        Me.OSList.Name = "OSList"
        '
        'NewMac4
        '
        Me.NewMac4.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac4.Controls.Add(Me.OSList)
        Me.NewMac4.Controls.Add(Me.CPUArch)
        Me.NewMac4.Controls.Add(Me.DiskMB)
        Me.NewMac4.Controls.Add(Me.MemoryMB)
        Me.NewMac4.Controls.Add(Me.CPUType)
        Me.NewMac4.Controls.Add(Me.Disk)
        Me.NewMac4.Controls.Add(Me.Memory)
        Me.NewMac4.Controls.Add(Me.DefaultHardware)
        Me.NewMac4.Controls.Add(Me.OSListTitle)
        Me.NewMac4.Controls.Add(Me.Help4)
        Me.NewMac4.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac4.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac4, "NewMac4")
        Me.NewMac4.Name = "NewMac4"
        '
        'RAMHelp
        '
        Me.RAMHelp.BackColor = System.Drawing.SystemColors.Control
        Me.RAMHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMHelp.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMHelp, "RAMHelp")
        Me.RAMHelp.Name = "RAMHelp"
        '
        'RAMHelpTitle
        '
        Me.RAMHelpTitle.BackColor = System.Drawing.SystemColors.Control
        Me.RAMHelpTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMHelpTitle.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMHelpTitle, "RAMHelpTitle")
        Me.RAMHelpTitle.Name = "RAMHelpTitle"
        '
        'RecRAM
        '
        Me.RecRAM.BackColor = System.Drawing.SystemColors.Control
        Me.RecRAM.Cursor = System.Windows.Forms.Cursors.Default
        Me.RecRAM.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RecRAM, "RecRAM")
        Me.RecRAM.Name = "RecRAM"
        '
        'Adjust
        '
        Me.Adjust.BackColor = System.Drawing.SystemColors.Control
        Me.Adjust.Cursor = System.Windows.Forms.Cursors.Default
        Me.Adjust.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Adjust, "Adjust")
        Me.Adjust.Name = "Adjust"
        Me.Adjust.TabStop = True
        Me.Adjust.UseVisualStyleBackColor = False
        '
        'Recommend
        '
        Me.Recommend.BackColor = System.Drawing.SystemColors.Control
        Me.Recommend.Checked = True
        Me.Recommend.Cursor = System.Windows.Forms.Cursors.Default
        Me.Recommend.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Recommend, "Recommend")
        Me.Recommend.Name = "Recommend"
        Me.Recommend.TabStop = True
        Me.Recommend.UseVisualStyleBackColor = False
        '
        'RAMAdjuster
        '
        Me.RAMAdjuster.BackColor = System.Drawing.SystemColors.Control
        Me.RAMAdjuster.Controls.Add(Me.RAMAdjust)
        Me.RAMAdjuster.Controls.Add(Me.RAMMegabyteNumber)
        Me.RAMAdjuster.Controls.Add(Me.MegaByte)
        Me.RAMAdjuster.Controls.Add(Me.RAMDescription)
        Me.RAMAdjuster.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMAdjuster.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMAdjuster, "RAMAdjuster")
        Me.RAMAdjuster.Name = "RAMAdjuster"
        '
        'RAMDescription
        '
        Me.RAMDescription.BackColor = System.Drawing.SystemColors.Control
        Me.RAMDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMDescription.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMDescription, "RAMDescription")
        Me.RAMDescription.Name = "RAMDescription"
        '
        'MegaByte
        '
        Me.MegaByte.BackColor = System.Drawing.SystemColors.Control
        Me.MegaByte.Cursor = System.Windows.Forms.Cursors.Default
        Me.MegaByte.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.MegaByte, "MegaByte")
        Me.MegaByte.Name = "MegaByte"
        '
        'RAMMegabyteNumber
        '
        Me.RAMMegabyteNumber.AcceptsReturn = True
        Me.RAMMegabyteNumber.BackColor = System.Drawing.SystemColors.Window
        Me.RAMMegabyteNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RAMMegabyteNumber.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.RAMMegabyteNumber, "RAMMegabyteNumber")
        Me.RAMMegabyteNumber.Name = "RAMMegabyteNumber"
        Me.RAMMegabyteNumber.TabStop = False
        '
        'RAMAdjust
        '
        resources.ApplyResources(Me.RAMAdjust, "RAMAdjust")
        Me.RAMAdjust.Maximum = 959
        Me.RAMAdjust.Name = "RAMAdjust"
        Me.RAMAdjust.Value = 128
        '
        'NewMac5
        '
        Me.NewMac5.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac5.Controls.Add(Me.RAMAdjuster)
        Me.NewMac5.Controls.Add(Me.Recommend)
        Me.NewMac5.Controls.Add(Me.Adjust)
        Me.NewMac5.Controls.Add(Me.RecRAM)
        Me.NewMac5.Controls.Add(Me.RAMHelpTitle)
        Me.NewMac5.Controls.Add(Me.RAMHelp)
        Me.NewMac5.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac5.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac5, "NewMac5")
        Me.NewMac5.Name = "NewMac5"
        '
        'AddExistDescription2
        '
        Me.AddExistDescription2.BackColor = System.Drawing.SystemColors.Control
        Me.AddExistDescription2.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddExistDescription2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AddExistDescription2, "AddExistDescription2")
        Me.AddExistDescription2.Name = "AddExistDescription2"
        '
        'UseDefaultsDescription2
        '
        Me.UseDefaultsDescription2.BackColor = System.Drawing.Color.Transparent
        Me.UseDefaultsDescription2.Cursor = System.Windows.Forms.Cursors.Default
        Me.UseDefaultsDescription2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.UseDefaultsDescription2, "UseDefaultsDescription2")
        Me.UseDefaultsDescription2.Name = "UseDefaultsDescription2"
        '
        'NewDescription2
        '
        Me.NewDescription2.BackColor = System.Drawing.Color.Transparent
        Me.NewDescription2.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewDescription2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewDescription2, "NewDescription2")
        Me.NewDescription2.Name = "NewDescription2"
        '
        'HelpSelect
        '
        Me.HelpSelect.BackColor = System.Drawing.SystemColors.Control
        Me.HelpSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpSelect.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.HelpSelect, "HelpSelect")
        Me.HelpSelect.Name = "HelpSelect"
        '
        'AddExist
        '
        Me.AddExist.BackColor = System.Drawing.SystemColors.Control
        Me.AddExist.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddExist.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AddExist, "AddExist")
        Me.AddExist.Name = "AddExist"
        Me.AddExist.TabStop = True
        Me.AddExist.UseVisualStyleBackColor = False
        '
        'UseDefaults
        '
        Me.UseDefaults.BackColor = System.Drawing.SystemColors.Control
        Me.UseDefaults.Cursor = System.Windows.Forms.Cursors.Default
        Me.UseDefaults.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.UseDefaults, "UseDefaults")
        Me.UseDefaults.Name = "UseDefaults"
        Me.UseDefaults.TabStop = True
        Me.UseDefaults.UseVisualStyleBackColor = False
        '
        'CreateNew
        '
        Me.CreateNew.BackColor = System.Drawing.SystemColors.Control
        Me.CreateNew.Checked = True
        Me.CreateNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.CreateNew.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CreateNew, "CreateNew")
        Me.CreateNew.Name = "CreateNew"
        Me.CreateNew.TabStop = True
        Me.CreateNew.UseVisualStyleBackColor = False
        '
        'NewMac2
        '
        Me.NewMac2.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac2.Controls.Add(Me.CreateNew)
        Me.NewMac2.Controls.Add(Me.UseDefaults)
        Me.NewMac2.Controls.Add(Me.AddExist)
        Me.NewMac2.Controls.Add(Me.HelpSelect)
        Me.NewMac2.Controls.Add(Me.NewDescription2)
        Me.NewMac2.Controls.Add(Me.UseDefaultsDescription2)
        Me.NewMac2.Controls.Add(Me.AddExistDescription2)
        Me.NewMac2.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac2, "NewMac2")
        Me.NewMac2.Name = "NewMac2"
        '
        'frmNewMac
        '
        Me.AcceptButton = Me.cmdNext
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdCancel
        Me.Controls.Add(Me.NewMacWizard)
        Me.Controls.Add(Me.NewMac1)
        Me.Controls.Add(Me.NewMacEnd)
        Me.Controls.Add(Me.ButtonBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewMac"
        Me.NewMacWizard.ResumeLayout(False)
        Me.DescriptionBox.ResumeLayout(False)
        CType(Me.WizardPictureSmall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewMac3.ResumeLayout(False)
        Me.NewMac3.PerformLayout()
        Me.NewMacEnd.ResumeLayout(False)
        Me.NewMacEnd.PerformLayout()
        CType(Me.WizardEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonBox.ResumeLayout(False)
        Me.NewMac1.ResumeLayout(False)
        CType(Me.WizardStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewMacFromExist.ResumeLayout(False)
        Me.NewMacFromExist.PerformLayout()
        Me.NewMac60ButtonFix.ResumeLayout(False)
        Me.NewMac60.ResumeLayout(False)
        Me.NewMac6.ResumeLayout(False)
        Me.NewMac6.PerformLayout()
        Me.NewMac4.ResumeLayout(False)
        Me.RAMAdjuster.ResumeLayout(False)
        Me.RAMAdjuster.PerformLayout()
        CType(Me.RAMAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewMac5.ResumeLayout(False)
        Me.NewMac2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents NewMac2 As Panel
    Public WithEvents CreateNew As RadioButton
    Public WithEvents UseDefaults As RadioButton
    Public WithEvents AddExist As RadioButton
    Public WithEvents HelpSelect As Label
    Public WithEvents NewDescription2 As Label
    Public WithEvents UseDefaultsDescription2 As Label
    Public WithEvents AddExistDescription2 As Label
    Public WithEvents NewMac5 As Panel
    Public WithEvents RAMAdjuster As Panel
    Friend WithEvents RAMAdjust As TrackBar
    Public WithEvents RAMMegabyteNumber As TextBox
    Public WithEvents MegaByte As Label
    Public WithEvents RAMDescription As Label
    Public WithEvents Recommend As RadioButton
    Public WithEvents Adjust As RadioButton
    Public WithEvents RecRAM As Label
    Public WithEvents RAMHelpTitle As Label
    Public WithEvents RAMHelp As Label
    Public WithEvents NewMac4 As Panel
    Public WithEvents OSList As ComboBox
    Public WithEvents CPUArch As Label
    Public WithEvents DiskMB As Label
    Public WithEvents MemoryMB As Label
    Public WithEvents CPUType As Label
    Public WithEvents Disk As Label
    Public WithEvents Memory As Label
    Public WithEvents DefaultHardware As Label
    Public WithEvents OSListTitle As Label
    Public WithEvents Help4 As Label
    Public WithEvents NewMac6 As Panel
    Public WithEvents DiskSizeMB As TextBox
    Public WithEvents NewVDBrowse As Button
    Public WithEvents NewMac7VDName As TextBox
    Public WithEvents WarningLowerSize As Label
    Public WithEvents VDInfoAboutVD As Label
    Public WithEvents VDInfoMaxMBSize As Label
    Public WithEvents VDMBInfo As Label
    Public WithEvents MaxVDSize As Label
    Public WithEvents InfoVDSize As Label
    Public WithEvents NewVDHelp As Label
    Public WithEvents NewVDTitleHelp As Label
    Public WithEvents NewMac60 As Panel
    Public WithEvents NewMac60ButtonFix As Panel
    Public WithEvents CreateNewVD As RadioButton
    Public WithEvents AddExistingVD As RadioButton
    Public WithEvents NewMac60Help As Label
    Public WithEvents NewMac60Use As Label
    Public WithEvents NewMac60About As Label
    Public WithEvents NewMacFromExist As Panel
    Public WithEvents FileNameA As TextBox
    Public WithEvents BrowseA As Button
    Public WithEvents FileNameTitleA As Label
    Public WithEvents HelpA As Label
    Public WithEvents ToolTip1 As ToolTip
#End Region
End Class