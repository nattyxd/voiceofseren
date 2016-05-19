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
        Me.chk_Amlodd = New System.Windows.Forms.CheckBox()
        Me.chk_Cadarn = New System.Windows.Forms.CheckBox()
        Me.chk_Crwys = New System.Windows.Forms.CheckBox()
        Me.chk_Hefin = New System.Windows.Forms.CheckBox()
        Me.chk_Iorwerth = New System.Windows.Forms.CheckBox()
        Me.chk_Ithell = New System.Windows.Forms.CheckBox()
        Me.chk_Trahaearn = New System.Windows.Forms.CheckBox()
        Me.chk_Meilyr = New System.Windows.Forms.CheckBox()
        Me.tracktime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'chk_Amlodd
        '
        Me.chk_Amlodd.AutoSize = True
        Me.chk_Amlodd.Location = New System.Drawing.Point(12, 12)
        Me.chk_Amlodd.Name = "chk_Amlodd"
        Me.chk_Amlodd.Size = New System.Drawing.Size(61, 17)
        Me.chk_Amlodd.TabIndex = 0
        Me.chk_Amlodd.Text = "Amlodd"
        Me.chk_Amlodd.UseVisualStyleBackColor = True
        '
        'chk_Cadarn
        '
        Me.chk_Cadarn.AutoSize = True
        Me.chk_Cadarn.Location = New System.Drawing.Point(12, 35)
        Me.chk_Cadarn.Name = "chk_Cadarn"
        Me.chk_Cadarn.Size = New System.Drawing.Size(60, 17)
        Me.chk_Cadarn.TabIndex = 1
        Me.chk_Cadarn.Text = "Cadarn"
        Me.chk_Cadarn.UseVisualStyleBackColor = True
        '
        'chk_Crwys
        '
        Me.chk_Crwys.AutoSize = True
        Me.chk_Crwys.Location = New System.Drawing.Point(12, 58)
        Me.chk_Crwys.Name = "chk_Crwys"
        Me.chk_Crwys.Size = New System.Drawing.Size(54, 17)
        Me.chk_Crwys.TabIndex = 2
        Me.chk_Crwys.Text = "Crwys"
        Me.chk_Crwys.UseVisualStyleBackColor = True
        '
        'chk_Hefin
        '
        Me.chk_Hefin.AutoSize = True
        Me.chk_Hefin.Location = New System.Drawing.Point(12, 81)
        Me.chk_Hefin.Name = "chk_Hefin"
        Me.chk_Hefin.Size = New System.Drawing.Size(51, 17)
        Me.chk_Hefin.TabIndex = 3
        Me.chk_Hefin.Text = "Hefin"
        Me.chk_Hefin.UseVisualStyleBackColor = True
        '
        'chk_Iorwerth
        '
        Me.chk_Iorwerth.AutoSize = True
        Me.chk_Iorwerth.Location = New System.Drawing.Point(12, 104)
        Me.chk_Iorwerth.Name = "chk_Iorwerth"
        Me.chk_Iorwerth.Size = New System.Drawing.Size(64, 17)
        Me.chk_Iorwerth.TabIndex = 4
        Me.chk_Iorwerth.Text = "Iorwerth"
        Me.chk_Iorwerth.UseVisualStyleBackColor = True
        '
        'chk_Ithell
        '
        Me.chk_Ithell.AutoSize = True
        Me.chk_Ithell.Location = New System.Drawing.Point(12, 127)
        Me.chk_Ithell.Name = "chk_Ithell"
        Me.chk_Ithell.Size = New System.Drawing.Size(48, 17)
        Me.chk_Ithell.TabIndex = 5
        Me.chk_Ithell.Text = "Ithell"
        Me.chk_Ithell.UseVisualStyleBackColor = True
        '
        'chk_Trahaearn
        '
        Me.chk_Trahaearn.AutoSize = True
        Me.chk_Trahaearn.Location = New System.Drawing.Point(12, 173)
        Me.chk_Trahaearn.Name = "chk_Trahaearn"
        Me.chk_Trahaearn.Size = New System.Drawing.Size(75, 17)
        Me.chk_Trahaearn.TabIndex = 6
        Me.chk_Trahaearn.Text = "Trahaearn"
        Me.chk_Trahaearn.UseVisualStyleBackColor = True
        '
        'chk_Meilyr
        '
        Me.chk_Meilyr.AutoSize = True
        Me.chk_Meilyr.Location = New System.Drawing.Point(12, 150)
        Me.chk_Meilyr.Name = "chk_Meilyr"
        Me.chk_Meilyr.Size = New System.Drawing.Size(53, 17)
        Me.chk_Meilyr.TabIndex = 7
        Me.chk_Meilyr.Text = "Meilyr"
        Me.chk_Meilyr.UseVisualStyleBackColor = True
        '
        'tracktime
        '
        Me.tracktime.Enabled = True
        Me.tracktime.Interval = 1000
        '
        'tracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(102, 302)
        Me.Controls.Add(Me.chk_Meilyr)
        Me.Controls.Add(Me.chk_Trahaearn)
        Me.Controls.Add(Me.chk_Ithell)
        Me.Controls.Add(Me.chk_Iorwerth)
        Me.Controls.Add(Me.chk_Hefin)
        Me.Controls.Add(Me.chk_Crwys)
        Me.Controls.Add(Me.chk_Cadarn)
        Me.Controls.Add(Me.chk_Amlodd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "tracker"
        Me.Opacity = 0.6R
        Me.ShowIcon = False
        Me.Text = "Tracker"
        Me.TopMost = True
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
End Class
