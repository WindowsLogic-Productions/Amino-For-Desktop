<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanel))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.UpdatesTab = New System.Windows.Forms.TabPage()
        Me.UpdateBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EnableUpdates = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisableUpdates = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpdatesSettingsButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PersonaliseSettingsButton = New System.Windows.Forms.Button()
        Me.GeneralSettingsButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.UpdatesTab.SuspendLayout()
        Me.UpdateBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.UpdatesTab)
        Me.TabControl1.Location = New System.Drawing.Point(0, 193)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(396, 149)
        Me.TabControl1.TabIndex = 1
        '
        'UpdatesTab
        '
        Me.UpdatesTab.Controls.Add(Me.UpdateBox)
        Me.UpdatesTab.Location = New System.Drawing.Point(4, 22)
        Me.UpdatesTab.Name = "UpdatesTab"
        Me.UpdatesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdatesTab.Size = New System.Drawing.Size(388, 123)
        Me.UpdatesTab.TabIndex = 0
        Me.UpdatesTab.Text = "Updates"
        Me.UpdatesTab.UseVisualStyleBackColor = True
        '
        'UpdateBox
        '
        Me.UpdateBox.Controls.Add(Me.PictureBox1)
        Me.UpdateBox.Controls.Add(Me.PictureBox2)
        Me.UpdateBox.Controls.Add(Me.EnableUpdates)
        Me.UpdateBox.Controls.Add(Me.Label2)
        Me.UpdateBox.Controls.Add(Me.DisableUpdates)
        Me.UpdateBox.Controls.Add(Me.Label3)
        Me.UpdateBox.Location = New System.Drawing.Point(6, 6)
        Me.UpdateBox.Name = "UpdateBox"
        Me.UpdateBox.Size = New System.Drawing.Size(376, 98)
        Me.UpdateBox.TabIndex = 15
        Me.UpdateBox.TabStop = False
        Me.UpdateBox.Text = "Update Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Amino.My.Resources.Resources.Okay
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Amino.My.Resources.Resources.ErrorIco
        Me.PictureBox2.Location = New System.Drawing.Point(6, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'EnableUpdates
        '
        Me.EnableUpdates.AutoSize = True
        Me.EnableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableUpdates.Location = New System.Drawing.Point(44, 21)
        Me.EnableUpdates.Name = "EnableUpdates"
        Me.EnableUpdates.Size = New System.Drawing.Size(159, 17)
        Me.EnableUpdates.TabIndex = 1
        Me.EnableUpdates.Text = "Enable automatic updates"
        Me.EnableUpdates.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(41, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Check for updates when starting."
        '
        'DisableUpdates
        '
        Me.DisableUpdates.AutoSize = True
        Me.DisableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisableUpdates.Location = New System.Drawing.Point(44, 59)
        Me.DisableUpdates.Name = "DisableUpdates"
        Me.DisableUpdates.Size = New System.Drawing.Size(162, 17)
        Me.DisableUpdates.TabIndex = 2
        Me.DisableUpdates.Text = "Disable automatic updates"
        Me.DisableUpdates.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(41, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Do not check for updates."
        '
        'UpdatesSettingsButton
        '
        Me.UpdatesSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdatesSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesSettingsButton.ForeColor = System.Drawing.Color.Black
        Me.UpdatesSettingsButton.Image = Global.Amino.My.Resources.Resources.Okay
        Me.UpdatesSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdatesSettingsButton.Location = New System.Drawing.Point(326, 65)
        Me.UpdatesSettingsButton.Name = "UpdatesSettingsButton"
        Me.UpdatesSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.UpdatesSettingsButton.TabIndex = 40
        Me.UpdatesSettingsButton.Text = "Updates"
        Me.UpdatesSettingsButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.Transparent
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(382, 210)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(95, 23)
        Me.ResetButton.TabIndex = 36
        Me.ResetButton.Text = "Reset Settings"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 53)
        Me.Panel1.TabIndex = 37
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(395, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Select a setting to change to your liking..."
        '
        'PersonaliseSettingsButton
        '
        Me.PersonaliseSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.PersonaliseSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonaliseSettingsButton.ForeColor = System.Drawing.Color.Black
        Me.PersonaliseSettingsButton.Image = Global.Amino.My.Resources.Resources.Personalisation
        Me.PersonaliseSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PersonaliseSettingsButton.Location = New System.Drawing.Point(169, 65)
        Me.PersonaliseSettingsButton.Name = "PersonaliseSettingsButton"
        Me.PersonaliseSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.PersonaliseSettingsButton.TabIndex = 39
        Me.PersonaliseSettingsButton.Text = "Personalise"
        Me.PersonaliseSettingsButton.UseVisualStyleBackColor = False
        '
        'GeneralSettingsButton
        '
        Me.GeneralSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.GeneralSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.GeneralSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralSettingsButton.ForeColor = System.Drawing.Color.Black
        Me.GeneralSettingsButton.Image = Global.Amino.My.Resources.Resources.Amino_V2
        Me.GeneralSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GeneralSettingsButton.Location = New System.Drawing.Point(12, 65)
        Me.GeneralSettingsButton.Name = "GeneralSettingsButton"
        Me.GeneralSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.GeneralSettingsButton.TabIndex = 38
        Me.GeneralSettingsButton.Text = "General"
        Me.GeneralSettingsButton.UseVisualStyleBackColor = False
        '
        'AminoSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 245)
        Me.Controls.Add(Me.UpdatesSettingsButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.PersonaliseSettingsButton)
        Me.Controls.Add(Me.GeneralSettingsButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AminoSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.UpdatesTab.ResumeLayout(False)
        Me.UpdateBox.ResumeLayout(False)
        Me.UpdateBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UpdatesTab As TabPage
    Friend WithEvents UpdateBox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EnableUpdates As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DisableUpdates As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents UpdatesSettingsButton As Button
    Friend WithEvents PersonaliseSettingsButton As Button
    Friend WithEvents GeneralSettingsButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitleLabel As Label
End Class
