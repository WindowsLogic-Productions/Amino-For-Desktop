<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelGeneral))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FullScreenBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SysTrayMinimiseBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.FollowBox = New System.Windows.Forms.GroupBox()
        Me.FollowCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.FollowLabel = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GPSetLabel = New System.Windows.Forms.Label()
        Me.GPSetButton = New System.Windows.Forms.Button()
        Me.GPText = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SettingsPanelButton = New System.Windows.Forms.RadioButton()
        Me.SystemTrayButton = New System.Windows.Forms.RadioButton()
        Me.NothingButton = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TopicSearchBox = New System.Windows.Forms.GroupBox()
        Me.TopicSearchCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TopicSearchLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.FollowBox.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TopicSearchBox.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 10
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.Amino.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(12, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(252, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change general settings..."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(409, 179)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Amino"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.FullScreenBox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 60)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Full Screen"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Amino.My.Resources.Resources.Fullscreen
        Me.PictureBox2.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'FullScreenBox
        '
        Me.FullScreenBox.AutoSize = True
        Me.FullScreenBox.Location = New System.Drawing.Point(44, 37)
        Me.FullScreenBox.Name = "FullScreenBox"
        Me.FullScreenBox.Size = New System.Drawing.Size(117, 17)
        Me.FullScreenBox.TabIndex = 1
        Me.FullScreenBox.Text = "Enable full screen"
        Me.FullScreenBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Use Amino For Desktop in full screen."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.SysTrayMinimiseBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minimising"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Amino.My.Resources.Resources.Minimise
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SysTrayMinimiseBox
        '
        Me.SysTrayMinimiseBox.AutoSize = True
        Me.SysTrayMinimiseBox.Location = New System.Drawing.Point(44, 50)
        Me.SysTrayMinimiseBox.Name = "SysTrayMinimiseBox"
        Me.SysTrayMinimiseBox.Size = New System.Drawing.Size(145, 17)
        Me.SysTrayMinimiseBox.TabIndex = 1
        Me.SysTrayMinimiseBox.Text = "Minimise to system tray"
        Me.SysTrayMinimiseBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "When minimising Amino For Desktop, it will hide itself in the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "system tray and ru" &
    "n in the background."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.FollowBox)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(409, 179)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Global Profile"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FollowBox
        '
        Me.FollowBox.Controls.Add(Me.FollowCheckBox)
        Me.FollowBox.Controls.Add(Me.PictureBox6)
        Me.FollowBox.Controls.Add(Me.FollowLabel)
        Me.FollowBox.Location = New System.Drawing.Point(6, 80)
        Me.FollowBox.Name = "FollowBox"
        Me.FollowBox.Size = New System.Drawing.Size(397, 71)
        Me.FollowBox.TabIndex = 2
        Me.FollowBox.TabStop = False
        Me.FollowBox.Text = "Followers/Following"
        '
        'FollowCheckBox
        '
        Me.FollowCheckBox.AutoSize = True
        Me.FollowCheckBox.Location = New System.Drawing.Point(47, 50)
        Me.FollowCheckBox.Name = "FollowCheckBox"
        Me.FollowCheckBox.Size = New System.Drawing.Size(207, 17)
        Me.FollowCheckBox.TabIndex = 5
        Me.FollowCheckBox.Text = "Show Followers/Following options"
        Me.FollowCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Amino.My.Resources.Resources.Start_up
        Me.PictureBox6.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'FollowLabel
        '
        Me.FollowLabel.AutoSize = True
        Me.FollowLabel.Location = New System.Drawing.Point(44, 21)
        Me.FollowLabel.Name = "FollowLabel"
        Me.FollowLabel.Size = New System.Drawing.Size(315, 26)
        Me.FollowLabel.TabIndex = 0
        Me.FollowLabel.Text = "Quickly access your global followers and following from the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'Global Profile' but" &
    "ton."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GPSetLabel)
        Me.GroupBox5.Controls.Add(Me.GPSetButton)
        Me.GroupBox5.Controls.Add(Me.GPText)
        Me.GroupBox5.Controls.Add(Me.PictureBox5)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(397, 68)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "One-Click Access"
        '
        'GPSetLabel
        '
        Me.GPSetLabel.AutoSize = True
        Me.GPSetLabel.Location = New System.Drawing.Point(309, 42)
        Me.GPSetLabel.Name = "GPSetLabel"
        Me.GPSetLabel.Size = New System.Drawing.Size(61, 13)
        Me.GPSetLabel.TabIndex = 4
        Me.GPSetLabel.Text = "Profile set!"
        Me.ToolTip1.SetToolTip(Me.GPSetLabel, "Your global Amino profile has been set to the Amino user ID you provided.")
        Me.GPSetLabel.Visible = False
        '
        'GPSetButton
        '
        Me.GPSetButton.Location = New System.Drawing.Point(228, 37)
        Me.GPSetButton.Name = "GPSetButton"
        Me.GPSetButton.Size = New System.Drawing.Size(75, 23)
        Me.GPSetButton.TabIndex = 3
        Me.GPSetButton.Text = "Set"
        Me.GPSetButton.UseVisualStyleBackColor = True
        '
        'GPText
        '
        Me.GPText.Location = New System.Drawing.Point(94, 37)
        Me.GPText.Name = "GPText"
        Me.GPText.Size = New System.Drawing.Size(128, 22)
        Me.GPText.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.GPText, "Enter your Amino username.")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Amino.My.Resources.Resources.Minimise
        Me.PictureBox5.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Quickly access your global profile in one click."
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Start-up"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.SettingsPanelButton)
        Me.GroupBox2.Controls.Add(Me.SystemTrayButton)
        Me.GroupBox2.Controls.Add(Me.NothingButton)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 59)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Start-up"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Amino.My.Resources.Resources.Start_up
        Me.PictureBox3.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'SettingsPanelButton
        '
        Me.SettingsPanelButton.AutoSize = True
        Me.SettingsPanelButton.Location = New System.Drawing.Point(271, 36)
        Me.SettingsPanelButton.Name = "SettingsPanelButton"
        Me.SettingsPanelButton.Size = New System.Drawing.Size(98, 17)
        Me.SettingsPanelButton.TabIndex = 3
        Me.SettingsPanelButton.TabStop = True
        Me.SettingsPanelButton.Text = "Settings Panel"
        Me.SettingsPanelButton.UseVisualStyleBackColor = True
        '
        'SystemTrayButton
        '
        Me.SystemTrayButton.AutoSize = True
        Me.SystemTrayButton.Location = New System.Drawing.Point(121, 36)
        Me.SystemTrayButton.Name = "SystemTrayButton"
        Me.SystemTrayButton.Size = New System.Drawing.Size(144, 17)
        Me.SystemTrayButton.TabIndex = 2
        Me.SystemTrayButton.TabStop = True
        Me.SystemTrayButton.Text = "Minimise to system tray"
        Me.SystemTrayButton.UseVisualStyleBackColor = True
        '
        'NothingButton
        '
        Me.NothingButton.AutoSize = True
        Me.NothingButton.Location = New System.Drawing.Point(47, 36)
        Me.NothingButton.Name = "NothingButton"
        Me.NothingButton.Size = New System.Drawing.Size(68, 17)
        Me.NothingButton.TabIndex = 1
        Me.NothingButton.TabStop = True
        Me.NothingButton.Text = "Nothing"
        Me.NothingButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Set how you want Amino For Desktop to start."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TopicSearchBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TopicSearchBox
        '
        Me.TopicSearchBox.Controls.Add(Me.TopicSearchCheckBox)
        Me.TopicSearchBox.Controls.Add(Me.PictureBox4)
        Me.TopicSearchBox.Controls.Add(Me.TopicSearchLabel)
        Me.TopicSearchBox.Location = New System.Drawing.Point(6, 6)
        Me.TopicSearchBox.Name = "TopicSearchBox"
        Me.TopicSearchBox.Size = New System.Drawing.Size(397, 75)
        Me.TopicSearchBox.TabIndex = 1
        Me.TopicSearchBox.TabStop = False
        Me.TopicSearchBox.Text = "Topic Search"
        '
        'TopicSearchCheckBox
        '
        Me.TopicSearchCheckBox.AutoSize = True
        Me.TopicSearchCheckBox.Location = New System.Drawing.Point(47, 50)
        Me.TopicSearchCheckBox.Name = "TopicSearchCheckBox"
        Me.TopicSearchCheckBox.Size = New System.Drawing.Size(126, 17)
        Me.TopicSearchCheckBox.TabIndex = 5
        Me.TopicSearchCheckBox.Text = "Enable topic search"
        Me.TopicSearchCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Amino.My.Resources.Resources.Search
        Me.PictureBox4.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'TopicSearchLabel
        '
        Me.TopicSearchLabel.AutoSize = True
        Me.TopicSearchLabel.Location = New System.Drawing.Point(44, 21)
        Me.TopicSearchLabel.Name = "TopicSearchLabel"
        Me.TopicSearchLabel.Size = New System.Drawing.Size(280, 26)
        Me.TopicSearchLabel.TabIndex = 0
        Me.TopicSearchLabel.Text = "Topic Search allows you to search for topics of Amino" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "communities."
        '
        'SettingsPanelGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > General"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.FollowBox.ResumeLayout(False)
        Me.FollowBox.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TopicSearchBox.ResumeLayout(False)
        Me.TopicSearchBox.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SysTrayMinimiseBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FullScreenBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SettingsPanelButton As RadioButton
    Friend WithEvents SystemTrayButton As RadioButton
    Friend WithEvents NothingButton As RadioButton
    Friend WithEvents TopicSearchBox As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TopicSearchLabel As Label
    Friend WithEvents TopicSearchCheckBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents FollowBox As GroupBox
    Friend WithEvents FollowCheckBox As CheckBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents FollowLabel As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GPSetButton As Button
    Friend WithEvents GPText As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GPSetLabel As Label
End Class
