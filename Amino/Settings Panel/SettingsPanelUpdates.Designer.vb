<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPanelUpdates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelUpdates))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.UpdatesTab = New System.Windows.Forms.TabPage()
        Me.ManualUpdateButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DisableUpdates = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnableUpdates = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.UpdatesTab.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 14
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.Amino.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(3, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(48, 48)
        Me.BackButton.TabIndex = 15
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(248, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change update settings..."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.UpdatesTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 15
        '
        'UpdatesTab
        '
        Me.UpdatesTab.Controls.Add(Me.ManualUpdateButton)
        Me.UpdatesTab.Controls.Add(Me.PictureBox3)
        Me.UpdatesTab.Controls.Add(Me.GroupBox1)
        Me.UpdatesTab.Location = New System.Drawing.Point(4, 22)
        Me.UpdatesTab.Name = "UpdatesTab"
        Me.UpdatesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdatesTab.Size = New System.Drawing.Size(409, 179)
        Me.UpdatesTab.TabIndex = 0
        Me.UpdatesTab.Text = "Updates"
        Me.UpdatesTab.UseVisualStyleBackColor = True
        '
        'ManualUpdateButton
        '
        Me.ManualUpdateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManualUpdateButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.ManualUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ManualUpdateButton.ForeColor = System.Drawing.Color.White
        Me.ManualUpdateButton.Location = New System.Drawing.Point(262, 150)
        Me.ManualUpdateButton.Name = "ManualUpdateButton"
        Me.ManualUpdateButton.Size = New System.Drawing.Size(141, 23)
        Me.ManualUpdateButton.TabIndex = 47
        Me.ManualUpdateButton.Text = "Force Update Check"
        Me.ManualUpdateButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Amino.My.Resources.Resources.GoodGradient
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(409, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 46
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.DisableUpdates)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.EnableUpdates)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 128)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "It is recommended that you keep updates on at all times."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Amino.My.Resources.Resources.Updates_On
        Me.PictureBox1.Location = New System.Drawing.Point(9, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'DisableUpdates
        '
        Me.DisableUpdates.AutoSize = True
        Me.DisableUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DisableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisableUpdates.Location = New System.Drawing.Point(47, 78)
        Me.DisableUpdates.Name = "DisableUpdates"
        Me.DisableUpdates.Size = New System.Drawing.Size(217, 18)
        Me.DisableUpdates.TabIndex = 14
        Me.DisableUpdates.Text = "Disable updates (not recommended)"
        Me.DisableUpdates.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Amino.My.Resources.Resources.Updates_Off
        Me.PictureBox2.Location = New System.Drawing.Point(9, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(44, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Check for updates when starting."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(44, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Do not check for updates when starting."
        '
        'EnableUpdates
        '
        Me.EnableUpdates.AutoSize = True
        Me.EnableUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EnableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableUpdates.Location = New System.Drawing.Point(47, 40)
        Me.EnableUpdates.Name = "EnableUpdates"
        Me.EnableUpdates.Size = New System.Drawing.Size(193, 18)
        Me.EnableUpdates.TabIndex = 13
        Me.EnableUpdates.Text = "Enable updates (recommended)"
        Me.EnableUpdates.UseVisualStyleBackColor = True
        '
        'SettingsPanelUpdates
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
        Me.Name = "SettingsPanelUpdates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Updates"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.UpdatesTab.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UpdatesTab As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EnableUpdates As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DisableUpdates As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ManualUpdateButton As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
