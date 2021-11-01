<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AminoWhatsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AminoWhatsNew))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"~Version 2.0.0.1~", "1. Fixed a bug where the 'About' dialogue would show in the taskbar.", "2. Fixed a bug where the 'Automatic Updates' dialogue would show in the taskbar.", "3. Changed updater code to point to new update servers.", "4. ", "", "~Version 2.0.0.0~", "1. Added 'Jump To...' which allows users to jump to Aminos via ID.", "2. Added 'Topic Search' which allows users to search for Amino communities or top" &
                "ics.", "3. Added 'About - More...' dialogue.", "4. Added the ability to show where you are in Amino on the title bar.", "5. Added ability to minimise to system tray.", "6. Added ability to use full screen mode. (Use F11 to enter full screen mode at a" &
                "ny time.)", "7. Added ability minimise to system tray or open the 'Settings Panel' at start-up" &
                ".", "8. Added 'Global Profile' button to easily jump to your global Amino profile.", "9. Added 'Sign Out' button to easily sign out of Amino.", "10. Added ability enable or disable 'Topic Search'.", "11. Added 'User Search' to search for users or user posts.", "12. Added ability to change the background colour of windows.", "", "~Version 1.0.1.2~", "1. Removed 'Surburban Suite' button.", "2. Updated Gecko to version 60.0.55.", "", "~Version 1.0.1.1~", "1. Fixed a bug where the 'Suburban Suite' button wouldn't work.", "2. Added keyboard shortcut, Alt+S to quickly access the 'Settings Panel'.", "3. Anime Amino is now blocked as a precaution to stop you getting wrongfully bann" &
                "ed.", "", "~Version 1.0.1.0~ (Service Pack 1)", "1. Updated Gecko to version 60.0.50.", "2. Updated 'Interest Avenue' button to 'Suburban Suite'.", "3. Fixed title on 'What's New?' dialogue.", "4. Fixed crashes from occuring throughout the application.", "5. Fixed dialogues being put in the taskbar.", "6. Updated some icons.", "", "~Version 1.0.0.0~", "1. Initial release.", "2. Browse Amino and chat with friends on your PC."})
        Me.ListBox1.Location = New System.Drawing.Point(0, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 312)
        Me.ListBox1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 53)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "See what's changed in the application..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Amino.My.Resources.Resources.GoodGradient
        Me.PictureBox1.Location = New System.Drawing.Point(397, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'AminoWhatsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 364)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AminoWhatsNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "What's New?"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
