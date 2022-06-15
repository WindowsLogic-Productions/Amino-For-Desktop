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
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.UpdatesSettingsButton = New System.Windows.Forms.Button()
        Me.PersonaliseSettingsButton = New System.Windows.Forms.Button()
        Me.GeneralSettingsButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResetButton
        '
        Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetButton.BackColor = System.Drawing.Color.Transparent
        Me.ResetButton.Enabled = False
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(381, 210)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(95, 23)
        Me.ResetButton.TabIndex = 36
        Me.ResetButton.Text = "Reset Settings"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'UpdatesSettingsButton
        '
        Me.UpdatesSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdatesSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesSettingsButton.ForeColor = System.Drawing.Color.Black
        Me.UpdatesSettingsButton.Image = Global.Amino.My.Resources.Resources.Update
        Me.UpdatesSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdatesSettingsButton.Location = New System.Drawing.Point(325, 66)
        Me.UpdatesSettingsButton.Name = "UpdatesSettingsButton"
        Me.UpdatesSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.UpdatesSettingsButton.TabIndex = 40
        Me.UpdatesSettingsButton.Text = "Updates"
        Me.UpdatesSettingsButton.UseVisualStyleBackColor = False
        '
        'PersonaliseSettingsButton
        '
        Me.PersonaliseSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.PersonaliseSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonaliseSettingsButton.ForeColor = System.Drawing.Color.Black
        Me.PersonaliseSettingsButton.Image = Global.Amino.My.Resources.Resources.Personalisation
        Me.PersonaliseSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PersonaliseSettingsButton.Location = New System.Drawing.Point(168, 66)
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
        Me.GeneralSettingsButton.Location = New System.Drawing.Point(11, 66)
        Me.GeneralSettingsButton.Name = "GeneralSettingsButton"
        Me.GeneralSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.GeneralSettingsButton.TabIndex = 38
        Me.GeneralSettingsButton.Text = "General"
        Me.GeneralSettingsButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 53)
        Me.Panel1.TabIndex = 41
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
        'SettingsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 245)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UpdatesSettingsButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.PersonaliseSettingsButton)
        Me.Controls.Add(Me.GeneralSettingsButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amino For Desktop - Settings Panel"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UpdatesSettingsButton As Button
    Friend WithEvents PersonaliseSettingsButton As Button
    Friend WithEvents GeneralSettingsButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitleLabel As Label
End Class
