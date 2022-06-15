<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelPersonalise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelPersonalise))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CustomColourBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CustomColourLabel = New System.Windows.Forms.Label()
        Me.CustomColourButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.CustomColourBox.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(422, 53)
        Me.Panel1.TabIndex = 7
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.Amino.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(3, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(48, 48)
        Me.BackButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(57, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(283, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Personalise your experience..."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(398, 218)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CustomColourBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(390, 192)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Colours"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CustomColourBox
        '
        Me.CustomColourBox.Controls.Add(Me.PictureBox2)
        Me.CustomColourBox.Controls.Add(Me.CheckBox1)
        Me.CustomColourBox.Controls.Add(Me.CustomColourLabel)
        Me.CustomColourBox.Controls.Add(Me.CustomColourButton)
        Me.CustomColourBox.Location = New System.Drawing.Point(3, 6)
        Me.CustomColourBox.Name = "CustomColourBox"
        Me.CustomColourBox.Size = New System.Drawing.Size(381, 63)
        Me.CustomColourBox.TabIndex = 8
        Me.CustomColourBox.TabStop = False
        Me.CustomColourBox.Text = "Background Colour"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Amino.My.Resources.Resources.Colours
        Me.PictureBox2.Location = New System.Drawing.Point(6, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(44, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(142, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Enable custom colours"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'CustomColourLabel
        '
        Me.CustomColourLabel.AutoSize = True
        Me.CustomColourLabel.Location = New System.Drawing.Point(41, 18)
        Me.CustomColourLabel.Name = "CustomColourLabel"
        Me.CustomColourLabel.Size = New System.Drawing.Size(282, 13)
        Me.CustomColourLabel.TabIndex = 7
        Me.CustomColourLabel.Text = "Set the colour of your Amino For Desktop experience."
        '
        'CustomColourButton
        '
        Me.CustomColourButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.CustomColourButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustomColourButton.ForeColor = System.Drawing.Color.White
        Me.CustomColourButton.Location = New System.Drawing.Point(268, 34)
        Me.CustomColourButton.Name = "CustomColourButton"
        Me.CustomColourButton.Size = New System.Drawing.Size(107, 23)
        Me.CustomColourButton.TabIndex = 6
        Me.CustomColourButton.Text = "Custom colour..."
        Me.CustomColourButton.UseVisualStyleBackColor = False
        '
        'SettingsPanelPersonalise
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 289)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelPersonalise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Personalisation"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.CustomColourBox.ResumeLayout(False)
        Me.CustomColourBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CustomColourBox As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CustomColourLabel As Label
    Friend WithEvents CustomColourButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
