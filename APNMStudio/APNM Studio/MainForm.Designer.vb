<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportProjectTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveFileToolStripMenuItem, Me.SaveAllToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExportProjectTemplateToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(750, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer1.Size = New System.Drawing.Size(221, 474)
        Me.SplitContainer1.SplitterDistance = 237
        Me.SplitContainer1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(227, 27)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(523, 474)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 5
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem1})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ProjectToolStripMenuItem1
        '
        Me.ProjectToolStripMenuItem1.Name = "ProjectToolStripMenuItem1"
        Me.ProjectToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ProjectToolStripMenuItem1.Text = "Project"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem2})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ProjectToolStripMenuItem2
        '
        Me.ProjectToolStripMenuItem2.Name = "ProjectToolStripMenuItem2"
        Me.ProjectToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ProjectToolStripMenuItem2.Text = "Reference"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CloseAllToolStripMenuItem.Text = "Close All"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(196, 6)
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SaveFileToolStripMenuItem.Text = "Save Current File"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SaveAllToolStripMenuItem.Text = "Save Current File As"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save Project"
        '
        'ExportProjectTemplateToolStripMenuItem
        '
        Me.ExportProjectTemplateToolStripMenuItem.Name = "ExportProjectTemplateToolStripMenuItem"
        Me.ExportProjectTemplateToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ExportProjectTemplateToolStripMenuItem.Text = "Export Project Template"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 526)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "APNM Studio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportProjectTemplateToolStripMenuItem As ToolStripMenuItem
End Class
