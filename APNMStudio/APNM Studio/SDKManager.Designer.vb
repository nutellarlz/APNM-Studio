<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SDKManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("APNM SDK Tools")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("APNM SDK Platform Tools")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("APNM SDK Build Tools")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("APNM Active Debug")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML5 with JavaScript Tools")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GUI Editor Tool")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Plugin Repo Publish Tool")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tools", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Documentation for APNM SDK")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SDK Platform")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Samples for SDK")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("APNM Web Apps Tools")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(".NET Runtimes")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sources for APNM SDK")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("APNM 1.0.1.0 (API 1)", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("APNM+USB")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Docs")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Git Extension")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stats Tracker")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("API Installers")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Extras", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SDKManager))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowUpdatesNewPackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.InstalledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObsoleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(12, 57)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "APNMSDKTools"
        TreeNode1.Text = "APNM SDK Tools"
        TreeNode2.Name = "APNMSDKPlatformTools"
        TreeNode2.Text = "APNM SDK Platform Tools"
        TreeNode3.Name = "APNMSDKBuildTools"
        TreeNode3.Text = "APNM SDK Build Tools"
        TreeNode4.Name = "APNMActiveDebug"
        TreeNode4.Text = "APNM Active Debug"
        TreeNode5.Name = "HTML5JSTools"
        TreeNode5.Text = "HTML5 with JavaScript Tools"
        TreeNode6.Name = "GUIEditorTool"
        TreeNode6.Text = "GUI Editor Tool"
        TreeNode7.Name = "PluginRepoPubTool"
        TreeNode7.Text = "Plugin Repo Publish Tool"
        TreeNode8.Name = "AllTools"
        TreeNode8.Text = "Tools"
        TreeNode9.Name = "DocsAPNMSDK1"
        TreeNode9.Text = "Documentation for APNM SDK"
        TreeNode10.Name = "SDKPlatform1"
        TreeNode10.Text = "SDK Platform"
        TreeNode11.Name = "SDKSamples1"
        TreeNode11.Text = "Samples for SDK"
        TreeNode12.Name = "WebApps1"
        TreeNode12.Text = "APNM Web Apps Tools"
        TreeNode13.Name = "dotNETRuntimes1"
        TreeNode13.Text = ".NET Runtimes"
        TreeNode14.Name = "SDKSources1"
        TreeNode14.Text = "Sources for APNM SDK"
        TreeNode15.Name = "API1"
        TreeNode15.Text = "APNM 1.0.1.0 (API 1)"
        TreeNode16.Name = "plusUSB"
        TreeNode16.Text = "APNM+USB"
        TreeNode17.Name = "SupportDocs"
        TreeNode17.Text = "Support Docs"
        TreeNode18.Name = "GitExt"
        TreeNode18.Text = "Git Extension"
        TreeNode19.Name = "StatsTracker"
        TreeNode19.Text = "Stats Tracker"
        TreeNode20.Name = "APIInstallers"
        TreeNode20.Text = "API Installers"
        TreeNode21.Name = "Extras"
        TreeNode21.Text = "Extras"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode15, TreeNode21})
        Me.TreeView1.Size = New System.Drawing.Size(681, 296)
        Me.TreeView1.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PackagesToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PackagesToolStripMenuItem
        '
        Me.PackagesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowUpdatesNewPackagesToolStripMenuItem, Me.InstalledToolStripMenuItem, Me.ObsoleteToolStripMenuItem})
        Me.PackagesToolStripMenuItem.Name = "PackagesToolStripMenuItem"
        Me.PackagesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PackagesToolStripMenuItem.Text = "Packages"
        '
        'ShowUpdatesNewPackagesToolStripMenuItem
        '
        Me.ShowUpdatesNewPackagesToolStripMenuItem.Checked = True
        Me.ShowUpdatesNewPackagesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowUpdatesNewPackagesToolStripMenuItem.Name = "ShowUpdatesNewPackagesToolStripMenuItem"
        Me.ShowUpdatesNewPackagesToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ShowUpdatesNewPackagesToolStripMenuItem.Text = "Show Updates/New Packages"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SDK Path:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(525, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Show:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(55, 363)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Updates/New"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(153, 363)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "Installed"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(55, 386)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox3.TabIndex = 9
        Me.CheckBox3.Text = "Obsolete"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'InstalledToolStripMenuItem
        '
        Me.InstalledToolStripMenuItem.Checked = True
        Me.InstalledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InstalledToolStripMenuItem.Name = "InstalledToolStripMenuItem"
        Me.InstalledToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.InstalledToolStripMenuItem.Text = "Installed"
        '
        'ObsoleteToolStripMenuItem
        '
        Me.ObsoleteToolStripMenuItem.Name = "ObsoleteToolStripMenuItem"
        Me.ObsoleteToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ObsoleteToolStripMenuItem.Text = "Obsolete"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(562, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Install {00} Packages"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(562, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Delete {00} Packages"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 417)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 32)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Package Load State"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(137, 6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(520, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.APNM_Studio.My.Resources.Resources.ic_content_clear
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(663, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SDKManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 449)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SDKManager"
        Me.Text = "SDK Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PackagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowUpdatesNewPackagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents InstalledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObsoleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
End Class
