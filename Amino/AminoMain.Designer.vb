<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AminoMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AminoMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BackButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardButton = New System.Windows.Forms.ToolStripButton()
        Me.RefreshButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExploreButton = New System.Windows.Forms.ToolStripButton()
        Me.SearchButton = New System.Windows.Forms.ToolStripButton()
        Me.JumpButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AppButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SettingsPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.WhatsNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.FollowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutButton = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsPanelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.ToolStrip1.SuspendLayout()
        Me.SysTrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackButton, Me.ForwardButton, Me.RefreshButton, Me.ToolStripSeparator1, Me.ExploreButton, Me.SearchButton, Me.JumpButton, Me.ToolStripSeparator2, Me.AppButton, Me.ProfileButton, Me.SignOutButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(946, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BackButton
        '
        Me.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackButton.Image = Global.Amino.My.Resources.Resources.Back
        Me.BackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.Text = "Back"
        '
        'ForwardButton
        '
        Me.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardButton.Image = Global.Amino.My.Resources.Resources.Forward
        Me.ForwardButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.Text = "Forward"
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshButton.Image = Global.Amino.My.Resources.Resources.Refresh
        Me.RefreshButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(36, 36)
        Me.RefreshButton.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ExploreButton
        '
        Me.ExploreButton.Image = Global.Amino.My.Resources.Resources.Web_Studio
        Me.ExploreButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExploreButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExploreButton.Name = "ExploreButton"
        Me.ExploreButton.Size = New System.Drawing.Size(81, 36)
        Me.ExploreButton.Text = "Explore"
        '
        'SearchButton
        '
        Me.SearchButton.Image = Global.Amino.My.Resources.Resources.Search
        Me.SearchButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(110, 36)
        Me.SearchButton.Text = "Topic Search"
        Me.SearchButton.Visible = False
        '
        'JumpButton
        '
        Me.JumpButton.Image = Global.Amino.My.Resources.Resources.Jump
        Me.JumpButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JumpButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.JumpButton.Name = "JumpButton"
        Me.JumpButton.Size = New System.Drawing.Size(97, 36)
        Me.JumpButton.Text = "Jump To..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'AppButton
        '
        Me.AppButton.BackColor = System.Drawing.SystemColors.Control
        Me.AppButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsPanelToolStripMenuItem, Me.ToolStripSeparator5, Me.WhatsNewToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator3, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.AppButton.Image = Global.Amino.My.Resources.Resources.NewWindow
        Me.AppButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AppButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AppButton.Name = "AppButton"
        Me.AppButton.Size = New System.Drawing.Size(113, 36)
        Me.AppButton.Text = "Application"
        '
        'SettingsPanelToolStripMenuItem
        '
        Me.SettingsPanelToolStripMenuItem.Image = Global.Amino.My.Resources.Resources.Settings
        Me.SettingsPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanelToolStripMenuItem.Name = "SettingsPanelToolStripMenuItem"
        Me.SettingsPanelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsPanelToolStripMenuItem.Size = New System.Drawing.Size(256, 38)
        Me.SettingsPanelToolStripMenuItem.Text = "Settings Panel"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(253, 6)
        '
        'WhatsNewToolStripMenuItem
        '
        Me.WhatsNewToolStripMenuItem.Image = Global.Amino.My.Resources.Resources.Changes
        Me.WhatsNewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WhatsNewToolStripMenuItem.Name = "WhatsNewToolStripMenuItem"
        Me.WhatsNewToolStripMenuItem.Size = New System.Drawing.Size(256, 38)
        Me.WhatsNewToolStripMenuItem.Text = "What's new?"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = Global.Amino.My.Resources.Resources.Update
        Me.CheckForUpdatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(256, 38)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(253, 6)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = Global.Amino.My.Resources.Resources.Question
        Me.HelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(256, 38)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Amino.My.Resources.Resources.Information
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(256, 38)
        Me.AboutToolStripMenuItem.Text = "About Amino For Desktop..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(253, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Amino.My.Resources.Resources.ExitIco
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(256, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProfileButton
        '
        Me.ProfileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ProfileButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FollowersToolStripMenuItem, Me.FollowingToolStripMenuItem})
        Me.ProfileButton.Image = Global.Amino.My.Resources.Resources.Information
        Me.ProfileButton.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.ProfileButton.Name = "ProfileButton"
        Me.ProfileButton.Size = New System.Drawing.Size(94, 36)
        Me.ProfileButton.Text = "Global Profile"
        Me.ProfileButton.ToolTipText = "Go to your global profile or click the drop-down for more options (if enabled)."
        '
        'FollowersToolStripMenuItem
        '
        Me.FollowersToolStripMenuItem.Name = "FollowersToolStripMenuItem"
        Me.FollowersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FollowersToolStripMenuItem.Text = "Followers"
        Me.FollowersToolStripMenuItem.Visible = False
        '
        'FollowingToolStripMenuItem
        '
        Me.FollowingToolStripMenuItem.Name = "FollowingToolStripMenuItem"
        Me.FollowingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FollowingToolStripMenuItem.Text = "Following"
        Me.FollowingToolStripMenuItem.Visible = False
        '
        'SignOutButton
        '
        Me.SignOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SignOutButton.Image = CType(resources.GetObject("SignOutButton.Image"), System.Drawing.Image)
        Me.SignOutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SignOutButton.Name = "SignOutButton"
        Me.SignOutButton.Size = New System.Drawing.Size(57, 36)
        Me.SignOutButton.Text = "Sign Out"
        Me.SignOutButton.ToolTipText = "Sign out of your Amino account."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'SysTrayIcon
        '
        Me.SysTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.SysTrayIcon.ContextMenuStrip = Me.SysTrayMenu
        Me.SysTrayIcon.Icon = CType(resources.GetObject("SysTrayIcon.Icon"), System.Drawing.Icon)
        Me.SysTrayIcon.Text = "Amino For Desktop"
        Me.SysTrayIcon.Visible = True
        '
        'SysTrayMenu
        '
        Me.SysTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ToolStripSeparator7, Me.SettingsPanelToolStripMenuItem1, Me.ToolStripSeparator6, Me.ExitToolStripMenuItem1})
        Me.SysTrayMenu.Name = "ContextMenuStrip1"
        Me.SysTrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SysTrayMenu.Size = New System.Drawing.Size(165, 130)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Image = Global.Amino.My.Resources.Resources.Restore
        Me.RestoreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(164, 38)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(161, 6)
        '
        'SettingsPanelToolStripMenuItem1
        '
        Me.SettingsPanelToolStripMenuItem1.Image = Global.Amino.My.Resources.Resources.Settings
        Me.SettingsPanelToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanelToolStripMenuItem1.Name = "SettingsPanelToolStripMenuItem1"
        Me.SettingsPanelToolStripMenuItem1.Size = New System.Drawing.Size(164, 38)
        Me.SettingsPanelToolStripMenuItem1.Text = "Settings Panel"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(161, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.Amino.My.Resources.Resources.ExitIco
        Me.ExitToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(164, 38)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeckoWebBrowser1.ConsoleMessageEventReceivesConsoleLogCalls = True
        Me.GeckoWebBrowser1.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(0, 39)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(946, 549)
        Me.GeckoWebBrowser1.TabIndex = 0
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'AminoMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 588)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "AminoMain"
        Me.Text = "Amino For Desktop"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SysTrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BackButton As ToolStripButton
    Friend WithEvents ForwardButton As ToolStripButton
    Friend WithEvents RefreshButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExploreButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AppButton As ToolStripDropDownButton
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents WhatsNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents JumpButton As ToolStripButton
    Friend WithEvents SearchButton As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SysTrayIcon As NotifyIcon
    Friend WithEvents SysTrayMenu As ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents SettingsPanelToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SignOutButton As ToolStripButton
    Friend WithEvents ProfileButton As ToolStripSplitButton
    Friend WithEvents FollowersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FollowingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
End Class
