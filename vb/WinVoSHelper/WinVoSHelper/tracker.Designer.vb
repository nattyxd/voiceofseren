<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tracker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tracker))
        Me.chk_Amlodd = New System.Windows.Forms.CheckBox()
        Me.chk_Cadarn = New System.Windows.Forms.CheckBox()
        Me.chk_Crwys = New System.Windows.Forms.CheckBox()
        Me.chk_Hefin = New System.Windows.Forms.CheckBox()
        Me.chk_Iorwerth = New System.Windows.Forms.CheckBox()
        Me.chk_Ithell = New System.Windows.Forms.CheckBox()
        Me.chk_Trahaearn = New System.Windows.Forms.CheckBox()
        Me.chk_Meilyr = New System.Windows.Forms.CheckBox()
        Me.tracktime = New System.Windows.Forms.Timer(Me.components)
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.epochBrowser = New System.Windows.Forms.WebBrowser()
        Me.notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.alertOnUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlertMeWhenClansForgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuneScapeBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetTransparencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowIconOnTaskbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_Amlodd
        '
        Me.chk_Amlodd.AutoSize = True
        Me.chk_Amlodd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Amlodd.Location = New System.Drawing.Point(12, 12)
        Me.chk_Amlodd.Name = "chk_Amlodd"
        Me.chk_Amlodd.Size = New System.Drawing.Size(73, 21)
        Me.chk_Amlodd.TabIndex = 0
        Me.chk_Amlodd.Tag = "1"
        Me.chk_Amlodd.Text = "Amlodd"
        Me.chk_Amlodd.UseVisualStyleBackColor = True
        '
        'chk_Cadarn
        '
        Me.chk_Cadarn.AutoSize = True
        Me.chk_Cadarn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Cadarn.Location = New System.Drawing.Point(12, 39)
        Me.chk_Cadarn.Name = "chk_Cadarn"
        Me.chk_Cadarn.Size = New System.Drawing.Size(69, 21)
        Me.chk_Cadarn.TabIndex = 1
        Me.chk_Cadarn.Tag = "2"
        Me.chk_Cadarn.Text = "Cadarn"
        Me.chk_Cadarn.UseVisualStyleBackColor = True
        '
        'chk_Crwys
        '
        Me.chk_Crwys.AutoSize = True
        Me.chk_Crwys.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Crwys.Location = New System.Drawing.Point(12, 66)
        Me.chk_Crwys.Name = "chk_Crwys"
        Me.chk_Crwys.Size = New System.Drawing.Size(61, 21)
        Me.chk_Crwys.TabIndex = 2
        Me.chk_Crwys.Tag = "3"
        Me.chk_Crwys.Text = "Crwys"
        Me.chk_Crwys.UseVisualStyleBackColor = True
        '
        'chk_Hefin
        '
        Me.chk_Hefin.AutoSize = True
        Me.chk_Hefin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Hefin.Location = New System.Drawing.Point(12, 93)
        Me.chk_Hefin.Name = "chk_Hefin"
        Me.chk_Hefin.Size = New System.Drawing.Size(57, 21)
        Me.chk_Hefin.TabIndex = 3
        Me.chk_Hefin.Tag = "4"
        Me.chk_Hefin.Text = "Hefin"
        Me.chk_Hefin.UseVisualStyleBackColor = True
        '
        'chk_Iorwerth
        '
        Me.chk_Iorwerth.AutoSize = True
        Me.chk_Iorwerth.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Iorwerth.Location = New System.Drawing.Point(12, 120)
        Me.chk_Iorwerth.Name = "chk_Iorwerth"
        Me.chk_Iorwerth.Size = New System.Drawing.Size(75, 21)
        Me.chk_Iorwerth.TabIndex = 4
        Me.chk_Iorwerth.Tag = "5"
        Me.chk_Iorwerth.Text = "Iorwerth"
        Me.chk_Iorwerth.UseVisualStyleBackColor = True
        '
        'chk_Ithell
        '
        Me.chk_Ithell.AutoSize = True
        Me.chk_Ithell.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Ithell.Location = New System.Drawing.Point(12, 147)
        Me.chk_Ithell.Name = "chk_Ithell"
        Me.chk_Ithell.Size = New System.Drawing.Size(54, 21)
        Me.chk_Ithell.TabIndex = 5
        Me.chk_Ithell.Tag = "6"
        Me.chk_Ithell.Text = "Ithell"
        Me.chk_Ithell.UseVisualStyleBackColor = True
        '
        'chk_Trahaearn
        '
        Me.chk_Trahaearn.AutoSize = True
        Me.chk_Trahaearn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Trahaearn.Location = New System.Drawing.Point(12, 201)
        Me.chk_Trahaearn.Name = "chk_Trahaearn"
        Me.chk_Trahaearn.Size = New System.Drawing.Size(85, 21)
        Me.chk_Trahaearn.TabIndex = 6
        Me.chk_Trahaearn.Tag = "8"
        Me.chk_Trahaearn.Text = "Trahaearn"
        Me.chk_Trahaearn.UseVisualStyleBackColor = True
        '
        'chk_Meilyr
        '
        Me.chk_Meilyr.AutoSize = True
        Me.chk_Meilyr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Meilyr.Location = New System.Drawing.Point(12, 174)
        Me.chk_Meilyr.Name = "chk_Meilyr"
        Me.chk_Meilyr.Size = New System.Drawing.Size(63, 21)
        Me.chk_Meilyr.TabIndex = 7
        Me.chk_Meilyr.Tag = "7"
        Me.chk_Meilyr.Text = "Meilyr"
        Me.chk_Meilyr.UseVisualStyleBackColor = True
        '
        'tracktime
        '
        Me.tracktime.Enabled = True
        Me.tracktime.Interval = 1000
        '
        'browser
        '
        Me.browser.Location = New System.Drawing.Point(69, 225)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(35, 20)
        Me.browser.TabIndex = 8
        Me.browser.Url = New System.Uri("http://www.polishedinter.net/jagex/twitter.php", System.UriKind.Absolute)
        Me.browser.Visible = False
        '
        'epochBrowser
        '
        Me.epochBrowser.Location = New System.Drawing.Point(0, 230)
        Me.epochBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.epochBrowser.Name = "epochBrowser"
        Me.epochBrowser.Size = New System.Drawing.Size(45, 20)
        Me.epochBrowser.TabIndex = 9
        Me.epochBrowser.Url = New System.Uri("http://www.polishedinter.net/jagex/epoch.php", System.UriKind.Absolute)
        Me.epochBrowser.Visible = False
        '
        'notify
        '
        Me.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notify.ContextMenuStrip = Me.notifyContext
        Me.notify.Icon = CType(resources.GetObject("notify.Icon"), System.Drawing.Icon)
        Me.notify.Text = "Voice of Seren Thieving Helper"
        Me.notify.Visible = True
        '
        'notifyContext
        '
        Me.notifyContext.AllowMerge = False
        Me.notifyContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.alertOnUpdate, Me.AlertMeWhenClansForgetToolStripMenuItem, Me.BackgroundColourToolStripMenuItem, Me.TextColourToolStripMenuItem, Me.SetTransparencyToolStripMenuItem, Me.LockLocationToolStripMenuItem, Me.ShowIconOnTaskbarToolStripMenuItem, Me.HideAppToolStripMenuItem, Me.ExitAppToolStripMenuItem})
        Me.notifyContext.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.notifyContext.Name = "notifyContext"
        Me.notifyContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.notifyContext.Size = New System.Drawing.Size(321, 224)
        '
        'alertOnUpdate
        '
        Me.alertOnUpdate.Checked = True
        Me.alertOnUpdate.CheckOnClick = True
        Me.alertOnUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.alertOnUpdate.Name = "alertOnUpdate"
        Me.alertOnUpdate.Size = New System.Drawing.Size(320, 22)
        Me.alertOnUpdate.Text = "Alert Me When VoS Changes"
        '
        'AlertMeWhenClansForgetToolStripMenuItem
        '
        Me.AlertMeWhenClansForgetToolStripMenuItem.Checked = True
        Me.AlertMeWhenClansForgetToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AlertMeWhenClansForgetToolStripMenuItem.Name = "AlertMeWhenClansForgetToolStripMenuItem"
        Me.AlertMeWhenClansForgetToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.AlertMeWhenClansForgetToolStripMenuItem.Text = "Alert Me When Clans Forget My Pickpocketing"
        '
        'BackgroundColourToolStripMenuItem
        '
        Me.BackgroundColourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransparentToolStripMenuItem, Me.DefaultToolStripMenuItem, Me.RuneScapeBlueToolStripMenuItem, Me.BlackToolStripMenuItem, Me.WhiteToolStripMenuItem})
        Me.BackgroundColourToolStripMenuItem.Name = "BackgroundColourToolStripMenuItem"
        Me.BackgroundColourToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.BackgroundColourToolStripMenuItem.Text = "Background Colour"
        '
        'TransparentToolStripMenuItem
        '
        Me.TransparentToolStripMenuItem.Name = "TransparentToolStripMenuItem"
        Me.TransparentToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TransparentToolStripMenuItem.Text = "Transparent"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'RuneScapeBlueToolStripMenuItem
        '
        Me.RuneScapeBlueToolStripMenuItem.Name = "RuneScapeBlueToolStripMenuItem"
        Me.RuneScapeBlueToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.RuneScapeBlueToolStripMenuItem.Text = "RuneScape Blue"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BlackToolStripMenuItem.Text = "Black"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'TextColourToolStripMenuItem
        '
        Me.TextColourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackToolStripMenuItem1, Me.WhiteToolStripMenuItem1})
        Me.TextColourToolStripMenuItem.Name = "TextColourToolStripMenuItem"
        Me.TextColourToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.TextColourToolStripMenuItem.Text = "Text Colour"
        '
        'BlackToolStripMenuItem1
        '
        Me.BlackToolStripMenuItem1.Name = "BlackToolStripMenuItem1"
        Me.BlackToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.BlackToolStripMenuItem1.Text = "Black"
        '
        'WhiteToolStripMenuItem1
        '
        Me.WhiteToolStripMenuItem1.Name = "WhiteToolStripMenuItem1"
        Me.WhiteToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.WhiteToolStripMenuItem1.Text = "White"
        '
        'SetTransparencyToolStripMenuItem
        '
        Me.SetTransparencyToolStripMenuItem.Name = "SetTransparencyToolStripMenuItem"
        Me.SetTransparencyToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.SetTransparencyToolStripMenuItem.Text = "Set Transparency"
        '
        'ShowIconOnTaskbarToolStripMenuItem
        '
        Me.ShowIconOnTaskbarToolStripMenuItem.Name = "ShowIconOnTaskbarToolStripMenuItem"
        Me.ShowIconOnTaskbarToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.ShowIconOnTaskbarToolStripMenuItem.Text = "Show Icon On Taskbar"
        '
        'HideAppToolStripMenuItem
        '
        Me.HideAppToolStripMenuItem.Name = "HideAppToolStripMenuItem"
        Me.HideAppToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.HideAppToolStripMenuItem.Text = "Hide App"
        '
        'ExitAppToolStripMenuItem
        '
        Me.ExitAppToolStripMenuItem.Name = "ExitAppToolStripMenuItem"
        Me.ExitAppToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.ExitAppToolStripMenuItem.Text = "Exit App"
        '
        'LockLocationToolStripMenuItem
        '
        Me.LockLocationToolStripMenuItem.Name = "LockLocationToolStripMenuItem"
        Me.LockLocationToolStripMenuItem.Size = New System.Drawing.Size(320, 22)
        Me.LockLocationToolStripMenuItem.Text = "Lock Location (Hide Title Bar)"
        '
        'tracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(111, 230)
        Me.Controls.Add(Me.epochBrowser)
        Me.Controls.Add(Me.browser)
        Me.Controls.Add(Me.chk_Meilyr)
        Me.Controls.Add(Me.chk_Trahaearn)
        Me.Controls.Add(Me.chk_Ithell)
        Me.Controls.Add(Me.chk_Iorwerth)
        Me.Controls.Add(Me.chk_Hefin)
        Me.Controls.Add(Me.chk_Crwys)
        Me.Controls.Add(Me.chk_Cadarn)
        Me.Controls.Add(Me.chk_Amlodd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tracker"
        Me.Opacity = 0.7R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VoS Tracker"
        Me.TopMost = True
        Me.notifyContext.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_Amlodd As CheckBox
    Friend WithEvents chk_Cadarn As CheckBox
    Friend WithEvents chk_Crwys As CheckBox
    Friend WithEvents chk_Hefin As CheckBox
    Friend WithEvents chk_Iorwerth As CheckBox
    Friend WithEvents chk_Ithell As CheckBox
    Friend WithEvents chk_Meilyr As CheckBox
    Friend WithEvents tracktime As Timer
    Friend WithEvents chk_Trahaearn As CheckBox
    Friend WithEvents browser As WebBrowser
    Friend WithEvents epochBrowser As WebBrowser
    Friend WithEvents notify As NotifyIcon
    Friend WithEvents notifyContext As ContextMenuStrip
    Friend WithEvents alertOnUpdate As ToolStripMenuItem
    Friend WithEvents SetTransparencyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlertMeWhenClansForgetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransparentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RuneScapeBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextColourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShowIconOnTaskbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LockLocationToolStripMenuItem As ToolStripMenuItem
End Class
